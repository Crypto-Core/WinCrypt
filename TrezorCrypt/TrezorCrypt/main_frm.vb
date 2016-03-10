Imports System.IO
Imports TrezorCrypt.IniFile.IniSection
Imports TrezorCrypt.IniFile

Public Class main_frm
    Dim loadCountDevices As Integer
    Private Sub Panel1_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.HandleCreated
        ListView1.Items.Clear()
        loadCountDevices = devices.GetDevicesName.Count
        For index As Integer = 0 To devices.GetDevicesName.Count - 1
            With ListView1.Items.Add(devices.DriveLetter.Item(index), 0)
                .SubItems.Add(devices.GetDevicesName.Item(index))
                .SubItems.Add(ToFuzzyByteString(devices.DriveSize.Item(index)))
                .SubItems.Add(devices.GetDevicesSerial.Item(index))
            End With
        Next
        TextBox1.Text = My.Computer.FileSystem.SpecialDirectories.Desktop & "\TrezorSync"
    End Sub
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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowDialog()

        If FolderBrowserDialog1.SelectedPath = "" Then
            TextBox1.Text = My.Computer.FileSystem.SpecialDirectories.Desktop & "\TrezorSync"
        Else
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub synDriveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles synDriveTimer.Tick
        If loadCountDevices <> devices.GetDevicesName.Count Then
            loadCountDevices = devices.GetDevicesName.Count
            ListView1.Items.Clear()
            For index As Integer = 0 To devices.GetDevicesName.Count - 1
                With ListView1.Items.Add(devices.DriveLetter.Item(index), 0)
                    .SubItems.Add(devices.GetDevicesName.Item(index))
                    .SubItems.Add(ToFuzzyByteString(devices.DriveSize.Item(index)))
                    .SubItems.Add(devices.GetDevicesSerial.Item(index))
                End With
            Next
        End If
    End Sub
    Public Shared selectedDevice As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListView1.SelectedIndices.Count > 0 Then
            On Error Resume Next
            selectedDevice = ListView1.SelectedIndices.Item(0).ToString
            Panel1.Hide()
            Controls.Add(password_page.Panel1)
            password_page.Panel1.Show()
            password_page.device_lb.Text = devices.DriveLetter.Item(main_frm.selectedDevice)
            password_page.product_lb.Text = devices.GetDevicesName.Item(main_frm.selectedDevice)
            password_page.size_lb.Text = main_frm.ToFuzzyByteString(devices.DriveSize.Item(main_frm.selectedDevice))
            password_page.serial_lb.Text = devices.GetDevicesSerial.Item(main_frm.selectedDevice)
        End If
    End Sub
    Dim loadini As New IniFile
    Private Sub main_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If enterpwd.isDecrypt = True Then

            Visible = True
            ShowInTaskbar = True
            WindowState = FormWindowState.Normal
            Show()
        Else

            If File.Exists(My.Application.Info.DirectoryPath & "\devices.ini") = True Then
                loadini.Load(My.Application.Info.DirectoryPath & "\devices.ini")

                Me.Visible = False
                ShowInTaskbar = False
                WindowState = FormWindowState.Minimized


                synDriveTimer.Enabled = False
                checkList.Enabled = True
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.BalloonTipTitle = "TrezorCrypt"
                NotifyIcon1.BalloonTipText = "Listen for registried USB Device"
                NotifyIcon1.ShowBalloonTip(2000)
            End If
        End If
        
    End Sub

    Private Sub checkList_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkList.Tick


        For Each s As IniSection In loadini.Sections
            For Each k As IniSection.IniKey In s.Keys
                If k.Value <> String.Empty Then
                    If devices.isDriveEmbed(k.Value) = True Then
                        If enterpwd.isDecrypt = True Then

                        Else
                            checkList.Enabled = False
                            For index As Integer = 0 To devices.GetDevicesName.Count - 1
                                If devices.GetDevicesSerial.Item(index) = k.Value Then
                                    enterpwd.Letter = devices.DriveLetter.Item(index)
                                    enterpwd.USBName = devices.GetDevicesName(index)
                                End If
                            Next
                            'enterpwd.ShowDialog()
                            secure()
                        End If
                       

                    Else

                    End If
                Else

                End If
            Next
        Next
    End Sub

    Sub secure()
        SecureDesktop.StartSecureWindow(enterpwd)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If enterpwd.isDecrypt = True Then
            CryptMain.Show()
        Else

        End If
    End Sub
End Class
