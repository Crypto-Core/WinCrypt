Imports System.IO
Imports System.Windows.Forms
Public Class FileHash_frm
    Private md5 As New classes.fileHash
    Private Sub form_head_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = MouseButtons.Left) Then
            form_head.Capture = False
            WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else
        End If
    End Sub

    Private Sub exit_bt_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Me.Close()
    End Sub

    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = MouseButtons.Left) Then
            wincrypttitle.Capture = False
            WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else
        End If
    End Sub

    Private Sub minimize_bt_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub file_txt_TextChanged(sender As Object, e As EventArgs) Handles file_txt.TextChanged
        If File.Exists(file_txt.Text) Then
            generate_bt.Enabled = True
            copy_bt.Enabled = True
        Else
            generate_bt.Enabled = False
            copy_bt.Enabled = False
        End If
    End Sub

    Private Sub copy_bt_Click(sender As Object, e As EventArgs) Handles copy_bt.Click
        Try
            Clipboard.SetText(md5_hash_txt.Text)
            MessageBox.Show("Hash wurde kopiert!", "Kopiert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub generate_bt_Click(sender As Object, e As EventArgs) Handles generate_bt.Click
        If select_Hash_combo.SelectedIndex = 0 Then
            md5_hash_txt.Text = classes.fileHash.FileHash(file_txt.Text, classes.fileHash.HASH.MD5)
        End If
        If select_Hash_combo.SelectedIndex = 1 Then
            md5_hash_txt.Text = classes.fileHash.FileHash(file_txt.Text, classes.fileHash.HASH.SHA1)
        End If
        If select_Hash_combo.SelectedIndex = 2 Then
            md5_hash_txt.Text = classes.fileHash.FileHash(file_txt.Text, classes.fileHash.HASH.SHA256)
        End If
        If select_Hash_combo.SelectedIndex = 3 Then
            md5_hash_txt.Text = classes.fileHash.FileHash(file_txt.Text, classes.fileHash.HASH.SHA384)
        End If
        If select_Hash_combo.SelectedIndex = 4 Then
            md5_hash_txt.Text = classes.fileHash.FileHash(file_txt.Text, classes.fileHash.HASH.SHA512)
        End If
        If select_Hash_combo.SelectedIndex = 5 Then
            md5_hash_txt.Text = classes.fileHash.FileHash(file_txt.Text, classes.fileHash.HASH.RIPEMD160)
        End If
    End Sub

    Private Sub open_bt_Click(sender As Object, e As EventArgs) Handles open_bt.Click
        openfile_dialog.ShowDialog()

        If File.Exists(openfile_dialog.FileName) Then
            file_txt.Text = openfile_dialog.FileName
        Else : End If
    End Sub

    Private Sub FileHash_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Dcolor As New designcolor
        Dcolor.color()
        select_Hash_combo.Text = "MD5"
    End Sub
End Class