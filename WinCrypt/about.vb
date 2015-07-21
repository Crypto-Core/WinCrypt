Option Strict On
Public Class about
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        copyright_lb.Text = "Copyright (C) " & System.DateTime.Today.Year & " Harry Machura"
        product_lb.Text = "WinCrypt " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        version_lb.Text = "(Version " & My.Application.Info.Version.ToString & ")"
        PictureBox1.Select()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://wincrypt.org/lizenz/")
    End Sub
End Class