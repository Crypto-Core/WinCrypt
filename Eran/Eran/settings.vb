
Imports System.IO
Public Class settings
    Dim ini As New IniFile
    Private Sub settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Try
            config.load()
            Select Case config.startmodus
                Case 0
                    startwindow_rb.Checked = True
                Case 1
                    start_normal.Checked = True
                Case 2
                    secure_desktop_rb.Checked = True
            End Select
            allow_access_node_cb.Checked = config.own_access_node
            listen_port_txt.Text = CStr(config.own_access_node_port)
            save_cb.Checked = config.acces_node_save
            scan_host_txt.Text = config.access_node_host
            scan_port_txt.Text = CStr(config.acces_node_port)
            play_msg_sound.Checked = config.play_audio_msg
            play_usr_online.Checked = config.play_usr_online
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub startwindow_rb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startwindow_rb.CheckedChanged
        Try
            ini.Load(StartWindow.config_path)
            ini.SetKeyValue("config", "startmodus", CStr(0))
            ini.Save(StartWindow.config_path)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub start_normal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start_normal.CheckedChanged
        Try
            ini.Load(StartWindow.config_path)
            ini.SetKeyValue("config", "startmodus", CStr(1))
            ini.Save(StartWindow.config_path)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub secure_desktop_rb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles secure_desktop_rb.CheckedChanged
        Try
            ini.Load(StartWindow.config_path)
            ini.SetKeyValue("config", "startmodus", CStr(2))
            ini.Save(StartWindow.config_path)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scan_port_txt.TextChanged
        Try
            ini.Load(StartWindow.config_path)
            Select Case ini.GetKeyValue("config", "acces_node_save")
                Case CStr(0)
                    ini.SetKeyValue("config", "acces_node_port", scan_port_txt.Text)
                Case CStr(1)
            End Select
            ini.Save(StartWindow.config_path)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles allow_access_node_cb.CheckedChanged
        Try
            ini.Load(StartWindow.config_path)
            If allow_access_node_cb.Checked Then
                ini.SetKeyValue("config", "own_access_node", CStr(0))
                listen_port_txt.Enabled = True
            Else
                ini.SetKeyValue("config", "own_access_node", CStr(1))
                listen_port_txt.Enabled = False
                ini.SetKeyValue("config", "own_access_node_port", "")
                listen_port_txt.Text = ""
            End If
            ini.Save(StartWindow.config_path)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_cb.CheckedChanged
        Try
            ini.Load(StartWindow.config_path)
            If save_cb.Checked Then
                ini.SetKeyValue("config", "acces_node_save", CStr(0))
            Else
                ini.SetKeyValue("config", "acces_node_save", CStr(1))
                ini.SetKeyValue("config", "access_node_host", "")
                ini.SetKeyValue("config", "access_node_port", "")
                scan_host_txt.Text = ""
                scan_port_txt.Text = ""
            End If
            ini.Save(StartWindow.config_path)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub scan_host_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scan_host_txt.TextChanged
        Try
            ini.Load(StartWindow.config_path)
            Select Case ini.GetKeyValue("config", "acces_node_save")
                Case CStr(0)
                    ini.SetKeyValue("config", "access_node_host", scan_host_txt.Text)
                Case CStr(1)
            End Select
            ini.Save(StartWindow.config_path)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub listen_port_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listen_port_txt.TextChanged
        Try
            If allow_access_node_cb.Checked Then
                ini.Load(StartWindow.config_path)
                ini.SetKeyValue("config", "own_access_node_port", listen_port_txt.Text)
                ini.Save(StartWindow.config_path)
            Else : End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles play_msg_sound.CheckedChanged
        Try
            ini.Load(StartWindow.config_path)
            If play_msg_sound.Checked Then
                ini.SetKeyValue("config", "play_audio_msg", "True")
                config.play_audio_msg = True
            Else
                ini.SetKeyValue("config", "play_audio_msg", "False")
                config.play_audio_msg = False
            End If
            ini.Save(StartWindow.config_path)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub play_usr_online_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles play_usr_online.CheckedChanged, play_usr_online.CheckedChanged
        Try
            ini.Load(StartWindow.config_path)
            If play_usr_online.Checked Then
                ini.SetKeyValue("config", "play_usr_online", "True")
                config.play_usr_online = True
            Else
                ini.SetKeyValue("config", "play_usr_online", "False")
                config.play_usr_online = False
            End If
            ini.Save(StartWindow.config_path)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class