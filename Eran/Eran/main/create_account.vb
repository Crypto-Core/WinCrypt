Imports System.IO
Public Class create_account
    Dim SHA512 As String
    Dim to_md5 As String
    Dim authkey As String
    Dim ini As New IniFile
    Private Sub validate()
        authkey = rndPass.Random(16)
        auth_key_lb.Text = "Auth. key: " & authkey
        If usr_txt.TextLength > 5 Then
            If pwd_txt.TextLength > 7 Then
                SHA512 = rHash.HashString(usr_txt.Text & pwd_txt.Text & authkey, rHash.HASH.SHA512)
                to_md5 = rHash.HashString(SHA512, rHash.HASH.MD5)
                eran_txt.Text = to_md5
                create_bt.Enabled = True
            Else
                create_bt.Enabled = False
            End If
        End If
    End Sub
    Private Sub create_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles create_bt.Click
        ini.AddSection("account")
        ini.SetKeyValue("account", "username", usr_txt.Text)
        ini.SetKeyValue("account", "password", rHash.HashString(pwd_txt.Text, rHash.HASH.SHA512))
        ini.SetKeyValue("account", "authkey", authkey)
        ini.SetKeyValue("account", "adress", to_md5)
        Dim mem As New MemoryStream
        My.Resources.profilimage.Save(mem, System.Drawing.Imaging.ImageFormat.Png)
        Dim img_bs64 As String = Convert.ToBase64String(mem.ToArray)
        mem.Close()
        ini.SetKeyValue("account", "image", img_bs64)
        ini.Save(main_frm.account_path)
        create_account_panel.Hide()
        main_frm.Controls.Add(login.login_panel)
        Dim myAccount As String = "[" & usr_txt.Text & "]" & vbNewLine & "adress=" & eran_txt.Text
        Dim null_byte As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(myAccount)
        Dim target_byte As Byte()
        Dim aes As New AESEncrypt
        aes.Encode(null_byte, target_byte, pwd_txt.Text, AESEncrypt.ALGO.RIJNDAEL, 4096)
        File.WriteAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini", target_byte)
        login.login_panel.Show()
    End Sub

    Private Sub usr_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usr_txt.TextChanged
        validate()
    End Sub
    Private Sub pwd_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pwd_txt.TextChanged
        validate()
    End Sub

    Private Sub importAcc_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles importAcc_bt.Click
        If main_frm.import_acc_sd.ShowDialog = Windows.Forms.DialogResult.OK Then
            If File.Exists(main_frm.import_acc_sd.FileName) Then
                importAccount.filepath_txt.Text = main_frm.import_acc_sd.FileName
                If importAccount.ShowDialog = Windows.Forms.DialogResult.OK Then
                    create_account_panel.Hide()
                    main_frm.Controls.Add(login.login_panel)
                    login.login_panel.Show()
                End If
            End If
        End If
    End Sub
End Class