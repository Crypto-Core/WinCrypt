﻿Public Class passwordmanager_add
    Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
    Dim ini As New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini")
    Dim aes As New AES

    Private Sub add_bt_Click(sender As Object, e As EventArgs) Handles add_bt.Click
        Dim addcount As Integer
        Try
            addcount = passwordmanager.ListView1.Items(passwordmanager.ListView1.Items.Count - 1).SubItems(2).Text + 1
        Catch ex As Exception
            addcount = 1
        End Try
        ini.WertSchreiben(addcount, "user", user_txt.Text)
        ini.WertSchreiben(addcount, "password", password_txt.Text)
        ini.WertSchreiben(addcount, "source", source_txt.Text)
        ini.WertSchreiben(addcount, "comment", comment_txt.Text.Replace((vbCrLf), ("\r\n")))
        ini.WertSchreiben(addcount, "index", addcount)
        passwordmanager.ListView1.Items.Clear()
        For Each go As String In passwordmanager.schleife.ToString
            Do
                passwordmanager.schleife += 1
                If ini.WertLesen(Str(passwordmanager.schleife), "index") = "" Then
                    passwordmanager.schleife = 0
                    Exit Do
                Else
                    If ini.WertLesen(Str(passwordmanager.schleife), "index") = "|" Then
                    Else
                        With passwordmanager.ListView1.Items.Add(ini.WertLesen(passwordmanager.schleife, "user"))
                            .SubItems.Add(ini.WertLesen(passwordmanager.schleife, "source"))
                            .SubItems.Add(ini.WertLesen(passwordmanager.schleife, "index"))
                        End With
                        Me.Close()
                    End If
                End If
            Loop
            If startwindow.langname = "English" Then
                MsgBox("Entry was successfully added!", MsgBoxStyle.Information)
            Else
                MsgBox("Eintrag wurde erfolgreich hinzugefügt!", MsgBoxStyle.Information)
            End If
            Return
        Next go
    End Sub
End Class