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
        Me.specialchar = New System.Windows.Forms.CheckBox()
        Me.uppercasecb = New System.Windows.Forms.CheckBox()
        Me.lowercasecb = New System.Windows.Forms.CheckBox()
        Me.numberscb = New System.Windows.Forms.CheckBox()
        Me.generatetxt = New System.Windows.Forms.TextBox()
        Me.copybt = New System.Windows.Forms.Button()
        Me.attachments = New System.Windows.Forms.CheckBox()
        Me.saveas_bt = New System.Windows.Forms.Button()
        Me.save_pw_dialog = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.length = New System.Windows.Forms.MaskedTextBox()
        Me.lines = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'generatebt
        '
        Me.generatebt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.generatebt.FlatAppearance.BorderSize = 0
        Me.generatebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generatebt.Location = New System.Drawing.Point(495, 335)
        Me.generatebt.Name = "generatebt"
        Me.generatebt.Size = New System.Drawing.Size(75, 27)
        Me.generatebt.TabIndex = 3
        Me.generatebt.Text = "generate"
        Me.generatebt.UseVisualStyleBackColor = False
        '
        'specialchar
        '
        Me.specialchar.AutoSize = True
        Me.specialchar.Checked = True
        Me.specialchar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.specialchar.Location = New System.Drawing.Point(12, 255)
        Me.specialchar.Name = "specialchar"
        Me.specialchar.Size = New System.Drawing.Size(98, 19)
        Me.specialchar.TabIndex = 4
        Me.specialchar.Text = "special char"
        Me.specialchar.UseVisualStyleBackColor = True
        '
        'uppercasecb
        '
        Me.uppercasecb.AutoSize = True
        Me.uppercasecb.Checked = True
        Me.uppercasecb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uppercasecb.Location = New System.Drawing.Point(12, 281)
        Me.uppercasecb.Name = "uppercasecb"
        Me.uppercasecb.Size = New System.Drawing.Size(80, 19)
        Me.uppercasecb.TabIndex = 5
        Me.uppercasecb.Text = "uppercase"
        Me.uppercasecb.UseVisualStyleBackColor = True
        '
        'lowercasecb
        '
        Me.lowercasecb.AutoSize = True
        Me.lowercasecb.Checked = True
        Me.lowercasecb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.lowercasecb.Location = New System.Drawing.Point(12, 308)
        Me.lowercasecb.Name = "lowercasecb"
        Me.lowercasecb.Size = New System.Drawing.Size(80, 19)
        Me.lowercasecb.TabIndex = 6
        Me.lowercasecb.Text = "lowercase"
        Me.lowercasecb.UseVisualStyleBackColor = True
        '
        'numberscb
        '
        Me.numberscb.AutoSize = True
        Me.numberscb.Checked = True
        Me.numberscb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.numberscb.Location = New System.Drawing.Point(12, 335)
        Me.numberscb.Name = "numberscb"
        Me.numberscb.Size = New System.Drawing.Size(68, 19)
        Me.numberscb.TabIndex = 7
        Me.numberscb.Text = "numbers"
        Me.numberscb.UseVisualStyleBackColor = True
        '
        'generatetxt
        '
        Me.generatetxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.generatetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.generatetxt.ForeColor = System.Drawing.Color.White
        Me.generatetxt.Location = New System.Drawing.Point(12, 14)
        Me.generatetxt.Multiline = True
        Me.generatetxt.Name = "generatetxt"
        Me.generatetxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.generatetxt.Size = New System.Drawing.Size(558, 230)
        Me.generatetxt.TabIndex = 8
        '
        'copybt
        '
        Me.copybt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.copybt.Enabled = False
        Me.copybt.FlatAppearance.BorderSize = 0
        Me.copybt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copybt.Location = New System.Drawing.Point(414, 335)
        Me.copybt.Name = "copybt"
        Me.copybt.Size = New System.Drawing.Size(75, 27)
        Me.copybt.TabIndex = 11
        Me.copybt.Text = "copy"
        Me.copybt.UseVisualStyleBackColor = False
        '
        'attachments
        '
        Me.attachments.AutoSize = True
        Me.attachments.Location = New System.Drawing.Point(480, 285)
        Me.attachments.Name = "attachments"
        Me.attachments.Size = New System.Drawing.Size(98, 19)
        Me.attachments.TabIndex = 12
        Me.attachments.Text = "attachments?"
        Me.attachments.UseVisualStyleBackColor = True
        Me.attachments.Visible = False
        '
        'saveas_bt
        '
        Me.saveas_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.saveas_bt.FlatAppearance.BorderSize = 0
        Me.saveas_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveas_bt.Location = New System.Drawing.Point(495, 250)
        Me.saveas_bt.Name = "saveas_bt"
        Me.saveas_bt.Size = New System.Drawing.Size(75, 27)
        Me.saveas_bt.TabIndex = 13
        Me.saveas_bt.Text = "save as..."
        Me.saveas_bt.UseVisualStyleBackColor = False
        Me.saveas_bt.Visible = False
        '
        'save_pw_dialog
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "lines:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "length:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(233, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(265, 306)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'length
        '
        Me.length.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.length.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.length.ForeColor = System.Drawing.Color.White
        Me.length.HidePromptOnLeave = True
        Me.length.Location = New System.Drawing.Point(188, 335)
        Me.length.Mask = "00000"
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(39, 18)
        Me.length.TabIndex = 18
        Me.length.Text = "16"
        Me.length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lines
        '
        Me.lines.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lines.ForeColor = System.Drawing.Color.White
        Me.lines.HidePromptOnLeave = True
        Me.lines.Location = New System.Drawing.Point(188, 307)
        Me.lines.Mask = "00000"
        Me.lines.Name = "lines"
        Me.lines.Size = New System.Drawing.Size(39, 18)
        Me.lines.TabIndex = 19
        Me.lines.Text = "1"
        Me.lines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'passwordgenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(582, 383)
        Me.Controls.Add(Me.lines)
        Me.Controls.Add(Me.length)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.saveas_bt)
        Me.Controls.Add(Me.attachments)
        Me.Controls.Add(Me.copybt)
        Me.Controls.Add(Me.generatetxt)
        Me.Controls.Add(Me.numberscb)
        Me.Controls.Add(Me.lowercasecb)
        Me.Controls.Add(Me.uppercasecb)
        Me.Controls.Add(Me.specialchar)
        Me.Controls.Add(Me.generatebt)
        Me.Font = New System.Drawing.Font("Ubuntu Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "passwordgenerator"
        Me.Text = "passwordgenerator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents generatebt As System.Windows.Forms.Button
    Friend WithEvents specialchar As System.Windows.Forms.CheckBox
    Friend WithEvents uppercasecb As System.Windows.Forms.CheckBox
    Friend WithEvents lowercasecb As System.Windows.Forms.CheckBox
    Friend WithEvents numberscb As System.Windows.Forms.CheckBox
    Friend WithEvents generatetxt As System.Windows.Forms.TextBox
    Friend WithEvents copybt As System.Windows.Forms.Button
    Friend WithEvents attachments As System.Windows.Forms.CheckBox
    Friend WithEvents saveas_bt As System.Windows.Forms.Button
    Friend WithEvents save_pw_dialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents length As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lines As System.Windows.Forms.MaskedTextBox
End Class
