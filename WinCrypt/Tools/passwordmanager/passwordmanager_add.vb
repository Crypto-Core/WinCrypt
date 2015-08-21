Option Strict On

Imports System.IO
Imports Project_WinCrypt.classes

Namespace tools.passwordmanager

    Public Class passwordmanager_add
        ReadOnly _
            _ini As _
                New IniDatei(
                    String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))

        Public Property Aes1 As AES = New AES

        Private Sub add_bt_Click(sender As Object, e As EventArgs) Handles add_bt.Click
            Dim addcount As Integer
            Try
                addcount =
                    CInt(
                        CDbl(
                            tools.passwordmanager.passwordmanager.database_viewer.Items(tools.passwordmanager.passwordmanager.database_viewer.Items.Count - 1).SubItems(
                                2).Text) + 1)
            Catch ex As Exception
                addcount = 1
            End Try
            _ini.WertSchreiben(CStr(addcount), "user", user_txt.Text)
            _ini.WertSchreiben(CStr(addcount), "password", password_txt.Text)
            _ini.WertSchreiben(CStr(addcount), "source", source_txt.Text)
            _ini.WertSchreiben(CStr(addcount), "comment", comment_txt.Text.Replace((vbCrLf), ("\r\n")))
            _ini.WertSchreiben(CStr(addcount), "index", CStr(addcount))
            tools.passwordmanager.passwordmanager.database_viewer.Items.Clear()
            For Each go As String In tools.passwordmanager.Passwordmanager.Schleife.ToString
                Do
                    tools.passwordmanager.Passwordmanager.Schleife += 1
                    If _ini.worthreading(Str(tools.passwordmanager.Passwordmanager.Schleife), "index") = Nothing Then
                        tools.passwordmanager.Passwordmanager.Schleife = 0
                        Exit Do
                    Else
                        If _ini.worthreading(Str(tools.passwordmanager.Passwordmanager.Schleife), "index") = "|" Then
                        Else
                            With _
                                tools.passwordmanager.Passwordmanager.database_viewer.Items.Add(_ini.worthreading(CStr(tools.passwordmanager.Passwordmanager.Schleife),
                                                                                                              "user"))
                                .SubItems.Add(_ini.worthreading(CStr(tools.passwordmanager.Passwordmanager.Schleife), "source"))
                                .SubItems.Add(_ini.worthreading(CStr(tools.passwordmanager.Passwordmanager.Schleife), "index"))
                            End With
                            Close()
                        End If
                    End If
                Loop
                If Startwindow.Langname = "English" Then
                    MessageBox.Show("Entry was successfully added!", "added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Eintrag wurde erfolgreich hinzugefügt!", "Hinzugefügt", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Return
            Next go
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

        Private Sub passwordmanager_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim loadcolor As New designcolor
            loadcolor.color()
        End Sub
    End Class
End Namespace