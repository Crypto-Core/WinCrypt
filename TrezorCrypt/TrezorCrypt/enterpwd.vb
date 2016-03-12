Public Class enterpwd
    Public Shared Letter As String
    Public Shared Password As String
    Public Shared syncpath As String
    Public Shared USBName As String
    Public Shared blocksize As Integer
    Public Shared algo As Integer
    Public Shared serial As String
    Public Shared isDecrypt As Boolean = False
    Friend Shared clipher As String
    Friend Shared isUSBout As Boolean = False
    Private Sub enterpwd_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        main_frm.checkList.Enabled = True
    End Sub
    Private Sub enterpwd_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If isDecrypt = False Then
            If isUSBout = False Then
                e.Cancel = True
            Else
                e.Cancel = False
            End If
        Else
            e.Cancel = False
        End If

    End Sub
    Private Sub enterpwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        device_name_lb.Text = USBName
        Dim ini As New IniFile
        ini.Load(Letter & "device.ini")
        Password = ini.GetKeyValue("Device", "Password")
        syncpath = ini.GetKeyValue("Device", "Syncpath")
        blocksize = ini.GetKeyValue("Device", "Blocksize")
        algo = ini.GetKeyValue("Device", "Algorithm")
        serial = ini.GetKeyValue("Device", "Serial")
        SynState.Enabled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sync_bt.Click
        If Password = rHash.HashString(password_txt.Text, rHash.HASH.SHA512) Then
            isDecrypt = True
            SynState.Enabled = False
            clipher = password_txt.Text
            Me.Close()
        Else
            MessageBox.Show("Wrong Password!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password_txt.TextChanged
        If password_txt.TextLength > 7 Then
            sync_bt.Enabled = True
        Else
            sync_bt.Enabled = False
        End If
    End Sub

    Private Sub SynState_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SynState.Tick
        If devices.isDriveEmbed(serial) = False Then
            isUSBout = True
            Me.Close()
            main_frm.checkList.Enabled = True
        End If
    End Sub

    Private Sub enterpwd_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        password_txt.Focus()
    End Sub

    Private Sub password_txt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles password_txt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            sync_bt.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(isUSBout)
    End Sub
End Class