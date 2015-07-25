<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class safedelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(safedelete))
        Me.deletebt = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.overwritecb = New System.Windows.Forms.ComboBox()
        Me.overwritelb = New System.Windows.Forms.Label()
        Me.generatebytelb = New System.Windows.Forms.Label()
        Me.progressstatus = New System.Windows.Forms.ProgressBar()
        Me.selectpathbt = New System.Windows.Forms.Button()
        Me.filelb = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.bgwrk = New System.ComponentModel.BackgroundWorker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.deletfilelist = New System.Windows.Forms.ListBox()
        Me.statuslb = New System.Windows.Forms.Label()
        Me.fileaddbt = New System.Windows.Forms.Button()
        Me.dragdroplb = New System.Windows.Forms.Label()
        Me.removeentrybt = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deletebt
        '
        Me.deletebt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.deletebt.FlatAppearance.BorderSize = 0
        Me.deletebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deletebt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.deletebt.Location = New System.Drawing.Point(345, 157)
        Me.deletebt.Name = "deletebt"
        Me.deletebt.Size = New System.Drawing.Size(75, 23)
        Me.deletebt.TabIndex = 0
        Me.deletebt.Text = "Löschen"
        Me.deletebt.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(12, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(327, 20)
        Me.TextBox1.TabIndex = 1
        '
        'overwritecb
        '
        Me.overwritecb.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.overwritecb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.overwritecb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.overwritecb.FormattingEnabled = True
        Me.overwritecb.Items.AddRange(New Object() {"1x", "10x", "20x", "100x"})
        Me.overwritecb.Location = New System.Drawing.Point(89, 81)
        Me.overwritecb.Name = "overwritecb"
        Me.overwritecb.Size = New System.Drawing.Size(55, 21)
        Me.overwritecb.TabIndex = 2
        Me.overwritecb.Text = "10x"
        '
        'overwritelb
        '
        Me.overwritelb.AutoSize = True
        Me.overwritelb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.overwritelb.Location = New System.Drawing.Point(9, 84)
        Me.overwritelb.Name = "overwritelb"
        Me.overwritelb.Size = New System.Drawing.Size(79, 13)
        Me.overwritelb.TabIndex = 3
        Me.overwritelb.Text = "Überschreiben:"
        '
        'generatebytelb
        '
        Me.generatebytelb.AutoSize = True
        Me.generatebytelb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.generatebytelb.Location = New System.Drawing.Point(9, 112)
        Me.generatebytelb.Name = "generatebytelb"
        Me.generatebytelb.Size = New System.Drawing.Size(87, 13)
        Me.generatebytelb.TabIndex = 4
        Me.generatebytelb.Text = "Generierte bytes:"
        '
        'progressstatus
        '
        Me.progressstatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.progressstatus.Location = New System.Drawing.Point(12, 128)
        Me.progressstatus.Name = "progressstatus"
        Me.progressstatus.Size = New System.Drawing.Size(408, 23)
        Me.progressstatus.TabIndex = 5
        '
        'selectpathbt
        '
        Me.selectpathbt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.selectpathbt.FlatAppearance.BorderSize = 0
        Me.selectpathbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectpathbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.selectpathbt.Location = New System.Drawing.Point(345, 53)
        Me.selectpathbt.Name = "selectpathbt"
        Me.selectpathbt.Size = New System.Drawing.Size(75, 23)
        Me.selectpathbt.TabIndex = 6
        Me.selectpathbt.Text = "Auswählen"
        Me.selectpathbt.UseVisualStyleBackColor = False
        '
        'filelb
        '
        Me.filelb.AutoSize = True
        Me.filelb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.filelb.Location = New System.Drawing.Point(9, 39)
        Me.filelb.Name = "filelb"
        Me.filelb.Size = New System.Drawing.Size(42, 13)
        Me.filelb.TabIndex = 7
        Me.filelb.Text = "Ordner:"
        '
        'bgwrk
        '
        Me.bgwrk.WorkerReportsProgress = True
        Me.bgwrk.WorkerSupportsCancellation = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(12, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 9
        '
        'deletfilelist
        '
        Me.deletfilelist.AllowDrop = True
        Me.deletfilelist.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.deletfilelist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.deletfilelist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.deletfilelist.FormattingEnabled = True
        Me.deletfilelist.Location = New System.Drawing.Point(15, 198)
        Me.deletfilelist.Name = "deletfilelist"
        Me.deletfilelist.Size = New System.Drawing.Size(405, 210)
        Me.deletfilelist.TabIndex = 10
        '
        'statuslb
        '
        Me.statuslb.AutoSize = True
        Me.statuslb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.statuslb.Location = New System.Drawing.Point(9, 182)
        Me.statuslb.Name = "statuslb"
        Me.statuslb.Size = New System.Drawing.Size(40, 13)
        Me.statuslb.TabIndex = 12
        Me.statuslb.Text = "Status:"
        '
        'fileaddbt
        '
        Me.fileaddbt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fileaddbt.FlatAppearance.BorderSize = 0
        Me.fileaddbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fileaddbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.fileaddbt.Location = New System.Drawing.Point(303, 79)
        Me.fileaddbt.Name = "fileaddbt"
        Me.fileaddbt.Size = New System.Drawing.Size(117, 23)
        Me.fileaddbt.TabIndex = 13
        Me.fileaddbt.Text = "Datei hinzufügen"
        Me.fileaddbt.UseVisualStyleBackColor = False
        '
        'dragdroplb
        '
        Me.dragdroplb.AutoSize = True
        Me.dragdroplb.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dragdroplb.ForeColor = System.Drawing.Color.DarkGray
        Me.dragdroplb.Location = New System.Drawing.Point(12, 421)
        Me.dragdroplb.Name = "dragdroplb"
        Me.dragdroplb.Size = New System.Drawing.Size(53, 13)
        Me.dragdroplb.TabIndex = 14
        Me.dragdroplb.Text = "Drag&Drop"
        '
        'removeentrybt
        '
        Me.removeentrybt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.removeentrybt.FlatAppearance.BorderSize = 0
        Me.removeentrybt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.removeentrybt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.removeentrybt.Location = New System.Drawing.Point(317, 411)
        Me.removeentrybt.Name = "removeentrybt"
        Me.removeentrybt.Size = New System.Drawing.Size(103, 23)
        Me.removeentrybt.TabIndex = 15
        Me.removeentrybt.Text = "Eintrag entfernen"
        Me.removeentrybt.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(432, 27)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "WinCrypt"
        '
        'XToolStripMenuItem
        '
        Me.XToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.XToolStripMenuItem.Name = "XToolStripMenuItem"
        Me.XToolStripMenuItem.Size = New System.Drawing.Size(29, 23)
        Me.XToolStripMenuItem.Text = "X"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(32, 23)
        Me.ToolStripMenuItem1.Text = "─"
        '
        'wincrypttitle
        '
        Me.wincrypttitle.AutoSize = True
        Me.wincrypttitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.wincrypttitle.Location = New System.Drawing.Point(34, 6)
        Me.wincrypttitle.Name = "wincrypttitle"
        Me.wincrypttitle.Size = New System.Drawing.Size(144, 16)
        Me.wincrypttitle.TabIndex = 17
        Me.wincrypttitle.Text = "Dateien sicher löschen"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_WinCrypt.My.Resources.Resources.icon
        Me.PictureBox1.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'safedelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(432, 442)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.removeentrybt)
        Me.Controls.Add(Me.dragdroplb)
        Me.Controls.Add(Me.fileaddbt)
        Me.Controls.Add(Me.statuslb)
        Me.Controls.Add(Me.deletfilelist)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.filelb)
        Me.Controls.Add(Me.selectpathbt)
        Me.Controls.Add(Me.progressstatus)
        Me.Controls.Add(Me.generatebytelb)
        Me.Controls.Add(Me.overwritelb)
        Me.Controls.Add(Me.overwritecb)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.deletebt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "safedelete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sicher löschen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deletebt As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents overwritecb As System.Windows.Forms.ComboBox
    Friend WithEvents overwritelb As System.Windows.Forms.Label
    Friend WithEvents generatebytelb As System.Windows.Forms.Label
    Friend WithEvents progressstatus As System.Windows.Forms.ProgressBar
    Friend WithEvents selectpathbt As System.Windows.Forms.Button
    Friend WithEvents filelb As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bgwrk As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents deletfilelist As System.Windows.Forms.ListBox
    Friend WithEvents statuslb As System.Windows.Forms.Label
    Friend WithEvents fileaddbt As System.Windows.Forms.Button
    Friend WithEvents dragdroplb As System.Windows.Forms.Label
    Friend WithEvents removeentrybt As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
