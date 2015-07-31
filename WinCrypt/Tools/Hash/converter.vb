Option Strict On

Imports Project_WinCrypt.classes

Namespace tools.hash
    Public Class converter
        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles convert_bt.Click
            Select Case toHash_ComboBox.Text
                Case "MD5"
                    isHash_Textbox.Text = rhash.HashString(noHash_Textbox.Text, rHash.HASH.MD5)
                Case "SHA1"
                    isHash_Textbox.Text = rhash.HashString(noHash_Textbox.Text, rHash.HASH.SHA1)
                Case "SHA256"
                    isHash_Textbox.Text = rhash.HashString(noHash_Textbox.Text, rHash.HASH.SHA256)
                Case "SHA384"
                    isHash_Textbox.Text = rhash.HashString(noHash_Textbox.Text, rHash.HASH.SHA384)
                Case "SHA512"
                    isHash_Textbox.Text = rHash.HashString(noHash_Textbox.Text, rHash.HASH.SHA512)
                Case "RIPEMD160"
                    isHash_Textbox.Text = rHash.HashString(noHash_Textbox.Text, rHash.HASH.RIPEMD160)
            End Select
        End Sub

        Private Sub Hash_converter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim loadcolor As New designcolor
            loadcolor.color()
            toHash_ComboBox.SelectedIndex = 0
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

        Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
            Close()
        End Sub

        Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
            WindowState = FormWindowState.Minimized
        End Sub

        Private Sub noHash_Textbox_KeyDown(sender As Object, e As KeyEventArgs) Handles noHash_Textbox.KeyDown
            If e.KeyCode = Keys.Enter Then
                convert_bt.PerformClick()
            End If
        End Sub
    End Class
End Namespace