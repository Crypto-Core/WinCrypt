Public Class setting

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Autostart(CheckBox1.Checked)
    End Sub
    Public Function Autostart(ByVal AutostartEnable As Boolean)
        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        If AutostartEnable = True Then
            key.SetValue("TrezorCrypt", System.Reflection.Assembly.GetEntryAssembly.Location)
        Else
            key.DeleteValue("TrezorCrypt", False)
        End If
        key.Close()
        Return AutostartEnable
    End Function

    Private Sub setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        If key.GetValue("TrezorCrypt", "") = "" Then
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
        End If

        Dim loadini As New IniFile
        loadini.Load(My.Application.Info.DirectoryPath & "\config.ini")
        If loadini.GetKeyValue("Config", "OpenSyncPathafterDecryption") = 1 Then
            CheckBox2.Checked = True
        Else
            CheckBox2.Checked = False
        End If

        NumericUpDown1.Value = loadini.GetKeyValue("Config", "EraseRepeat")
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Dim loadini As New IniFile
        loadini.Load(My.Application.Info.DirectoryPath & "\config.ini")

        If CheckBox2.Checked = True Then
            loadini.SetKeyValue("Config", "OpenSyncPathafterDecryption", 1)
        Else
            loadini.SetKeyValue("Config", "OpenSyncPathafterDecryption", 0)
        End If
        loadini.Save(My.Application.Info.DirectoryPath & "\config.ini")
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        Dim loadini As New IniFile
        loadini.Load(My.Application.Info.DirectoryPath & "\config.ini")
        loadini.SetKeyValue("Config", "EraseRepeat", NumericUpDown1.Value)
        loadini.Save(My.Application.Info.DirectoryPath & "\config.ini")
    End Sub
End Class