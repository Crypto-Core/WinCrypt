Imports System.Net
Imports System.IO
Module Update
    Private WithEvents downloadFile As New WebClient
    Private downloadString As New Net.WebClient
    Friend Function CheckVersion(ByVal https_host As String)
        Dim version As Double = CDbl(downloadString.DownloadString(https_host & "/version"))
        Dim currentVersion As Double = CDbl(My.Application.Info.Version.ToString.Replace(".", ""))
        If version > currentVersion Then
            Dim updateAv As String = language.ini.GetKeyValue("Update", "AvailableMSG")
            Dim updateAvTitle As String = language.ini.GetKeyValue("Update", "AvailableMSGTitle")
            If MessageBox.Show(updateAv, updateAvTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Update(https_host)
            End If
        Else
            Dim NoAvUpdate As String = language.ini.GetKeyValue("Update", "NoAvMSG")
            Dim NoAvUpdateTitle As String = language.ini.GetKeyValue("Update", "NoAvMSGTitle")
            MessageBox.Show(NoAvUpdate, NoAvUpdateTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function

    Friend Function CheckUpdateOnStart(ByVal https_host As String)
        On Error Resume Next
        Dim version As Double = CDbl(downloadString.DownloadString(https_host & "/version"))
        Dim currentVersion As Double = CDbl(My.Application.Info.Version.ToString.Replace(".", ""))
        If version > currentVersion Then
            Dim updateAv As String = language.ini.GetKeyValue("Update", "AvailableMSG")
            Dim updateAvTitle As String = language.ini.GetKeyValue("Update", "AvailableMSGTitle")
            If MessageBox.Show(updateAv, updateAvTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Update(https_host)
            End If
        Else
            Exit Function
        End If

    End Function
    Friend Function Update(ByVal https_host As String)
        Dim readDownlodFiles As String() = ReadLines(downloadString.DownloadString(https_host & "/fileList"))
        Control.CheckForIllegalCrossThreadCalls = False
        Dim trd As New Threading.Thread(AddressOf update_frm.ShowDialog)
        trd.Start()
        System.Threading.Thread.Sleep(1000)
        update_frm.ProgressBar1.Maximum = readDownlodFiles.Count
        Dim pack_lb As String = "File {0} of " & readDownlodFiles.Count
        update_frm.pack_lb.Text = "File 0 of " & readDownlodFiles.Count
        For Each getFiles In readDownlodFiles
            Select Case getFiles
                Case ""

                Case Else
                    Dim fileName As String = getFiles.Replace(https_host, "").Replace("/files", "").Replace("/", OS.OS_slash)
                    Dim inDir As String = fileName.Substring(0, fileName.LastIndexOf("\"))
                    If inDir = Nothing Then : Else
                        Directory.CreateDirectory(My.Application.Info.DirectoryPath & inDir)
                    End If
                    If fileName = "\Eran.exe" Then
                        Try
                            My.Computer.FileSystem.RenameFile(System.Windows.Forms.Application.ExecutablePath, "eran.bak")
                        Catch ex As IOException
                            File.Delete(My.Application.Info.DirectoryPath & "\eran.bak")
                            My.Computer.FileSystem.RenameFile(System.Windows.Forms.Application.ExecutablePath, "eran.bak")
                        End Try

                        Dim cacheName As String = IO.Path.GetFileName(System.Windows.Forms.Application.ExecutablePath)
                        downloadFile.DownloadFile(New Uri(https_host & getFiles), System.Windows.Forms.Application.ExecutablePath)
                        Using sw As New IO.StreamWriter(System.Windows.Forms.Application.StartupPath & "\uninstall.bat")
                            With sw
                                .WriteLine("@CD /D %~d0%~p0")
                                .WriteLine("@ERASE /Q /F """ & "eran.bak" & """")
                                .WriteLine("@start " & cacheName & "")
                                .WriteLine("@ERASE /Q /F uninstall.bat")
                            End With
                        End Using
                        Shell(System.Windows.Forms.Application.StartupPath & "\uninstall.bat", AppWinStyle.Hide)
                        End
                    Else
                        downloadFile.DownloadFile(New Uri(https_host & getFiles), My.Application.Info.DirectoryPath & fileName)
                    End If
                    update_frm.ProgressBar1.Value += 1
                    update_frm.pack_lb.Text = pack_lb.Replace("{0}", update_frm.ProgressBar1.Value)
            End Select
        Next
    End Function
    Private Function ReadLines(ByVal str As String) As String()
        Dim strsSplitted() As String
        strsSplitted = Split(str, vbLf)
        Return strsSplitted
    End Function
End Module
