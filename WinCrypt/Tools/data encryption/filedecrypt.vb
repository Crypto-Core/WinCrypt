Option Strict On
Imports System.ComponentModel

Namespace tools.data_encryption
    Public Class Filedecrypt
        Private Sub safevile_Click(sender As Object, e As EventArgs) Handles savefile.Click
            FolderBrowserDialog.ShowDialog()
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog.SelectedPath) Then
                pathtxt.Text = FolderBrowserDialog.SelectedPath &
                               filetxt.Text.Remove(0, filetxt.Text.LastIndexOf("\", StringComparison.Ordinal)).Replace(".wc", "")
                passwordtxt.Enabled = True
                If Startwindow.Iniread = "yes" Then
                    decrypt.Enabled = True
                Else
                End If
            End If
        End Sub

        Private Sub passwordtxt_DragEnter(sender As Object, e As DragEventArgs) Handles passwordtxt.DragEnter
            e.Effect = e.AllowedEffect
        End Sub

        Private Sub passwordtxt_TextChanged(sender As Object, e As EventArgs) Handles passwordtxt.TextChanged
            If Startwindow.Iniread = "yes" Then

            Else
                If passwordtxt.Text.Length < 6 Then
                    decrypt.Enabled = False
                Else
                    decrypt.Enabled = True
                End If
            End If
        End Sub

        Private Sub dencrypt_Click(sender As Object, e As EventArgs) Handles decrypt.Click
            If Startwindow.Iniread = "yes" Then
                Dim i As String = filetxt.Text.Substring(filetxt.Text.LastIndexOf("\", StringComparison.Ordinal),
                                                         filetxt.Text.Length - filetxt.Text.LastIndexOf("\", StringComparison.Ordinal))
                If My.Computer.FileSystem.FileExists(filetxt.Text) Then
                    If My.Computer.FileSystem.DirectoryExists(pathtxt.Text.Substring(0, pathtxt.Text.LastIndexOf("\", StringComparison.Ordinal))) Then
                        DecryptFile(Startwindow.Biosid, filetxt.Text, pathtxt.Text)
                        My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)
                        If Startwindow.Langname = "English" Then
                            statuslb.Text = String.Format("File {0} was decrypted!!", i.Substring(1, i.Length - 1))
                        Else
                            statuslb.Text = String.Format("Datei {0} wurde entschlüsselt!", i.Substring(1, i.Length - 1))
                        End If
                        filetxt.Text = ""
                        pathtxt.Text = ""
                        passwordtxt.Text = ""
                        pathtxt.Enabled = False
                        passwordtxt.Enabled = False
                        savefile.Enabled = False
                        decrypt.Enabled = False
                    Else
                        MsgBox("Pfad existiert nicht!")
                    End If
                Else
                    MsgBox("Datei existiert nicht!")
                End If
            Else
                Dim i As String = filetxt.Text.Substring(filetxt.Text.LastIndexOf("\", StringComparison.Ordinal),
                                                         filetxt.Text.Length - filetxt.Text.LastIndexOf("\", StringComparison.Ordinal))
                If My.Computer.FileSystem.FileExists(filetxt.Text) Then
                    If My.Computer.FileSystem.DirectoryExists(pathtxt.Text.Substring(0, pathtxt.Text.LastIndexOf("\", StringComparison.Ordinal))) Then
                        DecryptFile(passwordtxt.Text, filetxt.Text, pathtxt.Text)
                        My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)
                        If Startwindow.Langname = "English" Then
                            statuslb.Text = String.Format("File {0} was decrypted!!", i.Substring(1, i.Length - 1))
                        Else
                            statuslb.Text = String.Format("Datei {0} wurde entschlüsselt!", i.Substring(1, i.Length - 1))
                        End If
                        filetxt.Text = ""
                        pathtxt.Text = ""
                        passwordtxt.Text = ""
                        pathtxt.Enabled = False
                        passwordtxt.Enabled = False
                        savefile.Enabled = False
                        decrypt.Enabled = False
                    Else
                    End If
                Else
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

        Private Sub pathtxt_DragDrop(sender As Object, e As DragEventArgs) Handles pathtxt.DragDrop
            Dim filestr() As String
            Dim str As String
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
                str = filestr(0)
                filetxt.Text = str
            End If
        End Sub

        Private Sub pathtxt_DragEnter(sender As Object, e As DragEventArgs) Handles pathtxt.DragEnter
            e.Effect = e.AllowedEffect
        End Sub

        Private Sub passwordtxt_DragDrop(sender As Object, e As DragEventArgs) Handles passwordtxt.DragDrop
            Dim filestr() As String
            Dim str As String
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
                str = filestr(0)
                filetxt.Text = str
            End If
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

        Private Sub DateiEntschluesseln_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
            Dim filestr() As String
            Dim str As String
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
                str = filestr(0)
                filetxt.Text = str
            End If
        End Sub

        Private Sub DateiEntschluesseln_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
            e.Effect = e.AllowedEffect
        End Sub

        Private Sub filetxt_TextChanged(sender As Object, e As EventArgs) Handles filetxt.TextChanged
            If My.Computer.FileSystem.FileExists(filetxt.Text) Then
                pathtxt.Enabled = True
                savefile.Enabled = True
            Else
            End If
        End Sub

        Private Sub openfile_Click(sender As Object, e As EventArgs) Handles openfile.Click
            OpenFileDialog.ShowDialog()
            If My.Computer.FileSystem.FileExists(OpenFileDialog.FileName) Then
                filetxt.Text = OpenFileDialog.FileName
                pathtxt.Enabled = True
                savefile.Enabled = True
            Else
            End If
        End Sub

        Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
            WindowState = FormWindowState.Minimized
        End Sub

        Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
            Close()
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

        Private Sub passwordtxt_KeyDown(sender As Object, e As KeyEventArgs) Handles passwordtxt.KeyDown
            If e.KeyCode = Keys.Enter Then
                decrypt.PerformClick()
            End If
        End Sub

        Private Sub Filedecrypt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim loadcolor As New designcolor
            loadcolor.color()
        End Sub

        Private Sub Filedecrypt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
            If Startwindow.vCommand = True Then
                Application.Exit()
            End If
        End Sub
    End Class
End Namespace