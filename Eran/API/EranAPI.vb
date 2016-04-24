Imports System.Net.Sockets
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
    Friend Event ConnectionState(ByVal State As Boolean)
    Friend Event AuthorizedConnection(ByVal State As Boolean)
    Friend Event IncomingMessage(ByVal Message As Byte())
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
                RaiseEvent IncomingMessage(DecryptTarget)
                Dim address As String = parameter.read_parameter("/adress ", DecryptStr)

                'Sende eigenen OnlienStatus
                Dim getState As String = parameter.read_parameter("/get_state ", DecryptStr)
                If getState.Length > 0 Then
                    SendToServer("/adress " & Account.Address & "; /to " & address & "; /state " & Connection.OnlineState & ";")
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


                Dim get_profil_img As String = parameter.read_parameter("/get_profil_img ", DecryptStr)
                If get_profil_img.Length > 0 Then
                    Dim img_str As String = Convert.ToBase64String(Account.Profileimage)
                    SendToServer("/adress " & Account.Address & "; /to " & address & "; /profil_image " & img_str & ";")
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
