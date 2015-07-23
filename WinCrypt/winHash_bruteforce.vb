Option Strict On
Imports System.IO
Public Class winHash_bruteforce
    Dim crypt_md5 As String
    Dim encrypt_md5 As String
    Dim counter As Integer = 0
    Dim hashstatus As String
    Dim passstat As String
    Dim testpw As String
    Dim progmin As Integer = 0
    Dim progmax As Integer
    Dim langname As New language
    Private Sub startbf_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbf_bt.Click
        If inHash_Textbox.Text.Length = 32 Then
            If My.Computer.FileSystem.FileExists(file_txt.Text) Then
                inHash_Textbox.Enabled = False
                file_txt.Enabled = False
                open_bt.Enabled = False
                progresscheck.Enabled = False
                If progresscheck.Checked = True Then
                    progresstimer.Enabled = True
                    Dim lastLine As String = String.Empty
                    Using reader As New StreamReader(file_txt.Text)
                        Do Until reader.EndOfStream
                            lastLine = reader.ReadLine
                            progmax += 1
                        Loop
                    End Using
                    ProgressBar1.Maximum = progmax
                Else : End If
                startbf_bt.Visible = False
                stopbf_bt.Visible = True
                status_lb.Visible = True
                md5lb.Visible = True
                counter = 0
                bgw.RunWorkerAsync()
                statustimer.Enabled = True
            Else
                If langname.langname = "English" Then
                    MessageBox.Show("the password list does not exist!", "passwordlist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("Die Passwortliste existiert nicht!", "Passwortliste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Else
            If langname.langname = "English" Then
                MessageBox.Show("please enter a hash!", "note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Bitte geben Sie einen Hash ein!", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub
    Private Sub open_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_bt.Click
        OpenFileDialog.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog.FileName) Then
            file_txt.Text = OpenFileDialog.FileName
        Else : End If
    End Sub
    Private Sub bgw_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgw.DoWork
        Dim Daten_lesen() As String = IO.File.ReadAllLines(file_txt.Text)
        For Each pwline As String In Daten_lesen
            If bgw.CancellationPending = True Then
                Exit For
            End If
            Select Case theHash_ComboBox.Text
                Case "MD5"
                    If winHash.HashString(Daten_lesen(counter), winHash.HASH.MD5) = inHash_Textbox.Text Then
                        passstat = Daten_lesen(counter)
                        MsgBox("Crack it!", MsgBoxStyle.Exclamation)
                        Exit For
                    End If
                    hashstatus = winHash.HashString(Daten_lesen(counter), winHash.HASH.MD5)
                Case "SHA1"
                    If winHash.HashString(Daten_lesen(counter), winHash.HASH.SHA1) = inHash_Textbox.Text Then
                        passstat = Daten_lesen(counter)
                        MsgBox("Crack it!", MsgBoxStyle.Exclamation)
                        Exit For
                    End If
                    hashstatus = winHash.HashString(Daten_lesen(counter), winHash.HASH.SHA1)
                Case "SHA256"
                    If winHash.HashString(Daten_lesen(counter), winHash.HASH.SHA256) = inHash_Textbox.Text Then
                        passstat = Daten_lesen(counter)
                        MsgBox("Crack it!", MsgBoxStyle.Exclamation)
                        Exit For
                    End If
                    hashstatus = winHash.HashString(Daten_lesen(counter), winHash.HASH.SHA256)
                Case "SHA384"
                    If winHash.HashString(Daten_lesen(counter), winHash.HASH.SHA384) = inHash_Textbox.Text Then
                        passstat = Daten_lesen(counter)
                        MsgBox("Crack it!", MsgBoxStyle.Exclamation)
                        Exit For
                    End If
                    hashstatus = winHash.HashString(Daten_lesen(counter), winHash.HASH.SHA384)
                Case "SHA512"
                    If winHash.HashString(Daten_lesen(counter), winHash.HASH.SHA512) = inHash_Textbox.Text Then
                        passstat = Daten_lesen(counter)
                        MsgBox("Crack it!", MsgBoxStyle.Exclamation)
                        Exit For
                    End If
                    hashstatus = winHash.HashString(Daten_lesen(counter), winHash.HASH.SHA512)
            End Select
            testpw = Daten_lesen(counter)
            counter += 1
        Next
    End Sub

    Private Sub statustimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles statustimer.Tick
        If langname.langname = "English" Then
            status_lb.Text = "Status: [ " & counter & " ] Passwörter getestet"
        Else
            status_lb.Text = "Status: [ " & counter & " ] passwords tested"
        End If
        md5lb.Text = "MD5: " & hashstatus
        testedpw_lb.Text = "tested password: " & testpw
        If passstat = "" Then
        Else
            password_lb.Visible = True
            If langname.langname = "English" Then
                password_lb.Text = "password: " & passstat
            Else
                password_lb.Text = "Passwort: " & passstat
            End If
            statustimer.Enabled = False
        End If
    End Sub
    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal hProcess As IntPtr, ByVal dwMinimumWorkingSetSize As Int32, ByVal dwMaximumWorkingSetSize As Int32) As Int32
    Private Sub bgw_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted
        If password_lb.Visible = True Then
            line_lb.Visible = True
            line_lb.Text = "Line: " & counter
            counter = 0
        Else
            If langname.langname = "English" Then
                MsgBox("password not found!")
            Else
                MsgBox("Passwort nicht gefunden!")
            End If
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
            End If
            bgw.Dispose()
            startbf_bt.Visible = True
            stopbf_bt.Visible = False
            statustimer.Enabled = False
            counter = 0
        End If

    End Sub
    Private Sub stopbf_bt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopbf_bt.Click
        bgw.CancelAsync()
        startbf_bt.Visible = True
        stopbf_bt.Visible = False
        statustimer.Enabled = False
        progresstimer.Enabled = False
        progresscheck.Enabled = True
        inHash_Textbox.Enabled = True
        file_txt.Enabled = True
        open_bt.Enabled = True
    End Sub

    Private Sub progresscheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles progresscheck.CheckedChanged
        If progresscheck.Checked = True Then
            Dim size1 As New Size(437, 319)
            Me.Size = size1
        Else
            Dim size2 As New Size(437, 286)
            Me.Size = size2
        End If
    End Sub
    Private Sub progresstimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles progresstimer.Tick
        If progresscheck.Checked = True Then
            ProgressBar1.Value = counter
        Else : End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(langname.langname)
    End Sub
    Private Sub md5_bruteforce_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        langname.check()
        theHash_ComboBox.SelectedIndex = 0
    End Sub
End Class