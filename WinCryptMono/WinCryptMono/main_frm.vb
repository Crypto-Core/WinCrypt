Imports System.IO
Imports WinCryptMono.IniFile

Public Class main_frm
    Private Container_ As New Container
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
        If enc_folder.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = enc_folder.SelectedPath
            For Each data_ In Directory.GetFiles(TextBox1.Text, "*.*", SearchOption.AllDirectories)
                Dim fileinfo As New FileInfo(data_)
                ListBox1.Items.Add("file added: " & fileinfo.Name)
                Dim readbyte As Byte() = File.ReadAllBytes(data_)
                Container_.AddFile(readbyte, data_, enc_folder.SelectedPath)
            Next
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dirInfo As New DirectoryInfo(TextBox1.Text)
        crypt_filedialog.FileName = dirInfo.Name
        crypt_filedialog.ShowDialog()
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

    Private Sub crypt_filedialog_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles crypt_filedialog.FileOk
        Container_.SaveContainer(crypt_filedialog.FileName, TextBox2.Text, 4096)
        Container_.RemoveAll()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        decrypt_dialog.ShowDialog()
        TextBox4.Text = decrypt_dialog.FileName

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Container_.LoadContainer(TextBox4.Text, TextBox3.Text, 4096)
        For Each s As IniSection In WinCryptMono.Container.INI.Sections
            ListBox2.Items.Add("Decrypted: " & System.Text.UTF8Encoding.UTF8.GetChars(Convert.FromBase64String(s.Name)))

        Next
        Dim ExtractPath As String = decrypt_dialog.FileName.Replace(".crypt", "")

        Directory.CreateDirectory(ExtractPath)
        Container_.Extract(ExtractPath & "/")

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If File.Exists(TextBox4.Text) = True Then
            If TextBox3.TextLength > 7 Then
                Button4.Enabled = True
            Else
                Button4.Enabled = False
            End If
        Else
            Button4.Enabled = False
        End If
    End Sub

    Private Sub FileEraserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileEraserToolStripMenuItem.Click
        file_eraser.ShowDialog()
    End Sub

    Private Sub PasswordgeneratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordgeneratorToolStripMenuItem.Click
        passwordgenerator.ShowDialog()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        settings.ShowDialog()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
