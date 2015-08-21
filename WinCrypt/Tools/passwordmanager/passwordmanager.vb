Option Strict On
Imports System.ComponentModel
Imports System.IO
Imports Project_WinCrypt.classes
Imports Project_WinCrypt.My

Namespace tools.passwordmanager
    Public Class Passwordmanager
        ReadOnly _aes As New AES
        Public _
            Ini As _
                New IniDatei(
                    String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))

        Public Schleife As Integer = 0
        Public Index As Integer = 0
        Public Mgrpass As String

        Private Sub add_bt_Click(sender As Object, e As EventArgs) Handles add_bt.Click
            passwordmanager_add.Show()
        End Sub

        Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) _
            Handles database_viewer.SelectedIndexChanged
            If database_viewer.SelectedItems.Count > 0 Then
                Index = CInt(database_viewer.SelectedItems.Item(0).SubItems(2).Text)
                user_txt.Text = Ini.worthreading(CStr(Index), "user")
                password_txt.Text = Ini.worthreading(CStr(Index), "password")
                source_txt.Text = Ini.worthreading(CStr(Index), "source")
                comment_txt.Text = Ini.worthreading(CStr(Index), "comment").Replace("\r\n", vbCrLf)
            End If
        End Sub

        Private Sub delete_bt_Click(sender As Object, e As EventArgs) Handles delete_bt.Click
            Ini.WertSchreiben(CStr(Index), "user", Nothing)
            Ini.WertSchreiben(CStr(Index), "password", Nothing)
            Ini.WertSchreiben(CStr(Index), "source", Nothing)
            Ini.WertSchreiben(CStr(Index), "comment", Nothing)
            Ini.WertSchreiben(CStr(Index), "index", "|")
            database_viewer.Items.Clear()
            For Each go As String In Schleife.ToString
                Do
                    Schleife += 1
                    If Ini.worthreading(Str(Schleife), "index") = Nothing Then
                        Schleife = 0
                        Exit Do
                    Else
                        If Ini.worthreading(Str(Schleife), "index") = "|" Then
                        Else
                            With database_viewer.Items.Add(Ini.worthreading(CStr(Schleife), "user"))
                                .SubItems.Add(Ini.worthreading(CStr(Schleife), "source"))
                                .SubItems.Add(Ini.worthreading(CStr(Schleife), "index"))
                            End With
                        End If
                    End If
                Loop
                Return
            Next go
        End Sub

        Private Sub show_bt_Click(sender As Object, e As EventArgs) Handles save_bt.Click
            Ini.WertSchreiben(CStr(Index), "user", user_txt.Text)
            Ini.WertSchreiben(CStr(Index), "password", password_txt.Text)
            Ini.WertSchreiben(CStr(Index), "source", source_txt.Text)
            Ini.WertSchreiben(CStr(Index), "comment", comment_txt.Text.Replace((vbCrLf), ("\r\n")))
        End Sub

        Private Sub passwordmanager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            Try
                Dim readdb As String
                readdb =
                    Computer.FileSystem.ReadAllText(String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
                If Mgrpass = Nothing Then
                Else
                    Computer.FileSystem.WriteAllText(
                        String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)),
                        CStr(_aes.AesEncrypt(readdb, Mgrpass, Startwindow.Biosid)), False)
                End If
                Mgrpass = Nothing
            Catch ex As Exception

            End Try
        End Sub

        Private Sub passwordmanager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim loadcolor As New designcolor
            loadcolor.color()
            If File.Exists(String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))) Then
                passwordmgr_pass.ShowDialog()
            Else
                If Startwindow.Langname = "English" Then
                    If _
                        MessageBox.Show("It has not yet created any database you want to create a database?", "database", MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
                        MsgBoxResult.Yes Then
                        Newpwmgrdatabase.ShowDialog()
                    Else
                        Close()
                    End If
                Else

                    If _
                        MessageBox.Show("Es wurde noch keine Datenbank angelegt, möchten Sie eine Datenbank anlegen?", "Datenbank", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        Newpwmgrdatabase.ShowDialog()
                    Else
                        Close()
                    End If
                End If
            End If
            If Mgrpass = Nothing Then
                Close()
            End If
        End Sub

        Private Sub copy_user_bt_Click(sender As Object, e As EventArgs) Handles copy_user_bt.Click
            Computer.Clipboard.SetText(user_txt.Text)
            If Startwindow.Langname = "English" Then
                MessageBox.Show("User has been copied", "copied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Benutzer wurde kopiert", "Kopiert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub

        Private Sub copy_password_bt_Click(sender As Object, e As EventArgs) Handles copy_password_bt.Click
            Computer.Clipboard.SetText(password_txt.Text)
            If Startwindow.Langname = "English" Then
                MessageBox.Show("Password has been copied", "copied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Passwort wurde kopiert", "Kopiert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub

        Private Sub copy_source_bt_Click(sender As Object, e As EventArgs) Handles copy_source_bt.Click
            Computer.Clipboard.SetText(source_txt.Text)
            If Startwindow.Langname = "English" Then
                MessageBox.Show("Source has been copied", "copied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Quelle wurde kopiert", "Kopiert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub

        Private Sub minimize_bt_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
            WindowState = FormWindowState.Minimized
        End Sub

        Private Sub exit_bt_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
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

        Private Sub Passwordmanager_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
            If Startwindow.vCommand = True Then
                Startwindow.Close()
            End If
        End Sub
    End Class
End Namespace