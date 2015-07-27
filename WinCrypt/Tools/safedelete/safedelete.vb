Imports System.IO
Imports System.Text

Public Class safedelete
    Dim erasefile As New safedelete_function
    Dim delThread_Threading As System.Threading.Thread
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Enum ProgressBarColor
        Green = &H1
        Red = &H2
        Yellow = &H3
    End Enum
    Private Shared Sub ChangeProgBarColor(ByVal ProgressBar_Name As Windows.Forms.ProgressBar, ByVal ProgressBar_Color As ProgressBarColor)
        SendMessage(ProgressBar_Name.Handle, &H410, ProgressBar_Color, 0)
    End Sub
    Private Sub safedelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        ChangeProgBarColor(override_pb, ProgressBarColor.Red)
    End Sub
    Private Function UnicodeStringToBytes(ByVal str As String) As Byte()
        Return System.Text.Encoding.Unicode.GetBytes(str)
    End Function
    Private Sub selectpathbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectpathbt.Click
        FolderBrowserDialog.ShowDialog()
        file_txt.Text = FolderBrowserDialog.SelectedPath
        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog.SelectedPath) Then
            Dim di As New System.IO.DirectoryInfo(file_txt.Text)
            For Each fi As System.IO.FileInfo In di.GetFiles("*.*", System.IO.SearchOption.AllDirectories)
                deletfilelist.Items.Add(fi.FullName)
            Next
            SucheAlleOrdner(file_txt.Text)
            deletfilelist.Items.Add(FolderBrowserDialog.SelectedPath)
        Else : End If
    End Sub
    Private Sub SucheAlleOrdner(ByVal Pfad As String)
        Dim AlleOrdner() As String
        AlleOrdner = Directory.GetDirectories(Pfad)
        For i As Integer = 0 To AlleOrdner.Length - 1
            If AlleOrdner(i) <> Pfad Then
                deletfilelist.Items.Add(AlleOrdner(i))
                Call SucheAlleOrdner(AlleOrdner(i))
            End If
        Next i
    End Sub
    Private Sub deletefilelist_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles deletfilelist.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub bgwrk_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwrk.RunWorkerCompleted

    End Sub

    Private Sub fileaddbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fileaddbt.Click
        OpenFileDialog.ShowDialog()
        If OpenFileDialog.FileName.Length > 0 Then
            deletfilelist.Items.Add(OpenFileDialog.FileName)
            OpenFileDialog.FileName = ""
        Else : End If
    End Sub

    Private Sub deletefilelist_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles deletfilelist.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
            str = filestr(0)
            If My.Computer.FileSystem.FileExists(str) Then
                deletfilelist.Items.Add(str)
            Else
                If My.Computer.FileSystem.DirectoryExists(str) Then
                    If My.Computer.FileSystem.DirectoryExists(str) Then
                        Dim di As New System.IO.DirectoryInfo(str)
                        For Each fi As System.IO.FileInfo In di.GetFiles("*.*", System.IO.SearchOption.AllDirectories)
                            deletfilelist.Items.Add(fi.FullName)
                        Next
                        SucheAlleOrdner(str)
                        deletfilelist.Items.Add(str)
                    Else : End If
                End If
            End If
        End If
    End Sub

    Private Sub removeentrybt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeentrybt.Click
        deletfilelist.Items.Remove(deletfilelist.SelectedItem)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Me.Close()
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

    Private Sub deletebt_Click(sender As Object, e As EventArgs) Handles deletebt.Click
        deletebt.Visible = False
        abort_bt.Visible = True

        delThread_Threading = New System.Threading.Thread(AddressOf delThreas)
        delThread_Threading.Start()
        
    End Sub
    Sub delThreas()
        If MsgBox("Möchten Sie wirklich alle Daten unwiederruflich löschen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            deletfilelist.SelectedIndex = 0
            For list_i As Integer = 0 To deletfilelist.Items.Count - 1
                progressstatus.Maximum = deletfilelist.Items.Count
                override_pb.Maximum = overwritecb.Text.Replace("x", "")
                Try
                    deletfilelist.SelectedIndex = list_i
                Catch ex As Exception

                End Try
                If My.Computer.FileSystem.DirectoryExists(deletfilelist.SelectedItem) Then
                    Try
                        Directory.Delete(deletfilelist.SelectedItem, True)
                    Catch ex As Exception
                        'Add ReportList
                    End Try

                Else

                    For i As Integer = 0 To overwritecb.Text.Replace("x", "")

                        erasefile.SafeEraser(deletfilelist.SelectedItem, 1, False)
                        override_pb.Value = i

                    Next
                End If
                progressstatus.Value = list_i

                Try
                    File.Delete(deletfilelist.SelectedItem)
                Catch ex As Exception

                End Try
            Next
            MsgBox("Alle Daten wurden unwiederruflich gelöscht!", MsgBoxStyle.Information)
            progressstatus.Value = 0
            override_pb.Value = 0
            deletfilelist.Items.Clear()
        Else

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles abort_bt.Click
        deletebt.Visible = True
        abort_bt.Visible = False
        deletfilelist.Items.Clear()
        progressstatus.Value = 0
        override_pb.Value = 0
        delThread_Threading.Abort()
    End Sub
End Class