Option Strict On
Imports System.IO
Public Class bruteforce
    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal hProcess As IntPtr, ByVal dwMinimumWorkingSetSize As Int32, ByVal dwMaximumWorkingSetSize As Int32) As Int32

    Dim langname As New language

    Dim bruteforceSate As Boolean       '\\ status ob der bruteforce aktiv ist

    Dim currentPassword As String       '\\ das Aktuell getestete Passwort 
    Dim currentHash As String           '\\ der Hash des aktuellen Passwort 
    Dim searchedHash As String          '\\ der gesuchte Hash
    Dim rightHash As String             '\\ das gesuchte Passwort
    Dim Hashtype As String              '\\ welcher Hash wird verwendet (MD5, SHA1, SHA256 usw.)
    Dim checked As Integer = 0          '\\ anzahl der getesteten Hash's

    Private Sub bruteforceToggle_Click(sender As Object, e As EventArgs) Handles bruteforceToggle.Click

        Dim checkData As Boolean = False
        Dim progmax As Integer
        Dim lastLine As String = String.Empty

        If bruteforceSate Then
            '\\ Den Brute Force vorzeitig beenden
            resetData()
        Else

            '\\ Überprüfen ob der Hash richtig sein kann
            If bruteforcesearchedHash.Text.Length < 32 Then
                If langname.langname = "English" Then
                    MessageBox.Show("please enter a hash!", "note", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Bitte geben Sie einen Hash ein!", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                '\\ Testen ob die WordList noch exisiteiert
                If My.Computer.FileSystem.FileExists(fileWordlist.Text) Then
                    checkData = True
                Else
                    If langname.langname = "English" Then
                        MessageBox.Show("the password list does not exist!", "passwordlist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        MessageBox.Show("Die Passwortliste existiert nicht!", "Passwortliste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                rightHash = Nothing
                bruteforcerightPassword.Visible = False
                bruteforceLine.Visible = False
                searchedHash = bruteforcesearchedHash.Text
                bruteforcesearchedHash.Enabled = False
                fileWordlist.Enabled = False
                openWordlist.Enabled = False
                bruteforceHashtype.Enabled = False
                bruteforceWorker_status.Start()
                bruteforceSate = True
                bruteforceToggle.Text = "Cancel"

                bgw.RunWorkerAsync()
            End If

        End If

    End Sub

    Private Sub openWordlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openWordlist.Click

        '\\ Öffnen eines Auswahldialoges für Daten
        OpenFileDialog.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog.FileName) Then fileWordlist.Text = OpenFileDialog.FileName

    End Sub


    Private Sub bruteforceWorker(sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgw.DoWork

        Dim internTick As Integer

        '\\ einlesen der Wortliste anhand des lokalen Pfad
        For Each lineWordlist As String In IO.File.ReadAllLines(fileWordlist.Text)

            '\\ anzeigewerte setzen
            checked += 1
            currentPassword = lineWordlist

            '\\ bei einen abbruchbefehl den backgroundWorker anhalten
            If bgw.CancellationPending = True Then
                Exit For
            End If

            '\\ anhand des ausgewählten Hash dass aktuell geprüfte wort zum vergleich Hashen
            Select Case Hashtype
                Case "MD5"
                    currentHash = rHash.HashString(lineWordlist, rHash.HASH.MD5)
                Case "SHA1"
                    currentHash = rHash.HashString(lineWordlist, rHash.HASH.SHA1)
                Case "SHA256"
                    currentHash = rHash.HashString(lineWordlist, rHash.HASH.SHA256)
                Case "SHA384"
                    currentHash = rHash.HashString(lineWordlist, rHash.HASH.SHA384)
                Case "SHA512"
                    currentHash = rHash.HashString(lineWordlist, rHash.HASH.SHA512)
                Case "RIPEMD160"
                    currentHash = rHash.HashString(lineWordlist, rHash.HASH.RIPEMD160)
            End Select

            internTick += 1

            '\\ überprüfen ob das aktuelle wort zum gesuchten Hash passt
            If currentHash = searchedHash Then
                rightHash = lineWordlist
                checked = internTick
                currentPassword = lineWordlist
                Exit For
            End If

        Next
    End Sub

    Private Sub bruteforceWorker_status_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bruteforceWorker_status.Tick

        '\\ Ausgabe von Infromationen
        Select Case langname.langname
            Case "English"
                bruteforceStatus.Text = String.Format("Status: [{0}] passwords tested", checked)
                bruteforcePassword.Text = String.Format("current password: {0}", currentPassword)
            Case Else
                bruteforceStatus.Text = String.Format("Status: [{0}] Passwörter getestet", checked)
                bruteforcePassword.Text = String.Format("aktuelles Passwort: {0}", currentPassword)
        End Select
        bruteforceHash.Text = String.Format("Hash: {0}", currentHash)
        bruteforceChecked.Value = checked
    End Sub

    Private Sub foundHash()



        '\\ Richtiges Passwort setzen
        Select Case langname.langname
            Case "English"
                bruteforceStatus.Text = String.Format("Status: [{0}] passwords tested", checked)
                bruteforcePassword.Text = String.Format("current password: {0}", currentPassword)
                bruteforcerightPassword.Text = String.Format("password: {0}", rightHash)
            Case Else
                bruteforceStatus.Text = String.Format("Status: [{0}] Passwörter getestet", checked)
                bruteforcePassword.Text = String.Format("aktuelles Passwort: {0}", currentPassword)
                bruteforcerightPassword.Text = String.Format("Passwort: {0}", rightHash)
        End Select
        bruteforceLine.Text = String.Format("Line: {0}", checked)
        bruteforceHash.Text = String.Format("Hash: {0}", currentHash)

        '\\ Daten zurücksetzen
        resetData()

    End Sub

    Private Sub missHash(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted

        If rightHash = Nothing Then
            '\\ Fehlermeldung ausgeben
            Select Case langname.langname
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
            foundHash()
        End If
    End Sub

    Private Sub resetData()

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
        bruteforceSate = False
        checked = 0


    End Sub

    Private Sub progresscheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showProgress.CheckedChanged

        '\\ Größe der Form für die Progressbar anzeige anpassen
        If showProgress.Checked Then
            Me.Size = New Size(437, 319)
        Else
            Me.Size = New Size(437, 286)
        End If

    End Sub

    Private Sub md5_bruteforce_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '\\ Standartwerte Laden
        langname.check()
        bruteforceHashtype.SelectedIndex = 0

    End Sub

    Private Sub bruteforceHashtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bruteforceHashtype.SelectedIndexChanged

        '\\ den Hash Typen setzen
        Hashtype = bruteforceHashtype.Text

    End Sub
End Class