Option Strict On

Imports System.ComponentModel
Imports System.IO
Imports Project_WinCrypt.classes

Namespace tools.hash
    Public Class Bruteforce
        Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (hProcess As IntPtr,
                                                                             dwMinimumWorkingSetSize As Int32,
                                                                             dwMaximumWorkingSetSize As Int32) As Int32

        ReadOnly _langname As New language

        Dim _bruteforceSate As Boolean       '\\ status ob der bruteforce aktiv ist

        Dim _currentPassword As String       '\\ das Aktuell getestete Passwort 
        Dim _currentHash As String           '\\ der Hash des aktuellen Passwort 
        Dim _searchedHash As String          '\\ der gesuchte Hash
        Dim _rightHash As String             '\\ das gesuchte Passwort
        Dim _hashtype As String              '\\ welcher Hash wird verwendet (MD5, SHA1, SHA256 usw.)
        Dim _checked As Integer = 0          '\\ anzahl der getesteten Hash's

        Private Sub bruteforceToggle_Click(sender As Object, e As EventArgs) Handles bruteforceToggle.Click

            Dim checkData = False
            Dim progmax As Integer
            Dim lastLine As String = String.Empty

            If _bruteforceSate Then
                '\\ Den Brute Force vorzeitig beenden
                resetData()
            Else

                '\\ Überprüfen ob der Hash richtig sein kann
                If bruteforcesearchedHash.Text.Length < 32 Then
                    If _langname.langname = "English" Then
                        MessageBox.Show("please enter a hash!", "note", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Bitte geben Sie einen Hash ein!", "Hinweis", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)
                    End If
                Else
                    '\\ Testen ob die WordList noch exisiteiert
                    If File.Exists(fileWordlist.Text) Then
                        checkData = True
                    Else
                        If _langname.langname = "English" Then
                            MessageBox.Show("the password list does not exist!", "passwordlist", MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation)
                        Else
                            MessageBox.Show("Die Passwortliste existiert nicht!", "Passwortliste", MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation)
                        End If
                    End If
                End If

                '\\ Sollten beide Test erfolgtreich sein den Brute Force starten
                If checkData Then
                    Using reader As New StreamReader(fileWordlist.Text)
                        Do Until reader.EndOfStream
                            lastLine = reader.ReadLine
                            progmax += 1
                        Loop
                    End Using
                    bruteforceChecked.Maximum = progmax
                    _rightHash = Nothing
                    bruteforcerightPassword.Visible = False
                    bruteforceLine.Visible = False
                    _searchedHash = bruteforcesearchedHash.Text
                    bruteforcesearchedHash.Enabled = False
                    fileWordlist.Enabled = False
                    openWordlist.Enabled = False
                    bruteforceHashtype.Enabled = False
                    bruteforceWorker_status.Start()
                    _bruteforceSate = True
                    bruteforceToggle.Text = "Cancel"

                    bgw.RunWorkerAsync()
                End If

            End If
        End Sub

        Private Sub openWordlist_Click(sender As Object, e As EventArgs) Handles openWordlist.Click

            '\\ Öffnen eines Auswahldialoges für Daten
            OpenFileDialog.ShowDialog()
            If File.Exists(OpenFileDialog.FileName) Then fileWordlist.Text = OpenFileDialog.FileName
        End Sub


        Private Sub BruteforceWorker(sender As Object, e As DoWorkEventArgs) Handles bgw.DoWork

            Dim internTick As Integer

            '\\ einlesen der Wortliste anhand des lokalen Pfad
            For Each lineWordlist As String In File.ReadAllLines(fileWordlist.Text)

                '\\ anzeigewerte setzen
                _checked += 1
                _currentPassword = lineWordlist

                '\\ bei einen abbruchbefehl den backgroundWorker anhalten
                If bgw.CancellationPending = True Then
                    Exit For
                End If

                '\\ anhand des ausgewählten Hash dass aktuell geprüfte wort zum vergleich Hashen
                Select Case _hashtype
                    Case "MD5"
                        _currentHash = rHash.HashString(lineWordlist, rHash.HASH.MD5)
                    Case "SHA1"
                        _currentHash = rHash.HashString(lineWordlist, rHash.HASH.SHA1)
                    Case "SHA256"
                        _currentHash = rHash.HashString(lineWordlist, rHash.HASH.SHA256)
                    Case "SHA384"
                        _currentHash = rHash.HashString(lineWordlist, rHash.HASH.SHA384)
                    Case "SHA512"
                        _currentHash = rHash.HashString(lineWordlist, rHash.HASH.SHA512)
                    Case "RIPEMD160"
                        _currentHash = rHash.HashString(lineWordlist, rHash.HASH.RIPEMD160)
                End Select

                internTick += 1

                '\\ überprüfen ob das aktuelle wort zum gesuchten Hash passt
                If _currentHash = _searchedHash Then
                    _rightHash = lineWordlist
                    _checked = internTick
                    _currentPassword = lineWordlist
                    Exit For
                End If

            Next
        End Sub

        Private Sub bruteforceWorker_status_Tick(sender As Object, e As EventArgs) Handles bruteforceWorker_status.Tick

            '\\ Ausgabe von Infromationen
            Select Case _langname.langname
                Case "English"
                    bruteforceStatus.Text = String.Format("Status: [{0}] passwords tested", _checked)
                    bruteforcePassword.Text = String.Format("current password: {0}", _currentPassword)
                Case Else
                    bruteforceStatus.Text = String.Format("Status: [{0}] Passwörter getestet", _checked)
                    bruteforcePassword.Text = String.Format("aktuelles Passwort: {0}", _currentPassword)
            End Select
            bruteforceHash.Text = String.Format("Hash: {0}", _currentHash)
            bruteforceChecked.Value = _checked
        End Sub

        Private Sub FoundHash()


            '\\ Richtiges Passwort setzen
            Select Case _langname.langname
                Case "English"
                    bruteforceStatus.Text = String.Format("Status: [{0}] passwords tested", _checked)
                    bruteforcePassword.Text = String.Format("current password: {0}", _currentPassword)
                    bruteforcerightPassword.Text = String.Format("password: {0}", _rightHash)
                Case Else
                    bruteforceStatus.Text = String.Format("Status: [{0}] Passwörter getestet", _checked)
                    bruteforcePassword.Text = String.Format("aktuelles Passwort: {0}", _currentPassword)
                    bruteforcerightPassword.Text = String.Format("Passwort: {0}", _rightHash)
            End Select
            bruteforceLine.Text = String.Format("Line: {0}", _checked)
            bruteforceHash.Text = String.Format("Hash: {0}", _currentHash)

            '\\ Daten zurücksetzen
            resetData()
        End Sub

        Private Sub MissHash(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted

            If _rightHash = Nothing Then
                '\\ Fehlermeldung ausgeben
                Select Case _langname.langname
                    Case "English"
                        bruteforcerightPassword.Text = "password: password not found!"
                    Case Else
                        bruteforcerightPassword.Text = "Passwort: Passwort nicht gefunden!"
                End Select
                bruteforceLine.Text = "Line:"

                '\\ Freigeben des verwendeten Speicher
                GC.Collect()
                GC.WaitForPendingFinalizers()
                If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                    SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                End If

                '\\ Daten zurücksetzen
                resetData()

            Else
                FoundHash()
            End If
        End Sub

        Private Sub ResetData()

            '\\ Daten zurücksetzen
            Try
                bgw.CancelAsync()
            Catch ex As Exception
            End Try

            bgw.Dispose()
            bruteforceWorker_status.Stop()
            bruteforcesearchedHash.Enabled = True
            bruteforcerightPassword.Visible = True
            bruteforceLine.Visible = True
            bruteforceToggle.Text = "Brute Force"
            bruteforceHashtype.Enabled = True

            fileWordlist.Enabled = True
            openWordlist.Enabled = True
            _bruteforceSate = False
            _checked = 0
        End Sub

        Private Sub progresscheck_CheckedChanged(sender As Object, e As EventArgs) Handles showProgress.CheckedChanged

            '\\ Größe der Form für die Progressbar anzeige anpassen
            If showProgress.Checked Then
                Size = New Size(421, 315)
            Else
                Size = New Size(421, 276)
            End If
        End Sub

        Private Sub md5_bruteforce_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim loadcolor As New designcolor
            loadcolor.color()
            '\\ Standartwerte Laden
            _langname.check()
            bruteforceHashtype.SelectedIndex = 0
        End Sub

        Private Sub bruteforceHashtype_SelectedIndexChanged(sender As Object, e As EventArgs) _
            Handles bruteforceHashtype.SelectedIndexChanged

            '\\ den Hash Typen setzen
            _hashtype = bruteforceHashtype.Text
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

        Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
            WindowState = FormWindowState.Minimized
        End Sub

        Private Sub bruteforcesearchedHash_KeyDown(sender As Object, e As KeyEventArgs) _
            Handles bruteforcesearchedHash.KeyDown
            If e.KeyCode = Keys.Enter Then
                bruteforceToggle.PerformClick()
            End If
        End Sub
    End Class
End Namespace