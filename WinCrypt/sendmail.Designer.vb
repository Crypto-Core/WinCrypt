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
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.server_txt = New System.Windows.Forms.TextBox()
        Me.emailto_txt = New System.Windows.Forms.TextBox()
        Me.subject_txt = New System.Windows.Forms.TextBox()
        Me.message_txt = New System.Windows.Forms.TextBox()
        Me.file_txt = New System.Windows.Forms.TextBox()
        Me.file_txt1 = New System.Windows.Forms.TextBox()
        Me.file_txt2 = New System.Windows.Forms.TextBox()
        Me.file_txt3 = New System.Windows.Forms.TextBox()
        Me.email_lb = New System.Windows.Forms.Label()
        Me.password_lb = New System.Windows.Forms.Label()
        Me.server_lb = New System.Windows.Forms.Label()
        Me.emailto_lb = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.attachment_lb = New System.Windows.Forms.Label()
        Me.attachment_lb1 = New System.Windows.Forms.Label()
        Me.attachment_lb2 = New System.Windows.Forms.Label()
        Me.attachment_lb3 = New System.Windows.Forms.Label()
        Me.fileadd_bt = New System.Windows.Forms.Button()
        Me.fileadd_bt1 = New System.Windows.Forms.Button()
        Me.fileadd_bt2 = New System.Windows.Forms.Button()
        Me.fileadd_bt3 = New System.Windows.Forms.Button()
        Me.add_bt = New System.Windows.Forms.Button()
        Me.sendmail_bt = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.account_bt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'email_txt
        '
        Me.email_txt.Location = New System.Drawing.Point(54, 12)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(140, 20)
        Me.email_txt.TabIndex = 0
        '
        'password_txt
        '
        Me.password_txt.Location = New System.Drawing.Point(260, 12)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(145, 20)
        Me.password_txt.TabIndex = 1
        Me.password_txt.UseSystemPasswordChar = True
        '
        'server_txt
        '
        Me.server_txt.Location = New System.Drawing.Point(512, 12)
        Me.server_txt.Name = "server_txt"
        Me.server_txt.Size = New System.Drawing.Size(112, 20)
        Me.server_txt.TabIndex = 2
        '
        'emailto_txt
        '
        Me.emailto_txt.Location = New System.Drawing.Point(76, 42)
        Me.emailto_txt.Name = "emailto_txt"
        Me.emailto_txt.Size = New System.Drawing.Size(548, 20)
        Me.emailto_txt.TabIndex = 3
        '
        'subject_txt
        '
        Me.subject_txt.Location = New System.Drawing.Point(76, 68)
        Me.subject_txt.Name = "subject_txt"
        Me.subject_txt.Size = New System.Drawing.Size(548, 20)
        Me.subject_txt.TabIndex = 4
        '
        'message_txt
        '
        Me.message_txt.Location = New System.Drawing.Point(12, 94)
        Me.message_txt.Multiline = True
        Me.message_txt.Name = "message_txt"
        Me.message_txt.Size = New System.Drawing.Size(612, 252)
        Me.message_txt.TabIndex = 5
        '
        'file_txt
        '
        Me.file_txt.Location = New System.Drawing.Point(62, 355)
        Me.file_txt.Name = "file_txt"
        Me.file_txt.Size = New System.Drawing.Size(387, 20)
        Me.file_txt.TabIndex = 6
        '
        'file_txt1
        '
        Me.file_txt1.Location = New System.Drawing.Point(62, 381)
        Me.file_txt1.Name = "file_txt1"
        Me.file_txt1.Size = New System.Drawing.Size(387, 20)
        Me.file_txt1.TabIndex = 7
        '
        'file_txt2
        '
        Me.file_txt2.Location = New System.Drawing.Point(62, 407)
        Me.file_txt2.Name = "file_txt2"
        Me.file_txt2.Size = New System.Drawing.Size(387, 20)
        Me.file_txt2.TabIndex = 8
        '
        'file_txt3
        '
        Me.file_txt3.Location = New System.Drawing.Point(62, 433)
        Me.file_txt3.Name = "file_txt3"
        Me.file_txt3.Size = New System.Drawing.Size(387, 20)
        Me.file_txt3.TabIndex = 9
        '
        'email_lb
        '
        Me.email_lb.AutoSize = True
        Me.email_lb.Location = New System.Drawing.Point(12, 15)
        Me.email_lb.Name = "email_lb"
        Me.email_lb.Size = New System.Drawing.Size(36, 13)
        Me.email_lb.TabIndex = 10
        Me.email_lb.Text = "E-Mail"
        '
        'password_lb
        '
        Me.password_lb.AutoSize = True
        Me.password_lb.Location = New System.Drawing.Point(206, 15)
        Me.password_lb.Name = "password_lb"
        Me.password_lb.Size = New System.Drawing.Size(50, 13)
        Me.password_lb.TabIndex = 11
        Me.password_lb.Text = "Passwort"
        '
        'server_lb
        '
        Me.server_lb.AutoSize = True
        Me.server_lb.Location = New System.Drawing.Point(465, 15)
        Me.server_lb.Name = "server_lb"
        Me.server_lb.Size = New System.Drawing.Size(41, 13)
        Me.server_lb.TabIndex = 12
        Me.server_lb.Text = "Server:"
        '
        'emailto_lb
        '
        Me.emailto_lb.AutoSize = True
        Me.emailto_lb.Location = New System.Drawing.Point(12, 45)
        Me.emailto_lb.Name = "emailto_lb"
        Me.emailto_lb.Size = New System.Drawing.Size(58, 13)
        Me.emailto_lb.TabIndex = 13
        Me.emailto_lb.Text = "Empfänger"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Betreff"
        '
        'attachment_lb
        '
        Me.attachment_lb.AutoSize = True
        Me.attachment_lb.Location = New System.Drawing.Point(12, 358)
        Me.attachment_lb.Name = "attachment_lb"
        Me.attachment_lb.Size = New System.Drawing.Size(44, 13)
        Me.attachment_lb.TabIndex = 15
        Me.attachment_lb.Text = "Anhang"
        '
        'attachment_lb1
        '
        Me.attachment_lb1.AutoSize = True
        Me.attachment_lb1.Location = New System.Drawing.Point(12, 384)
        Me.attachment_lb1.Name = "attachment_lb1"
        Me.attachment_lb1.Size = New System.Drawing.Size(44, 13)
        Me.attachment_lb1.TabIndex = 16
        Me.attachment_lb1.Text = "Anhang"
        '
        'attachment_lb2
        '
        Me.attachment_lb2.AutoSize = True
        Me.attachment_lb2.Location = New System.Drawing.Point(12, 410)
        Me.attachment_lb2.Name = "attachment_lb2"
        Me.attachment_lb2.Size = New System.Drawing.Size(44, 13)
        Me.attachment_lb2.TabIndex = 17
        Me.attachment_lb2.Text = "Anhang"
        '
        'attachment_lb3
        '
        Me.attachment_lb3.AutoSize = True
        Me.attachment_lb3.Location = New System.Drawing.Point(12, 436)
        Me.attachment_lb3.Name = "attachment_lb3"
        Me.attachment_lb3.Size = New System.Drawing.Size(44, 13)
        Me.attachment_lb3.TabIndex = 18
        Me.attachment_lb3.Text = "Anhang"
        '
        'fileadd_bt
        '
        Me.fileadd_bt.Location = New System.Drawing.Point(455, 353)
        Me.fileadd_bt.Name = "fileadd_bt"
        Me.fileadd_bt.Size = New System.Drawing.Size(69, 23)
        Me.fileadd_bt.TabIndex = 19
        Me.fileadd_bt.Text = "Hinzufügen"
        Me.fileadd_bt.UseVisualStyleBackColor = True
        '
        'fileadd_bt1
        '
        Me.fileadd_bt1.Location = New System.Drawing.Point(455, 379)
        Me.fileadd_bt1.Name = "fileadd_bt1"
        Me.fileadd_bt1.Size = New System.Drawing.Size(69, 23)
        Me.fileadd_bt1.TabIndex = 20
        Me.fileadd_bt1.Text = "Hinzufügen"
        Me.fileadd_bt1.UseVisualStyleBackColor = True
        '
        'fileadd_bt2
        '
        Me.fileadd_bt2.Location = New System.Drawing.Point(455, 405)
        Me.fileadd_bt2.Name = "fileadd_bt2"
        Me.fileadd_bt2.Size = New System.Drawing.Size(69, 23)
        Me.fileadd_bt2.TabIndex = 21
        Me.fileadd_bt2.Text = "Hinzufügen"
        Me.fileadd_bt2.UseVisualStyleBackColor = True
        '
        'fileadd_bt3
        '
        Me.fileadd_bt3.Location = New System.Drawing.Point(455, 431)
        Me.fileadd_bt3.Name = "fileadd_bt3"
        Me.fileadd_bt3.Size = New System.Drawing.Size(69, 23)
        Me.fileadd_bt3.TabIndex = 22
        Me.fileadd_bt3.Text = "Hinzufügen"
        Me.fileadd_bt3.UseVisualStyleBackColor = True
        '
        'add_bt
        '
        Me.add_bt.Image = Global.Project_WinCrypt.My.Resources.Resources.add16
        Me.add_bt.Location = New System.Drawing.Point(524, 353)
        Me.add_bt.Name = "add_bt"
        Me.add_bt.Size = New System.Drawing.Size(25, 23)
        Me.add_bt.TabIndex = 23
        Me.add_bt.UseVisualStyleBackColor = True
        '
        'sendmail_bt
        '
        Me.sendmail_bt.Location = New System.Drawing.Point(561, 352)
        Me.sendmail_bt.Name = "sendmail_bt"
        Me.sendmail_bt.Size = New System.Drawing.Size(63, 23)
        Me.sendmail_bt.TabIndex = 24
        Me.sendmail_bt.Text = "Senden"
        Me.sendmail_bt.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'account_bt
        '
        Me.account_bt.Location = New System.Drawing.Point(512, 92)
        Me.account_bt.Name = "account_bt"
        Me.account_bt.Size = New System.Drawing.Size(112, 23)
        Me.account_bt.TabIndex = 25
        Me.account_bt.Text = "Konto entfernen"
        Me.account_bt.UseVisualStyleBackColor = True
        Me.account_bt.Visible = False
        '
        'sendmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 379)
        Me.Controls.Add(Me.account_bt)
        Me.Controls.Add(Me.sendmail_bt)
        Me.Controls.Add(Me.add_bt)
        Me.Controls.Add(Me.fileadd_bt3)
        Me.Controls.Add(Me.fileadd_bt2)
        Me.Controls.Add(Me.fileadd_bt1)
        Me.Controls.Add(Me.fileadd_bt)
        Me.Controls.Add(Me.attachment_lb3)
        Me.Controls.Add(Me.attachment_lb2)
        Me.Controls.Add(Me.attachment_lb1)
        Me.Controls.Add(Me.attachment_lb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.emailto_lb)
        Me.Controls.Add(Me.server_lb)
        Me.Controls.Add(Me.password_lb)
        Me.Controls.Add(Me.email_lb)
        Me.Controls.Add(Me.file_txt3)
        Me.Controls.Add(Me.file_txt2)
        Me.Controls.Add(Me.file_txt1)
        Me.Controls.Add(Me.file_txt)
        Me.Controls.Add(Me.message_txt)
        Me.Controls.Add(Me.subject_txt)
        Me.Controls.Add(Me.emailto_txt)
        Me.Controls.Add(Me.server_txt)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.email_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(652, 418)
        Me.Name = "sendmail"
        Me.Text = "E-Mail senden"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents email_txt As System.Windows.Forms.TextBox
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
    Friend WithEvents server_txt As System.Windows.Forms.TextBox
    Friend WithEvents emailto_txt As System.Windows.Forms.TextBox
    Friend WithEvents subject_txt As System.Windows.Forms.TextBox
    Friend WithEvents message_txt As System.Windows.Forms.TextBox
    Friend WithEvents file_txt As System.Windows.Forms.TextBox
    Friend WithEvents file_txt1 As System.Windows.Forms.TextBox
    Friend WithEvents file_txt2 As System.Windows.Forms.TextBox
    Friend WithEvents file_txt3 As System.Windows.Forms.TextBox
    Friend WithEvents email_lb As System.Windows.Forms.Label
    Friend WithEvents password_lb As System.Windows.Forms.Label
    Friend WithEvents server_lb As System.Windows.Forms.Label
    Friend WithEvents emailto_lb As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents attachment_lb As System.Windows.Forms.Label
    Friend WithEvents attachment_lb1 As System.Windows.Forms.Label
    Friend WithEvents attachment_lb2 As System.Windows.Forms.Label
    Friend WithEvents attachment_lb3 As System.Windows.Forms.Label
    Friend WithEvents fileadd_bt As System.Windows.Forms.Button
    Friend WithEvents fileadd_bt1 As System.Windows.Forms.Button
    Friend WithEvents fileadd_bt2 As System.Windows.Forms.Button
    Friend WithEvents fileadd_bt3 As System.Windows.Forms.Button
    Friend WithEvents add_bt As System.Windows.Forms.Button
    Friend WithEvents sendmail_bt As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents account_bt As System.Windows.Forms.Button
End Class
