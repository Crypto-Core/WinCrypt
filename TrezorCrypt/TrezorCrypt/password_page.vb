Imports System.IO

Public Class password_page

    Private Sub Panel1_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles main_panel.HandleCreated
        algo_cb.SelectedIndex = 2
        blocksize_cb.SelectedIndex = 2

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles main_panel.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_bt.Click
        Me.main_panel.Hide()

        main_frm.main_panel.Show()
        device_lb.Text = ""
        product_lb.Text = ""
        size_lb.Text = ""
        serial_lb.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles encrypt_device_bt.Click
        Dim ini As New IniFile
        ini.AddSection("Device")
        ini.SetKeyValue("Device", "Name", product_lb.Text)
        ini.SetKeyValue("Device", "Serial", serial_lb.Text)
        ini.SetKeyValue("Device", "Syncpath", main_frm.sync_path_txt.Text)
        ini.SetKeyValue("Device", "Password", rHash.HashString(password_txt.Text, rHash.HASH.SHA512))
        ini.SetKeyValue("Device", "Algorithm", algo_cb.SelectedIndex)
        ini.SetKeyValue("Device", "Blocksize", blocksize_cb.Text)
        ini.Save(device_lb.Text & "device.ini")

        Dim localini As New IniFile
        localini.AddSection("Device")
        localini.SetKeyValue("Device", "Serial", serial_lb.Text)
        localini.Save(My.Application.Info.DirectoryPath & "\devices.ini")

        Dim createIcon As New FileStream(device_lb.Text & "trezor.ico", FileMode.Create)
        createIcon.Write(My.Resources.drivelock, 0, My.Resources.drivelock.Length)
        createIcon.Close()
        My.Computer.FileSystem.WriteAllText(device_lb.Text & "autorun.inf", "[Autorun]" & vbNewLine & "icon=trezor.ico" & vbNewLine & "label=TrezorCrypt", False)

        Directory.CreateDirectory(device_lb.Text & "crypt")
        Application.Restart()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password_txt.TextChanged
        If password_txt.TextLength > 7 Then
            encrypt_device_bt.Enabled = True
        Else
            encrypt_device_bt.Enabled = False
        End If
    End Sub
End Class