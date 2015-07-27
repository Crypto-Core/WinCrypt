Option Strict On

Imports System.IO
Imports Project_WinCrypt.classes

Public Class passwordmanager_add
    Dim ReadOnly root As New DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)

    Dim ReadOnly _
        ini As _
            New INIDatei(
                root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini")

    Dim aes As New AES

    Private Sub add_bt_Click(sender As Object, e As EventArgs) Handles add_bt.Click
        Dim addcount As Integer
        Try
            addcount =
                CInt(
                    CDbl(
                        passwordmanager.database_viewer.Items(passwordmanager.database_viewer.Items.Count - 1).SubItems(
                            2).Text) + 1)
        Catch ex As Exception
            addcount = 1
        End Try
        ini.WertSchreiben(CStr(addcount), "user", user_txt.Text)
        ini.WertSchreiben(CStr(addcount), "password", password_txt.Text)
        ini.WertSchreiben(CStr(addcount), "source", source_txt.Text)
        ini.WertSchreiben(CStr(addcount), "comment", comment_txt.Text.Replace((vbCrLf), ("\r\n")))
        ini.WertSchreiben(CStr(addcount), "index", CStr(addcount))
        passwordmanager.database_viewer.Items.Clear()
        For Each go As String In passwordmanager.schleife.ToString
            Do
                passwordmanager.schleife += 1
                If ini.WertLesen(Str(passwordmanager.schleife), "index") = "" Then
                    passwordmanager.schleife = 0
                    Exit Do
                Else
                    If ini.WertLesen(Str(passwordmanager.schleife), "index") = "|" Then
                    Else
                        With _
                            passwordmanager.database_viewer.Items.Add(ini.WertLesen(CStr(passwordmanager.schleife),
                                                                                    "user"))
                            .SubItems.Add(ini.WertLesen(CStr(passwordmanager.schleife), "source"))
                            .SubItems.Add(ini.WertLesen(CStr(passwordmanager.schleife), "index"))
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
End Class