Public Class connect_frame
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        main_frm.eran_adr_txt.Text = login.eran_adress
    End Sub
End Class