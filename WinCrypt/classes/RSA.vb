Option Strict On

Imports System.Security.Cryptography
Imports System.Text

Module RSA
    Structure RSA_key_Struct
        Dim open_key As String
        Dim privat_key As String
    End Structure

    Function Create_RSA_Key(Optional ByVal keysize As Integer = 2048) As RSA_key_Struct
        Dim RSA_key As RSA_key_Struct
        Dim RSA_Crypto As New RSACryptoServiceProvider(keysize)
        RSA_key.open_key = RSA_Crypto.ToXmlString(False)
        RSA_key.privat_key = RSA_Crypto.ToXmlString(True)
        RSA_Crypto.Dispose()
        Return RSA_key
    End Function

    Function RSA_encrypt(DATA As String, Openkey_Xml As String, Optional ByVal keysize As Integer = 2048) As String
        Dim RSA_Crypto_ver As New RSACryptoServiceProvider(keysize)
        Dim byte_data As Byte() = UTF8Encoding.UTF8.GetBytes(DATA)
        Dim Out_String As String = String.Empty
        Try
            RSA_Crypto_ver.FromXmlString(Openkey_Xml)
            Out_String = Convert.ToBase64String(RSA_Crypto_ver.Encrypt(byte_data, True))
            RSA_Crypto_ver.Dispose()
            Return Out_String
        Catch ex As Exception
            Return ""
            MsgBox(ErrorToString, MsgBoxStyle.Critical)
        End Try
    End Function

    Function RSA_decrypt(DATA As String, Privatekey_Xml As String, Optional ByVal keysize As Integer = 2048) As String
        Dim RSA_Crypto_ent As New RSACryptoServiceProvider(keysize)
        Try
            Dim byte_data As Byte() = Convert.FromBase64String(DATA)
            Dim Out_String As String = String.Empty
            Try
                RSA_Crypto_ent.FromXmlString(Privatekey_Xml)
            Catch ex As Exception
                MsgBox(ErrorToString, MsgBoxStyle.Critical)
            End Try
            Try
                Out_String = Encoding.UTF8.GetString(RSA_Crypto_ent.Decrypt(byte_data, True))
            Catch ex As Exception
                MsgBox("Falscher Schlüssel!", MsgBoxStyle.Exclamation)
            End Try
            RSA_Crypto_ent.Dispose()
            Return Out_String
        Catch ex As Exception
            Return ""
            MsgBox("Verschlüsselte Nachricht stimmt nicht mit dem Private Key überein!", MsgBoxStyle.Exclamation)
        End Try
    End Function
End Module
