Option Strict On

Imports Project_WinCrypt.classes

Namespace tools.rsa

    Public Class rsa_decrypt
        Dim privkey As String

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles open_privkey_bt.Click
            open_private_key_dialog.ShowDialog()
            If My.Computer.FileSystem.FileExists(open_private_key_dialog.FileName) Then
                privkey_path_txt.Text = open_private_key_dialog.FileName
                privkey = My.Computer.FileSystem.ReadAllText(open_private_key_dialog.FileName)
            Else
            End If
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles decrypt_bt.Click
            message_txt.Text = classes.RSA.RSA_decrypt(encrypt_message_txt.Text, privkey)
        End Sub

        Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
            Me.WindowState = FormWindowState.Minimized
        End Sub

        Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
            Me.Close()
        End Sub

        Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
            If (e.Button = MouseButtons.Left) Then
                wincrypttitle.Capture = False
                Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
            Else
            End If
        End Sub

        Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
            If (e.Button = MouseButtons.Left) Then
                form_head.Capture = False
                Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
            Else
            End If
        End Sub

        Private Sub rsa_decrypt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim loadcolor As New designcolor
            loadcolor.color()
        End Sub
    End Class
End Namespace