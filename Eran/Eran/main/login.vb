
Imports System.IO
Imports System.IO.Stream
Public Class login
    Dim ini As New IniFile
    Friend Shared profile_img_memstream As MemoryStream
    Friend Shared eran_adress As String
    Friend Shared username As String
    Friend Shared pwd As String
    Friend Shared authKey As String
    Private Sub login_panel_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles login_panel.HandleCreated
        ini.Load(main_frm.account_path)
        Dim img_bs64 As String = ini.GetKeyValue("account", "image")
        Dim img_to_byte As Byte() = Convert.FromBase64String(img_bs64)
        profile_img_memstream = New MemoryStream(img_to_byte)
        profile_img.BackgroundImage = Image.FromStream(profile_img_memstream)
        main_frm.profil_img.BackgroundImage = Image.FromStream(profile_img_memstream)
        username = ini.GetKeyValue("account", "username")
        authKey = ini.GetKeyValue("account", "authkey")
        usr_txt.Text = username
        eran_adress = ini.GetKeyValue("account", "adress")
        host_txt.Text = config.access_node_host
        port_txt.Text = CStr(config.acces_node_port)
    End Sub

    Private Sub join_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles join_bt.Click
        Dim combine As String = rHash.HashString(rHash.HashString(ini.GetKeyValue("account", "username") & pwd_txt.Text & ini.GetKeyValue("account", "authkey"), rHash.HASH.SHA512), rHash.HASH.MD5)
        main_frm.host = host_txt.Text
        main_frm.port = CInt(port_txt.Text)
        If combine = ini.GetKeyValue("account", "adress") Then
            main_frm.isEncrypted_Server = False
            main_frm.DisconnectFromUser = False
            main_frm.handshake = CStr(0)
            'login_panel.Hide()
            main_frm.Controls.Add(connect_frame.Panel1)
            connect_frame.Panel1.Show()
            connect_frame.Panel1.BringToFront()
            connect_frame.wait_tm.Enabled = True
            main_frm.eran_adress = eran_adress
            main_frm.username = username
            main_frm.Text = "Eran - " & username
            pwd = pwd_txt.Text
        Else
            Dim WrongLoginMSG As String = "{0}" & vbNewLine & "Wrong logindata!"
            Dim WrongLoginTitle As String = "Join failed!"
            If language.ini.GetKeyValue("login", "WrongLoginMSG") = Nothing Then : Else
                WrongLoginMSG = language.ini.GetKeyValue("login", "WrongLoginMSG")
                WrongLoginTitle = language.ini.GetKeyValue("login", "WrongLoginTitle")
            End If
            MessageBox.Show(String.Format(WrongLoginMSG, combine), WrongLoginTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub pwd_txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pwd_txt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            join_bt.PerformClick()
        End If
    End Sub
End Class