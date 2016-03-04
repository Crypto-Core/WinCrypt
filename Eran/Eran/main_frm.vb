Imports System.Net.Sockets
Imports System.IO

Public Class main_frm
    Private stream As NetworkStream
    Friend Shared streamw As StreamWriter
    Private streamr As StreamReader
    Private client As New TcpClient
    Private t As New Threading.Thread(AddressOf Listen)
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
    Friend Shared account_path As String = My.Application.Info.DirectoryPath & "\account.ini"
    Friend Shared users_lst_path As String = My.Application.Info.DirectoryPath & "\userlist.ini"
    Friend Shared profilimage_ As String = ""
    Private chat_frm(10000) As Form
    Private chat_rtb(10000) As RichTextBox
    Private index As Integer = 0
    Private enc_file_byt_target As Byte()
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

            'Deklariere Parameter für wen die Nachricht ist (Empfänger).
            Dim to_ As String = parameter.read_parameter("/to ", decrypted_to_str)
            Dim all As String = parameter.read_parameter("/all ", decrypted_to_str)

            If all.Length > 0 Then
                Dim send_state As String = parameter.read_parameter("/state ", decrypted_to_str)
                If send_state.Length > 0 Then
                    For remove As Integer = 0 To connected_usr.usr_lst.Count - 1
                        Try
                            If all = connected_usr.usr_lst.Item(remove).Eran_adress Then
                                connected_usr.usr_lst.RemoveRange(remove, remove + 1)
                            End If
                        Catch ex As Exception

                        End Try
                    Next
                    For set_usr_state As Integer = 0 To userlist_viewer.Items.Count - 1
                        If userlist_viewer.Items(set_usr_state).SubItems(1).Text = all Then
                            userlist_viewer.Items(set_usr_state).ImageIndex = Int(send_state)
                        End If
                    Next
                End If
            End If

            'Überprüfen ob die Nachricht für mich ist ---------------------------------------->
            If to_ = eran_adress Then

                'Inhalt abarbeiten
                Dim ping As String = parameter.read_parameter("/ping ", decrypted_to_str) ' Deklariere den Parameter Ping
                Dim state As String = parameter.read_parameter("/get_state ", decrypted_to_str)
                Dim adress_ As String = parameter.read_parameter("/adress ", decrypted_to_str) 'Deklariere den Parameter Absender
                Dim get_publickey As String = parameter.read_parameter("/get_publickey ", decrypted_to_str) 'Deklariere den Parameter get_PublicKey
                Dim publickey_ As String = parameter.read_parameter("/publickey ", decrypted_to_str)
                Dim handshake As String = parameter.read_parameter("/handshake ", decrypted_to_str) 'Deklariere den Parameter PublicKey
                Dim msg As String = parameter.read_parameter("/msg ", decrypted_to_str) 'Deklariere den Parameter Message
                Dim username As String = parameter.read_parameter("/username ", decrypted_to_str) 'Deklariere den Parameter Username
                Dim send_state As String = parameter.read_parameter("/state ", decrypted_to_str) 'Send state status
                Dim get_state As String = parameter.read_parameter("/get_state ", decrypted_to_str)
                Dim profilimage As String = parameter.read_parameter("/profil_image ", decrypted_to_str)
                Dim encrypted_key As String = parameter.read_parameter("/encrypted_key ", decrypted_to_str)
                Dim get_profilimage As String = parameter.read_parameter("/get_profil_img ", decrypted_to_str)

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
                        End If


                    Else
                        new_chat(adress_, adress_, msg)
                    End If


                End If


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


                                SaveFileDialog1.FileName = System.Text.UTF8Encoding.UTF8.GetChars(enc_filename_byt_target)
                                SaveFileDialog1.ShowDialog()



                            End If
                        Else
                            GC_.FlushMemory()
                        End If

                    End If
                End If





                'Sende meinen OnlineStatus
                If get_state = "True" Then
                    Send_to_Server("/adress " & eran_adress & "; /to " & adress_ & "; " & "/state " & online_state & ";")
                End If


                'Empfange einen OnlineStatus und überprüfe ihn mit meiner Liste
                If send_state.Length > 0 Then
                    For set_usr_state As Integer = 0 To userlist_viewer.Items.Count - 1
                        If userlist_viewer.Items(set_usr_state).SubItems(1).Text = adress_ Then
                            userlist_viewer.Items(set_usr_state).ImageIndex = Int(send_state)
                        End If
                    Next
                End If

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
                    End Select
                End If


            End If
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
                    load_userlist()
                    set_State(2)
                End If
            End If
            GC_.FlushMemory()
        End If
    End Sub
    Friend Function is_in_usrlst(ByVal eran_adress As String) As String
        For Each Item As ListViewItem In userlist_viewer.Items
            If eran_adress = Item.SubItems(1).Text Then
                Return Item.Text
                End
            End If
        Next
        Return ""
    End Function
    Public Shared Sub alert()

        My.Computer.Audio.Play(My.Resources.alert, AudioPlayMode.Background)
    End Sub

    Private Sub Listen()
        While client.Connected
            Try
                Invoke(New DAddItem(AddressOf AddItem), Base64.FromBase64Str_to_decodeBytes(streamr.ReadLine))
            Catch ex As Exception
                
                MessageBox.Show("Connection to Server Lost." & vbNewLine & "Eran has to be restarted!", "Connection Lost!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Process.GetCurrentProcess.Kill()
                Exit While

            End Try
        End While
    End Sub
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

    Friend Shared Function load_userlist()
        If File.Exists(My.Application.Info.DirectoryPath & "\userlist.ini") = True Then
            Dim ini As New IniFile

            Dim read_ini_bytes As Byte() = File.ReadAllBytes(My.Application.Info.DirectoryPath & "\userlist.ini")

            Dim target_enc As Byte()

            aes_.Decode(read_ini_bytes, target_enc, login.pwd, AESEncrypt.ALGO.RIJNDAEL, 4096)

            Dim ini_mem As New MemoryStream(target_enc)

            ini.LoadFromMemory(ini_mem)

            'ini.Load(My.Application.Info.DirectoryPath & "\userlist.ini")
            For Each s As IniFile.IniSection In ini.Sections
                For Each k As IniFile.IniSection.IniKey In s.Keys
                    With main_frm.userlist_viewer.Items.Add(s.Name, 0)
                        .SubItems.Add(k.Value)
                    End With
                Next
            Next

            For check_State As Integer = 0 To main_frm.userlist_viewer.Items.Count - 1
                Send_to_Server("/adress " & eran_adress & "; /to " & main_frm.userlist_viewer.Items(check_State).SubItems(1).Text & "; /get_state True;")
            Next
        Else

        End If
    End Function
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
    End Sub
    Private Function Connect(ByVal host As String, ByVal port As Integer, ByVal eran_adress As String)
        Dim createRSA_Keys = RSA.Create_RSA_Key
        PublicKey = createRSA_Keys.OpenKey
        PrivateKey = createRSA_Keys.PrivatKey
        Try
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
                t.Start()
                main_panel.Show()
                connect_frame.Panel1.Hide()
            Else
                MessageBox.Show("Verbindung zum Server nicht möglich!2")
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show("Access node offline!", "Connection fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            eran_adr_txt.Text = "error"
            connect_frame.Panel1.Hide()
            main_panel.Hide()
            login.login_panel.Show()
        End Try
    End Function

    Private Sub eran_adr_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eran_adr_txt.TextChanged
        If eran_adr_txt.Text = "error" Then
        Else
            Connect(host, port, eran_adress)
        End If
    End Sub
    
    Dim cache_rtb As New RichTextBox
    Private Function new_chat(ByVal eran_adress As String, ByVal username As String, Optional ByVal get_msg As String = "")

        Dim bool As Boolean = False
        Dim window As Integer = 0
        For tt As Integer = 0 To index
            Try
                If chat_frm(tt).Name = eran_adress Then
                    bool = True
                    window = tt
                    Exit For
                Else
                    bool = False
                End If
            Catch ex As Exception

            End Try
        Next
        
        If bool = True Then

            If parameter.read_parameter("/alert ", get_msg) = "1" Then
                chat_frm(window).Show()
                chat_frm(window).BringToFront()
                vibrate_frm(chat_frm(window), 3)
            Else
                chat_frm(window).Show()

                If get_msg = "" Then
                Else
                    AddText(cache_rtb, "[" & DateTime.Now.ToString("hh:mm:ss") & "]: " & get_msg, Color.FromArgb(255, 255, 255))
                    chat_rtb(window).AppendText(cache_rtb.Text)
                    cache_rtb.Clear()
                End If
            End If
            

        Else
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
            chat_rtb(index).Show()
            chat_frm(index).Controls.Add(chat_rtb(index))
            


            chat_frm(index).StartPosition = FormStartPosition.WindowsDefaultLocation
            If parameter.read_parameter("/alert ", get_msg) = "1" Then
                chat_frm(index).Show()
                chat_frm(index).TopMost = True
                If SecureDesktop.isOnSecureDesktop = True Then
                    chat_frm(index).TopMost = True
                End If
                chat_frm(index).BringToFront()
                vibrate_frm(chat_frm(index), 3)
            Else
                If get_msg.Length > 0 Then
                    'chat_rtb(index).AppendText(get_msg)
                    AddText(cache_rtb, "[" & DateTime.Now.ToString("hh:mm:ss") & "]: " & get_msg, Color.FromArgb(255, 255, 255))
                    chat_rtb(index).AppendText(cache_rtb.Text)
                    cache_rtb.Clear()
                End If
                chat_frm(index).Show()
                If SecureDesktop.isOnSecureDesktop = True Then
                    chat_frm(index).TopMost = True
                End If
            End If

            index += 1

        End If
        ' new_chat(userlist_viewer.Items(select_count).SubItems(1).Text, userlist_viewer.Items(select_count).Text)
    End Function
    Friend Shared Function vibrate_frm(ByVal frm As Form, ByVal repeat As Integer)
        For index As Integer = 0 To repeat
            frm.Location = New Point(frm.Location.X - 10, frm.Location.Y)
            System.Threading.Thread.Sleep(30)
            frm.Location = New Point(frm.Location.X, frm.Location.Y - 10)
            System.Threading.Thread.Sleep(30)
            frm.Location = New Point(frm.Location.X + 10, frm.Location.Y)
            System.Threading.Thread.Sleep(30)
            frm.Location = New Point(frm.Location.X, frm.Location.Y + 10)
        Next
    End Function
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
        
        'e.Cancel = True
        'Me.WindowState = FormWindowState.Minimized
        'Me.Hide()
    End Sub

    Private Sub SendToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendToolStripMenuItem.Click
        Send_to_Server("/adress " & eran_adress & "; /to server; /ping ping;")
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        add_user.ShowDialog()
    End Sub

    Private Sub OfflineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfflineToolStripMenuItem.Click
        set_State(0)
    End Sub

    Friend Function set_State(ByVal state As Integer)
        Select Case state
            Case 0
                status_strip.Text = "Offline"
                status_strip.Image = My.Resources.offline16
                online_state = 0
                NotifyIcon.Text = "Eran - Offline"
                For send_to_usr As Integer = 0 To userlist_viewer.Items.Count - 1
                    Dim adress As String = userlist_viewer.Items(send_to_usr).SubItems(1).Text
                    Send_to_Server("/adress " & eran_adress & "; /to " & adress & "; /state 0;")
                Next
                connected_usr.broke_all_sessions()
            Case 1
                status_strip.Text = "Busy"
                status_strip.Image = My.Resources.busy16
                online_state = 1
                NotifyIcon.Text = "Eran - Busy"
                For send_to_usr As Integer = 0 To userlist_viewer.Items.Count - 1
                    Dim adress As String = userlist_viewer.Items(send_to_usr).SubItems(1).Text
                    Send_to_Server("/adress " & eran_adress & "; /to " & adress & "; /state 1;")
                Next
            Case 2
                status_strip.Text = "Online"
                status_strip.Image = My.Resources.online16
                online_state = 2
                NotifyIcon.Text = "Eran - Online"
                For send_to_usr As Integer = 0 To userlist_viewer.Items.Count - 1
                    Dim adress As String = userlist_viewer.Items(send_to_usr).SubItems(1).Text
                    Send_to_Server("/adress " & eran_adress & "; /to " & adress & "; /state 2;")
                Next
        End Select
    End Function

    Private Sub BusyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusyToolStripMenuItem.Click
        set_State(1)
    End Sub

    Private Sub OnlineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlineToolStripMenuItem.Click
        set_State(2)
    End Sub

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

    Private Sub NotifyIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub profil_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profil_img.Click
        If SecureDesktop.isOnSecureDesktop = True Then

        Else
            open_file_diag.ShowDialog()
        End If
    End Sub

    Private Sub GetImgToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetImgToolStripMenuItem.Click
        MsgBox(SecureDesktop.isOnSecureDesktop)
    End Sub

    Private Sub DeleteFromListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFromListToolStripMenuItem.Click
        If MessageBox.Show("Do you want to delete this contact?", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim selected_count As Integer = userlist_viewer.SelectedIndices.Item(0).ToString
            Dim usr_name As String = userlist_viewer.Items(selected_count).Text
            Dim adress As String = userlist_viewer.Items(selected_count).SubItems(1).Text
            Dim ini As New IniFile
            Dim read_enc_bytes As Byte() = File.ReadAllBytes(My.Application.Info.DirectoryPath & "\userlist.ini")
            Dim dec_trg_byte As Byte()

            aes_.Encode(read_enc_bytes, dec_trg_byte, login.pwd, AESEncrypt.ALGO.RIJNDAEL, 4096)
            Dim mem_ As New MemoryStream(dec_trg_byte)
            ini.LoadFromMemory(mem_)
            ini.RemoveSection(usr_name)
            userlist_viewer.Items(selected_count).Remove()
            Dim save_ini_byt As Byte()
            save_ini_byt = ini.SavetoByte
            Dim targed_enc_byt As Byte()

            aes_.Encode(save_ini_byt, targed_enc_byt, login.pwd, AESEncrypt.ALGO.RIJNDAEL, 4096)
            File.WriteAllBytes(users_lst_path, targed_enc_byt)
        Else

        End If
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
        Dim selected_count As Integer = userlist_viewer.SelectedIndices.Item(0)
        My.Computer.Clipboard.SetText(userlist_viewer.SelectedItems(selected_count).SubItems(1).Text)
        MessageBox.Show("Eran adress copied!", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        File.WriteAllBytes(SaveFileDialog1.FileName, enc_file_byt_target)
        enc_file_byt_target = Nothing
        GC_.FlushMemory()
    End Sub
End Class
