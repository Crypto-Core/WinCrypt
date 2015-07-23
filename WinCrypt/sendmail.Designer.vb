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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.file_bt1 = New System.Windows.Forms.Button()
        Me.file_txt1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.file_bt2 = New System.Windows.Forms.Button()
        Me.file_txt2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.file_bt3 = New System.Windows.Forms.Button()
        Me.file_txt3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
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
        Me.emailto_txt.Size = New System.Drawing.Size(675, 20)
        Me.emailto_txt.TabIndex = 2
        '
        'subject_txt
        '
        Me.subject_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.subject_txt.Location = New System.Drawing.Point(65, 82)
        Me.subject_txt.Name = "subject_txt"
        Me.subject_txt.Size = New System.Drawing.Size(689, 20)
        Me.subject_txt.TabIndex = 3
        '
        'message_txt
        '
        Me.message_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.message_txt.Location = New System.Drawing.Point(15, 108)
        Me.message_txt.Multiline = True
        Me.message_txt.Name = "message_txt"
        Me.message_txt.Size = New System.Drawing.Size(739, 216)
        Me.message_txt.TabIndex = 4
        '
        'server_txt
        '
        Me.server_txt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.server_txt.Location = New System.Drawing.Point(654, 12)
        Me.server_txt.Name = "server_txt"
        Me.server_txt.Size = New System.Drawing.Size(100, 20)
        Me.server_txt.TabIndex = 5
        '
        'file_txt
        '
        Me.file_txt.Location = New System.Drawing.Point(70, 332)
        Me.file_txt.Name = "file_txt"
        Me.file_txt.Size = New System.Drawing.Size(468, 20)
        Me.file_txt.TabIndex = 6
        '
        'file_bt
        '
        Me.file_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.file_bt.FlatAppearance.BorderSize = 0
        Me.file_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.file_bt.Location = New System.Drawing.Point(544, 330)
        Me.file_bt.Name = "file_bt"
        Me.file_bt.Size = New System.Drawing.Size(51, 23)
        Me.file_bt.TabIndex = 7
        Me.file_bt.Text = "Öffnen"
        Me.file_bt.UseVisualStyleBackColor = False
        '
        'sendmail_bt
        '
        Me.sendmail_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.sendmail_bt.FlatAppearance.BorderSize = 0
        Me.sendmail_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sendmail_bt.Location = New System.Drawing.Point(679, 330)
        Me.sendmail_bt.Name = "sendmail_bt"
        Me.sendmail_bt.Size = New System.Drawing.Size(75, 23)
        Me.sendmail_bt.TabIndex = 8
        Me.sendmail_bt.Text = "Senden"
        Me.sendmail_bt.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 335)
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
        Me.server_lb.Location = New System.Drawing.Point(607, 15)
        Me.server_lb.Name = "server_lb"
        Me.server_lb.Size = New System.Drawing.Size(41, 13)
        Me.server_lb.TabIndex = 14
        Me.server_lb.Text = "Server:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 364)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Anhang:"
        '
        'file_bt1
        '
        Me.file_bt1.BackColor = System.Drawing.Color.Gainsboro
        Me.file_bt1.FlatAppearance.BorderSize = 0
        Me.file_bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.file_bt1.Location = New System.Drawing.Point(544, 359)
        Me.file_bt1.Name = "file_bt1"
        Me.file_bt1.Size = New System.Drawing.Size(51, 23)
        Me.file_bt1.TabIndex = 16
        Me.file_bt1.Text = "Öffnen"
        Me.file_bt1.UseVisualStyleBackColor = False
        '
        'file_txt1
        '
        Me.file_txt1.Location = New System.Drawing.Point(70, 361)
        Me.file_txt1.Name = "file_txt1"
        Me.file_txt1.Size = New System.Drawing.Size(468, 20)
        Me.file_txt1.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 393)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Anhang:"
        '
        'file_bt2
        '
        Me.file_bt2.BackColor = System.Drawing.Color.Gainsboro
        Me.file_bt2.FlatAppearance.BorderSize = 0
        Me.file_bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.file_bt2.Location = New System.Drawing.Point(544, 388)
        Me.file_bt2.Name = "file_bt2"
        Me.file_bt2.Size = New System.Drawing.Size(51, 23)
        Me.file_bt2.TabIndex = 19
        Me.file_bt2.Text = "Öffnen"
        Me.file_bt2.UseVisualStyleBackColor = False
        '
        'file_txt2
        '
        Me.file_txt2.Location = New System.Drawing.Point(70, 390)
        Me.file_txt2.Name = "file_txt2"
        Me.file_txt2.Size = New System.Drawing.Size(468, 20)
        Me.file_txt2.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 422)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Anhang:"
        '
        'file_bt3
        '
        Me.file_bt3.BackColor = System.Drawing.Color.Gainsboro
        Me.file_bt3.FlatAppearance.BorderSize = 0
        Me.file_bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.file_bt3.Location = New System.Drawing.Point(544, 417)
        Me.file_bt3.Name = "file_bt3"
        Me.file_bt3.Size = New System.Drawing.Size(51, 23)
        Me.file_bt3.TabIndex = 22
        Me.file_bt3.Text = "Öffnen"
        Me.file_bt3.UseVisualStyleBackColor = False
        '
        'file_txt3
        '
        Me.file_txt3.Location = New System.Drawing.Point(70, 419)
        Me.file_txt3.Name = "file_txt3"
        Me.file_txt3.Size = New System.Drawing.Size(468, 20)
        Me.file_txt3.TabIndex = 21
        '
        'Button4
        '
        Me.Button4.Image = Global.Project_WinCrypt.My.Resources.Resources._1437704584_add
        Me.Button4.Location = New System.Drawing.Point(601, 330)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(26, 23)
        Me.Button4.TabIndex = 24
        Me.Button4.UseVisualStyleBackColor = True
        '
        'sendmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 453)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.file_bt3)
        Me.Controls.Add(Me.file_txt3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.file_bt2)
        Me.Controls.Add(Me.file_txt2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.file_bt1)
        Me.Controls.Add(Me.file_txt1)
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
        Me.Name = "sendmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents file_bt1 As System.Windows.Forms.Button
    Friend WithEvents file_txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents file_bt2 As System.Windows.Forms.Button
    Friend WithEvents file_txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents file_bt3 As System.Windows.Forms.Button
    Friend WithEvents file_txt3 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
