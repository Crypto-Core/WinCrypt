Namespace tools.safedelete
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
            Me.file_txt = New System.Windows.Forms.TextBox()
            Me.overwritecb = New System.Windows.Forms.ComboBox()
            Me.overwritelb = New System.Windows.Forms.Label()
            Me.progressstatus = New System.Windows.Forms.ProgressBar()
            Me.selectpathbt = New System.Windows.Forms.Button()
            Me.filelb = New System.Windows.Forms.Label()
            Me.add_file_dialog = New System.Windows.Forms.OpenFileDialog()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
            Me.deletfilelist = New System.Windows.Forms.ListBox()
            Me.statuslb = New System.Windows.Forms.Label()
            Me.fileaddbt = New System.Windows.Forms.Button()
            Me.removeentrybt = New System.Windows.Forms.Button()
            Me.form_head = New System.Windows.Forms.MenuStrip()
            Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.minimize_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.wincrypttitle = New System.Windows.Forms.Label()
            Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
            Me.overwrite_pb = New System.Windows.Forms.ProgressBar()
            Me.override_pb_lb = New System.Windows.Forms.Label()
            Me.abort_bt = New System.Windows.Forms.Button()
            Me.report_bt = New System.Windows.Forms.Button()
            Me.cleanlb1 = New System.Windows.Forms.Button()
            Me.loadBall = New System.Windows.Forms.PictureBox()
            Me.form_head.SuspendLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.loadBall, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'deletebt
            '
            Me.deletebt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.deletebt.FlatAppearance.BorderSize = 0
            Me.deletebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.deletebt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.deletebt.Location = New System.Drawing.Point(179, 446)
            Me.deletebt.Name = "deletebt"
            Me.deletebt.Size = New System.Drawing.Size(75, 23)
            Me.deletebt.TabIndex = 0
            Me.deletebt.Text = "Löschen"
            Me.deletebt.UseVisualStyleBackColor = False
            '
            'file_txt
            '
            Me.file_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.file_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.file_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.file_txt.Location = New System.Drawing.Point(12, 55)
            Me.file_txt.Name = "file_txt"
            Me.file_txt.Size = New System.Drawing.Size(327, 22)
            Me.file_txt.TabIndex = 1
            '
            'overwritecb
            '
            Me.overwritecb.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.overwritecb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.overwritecb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.overwritecb.FormattingEnabled = True
            Me.overwritecb.Items.AddRange(New Object() {"1x", "3x", "10x", "20x", "100x"})
            Me.overwritecb.Location = New System.Drawing.Point(100, 81)
            Me.overwritecb.Name = "overwritecb"
            Me.overwritecb.Size = New System.Drawing.Size(55, 21)
            Me.overwritecb.TabIndex = 2
            Me.overwritecb.Text = "3x"
            '
            'overwritelb
            '
            Me.overwritelb.AutoSize = True
            Me.overwritelb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.overwritelb.Location = New System.Drawing.Point(9, 84)
            Me.overwritelb.Name = "overwritelb"
            Me.overwritelb.Size = New System.Drawing.Size(85, 13)
            Me.overwritelb.TabIndex = 3
            Me.overwritelb.Text = "Überschreiben:"
            '
            'progressstatus
            '
            Me.progressstatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.progressstatus.Location = New System.Drawing.Point(12, 198)
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
            Me.filelb.Size = New System.Drawing.Size(47, 13)
            Me.filelb.TabIndex = 7
            Me.filelb.Text = "Ordner:"
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
            Me.deletfilelist.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.deletfilelist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.deletfilelist.FormattingEnabled = True
            Me.deletfilelist.Location = New System.Drawing.Point(15, 230)
            Me.deletfilelist.Name = "deletfilelist"
            Me.deletfilelist.Size = New System.Drawing.Size(405, 208)
            Me.deletfilelist.TabIndex = 10
            '
            'statuslb
            '
            Me.statuslb.AutoSize = True
            Me.statuslb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.statuslb.Location = New System.Drawing.Point(9, 182)
            Me.statuslb.Name = "statuslb"
            Me.statuslb.Size = New System.Drawing.Size(42, 13)
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
            'removeentrybt
            '
            Me.removeentrybt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.removeentrybt.FlatAppearance.BorderSize = 0
            Me.removeentrybt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.removeentrybt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.removeentrybt.Location = New System.Drawing.Point(313, 446)
            Me.removeentrybt.Name = "removeentrybt"
            Me.removeentrybt.Size = New System.Drawing.Size(107, 23)
            Me.removeentrybt.TabIndex = 15
            Me.removeentrybt.Text = "Eintrag entfernen"
            Me.removeentrybt.UseVisualStyleBackColor = False
            '
            'form_head
            '
            Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt, Me.minimize_bt})
            Me.form_head.Location = New System.Drawing.Point(0, 0)
            Me.form_head.Name = "form_head"
            Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.form_head.Size = New System.Drawing.Size(432, 27)
            Me.form_head.TabIndex = 16
            Me.form_head.Text = "WinCrypt"
            '
            'exit_bt
            '
            Me.exit_bt.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.exit_bt.ForeColor = System.Drawing.Color.White
            Me.exit_bt.Name = "exit_bt"
            Me.exit_bt.Size = New System.Drawing.Size(29, 23)
            Me.exit_bt.Text = "X"
            '
            'minimize_bt
            '
            Me.minimize_bt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.minimize_bt.ForeColor = System.Drawing.Color.White
            Me.minimize_bt.Name = "minimize_bt"
            Me.minimize_bt.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.minimize_bt.Size = New System.Drawing.Size(32, 23)
            Me.minimize_bt.Text = "─"
            '
            'wincrypttitle
            '
            Me.wincrypttitle.AutoSize = True
            Me.wincrypttitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.wincrypttitle.Location = New System.Drawing.Point(34, 6)
            Me.wincrypttitle.Name = "wincrypttitle"
            Me.wincrypttitle.Size = New System.Drawing.Size(138, 17)
            Me.wincrypttitle.TabIndex = 17
            Me.wincrypttitle.Text = "Dateien sicher löschen"
            '
            'wincrypt_icon
            '
            Me.wincrypt_icon.Image = Global.Project_WinCrypt.My.Resources.Resources.wc_icon16
            Me.wincrypt_icon.Location = New System.Drawing.Point(9, 6)
            Me.wincrypt_icon.Name = "wincrypt_icon"
            Me.wincrypt_icon.Size = New System.Drawing.Size(16, 16)
            Me.wincrypt_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.wincrypt_icon.TabIndex = 18
            Me.wincrypt_icon.TabStop = False
            '
            'overwrite_pb
            '
            Me.overwrite_pb.ForeColor = System.Drawing.Color.Red
            Me.overwrite_pb.Location = New System.Drawing.Point(12, 144)
            Me.overwrite_pb.Maximum = 10
            Me.overwrite_pb.Name = "overwrite_pb"
            Me.overwrite_pb.Size = New System.Drawing.Size(386, 23)
            Me.overwrite_pb.TabIndex = 5
            '
            'override_pb_lb
            '
            Me.override_pb_lb.AutoSize = True
            Me.override_pb_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.override_pb_lb.Location = New System.Drawing.Point(9, 128)
            Me.override_pb_lb.Name = "override_pb_lb"
            Me.override_pb_lb.Size = New System.Drawing.Size(85, 13)
            Me.override_pb_lb.TabIndex = 20
            Me.override_pb_lb.Text = "Überschrieben:"
            '
            'abort_bt
            '
            Me.abort_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.abort_bt.FlatAppearance.BorderSize = 0
            Me.abort_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.abort_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.abort_bt.Location = New System.Drawing.Point(179, 446)
            Me.abort_bt.Name = "abort_bt"
            Me.abort_bt.Size = New System.Drawing.Size(75, 23)
            Me.abort_bt.TabIndex = 22
            Me.abort_bt.Text = "Abbruch"
            Me.abort_bt.UseVisualStyleBackColor = False
            Me.abort_bt.Visible = False
            '
            'report_bt
            '
            Me.report_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.report_bt.Enabled = False
            Me.report_bt.FlatAppearance.BorderSize = 0
            Me.report_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.report_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.report_bt.Location = New System.Drawing.Point(15, 446)
            Me.report_bt.Name = "report_bt"
            Me.report_bt.Size = New System.Drawing.Size(75, 23)
            Me.report_bt.TabIndex = 23
            Me.report_bt.Text = "Report"
            Me.report_bt.UseVisualStyleBackColor = False
            '
            'cleanlb1
            '
            Me.cleanlb1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cleanlb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.cleanlb1.FlatAppearance.BorderSize = 0
            Me.cleanlb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cleanlb1.Image = Global.Project_WinCrypt.My.Resources.Resources.Clean_16
            Me.cleanlb1.Location = New System.Drawing.Point(270, 446)
            Me.cleanlb1.Name = "cleanlb1"
            Me.cleanlb1.Size = New System.Drawing.Size(37, 23)
            Me.cleanlb1.TabIndex = 24
            Me.cleanlb1.UseVisualStyleBackColor = False
            '
            'loadBall
            '
            Me.loadBall.Enabled = False
            Me.loadBall.Image = Global.Project_WinCrypt.My.Resources.Resources.Ballload
            Me.loadBall.Location = New System.Drawing.Point(404, 144)
            Me.loadBall.Name = "loadBall"
            Me.loadBall.Size = New System.Drawing.Size(23, 23)
            Me.loadBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.loadBall.TabIndex = 25
            Me.loadBall.TabStop = False
            '
            'safedelete
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(432, 475)
            Me.Controls.Add(Me.loadBall)
            Me.Controls.Add(Me.cleanlb1)
            Me.Controls.Add(Me.report_bt)
            Me.Controls.Add(Me.abort_bt)
            Me.Controls.Add(Me.override_pb_lb)
            Me.Controls.Add(Me.overwrite_pb)
            Me.Controls.Add(Me.wincrypt_icon)
            Me.Controls.Add(Me.wincrypttitle)
            Me.Controls.Add(Me.form_head)
            Me.Controls.Add(Me.removeentrybt)
            Me.Controls.Add(Me.fileaddbt)
            Me.Controls.Add(Me.statuslb)
            Me.Controls.Add(Me.deletfilelist)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.filelb)
            Me.Controls.Add(Me.selectpathbt)
            Me.Controls.Add(Me.progressstatus)
            Me.Controls.Add(Me.overwritelb)
            Me.Controls.Add(Me.overwritecb)
            Me.Controls.Add(Me.file_txt)
            Me.Controls.Add(Me.deletebt)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "safedelete"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Sicher löschen"
            Me.form_head.ResumeLayout(False)
            Me.form_head.PerformLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.loadBall, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents deletebt As System.Windows.Forms.Button
        Friend WithEvents file_txt As System.Windows.Forms.TextBox
        Friend WithEvents overwritecb As System.Windows.Forms.ComboBox
        Friend WithEvents overwritelb As System.Windows.Forms.Label
        Friend WithEvents progressstatus As System.Windows.Forms.ProgressBar
        Friend WithEvents selectpathbt As System.Windows.Forms.Button
        Friend WithEvents filelb As System.Windows.Forms.Label
        Friend WithEvents add_file_dialog As System.Windows.Forms.OpenFileDialog
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
        Friend WithEvents deletfilelist As System.Windows.Forms.ListBox
        Friend WithEvents statuslb As System.Windows.Forms.Label
        Friend WithEvents fileaddbt As System.Windows.Forms.Button
        Friend WithEvents removeentrybt As System.Windows.Forms.Button
        Friend WithEvents form_head As System.Windows.Forms.MenuStrip
        Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents minimize_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents wincrypttitle As System.Windows.Forms.Label
        Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
        Friend WithEvents overwrite_pb As System.Windows.Forms.ProgressBar
        Friend WithEvents override_pb_lb As System.Windows.Forms.Label
        Friend WithEvents abort_bt As System.Windows.Forms.Button
        Friend WithEvents report_bt As System.Windows.Forms.Button
        Friend WithEvents cleanlb1 As System.Windows.Forms.Button
        Friend WithEvents loadBall As System.Windows.Forms.PictureBox
    End Class
End Namespace