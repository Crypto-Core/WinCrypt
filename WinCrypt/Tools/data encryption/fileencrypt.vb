Option Strict On
Public Class fileencrypt

    Private Sub fileopenbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fileopenbt.Click
        OpenFileDialog.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog.FileName) Then
            filetxt.Text = OpenFileDialog.FileName
            savefilebt.Enabled = True
            savepathtxt.Enabled = True
        Else : End If
    End Sub

    Private Sub savefilebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savefilebt.Click
        FolderBrowserDialog.ShowDialog()
        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog.SelectedPath) Then
            savepathtxt.Text = FolderBrowserDialog.SelectedPath
            passwordtxt.Enabled = True
            generatebt.Enabled = True
            If startwindow.iniread = "yes" Then
                encryptbt.Enabled = True
            Else : End If
        Else : End If
    End Sub

    Private Sub generatebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generatebt.Click
        Dim num_characters As Integer
        Dim i As Integer
        Dim txt As String = ""
        Dim ch As Integer
        Randomize()
        num_characters = CInt(32)
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
        passwordtxt.Text = txt
    End Sub

    Private Sub passwordtxt_KeyDown(sender As Object, e As KeyEventArgs) Handles passwordtxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            encryptbt.PerformClick()
        End If
    End Sub

    Private Sub passwordtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passwordtxt.TextChanged
        If startwindow.iniread = "yes" Then
            encryptbt.Enabled = True
        Else
            If passwordtxt.Text.Length < 6 Then
                encryptbt.Enabled = False
            Else
                encryptbt.Enabled = True
            End If
        End If
    End Sub

    Private Sub encryptbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles encryptbt.Click
        Dim i As String = filetxt.Text.Substring(filetxt.Text.LastIndexOf("\"), filetxt.Text.Length - filetxt.Text.LastIndexOf("\"))
        If startwindow.iniread = "yes" Then
            If My.Computer.FileSystem.FileExists(filetxt.Text) Then
                If My.Computer.FileSystem.DirectoryExists(savepathtxt.Text) Then
                    CryptoStuff.CryptFile(startwindow.biosid, filetxt.Text, savepathtxt.Text & "\" & i.Substring(1, i.Length - 1) & ".wc", True)
                    My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)

                    If startwindow.langname = "English" Then
                        statuslb.Text = "File " & i.Substring(1, i.Length - 1) & " encrypted!"
                    Else
                        statuslb.Text = "Datei " & i.Substring(1, i.Length - 1) & " wurde verschlüsselt!"
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
                    If startwindow.langname = "English" Then
                        MsgBox("Location does not exist!", MsgBoxStyle.Exclamation)
                    Else
                        MsgBox("Speicherort existiert nicht!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                If startwindow.langname = "English" Then
                    MsgBox("File does not exist!!", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Datei existiert nicht!", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            If My.Computer.FileSystem.FileExists(filetxt.Text) Then
                If My.Computer.FileSystem.DirectoryExists(savepathtxt.Text) Then
                    If passwordtxt.Text.Length < 6 Then

                        If startwindow.langname = "English" Then
                            MsgBox("Password is too short!", MsgBoxStyle.Information)
                        Else
                            MsgBox("Passwort zu kurz!", MsgBoxStyle.Information)
                        End If
                    Else
                        CryptoStuff.CryptFile(passwordtxt.Text, filetxt.Text, savepathtxt.Text & "\" & i.Substring(1, i.Length - 1) & ".wc", True)
                        My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)

                        If startwindow.langname = "English" Then
                            statuslb.Text = "File " & i.Substring(1, i.Length - 1) & " encrypted!"
                        Else
                            statuslb.Text = "Datei " & i.Substring(1, i.Length - 1) & " wurde verschlüsselt!"
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
                    If startwindow.langname = "English" Then
                        MsgBox("Location does not exist!", MsgBoxStyle.Exclamation)
                    Else
                        MsgBox("Speicherort existiert nicht!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                If startwindow.langname = "English" Then
                    MsgBox("File does not exist!!", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Datei existiert nicht!", MsgBoxStyle.Exclamation)
                End If
            End If
        End If

    End Sub
    Private Sub filetxt_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles filetxt.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
            str = filestr(0)
            filetxt.Text = str
        End If
    End Sub

    Private Sub filetxt_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles filetxt.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub savepathtxt_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles savepathtxt.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
            str = filestr(0)
            filetxt.Text = str
        End If
    End Sub

    Private Sub savepathtxt_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles savepathtxt.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub statuslb_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles statuslb.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
            str = filestr(0)
            filetxt.Text = str
        End If
    End Sub

    Private Sub statuslb_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles statuslb.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub DateiVerschluesseln_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
            str = filestr(0)
            filetxt.Text = str
        End If
    End Sub

    Private Sub DateiVerschluesseln_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub filetxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filetxt.TextChanged
        If My.Computer.FileSystem.FileExists(filetxt.Text) Then
            savefilebt.Enabled = True
            savepathtxt.Enabled = True
        Else : End If
    End Sub
    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            wincrypttitle.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            form_head.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class