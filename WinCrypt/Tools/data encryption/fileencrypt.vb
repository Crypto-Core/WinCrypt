Option Strict On
Imports System.ComponentModel
Imports System.IO
Namespace tools.data_encryption
    Public Class Fileencrypt
        Private Sub fileopenbt_Click(sender As Object, e As EventArgs) Handles fileopenbt.Click
            OpenFileDialog.ShowDialog()
            If File.Exists(OpenFileDialog.FileName) Then
                filetxt.Text = OpenFileDialog.FileName
                savefilebt.Enabled = True
                savepathtxt.Enabled = True
            Else : End If
        End Sub

        Private Sub savefilebt_Click(sender As Object, e As EventArgs) Handles savefilebt.Click
            FolderBrowserDialog.ShowDialog()
            If Directory.Exists(FolderBrowserDialog.SelectedPath) Then
                savepathtxt.Text = FolderBrowserDialog.SelectedPath
                passwordtxt.Enabled = True
                generatebt.Enabled = True
                If Startwindow.Iniread = "yes" Then
                    encryptbt.Enabled = True
                Else : End If
            Else
            End If
        End Sub

        Private Sub generatebt_Click(sender As Object, e As EventArgs) Handles generatebt.Click
            Dim numCharacters As Integer
            Dim i As Integer
            Dim txt = Nothing
            Dim ch As Integer
            Randomize()
            numCharacters = CInt(32)
            For i = 1 To numCharacters
                ch = CInt(Int((26 + 26 + 10) * Rnd()))
                If ch < 26 Then
                    txt = CStr(txt) & Chr(ch + Asc("A"))
                ElseIf ch < 2 * 26 Then
                    ch = ch - 26
                    txt = CStr(txt) & Chr(ch + Asc("a"))
                Else
                    ch = ch - 26 - 26
                    txt = CStr(txt) & Chr(ch + Asc("0"))
                End If
            Next i
            passwordtxt.Text = CStr(txt)
        End Sub

        Private Sub passwordtxt_KeyDown(sender As Object, e As KeyEventArgs) Handles passwordtxt.KeyDown
            If e.KeyCode = Keys.Enter Then
                encryptbt.PerformClick()
            End If
        End Sub

        Private Sub passwordtxt_TextChanged(sender As Object, e As EventArgs) Handles passwordtxt.TextChanged
            Dim passstrength As New Passstrength
            If passstrength.PasswordStrength(passwordtxt.Text, passwordtxt.Text.Length) = -0 Then
                Dim color As New designcolor
                passwordtxt.BackColor = color.inputbackgroundcolor
            End If
            If passstrength.PasswordStrength(passwordtxt.Text, passwordtxt.Text.Length) = 1 Then
                Dim color As New designcolor
                passwordtxt.BackColor = Drawing.Color.Red
            End If
            If passstrength.PasswordStrength(passwordtxt.Text, passwordtxt.Text.Length) = 2 Then
                Dim color As New designcolor
                passwordtxt.BackColor = Drawing.Color.Yellow
            End If
            If passstrength.PasswordStrength(passwordtxt.Text, passwordtxt.Text.Length) = 3 Then
                Dim color As New designcolor
                passwordtxt.BackColor = Drawing.Color.GreenYellow
            End If
            If passstrength.PasswordStrength(passwordtxt.Text, passwordtxt.Text.Length) = 4 Then
                Dim color As New designcolor
                passwordtxt.BackColor = Drawing.Color.Lime
            End If
            If Startwindow.Iniread = "yes" Then
                encryptbt.Enabled = True
            Else
                If passwordtxt.Text.Length < 6 Then
                    encryptbt.Enabled = False
                Else
                    encryptbt.Enabled = True
                End If
            End If
        End Sub

        Private Sub encryptbt_Click(sender As Object, e As EventArgs) Handles encryptbt.Click
            Dim i As String = filetxt.Text.Substring(filetxt.Text.LastIndexOf("\", StringComparison.Ordinal),
                                                     filetxt.Text.Length - filetxt.Text.LastIndexOf("\", StringComparison.Ordinal))
            If Startwindow.Iniread = "yes" Then
                If File.Exists(filetxt.Text) Then
                    If Directory.Exists(savepathtxt.Text) Then
                        classes.CryptFile(Startwindow.Biosid, filetxt.Text,
                                                        savepathtxt.Text & "\" & i.Substring(1, Int(i.Length - 1)) & ".wc", True)
                        My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)
                        If Startwindow.Langname = "English" Then
                            statuslb.Text = String.Format("File {0} encrypted!", i.Substring(1, i.Length - 1))
                        Else
                            statuslb.Text = String.Format("Datei {0} wurde verschlüsselt!", i.Substring(1, i.Length - 1))
                        End If
                        filetxt.Text = Nothing
                        savepathtxt.Text = Nothing
                        passwordtxt.Text = Nothing
                        savepathtxt.Enabled = False
                        passwordtxt.Enabled = False
                        savefilebt.Enabled = False
                        encryptbt.Enabled = False
                        generatebt.Enabled = False
                    Else
                        If Startwindow.Langname = "English" Then
                            MessageBox.Show("Location does not exist!", "Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Else
                            MessageBox.Show("Speicherort existiert nicht!", "Speicherort", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                Else
                    If Startwindow.Langname = CStr("English") Then
                        MessageBox.Show(CStr("File does not exist!"), CStr("File"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        MessageBox.Show("Datei existiert nicht!", "Datei", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            Else

                If File.Exists(CStr(filetxt.Text)) Then
                    If Directory.Exists(CStr(savepathtxt.Text)) Then
                        If Int(passwordtxt.Text.Length) < 6 Then
                            If Startwindow.Langname = CStr("English") Then
                                MessageBox.Show(CStr("Password is too short!"), CStr("Password"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Else
                                MessageBox.Show(CStr("Passwort ist zu kurz!"), CStr("Passwort"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                            End If
                        Else
                            classes.CryptFile(passwordtxt.Text, filetxt.Text,
                                                            savepathtxt.Text & "\" & i.Substring(1, i.Length - 1) & ".wc", True)
                            My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)

                            If Startwindow.Langname = "English" Then
                                statuslb.Text = String.Format("File {0} encrypted!", i.Substring(1, i.Length - 1))
                            Else
                                statuslb.Text = String.Format("Datei {0} wurde verschlüsselt!", i.Substring(1, i.Length - 1))
                            End If
                            filetxt.Text = Nothing
                            savepathtxt.Text = Nothing
                            passwordtxt.Text = Nothing
                            savepathtxt.Enabled = False
                            passwordtxt.Enabled = False
                            savefilebt.Enabled = False
                            encryptbt.Enabled = False
                            generatebt.Enabled = False
                        End If
                    Else
                        If Startwindow.Langname = "English" Then
                            MessageBox.Show("Location does not exist!", "Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Else
                            MessageBox.Show("Speicherort existiert nicht!", "Speicherort", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                Else
                    If Startwindow.Langname = "English" Then
                        MessageBox.Show("File does not exist!", "file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        MessageBox.Show("Datei existiert nicht!", "Datei", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            End If
        End Sub

        Private Sub filetxt_DragDrop(sender As Object, e As DragEventArgs) Handles filetxt.DragDrop
            Dim filestr() As String
            Dim str As String
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
                str = filestr(0)
                filetxt.Text = str
            End If
        End Sub

        Private Sub filetxt_DragEnter(sender As Object, e As DragEventArgs) Handles filetxt.DragEnter
            e.Effect = e.AllowedEffect
        End Sub

        Private Sub savepathtxt_DragDrop(sender As Object, e As DragEventArgs) Handles savepathtxt.DragDrop
            Dim filestr() As String
            Dim str As String
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
                str = filestr(0)
                filetxt.Text = str
            End If
        End Sub

        Private Sub savepathtxt_DragEnter(sender As Object, e As DragEventArgs) Handles savepathtxt.DragEnter
            e.Effect = e.AllowedEffect
        End Sub

        Private Sub statuslb_DragDrop(sender As Object, e As DragEventArgs) Handles statuslb.DragDrop
            Dim filestr() As String
            Dim str As String
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
                str = filestr(0)
                filetxt.Text = str
            End If
        End Sub

        Private Sub statuslb_DragEnter(sender As Object, e As DragEventArgs) Handles statuslb.DragEnter
            e.Effect = e.AllowedEffect
        End Sub

        Private Sub DateiVerschluesseln_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
            Dim filestr() As String
            Dim str As String
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
                str = filestr(0)
                filetxt.Text = str
            End If
        End Sub

        Private Sub DateiVerschluesseln_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
            e.Effect = e.AllowedEffect
        End Sub

        Private Sub filetxt_TextChanged(sender As Object, e As EventArgs) Handles filetxt.TextChanged
            If File.Exists(CStr(filetxt.Text)) Then
                savefilebt.Enabled = True
                savepathtxt.Enabled = True
            Else
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

        Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
            WindowState = FormWindowState.Minimized
        End Sub

        Private Sub Fileencrypt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim loadcolor As New designcolor
            loadcolor.color()
        End Sub

        Private Sub Fileencrypt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
            If Startwindow.vCommand = True Then
                Startwindow.Close()
            End If
        End Sub
    End Class
End Namespace