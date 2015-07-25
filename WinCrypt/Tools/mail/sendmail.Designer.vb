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
        Me.rsa_open_bt = New System.Windows.Forms.Button()
        Me.pubkey_txt = New System.Windows.Forms.TextBox()
        Me.pubkey_lb = New System.Windows.Forms.Label()
        Me.rsa_cb = New System.Windows.Forms.CheckBox()
        Me.rsadialog = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'email_txt
        '
        Me.email_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.email_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.email_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.email_txt.Location = New System.Drawing.Point(54, 46)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(140, 20)
        Me.email_txt.TabIndex = 0
        '
        'password_txt
        '
        Me.password_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.password_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.password_txt.Location = New System.Drawing.Point(260, 46)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(145, 20)
        Me.password_txt.TabIndex = 1
        Me.password_txt.UseSystemPasswordChar = True
        '
        'server_txt
        '
        Me.server_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.server_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.server_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.server_txt.Location = New System.Drawing.Point(512, 46)
        Me.server_txt.Name = "server_txt"
        Me.server_txt.Size = New System.Drawing.Size(112, 20)
        Me.server_txt.TabIndex = 2
        '
        'emailto_txt
        '
        Me.emailto_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.emailto_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emailto_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.emailto_txt.Location = New System.Drawing.Point(76, 76)
        Me.emailto_txt.Name = "emailto_txt"
        Me.emailto_txt.Size = New System.Drawing.Size(548, 20)
        Me.emailto_txt.TabIndex = 3
        '
        'subject_txt
        '
        Me.subject_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.subject_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.subject_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.subject_txt.Location = New System.Drawing.Point(76, 102)
        Me.subject_txt.Name = "subject_txt"
        Me.subject_txt.Size = New System.Drawing.Size(548, 20)
        Me.subject_txt.TabIndex = 4
        '
        'message_txt
        '
        Me.message_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.message_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.message_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.message_txt.Location = New System.Drawing.Point(12, 128)
        Me.message_txt.Multiline = True
        Me.message_txt.Name = "message_txt"
        Me.message_txt.Size = New System.Drawing.Size(612, 297)
        Me.message_txt.TabIndex = 5
        '
        'file_txt
        '
        Me.file_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.file_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.file_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.file_txt.Location = New System.Drawing.Point(62, 460)
        Me.file_txt.Name = "file_txt"
        Me.file_txt.Size = New System.Drawing.Size(387, 20)
        Me.file_txt.TabIndex = 6
        '
        'file_txt1
        '
        Me.file_txt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.file_txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.file_txt1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.file_txt1.Location = New System.Drawing.Point(62, 489)
        Me.file_txt1.Name = "file_txt1"
        Me.file_txt1.Size = New System.Drawing.Size(387, 20)
        Me.file_txt1.TabIndex = 7
        '
        'file_txt2
        '
        Me.file_txt2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.file_txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.file_txt2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.file_txt2.Location = New System.Drawing.Point(62, 515)
        Me.file_txt2.Name = "file_txt2"
        Me.file_txt2.Size = New System.Drawing.Size(387, 20)
        Me.file_txt2.TabIndex = 8
        '
        'file_txt3
        '
        Me.file_txt3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.file_txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.file_txt3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.file_txt3.Location = New System.Drawing.Point(62, 541)
        Me.file_txt3.Name = "file_txt3"
        Me.file_txt3.Size = New System.Drawing.Size(387, 20)
        Me.file_txt3.TabIndex = 9
        '
        'email_lb
        '
        Me.email_lb.AutoSize = True
        Me.email_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.email_lb.Location = New System.Drawing.Point(12, 49)
        Me.email_lb.Name = "email_lb"
        Me.email_lb.Size = New System.Drawing.Size(36, 13)
        Me.email_lb.TabIndex = 10
        Me.email_lb.Text = "E-Mail"
        '
        'password_lb
        '
        Me.password_lb.AutoSize = True
        Me.password_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.password_lb.Location = New System.Drawing.Point(206, 49)
        Me.password_lb.Name = "password_lb"
        Me.password_lb.Size = New System.Drawing.Size(50, 13)
        Me.password_lb.TabIndex = 11
        Me.password_lb.Text = "Passwort"
        '
        'server_lb
        '
        Me.server_lb.AutoSize = True
        Me.server_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.server_lb.Location = New System.Drawing.Point(465, 49)
        Me.server_lb.Name = "server_lb"
        Me.server_lb.Size = New System.Drawing.Size(41, 13)
        Me.server_lb.TabIndex = 12
        Me.server_lb.Text = "Server:"
        '
        'emailto_lb
        '
        Me.emailto_lb.AutoSize = True
        Me.emailto_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.emailto_lb.Location = New System.Drawing.Point(12, 79)
        Me.emailto_lb.Name = "emailto_lb"
        Me.emailto_lb.Size = New System.Drawing.Size(58, 13)
        Me.emailto_lb.TabIndex = 13
        Me.emailto_lb.Text = "Empfänger"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(12, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Betreff"
        '
        'attachment_lb
        '
        Me.attachment_lb.AutoSize = True
        Me.attachment_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.attachment_lb.Location = New System.Drawing.Point(12, 463)
        Me.attachment_lb.Name = "attachment_lb"
        Me.attachment_lb.Size = New System.Drawing.Size(44, 13)
        Me.attachment_lb.TabIndex = 15
        Me.attachment_lb.Text = "Anhang"
        '
        'attachment_lb1
        '
        Me.attachment_lb1.AutoSize = True
        Me.attachment_lb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.attachment_lb1.Location = New System.Drawing.Point(12, 492)
        Me.attachment_lb1.Name = "attachment_lb1"
        Me.attachment_lb1.Size = New System.Drawing.Size(44, 13)
        Me.attachment_lb1.TabIndex = 16
        Me.attachment_lb1.Text = "Anhang"
        '
        'attachment_lb2
        '
        Me.attachment_lb2.AutoSize = True
        Me.attachment_lb2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.attachment_lb2.Location = New System.Drawing.Point(12, 518)
        Me.attachment_lb2.Name = "attachment_lb2"
        Me.attachment_lb2.Size = New System.Drawing.Size(44, 13)
        Me.attachment_lb2.TabIndex = 17
        Me.attachment_lb2.Text = "Anhang"
        '
        'attachment_lb3
        '
        Me.attachment_lb3.AutoSize = True
        Me.attachment_lb3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.attachment_lb3.Location = New System.Drawing.Point(12, 544)
        Me.attachment_lb3.Name = "attachment_lb3"
        Me.attachment_lb3.Size = New System.Drawing.Size(44, 13)
        Me.attachment_lb3.TabIndex = 18
        Me.attachment_lb3.Text = "Anhang"
        '
        'fileadd_bt
        '
        Me.fileadd_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fileadd_bt.FlatAppearance.BorderSize = 0
        Me.fileadd_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fileadd_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.fileadd_bt.Location = New System.Drawing.Point(455, 458)
        Me.fileadd_bt.Name = "fileadd_bt"
        Me.fileadd_bt.Size = New System.Drawing.Size(69, 23)
        Me.fileadd_bt.TabIndex = 19
        Me.fileadd_bt.Text = "Hinzufügen"
        Me.fileadd_bt.UseVisualStyleBackColor = False
        '
        'fileadd_bt1
        '
        Me.fileadd_bt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fileadd_bt1.Enabled = False
        Me.fileadd_bt1.FlatAppearance.BorderSize = 0
        Me.fileadd_bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fileadd_bt1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.fileadd_bt1.Location = New System.Drawing.Point(455, 487)
        Me.fileadd_bt1.Name = "fileadd_bt1"
        Me.fileadd_bt1.Size = New System.Drawing.Size(69, 23)
        Me.fileadd_bt1.TabIndex = 20
        Me.fileadd_bt1.Text = "Hinzufügen"
        Me.fileadd_bt1.UseVisualStyleBackColor = False
        '
        'fileadd_bt2
        '
        Me.fileadd_bt2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fileadd_bt2.Enabled = False
        Me.fileadd_bt2.FlatAppearance.BorderSize = 0
        Me.fileadd_bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fileadd_bt2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.fileadd_bt2.Location = New System.Drawing.Point(455, 513)
        Me.fileadd_bt2.Name = "fileadd_bt2"
        Me.fileadd_bt2.Size = New System.Drawing.Size(69, 23)
        Me.fileadd_bt2.TabIndex = 21
        Me.fileadd_bt2.Text = "Hinzufügen"
        Me.fileadd_bt2.UseVisualStyleBackColor = False
        '
        'fileadd_bt3
        '
        Me.fileadd_bt3.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fileadd_bt3.Enabled = False
        Me.fileadd_bt3.FlatAppearance.BorderSize = 0
        Me.fileadd_bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fileadd_bt3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.fileadd_bt3.Location = New System.Drawing.Point(455, 539)
        Me.fileadd_bt3.Name = "fileadd_bt3"
        Me.fileadd_bt3.Size = New System.Drawing.Size(69, 23)
        Me.fileadd_bt3.TabIndex = 22
        Me.fileadd_bt3.Text = "Hinzufügen"
        Me.fileadd_bt3.UseVisualStyleBackColor = False
        '
        'add_bt
        '
        Me.add_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.add_bt.FlatAppearance.BorderSize = 0
        Me.add_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_bt.Image = Global.Project_WinCrypt.My.Resources.Resources.AddNew16
        Me.add_bt.Location = New System.Drawing.Point(524, 458)
        Me.add_bt.Name = "add_bt"
        Me.add_bt.Size = New System.Drawing.Size(25, 23)
        Me.add_bt.TabIndex = 23
        Me.add_bt.UseVisualStyleBackColor = False
        '
        'sendmail_bt
        '
        Me.sendmail_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sendmail_bt.FlatAppearance.BorderSize = 0
        Me.sendmail_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sendmail_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sendmail_bt.Location = New System.Drawing.Point(561, 457)
        Me.sendmail_bt.Name = "sendmail_bt"
        Me.sendmail_bt.Size = New System.Drawing.Size(63, 23)
        Me.sendmail_bt.TabIndex = 24
        Me.sendmail_bt.Text = "Senden"
        Me.sendmail_bt.UseVisualStyleBackColor = False
        '
        'account_bt
        '
        Me.account_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.account_bt.FlatAppearance.BorderSize = 0
        Me.account_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.account_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.account_bt.Location = New System.Drawing.Point(512, 126)
        Me.account_bt.Name = "account_bt"
        Me.account_bt.Size = New System.Drawing.Size(112, 23)
        Me.account_bt.TabIndex = 25
        Me.account_bt.Text = "Konto entfernen"
        Me.account_bt.UseVisualStyleBackColor = False
        Me.account_bt.Visible = False
        '
        'rsa_open_bt
        '
        Me.rsa_open_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rsa_open_bt.FlatAppearance.BorderSize = 0
        Me.rsa_open_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rsa_open_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rsa_open_bt.Location = New System.Drawing.Point(455, 429)
        Me.rsa_open_bt.Name = "rsa_open_bt"
        Me.rsa_open_bt.Size = New System.Drawing.Size(69, 23)
        Me.rsa_open_bt.TabIndex = 26
        Me.rsa_open_bt.Text = "Öffnen"
        Me.rsa_open_bt.UseVisualStyleBackColor = False
        Me.rsa_open_bt.Visible = False
        '
        'pubkey_txt
        '
        Me.pubkey_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pubkey_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pubkey_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pubkey_txt.Location = New System.Drawing.Point(62, 431)
        Me.pubkey_txt.Name = "pubkey_txt"
        Me.pubkey_txt.Size = New System.Drawing.Size(387, 20)
        Me.pubkey_txt.TabIndex = 27
        Me.pubkey_txt.Visible = False
        '
        'pubkey_lb
        '
        Me.pubkey_lb.AutoSize = True
        Me.pubkey_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pubkey_lb.Location = New System.Drawing.Point(-1, 434)
        Me.pubkey_lb.Name = "pubkey_lb"
        Me.pubkey_lb.Size = New System.Drawing.Size(57, 13)
        Me.pubkey_lb.TabIndex = 28
        Me.pubkey_lb.Text = "Public Key"
        Me.pubkey_lb.Visible = False
        '
        'rsa_cb
        '
        Me.rsa_cb.AutoSize = True
        Me.rsa_cb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rsa_cb.Location = New System.Drawing.Point(553, 433)
        Me.rsa_cb.Name = "rsa_cb"
        Me.rsa_cb.Size = New System.Drawing.Size(70, 17)
        Me.rsa_cb.TabIndex = 29
        Me.rsa_cb.Text = "RSA Mail"
        Me.rsa_cb.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(635, 27)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "WinCrypt"
        '
        'XToolStripMenuItem
        '
        Me.XToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.XToolStripMenuItem.Name = "XToolStripMenuItem"
        Me.XToolStripMenuItem.Size = New System.Drawing.Size(29, 23)
        Me.XToolStripMenuItem.Text = "X"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(32, 23)
        Me.ToolStripMenuItem1.Text = "─"
        '
        'wincrypttitle
        '
        Me.wincrypttitle.AutoSize = True
        Me.wincrypttitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.wincrypttitle.Location = New System.Drawing.Point(34, 6)
        Me.wincrypttitle.Name = "wincrypttitle"
        Me.wincrypttitle.Size = New System.Drawing.Size(94, 16)
        Me.wincrypttitle.TabIndex = 31
        Me.wincrypttitle.Text = "E-Mail senden"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_WinCrypt.My.Resources.Resources.icon
        Me.PictureBox1.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'sendmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(635, 488)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.rsa_cb)
        Me.Controls.Add(Me.pubkey_lb)
        Me.Controls.Add(Me.pubkey_txt)
        Me.Controls.Add(Me.rsa_open_bt)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "sendmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-Mail senden"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents rsa_open_bt As System.Windows.Forms.Button
    Friend WithEvents pubkey_txt As System.Windows.Forms.TextBox
    Friend WithEvents pubkey_lb As System.Windows.Forms.Label
    Friend WithEvents rsa_cb As System.Windows.Forms.CheckBox
    Friend WithEvents rsadialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
