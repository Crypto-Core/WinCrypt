Imports System.IO

Public Class nChat_frm
    Dim encrypted As Boolean = False
    Dim key As String
    Dim aes_ As New AESEncrypt
    Private Sub nChat_frm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub message_box_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles message_box.KeyDown
        Dim rtb = Me.Controls.Find("richtextbox", True)

        If e.KeyData = Keys.Enter Then
            If encrypted = True Then

                Dim getbytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(message_box.Text)
                Dim target As Byte()
                aes_.Encode(getbytes, target, key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                Dim to_bs64 As String = Convert.ToBase64String(target)
                main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /msg " & to_bs64 & ";")

                If rtb(0).Text.Length < 2 Then
                    'rtb(0).Text = TextBox1.Text & vbNewLine
                    AddText(rtb(0), "(me)[" & DateTime.Now.ToString("hh:mm:ss") & "]: " & message_box.Text & vbNewLine, Color.FromArgb(104, 197, 240))
                Else
                    'rtb(0).Text = 
                    AddText(rtb(0), "(me)[" & DateTime.Now.ToString("hh:mm:ss") & "]: " & message_box.Text & vbNewLine, Color.FromArgb(104, 197, 240))
                End If

            Else

                Dim read_bytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(message_box.Text)
                Dim to_bs64_str As String = Convert.ToBase64String(read_bytes)
                main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /msg " & to_bs64_str & ";")

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
    Private Sub encrypt_state_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles encrypt_state.Tick
        If connected_usr.isConnect_Encrypt(Name) = True Then
            lock_bt.Image = My.Resources.lock16
            message_box.Enabled = True
            encrypted = True
            get_key()
            message_box.BackColor = Color.FromArgb(30, 30, 30)
            encrypt_state.Interval = 2000
        Else
            lock_bt.Image = My.Resources.unlock16
            message_box.Enabled = False
            message_box.BackColor = Color.FromArgb(106, 106, 106)
            encrypted = False
            key = ""
        End If
    End Sub
    Private Sub lock_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lock_bt.Click
        If encrypted = True Then
            MessageBox.Show("SHA1: " & rHash.HashString(key, rHash.HASH.SHA1), "Key", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("It's not Encrypted!" & vbNewLine & "You will be send a new Handshake?", "Not Encrypted", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & Name & "; /handshake 0;")
            Else

            End If
        End If
    End Sub
    Sub get_key()
        For Each tt In connected_usr.usr_lst
            If tt.Eran_adress = Name Then
                key = tt.Key
            End If
        Next
    End Sub
    Private Sub nChat_frm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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
    Friend Function is_in_usrlst(ByVal eran_adress As String) As Boolean
        If File.Exists(My.Application.Info.DirectoryPath & "\userlist.ini") = True Then
            Dim ini As New IniFile
            Dim read_enc_bytes As Byte() = File.ReadAllBytes(My.Application.Info.DirectoryPath & "\userlist.ini")
            Dim dec_trg_byte As Byte()

            aes_.Decode(read_enc_bytes, dec_trg_byte, login.pwd, AESEncrypt.ALGO.RIJNDAEL, 4096)
            Dim mem_ As New MemoryStream(dec_trg_byte)
            ini.LoadFromMemory(mem_)
            For Each s As IniFile.IniSection In ini.Sections
                For Each k As IniFile.IniSection.IniKey In s.Keys
                    If Me.Name = k.Value Then
                        Return True
                        End
                    Else

                    End If
                Next
            Next
        Else
        End If
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

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles message_box.KeyUp
        If e.Shift = True Then
            If e.KeyCode = Keys.Enter Then

            End If
        Else
            If e.KeyCode = Keys.Enter Then
                message_box.Clear()
            End If
        End If

    End Sub

    Private Sub alert_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alert_bt.Click
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
        add_user.username_txt.Text = Me.Text
        add_user.eran_adress_txt.Text = Name
        add_user.ShowDialog()
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
    End Sub
End Class