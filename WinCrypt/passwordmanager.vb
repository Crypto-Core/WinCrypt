﻿Public Class passwordmanager
    Dim aes As New AES
    Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
    Public ini As New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini")
    Public schleife As Integer = 0
    Public index As Integer = 0
    Public mgrpass As String
    Private Sub add_bt_Click(sender As Object, e As EventArgs) Handles add_bt.Click
        passwordmanager_add.Show()
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            index = ListView1.SelectedItems.Item(0).SubItems(2).Text
            user_txt.Text = ini.WertLesen(index, "user")
            password_txt.Text = ini.WertLesen(index, "password")
            source_txt.Text = ini.WertLesen(index, "source")
            comment_txt.Text = ini.WertLesen(index, "comment").Replace("\r\n", vbCrLf)
        End If
    End Sub

    Private Sub delete_bt_Click(sender As Object, e As EventArgs) Handles delete_bt.Click
        ini.WertSchreiben(index, "user", "")
        ini.WertSchreiben(index, "password", "")
        ini.WertSchreiben(index, "source", "")
        ini.WertSchreiben(index, "comment", "")
        ini.WertSchreiben(index, "index", "|")
        ListView1.Items.Clear()
        For Each go As String In schleife.ToString
            Do
                schleife += 1
                If ini.WertLesen(Str(schleife), "index") = "" Then
                    schleife = 0
                    Exit Do
                Else
                    If ini.WertLesen(Str(schleife), "index") = "|" Then
                    Else
                        With ListView1.Items.Add(ini.WertLesen(schleife, "user"))
                            .SubItems.Add(ini.WertLesen(schleife, "source"))
                            .SubItems.Add(ini.WertLesen(schleife, "index"))
                        End With
                    End If
                End If
            Loop
            Return
        Next go
    End Sub

    Private Sub show_bt_Click(sender As Object, e As EventArgs) Handles save_bt.Click
        ini.WertSchreiben(index, "user", user_txt.Text)
        ini.WertSchreiben(index, "password", password_txt.Text)
        ini.WertSchreiben(index, "source", source_txt.Text)
        ini.WertSchreiben(index, "comment", comment_txt.Text.Replace((vbCrLf), ("\r\n")))
    End Sub
    Private Sub passwordmanager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dim readdb As String
            readdb = My.Computer.FileSystem.ReadAllText(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini")
            If mgrpass = "" Then
            Else
                My.Computer.FileSystem.WriteAllText(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", aes.AESEncrypt(readdb, mgrpass, startwindow.biosid), False)
            End If
            mgrpass = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub passwordmanager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
            passwordmgr_pass.ShowDialog()
        Else
            If startwindow.langname = "English" Then
                If MsgBox("It has not yet created any database you want to create a database?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    newpwmgrdatabase.ShowDialog()
                Else
                    Me.Close()
                End If
            Else
                If MsgBox("Es wurde noch keine Datenbank angelegt, möchten Sie eine Datenbank anlegen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
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
End Class