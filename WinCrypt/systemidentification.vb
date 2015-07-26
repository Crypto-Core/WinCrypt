Option Strict On
Public Class systemidentification
    Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
    Dim ini As New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")
    Dim restart As String = startwindow.iniread
    Dim restart1 As String = "no"
    Dim filezip As New Zip
    Private Sub ok(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_bt.Click
        If restart = restart1 Then
        Else
            If startwindow.formclose = True Then
                If MsgBox("Laufwerk " & startwindow.drivecb.Text & " ist eingebunden" & vbCrLf & "Sie müssen dieses Laufwerk vorher erst schließen. Möchten Sie dieses Laufwerk schließen?", MsgBoxStyle.YesNo, "Achtung") = MsgBoxResult.Yes Then
                    startwindow.dismount.PerformClick()
                Else : End If
            Else
                If startwindow.langname = "English" Then
                    If MsgBox("Need to accept the change WinCrypt be restarted." & vbCrLf & "Do you want to WinCrypt restart?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        If on_rb.Checked = True Then
                            ini.WertSchreiben("systemidentification", "status", "yes")
                            restart1 = "yes"
                        End If
                        If off_rb.Checked = True Then
                            ini.WertSchreiben("systemidentification", "status", "no")
                            restart1 = "no"
                        End If
                        Application.Restart()
                    Else : End If
                Else
                    If MsgBox("Um die änderung zu übernehmen muss WinCrypt neu gestartet werden" & vbCrLf & "Möchte Sie das Programm neu starten?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        If on_rb.Checked = True Then
                            ini.WertSchreiben("systemidentification", "status", "yes")
                            restart1 = "yes"
                        End If
                        If off_rb.Checked = True Then
                            ini.WertSchreiben("systemidentification", "status", "no")
                            restart1 = "no"
                        End If
                        Application.Restart()
                    Else : End If
                End If
            End If
        End If
        Me.Close()
    End Sub

    Private Sub systemidentification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If startwindow.iniread = "yes" Then
            on_rb.Checked = True
        Else
            off_rb.Checked = True
        End If
    End Sub

    Private Sub off_rb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles off_rb.CheckedChanged
        restart1 = "no"
    End Sub

    Private Sub on_rb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles on_rb.CheckedChanged
        restart1 = "yes"
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Me.Close()
    End Sub
    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            wincrypttitle.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            MenuStrip1.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
End Class