Public Class about

    Private Sub about_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        productname.Text = "Productname: " & My.Application.Info.ProductName
        version_lb.Text = "Version: " & My.Application.Info.Version.ToString
        organisation_lb.Text = "Organisation: " & My.Application.Info.CompanyName
    End Sub

    Private Sub next_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles next_bt.Click
        Me.Close()
    End Sub
End Class