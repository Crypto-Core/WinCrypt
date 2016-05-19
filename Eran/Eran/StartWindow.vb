
Imports Microsoft.Win32
Imports System.IO
Public Class StartWindow
    Private ini As New IniFile
    Friend Shared config_path As String = My.Application.Info.DirectoryPath & OS.OS_slash & "config.ini"
    Private Sub join_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles secureDesktop_bt.Click
        If save_selection_cb.Checked Then
            ini.Load(config_path)
            ini.SetKeyValue("config", "startmodus", CStr(2))
            ini.Save(config_path)
        Else : End If
        SecureDesktop.isOnSecureDesktop = True
        Control.CheckForIllegalCrossThreadCalls = False
        SecureDesktop.StartSecureWindow(main_frm)
    End Sub

    Private Sub startNormal_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startNormal_bt.Click
        If save_selection_cb.Checked Then
            ini.Load(config_path)
            ini.SetKeyValue("config", "startmodus", CStr(1))
            ini.Save(config_path)
        Else : End If
        SecureDesktop.isOnSecureDesktop = False
        Me.Hide()
        main_frm.ShowDialog()
    End Sub

End Class