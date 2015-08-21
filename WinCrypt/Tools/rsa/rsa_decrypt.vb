Option Strict On
Imports System.ComponentModel
Imports Project_WinCrypt.classes
Imports System.IO
Namespace tools.rsa
    Public Class rsa_decrypt
        Private privkey As String
        Public decryptbit As Integer
        Private Sub open_privkey_bt_Click(sender As Object, e As EventArgs) Handles open_privkey_bt.Click
            open_private_key_dialog.ShowDialog()
            If File.Exists(open_private_key_dialog.FileName) Then
                privkey_path_txt.Text = open_private_key_dialog.FileName
                privkey = File.ReadAllText(open_private_key_dialog.FileName)
                privkey = privkey.Replace("---BEGIN WINCRYPT RSA PRIVATEKEY---", Nothing).Replace("---END WINCRYPT RSA PRIVATEKEY---", Nothing).Replace(vbCrLf, Nothing)
                Try
                    Dim privkeybyte() As Byte = System.Convert.FromBase64String(privkey)
                    privkey = System.Text.Encoding.Default.GetString(privkeybyte)
                Catch ex As Exception
                    If Startwindow.Langname = "English" Then
                        MessageBox.Show("this is not a WinCrypt privatekey!", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        MessageBox.Show("Dies ist kein WinCrypt privatekey!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Try
            Else
            End If
        End Sub
        Private Sub decrypt_bt_Click(sender As Object, e As EventArgs) Handles decrypt_bt.Click
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
            bit_cb.SelectedIndex = 1
            decryptbit = CInt(bit_cb.Text)
            Dim loadcolor As New designcolor
            loadcolor.color()
        End Sub
        Private Sub rsa_decrypt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
            If Startwindow.vCommand = True Then
                Startwindow.Close()
            End If
        End Sub
        Private Sub bit_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bit_cb.SelectedIndexChanged
            decryptbit = CInt(bit_cb.Text)
        End Sub
    End Class
End Namespace