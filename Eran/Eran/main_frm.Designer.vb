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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowPublicKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowServerKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendPingToConnectedAccesNodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.main_panel = New System.Windows.Forms.Panel()
        Me.userlist_viewer = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.head_panel = New System.Windows.Forms.Panel()
        Me.eran_adr_txt = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.profil_img = New System.Windows.Forms.PictureBox()
        Me.status_lb = New System.Windows.Forms.Label()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.status_strip = New System.Windows.Forms.ToolStripSplitButton()
        Me.OfflineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.user_conextmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyEranAdressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFromListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.open_file_diag = New System.Windows.Forms.OpenFileDialog()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.notify_conextmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OfflineToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.available_timer = New System.Windows.Forms.Timer(Me.components)
        Me.OnlineBallon_tmr = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.main_panel.SuspendLayout()
        Me.head_panel.SuspendLayout()
        CType(Me.profil_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.user_conextmenu.SuspendLayout()
        Me.notify_conextmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.UsersToolStripMenuItem, Me.AccountToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(355, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem})
        Me.UsersToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisconnectToolStripMenuItem, Me.ConnectionToolStripMenuItem})
        Me.AccountToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect"
        '
        'ConnectionToolStripMenuItem
        '
        Me.ConnectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowPublicKeyToolStripMenuItem, Me.ToolStripSeparator1, Me.ShowServerKeyToolStripMenuItem})
        Me.ConnectionToolStripMenuItem.Name = "ConnectionToolStripMenuItem"
        Me.ConnectionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConnectionToolStripMenuItem.Text = "Connection"
        '
        'ShowPublicKeyToolStripMenuItem
        '
        Me.ShowPublicKeyToolStripMenuItem.Name = "ShowPublicKeyToolStripMenuItem"
        Me.ShowPublicKeyToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ShowPublicKeyToolStripMenuItem.Text = "Show PublicKey"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'ShowServerKeyToolStripMenuItem
        '
        Me.ShowServerKeyToolStripMenuItem.Name = "ShowServerKeyToolStripMenuItem"
        Me.ShowServerKeyToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ShowServerKeyToolStripMenuItem.Text = "Show Server Key"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.SendPingToConnectedAccesNodeToolStripMenuItem})
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'SendPingToConnectedAccesNodeToolStripMenuItem
        '
        Me.SendPingToConnectedAccesNodeToolStripMenuItem.Name = "SendPingToConnectedAccesNodeToolStripMenuItem"
        Me.SendPingToConnectedAccesNodeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SendPingToConnectedAccesNodeToolStripMenuItem.Text = "Send Ping"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem1, Me.ConnectToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TestToolStripMenuItem1
        '
        Me.TestToolStripMenuItem1.Name = "TestToolStripMenuItem1"
        Me.TestToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.TestToolStripMenuItem1.Text = "Test"
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ConnectToolStripMenuItem.Text = "Connect"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "offline16.png")
        Me.ImageList.Images.SetKeyName(1, "busy16.png")
        Me.ImageList.Images.SetKeyName(2, "online16.png")
        '
        'main_panel
        '
        Me.main_panel.Controls.Add(Me.userlist_viewer)
        Me.main_panel.Controls.Add(Me.head_panel)
        Me.main_panel.Controls.Add(Me.MenuStrip)
        Me.main_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_panel.Location = New System.Drawing.Point(0, 0)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(355, 463)
        Me.main_panel.TabIndex = 4
        '
        'userlist_viewer
        '
        Me.userlist_viewer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.userlist_viewer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userlist_viewer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.userlist_viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userlist_viewer.ForeColor = System.Drawing.SystemColors.Window
        Me.userlist_viewer.LabelEdit = True
        Me.userlist_viewer.Location = New System.Drawing.Point(0, 122)
        Me.userlist_viewer.MultiSelect = False
        Me.userlist_viewer.Name = "userlist_viewer"
        Me.userlist_viewer.Size = New System.Drawing.Size(355, 341)
        Me.userlist_viewer.SmallImageList = Me.ImageList
        Me.userlist_viewer.TabIndex = 3
        Me.userlist_viewer.UseCompatibleStateImageBehavior = False
        Me.userlist_viewer.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "User"
        Me.ColumnHeader1.Width = 115
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Eran adress"
        Me.ColumnHeader2.Width = 241
        '
        'head_panel
        '
        Me.head_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.head_panel.Controls.Add(Me.eran_adr_txt)
        Me.head_panel.Controls.Add(Me.TextBox1)
        Me.head_panel.Controls.Add(Me.profil_img)
        Me.head_panel.Controls.Add(Me.status_lb)
        Me.head_panel.Controls.Add(Me.StatusStrip)
        Me.head_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.head_panel.Location = New System.Drawing.Point(0, 24)
        Me.head_panel.Name = "head_panel"
        Me.head_panel.Size = New System.Drawing.Size(355, 98)
        Me.head_panel.TabIndex = 1
        '
        'eran_adr_txt
        '
        Me.eran_adr_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.eran_adr_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.eran_adr_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.eran_adr_txt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eran_adr_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eran_adr_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.eran_adr_txt.Location = New System.Drawing.Point(92, 52)
        Me.eran_adr_txt.Name = "eran_adr_txt"
        Me.eran_adr_txt.ReadOnly = True
        Me.eran_adr_txt.Size = New System.Drawing.Size(245, 14)
        Me.eran_adr_txt.TabIndex = 3
        Me.eran_adr_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(98, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(245, 22)
        Me.TextBox1.TabIndex = 7
        '
        'profil_img
        '
        Me.profil_img.BackgroundImage = Global.Eran.My.Resources.Resources.profilimage
        Me.profil_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.profil_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profil_img.Image = Global.Eran.My.Resources.Resources.offlineR
        Me.profil_img.Location = New System.Drawing.Point(12, 13)
        Me.profil_img.Name = "profil_img"
        Me.profil_img.Size = New System.Drawing.Size(74, 74)
        Me.profil_img.TabIndex = 6
        Me.profil_img.TabStop = False
        '
        'status_lb
        '
        Me.status_lb.AutoSize = True
        Me.status_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.status_lb.Location = New System.Drawing.Point(95, 70)
        Me.status_lb.Name = "status_lb"
        Me.status_lb.Size = New System.Drawing.Size(40, 13)
        Me.status_lb.TabIndex = 5
        Me.status_lb.Text = "Status:"
        '
        'StatusStrip
        '
        Me.StatusStrip.AutoSize = False
        Me.StatusStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status_strip})
        Me.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip.Location = New System.Drawing.Point(138, 65)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip.Size = New System.Drawing.Size(80, 22)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip"
        '
        'status_strip
        '
        Me.status_strip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OfflineToolStripMenuItem, Me.BusyToolStripMenuItem, Me.OnlineToolStripMenuItem})
        Me.status_strip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.status_strip.Image = Global.Eran.My.Resources.Resources.offline16
        Me.status_strip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.status_strip.Name = "status_strip"
        Me.status_strip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.status_strip.Size = New System.Drawing.Size(75, 20)
        Me.status_strip.Text = "Offline"
        '
        'OfflineToolStripMenuItem
        '
        Me.OfflineToolStripMenuItem.Image = Global.Eran.My.Resources.Resources.offline16
        Me.OfflineToolStripMenuItem.Name = "OfflineToolStripMenuItem"
        Me.OfflineToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.OfflineToolStripMenuItem.Text = "Offline"
        '
        'BusyToolStripMenuItem
        '
        Me.BusyToolStripMenuItem.Image = Global.Eran.My.Resources.Resources.busy16
        Me.BusyToolStripMenuItem.Name = "BusyToolStripMenuItem"
        Me.BusyToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.BusyToolStripMenuItem.Text = "Busy"
        '
        'OnlineToolStripMenuItem
        '
        Me.OnlineToolStripMenuItem.Image = Global.Eran.My.Resources.Resources.online16
        Me.OnlineToolStripMenuItem.Name = "OnlineToolStripMenuItem"
        Me.OnlineToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.OnlineToolStripMenuItem.Text = "Online"
        '
        'user_conextmenu
        '
        Me.user_conextmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartChatToolStripMenuItem, Me.EditUserToolStripMenuItem, Me.CopyEranAdressToolStripMenuItem, Me.DeleteFromListToolStripMenuItem})
        Me.user_conextmenu.Name = "ContextMenuStrip1"
        Me.user_conextmenu.Size = New System.Drawing.Size(165, 92)
        '
        'StartChatToolStripMenuItem
        '
        Me.StartChatToolStripMenuItem.Name = "StartChatToolStripMenuItem"
        Me.StartChatToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.StartChatToolStripMenuItem.Text = "Start Chat"
        '
        'EditUserToolStripMenuItem
        '
        Me.EditUserToolStripMenuItem.Name = "EditUserToolStripMenuItem"
        Me.EditUserToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EditUserToolStripMenuItem.Text = "Edit user"
        '
        'CopyEranAdressToolStripMenuItem
        '
        Me.CopyEranAdressToolStripMenuItem.Name = "CopyEranAdressToolStripMenuItem"
        Me.CopyEranAdressToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CopyEranAdressToolStripMenuItem.Text = "Copy Eran adress"
        '
        'DeleteFromListToolStripMenuItem
        '
        Me.DeleteFromListToolStripMenuItem.Name = "DeleteFromListToolStripMenuItem"
        Me.DeleteFromListToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DeleteFromListToolStripMenuItem.Text = "Delete from list"
        '
        'open_file_diag
        '
        Me.open_file_diag.Filter = "All|*.*|PNG|*.png|BMP|*.bmp|JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif"
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.notify_conextmenu
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "Eran"
        Me.NotifyIcon.Visible = True
        '
        'notify_conextmenu
        '
        Me.notify_conextmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StateToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.notify_conextmenu.Name = "notify_conextmenu"
        Me.notify_conextmenu.Size = New System.Drawing.Size(104, 70)
        '
        'StateToolStripMenuItem
        '
        Me.StateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnlineToolStripMenuItem1, Me.BusyToolStripMenuItem1, Me.OfflineToolStripMenuItem1})
        Me.StateToolStripMenuItem.Name = "StateToolStripMenuItem"
        Me.StateToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.StateToolStripMenuItem.Text = "State"
        '
        'OnlineToolStripMenuItem1
        '
        Me.OnlineToolStripMenuItem1.Image = Global.Eran.My.Resources.Resources.online16
        Me.OnlineToolStripMenuItem1.Name = "OnlineToolStripMenuItem1"
        Me.OnlineToolStripMenuItem1.Size = New System.Drawing.Size(110, 22)
        Me.OnlineToolStripMenuItem1.Text = "Online"
        '
        'BusyToolStripMenuItem1
        '
        Me.BusyToolStripMenuItem1.Image = Global.Eran.My.Resources.Resources.busy16
        Me.BusyToolStripMenuItem1.Name = "BusyToolStripMenuItem1"
        Me.BusyToolStripMenuItem1.Size = New System.Drawing.Size(110, 22)
        Me.BusyToolStripMenuItem1.Text = "Busy"
        '
        'OfflineToolStripMenuItem1
        '
        Me.OfflineToolStripMenuItem1.Image = Global.Eran.My.Resources.Resources.offline16
        Me.OfflineToolStripMenuItem1.Name = "OfflineToolStripMenuItem1"
        Me.OfflineToolStripMenuItem1.Size = New System.Drawing.Size(110, 22)
        Me.OfflineToolStripMenuItem1.Text = "Offline"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SaveFileDialog
        '
        '
        'available_timer
        '
        Me.available_timer.Interval = 60000
        '
        'OnlineBallon_tmr
        '
        Me.OnlineBallon_tmr.Interval = 5000
        '
        'main_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 463)
        Me.Controls.Add(Me.main_panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "main_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eran"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.main_panel.ResumeLayout(False)
        Me.main_panel.PerformLayout()
        Me.head_panel.ResumeLayout(False)
        Me.head_panel.PerformLayout()
        CType(Me.profil_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.user_conextmenu.ResumeLayout(False)
        Me.notify_conextmenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents main_panel As System.Windows.Forms.Panel
    Friend WithEvents user_conextmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyEranAdressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteFromListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartChatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents open_file_diag As System.Windows.Forms.OpenFileDialog
    Friend WithEvents userlist_viewer As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents head_panel As System.Windows.Forms.Panel
    Friend WithEvents status_lb As System.Windows.Forms.Label
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents status_strip As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents OfflineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents notify_conextmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlineToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OfflineToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents profil_img As System.Windows.Forms.PictureBox
    Friend WithEvents EditUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendPingToConnectedAccesNodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents eran_adr_txt As System.Windows.Forms.TextBox
    Friend WithEvents available_timer As System.Windows.Forms.Timer
    Friend WithEvents OnlineBallon_tmr As System.Windows.Forms.Timer
    Friend WithEvents TestToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowPublicKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ShowServerKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
