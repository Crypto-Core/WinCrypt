Public Class login

    Private Sub login_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_bt.Click
        main_panel.Hide()
        main_frm.Controls.Add(connecting_frame.Panel1)
        connecting_frame.Panel1.Show()
        Do While connecting_frame.Panel1.Created
            connecting_frame.login_img.Visible = True
            Control.CheckForIllegalCrossThreadCalls = False
            main_frm.conStateTimer.Enabled = True
            connecting()
            Exit Do
        Loop
        
        

    End Sub

    Private Sub password_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password_txt.TextChanged
        If password_txt.TextLength > 7 Then
            login_bt.Enabled = True
        Else
            login_bt.Enabled = False
        End If
    End Sub

    Sub connecting()
        
        Dim ini As New IniFile
        ini.Load(My.Application.Info.DirectoryPath & OS.OS_slash & "account.ini")
        EranAPI.Account.Aliasname = username_txt.Text
        EranAPI.Account.AuthKey = ini.GetKeyValue("account", "authkey")
        EranAPI.Account.OnlineState = 1
        EranAPI.Account.Password = password_txt.Text
        EranAPI.Account.Profileimage = Convert.FromBase64String(ini.GetKeyValue("account", "image"))
        EranAPI.Account.Username = username_txt.Text
        main_frm.API.Connect(host_txt.Text, port_txt.Text)
    End Sub
End Class