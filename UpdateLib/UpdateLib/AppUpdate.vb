Imports System.Net
Imports System.IO
Imports System.ComponentModel

Public Class AppUpdate
    Private WithEvents downloader As WebClient
    Private WithEvents unzipfile As Unzip

    ''' <summary>New instance of ZipDownload class.</summary>
    ''' <param name="Zip_from">From where the ZIP is downloaded. ( e.g. https://localhost/update.zip )</param>
    ''' <param name="Zip_to">Destination folder where the update is to be saved. ( e.g. the Temp directory )</param>
    ''' <remarks></remarks>
    Public Sub ZipDownload(ByVal Zip_from As String, Zip_to As String)
        downloader = New WebClient
        downloader.DownloadFileAsync(New Uri(Zip_from), Zip_to)
    End Sub
    ''' <summary>Event which before unpacking (Unzip) is executed.</summary>
    ''' <param name="progress_value">Displays the current status of progress.</param>
    ''' <param name="TotalBytes">Displays the size of the zip file to.</param>
    ''' <param name="bytes">Shows how many bytes have been downloaded.</param>
    ''' <remarks></remarks>
    Public Event DownloadProgress(ByVal progress_value As Integer, ByVal TotalBytes As Integer, bytes As Integer)

    ''' <summary>Event is executed when the download is complete.</summary>
    ''' <remarks></remarks>
    Public Event DownloadFinish()

    ''' <summary>Event is executed if that is finished unpacking.</summary>
    ''' <remarks></remarks>
    Public Event extractUpdateComplete()

    ''' <summary>New instance of ClassUnzip class.</summary>
    ''' <param name="localZip_from">Path where the downloaded zip</param>
    ''' <param name="extract_to">Destination folder where the update is to be unpacked.</param>
    ''' <param name="deleteFiles">Query whether the files (incl. Folders) to be deleted in the destination folder before being unpacked.</param>
    ''' <param name="Delete_file_exception">Except that file should not be deleted. Normally, it is the application which performs the update. (The UpdateLib.ddl is always excluded)</param>
    ''' <remarks></remarks>
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
                            If fi.Name = "UpdateLib.ddl" Then
                            Else
                                My.Computer.FileSystem.DeleteFile(fi.FullName)
                            End If
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
        unzipfile.UnzipNow()
    End Sub

    Private Sub downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged
        RaiseEvent DownloadProgress(e.ProgressPercentage, e.TotalBytesToReceive, e.BytesReceived)
    End Sub

    Private Sub downloader_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles downloader.DownloadFileCompleted
        RaiseEvent DownloadFinish()
    End Sub

    Private Sub unzipfile_UnzipFinishd() Handles unzipfile.UnzipFinishd
        RaiseEvent extractUpdateComplete()
    End Sub
End Class
