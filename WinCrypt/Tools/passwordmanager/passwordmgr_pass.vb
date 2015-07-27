Option Strict On

Imports System.IO

Public Class passwordmgr_pass
    Public pass As String
    Dim ReadOnly aes As New AES
    Dim ReadOnly root As New DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ok_bt.Click
        If password_txt.Text.Length < 8 Then

            If startwindow.langname = "English" Then
                MsgBox("The password must be at least 8 characters estend consist!", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Das Passwort muss mindestend aus 8 Zeichen bestehen!", MsgBoxStyle.Exclamation)
            End If
        Else
            Dim textdecrypt As String
            textdecrypt =
                aes.AESDecrypt(
                    My.Computer.FileSystem.ReadAllText(
                        root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini"),
                    password_txt.Text, startwindow.biosid)
            If textdecrypt = "error" Then
            Else
                passwordmanager.mgrpass = password_txt.Text
                My.Computer.FileSystem.WriteAllText(
                    root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini",
                    textdecrypt, False)
                passwordmanager.database_viewer.Items.Clear()
                For Each go As String In passwordmanager.schleife.ToString
                    Do
                        passwordmanager.schleife += 1
                        If passwordmanager.ini.WertLesen(Str(passwordmanager.schleife), "index") = "" Then
                            passwordmanager.schleife = 0
                            Exit Do
                        Else
                            If passwordmanager.ini.WertLesen(Str(passwordmanager.schleife), "index") = "|" Then
                            Else
                                With _
                                    passwordmanager.database_viewer.Items.Add(
                                        passwordmanager.ini.WertLesen(CStr(passwordmanager.schleife), "user"))
                                    .SubItems.Add(passwordmanager.ini.WertLesen(CStr(passwordmanager.schleife), "source"))
                                    .SubItems.Add(passwordmanager.ini.WertLesen(CStr(passwordmanager.schleife), "index"))
                                End With
                            End If
                        End If
                    Loop
                    Me.Close()
                    Return
                Next go
            End If
        End If
    End Sub

    Private Sub passwordmgr_pass_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        password_txt.Text = ""
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

    Private Sub password_txt_KeyDown(sender As Object, e As KeyEventArgs) Handles password_txt.KeyDown
        If e.KeyCode = Keys.Enter Then
            ok_bt.PerformClick()
        End If
    End Sub
End Class