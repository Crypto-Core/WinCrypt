Imports System.IO
Imports TrezorCrypt.IniFile.IniSection
Imports TrezorCrypt.IniFile

Public Class main_frm
    Friend loadCountDevices As Integer
    Friend Shared EraseRepeat As Integer = 3
    Friend Shared OpenSyncPathafterDecryption As Integer = 0
    Friend Shared configINI As New IniFile
    Private Sub main_panel_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles main_panel.HandleCreated
        ' devices_view wird bereinigt
        devices_view.Items.Clear()

        'Die Anzahl der Geräte wird deklariert
        loadCountDevices = devices.GetDevicesName.Count

        'Die USB Geräte werden in der devices_view aufgelistet
        For index As Integer = 0 To devices.GetDevicesName.Count - 1
            With devices_view.Items.Add(devices.DriveLetter.Item(index), 0)
                .SubItems.Add(devices.GetDevicesName.Item(index))
                .SubItems.Add(ToFuzzyByteString(devices.DriveSize.Item(index)))
                .SubItems.Add(devices.GetDevicesSerial.Item(index))
            End With
        Next

        'Dem Synchronastionspfad wird der Desktop vordefiniert (Wenn gewünscht)
        sync_path_txt.Text = My.Computer.FileSystem.SpecialDirectories.Desktop & "\TrezorSync"
    End Sub

    ' Die Bytegröße wird abgekürzt
    Public Shared Function ToFuzzyByteString(ByVal bytes As Long) As String
        Dim s As Double = bytes
        Dim format As String() = New String() {"{0} bytes", "{0} KB", "{0} MB", "{0} GB", "{0} TB", "{0} PB", _
         "{0} EB"}

        Dim i As Integer = 0

        While i < format.Length AndAlso s >= 1024
            s = CLng(Math.Truncate(100 * s / 1024)) / 100.0
            i += 1
        End While
        Return String.Format(format(i), s)
    End Function

    'Der Nutzer Bestimmt seinen eigenen Synchronisationspfad
    Private Sub open_folderdiag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_folderdiag.Click
        folder_diag.ShowDialog()

        If folder_diag.SelectedPath = "" Then
            sync_path_txt.Text = My.Computer.FileSystem.SpecialDirectories.Desktop & "\TrezorSync"
        Else
            sync_path_txt.Text = folder_diag.SelectedPath
        End If
    End Sub

    'Die Geräte werden automatisch neugeladen, jede 0,5 sek.
    Private Sub synDriveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles synDriveTimer.Tick
        If loadCountDevices <> devices.GetDevicesName.Count Then
            loadCountDevices = devices.GetDevicesName.Count
            devices_view.Items.Clear()
            For index As Integer = 0 To devices.GetDevicesName.Count - 1
                With devices_view.Items.Add(devices.DriveLetter.Item(index), 0)
                    .SubItems.Add(devices.GetDevicesName.Item(index))
                    .SubItems.Add(ToFuzzyByteString(devices.DriveSize.Item(index)))
                    .SubItems.Add(devices.GetDevicesSerial.Item(index))
                End With
            Next
        End If
    End Sub

    'Es wird die Zahl des Ausgewählten Gerätes deklariert
    Public Shared selectedDevice As Integer

    'Die Seite enterpwd.main_panel wird geladen und die eigene main_panel versteckt
    Private Sub next_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles next_bt.Click
        If devices_view.SelectedIndices.Count > 0 Then
            On Error Resume Next
            selectedDevice = devices_view.SelectedIndices.Item(0).ToString
            main_panel.Hide()
            Controls.Add(password_page.main_panel)
            password_page.main_panel.Show()
            password_page.device_lb.Text = devices.DriveLetter.Item(main_frm.selectedDevice)
            password_page.product_lb.Text = devices.GetDevicesName.Item(main_frm.selectedDevice)
            password_page.size_lb.Text = main_frm.ToFuzzyByteString(devices.DriveSize.Item(main_frm.selectedDevice))
            password_page.serial_lb.Text = devices.GetDevicesSerial.Item(main_frm.selectedDevice)
        End If
    End Sub
    Friend loadini As New IniFile
    Private Sub main_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If File.Exists(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\config.ini") = False Then
            configINI.AddSection("Config")
            configINI.SetKeyValue("Config", "OpenSyncPathafterDecryption", 0)
            configINI.SetKeyValue("Config", "Listenmode", 0)
            configINI.Save(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\config.ini")
            configINI.Load(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\config.ini")
            OpenSyncPathafterDecryption = configINI.GetKeyValue("Config", "OpenSyncPathafterDecryption")
        Else
            configINI.Load(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\config.ini")
            OpenSyncPathafterDecryption = configINI.GetKeyValue("Config", "OpenSyncPathafterDecryption")
        End If
        'Es wird überprüft ob der Nutzer seinen USB bereits entschlüsselt hat
        If enterpwd.isDecrypt = True Then
            'Wenn ja dann soll das main_frm angezeigt werden
            Visible = True
            ShowInTaskbar = True
            WindowState = FormWindowState.Normal
            Show()
        Else
            loadini.Load(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\config.ini")
            'Es wird überprüft ob die Datei device.ini existiert
            If loadini.GetKeyValue("Config", "Listenmode") = 1 Then
                'Wenn ja, dann soll der Inhalt geladen werden
                'loadini.Load(My.Application.Info.DirectoryPath & "\devices.ini")
                'Die main_frm wird versteckt
                Me.Visible = False
                ShowInTaskbar = False
                WindowState = FormWindowState.Minimized
                'Der Timer zum automatischen neuladen der Geräte wird ausgeschaltet
                synDriveTimer.Enabled = False
                'Jetzt wird das USB Gerät gesucht, bzw. es wird gelauscht bis es angeschlossen wird
                checkList.Enabled = True

                'Zeige dem Ntuzer die Information an das jetzt nach dem USB Gerät gelauscht wird
                NotifyIcon.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon.BalloonTipTitle = "TrezorCrypt"
                NotifyIcon.BalloonTipText = "Listen for registried USB Device"
                NotifyIcon.ShowBalloonTip(2000)
            Else

            End If
        End If

    End Sub

    Private Sub checkList_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkList.Tick
        For Each driveIndex In DriveInfo.GetDrives
            If driveIndex.DriveType = DriveType.Removable Then
                Dim index As Integer = 0
                For Each getDrives In devices.GetDevicesSerial

                    If File.Exists(driveIndex.Name & "\" & rHash.HashString(getDrives, rHash.HASH.MD5)) = True Then
                        checkList.Enabled = False
                        enterpwd.Letter = driveIndex.Name
                        enterpwd.USBName = devices.GetDevicesName(index)
                        index += 1
                        SecureDesktop.StartSecureWindow(enterpwd)

                    End If
                Next
            End If
        Next
    End Sub
    Sub secure()
        'Die Klasse SecureDesktop wird secure() angewiesen.

    End Sub
    'Wenn der Nutzer doppelklickt auf das NotifyIcon
    Private Sub NotifyIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        If enterpwd.isDecrypt = True Then
            CryptMain.WindowState = FormWindowState.Normal
            CryptMain.Show()
            CryptMain.BringToFront()
        Else : End If
    End Sub
    'Wenn er den Exit Button klickt
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        NotifyIcon.Visible = False
        If enterpwd.isDecrypt = True Then : Else
            Application.Exit()
        End If
    End Sub

    Private Sub SettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingToolStripMenuItem.Click
        setting.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub

    Private Sub SettingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingToolStripMenuItem1.Click
        setting.ShowDialog()
    End Sub
End Class
