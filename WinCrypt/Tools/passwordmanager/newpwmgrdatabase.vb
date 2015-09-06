Option Strict On

Imports System.IO
Imports Project_WinCrypt.classes

Public Class Newpwmgrdatabase
    ReadOnly _aes As New AES

    Private Sub createdb_bt_Click(sender As Object, e As EventArgs) Handles createdb_bt.Click
        If password_txt.Text.Length < 8 Then
            If Startwindow.Langname = "English" Then
                MessageBox.Show("The password must consist of at least 8 characters!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Das Passwort muss mindestens aus 8 Zeichen bestehen!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            Dim newentry As String = "[1]" & vbCrLf & "user=" & vbCrLf & "password=" & vbCrLf & "source=" & vbCrLf &
                                     "comment=" & vbCrLf & "index=|"
            File.WriteAllText(String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)), CStr(_aes.AesEncrypt(newentry, password_txt.Text, Startwindow.Biosid)))
            tools.passwordmanager.Passwordmanager.Mgrpass = password_txt.Text
            If Startwindow.Langname = "English" Then
                MessageBox.Show("Database has been successfully created!", "database created", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Datenbank wurde erfolgreich angelegt!", "Datenbank erstellt", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Dim textdecrypt As String
            textdecrypt =
                _aes.AesDecrypt(File.ReadAllText(String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))),
                    password_txt.Text, Startwindow.Biosid)
            File.WriteAllText(String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)), textdecrypt)
            tools.passwordmanager.Passwordmanager.database_viewer.Items.Clear()
            For Each go In tools.passwordmanager.Passwordmanager.Schleife.ToString
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

    Private Sub Newpwmgrdatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loadcolor As New designcolor
        loadcolor.color()
    End Sub

    Private Sub password_txt_TextChanged(sender As Object, e As EventArgs) Handles password_txt.TextChanged
        Dim passstrength As New Passstrength
        If passstrength.PasswordStrength(password_txt.Text, password_txt.Text.Length) = -0 Then
            Dim color As New designcolor
            password_txt.BackColor = color.inputbackgroundcolor
        End If
        If passstrength.PasswordStrength(password_txt.Text, password_txt.Text.Length) = 1 Then
            Dim color As New designcolor
            password_txt.BackColor = Drawing.Color.Red
        End If
        If passstrength.PasswordStrength(password_txt.Text, password_txt.Text.Length) = 2 Then
            Dim color As New designcolor
            password_txt.BackColor = Drawing.Color.Yellow
        End If
        If passstrength.PasswordStrength(password_txt.Text, password_txt.Text.Length) = 3 Then
            Dim color As New designcolor
            password_txt.BackColor = Drawing.Color.GreenYellow
        End If
        If passstrength.PasswordStrength(password_txt.Text, password_txt.Text.Length) = 4 Then
            Dim color As New designcolor
            password_txt.BackColor = Drawing.Color.Lime
        End If

    End Sub
End Class