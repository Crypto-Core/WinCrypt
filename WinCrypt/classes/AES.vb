Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class AES
    Public Function AESEncrypt(PlainText As String, Password As String, salt As String) As String
        Dim HashAlgorithm = "SHA1"
        Dim PasswordIterations = CStr(1)
        Dim InitialVector = "gGw3zFYrtsrXExYu"
        Dim KeySize = 256
        If (String.IsNullOrEmpty(PlainText)) Then
            Return ""
            Exit Function
        End If
        Dim InitialVectorBytes As Byte() = Encoding.ASCII.GetBytes(InitialVector)
        Dim SaltValueBytes As Byte() = Encoding.ASCII.GetBytes(salt)
        Dim PlainTextBytes As Byte() = Encoding.UTF8.GetBytes(PlainText)
        Dim DerivedPassword = New PasswordDeriveBytes(Password, SaltValueBytes, HashAlgorithm, PasswordIterations)
        Dim KeyBytes As Byte() = DerivedPassword.GetBytes(CInt(KeySize/8))
        Dim SymmetricKey = New RijndaelManaged()
        SymmetricKey.Mode = CipherMode.CBC
        Dim CipherTextBytes As Byte() = Nothing
        Using Encryptor As ICryptoTransform = SymmetricKey.CreateEncryptor(KeyBytes, InitialVectorBytes)
            Using MemStream As New MemoryStream()
                Using CryptoStream As New CryptoStream(MemStream, Encryptor, CryptoStreamMode.Write)
                    CryptoStream.Write(PlainTextBytes, 0, PlainTextBytes.Length)
                    CryptoStream.FlushFinalBlock()
                    CipherTextBytes = MemStream.ToArray()
                    MemStream.Close()
                    CryptoStream.Close()
                End Using
            End Using
        End Using
        SymmetricKey.Clear()
        Return Convert.ToBase64String(CipherTextBytes)
    End Function

    Public Function AESDecrypt(CipherText As String, password As String, salt As String) As String
        Dim HashAlgorithm = "SHA1"
        Dim PasswordIterations = CStr(2)
        Dim InitialVector = "gGw3zFYrtsrXExYu"
        Dim KeySize = 256
        If (String.IsNullOrEmpty(CipherText)) Then
            Return ""
        End If
        Dim InitialVectorBytes As Byte() = Encoding.ASCII.GetBytes(InitialVector)
        Dim SaltValueBytes As Byte() = Encoding.ASCII.GetBytes(salt)
        Dim CipherTextBytes As Byte() = Convert.FromBase64String(CipherText)
        Dim DerivedPassword = New PasswordDeriveBytes(password, SaltValueBytes, HashAlgorithm, PasswordIterations)
        Dim KeyBytes As Byte() = DerivedPassword.GetBytes(CInt(KeySize/8))
        Dim SymmetricKey = New RijndaelManaged()
        SymmetricKey.Mode = CipherMode.CBC
        Dim PlainTextBytes = New Byte(CipherTextBytes.Length - 1) {}
        Dim ByteCount = 0
        Try
            Using Decryptor As ICryptoTransform = SymmetricKey.CreateDecryptor(KeyBytes, InitialVectorBytes)
                Using MemStream = New MemoryStream(CipherTextBytes)

                    Using CryptoStream = New CryptoStream(MemStream, Decryptor, CryptoStreamMode.Read)
                        ByteCount = CryptoStream.Read(PlainTextBytes, 0, PlainTextBytes.Length)
                        MemStream.Close()
                        CryptoStream.Close()
                    End Using

                End Using
            End Using
            SymmetricKey.Clear()
            Return Encoding.UTF8.GetString(PlainTextBytes, 0, ByteCount)
        Catch ex As Exception
            If startwindow.langname = "English" Then
                MsgBox("Wrong password!", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Falsches Passwort!", MsgBoxStyle.Exclamation)
            End If
            Return "error"
        End Try
    End Function
End Class
