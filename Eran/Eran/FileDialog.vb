Imports System.IO
Public Class FileDialog_
    Friend Shared Path As String = My.Computer.FileSystem.SpecialDirectories.Desktop
    Friend Shared FilePath As String
    Friend Shared History As New List(Of String)
    Friend Shared FileSelected As Boolean = False
    Private Sub FileDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadFiles(Path)
    End Sub

    Private Function LoadFiles(ByVal Path_ As String)
        Path = Path_
        path_txt.Text = Path_
        History.Add(Path)
        ListView1.Items.Clear()
        ListView1.Items.Add("[..]", 12)
        For Each folders In Directory.GetDirectories(Path, "*.*", SearchOption.TopDirectoryOnly)
            Dim dirInfo As New DirectoryInfo(folders)
            With ListView1.Items.Add(dirInfo.Name, 1)
                .SubItems.Add("")
                .SubItems.Add("")
                .SubItems.Add(dirInfo.CreationTime)
            End With
        Next
        For Each files In Directory.GetFiles(Path, "*.*", SearchOption.TopDirectoryOnly)
            Dim fileInfo_ As New FileInfo(files)
            Select Case fileInfo_.Extension.ToLower
                Case ".mp3", ".ogg", ".wav"
                    With ListView1.Items.Add(fileInfo_.Name, 3)
                        .SubItems.Add(fileInfo_.Extension)
                        .SubItems.Add(fileInfo_.Length)
                        .SubItems.Add(fileInfo_.CreationTime)
                    End With
                Case ".wmv", ".mp4", ".avi", ".flv", ".mov"
                    With ListView1.Items.Add(fileInfo_.Name, 5)
                        .SubItems.Add(fileInfo_.Extension)
                        .SubItems.Add(fileInfo_.Length)
                        .SubItems.Add(fileInfo_.CreationTime)
                    End With
                Case ".ini"
                    With ListView1.Items.Add(fileInfo_.Name, 7)
                        .SubItems.Add(fileInfo_.Extension)
                        .SubItems.Add(fileInfo_.Length)
                        .SubItems.Add(fileInfo_.CreationTime)
                    End With
                Case ".exe"
                    With ListView1.Items.Add(fileInfo_.Name, 10)
                        .SubItems.Add(fileInfo_.Extension)
                        .SubItems.Add(fileInfo_.Length)
                        .SubItems.Add(fileInfo_.CreationTime)
                    End With
                Case ".png", ".jpg", ".jpeg", ".gif", ".bmp", ".ico"
                    With ListView1.Items.Add(fileInfo_.Name, 2)
                        .SubItems.Add(fileInfo_.Extension)
                        .SubItems.Add(fileInfo_.Length)
                        .SubItems.Add(fileInfo_.CreationTime)
                    End With
                Case ".zip", ".7zip", ".rar", ".iso", ".tar", ".gz"
                    With ListView1.Items.Add(fileInfo_.Name, 11)
                        .SubItems.Add(fileInfo_.Extension)
                        .SubItems.Add(fileInfo_.Length)
                        .SubItems.Add(fileInfo_.CreationTime)
                    End With
                Case Else

                    With ListView1.Items.Add(fileInfo_.Name, 9)
                        .SubItems.Add(fileInfo_.Extension)
                        .SubItems.Add(fileInfo_.Length)
                        .SubItems.Add(fileInfo_.CreationTime)
                    End With
            End Select

        Next
    End Function
    Private Sub open_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_bt.Click
        If File.Exists(FilePath) Then
            FileSelected = True
        Else
            FileSelected = False
        End If
        Me.Close()
    End Sub

    Private Sub cancel_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_bt.Click
        FileSelected = False
        Me.Close()
    End Sub

    Private Sub ListView1_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Try
            Dim selectedIndex As Integer = ListView1.SelectedIndices(0)
            If ListView1.Items(selectedIndex).ImageIndex = 1 Then
                Dim path_ As String = Path & OS.OS_slash & ListView1.Items(selectedIndex).Text
                LoadFiles(path_)
                path_txt.Text = Path
            Else
                If selectedIndex = 0 Then
                    LoadFiles(Path.Substring(0, Path.LastIndexOf(OS.OS_slash)))
                Else
                    filename_txt.Text = ListView1.Items(selectedIndex).Text
                    FilePath = Path & OS.OS_slash & ListView1.Items(selectedIndex).Text
                    FileSelected = True
                    Me.Close()
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListView1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            Try
                Dim selectedIndex As Integer = ListView1.SelectedIndices(0)
                If ListView1.Items(selectedIndex).ImageIndex = 1 Then
                    Dim path_ As String = Path & OS.OS_slash & ListView1.Items(selectedIndex).Text
                    LoadFiles(path_)
                    path_txt.Text = Path
                Else
                    If selectedIndex = 0 Then
                        LoadFiles(Path.Substring(0, Path.LastIndexOf(OS.OS_slash)))
                    Else
                        filename_txt.Text = ListView1.Items(selectedIndex).Text
                        FilePath = Path & OS.OS_slash & ListView1.Items(selectedIndex).Text
                        FileSelected = True
                        Me.Close()
                    End If

                End If
            Catch ex As Exception
            End Try
        End If
        If e.KeyData = Keys.Back Then
            LoadFiles(Path.Substring(0, Path.LastIndexOf(OS.OS_slash)))
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        path_txt.Text = Path
        Try
            Dim selectedIndex As Integer = ListView1.SelectedIndices(0)
            If ListView1.Items(selectedIndex).ImageIndex = 1 Then
                filename_txt.Text = Nothing
                SplitContainer1.SplitterDistance = SplitContainer1.Size.Width - 2
            Else
                If selectedIndex = 0 Then
                Else
                    FilePath = Path & OS.OS_slash & ListView1.Items(selectedIndex).Text
                    If ListView1.Items(selectedIndex).ImageIndex = 2 Then
                        SplitContainer1.SplitterDistance = SplitContainer1.Size.Width - 250
                        PictureBox1.ImageLocation = FilePath
                        
                    Else
                        SplitContainer1.SplitterDistance = SplitContainer1.Size.Width - 2
                    End If
                    filename_txt.Text = ListView1.Items(selectedIndex).Text

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FileDialog__Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        SplitContainer1.SplitterDistance = SplitContainer1.Size.Width - 2
    End Sub

    Private Sub PictureBox1_LoadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles PictureBox1.LoadCompleted
        If PictureBox1.Image.Size.Width > PictureBox1.Size.Width Then
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        End If
        If PictureBox1.Image.Size.Height > PictureBox1.Size.Height Then
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        End If
    End Sub

    Private Sub PictureBox1_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.LocationChanged

        
    End Sub
End Class