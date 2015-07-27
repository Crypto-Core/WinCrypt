Option Strict On

Imports System.IO
Imports Project_WinCrypt.classes

Public Class passwordmanager
    Dim ReadOnly aes As New AES
    Dim ReadOnly root As New DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)

    Public _
        ini As _
            New INIDatei(
                root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini")

    Public schleife As Integer = 0
    Public index As Integer = 0
    Public mgrpass As String

    Private Sub add_bt_Click(sender As Object, e As EventArgs) Handles add_bt.Click
        passwordmanager_add.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles database_viewer.SelectedIndexChanged
        If database_viewer.SelectedItems.Count > 0 Then
            index = CInt(database_viewer.SelectedItems.Item(0).SubItems(2).Text)
            user_txt.Text = ini.WertLesen(CStr(index), "user")
            password_txt.Text = ini.WertLesen(CStr(index), "password")
            source_txt.Text = ini.WertLesen(CStr(index), "source")
            comment_txt.Text = ini.WertLesen(CStr(index), "comment").Replace("\r\n", vbCrLf)
        End If
    End Sub

    Private Sub delete_bt_Click(sender As Object, e As EventArgs) Handles delete_bt.Click
        ini.WertSchreiben(CStr(index), "user", "")
        ini.WertSchreiben(CStr(index), "password", "")
        ini.WertSchreiben(CStr(index), "source", "")
        ini.WertSchreiben(CStr(index), "comment", "")
        ini.WertSchreiben(CStr(index), "index", "|")
        database_viewer.Items.Clear()
        For Each go As String In schleife.ToString
            Do
                schleife += 1
                If ini.WertLesen(Str(schleife), "index") = "" Then
                    schleife = 0
                    Exit Do
                Else
                    If ini.WertLesen(Str(schleife), "index") = "|" Then
                    Else
                        With database_viewer.Items.Add(ini.WertLesen(CStr(schleife), "user"))
                            .SubItems.Add(ini.WertLesen(CStr(schleife), "source"))
                            .SubItems.Add(ini.WertLesen(CStr(schleife), "index"))
                        End With
                    End If
                End If
            Loop
            Return
        Next go
    End Sub

    Private Sub show_bt_Click(sender As Object, e As EventArgs) Handles save_bt.Click
        ini.WertSchreiben(CStr(index), "user", user_txt.Text)
        ini.WertSchreiben(CStr(index), "password", password_txt.Text)
        ini.WertSchreiben(CStr(index), "source", source_txt.Text)
        ini.WertSchreiben(CStr(index), "comment", comment_txt.Text.Replace((vbCrLf), ("\r\n")))
    End Sub

    Private Sub passwordmanager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dim readdb As String
            readdb =
                My.Computer.FileSystem.ReadAllText(
                    root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini")
            If mgrpass = "" Then
            Else
                My.Computer.FileSystem.WriteAllText(
                    root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini",
                    CStr(aes.AESEncrypt(readdb, mgrpass, startwindow.biosid)), False)
            End If
            mgrpass = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub passwordmanager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _
            My.Computer.FileSystem.FileExists(
                root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
            passwordmgr_pass.ShowDialog()
        Else
            If startwindow.langname = "English" Then
                If _
                    MsgBox("It has not yet created any database you want to create a database?", MsgBoxStyle.YesNo) =
                    MsgBoxResult.Yes Then
                    newpwmgrdatabase.ShowDialog()
                Else
                    Me.Close()
                End If
            Else
                If _
                    MsgBox("Es wurde noch keine Datenbank angelegt, möchten Sie eine Datenbank anlegen?",
                           MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    newpwmgrdatabase.ShowDialog()
                Else
                    Me.Close()
                End If
            End If
        End If
        If mgrpass = "" Then
            Me.Close()
        End If
    End Sub

    Private Sub copy_user_bt_Click(sender As Object, e As EventArgs) Handles copy_user_bt.Click
        My.Computer.Clipboard.SetText(user_txt.Text)
        If startwindow.langname = "English" Then
            MsgBox("User has been copied", MsgBoxStyle.Information)
        Else
            MsgBox("Benutzer wurde kopiert", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub copy_password_bt_Click(sender As Object, e As EventArgs) Handles copy_password_bt.Click
        My.Computer.Clipboard.SetText(password_txt.Text)
        If startwindow.langname = "English" Then
            MsgBox("Password has been copied", MsgBoxStyle.Information)
        Else
            MsgBox("Passwort wurde kopiert", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub copy_source_bt_Click(sender As Object, e As EventArgs) Handles copy_source_bt.Click
        My.Computer.Clipboard.SetText(source_txt.Text)
        If startwindow.langname = "English" Then
            MsgBox("Source has been copied", MsgBoxStyle.Information)
        Else
            MsgBox("Quelle wurde kopiert", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Me.Close()
    End Sub

    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = MouseButtons.Left) Then
            wincrypttitle.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else :
        End If
    End Sub

    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = MouseButtons.Left) Then
            form_head.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else :
        End If
    End Sub

    Private Sub user_txt_TextChanged(sender As Object, e As EventArgs) Handles user_txt.TextChanged
        If user_txt.Text.Length > 1 Then
            copy_user_bt.Enabled = True
        Else
            copy_user_bt.Enabled = False
        End If
    End Sub

    Private Sub password_txt_TextChanged(sender As Object, e As EventArgs) Handles password_txt.TextChanged
        If password_txt.Text.Length > 1 Then
            copy_password_bt.Enabled = True
        Else
            copy_password_bt.Enabled = False
        End If
    End Sub

    Private Sub source_txt_TextChanged(sender As Object, e As EventArgs) Handles source_txt.TextChanged
        If source_txt.Text.Length > 1 Then
            copy_source_bt.Enabled = True
        Else
            copy_source_bt.Enabled = False
        End If
    End Sub
End Class