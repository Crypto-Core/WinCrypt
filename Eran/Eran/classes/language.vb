Imports System.IO
Module language
    Friend ini As New IniFile

    Friend Function load()
        If config.language = "" Then : Else
            If File.Exists(My.Application.Info.DirectoryPath & OS.OS_slash.ToString & "language" & OS.OS_slash & config.language) Then
                ini.Load(My.Application.Info.DirectoryPath & OS.OS_slash.ToString & "language" & OS.OS_slash & config.language)
                'main_frm
                main_frm.FileToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "FileToolStripMenuItem")
                main_frm.ExitToolStripMenuItem1.Text = ini.GetKeyValue("main_frm", "ExitToolStripMenuItem1")
                main_frm.UsersToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "UsersToolStripMenuItem")
                main_frm.AddUserToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "AddUserToolStripMenuItem")
                main_frm.AccountToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "AccountToolStripMenuItem")
                main_frm.DisconnectToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "DisconnectToolStripMenuItem")
                main_frm.ConnectionToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "ConnectionToolStripMenuItem")
                main_frm.ShowPublicKeyToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "ShowPublicKeyToolStripMenuItem")
                main_frm.ShowPublicKeyToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "ShowPublicKeyToolStripMenuItem")
                main_frm.ToolsToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "ToolsToolStripMenuItem")
                main_frm.SettingsToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "SettingsToolStripMenuItem")
                main_frm.SendPingToConnectedAccesNodeToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "SendPingToConnectedAccesNodeToolStripMenuItem")
                main_frm.HelpToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "HelpToolStripMenuItem")
                main_frm.AboutToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "AboutToolStripMenuItem")
                main_frm.status_lb.Text = ini.GetKeyValue("main_frm", "status_lb")
                main_frm.status_strip.Text = ini.GetKeyValue("main_frm", "status_strip")
                main_frm.OfflineToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "OfflineToolStripMenuItem")
                main_frm.BusyToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "BusyToolStripMenuItem")
                main_frm.OnlineToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "OnlineToolStripMenuItem")
                main_frm.user_column.Text = ini.GetKeyValue("main_frm", "user_column")
                main_frm.eran_adr_column.Text = ini.GetKeyValue("main_frm", "eran_adr_column")
                main_frm.StartChatToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "StartChatToolStripMenuItem")
                main_frm.CopyEranAddressToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "CopyEranAddressToolStripMenuItem")
                main_frm.DeleteFromListToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "DeleteFromListToolStripMenuItem")
                main_frm.BlockingToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "BlockingToolStripMenuItem")
                main_frm.ReloadListToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "ReloadListToolStripMenuItem")
                main_frm.StateToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "StateToolStripMenuItem")
                main_frm.OnlineToolStripMenuItem1.Text = ini.GetKeyValue("main_frm", "OnlineToolStripMenuItem1")
                main_frm.BusyToolStripMenuItem1.Text = ini.GetKeyValue("main_frm", "BusyToolStripMenuItem1")
                main_frm.OfflineToolStripMenuItem1.Text = ini.GetKeyValue("main_frm", "OfflineToolStripMenuItem1")
                main_frm.OpenToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "OpenToolStripMenuItem")
                main_frm.ExitToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "ExitToolStripMenuItem")
                main_frm.ShowServerKeyToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "ShowServerKeyToolStripMenuItem")
                main_frm.LanguageToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "LanguageToolStripMenuItem")
                main_frm.ExportAccountToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "ExportAccountToolStripMenuItem")
                main_frm.ImportAccountToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "ImportAccountToolStripMenuItem")
                main_frm.CheckUpdateToolStripMenuItem.Text = ini.GetKeyValue("main_frm", "CheckUpdateToolStripMenuItem")

                'add_user
                add_user.Text = ini.GetKeyValue("add_user", "title")
                add_user.eran_adress_lb.Text = ini.GetKeyValue("add_user", "eran_adress_lb")
                add_user.add_bt.Text = ini.GetKeyValue("add_user", "add_bt")

                'about
                about.Text = ini.GetKeyValue("about", "title")
                about.ok_bt.Text = ini.GetKeyValue("about", "ok_bt")

                'connect_frame
                connect_frame.connect_lb.Text = ini.GetKeyValue("connect_frame", "connect_lb")

                'create_account
                create_account.create_eran_acc_gb.Text = ini.GetKeyValue("create_account", "create_eran_acc_gb")
                create_account.usr_lb.Text = ini.GetKeyValue("create_account", "usr_lb")
                create_account.min_chars_urs_lb.Text = ini.GetKeyValue("create_account", "min_chars_urs_lb")
                create_account.pwd_lb.Text = ini.GetKeyValue("create_account", "pwd_lb")
                create_account.min_chars_pwd_lb.Text = ini.GetKeyValue("create_account", "min_chars_pwd_lb")
                create_account.eran_adr_lb.Text = ini.GetKeyValue("create_account", "eran_adr_lb")
                create_account.auth_key_lb.Text = ini.GetKeyValue("create_account", "auth_key_lb")
                create_account.create_bt.Text = ini.GetKeyValue("create_account", "create_bt")

                'FileDialog_
                FileDialog_.Text = ini.GetKeyValue("FileDialog_", "title")
                FileDialog_.name_column.Text = ini.GetKeyValue("FileDialog_", "name_column")
                FileDialog_.type_column.Text = ini.GetKeyValue("FileDialog_", "type_column")
                FileDialog_.size_column.Text = ini.GetKeyValue("FileDialog_", "size_column")
                FileDialog_.creat_time_column.Text = ini.GetKeyValue("FileDialog_", "creat_time_column")
                FileDialog_.filename_lb.Text = ini.GetKeyValue("FileDialog_", "filename_lb")
                FileDialog_.open_bt.Text = ini.GetKeyValue("FileDialog_", "open_bt")
                FileDialog_.cancel_bt.Text = ini.GetKeyValue("FileDialog_", "cancel_bt")

                'FileTransfer
                FileTransfer.Text = ini.GetKeyValue("FileTransfer", "title")
                FileTransfer.brocken_lb.Text = ini.GetKeyValue("FileTransfer", "brocken_lb")
                FileTransfer.hash_lb.Text = ini.GetKeyValue("FileTransfer", "hash_lb")
                FileTransfer.packname_lb.Text = ini.GetKeyValue("FileTransfer", "packname_lb")
                FileTransfer.ok_bt.Text = ini.GetKeyValue("FileTransfer", "ok_bt")

                'login
                login.server_gb.Text = ini.GetKeyValue("login", "server_gb")
                login.port_lb.Text = ini.GetKeyValue("login", "port_lb")
                login.login_gb.Text = ini.GetKeyValue("login", "login_gb")
                login.usr_lb.Text = ini.GetKeyValue("login", "usr_lb")
                login.pwd_lb.Text = ini.GetKeyValue("login", "pwd_lb")
                login.join_bt.Text = ini.GetKeyValue("login", "join_bt")

                'SendFile
                SendFile.Text = ini.GetKeyValue("SendFile", "title")

                'settings
                settings.Text = ini.GetKeyValue("settings", "title")
                settings.startmodus_gb.Text = ini.GetKeyValue("settings", "startmodus_gb")
                settings.startwindow_rb.Text = ini.GetKeyValue("settings", "startwindow_rb")
                settings.start_normal.Text = ini.GetKeyValue("settings", "start_normal")
                settings.secure_desktop_rb.Text = ini.GetKeyValue("settings", "secure_desktop_rb")
                settings.scan_gb.Text = ini.GetKeyValue("settings", "scan_gb")
                settings.save_cb.Text = ini.GetKeyValue("settings", "save_cb")
                settings.host_lb.Text = ini.GetKeyValue("settings", "host_lb")
                settings.port_lb.Text = ini.GetKeyValue("settings", "port_lb")
                settings.own_access_node_gb.Text = ini.GetKeyValue("settings", "own_access_node_gb")
                settings.listen_on_port_lb.Text = ini.GetKeyValue("settings", "listen_on_port_lb")
                settings.allow_access_node_cb.Text = ini.GetKeyValue("settings", "allow_access_node_cb")
                settings.messenger_gb.Text = ini.GetKeyValue("settings", "messenger_gb")
                settings.play_msg_sound.Text = ini.GetKeyValue("settings", "play_msg_sound")
                settings.play_usr_online.Text = ini.GetKeyValue("settings", "play_usr_online")
                settings.encryption_gb.Text = ini.GetKeyValue("settings", "encryption_gb")
                settings.auto_rec_lb.Text = ini.GetKeyValue("settings", "auto_rec_lb")


                'StartWindow
                StartWindow.Text = ini.GetKeyValue("StartWindow", "title")
                StartWindow.msg1.Text = ini.GetKeyValue("StartWindow", "msg1")
                StartWindow.msg2.Text = ini.GetKeyValue("StartWindow", "msg2")
                StartWindow.save_selection_cb.Text = ini.GetKeyValue("StartWindow", "save_selection_cb")
                StartWindow.startNormal_bt.Text = ini.GetKeyValue("StartWindow", "startNormal_bt")
                StartWindow.secureDesktop_bt.Text = ini.GetKeyValue("StartWindow", "secureDesktop_bt")


                'importAccount
                importAccount.Text = ini.GetKeyValue("importAccount", "title")
                importAccount.pwd_lb.Text = ini.GetKeyValue("importAccount", "pwd_lb")
                importAccount.path_lb.Text = ini.GetKeyValue("importAccount", "path_lb")
                importAccount.import_bt.Text = ini.GetKeyValue("importAccount", "import_bt")
            End If
        End If
    End Function
End Module
