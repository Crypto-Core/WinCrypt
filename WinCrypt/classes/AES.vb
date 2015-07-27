Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Namespace classes
    Public Class AES
        Public Function AesEncrypt(plainText As String, password As String, salt As String) As String
            Dim HashAlgorithm = "SHA1"
            Dim passwordIterations = CStr(1)
            Dim InitialVector = "gGw3zFYrtsrXExYu"
            Dim KeySize = 256
            If (String.IsNullOrEmpty(plainText)) Then
                Return ""
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
                Return ""
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
                    MsgBox("Wrong password!", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Falsches Passwort!", MsgBoxStyle.Exclamation)
                End If
                Return "error"
            End Try
        End Function
    End Class
End Namespace