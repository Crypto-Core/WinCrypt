Public Class FileTransfer

    Private Sub ok_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_bt.Click
        brocken_lb.Visible = False
        ok_bt.Visible = False
        Me.Close()
    End Sub
End Class