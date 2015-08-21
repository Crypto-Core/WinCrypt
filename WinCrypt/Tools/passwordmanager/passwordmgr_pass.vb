﻿Option Strict On
Imports System.ComponentModel
Imports System.IO
Imports Project_WinCrypt.classes

Namespace tools.passwordmanager

    Public Class passwordmgr_pass
        Public Pass As String
        ReadOnly _aes As New AES
        ReadOnly _root As New DirectoryInfo(Application.StartupPath)

        Private Sub ok_bt_Click(sender As Object, e As EventArgs) Handles ok_bt.Click
            If password_txt.Text.Length < 8 Then

                If Startwindow.Langname = "English" Then
                    MsgBox("The password must be at least 8 characters estend consist!", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Das Passwort muss mindestend aus 8 Zeichen bestehen!", MsgBoxStyle.Exclamation)
                End If
            Else
                Dim textdecrypt As String

                textdecrypt = _aes.AesDecrypt(
                        File.ReadAllText(_root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini"),
                        password_txt.Text, Startwindow.Biosid)
                If textdecrypt = "error" Then
                Else
                    tools.passwordmanager.Passwordmanager.Mgrpass = password_txt.Text
                    File.WriteAllText(_root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", textdecrypt)
                    tools.passwordmanager.Passwordmanager.database_viewer.Items.Clear()
                    For Each go As String In tools.passwordmanager.Passwordmanager.Schleife.ToString
                        Do
                            tools.passwordmanager.Passwordmanager.Schleife += 1
                            If tools.passwordmanager.Passwordmanager.Ini.worthreading(Str(tools.passwordmanager.Passwordmanager.Schleife), "index") = Nothing Then
                                tools.passwordmanager.Passwordmanager.Schleife = 0
                                Exit Do
                            Else
                                If tools.passwordmanager.Passwordmanager.Ini.worthreading(Str(tools.passwordmanager.Passwordmanager.Schleife), "index") = "|" Then
                                Else
                                    With _
                                        tools.passwordmanager.Passwordmanager.database_viewer.Items.Add(
                                            tools.passwordmanager.Passwordmanager.Ini.worthreading(CStr(tools.passwordmanager.Passwordmanager.Schleife), "user"))
                                        .SubItems.Add(tools.passwordmanager.Passwordmanager.Ini.worthreading(CStr(tools.passwordmanager.Passwordmanager.Schleife), "source"))
                                        .SubItems.Add(tools.passwordmanager.Passwordmanager.Ini.worthreading(CStr(tools.passwordmanager.Passwordmanager.Schleife), "index"))
                                    End With
                                End If
                            End If
                        Loop
                        Close()
                        Return
                    Next go
                End If
            End If
        End Sub

        Private Sub passwordmgr_pass_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            password_txt.Text = Nothing
        End Sub

        Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
            Close()
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

        Private Sub password_txt_KeyDown(sender As Object, e As KeyEventArgs) Handles password_txt.KeyDown
            If e.KeyCode = Keys.Enter Then
                ok_bt.PerformClick()
            End If
        End Sub

        Private Sub passwordmgr_pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim loadcolor As New designcolor
            loadcolor.color()
        End Sub
    End Class
End Namespace