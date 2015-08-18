Namespace tools.rsa
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class rsa_create_keys
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rsa_create_keys))
            Me.private_key_lb1 = New System.Windows.Forms.Label()
            Me.public_key_lb1 = New System.Windows.Forms.Label()
            Me.save_privkey_bt = New System.Windows.Forms.Button()
            Me.save_pubkey_bt = New System.Windows.Forms.Button()
            Me.private_key_path_txt = New System.Windows.Forms.TextBox()
            Me.public_key_path_txt = New System.Windows.Forms.TextBox()
            Me.save_keys_dialog = New System.Windows.Forms.SaveFileDialog()
            Me.generate_key_bt = New System.Windows.Forms.Button()
            Me.save_bt = New System.Windows.Forms.Button()
            Me.private_key_lb2 = New System.Windows.Forms.Label()
            Me.privatekey_txt = New System.Windows.Forms.TextBox()
            Me.publickey_txt = New System.Windows.Forms.TextBox()
            Me.public_key_lb2 = New System.Windows.Forms.Label()
            Me.form_head = New System.Windows.Forms.MenuStrip()
            Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.minimize_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.wincrypttitle = New System.Windows.Forms.Label()
            Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
            Me.bit_cb = New System.Windows.Forms.ComboBox()
            Me.form_head.SuspendLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'private_key_lb1
            '
            Me.private_key_lb1.AutoSize = True
            Me.private_key_lb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.private_key_lb1.Location = New System.Drawing.Point(12, 53)
            Me.private_key_lb1.Name = "private_key_lb1"
            Me.private_key_lb1.Size = New System.Drawing.Size(64, 13)
            Me.private_key_lb1.TabIndex = 0
            Me.private_key_lb1.Text = "Private Key:"
            '
            'public_key_lb1
            '
            Me.public_key_lb1.AutoSize = True
            Me.public_key_lb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.public_key_lb1.Location = New System.Drawing.Point(12, 82)
            Me.public_key_lb1.Name = "public_key_lb1"
            Me.public_key_lb1.Size = New System.Drawing.Size(61, 13)
            Me.public_key_lb1.TabIndex = 1
            Me.public_key_lb1.Text = "Public Key:"
            '
            'save_privkey_bt
            '
            Me.save_privkey_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.save_privkey_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.save_privkey_bt.FlatAppearance.BorderSize = 0
            Me.save_privkey_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.save_privkey_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.save_privkey_bt.Location = New System.Drawing.Point(515, 48)
            Me.save_privkey_bt.Name = "save_privkey_bt"
            Me.save_privkey_bt.Size = New System.Drawing.Size(103, 23)
            Me.save_privkey_bt.TabIndex = 2
            Me.save_privkey_bt.Text = "Speichern unter"
            Me.save_privkey_bt.UseVisualStyleBackColor = False
            '
            'save_pubkey_bt
            '
            Me.save_pubkey_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.save_pubkey_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.save_pubkey_bt.FlatAppearance.BorderSize = 0
            Me.save_pubkey_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.save_pubkey_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.save_pubkey_bt.Location = New System.Drawing.Point(515, 77)
            Me.save_pubkey_bt.Name = "save_pubkey_bt"
            Me.save_pubkey_bt.Size = New System.Drawing.Size(103, 23)
            Me.save_pubkey_bt.TabIndex = 3
            Me.save_pubkey_bt.Text = "Speichern unter"
            Me.save_pubkey_bt.UseVisualStyleBackColor = False
            '
            'private_key_path_txt
            '
            Me.private_key_path_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.private_key_path_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.private_key_path_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.private_key_path_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.private_key_path_txt.Location = New System.Drawing.Point(82, 50)
            Me.private_key_path_txt.Name = "private_key_path_txt"
            Me.private_key_path_txt.Size = New System.Drawing.Size(427, 22)
            Me.private_key_path_txt.TabIndex = 4
            '
            'public_key_path_txt
            '
            Me.public_key_path_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.public_key_path_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.public_key_path_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.public_key_path_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.public_key_path_txt.Location = New System.Drawing.Point(82, 79)
            Me.public_key_path_txt.Name = "public_key_path_txt"
            Me.public_key_path_txt.Size = New System.Drawing.Size(427, 22)
            Me.public_key_path_txt.TabIndex = 5
            '
            'save_keys_dialog
            '
            Me.save_keys_dialog.Filter = "KEY-file|*.key"
            '
            'generate_key_bt
            '
            Me.generate_key_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.generate_key_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.generate_key_bt.FlatAppearance.BorderSize = 0
            Me.generate_key_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.generate_key_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.generate_key_bt.Location = New System.Drawing.Point(12, 424)
            Me.generate_key_bt.Name = "generate_key_bt"
            Me.generate_key_bt.Size = New System.Drawing.Size(137, 23)
            Me.generate_key_bt.TabIndex = 6
            Me.generate_key_bt.Text = "Schlüssel generieren"
            Me.generate_key_bt.UseVisualStyleBackColor = False
            '
            'save_bt
            '
            Me.save_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.save_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.save_bt.Enabled = False
            Me.save_bt.FlatAppearance.BorderSize = 0
            Me.save_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.save_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.save_bt.Location = New System.Drawing.Point(543, 424)
            Me.save_bt.Name = "save_bt"
            Me.save_bt.Size = New System.Drawing.Size(75, 23)
            Me.save_bt.TabIndex = 7
            Me.save_bt.Text = "Speichern"
            Me.save_bt.UseVisualStyleBackColor = False
            '
            'private_key_lb2
            '
            Me.private_key_lb2.AutoSize = True
            Me.private_key_lb2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.private_key_lb2.Location = New System.Drawing.Point(12, 113)
            Me.private_key_lb2.Name = "private_key_lb2"
            Me.private_key_lb2.Size = New System.Drawing.Size(61, 13)
            Me.private_key_lb2.TabIndex = 8
            Me.private_key_lb2.Text = "Private Key"
            '
            'privatekey_txt
            '
            Me.privatekey_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.privatekey_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.privatekey_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.privatekey_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.privatekey_txt.Location = New System.Drawing.Point(15, 129)
            Me.privatekey_txt.Multiline = True
            Me.privatekey_txt.Name = "privatekey_txt"
            Me.privatekey_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.privatekey_txt.Size = New System.Drawing.Size(603, 165)
            Me.privatekey_txt.TabIndex = 9
            '
            'publickey_txt
            '
            Me.publickey_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.publickey_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.publickey_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.publickey_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.publickey_txt.Location = New System.Drawing.Point(12, 313)
            Me.publickey_txt.Multiline = True
            Me.publickey_txt.Name = "publickey_txt"
            Me.publickey_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.publickey_txt.Size = New System.Drawing.Size(606, 105)
            Me.publickey_txt.TabIndex = 10
            '
            'public_key_lb2
            '
            Me.public_key_lb2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.public_key_lb2.AutoSize = True
            Me.public_key_lb2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.public_key_lb2.Location = New System.Drawing.Point(12, 297)
            Me.public_key_lb2.Name = "public_key_lb2"
            Me.public_key_lb2.Size = New System.Drawing.Size(58, 13)
            Me.public_key_lb2.TabIndex = 11
            Me.public_key_lb2.Text = "Public Key"
            '
            'form_head
            '
            Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt, Me.minimize_bt})
            Me.form_head.Location = New System.Drawing.Point(0, 0)
            Me.form_head.Name = "form_head"
            Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.form_head.Size = New System.Drawing.Size(630, 27)
            Me.form_head.TabIndex = 13
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
            Me.wincrypttitle.Size = New System.Drawing.Size(140, 17)
            Me.wincrypttitle.TabIndex = 14
            Me.wincrypttitle.Text = "RSA Schlüssel erstellen"
            '
            'wincrypt_icon
            '
            Me.wincrypt_icon.Image = Global.Project_WinCrypt.My.Resources.Resources.wc_icon16
            Me.wincrypt_icon.Location = New System.Drawing.Point(9, 6)
            Me.wincrypt_icon.Name = "wincrypt_icon"
            Me.wincrypt_icon.Size = New System.Drawing.Size(16, 16)
            Me.wincrypt_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.wincrypt_icon.TabIndex = 15
            Me.wincrypt_icon.TabStop = False
            '
            'bit_cb
            '
            Me.bit_cb.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.bit_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.bit_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bit_cb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.bit_cb.FormattingEnabled = True
            Me.bit_cb.Items.AddRange(New Object() {"1024", "2048", "4096"})
            Me.bit_cb.Location = New System.Drawing.Point(155, 425)
            Me.bit_cb.Name = "bit_cb"
            Me.bit_cb.Size = New System.Drawing.Size(57, 21)
            Me.bit_cb.TabIndex = 16
            '
            'rsa_create_keys
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(630, 459)
            Me.Controls.Add(Me.bit_cb)
            Me.Controls.Add(Me.wincrypt_icon)
            Me.Controls.Add(Me.wincrypttitle)
            Me.Controls.Add(Me.form_head)
            Me.Controls.Add(Me.public_key_lb2)
            Me.Controls.Add(Me.publickey_txt)
            Me.Controls.Add(Me.privatekey_txt)
            Me.Controls.Add(Me.private_key_lb2)
            Me.Controls.Add(Me.save_bt)
            Me.Controls.Add(Me.generate_key_bt)
            Me.Controls.Add(Me.public_key_path_txt)
            Me.Controls.Add(Me.private_key_path_txt)
            Me.Controls.Add(Me.save_pubkey_bt)
            Me.Controls.Add(Me.save_privkey_bt)
            Me.Controls.Add(Me.public_key_lb1)
            Me.Controls.Add(Me.private_key_lb1)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "rsa_create_keys"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "RSA Schlüssel erstellen"
            Me.form_head.ResumeLayout(False)
            Me.form_head.PerformLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents private_key_lb1 As System.Windows.Forms.Label
        Friend WithEvents public_key_lb1 As System.Windows.Forms.Label
        Friend WithEvents save_privkey_bt As System.Windows.Forms.Button
        Friend WithEvents save_pubkey_bt As System.Windows.Forms.Button
        Friend WithEvents private_key_path_txt As System.Windows.Forms.TextBox
        Friend WithEvents public_key_path_txt As System.Windows.Forms.TextBox
        Friend WithEvents save_keys_dialog As System.Windows.Forms.SaveFileDialog
        Friend WithEvents generate_key_bt As System.Windows.Forms.Button
        Friend WithEvents save_bt As System.Windows.Forms.Button
        Friend WithEvents private_key_lb2 As System.Windows.Forms.Label
        Friend WithEvents privatekey_txt As System.Windows.Forms.TextBox
        Friend WithEvents publickey_txt As System.Windows.Forms.TextBox
        Friend WithEvents public_key_lb2 As System.Windows.Forms.Label
        Friend WithEvents form_head As System.Windows.Forms.MenuStrip
        Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents minimize_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents wincrypttitle As System.Windows.Forms.Label
        Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
        Friend WithEvents bit_cb As System.Windows.Forms.ComboBox
    End Class
End Namespace