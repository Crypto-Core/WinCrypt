Imports System.Xml
Imports System.IO

Public Class newPass
    Dim _root As New DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
    Dim filePath As String = _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\FileZilla\recentservers.xml"
    Dim EncryptfilePath As String = _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\FileZilla\recentservers.xml.aes"
    Private Sub newPass_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub newPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ok_bt.Click
        classes.EncryptFile(password_txt.Text, filePath, EncryptfilePath)
        classes.EncryptFile(password_txt.Text, _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\FileZilla\filezilla.xml", _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\FileZilla\filezilla.xml.aes")
        My.Computer.FileSystem.DeleteFile(filePath)
        My.Computer.FileSystem.DeleteFile(_root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\FileZilla\filezilla.xml")
        MessageBox.Show("Neues Kennwort wurde gesetzt!", "FileZilla - Neues Kennwort", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Application.Restart()
    End Sub
End Class