<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CryptMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CryptMain))
        Me.isEmbedUSB = New System.Windows.Forms.Timer(Me.components)
        Me.fsw = New System.IO.FileSystemWatcher()
        Me.main_panel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.statebar = New System.Windows.Forms.ProgressBar()
        Me.state_lst = New System.Windows.Forms.ListBox()
        Me.unlock_device_gb = New System.Windows.Forms.GroupBox()
        Me.state_lb = New System.Windows.Forms.Label()
        Me.serial_lb = New System.Windows.Forms.Label()
        Me.productname_lb = New System.Windows.Forms.Label()
        Me.size_lb = New System.Windows.Forms.Label()
        Me.devicelb = New System.Windows.Forms.Label()
        Me.product_lb = New System.Windows.Forms.Label()
        Me.sizelb = New System.Windows.Forms.Label()
        Me.device_lb = New System.Windows.Forms.Label()
        Me.seriallb = New System.Windows.Forms.Label()
        Me.product_label = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.DeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnlockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncryptionSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.prg = New System.Windows.Forms.Timer(Me.components)
        Me.lock_img = New System.Windows.Forms.PictureBox()
        Me.logo_img = New System.Windows.Forms.PictureBox()
        CType(Me.fsw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.main_panel.SuspendLayout()
        Me.unlock_device_gb.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.lock_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'isEmbedUSB
        '
        Me.isEmbedUSB.Enabled = True
        Me.isEmbedUSB.Interval = 1000
        '
        'fsw
        '
        Me.fsw.EnableRaisingEvents = True
        Me.fsw.IncludeSubdirectories = True
        Me.fsw.SynchronizingObject = Me
        '
        'main_panel
        '
        Me.main_panel.Controls.Add(Me.Label1)
        Me.main_panel.Controls.Add(Me.statebar)
        Me.main_panel.Controls.Add(Me.state_lst)
        Me.main_panel.Controls.Add(Me.unlock_device_gb)
        Me.main_panel.Controls.Add(Me.product_label)
        Me.main_panel.Controls.Add(Me.logo_img)
        Me.main_panel.Controls.Add(Me.MenuStrip)
        Me.main_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_panel.Location = New System.Drawing.Point(0, 0)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(465, 386)
        Me.main_panel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "BETA"
        '
        'statebar
        '
        Me.statebar.Location = New System.Drawing.Point(3, 350)
        Me.statebar.Name = "statebar"
        Me.statebar.Size = New System.Drawing.Size(459, 16)
        Me.statebar.TabIndex = 7
        '
        'state_lst
        '
        Me.state_lst.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.state_lst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.state_lst.ForeColor = System.Drawing.Color.White
        Me.state_lst.FormattingEnabled = True
        Me.state_lst.Location = New System.Drawing.Point(3, 165)
        Me.state_lst.Name = "state_lst"
        Me.state_lst.Size = New System.Drawing.Size(459, 184)
        Me.state_lst.TabIndex = 6
        '
        'unlock_device_gb
        '
        Me.unlock_device_gb.Controls.Add(Me.lock_img)
        Me.unlock_device_gb.Controls.Add(Me.state_lb)
        Me.unlock_device_gb.Controls.Add(Me.serial_lb)
        Me.unlock_device_gb.Controls.Add(Me.productname_lb)
        Me.unlock_device_gb.Controls.Add(Me.size_lb)
        Me.unlock_device_gb.Controls.Add(Me.devicelb)
        Me.unlock_device_gb.Controls.Add(Me.product_lb)
        Me.unlock_device_gb.Controls.Add(Me.sizelb)
        Me.unlock_device_gb.Controls.Add(Me.device_lb)
        Me.unlock_device_gb.Controls.Add(Me.seriallb)
        Me.unlock_device_gb.ForeColor = System.Drawing.Color.White
        Me.unlock_device_gb.Location = New System.Drawing.Point(118, 37)
        Me.unlock_device_gb.Name = "unlock_device_gb"
        Me.unlock_device_gb.Size = New System.Drawing.Size(335, 100)
        Me.unlock_device_gb.TabIndex = 5
        Me.unlock_device_gb.TabStop = False
        Me.unlock_device_gb.Text = "Unlock Device"
        '
        'state_lb
        '
        Me.state_lb.AutoSize = True
        Me.state_lb.Location = New System.Drawing.Point(258, 76)
        Me.state_lb.Name = "state_lb"
        Me.state_lb.Size = New System.Drawing.Size(49, 13)
        Me.state_lb.TabIndex = 16
        Me.state_lb.Text = "Status:"
        '
        'serial_lb
        '
        Me.serial_lb.AutoSize = True
        Me.serial_lb.Location = New System.Drawing.Point(81, 59)
        Me.serial_lb.Name = "serial_lb"
        Me.serial_lb.Size = New System.Drawing.Size(13, 13)
        Me.serial_lb.TabIndex = 15
        Me.serial_lb.Text = "-"
        '
        'productname_lb
        '
        Me.productname_lb.AutoSize = True
        Me.productname_lb.Location = New System.Drawing.Point(6, 25)
        Me.productname_lb.Name = "productname_lb"
        Me.productname_lb.Size = New System.Drawing.Size(79, 13)
        Me.productname_lb.TabIndex = 9
        Me.productname_lb.Text = "Productname:"
        '
        'size_lb
        '
        Me.size_lb.AutoSize = True
        Me.size_lb.Location = New System.Drawing.Point(81, 76)
        Me.size_lb.Name = "size_lb"
        Me.size_lb.Size = New System.Drawing.Size(13, 13)
        Me.size_lb.TabIndex = 14
        Me.size_lb.Text = "-"
        '
        'devicelb
        '
        Me.devicelb.AutoSize = True
        Me.devicelb.Location = New System.Drawing.Point(36, 42)
        Me.devicelb.Name = "devicelb"
        Me.devicelb.Size = New System.Drawing.Size(49, 13)
        Me.devicelb.TabIndex = 8
        Me.devicelb.Text = "Device:"
        '
        'product_lb
        '
        Me.product_lb.AutoSize = True
        Me.product_lb.Location = New System.Drawing.Point(81, 25)
        Me.product_lb.Name = "product_lb"
        Me.product_lb.Size = New System.Drawing.Size(13, 13)
        Me.product_lb.TabIndex = 13
        Me.product_lb.Text = "-"
        '
        'sizelb
        '
        Me.sizelb.AutoSize = True
        Me.sizelb.Location = New System.Drawing.Point(48, 76)
        Me.sizelb.Name = "sizelb"
        Me.sizelb.Size = New System.Drawing.Size(37, 13)
        Me.sizelb.TabIndex = 10
        Me.sizelb.Text = "Size:"
        '
        'device_lb
        '
        Me.device_lb.AutoSize = True
        Me.device_lb.Location = New System.Drawing.Point(81, 42)
        Me.device_lb.Name = "device_lb"
        Me.device_lb.Size = New System.Drawing.Size(13, 13)
        Me.device_lb.TabIndex = 12
        Me.device_lb.Text = "-"
        '
        'seriallb
        '
        Me.seriallb.AutoSize = True
        Me.seriallb.Location = New System.Drawing.Point(36, 59)
        Me.seriallb.Name = "seriallb"
        Me.seriallb.Size = New System.Drawing.Size(49, 13)
        Me.seriallb.TabIndex = 11
        Me.seriallb.Text = "Serial:"
        '
        'product_label
        '
        Me.product_label.AutoSize = True
        Me.product_label.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.product_label.Location = New System.Drawing.Point(2, 140)
        Me.product_label.Name = "product_label"
        Me.product_label.Size = New System.Drawing.Size(120, 22)
        Me.product_label.TabIndex = 4
        Me.product_label.Text = "TrezorCrypt"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MenuStrip.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeviceToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(465, 24)
        Me.MenuStrip.TabIndex = 9
        Me.MenuStrip.Text = "MenuStrip"
        '
        'DeviceToolStripMenuItem
        '
        Me.DeviceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LockToolStripMenuItem, Me.UnlockToolStripMenuItem, Me.EncryptionSettingToolStripMenuItem, Me.LockoutToolStripMenuItem})
        Me.DeviceToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DeviceToolStripMenuItem.Name = "DeviceToolStripMenuItem"
        Me.DeviceToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.DeviceToolStripMenuItem.Text = "Device"
        '
        'LockToolStripMenuItem
        '
        Me.LockToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LockToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LockToolStripMenuItem.Name = "LockToolStripMenuItem"
        Me.LockToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.LockToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.LockToolStripMenuItem.Text = "Lock"
        '
        'UnlockToolStripMenuItem
        '
        Me.UnlockToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.UnlockToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UnlockToolStripMenuItem.Name = "UnlockToolStripMenuItem"
        Me.UnlockToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.UnlockToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.UnlockToolStripMenuItem.Text = "Unlock"
        '
        'EncryptionSettingToolStripMenuItem
        '
        Me.EncryptionSettingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EncryptionSettingToolStripMenuItem.Enabled = False
        Me.EncryptionSettingToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EncryptionSettingToolStripMenuItem.Name = "EncryptionSettingToolStripMenuItem"
        Me.EncryptionSettingToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.EncryptionSettingToolStripMenuItem.Text = "Encryption Setting"
        '
        'LockoutToolStripMenuItem
        '
        Me.LockoutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LockoutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LockoutToolStripMenuItem.Name = "LockoutToolStripMenuItem"
        Me.LockoutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.LockoutToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.LockoutToolStripMenuItem.Text = "Lockout"
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
        'prg
        '
        Me.prg.Interval = 1
        '
        'lock_img
        '
        Me.lock_img.Image = Global.TrezorCrypt.My.Resources.Resources._1457579322_lock
        Me.lock_img.Location = New System.Drawing.Point(306, 74)
        Me.lock_img.Name = "lock_img"
        Me.lock_img.Size = New System.Drawing.Size(16, 16)
        Me.lock_img.TabIndex = 17
        Me.lock_img.TabStop = False
        '
        'logo_img
        '
        Me.logo_img.Image = Global.TrezorCrypt.My.Resources.Resources.trezorcrypt100
        Me.logo_img.Location = New System.Drawing.Point(12, 37)
        Me.logo_img.Name = "logo_img"
        Me.logo_img.Size = New System.Drawing.Size(100, 100)
        Me.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.logo_img.TabIndex = 1
        Me.logo_img.TabStop = False
        '
        'CryptMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(465, 386)
        Me.Controls.Add(Me.main_panel)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "CryptMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrezorCrypt"
        CType(Me.fsw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.main_panel.ResumeLayout(False)
        Me.main_panel.PerformLayout()
        Me.unlock_device_gb.ResumeLayout(False)
        Me.unlock_device_gb.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.lock_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fsw As System.IO.FileSystemWatcher
    Friend WithEvents main_panel As System.Windows.Forms.Panel
    Friend WithEvents product_label As System.Windows.Forms.Label
    Friend WithEvents logo_img As System.Windows.Forms.PictureBox
    Friend WithEvents unlock_device_gb As System.Windows.Forms.GroupBox
    Friend WithEvents serial_lb As System.Windows.Forms.Label
    Friend WithEvents productname_lb As System.Windows.Forms.Label
    Friend WithEvents size_lb As System.Windows.Forms.Label
    Friend WithEvents devicelb As System.Windows.Forms.Label
    Friend WithEvents product_lb As System.Windows.Forms.Label
    Friend WithEvents sizelb As System.Windows.Forms.Label
    Friend WithEvents device_lb As System.Windows.Forms.Label
    Friend WithEvents seriallb As System.Windows.Forms.Label
    Friend WithEvents state_lb As System.Windows.Forms.Label
    Friend WithEvents lock_img As System.Windows.Forms.PictureBox
    Friend WithEvents state_lst As System.Windows.Forms.ListBox
    Friend WithEvents isEmbedUSB As System.Windows.Forms.Timer
    Friend WithEvents statebar As System.Windows.Forms.ProgressBar
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents DeviceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnlockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncryptionSettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LockoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents prg As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
