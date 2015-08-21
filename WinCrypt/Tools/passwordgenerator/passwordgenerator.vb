Imports System.ComponentModel
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Namespace tools.passwordgenerator

    Public Class passwordgenerator
        Private Sub generatebt_Click(sender As Object, e As EventArgs) Handles generatebt.Click
            Dim specialchars = "!§$%&/()=?`#+-_.,<>:;*'^"
            Dim upchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            Dim lowchar = "abcdefghijklmnopqrstuvwxyz"
            Dim numbchar = "1234567890"

            Dim suln As String = specialchars & upchar & lowchar & numbchar
            Dim snl As String = specialchars & numbchar & lowchar
            Dim sn As String = specialchars & numbchar
            Dim s As String = specialchars
            Dim sul As String = specialchars & upchar & lowchar
            Dim snu As String = specialchars & numbchar & upchar
            Dim su As String = specialchars & upchar
            Dim nl As String = numbchar & lowchar
            Dim n As String = numbchar
            Dim l As String = lowchar
            Dim u As String = upchar
            Dim nlu As String = numbchar & lowchar & upchar
            Dim sl As String = specialchars & lowchar
            Dim nu As String = numbchar & upchar
            Dim ul As String = upchar & lowchar
            Dim r As New Random
            Dim sb As New StringBuilder
            If specialchar.Checked = True Then
                If uppercasecb.Checked = True Then
                    If lowercasecb.Checked = True Then
                        If numberscb.Checked = True Then
                            For z = 1 To Int(lines.Text)
                                For o = 1 To CInt(length.Text)
                                    Dim idx As Integer = r.Next(0, suln.Length)
                                    sb.Append(suln.Substring(idx, 1))
                                Next
                                sb.Append(vbCrLf)
                            Next
                            generatetxt.Text = sb.ToString.Substring(0, sb.Length - 2)
                        End If
                    End If
                End If
            End If

            If specialchar.Checked = True Then
                If uppercasecb.Checked = False Then
                    If lowercasecb.Checked = True Then
                        If numberscb.Checked = True Then
                            For z = 1 To Int(lines.Text)
                                For o = 1 To CInt(length.Text)
                                    Dim idx As Integer = r.Next(0, snl.Length)
                                    sb.Append(snl.Substring(idx, 1))
                                Next
                                sb.Append(vbCrLf)
                            Next
                            generatetxt.Text = sb.ToString.Substring(0, sb.Length - 2)
                        End If
                    End If
                End If
            End If

            If specialchar.Checked = True Then
                If uppercasecb.Checked = False Then
                    If lowercasecb.Checked = False Then
                        If numberscb.Checked = True Then
                            For z = 1 To Int(lines.Text)
                                For o = 1 To CInt(length.Text)
                                    Dim idx As Integer = r.Next(0, sn.Length)
                                    sb.Append(sn.Substring(idx, 1))
                                Next
                                sb.Append(vbCrLf)
                            Next
                            generatetxt.Text = sb.ToString.Substring(0, sb.Length - 2)
                        End If
                    End If
                End If
            End If

            If specialchar.Checked = True Then
                If uppercasecb.Checked = False Then
                    If lowercasecb.Checked = False Then
                        If numberscb.Checked = False Then
                            For z = 1 To Int(lines.Text)
                                For o = 1 To CInt(length.Text)
                                    Dim idx As Integer = r.Next(0, s.Length)
                                    sb.Append(s.Substring(idx, 1))
                                Next
                                sb.Append(vbCrLf)
                            Next
                            generatetxt.Text = sb.ToString.Substring(0, sb.Length - 2)
                        End If
                    End If
                End If
            End If

            If specialchar.Checked = True Then
                If uppercasecb.Checked = True Then
                    If lowercasecb.Checked = True Then
                        If numberscb.Checked = False Then
                            For z = 1 To Int(lines.Text)
                                For o = 1 To CInt(length.Text)
                                    Dim idx As Integer = r.Next(0, sul.Length)
                                    sb.Append(sul.Substring(idx, 1))
                                Next
                                sb.Append(vbCrLf)
                            Next
                            generatetxt.Text = sb.ToString.Substring(0, sb.Length - 2)
                        End If
                    End If
                End If
            End If

            If specialchar.Checked = True Then
                If uppercasecb.Checked = True Then
                    If lowercasecb.Checked = False Then
                        If numberscb.Checked = True Then
                            For z = 1 To Int(lines.Text)
                                For o = 1 To CInt(length.Text)
                                    Dim idx As Integer = r.Next(0, snu.Length)
                                    sb.Append(snu.Substring(idx, 1))
                                Next
                                sb.Append(vbCrLf)
                            Next
                            generatetxt.Text = sb.ToString.Substring(0, sb.Length - 2)
                        End If
                    End If
                End If
            End If

            If specialchar.Checked = True Then
                If uppercasecb.Checked = True Then
                    If lowercasecb.Checked = False Then
                        If numberscb.Checked = False Then
                            For z = 1 To Int(lines.Text)
                                For o = 1 To CInt(length.Text)
                                    Dim idx As Integer = r.Next(0, su.Length)
                                    sb.Append(su.Substring(idx, 1))
                                Next
                                sb.Append(vbCrLf)
                            Next
                            generatetxt.Text = sb.ToString.Substring(0, sb.Length - 2)
                        End If
                    End If
                End If
            End If


            If specialchar.Checked = False Then
                If uppercasecb.Checked = False Then
                    If lowercasecb.Checked = True Then
                        If numberscb.Checked = True Then
                            For z = 1 To Int(lines.Text)
                                For o = 1 To CInt(length.Text)
                                    Dim idx As Integer = r.Next(0, nl.Length)
                                    sb.Append(nl.Substring(idx, 1))
                                Next
                                sb.Append(vbCrLf)
                            Next
                            generatetxt.Text = sb.ToString.Substring(0, sb.Length - 2)
                        End If
                    End If
                End If
            End If

            If specialchar.Checked = False Then
                If uppercasecb.Checked = False Then
                    If lowercasecb.Checked = False Then
                        If numberscb.Checked = True Then
                            For z = 1 To Int(lines.Text)
                                For o = 1 To CInt(length.Text)
                                    Dim idx As Integer = r.Next(0, n.Length)
                                    sb.Append(n.Substring(idx, 1))
                                Next
                                sb.Append(vbCrLf)
                            Next
                            generatetxt.Text = sb.ToString.Substring(0, sb.Length - 2)
                        End If
                    End If
                End If
            End If

            If specialchar.Checked = False Then
                If uppercasecb.Checked = False Then
                    If lowercasecb.Checked = True Then
                        If numberscb.Checked = False Then
                            For z = 1 To Int(lines.Text)
                                For o = 1 To CInt(length.Text)
                                    Dim idx As Integer = r.Next(0, l.Length)
                                    sb.Append(l.Substring(idx, 1))
                                Next
                                sb.Append(vbCrLf)
                            Next
                            generatetxt.Text = sb.ToString.Substring(0, sb.Length - 2)
                        End If
                    End If
                End If
            End If

            If specialchar.Checked = False Then
                If uppercasecb.Checked = True Then
                    If lowercasecb.Checked = False Then
                        If numberscb.Checked = False Then
                            For z = 1 To Int(lines.Text)
                                For o = 1 To CInt(length.Text)
                                    Dim idx As Integer = r.Next(0, u.Length)
                                    sb.Append(u.Substring(idx, 1))
                                Next
                                sb.Append(vbCrLf)
                            Next
                            generatetxt.Text = sb.ToString.Substring(0, sb.Length - 2)
                        End If
                    End If
                End If
            End If
            If specialchar.Checked = False Then
                If uppercasecb.Checked = True Then
                    If lowercasecb.Checked = True Then
                        If numberscb.Checked = True Then
                            For z = 1 To Int(lines.Text)
                                For o = 1 To CInt(length.Text)
                                    Dim idx As Integer = r.Next(0, nlu.Length)
                                    sb.Append(nlu.Substring(idx, 1))
                                Next
                                sb.Append(vbCrLf)
                            Next
                            generatetxt.Text = sb.ToString.Substring(0, sb.Length - 2)
                        End If
                    End If
                End If
            End If
            If specialchar.Checked = True Then
                If uppercasecb.Checked = False Then
                    If lowercasecb.Checked = True Then
                        If numberscb.Checked = False Then
                            For z = 1 To Int(lines.Text)
                                For o = 1 To CInt(length.Text)
                                    Dim idx As Integer = r.Next(0, sl.Length)
                                    sb.Append(sl.Substring(idx, 1))
                                Next
                                sb.Append(vbCrLf)
                            Next
                            generatetxt.Text = sb.ToString.Substring(0, sb.Length - 2)
                        End If
                    End If
                End If
            End If

            If specialchar.Checked = False Then
                If uppercasecb.Checked = True Then
                    If lowercasecb.Checked = False Then
                        If numberscb.Checked = True Then
                            For z = 1 To Int(lines.Text)
                                For o = 1 To CInt(length.Text)
                                    Dim idx As Integer = r.Next(0, nu.Length)
                                    sb.Append(nu.Substring(idx, 1))
                                Next
                                sb.Append(vbCrLf)
                            Next
                            generatetxt.Text = sb.ToString.Substring(0, sb.Length - 2)
                        End If
                    End If
                End If
            End If

            If specialchar.Checked = False Then
                If uppercasecb.Checked = True Then
                    If lowercasecb.Checked = True Then
                        If numberscb.Checked = False Then
                            For z = 1 To Int(lines.Text)
                                For o = 1 To CInt(length.Text)
                                    Dim idx As Integer = r.Next(0, ul.Length)
                                    sb.Append(ul.Substring(idx, 1))
                                Next
                                sb.Append(vbCrLf)
                            Next
                            generatetxt.Text = sb.ToString.Substring(0, sb.Length - 2)
                        End If
                    End If
                End If
            End If
        End Sub

        Private Sub copybt_Click_1(sender As Object, e As EventArgs) Handles copybt.Click
            Clipboard.SetText(generatetxt.Text)
            If Startwindow.Langname = "English" Then
                MessageBox.Show("Text copied!", "copied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Text kopiert!", "Kopiert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub

        Private Sub generatetxt_TextChanged(sender As Object, e As EventArgs) Handles generatetxt.TextChanged
            If generatetxt.Text.Length < 1 Then
                attachments.Visible = False
                saveas_bt.Visible = False
            Else
                attachments.Visible = True
                saveas_bt.Visible = True
            End If
            Dim replace_char As String = generatetxt.Text
            If Startwindow.Langname = "English" Then
                pw_length.Text = "length: " & replace_char.Replace(vbCrLf, Nothing).Length
            Else
                pw_length.Text = "Zeichen: " & replace_char.Replace(vbCrLf, Nothing).Length
            End If

            If generatetxt.Text.Length > 0 Then
                copybt.Enabled = True
            Else
                copybt.Enabled = False
            End If
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

        Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
            Close()
        End Sub

        Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
            lines.Text += 1
        End Sub

        Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
            lines.Text -= 1
        End Sub

        Private Sub saveas_bt_Click(sender As Object, e As EventArgs) Handles saveas_bt.Click
            save_pw_dialog.ShowDialog()

        End Sub

        Private Sub save_pw_dialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles save_pw_dialog.FileOk
            If attachments.Checked = True Then
                File.AppendAllText(save_pw_dialog.FileName, generatetxt.Text & vbNewLine)
            Else
                File.WriteAllText(save_pw_dialog.FileName, generatetxt.Text)
            End If

            If Startwindow.Langname = "English" Then
                MessageBox.Show("saved!", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Gespeichert!", "Gespeichert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub

        Private Sub passwordgenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim loadcolor As New designcolor
            loadcolor.color()
        End Sub

        Private Sub passwordgenerator_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
            If Startwindow.vCommand = True Then
                Application.Exit()
            End If
        End Sub
    End Class
End Namespace