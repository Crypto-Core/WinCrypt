Namespace tools.rsa
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class rsa_encrypt
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rsa_encrypt))
            Me.pubkey_path_bt = New System.Windows.Forms.Button()
            Me.pubkey_lb = New System.Windows.Forms.Label()
            Me.pubkey_path_txt = New System.Windows.Forms.TextBox()
            Me.encryption_message_txt = New System.Windows.Forms.TextBox()
            Me.decryption_message_txt = New System.Windows.Forms.TextBox()
            Me.message_lb = New System.Windows.Forms.Label()
            Me.encryption_message_lb = New System.Windows.Forms.Label()
            Me.encryption_bt = New System.Windows.Forms.Button()
            Me.open_public_key_dialog = New System.Windows.Forms.OpenFileDialog()
            Me.form_head = New System.Windows.Forms.MenuStrip()
            Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.minimze_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.wincrypttitle = New System.Windows.Forms.Label()
            Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
            Me.bit_cb = New System.Windows.Forms.ComboBox()
            Me.form_head.SuspendLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pubkey_path_bt
            '
            Me.pubkey_path_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pubkey_path_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.pubkey_path_bt.FlatAppearance.BorderSize = 0
            Me.pubkey_path_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.pubkey_path_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.pubkey_path_bt.Location = New System.Drawing.Point(591, 38)
            Me.pubkey_path_bt.Name = "pubkey_path_bt"
            Me.pubkey_path_bt.Size = New System.Drawing.Size(75, 23)
            Me.pubkey_path_bt.TabIndex = 0
            Me.pubkey_path_bt.Text = "Öffnen"
            Me.pubkey_path_bt.UseVisualStyleBackColor = False
            '
            'pubkey_lb
            '
            Me.pubkey_lb.AutoSize = True
            Me.pubkey_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.pubkey_lb.Location = New System.Drawing.Point(9, 43)
            Me.pubkey_lb.Name = "pubkey_lb"
            Me.pubkey_lb.Size = New System.Drawing.Size(61, 13)
            Me.pubkey_lb.TabIndex = 1
            Me.pubkey_lb.Text = "Public Key:"
            '
            'pubkey_path_txt
            '
            Me.pubkey_path_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pubkey_path_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.pubkey_path_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pubkey_path_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.pubkey_path_txt.Location = New System.Drawing.Point(75, 40)
            Me.pubkey_path_txt.Name = "pubkey_path_txt"
            Me.pubkey_path_txt.Size = New System.Drawing.Size(510, 22)
            Me.pubkey_path_txt.TabIndex = 2
            '
            'encryption_message_txt
            '
            Me.encryption_message_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.encryption_message_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.encryption_message_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.encryption_message_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.encryption_message_txt.Location = New System.Drawing.Point(15, 85)
            Me.encryption_message_txt.Multiline = True
            Me.encryption_message_txt.Name = "encryption_message_txt"
            Me.encryption_message_txt.Size = New System.Drawing.Size(654, 176)
            Me.encryption_message_txt.TabIndex = 3
            '
            'decryption_message_txt
            '
            Me.decryption_message_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.decryption_message_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.decryption_message_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.decryption_message_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.decryption_message_txt.Location = New System.Drawing.Point(12, 288)
            Me.decryption_message_txt.Multiline = True
            Me.decryption_message_txt.Name = "decryption_message_txt"
            Me.decryption_message_txt.ReadOnly = True
            Me.decryption_message_txt.Size = New System.Drawing.Size(654, 151)
            Me.decryption_message_txt.TabIndex = 4
            '
            'message_lb
            '
            Me.message_lb.AutoSize = True
            Me.message_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.message_lb.Location = New System.Drawing.Point(12, 69)
            Me.message_lb.Name = "message_lb"
            Me.message_lb.Size = New System.Drawing.Size(56, 13)
            Me.message_lb.TabIndex = 5
            Me.message_lb.Text = "Nachricht"
            '
            'encryption_message_lb
            '
            Me.encryption_message_lb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.encryption_message_lb.AutoSize = True
            Me.encryption_message_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.encryption_message_lb.Location = New System.Drawing.Point(15, 270)
            Me.encryption_message_lb.Name = "encryption_message_lb"
            Me.encryption_message_lb.Size = New System.Drawing.Size(131, 13)
            Me.encryption_message_lb.TabIndex = 6
            Me.encryption_message_lb.Text = "Verschlüsselte Nachricht"
            '
            'encryption_bt
            '
            Me.encryption_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.encryption_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.encryption_bt.FlatAppearance.BorderSize = 0
            Me.encryption_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.encryption_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.encryption_bt.Location = New System.Drawing.Point(574, 445)
            Me.encryption_bt.Name = "encryption_bt"
            Me.encryption_bt.Size = New System.Drawing.Size(92, 23)
            Me.encryption_bt.TabIndex = 7
            Me.encryption_bt.Text = "Verschlüsseln"
            Me.encryption_bt.UseVisualStyleBackColor = False
            '
            'open_public_key_dialog
            '
            Me.open_public_key_dialog.Filter = "KEY-file|*.key"
            '
            'form_head
            '
            Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt, Me.minimze_bt})
            Me.form_head.Location = New System.Drawing.Point(0, 0)
            Me.form_head.Name = "form_head"
            Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.form_head.Size = New System.Drawing.Size(681, 27)
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
            'minimze_bt
            '
            Me.minimze_bt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.minimze_bt.ForeColor = System.Drawing.Color.White
            Me.minimze_bt.Name = "minimze_bt"
            Me.minimze_bt.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.minimze_bt.Size = New System.Drawing.Size(32, 23)
            Me.minimze_bt.Text = "─"
            '
            'wincrypttitle
            '
            Me.wincrypttitle.AutoSize = True
            Me.wincrypttitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.wincrypttitle.Location = New System.Drawing.Point(34, 6)
            Me.wincrypttitle.Name = "wincrypttitle"
            Me.wincrypttitle.Size = New System.Drawing.Size(127, 17)
            Me.wincrypttitle.TabIndex = 14
            Me.wincrypttitle.Text = "RSA Verschlüsselung"
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
            Me.bit_cb.Location = New System.Drawing.Point(511, 446)
            Me.bit_cb.Name = "bit_cb"
            Me.bit_cb.Size = New System.Drawing.Size(57, 21)
            Me.bit_cb.TabIndex = 16
            '
            'rsa_encrypt
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(681, 473)
            Me.Controls.Add(Me.bit_cb)
            Me.Controls.Add(Me.wincrypt_icon)
            Me.Controls.Add(Me.wincrypttitle)
            Me.Controls.Add(Me.form_head)
            Me.Controls.Add(Me.encryption_bt)
            Me.Controls.Add(Me.encryption_message_lb)
            Me.Controls.Add(Me.message_lb)
            Me.Controls.Add(Me.decryption_message_txt)
            Me.Controls.Add(Me.encryption_message_txt)
            Me.Controls.Add(Me.pubkey_path_txt)
            Me.Controls.Add(Me.pubkey_lb)
            Me.Controls.Add(Me.pubkey_path_bt)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "rsa_encrypt"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "RSA Verschlüsselung"
            Me.form_head.ResumeLayout(False)
            Me.form_head.PerformLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents pubkey_path_bt As System.Windows.Forms.Button
        Friend WithEvents pubkey_lb As System.Windows.Forms.Label
        Friend WithEvents pubkey_path_txt As System.Windows.Forms.TextBox
        Friend WithEvents encryption_message_txt As System.Windows.Forms.TextBox
        Friend WithEvents decryption_message_txt As System.Windows.Forms.TextBox
        Friend WithEvents message_lb As System.Windows.Forms.Label
        Friend WithEvents encryption_message_lb As System.Windows.Forms.Label
        Friend WithEvents encryption_bt As System.Windows.Forms.Button
        Friend WithEvents open_public_key_dialog As System.Windows.Forms.OpenFileDialog
        Friend WithEvents form_head As System.Windows.Forms.MenuStrip
        Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents minimze_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents wincrypttitle As System.Windows.Forms.Label
        Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
        Friend WithEvents bit_cb As System.Windows.Forms.ComboBox
    End Class
End Namespace