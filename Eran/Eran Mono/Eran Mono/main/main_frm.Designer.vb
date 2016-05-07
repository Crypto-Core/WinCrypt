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
        Me.userlist_viewer = New System.Windows.Forms.ListView()
        Me.user_column = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eran_adr_column = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.eran_adr_txt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.alias_txt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.help_bt = New System.Windows.Forms.Button()
        Me.tools_bt = New System.Windows.Forms.Button()
        Me.account_bt = New System.Windows.Forms.Button()
        Me.users_bt = New System.Windows.Forms.Button()
        Me.file_bt = New System.Windows.Forms.Button()
        Me.loginStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.adduser_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.conStateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OnlineStateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.main_panel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.loginStrip.SuspendLayout()
        Me.UsersStrip.SuspendLayout()
        Me.AccountStrip.SuspendLayout()
        Me.ToolsStrip.SuspendLayout()
        Me.HelpStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'main_panel
        '
        Me.main_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.main_panel.Controls.Add(Me.userlist_viewer)
        Me.main_panel.Controls.Add(Me.Panel2)
        Me.main_panel.Controls.Add(Me.Panel1)
        Me.main_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_panel.Location = New System.Drawing.Point(0, 0)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(356, 576)
        Me.main_panel.TabIndex = 0
        '
        'userlist_viewer
        '
        Me.userlist_viewer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.userlist_viewer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userlist_viewer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.user_column, Me.eran_adr_column})
        Me.userlist_viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userlist_viewer.Font = New System.Drawing.Font("Ubuntu Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userlist_viewer.ForeColor = System.Drawing.SystemColors.Window
        Me.userlist_viewer.LabelEdit = True
        Me.userlist_viewer.Location = New System.Drawing.Point(0, 144)
        Me.userlist_viewer.MultiSelect = False
        Me.userlist_viewer.Name = "userlist_viewer"
        Me.userlist_viewer.Size = New System.Drawing.Size(356, 432)
        Me.userlist_viewer.TabIndex = 4
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel2.Controls.Add(Me.eran_adr_txt)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.alias_txt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 109)
        Me.Panel2.TabIndex = 1
        '
        'eran_adr_txt
        '
        Me.eran_adr_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.eran_adr_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.eran_adr_txt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eran_adr_txt.Font = New System.Drawing.Font("Ubuntu Condensed", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eran_adr_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.eran_adr_txt.Location = New System.Drawing.Point(96, 66)
        Me.eran_adr_txt.Name = "eran_adr_txt"
        Me.eran_adr_txt.ReadOnly = True
        Me.eran_adr_txt.Size = New System.Drawing.Size(250, 15)
        Me.eran_adr_txt.TabIndex = 11
        Me.eran_adr_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Eran_Mono.My.Resources.Resources.profilimage
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.Eran_Mono.My.Resources.Resources.offlineR
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'alias_txt
        '
        Me.alias_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.alias_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.alias_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.alias_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alias_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.alias_txt.Location = New System.Drawing.Point(98, 26)
        Me.alias_txt.MaxLength = 20
        Me.alias_txt.Name = "alias_txt"
        Me.alias_txt.Size = New System.Drawing.Size(245, 22)
        Me.alias_txt.TabIndex = 8
        Me.alias_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.help_bt)
        Me.Panel1.Controls.Add(Me.tools_bt)
        Me.Panel1.Controls.Add(Me.account_bt)
        Me.Panel1.Controls.Add(Me.users_bt)
        Me.Panel1.Controls.Add(Me.file_bt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 35)
        Me.Panel1.TabIndex = 0
        '
        'help_bt
        '
        Me.help_bt.AutoSize = True
        Me.help_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.help_bt.Dock = System.Windows.Forms.DockStyle.Left
        Me.help_bt.FlatAppearance.BorderSize = 0
        Me.help_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.help_bt.Location = New System.Drawing.Point(200, 0)
        Me.help_bt.Name = "help_bt"
        Me.help_bt.Size = New System.Drawing.Size(47, 35)
        Me.help_bt.TabIndex = 12
        Me.help_bt.Text = "Help"
        Me.help_bt.UseVisualStyleBackColor = False
        '
        'tools_bt
        '
        Me.tools_bt.AutoSize = True
        Me.tools_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tools_bt.Dock = System.Windows.Forms.DockStyle.Left
        Me.tools_bt.FlatAppearance.BorderSize = 0
        Me.tools_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tools_bt.Location = New System.Drawing.Point(153, 0)
        Me.tools_bt.Name = "tools_bt"
        Me.tools_bt.Size = New System.Drawing.Size(47, 35)
        Me.tools_bt.TabIndex = 11
        Me.tools_bt.Text = "Tools"
        Me.tools_bt.UseVisualStyleBackColor = False
        '
        'account_bt
        '
        Me.account_bt.AutoSize = True
        Me.account_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.account_bt.Dock = System.Windows.Forms.DockStyle.Left
        Me.account_bt.FlatAppearance.BorderSize = 0
        Me.account_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.account_bt.Location = New System.Drawing.Point(94, 0)
        Me.account_bt.Name = "account_bt"
        Me.account_bt.Size = New System.Drawing.Size(59, 35)
        Me.account_bt.TabIndex = 10
        Me.account_bt.Text = "Account"
        Me.account_bt.UseVisualStyleBackColor = False
        '
        'users_bt
        '
        Me.users_bt.AutoSize = True
        Me.users_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.users_bt.Dock = System.Windows.Forms.DockStyle.Left
        Me.users_bt.FlatAppearance.BorderSize = 0
        Me.users_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.users_bt.Location = New System.Drawing.Point(47, 0)
        Me.users_bt.Name = "users_bt"
        Me.users_bt.Size = New System.Drawing.Size(47, 35)
        Me.users_bt.TabIndex = 9
        Me.users_bt.Text = "Users"
        Me.users_bt.UseVisualStyleBackColor = False
        '
        'file_bt
        '
        Me.file_bt.AutoSize = True
        Me.file_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.file_bt.Dock = System.Windows.Forms.DockStyle.Left
        Me.file_bt.FlatAppearance.BorderSize = 0
        Me.file_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.file_bt.Location = New System.Drawing.Point(0, 0)
        Me.file_bt.Name = "file_bt"
        Me.file_bt.Size = New System.Drawing.Size(47, 35)
        Me.file_bt.TabIndex = 8
        Me.file_bt.Text = "Login"
        Me.file_bt.UseVisualStyleBackColor = False
        '
        'loginStrip
        '
        Me.loginStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.loginStrip.Font = New System.Drawing.Font("Ubuntu Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem})
        Me.loginStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.loginStrip.Name = "loginStrip"
        Me.loginStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.loginStrip.Size = New System.Drawing.Size(105, 26)
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TestToolStripMenuItem.Image = Global.Eran_Mono.My.Resources.Resources.cancel
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.TestToolStripMenuItem.Text = "Exit"
        '
        'UsersStrip
        '
        Me.UsersStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.UsersStrip.Font = New System.Drawing.Font("Ubuntu Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.adduser_bt})
        Me.UsersStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.UsersStrip.Name = "loginStrip"
        Me.UsersStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.UsersStrip.Size = New System.Drawing.Size(129, 26)
        '
        'adduser_bt
        '
        Me.adduser_bt.ForeColor = System.Drawing.Color.White
        Me.adduser_bt.Image = Global.Eran_Mono.My.Resources.Resources.add
        Me.adduser_bt.Name = "adduser_bt"
        Me.adduser_bt.Size = New System.Drawing.Size(128, 22)
        Me.adduser_bt.Text = "Add User"
        '
        'AccountStrip
        '
        Me.AccountStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AccountStrip.Font = New System.Drawing.Font("Ubuntu Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ExportAccountToolStripMenuItem, Me.ImportAccountToolStripMenuItem})
        Me.AccountStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.AccountStrip.Name = "loginStrip"
        Me.AccountStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.AccountStrip.ShowImageMargin = False
        Me.AccountStrip.ShowItemToolTips = False
        Me.AccountStrip.Size = New System.Drawing.Size(140, 92)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.ToolStripMenuItem1.Text = "Disconnect"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
        Me.ToolStripMenuItem2.Text = "Connection"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem5.Image = Global.Eran_Mono.My.Resources.Resources.key
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem5.Text = "Show PublicKey"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ToolStripMenuItem6.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem6.Image = Global.Eran_Mono.My.Resources.Resources.key
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem6.Text = "Show Server key"
        '
        'ExportAccountToolStripMenuItem
        '
        Me.ExportAccountToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExportAccountToolStripMenuItem.Name = "ExportAccountToolStripMenuItem"
        Me.ExportAccountToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ExportAccountToolStripMenuItem.Text = "Export Account"
        '
        'ImportAccountToolStripMenuItem
        '
        Me.ImportAccountToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ImportAccountToolStripMenuItem.Name = "ImportAccountToolStripMenuItem"
        Me.ImportAccountToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ImportAccountToolStripMenuItem.Text = "Import Account"
        '
        'ToolsStrip
        '
        Me.ToolsStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ToolsStrip.Font = New System.Drawing.Font("Ubuntu Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolsStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8})
        Me.ToolsStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolsStrip.Name = "loginStrip"
        Me.ToolsStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolsStrip.Size = New System.Drawing.Size(135, 70)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem3.Text = "Setting"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem7.Text = "Send Ping"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem8.Text = "Language"
        '
        'HelpStrip
        '
        Me.HelpStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.HelpStrip.Font = New System.Drawing.Font("Ubuntu Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem9})
        Me.HelpStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.HelpStrip.Name = "loginStrip"
        Me.HelpStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.HelpStrip.Size = New System.Drawing.Size(153, 48)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem4.Text = "About"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem9.Text = "Check Update"
        '
        'conStateTimer
        '
        Me.conStateTimer.Interval = 10
        '
        'OnlineStateTimer
        '
        '
        'main_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(356, 576)
        Me.Controls.Add(Me.main_panel)
        Me.Font = New System.Drawing.Font("Ubuntu Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eran Mono"
        Me.main_panel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.loginStrip.ResumeLayout(False)
        Me.UsersStrip.ResumeLayout(False)
        Me.AccountStrip.ResumeLayout(False)
        Me.ToolsStrip.ResumeLayout(False)
        Me.HelpStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_panel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents file_bt As System.Windows.Forms.Button
    Friend WithEvents loginStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents help_bt As System.Windows.Forms.Button
    Friend WithEvents tools_bt As System.Windows.Forms.Button
    Friend WithEvents account_bt As System.Windows.Forms.Button
    Friend WithEvents users_bt As System.Windows.Forms.Button
    Friend WithEvents UsersStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents adduser_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents alias_txt As System.Windows.Forms.TextBox
    Friend WithEvents userlist_viewer As System.Windows.Forms.ListView
    Friend WithEvents user_column As System.Windows.Forms.ColumnHeader
    Friend WithEvents eran_adr_column As System.Windows.Forms.ColumnHeader
    Friend WithEvents conStateTimer As System.Windows.Forms.Timer
    Friend WithEvents OnlineStateTimer As System.Windows.Forms.Timer
    Friend WithEvents eran_adr_txt As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem

End Class
