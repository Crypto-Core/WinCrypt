
Imports System.IO

Public Class nChat_frm
    Dim encrypted As Boolean = False
    Dim key As String
    Dim aes_ As New AESEncrypt
    Dim Timeout As Integer = 3
    Private audioBT(100000) As Button
    Dim cacheDate(100000) As String
    Dim audioTime(100000) As Double
    Dim timeLabel(100000) As Label
    Dim PlayTimer(100000) As Timer
    Dim PlayPGB(100000) As ProgressBar
    Dim window As Integer = 0
    Dim audioIndex As Integer = 0
    Dim audioByte As New List(Of Byte())

    Private Sub nChat_frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        loadLang()
    End Sub

    Private Sub nChat_frm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next
        e.Cancel = True
        Me.WindowState = FormWindowState.Minimized
        Me.Hide()
    End Sub

    Private Sub message_box_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles message_box.KeyDown
        If message_box.TextLength = 0 Then : Else
            Dim rtb = Me.Controls.Find("richtextbox", True)
            If e.KeyData = Keys.Enter Then
                If encrypted Then
                    Dim getbytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(message_box.Text)
                    Dim target As Byte()
                    aes_.Encode(getbytes, target, key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                    Dim to_bs64 As String = Convert.ToBase64String(target)
                    main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /msg " & to_bs64 & ";")
                    If rtb(0).Text.Length < 2 Then
                        AddText(CType(rtb(0), RichTextBox), "(me)[" & DateTime.Now.ToString("hh:mm:ss") & "]: " & message_box.Text & vbNewLine, Color.FromArgb(104, 197, 240))
                    Else
                        AddText(CType(rtb(0), RichTextBox), "(me)[" & DateTime.Now.ToString("hh:mm:ss") & "]: " & message_box.Text & vbNewLine, Color.FromArgb(104, 197, 240))
                    End If
                Else
                    Dim read_bytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(message_box.Text)
                    Dim to_bs64_str As String = Convert.ToBase64String(read_bytes)
                    main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /msg " & to_bs64_str & ";")
                End If
            End If
        End If
    End Sub
    Private Sub AddText(ByVal rtb As RichTextBox, ByVal txt As String, ByVal col As Color)
        On Error Resume Next
        Dim pos As Integer = rtb.TextLength
        rtb.AppendText(txt)
        rtb.[Select](pos, txt.Length)
        rtb.SelectionColor = col
        rtb.[Select]()
        rtb.Select(rtb.TextLength, 1)
        message_box.Focus()
    End Sub
    Dim enc As Integer = 0
    ''' <summary>
    ''' Es wird der Status der Verschlüsselung überprüft und ob diese noch verhanden ist.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub encrypt_state_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles encrypt_state.Tick
        If connected_usr.isConnect_Encrypt(Name) Then
            lock_bt.Image = My.Resources.lock16
            lock_bt.Text = "Encrypted"
            lock_bt.Enabled = True
            message_box.Enabled = True
            encrypted = True
            If SecureDesktop.isOnSecureDesktop Then
                sendfile_bt.Enabled = False
            Else
                If main_frm.sendFileState = True Then
                    sendfile_bt.Enabled = False
                Else
                    sendfile_bt.Enabled = True
                End If
            End If
            get_key()
            message_box.BackColor = Color.FromArgb(30, 30, 30)
            encrypt_state.Interval = 2000
            If enc = 0 Then
                alert_bt.Enabled = True
                AddText(rtb_, "[Chat encrypted!]" & vbNewLine, Color.Lime)
            End If
            enc = 1
            If reEncrypt.Enabled Then
                reEncrypt.Enabled = False
                Timeout = 3
            End If
        Else
            lock_bt.Image = My.Resources.unlock16
            message_box.Enabled = False
            message_box.BackColor = Color.FromArgb(106, 106, 106)
            If main_frm.sendFileState = True Then
                sendfile_bt.Enabled = False
            Else
                sendfile_bt.Enabled = False
            End If
            encrypted = False
            If key = "" Then : Else
                AddText(rtb_, "[Encryption brocken!]" & vbNewLine, Color.Red)
            End If
            key = ""
            lock_bt.Enabled = True
            lock_bt.Text = "New Encrypt session"
        End If
    End Sub
    Private Sub lock_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lock_bt.Click
        encrypt_state.Enabled = True
        If encrypted Then
            Dim msgEncStr As String = "Handshake with: RSA 2048bit" & vbNewLine & "Chat Encryption: AES 256bit" & vbNewLine & "SHA1: {0}"
            If language.ini.GetKeyValue("nChat_frm", "EncryptMSG") = Nothing Then : Else
                msgEncStr = language.ini.GetKeyValue("nChat_frm", "EncryptMSG")
            End If
            MessageBox.Show(String.Format(msgEncStr, rHash.HashString(key, rHash.HASH.SHA1)), "Key", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            AddText(rtb_, "[Send Handshake]" & vbNewLine, Color.Yellow)
            main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /handshake 0;")
            encrypt_state.Enabled = True
        End If
    End Sub
    Sub get_key()
        For Each tt In connected_usr.usr_lst
            If tt.Eran_adress = Name Then
                key = tt.Key
            End If
        Next
    End Sub
    Friend Function is_in_usrlst(ByVal eran_adress As String) As Boolean
        If File.Exists(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini") Then
            Dim ini As New IniFile
            Dim read_enc_bytes As Byte() = File.ReadAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini")
            Dim dec_trg_byte As Byte()
            aes_.Decode(read_enc_bytes, dec_trg_byte, login.pwd, AESEncrypt.ALGO.RIJNDAEL, 4096)
            Dim mem_ As New MemoryStream(dec_trg_byte)
            ini.LoadFromMemory(mem_)
            For Each s As IniFile.IniSection In ini.Sections
                For Each k As IniFile.IniSection.IniKey In s.Keys
                    If Me.Name = k.Value Then
                        Return True
                        End
                    Else : End If
                Next : Next : Else : End If
        Return False
    End Function
    Private WithEvents rtb_ As RichTextBox
    Public WithEvents main_img As PictureBox = main_frm.profil_img
    Sub loadLang()
        UserToolStripMenuItem.Text = language.ini.GetKeyValue("nChat_frm", "UserToolStripMenuItem")
        BlockingToolStripMenuItem.Text = language.ini.GetKeyValue("nChat_frm", "BlockingToolStripMenuItem")
        OptionsToolStripMenuItem.Text = language.ini.GetKeyValue("nChat_frm", "OptionsToolStripMenuItem")
        RenewEncryptionToolStripMenuItem.Text = language.ini.GetKeyValue("nChat_frm", "RenewEncryptionToolStripMenuItem")
        ClearChatToolStripMenuItem1.Text = language.ini.GetKeyValue("nChat_frm", "ClearChatToolStripMenuItem1")
        ClearChatToolStripMenuItem.Text = language.ini.GetKeyValue("nChat_frm", "ClearChatToolStripMenuItem")
        sendfile_bt.Text = language.ini.GetKeyValue("nChat_frm", "sendfile_bt")
        alert_bt.Text = language.ini.GetKeyValue("nChat_frm", "alert_bt")
    End Sub
    Private Sub nChat_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadLang()
        If SecureDesktop.isOnSecureDesktop Then
            sendfile_bt.Enabled = False
        End If
        Dim rtb = Me.Controls.Find("richtextbox", True)
        rtb_ = CType(rtb(0), RichTextBox)
        rtb_.ContextMenuStrip = Contextmenu
        profil_img.BackgroundImage = main_frm.profil_img.BackgroundImage
        ActiveControl = message_box
        AddHandler rtb_.TextChanged, AddressOf scrolldown
        If connected_usr.isConnect_Encrypt(Name) = False Then
            main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /handshake 0;")
        End If
        main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /get_profil_img 1;")
        If is_in_usrlst(Name) Then
            addusr_bt.Visible = False
        Else
            addusr_bt.Visible = True
        End If
    End Sub
    Sub scrolldown()
        rtb_.ScrollToCaret()
    End Sub
    Private Sub check_profil_img_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_profil_img.Tick
        If main_frm.profilimage_.Length > 0 Then
            Dim check As String = parameter.read_parameter("/to ", main_frm.profilimage_)
            If check = Name Then
                check_profil_img.Enabled = False
                Dim to_byte As Byte() = Convert.FromBase64String(parameter.read_parameter("/get_profil_img ", main_frm.profilimage_))
                Dim new_stream As New MemoryStream(to_byte)
                Dim i As Image = Image.FromStream(new_stream)
                partner_img.BackgroundImage = i
                main_frm.profilimage_ = ""
                check_profil_img.Enabled = True
            End If
        End If
    End Sub

    Private Sub check_onlinestate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_onlinestate.Tick
        If main_frm.blocklist.Exists(Function(x) x = Name) Then
            BlockingToolStripMenuItem.Text = "Unblock"
        Else
            BlockingToolStripMenuItem.Text = "Blocking"
        End If
        For check As Integer = 0 To main_frm.userlist_viewer.Items.Count - 1
            If main_frm.userlist_viewer.Items(check).SubItems(1).Text = Name Then
                Select Case main_frm.userlist_viewer.Items(check).ImageIndex
                    Case 0
                        partner_img.Image = My.Resources.offlineR
                    Case 1
                        partner_img.Image = My.Resources.busyR
                    Case 2
                        partner_img.Image = My.Resources.onlineR
                    Case 3
                        partner_img.BackgroundImage = My.Resources.blockprofil
                        partner_img.Image = My.Resources.busyR
                End Select
            End If
        Next
        Select Case main_frm.online_state
            Case 0
                profil_img.Image = My.Resources.offlineR
            Case 1
                profil_img.Image = My.Resources.busyR
            Case 2
                profil_img.Image = My.Resources.onlineR
        End Select
    End Sub

    Private Sub rtb__GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_.GotFocus
        message_box.Focus()
    End Sub

    Private Sub message_box_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles message_box.KeyUp
        If e.Shift Then
            If e.KeyCode = Keys.Enter Then
            End If
        Else
            If e.KeyCode = Keys.Enter Then
                message_box.Clear()
            End If : End If
    End Sub

    Private Sub alert_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alert_bt.Click
        alert_bt.Enabled = False
        alertCountdown.Enabled = True
        If encrypted Then
            Dim getbytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes("/alert 1;")
            Dim target As Byte()
            aes_.Encode(getbytes, target, key, AESEncrypt.ALGO.RIJNDAEL, 4096)
            Dim to_bs64 As String = Convert.ToBase64String(target)
            main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /msg " & to_bs64 & ";")
        Else
            Dim read_bytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes("/alert 1;")
            Dim to_bs64_str As String = Convert.ToBase64String(read_bytes)
            main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /msg " & to_bs64_str & ";")
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /get_profil_img 1;")
    End Sub

    Private Sub main_img_BackgroundImageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles main_img.BackgroundImageChanged
        profil_img.BackgroundImage = main_frm.profil_img.BackgroundImage
    End Sub

    Private Sub nChat_frm_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        backgroundSecure.SendToBack()
    End Sub

    Private Sub addusr_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addusr_bt.Click
        If encrypted Then
            main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /get_username 1;")
        Else
            main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /get_username 1;")
        End If
        addusr_bt.Visible = False
    End Sub

    Private Sub sendfile_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendfile_bt.Click
        If SecureDesktop.isOnSecureDesktop Then
            FileDialog_.TopMost = True
            FileDialog_.ShowDialog()

            If FileDialog_.FileSelected Then
                If File.Exists(FileDialog_.FilePath) Then
                    main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /accept_trans 0;")
                    main_frm.transKey = key
                    main_frm.transFile = FileDialog_.FilePath
                End If
            End If
        Else
            If send_file_dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /accept_trans 0;")
                main_frm.transKey = key
                main_frm.transFile = send_file_dialog.FileName
            End If
        End If


       
    End Sub

    Private Sub ClearChatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearChatToolStripMenuItem.Click
        rtb_.Clear()
        rtb_.Controls.Clear()
    End Sub
    Private Sub GetUsernameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /username " & main_frm.alias_txt.Text & ";")
    End Sub
    Dim alertindex As Integer = 10
    Private Sub alertCountdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alertCountdown.Tick
        alertindex -= 1
        If alertindex = 0 Then
            alert_bt.Enabled = True
            alertCountdown.Enabled = False
            alertindex = 30
        End If
    End Sub

    Private Sub profil_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profil_img.Click
        If SecureDesktop.isOnSecureDesktop Then
            FileDialog_.TopMost = True
            FileDialog_.ShowDialog()
            If File.Exists(FileDialog_.FilePath) Then
                If FileDialog_.FileSelected Then
                    Dim new_bmp As Bitmap = CType(Bitmap.FromFile(FileDialog_.FilePath), Bitmap)
                    Dim resize As Bitmap = New Bitmap(new_bmp, New Size(64, 64))
                    profil_img.BackgroundImage = resize
                    Dim mem_ As New MemoryStream
                    resize.Save(mem_, System.Drawing.Imaging.ImageFormat.Png)
                    Dim to_bs64 As String = Convert.ToBase64String(mem_.ToArray)
                    mem_.Close()
                    Dim ini As New IniFile
                    ini.Load(main_frm.account_path)
                    ini.SetKeyValue("account", "image", to_bs64)
                    ini.Save(main_frm.account_path)
                    Dim img_str As String = to_bs64
                    For Each send_img In connected_usr.usr_lst
                        main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & send_img.Eran_adress & "; /profil_image " & img_str & ";")
                    Next
                End If
            End If
        Else
            main_frm.open_file_diag.ShowDialog()
        End If
    End Sub

    Private Sub RenewEncryptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenewEncryptionToolStripMenuItem.Click
        AddText(rtb_, "[Renew encryption]" & vbNewLine, Color.Yellow)
        connected_usr.remove_encrypt_session(Name)
        AddText(rtb_, "[Send Handshake]" & vbNewLine, Color.Yellow)
        main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /handshake 0;")
        AddText(rtb_, "[Handshake successful]" & vbNewLine, Color.Lime)
    End Sub

    Dim recTime As Integer = 0
    Private Sub recTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recTimer.Tick
        recTime += 1
        recAudio.Text = recTime & " sec."
    End Sub

    Private Sub recAudio_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles recAudio.MouseDown
        recAudio.Image = My.Resources.rec_now
        recTimer.Enabled = True
        recAudio.Text = recTime & " sec."
        record.start_record()
    End Sub

    Private Sub recAudio_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles recAudio.MouseUp
        recAudio.Image = My.Resources.rec1
        recTimer.Enabled = False
        recTime = 0
        recAudio.Text = Nothing
        record.save_record(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & OS.OS_slash & "rec.wav")
        Dim readRecByte As Byte() = File.ReadAllBytes(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & OS.OS_slash & "rec.wav")
        Dim getbytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes("/" & System.Text.UTF8Encoding.UTF8.GetChars({200, 5, 255, 80, 208, 156}) & Convert.ToBase64String(readRecByte) & ";")
        Dim target As Byte()
        aes_.Encode(getbytes, target, key, AESEncrypt.ALGO.RIJNDAEL, 4096)
        Dim to_bs64 As String = Convert.ToBase64String(target)
        audioTime(audioIndex) = Wave.GetDuration(readRecByte)
        audioByte.Add(readRecByte)
        cacheDate(audioIndex) = "(me)(" & DateTime.Now.ToString("hh:mm:ss") & ") Audio: "
        AddText(rtb_, cacheDate(audioIndex) & vbNewLine & vbNewLine, Color.FromArgb(104, 197, 240))
        Dim TSpan As TimeSpan = TimeSpan.FromMilliseconds(Wave.GetDuration(readRecByte))
        Dim Playseconds As Decimal = Math.Round(CDec(TSpan.Milliseconds / 1000) + TSpan.Seconds + TSpan.Minutes * 60 + TSpan.Hours * 3600)
        audioBT(audioIndex) = New Button
        audioBT(audioIndex).Name = "index" & audioIndex
        audioBT(audioIndex).FlatStyle = FlatStyle.Flat
        audioBT(audioIndex).FlatAppearance.BorderSize = 1
        PlayPGB(audioIndex) = New ProgressBar
        PlayPGB(audioIndex).Name = "pgr" & audioIndex
        PlayPGB(audioIndex).Maximum = CInt(Playseconds)
        PlayPGB(audioIndex).Size = New Size(120, 10)
        PlayPGB(audioIndex).Location = New Point(27, CInt((audioBT(audioIndex).Size.Height / 2) - PlayPGB(audioIndex).Size.Height / 2))
        PlayPGB(audioIndex).SendToBack()
        Dim str As String = String.Format("{0:00}:{1:00}:{2:00}", TSpan.Minutes, TSpan.Seconds, TSpan.Milliseconds.ToString.Substring(0, 2))
        timeLabel(audioIndex) = New Label
        timeLabel(audioIndex).Font = New Font("Arial", 8)
        timeLabel(audioIndex).AutoSize = True
        timeLabel(audioIndex).Text = str
        timeLabel(audioIndex).BackColor = Color.Transparent
        timeLabel(audioIndex).BringToFront()
        PlayTimer(audioIndex) = New Timer
        PlayTimer(audioIndex).Tag = "index" & audioIndex
        PlayTimer(audioIndex).Interval = 1000
        AddHandler PlayTimer(audioIndex).Tick, AddressOf PlayTick
        audioBT(audioIndex).FlatAppearance.BorderColor = Color.FromArgb(104, 197, 240)
        audioBT(audioIndex).Size = New Size(150, 31)
        timeLabel(audioIndex).Location = New Point(CInt(audioBT(audioIndex).Size.Width / 2 - timeLabel(audioIndex).Size.Width / 2), audioBT(audioIndex).Size.Height - 15)
        audioBT(audioIndex).Cursor = Cursors.Default
        audioBT(audioIndex).Image = My.Resources.play
        audioBT(audioIndex).ImageAlign = ContentAlignment.MiddleLeft
        audioBT(audioIndex).BackColor = Color.FromArgb(144, 158, 180)
        audioBT(audioIndex).Location = New Point(rtb_.GetPositionFromCharIndex(rtb_.Text.LastIndexOf(cacheDate(audioIndex)) + cacheDate(audioIndex).Length).X, rtb_.GetPositionFromCharIndex(rtb_.Text.IndexOf(cacheDate(audioIndex))).Y)
        audioBT(audioIndex).Controls.Add(timeLabel(audioIndex))
        audioBT(audioIndex).Controls.Add(PlayPGB(audioIndex))
        rtb_.Controls.Add(audioBT(audioIndex))
        audioBT(audioIndex).Show()
        AddHandler rtb_.VScroll, AddressOf audioscroll
        AddHandler audioBT(audioIndex).Click, AddressOf audioPlay
        audioIndex += 1
        main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /msg " & to_bs64 & ";")
    End Sub
    Sub PlayTick(ByVal sender As Object, ByVal e As EventArgs)
        Dim tmr = DirectCast(sender, Timer)
        Dim tmr_index As Integer = tmr.Tag.Replace("index", "")
        If PlayPGB(tmr_index).Value = PlayPGB(tmr_index).Maximum Then
            tmr.Enabled = False
        Else
            PlayPGB(tmr_index).Value += 1
        End If
    End Sub
    Public Sub audioPlay(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        Dim btn_index As Integer = CInt(btn.Name.Replace("index", ""))
        My.Computer.Audio.Play(audioByte.Item(btn_index), AudioPlayMode.Background)
        btn.FlatAppearance.BorderColor = Color.LimeGreen
        Dim span As TimeSpan = TimeSpan.FromMilliseconds(audioTime(btn_index))
        PlayPGB(btn_index).Value = 0
        Dim seconds As Decimal = Math.Round(CDec(span.Milliseconds / 1000) + span.Seconds + span.Minutes * 60 + span.Hours * 3600)
        PlayTimer(btn_index).Enabled = True
    End Sub

    Sub audioscroll()
        For tt As Integer = 0 To audioIndex - 1
            audioBT(tt).Location = New Point(rtb_.GetPositionFromCharIndex(rtb_.Text.LastIndexOf(cacheDate(tt)) + cacheDate(tt).Length).X, rtb_.GetPositionFromCharIndex(rtb_.Text.IndexOf(cacheDate(tt))).Y)
        Next
    End Sub

    Private Sub BlockingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlockingToolStripMenuItem.Click
        connected_usr.blockuser(Name)
    End Sub

    Private Sub ClearChatToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearChatToolStripMenuItem1.Click
        rtb_.Clear()
        rtb_.Controls.Clear()
    End Sub
End Class