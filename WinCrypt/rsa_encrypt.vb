Option Strict On
Public Class rsa_encrypt
    Dim pubkey As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pubkey_path_bt.Click
        OpenFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
            pubkey_path_txt.Text = OpenFileDialog1.FileName
            pubkey = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles encryption_bt.Click
        decryption_message_txt.Text = RSA.RSA_encrypt(encryption_message_txt.Text, pubkey)
    End Sub
End Class