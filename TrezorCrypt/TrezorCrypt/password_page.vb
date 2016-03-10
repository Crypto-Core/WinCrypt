Imports System.IO

Public Class password_page

    Private Sub Panel1_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.HandleCreated
        ComboBox1.SelectedIndex = 2
        ComboBox2.SelectedIndex = 2

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Panel1.Hide()

        main_frm.Panel1.Show()
        device_lb.Text = ""
        product_lb.Text = ""
        size_lb.Text = ""
        serial_lb.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ini As New IniFile
        ini.AddSection("Device")
        ini.SetKeyValue("Device", "Name", product_lb.Text)
        ini.SetKeyValue("Device", "Serial", serial_lb.Text)
        ini.SetKeyValue("Device", "Syncpath", main_frm.TextBox1.Text)
        ini.SetKeyValue("Device", "Password", rHash.HashString(TextBox1.Text, rHash.HASH.SHA512))
        ini.SetKeyValue("Device", "Algorithm", ComboBox1.SelectedIndex)
        ini.SetKeyValue("Device", "Blocksize", ComboBox2.Text)
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

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength > 7 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
End Class