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
        SaveFileDialog1.FileName = "Private Key.xml"
        SaveFileDialog1.ShowDialog()
        private_key_path_txt.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_pubkey_bt.Click
        SaveFileDialog1.FileName = "Public Key.xml"
        SaveFileDialog1.ShowDialog()
        public_key_path_txt.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_bt.Click
        My.Computer.FileSystem.WriteAllText(private_key_path_txt.Text, privatekey_txt.Text, True)
        My.Computer.FileSystem.WriteAllText(public_key_path_txt.Text, publickey_txt.Text, True)
    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.WindowState = FormWindowState.Minimized
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
End Class