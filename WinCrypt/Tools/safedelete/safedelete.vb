Option Strict On
Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports System.Threading
Imports Project_WinCrypt.classes

Namespace tools.safedelete
    Public Class safedelete
        ReadOnly _erasefile As New SafedeleteFunction
        Private _delThreadThreading As Thread
        ReadOnly _errorreport As New StringBuilder
        Declare Auto Function SendMessage Lib "user32.dll" (hWnd As IntPtr, msg As Integer, wParam As Integer,
                                                    lParam As Integer) As Integer
        Enum ProgressBarColor
            Green = &H1
            Red = &H2
            Yellow = &H3
        End Enum
        Private Shared Sub ChangeProgBarColor(progressBarName As ProgressBar, progressBarColor As ProgressBarColor)
            SendMessage(progressBarName.Handle, &H410, progressBarColor, 0)
        End Sub
        Private Sub safedelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim loadcolor As New designcolor
            loadcolor.color()
            CheckForIllegalCrossThreadCalls = False
            ChangeProgBarColor(overwrite_pb, ProgressBarColor.Red)
        End Sub
        Private Sub selectpathbt_Click(sender As Object, e As EventArgs) Handles selectpathbt.Click
            FolderBrowserDialog.ShowDialog()
            file_txt.Text = FolderBrowserDialog.SelectedPath
            If Directory.Exists(FolderBrowserDialog.SelectedPath) Then
                Dim di As New DirectoryInfo(file_txt.Text)
                For Each fi As FileInfo In di.GetFiles("*.*", SearchOption.AllDirectories)
                    deletfilelist.Items.Add(fi.FullName)
                Next
                SucheAlleOrdner(file_txt.Text)
                deletfilelist.Items.Add(FolderBrowserDialog.SelectedPath)
            Else
            End If
        End Sub
        Private Sub SucheAlleOrdner(pfad As String)
            Dim alleOrdner() As String
            alleOrdner = Directory.GetDirectories(pfad)
            For i = 0 To alleOrdner.Length - 1
                If alleOrdner(i) <> pfad Then
                    deletfilelist.Items.Add(alleOrdner(i))
                    Call SucheAlleOrdner(alleOrdner(i))
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
                add_file_dialog.FileName = Nothing
            Else
            End If
        End Sub
        Private Sub deletefilelist_DragDrop(sender As Object, e As DragEventArgs) Handles deletfilelist.DragDrop
            Dim filestr() As String
            Dim str As String
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
                str = filestr(0)
                If File.Exists(str) Then
                    deletfilelist.Items.Add(str)
                Else
                    If Directory.Exists(str) Then
                        If Directory.Exists(str) Then
                            Dim di As New DirectoryInfo(str)
                            For Each fi As FileInfo In di.GetFiles("*.*", SearchOption.AllDirectories)
                                deletfilelist.Items.Add(fi.FullName)
                            Next
                            SucheAlleOrdner(str)
                            deletfilelist.Items.Add(str)
                        Else
                        End If
                    End If
                End If
            End If
        End Sub
        Private Sub removeentrybt_Click(sender As Object, e As EventArgs) Handles removeentrybt.Click
            deletfilelist.Items.Remove(deletfilelist.SelectedItem)
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
        Private Sub form_head_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
            If (e.Button = MouseButtons.Left) Then
                form_head.Capture = False
                WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
            Else
            End If
        End Sub
        Private Sub deletebt_Click(sender As Object, e As EventArgs) Handles deletebt.Click
            loadBall.Enabled = True
            _delThreadThreading = New Thread(AddressOf DelThreas)
            _delThreadThreading.Start()
            deletebt.Visible = False
            abort_bt.Visible = True
        End Sub
        Sub DelThreas()
            If MessageBox.Show("Möchten Sie wirklich alle Daten unwiederruflich löschen?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
                deletfilelist.SelectedIndex = 0
                file_txt.Enabled = False
                selectpathbt.Enabled = False
                fileaddbt.Enabled = False
                overwritecb.Enabled = False
                deletfilelist.Enabled = False
                For list_i = 0 To deletfilelist.Items.Count - 1
                    progressstatus.Maximum = deletfilelist.Items.Count
                    overwrite_pb.Maximum = CInt(overwritecb.Text.Replace("x", Nothing))
                    Try
                        deletfilelist.SelectedIndex = list_i
                    Catch ex As Exception

                    End Try

                    If Directory.Exists(CStr(deletfilelist.SelectedItem)) Then
                        Try
                            Directory.Delete(CStr(deletfilelist.SelectedItem), True)
                        Catch ex As Exception
                            _errorreport.Append(ErrorToString)
                            _errorreport.AppendLine()
                            _errorreport.AppendLine()
                        End Try
                    Else
                        For i = 0 To CInt(overwritecb.Text.Replace("x", Nothing))
                            _erasefile.SafeEraser(CStr(deletfilelist.SelectedItem), 1, False)
                            overwrite_pb.Value = i
                        Next
                    End If
                    progressstatus.Value = list_i
                    Try
                        File.Delete(CStr(deletfilelist.SelectedItem))
                    Catch ex As Exception
                        _errorreport.Append(ErrorToString)
                        _errorreport.AppendLine()
                        _errorreport.AppendLine()
                    End Try
                Next
                loadBall.Enabled = False
                loadBall.Image = My.Resources.Ballload
                MessageBox.Show("Alle Daten wurden unwiederruflich gelöscht!", "Gelöscht", MessageBoxButtons.OK, MessageBoxIcon.Information)
                file_txt.Enabled = True
                selectpathbt.Enabled = True
                fileaddbt.Enabled = True
                overwritecb.Enabled = True
                deletfilelist.Enabled = True
                report_bt.Enabled = True
                deletfilelist.Items.Clear()
            Else
                loadBall.Enabled = False
                loadBall.Image = My.Resources.Ballload
                deletebt.Visible = True
                abort_bt.Visible = False
                _delThreadThreading.Abort()
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
            _delThreadThreading.Abort()
        End Sub
        Private Sub report_bt_Click(sender As Object, e As EventArgs) Handles report_bt.Click
            tools.safedelete.del_report.report_txt.Text = _errorreport.ToString
            tools.safedelete.del_report.Show()
        End Sub
        Private Sub cleanlb1_Click(sender As Object, e As EventArgs) Handles cleanlb1.Click
            deletfilelist.Items.Clear()
        End Sub
        Private Sub report_bt_EnabledChanged(sender As Object, e As EventArgs) Handles report_bt.EnabledChanged
            If report_bt.Enabled = True Then
                deletebt.Visible = True
                abort_bt.Visible = False
                progressstatus.Value = 0
                overwrite_pb.Value = 0
            End If
        End Sub
        Private Sub safedelete_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
            If Startwindow.vCommand = True Then
                Startwindow.Close()
            End If
        End Sub
    End Class
End Namespace