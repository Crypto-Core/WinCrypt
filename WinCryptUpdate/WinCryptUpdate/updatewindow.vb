Imports System.Diagnostics
Imports System.Net
Imports System.IO
Public Class updatewindow
    Public WithEvents downloader As WebClient
    Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
    Dim ini As New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")
    Public version As String
    Public updateversion As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        version = ini.WertLesen("Info", "Version")
        Dim httpRequest As HttpWebRequest = HttpWebRequest.Create("http://wincrypt.org/update/index.html")
        Dim httpResponse As HttpWebResponse = httpRequest.GetResponse()
        Dim reader As StreamReader = New StreamReader(httpResponse.GetResponseStream)
        Dim httpContent As String = reader.ReadToEnd
        updateversion = httpContent
        If version < updateversion Then
            Dim newupdate = MsgBox("Update " & updateversion.Insert(1, ".").Insert(3, ".").Insert(5, ".") & " verfügbar, möchten Sie das Update herunterladen?", MsgBoxStyle.YesNo)
            If newupdate = MsgBoxResult.Yes Then
                Try
                    Process.GetProcessesByName("Project WinCrypt")(0).Kill()
                    Threading.Thread.Sleep(2000)
                Catch ex As Exception

                End Try
                downloader = New WebClient
                downloader.DownloadFileAsync(New Uri("http://wincrypt.org/update/files/Project%20WinCrypt.exe"), My.Computer.FileSystem.CurrentDirectory & "\Project WinCrypt.exe")
            End If
            If newupdate = MsgBoxResult.No Then
                Application.Exit()
            End If
        Else
            MsgBox("Es stehen keine neuen Updates zur Verfügung!")
            Application.Exit()
        End If

    End Sub

    Private Sub downloader_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles downloader.DownloadFileCompleted
        Process.Start(My.Computer.FileSystem.CurrentDirectory & "\Project WinCrypt.exe")
        Me.Close()
    End Sub

    Private Sub downloader_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Label1.Text = e.BytesReceived & " von " & e.TotalBytesToReceive & " bytes"
    End Sub
End Class
