Option Strict On

Imports Project_WinCrypt.classes
Imports WinCryptMono.classes

Namespace tools.hash
    Public Class converter
        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convert_bt.Click
            Select Case toHash_ComboBox.Text
                Case "MD5"
                    isHash_Textbox.Text = rHash.HashString(noHash_Textbox.Text, rHash.HASH.MD5)
                Case "SHA1"
                    isHash_Textbox.Text = rHash.HashString(noHash_Textbox.Text, rHash.HASH.SHA1)
                Case "SHA256"
                    isHash_Textbox.Text = rHash.HashString(noHash_Textbox.Text, rHash.HASH.SHA256)
                Case "SHA384"
                    isHash_Textbox.Text = rHash.HashString(noHash_Textbox.Text, rHash.HASH.SHA384)
                Case "SHA512"
                    isHash_Textbox.Text = rHash.HashString(noHash_Textbox.Text, rHash.HASH.SHA512)
                Case "RIPEMD160"
                    isHash_Textbox.Text = rHash.HashString(noHash_Textbox.Text, rHash.HASH.RIPEMD160)
            End Select
        End Sub

        Private Sub Hash_converter_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            toHash_ComboBox.SelectedIndex = 0
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
            WindowState = FormWindowState.Minimized
        End Sub

        Private Sub noHash_Textbox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles noHash_Textbox.KeyDown
            If e.KeyCode = Keys.Enter Then
                convert_bt.PerformClick()
            End If
        End Sub
    End Class
End Namespace