Imports System.Net
Imports System.Net.Mail
Public Class sendmail
    Dim mailmessage As New System.Net.Mail.MailMessage
    Dim mailini As New INIDatei(My.Application.Info.DirectoryPath & "\mail.ini")
    Private Sub fileadd_bt_Click(sender As Object, e As EventArgs) Handles fileadd_bt.Click
        OpenFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
            file_txt.Text = OpenFileDialog1.FileName
            mailmessage.Attachments.Add(New System.Net.Mail.Attachment(file_txt.Text)) ' Anhang
        End If
        
    End Sub

    Private Sub send_bt_Click(sender As Object, e As EventArgs) Handles sendmail_bt.Click
        Try
            Dim mail As String
            mail = message_txt.Text
            Dim client As New Mail.SmtpClient(server_txt.Text) ' SMTP Server
            client.Credentials = New NetworkCredential(email_txt.Text, password_txt.Text) ' Meine E-Mail und Passwort
            Dim attachment As Attachment = Nothing ' Anhang = nichts
            Dim Mailfile As New MailMessage(email_txt.Text, emailto_txt.Text) ' Meine E-Mail, Empfänger

            MailMessage.From = New System.Net.Mail.MailAddress(email_txt.Text) ' Meine E-Mail
            MailMessage.To.Add(emailto_txt.Text) ' Empfänger
            MailMessage.Subject = subject_txt.Text ' Betreff
            MailMessage.Body = message_txt.Text ' Nachricht
            
            client.Send(MailMessage) ' E-Mail Senden
            MsgBox("Nachricht wurde an " & emailto_txt.Text & " erfolgreich gesendet!", MsgBoxStyle.Information)
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\mail.ini") = True Then

            Else
                Dim aes As New AES
                If MsgBox("Möchtest du dein E-Mail Konto speichern?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    mailini.WertSchreiben("MailAccount", "mail", email_txt.Text)
                    mailini.WertSchreiben("MailAccount", "password", aes.AESEncrypt(password_txt.Text, startwindow.biosid, startwindow.biosid))
                    mailini.WertSchreiben("MailAccount", "server", server_txt.Text)
                End If
            End If
        Catch ex As Exception
            MsgBox(ErrorToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub fileadd_bt1_Click(sender As Object, e As EventArgs) Handles fileadd_bt1.Click
        OpenFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
            file_txt1.Text = OpenFileDialog1.FileName
            mailmessage.Attachments.Add(New System.Net.Mail.Attachment(file_txt1.Text)) ' Anhang
        End If
    End Sub

    Private Sub fileadd_bt2_Click(sender As Object, e As EventArgs) Handles fileadd_bt2.Click
        OpenFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
            file_txt2.Text = OpenFileDialog1.FileName
            mailmessage.Attachments.Add(New System.Net.Mail.Attachment(file_txt2.Text)) ' Anhang
        End If
    End Sub

    Private Sub fileadd_bt3_Click(sender As Object, e As EventArgs) Handles fileadd_bt3.Click
        OpenFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
            file_txt3.Text = OpenFileDialog1.FileName
            mailmessage.Attachments.Add(New System.Net.Mail.Attachment(file_txt3.Text)) ' Anhang
        End If
    End Sub

    Private Sub add_bt_Click(sender As Object, e As EventArgs) Handles add_bt.Click
        If Me.Size = New Size(652, 471) Then
            Me.Size = New Size(652, 498)
            add_bt.Location = New Point(524, 431)
            add_bt.Enabled = False
        End If
        If Me.Size = New Size(652, 444) Then
            Me.Size = New Size(652, 471)
            add_bt.Location = New Point(524, 405)
        End If
        If Me.Size = New Size(652, 418) Then
            Me.Size = New Size(652, 444)
            add_bt.Location = New Point(524, 379)
        End If
        

    End Sub

    Private Sub sendmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\mail.ini") = True Then
            Dim aes As New AES
            email_txt.Text = mailini.WertLesen("MailAccount", "mail")
            password_txt.Text = aes.AESDecrypt(mailini.WertLesen("MailAccount", "password"), startwindow.biosid, startwindow.biosid)
            server_txt.Text = mailini.WertLesen("MailAccount", "server")
            message_txt.Size = New Size(612, 230)
            message_txt.Location = New Point(12, 116)
            account_bt.Visible = True
        Else : End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles account_bt.Click
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\mail.ini") Then
            If MsgBox("Möchten Sie wirklich ihr E-Mail Konto entfernen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\mail.ini")
                account_bt.Visible = False
                message_txt.Size = New Size(612, 252)
                message_txt.Location = New Point(12, 94)

                MsgBox("Konto wurde entfernt!", MsgBoxStyle.Information)
            Else : End If
        Else : End If
        
    End Sub
End Class