Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Globalization
Imports System.Runtime.CompilerServices
Namespace classes
    Public Class AES
        Public Function AesEncrypt(plainText As String, password As String, salt As String) As String
            Dim HashAlgorithm = "SHA1"
            Dim passwordIterations = CStr(1)
            Dim InitialVector = "gGw3zFYrtsrXExYu"
            Dim KeySize = 256
            If (String.IsNullOrEmpty(plainText)) Then
                Return Nothing
                Exit Function
            End If
            Dim initialVectorBytes As Byte() = Encoding.ASCII.GetBytes(InitialVector)
            Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(salt)
            Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plainText)
            Dim derivedPassword = New PasswordDeriveBytes(password, saltValueBytes, HashAlgorithm, passwordIterations)
            Dim keyBytes As Byte() = derivedPassword.GetBytes(CInt(KeySize / 8))
            Dim symmetricKey = New RijndaelManaged()
            symmetricKey.Mode = CipherMode.CBC
            Dim cipherTextBytes As Byte() = Nothing
            Using encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initialVectorBytes)
                Using memStream As New MemoryStream()
                    Using cryptoStream As New CryptoStream(memStream, encryptor, CryptoStreamMode.Write)
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
                        cryptoStream.FlushFinalBlock()
                        cipherTextBytes = memStream.ToArray()
                        memStream.Close()
                        cryptoStream.Close()
                    End Using
                End Using
            End Using
            symmetricKey.Clear()
            Return Convert.ToBase64String(cipherTextBytes)
        End Function
        Public Function AesDecrypt(cipherText As String, password As String, salt As String) As String
            Dim HashAlgorithm = "SHA1"
            Dim passwordIterations = CStr(2)
            Dim InitialVector = "gGw3zFYrtsrXExYu"
            Dim KeySize = 256
            If (String.IsNullOrEmpty(cipherText)) Then
                Return Nothing
            End If
            Dim initialVectorBytes As Byte() = Encoding.ASCII.GetBytes(InitialVector)
            Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(salt)
            Dim cipherTextBytes As Byte() = Convert.FromBase64String(cipherText)
            Dim derivedPassword = New PasswordDeriveBytes(password, saltValueBytes, HashAlgorithm, passwordIterations)
            Dim keyBytes As Byte() = derivedPassword.GetBytes(CInt(KeySize / 8))
            Dim symmetricKey = New RijndaelManaged()
            symmetricKey.Mode = CipherMode.CBC
            Dim plainTextBytes = New Byte(cipherTextBytes.Length - 1) {}
            Dim byteCount = 0
            Try
                Using decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initialVectorBytes)
                    Using memStream = New MemoryStream(cipherTextBytes)
                        Using cryptoStream = New CryptoStream(memStream, decryptor, CryptoStreamMode.Read)
                            byteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
                            memStream.Close()
                            cryptoStream.Close()
                        End Using
                    End Using
                End Using
                symmetricKey.Clear()
                Return Encoding.UTF8.GetString(plainTextBytes, 0, byteCount)
            Catch ex As Exception
                If Startwindow.Langname = "English" Then
                    MessageBox.Show("Wrong Password!", "WinCrypt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("Falsches Passwort!", "WinCrypt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                Return "error"
            End Try
        End Function
    End Class
    Module CryptoStuff
        Public Property Selectcombo As String
        Private Sub MakeKeyAndIv(password As String, salt() As Byte, keySizeBits As Integer, blockSizeBits As Integer, ByRef key() As Byte, ByRef iv() As Byte)
            Dim deriveBytes As New Rfc2898DeriveBytes(password, salt, 1000)
            key = deriveBytes.GetBytes(CInt(keySizeBits / 8))
            iv = deriveBytes.GetBytes(CInt(blockSizeBits / 8))
        End Sub
#Region "Encrypt Files and Streams"
        Public Sub EncryptFile(password As String, inFile As String, outFile As String)
            CryptFile(password, inFile, outFile, True)
        End Sub
        Public Sub DecryptFile(password As String, inFile As String, outFile As String)
            CryptFile(password, inFile, outFile, False)
        End Sub
        Public Sub CryptFile(password As String, inFile As String, outFile As String, encrypt As Boolean)
            Try
                Using inStream As New FileStream(inFile, FileMode.Open, FileAccess.Read)
                    Using outStream As New FileStream(outFile, FileMode.Create, FileAccess.Write)
                        CryptStream(password, inStream, outStream, encrypt)
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ErrorToString, MsgBoxStyle.Critical)
                Startwindow.decrypt_list_status.Items.Add(ErrorToString)
            End Try
        End Sub
        Public Sub CryptStream(password As String, inStream As Stream, outStream As Stream, encrypt As Boolean)
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
                Startwindow.Errormount = "error"
                Startwindow.Formclose = False
                MsgBox("Die Datei ist beschädigt oder der Schlüssel ist falsch!", MsgBoxStyle.Critical)
                Application.Restart()
            End Try
            cryptoTransform.Dispose()
        End Sub
#End Region

#Region "Encrypt Strings and Byte()"
        Public Function CryptBytes(password As String, inBytes() As Byte, encrypt As Boolean) As Byte()
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
        <Extension>
        Public Function Encrypt(theString As String, password As String) As Byte()
            Dim asciiEncoder As New ASCIIEncoding()
            Dim plainBytes() As Byte = asciiEncoder.GetBytes(theString)
            Return CryptBytes(password, plainBytes, True)
        End Function
        <Extension>
        Public Function Decrypt(theBytes() As Byte, password As String) As String
            Dim decryptedBytes() As Byte = CryptBytes(password, theBytes, False)
            Dim asciiEncoder As New ASCIIEncoding()
            Return asciiEncoder.GetString(decryptedBytes)
        End Function
        Public Function CryptString(password As String, inString As String, encrypt As Boolean) As String
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
        <Extension>
        Public Function ToHex(theBytes() As Byte) As String
            Return theBytes.ToHex(False)
        End Function
        <Extension>
        Public Function ToHex(theBytes() As Byte, addSpaces As Boolean) As String
            Dim result = Nothing
            Dim separator = Nothing
            If (addSpaces) Then separator = " "
            For i = 0 To theBytes.Length - 1
                result &= theBytes(i).ToString("x2") & separator
            Next i
            Return result
        End Function
        <Extension>
        Public Function ToBytes(theString As String) As Byte()
            Dim theBytes As New List(Of Byte)()
            theString = theString.Replace(" ", Nothing)
            For i = 0 To theString.Length - 1 Step 2
                theBytes.Add(Byte.Parse(theString.Substring(i, 2), NumberStyles.HexNumber))
            Next i
            Return theBytes.ToArray()
        End Function
#End Region
    End Module
End Namespace