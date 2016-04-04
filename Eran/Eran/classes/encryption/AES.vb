Imports System.Runtime.CompilerServices
Imports System.Globalization
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO

Module CryptoStuff
    Public Property Selectcombo As String
    Private Sub MakeKeyAndIv(ByVal password As String, ByVal salt() As Byte, ByVal keySizeBits As Integer, ByVal blockSizeBits As Integer, ByRef key() As Byte, ByRef iv() As Byte)
        Dim deriveBytes As New Rfc2898DeriveBytes(password, salt, 1000)
        key = deriveBytes.GetBytes(CInt(keySizeBits / 8))
        iv = deriveBytes.GetBytes(CInt(blockSizeBits / 8))
    End Sub
#Region "Encrypt Files and Streams"
    Public Sub EncryptFile(ByVal password As String, ByVal inFile As String, ByVal outFile As String)
        CryptFile(password, inFile, outFile, True)
    End Sub
    Public Sub DecryptFile(ByVal password As String, ByVal inFile As String, ByVal outFile As String)
        CryptFile(password, inFile, outFile, False)
    End Sub
    Public Sub CryptFile(ByVal password As String, ByVal inFile As String, ByVal outFile As String, ByVal encrypt As Boolean)
        Try
            Using inStream As New FileStream(inFile, FileMode.Open, FileAccess.Read)
                Using outStream As New FileStream(outFile, FileMode.Create, FileAccess.Write)
                    CryptStream(password, inStream, outStream, encrypt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ErrorToString, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub CryptStream(ByVal password As String, ByVal inStream As Stream, ByVal outStream As Stream, ByVal encrypt As Boolean)
        Dim aesProvider As New AesCryptoServiceProvider()
        Dim keySizeBits = 0
        For i = 1024 To 1 Step -1
            If (aesProvider.ValidKeySize(i)) Then
                keySizeBits = i
                Exit For
            End If
        Next i
        Debug.Assert(keySizeBits > 0)
        Dim blockSizeBits As Integer = aesProvider.BlockSize
        Dim key() As Byte = Nothing
        Dim iv() As Byte = Nothing
        Dim salt() As Byte = {&H0, &H0, &H1, &H2, &H3, &H4, &H5, &H6, &HF1, &HF0, &HEE, &H21, &H22, &H45}
        MakeKeyAndIv(password, salt, keySizeBits, blockSizeBits, key, iv)
        Dim cryptoTransform As ICryptoTransform
        If (encrypt) Then
            cryptoTransform = aesProvider.CreateEncryptor(key, iv)
        Else
            cryptoTransform = aesProvider.CreateDecryptor(key, iv)
        End If
        Try
            Using cryptoStream As New CryptoStream(outStream, cryptoTransform, CryptoStreamMode.Write)
                Const blockSize = 1024
                Dim buffer(blockSize) As Byte
                Dim bytesRead As Integer
                Do
                    bytesRead = inStream.Read(buffer, 0, blockSize)
                    If (bytesRead = 0) Then Exit Do
                    cryptoStream.Write(buffer, 0, bytesRead)
                Loop
            End Using
        Catch

            MsgBox("Die Datei ist beschädigt oder der Schlüssel ist falsch!", MsgBoxStyle.Critical)
            Application.Restart()
        End Try
        cryptoTransform.Dispose()
    End Sub
#End Region

#Region "Encrypt Strings and Byte()"
    Public Function CryptBytes(ByVal password As String, ByVal inBytes() As Byte, ByVal encrypt As Boolean) As Byte()
        Dim aesProvider As New AesCryptoServiceProvider()
        Dim keySizeBits = 0
        For i = 1024 To 1 Step -1
            If (aesProvider.ValidKeySize(i)) Then
                keySizeBits = i
                Exit For
            End If
        Next i
        Debug.Assert(keySizeBits > 0)
        Dim blockSizeBits As Integer = aesProvider.BlockSize
        Dim key() As Byte = Nothing
        Dim iv() As Byte = Nothing
        Dim salt() As Byte = {&H0, &H0, &H1, &H2, &H3, &H4, &H5, &H6, &HF1, &HF0, &HEE, &H21, &H22, &H45}
        MakeKeyAndIv(password, salt, keySizeBits, blockSizeBits, key, iv)
        Dim cryptoTransform As ICryptoTransform
        If (encrypt) Then
            cryptoTransform = aesProvider.CreateEncryptor(key, iv)
        Else
            cryptoTransform = aesProvider.CreateDecryptor(key, iv)
        End If
        Using outStream As New MemoryStream()
            Using cryptoStream As New CryptoStream(outStream, cryptoTransform, CryptoStreamMode.Write)
                cryptoStream.Write(inBytes, 0, inBytes.Length)
                Try
                    cryptoStream.FlushFinalBlock()
                Catch ex As CryptographicException
                    ' Ignore this exception. The password is bad.
                Catch
                    ' Re-throw this exception.
                    Throw
                End Try
                ' return the result.
                Return outStream.ToArray()
            End Using
        End Using
    End Function
    <Extension()>
    Public Function Encrypt(ByVal theString As String, ByVal password As String) As Byte()
        Dim asciiEncoder As New ASCIIEncoding()
        Dim plainBytes() As Byte = asciiEncoder.GetBytes(theString)
        Return CryptBytes(password, plainBytes, True)
    End Function
    <Extension()>
    Public Function Decrypt(ByVal theBytes() As Byte, ByVal password As String) As String
        Dim decryptedBytes() As Byte = CryptBytes(password, theBytes, False)
        Dim asciiEncoder As New ASCIIEncoding()
        Return asciiEncoder.GetString(decryptedBytes)
    End Function
    Public Function CryptString(ByVal password As String, ByVal inString As String, ByVal encrypt As Boolean) As String
        Dim inBytes() As Byte = Encoding.ASCII.GetBytes(inString)
        Using inStream As New MemoryStream(inBytes)
            Using outStream As New MemoryStream()
                CryptStream(password, inStream, outStream, True)
                outStream.Seek(0, SeekOrigin.Begin)
                Using streamReader As New StreamReader(outStream)
                    Return streamReader.ReadToEnd()
                End Using
            End Using
        End Using
    End Function
    <Extension()>
    Public Function ToHex(ByVal theBytes() As Byte) As String
        Return theBytes.ToHex(False)
    End Function
    <Extension()>
    Public Function ToHex(ByVal theBytes() As Byte, ByVal addSpaces As Boolean) As String
        Dim result = Nothing
        Dim separator = Nothing
        If (addSpaces) Then separator = " "
        For i = 0 To theBytes.Length - 1
            result &= theBytes(i).ToString("x2") & separator
        Next i
        Return result
    End Function
    <Extension()>
    Public Function ToBytes(ByVal theString As String) As Byte()
        Dim theBytes As New List(Of Byte)()
        theString = theString.Replace(" ", Nothing)
        For i = 0 To theString.Length - 1 Step 2
            theBytes.Add(Byte.Parse(theString.Substring(i, 2), NumberStyles.HexNumber))
        Next i
        Return theBytes.ToArray()
    End Function
#End Region
End Module