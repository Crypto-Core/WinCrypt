Option Strict On

Imports System.Text

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
                        For o = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, suln.Length)
                            sb.Append(suln.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If

        If specialchar.Checked = True Then
            If uppercasecb.Checked = False Then
                If lowercasecb.Checked = True Then
                    If numberscb.Checked = True Then
                        For o = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, snl.Length)
                            sb.Append(snl.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If

        If specialchar.Checked = True Then
            If uppercasecb.Checked = False Then
                If lowercasecb.Checked = False Then
                    If numberscb.Checked = True Then
                        For o = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, sn.Length)
                            sb.Append(sn.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If

        If specialchar.Checked = True Then
            If uppercasecb.Checked = False Then
                If lowercasecb.Checked = False Then
                    If numberscb.Checked = False Then
                        For o = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, s.Length)
                            sb.Append(s.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If

        If specialchar.Checked = True Then
            If uppercasecb.Checked = True Then
                If lowercasecb.Checked = True Then
                    If numberscb.Checked = False Then
                        For o = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, sul.Length)
                            sb.Append(sul.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If

        If specialchar.Checked = True Then
            If uppercasecb.Checked = True Then
                If lowercasecb.Checked = False Then
                    If numberscb.Checked = True Then
                        For o = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, snu.Length)
                            sb.Append(snu.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If

        If specialchar.Checked = True Then
            If uppercasecb.Checked = True Then
                If lowercasecb.Checked = False Then
                    If numberscb.Checked = False Then
                        For o = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, su.Length)
                            sb.Append(su.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If


        If specialchar.Checked = False Then
            If uppercasecb.Checked = False Then
                If lowercasecb.Checked = True Then
                    If numberscb.Checked = True Then
                        For o = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, nl.Length)
                            sb.Append(nl.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If

        If specialchar.Checked = False Then
            If uppercasecb.Checked = False Then
                If lowercasecb.Checked = False Then
                    If numberscb.Checked = True Then
                        For o = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, n.Length)
                            sb.Append(n.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If

        If specialchar.Checked = False Then
            If uppercasecb.Checked = False Then
                If lowercasecb.Checked = True Then
                    If numberscb.Checked = False Then
                        For o = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, l.Length)
                            sb.Append(l.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If

        If specialchar.Checked = False Then
            If uppercasecb.Checked = True Then
                If lowercasecb.Checked = False Then
                    If numberscb.Checked = False Then
                        For o = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, u.Length)
                            sb.Append(u.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If
        If specialchar.Checked = False Then
            If uppercasecb.Checked = True Then
                If lowercasecb.Checked = True Then
                    If numberscb.Checked = True Then
                        For o = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, nlu.Length)
                            sb.Append(nlu.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If
        If specialchar.Checked = True Then
            If uppercasecb.Checked = False Then
                If lowercasecb.Checked = True Then
                    If numberscb.Checked = False Then
                        For o = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, sl.Length)
                            sb.Append(sl.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If

        If specialchar.Checked = False Then
            If uppercasecb.Checked = True Then
                If lowercasecb.Checked = False Then
                    If numberscb.Checked = True Then
                        For o = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, nu.Length)
                            sb.Append(nu.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If

        If specialchar.Checked = False Then
            If uppercasecb.Checked = True Then
                If lowercasecb.Checked = True Then
                    If numberscb.Checked = False Then
                        For o = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, ul.Length)
                            sb.Append(ul.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub copybt_Click_1(sender As Object, e As EventArgs) Handles copybt.Click
        My.Computer.Clipboard.SetText(generatetxt.Text)
        If startwindow.langname = "English" Then
            MsgBox("Text copied!!", MsgBoxStyle.Information, "Copy")
        Else
            MsgBox("Text kopiert!", MsgBoxStyle.Information, "Kopiert")
        End If
    End Sub

    Private Sub generatetxt_TextChanged(sender As Object, e As EventArgs) Handles generatetxt.TextChanged
        If generatetxt.Text.Length > 0 Then
            copybt.Enabled = True
        Else
            copybt.Enabled = False
        End If
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

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Me.Close()
    End Sub
End Class