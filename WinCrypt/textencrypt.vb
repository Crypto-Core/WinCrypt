Option Strict On
Public Class textencrypt

    Private Sub encrypt_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles encrypt_bt.Click
        Dim lGuid As System.Runtime.InteropServices.GuidAttribute
        lGuid = DirectCast(System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes( _
                  GetType(System.Runtime.InteropServices.GuidAttribute), False)(0),  _
                  System.Runtime.InteropServices.GuidAttribute)
        Dim AES2 As New AES
        If startwindow.iniread = "true" Then
            text_output.Text = CStr(AES2.AESEncrypt(text_input.Text, startwindow.biosid, lGuid.Value))
        Else
            text_output.Text = CStr(AES2.AESEncrypt(text_input.Text, password_txt.Text, lGuid.Value))
        End If

    End Sub

    Private Sub generate_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generate_bt.Click
        Dim num_characters As Integer
        Dim i As Integer
        Dim txt As String
        Dim ch As Integer
        Randomize()
        num_characters = CInt(32)
        For i = 1 To num_characters
            ch = CInt(Int((26 + 26 + 10) * Rnd()))
            If ch < 26 Then
                txt = txt & Chr(ch + Asc("A"))
            ElseIf ch < 2 * 26 Then
                ch = ch - 26
                txt = txt & Chr(ch + Asc("a"))
            Else
                ch = ch - 26 - 26
                txt = txt & Chr(ch + Asc("0"))
            End If
        Next i
        password_txt.Text = txt
    End Sub

    Private Sub TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar.Scroll
        If TrackBar.Value = 1 Then
            text_input.Text = "Text ausgabe"
            text_output.Text = "Text eingabe"
            text_output.ReadOnly = False
            text_input.ReadOnly = True
            encrypt_bt.Visible = False
            generate_bt.Visible = False
            decrypt_bt.Visible = True
            arrow_1.Image = My.Resources.uparrow
            arrow_2.Image = My.Resources.uparrow
            arrow_3.Image = My.Resources.uparrow
        Else
            text_output.Text = "Text ausgabe"
            text_input.Text = "Text eingabe"
            text_output.ReadOnly = True
            text_input.ReadOnly = False
            encrypt_bt.Visible = True
            If startwindow.iniread = "true" Then
                generate_bt.Visible = False
            Else
                generate_bt.Visible = True
            End If
            decrypt_bt.Visible = False
            arrow_1.Image = My.Resources.arrowdown
            arrow_2.Image = My.Resources.arrowdown
            arrow_3.Image = My.Resources.arrowdown
        End If
    End Sub

    Private Sub decrypt_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decrypt_bt.Click
        Dim lGuid As System.Runtime.InteropServices.GuidAttribute
        lGuid = DirectCast(System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes( _
                  GetType(System.Runtime.InteropServices.GuidAttribute), False)(0),  _
                  System.Runtime.InteropServices.GuidAttribute)
        Dim AES2 As New AES
        If startwindow.iniread = "true" Then
            text_input.Text = AES2.AESDecrypt(text_output.Text, startwindow.biosid, lGuid.Value)
        Else
            text_input.Text = AES2.AESDecrypt(text_output.Text, password_txt.Text, lGuid.Value)
        End If
    End Sub

    Private Sub password_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password_txt.TextChanged
        If password_txt.Text.Length < 6 Then
            encrypt_bt.Enabled = False
            decrypt_bt.Enabled = False
        Else
            encrypt_bt.Enabled = True
            decrypt_bt.Enabled = True
        End If
    End Sub

    Private Sub textencrypt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If startwindow.iniread = "true" Then
            decrypt_bt.Enabled = True
            encrypt_bt.Enabled = True
        Else : End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If TrackBar.Value = 1 Then
                text_input.RightToLeft = Windows.Forms.RightToLeft.Yes
            End If
            If TrackBar.Value = 0 Then
                text_input.RightToLeft = Windows.Forms.RightToLeft.Yes
            End If
        Else
            If TrackBar.Value = 1 Then
                text_input.RightToLeft = Windows.Forms.RightToLeft.No
            End If
            If TrackBar.Value = 0 Then
                text_input.RightToLeft = Windows.Forms.RightToLeft.No
            End If
        End If
    End Sub

End Class