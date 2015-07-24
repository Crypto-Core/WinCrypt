Option Strict On

Imports System.Text

Public Class passwordgenerator

    Private Sub generatebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generatebt.Click
        Dim specialchars As String = "!§$%&/()=?`#+-_.,<>:;*'^"
        Dim upchar As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim lowchar As String = "abcdefghijklmnopqrstuvwxyz"
        Dim numbchar As String = "1234567890"

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
                        For o As Integer = 1 To CInt(length.Text)
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
                        For o As Integer = 1 To CInt(length.Text)
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
                        For o As Integer = 1 To CInt(length.Text)
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
                        For o As Integer = 1 To CInt(length.Text)
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
                        For o As Integer = 1 To CInt(length.Text)
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
                        For o As Integer = 1 To CInt(length.Text)
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
                        For o As Integer = 1 To CInt(length.Text)
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
                        For o As Integer = 1 To CInt(length.Text)
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
                        For o As Integer = 1 To CInt(length.Text)
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
                        For o As Integer = 1 To CInt(length.Text)
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
                        For o As Integer = 1 To CInt(length.Text)
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
                        For o As Integer = 1 To CInt(length.Text)
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
                        For o As Integer = 1 To CInt(length.Text)
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
                        For o As Integer = 1 To CInt(length.Text)
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
                        For o As Integer = 1 To CInt(length.Text)
                            Dim idx As Integer = r.Next(0, ul.Length)
                            sb.Append(ul.Substring(idx, 1))
                        Next
                        generatetxt.Text = sb.ToString
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub copybt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles copybt.Click
        My.Computer.Clipboard.SetText(generatetxt.Text)
        If startwindow.langname = "English" Then
            MsgBox("Text copied!!", MsgBoxStyle.Information, "Copy")
        Else
            MsgBox("Text kopiert!", MsgBoxStyle.Information, "Kopiert")
        End If
    End Sub

    Private Sub generatetxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generatetxt.TextChanged
        If generatetxt.Text.Length > 0 Then
            copybt.Enabled = True
        Else
            copybt.Enabled = False
        End If
    End Sub
End Class