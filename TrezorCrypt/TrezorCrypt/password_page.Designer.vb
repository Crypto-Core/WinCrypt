<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class password_page
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
        Me.selected_gb = New System.Windows.Forms.GroupBox()
        Me.serial_lb = New System.Windows.Forms.Label()
        Me.size_lb = New System.Windows.Forms.Label()
        Me.product_lb = New System.Windows.Forms.Label()
        Me.device_lb = New System.Windows.Forms.Label()
        Me.seriallb = New System.Windows.Forms.Label()
        Me.sizelb = New System.Windows.Forms.Label()
        Me.productname_lb = New System.Windows.Forms.Label()
        Me.devicelb = New System.Windows.Forms.Label()
        Me.encryption_gb = New System.Windows.Forms.GroupBox()
        Me.min_chars_lb = New System.Windows.Forms.Label()
        Me.blocksize_cb = New System.Windows.Forms.ComboBox()
        Me.blocksize_lb = New System.Windows.Forms.Label()
        Me.algo_cb = New System.Windows.Forms.ComboBox()
        Me.algo_lb = New System.Windows.Forms.Label()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.password_lb = New System.Windows.Forms.Label()
        Me.back_bt = New System.Windows.Forms.Button()
        Me.logo_img = New System.Windows.Forms.PictureBox()
        Me.encrypt_device_bt = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.main_panel.SuspendLayout()
        Me.selected_gb.SuspendLayout()
        Me.encryption_gb.SuspendLayout()
        CType(Me.logo_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'main_panel
        '
        Me.main_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.main_panel.Controls.Add(Me.MenuStrip)
        Me.main_panel.Controls.Add(Me.selected_gb)
        Me.main_panel.Controls.Add(Me.encryption_gb)
        Me.main_panel.Controls.Add(Me.back_bt)
        Me.main_panel.Controls.Add(Me.logo_img)
        Me.main_panel.Controls.Add(Me.encrypt_device_bt)
        Me.main_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_panel.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_panel.ForeColor = System.Drawing.Color.White
        Me.main_panel.Location = New System.Drawing.Point(0, 0)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(475, 376)
        Me.main_panel.TabIndex = 1
        '
        'selected_gb
        '
        Me.selected_gb.Controls.Add(Me.serial_lb)
        Me.selected_gb.Controls.Add(Me.size_lb)
        Me.selected_gb.Controls.Add(Me.product_lb)
        Me.selected_gb.Controls.Add(Me.device_lb)
        Me.selected_gb.Controls.Add(Me.seriallb)
        Me.selected_gb.Controls.Add(Me.sizelb)
        Me.selected_gb.Controls.Add(Me.productname_lb)
        Me.selected_gb.Controls.Add(Me.devicelb)
        Me.selected_gb.ForeColor = System.Drawing.Color.White
        Me.selected_gb.Location = New System.Drawing.Point(15, 118)
        Me.selected_gb.Name = "selected_gb"
        Me.selected_gb.Size = New System.Drawing.Size(448, 101)
        Me.selected_gb.TabIndex = 6
        Me.selected_gb.TabStop = False
        Me.selected_gb.Text = "Selected Device"
        '
        'serial_lb
        '
        Me.serial_lb.AutoSize = True
        Me.serial_lb.Location = New System.Drawing.Point(84, 59)
        Me.serial_lb.Name = "serial_lb"
        Me.serial_lb.Size = New System.Drawing.Size(13, 13)
        Me.serial_lb.TabIndex = 7
        Me.serial_lb.Text = "-"
        '
        'size_lb
        '
        Me.size_lb.AutoSize = True
        Me.size_lb.Location = New System.Drawing.Point(84, 76)
        Me.size_lb.Name = "size_lb"
        Me.size_lb.Size = New System.Drawing.Size(13, 13)
        Me.size_lb.TabIndex = 6
        Me.size_lb.Text = "-"
        '
        'product_lb
        '
        Me.product_lb.AutoSize = True
        Me.product_lb.Location = New System.Drawing.Point(84, 25)
        Me.product_lb.Name = "product_lb"
        Me.product_lb.Size = New System.Drawing.Size(13, 13)
        Me.product_lb.TabIndex = 5
        Me.product_lb.Text = "-"
        '
        'device_lb
        '
        Me.device_lb.AutoSize = True
        Me.device_lb.Location = New System.Drawing.Point(84, 42)
        Me.device_lb.Name = "device_lb"
        Me.device_lb.Size = New System.Drawing.Size(13, 13)
        Me.device_lb.TabIndex = 4
        Me.device_lb.Text = "-"
        '
        'seriallb
        '
        Me.seriallb.AutoSize = True
        Me.seriallb.Location = New System.Drawing.Point(39, 59)
        Me.seriallb.Name = "seriallb"
        Me.seriallb.Size = New System.Drawing.Size(49, 13)
        Me.seriallb.TabIndex = 3
        Me.seriallb.Text = "Serial:"
        '
        'sizelb
        '
        Me.sizelb.AutoSize = True
        Me.sizelb.Location = New System.Drawing.Point(51, 76)
        Me.sizelb.Name = "sizelb"
        Me.sizelb.Size = New System.Drawing.Size(37, 13)
        Me.sizelb.TabIndex = 2
        Me.sizelb.Text = "Size:"
        '
        'productname_lb
        '
        Me.productname_lb.AutoSize = True
        Me.productname_lb.Location = New System.Drawing.Point(9, 25)
        Me.productname_lb.Name = "productname_lb"
        Me.productname_lb.Size = New System.Drawing.Size(79, 13)
        Me.productname_lb.TabIndex = 1
        Me.productname_lb.Text = "Productname:"
        '
        'devicelb
        '
        Me.devicelb.AutoSize = True
        Me.devicelb.Location = New System.Drawing.Point(39, 42)
        Me.devicelb.Name = "devicelb"
        Me.devicelb.Size = New System.Drawing.Size(49, 13)
        Me.devicelb.TabIndex = 0
        Me.devicelb.Text = "Device:"
        '
        'encryption_gb
        '
        Me.encryption_gb.Controls.Add(Me.min_chars_lb)
        Me.encryption_gb.Controls.Add(Me.blocksize_cb)
        Me.encryption_gb.Controls.Add(Me.blocksize_lb)
        Me.encryption_gb.Controls.Add(Me.algo_cb)
        Me.encryption_gb.Controls.Add(Me.algo_lb)
        Me.encryption_gb.Controls.Add(Me.password_txt)
        Me.encryption_gb.Controls.Add(Me.password_lb)
        Me.encryption_gb.ForeColor = System.Drawing.Color.White
        Me.encryption_gb.Location = New System.Drawing.Point(15, 225)
        Me.encryption_gb.Name = "encryption_gb"
        Me.encryption_gb.Size = New System.Drawing.Size(448, 98)
        Me.encryption_gb.TabIndex = 5
        Me.encryption_gb.TabStop = False
        Me.encryption_gb.Text = "Encryption"
        '
        'min_chars_lb
        '
        Me.min_chars_lb.AutoSize = True
        Me.min_chars_lb.Location = New System.Drawing.Point(77, 42)
        Me.min_chars_lb.Name = "min_chars_lb"
        Me.min_chars_lb.Size = New System.Drawing.Size(79, 13)
        Me.min_chars_lb.TabIndex = 9
        Me.min_chars_lb.Text = "min. 8 chars"
        '
        'blocksize_cb
        '
        Me.blocksize_cb.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.blocksize_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.blocksize_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.blocksize_cb.ForeColor = System.Drawing.Color.White
        Me.blocksize_cb.Items.AddRange(New Object() {"1024", "2048", "4096"})
        Me.blocksize_cb.Location = New System.Drawing.Point(361, 71)
        Me.blocksize_cb.Name = "blocksize_cb"
        Me.blocksize_cb.Size = New System.Drawing.Size(79, 21)
        Me.blocksize_cb.TabIndex = 8
        '
        'blocksize_lb
        '
        Me.blocksize_lb.AutoSize = True
        Me.blocksize_lb.Location = New System.Drawing.Point(288, 74)
        Me.blocksize_lb.Name = "blocksize_lb"
        Me.blocksize_lb.Size = New System.Drawing.Size(67, 13)
        Me.blocksize_lb.TabIndex = 7
        Me.blocksize_lb.Text = "Blocksize:"
        '
        'algo_cb
        '
        Me.algo_cb.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.algo_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.algo_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.algo_cb.ForeColor = System.Drawing.Color.White
        Me.algo_cb.Items.AddRange(New Object() {"DES", "RC4", "RIJNDAEL", "TDES"})
        Me.algo_cb.Location = New System.Drawing.Point(193, 71)
        Me.algo_cb.Name = "algo_cb"
        Me.algo_cb.Size = New System.Drawing.Size(79, 21)
        Me.algo_cb.TabIndex = 6
        '
        'algo_lb
        '
        Me.algo_lb.AutoSize = True
        Me.algo_lb.Location = New System.Drawing.Point(120, 74)
        Me.algo_lb.Name = "algo_lb"
        Me.algo_lb.Size = New System.Drawing.Size(67, 13)
        Me.algo_lb.TabIndex = 5
        Me.algo_lb.Text = "Algorithm:"
        '
        'password_txt
        '
        Me.password_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.password_txt.ForeColor = System.Drawing.Color.White
        Me.password_txt.Location = New System.Drawing.Point(80, 19)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(360, 20)
        Me.password_txt.TabIndex = 4
        Me.password_txt.UseSystemPasswordChar = True
        '
        'password_lb
        '
        Me.password_lb.AutoSize = True
        Me.password_lb.Location = New System.Drawing.Point(13, 22)
        Me.password_lb.Name = "password_lb"
        Me.password_lb.Size = New System.Drawing.Size(61, 13)
        Me.password_lb.TabIndex = 3
        Me.password_lb.Text = "Password:"
        '
        'back_bt
        '
        Me.back_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.back_bt.FlatAppearance.BorderSize = 0
        Me.back_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back_bt.Location = New System.Drawing.Point(15, 341)
        Me.back_bt.Name = "back_bt"
        Me.back_bt.Size = New System.Drawing.Size(75, 23)
        Me.back_bt.TabIndex = 2
        Me.back_bt.Text = "Back"
        Me.back_bt.UseVisualStyleBackColor = False
        '
        'logo_img
        '
        Me.logo_img.Image = Global.TrezorCrypt.My.Resources.Resources.trezorcrypt100
        Me.logo_img.Location = New System.Drawing.Point(187, 19)
        Me.logo_img.Name = "logo_img"
        Me.logo_img.Size = New System.Drawing.Size(100, 100)
        Me.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.logo_img.TabIndex = 1
        Me.logo_img.TabStop = False
        '
        'encrypt_device_bt
        '
        Me.encrypt_device_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.encrypt_device_bt.Enabled = False
        Me.encrypt_device_bt.FlatAppearance.BorderSize = 0
        Me.encrypt_device_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.encrypt_device_bt.Location = New System.Drawing.Point(351, 341)
        Me.encrypt_device_bt.Name = "encrypt_device_bt"
        Me.encrypt_device_bt.Size = New System.Drawing.Size(112, 23)
        Me.encrypt_device_bt.TabIndex = 0
        Me.encrypt_device_bt.Text = "Encrypt Device"
        Me.encrypt_device_bt.UseVisualStyleBackColor = False
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MenuStrip.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(475, 24)
        Me.MenuStrip.TabIndex = 11
        Me.MenuStrip.Text = "MenuStrip"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SettingToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'password_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 376)
        Me.Controls.Add(Me.main_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "password_page"
        Me.Text = "password_page"
        Me.main_panel.ResumeLayout(False)
        Me.main_panel.PerformLayout()
        Me.selected_gb.ResumeLayout(False)
        Me.selected_gb.PerformLayout()
        Me.encryption_gb.ResumeLayout(False)
        Me.encryption_gb.PerformLayout()
        CType(Me.logo_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_panel As System.Windows.Forms.Panel
    Friend WithEvents logo_img As System.Windows.Forms.PictureBox
    Friend WithEvents encrypt_device_bt As System.Windows.Forms.Button
    Friend WithEvents encryption_gb As System.Windows.Forms.GroupBox
    Friend WithEvents blocksize_cb As System.Windows.Forms.ComboBox
    Friend WithEvents blocksize_lb As System.Windows.Forms.Label
    Friend WithEvents algo_cb As System.Windows.Forms.ComboBox
    Friend WithEvents algo_lb As System.Windows.Forms.Label
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
    Friend WithEvents password_lb As System.Windows.Forms.Label
    Friend WithEvents back_bt As System.Windows.Forms.Button
    Friend WithEvents selected_gb As System.Windows.Forms.GroupBox
    Friend WithEvents serial_lb As System.Windows.Forms.Label
    Friend WithEvents size_lb As System.Windows.Forms.Label
    Friend WithEvents product_lb As System.Windows.Forms.Label
    Friend WithEvents device_lb As System.Windows.Forms.Label
    Friend WithEvents seriallb As System.Windows.Forms.Label
    Friend WithEvents sizelb As System.Windows.Forms.Label
    Friend WithEvents productname_lb As System.Windows.Forms.Label
    Friend WithEvents devicelb As System.Windows.Forms.Label
    Friend WithEvents min_chars_lb As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
