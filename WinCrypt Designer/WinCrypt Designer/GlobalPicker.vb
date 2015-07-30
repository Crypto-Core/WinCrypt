Public Class GlobalPicker
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Long) As Integer
    Public colorFrom As String
    Public oldColor As Color
    Dim abortExit As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles start_bt.Click
        GetColor.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles stop_bt.Click
        GetColor.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles GetColor.Tick
        Dim BMP As New Drawing.Bitmap(1, 1)
        Dim GFX As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(BMP)
        GFX.CopyFromScreen(New Drawing.Point(MousePosition.X, MousePosition.Y), _
                           New Drawing.Point(0, 0), BMP.Size)
        Dim Pixel As Drawing.Color = BMP.GetPixel(0, 0)
        color_pb.BackColor = Pixel
        If colorFrom = "formhead" Then
            Try
                wincryptdesigner_frm.WinCryptForm.form_head.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.wincrypttitle.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.wincrypt_icon.BackColor = Pixel
            Catch ex As Exception

            End Try
        Else : End If
        If colorFrom = "bgcolor" Then
            Try
                wincryptdesigner_frm.WinCryptForm.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.setting_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.exit_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.file_decrypt_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.file_encrypt_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.text_encrypt_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.hash_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.md5_converter_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.md5_bf_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.rsa_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.rsa_encrypt_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.rsa_decrypt_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.rsa_create_keys_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.mail_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.send_mail_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.pw_manager_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.export_db_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.import_db_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.delete_db_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.systemidentification_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.pw_generator_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.delete_file_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.update_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.feedback_bt_menu.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.about_bt_menu.BackColor = Pixel
            Catch ex As Exception

            End Try
        End If
        If colorFrom = "txtcolor" Then
            Try
                wincryptdesigner_frm.WinCryptForm.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.form_head.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.encrypt_gb.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.path_encrypt.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.key_lb1.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.crypt_file_pathbutton.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.create_container_encrypt.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.mount_gb.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.file_lb.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.opencryptfile.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.key_lb.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.drive_lb.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.mount.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.dismount.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.wincrypttitle.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.file_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.tools_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.info_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.exit_bt.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.minimize_bt.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.setting_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.exit_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.file_encrypt_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.file_decrypt_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.text_encrypt_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.hash_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.md5_converter_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.md5_bf_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.rsa_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.rsa_encrypt_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.rsa_decrypt_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.rsa_create_keys_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.mail_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.send_mail_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.pw_manager_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.export_db_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.import_db_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.delete_db_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.systemidentification_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.pw_generator_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.delete_file_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.update_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.feedback_bt_menu.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.about_bt_menu.ForeColor = Pixel
            Catch ex As Exception

            End Try
        End If
        If colorFrom = "textinputcolor" Then
            Try
                wincryptdesigner_frm.WinCryptForm.pathtxt.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.keycrypt.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.encrypt_list_status.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.decrypt_filepath.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.decrypt_list_status.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.keyencrypt.ForeColor = Pixel
                wincryptdesigner_frm.WinCryptForm.drivecb.ForeColor = Pixel
            Catch ex As Exception

            End Try
        End If
        If colorFrom = "inputcolor" Then
            Try
                wincryptdesigner_frm.WinCryptForm.pathtxt.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.keycrypt.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.encrypt_list_status.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.decrypt_filepath.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.decrypt_list_status.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.keyencrypt.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.drivecb.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.MenuStrip.BackColor = Pixel
            Catch ex As Exception

            End Try
        End If
        If colorFrom = "buttoncolor" Then
            Try
                wincryptdesigner_frm.WinCryptForm.crypt_file_pathbutton.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.generate_key_encrypt.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.create_container_encrypt.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.cleanlb1.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.opencryptfile.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.cleanlb2.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.mount.BackColor = Pixel
                wincryptdesigner_frm.WinCryptForm.dismount.BackColor = Pixel
            Catch ex As Exception

            End Try
        End If
        rgb_red_txt.Text = Pixel.R
        rgb_green_txt.Text = Pixel.G
        rgb_blue_txt.Text = Pixel.B
    End Sub

    Private Sub SSChk_Tick(sender As Object, e As EventArgs) Handles SSChk.Tick
        If (GetAsyncKeyState(114)) Then
            GetColor.Start()
        End If
        If (GetAsyncKeyState(115)) Then
            GetColor.Stop()
        End If
    End Sub

    Private Sub add_color_bt_Click(sender As Object, e As EventArgs) Handles add_color_bt.Click
        abortExit = True
        If colorFrom = "formhead" Then
            wincryptdesigner_frm.formhead_hex_txt.Text = ColorTranslator.ToHtml(color_pb.BackColor)
        End If
        If colorFrom = "bgcolor" Then
            wincryptdesigner_frm.bgcolor_hex_txt.Text = ColorTranslator.ToHtml(color_pb.BackColor)
        End If
        If colorFrom = "txtcolor" Then
            wincryptdesigner_frm.txtcolor_hex_txt.Text = ColorTranslator.ToHtml(color_pb.BackColor)
        End If
        If colorFrom = "textinputcolor" Then
            wincryptdesigner_frm.textinputcolor_hex_txt.Text = ColorTranslator.ToHtml(color_pb.BackColor)
        End If
        If colorFrom = "inputcolor" Then
            wincryptdesigner_frm.inputcolor_hex_txt.Text = ColorTranslator.ToHtml(color_pb.BackColor)
        End If
        If colorFrom = "buttoncolor" Then
            wincryptdesigner_frm.buttoncolor_hex_txt.Text = ColorTranslator.ToHtml(color_pb.BackColor)
        End If
        color_pb.BackColor = ColorTranslator.FromHtml("#F0F0F0")
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles abort_bt.Click
        abortExit = True
        If abortExit = True Then
            If colorFrom = "formhead" Then
                wincryptdesigner_frm.formhead_hex_txt.Text = ""
                wincryptdesigner_frm.formhead_hex_txt.Text = ColorTranslator.ToHtml(oldColor)
            End If
            If colorFrom = "bgcolor" Then
                wincryptdesigner_frm.bgcolor_hex_txt.Text = ""
                wincryptdesigner_frm.bgcolor_hex_txt.Text = ColorTranslator.ToHtml(oldColor)
            End If
            If colorFrom = "txtcolor" Then
                wincryptdesigner_frm.txtcolor_hex_txt.Text = ""
                wincryptdesigner_frm.txtcolor_hex_txt.Text = ColorTranslator.ToHtml(oldColor)
            End If
            If colorFrom = "textinputcolor" Then
                wincryptdesigner_frm.textinputcolor_hex_txt.Text = ""
                wincryptdesigner_frm.textinputcolor_hex_txt.Text = ColorTranslator.ToHtml(oldColor)
            End If
            If colorFrom = "inputcolor" Then
                wincryptdesigner_frm.inputcolor_hex_txt.Text = ""
                wincryptdesigner_frm.inputcolor_hex_txt.Text = ColorTranslator.ToHtml(oldColor)
            End If
            If colorFrom = "buttoncolor" Then
                wincryptdesigner_frm.buttoncolor_hex_txt.Text = ""
                wincryptdesigner_frm.buttoncolor_hex_txt.Text = ColorTranslator.ToHtml(oldColor)
            End If
            color_pb.BackColor = ColorTranslator.FromHtml("#F0F0F0")
            Me.Close()
        End If
    End Sub

    Private Sub GlobalPicker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If abortExit = False Then
            GetColor.Enabled = False
            If colorFrom = "formhead" Then
                wincryptdesigner_frm.formhead_hex_txt.Text = ""
                wincryptdesigner_frm.formhead_hex_txt.Text = ColorTranslator.ToHtml(oldColor)
            End If
            If colorFrom = "bgcolor" Then
                wincryptdesigner_frm.bgcolor_hex_txt.Text = ""
                wincryptdesigner_frm.bgcolor_hex_txt.Text = ColorTranslator.ToHtml(oldColor)
            End If
            If colorFrom = "txtcolor" Then
                wincryptdesigner_frm.txtcolor_hex_txt.Text = ""
                wincryptdesigner_frm.txtcolor_hex_txt.Text = ColorTranslator.ToHtml(oldColor)
            End If
            If colorFrom = "textinputcolor" Then
                wincryptdesigner_frm.textinputcolor_hex_txt.Text = ""
                wincryptdesigner_frm.textinputcolor_hex_txt.Text = ColorTranslator.ToHtml(oldColor)
            End If
            If colorFrom = "inputcolor" Then
                wincryptdesigner_frm.inputcolor_hex_txt.Text = ""
                wincryptdesigner_frm.inputcolor_hex_txt.Text = ColorTranslator.ToHtml(oldColor)
            End If
            If colorFrom = "buttoncolor" Then
                wincryptdesigner_frm.buttoncolor_hex_txt.Text = ""
                wincryptdesigner_frm.buttoncolor_hex_txt.Text = ColorTranslator.ToHtml(oldColor)
            End If
            color_pb.BackColor = ColorTranslator.FromHtml("#F0F0F0")
        Else
        End If
        
    End Sub

    Private Sub GlobalPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class