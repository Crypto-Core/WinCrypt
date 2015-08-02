Public Class wincryptdesigner_frm
    Public WinCryptForm As New WinCrypt_Designer.Startwindow

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wincrypt_panel.Controls.Clear()

        With WinCryptForm
            .TopLevel = False
            .Visible = True
            .Parent = wincrypt_panel
            .StartPosition = FormStartPosition.CenterParent
            wincrypt_panel.Controls.Add(WinCryptForm)
        End With
        loadstandard_color()

    End Sub
    Private Sub loadstandard_color()
        Dim formhead_color As Color = WinCryptForm.form_head.BackColor
        Dim bgcolor As Color = WinCryptForm.BackColor
        Dim textcolor As Color = WinCryptForm.path_encrypt.ForeColor
        Dim textinputcolor As Color = WinCryptForm.pathtxt.ForeColor
        Dim inputbgcolor As Color = WinCryptForm.pathtxt.BackColor
        Dim buttoncolor As Color = WinCryptForm.create_container_encrypt.BackColor

        formhead_hex_txt.Text = ColorTranslator.ToHtml(formhead_color)
        bgcolor_hex_txt.Text = ColorTranslator.ToHtml(bgcolor)

        If ColorTranslator.ToHtml(textcolor) = "" Then
            txtcolor_hex_txt.Text = "#FFF"
        Else
            txtcolor_hex_txt.Text = ColorTranslator.ToHtml(textcolor)
        End If
        textinputcolor_hex_txt.Text = ColorTranslator.ToHtml(textinputcolor)
        inputcolor_hex_txt.Text = ColorTranslator.ToHtml(inputbgcolor)
        buttoncolor_hex_txt.Text = ColorTranslator.ToHtml(buttoncolor)
    End Sub

    Private Sub wincryptdesigner_frm_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        WinCryptForm.Location = New Point(wincrypt_panel.Size.Width / 2 - WinCryptForm.Size.Width / 2, wincrypt_panel.Size.Height / 2 - WinCryptForm.Size.Height / 2)
    End Sub
    Private Sub inputcolortofrm()
        

    End Sub

    Private Sub formhead_hex_txt_TextChanged(sender As Object, e As EventArgs) Handles formhead_hex_txt.TextChanged
        Try
            WinCryptForm.form_head.BackColor = ColorTranslator.FromHtml(formhead_hex_txt.Text)
            WinCryptForm.wincrypttitle.BackColor = ColorTranslator.FromHtml(formhead_hex_txt.Text)
            WinCryptForm.wincrypt_icon.BackColor = ColorTranslator.FromHtml(formhead_hex_txt.Text)
        Catch ex As Exception
            
        End Try
    End Sub

    Private Sub bgcolor_hex_txt_TextChanged(sender As Object, e As EventArgs) Handles bgcolor_hex_txt.TextChanged
        Try
            WinCryptForm.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.setting_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.exit_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.file_decrypt_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.file_encrypt_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.text_encrypt_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.hash_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.md5_converter_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.md5_bf_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.rsa_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.rsa_encrypt_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.rsa_decrypt_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.rsa_create_keys_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.mail_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.send_mail_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.pw_manager_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.export_db_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.import_db_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.delete_db_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.systemidentification_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.pw_generator_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.delete_file_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.update_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.feedback_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
            WinCryptForm.about_bt_menu.BackColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtcolor_hex_txt_TextChanged(sender As Object, e As EventArgs) Handles txtcolor_hex_txt.TextChanged
        Try
            WinCryptForm.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.form_head.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.encrypt_gb.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.path_encrypt.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.key_lb1.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.crypt_file_pathbutton.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.create_container_encrypt.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.mount_gb.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.file_lb.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.opencryptfile.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.key_lb.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.drive_lb.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.mount.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.dismount.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.wincrypttitle.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.file_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.tools_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.info_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.exit_bt.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.minimize_bt.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.setting_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.exit_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.file_encrypt_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.file_decrypt_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.text_encrypt_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.hash_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.md5_converter_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.md5_bf_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.rsa_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.rsa_encrypt_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.rsa_decrypt_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.rsa_create_keys_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.mail_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.send_mail_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.pw_manager_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.export_db_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.import_db_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.delete_db_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.systemidentification_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.pw_generator_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.delete_file_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.update_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.feedback_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
            WinCryptForm.about_bt_menu.ForeColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
        Catch ex As Exception
            
        End Try
    End Sub

    Private Sub textinputcolor_hex_txt_TextChanged(sender As Object, e As EventArgs) Handles textinputcolor_hex_txt.TextChanged
        Try
            WinCryptForm.pathtxt.ForeColor = ColorTranslator.FromHtml(textinputcolor_hex_txt.Text)
            WinCryptForm.keycrypt.ForeColor = ColorTranslator.FromHtml(textinputcolor_hex_txt.Text)
            WinCryptForm.encrypt_list_status.ForeColor = ColorTranslator.FromHtml(textinputcolor_hex_txt.Text)
            WinCryptForm.decrypt_filepath.ForeColor = ColorTranslator.FromHtml(textinputcolor_hex_txt.Text)
            WinCryptForm.decrypt_list_status.ForeColor = ColorTranslator.FromHtml(textinputcolor_hex_txt.Text)
            WinCryptForm.keyencrypt.ForeColor = ColorTranslator.FromHtml(textinputcolor_hex_txt.Text)
            WinCryptForm.drivecb.ForeColor = ColorTranslator.FromHtml(textinputcolor_hex_txt.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub inputcolor_hex_txt_TextChanged(sender As Object, e As EventArgs) Handles inputcolor_hex_txt.TextChanged
        
        Try
            WinCryptForm.pathtxt.BackColor = ColorTranslator.FromHtml(inputcolor_hex_txt.Text)
            WinCryptForm.keycrypt.BackColor = ColorTranslator.FromHtml(inputcolor_hex_txt.Text)
            WinCryptForm.encrypt_list_status.BackColor = ColorTranslator.FromHtml(inputcolor_hex_txt.Text)
            WinCryptForm.decrypt_filepath.BackColor = ColorTranslator.FromHtml(inputcolor_hex_txt.Text)
            WinCryptForm.decrypt_list_status.BackColor = ColorTranslator.FromHtml(inputcolor_hex_txt.Text)
            WinCryptForm.keyencrypt.BackColor = ColorTranslator.FromHtml(inputcolor_hex_txt.Text)
            WinCryptForm.drivecb.BackColor = ColorTranslator.FromHtml(inputcolor_hex_txt.Text)
            WinCryptForm.MenuStrip.BackColor = ColorTranslator.FromHtml(inputcolor_hex_txt.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub buttoncolor_hex_txt_TextChanged(sender As Object, e As EventArgs) Handles buttoncolor_hex_txt.TextChanged
        Try
            WinCryptForm.crypt_file_pathbutton.BackColor = ColorTranslator.FromHtml(buttoncolor_hex_txt.Text)
            WinCryptForm.generate_key_encrypt.BackColor = ColorTranslator.FromHtml(buttoncolor_hex_txt.Text)
            WinCryptForm.create_container_encrypt.BackColor = ColorTranslator.FromHtml(buttoncolor_hex_txt.Text)
            WinCryptForm.cleanlb1.BackColor = ColorTranslator.FromHtml(buttoncolor_hex_txt.Text)
            WinCryptForm.opencryptfile.BackColor = ColorTranslator.FromHtml(buttoncolor_hex_txt.Text)
            WinCryptForm.cleanlb2.BackColor = ColorTranslator.FromHtml(buttoncolor_hex_txt.Text)
            WinCryptForm.mount.BackColor = ColorTranslator.FromHtml(buttoncolor_hex_txt.Text)
            WinCryptForm.dismount.BackColor = ColorTranslator.FromHtml(buttoncolor_hex_txt.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub formhead_picker_bt_Click(sender As Object, e As EventArgs) Handles formhead_picker_bt.Click
        wincrypt_picker_dialog.Color = ColorTranslator.FromHtml(formhead_hex_txt.Text)
        wincrypt_picker_dialog.ShowDialog()
        formhead_hex_txt.Text = ColorTranslator.ToHtml(wincrypt_picker_dialog.Color)
    End Sub

    Private Sub bgcolor_picker_bt_Click(sender As Object, e As EventArgs) Handles bgcolor_picker_bt.Click
        wincrypt_picker_dialog.Color = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
        wincrypt_picker_dialog.ShowDialog()
        bgcolor_hex_txt.Text = ColorTranslator.ToHtml(wincrypt_picker_dialog.Color)
    End Sub

    Private Sub txtcolor_picker_bt_Click(sender As Object, e As EventArgs) Handles txtcolor_picker_bt.Click
        wincrypt_picker_dialog.Color = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
        wincrypt_picker_dialog.ShowDialog()
        txtcolor_hex_txt.Text = ColorTranslator.ToHtml(wincrypt_picker_dialog.Color)
    End Sub

    Private Sub textinputcolor_picker_bt_Click(sender As Object, e As EventArgs) Handles textinputcolor_picker_bt.Click
        wincrypt_picker_dialog.Color = ColorTranslator.FromHtml(textinputcolor_hex_txt.Text)
        wincrypt_picker_dialog.ShowDialog()
        textinputcolor_hex_txt.Text = ColorTranslator.ToHtml(wincrypt_picker_dialog.Color)
    End Sub

    Private Sub inputcolor_picker_bt_Click(sender As Object, e As EventArgs) Handles inputcolor_picker_bt.Click
        wincrypt_picker_dialog.Color = ColorTranslator.FromHtml(inputcolor_hex_txt.Text)
        wincrypt_picker_dialog.ShowDialog()
        inputcolor_hex_txt.Text = ColorTranslator.ToHtml(wincrypt_picker_dialog.Color)
    End Sub

    Private Sub buttoncolor_picker_bt_Click(sender As Object, e As EventArgs) Handles buttoncolor_picker_bt.Click
        wincrypt_picker_dialog.Color = ColorTranslator.FromHtml(buttoncolor_hex_txt.Text)
        wincrypt_picker_dialog.ShowDialog()
        buttoncolor_hex_txt.Text = ColorTranslator.ToHtml(wincrypt_picker_dialog.Color)
    End Sub

    Private Sub formhead_ImagePicker_bt_Click(sender As Object, e As EventArgs) Handles formhead_ImagePicker_bt.Click
        GlobalPicker.oldColor = ColorTranslator.FromHtml(formhead_hex_txt.Text)
        GlobalPicker.colorFrom = "formhead"
        GlobalPicker.ShowDialog()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles bgcolor_ImagePicker_bt.Click
        GlobalPicker.oldColor = ColorTranslator.FromHtml(bgcolor_hex_txt.Text)
        GlobalPicker.colorFrom = "bgcolor"
        GlobalPicker.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles txtcolor_ImagePicker_bt.Click
        GlobalPicker.oldColor = ColorTranslator.FromHtml(txtcolor_hex_txt.Text)
        GlobalPicker.colorFrom = "txtcolor"
        GlobalPicker.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles textinputcolor_ImagePicker_bt.Click
        GlobalPicker.oldColor = ColorTranslator.FromHtml(textinputcolor_hex_txt.Text)
        GlobalPicker.colorFrom = "textinputcolor"
        GlobalPicker.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles inputcolor_ImagePicker_bt.Click
        GlobalPicker.oldColor = ColorTranslator.FromHtml(inputcolor_hex_txt.Text)
        GlobalPicker.colorFrom = "inputcolor"
        GlobalPicker.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles buttoncolor_ImagePicker_bt.Click
        GlobalPicker.oldColor = ColorTranslator.FromHtml(buttoncolor_hex_txt.Text)
        GlobalPicker.colorFrom = "buttoncolor"
        GlobalPicker.ShowDialog()
    End Sub

    Private Sub DesignSpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesignSpeichernToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        Dim exportDesign As New IniDatei(SaveFileDialog1.FileName)
        exportDesign.WertSchreiben("Design", "BackgroundColor", bgcolor_hex_txt.Text)
        exportDesign.WertSchreiben("Design", "FormHeadColor", formhead_hex_txt.Text)
        exportDesign.WertSchreiben("Design", "InputBackgroundColor", inputcolor_hex_txt.Text)
        exportDesign.WertSchreiben("Design", "ButtonColor", buttoncolor_hex_txt.Text)
        exportDesign.WertSchreiben("Design", "TextColor", txtcolor_hex_txt.Text)
        exportDesign.WertSchreiben("Design", "InputTextColor", textinoutcolor_hex_lb.Text)
        MsgBox("Design exported!", MsgBoxStyle.Information)
    End Sub

    Private Sub DesignLadenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesignLadenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
            Dim readDesign As New IniDatei(OpenFileDialog1.FileName)
            formhead_hex_txt.Text = readDesign.WertLesen("Design", "FormHeadColor")
            bgcolor_hex_txt.Text = readDesign.WertLesen("Design", "BackgroundColor")
            txtcolor_hex_txt.Text = readDesign.WertLesen("Design", "TextColor")
            textinputcolor_hex_txt.Text = readDesign.WertLesen("Design", "InputTextColor")
            inputcolor_hex_txt.Text = readDesign.WertLesen("Design", "InputBackgroundColor")
            buttoncolor_hex_txt.Text = readDesign.WertLesen("Design", "ButtonColor")
            MsgBox("Design loaded!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub NewdefaultDesignToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewdefaultDesignToolStripMenuItem.Click
        formhead_hex_txt.Text = "#2D2D30"
        bgcolor_hex_txt.Text = "#2D2D30"
        txtcolor_hex_txt.Text = "#FFF"
        textinputcolor_hex_txt.Text = "#007ACC"
        inputcolor_hex_txt.Text = "#333337"
        buttoncolor_hex_txt.Text = "#3E3E40"
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        about.ShowDialog()
    End Sub
End Class
