Imports System.IO

Public Class nChat_frm
    Dim encrypted As Boolean = False
    Dim key As String
    Dim aes_ As New AESEncrypt
    Dim Timeout As Integer = 3
    Private Sub nChat_frm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub message_box_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles message_box.KeyDown
        If message_box.TextLength = 0 Then : Else
            Dim rtb = Me.Controls.Find("richtextbox", True)
            If e.KeyData = Keys.Enter Then
                If encrypted = True Then
                    Dim getbytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(message_box.Text)
                    Dim target As Byte()
                    aes_.Encode(getbytes, target, key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                    Dim to_bs64 As String = Convert.ToBase64String(target)
                    main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /msg " & to_bs64 & ";")
                    If rtb(0).Text.Length < 2 Then
                        AddText(rtb(0), "(me)[" & DateTime.Now.ToString("hh:mm:ss") & "]: " & message_box.Text & vbNewLine, Color.FromArgb(104, 197, 240))
                    Else
                        AddText(rtb(0), "(me)[" & DateTime.Now.ToString("hh:mm:ss") & "]: " & message_box.Text & vbNewLine, Color.FromArgb(104, 197, 240))
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
        If connected_usr.isConnect_Encrypt(Name) = True Then
            lock_bt.Image = My.Resources.lock16
            lock_bt.Text = "Encrypted"
            lock_bt.Enabled = True

            message_box.Enabled = True
            encrypted = True
            sendfile_bt.Enabled = True
            get_key()
            message_box.BackColor = Color.FromArgb(30, 30, 30)
            encrypt_state.Interval = 2000
            If enc = 0 Then
                alert_bt.Enabled = True
                AddText(rtb_, "[Chat encrypted!]" & vbNewLine, Color.Lime)
            End If
            enc = 1
            If reEncrypt.Enabled = True Then
                reEncrypt.Enabled = False
                Timeout = 3
            End If
        Else
            lock_bt.Image = My.Resources.unlock16
            message_box.Enabled = False
            message_box.BackColor = Color.FromArgb(106, 106, 106)
            sendfile_bt.Enabled = False
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
        If encrypted = True Then
            MessageBox.Show("Handshake with: RSA 2048bit" & vbNewLine & "Chat Encryption: AES 256bit" & vbNewLine & "SHA1: " & rHash.HashString(key, rHash.HASH.SHA1), "Key", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If File.Exists(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini") = True Then
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
    Private Sub nChat_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If SecureDesktop.isOnSecureDesktop = True Then
            sendfile_bt.Enabled = False
        End If
        Dim rtb = Me.Controls.Find("richtextbox", True)
        rtb_ = rtb(0)
        rtb_.ContextMenuStrip = Contextmenu
        profil_img.BackgroundImage = main_frm.profil_img.BackgroundImage
        ActiveControl = message_box
        AddHandler rtb_.TextChanged, AddressOf scrolldown

        If connected_usr.isConnect_Encrypt(Name) = False Then
            main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /handshake 0;")
        End If
        main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /get_profil_img 1;")
        If is_in_usrlst(Name) = True Then
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
        For check As Integer = 0 To main_frm.userlist_viewer.Items.Count - 1
            If main_frm.userlist_viewer.Items(check).SubItems(1).Text = Name Then
                Select Case main_frm.userlist_viewer.Items(check).ImageIndex
                    Case 0
                        partner_img.Image = My.Resources.offlineR
                    Case 1
                        partner_img.Image = My.Resources.busyR
                    Case 2
                        partner_img.Image = My.Resources.onlineR
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
        If e.Shift = True Then
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
        If encrypted = True Then
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
        If encrypted = True Then
            main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /get_username 1;")
        Else
            main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /get_username 1;")
        End If
        addusr_bt.Visible = False
    End Sub

    Private Sub sendfile_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendfile_bt.Click
        send_file_dialog.ShowDialog()
    End Sub

    Private Sub send_file_dialog_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles send_file_dialog.FileOk
        'Encrypt filename
        Dim info As FileInfo = New FileInfo(send_file_dialog.FileName)
        If info.Length < 2097153 Then
            Dim filename As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(info.Name)
            Dim target_name As Byte()
            aes_.Encode(filename, target_name, key, AESEncrypt.ALGO.RIJNDAEL, 4096)
            Dim filename_b64_enc As String = Convert.ToBase64String(target_name)

            'Encrypt file
            Dim read_byt As Byte() = File.ReadAllBytes(send_file_dialog.FileName)
            Dim target_enc As Byte()
            aes_.Encode(read_byt, target_enc, key, AESEncrypt.ALGO.RIJNDAEL, 4096)
            Dim to_b64 As String = Convert.ToBase64String(target_enc)

            'Encrypt Message
            Dim msg_file As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes("Sendet a file: " & info.Name)
            Dim target_msgfile As Byte()
            aes_.Encode(msg_file, target_msgfile, key, AESEncrypt.ALGO.RIJNDAEL, 4096)
            Dim msgfile_b64 As String = Convert.ToBase64String(target_msgfile)
            'Encrypt---> Send file {fromfilename}
            main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /file " & to_b64 & "; /Fname " & filename_b64_enc & "; /msg " & msgfile_b64 & ";")
            GC_.FlushMemory()
        Else
            MessageBox.Show("File is too large.", "Send file", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ClearChatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearChatToolStripMenuItem.Click
        rtb_.Clear()
        rtb_.Controls.Clear()
    End Sub
    Private Sub nChat_frm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged

    End Sub

    Private Sub GetUsernameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetUsernameToolStripMenuItem.Click
        main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /username " & main_frm.alias_txt.Text & ";")
    End Sub
    Dim alertindex As Integer = 30
    Private Sub alertCountdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alertCountdown.Tick
        alertindex -= 1
        If alertindex = 0 Then
            alert_bt.Enabled = True
            alertCountdown.Enabled = False
            alertindex = 30
        End If
    End Sub

    Private Sub profil_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profil_img.Click
        If SecureDesktop.isOnSecureDesktop = True Then
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
        record.save_record(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\rec.wav")
        Dim readRecByte As Byte() = My.Computer.FileSystem.ReadAllBytes(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\rec.wav")

        Dim getbytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes("/inAudio " & Convert.ToBase64String(readRecByte) & ";")
        Dim target As Byte()
        aes_.Encode(getbytes, target, key, AESEncrypt.ALGO.RIJNDAEL, 4096)
        Dim to_bs64 As String = Convert.ToBase64String(target)
        main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /msg " & to_bs64 & ";")
    End Sub

    Private Sub recAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recAudio.Click

    End Sub
End Class