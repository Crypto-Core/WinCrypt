Option Strict On
Public Class rsa_create_keys

    Private Sub rsa_create_keys_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        private_key_path_txt.Text = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Private Key.xml"
        public_key_path_txt.Text = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Public Key.xml"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generate_key_bt.Click
        Dim RSA_key As RSA.RSA_key_Struct = RSA.Create_RSA_Key
        privatekey_txt.Text = RSA_key.privat_key
        publickey_txt.Text = RSA_key.open_key
        save_bt.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_privkey_bt.Click
        save_keys_dialog.FileName = "Private Key.xml"
        save_keys_dialog.ShowDialog()
        private_key_path_txt.Text = save_keys_dialog.FileName
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_pubkey_bt.Click
        save_keys_dialog.FileName = "Public Key.xml"
        save_keys_dialog.ShowDialog()
        public_key_path_txt.Text = save_keys_dialog.FileName
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_bt.Click
        My.Computer.FileSystem.WriteAllText(private_key_path_txt.Text, privatekey_txt.Text, True)
        My.Computer.FileSystem.WriteAllText(public_key_path_txt.Text, publickey_txt.Text, True)
    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            wincrypttitle.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            form_head.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
End Class