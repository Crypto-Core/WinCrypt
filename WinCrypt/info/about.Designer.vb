<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(about))
        Me.product_lb = New System.Windows.Forms.Label()
        Me.ok_bt = New System.Windows.Forms.Button()
        Me.version_lb = New System.Windows.Forms.Label()
        Me.copyright_lb = New System.Windows.Forms.Label()
        Me.gpl_txt = New System.Windows.Forms.RichTextBox()
        Me.wincrypt_logo = New System.Windows.Forms.PictureBox()
        Me.dev_txt = New System.Windows.Forms.RichTextBox()
        Me.form_head = New System.Windows.Forms.MenuStrip()
        Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        CType(Me.wincrypt_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.form_head.SuspendLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'product_lb
        '
        Me.product_lb.AutoSize = True
        Me.product_lb.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.product_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.product_lb.Location = New System.Drawing.Point(127, 161)
        Me.product_lb.Name = "product_lb"
        Me.product_lb.Size = New System.Drawing.Size(166, 23)
        Me.product_lb.TabIndex = 1
        Me.product_lb.Text = "WinCrypt 1.2"
        '
        'ok_bt
        '
        Me.ok_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ok_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ok_bt.FlatAppearance.BorderSize = 0
        Me.ok_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ok_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ok_bt.Location = New System.Drawing.Point(276, 465)
        Me.ok_bt.Name = "ok_bt"
        Me.ok_bt.Size = New System.Drawing.Size(134, 23)
        Me.ok_bt.TabIndex = 4
        Me.ok_bt.Text = "OK"
        Me.ok_bt.UseVisualStyleBackColor = False
        '
        'version_lb
        '
        Me.version_lb.AutoSize = True
        Me.version_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.version_lb.Location = New System.Drawing.Point(168, 183)
        Me.version_lb.Name = "version_lb"
        Me.version_lb.Size = New System.Drawing.Size(87, 13)
        Me.version_lb.TabIndex = 5
        Me.version_lb.Text = "(Version 0.0.0.0)"
        '
        'copyright_lb
        '
        Me.copyright_lb.AutoSize = True
        Me.copyright_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.copyright_lb.Location = New System.Drawing.Point(6, 470)
        Me.copyright_lb.Name = "copyright_lb"
        Me.copyright_lb.Size = New System.Drawing.Size(203, 13)
        Me.copyright_lb.TabIndex = 7
        Me.copyright_lb.Text = "Copyright (C) [Jahr]  [Name des Autors]"
        '
        'gpl_txt
        '
        Me.gpl_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.gpl_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gpl_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.gpl_txt.Location = New System.Drawing.Point(10, 275)
        Me.gpl_txt.Name = "gpl_txt"
        Me.gpl_txt.ReadOnly = True
        Me.gpl_txt.Size = New System.Drawing.Size(400, 185)
        Me.gpl_txt.TabIndex = 8
        Me.gpl_txt.Text = resources.GetString("gpl_txt.Text")
        '
        'wincrypt_logo
        '
        Me.wincrypt_logo.Image = Global.Project_WinCrypt.My.Resources.Resources.wc_icon128
        Me.wincrypt_logo.Location = New System.Drawing.Point(146, 28)
        Me.wincrypt_logo.Name = "wincrypt_logo"
        Me.wincrypt_logo.Size = New System.Drawing.Size(128, 128)
        Me.wincrypt_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.wincrypt_logo.TabIndex = 9
        Me.wincrypt_logo.TabStop = False
        '
        'dev_txt
        '
        Me.dev_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.dev_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dev_txt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dev_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dev_txt.Location = New System.Drawing.Point(10, 200)
        Me.dev_txt.Name = "dev_txt"
        Me.dev_txt.ReadOnly = True
        Me.dev_txt.Size = New System.Drawing.Size(400, 69)
        Me.dev_txt.TabIndex = 10
        Me.dev_txt.Text = "Harry Machura, Ruben Gasda"
        '
        'form_head
        '
        Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt})
        Me.form_head.Location = New System.Drawing.Point(0, 0)
        Me.form_head.Name = "form_head"
        Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.form_head.Size = New System.Drawing.Size(420, 24)
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
        'wincrypt_icon
        '
        Me.wincrypt_icon.Image = Global.Project_WinCrypt.My.Resources.Resources.wc_icon16
        Me.wincrypt_icon.Location = New System.Drawing.Point(9, 6)
        Me.wincrypt_icon.Name = "wincrypt_icon"
        Me.wincrypt_icon.Size = New System.Drawing.Size(16, 16)
        Me.wincrypt_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wincrypt_icon.TabIndex = 14
        Me.wincrypt_icon.TabStop = False
        '
        'wincrypttitle
        '
        Me.wincrypttitle.AutoSize = True
        Me.wincrypttitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.wincrypttitle.Location = New System.Drawing.Point(34, 6)
        Me.wincrypttitle.Name = "wincrypttitle"
        Me.wincrypttitle.Size = New System.Drawing.Size(43, 17)
        Me.wincrypttitle.TabIndex = 15
        Me.wincrypttitle.Text = "About"
        '
        'about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 493)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.wincrypt_icon)
        Me.Controls.Add(Me.form_head)
        Me.Controls.Add(Me.dev_txt)
        Me.Controls.Add(Me.wincrypt_logo)
        Me.Controls.Add(Me.gpl_txt)
        Me.Controls.Add(Me.copyright_lb)
        Me.Controls.Add(Me.version_lb)
        Me.Controls.Add(Me.ok_bt)
        Me.Controls.Add(Me.product_lb)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "about"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        CType(Me.wincrypt_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.form_head.ResumeLayout(False)
        Me.form_head.PerformLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents product_lb As System.Windows.Forms.Label
    Friend WithEvents ok_bt As System.Windows.Forms.Button
    Friend WithEvents version_lb As System.Windows.Forms.Label
    Friend WithEvents copyright_lb As System.Windows.Forms.Label
    Friend WithEvents gpl_txt As System.Windows.Forms.RichTextBox
    Friend WithEvents wincrypt_logo As System.Windows.Forms.PictureBox
    Friend WithEvents dev_txt As System.Windows.Forms.RichTextBox
    Friend WithEvents form_head As System.Windows.Forms.MenuStrip
    Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
End Class
