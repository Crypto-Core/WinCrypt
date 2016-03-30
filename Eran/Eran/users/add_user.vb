Imports System.IO
Public Class add_user
    Dim ini As New IniFile
    Dim aes As New AESEncrypt

    Private Sub add_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_bt.Click
        If eran_adress_txt.TextLength = 32 Then
            main_frm.userlist_viewer.Items.Clear()
            If File.Exists(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini") Then
                Dim read_enc_bytes As Byte() = File.ReadAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini")
                Dim dec_trg_byte As Byte()
                aes.Decode(read_enc_bytes, dec_trg_byte, login.pwd, AESEncrypt.ALGO.RIJNDAEL, 4096)
                Dim mem_ As New MemoryStream(dec_trg_byte)
                ini.LoadFromMemory(mem_)
                ini.AddSection(eran_adress_txt.Text)
                ini.SetKeyValue(eran_adress_txt.Text, "adress", eran_adress_txt.Text)
                Dim save_trg_enc As Byte()
                aes.Encode(ini.SavetoByte(), save_trg_enc, login.pwd, AESEncrypt.ALGO.RIJNDAEL, 4096)
                File.WriteAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini", save_trg_enc)
                main_frm.load_userlist()
                Me.Close()
            Else
                ini.AddSection(eran_adress_txt.Text)
                ini.SetKeyValue(eran_adress_txt.Text, "adress", eran_adress_txt.Text)
                Dim ini_save_byte As Byte()
                ini_save_byte = ini.SavetoByte()
                Dim save_trg_enc As Byte()
                aes.Encode(ini_save_byte, save_trg_enc, login.pwd, AESEncrypt.ALGO.RIJNDAEL, 4096)
                File.WriteAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini", save_trg_enc)
                main_frm.load_userlist()
                Close()
            End If
        Else
            MsgBox("It's not a Eran adress!", MsgBoxStyle.Exclamation, "Eran adress")
        End If
    End Sub

    Private Sub add_user_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        eran_adress_txt.Text = ""
    End Sub
End Class