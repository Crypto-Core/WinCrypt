Option Strict On

Imports System.Net

Public Class feedback
    Private ReadOnly i As New WebClient

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles send_bt.Click

        If CInt(name_txt.Text.Length) < 3 Then
            If Startwindow.Langname = "English" Then
                MessageBox.Show("Please enter a name!", "Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Bitte gebe einen Namen ein!", "Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            If CInt(mail_txt.Text.Length) < 5 Then

                If Startwindow.Langname = "English" Then
                    MessageBox.Show("Please enter an email!", "E-Mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("Bitte gebe eine E-Mail ein!", "E-Mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                If CInt(message_txt.Text.Length) < 3 Then

                    If Startwindow.Langname = "English" Then
                        MessageBox.Show("Please enter your message!", "message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        MessageBox.Show("Bitte gebe eine Nachricht ein!", "Nachricht", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    i.OpenRead(
                        "http://wincrypt.org/feedback/mail_send.php?name=" & name_txt.Text & ChrW(38) & "email=" &
                        mail_txt.Text & ChrW(38) & "betreff=" & subject_cb.Text & ChrW(38) & "nachricht=" &
                        message_txt.Text.Replace(" ", "+").Replace(vbCrLf, "%0D") & ChrW(38) & "Submit=Senden")
                    If Startwindow.Langname = "English" Then
                        MessageBox.Show("Feedback has been sent, thank you for your feedback!", "Thanks", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Feedback wurde gesendet, vielen Dank für Ihr Feedback!", "Danke", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loadcolor As New designcolor
        loadcolor.color()
        subject_cb.SelectedIndex = 0
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