Option Strict On

Imports System.IO
Imports Project_WinCrypt.classes

Public Class Newpwmgrdatabase
    ReadOnly _aes As New AES
    ReadOnly _root As New DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)

    Private Sub createdb_bt_Click(sender As Object, e As EventArgs) Handles createdb_bt.Click
        If password_txt.Text.Length < 8 Then
            If Startwindow.Langname = "English" Then
                MsgBox("The password must consist of at least 8 characters!", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Das Passwort muss mindestens aus 8 Zeichen bestehen!", MsgBoxStyle.Exclamation)
            End If
        Else
            Dim newentry As String = "[1]" & vbCrLf & "user=" & vbCrLf & "password=" & vbCrLf & "source=" & vbCrLf &
                                     "comment=" & vbCrLf & "index=|"
            My.Computer.FileSystem.WriteAllText(
                _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini",
                CStr(_aes.AESEncrypt(newentry, password_txt.Text, Startwindow.Biosid)), False)
            tools.passwordmanager.Passwordmanager.Mgrpass = password_txt.Text
            If Startwindow.Langname = "English" Then
                MsgBox("Database has been successfully created!", MsgBoxStyle.Information)
            Else
                MsgBox("Datenbank wurde erfolgreich angelegt!", MsgBoxStyle.Information)
            End If
            Dim textdecrypt As String
            textdecrypt =
                _aes.AESDecrypt(
                    My.Computer.FileSystem.ReadAllText(
                        _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini"),
                    password_txt.Text, Startwindow.Biosid)
            My.Computer.FileSystem.WriteAllText(
                _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini",
                textdecrypt, False)
            tools.passwordmanager.Passwordmanager.database_viewer.Items.Clear()
            For Each go In tools.passwordmanager.Passwordmanager.Schleife.ToString
                Do
                    tools.passwordmanager.Passwordmanager.Schleife += 1
                    If tools.passwordmanager.Passwordmanager.Ini.WertLesen(Str(tools.passwordmanager.Passwordmanager.Schleife), "index") = "" Then
                        tools.passwordmanager.Passwordmanager.Schleife = 0
                        Exit Do
                    Else
                        If tools.passwordmanager.Passwordmanager.Ini.WertLesen(Str(tools.passwordmanager.Passwordmanager.Schleife), "index") = "|" Then
                        Else
                            With _
                                tools.passwordmanager.Passwordmanager.database_viewer.Items.Add(
                                    tools.passwordmanager.Passwordmanager.Ini.WertLesen(CStr(tools.passwordmanager.Passwordmanager.Schleife), "user"))
                                .SubItems.Add(tools.passwordmanager.Passwordmanager.Ini.WertLesen(CStr(tools.passwordmanager.Passwordmanager.Schleife), "source"))
                                .SubItems.Add(tools.passwordmanager.Passwordmanager.Ini.WertLesen(CStr(tools.passwordmanager.Passwordmanager.Schleife), "index"))
                            End With
                        End If
                    End If
                Loop
                Close()
                Return
            Next go
        End If
    End Sub

    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = MouseButtons.Left) Then
            wincrypttitle.Capture = False
            WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else
        End If
    End Sub

    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = MouseButtons.Left) Then
            form_head.Capture = False
            WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Close()
    End Sub

    Private Sub password_txt_KeyDown(sender As Object, e As KeyEventArgs) Handles password_txt.KeyDown
        If e.KeyCode = Keys.Enter Then
            createdb_bt.PerformClick()
        End If
    End Sub
End Class