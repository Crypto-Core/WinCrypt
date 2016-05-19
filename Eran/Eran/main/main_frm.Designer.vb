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
        Me.ShowServerKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendPingToConnectedAccesNodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.main_panel = New System.Windows.Forms.Panel()
        Me.userlist_viewer = New System.Windows.Forms.ListView()
        Me.user_column = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eran_adr_column = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.donate_bt = New System.Windows.Forms.Button()
        Me.head_panel = New System.Windows.Forms.Panel()
        Me.eran_adr_txt = New System.Windows.Forms.TextBox()
        Me.alias_txt = New System.Windows.Forms.TextBox()
        Me.profil_img = New System.Windows.Forms.PictureBox()
        Me.status_lb = New System.Windows.Forms.Label()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.status_strip = New System.Windows.Forms.ToolStripSplitButton()
        Me.OfflineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.user_conextmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyEranAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFromListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlockingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReloadListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.export_acc_sd = New System.Windows.Forms.SaveFileDialog()
        Me.import_acc_sd = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip.SuspendLayout()
        Me.main_panel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.head_panel.SuspendLayout()
        CType(Me.profil_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.user_conextmenu.SuspendLayout()
        Me.notify_conextmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.UsersToolStripMenuItem, Me.AccountToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(355, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
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
        Me.ExitToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ExitToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ExitToolStripMenuItem1.Image = Global.Eran.My.Resources.Resources.Close_16
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
        Me.AddUserToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AddUserToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AddUserToolStripMenuItem.Image = Global.Eran.My.Resources.Resources.Add_New_16
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisconnectToolStripMenuItem, Me.ConnectionToolStripMenuItem, Me.ExportAccountToolStripMenuItem, Me.ImportAccountToolStripMenuItem})
        Me.AccountToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DisconnectToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DisconnectToolStripMenuItem.Image = Global.Eran.My.Resources.Resources.Network_Disconnected_16
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect"
        '
        'ConnectionToolStripMenuItem
        '
        Me.ConnectionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ConnectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowPublicKeyToolStripMenuItem, Me.ShowServerKeyToolStripMenuItem})
        Me.ConnectionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ConnectionToolStripMenuItem.Name = "ConnectionToolStripMenuItem"
        Me.ConnectionToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ConnectionToolStripMenuItem.Text = "Connection"
        '
        'ShowPublicKeyToolStripMenuItem
        '
        Me.ShowPublicKeyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ShowPublicKeyToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ShowPublicKeyToolStripMenuItem.Image = CType(resources.GetObject("ShowPublicKeyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowPublicKeyToolStripMenuItem.Name = "ShowPublicKeyToolStripMenuItem"
        Me.ShowPublicKeyToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ShowPublicKeyToolStripMenuItem.Text = "Show PublicKey"
        '
        'ShowServerKeyToolStripMenuItem
        '
        Me.ShowServerKeyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ShowServerKeyToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ShowServerKeyToolStripMenuItem.Image = CType(resources.GetObject("ShowServerKeyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowServerKeyToolStripMenuItem.Name = "ShowServerKeyToolStripMenuItem"
        Me.ShowServerKeyToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ShowServerKeyToolStripMenuItem.Text = "Show Server Key"
        '
        'ExportAccountToolStripMenuItem
        '
        Me.ExportAccountToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ExportAccountToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExportAccountToolStripMenuItem.Name = "ExportAccountToolStripMenuItem"
        Me.ExportAccountToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ExportAccountToolStripMenuItem.Text = "Export Account"
        '
        'ImportAccountToolStripMenuItem
        '
        Me.ImportAccountToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ImportAccountToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ImportAccountToolStripMenuItem.Name = "ImportAccountToolStripMenuItem"
        Me.ImportAccountToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ImportAccountToolStripMenuItem.Text = "Import Account"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.SendPingToConnectedAccesNodeToolStripMenuItem, Me.LanguageToolStripMenuItem})
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SettingsToolStripMenuItem.Image = Global.Eran.My.Resources.Resources.Settings_01_16
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'SendPingToConnectedAccesNodeToolStripMenuItem
        '
        Me.SendPingToConnectedAccesNodeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SendPingToConnectedAccesNodeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SendPingToConnectedAccesNodeToolStripMenuItem.Image = Global.Eran.My.Resources.Resources.Server_01_16
        Me.SendPingToConnectedAccesNodeToolStripMenuItem.Name = "SendPingToConnectedAccesNodeToolStripMenuItem"
        Me.SendPingToConnectedAccesNodeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.SendPingToConnectedAccesNodeToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SendPingToConnectedAccesNodeToolStripMenuItem.Text = "Send Ping"
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LanguageToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        Me.LanguageToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.LanguageToolStripMenuItem.Text = "Language"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.CheckUpdateToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Image = Global.Eran.My.Resources.Resources.Dialog_Box_About_16
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CheckUpdateToolStripMenuItem
        '
        Me.CheckUpdateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CheckUpdateToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CheckUpdateToolStripMenuItem.Image = Global.Eran.My.Resources.Resources.Reload_16
        Me.CheckUpdateToolStripMenuItem.Name = "CheckUpdateToolStripMenuItem"
        Me.CheckUpdateToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CheckUpdateToolStripMenuItem.Text = "Check Update"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "offline16.png")
        Me.ImageList.Images.SetKeyName(1, "busy16.png")
        Me.ImageList.Images.SetKeyName(2, "online16.png")
        Me.ImageList.Images.SetKeyName(3, "block.png")
        Me.ImageList.Images.SetKeyName(4, "warning.png")
        '
        'main_panel
        '
        Me.main_panel.Controls.Add(Me.userlist_viewer)
        Me.main_panel.Controls.Add(Me.Panel1)
        Me.main_panel.Controls.Add(Me.head_panel)
        Me.main_panel.Controls.Add(Me.MenuStrip)
        Me.main_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_panel.Location = New System.Drawing.Point(0, 0)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(355, 560)
        Me.main_panel.TabIndex = 4
        '
        'userlist_viewer
        '
        Me.userlist_viewer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.userlist_viewer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userlist_viewer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.user_column, Me.eran_adr_column})
        Me.userlist_viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userlist_viewer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userlist_viewer.ForeColor = System.Drawing.SystemColors.Window
        Me.userlist_viewer.LabelEdit = True
        Me.userlist_viewer.Location = New System.Drawing.Point(0, 122)
        Me.userlist_viewer.MultiSelect = False
        Me.userlist_viewer.Name = "userlist_viewer"
        Me.userlist_viewer.Size = New System.Drawing.Size(355, 359)
        Me.userlist_viewer.SmallImageList = Me.ImageList
        Me.userlist_viewer.TabIndex = 3
        Me.userlist_viewer.UseCompatibleStateImageBehavior = False
        Me.userlist_viewer.View = System.Windows.Forms.View.Details
        '
        'user_column
        '
        Me.user_column.Text = "User"
        Me.user_column.Width = 132
        '
        'eran_adr_column
        '
        Me.eran_adr_column.Text = "Eran address"
        Me.eran_adr_column.Width = 222
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.Controls.Add(Me.donate_bt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 481)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 79)
        Me.Panel1.TabIndex = 4
        Me.Panel1.Visible = False
        '
        'donate_bt
        '
        Me.donate_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.donate_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.donate_bt.FlatAppearance.BorderSize = 0
        Me.donate_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.donate_bt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.donate_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.donate_bt.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.donate_bt.ImageIndex = 4
        Me.donate_bt.ImageList = Me.ImageList
        Me.donate_bt.Location = New System.Drawing.Point(91, 20)
        Me.donate_bt.Name = "donate_bt"
        Me.donate_bt.Size = New System.Drawing.Size(173, 38)
        Me.donate_bt.TabIndex = 3
        Me.donate_bt.Text = "DONATE"
        Me.donate_bt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.donate_bt.UseVisualStyleBackColor = False
        '
        'head_panel
        '
        Me.head_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.head_panel.Controls.Add(Me.eran_adr_txt)
        Me.head_panel.Controls.Add(Me.alias_txt)
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
        Me.eran_adr_txt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eran_adr_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.eran_adr_txt.Location = New System.Drawing.Point(92, 52)
        Me.eran_adr_txt.Name = "eran_adr_txt"
        Me.eran_adr_txt.ReadOnly = True
        Me.eran_adr_txt.Size = New System.Drawing.Size(245, 14)
        Me.eran_adr_txt.TabIndex = 3
        Me.eran_adr_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.eran_adr_txt, "Eran address")
        '
        'alias_txt
        '
        Me.alias_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.alias_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.alias_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.alias_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alias_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.alias_txt.Location = New System.Drawing.Point(98, 20)
        Me.alias_txt.MaxLength = 20
        Me.alias_txt.Name = "alias_txt"
        Me.alias_txt.Size = New System.Drawing.Size(245, 22)
        Me.alias_txt.TabIndex = 7
        Me.alias_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.alias_txt, "Alias name")
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
        Me.status_lb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.status_lb.Location = New System.Drawing.Point(95, 70)
        Me.status_lb.Name = "status_lb"
        Me.status_lb.Size = New System.Drawing.Size(42, 13)
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
        Me.OfflineToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OfflineToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OfflineToolStripMenuItem.Image = Global.Eran.My.Resources.Resources.offline16
        Me.OfflineToolStripMenuItem.Name = "OfflineToolStripMenuItem"
        Me.OfflineToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.OfflineToolStripMenuItem.Text = "Offline"
        '
        'BusyToolStripMenuItem
        '
        Me.BusyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BusyToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BusyToolStripMenuItem.Image = Global.Eran.My.Resources.Resources.busy16
        Me.BusyToolStripMenuItem.Name = "BusyToolStripMenuItem"
        Me.BusyToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.BusyToolStripMenuItem.Text = "Busy"
        '
        'OnlineToolStripMenuItem
        '
        Me.OnlineToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OnlineToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OnlineToolStripMenuItem.Image = Global.Eran.My.Resources.Resources.online16
        Me.OnlineToolStripMenuItem.Name = "OnlineToolStripMenuItem"
        Me.OnlineToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.OnlineToolStripMenuItem.Text = "Online"
        '
        'user_conextmenu
        '
        Me.user_conextmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.user_conextmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartChatToolStripMenuItem, Me.CopyEranAddressToolStripMenuItem, Me.DeleteFromListToolStripMenuItem, Me.BlockingToolStripMenuItem, Me.ToolStripSeparator1, Me.ReloadListToolStripMenuItem})
        Me.user_conextmenu.Name = "ContextMenuStrip1"
        Me.user_conextmenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.user_conextmenu.ShowImageMargin = False
        Me.user_conextmenu.Size = New System.Drawing.Size(147, 120)
        '
        'StartChatToolStripMenuItem
        '
        Me.StartChatToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.StartChatToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.StartChatToolStripMenuItem.Name = "StartChatToolStripMenuItem"
        Me.StartChatToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.StartChatToolStripMenuItem.Text = "Start Chat"
        '
        'CopyEranAddressToolStripMenuItem
        '
        Me.CopyEranAddressToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CopyEranAddressToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CopyEranAddressToolStripMenuItem.Name = "CopyEranAddressToolStripMenuItem"
        Me.CopyEranAddressToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CopyEranAddressToolStripMenuItem.Text = "Copy Eran address"
        '
        'DeleteFromListToolStripMenuItem
        '
        Me.DeleteFromListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DeleteFromListToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DeleteFromListToolStripMenuItem.Name = "DeleteFromListToolStripMenuItem"
        Me.DeleteFromListToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.DeleteFromListToolStripMenuItem.Text = "Delete from list"
        '
        'BlockingToolStripMenuItem
        '
        Me.BlockingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BlockingToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BlockingToolStripMenuItem.Name = "BlockingToolStripMenuItem"
        Me.BlockingToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.BlockingToolStripMenuItem.Text = "Blocking"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'ReloadListToolStripMenuItem
        '
        Me.ReloadListToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReloadListToolStripMenuItem.Name = "ReloadListToolStripMenuItem"
        Me.ReloadListToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ReloadListToolStripMenuItem.Text = "Reload List"
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
        Me.notify_conextmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.notify_conextmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StateToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.notify_conextmenu.Name = "notify_conextmenu"
        Me.notify_conextmenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.notify_conextmenu.ShowImageMargin = False
        Me.notify_conextmenu.Size = New System.Drawing.Size(79, 70)
        '
        'StateToolStripMenuItem
        '
        Me.StateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.StateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnlineToolStripMenuItem1, Me.BusyToolStripMenuItem1, Me.OfflineToolStripMenuItem1})
        Me.StateToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.StateToolStripMenuItem.Name = "StateToolStripMenuItem"
        Me.StateToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.StateToolStripMenuItem.Text = "State"
        '
        'OnlineToolStripMenuItem1
        '
        Me.OnlineToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OnlineToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.OnlineToolStripMenuItem1.Image = Global.Eran.My.Resources.Resources.online16
        Me.OnlineToolStripMenuItem1.Name = "OnlineToolStripMenuItem1"
        Me.OnlineToolStripMenuItem1.Size = New System.Drawing.Size(110, 22)
        Me.OnlineToolStripMenuItem1.Text = "Online"
        '
        'BusyToolStripMenuItem1
        '
        Me.BusyToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BusyToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.BusyToolStripMenuItem1.Image = Global.Eran.My.Resources.Resources.busy16
        Me.BusyToolStripMenuItem1.Name = "BusyToolStripMenuItem1"
        Me.BusyToolStripMenuItem1.Size = New System.Drawing.Size(110, 22)
        Me.BusyToolStripMenuItem1.Text = "Busy"
        '
        'OfflineToolStripMenuItem1
        '
        Me.OfflineToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OfflineToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.OfflineToolStripMenuItem1.Image = Global.Eran.My.Resources.Resources.offline16
        Me.OfflineToolStripMenuItem1.Name = "OfflineToolStripMenuItem1"
        Me.OfflineToolStripMenuItem1.Size = New System.Drawing.Size(110, 22)
        Me.OfflineToolStripMenuItem1.Text = "Offline"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SaveFileDialog
        '
        '
        'available_timer
        '
        Me.available_timer.Enabled = True
        Me.available_timer.Interval = 10000
        '
        'OnlineBallon_tmr
        '
        Me.OnlineBallon_tmr.Interval = 5000
        '
        'export_acc_sd
        '
        Me.export_acc_sd.Filter = "Eran Account|*.era"
        '
        'import_acc_sd
        '
        Me.import_acc_sd.Filter = "Eran Account|*.era"
        '
        'main_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 560)
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
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents CopyEranAddressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteFromListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartChatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents open_file_diag As System.Windows.Forms.OpenFileDialog
    Friend WithEvents userlist_viewer As System.Windows.Forms.ListView
    Friend WithEvents user_column As System.Windows.Forms.ColumnHeader
    Friend WithEvents eran_adr_column As System.Windows.Forms.ColumnHeader
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
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendPingToConnectedAccesNodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents alias_txt As System.Windows.Forms.TextBox
    Friend WithEvents eran_adr_txt As System.Windows.Forms.TextBox
    Friend WithEvents available_timer As System.Windows.Forms.Timer
    Friend WithEvents OnlineBallon_tmr As System.Windows.Forms.Timer
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowPublicKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowServerKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents BlockingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReloadListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents donate_bt As System.Windows.Forms.Button
    Friend WithEvents LanguageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents export_acc_sd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ImportAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents import_acc_sd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CheckUpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
