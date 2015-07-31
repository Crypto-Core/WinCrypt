<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Systemidentification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Systemidentification))
        Me.on_rb = New System.Windows.Forms.RadioButton()
        Me.off_rb = New System.Windows.Forms.RadioButton()
        Me.systemidentification_lb = New System.Windows.Forms.Label()
        Me.ok_bt = New System.Windows.Forms.Button()
        Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.form_head = New System.Windows.Forms.MenuStrip()
        Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.minimize_bt = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.form_head.SuspendLayout()
        Me.SuspendLayout()
        '
        'on_rb
        '
        Me.on_rb.AutoSize = True
        Me.on_rb.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.on_rb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.on_rb.Location = New System.Drawing.Point(262, 134)
        Me.on_rb.Name = "on_rb"
        Me.on_rb.Size = New System.Drawing.Size(84, 17)
        Me.on_rb.TabIndex = 0
        Me.on_rb.Text = "Einschalten"
        Me.on_rb.UseVisualStyleBackColor = False
        '
        'off_rb
        '
        Me.off_rb.AutoSize = True
        Me.off_rb.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.off_rb.Checked = True
        Me.off_rb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.off_rb.Location = New System.Drawing.Point(145, 134)
        Me.off_rb.Name = "off_rb"
        Me.off_rb.Size = New System.Drawing.Size(87, 17)
        Me.off_rb.TabIndex = 1
        Me.off_rb.TabStop = True
        Me.off_rb.Text = "Ausschalten"
        Me.off_rb.UseVisualStyleBackColor = False
        '
        'systemidentification_lb
        '
        Me.systemidentification_lb.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.systemidentification_lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.systemidentification_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.systemidentification_lb.Location = New System.Drawing.Point(18, 31)
        Me.systemidentification_lb.Margin = New System.Windows.Forms.Padding(7, 0, 3, 0)
        Me.systemidentification_lb.Name = "systemidentification_lb"
        Me.systemidentification_lb.Padding = New System.Windows.Forms.Padding(0, 0, 0, 40)
        Me.systemidentification_lb.Size = New System.Drawing.Size(438, 131)
        Me.systemidentification_lb.TabIndex = 2
        Me.systemidentification_lb.Text = resources.GetString("systemidentification_lb.Text")
        '
        'ok_bt
        '
        Me.ok_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ok_bt.FlatAppearance.BorderSize = 0
        Me.ok_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ok_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ok_bt.Location = New System.Drawing.Point(197, 171)
        Me.ok_bt.Name = "ok_bt"
        Me.ok_bt.Size = New System.Drawing.Size(75, 23)
        Me.ok_bt.TabIndex = 3
        Me.ok_bt.Text = "OK"
        Me.ok_bt.UseVisualStyleBackColor = False
        '
        'wincrypt_icon
        '
        Me.wincrypt_icon.Image = Global.Project_WinCrypt.My.Resources.Resources.wc_icon16
        Me.wincrypt_icon.Location = New System.Drawing.Point(9, 6)
        Me.wincrypt_icon.Name = "wincrypt_icon"
        Me.wincrypt_icon.Size = New System.Drawing.Size(16, 16)
        Me.wincrypt_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wincrypt_icon.TabIndex = 17
        Me.wincrypt_icon.TabStop = False
        '
        'wincrypttitle
        '
        Me.wincrypttitle.AutoSize = True
        Me.wincrypttitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.wincrypttitle.Location = New System.Drawing.Point(34, 6)
        Me.wincrypttitle.Name = "wincrypttitle"
        Me.wincrypttitle.Size = New System.Drawing.Size(123, 17)
        Me.wincrypttitle.TabIndex = 18
        Me.wincrypttitle.Text = "Systemidentifikation"
        '
        'form_head
        '
        Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt, Me.minimize_bt})
        Me.form_head.Location = New System.Drawing.Point(0, 0)
        Me.form_head.Name = "form_head"
        Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.form_head.Size = New System.Drawing.Size(468, 27)
        Me.form_head.TabIndex = 19
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
        'Systemidentification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(468, 202)
        Me.Controls.Add(Me.wincrypt_icon)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.ok_bt)
        Me.Controls.Add(Me.off_rb)
        Me.Controls.Add(Me.on_rb)
        Me.Controls.Add(Me.systemidentification_lb)
        Me.Controls.Add(Me.form_head)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Systemidentification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "systemidentification"
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.form_head.ResumeLayout(False)
        Me.form_head.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents on_rb As System.Windows.Forms.RadioButton
    Friend WithEvents off_rb As System.Windows.Forms.RadioButton
    Friend WithEvents systemidentification_lb As System.Windows.Forms.Label
    Friend WithEvents ok_bt As System.Windows.Forms.Button
    Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents form_head As System.Windows.Forms.MenuStrip
    Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents minimize_bt As System.Windows.Forms.ToolStripMenuItem
End Class
