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
        trd.Start()
        
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
                Dim SafeDelete As New SafedeleteFunction
                For Each DeleteFiles In Directory.GetFiles(SyncPath, "*.*", SearchOption.AllDirectories)
                    SafeDelete.SafeEraser(DeleteFiles, 3, True)
                    state_lst.Items.Add("Erase: " & ShortPath(DeleteFiles))
                    state_lst.TopIndex = state_lst.Items.Count - 1
                Next
                Directory.Delete(SyncPath, True)
            Catch ex As Exception
                main_frm.NotifyIcon.Visible = False
                Application.Restart()
            End Try
            main_frm.NotifyIcon.Visible = False
            Application.Restart()
        End If
    End Sub

    Private Sub FileSystemWatcher1_Changed(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles fsw.Changed
        state_lst.Items.Add("Changed: " & ShortPath(e.FullPath))
        state_lst.TopIndex = state_lst.Items.Count - 1
    End Sub

    Private Sub FileSystemWatcher1_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles fsw.Created
        state_lst.Items.Add("Encrypt: " & ShortPath(e.FullPath))
        state_lst.TopIndex = state_lst.Items.Count - 1
    End Sub

    Private Sub FileSystemWatcher1_Deleted(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles fsw.Deleted
        state_lst.Items.Add("Deleted: " & ShortPath(e.FullPath))
        state_lst.TopIndex = state_lst.Items.Count - 1
    End Sub

    Private Sub FileSystemWatcher1_Renamed(ByVal sender As Object, ByVal e As System.IO.RenamedEventArgs) Handles fsw.Renamed
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
End Class