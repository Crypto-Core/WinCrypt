Imports Microsoft.Win32

Public Class StartWindow

    Private Sub join_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles secureDesktop_bt.Click
        SecureDesktop.isOnSecureDesktop = True
        SecureDesktop.StartSecureWindow(main_frm)

    End Sub

    Private Sub startNormal_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startNormal_bt.Click
        SecureDesktop.isOnSecureDesktop = False
        Me.Hide()

        main_frm.ShowDialog()

    End Sub

    Private Sub StartWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class