Namespace tools.text_encryption
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Textencrypt
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Textencrypt))
            Me.text_input = New System.Windows.Forms.TextBox()
            Me.text_output = New System.Windows.Forms.TextBox()
            Me.encrypt_bt = New System.Windows.Forms.Button()
            Me.password_txt = New System.Windows.Forms.TextBox()
            Me.password_lb = New System.Windows.Forms.Label()
            Me.generate_bt = New System.Windows.Forms.Button()
            Me.decrypt_bt = New System.Windows.Forms.Button()
            Me.TrackBar = New System.Windows.Forms.TrackBar()
            Me.encrypt_lb = New System.Windows.Forms.Label()
            Me.decrypt_lb = New System.Windows.Forms.Label()
            Me.arrow_1 = New System.Windows.Forms.PictureBox()
            Me.arrow_2 = New System.Windows.Forms.PictureBox()
            Me.arrow_3 = New System.Windows.Forms.PictureBox()
            Me.arab_cb = New System.Windows.Forms.CheckBox()
            Me.form_head = New System.Windows.Forms.MenuStrip()
            Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.minimize_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.wincrypttitle = New System.Windows.Forms.Label()
            Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
            Me.algo_cb = New System.Windows.Forms.ComboBox()
            CType(Me.TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arrow_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arrow_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arrow_3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.form_head.SuspendLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'text_input
            '
            Me.text_input.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.text_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.text_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.text_input.Location = New System.Drawing.Point(12, 66)
            Me.text_input.Multiline = True
            Me.text_input.Name = "text_input"
            Me.text_input.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.text_input.Size = New System.Drawing.Size(577, 136)
            Me.text_input.TabIndex = 0
            Me.text_input.Text = "Text eingabe"
            '
            'text_output
            '
            Me.text_output.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.text_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.text_output.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.text_output.Location = New System.Drawing.Point(12, 228)
            Me.text_output.Multiline = True
            Me.text_output.Name = "text_output"
            Me.text_output.ReadOnly = True
            Me.text_output.Size = New System.Drawing.Size(577, 164)
            Me.text_output.TabIndex = 1
            Me.text_output.Text = "Text ausgabe"
            '
            'encrypt_bt
            '
            Me.encrypt_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.encrypt_bt.Enabled = False
            Me.encrypt_bt.FlatAppearance.BorderSize = 0
            Me.encrypt_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.encrypt_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.encrypt_bt.Location = New System.Drawing.Point(497, 398)
            Me.encrypt_bt.Name = "encrypt_bt"
            Me.encrypt_bt.Size = New System.Drawing.Size(92, 23)
            Me.encrypt_bt.TabIndex = 5
            Me.encrypt_bt.Text = "Verschlüsseln"
            Me.encrypt_bt.UseVisualStyleBackColor = False
            '
            'password_txt
            '
            Me.password_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.password_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.password_txt.Location = New System.Drawing.Point(74, 400)
            Me.password_txt.Name = "password_txt"
            Me.password_txt.Size = New System.Drawing.Size(234, 22)
            Me.password_txt.TabIndex = 6
            Me.password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'password_lb
            '
            Me.password_lb.AutoSize = True
            Me.password_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.password_lb.Location = New System.Drawing.Point(12, 403)
            Me.password_lb.Name = "password_lb"
            Me.password_lb.Size = New System.Drawing.Size(56, 13)
            Me.password_lb.TabIndex = 7
            Me.password_lb.Text = "Passwort:"
            '
            'generate_bt
            '
            Me.generate_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.generate_bt.FlatAppearance.BorderSize = 0
            Me.generate_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.generate_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.generate_bt.Location = New System.Drawing.Point(314, 398)
            Me.generate_bt.Name = "generate_bt"
            Me.generate_bt.Size = New System.Drawing.Size(75, 23)
            Me.generate_bt.TabIndex = 8
            Me.generate_bt.Text = "Generieren"
            Me.generate_bt.UseVisualStyleBackColor = False
            '
            'decrypt_bt
            '
            Me.decrypt_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.decrypt_bt.Enabled = False
            Me.decrypt_bt.FlatAppearance.BorderSize = 0
            Me.decrypt_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.decrypt_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.decrypt_bt.Location = New System.Drawing.Point(497, 398)
            Me.decrypt_bt.Name = "decrypt_bt"
            Me.decrypt_bt.Size = New System.Drawing.Size(92, 23)
            Me.decrypt_bt.TabIndex = 9
            Me.decrypt_bt.Text = "Entschlüsseln"
            Me.decrypt_bt.UseVisualStyleBackColor = False
            Me.decrypt_bt.Visible = False
            '
            'TrackBar
            '
            Me.TrackBar.LargeChange = 2
            Me.TrackBar.Location = New System.Drawing.Point(269, 33)
            Me.TrackBar.Maximum = 1
            Me.TrackBar.Name = "TrackBar"
            Me.TrackBar.Size = New System.Drawing.Size(80, 45)
            Me.TrackBar.TabIndex = 2
            '
            'encrypt_lb
            '
            Me.encrypt_lb.AutoSize = True
            Me.encrypt_lb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.encrypt_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.encrypt_lb.Location = New System.Drawing.Point(159, 39)
            Me.encrypt_lb.Name = "encrypt_lb"
            Me.encrypt_lb.Size = New System.Drawing.Size(104, 17)
            Me.encrypt_lb.TabIndex = 10
            Me.encrypt_lb.Text = "Verschlüsseln >"
            '
            'decrypt_lb
            '
            Me.decrypt_lb.AutoSize = True
            Me.decrypt_lb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.decrypt_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.decrypt_lb.Location = New System.Drawing.Point(355, 40)
            Me.decrypt_lb.Name = "decrypt_lb"
            Me.decrypt_lb.Size = New System.Drawing.Size(104, 17)
            Me.decrypt_lb.TabIndex = 11
            Me.decrypt_lb.Text = "< Entschlüsseln"
            '
            'arrow_1
            '
            Me.arrow_1.Image = Global.Project_WinCrypt.My.Resources.Resources.arrowdown
            Me.arrow_1.Location = New System.Drawing.Point(12, 203)
            Me.arrow_1.Name = "arrow_1"
            Me.arrow_1.Size = New System.Drawing.Size(26, 19)
            Me.arrow_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.arrow_1.TabIndex = 12
            Me.arrow_1.TabStop = False
            '
            'arrow_2
            '
            Me.arrow_2.Image = Global.Project_WinCrypt.My.Resources.Resources.arrowdown
            Me.arrow_2.Location = New System.Drawing.Point(282, 203)
            Me.arrow_2.Name = "arrow_2"
            Me.arrow_2.Size = New System.Drawing.Size(26, 19)
            Me.arrow_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.arrow_2.TabIndex = 13
            Me.arrow_2.TabStop = False
            '
            'arrow_3
            '
            Me.arrow_3.Image = Global.Project_WinCrypt.My.Resources.Resources.arrowdown
            Me.arrow_3.Location = New System.Drawing.Point(563, 203)
            Me.arrow_3.Name = "arrow_3"
            Me.arrow_3.Size = New System.Drawing.Size(26, 19)
            Me.arrow_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.arrow_3.TabIndex = 14
            Me.arrow_3.TabStop = False
            '
            'arab_cb
            '
            Me.arab_cb.AutoSize = True
            Me.arab_cb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.arab_cb.Location = New System.Drawing.Point(533, 43)
            Me.arab_cb.Name = "arab_cb"
            Me.arab_cb.Size = New System.Drawing.Size(58, 17)
            Me.arab_cb.TabIndex = 15
            Me.arab_cb.Text = "العربية"
            Me.arab_cb.UseVisualStyleBackColor = True
            '
            'form_head
            '
            Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt, Me.minimize_bt})
            Me.form_head.Location = New System.Drawing.Point(0, 0)
            Me.form_head.Name = "form_head"
            Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.form_head.Size = New System.Drawing.Size(601, 27)
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
            Me.wincrypttitle.Size = New System.Drawing.Size(118, 17)
            Me.wincrypttitle.TabIndex = 17
            Me.wincrypttitle.Text = "Passwortgenerator"
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
            'algo_cb
            '
            Me.algo_cb.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.algo_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.algo_cb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.algo_cb.FormattingEnabled = True
            Me.algo_cb.Items.AddRange(New Object() {"AES", "RC4"})
            Me.algo_cb.Location = New System.Drawing.Point(12, 39)
            Me.algo_cb.Name = "algo_cb"
            Me.algo_cb.Size = New System.Drawing.Size(51, 21)
            Me.algo_cb.TabIndex = 19
            Me.algo_cb.Text = "AES"
            '
            'Textencrypt
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(601, 430)
            Me.Controls.Add(Me.algo_cb)
            Me.Controls.Add(Me.wincrypt_icon)
            Me.Controls.Add(Me.wincrypttitle)
            Me.Controls.Add(Me.form_head)
            Me.Controls.Add(Me.arab_cb)
            Me.Controls.Add(Me.arrow_3)
            Me.Controls.Add(Me.arrow_2)
            Me.Controls.Add(Me.arrow_1)
            Me.Controls.Add(Me.decrypt_lb)
            Me.Controls.Add(Me.encrypt_lb)
            Me.Controls.Add(Me.decrypt_bt)
            Me.Controls.Add(Me.generate_bt)
            Me.Controls.Add(Me.password_lb)
            Me.Controls.Add(Me.password_txt)
            Me.Controls.Add(Me.encrypt_bt)
            Me.Controls.Add(Me.text_output)
            Me.Controls.Add(Me.text_input)
            Me.Controls.Add(Me.TrackBar)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Textencrypt"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Text verschlüsseln"
            CType(Me.TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arrow_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arrow_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arrow_3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.form_head.ResumeLayout(False)
            Me.form_head.PerformLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents text_input As System.Windows.Forms.TextBox
        Friend WithEvents text_output As System.Windows.Forms.TextBox
        Friend WithEvents encrypt_bt As System.Windows.Forms.Button
        Friend WithEvents password_txt As System.Windows.Forms.TextBox
        Friend WithEvents password_lb As System.Windows.Forms.Label
        Friend WithEvents generate_bt As System.Windows.Forms.Button
        Friend WithEvents decrypt_bt As System.Windows.Forms.Button
        Friend WithEvents TrackBar As System.Windows.Forms.TrackBar
        Friend WithEvents encrypt_lb As System.Windows.Forms.Label
        Friend WithEvents decrypt_lb As System.Windows.Forms.Label
        Friend WithEvents arrow_1 As System.Windows.Forms.PictureBox
        Friend WithEvents arrow_2 As System.Windows.Forms.PictureBox
        Friend WithEvents arrow_3 As System.Windows.Forms.PictureBox
        Friend WithEvents arab_cb As System.Windows.Forms.CheckBox
        Friend WithEvents form_head As System.Windows.Forms.MenuStrip
        Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents minimize_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents wincrypttitle As System.Windows.Forms.Label
        Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
        Friend WithEvents algo_cb As System.Windows.Forms.ComboBox
    End Class
End Namespace