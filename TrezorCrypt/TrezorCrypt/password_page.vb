Imports System.IO

Public Class password_page
    'Wenn der Handle von main_panel erstellt wurde
    Private Sub main_panel_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles main_panel.HandleCreated
        'dann wird das zweite Item aus der Algorithmusliste ausgewählt
        algo_cb.SelectedIndex = 2
        'und das zweite Item aus der Blocksizeliste ausgewählts
        blocksize_cb.SelectedIndex = 2
    End Sub


    Private Sub back_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_bt.Click
        Me.main_panel.Hide()
        main_frm.main_panel.Show()
        device_lb.Text = ""
        product_lb.Text = ""
        size_lb.Text = ""
        serial_lb.Text = ""
    End Sub

    Private Sub encrypt_device_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles encrypt_device_bt.Click
        Dim ini As New IniFile
        ini.AddSection("Device")
        ini.SetKeyValue("Device", "Name", product_lb.Text)
        ini.SetKeyValue("Device", "Serial", serial_lb.Text)
        ini.SetKeyValue("Device", "Syncpath", main_frm.sync_path_txt.Text)
        ini.SetKeyValue("Device", "Password", rHash.HashString(password_txt.Text, rHash.HASH.SHA512))
        ini.SetKeyValue("Device", "Algorithm", algo_cb.SelectedIndex)
        ini.SetKeyValue("Device", "Blocksize", blocksize_cb.Text)
        ini.Save(device_lb.Text & "device.ini")

        File.Create(device_lb.Text & rHash.HashString(serial_lb.Text, rHash.HASH.MD5)).Close()
        Dim info As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(device_lb.Text & rHash.HashString(serial_lb.Text, rHash.HASH.MD5))
        info.Attributes = info.Attributes Or IO.FileAttributes.Hidden
        Dim configINI As New IniFile
        configINI.AddSection("Config")
        configINI.SetKeyValue("Config", "EraseRepeat", 3)
        configINI.SetKeyValue("Config", "OpenSyncPathafterDecryption", 0)
        configINI.SetKeyValue("Config", "Listenmode", 1)
        configINI.Save(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\config.ini")
        Dim createIcon As New FileStream(device_lb.Text & "trezor.ico", FileMode.Create)
        createIcon.Write(My.Resources.drivelock, 0, My.Resources.drivelock.Length)
        createIcon.Close()
        My.Computer.FileSystem.WriteAllText(device_lb.Text & "autorun.inf", "[Autorun]" & vbNewLine & "icon=trezor.ico" & vbNewLine & "label=TrezorCrypt", False)

        Directory.CreateDirectory(device_lb.Text & "crypt")
        Application.Restart()
    End Sub

    Private Sub password_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password_txt.TextChanged
        If password_txt.TextLength > 7 Then
            encrypt_device_bt.Enabled = True
        Else
            encrypt_device_bt.Enabled = False
        End If
    End Sub

    Private Sub SettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingToolStripMenuItem.Click
        setting.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub
End Class