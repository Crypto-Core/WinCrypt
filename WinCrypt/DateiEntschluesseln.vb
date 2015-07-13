Public Class DateiEntschluesseln

    Private Sub safevile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savefile.Click
        FolderBrowserDialog.ShowDialog()
        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog.SelectedPath) Then
            pathtxt.Text = FolderBrowserDialog.SelectedPath & filetxt.Text.Remove(0, filetxt.Text.LastIndexOf("\")).Replace(".wc", "")
            passwordtxt.Enabled = True
            If startwindow.iniread = "true" Then
                dencrypt.Enabled = True
            Else

            End If
        End If
    End Sub

    Private Sub passwordtxt_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles passwordtxt.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub passwordtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passwordtxt.TextChanged
        If startwindow.iniread = "true" Then

        Else
            If passwordtxt.Text.Length < 6 Then
                dencrypt.Enabled = False
            Else
                dencrypt.Enabled = True

            End If
        End If
    End Sub

    Private Sub dencrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dencrypt.Click
        If startwindow.iniread = "true" Then
            Dim i As String = filetxt.Text.Substring(filetxt.Text.LastIndexOf("\"), filetxt.Text.Length - filetxt.Text.LastIndexOf("\"))
            If My.Computer.FileSystem.FileExists(filetxt.Text) Then
                If My.Computer.FileSystem.DirectoryExists(pathtxt.Text.Substring(0, pathtxt.Text.LastIndexOf("\"))) Then
                    CryptoStuff.DecryptFile(startwindow.biosid, filetxt.Text, pathtxt.Text)
                    My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)

                    If startwindow.langname = "English" Then
                        statuslb.Text = "File " & i.Substring(1, i.Length - 1) & " was decrypted!!"
                    Else
                        statuslb.Text = "Datei " & i.Substring(1, i.Length - 1) & " wurde entschlüsselt!"
                    End If
                    filetxt.Text = ""
                    pathtxt.Text = ""
                    passwordtxt.Text = ""
                    pathtxt.Enabled = False
                    passwordtxt.Enabled = False
                    savefile.Enabled = False
                    dencrypt.Enabled = False
                Else
                    MsgBox("Pfad existiert nicht!")
                End If
            Else
                MsgBox("Datei existiert nicht!")
            End If
        Else
            Dim i As String = filetxt.Text.Substring(filetxt.Text.LastIndexOf("\"), filetxt.Text.Length - filetxt.Text.LastIndexOf("\"))
            If My.Computer.FileSystem.FileExists(filetxt.Text) Then
                If My.Computer.FileSystem.DirectoryExists(pathtxt.Text.Substring(0, pathtxt.Text.LastIndexOf("\"))) Then
                    CryptoStuff.DecryptFile(passwordtxt.Text, filetxt.Text, pathtxt.Text)
                    My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)
                    If startwindow.langname = "English" Then
                        statuslb.Text = "File " & i.Substring(1, i.Length - 1) & " was decrypted!!"
                    Else
                        statuslb.Text = "Datei " & i.Substring(1, i.Length - 1) & " wurde entschlüsselt!"
                    End If
                    filetxt.Text = ""
                    pathtxt.Text = ""
                    passwordtxt.Text = ""
                    pathtxt.Enabled = False
                    passwordtxt.Enabled = False
                    savefile.Enabled = False
                    dencrypt.Enabled = False
                Else

                End If

            Else

            End If
        End If

    End Sub

    Private Sub filetxt_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles filetxt.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = e.Data.GetData(DataFormats.FileDrop)
            str = filestr(0)
            filetxt.Text = str
        End If
    End Sub

    Private Sub filetxt_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles filetxt.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub pathtxt_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pathtxt.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = e.Data.GetData(DataFormats.FileDrop)
            str = filestr(0)
            filetxt.Text = str
        End If
    End Sub

    Private Sub pathtxt_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pathtxt.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub passwordtxt_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles passwordtxt.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = e.Data.GetData(DataFormats.FileDrop)
            str = filestr(0)
            filetxt.Text = str
        End If
    End Sub

    Private Sub statuslb_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles statuslb.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = e.Data.GetData(DataFormats.FileDrop)
            str = filestr(0)
            filetxt.Text = str
        End If
    End Sub

    Private Sub statuslb_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles statuslb.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub DateiEntschluesseln_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = e.Data.GetData(DataFormats.FileDrop)
            str = filestr(0)
            filetxt.Text = str
        End If
    End Sub

    Private Sub DateiEntschluesseln_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub filetxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filetxt.TextChanged
        If My.Computer.FileSystem.FileExists(filetxt.Text) Then
            pathtxt.Enabled = True
            savefile.Enabled = True
        Else

        End If
    End Sub

    Private Sub openfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openfile.Click
        OpenFileDialog.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog.FileName) Then
            filetxt.Text = OpenFileDialog.FileName
            pathtxt.Enabled = True
            savefile.Enabled = True
        Else

        End If
    End Sub

    Private Sub DateiEntschluesseln_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class