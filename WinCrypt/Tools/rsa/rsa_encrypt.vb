Option Strict On
Imports System.ComponentModel
Imports Project_WinCrypt.classes
Imports System.IO
Imports System.Text
Namespace tools.rsa
    Public Class rsa_encrypt
        Public encryptbit As Integer
        Private _pubkey As String
        Private Sub pubkey_path_bt_Click(sender As Object, e As EventArgs) Handles pubkey_path_bt.Click
            open_public_key_dialog.ShowDialog()
            If File.Exists(open_public_key_dialog.FileName) Then
                pubkey_path_txt.Text = open_public_key_dialog.FileName
                _pubkey = File.ReadAllText(open_public_key_dialog.FileName)
                _pubkey = _pubkey.Replace("---BEGIN WINCRYPT RSA PUBLICKEY---", Nothing).Replace("---END WINCRYPT RSA PUBLICKEY---", Nothing).Replace(vbCrLf, Nothing)
                Try
                    Dim pubkeybyte() As Byte = Convert.FromBase64String(_pubkey)
                    _pubkey = Encoding.Default.GetString(pubkeybyte)
                Catch ex As Exception
                    If Startwindow.Langname = "English" Then
                        MessageBox.Show("Dies ist kein WinCrypt publickey!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        MessageBox.Show("this is not a WinCrypt publickey!", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Try
            End If
        End Sub
        Private Sub encryption_bt_Click(sender As Object, e As EventArgs) Handles encryption_bt.Click
            decryption_message_txt.Text = classes.RSA.RSA_encrypt(encryption_message_txt.Text, _pubkey)
        End Sub
        Private Sub exit_bt_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
            Close()
        End Sub
        Private Sub minimze_bt_Click(sender As Object, e As EventArgs) Handles minimze_bt.Click
            WindowState = FormWindowState.Minimized
        End Sub
        Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
            If (e.Button = MouseButtons.Left) Then
                wincrypttitle.Capture = False
                WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
            Else
            End If
        End Sub
        Private Sub form_head_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
            If (e.Button = MouseButtons.Left) Then
                form_head.Capture = False
                WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
            Else
            End If
        End Sub
        Private Sub rsa_encrypt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim loadcolor As New designcolor
            loadcolor.color()
            bit_cb.SelectedIndex = 1
            encryptbit = CInt(bit_cb.Text)
        End Sub
        Private Sub rsa_encrypt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
            If Startwindow.vCommand = True Then
                Startwindow.Close()
            End If
        End Sub
        Private Sub bit_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bit_cb.SelectedIndexChanged
            encryptbit = CInt(bit_cb.Text)
        End Sub
    End Class
End Namespace