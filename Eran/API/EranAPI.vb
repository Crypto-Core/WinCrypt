﻿Imports System.Net.Sockets
Imports System.IO
Public Class EranAPI
    Private client As New TcpClient
    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private t As New Threading.Thread(AddressOf Listen)
    Private Delegate Sub DAddItem(ByVal s As String)
    Private EncryptedConnection As Boolean = False
    Friend ServerKey As String = ""
    Dim AES As New AESEncrypt
    Private handshake As String
    Friend Event ConnectionState(ByVal State As Boolean)
    Friend Event AuthorizedConnection(ByVal State As Boolean)
    Friend Event IncomingData(ByVal Message As Byte())
    Friend Event IncomingMessage(ByVal Address As String, ByVal Aliasname As String, ByVal ExchangeKey As String, ByVal Message As String)
    Shared ChatSessions As New List(Of ChatSessions_)
    Structure ChatSessions_
        Dim Address As String
        Dim Aliasname As String
        Dim ProfilImage As Image
        Dim OnlineState As Integer
        Dim Encrypted As Boolean
        Dim Key As String
    End Structure
    Friend Structure Connection
        Shared OnlineState As Integer = 2
    End Structure
    Friend Structure Account
        Shared Username As String
        Shared Aliasname As String
        Shared Password As String
        Shared AuthKey As String
        Shared Profileimage As Byte() = Convert.FromBase64String(Resources_.ProfilImageB64)
        Shared Function Address() As String
            Return rHash.HashString(rHash.HashString(Username + Password + AuthKey, rHash.HASH.SHA512), rHash.HASH.MD5)
        End Function
    End Structure


    'Empfange Nachricht
    Private Sub AddItem(ByVal s As String)
        Dim decodeB64 As Byte() = Convert.FromBase64String(s)
        If EncryptedConnection Then
            Dim DecryptTarget As Byte()

            AES.Decode(decodeB64, DecryptTarget, ServerKey, AESEncrypt.ALGO.RIJNDAEL, 4096)
            Dim DecryptStr As String = System.Text.UTF8Encoding.UTF8.GetChars(DecryptTarget)


            'Überprüfen ob die Nachricht für mich ist
            If parameter.read_parameter("/to ", DecryptStr) = Account.Address() Then

                'RaiseEvent IncomingMessage(DecryptTarget)
                'Überprüfen ob die Nachricht vom Server ist
                If parameter.read_parameter("/adress ", DecryptStr) = "server" Then
                    'Autorisierung prüfen
                    If parameter.read_parameter("/authorized ", DecryptStr).Length > 0 Then
                        If CInt(parameter.read_parameter("/authorized", DecryptStr)) = 1 Then
                            Control.CheckForIllegalCrossThreadCalls = False
                            RaiseEvent AuthorizedConnection(True)
                        Else
                            Control.CheckForIllegalCrossThreadCalls = False
                            RaiseEvent AuthorizedConnection(True)
                        End If
                    End If

                End If
                RaiseEvent IncomingData(DecryptTarget)
                Dim address As String = parameter.read_parameter("/adress ", DecryptStr)

                'Sende eigenen OnlienStatus
                Dim getState As String = parameter.read_parameter("/get_state ", DecryptStr)
                If getState.Length > 0 Then
                    SendToServer("/adress " & Account.Address & "; /to " & address & "; /state " & Connection.OnlineState & ";")
                End If

                'Empfange Benutzernamen
                Dim username As String = parameter.read_parameter("/username ", DecryptStr)
                If username.Length > 0 Then

                    'Überprüfen ob bereits eine Session besteht
                    If ChatSessions.Exists(Function(x) x.Address = address) = True Then
                        MsgBox(username)
                        'Suche den Index heraus
                        Dim index As Integer = ChatSessions.FindIndex(Function(x) x.Address = address)
                        Dim current = ChatSessions.Item(index)
                        Dim p As New ChatSessions_
                        p.Address = current.Address
                        p.Aliasname = username
                        p.Encrypted = current.Encrypted
                        p.Key = current.Key
                        p.OnlineState = current.OnlineState
                        p.ProfilImage = current.ProfilImage
                        ChatSessions.RemoveAt(index)
                        ChatSessions.Add(p)
                    End If
                End If

                'Empfange Nachricht
                Dim msg As String = parameter.read_parameter("/msg ", DecryptStr)
                If msg.Length > 0 Then
                    If ChatSessions.Exists(Function(x) x.Address = address) Then
                        Dim decryptTargetMSG As Byte()
                        AES.Decode(Convert.FromBase64String(msg), decryptTargetMSG, ChatSessions.Find(Function(x) x.Address = address).Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                        Dim Message As String = System.Text.UTF8Encoding.UTF8.GetChars(decryptTargetMSG)
                        Dim User = ChatSessions.Find(Function(x) x.Address = address)
                        RaiseEvent IncomingMessage(address, User.Aliasname, User.Key, System.Text.UTF8Encoding.UTF8.GetChars(decryptTargetMSG))
                    Else

                    End If
                End If

                'Sende eigenen Aliasnamen
                Dim get_username As String = parameter.read_parameter("/get_username ", DecryptStr)
                If get_username.Length > 0 Then
                    Dim Alias_ As String
                    If Account.Aliasname.Length < 5 Then
                        Alias_ = Account.Username
                    Else
                        Alias_ = Account.Aliasname
                    End If
                    SendToServer("/adress " & Account.Address & "; /to " & address & "; /username " & Alias_ & ";")
                End If

                'Sende eigenes Profilbild
                Dim get_profil_img As String = parameter.read_parameter("/get_profil_img ", DecryptStr)
                If get_profil_img.Length > 0 Then
                    Dim img_str As String = Convert.ToBase64String(Account.Profileimage)
                    SendToServer("/adress " & Account.Address & "; /to " & address & "; /profil_image " & img_str & ";")
                End If

                Dim publickey_ As String = parameter.read_parameter("/publickey ", DecryptStr)
                Dim encrypted_key As String = parameter.read_parameter("/encrypted_key ", DecryptStr)

                handshake = parameter.read_parameter("/handshake ", DecryptStr)
                If Connection.OnlineState = 0 Then
                Else
                    Select Case handshake
                        Case CStr(0)
                            If ChatSessions.Exists(Function(x) x.Address = address) = True Then
                                Dim index As Integer = ChatSessions.FindIndex(Function(x) x.Address = address)
                                ChatSessions.RemoveAt(index)
                            End If
                            SendToServer("/adress " & Account.Address & "; /to " & address & ";  /publickey " & PublicKey & "; " & "/handshake 1;")
                            '/get_username 1;
                            SendToServer("/adress " & Account.Address & "; /to " & address & ";  /get_username 1;")
                        Case CStr(1)
                            'Empfange die Verschlüsselte RSA nachricht
                            'adresse / key
                            Dim rndKey As String = rndPass.Random(32)
                            Dim encrypt_now As String = RSA_encrypt(rndKey, publickey_, 2048)
                            SendToServer("/adress " & Account.Address & "; /to " & address & "; /encrypted_key " & encrypt_now & "; /handshake 2;")
                            Dim session As New ChatSessions_
                            session.Address = address
                            session.Encrypted = True
                            session.Key = rndKey
                            ChatSessions.Add(session)
                        Case CStr(2)
                            Dim decrypt_key As String = RSA_decrypt(encrypted_key, PrivateKey, 2048)
                            Dim session As New ChatSessions_
                            session.Address = address
                            session.Encrypted = True
                            session.Key = decrypt_key
                            ChatSessions.Add(session)
                        Case CStr(3)
                            remove_encrypt_session(address)
                    End Select
                End If

            End If
        Else
            If parameter.read_parameter("/server_encrypted_key ", System.Text.UTF8Encoding.UTF8.GetChars(decodeB64)).Length > 0 Then
                Dim EncryptedKey As String = parameter.read_parameter("/server_encrypted_key ", System.Text.UTF8Encoding.UTF8.GetChars(decodeB64))
                Dim DecryptKey As String = RSA.RSA_decrypt(EncryptedKey, PrivateKey, 2048)
                ServerKey = DecryptKey
                Control.CheckForIllegalCrossThreadCalls = False
                RaiseEvent ConnectionState(True)
                EncryptedConnection = True
                Dim getAuthByte As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(Account.Username & Account.Password & Account.AuthKey)
                Dim toB64 As String = Convert.ToBase64String(getAuthByte)
                SendToServer("/adress " & Account.Address() & "; /getauthKey " & toB64 & ";")
            End If
        End If
    End Sub
    Friend Shared Function remove_encrypt_session(ByVal eran_adress As String) As Object
        On Error Resume Next
        For Each check In ChatSessions
            If eran_adress = check.Address Then
                ChatSessions.Remove(check)
            End If
        Next
    End Function

    Private PublicKey As String
    Private PrivateKey As String
    Friend Function Disconnect()
        client.Close()
        stream.Close()
        streamr.Close()
        streamw.Close()
        t.Abort()
    End Function
    Friend Function Connect(ByVal Host As String, ByVal Port As String)
        Dim RSAKeys = RSA.Create_RSA_Key
        PublicKey = RSAKeys.OpenKey
        PrivateKey = RSAKeys.PrivatKey
        Try
            client = New TcpClient
            client.Connect(Host, Port) ' hier die ip des servers eintragen. 
            ' da dieser beim testen wohl lokal läuft, hier die loopback-ip 127.0.0.1.
            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)
                Dim bs64_publickey As String = Base64.Str_To_Base64Str(PublicKey)

                streamw.WriteLine(Base64.Str_To_Base64Str("/adress " & Account.Address() & "; " & "/publickey " & bs64_publickey & ";")) ' das ist optional.
                streamw.Flush()
                t = New Threading.Thread(AddressOf Listen)
                t.Start()
            Else
                MessageBox.Show("Verbindung zum Server nicht möglich!" & vbNewLine & "Test")
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show("Verbindung zum Server nicht möglich!" & vbNewLine & ex.ToString)
            Application.Exit()
        End Try
    End Function

    Private Sub Listen()
        Control.CheckForIllegalCrossThreadCalls = False
        While client.Connected
            Try
                Dim line As String = streamr.ReadLine

                AddItem(line)
            Catch ex As Exception
                Control.CheckForIllegalCrossThreadCalls = False
                EncryptedConnection = False
                RaiseEvent ConnectionState(False)
                MsgBox(ex.ToString)
            End Try
        End While
    End Sub
    Friend Function SendToServer(ByVal input As String)
        If EncryptedConnection Then
            Dim get_msg_bytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(input)
            Dim source_enc_mgs As Byte()
            AES.Encode(get_msg_bytes, source_enc_mgs, ServerKey, AESEncrypt.ALGO.RIJNDAEL, 4096)
            Dim convert_tobs64 As String = Convert.ToBase64String(source_enc_mgs)
            streamw.WriteLine(convert_tobs64)
            streamw.Flush()
        Else
            streamw.WriteLine(input)
            streamw.Flush()
        End If

    End Function

    Private Sub EranAPI_ConnectionState(ByVal State As Boolean) Handles Me.ConnectionState
        If State = False Then
            Control.CheckForIllegalCrossThreadCalls = False
            RaiseEvent AuthorizedConnection(False)
        End If
    End Sub
End Class
