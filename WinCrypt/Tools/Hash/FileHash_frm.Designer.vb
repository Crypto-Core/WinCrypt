<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileHash_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileHash_frm))
        Me.form_head = New System.Windows.Forms.MenuStrip()
        Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.minimize_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
        Me.file_txt = New System.Windows.Forms.TextBox()
        Me.file_lb = New System.Windows.Forms.Label()
        Me.open_bt = New System.Windows.Forms.Button()
        Me.generate_bt = New System.Windows.Forms.Button()
        Me.md5_hash_txt = New System.Windows.Forms.TextBox()
        Me.md5_lb = New System.Windows.Forms.Label()
        Me.copy_bt = New System.Windows.Forms.Button()
        Me.openfile_dialog = New System.Windows.Forms.OpenFileDialog()
        Me.select_Hash_combo = New System.Windows.Forms.ComboBox()
        Me.form_head.SuspendLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'form_head
        '
        Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt, Me.minimize_bt})
        Me.form_head.Location = New System.Drawing.Point(0, 0)
        Me.form_head.Name = "form_head"
        Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.form_head.Size = New System.Drawing.Size(517, 27)
        Me.form_head.TabIndex = 20
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
        Me.wincrypttitle.Size = New System.Drawing.Size(98, 17)
        Me.wincrypttitle.TabIndex = 21
        Me.wincrypttitle.Text = "Datei checksum"
        '
        'wincrypt_icon
        '
        Me.wincrypt_icon.Image = Global.Project_WinCrypt.My.Resources.Resources.wc_icon16
        Me.wincrypt_icon.Location = New System.Drawing.Point(9, 6)
        Me.wincrypt_icon.Name = "wincrypt_icon"
        Me.wincrypt_icon.Size = New System.Drawing.Size(16, 16)
        Me.wincrypt_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wincrypt_icon.TabIndex = 22
        Me.wincrypt_icon.TabStop = False
        '
        'file_txt
        '
        Me.file_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.file_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.file_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.file_txt.Location = New System.Drawing.Point(47, 54)
        Me.file_txt.Name = "file_txt"
        Me.file_txt.Size = New System.Drawing.Size(377, 20)
        Me.file_txt.TabIndex = 23
        '
        'file_lb
        '
        Me.file_lb.AutoSize = True
        Me.file_lb.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.file_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.file_lb.Location = New System.Drawing.Point(6, 56)
        Me.file_lb.Name = "file_lb"
        Me.file_lb.Size = New System.Drawing.Size(37, 13)
        Me.file_lb.TabIndex = 24
        Me.file_lb.Text = "Datei:"
        '
        'open_bt
        '
        Me.open_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.open_bt.FlatAppearance.BorderSize = 0
        Me.open_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.open_bt.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.open_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.open_bt.Location = New System.Drawing.Point(430, 51)
        Me.open_bt.Name = "open_bt"
        Me.open_bt.Size = New System.Drawing.Size(75, 23)
        Me.open_bt.TabIndex = 25
        Me.open_bt.Text = "Öffnen"
        Me.open_bt.UseVisualStyleBackColor = False
        '
        'generate_bt
        '
        Me.generate_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.generate_bt.Enabled = False
        Me.generate_bt.FlatAppearance.BorderSize = 0
        Me.generate_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generate_bt.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.generate_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.generate_bt.Location = New System.Drawing.Point(225, 106)
        Me.generate_bt.Name = "generate_bt"
        Me.generate_bt.Size = New System.Drawing.Size(75, 23)
        Me.generate_bt.TabIndex = 26
        Me.generate_bt.Text = "Generieren"
        Me.generate_bt.UseVisualStyleBackColor = False
        '
        'md5_hash_txt
        '
        Me.md5_hash_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.md5_hash_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.md5_hash_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.md5_hash_txt.Location = New System.Drawing.Point(47, 80)
        Me.md5_hash_txt.Name = "md5_hash_txt"
        Me.md5_hash_txt.ReadOnly = True
        Me.md5_hash_txt.Size = New System.Drawing.Size(377, 20)
        Me.md5_hash_txt.TabIndex = 27
        Me.md5_hash_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'md5_lb
        '
        Me.md5_lb.AutoSize = True
        Me.md5_lb.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.md5_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.md5_lb.Location = New System.Drawing.Point(6, 82)
        Me.md5_lb.Name = "md5_lb"
        Me.md5_lb.Size = New System.Drawing.Size(36, 13)
        Me.md5_lb.TabIndex = 28
        Me.md5_lb.Text = "Hash:"
        '
        'copy_bt
        '
        Me.copy_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.copy_bt.FlatAppearance.BorderSize = 0
        Me.copy_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copy_bt.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.copy_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.copy_bt.Location = New System.Drawing.Point(430, 80)
        Me.copy_bt.Name = "copy_bt"
        Me.copy_bt.Size = New System.Drawing.Size(75, 23)
        Me.copy_bt.TabIndex = 29
        Me.copy_bt.Text = "Kopieren"
        Me.copy_bt.UseVisualStyleBackColor = False
        '
        'select_Hash_combo
        '
        Me.select_Hash_combo.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.select_Hash_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.select_Hash_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.select_Hash_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.select_Hash_combo.FormattingEnabled = True
        Me.select_Hash_combo.Items.AddRange(New Object() {"MD5", "SHA1", "SHA256", "SHA384", "SHA512", "RIPEMD160"})
        Me.select_Hash_combo.Location = New System.Drawing.Point(336, 106)
        Me.select_Hash_combo.Name = "select_Hash_combo"
        Me.select_Hash_combo.Size = New System.Drawing.Size(88, 21)
        Me.select_Hash_combo.TabIndex = 30
        '
        'FileHash_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(517, 143)
        Me.Controls.Add(Me.select_Hash_combo)
        Me.Controls.Add(Me.copy_bt)
        Me.Controls.Add(Me.md5_lb)
        Me.Controls.Add(Me.md5_hash_txt)
        Me.Controls.Add(Me.generate_bt)
        Me.Controls.Add(Me.open_bt)
        Me.Controls.Add(Me.file_lb)
        Me.Controls.Add(Me.file_txt)
        Me.Controls.Add(Me.wincrypt_icon)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.form_head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FileHash_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datei checksum"
        Me.form_head.ResumeLayout(False)
        Me.form_head.PerformLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents form_head As System.Windows.Forms.MenuStrip
    Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents minimize_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
    Friend WithEvents file_txt As System.Windows.Forms.TextBox
    Friend WithEvents file_lb As System.Windows.Forms.Label
    Friend WithEvents open_bt As System.Windows.Forms.Button
    Friend WithEvents generate_bt As System.Windows.Forms.Button
    Friend WithEvents md5_hash_txt As System.Windows.Forms.TextBox
    Friend WithEvents md5_lb As System.Windows.Forms.Label
    Friend WithEvents copy_bt As System.Windows.Forms.Button
    Friend WithEvents openfile_dialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents select_Hash_combo As System.Windows.Forms.ComboBox
End Class
