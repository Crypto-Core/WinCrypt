Public Class connect_frame
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wait_tm.Tick
        wait_tm.Enabled = False
        main_frm.eran_adr_txt.Text = login.eran_adress
        main_frm.main_panel.Show()
        Panel1.Hide()
    End Sub
End Class