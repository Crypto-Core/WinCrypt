Option Strict On
Imports System.Net
Imports System.Net.Mail
Public Class sendmail
    Private Sub file_bt_Click(sender As Object, e As EventArgs) Handles file_bt.Click
        OpenFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
            file_txt.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub sendmail_bt_Click(sender As Object, e As EventArgs) Handles sendmail_bt.Click
        Try
            Dim mail As String
            mail = message_txt.Text
            Dim Anhang As String = file_txt.Text ' Pfad zum Anhang
            Dim client As New Mail.SmtpClient(server_txt.Text) ' SMTP Server
            client.Credentials = New NetworkCredential(email_txt.Text, password_txt.Text) ' Meine E-Mail und Passwort
            Dim attachment As Attachment = Nothing ' Anhang = nichts
            Dim Mailfile As New MailMessage(email_txt.Text, emailto_txt.Text) ' Meine E-Mail, Empfänger
            Dim mailmessage As New System.Net.Mail.MailMessage
            mailmessage.From = New System.Net.Mail.MailAddress(email_txt.Text) ' Meine E-Mail
            mailmessage.To.Add(emailto_txt.Text) ' Empfänger
            mailmessage.Subject = subject_txt.Text ' Betreff
            mailmessage.Body = message_txt.Text ' Nachricht
            If My.Computer.FileSystem.FileExists(file_txt.Text) Then
                mailmessage.Attachments.Add(New System.Net.Mail.Attachment(Anhang)) ' Anhang
            Else : End If
            client.Send(mailmessage) ' E-Mail Senden
            MsgBox("Nachricht wurde an " & emailto_txt.Text & " erfolgreich gesendet!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ErrorToString, MsgBoxStyle.Critical)
        End Try
        
    End Sub
End Class