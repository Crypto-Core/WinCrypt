Option Strict On
Imports System.Text
Public Class converter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convert_bt.Click
        Select Case toHash_ComboBox.Text
            Case "MD5"
                isHash_Textbox.Text = rhash.HashString(noHash_Textbox.Text, rhash.HASH.MD5)
            Case "SHA1"
                isHash_Textbox.Text = rhash.HashString(noHash_Textbox.Text, rhash.HASH.SHA1)
            Case "SHA256"
                isHash_Textbox.Text = rhash.HashString(noHash_Textbox.Text, rhash.HASH.SHA256)
            Case "SHA384"
                isHash_Textbox.Text = rhash.HashString(noHash_Textbox.Text, rhash.HASH.SHA384)
            Case "SHA512"
                isHash_Textbox.Text = rHash.HashString(noHash_Textbox.Text, rHash.HASH.SHA512)
            Case "RIPEMD160"
                isHash_Textbox.Text = rHash.HashString(noHash_Textbox.Text, rHash.HASH.RIPEMD160)
        End Select
    End Sub

    Private Sub Hash_converter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toHash_ComboBox.SelectedIndex = 0
    End Sub
End Class