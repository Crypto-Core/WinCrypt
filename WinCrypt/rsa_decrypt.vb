Public Class rsa_decrypt
    Dim privkey As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_privkey_bt.Click
        OpenFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
            privkey_path_txt.Text = OpenFileDialog1.FileName
            privkey = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        Else

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decrypt_bt.Click
        message_txt.Text = RSA.RSA_decrypt(encrypt_message_txt.Text, privkey)
    End Sub
End Class