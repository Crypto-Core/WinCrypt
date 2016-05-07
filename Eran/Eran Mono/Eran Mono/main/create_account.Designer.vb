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
        Me.main_panel = New System.Windows.Forms.Panel()
        Me.import_acc_bt = New System.Windows.Forms.Button()
        Me.logo_img = New System.Windows.Forms.PictureBox()
        Me.create_bt = New System.Windows.Forms.Button()
        Me.createAcc_gb = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.authkey_lb = New System.Windows.Forms.Label()
        Me.address_txt = New System.Windows.Forms.TextBox()
        Me.address_lb = New System.Windows.Forms.Label()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.password_lb = New System.Windows.Forms.Label()
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.username_lb = New System.Windows.Forms.Label()
        Me.main_panel.SuspendLayout()
        CType(Me.logo_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.createAcc_gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'main_panel
        '
        Me.main_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.main_panel.Controls.Add(Me.import_acc_bt)
        Me.main_panel.Controls.Add(Me.logo_img)
        Me.main_panel.Controls.Add(Me.create_bt)
        Me.main_panel.Controls.Add(Me.createAcc_gb)
        Me.main_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_panel.Font = New System.Drawing.Font("Ubuntu Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_panel.ForeColor = System.Drawing.Color.White
        Me.main_panel.Location = New System.Drawing.Point(0, 0)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(332, 549)
        Me.main_panel.TabIndex = 0
        '
        'import_acc_bt
        '
        Me.import_acc_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.import_acc_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.import_acc_bt.FlatAppearance.BorderSize = 0
        Me.import_acc_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.import_acc_bt.Location = New System.Drawing.Point(216, 514)
        Me.import_acc_bt.Name = "import_acc_bt"
        Me.import_acc_bt.Size = New System.Drawing.Size(104, 23)
        Me.import_acc_bt.TabIndex = 10
        Me.import_acc_bt.Text = "Import Account"
        Me.import_acc_bt.UseVisualStyleBackColor = False
        '
        'logo_img
        '
        Me.logo_img.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logo_img.Image = Global.Eran_Mono.My.Resources.Resources.eran_icon80
        Me.logo_img.Location = New System.Drawing.Point(126, 73)
        Me.logo_img.Name = "logo_img"
        Me.logo_img.Size = New System.Drawing.Size(80, 80)
        Me.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.logo_img.TabIndex = 9
        Me.logo_img.TabStop = False
        '
        'create_bt
        '
        Me.create_bt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.create_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.create_bt.Enabled = False
        Me.create_bt.FlatAppearance.BorderSize = 0
        Me.create_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.create_bt.Location = New System.Drawing.Point(129, 415)
        Me.create_bt.Name = "create_bt"
        Me.create_bt.Size = New System.Drawing.Size(75, 23)
        Me.create_bt.TabIndex = 8
        Me.create_bt.Text = "Create"
        Me.create_bt.UseVisualStyleBackColor = False
        '
        'createAcc_gb
        '
        Me.createAcc_gb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.createAcc_gb.BackColor = System.Drawing.Color.Transparent
        Me.createAcc_gb.Controls.Add(Me.Label5)
        Me.createAcc_gb.Controls.Add(Me.Label4)
        Me.createAcc_gb.Controls.Add(Me.authkey_lb)
        Me.createAcc_gb.Controls.Add(Me.address_txt)
        Me.createAcc_gb.Controls.Add(Me.address_lb)
        Me.createAcc_gb.Controls.Add(Me.password_txt)
        Me.createAcc_gb.Controls.Add(Me.password_lb)
        Me.createAcc_gb.Controls.Add(Me.username_txt)
        Me.createAcc_gb.Controls.Add(Me.username_lb)
        Me.createAcc_gb.ForeColor = System.Drawing.Color.White
        Me.createAcc_gb.Location = New System.Drawing.Point(36, 159)
        Me.createAcc_gb.Name = "createAcc_gb"
        Me.createAcc_gb.Size = New System.Drawing.Size(261, 250)
        Me.createAcc_gb.TabIndex = 2
        Me.createAcc_gb.TabStop = False
        Me.createAcc_gb.Text = "Create account"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "min. 8 chars"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "min. 6 chars"
        '
        'authkey_lb
        '
        Me.authkey_lb.AutoSize = True
        Me.authkey_lb.Location = New System.Drawing.Point(6, 218)
        Me.authkey_lb.Name = "authkey_lb"
        Me.authkey_lb.Size = New System.Drawing.Size(67, 15)
        Me.authkey_lb.TabIndex = 9
        Me.authkey_lb.Text = "Auth. key:"
        '
        'address_txt
        '
        Me.address_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.address_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.address_txt.Font = New System.Drawing.Font("Ubuntu Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.address_txt.Location = New System.Drawing.Point(9, 183)
        Me.address_txt.Name = "address_txt"
        Me.address_txt.ReadOnly = True
        Me.address_txt.Size = New System.Drawing.Size(246, 25)
        Me.address_txt.TabIndex = 8
        '
        'address_lb
        '
        Me.address_lb.AutoSize = True
        Me.address_lb.Location = New System.Drawing.Point(6, 165)
        Me.address_lb.Name = "address_lb"
        Me.address_lb.Size = New System.Drawing.Size(85, 15)
        Me.address_lb.TabIndex = 7
        Me.address_lb.Text = "Eran address:"
        '
        'password_txt
        '
        Me.password_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.password_txt.Font = New System.Drawing.Font("Ubuntu Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.password_txt.Location = New System.Drawing.Point(9, 114)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.Size = New System.Drawing.Size(246, 25)
        Me.password_txt.TabIndex = 6
        '
        'password_lb
        '
        Me.password_lb.AutoSize = True
        Me.password_lb.Location = New System.Drawing.Point(6, 96)
        Me.password_lb.Name = "password_lb"
        Me.password_lb.Size = New System.Drawing.Size(61, 15)
        Me.password_lb.TabIndex = 5
        Me.password_lb.Text = "Password:"
        '
        'username_txt
        '
        Me.username_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.username_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.username_txt.Font = New System.Drawing.Font("Ubuntu Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.username_txt.Location = New System.Drawing.Point(9, 44)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(246, 25)
        Me.username_txt.TabIndex = 4
        '
        'username_lb
        '
        Me.username_lb.AutoSize = True
        Me.username_lb.Location = New System.Drawing.Point(6, 26)
        Me.username_lb.Name = "username_lb"
        Me.username_lb.Size = New System.Drawing.Size(61, 15)
        Me.username_lb.TabIndex = 4
        Me.username_lb.Text = "Username:"
        '
        'create_account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 549)
        Me.Controls.Add(Me.main_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "create_account"
        Me.Text = "create_account"
        Me.main_panel.ResumeLayout(False)
        Me.main_panel.PerformLayout()
        CType(Me.logo_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.createAcc_gb.ResumeLayout(False)
        Me.createAcc_gb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_panel As System.Windows.Forms.Panel
    Friend WithEvents createAcc_gb As System.Windows.Forms.GroupBox
    Friend WithEvents username_txt As System.Windows.Forms.TextBox
    Friend WithEvents username_lb As System.Windows.Forms.Label
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
    Friend WithEvents password_lb As System.Windows.Forms.Label
    Friend WithEvents authkey_lb As System.Windows.Forms.Label
    Friend WithEvents address_txt As System.Windows.Forms.TextBox
    Friend WithEvents address_lb As System.Windows.Forms.Label
    Friend WithEvents logo_img As System.Windows.Forms.PictureBox
    Friend WithEvents create_bt As System.Windows.Forms.Button
    Friend WithEvents import_acc_bt As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
