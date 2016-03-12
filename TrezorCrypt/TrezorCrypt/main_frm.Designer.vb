<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_frm))
        Me.main_panel = New System.Windows.Forms.Panel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.open_folderdiag = New System.Windows.Forms.Button()
        Me.sync_path_txt = New System.Windows.Forms.TextBox()
        Me.sync_path_lb = New System.Windows.Forms.Label()
        Me.product_label = New System.Windows.Forms.Label()
        Me.select_lb = New System.Windows.Forms.Label()
        Me.devices_view = New System.Windows.Forms.ListView()
        Me.device = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Productname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.size = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Serial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.img_lst = New System.Windows.Forms.ImageList(Me.components)
        Me.logo_img = New System.Windows.Forms.PictureBox()
        Me.next_bt = New System.Windows.Forms.Button()
        Me.folder_diag = New System.Windows.Forms.FolderBrowserDialog()
        Me.synDriveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.checkList = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.notifiy_context = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SettingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.main_panel.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.logo_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.notifiy_context.SuspendLayout()
        Me.SuspendLayout()
        '
        'main_panel
        '
        Me.main_panel.Controls.Add(Me.MenuStrip)
        Me.main_panel.Controls.Add(Me.open_folderdiag)
        Me.main_panel.Controls.Add(Me.sync_path_txt)
        Me.main_panel.Controls.Add(Me.sync_path_lb)
        Me.main_panel.Controls.Add(Me.product_label)
        Me.main_panel.Controls.Add(Me.select_lb)
        Me.main_panel.Controls.Add(Me.devices_view)
        Me.main_panel.Controls.Add(Me.logo_img)
        Me.main_panel.Controls.Add(Me.next_bt)
        Me.main_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_panel.Location = New System.Drawing.Point(0, 0)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(475, 376)
        Me.main_panel.TabIndex = 0
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MenuStrip.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(475, 24)
        Me.MenuStrip.TabIndex = 10
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
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'open_folderdiag
        '
        Me.open_folderdiag.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.open_folderdiag.FlatAppearance.BorderSize = 0
        Me.open_folderdiag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.open_folderdiag.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.open_folderdiag.Location = New System.Drawing.Point(349, 337)
        Me.open_folderdiag.Name = "open_folderdiag"
        Me.open_folderdiag.Size = New System.Drawing.Size(28, 23)
        Me.open_folderdiag.TabIndex = 7
        Me.open_folderdiag.Text = "..."
        Me.open_folderdiag.UseVisualStyleBackColor = False
        '
        'sync_path_txt
        '
        Me.sync_path_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.sync_path_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sync_path_txt.ForeColor = System.Drawing.Color.White
        Me.sync_path_txt.Location = New System.Drawing.Point(82, 339)
        Me.sync_path_txt.Name = "sync_path_txt"
        Me.sync_path_txt.ReadOnly = True
        Me.sync_path_txt.Size = New System.Drawing.Size(261, 20)
        Me.sync_path_txt.TabIndex = 6
        '
        'sync_path_lb
        '
        Me.sync_path_lb.AutoSize = True
        Me.sync_path_lb.Location = New System.Drawing.Point(9, 342)
        Me.sync_path_lb.Name = "sync_path_lb"
        Me.sync_path_lb.Size = New System.Drawing.Size(67, 13)
        Me.sync_path_lb.TabIndex = 5
        Me.sync_path_lb.Text = "Sync Path:"
        '
        'product_label
        '
        Me.product_label.AutoSize = True
        Me.product_label.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.product_label.Location = New System.Drawing.Point(177, 122)
        Me.product_label.Name = "product_label"
        Me.product_label.Size = New System.Drawing.Size(120, 22)
        Me.product_label.TabIndex = 4
        Me.product_label.Text = "TrezorCrypt"
        '
        'select_lb
        '
        Me.select_lb.AutoSize = True
        Me.select_lb.Location = New System.Drawing.Point(12, 154)
        Me.select_lb.Name = "select_lb"
        Me.select_lb.Size = New System.Drawing.Size(115, 13)
        Me.select_lb.TabIndex = 3
        Me.select_lb.Text = "Select your Device"
        '
        'devices_view
        '
        Me.devices_view.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.devices_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.devices_view.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.device, Me.Productname, Me.size, Me.Serial})
        Me.devices_view.ForeColor = System.Drawing.Color.White
        Me.devices_view.FullRowSelect = True
        Me.devices_view.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.devices_view.LargeImageList = Me.img_lst
        Me.devices_view.Location = New System.Drawing.Point(12, 170)
        Me.devices_view.MultiSelect = False
        Me.devices_view.Name = "devices_view"
        Me.devices_view.Size = New System.Drawing.Size(451, 161)
        Me.devices_view.SmallImageList = Me.img_lst
        Me.devices_view.TabIndex = 2
        Me.devices_view.UseCompatibleStateImageBehavior = False
        Me.devices_view.View = System.Windows.Forms.View.Details
        '
        'device
        '
        Me.device.Text = "Device"
        Me.device.Width = 51
        '
        'Productname
        '
        Me.Productname.Text = "Productname"
        Me.Productname.Width = 175
        '
        'size
        '
        Me.size.Text = "Size"
        Me.size.Width = 71
        '
        'Serial
        '
        Me.Serial.Text = "Serialnumber"
        Me.Serial.Width = 152
        '
        'img_lst
        '
        Me.img_lst.ImageStream = CType(resources.GetObject("img_lst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_lst.TransparentColor = System.Drawing.Color.Transparent
        Me.img_lst.Images.SetKeyName(0, "1457531223_hdd_unmount.png")
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
        'next_bt
        '
        Me.next_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.next_bt.FlatAppearance.BorderSize = 0
        Me.next_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.next_bt.Location = New System.Drawing.Point(388, 337)
        Me.next_bt.Name = "next_bt"
        Me.next_bt.Size = New System.Drawing.Size(75, 23)
        Me.next_bt.TabIndex = 0
        Me.next_bt.Text = "Next"
        Me.next_bt.UseVisualStyleBackColor = False
        '
        'synDriveTimer
        '
        Me.synDriveTimer.Enabled = True
        Me.synDriveTimer.Interval = 500
        '
        'checkList
        '
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.notifiy_context
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "TrezorCrypt"
        Me.NotifyIcon.Visible = True
        '
        'notifiy_context
        '
        Me.notifiy_context.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem1, Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.notifiy_context.Name = "ContextMenuStrip1"
        Me.notifiy_context.Size = New System.Drawing.Size(153, 92)
        '
        'SettingToolStripMenuItem1
        '
        Me.SettingToolStripMenuItem1.Name = "SettingToolStripMenuItem1"
        Me.SettingToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SettingToolStripMenuItem1.Text = "Setting"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'main_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(475, 376)
        Me.Controls.Add(Me.main_panel)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrezorCrypt"
        Me.main_panel.ResumeLayout(False)
        Me.main_panel.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.logo_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.notifiy_context.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_panel As System.Windows.Forms.Panel
    Friend WithEvents logo_img As System.Windows.Forms.PictureBox
    Friend WithEvents next_bt As System.Windows.Forms.Button
    Friend WithEvents devices_view As System.Windows.Forms.ListView
    Friend WithEvents device As System.Windows.Forms.ColumnHeader
    Friend WithEvents Productname As System.Windows.Forms.ColumnHeader
    Friend WithEvents size As System.Windows.Forms.ColumnHeader
    Friend WithEvents Serial As System.Windows.Forms.ColumnHeader
    Friend WithEvents img_lst As System.Windows.Forms.ImageList
    Friend WithEvents product_label As System.Windows.Forms.Label
    Friend WithEvents select_lb As System.Windows.Forms.Label
    Friend WithEvents open_folderdiag As System.Windows.Forms.Button
    Friend WithEvents sync_path_txt As System.Windows.Forms.TextBox
    Friend WithEvents sync_path_lb As System.Windows.Forms.Label
    Friend WithEvents folder_diag As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents synDriveTimer As System.Windows.Forms.Timer
    Friend WithEvents checkList As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents notifiy_context As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
