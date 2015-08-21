Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Threading

Public Class updatewindow
    Public WithEvents downloader As WebClient
    Dim ReadOnly root As New DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)

    Dim ReadOnly _
        ini As _
            New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")

    Public version As String
    Public updateversion As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        version = ini.worthreading("Info", "Version")
        Dim checkSSL As New SSL

        If checkSSL.SSL_validation(My.Application.Info.DirectoryPath & "\sig.cer", "https://wincrypt.org") = True Then
            Dim httpRequest As HttpWebRequest = HttpWebRequest.Create("https://wincrypt.org/update/version.html")
            Dim httpResponse As HttpWebResponse = httpRequest.GetResponse()
            Dim reader = New StreamReader(httpResponse.GetResponseStream)
            Dim httpContent As String = reader.ReadToEnd
            updateversion = httpContent
            If version < updateversion Then
                Dim newupdate =
                        MsgBox(
                            "Update " & updateversion.Insert(1, ".").Insert(3, ".").Insert(5, ".") &
                            " verfügbar, möchten Sie das Update herunterladen?", MsgBoxStyle.YesNo)
                If newupdate = MsgBoxResult.Yes Then
                    Try
                        Process.GetProcessesByName("Project WinCrypt")(0).Kill()
                        Thread.Sleep(2000)
                    Catch ex As Exception

                    End Try
                    downloader = New WebClient
                    downloader.DownloadFileAsync(New Uri("https://wincrypt.org/update/files/update.zip"),
                                                 My.Computer.FileSystem.SpecialDirectories.Temp & "\update.zip")
                End If
                If newupdate = MsgBoxResult.No Then
                    Application.Exit()
                End If
            Else
                MsgBox("Es stehen keine neuen Updates zur Verfügung!")
                Application.Exit()
            End If
        Else
            MessageBox.Show("The SSL certificate does not match with the original SSL certificate!", "SSL validation error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Application.Exit()
        End If

    End Sub

    Private Sub downloader_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) _
        Handles downloader.DownloadFileCompleted
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.CurrentDirectory) Then
            Dim di As New DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
            For Each fi As FileInfo In di.GetFiles("*.*", SearchOption.AllDirectories)
                If fi.Name = "WinCryptUpdate.exe" Then
                Else
                    My.Computer.FileSystem.DeleteFile(fi.FullName)
                End If
            Next
            Dim alleOrdner() As String
            alleOrdner = Directory.GetDirectories(My.Computer.FileSystem.CurrentDirectory)
            For i = 0 To alleOrdner.Length - 1
                If alleOrdner(i) <> My.Computer.FileSystem.CurrentDirectory Then
                    My.Computer.FileSystem.DeleteDirectory(alleOrdner(i), FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
            Next i
        Else
        End If
        Dim extract As New Unzip(My.Computer.FileSystem.SpecialDirectories.Temp & "\update.zip", My.Computer.FileSystem.CurrentDirectory)
        extract.UnzipNow()
    End Sub

    Private Sub downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) _
        Handles downloader.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Label1.Text = e.BytesReceived & " von " & e.TotalBytesToReceive & " bytes"
    End Sub
End Class
