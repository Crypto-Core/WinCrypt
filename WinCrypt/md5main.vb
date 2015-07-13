Imports System.Security.Cryptography
Imports System.Text
Public Class md5main
    Dim i As New MD5
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convert_bt.Click
        md5_txt.Text = i.MD5StringHash(text_txt.Text)
    End Sub

End Class