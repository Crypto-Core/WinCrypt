Imports System.IO

Public Class create_account
    Friend combineAddress As String
    Friend pwd_hash As String
    Friend usr_name As String
    Friend rnd_authkey As String
    Private ini As New IniFile
    Private Sub username_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username_txt.TextChanged
        validate()
    End Sub

    Sub validate()
        If username_txt.TextLength > 5 Then
            If password_txt.TextLength > 7 Then
                rnd_authkey = rndPass.Random(16)
                authkey_lb.Text = "Aut. key: " & rnd_authkey
                combineAddress = rHash.HashString(rHash.HashString(username_txt.Text & password_txt.Text & rnd_authkey, rHash.HASH.SHA512), rHash.HASH.MD5)
                address_txt.Text = combineAddress
                create_bt.Enabled = True
            Else
                create_bt.Enabled = False
            End If
        Else
            create_bt.Enabled = False
        End If
    End Sub

    Private Sub password_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password_txt.TextChanged
        validate()
    End Sub

    Private Sub create_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles create_bt.Click
        ini.AddSection("account")
        ini.SetKeyValue("account", "username", username_txt.Text)
        ini.SetKeyValue("account", "password", rHash.HashString(password_txt.Text, rHash.HASH.SHA512))
        ini.SetKeyValue("account", "authkey", rnd_authkey)
        ini.SetKeyValue("account", "adress", combineAddress)
        Dim mem As New MemoryStream
        My.Resources.profilimage.Save(mem, System.Drawing.Imaging.ImageFormat.Png)
        Dim img_bs64 As String = Convert.ToBase64String(mem.ToArray)
        mem.Close()
        ini.SetKeyValue("account", "image", img_bs64)
        ini.Save(My.Application.Info.DirectoryPath & OS.OS_slash & "account.ini")
        main_panel.Hide()
        main_frm.Controls.Add(login.main_panel)
        Dim myAccount As String = "[" & username_txt.Text & "]" & vbNewLine & "adress=" & combineAddress
        Dim null_byte As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(myAccount)
        Dim target_byte As Byte()
        Dim aes As New AESEncrypt
        aes.Encode(null_byte, target_byte, password_txt.Text, AESEncrypt.ALGO.RIJNDAEL, 4096)
        File.WriteAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini", target_byte)
        login.main_panel.Show()

    End Sub
End Class