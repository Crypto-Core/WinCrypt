Option Strict On
Public Class passwortgenerator

    Private Sub generatebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generatebt.Click
        generatetxt.MaxLength = CInt(length.Text)
        Dim num_characters As Integer
        Dim i As Integer
        Dim txt As String
        Dim ch As Integer
        Randomize()
        num_characters = CInt(length.Text)
        If uppercasecb.Checked = True Then
            If lowercasecb.Checked = True Then
                If numberscb.Checked = True Then
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
                    generatetxt.Text = txt
                End If
            End If
        End If

        If uppercasecb.Checked = False Then
            If lowercasecb.Checked = True Then
                If numberscb.Checked = True Then
                    For i = 1 To num_characters
                        ch = CInt(Int((26 + 26 + 10) * Rnd()))
                        If ch < 26 Then
                            txt = txt & Chr(ch + Asc("a"))
                        ElseIf ch < 2 * 26 Then
                            ch = ch - 26
                            txt = txt & Chr(ch + Asc("a"))
                        Else
                            ch = ch - 26 - 26
                            txt = txt & Chr(ch + Asc("0"))
                        End If
                    Next i
                    generatetxt.Text = txt
                End If
            End If

        End If

        If uppercasecb.Checked = False Then
            If lowercasecb.Checked = False Then
                If numberscb.Checked = True Then
                    For i = 1 To num_characters
                        ch = CInt(Int((26 + 26 + 10) * Rnd()))
                        ch = ch - 26 - 26
                        txt = txt & Int(ch + Asc("0"))

                    Next i
                    generatetxt.Text = txt.Replace("-", "").Substring(0, CInt(length.Text))
                End If
            End If
        End If

        If uppercasecb.Checked = False Then
            If lowercasecb.Checked = True Then
                If numberscb.Checked = False Then
                    For i = 1 To num_characters
                        ch = CInt(Int((26 + 26 + 10) * Rnd()))
                        If ch < 26 Then
                            txt = txt & Chr(ch + Asc("a"))
                        ElseIf ch < 2 * 26 Then
                            ch = ch - 26
                            txt = txt & Chr(ch + Asc("a"))
                        Else
                            ch = ch - 26 - 26
                            txt = txt & Chr(ch + Asc("a"))
                        End If
                    Next i
                    generatetxt.Text = txt
                End If
            End If
        End If

        If uppercasecb.Checked = True Then
            If lowercasecb.Checked = False Then
                If numberscb.Checked = False Then
                    For i = 1 To num_characters
                        ch = CInt(Int((26 + 26 + 10) * Rnd()))
                        If ch < 26 Then
                            txt = txt & Chr(ch + Asc("A"))
                        ElseIf ch < 2 * 26 Then
                            ch = ch - 26
                            txt = txt & Chr(ch + Asc("A"))
                        Else
                            ch = ch - 26 - 26
                            txt = txt & Chr(ch + Asc("A"))
                        End If
                    Next i
                    generatetxt.Text = txt
                End If
            End If
        End If

        If uppercasecb.Checked = True Then
            If lowercasecb.Checked = False Then
                If numberscb.Checked = True Then
                    For i = 1 To num_characters
                        ch = CInt(Int((26 + 26 + 10) * Rnd()))
                        If ch < 26 Then
                            txt = txt & Chr(ch + Asc("A"))
                        ElseIf ch < 2 * 26 Then
                            ch = ch - 26
                            txt = txt & Chr(ch + Asc("A"))
                        Else
                            ch = ch - 26 - 26
                            txt = txt & Chr(ch + Asc("0"))
                        End If
                    Next i
                    generatetxt.Text = txt
                End If
            End If
        End If

        If uppercasecb.Checked = True Then
            If lowercasecb.Checked = True Then
                If numberscb.Checked = False Then
                    For i = 1 To num_characters
                        ch = CInt(Int((26 + 26 + 10) * Rnd()))
                        If ch < 26 Then
                            txt = txt & Chr(ch + Asc("A"))
                        ElseIf ch < 2 * 26 Then
                            ch = ch - 26
                            txt = txt & Chr(ch + Asc("A"))
                        Else
                            ch = ch - 26 - 26
                            txt = txt & Chr(ch + Asc("a"))
                        End If
                    Next i
                    generatetxt.Text = txt
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