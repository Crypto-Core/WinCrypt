Option Strict On
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Diagnostics
Imports System.Runtime.CompilerServices

Module CryptoStuff
    Dim selectcombo As String
    Private Sub MakeKeyAndIV(ByVal password As String, ByVal salt() As Byte, ByVal key_size_bits As Integer, ByVal block_size_bits As Integer, ByRef key() As Byte, ByRef iv() As Byte)
        Dim derive_bytes As New Rfc2898DeriveBytes(password, salt, 1000)
        key = derive_bytes.GetBytes(CInt(key_size_bits / 8))
        iv = derive_bytes.GetBytes(CInt(block_size_bits / 8))
    End Sub

#Region "Encrypt Files and Streams"
    Public Sub EncryptFile(ByVal password As String, ByVal in_file As String, ByVal out_file As String)
        CryptFile(password, in_file, out_file, True)
    End Sub
    Public Sub DecryptFile(ByVal password As String, ByVal in_file As String, ByVal out_file As String)
        CryptFile(password, in_file, out_file, False)
    End Sub
    Public Sub CryptFile(ByVal password As String, ByVal in_file As String, ByVal out_file As String, ByVal encrypt As Boolean)
        Try
            Using in_stream As New FileStream(in_file, FileMode.Open, FileAccess.Read)
                Using out_stream As New FileStream(out_file, FileMode.Create, FileAccess.Write)
                    CryptStream(password, in_stream, out_stream, encrypt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ErrorToString, MsgBoxStyle.Critical)
            startwindow.decrypt_list_status.Items.Add(ErrorToString)
        End Try
    End Sub
    Public Sub CryptStream(ByVal password As String, ByVal in_stream As Stream, ByVal out_stream As Stream, ByVal encrypt As Boolean)
        Dim aes_provider As New AesCryptoServiceProvider()
        Dim key_size_bits As Integer = 0
        For i As Integer = 1024 To 1 Step -1
            If (aes_provider.ValidKeySize(i)) Then
                key_size_bits = i
                Exit For
            End If
        Next i
        Debug.Assert(key_size_bits > 0)
        Console.WriteLine("Key size: " & key_size_bits)
        Dim block_size_bits As Integer = aes_provider.BlockSize
        Dim key() As Byte = Nothing
        Dim iv() As Byte = Nothing
        Dim salt() As Byte = {&H0, &H0, &H1, &H2, &H3, &H4, &H5, &H6, &HF1, &HF0, &HEE, &H21, &H22, &H45}
        MakeKeyAndIV(password, salt, key_size_bits, block_size_bits, key, iv)
        Dim crypto_transform As ICryptoTransform
        If (encrypt) Then
            crypto_transform = aes_provider.CreateEncryptor(key, iv)
        Else
            crypto_transform = aes_provider.CreateDecryptor(key, iv)
        End If
        Try
            Using crypto_stream As New CryptoStream(out_stream, crypto_transform, CryptoStreamMode.Write)
                Const block_size As Integer = 1024
                Dim buffer(block_size) As Byte
                Dim bytes_read As Integer
                Do
                    bytes_read = in_stream.Read(buffer, 0, block_size)
                    If (bytes_read = 0) Then Exit Do
                    crypto_stream.Write(buffer, 0, bytes_read)
                Loop
            End Using
        Catch
            startwindow.errormount = "error"
            startwindow.formclose = False
            MsgBox("Die Datei ist beschädigt oder der Schlüssel ist falsch!", MsgBoxStyle.Critical)
            Application.Restart()
        End Try
        crypto_transform.Dispose()
    End Sub

#End Region

#Region "Encrypt Strings and Byte()"
    Public Function CryptBytes(ByVal password As String, ByVal in_bytes() As Byte, ByVal encrypt As Boolean) As Byte()
        Dim aes_provider As New AesCryptoServiceProvider()
        Dim key_size_bits As Integer = 0
        For i As Integer = 1024 To 1 Step -1
            If (aes_provider.ValidKeySize(i)) Then
                key_size_bits = i
                Exit For
            End If
        Next i
        Debug.Assert(key_size_bits > 0)
        Console.WriteLine("Key size: " & key_size_bits)
        Dim block_size_bits As Integer = aes_provider.BlockSize
        Dim key() As Byte = Nothing
        Dim iv() As Byte = Nothing
        Dim salt() As Byte = {&H0, &H0, &H1, &H2, &H3, &H4, &H5, &H6, &HF1, &HF0, &HEE, &H21, &H22, &H45}
        MakeKeyAndIV(password, salt, key_size_bits, block_size_bits, key, iv)
        Dim crypto_transform As ICryptoTransform
        If (encrypt) Then
            crypto_transform = aes_provider.CreateEncryptor(key, iv)
        Else
            crypto_transform = aes_provider.CreateDecryptor(key, iv)
        End If
        Using out_stream As New MemoryStream()
            Using crypto_stream As New CryptoStream(out_stream, _
                    crypto_transform, CryptoStreamMode.Write)
                crypto_stream.Write(in_bytes, 0, in_bytes.Length)
                Try
                    crypto_stream.FlushFinalBlock()
                Catch ex As CryptographicException
                    ' Ignore this exception. The password is bad.
                Catch
                    ' Re-throw this exception.
                    Throw
                End Try
                ' return the result.
                Return out_stream.ToArray()
            End Using
        End Using
    End Function

    <Extension()> _
    Public Function Encrypt(ByVal the_string As String, ByVal password As String) As Byte()
        Dim ascii_encoder As New System.Text.ASCIIEncoding()
        Dim plain_bytes() As Byte = ascii_encoder.GetBytes(the_string)
        Return CryptBytes(password, plain_bytes, True)
    End Function
    <Extension()> _
    Public Function Decrypt(ByVal the_bytes() As Byte, ByVal password As String) As String
        Dim decrypted_bytes() As Byte = CryptBytes(password, the_bytes, False)
        Dim ascii_encoder As New System.Text.ASCIIEncoding()
        Return ascii_encoder.GetString(decrypted_bytes)
    End Function
    Public Function CryptString(ByVal password As String, ByVal in_string As String, ByVal encrypt As Boolean) As String
        Dim in_bytes() As Byte = Encoding.ASCII.GetBytes(in_string)
        Using in_stream As New MemoryStream(in_bytes)
            Using out_stream As New MemoryStream()
                CryptStream(password, in_stream, out_stream, True)
                out_stream.Seek(0, SeekOrigin.Begin)
                Using stream_reader As New StreamReader(out_stream)
                    Return stream_reader.ReadToEnd()
                End Using
            End Using
        End Using
    End Function

    <Extension()> _
    Public Function ToHex(ByVal the_bytes() As Byte) As String
        Return ToHex(the_bytes, False)
    End Function
    <Extension()> _
    Public Function ToHex(ByVal the_bytes() As Byte, ByVal add_spaces As Boolean) As String
        Dim result As String = ""
        Dim separator As String = ""
        If (add_spaces) Then separator = " "
        For i As Integer = 0 To the_bytes.Length - 1
            result &= the_bytes(i).ToString("x2") & separator
        Next i
        Return result
    End Function
    <Extension()> _
    Public Function ToBytes(ByVal the_string As String) As Byte()
        Dim the_bytes As New List(Of Byte)()
        the_string = the_string.Replace(" ", "")
        For i As Integer = 0 To the_string.Length - 1 Step 2
            the_bytes.Add( _
                Byte.Parse(the_string.Substring(i, 2), _
                    System.Globalization.NumberStyles.HexNumber))
        Next i
        Return the_bytes.ToArray()
    End Function
#End Region

End Module
