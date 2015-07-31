Namespace tools.passwordgenerator
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class passwordgenerator
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(passwordgenerator))
            Me.generatebt = New System.Windows.Forms.Button()
            Me.generatetxt = New System.Windows.Forms.TextBox()
            Me.length = New System.Windows.Forms.TextBox()
            Me.uppercasecb = New System.Windows.Forms.CheckBox()
            Me.lowercasecb = New System.Windows.Forms.CheckBox()
            Me.numberscb = New System.Windows.Forms.CheckBox()
            Me.length_lb = New System.Windows.Forms.Label()
            Me.copybt = New System.Windows.Forms.Button()
            Me.specialchar = New System.Windows.Forms.CheckBox()
            Me.form_head = New System.Windows.Forms.MenuStrip()
            Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.minimize_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.wincrypttitle = New System.Windows.Forms.Label()
            Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
            Me.lines_lb = New System.Windows.Forms.Label()
            Me.lines = New System.Windows.Forms.TextBox()
            Me.plus = New System.Windows.Forms.Button()
            Me.minus = New System.Windows.Forms.Button()
            Me.pw_length = New System.Windows.Forms.Label()
            Me.saveas_bt = New System.Windows.Forms.Button()
            Me.save_pw_dialog = New System.Windows.Forms.SaveFileDialog()
            Me.attachments = New System.Windows.Forms.CheckBox()
            Me.form_head.SuspendLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'generatebt
            '
            Me.generatebt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.generatebt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.generatebt.FlatAppearance.BorderSize = 0
            Me.generatebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.generatebt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.generatebt.Location = New System.Drawing.Point(553, 383)
            Me.generatebt.Name = "generatebt"
            Me.generatebt.Size = New System.Drawing.Size(75, 23)
            Me.generatebt.TabIndex = 0
            Me.generatebt.Text = "Generieren"
            Me.generatebt.UseVisualStyleBackColor = False
            '
            'generatetxt
            '
            Me.generatetxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.generatetxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.generatetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.generatetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.generatetxt.Location = New System.Drawing.Point(12, 35)
            Me.generatetxt.Multiline = True
            Me.generatetxt.Name = "generatetxt"
            Me.generatetxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.generatetxt.Size = New System.Drawing.Size(616, 266)
            Me.generatetxt.TabIndex = 1
            '
            'length
            '
            Me.length.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.length.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.length.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.length.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.length.Location = New System.Drawing.Point(205, 386)
            Me.length.MaxLength = 5
            Me.length.Name = "length"
            Me.length.Size = New System.Drawing.Size(39, 22)
            Me.length.TabIndex = 2
            Me.length.Text = "32"
            '
            'uppercasecb
            '
            Me.uppercasecb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.uppercasecb.AutoSize = True
            Me.uppercasecb.Checked = True
            Me.uppercasecb.CheckState = System.Windows.Forms.CheckState.Checked
            Me.uppercasecb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.uppercasecb.Location = New System.Drawing.Point(12, 343)
            Me.uppercasecb.Name = "uppercasecb"
            Me.uppercasecb.Size = New System.Drawing.Size(112, 17)
            Me.uppercasecb.TabIndex = 3
            Me.uppercasecb.Text = "Großbuchstaben"
            Me.uppercasecb.UseVisualStyleBackColor = True
            '
            'lowercasecb
            '
            Me.lowercasecb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lowercasecb.AutoSize = True
            Me.lowercasecb.Checked = True
            Me.lowercasecb.CheckState = System.Windows.Forms.CheckState.Checked
            Me.lowercasecb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.lowercasecb.Location = New System.Drawing.Point(12, 366)
            Me.lowercasecb.Name = "lowercasecb"
            Me.lowercasecb.Size = New System.Drawing.Size(112, 17)
            Me.lowercasecb.TabIndex = 4
            Me.lowercasecb.Text = "Kleinbuchstaben"
            Me.lowercasecb.UseVisualStyleBackColor = True
            '
            'numberscb
            '
            Me.numberscb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numberscb.AutoSize = True
            Me.numberscb.Checked = True
            Me.numberscb.CheckState = System.Windows.Forms.CheckState.Checked
            Me.numberscb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.numberscb.Location = New System.Drawing.Point(12, 389)
            Me.numberscb.Name = "numberscb"
            Me.numberscb.Size = New System.Drawing.Size(61, 17)
            Me.numberscb.TabIndex = 5
            Me.numberscb.Text = "Zahlen"
            Me.numberscb.UseVisualStyleBackColor = True
            '
            'length_lb
            '
            Me.length_lb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.length_lb.AutoSize = True
            Me.length_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.length_lb.Location = New System.Drawing.Point(152, 390)
            Me.length_lb.Name = "length_lb"
            Me.length_lb.Size = New System.Drawing.Size(38, 13)
            Me.length_lb.TabIndex = 6
            Me.length_lb.Text = "Länge"
            '
            'copybt
            '
            Me.copybt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.copybt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.copybt.Enabled = False
            Me.copybt.FlatAppearance.BorderSize = 0
            Me.copybt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.copybt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.copybt.Location = New System.Drawing.Point(472, 383)
            Me.copybt.Name = "copybt"
            Me.copybt.Size = New System.Drawing.Size(75, 23)
            Me.copybt.TabIndex = 7
            Me.copybt.Text = "Kopieren"
            Me.copybt.UseVisualStyleBackColor = False
            '
            'specialchar
            '
            Me.specialchar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.specialchar.AutoSize = True
            Me.specialchar.Checked = True
            Me.specialchar.CheckState = System.Windows.Forms.CheckState.Checked
            Me.specialchar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.specialchar.Location = New System.Drawing.Point(12, 320)
            Me.specialchar.Name = "specialchar"
            Me.specialchar.Size = New System.Drawing.Size(161, 17)
            Me.specialchar.TabIndex = 9
            Me.specialchar.Text = "Sonderzeichen (!""§$%&/()=?)"
            Me.specialchar.UseVisualStyleBackColor = True
            '
            'form_head
            '
            Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt, Me.minimize_bt})
            Me.form_head.Location = New System.Drawing.Point(0, 0)
            Me.form_head.Name = "form_head"
            Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.form_head.Size = New System.Drawing.Size(640, 27)
            Me.form_head.TabIndex = 31
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
            Me.wincrypttitle.Size = New System.Drawing.Size(118, 17)
            Me.wincrypttitle.TabIndex = 32
            Me.wincrypttitle.Text = "Passwortgenerator"
            '
            'wincrypt_icon
            '
            Me.wincrypt_icon.Image = Global.Project_WinCrypt.My.Resources.Resources.wc_icon16
            Me.wincrypt_icon.Location = New System.Drawing.Point(9, 6)
            Me.wincrypt_icon.Name = "wincrypt_icon"
            Me.wincrypt_icon.Size = New System.Drawing.Size(16, 16)
            Me.wincrypt_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.wincrypt_icon.TabIndex = 33
            Me.wincrypt_icon.TabStop = False
            '
            'lines_lb
            '
            Me.lines_lb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lines_lb.AutoSize = True
            Me.lines_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.lines_lb.Location = New System.Drawing.Point(152, 359)
            Me.lines_lb.Name = "lines_lb"
            Me.lines_lb.Size = New System.Drawing.Size(38, 13)
            Me.lines_lb.TabIndex = 34
            Me.lines_lb.Text = "Zeilen"
            '
            'lines
            '
            Me.lines.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lines.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lines.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.lines.Location = New System.Drawing.Point(205, 357)
            Me.lines.MaxLength = 100000
            Me.lines.Name = "lines"
            Me.lines.Size = New System.Drawing.Size(39, 22)
            Me.lines.TabIndex = 35
            Me.lines.Text = "1"
            '
            'plus
            '
            Me.plus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.plus.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.plus.FlatAppearance.BorderSize = 0
            Me.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.plus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.plus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.plus.Image = Global.Project_WinCrypt.My.Resources.Resources.AddNew16
            Me.plus.Location = New System.Drawing.Point(281, 355)
            Me.plus.Name = "plus"
            Me.plus.Size = New System.Drawing.Size(25, 25)
            Me.plus.TabIndex = 36
            Me.plus.UseVisualStyleBackColor = False
            '
            'minus
            '
            Me.minus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.minus.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.minus.FlatAppearance.BorderSize = 0
            Me.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.minus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.minus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.minus.Image = Global.Project_WinCrypt.My.Resources.Resources.Minus_16
            Me.minus.Location = New System.Drawing.Point(250, 355)
            Me.minus.Name = "minus"
            Me.minus.Size = New System.Drawing.Size(25, 25)
            Me.minus.TabIndex = 37
            Me.minus.UseVisualStyleBackColor = False
            '
            'pw_length
            '
            Me.pw_length.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.pw_length.AutoSize = True
            Me.pw_length.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.pw_length.Location = New System.Drawing.Point(12, 304)
            Me.pw_length.Name = "pw_length"
            Me.pw_length.Size = New System.Drawing.Size(50, 13)
            Me.pw_length.TabIndex = 38
            Me.pw_length.Text = "Zeichen:"
            '
            'saveas_bt
            '
            Me.saveas_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.saveas_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.saveas_bt.FlatAppearance.BorderSize = 0
            Me.saveas_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.saveas_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.saveas_bt.Location = New System.Drawing.Point(500, 307)
            Me.saveas_bt.Name = "saveas_bt"
            Me.saveas_bt.Size = New System.Drawing.Size(128, 23)
            Me.saveas_bt.TabIndex = 39
            Me.saveas_bt.Text = "Speichern unter..."
            Me.saveas_bt.UseVisualStyleBackColor = False
            Me.saveas_bt.Visible = False
            '
            'save_pw_dialog
            '
            Me.save_pw_dialog.FileName = "pwlist.txt"
            Me.save_pw_dialog.Filter = "text file|*.txt"
            Me.save_pw_dialog.OverwritePrompt = False
            '
            'attachments
            '
            Me.attachments.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.attachments.AutoSize = True
            Me.attachments.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.attachments.Location = New System.Drawing.Point(519, 336)
            Me.attachments.Name = "attachments"
            Me.attachments.Size = New System.Drawing.Size(85, 17)
            Me.attachments.TabIndex = 40
            Me.attachments.Text = "Anhängen?"
            Me.attachments.UseVisualStyleBackColor = True
            Me.attachments.Visible = False
            '
            'passwordgenerator
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(640, 418)
            Me.Controls.Add(Me.attachments)
            Me.Controls.Add(Me.saveas_bt)
            Me.Controls.Add(Me.pw_length)
            Me.Controls.Add(Me.minus)
            Me.Controls.Add(Me.plus)
            Me.Controls.Add(Me.lines)
            Me.Controls.Add(Me.lines_lb)
            Me.Controls.Add(Me.wincrypt_icon)
            Me.Controls.Add(Me.wincrypttitle)
            Me.Controls.Add(Me.form_head)
            Me.Controls.Add(Me.specialchar)
            Me.Controls.Add(Me.copybt)
            Me.Controls.Add(Me.length_lb)
            Me.Controls.Add(Me.numberscb)
            Me.Controls.Add(Me.lowercasecb)
            Me.Controls.Add(Me.uppercasecb)
            Me.Controls.Add(Me.length)
            Me.Controls.Add(Me.generatetxt)
            Me.Controls.Add(Me.generatebt)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimumSize = New System.Drawing.Size(300, 300)
            Me.Name = "passwordgenerator"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "WinCrypt - Passwortgenerator"
            Me.form_head.ResumeLayout(False)
            Me.form_head.PerformLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents generatebt As System.Windows.Forms.Button
        Friend WithEvents generatetxt As System.Windows.Forms.TextBox
        Friend WithEvents length As System.Windows.Forms.TextBox
        Friend WithEvents uppercasecb As System.Windows.Forms.CheckBox
        Friend WithEvents lowercasecb As System.Windows.Forms.CheckBox
        Friend WithEvents numberscb As System.Windows.Forms.CheckBox
        Friend WithEvents length_lb As System.Windows.Forms.Label
        Friend WithEvents copybt As System.Windows.Forms.Button
        Friend WithEvents specialchar As System.Windows.Forms.CheckBox
        Friend WithEvents form_head As System.Windows.Forms.MenuStrip
        Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents minimize_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents wincrypttitle As System.Windows.Forms.Label
        Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
        Friend WithEvents lines_lb As System.Windows.Forms.Label
        Friend WithEvents lines As System.Windows.Forms.TextBox
        Friend WithEvents plus As System.Windows.Forms.Button
        Friend WithEvents minus As System.Windows.Forms.Button
        Friend WithEvents pw_length As System.Windows.Forms.Label
        Friend WithEvents saveas_bt As System.Windows.Forms.Button
        Friend WithEvents save_pw_dialog As System.Windows.Forms.SaveFileDialog
        Friend WithEvents attachments As System.Windows.Forms.CheckBox
    End Class
End Namespace