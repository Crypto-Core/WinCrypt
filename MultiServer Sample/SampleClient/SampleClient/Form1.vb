Imports System.Net.Sockets
Imports System.IO

Public Class Form1
    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private client As New TcpClient
    Private t As New Threading.Thread(AddressOf Listen)
    Private Delegate Sub DAddItem(ByVal s As Byte())
    Private nick As String = "93ru230ru039r"
    Friend Shared PublicKey As String
    Friend Shared PrivateKey As String
    Friend Shared isEncrypted_Server As Boolean = False
    Friend Shared Server_key As String
    Friend Shared aes_ As New AESEncrypt
    Friend tempHost As String
    Private Sub AddItem(ByVal s As Byte())
        'Überprüfen ob die Nachricht für mich
        If isEncrypted_Server = True Then
            Dim source_encrypt As Byte() = s

            Dim target As Byte()
            aes_.Decode(source_encrypt, target, Server_key, AESEncrypt.ALGO.RIJNDAEL, 4096)
            Dim decrypted_to_str As String = System.Text.UTF8Encoding.UTF8.GetChars(target)
            'Inhalt abarbeiten

            'ListBox1.Items.Add(decrypted_to_str)
        End If
        
        Dim byte_to_str = System.Text.UTF8Encoding.UTF8.GetChars(s)
        If parameter.read_parameter("/to ", byte_to_str) = nick Then
            'Wenn es einen Handshake vom Server gibt
            If parameter.read_parameter("/server_encrypted_key ", byte_to_str).Length > 0 Then
                ' Dim encrypt_decodeBase64 = Base64.FromBase64Str_to_Str(parameter.read_parameter("/server_encrypted_key ", s))
                Dim decrypt As String = parameter.read_parameter("/server_encrypted_key ", byte_to_str)
                Dim temp_Host As String = parameter.read_parameter("/reconnect_to ", byte_to_str)
                tempHost = temp_Host
                Server_key = RSA_decrypt(decrypt, PrivateKey)
                isEncrypted_Server = True
            End If
        End If

    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            client.Connect("localhost", 8000) ' hier die ip des servers eintragen. 
            ' da dieser beim testen wohl lokal läuft, hier die loopback-ip 127.0.0.1.
            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)

                'Den PublicKey in Base64

                Dim bs64_publickey As String = Base64.Str_To_Base64Str(PublicKey)

                'Kodiere den Base64 String
                streamw.WriteLine(Base64.Str_To_Base64Str("/adress " & nick & "; " & "/publickey " & bs64_publickey & ";")) ' das ist optional.
                streamw.Flush()

                t.Start()
            Else
                MessageBox.Show("Verbindung zum Server nicht möglich!")
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show("Verbindung zum Server nicht möglich!")
            Application.Exit()
        End Try
    End Sub

    Private Sub Listen()
        While client.Connected
            Try
                Me.Invoke(New DAddItem(AddressOf AddItem), Base64.FromBase64Str_to_decodeBytes(streamr.ReadLine))
            Catch
                MessageBox.Show("Verbindung zum Server nicht möglich!")
                Application.Exit()
            End Try
        End While
    End Sub
    Private Function Send_to_Server(ByVal str As String)
        If isEncrypted_Server = True Then
            Dim get_msg_bytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(str)
            Dim source_enc_mgs As Byte()
            aes_.Encode(get_msg_bytes, source_enc_mgs, Server_key, AESEncrypt.ALGO.RIJNDAEL, 4096)
            Dim convert_tobs64 As String = Convert.ToBase64String(source_enc_mgs)
            streamw.WriteLine(convert_tobs64)
            streamw.Flush()
        Else
            streamw.WriteLine(str)
            streamw.Flush()
        End If
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nick = InputBox("Gebe dei Nick ein", "Nickname", nick)


        Dim createRSA_Keys = RSA.Create_RSA_Key
        PublicKey = createRSA_Keys.OpenKey
        PrivateKey = createRSA_Keys.PrivatKey
    End Sub

End Class
