Imports System.Net.Sockets
Imports System.IO

Public Class main_frm
    Private stream As NetworkStream
    Friend Shared streamw As StreamWriter
    Private streamr As StreamReader
    Private client As TcpClient
    Private t As Threading.Thread
    Private Delegate Sub DAddItem(ByVal s As Byte())
    Friend Shared eran_adress As String
    Friend Shared username As String
    Friend Shared host As String
    Friend Shared port As Integer
    Friend Shared PublicKey As String
    Friend Shared PrivateKey As String
    Friend Shared isEncrypted_Server As Boolean = False
    Friend Shared Server_key As String
    Friend Shared aes_ As New AESEncrypt
    Friend Shared tempHost As String
    Friend Shared online_state As Integer = 0
    Friend Shared account_path As String = My.Application.Info.DirectoryPath & OS.OS_slash & "account.ini"
    Friend Shared users_lst_path As String = My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini"
    Friend Shared profilimage_ As String = ""
    Friend chat_frm(10000) As Form
    Friend chat_rtb(10000) As RichTextBox
    Private index As Integer = 0
    Private enc_file_byt_target As Byte()
    Friend trd_con As System.Threading.Thread
    Friend Shared handshake As String
    Private OnlineBallon As Boolean = False
    Friend Shared DisconnectFromUser As Boolean = False
    ''' <summary>
    ''' Es wird eine Nachricht empfangen und verarbeitet.
    ''' </summary>
    ''' <param name="s">Die enthaltende Nachricht.</param>
    ''' <remarks></remarks>
    Private Sub AddItem(ByVal s As Byte())
        '
        'Überprüfen ob die Verbindung verschlüsselt ist
        If isEncrypted_Server = True Then

            Dim source_encrypt As Byte() = s
            Dim target As Byte()

            'Eingehende Nachricht vom Server entschlüsseln
            aes_.Decode(source_encrypt, target, Server_key, AESEncrypt.ALGO.RIJNDAEL, 4096)

            'Eingehende Nachricht von Byte in Chars.
            Dim decrypted_to_str As String = System.Text.UTF8Encoding.UTF8.GetChars(target)

            'Deklariere Parameter für wenn die Nachricht ist (Empfänger).
            Dim to_ As String = parameter.read_parameter("/to ", decrypted_to_str)
            Dim all As String = parameter.read_parameter("/all ", decrypted_to_str)

            If all.Length > 0 Then 'Überprüfe wie Lang der Parameter all ist.
                ' Deklariere den Status eines Nutzers
                Dim send_state As String = parameter.read_parameter("/state ", decrypted_to_str)
                If send_state.Length > 0 Then
                    For remove As Integer = 0 To connected_usr.usr_lst.Count - 1
                        Try
                            If all = connected_usr.usr_lst.Item(remove).Eran_adress Then
                                connected_usr.usr_lst.RemoveRange(remove, remove + 1)
                            End If
                        Catch ex As Exception : End Try
                    Next
                    For set_usr_state As Integer = 0 To userlist_viewer.Items.Count - 1
                        If userlist_viewer.Items(set_usr_state).SubItems(1).Text = all Then
                            userlist_viewer.Items(set_usr_state).ImageIndex = Int(send_state)
                        End If
                    Next
                End If
            End If
            Dim adress_ As String = parameter.read_parameter("/adress ", decrypted_to_str) 'Deklariere den Parameter Absender

            'Überprüfen ob die Nachricht für mich ist ---------------------------------------->
            If to_ = eran_adress Then
                'Inhalt abarbeiten
                Dim ping As String = parameter.read_parameter("/ping ", decrypted_to_str) ' Deklariere den Parameter Ping
                Dim state As String = parameter.read_parameter("/get_state ", decrypted_to_str)
                Dim get_publickey As String = parameter.read_parameter("/get_publickey ", decrypted_to_str) 'Deklariere den Parameter get_PublicKey
                Dim publickey_ As String = parameter.read_parameter("/publickey ", decrypted_to_str)
                handshake = parameter.read_parameter("/handshake ", decrypted_to_str) 'Deklariere den Parameter PublicKey
                Dim msg As String = parameter.read_parameter("/msg ", decrypted_to_str) 'Deklariere den Parameter Message
                Dim username As String = parameter.read_parameter("/username ", decrypted_to_str) 'Deklariere den Parameter Username
                Dim send_state As String = parameter.read_parameter("/state ", decrypted_to_str) 'Send state status
                Dim get_state As String = parameter.read_parameter("/get_state ", decrypted_to_str)
                Dim profilimage As String = parameter.read_parameter("/profil_image ", decrypted_to_str)
                Dim encrypted_key As String = parameter.read_parameter("/encrypted_key ", decrypted_to_str)
                Dim get_profilimage As String = parameter.read_parameter("/get_profil_img ", decrypted_to_str)
                Dim get_username As String = parameter.read_parameter("/get_username ", decrypted_to_str)

                If username = "" Then
                Else

                    If is_in_usrlst(adress_) = "" Then
                        Dim ini As New IniFile
                        Dim read_enc_bytes As Byte() = File.ReadAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini")
                        Dim dec_trg_byte As Byte()
                        aes_.Decode(read_enc_bytes, dec_trg_byte, login.pwd, AESEncrypt.ALGO.RIJNDAEL, 4096)
                        Dim mem_ As New MemoryStream(dec_trg_byte)
                        ini.LoadFromMemory(mem_)
                        ini.SetKeyValue(username, "adress", adress_)
                        Dim save_ini_byt As Byte()
                        save_ini_byt = ini.SavetoByte
                        Dim targed_enc_byt As Byte()
                        aes_.Encode(save_ini_byt, targed_enc_byt, login.pwd, AESEncrypt.ALGO.RIJNDAEL, 4096)
                        File.WriteAllBytes(users_lst_path, targed_enc_byt)
                        If index = 0 Then : Else
                            For setFRM As Integer = 0 To index - 1
                                If chat_frm(setFRM).Name = adress_ Then
                                    chat_frm(setFRM).Text = username
                                End If
                            Next
                        End If
                        With userlist_viewer.Items.Add(username, 0)
                            .SubItems.Add(adress_)
                        End With
                        Send_to_Server("/adress " & eran_adress & "; /to " & adress_ & "; /get_state True;")
                    Else
                        For Each changeUSR As ListViewItem In userlist_viewer.Items
                            If changeUSR.SubItems(1).Text = adress_ Then
                                Dim ini As New IniFile
                                Dim read_enc_bytes As Byte() = File.ReadAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini")
                                Dim dec_trg_byte As Byte()
                                aes_.Decode(read_enc_bytes, dec_trg_byte, login.pwd, AESEncrypt.ALGO.RIJNDAEL, 4096)
                                Dim mem_ As New MemoryStream(dec_trg_byte)
                                ini.LoadFromMemory(mem_)
                                ini.RemoveSection(changeUSR.Text)
                                ini.SetKeyValue(username, "adress", adress_)
                                Dim save_ini_byt As Byte()
                                save_ini_byt = ini.SavetoByte
                                Dim targed_enc_byt As Byte()
                                aes_.Encode(save_ini_byt, targed_enc_byt, login.pwd, AESEncrypt.ALGO.RIJNDAEL, 4096)
                                File.WriteAllBytes(users_lst_path, targed_enc_byt)
                                changeUSR.Text = username
                            End If
                        Next
                        If index = 0 Then : Else
                            For setFRM As Integer = 0 To index - 1
                                If chat_frm(setFRM).Name = adress_ Then
                                    chat_frm(setFRM).Text = username
                                End If
                            Next
                        End If



                    End If
                End If
                If get_username = "" Then : Else
                    Send_to_Server("/adress " & eran_adress & "; /to " & adress_ & "; /username " & alias_txt.Text & ";")
                End If
                If ping = "pong" Then
                    MsgBox("Pong from Server", MsgBoxStyle.Information, "Server")
                End If

                'Sende Profilbild
                If get_profilimage.Length = "1" Then
                    Dim ini As New IniFile
                    ini.Load(account_path)
                    Dim img_str As String = ini.GetKeyValue("account", "image")
                    Send_to_Server("/adress " & eran_adress & "; /to " & adress_ & "; /profil_image " & img_str & ";")
                End If

                'Empfange Profilbild
                If profilimage.Length > 0 Then
                    profilimage_ = "/to " & adress_ & "; /get_profil_img " & profilimage & ";"
                End If

                'Emfange neue Nachricht
                If msg.Length > 0 Then
                    alert()
                    If connected_usr.isConnect_Encrypt(adress_) = True Then
                        Dim key As String
                        For Each tt In connected_usr.usr_lst
                            If tt.Eran_adress = adress_ Then
                                key = tt.Key
                            End If
                        Next
                        Dim to_char As Byte() = Convert.FromBase64String(msg)
                        Dim target_msg As Byte()
                        aes_.Decode(to_char, target_msg, key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                        Dim check_in_lst As String = is_in_usrlst(adress_)
                        If check_in_lst.Length > 0 Then
                            new_chat(adress_, check_in_lst, System.Text.UTF8Encoding.UTF8.GetChars(target_msg) & vbNewLine)
                        Else
                            new_chat(adress_, adress_, System.Text.UTF8Encoding.UTF8.GetChars(target_msg) & vbNewLine)
                        End If : Else
                        new_chat(adress_, adress_, msg)
                    End If : End If

                'Empfange Verschlüsselte Datei
                Dim file_ As String = parameter.read_parameter("/file ", decrypted_to_str)
                Dim filename As String = parameter.read_parameter("/Fname ", decrypted_to_str)
                If file_.Length > 0 Then
                    If connected_usr.isConnect_Encrypt(adress_) = True Then
                        Dim key_ As String
                        Dim name_ As String = ""
                        For Each tt As ListViewItem In userlist_viewer.Items ' Search Username
                            If tt.SubItems(1).Text = adress_ Then
                                name_ = tt.Text
                            End If
                        Next
                        For Each src_usr In connected_usr.usr_lst 'Search User and get key
                            If src_usr.Eran_adress = adress_ Then
                                key_ = src_usr.Key
                            End If
                        Next
                        If name_.Length = 0 Then
                            name_ = adress_
                        End If

                        If MessageBox.Show("A file comes from " & name_ & " , do you want to accept the file?", "Incoming file", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            If file_.Length > 0 Then
                                Dim enc_dec_b64_file As Byte() = Convert.FromBase64String(file_) 'Decode Base64
                                Dim enc_dec_b64_filename As Byte() = Convert.FromBase64String(filename) 'Decode Base64
                                Dim enc_filename_byt_target As Byte()
                                aes_.Decode(enc_dec_b64_file, enc_file_byt_target, key_, AESEncrypt.ALGO.RIJNDAEL, 4096)
                                aes_.Decode(enc_dec_b64_filename, enc_filename_byt_target, key_, AESEncrypt.ALGO.RIJNDAEL, 4096)
                                enc_dec_b64_file = Nothing
                                enc_dec_b64_filename = Nothing
                                SaveFileDialog.FileName = System.Text.UTF8Encoding.UTF8.GetChars(enc_filename_byt_target)
                                SaveFileDialog.ShowDialog()
                            End If
                        Else
                            GC_.FlushMemory()
                        End If : End If : End If

                'Sende meinen OnlineStatus
                If get_state = "True" Then
                    Send_to_Server("/adress " & eran_adress & "; /to " & adress_ & "; " & "/state " & online_state & ";")
                End If

                'Empfange einen OnlineStatus und überprüfe ihn mit meiner Liste
                If send_state.Length > 0 Then
                    For set_usr_state As Integer = 0 To userlist_viewer.Items.Count - 1
                        If userlist_viewer.Items(set_usr_state).SubItems(1).Text = adress_ Then
                            If OnlineBallon = True Then
                                Select Case send_state
                                    Case 2
                                        Dim trdOnlineSound As New Threading.Thread(AddressOf userOnlineSound)
                                        trdOnlineSound.IsBackground = True
                                        trdOnlineSound.Start()
                                End Select : End If
                            userlist_viewer.Items(set_usr_state).ImageIndex = Int(send_state)
                        End If : Next : End If

                'Empfange einen Handshake
                If online_state = 0 Then
                Else
                    Select Case handshake
                        Case 0
                            Send_to_Server("/adress " & eran_adress & "; /to " & adress_ & ";  /publickey " & PublicKey & "; " & "/handshake 1;")
                        Case 1
                            'Empfange die Verschlüsselte RSA nachricht
                            'adresse / key
                            Dim rndKey As String = rndPass.Random(32)
                            Dim encrypt_now As String = RSA_encrypt(rndKey, publickey_, 2048)
                            Send_to_Server("/adress " & eran_adress & "; /to " & adress_ & "; /encrypted_key " & encrypt_now & "; /handshake 2;")
                            Dim enc_usr As New connected_usr.Encrypted_User
                            enc_usr.Eran_adress = adress_
                            enc_usr.Key = rndKey
                            connected_usr.usr_lst.Add(enc_usr)
                        Case 2
                            Dim decrypt_key As String = RSA_decrypt(encrypted_key, PrivateKey, 2048)
                            Dim enc_usr As New connected_usr.Encrypted_User
                            enc_usr.Eran_adress = adress_
                            enc_usr.Key = decrypt_key
                            connected_usr.usr_lst.Add(enc_usr)
                        Case 3
                            connected_usr.remove_encrypt_session(adress_)
                    End Select : End If : End If
            GC_.FlushMemory()
        Else
            Dim byte_to_str = System.Text.UTF8Encoding.UTF8.GetChars(s)

            'Überprüfen ob die Nachricht für mich
            If parameter.read_parameter("/to ", byte_to_str) = eran_adress Then
                'Wenn es einen Handshake vom Server gibt
                If parameter.read_parameter("/server_encrypted_key ", byte_to_str).Length > 0 Then
                    ' Dim encrypt_decodeBase64 = Base64.FromBase64Str_to_Str(parameter.read_parameter("/server_encrypted_key ", s))
                    Dim decrypt As String = parameter.read_parameter("/server_encrypted_key ", byte_to_str)
                    Dim temp_Host As String = parameter.read_parameter("/reconnect_to ", byte_to_str)
                    tempHost = temp_Host
                    Server_key = RSA_decrypt(decrypt, PrivateKey)
                    isEncrypted_Server = True
                    userlist_viewer.Items.Clear()
                    load_userlist()
                    set_State(2)
                End If
            End If
            GC_.FlushMemory()
        End If
    End Sub

    ''' <summary>
    ''' Überprüft ob ei Benutzer in der Freundeslist ist.
    ''' </summary>
    ''' <param name="eran_adress">Die Eran Adresse die überprüft werden soll.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function is_in_usrlst(ByVal eran_adress As String) As String
        For Each Item As ListViewItem In userlist_viewer.Items
            If eran_adress = Item.SubItems(1).Text Then
                Return Item.Text
                End
            End If : Next
        Return ""
    End Function

    ''' <summary>
    ''' Es wird ein Alert Sound abgespielt.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub alert()
        My.Computer.Audio.Play(My.Resources.alert, AudioPlayMode.Background)
    End Sub
    ''' <summary>
    ''' Der Client lauscht ob eingehende Nachricht vom Server kommen.
    ''' Meldet wenn die Verbindung abgebrochen wurde zum Server.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Listen()
        While client.Connected
            Try
                Invoke(New DAddItem(AddressOf AddItem), Base64.FromBase64Str_to_decodeBytes(streamr.ReadLine))
            Catch ex As Exception
                If DisconnectFromUser = True Then
                    eran_adr_txt.Text = "error"
                    main_panel.Hide()
                    login.login_panel.Show()
                Else
                    Connect()
                End If

                Exit While
            End Try : End While
    End Sub

    ''' <summary>
    ''' Nachricht wird an den Server gesendet
    ''' </summary>
    ''' <param name="str">Nachricht die an den Server gesendet werden soll.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Shared Function Send_to_Server(ByVal str As String)
        If isEncrypted_Server = True Then
            Dim get_msg_bytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(Str)
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
    ''' <summary>
    ''' Benutzerliste wird geladen
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Shared Function load_userlist()
        If File.Exists(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini") = True Then
            Dim ini As New IniFile
            Dim read_ini_bytes As Byte() = File.ReadAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini")
            Dim target_enc As Byte()
            aes_.Decode(read_ini_bytes, target_enc, login.pwd, AESEncrypt.ALGO.RIJNDAEL, 4096)
            Dim ini_mem As New MemoryStream(target_enc)
            ini.LoadFromMemory(ini_mem)
            For Each s As IniFile.IniSection In ini.Sections
                For Each k As IniFile.IniSection.IniKey In s.Keys
                    With main_frm.userlist_viewer.Items.Add(s.Name, 0)
                        .SubItems.Add(k.Value)
                    End With : Next : Next
            For check_State As Integer = 0 To main_frm.userlist_viewer.Items.Count - 1
                Send_to_Server("/adress " & eran_adress & "; /to " & main_frm.userlist_viewer.Items(check_State).SubItems(1).Text & "; /get_state True; /get_username 1;")
            Next : Else : End If
    End Function
    ''' <summary>
    ''' Benutzerliste wird neu geladen
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function refresh_usrlist()
        For check_State As Integer = 0 To userlist_viewer.Items.Count - 1
            Send_to_Server("/adress " & eran_adress & "; /to " & userlist_viewer.Items(check_State).SubItems(1).Text & "; /get_state True;")
        Next
    End Function

    Private Sub main_frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If SecureDesktop.isOnSecureDesktop = True Then
            BringToFront()
            TopMost = True
        End If
    End Sub

    Private Sub main_frm_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        If SecureDesktop.isOnSecureDesktop = True Then
            backgroundSecure.SendToBack()
        End If
    End Sub
    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Controls.Add(create_account.create_account_panel)
        main_panel.Hide()
        If File.Exists(account_path) = True Then
            create_account.create_account_panel.Hide()
            Me.Controls.Add(login.login_panel)
            login.login_panel.Show()
        Else
            login.login_panel.Hide()
            create_account.create_account_panel.Show()
        End If
        If SecureDesktop.isOnSecureDesktop = True Then
            profil_img.Cursor = Cursors.Default
        End If

        'Start Localserver
        'trd = New Threading.Thread(AddressOf server.Main)
        'trd.IsBackground = True
        'trd.Start()
    End Sub


    ''' <summary>
    ''' Wenn eine Verbindung aufgebaut wird, wird ein Handshake mit dem Server vereinbart über RSA.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub conn()
        Dim createRSA_Keys = RSA.Create_RSA_Key
        PublicKey = createRSA_Keys.OpenKey
        PrivateKey = createRSA_Keys.PrivatKey
        Try
            client = New TcpClient
            client.Connect(host, port) ' hier die ip des servers eintragen. 
            ' da dieser beim testen wohl lokal läuft, hier die loopback-ip 127.0.0.1.
            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)

                'Den PublicKey in Base64
                Dim bs64_publickey As String = Base64.Str_To_Base64Str(PublicKey)

                'Kodiere den Base64 String
                streamw.WriteLine(Base64.Str_To_Base64Str("/adress " & eran_adress & "; " & "/publickey " & bs64_publickey & ";")) ' das ist optional.
                streamw.Flush()
                t = New Threading.Thread(AddressOf Listen)
                t.Start()
                main_panel.Show()

                connect_frame.Panel1.Hide()
                Dim ini As New IniFile
                ini.Load(account_path)
                If ini.GetKeyValue("account", "alias") = "" Then
                    alias_txt.Text = username
                Else
                    alias_txt.Text = ini.GetKeyValue("account", "alias")
                End If

                server.myHost = host
            Else
                MessageBox.Show("Verbindung zum Server nicht möglich!2")
                Application.Exit()
            End If
        Catch ex As Exception
            If index = 0 Then : Else
                For closeIndex As Integer = 0 To index - 1
                    chat_frm(closeIndex).Close()
                    chat_frm(closeIndex).Dispose()
                    chat_frm(closeIndex) = Nothing
                Next
                index = 0
            End If

            eran_adr_txt.Text = "error"
            main_panel.Hide()
            login.login_panel.Show()

            MsgBox(ex.Message)
            login.login_panel.Show()
        End Try
    End Sub
    Private Sub userOnlineSound()
        My.Computer.Audio.Play(My.Resources.useronlinesound, AudioPlayMode.Background)
    End Sub
    Private Sub eran_adr_txt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles eran_adr_txt.Click
        My.Computer.Clipboard.SetText(eran_adr_txt.Text)
        MessageBox.Show("Eran address copied!", "Copy", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub eran_adr_txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles eran_adr_txt.GotFocus
        userlist_viewer.Focus()
    End Sub

    Private Sub eran_adr_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eran_adr_txt.TextChanged
        If eran_adr_txt.Text = "error" Then
        Else
            Control.CheckForIllegalCrossThreadCalls = False
            trd_con = New System.Threading.Thread(AddressOf conn)
            trd_con.IsBackground = True
            trd_con.Start()
            OnlineBallon_tmr.Enabled = True
            'Connect(host, port, eran_adress)
        End If
    End Sub
    Dim cache_rtb As New RichTextBox
    Private audioBT(100000) As Button
    Dim cacheDate(100000) As String
    Dim audioTime(100000) As Double
    Dim timeLabel(100000) As Label
    Dim window As Integer = 0
    Dim audioIndex As Integer = 0
    Dim audioByte As New List(Of Byte())
    ''' <summary>
    ''' Erstellt ein neues Chatfenster oder wenn bereits erstellt wird es geöffnet.
    ''' </summary>
    ''' <param name="eran_adress">Die Eran Adresse vom Absender.</param>
    ''' <param name="username">Der Benutzername vom Absender (wenn vorhanden)</param>
    ''' <param name="get_msg">Die neue Nachricht.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function new_chat(ByVal eran_adress As String, ByVal username As String, Optional ByVal get_msg As String = "")
        Dim bool As Boolean = False

        For tt As Integer = 0 To index
            Try
                If chat_frm(tt).Name = eran_adress Then
                    bool = True
                    window = tt
                    Exit For
                Else
                    bool = False
                End If
            Catch ex As Exception : End Try : Next
        If bool = True Then
            If parameter.read_parameter("/alert ", get_msg) = "1" Then
                chat_frm(window).Text = username

                chat_frm(window).BringToFront()
                chat_frm(window).Show()
                vibrate_frm(chat_frm(window), 3)
            Else
                If parameter.read_parameter("/inAudio ", get_msg).Length > 0 Then
                    Dim Audio As Byte() = Convert.FromBase64String(parameter.read_parameter("/inAudio ", get_msg))
                    audioTime(audioIndex) = Wave.GetDuration(Audio)
                    audioByte.Add(Audio)
                    cacheDate(audioIndex) = "[" & DateTime.Now.ToString("hh:mm:ss") & "] Audio: "
                    AddText(chat_rtb(window), cacheDate(audioIndex) & vbNewLine & vbNewLine, Color.FromArgb(255, 255, 255))

                    Dim TSpan As TimeSpan = TimeSpan.FromMilliseconds(Wave.GetDuration(Audio))


                    Dim str As String = String.Format("{0:00}:{1:00}:{2:00}", TSpan.Minutes, TSpan.Seconds, TSpan.Milliseconds.ToString.Substring(0, 2))
                    timeLabel(audioIndex) = New Label
                    timeLabel(audioIndex).Font = New Font("Arial", 8)
                    timeLabel(audioIndex).AutoSize = True
                    timeLabel(audioIndex).Text = str
                    timeLabel(audioIndex).BackColor = Color.Transparent
                    audioBT(audioIndex) = New Button
                    audioBT(audioIndex).Name = "index" & audioIndex
                    audioBT(audioIndex).FlatStyle = FlatStyle.Flat
                    audioBT(audioIndex).FlatAppearance.BorderSize = 2


                    audioBT(audioIndex).FlatAppearance.BorderColor = Color.FromArgb(104, 197, 240)


                    audioBT(audioIndex).Size = New Size(150, 31)
                    timeLabel(audioIndex).Location = New Point(0, audioBT(audioIndex).Size.Height - 15)
                    audioBT(audioIndex).Cursor = Cursors.Default
                    audioBT(audioIndex).BackgroundImage = My.Resources.play
                    audioBT(audioIndex).BackgroundImageLayout = ImageLayout.Center
                    audioBT(audioIndex).BackColor = Color.Gray
                    audioBT(audioIndex).Location = New Point(chat_rtb(window).GetPositionFromCharIndex(chat_rtb(window).Text.LastIndexOf(cacheDate(audioIndex)) + cacheDate(audioIndex).Length).X, chat_rtb(window).GetPositionFromCharIndex(chat_rtb(window).Text.IndexOf(cacheDate(audioIndex))).Y)
                    audioBT(audioIndex).Controls.Add(timeLabel(audioIndex))

                    
                    
                    ' timeLabel(audioIndex).Location = New Point(5, 20)



                    chat_rtb(window).Controls.Add(audioBT(audioIndex))
                    audioBT(audioIndex).Show()
                    AddHandler chat_rtb(window).VScroll, AddressOf audioscroll
                    AddHandler audioBT(audioIndex).Click, AddressOf audioPlay


                    audioIndex += 1
                Else
                    chat_frm(window).Text = username

                    If get_msg = "" Then
                    Else
                        AddText(cache_rtb, "[" & DateTime.Now.ToString("hh:mm:ss") & "]: " & get_msg, Color.FromArgb(255, 255, 255))
                        chat_rtb(window).AppendText(cache_rtb.Text)
                        cache_rtb.Clear()
                    End If
                    chat_frm(window).Show()
                End If
                
            End If : Else
            chat_frm(index) = New nChat_frm
            chat_frm(index).Name = eran_adress
            chat_frm(index).Text = username
            chat_rtb(index) = New RichTextBox
            chat_rtb(index).BorderStyle = BorderStyle.None
            chat_rtb(index).Name = "richtextbox"
            chat_rtb(index).BackColor = Color.FromArgb(30, 30, 30)
            chat_rtb(index).ForeColor = Color.White
            chat_rtb(index).ReadOnly = True

            chat_rtb(index).Font = New Font("Arial", 10, FontStyle.Regular)
            chat_rtb(index).Location = New Point(92, 27)
            chat_rtb(index).Size = New Size(494, 270)
            chat_rtb(index).Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

            chat_frm(index).Controls.Add(chat_rtb(index))
            chat_frm(index).StartPosition = FormStartPosition.WindowsDefaultLocation

            If parameter.read_parameter("/alert ", get_msg) = "1" Then
                chat_frm(index).Show()
                chat_frm(index).TopMost = True
                If SecureDesktop.isOnSecureDesktop = True Then
                    chat_frm(index).TopMost = True
                End If
                chat_rtb(index).Show()
                vibrate_frm(chat_frm(index), 3)
            Else

                If get_msg.Length > 0 Then
                    AddText(cache_rtb, "[" & DateTime.Now.ToString("hh:mm:ss") & "]: " & get_msg, Color.FromArgb(255, 255, 255))
                    chat_rtb(index).AppendText(cache_rtb.Text)
                    cache_rtb.Clear()
                End If
                chat_frm(index).Show()
                If SecureDesktop.isOnSecureDesktop = True Then
                    chat_frm(index).TopMost = True
                End If : End If
            index += 1
        End If
    End Function
    Public Sub audioPlay(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        My.Computer.Audio.Play(audioByte.Item(btn.Name.Replace("index", "")), AudioPlayMode.Background)
        btn.FlatAppearance.BorderColor = Color.LimeGreen

    End Sub

     
    Sub audioscroll()
        For tt As Integer = 0 To audioIndex - 1
            audioBT(tt).Location = New Point(chat_rtb(window).GetPositionFromCharIndex(chat_rtb(window).Text.LastIndexOf(cacheDate(tt)) + cacheDate(tt).Length).X, chat_rtb(window).GetPositionFromCharIndex(chat_rtb(window).Text.IndexOf(cacheDate(tt))).Y)
        Next

    End Sub

    ''' <summary>
    ''' Es wird ein Vibrate ausgeführt für ein bestimmtes Fenster.
    ''' </summary>
    ''' <param name="frm">Wähle die Form</param>
    ''' <param name="repeat">Wie oft das Fenster vibrieren soll.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Shared Function vibrate_frm(ByVal frm As Form, ByVal repeat As Integer)
        frm.TopMost = True
        For index As Integer = 0 To repeat
            frm.Location = New Point(frm.Location.X - 10, frm.Location.Y)
            System.Threading.Thread.Sleep(30)
            frm.Location = New Point(frm.Location.X, frm.Location.Y - 10)
            System.Threading.Thread.Sleep(30)
            frm.Location = New Point(frm.Location.X + 10, frm.Location.Y)
            System.Threading.Thread.Sleep(30)
            frm.Location = New Point(frm.Location.X, frm.Location.Y + 10)
        Next
        frm.TopMost = False
    End Function

    ''' <summary>
    ''' Ein Text wird Farblich in die RichTextbox eingefügt.
    ''' </summary>
    ''' <param name="rtb">Wähle die RichTextbox aus.</param>
    ''' <param name="txt">Welcher Text soll hinzugefügt werden?</param>
    ''' <param name="col">Wähle die Farbe aus die der Text haben soll.</param>
    ''' <remarks></remarks>
    Private Sub AddText(ByVal rtb As RichTextBox, ByVal txt As String, ByVal col As Color)
        Dim pos As Integer = rtb.TextLength
        rtb.AppendText(txt)
        rtb.[Select](pos, txt.Length)
        rtb.SelectionColor = col
        rtb.[Select]()
        rtb.Select(rtb.TextLength, 1)
    End Sub

    Private Sub userlist_viewer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles userlist_viewer.DoubleClick
        If userlist_viewer.SelectedIndices.Count > 0 Then
            Dim selectedCount As Integer = userlist_viewer.SelectedIndices.Item(0)
            Dim select_adress As String = userlist_viewer.Items(selectedCount).SubItems(1).Text
            Dim select_username As String = userlist_viewer.Items(selectedCount).Text
            new_chat(select_adress, select_username)
        End If
    End Sub
    Private Sub userlist_viewer_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles userlist_viewer.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            userlist_viewer.ContextMenuStrip = user_conextmenu
        End If
    End Sub

    Private Sub user_conextmenu_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosingEventArgs) Handles user_conextmenu.Closing
        userlist_viewer.ContextMenuStrip = Nothing
    End Sub

    Private Sub main_frm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If SecureDesktop.isOnSecureDesktop = False Then
            e.Cancel = True
            Me.WindowState = FormWindowState.Minimized
            Me.Hide()
            NotifyIcon.BalloonTipIcon = ToolTipIcon.None
            NotifyIcon.BalloonTipTitle = Text
            NotifyIcon.BalloonTipText = "Eran is minimized on Taskbar"
            NotifyIcon.ShowBalloonTip(1000)
        Else
            e.Cancel = False
        End If
        'Me.Hide()
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        add_user.ShowDialog()
    End Sub

    Private Sub OfflineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfflineToolStripMenuItem.Click
        set_State(0)
    End Sub
    ''' <summary>
    ''' Sendet an alle Nutzer in der Freundesliste den gestzten Online Status
    ''' </summary>
    ''' <param name="state"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function set_State(ByVal state As Integer)
        Select Case state
            Case 0
                status_strip.Text = "Offline"
                status_strip.Image = My.Resources.offline16
                profil_img.Image = My.Resources.offlineR
                online_state = 0
                NotifyIcon.Text = "Eran - Offline"
                For send_to_usr As Integer = 0 To userlist_viewer.Items.Count - 1
                    Dim adress As String = userlist_viewer.Items(send_to_usr).SubItems(1).Text
                    Send_to_Server("/adress " & eran_adress & "; /to " & adress & "; /state 0; /username " & alias_txt.Text & ";")
                Next
                connected_usr.broke_all_sessions()
            Case 1
                status_strip.Text = "Busy"
                status_strip.Image = My.Resources.busy16
                profil_img.Image = My.Resources.busyR
                online_state = 1
                NotifyIcon.Text = "Eran - Busy"
                For send_to_usr As Integer = 0 To userlist_viewer.Items.Count - 1
                    Dim adress As String = userlist_viewer.Items(send_to_usr).SubItems(1).Text
                    Send_to_Server("/adress " & eran_adress & "; /to " & adress & "; /state 1; /username " & alias_txt.Text & ";")
                Next
            Case 2
                status_strip.Text = "Online"
                status_strip.Image = My.Resources.online16
                profil_img.Image = My.Resources.onlineR
                online_state = 2
                NotifyIcon.Text = "Eran - Online"
                For send_to_usr As Integer = 0 To userlist_viewer.Items.Count - 1
                    Dim adress As String = userlist_viewer.Items(send_to_usr).SubItems(1).Text
                    Send_to_Server("/adress " & eran_adress & "; /to " & adress & "; /state 2; /username " & alias_txt.Text & ";")
                Next
        End Select
    End Function

    Private Sub BusyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusyToolStripMenuItem.Click
        set_State(1)
    End Sub

    Private Sub OnlineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlineToolStripMenuItem.Click
        set_State(2)
    End Sub
    ''' <summary>
    ''' Wenn der Client ein Profilbild gewählt hat wird dieses gesetzt.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub open_file_diag_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles open_file_diag.FileOk
        Dim new_bmp As Bitmap = Bitmap.FromFile(open_file_diag.FileName)
        Dim resize As Bitmap = New Bitmap(new_bmp, New Size(64, 64))
        profil_img.BackgroundImage = resize
        Dim mem_ As New MemoryStream
        resize.Save(mem_, System.Drawing.Imaging.ImageFormat.Png)
        Dim to_bs64 As String = Convert.ToBase64String(mem_.ToArray)
        mem_.Close()
        Dim ini As New IniFile
        ini.Load(account_path)
        ini.SetKeyValue("account", "image", to_bs64)
        ini.Save(account_path)
        Dim img_str As String = to_bs64
        For Each send_img In connected_usr.usr_lst
            Send_to_Server("/adress " & eran_adress & "; /to " & send_img.Eran_adress & "; /profil_image " & img_str & ";")
        Next
    End Sub

    Private Sub OnlineToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlineToolStripMenuItem1.Click
        set_State(2)
    End Sub

    Private Sub BusyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusyToolStripMenuItem1.Click
        set_State(1)
    End Sub

    Private Sub OfflineToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfflineToolStripMenuItem1.Click
        set_State(0)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        NotifyIcon.Visible = False
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub NotifyIcon_BalloonTipClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon.BalloonTipClicked
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub
    ''' <summary>
    ''' Öffnet das Dialog um ein neues Profilbild festzulegen.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub profil_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profil_img.Click
        If SecureDesktop.isOnSecureDesktop = True Then : Else
            open_file_diag.ShowDialog()
        End If
    End Sub
    ''' <summary>
    ''' Einen Benutzer von der Liste löschen.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DeleteFromListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFromListToolStripMenuItem.Click
        If MessageBox.Show("Do you want to delete this contact?", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim usr_name As String = userlist_viewer.SelectedItems(0).Text
            Dim ini As New IniFile
            Dim read_enc_bytes As Byte() = File.ReadAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini")
            Dim dec_trg_byte As Byte()
            aes_.Decode(read_enc_bytes, dec_trg_byte, login.pwd, AESEncrypt.ALGO.RIJNDAEL, 4096)
            Dim mem_ As New MemoryStream(dec_trg_byte)
            ini.LoadFromMemory(mem_)
            ini.RemoveSection(usr_name)
            userlist_viewer.SelectedItems(0).Remove()
            Dim save_ini_byt As Byte()
            save_ini_byt = ini.SavetoByte
            Dim targed_enc_byt As Byte()
            aes_.Encode(save_ini_byt, targed_enc_byt, login.pwd, AESEncrypt.ALGO.RIJNDAEL, 4096)
            File.WriteAllBytes(users_lst_path, targed_enc_byt)
        Else : End If
    End Sub
    Private Sub StartChatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartChatToolStripMenuItem.Click
        If userlist_viewer.SelectedIndices.Count > 0 Then
            Dim selectedCount As Integer = userlist_viewer.SelectedIndices.Item(0)
            Dim select_adress As String = userlist_viewer.Items(selectedCount).SubItems(1).Text
            Dim select_username As String = userlist_viewer.Items(selectedCount).Text
            new_chat(select_adress, select_username)
        End If
    End Sub

    Private Sub CopyEranAdressToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyEranAdressToolStripMenuItem.Click
        Dim eran As String = userlist_viewer.SelectedItems(0).SubItems(1).Text.ToString
        My.Computer.Clipboard.SetText(eran)
        MessageBox.Show("Eran adress copied!", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog.FileOk
        File.WriteAllBytes(SaveFileDialog.FileName, enc_file_byt_target)
        enc_file_byt_target = Nothing
        GC_.FlushMemory()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        settings.ShowDialog()
    End Sub
    ''' <summary>
    ''' Sendet eine Ping anfrage zum Server
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SendPingToConnectedAccesNodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendPingToConnectedAccesNodeToolStripMenuItem.Click
        Send_to_Server("/adress " & eran_adress & "; /to server; /ping ping;")
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        If SecureDesktop.isOnSecureDesktop = False Then
            NotifyIcon.Visible = False
            Process.GetCurrentProcess.Kill()
        Else
            Me.WindowState = FormWindowState.Minimized
            Me.Hide()
        End If
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles alias_txt.GotFocus
        alias_txt.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles alias_txt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            userlist_viewer.Focus()
            For Each tt As ListViewItem In userlist_viewer.Items
                main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & tt.SubItems(1).Text & "; /username " & alias_txt.Text & ";")
            Next
            Dim ini As New IniFile
            ini.Load(account_path)
            ini.SetKeyValue("account", "alias", alias_txt.Text)
            ini.Save(account_path)
        End If
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles alias_txt.LostFocus
        alias_txt.BackColor = Color.FromArgb(45, 45, 45)
        If alias_txt.Text = "" Then
            alias_txt.Text = login.username
        End If
    End Sub

    Private Sub EditUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditUserToolStripMenuItem.Click
        userlist_viewer.LabelEdit = True
    End Sub
    ''' <summary>
    ''' Sendet an den Server das der Client noch Aktiv ist damit die Verbindung nicht in den Sleep modus geht.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub available_timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles available_timer.Tick
        Send_to_Server("available")
    End Sub

    Private Sub OnlineBallon_tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlineBallon_tmr.Tick
        OnlineBallon = True
        OnlineBallon_tmr.Enabled = False
    End Sub
    Private Sub status_strip_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles status_strip.ButtonClick
        Select Case online_state
            Case 0
                set_State(1)
            Case 1
                set_State(2)
            Case 2
                set_State(1)
        End Select
    End Sub
    Sub Connect()
        'userlist_viewer.Items.Clear()
        Control.CheckForIllegalCrossThreadCalls = False
        trd_con = New System.Threading.Thread(AddressOf conn)
        trd_con.IsBackground = True
        trd_con.Start()
        OnlineBallon_tmr.Enabled = True
    End Sub
    Sub Disconnect()
        isEncrypted_Server = False
        handshake = 0
        trd_con.Abort()
        client.Close()
        stream.Close()
        streamr.Close()
        streamw.Close()
        t.Abort()
        OnlineBallon = False
    End Sub
    Private Sub DisconnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectToolStripMenuItem.Click
        userlist_viewer.Items.Clear()
        DisconnectFromUser = True
        Disconnect()
    End Sub

    Private Sub ShowPublicKeyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowPublicKeyToolStripMenuItem.Click
        MessageBox.Show("Public Key: " & vbNewLine & PublicKey, "Public Key", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub ShowServerKeyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowServerKeyToolStripMenuItem.Click
        MessageBox.Show("Hash: " & rHash.HashString(Server_key, rHash.HASH.MD5), "Server Key", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub
End Class
