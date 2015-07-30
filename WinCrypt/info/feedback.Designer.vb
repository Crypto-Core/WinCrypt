<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class feedback
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(feedback))
        Me.name_txt = New System.Windows.Forms.TextBox()
        Me.mail_txt = New System.Windows.Forms.TextBox()
        Me.message_txt = New System.Windows.Forms.TextBox()
        Me.send_bt = New System.Windows.Forms.Button()
        Me.name_lb = New System.Windows.Forms.Label()
        Me.email_lb = New System.Windows.Forms.Label()
        Me.subject_lb = New System.Windows.Forms.Label()
        Me.message_lb = New System.Windows.Forms.Label()
        Me.subject_cb = New System.Windows.Forms.ComboBox()
        Me.form_head = New System.Windows.Forms.MenuStrip()
        Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.minimize_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.form_head.SuspendLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'name_txt
        '
        Me.name_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.name_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.name_txt.Location = New System.Drawing.Point(50, 37)
        Me.name_txt.Name = "name_txt"
        Me.name_txt.Size = New System.Drawing.Size(309, 22)
        Me.name_txt.TabIndex = 0
        '
        'mail_txt
        '
        Me.mail_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.mail_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mail_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.mail_txt.Location = New System.Drawing.Point(50, 65)
        Me.mail_txt.Name = "mail_txt"
        Me.mail_txt.Size = New System.Drawing.Size(309, 22)
        Me.mail_txt.TabIndex = 1
        '
        'message_txt
        '
        Me.message_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.message_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.message_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.message_txt.Location = New System.Drawing.Point(12, 147)
        Me.message_txt.Multiline = True
        Me.message_txt.Name = "message_txt"
        Me.message_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.message_txt.Size = New System.Drawing.Size(347, 187)
        Me.message_txt.TabIndex = 3
        '
        'send_bt
        '
        Me.send_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.send_bt.FlatAppearance.BorderSize = 0
        Me.send_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.send_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.send_bt.Location = New System.Drawing.Point(148, 340)
        Me.send_bt.Name = "send_bt"
        Me.send_bt.Size = New System.Drawing.Size(75, 23)
        Me.send_bt.TabIndex = 4
        Me.send_bt.Text = "Senden"
        Me.send_bt.UseVisualStyleBackColor = False
        '
        'name_lb
        '
        Me.name_lb.AutoSize = True
        Me.name_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.name_lb.Location = New System.Drawing.Point(9, 40)
        Me.name_lb.Name = "name_lb"
        Me.name_lb.Size = New System.Drawing.Size(36, 13)
        Me.name_lb.TabIndex = 5
        Me.name_lb.Text = "Name"
        '
        'email_lb
        '
        Me.email_lb.AutoSize = True
        Me.email_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.email_lb.Location = New System.Drawing.Point(9, 68)
        Me.email_lb.Name = "email_lb"
        Me.email_lb.Size = New System.Drawing.Size(39, 13)
        Me.email_lb.TabIndex = 6
        Me.email_lb.Text = "E-Mail"
        '
        'subject_lb
        '
        Me.subject_lb.AutoSize = True
        Me.subject_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.subject_lb.Location = New System.Drawing.Point(9, 94)
        Me.subject_lb.Name = "subject_lb"
        Me.subject_lb.Size = New System.Drawing.Size(42, 13)
        Me.subject_lb.TabIndex = 7
        Me.subject_lb.Text = "Betreff"
        '
        'message_lb
        '
        Me.message_lb.AutoSize = True
        Me.message_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.message_lb.Location = New System.Drawing.Point(9, 131)
        Me.message_lb.Name = "message_lb"
        Me.message_lb.Size = New System.Drawing.Size(56, 13)
        Me.message_lb.TabIndex = 8
        Me.message_lb.Text = "Nachricht"
        '
        'subject_cb
        '
        Me.subject_cb.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.subject_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subject_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subject_cb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.subject_cb.FormattingEnabled = True
        Me.subject_cb.Items.AddRange(New Object() {"Fehler", "Verbesserungsvorschlag", "Danksagung", "Hilfe", "anderes"})
        Me.subject_cb.Location = New System.Drawing.Point(50, 91)
        Me.subject_cb.Name = "subject_cb"
        Me.subject_cb.Size = New System.Drawing.Size(309, 21)
        Me.subject_cb.TabIndex = 0
        '
        'form_head
        '
        Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt, Me.minimize_bt})
        Me.form_head.Location = New System.Drawing.Point(0, 0)
        Me.form_head.Name = "form_head"
        Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.form_head.Size = New System.Drawing.Size(376, 27)
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
        Me.wincrypttitle.Size = New System.Drawing.Size(63, 17)
        Me.wincrypttitle.TabIndex = 15
        Me.wincrypttitle.Text = "Feedback"
        '
        'feedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(376, 372)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.wincrypt_icon)
        Me.Controls.Add(Me.form_head)
        Me.Controls.Add(Me.subject_cb)
        Me.Controls.Add(Me.message_lb)
        Me.Controls.Add(Me.subject_lb)
        Me.Controls.Add(Me.email_lb)
        Me.Controls.Add(Me.name_lb)
        Me.Controls.Add(Me.send_bt)
        Me.Controls.Add(Me.message_txt)
        Me.Controls.Add(Me.mail_txt)
        Me.Controls.Add(Me.name_txt)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "feedback"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WinCrypt - Feedback"
        Me.form_head.ResumeLayout(False)
        Me.form_head.PerformLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents name_txt As System.Windows.Forms.TextBox
    Friend WithEvents mail_txt As System.Windows.Forms.TextBox
    Friend WithEvents message_txt As System.Windows.Forms.TextBox
    Friend WithEvents send_bt As System.Windows.Forms.Button
    Friend WithEvents name_lb As System.Windows.Forms.Label
    Friend WithEvents email_lb As System.Windows.Forms.Label
    Friend WithEvents subject_lb As System.Windows.Forms.Label
    Friend WithEvents message_lb As System.Windows.Forms.Label
    Friend WithEvents subject_cb As System.Windows.Forms.ComboBox
    Friend WithEvents form_head As System.Windows.Forms.MenuStrip
    Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents minimize_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
End Class
