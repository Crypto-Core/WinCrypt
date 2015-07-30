Namespace tools.passwordmanager
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class passwordmanager_add
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(passwordmanager_add))
            Me.user_txt = New System.Windows.Forms.TextBox()
            Me.password_txt = New System.Windows.Forms.TextBox()
            Me.source_txt = New System.Windows.Forms.TextBox()
            Me.comment_txt = New System.Windows.Forms.TextBox()
            Me.add_bt = New System.Windows.Forms.Button()
            Me.user_lb = New System.Windows.Forms.Label()
            Me.password_lb = New System.Windows.Forms.Label()
            Me.source_lb = New System.Windows.Forms.Label()
            Me.comment_lb = New System.Windows.Forms.Label()
            Me.form_head = New System.Windows.Forms.MenuStrip()
            Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.wincrypttitle = New System.Windows.Forms.Label()
            Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
            Me.form_head.SuspendLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'user_txt
            '
            Me.user_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.user_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.user_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.user_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.user_txt.Location = New System.Drawing.Point(69, 47)
            Me.user_txt.Name = "user_txt"
            Me.user_txt.Size = New System.Drawing.Size(256, 22)
            Me.user_txt.TabIndex = 0
            '
            'password_txt
            '
            Me.password_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.password_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.password_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.password_txt.Location = New System.Drawing.Point(70, 73)
            Me.password_txt.Name = "password_txt"
            Me.password_txt.Size = New System.Drawing.Size(255, 22)
            Me.password_txt.TabIndex = 1
            '
            'source_txt
            '
            Me.source_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.source_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.source_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.source_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.source_txt.Location = New System.Drawing.Point(70, 99)
            Me.source_txt.Name = "source_txt"
            Me.source_txt.Size = New System.Drawing.Size(255, 22)
            Me.source_txt.TabIndex = 2
            '
            'comment_txt
            '
            Me.comment_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.comment_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.comment_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.comment_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.comment_txt.Location = New System.Drawing.Point(12, 143)
            Me.comment_txt.Multiline = True
            Me.comment_txt.Name = "comment_txt"
            Me.comment_txt.Size = New System.Drawing.Size(314, 171)
            Me.comment_txt.TabIndex = 3
            '
            'add_bt
            '
            Me.add_bt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.add_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.add_bt.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.add_bt.FlatAppearance.BorderSize = 0
            Me.add_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.add_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.add_bt.Location = New System.Drawing.Point(131, 320)
            Me.add_bt.Name = "add_bt"
            Me.add_bt.Size = New System.Drawing.Size(83, 23)
            Me.add_bt.TabIndex = 4
            Me.add_bt.Text = "Hinzufügen"
            Me.add_bt.UseVisualStyleBackColor = False
            '
            'user_lb
            '
            Me.user_lb.AutoSize = True
            Me.user_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.user_lb.Location = New System.Drawing.Point(11, 50)
            Me.user_lb.Name = "user_lb"
            Me.user_lb.Size = New System.Drawing.Size(56, 13)
            Me.user_lb.TabIndex = 5
            Me.user_lb.Text = "Benutzer:"
            '
            'password_lb
            '
            Me.password_lb.AutoSize = True
            Me.password_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.password_lb.Location = New System.Drawing.Point(11, 76)
            Me.password_lb.Name = "password_lb"
            Me.password_lb.Size = New System.Drawing.Size(56, 13)
            Me.password_lb.TabIndex = 6
            Me.password_lb.Text = "Passwort:"
            '
            'source_lb
            '
            Me.source_lb.AutoSize = True
            Me.source_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.source_lb.Location = New System.Drawing.Point(12, 102)
            Me.source_lb.Name = "source_lb"
            Me.source_lb.Size = New System.Drawing.Size(43, 13)
            Me.source_lb.TabIndex = 7
            Me.source_lb.Text = "Quelle:"
            '
            'comment_lb
            '
            Me.comment_lb.AutoSize = True
            Me.comment_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.comment_lb.Location = New System.Drawing.Point(12, 127)
            Me.comment_lb.Name = "comment_lb"
            Me.comment_lb.Size = New System.Drawing.Size(65, 13)
            Me.comment_lb.TabIndex = 8
            Me.comment_lb.Text = "Kommentar"
            '
            'form_head
            '
            Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt})
            Me.form_head.Location = New System.Drawing.Point(0, 0)
            Me.form_head.Name = "form_head"
            Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.form_head.Size = New System.Drawing.Size(338, 24)
            Me.form_head.TabIndex = 13
            Me.form_head.Text = "WinCrypt"
            '
            'exit_bt
            '
            Me.exit_bt.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.exit_bt.ForeColor = System.Drawing.Color.White
            Me.exit_bt.Name = "exit_bt"
            Me.exit_bt.Size = New System.Drawing.Size(29, 20)
            Me.exit_bt.Text = "X"
            '
            'wincrypttitle
            '
            Me.wincrypttitle.AutoSize = True
            Me.wincrypttitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.wincrypttitle.Location = New System.Drawing.Point(34, 6)
            Me.wincrypttitle.Name = "wincrypttitle"
            Me.wincrypttitle.Size = New System.Drawing.Size(73, 17)
            Me.wincrypttitle.TabIndex = 14
            Me.wincrypttitle.Text = "Hinzufügen"
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
            'passwordmanager_add
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(338, 355)
            Me.Controls.Add(Me.wincrypt_icon)
            Me.Controls.Add(Me.wincrypttitle)
            Me.Controls.Add(Me.form_head)
            Me.Controls.Add(Me.comment_lb)
            Me.Controls.Add(Me.source_lb)
            Me.Controls.Add(Me.password_lb)
            Me.Controls.Add(Me.user_lb)
            Me.Controls.Add(Me.add_bt)
            Me.Controls.Add(Me.comment_txt)
            Me.Controls.Add(Me.source_txt)
            Me.Controls.Add(Me.password_txt)
            Me.Controls.Add(Me.user_txt)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimumSize = New System.Drawing.Size(295, 218)
            Me.Name = "passwordmanager_add"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Passwortmanager - Hinzufügen"
            Me.form_head.ResumeLayout(False)
            Me.form_head.PerformLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents user_txt As System.Windows.Forms.TextBox
        Friend WithEvents password_txt As System.Windows.Forms.TextBox
        Friend WithEvents source_txt As System.Windows.Forms.TextBox
        Friend WithEvents comment_txt As System.Windows.Forms.TextBox
        Friend WithEvents add_bt As System.Windows.Forms.Button
        Friend WithEvents user_lb As System.Windows.Forms.Label
        Friend WithEvents password_lb As System.Windows.Forms.Label
        Friend WithEvents source_lb As System.Windows.Forms.Label
        Friend WithEvents comment_lb As System.Windows.Forms.Label
        Friend WithEvents form_head As System.Windows.Forms.MenuStrip
        Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents wincrypttitle As System.Windows.Forms.Label
        Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
    End Class
End Namespace