<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create_account
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
        Me.create_account_panel = New System.Windows.Forms.Panel()
        Me.importAcc_bt = New System.Windows.Forms.Button()
        Me.logo_img = New System.Windows.Forms.PictureBox()
        Me.create_bt = New System.Windows.Forms.Button()
        Me.create_eran_acc_gb = New System.Windows.Forms.GroupBox()
        Me.auth_key_lb = New System.Windows.Forms.Label()
        Me.min_chars_pwd_lb = New System.Windows.Forms.Label()
        Me.min_chars_urs_lb = New System.Windows.Forms.Label()
        Me.eran_adr_lb = New System.Windows.Forms.Label()
        Me.eran_txt = New System.Windows.Forms.TextBox()
        Me.pwd_txt = New System.Windows.Forms.TextBox()
        Me.usr_txt = New System.Windows.Forms.TextBox()
        Me.pwd_lb = New System.Windows.Forms.Label()
        Me.usr_lb = New System.Windows.Forms.Label()
        Me.create_account_panel.SuspendLayout()
        CType(Me.logo_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.create_eran_acc_gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'create_account_panel
        '
        Me.create_account_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.create_account_panel.Controls.Add(Me.importAcc_bt)
        Me.create_account_panel.Controls.Add(Me.logo_img)
        Me.create_account_panel.Controls.Add(Me.create_bt)
        Me.create_account_panel.Controls.Add(Me.create_eran_acc_gb)
        Me.create_account_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.create_account_panel.Location = New System.Drawing.Point(0, 0)
        Me.create_account_panel.Name = "create_account_panel"
        Me.create_account_panel.Size = New System.Drawing.Size(313, 419)
        Me.create_account_panel.TabIndex = 0
        '
        'importAcc_bt
        '
        Me.importAcc_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.importAcc_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.importAcc_bt.FlatAppearance.BorderSize = 0
        Me.importAcc_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.importAcc_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.importAcc_bt.Location = New System.Drawing.Point(202, 384)
        Me.importAcc_bt.Name = "importAcc_bt"
        Me.importAcc_bt.Size = New System.Drawing.Size(99, 23)
        Me.importAcc_bt.TabIndex = 3
        Me.importAcc_bt.Text = "Import account"
        Me.importAcc_bt.UseVisualStyleBackColor = False
        '
        'logo_img
        '
        Me.logo_img.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logo_img.Image = Global.Eran.My.Resources.Resources.eran_icon80
        Me.logo_img.Location = New System.Drawing.Point(116, 12)
        Me.logo_img.Name = "logo_img"
        Me.logo_img.Size = New System.Drawing.Size(80, 80)
        Me.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.logo_img.TabIndex = 2
        Me.logo_img.TabStop = False
        '
        'create_bt
        '
        Me.create_bt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.create_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.create_bt.FlatAppearance.BorderSize = 0
        Me.create_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.create_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.create_bt.Location = New System.Drawing.Point(119, 337)
        Me.create_bt.Name = "create_bt"
        Me.create_bt.Size = New System.Drawing.Size(75, 23)
        Me.create_bt.TabIndex = 0
        Me.create_bt.Text = "Create"
        Me.create_bt.UseVisualStyleBackColor = False
        '
        'create_eran_acc_gb
        '
        Me.create_eran_acc_gb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.create_eran_acc_gb.Controls.Add(Me.auth_key_lb)
        Me.create_eran_acc_gb.Controls.Add(Me.min_chars_pwd_lb)
        Me.create_eran_acc_gb.Controls.Add(Me.min_chars_urs_lb)
        Me.create_eran_acc_gb.Controls.Add(Me.eran_adr_lb)
        Me.create_eran_acc_gb.Controls.Add(Me.eran_txt)
        Me.create_eran_acc_gb.Controls.Add(Me.pwd_txt)
        Me.create_eran_acc_gb.Controls.Add(Me.usr_txt)
        Me.create_eran_acc_gb.Controls.Add(Me.pwd_lb)
        Me.create_eran_acc_gb.Controls.Add(Me.usr_lb)
        Me.create_eran_acc_gb.ForeColor = System.Drawing.Color.White
        Me.create_eran_acc_gb.Location = New System.Drawing.Point(34, 117)
        Me.create_eran_acc_gb.Name = "create_eran_acc_gb"
        Me.create_eran_acc_gb.Size = New System.Drawing.Size(244, 214)
        Me.create_eran_acc_gb.TabIndex = 1
        Me.create_eran_acc_gb.TabStop = False
        Me.create_eran_acc_gb.Text = "Create Eran Account"
        '
        'auth_key_lb
        '
        Me.auth_key_lb.AutoSize = True
        Me.auth_key_lb.Location = New System.Drawing.Point(7, 183)
        Me.auth_key_lb.Name = "auth_key_lb"
        Me.auth_key_lb.Size = New System.Drawing.Size(55, 13)
        Me.auth_key_lb.TabIndex = 8
        Me.auth_key_lb.Text = "Auth. key:"
        '
        'min_chars_pwd_lb
        '
        Me.min_chars_pwd_lb.AutoSize = True
        Me.min_chars_pwd_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min_chars_pwd_lb.Location = New System.Drawing.Point(10, 119)
        Me.min_chars_pwd_lb.Name = "min_chars_pwd_lb"
        Me.min_chars_pwd_lb.Size = New System.Drawing.Size(55, 12)
        Me.min_chars_pwd_lb.TabIndex = 7
        Me.min_chars_pwd_lb.Text = "min. 8 chars"
        '
        'min_chars_urs_lb
        '
        Me.min_chars_urs_lb.AutoSize = True
        Me.min_chars_urs_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min_chars_urs_lb.Location = New System.Drawing.Point(10, 60)
        Me.min_chars_urs_lb.Name = "min_chars_urs_lb"
        Me.min_chars_urs_lb.Size = New System.Drawing.Size(55, 12)
        Me.min_chars_urs_lb.TabIndex = 6
        Me.min_chars_urs_lb.Text = "min. 6 chars"
        '
        'eran_adr_lb
        '
        Me.eran_adr_lb.AutoSize = True
        Me.eran_adr_lb.Location = New System.Drawing.Point(3, 139)
        Me.eran_adr_lb.Name = "eran_adr_lb"
        Me.eran_adr_lb.Size = New System.Drawing.Size(72, 13)
        Me.eran_adr_lb.TabIndex = 5
        Me.eran_adr_lb.Text = "Eran address:"
        '
        'eran_txt
        '
        Me.eran_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.eran_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.eran_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.eran_txt.Location = New System.Drawing.Point(6, 155)
        Me.eran_txt.Name = "eran_txt"
        Me.eran_txt.ReadOnly = True
        Me.eran_txt.Size = New System.Drawing.Size(232, 20)
        Me.eran_txt.TabIndex = 4
        Me.eran_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pwd_txt
        '
        Me.pwd_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pwd_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pwd_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pwd_txt.Location = New System.Drawing.Point(6, 96)
        Me.pwd_txt.Name = "pwd_txt"
        Me.pwd_txt.Size = New System.Drawing.Size(232, 20)
        Me.pwd_txt.TabIndex = 3
        Me.pwd_txt.UseSystemPasswordChar = True
        '
        'usr_txt
        '
        Me.usr_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.usr_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usr_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.usr_txt.Location = New System.Drawing.Point(6, 37)
        Me.usr_txt.Name = "usr_txt"
        Me.usr_txt.Size = New System.Drawing.Size(232, 20)
        Me.usr_txt.TabIndex = 2
        '
        'pwd_lb
        '
        Me.pwd_lb.AutoSize = True
        Me.pwd_lb.Location = New System.Drawing.Point(3, 80)
        Me.pwd_lb.Name = "pwd_lb"
        Me.pwd_lb.Size = New System.Drawing.Size(56, 13)
        Me.pwd_lb.TabIndex = 1
        Me.pwd_lb.Text = "Password:"
        '
        'usr_lb
        '
        Me.usr_lb.AutoSize = True
        Me.usr_lb.Location = New System.Drawing.Point(3, 21)
        Me.usr_lb.Name = "usr_lb"
        Me.usr_lb.Size = New System.Drawing.Size(58, 13)
        Me.usr_lb.TabIndex = 0
        Me.usr_lb.Text = "Username:"
        '
        'create_account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 419)
        Me.Controls.Add(Me.create_account_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "create_account"
        Me.Text = "create_account"
        Me.create_account_panel.ResumeLayout(False)
        Me.create_account_panel.PerformLayout()
        CType(Me.logo_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.create_eran_acc_gb.ResumeLayout(False)
        Me.create_eran_acc_gb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents create_account_panel As System.Windows.Forms.Panel
    Friend WithEvents create_bt As System.Windows.Forms.Button
    Friend WithEvents create_eran_acc_gb As System.Windows.Forms.GroupBox
    Friend WithEvents eran_adr_lb As System.Windows.Forms.Label
    Friend WithEvents eran_txt As System.Windows.Forms.TextBox
    Friend WithEvents pwd_txt As System.Windows.Forms.TextBox
    Friend WithEvents usr_txt As System.Windows.Forms.TextBox
    Friend WithEvents pwd_lb As System.Windows.Forms.Label
    Friend WithEvents usr_lb As System.Windows.Forms.Label
    Friend WithEvents min_chars_pwd_lb As System.Windows.Forms.Label
    Friend WithEvents min_chars_urs_lb As System.Windows.Forms.Label
    Friend WithEvents auth_key_lb As System.Windows.Forms.Label
    Friend WithEvents logo_img As System.Windows.Forms.PictureBox
    Friend WithEvents importAcc_bt As System.Windows.Forms.Button
End Class
