Option Strict On

Imports System.IO

Public Class systemidentification
    Dim ReadOnly root As New DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)

    Dim ReadOnly _
        ini As _
            New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")

    Dim ReadOnly restart As String = startwindow.iniread
    Dim restart1 As String = "no"
    Dim filezip As New Zip

    Private Sub ok(sender As Object, e As EventArgs) Handles ok_bt.Click
        If restart = restart1 Then
        Else
            If startwindow.formclose = True Then
                If _
                    MsgBox(
                        "Laufwerk " & startwindow.drivecb.Text & " ist eingebunden" & vbCrLf &
                        "Sie müssen dieses Laufwerk vorher erst schließen. Möchten Sie dieses Laufwerk schließen?",
                        MsgBoxStyle.YesNo, "Achtung") = MsgBoxResult.Yes Then
                    startwindow.dismount.PerformClick()
                Else :
                End If
            Else
                If startwindow.langname = "English" Then
                    If _
                        MsgBox(
                            "Need to accept the change WinCrypt be restarted." & vbCrLf &
                            "Do you want to WinCrypt restart?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        If on_rb.Checked = True Then
                            ini.WertSchreiben("systemidentification", "status", "yes")
                            restart1 = "yes"
                        End If
                        If off_rb.Checked = True Then
                            ini.WertSchreiben("systemidentification", "status", "no")
                            restart1 = "no"
                        End If
                        Application.Restart()
                    Else :
                    End If
                Else
                    If _
                        MsgBox(
                            "Um die änderung zu übernehmen muss WinCrypt neu gestartet werden" & vbCrLf &
                            "Möchte Sie das Programm neu starten?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        If on_rb.Checked = True Then
                            ini.WertSchreiben("systemidentification", "status", "yes")
                            restart1 = "yes"
                        End If
                        If off_rb.Checked = True Then
                            ini.WertSchreiben("systemidentification", "status", "no")
                            restart1 = "no"
                        End If
                        Application.Restart()
                    Else :
                    End If
                End If
            End If
        End If
        Me.Close()
    End Sub

    Private Sub systemidentification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If startwindow.iniread = "yes" Then
            on_rb.Checked = True
        Else
            off_rb.Checked = True
        End If
    End Sub

    Private Sub off_rb_CheckedChanged(sender As Object, e As EventArgs) Handles off_rb.CheckedChanged
        restart1 = "no"
    End Sub

    Private Sub on_rb_CheckedChanged(sender As Object, e As EventArgs) Handles on_rb.CheckedChanged
        restart1 = "yes"
    End Sub

    Private Sub minimize_bt_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub exit_bt_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Me.Close()
    End Sub

    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = MouseButtons.Left) Then
            wincrypttitle.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else :
        End If
    End Sub

    Private Sub form_head_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = MouseButtons.Left) Then
            form_head.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else :
        End If
    End Sub
End Class