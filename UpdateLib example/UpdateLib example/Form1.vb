Imports UpdateLib
Public Class Form1
    Private WithEvents Update As New AppUpdate
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Text = My.Computer.FileSystem.SpecialDirectories.Temp & "\update.zip"
        TextBox3.Text = My.Computer.FileSystem.SpecialDirectories.Temp & "\update.zip"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SaveFileDialog1.ShowDialog()
        TextBox2.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        OpenFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
            TextBox3.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FolderBrowserDialog1.ShowDialog()
        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath) Then
            TextBox4.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Update.Download_Update(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub Update_DownloadComplete() Handles Update.DownloadComplete
        Update.Start_extract(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub Update_DownloadProgress(ByVal progress_value As Integer, ByVal BytesReceived As Integer, ByVal TotalBytes As Integer) Handles Update.DownloadProgress
        ProgressBar1.Value = progress_value
        Label5.Text = BytesReceived & " from " & TotalBytes
    End Sub

    Private Sub Update_UnzipComplete() Handles Update.UnzipComplete
        MsgBox("Update abgeschlossen")
    End Sub
End Class
