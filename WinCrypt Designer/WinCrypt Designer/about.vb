Public Class about

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link.LinkClicked
        Process.Start("https://wincrypt.org")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ok.Click
        Me.Close()
    End Sub

    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        product.Text = "WinCrypt Designer " & My.Application.Info.Version.ToString
    End Sub
End Class