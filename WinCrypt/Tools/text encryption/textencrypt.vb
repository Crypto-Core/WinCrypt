Option Strict On

Imports System.Reflection
Imports System.Runtime.InteropServices

Public Class textencrypt
    Private Sub encrypt_bt_Click(sender As Object, e As EventArgs) Handles encrypt_bt.Click
        Dim lGuid As GuidAttribute
        lGuid = DirectCast(
            Assembly.GetExecutingAssembly().GetCustomAttributes(
                GetType(GuidAttribute), False)(0),
            GuidAttribute)
        Dim AES2 As New AES
        If startwindow.iniread = "true" Then
            text_output.Text = CStr(AES2.AESEncrypt(text_input.Text, startwindow.biosid, lGuid.Value))
        Else
            text_output.Text = CStr(AES2.AESEncrypt(text_input.Text, password_txt.Text, lGuid.Value))
        End If
    End Sub

    Private Sub generate_bt_Click(sender As Object, e As EventArgs) Handles generate_bt.Click
        Dim num_characters As Integer
        Dim i As Integer
        Dim txt = ""
        Dim ch As Integer
        Randomize()
        num_characters = CInt(32)
        For i = 1 To num_characters
            ch = CInt(Int((26 + 26 + 10)*Rnd()))
            If ch < 26 Then
                txt = txt & Chr(ch + Asc("A"))
            ElseIf ch < 2*26 Then
                ch = ch - 26
                txt = txt & Chr(ch + Asc("a"))
            Else
                ch = ch - 26 - 26
                txt = txt & Chr(ch + Asc("0"))
            End If
        Next i
        password_txt.Text = txt
    End Sub

    Private Sub TrackBar_Scroll(sender As Object, e As EventArgs) Handles TrackBar.Scroll
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

    Private Sub decrypt_bt_Click(sender As Object, e As EventArgs) Handles decrypt_bt.Click
        Dim lGuid As GuidAttribute
        lGuid = DirectCast(
            Assembly.GetExecutingAssembly().GetCustomAttributes(
                GetType(GuidAttribute), False)(0),
            GuidAttribute)
        Dim AES2 As New AES
        If startwindow.iniread = "true" Then
            text_input.Text = AES2.AESDecrypt(text_output.Text, startwindow.biosid, lGuid.Value)
        Else
            text_input.Text = AES2.AESDecrypt(text_output.Text, password_txt.Text, lGuid.Value)
        End If
    End Sub

    Private Sub password_txt_TextChanged(sender As Object, e As EventArgs) Handles password_txt.TextChanged
        If password_txt.Text.Length < 6 Then
            encrypt_bt.Enabled = False
            decrypt_bt.Enabled = False
        Else
            encrypt_bt.Enabled = True
            decrypt_bt.Enabled = True
        End If
    End Sub

    Private Sub textencrypt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If startwindow.iniread = "true" Then
            decrypt_bt.Enabled = True
            encrypt_bt.Enabled = True
        Else :
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles arab_cb.CheckedChanged
        If arab_cb.Checked = True Then
            If TrackBar.Value = 1 Then
                text_input.RightToLeft = RightToLeft.Yes
            End If
            If TrackBar.Value = 0 Then
                text_input.RightToLeft = RightToLeft.Yes
            End If
        Else
            If TrackBar.Value = 1 Then
                text_input.RightToLeft = RightToLeft.No
            End If
            If TrackBar.Value = 0 Then
                text_input.RightToLeft = RightToLeft.No
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Me.Close()
    End Sub

    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = MouseButtons.Left) Then
            wincrypttitle.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else :
        End If
    End Sub

    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = MouseButtons.Left) Then
            form_head.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else :
        End If
    End Sub
End Class