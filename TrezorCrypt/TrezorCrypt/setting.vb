Public Class setting
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
            autostart_cb.Checked = False
        Else
            autostart_cb.Checked = True
        End If

        Dim loadini As New IniFile
        loadini.Load(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\config.ini")
        If loadini.GetKeyValue("Config", "OpenSyncPathafterDecryption") = 1 Then
            opensync_cb.Checked = True
        Else
            opensync_cb.Checked = False
        End If
        If loadini.GetKeyValue("Config", "Listenmode") = 0 Then
            listenmode_cb.Checked = False
        Else
            listenmode_cb.Checked = True
        End If
    End Sub

    Private Sub autostart_cb_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autostart_cb.CheckedChanged
        Autostart(autostart_cb.Checked)
    End Sub

    Private Sub listenmode_cb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listenmode_cb.CheckedChanged
        Dim loadini As New IniFile
        loadini.Load(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\config.ini")

        If listenmode_cb.Checked = True Then
            loadini.SetKeyValue("Config", "Listenmode", 1)
        Else
            loadini.SetKeyValue("Config", "Listenmode", 0)
        End If
        loadini.Save(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\config.ini")
    End Sub

    Private Sub opensync_cb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opensync_cb.CheckedChanged
        Dim loadini As New IniFile
        loadini.Load(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\config.ini")

        If opensync_cb.Checked = True Then
            loadini.SetKeyValue("Config", "OpenSyncPathafterDecryption", 1)
        Else
            loadini.SetKeyValue("Config", "OpenSyncPathafterDecryption", 0)
        End If
        loadini.Save(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\config.ini")
    End Sub
End Class