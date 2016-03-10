Imports System.IO
Imports System.Threading
Imports System
Imports System.Collections.Specialized

Public Class CryptMain
    Dim serial As String
    Dim letter As String
    Dim USBName As String
    Dim SyncPath As String
    Dim ini As New IniFile
    Dim algo As String
    Dim blocksize As Integer
    Dim clipher As String
    Dim aes As New AESEncrypt
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
        SetIcon(SyncPath, My.Computer.FileSystem.SpecialDirectories.Desktop & "\icon.ico")
        SHChangeNotify(&H8000000, &H0&, 0, 0)
        Dim wrk As New Worker
        wrk.Path = SyncPath
        wrk.Letter = letter
        wrk.Blocksize = blocksize
        wrk.Algorithm = algo
        wrk.Clipher = clipher

        trd = New Thread(AddressOf wrk.Start)
        trd.IsBackground = True
        trd.Start()
        
        FileSystemWatcher1.Path = SyncPath
    End Sub
   Private Declare Sub SHChangeNotify Lib "shell32.dll" ( _
     ByVal wEventId As Integer, _
     ByVal uFlags As Integer, _
     ByVal dwItem1 As Integer, _
     ByVal dwItem2 As Integer)
    Public Sub SetIcon(ByVal Folderpath As String, ByVal Iconpath As String)
        My.Computer.FileSystem.WriteAllText(Folderpath & "\desktop.ini", "", False)
        Dim b As New IO.FileInfo(Folderpath & "\desktop.ini")
        Dim FileContent As String = "[.ShellClassInfo]" & vbNewLine & "IconResource=" & Iconpath
        b.Attributes = FileAttributes.Normal
        b.Attributes = FileAttributes.System
        Dim buffer() As Byte = System.Text.Encoding.UTF8.GetBytes(FileContent)
        Dim fs As FileStream = b.OpenWrite()
        fs.Write(buffer, 0, buffer.Length)
        fs.Close()
        Shell("attrib +a +s +h " & Folderpath & "\desktop.ini")

    End Sub
    Friend Shared isDisconnected As Boolean = False
    Private Sub isEmbedUSB_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles isEmbedUSB.Tick

        If devices.isDriveEmbed(serial_lb.Text) = True Then
            PictureBox2.Image = My.Resources._1457579252_lock_unlock
        Else
            Try
                PictureBox2.Image = My.Resources._1457579322_lock
                isDisconnected = True
                isEmbedUSB.Enabled = False
                trd.Abort()
                FileSystemWatcher1.EnableRaisingEvents = False
                Dim SafeDelete As New SafedeleteFunction
                For Each DeleteFiles In Directory.GetFiles(SyncPath, "*.*", SearchOption.AllDirectories)
                    SafeDelete.SafeEraser(DeleteFiles, 3, True)
                    ListBox1.Items.Add("Erase: " & ShortPath(DeleteFiles))
                    ListBox1.TopIndex = ListBox1.Items.Count - 1
                Next
                Directory.Delete(SyncPath, True)
            Catch ex As Exception
                main_frm.NotifyIcon1.Visible = False
                Application.Restart()
            End Try
            main_frm.NotifyIcon1.Visible = False
            Application.Restart()
        End If
    End Sub

    Private Sub FileSystemWatcher1_Changed(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        ListBox1.Items.Add("Changed: " & ShortPath(e.FullPath))
        ListBox1.TopIndex = ListBox1.Items.Count - 1
    End Sub

    Private Sub FileSystemWatcher1_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Created
        ListBox1.Items.Add("Encrypt: " & ShortPath(e.FullPath))
        ListBox1.TopIndex = ListBox1.Items.Count - 1
    End Sub

    Private Sub FileSystemWatcher1_Deleted(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Deleted
        ListBox1.Items.Add("Deleted: " & ShortPath(e.FullPath))
        ListBox1.TopIndex = ListBox1.Items.Count - 1
    End Sub

    Private Sub FileSystemWatcher1_Renamed(ByVal sender As Object, ByVal e As System.IO.RenamedEventArgs) Handles FileSystemWatcher1.Renamed
        ListBox1.Items.Add("Renamed: " & ShortPath(e.FullPath))
        ListBox1.TopIndex = ListBox1.Items.Count - 1
    End Sub
    Private Function ShortPath(ByVal str As String) As String
        Dim arrSTR() As String = str.Split("\")
        Dim subSlash As String = arrSTR(arrSTR.Count / 2)



        Dim a As String = str.Substring(0, str.IndexOf(subSlash))
        Dim b As String = str.Substring(str.LastIndexOf("\"), str.Length - str.LastIndexOf("\"))
        Return a & "..." & b
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SHChangeNotify(&H8000000, &H0&, 0, 0)
    End Sub
End Class