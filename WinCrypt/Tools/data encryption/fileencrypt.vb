Option Strict On
Imports System.ComponentModel

Namespace tools.data_encryption
    Public Class Fileencrypt
        Private Sub fileopenbt_Click(sender As Object, e As EventArgs) Handles fileopenbt.Click
            OpenFileDialog.ShowDialog()
            If My.Computer.FileSystem.FileExists(OpenFileDialog.FileName) Then
                filetxt.Text = OpenFileDialog.FileName
                savefilebt.Enabled = True
                savepathtxt.Enabled = True
            Else
            End If
        End Sub

        Private Sub savefilebt_Click(sender As Object, e As EventArgs) Handles savefilebt.Click
            FolderBrowserDialog.ShowDialog()
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog.SelectedPath) Then
                savepathtxt.Text = FolderBrowserDialog.SelectedPath
                passwordtxt.Enabled = True
                generatebt.Enabled = True
                If Startwindow.Iniread = "yes" Then
                    encryptbt.Enabled = True
                Else
                End If
            Else
            End If
        End Sub

        Private Sub generatebt_Click(sender As Object, e As EventArgs) Handles generatebt.Click
            Dim numCharacters As Integer
            Dim i As Integer
            Dim txt = ""
            Dim ch As Integer
            Randomize()
            numCharacters = CInt(32)
            For i = 1 To numCharacters
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
            passwordtxt.Text = txt
        End Sub

        Private Sub passwordtxt_KeyDown(sender As Object, e As KeyEventArgs) Handles passwordtxt.KeyDown
            If e.KeyCode = Keys.Enter Then
                encryptbt.PerformClick()
            End If
        End Sub

        Private Sub passwordtxt_TextChanged(sender As Object, e As EventArgs) Handles passwordtxt.TextChanged
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
                If My.Computer.FileSystem.FileExists(filetxt.Text) Then
                    If My.Computer.FileSystem.DirectoryExists(savepathtxt.Text) Then
                        CryptFile(Startwindow.Biosid, filetxt.Text,
                                                        savepathtxt.Text & "\" & i.Substring(1, i.Length - 1) & ".wc", True)
                        My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)

                        If Startwindow.Langname = "English" Then
                            statuslb.Text = String.Format("File {0} encrypted!", i.Substring(1, i.Length - 1))
                        Else
                            statuslb.Text = String.Format("Datei {0} wurde verschlüsselt!", i.Substring(1, i.Length - 1))
                        End If
                        filetxt.Text = ""
                        savepathtxt.Text = ""
                        passwordtxt.Text = ""
                        savepathtxt.Enabled = False
                        passwordtxt.Enabled = False
                        savefilebt.Enabled = False
                        encryptbt.Enabled = False
                        generatebt.Enabled = False
                    Else
                        If Startwindow.Langname = "English" Then
                            MsgBox("Location does not exist!", MsgBoxStyle.Exclamation)
                        Else
                            MsgBox("Speicherort existiert nicht!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                Else
                    If Startwindow.Langname = "English" Then
                        MsgBox("File does not exist!!", MsgBoxStyle.Exclamation)
                    Else
                        MsgBox("Datei existiert nicht!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                If My.Computer.FileSystem.FileExists(filetxt.Text) Then
                    If My.Computer.FileSystem.DirectoryExists(savepathtxt.Text) Then
                        If passwordtxt.Text.Length < 6 Then

                            If Startwindow.Langname = "English" Then
                                MsgBox("Password is too short!", MsgBoxStyle.Information)
                            Else
                                MsgBox("Passwort zu kurz!", MsgBoxStyle.Information)
                            End If
                        Else
                            CryptFile(passwordtxt.Text, filetxt.Text,
                                                            savepathtxt.Text & "\" & i.Substring(1, i.Length - 1) & ".wc", True)
                            My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)

                            If Startwindow.Langname = "English" Then
                                statuslb.Text = String.Format("File {0} encrypted!", i.Substring(1, i.Length - 1))
                            Else
                                statuslb.Text = String.Format("Datei {0} wurde verschlüsselt!", i.Substring(1, i.Length - 1))
                            End If
                            filetxt.Text = ""
                            savepathtxt.Text = ""
                            passwordtxt.Text = ""
                            savepathtxt.Enabled = False
                            passwordtxt.Enabled = False
                            savefilebt.Enabled = False
                            encryptbt.Enabled = False
                            generatebt.Enabled = False
                        End If
                    Else
                        If Startwindow.Langname = "English" Then
                            MsgBox("Location does not exist!", MsgBoxStyle.Exclamation)
                        Else
                            MsgBox("Speicherort existiert nicht!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                Else
                    If Startwindow.Langname = "English" Then
                        MsgBox("File does not exist!!", MsgBoxStyle.Exclamation)
                    Else
                        MsgBox("Datei existiert nicht!", MsgBoxStyle.Exclamation)
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
            If My.Computer.FileSystem.FileExists(filetxt.Text) Then
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