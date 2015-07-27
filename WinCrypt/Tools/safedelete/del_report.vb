Public Class del_report
    Private Sub ok_bt_Click(sender As Object, e As EventArgs) Handles ok_bt.Click
        Me.Close()
    End Sub

    Private Sub saveas_bt_Click(sender As Object, e As EventArgs) Handles saveas_bt.Click
        save_error_dialog.ShowDialog()
        Try
            System.IO.File.WriteAllText(save_error_dialog.FileName, report_txt.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub form_head_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            form_head.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
    Private Sub exit_bt_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Me.Close()
    End Sub
    Private Sub wincrypttitle_MouseDown_1(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            wincrypttitle.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
End Class