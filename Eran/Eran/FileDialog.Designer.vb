<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileDialog_
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileDialog_))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.filename_lb = New System.Windows.Forms.Label()
        Me.filename_txt = New System.Windows.Forms.TextBox()
        Me.open_bt = New System.Windows.Forms.Button()
        Me.cancel_bt = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.path_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.file_view = New System.Windows.Forms.ListView()
        Me.name_column = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.type_column = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.size_column = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.creat_time_column = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.Controls.Add(Me.filename_lb)
        Me.Panel1.Controls.Add(Me.filename_txt)
        Me.Panel1.Controls.Add(Me.open_bt)
        Me.Panel1.Controls.Add(Me.cancel_bt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 319)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(641, 78)
        Me.Panel1.TabIndex = 0
        '
        'filename_lb
        '
        Me.filename_lb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.filename_lb.AutoSize = True
        Me.filename_lb.ForeColor = System.Drawing.Color.White
        Me.filename_lb.Location = New System.Drawing.Point(32, 19)
        Me.filename_lb.Name = "filename_lb"
        Me.filename_lb.Size = New System.Drawing.Size(52, 13)
        Me.filename_lb.TabIndex = 7
        Me.filename_lb.Text = "Filename:"
        '
        'filename_txt
        '
        Me.filename_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filename_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.filename_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.filename_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.filename_txt.Location = New System.Drawing.Point(90, 17)
        Me.filename_txt.Name = "filename_txt"
        Me.filename_txt.ReadOnly = True
        Me.filename_txt.Size = New System.Drawing.Size(381, 20)
        Me.filename_txt.TabIndex = 6
        '
        'open_bt
        '
        Me.open_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.open_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.open_bt.FlatAppearance.BorderSize = 0
        Me.open_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.open_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.open_bt.Location = New System.Drawing.Point(473, 43)
        Me.open_bt.Name = "open_bt"
        Me.open_bt.Size = New System.Drawing.Size(75, 23)
        Me.open_bt.TabIndex = 5
        Me.open_bt.Text = "Open"
        Me.open_bt.UseVisualStyleBackColor = False
        '
        'cancel_bt
        '
        Me.cancel_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancel_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cancel_bt.FlatAppearance.BorderSize = 0
        Me.cancel_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cancel_bt.Location = New System.Drawing.Point(554, 43)
        Me.cancel_bt.Name = "cancel_bt"
        Me.cancel_bt.Size = New System.Drawing.Size(75, 23)
        Me.cancel_bt.TabIndex = 4
        Me.cancel_bt.Text = "Cancel"
        Me.cancel_bt.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "drive.ico")
        Me.ImageList1.Images.SetKeyName(1, "folder.ico")
        Me.ImageList1.Images.SetKeyName(2, "imgfile.ico")
        Me.ImageList1.Images.SetKeyName(3, "musicfile.ico")
        Me.ImageList1.Images.SetKeyName(4, "txtfile.ico")
        Me.ImageList1.Images.SetKeyName(5, "videofile.ico")
        Me.ImageList1.Images.SetKeyName(6, "dllfile.ico")
        Me.ImageList1.Images.SetKeyName(7, "inifile.ico")
        Me.ImageList1.Images.SetKeyName(8, "rtffile.ico")
        Me.ImageList1.Images.SetKeyName(9, "file.ico")
        Me.ImageList1.Images.SetKeyName(10, "exefile.ico")
        Me.ImageList1.Images.SetKeyName(11, "zipfile.ico")
        Me.ImageList1.Images.SetKeyName(12, "back.ico")
        '
        'path_txt
        '
        Me.path_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.path_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.path_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.path_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.path_txt.Location = New System.Drawing.Point(90, 12)
        Me.path_txt.Name = "path_txt"
        Me.path_txt.ReadOnly = True
        Me.path_txt.Size = New System.Drawing.Size(381, 20)
        Me.path_txt.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(52, -51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Path:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 44)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.file_view)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel2MinSize = 0
        Me.SplitContainer1.Size = New System.Drawing.Size(641, 275)
        Me.SplitContainer1.SplitterDistance = 612
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 9
        '
        'file_view
        '
        Me.file_view.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.file_view.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.name_column, Me.type_column, Me.size_column, Me.creat_time_column})
        Me.file_view.Dock = System.Windows.Forms.DockStyle.Fill
        Me.file_view.ForeColor = System.Drawing.Color.White
        Me.file_view.FullRowSelect = True
        Me.file_view.LargeImageList = Me.ImageList1
        Me.file_view.Location = New System.Drawing.Point(0, 0)
        Me.file_view.MultiSelect = False
        Me.file_view.Name = "file_view"
        Me.file_view.Size = New System.Drawing.Size(612, 275)
        Me.file_view.SmallImageList = Me.ImageList1
        Me.file_view.TabIndex = 2
        Me.file_view.UseCompatibleStateImageBehavior = False
        Me.file_view.View = System.Windows.Forms.View.Details
        '
        'name_column
        '
        Me.name_column.Text = "Name"
        Me.name_column.Width = 325
        '
        'type_column
        '
        Me.type_column.Text = "Type"
        Me.type_column.Width = 69
        '
        'size_column
        '
        Me.size_column.Text = "Size"
        Me.size_column.Width = 108
        '
        'creat_time_column
        '
        Me.creat_time_column.Text = "Creation Time"
        Me.creat_time_column.Width = 132
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-88, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 109)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FileDialog_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(641, 397)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.path_txt)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FileDialog_"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Dialog"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents open_bt As System.Windows.Forms.Button
    Friend WithEvents cancel_bt As System.Windows.Forms.Button
    Friend WithEvents filename_txt As System.Windows.Forms.TextBox
    Friend WithEvents filename_lb As System.Windows.Forms.Label
    Friend WithEvents path_txt As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents file_view As System.Windows.Forms.ListView
    Friend WithEvents name_column As System.Windows.Forms.ColumnHeader
    Friend WithEvents type_column As System.Windows.Forms.ColumnHeader
    Friend WithEvents size_column As System.Windows.Forms.ColumnHeader
    Friend WithEvents creat_time_column As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
