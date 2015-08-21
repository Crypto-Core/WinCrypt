Option Strict On

Imports System.IO
Imports Project_WinCrypt.classes

Public Class Systemidentification
    ReadOnly _
        _ini As _
            New IniDatei(String.Format("{0}\WinCrypt\config.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))

    ReadOnly _restart As String = Startwindow.Iniread
    Private _restart1 As String = "no"
    Public Property Filezip As Zip = New Zip

    Private Sub Ok(sender As Object, e As EventArgs) Handles ok_bt.Click
        If _restart = _restart1 Then
        Else
            If Startwindow.Formclose = True Then

                If _
                    MessageBox.Show("Laufwerk " & Startwindow.drivecb.Text & " ist eingebunden" & vbCrLf & "Sie müssen dieses Laufwerk vorher erst schließen. Möchten Sie dieses Laufwerk schließen?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
                    Startwindow.dismount.PerformClick()
                Else
                End If
            Else
                If Startwindow.Langname = "English" Then
                    
                    If _
                        MessageBox.Show("Need to accept the change WinCrypt be restarted." & vbCrLf &
                            "Do you want to WinCrypt restart?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
                        If on_rb.Checked = True Then
                            _ini.WertSchreiben("systemidentification", "status", "yes")
                            _restart1 = "yes"
                        End If
                        If off_rb.Checked = True Then
                            _ini.WertSchreiben("systemidentification", "status", "no")
                            _restart1 = "no"
                        End If
                        Application.Restart()
                    Else
                    End If
                Else
                    If _
                        MessageBox.Show("Um die änderung zu übernehmen muss WinCrypt neu gestartet werden" & vbCrLf &
                            "Möchte Sie das Programm neu starten?", "Hinweis", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = MsgBoxResult.Yes Then
                        If on_rb.Checked = True Then
                            _ini.WertSchreiben("systemidentification", "status", "yes")
                            _restart1 = "yes"
                        End If
                        If off_rb.Checked = True Then
                            _ini.WertSchreiben("systemidentification", "status", "no")
                            _restart1 = "no"
                        End If
                        Application.Restart()
                    Else
                    End If
                End If
            End If
        End If
        Close()
    End Sub

    Private Sub systemidentification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loadcolor As New designcolor
        loadcolor.color()
        If Startwindow.Iniread = "yes" Then
            on_rb.Checked = True
        Else
            off_rb.Checked = True
        End If
    End Sub

    Private Sub off_rb_CheckedChanged(sender As Object, e As EventArgs) Handles off_rb.CheckedChanged
        _restart1 = "no"
    End Sub

    Private Sub on_rb_CheckedChanged(sender As Object, e As EventArgs) Handles on_rb.CheckedChanged
        _restart1 = "yes"
    End Sub

    Private Sub minimize_bt_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub exit_bt_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Close()
    End Sub

    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = MouseButtons.Left) Then
            wincrypttitle.Capture = False
            WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else
        End If
    End Sub

    Private Sub form_head_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = MouseButtons.Left) Then
            form_head.Capture = False
            WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else
        End If
    End Sub
End Class