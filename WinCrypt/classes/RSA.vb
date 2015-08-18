﻿Option Strict On

Imports System.Security.Cryptography
Imports System.Text

Namespace classes

    Module RSA
        Structure RsaKeyStruct
            Dim OpenKey As String
            Dim PrivatKey As String
        End Structure

        Function Create_RSA_Key(Optional ByVal keysize As Integer = 2048) As RsaKeyStruct
            Dim createbit As Integer = tools.rsa.rsa_create_keys.createbit
            keysize = createbit
            Dim rsaKey As RsaKeyStruct
            Dim rsaCrypto As New RSACryptoServiceProvider(keysize)
            rsaKey.OpenKey = rsaCrypto.ToXmlString(False)
            rsaKey.PrivatKey = rsaCrypto.ToXmlString(True)
            rsaCrypto.Dispose()
            Return rsaKey
        End Function

        Function RSA_encrypt(data As String, openkeyXml As String, Optional ByVal keysize As Integer = 2048) As String
            Dim encryptbit As Integer = tools.rsa.rsa_encrypt.encryptbit
            keysize = encryptbit
            Dim rsaCryptoVer As New RSACryptoServiceProvider(keysize)
            Dim byteData As Byte() = UTF8Encoding.UTF8.GetBytes(data)
            Dim outString As String = String.Empty
            Try
                rsaCryptoVer.FromXmlString(openkeyXml)

                outString = Convert.ToBase64String(rsaCryptoVer.Encrypt(byteData, True))
                rsaCryptoVer.Dispose()
                Return outString
            Catch ex As Exception
                Return ""
                MsgBox(ErrorToString, MsgBoxStyle.Critical)
            End Try
        End Function

        Function RSA_decrypt(data As String, privatekeyXml As String, Optional ByVal keysize As Integer = 2048) As String
            Dim decryptbit As Integer = tools.rsa.rsa_decrypt.decryptbit
            keysize = decryptbit
            Dim rsaCryptoEnt As New RSACryptoServiceProvider(keysize)
            Try
                Dim byteData As Byte() = Convert.FromBase64String(data)
                Dim outString As String = String.Empty
                Try
                    rsaCryptoEnt.FromXmlString(privatekeyXml)
                Catch ex As Exception
                    MsgBox(ErrorToString, MsgBoxStyle.Critical)
                End Try
                Try
                    outString = Encoding.UTF8.GetString(rsaCryptoEnt.Decrypt(byteData, True))
                Catch ex As Exception
                    If Startwindow.Langname = "English" Then
                        MsgBox("wrong key!", MsgBoxStyle.Exclamation)
                    Else
                        MsgBox("Falscher Schlüssel!", MsgBoxStyle.Exclamation)
                    End If

                End Try
                rsaCryptoEnt.Dispose()
                Return outString
            Catch ex As Exception
                Return ""
                If Startwindow.Langname = "English" Then
                    MsgBox("Verschlüsselte Nachricht stimmt nicht mit dem Private Key überein!", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Encrypted message does not match the private key!", MsgBoxStyle.Exclamation)
                End If

            End Try
        End Function
    End Module
End Namespace