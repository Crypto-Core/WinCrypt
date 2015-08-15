Imports System.IO
Public Class install_frm
    Dim _root As New DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
    Dim InstallPath As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\FileZilla FTP Client"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        save_path_txt.Text = InstallPath

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles select_path_bt.Click
        FolderBrowserDialog1.ShowDialog()
        save_path_txt.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles install_bt.Click
        If My.Computer.FileSystem.DirectoryExists(InstallPath) Then
            If My.Computer.FileSystem.FileExists(InstallPath & "\client.exe") Then
                MsgBox("Das Plugin wurde bereits installiert!", MsgBoxStyle.Information)
            Else
                If My.Computer.FileSystem.FileExists(InstallPath & "\filezilla.exe") Then
                    My.Computer.FileSystem.RenameFile(InstallPath & "\filezilla.exe", "client.exe")
                    Dim extract As New FileStream(InstallPath & "\filezilla.exe", FileMode.Create)
                    extract.Write(My.Resources.filezilla, 0, My.Resources.filezilla.Length)
                    extract.Close()
                    MessageBox.Show("Plugin wurde erfolgreich installiert!", "Installiert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Application.Exit()
                Else
                    MessageBox.Show("filezilla.exe existiert nicht!", "Datei existiert nicht", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        End If
    End Sub
End Class
