Imports System.IO
Public Class mainfrm
    Dim _root As New DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
    Public filePath As String = _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\FileZilla\recentservers.xml"
    Public EncryptfilePath As String = _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\FileZilla\recentservers.xml.aes"
    Public ExterneAnwendung As New System.Diagnostics.Process()
    Public decrypt As Boolean = False

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles password_txt.TextChanged

    End Sub

    Private Sub mainfrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub mainfrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            ExterneAnwendung.StartInfo.FileName = "client.exe"
            ExterneAnwendung.Kill()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub mainfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExterneAnwendung.StartInfo.FileName = "client.exe"
        If My.Computer.FileSystem.FileExists(filePath) = True Then
            Me.WindowState = FormWindowState.Minimized
            Me.Hide()
            newPass.ShowDialog()

        Else
            If My.Computer.FileSystem.FileExists(EncryptfilePath) Then

            Else
                Process.Start(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\FileZilla FTP Client\client.exe")
                Application.Exit()
            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ok_bt.Click

        decrypt = True
        If password_txt.Text.Length < 8 Then
            MessageBox.Show("Es müssen mindestens 8 Zeichen sein!", "Kennwortlänge", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            classes.DecryptFile(password_txt.Text, EncryptfilePath, filePath)
            classes.DecryptFile(password_txt.Text, _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\FileZilla\filezilla.xml.aes", _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\FileZilla\filezilla.xml")
            If decrypt = True Then
                ExterneAnwendung.Start()
            Else
                My.Computer.FileSystem.DeleteFile(filePath)
                My.Computer.FileSystem.DeleteFile(_root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\FileZilla\filezilla.xml")
                MsgBox("Kennwort ist Falsch!")
            End If

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If ExterneAnwendung.HasExited Then

                Timer1.Enabled = False
                classes.EncryptFile(password_txt.Text, filePath, EncryptfilePath)
                classes.EncryptFile(password_txt.Text, _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\FileZilla\filezilla.xml", _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\FileZilla\filezilla.xml.aes")
                My.Computer.FileSystem.DeleteFile(filePath)
                My.Computer.FileSystem.DeleteFile(_root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\FileZilla\filezilla.xml")
                Application.Exit()
            Else

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles wincrypt_link.LinkClicked
        Process.Start("https://wincrypt.org")
    End Sub
End Class
