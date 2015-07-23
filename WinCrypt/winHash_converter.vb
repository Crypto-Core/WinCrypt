Option Strict On
Imports System.Text
Public Class winHash_converter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convert_bt.Click

        Select Case toHash_ComboBox.Text
            Case "MD5"
                isHash_Textbox.Text = winHash.HashString(noHash_Textbox.Text, winHash.HASH.MD5)
            Case "SHA1"
                isHash_Textbox.Text = winHash.HashString(noHash_Textbox.Text, winHash.HASH.SHA1)
            Case "SHA256"
                isHash_Textbox.Text = winHash.HashString(noHash_Textbox.Text, winHash.HASH.SHA256)
            Case "SHA384"
                isHash_Textbox.Text = winHash.HashString(noHash_Textbox.Text, winHash.HASH.SHA384)
            Case "SHA512"
                isHash_Textbox.Text = winHash.HashString(noHash_Textbox.Text, winHash.HASH.SHA512)
        End Select
    End Sub

    Private Sub winHash_converter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toHash_ComboBox.SelectedIndex = 0
    End Sub
End Class