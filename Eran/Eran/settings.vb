Imports System.IO
Public Class settings
    Dim ini As New IniFile
    Private Sub settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        listen_port_txt.Text = config.own_access_node_port
        save_cb.Checked = config.acces_node_save
        scan_host_txt.Text = config.access_node_host
        scan_port_txt.Text = config.acces_node_port

    End Sub

    Private Sub startwindow_rb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startwindow_rb.CheckedChanged
        ini.Load(StartWindow.config_path)
        ini.SetKeyValue("config", "startmodus", 0)
        ini.Save(StartWindow.config_path)
    End Sub

    Private Sub start_normal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start_normal.CheckedChanged
        ini.Load(StartWindow.config_path)
        ini.SetKeyValue("config", "startmodus", 1)
        ini.Save(StartWindow.config_path)
    End Sub

    Private Sub secure_desktop_rb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles secure_desktop_rb.CheckedChanged
        ini.Load(StartWindow.config_path)
        ini.SetKeyValue("config", "startmodus", 2)
        ini.Save(StartWindow.config_path)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scan_port_txt.TextChanged
        ini.Load(StartWindow.config_path)
        Select Case ini.GetKeyValue("config", "acces_node_save")
            Case 0
                ini.SetKeyValue("config", "acces_node_port", scan_port_txt.Text)
            Case 1

        End Select

        ini.Save(StartWindow.config_path)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles allow_access_node_cb.CheckedChanged
        ini.Load(StartWindow.config_path)
        If allow_access_node_cb.Checked = True Then
            ini.SetKeyValue("config", "own_access_node", 0)
            listen_port_txt.Enabled = True
        Else
            ini.SetKeyValue("config", "own_access_node", 1)
            listen_port_txt.Enabled = False
            ini.SetKeyValue("config", "own_access_node_port", "")
            listen_port_txt.Text = ""
        End If
        ini.Save(StartWindow.config_path)
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_cb.CheckedChanged
        If save_cb.Checked = True Then
            ini.SetKeyValue("config", "acces_node_save", 0)
            
        Else
            ini.SetKeyValue("config", "acces_node_save", 1)
            ini.SetKeyValue("config", "access_node_host", "")
            ini.SetKeyValue("config", "access_node_port", "")
            scan_host_txt.Text = ""
            scan_port_txt.Text = ""
        End If
        ini.Save(StartWindow.config_path)
    End Sub

    Private Sub scan_host_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scan_host_txt.TextChanged
        ini.Load(StartWindow.config_path)
        Select Case ini.GetKeyValue("config", "acces_node_save")
            Case 0
                ini.SetKeyValue("config", "access_node_host", scan_host_txt.Text)
            Case 1

        End Select
        ini.Save(StartWindow.config_path)
    End Sub

    Private Sub listen_port_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listen_port_txt.TextChanged
        If allow_access_node_cb.Checked = True Then
            ini.Load(StartWindow.config_path)
            ini.SetKeyValue("config", "own_access_node_port", listen_port_txt.Text)
            ini.Save(StartWindow.config_path)

        Else

        End If
        
    End Sub
End Class