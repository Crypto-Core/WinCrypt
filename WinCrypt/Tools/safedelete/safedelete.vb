Option Strict On

Imports System.IO
Imports System.Text
Imports System.Threading

Public Class safedelete
    Dim ReadOnly erasefile As New safedelete_function
    Dim delThread_Threading As Thread
    Dim ReadOnly errorreport As New StringBuilder
    Declare Auto Function SendMessage Lib "user32.dll"(hWnd As IntPtr, msg As Integer, wParam As Integer,
                                                       lParam As Integer) As Integer

    Enum ProgressBarColor
        Green = &H1
        Red = &H2
        Yellow = &H3
    End Enum

    Private Shared Sub ChangeProgBarColor(ProgressBar_Name As ProgressBar, ProgressBar_Color As ProgressBarColor)
        SendMessage(ProgressBar_Name.Handle, &H410, ProgressBar_Color, 0)
    End Sub

    Private Sub safedelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ChangeProgBarColor(overwrite_pb, ProgressBarColor.Red)
    End Sub

    Private Function UnicodeStringToBytes(str As String) As Byte()
        Return Encoding.Unicode.GetBytes(str)
    End Function

    Private Sub selectpathbt_Click(sender As Object, e As EventArgs) Handles selectpathbt.Click
        FolderBrowserDialog.ShowDialog()
        file_txt.Text = FolderBrowserDialog.SelectedPath
        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog.SelectedPath) Then
            Dim di As New DirectoryInfo(file_txt.Text)
            For Each fi As FileInfo In di.GetFiles("*.*", SearchOption.AllDirectories)
                deletfilelist.Items.Add(fi.FullName)
            Next
            SucheAlleOrdner(file_txt.Text)
            deletfilelist.Items.Add(FolderBrowserDialog.SelectedPath)
        Else :
        End If
    End Sub

    Private Sub SucheAlleOrdner(Pfad As String)
        Dim AlleOrdner() As String
        AlleOrdner = Directory.GetDirectories(Pfad)
        For i = 0 To AlleOrdner.Length - 1
            If AlleOrdner(i) <> Pfad Then
                deletfilelist.Items.Add(AlleOrdner(i))
                Call SucheAlleOrdner(AlleOrdner(i))
            End If
        Next i
    End Sub

    Private Sub deletefilelist_DragEnter(sender As Object, e As DragEventArgs) Handles deletfilelist.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub fileaddbt_Click(sender As Object, e As EventArgs) Handles fileaddbt.Click
        add_file_dialog.ShowDialog()
        If add_file_dialog.FileName.Length > 0 Then
            deletfilelist.Items.Add(add_file_dialog.FileName)
            add_file_dialog.FileName = ""
        Else :
        End If
    End Sub

    Private Sub deletefilelist_DragDrop(sender As Object, e As DragEventArgs) Handles deletfilelist.DragDrop
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
                        Dim di As New DirectoryInfo(str)
                        For Each fi As FileInfo In di.GetFiles("*.*", SearchOption.AllDirectories)
                            deletfilelist.Items.Add(fi.FullName)
                        Next
                        SucheAlleOrdner(str)
                        deletfilelist.Items.Add(str)
                    Else :
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub removeentrybt_Click(sender As Object, e As EventArgs) Handles removeentrybt.Click
        deletfilelist.Items.Remove(deletfilelist.SelectedItem)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Me.Close()
    End Sub

    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = MouseButtons.Left) Then
            wincrypttitle.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else :
        End If
    End Sub

    Private Sub form_head_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = MouseButtons.Left) Then
            form_head.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else :
        End If
    End Sub

    Private Sub deletebt_Click(sender As Object, e As EventArgs) Handles deletebt.Click
        delThread_Threading = New Thread(AddressOf delThreas)
        delThread_Threading.Start()
        deletebt.Visible = False
        abort_bt.Visible = True
    End Sub

    Sub delThreas()
        If MsgBox("Möchten Sie wirklich alle Daten unwiederruflich löschen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            deletfilelist.SelectedIndex = 0
            file_txt.Enabled = False
            selectpathbt.Enabled = False
            fileaddbt.Enabled = False
            overwritecb.Enabled = False
            deletfilelist.Enabled = False
            For list_i = 0 To deletfilelist.Items.Count - 1
                progressstatus.Maximum = deletfilelist.Items.Count
                overwrite_pb.Maximum = CInt(overwritecb.Text.Replace("x", ""))
                Try
                    deletfilelist.SelectedIndex = list_i
                Catch ex As Exception

                End Try
                If My.Computer.FileSystem.DirectoryExists(CStr(deletfilelist.SelectedItem)) Then
                    Try
                        Directory.Delete(CStr(deletfilelist.SelectedItem), True)
                    Catch ex As Exception
                        errorreport.Append(ErrorToString)
                        errorreport.AppendLine()
                        errorreport.AppendLine()
                    End Try

                Else

                    For i = 0 To CInt(overwritecb.Text.Replace("x", ""))
                        erasefile.SafeEraser(CStr(deletfilelist.SelectedItem), 1, False)
                        overwrite_pb.Value = i
                    Next
                End If
                progressstatus.Value = list_i
                Try
                    File.Delete(CStr(deletfilelist.SelectedItem))
                Catch ex As Exception
                    errorreport.Append(ErrorToString)
                    errorreport.AppendLine()
                    errorreport.AppendLine()
                End Try
            Next
            MsgBox("Alle Daten wurden unwiederruflich gelöscht!", MsgBoxStyle.Information)
            file_txt.Enabled = True
            selectpathbt.Enabled = True
            fileaddbt.Enabled = True
            overwritecb.Enabled = True
            deletfilelist.Enabled = True
            report_bt.Enabled = True
            deletfilelist.Items.Clear()
        Else
            deletebt.Visible = True
            abort_bt.Visible = False
            delThread_Threading.Abort()
        End If
    End Sub

    Private Sub abort_bt_Click(sender As Object, e As EventArgs) Handles abort_bt.Click
        file_txt.Enabled = True
        selectpathbt.Enabled = True
        fileaddbt.Enabled = True
        overwritecb.Enabled = True
        deletfilelist.Enabled = True
        report_bt.Enabled = True
        deletebt.Visible = True
        abort_bt.Visible = False
        deletfilelist.Items.Clear()
        progressstatus.Value = 0
        overwrite_pb.Value = 0
        delThread_Threading.Abort()
    End Sub

    Private Sub report_bt_Click(sender As Object, e As EventArgs) Handles report_bt.Click
        del_report.report_txt.Text = errorreport.ToString
        del_report.Show()
    End Sub

    Private Sub cleanlb1_Click(sender As Object, e As EventArgs) Handles cleanlb1.Click
        deletfilelist.Items.Clear()
    End Sub

    Private Sub report_bt_EnabledChanged(sender As Object, e As EventArgs) Handles report_bt.EnabledChanged
        If report_bt.Enabled = True Then
            abort_bt.Visible = False
            deletebt.Visible = True
            progressstatus.Value = 0
            overwrite_pb.Value = 0
        End If
    End Sub
End Class