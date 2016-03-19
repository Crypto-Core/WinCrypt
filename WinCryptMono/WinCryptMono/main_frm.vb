Imports System.IO

Public Class main_frm

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub

    Private Sub ConverterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConverterToolStripMenuItem.Click
        tools.hash.converter.ShowDialog()
    End Sub

    Private Structure Files
        Friend name As String
    End Structure
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        enc_folder.ShowDialog()
        TextBox1.Text = enc_folder.SelectedPath
        
    End Sub

    Private Sub main_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cachePath As String() = Directory.GetFiles(enc_folder.SelectedPath, "*.*", SearchOption.AllDirectories)
        Directory.CreateDirectory(enc_folder.SelectedPath & "/encrypt")
        For Each data_ In cachePath
            Dim info As New FileInfo(data_)
            Dim encryptName As Byte() = classes.Encrypt(data_.Replace(enc_folder.SelectedPath, ""), TextBox2.Text)
            Dim toB64 As String = Convert.ToBase64String(encryptName)

            ListBox1.Items.Add("encrypt: " & info.Name)
            classes.CryptFile(TextBox2.Text, data_, enc_folder.SelectedPath & "/encrypt/" & toB64.Replace("/", "-"), True)

        Next
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Directory.Exists(TextBox1.Text) = True Then
            If TextBox2.TextLength > 7 Then
                Button3.Enabled = True
            Else
                Button3.Enabled = False
            End If
        Else
            Button3.Enabled = False
        End If
        Dim i As New Passstrength
        Select Case i.PasswordStrength(TextBox2.Text, TextBox2.Text.Length)
            Case -1
                TextBox2.BackColor = Color.FromArgb(51, 51, 55)
                TextBox2.ForeColor = Color.FromArgb(0, 122, 204)
            Case 0
                TextBox2.BackColor = Color.Red
                TextBox2.ForeColor = Color.FromArgb(0, 122, 204)
            Case 1
                TextBox2.BackColor = Color.Orange
                TextBox2.ForeColor = Color.FromArgb(0, 122, 204)
            Case 2
                TextBox2.BackColor = Color.Yellow
                TextBox2.ForeColor = Color.FromArgb(0, 122, 204)
            Case 3
                TextBox2.BackColor = Color.GreenYellow
                TextBox2.ForeColor = Color.FromArgb(0, 122, 204)
            Case 4
                TextBox2.BackColor = Color.Green
                TextBox2.ForeColor = Color.White
        End Select

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox2.Text = rndPass.random(32)
    End Sub
End Class
