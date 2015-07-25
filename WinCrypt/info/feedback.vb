Option Strict On
Imports System.Net
Public Class feedback
    Dim i As New System.Net.WebClient
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If name_txt.Text.Length < 3 Then
            MsgBox("Bitte gebe einen Namen ein!", MsgBoxStyle.Exclamation)
        Else
            If mail_txt.Text.Length < 5 Then
                MsgBox("Bitte gebe eine E-Mail ein!", MsgBoxStyle.Exclamation)
            Else
                If message_txt.Text.Length < 3 Then
                    MsgBox("Bitte gebe eine Nachricht ein!", MsgBoxStyle.Exclamation)
                Else
                    i.OpenRead("http://wincrypt.org/feedback/mail_send.php?name=" & name_txt.Text & ChrW(38) & "email=" & mail_txt.Text & ChrW(38) & "betreff=" & ComboBox1.Text & ChrW(38) & "nachricht=" & message_txt.Text.Replace(" ", "+").Replace(vbCrLf, "%0D") & ChrW(38) & "Submit=Senden")
                    MsgBox("Feedback wurde gesendet, vielen Dank für Ihr Feedback!", MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub
    Private Sub feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub
    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            wincrypttitle.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            MenuStrip1.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class