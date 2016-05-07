Imports System.IO
Public Class main_frm
    Friend WithEvents API As New EranAPI
    Private Sub login_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles file_bt.Click
        loginStrip.Show(file_bt, 0, file_bt.Height)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles users_bt.Click
        UsersStrip.Show(users_bt, 0, users_bt.Height)
    End Sub

    Private Sub account_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles account_bt.Click
        AccountStrip.Show(account_bt, 0, account_bt.Height)
    End Sub

    Private Sub tools_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tools_bt.Click
        ToolsStrip.Show(tools_bt, 0, tools_bt.Height)
    End Sub

    Private Sub help_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles help_bt.Click
        HelpStrip.Show(help_bt, 0, help_bt.Height)
    End Sub

    Private Sub main_frm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If authorizedCon = True Then
            API.Disconnect()
            Application.Exit()
        End If  
    End Sub

    Private Sub main_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If File.Exists(My.Application.Info.DirectoryPath & OS.OS_slash & "account.ini") Then
            main_panel.Hide()
            Me.Controls.Add(login.main_panel)
            login.main_panel.Show()
            Dim ini As New IniFile
            ini.Load(My.Application.Info.DirectoryPath & OS.OS_slash & "account.ini")
            login.username_txt.Text = ini.GetKeyValue("account", "username")
            login.password_txt.Focus()
        Else
            main_panel.Hide()
            Me.Controls.Add(create_account.main_panel)
            create_account.main_panel.Show()
        End If
    End Sub
    Friend authorizedCon As Boolean = False
    Private Sub API_AuthorizedConnection(ByVal State As Boolean) Handles API.AuthorizedConnection
        connecting_frame.acc_veri_img.Visible = True
        If State = True Then
            authorizedCon = True
        Else
            authorizedCon = False   
        End If
    End Sub
    Friend connState As Boolean = False
    Private Sub API_ConnectionState(ByVal State As Boolean) Handles API.ConnectionState
        If State = True Then
            connState = True
        Else
            connState = False
        End If
    End Sub
    Private Sub conStateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles conStateTimer.Tick
        If authorizedCon = True Then
            conStateTimer.Enabled = False
            connecting_frame.acc_veri_img.Image = My.Resources.accept
            connecting_frame.acc_veri_img.Visible = True

            Dim trd As New Threading.Thread(AddressOf countDown)
            trd.Start()
            OnlineStateTimer.Enabled = True
            alias_txt.Text = EranAPI.Account.Aliasname
            eran_adr_txt.Text = EranAPI.Account.Address
        Else
            connecting_frame.acc_veri_img.Image = My.Resources.cancel
            connecting_frame.acc_veri_img.Visible = True
        End If

        If connState = True Then
            connecting_frame.con_img.Image = My.Resources.accept
            connecting_frame.con_img.Visible = True
        Else
            connecting_frame.con_img.Image = My.Resources.cancel
            connecting_frame.con_img.Visible = True
        End If
    End Sub
    Sub countDown()
        For tt As Integer = 0 To 500000000 : Next
        connecting_frame.Panel1.Hide()
        main_panel.Show()
    End Sub

    Private Sub OnlineStatusTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlineStateTimer.Tick
        Select Case EranAPI.Connection.OnlineState
            Case 0
                PictureBox1.Image = My.Resources.offlineR
            Case 1
                PictureBox1.Image = My.Resources.busyR
            Case 2
                PictureBox1.Image = My.Resources.onlineR
        End Select
    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles eran_adr_txt.MouseClick
        My.Computer.Clipboard.SetText(eran_adr_txt.Text)
        userlist_viewer.Focus()
        MessageBox.Show("Eran address copied!", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub alias_txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles alias_txt.GotFocus
        alias_txt.BackColor = Color.FromArgb(40, 40, 40)
    End Sub

    Private Sub alias_txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles alias_txt.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            userlist_viewer.Focus()
        End If
    End Sub

    Private Sub alias_txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles alias_txt.LostFocus
        alias_txt.BackColor = Color.FromArgb(45, 45, 45)
    End Sub
    Private Sub TestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripMenuItem.Click
        If authorizedCon = True Then
            API.Disconnect()
            Application.Exit()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        API.Disconnect()
        conStateTimer.Enabled = True
        main_panel.Hide()
        login.main_panel.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        MessageBox.Show("Server key: " & API.ServerKey, "Server key", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        MessageBox.Show("Public key: " & API.PublicKey, "Public key", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub eran_adr_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eran_adr_txt.TextChanged

    End Sub
End Class
