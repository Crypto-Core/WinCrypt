Imports System.IO

Public Class importAccount
    Dim aes As New AESEncrypt
    Private Sub import_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles import_bt.Click
        Dim readFilebytes As Byte() = File.ReadAllBytes(filepath_txt.Text)
        Dim decTarget As Byte()
        aes.Decode(readFilebytes, decTarget, pwd_txt.Text, AESEncrypt.ALGO.RIJNDAEL, 4096)
        Try
            decTarget.ToString()
        Catch ex As NullReferenceException
            MessageBox.Show("Wrong password!", "Decrypt failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DialogResult = Windows.Forms.DialogResult.Abort
            pwd_txt.Text = Nothing
            filepath_txt.Text = Nothing
            Exit Sub
        End Try
        Dim ini As New IniFile
        Dim mem As New MemoryStream(decTarget)
        ini.LoadFromMemory(mem)
        Dim decodeAccount As Byte() = Convert.FromBase64String(ini.GetKeyValue("exportAccount", "account"))
        Dim decodeUserlist As Byte() = Convert.FromBase64String(ini.GetKeyValue("exportAccount", "userlist"))
        File.WriteAllBytes(main_frm.account_path, decodeAccount)
        File.WriteAllBytes(main_frm.users_lst_path, decodeUserlist)
        mem.Close()
        mem.Flush()
        MessageBox.Show("Import success!", "Import Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class