<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Masterkey
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Masterkey))
        Me.key_txt = New System.Windows.Forms.TextBox()
        Me.key_lb = New System.Windows.Forms.Label()
        Me.ok_bt = New System.Windows.Forms.Button()
        Me.abort_bt = New System.Windows.Forms.Button()
        Me.key_pic = New System.Windows.Forms.PictureBox()
        Me.form_head = New System.Windows.Forms.MenuStrip()
        Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        CType(Me.key_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.form_head.SuspendLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'key_txt
        '
        Me.key_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.key_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.key_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.key_txt.Location = New System.Drawing.Point(13, 116)
        Me.key_txt.Name = "key_txt"
        Me.key_txt.Size = New System.Drawing.Size(266, 22)
        Me.key_txt.TabIndex = 0
        Me.key_txt.UseSystemPasswordChar = True
        '
        'key_lb
        '
        Me.key_lb.AutoSize = True
        Me.key_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.key_lb.Location = New System.Drawing.Point(10, 100)
        Me.key_lb.Name = "key_lb"
        Me.key_lb.Size = New System.Drawing.Size(62, 13)
        Me.key_lb.TabIndex = 1
        Me.key_lb.Text = "Masterkey:"
        '
        'ok_bt
        '
        Me.ok_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ok_bt.FlatAppearance.BorderSize = 0
        Me.ok_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ok_bt.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ok_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ok_bt.Location = New System.Drawing.Point(13, 142)
        Me.ok_bt.Name = "ok_bt"
        Me.ok_bt.Size = New System.Drawing.Size(75, 23)
        Me.ok_bt.TabIndex = 2
        Me.ok_bt.Text = "OK"
        Me.ok_bt.UseVisualStyleBackColor = False
        '
        'abort_bt
        '
        Me.abort_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.abort_bt.FlatAppearance.BorderSize = 0
        Me.abort_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abort_bt.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.abort_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.abort_bt.Location = New System.Drawing.Point(204, 142)
        Me.abort_bt.Name = "abort_bt"
        Me.abort_bt.Size = New System.Drawing.Size(75, 23)
        Me.abort_bt.TabIndex = 3
        Me.abort_bt.Text = "Abbrechen"
        Me.abort_bt.UseVisualStyleBackColor = False
        '
        'key_pic
        '
        Me.key_pic.Image = Global.Project_WinCrypt.My.Resources.Resources.key2
        Me.key_pic.Location = New System.Drawing.Point(87, 37)
        Me.key_pic.Name = "key_pic"
        Me.key_pic.Size = New System.Drawing.Size(127, 60)
        Me.key_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.key_pic.TabIndex = 4
        Me.key_pic.TabStop = False
        '
        'form_head
        '
        Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt})
        Me.form_head.Location = New System.Drawing.Point(0, 0)
        Me.form_head.Name = "form_head"
        Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.form_head.Size = New System.Drawing.Size(290, 24)
        Me.form_head.TabIndex = 13
        Me.form_head.Text = "MenuStrip1"
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
        Me.wincrypttitle.Size = New System.Drawing.Size(68, 17)
        Me.wincrypttitle.TabIndex = 15
        Me.wincrypttitle.Text = "Masterkey"
        '
        'Masterkey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(290, 174)
        Me.Controls.Add(Me.wincrypt_icon)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.form_head)
        Me.Controls.Add(Me.key_pic)
        Me.Controls.Add(Me.abort_bt)
        Me.Controls.Add(Me.ok_bt)
        Me.Controls.Add(Me.key_lb)
        Me.Controls.Add(Me.key_txt)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Masterkey"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Masterkey"
        CType(Me.key_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.form_head.ResumeLayout(False)
        Me.form_head.PerformLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents key_txt As System.Windows.Forms.TextBox
    Friend WithEvents key_lb As System.Windows.Forms.Label
    Friend WithEvents ok_bt As System.Windows.Forms.Button
    Friend WithEvents abort_bt As System.Windows.Forms.Button
    Friend WithEvents key_pic As System.Windows.Forms.PictureBox
    Friend WithEvents form_head As System.Windows.Forms.MenuStrip
    Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
End Class
