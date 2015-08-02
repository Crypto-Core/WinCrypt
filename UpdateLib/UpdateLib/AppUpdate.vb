Imports System.Net
Imports System.IO
Imports System.ComponentModel

Public Class AppUpdate
    Private WithEvents downloader As WebClient
    Private WithEvents unzipfile As Unzip
    Public Sub ZipDownload(ByVal Zip_from As String, Zip_to As String)
        downloader = New WebClient
        downloader.DownloadFileAsync(New Uri(Zip_from), Zip_to)
    End Sub
    Public Event DownloadProgress(ByVal progress_value As Integer, ByVal TotalBytes As Integer, bytes As Integer)
    Public Event DownloadFinish()
    Public Sub extract_update(ByVal localZip_from As String, ByVal extract_to As String, deleteFiles As Boolean, ByVal Delete_file_exception As String)
        If deleteFiles = True Then
            If My.Computer.FileSystem.DirectoryExists(extract_to) Then
                Dim di As New DirectoryInfo(extract_to)
                For Each fi As FileInfo In di.GetFiles("*.*", SearchOption.AllDirectories)
                    If Delete_file_exception = "" Then
                        My.Computer.FileSystem.DeleteFile(fi.FullName)
                    Else
                        If fi.Name = Delete_file_exception Then
                        Else
                            My.Computer.FileSystem.DeleteFile(fi.FullName)
                        End If
                    End If
                Next
                Dim alleOrdner() As String
                alleOrdner = Directory.GetDirectories(extract_to)
                For i = 0 To alleOrdner.Length - 1
                    If alleOrdner(i) <> extract_to Then
                        My.Computer.FileSystem.DeleteDirectory(alleOrdner(i), FileIO.DeleteDirectoryOption.DeleteAllContents)
                    End If
                Next i
            Else
            End If
        Else : End If
        unzipfile = New Unzip(localZip_from, extract_to)


    End Sub

    Private Sub downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged
        RaiseEvent DownloadProgress(e.ProgressPercentage, e.TotalBytesToReceive, e.BytesReceived)
    End Sub

    Private Sub downloader_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles downloader.DownloadFileCompleted
        RaiseEvent DownloadFinish()
    End Sub
End Class
