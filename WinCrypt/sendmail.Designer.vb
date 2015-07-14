<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sendmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sendmail))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.emailto_txt = New System.Windows.Forms.TextBox()
        Me.subject_txt = New System.Windows.Forms.TextBox()
        Me.message_txt = New System.Windows.Forms.TextBox()
        Me.server_txt = New System.Windows.Forms.TextBox()
        Me.file_txt = New System.Windows.Forms.TextBox()
        Me.file_bt = New System.Windows.Forms.Button()
        Me.sendmail_bt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.email_lb = New System.Windows.Forms.Label()
        Me.emailto_lb = New System.Windows.Forms.Label()
        Me.subject_lb = New System.Windows.Forms.Label()
        Me.password_lb = New System.Windows.Forms.Label()
        Me.server_lb = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'email_txt
        '
        Me.email_txt.Location = New System.Drawing.Point(65, 12)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(139, 20)
        Me.email_txt.TabIndex = 0
        '
        'password_txt
        '
        Me.password_txt.Location = New System.Drawing.Point(284, 12)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(148, 20)
        Me.password_txt.TabIndex = 1
        Me.password_txt.UseSystemPasswordChar = True
        '
        'emailto_txt
        '
        Me.emailto_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emailto_txt.Location = New System.Drawing.Point(79, 56)
        Me.emailto_txt.Name = "emailto_txt"
        Me.emailto_txt.Size = New System.Drawing.Size(662, 20)
        Me.emailto_txt.TabIndex = 2
        '
        'subject_txt
        '
        Me.subject_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.subject_txt.Location = New System.Drawing.Point(65, 82)
        Me.subject_txt.Name = "subject_txt"
        Me.subject_txt.Size = New System.Drawing.Size(676, 20)
        Me.subject_txt.TabIndex = 3
        '
        'message_txt
        '
        Me.message_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.message_txt.Location = New System.Drawing.Point(15, 108)
        Me.message_txt.Multiline = True
        Me.message_txt.Name = "message_txt"
        Me.message_txt.Size = New System.Drawing.Size(726, 302)
        Me.message_txt.TabIndex = 4
        '
        'server_txt
        '
        Me.server_txt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.server_txt.Location = New System.Drawing.Point(641, 12)
        Me.server_txt.Name = "server_txt"
        Me.server_txt.Size = New System.Drawing.Size(100, 20)
        Me.server_txt.TabIndex = 5
        '
        'file_txt
        '
        Me.file_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.file_txt.Location = New System.Drawing.Point(65, 416)
        Me.file_txt.Name = "file_txt"
        Me.file_txt.Size = New System.Drawing.Size(387, 20)
        Me.file_txt.TabIndex = 6
        '
        'file_bt
        '
        Me.file_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.file_bt.Location = New System.Drawing.Point(458, 414)
        Me.file_bt.Name = "file_bt"
        Me.file_bt.Size = New System.Drawing.Size(75, 23)
        Me.file_bt.TabIndex = 7
        Me.file_bt.Text = "Öffnen"
        Me.file_bt.UseVisualStyleBackColor = True
        '
        'sendmail_bt
        '
        Me.sendmail_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sendmail_bt.Location = New System.Drawing.Point(666, 414)
        Me.sendmail_bt.Name = "sendmail_bt"
        Me.sendmail_bt.Size = New System.Drawing.Size(75, 23)
        Me.sendmail_bt.TabIndex = 8
        Me.sendmail_bt.Text = "Senden"
        Me.sendmail_bt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 419)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Anhang:"
        '
        'email_lb
        '
        Me.email_lb.AutoSize = True
        Me.email_lb.Location = New System.Drawing.Point(12, 15)
        Me.email_lb.Name = "email_lb"
        Me.email_lb.Size = New System.Drawing.Size(39, 13)
        Me.email_lb.TabIndex = 10
        Me.email_lb.Text = "E-Mail:"
        '
        'emailto_lb
        '
        Me.emailto_lb.AutoSize = True
        Me.emailto_lb.Location = New System.Drawing.Point(12, 59)
        Me.emailto_lb.Name = "emailto_lb"
        Me.emailto_lb.Size = New System.Drawing.Size(61, 13)
        Me.emailto_lb.TabIndex = 11
        Me.emailto_lb.Text = "Empfänger:"
        '
        'subject_lb
        '
        Me.subject_lb.AutoSize = True
        Me.subject_lb.Location = New System.Drawing.Point(12, 85)
        Me.subject_lb.Name = "subject_lb"
        Me.subject_lb.Size = New System.Drawing.Size(41, 13)
        Me.subject_lb.TabIndex = 12
        Me.subject_lb.Text = "Betreff:"
        '
        'password_lb
        '
        Me.password_lb.AutoSize = True
        Me.password_lb.Location = New System.Drawing.Point(225, 15)
        Me.password_lb.Name = "password_lb"
        Me.password_lb.Size = New System.Drawing.Size(53, 13)
        Me.password_lb.TabIndex = 13
        Me.password_lb.Text = "Passwort:"
        '
        'server_lb
        '
        Me.server_lb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.server_lb.AutoSize = True
        Me.server_lb.Location = New System.Drawing.Point(594, 15)
        Me.server_lb.Name = "server_lb"
        Me.server_lb.Size = New System.Drawing.Size(41, 13)
        Me.server_lb.TabIndex = 14
        Me.server_lb.Text = "Server:"
        '
        'sendmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 449)
        Me.Controls.Add(Me.server_lb)
        Me.Controls.Add(Me.password_lb)
        Me.Controls.Add(Me.subject_lb)
        Me.Controls.Add(Me.emailto_lb)
        Me.Controls.Add(Me.email_lb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sendmail_bt)
        Me.Controls.Add(Me.file_bt)
        Me.Controls.Add(Me.file_txt)
        Me.Controls.Add(Me.server_txt)
        Me.Controls.Add(Me.message_txt)
        Me.Controls.Add(Me.subject_txt)
        Me.Controls.Add(Me.emailto_txt)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.email_txt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(614, 407)
        Me.Name = "sendmail"
        Me.Text = "E-Mail Senden"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents email_txt As System.Windows.Forms.TextBox
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
    Friend WithEvents emailto_txt As System.Windows.Forms.TextBox
    Friend WithEvents subject_txt As System.Windows.Forms.TextBox
    Friend WithEvents message_txt As System.Windows.Forms.TextBox
    Friend WithEvents server_txt As System.Windows.Forms.TextBox
    Friend WithEvents file_txt As System.Windows.Forms.TextBox
    Friend WithEvents file_bt As System.Windows.Forms.Button
    Friend WithEvents sendmail_bt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents email_lb As System.Windows.Forms.Label
    Friend WithEvents emailto_lb As System.Windows.Forms.Label
    Friend WithEvents subject_lb As System.Windows.Forms.Label
    Friend WithEvents password_lb As System.Windows.Forms.Label
    Friend WithEvents server_lb As System.Windows.Forms.Label
End Class
