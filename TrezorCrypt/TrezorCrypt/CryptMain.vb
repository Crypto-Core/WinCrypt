Imports System.IO
Imports System.Threading
Imports System
Imports System.Collections.Specialized

Public Class CryptMain
    Friend serial As String
    Friend letter As String
    Friend USBName As String
    Friend SyncPath As String
    Friend ini As New IniFile
    Friend algo As String
    Friend blocksize As Integer
    Friend clipher As String
    Friend aes As New AESEncrypt
    Friend Shared trd As Thread
    Friend isExit As Boolean = False
    Private Sub CryptMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If isExit = False Then
            e.Cancel = True
            Me.Hide()
        End If
        
    End Sub
    Private Sub CryptMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each tt In DriveInfo.GetDrives
            If tt.Name = device_lb.Text Then
                size_lb.Text = main_frm.ToFuzzyByteString(tt.TotalSize)
            End If
        Next
        ini.Load(device_lb.Text & "device.ini")
        serial = ini.GetKeyValue("Device", "Serial")
        letter = device_lb.Text
        USBName = ini.GetKeyValue("Device", "Name")
        SyncPath = ini.GetKeyValue("Device", "SyncPath")
        algo = ini.GetKeyValue("Device", "Algorithm")
        blocksize = ini.GetKeyValue("Device", "Blocksize")
        clipher = enterpwd.clipher
        enterpwd.clipher = ""
        Directory.CreateDirectory(SyncPath)
        Dim wrk As New Worker
        wrk.Path = SyncPath
        wrk.Letter = letter
        wrk.Blocksize = blocksize
        wrk.Algorithm = algo
        wrk.Clipher = clipher
        trd = New Thread(AddressOf wrk.Start)
        trd.IsBackground = True
        MenuStrip.Enabled = False
        trd.Start()
        prg.Enabled = True
        fsw.Path = SyncPath
    End Sub
    Friend Shared isDisconnected As Boolean = False
    Private Sub isEmbedUSB_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles isEmbedUSB.Tick

        If devices.isDriveEmbed(serial_lb.Text) = True Then
            lock_img.Image = My.Resources._1457579252_lock_unlock
        Else
            Try
                lock_img.Image = My.Resources._1457579322_lock
                isDisconnected = True
                isEmbedUSB.Enabled = False
                trd.Abort()
                fsw.EnableRaisingEvents = False
                If Worker.error_feedback = True Then
                    If MessageBox.Show("It could not encrypt all files in the synchronization folder. The synchronization folder will therefore not be deleted." & vbNewLine & "Wanna check out the errors?", "Encryption Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        Application.Exit()
                    Else

                    End If
                Else

                    Dim SafeDelete As New SafedeleteFunction
                    For Each DeleteFiles In Directory.GetFiles(SyncPath, "*.*", SearchOption.AllDirectories)
                        SafedeleteFunction.SafeErase(DeleteFiles)
                        state_lst.Items.Add("Erase: " & ShortPath(DeleteFiles))
                        state_lst.TopIndex = state_lst.Items.Count - 1
                    Next
                    isExit = True
                    Directory.Delete(SyncPath, True)
                End If

            Catch ex As Exception
                main_frm.NotifyIcon.Visible = False
                Application.Restart()
            End Try
            main_frm.NotifyIcon.Visible = False
            Application.Restart()
        End If
    End Sub

    Private Sub fsw_Changed(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles fsw.Changed
        If Worker.isDecrypted_files = True Then
            state_lst.Items.Add("Changed: " & ShortPath(e.FullPath))
            state_lst.TopIndex = state_lst.Items.Count - 1
        Else
            state_lst.Items.Add("Decrypted: " & ShortPath(e.FullPath))
            state_lst.TopIndex = state_lst.Items.Count - 1
        End If
    End Sub

    Private Sub fsw_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles fsw.Created
        If Worker.isDecrypted_files = True Then
            state_lst.Items.Add("Encrypt: " & ShortPath(e.FullPath))
            state_lst.TopIndex = state_lst.Items.Count - 1
        Else

        End If

    End Sub

    Private Sub fsw_Deleted(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles fsw.Deleted
        state_lst.Items.Add("Deleted: " & ShortPath(e.FullPath))
        state_lst.TopIndex = state_lst.Items.Count - 1
    End Sub

    Private Sub fsw_Renamed(ByVal sender As Object, ByVal e As System.IO.RenamedEventArgs) Handles fsw.Renamed
        state_lst.Items.Add("Renamed: " & ShortPath(e.FullPath))
        state_lst.TopIndex = state_lst.Items.Count - 1
    End Sub
    Private Function ShortPath(ByVal str As String) As String
        Dim arrSTR() As String = str.Split("\")
        Dim subSlash As String = arrSTR(arrSTR.Count / 2)
        Dim a As String = str.Substring(0, str.IndexOf(subSlash))
        Dim b As String = str.Substring(str.LastIndexOf("\"), str.Length - str.LastIndexOf("\"))
        Return a & "..." & b
    End Function
    Private Sub prg_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prg.Tick
        If Worker.max_files > 0 Then
            statebar.Maximum = Worker.max_files
            statebar.Value = Worker.value_files
            If statebar.Value = statebar.Maximum Then
                prg.Enabled = False
                MenuStrip.Enabled = True
                Worker.max_files = 0
                Worker.value_files = 0
                statebar.MarqueeAnimationSpeed = 40
                statebar.Style = ProgressBarStyle.Marquee
                If main_frm.OpenSyncPathafterDecryption = 1 Then
                    Process.Start("explorer.exe", SyncPath)
                    Me.WindowState = FormWindowState.Minimized
                    Me.Hide()
                Else

                End If

            End If
        End If

    End Sub

    Private Sub LockoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockoutToolStripMenuItem.Click
        isExit = True
        Try
            lock_img.Image = My.Resources._1457579322_lock
            isDisconnected = True
            isEmbedUSB.Enabled = False
            trd.Abort()
            fsw.EnableRaisingEvents = False
            If Worker.error_feedback = True Then
                If MessageBox.Show("It could not encrypt all files in the synchronization folder. The synchronization folder will therefore not be deleted." & vbNewLine & "Wanna check out the errors?", "Encryption Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    Dim read_err As String
                    For Each errors In Worker.error_lst
                        read_err = +errors & vbNewLine & vbNewLine
                    Next
                    My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Desktop & "\TrezorCrypt error log.log", read_err, False)
                Else

                End If
            Else

                Dim SafeDelete As New SafedeleteFunction
                For Each DeleteFiles In Directory.GetFiles(SyncPath, "*.*", SearchOption.AllDirectories)
                    SafedeleteFunction.SafeErase(DeleteFiles)
                    state_lst.Items.Add("Erase: " & ShortPath(DeleteFiles))
                    state_lst.TopIndex = state_lst.Items.Count - 1
                Next
                Directory.Delete(SyncPath, True)
            End If

        Catch ex As Exception
            main_frm.NotifyIcon.Visible = False
            Application.Exit()
        End Try
        main_frm.NotifyIcon.Visible = False
        Application.Exit()
    End Sub

    Private Sub SettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingToolStripMenuItem.Click
        setting.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub
End Class