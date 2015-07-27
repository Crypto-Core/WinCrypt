﻿Option Strict On

Imports Project_WinCrypt.classes

Namespace tools.rsa

    Public Class rsa_encrypt
        Dim _pubkey As String

        Private Sub pubkey_path_bt_Click(sender As Object, e As EventArgs) Handles pubkey_path_bt.Click
            open_public_key_dialog.ShowDialog()
            If My.Computer.FileSystem.FileExists(open_public_key_dialog.FileName) Then
                pubkey_path_txt.Text = open_public_key_dialog.FileName
                _pubkey = My.Computer.FileSystem.ReadAllText(open_public_key_dialog.FileName)
            End If
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles encryption_bt.Click
            decryption_message_txt.Text = classes.RSA.RSA_encrypt(encryption_message_txt.Text, _pubkey)
        End Sub

        Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
            Close()
        End Sub

        Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimze_bt.Click
            WindowState = FormWindowState.Minimized
        End Sub

        Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
            If (e.Button = MouseButtons.Left) Then
                wincrypttitle.Capture = False
                WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
            Else
            End If
        End Sub

        Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
            If (e.Button = MouseButtons.Left) Then
                form_head.Capture = False
                WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
            Else
            End If
        End Sub
    End Class
End Namespace