Option Strict On

Imports System.IO
Imports System.Net
Imports System.Net.Mail

Public Class sendmail
    Dim ReadOnly mailmessage As New MailMessage
    Dim pubkey As String
    Dim ReadOnly root As New DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)

    Dim ReadOnly _
        mailini As _
            New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\mail.ini")

    Private Sub fileadd_bt_Click(sender As Object, e As EventArgs) Handles fileadd_bt.Click
        add_file_dialog.ShowDialog()
        If My.Computer.FileSystem.FileExists(add_file_dialog.FileName) Then
            file_txt.Text = add_file_dialog.FileName
            mailmessage.Attachments.Add(New Attachment(file_txt.Text)) ' Anhang
        End If
    End Sub

    Private Sub send_bt_Click(sender As Object, e As EventArgs) Handles sendmail_bt.Click
        If rsa_cb.Checked = True Then
            Try
                Dim mail As String
                mail = message_txt.Text
                Dim client As New SmtpClient(server_txt.Text) ' SMTP Server
                client.Credentials = New NetworkCredential(email_txt.Text, password_txt.Text) _
                ' Meine E-Mail und Passwort
                Dim attachment As Attachment = Nothing ' Anhang = nichts
                Dim Mailfile As New MailMessage(email_txt.Text, emailto_txt.Text) ' Meine E-Mail, Empfänger

                mailmessage.From = New MailAddress(email_txt.Text) ' Meine E-Mail
                mailmessage.To.Add(emailto_txt.Text) ' Empfänger
                mailmessage.Subject = subject_txt.Text ' Betreff
                mailmessage.Body = RSA.RSA_encrypt(message_txt.Text, pubkey) ' Nachricht

                client.Send(mailmessage) ' E-Mail Senden
                MsgBox("Nachricht wurde an " & emailto_txt.Text & " erfolgreich gesendet!", MsgBoxStyle.Information)
                If _
                    My.Computer.FileSystem.FileExists(
                        root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\mail.ini") =
                    True Then

                Else
                    Dim aes As New AES
                    If MsgBox("Möchtest du dein E-Mail Konto speichern?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        mailini.WertSchreiben("MailAccount", "mail", email_txt.Text)
                        mailini.WertSchreiben("MailAccount", "password",
                                              aes.AESEncrypt(password_txt.Text, startwindow.biosid, startwindow.biosid))
                        mailini.WertSchreiben("MailAccount", "server", server_txt.Text)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ErrorToString, MsgBoxStyle.Critical)
            End Try
        Else
            Try
                Dim mail As String
                mail = message_txt.Text
                Dim client As New SmtpClient(server_txt.Text) ' SMTP Server
                client.Credentials = New NetworkCredential(email_txt.Text, password_txt.Text) _
                ' Meine E-Mail und Passwort
                Dim attachment As Attachment = Nothing ' Anhang = nichts
                Dim Mailfile As New MailMessage(email_txt.Text, emailto_txt.Text) ' Meine E-Mail, Empfänger

                mailmessage.From = New MailAddress(email_txt.Text) ' Meine E-Mail
                mailmessage.To.Add(emailto_txt.Text) ' Empfänger
                mailmessage.Subject = subject_txt.Text ' Betreff
                mailmessage.Body = message_txt.Text ' Nachricht

                client.Send(mailmessage) ' E-Mail Senden
                MsgBox("Nachricht wurde an " & emailto_txt.Text & " erfolgreich gesendet!", MsgBoxStyle.Information)
                If _
                    My.Computer.FileSystem.FileExists(
                        root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\mail.ini") =
                    True Then

                Else
                    Dim aes As New AES
                    If MsgBox("Möchtest du dein E-Mail Konto speichern?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        mailini.WertSchreiben("MailAccount", "mail", email_txt.Text)
                        mailini.WertSchreiben("MailAccount", "password",
                                              aes.AESEncrypt(password_txt.Text, startwindow.biosid, startwindow.biosid))
                        mailini.WertSchreiben("MailAccount", "server", server_txt.Text)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ErrorToString, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub fileadd_bt1_Click(sender As Object, e As EventArgs) Handles fileadd_bt1.Click
        add_file_dialog.ShowDialog()
        If My.Computer.FileSystem.FileExists(add_file_dialog.FileName) Then
            file_txt1.Text = add_file_dialog.FileName
            mailmessage.Attachments.Add(New Attachment(file_txt1.Text)) ' Anhang
        End If
    End Sub

    Private Sub fileadd_bt2_Click(sender As Object, e As EventArgs) Handles fileadd_bt2.Click
        add_file_dialog.ShowDialog()
        If My.Computer.FileSystem.FileExists(add_file_dialog.FileName) Then
            file_txt2.Text = add_file_dialog.FileName
            mailmessage.Attachments.Add(New Attachment(file_txt2.Text)) ' Anhang
        End If
    End Sub

    Private Sub fileadd_bt3_Click(sender As Object, e As EventArgs) Handles fileadd_bt3.Click
        add_file_dialog.ShowDialog()
        If My.Computer.FileSystem.FileExists(add_file_dialog.FileName) Then
            file_txt3.Text = add_file_dialog.FileName
            mailmessage.Attachments.Add(New Attachment(file_txt3.Text)) ' Anhang
        End If
    End Sub

    Private Sub add_bt_Click(sender As Object, e As EventArgs) Handles add_bt.Click
        If fileadd_bt2.Enabled = True Then
            fileadd_bt3.Enabled = True
            Me.Size = New Size(Me.Size.Width, Me.Size.Height)
            add_bt.Enabled = False
        End If
        If fileadd_bt1.Enabled = True Then
            fileadd_bt2.Enabled = True
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + 26)
        End If
        If fileadd_bt1.Enabled = False Then
            fileadd_bt1.Enabled = True
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + 26)
        End If
    End Sub

    Private Sub sendmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _
            My.Computer.FileSystem.FileExists(
                root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\mail.ini") = True Then
            Dim aes As New AES
            email_txt.Text = mailini.WertLesen("MailAccount", "mail")
            password_txt.Text = aes.AESDecrypt(mailini.WertLesen("MailAccount", "password"), startwindow.biosid,
                                               startwindow.biosid)
            server_txt.Text = mailini.WertLesen("MailAccount", "server")
            message_txt.Size = New Size(612, 270)
            message_txt.Location = New Point(12, 155)
            account_bt.Visible = True
        Else :
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles account_bt.Click
        If _
            My.Computer.FileSystem.FileExists(
                root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\mail.ini") Then
            If MsgBox("Möchten Sie wirklich ihr E-Mail Konto entfernen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                My.Computer.FileSystem.DeleteFile(
                    root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\mail.ini")
                account_bt.Visible = False
                message_txt.Size = New Size(612, 297)
                message_txt.Location = New Point(12, 128)

                MsgBox("Konto wurde entfernt!", MsgBoxStyle.Information)
            Else :
            End If
        Else :
        End If
    End Sub

    Private Sub rsa_cb_CheckedChanged(sender As Object, e As EventArgs) Handles rsa_cb.CheckedChanged
        If rsa_cb.Checked = True Then
            rsa_open_bt.Visible = True
            pubkey_lb.Visible = True
            pubkey_txt.Visible = True
        Else
            rsa_open_bt.Visible = False
            pubkey_lb.Visible = False
            pubkey_txt.Visible = False
        End If
    End Sub

    Private Sub rsa_open_bt_Click(sender As Object, e As EventArgs) Handles rsa_open_bt.Click
        rsadialog.ShowDialog()
        If My.Computer.FileSystem.FileExists(rsadialog.FileName) Then
            pubkey_txt.Text = rsadialog.FileName
            pubkey = My.Computer.FileSystem.ReadAllText(pubkey_txt.Text)
        Else :
        End If
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

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Me.Close()
    End Sub
End Class