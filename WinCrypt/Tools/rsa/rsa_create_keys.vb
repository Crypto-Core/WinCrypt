Option Strict On
Imports System.ComponentModel
Imports System.IO
Imports System.Text
Namespace tools.rsa
    Public Class rsa_create_keys
        Public createbit As Integer
        Private Sub rsa_create_keys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim loadcolor As New designcolor
            loadcolor.color()
            bit_cb.SelectedIndex = 1
            createbit = CInt(bit_cb.Text)
            private_key_path_txt.Text = String.Format("{0}\Private Key.key", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory))
            public_key_path_txt.Text = String.Format("{0}\Public Key.key", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory))
        End Sub
        Private Sub generate_key_bt_Click(sender As Object, e As EventArgs) Handles generate_key_bt.Click
            Dim rsaKey As classes.RsaKeyStruct = classes.Create_RSA_Key
            Dim pubBytes() As Byte = Encoding.Default.GetBytes(rsaKey.OpenKey)
            Dim privBytes() As Byte = Encoding.Default.GetBytes(rsaKey.PrivatKey)
            privatekey_txt.Text = "---BEGIN WINCRYPT RSA PRIVATEKEY---" & vbCrLf & System.Convert.ToBase64String(privBytes) & vbCrLf & "---END WINCRYPT RSA PRIVATEKEY---"
            publickey_txt.Text = "---BEGIN WINCRYPT RSA PUBLICKEY---" & vbCrLf & System.Convert.ToBase64String(pubBytes) & vbCrLf & "---END WINCRYPT RSA PUBLICKEY---"
            save_bt.Enabled = True
        End Sub
        Private Sub save_privkey_bt_Click(sender As Object, e As EventArgs) Handles save_privkey_bt.Click
            save_keys_dialog.FileName = "Private Key.key"
            save_keys_dialog.ShowDialog()
            private_key_path_txt.Text = save_keys_dialog.FileName
        End Sub
        Private Sub save_pubkey_bt_Click(sender As Object, e As EventArgs) Handles save_pubkey_bt.Click
            save_keys_dialog.FileName = "Public Key.key"
            save_keys_dialog.ShowDialog()
            public_key_path_txt.Text = save_keys_dialog.FileName
        End Sub
        Private Sub save_bt_Click(sender As Object, e As EventArgs) Handles save_bt.Click
            File.WriteAllText(private_key_path_txt.Text, privatekey_txt.Text)
            File.WriteAllText(public_key_path_txt.Text, publickey_txt.Text)
        End Sub
        Private Sub exit_bt_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
            Close()
        End Sub
        Private Sub minimize_bt_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
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
        Private Sub rsa_create_keys_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
            If Startwindow.vCommand = True Then
                Startwindow.Close()
            End If
        End Sub
        Private Sub bit_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bit_cb.SelectedIndexChanged
            createbit = CInt(bit_cb.Text)
        End Sub
    End Class
End Namespace