<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class nChat_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nChat_frm))
        Me.message_box = New System.Windows.Forms.TextBox()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.sendfile_bt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.alert_bt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lock_bt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.recAudio = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlockingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenewEncryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearChatToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.encrypt_state = New System.Windows.Forms.Timer(Me.components)
        Me.check_profil_img = New System.Windows.Forms.Timer(Me.components)
        Me.check_onlinestate = New System.Windows.Forms.Timer(Me.components)
        Me.send_file_dialog = New System.Windows.Forms.OpenFileDialog()
        Me.Contextmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.alertCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.reEncrypt = New System.Windows.Forms.Timer(Me.components)
        Me.recTimer = New System.Windows.Forms.Timer(Me.components)
        Me.addusr_bt = New System.Windows.Forms.Button()
        Me.profil_img = New System.Windows.Forms.PictureBox()
        Me.partner_img = New System.Windows.Forms.PictureBox()
        Me.ToolStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.Contextmenu.SuspendLayout()
        CType(Me.profil_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.partner_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'message_box
        '
        Me.message_box.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.message_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.message_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.message_box.Enabled = False
        Me.message_box.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.message_box.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.message_box.Location = New System.Drawing.Point(92, 323)
        Me.message_box.MaxLength = 64000
        Me.message_box.Multiline = True
        Me.message_box.Name = "message_box"
        Me.message_box.Size = New System.Drawing.Size(494, 56)
        Me.message_box.TabIndex = 0
        '
        'ToolStrip
        '
        Me.ToolStrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip.AutoSize = False
        Me.ToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sendfile_bt, Me.ToolStripSeparator1, Me.alert_bt, Me.ToolStripSeparator2, Me.lock_bt, Me.ToolStripSeparator3, Me.recAudio})
        Me.ToolStrip.Location = New System.Drawing.Point(92, 300)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip.Size = New System.Drawing.Size(494, 25)
        Me.ToolStrip.TabIndex = 1
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'sendfile_bt
        '
        Me.sendfile_bt.Image = Global.Eran.My.Resources.Resources.add
        Me.sendfile_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.sendfile_bt.Name = "sendfile_bt"
        Me.sendfile_bt.Size = New System.Drawing.Size(72, 22)
        Me.sendfile_bt.Text = "Send file"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'alert_bt
        '
        Me.alert_bt.ForeColor = System.Drawing.Color.White
        Me.alert_bt.Image = Global.Eran.My.Resources.Resources._1456843663_bell
        Me.alert_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.alert_bt.Name = "alert_bt"
        Me.alert_bt.Size = New System.Drawing.Size(55, 22)
        Me.alert_bt.Text = "Alert!"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'lock_bt
        '
        Me.lock_bt.Image = Global.Eran.My.Resources.Resources.unlock16
        Me.lock_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.lock_bt.Name = "lock_bt"
        Me.lock_bt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lock_bt.Size = New System.Drawing.Size(23, 22)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'recAudio
        '
        Me.recAudio.Image = Global.Eran.My.Resources.Resources.rec1
        Me.recAudio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.recAudio.Name = "recAudio"
        Me.recAudio.Size = New System.Drawing.Size(23, 22)
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(598, 24)
        Me.MenuStrip.TabIndex = 3
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlockingToolStripMenuItem})
        Me.UserToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'BlockingToolStripMenuItem
        '
        Me.BlockingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BlockingToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BlockingToolStripMenuItem.Name = "BlockingToolStripMenuItem"
        Me.BlockingToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BlockingToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.BlockingToolStripMenuItem.Text = "Blocking"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenewEncryptionToolStripMenuItem, Me.ClearChatToolStripMenuItem1})
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'RenewEncryptionToolStripMenuItem
        '
        Me.RenewEncryptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RenewEncryptionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RenewEncryptionToolStripMenuItem.Name = "RenewEncryptionToolStripMenuItem"
        Me.RenewEncryptionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.RenewEncryptionToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.RenewEncryptionToolStripMenuItem.Text = "Renew encryption"
        '
        'ClearChatToolStripMenuItem1
        '
        Me.ClearChatToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClearChatToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ClearChatToolStripMenuItem1.Name = "ClearChatToolStripMenuItem1"
        Me.ClearChatToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ClearChatToolStripMenuItem1.Size = New System.Drawing.Size(211, 22)
        Me.ClearChatToolStripMenuItem1.Text = "Clear chat"
        '
        'encrypt_state
        '
        Me.encrypt_state.Enabled = True
        Me.encrypt_state.Interval = 250
        '
        'check_profil_img
        '
        Me.check_profil_img.Enabled = True
        Me.check_profil_img.Interval = 1
        '
        'check_onlinestate
        '
        Me.check_onlinestate.Enabled = True
        '
        'Contextmenu
        '
        Me.Contextmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Contextmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearChatToolStripMenuItem})
        Me.Contextmenu.Name = "Contextmenu"
        Me.Contextmenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Contextmenu.ShowImageMargin = False
        Me.Contextmenu.Size = New System.Drawing.Size(105, 26)
        '
        'ClearChatToolStripMenuItem
        '
        Me.ClearChatToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClearChatToolStripMenuItem.Name = "ClearChatToolStripMenuItem"
        Me.ClearChatToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.ClearChatToolStripMenuItem.Text = "Clear Chat"
        '
        'alertCountdown
        '
        Me.alertCountdown.Interval = 1000
        '
        'reEncrypt
        '
        Me.reEncrypt.Interval = 2000
        '
        'recTimer
        '
        Me.recTimer.Interval = 1000
        '
        'addusr_bt
        '
        Me.addusr_bt.BackColor = System.Drawing.Color.Transparent
        Me.addusr_bt.BackgroundImage = Global.Eran.My.Resources.Resources.adduser30
        Me.addusr_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.addusr_bt.FlatAppearance.BorderSize = 0
        Me.addusr_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addusr_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.addusr_bt.Location = New System.Drawing.Point(31, 107)
        Me.addusr_bt.Name = "addusr_bt"
        Me.addusr_bt.Size = New System.Drawing.Size(30, 30)
        Me.addusr_bt.TabIndex = 7
        Me.addusr_bt.UseVisualStyleBackColor = False
        Me.addusr_bt.Visible = False
        '
        'profil_img
        '
        Me.profil_img.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.profil_img.BackgroundImage = Global.Eran.My.Resources.Resources.profilimage
        Me.profil_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.profil_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profil_img.Image = Global.Eran.My.Resources.Resources.offlineR
        Me.profil_img.Location = New System.Drawing.Point(12, 305)
        Me.profil_img.Name = "profil_img"
        Me.profil_img.Size = New System.Drawing.Size(74, 74)
        Me.profil_img.TabIndex = 6
        Me.profil_img.TabStop = False
        '
        'partner_img
        '
        Me.partner_img.BackgroundImage = Global.Eran.My.Resources.Resources.profilimage
        Me.partner_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.partner_img.Image = Global.Eran.My.Resources.Resources.offlineR
        Me.partner_img.Location = New System.Drawing.Point(12, 27)
        Me.partner_img.Name = "partner_img"
        Me.partner_img.Size = New System.Drawing.Size(74, 74)
        Me.partner_img.TabIndex = 5
        Me.partner_img.TabStop = False
        '
        'nChat_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(598, 392)
        Me.Controls.Add(Me.addusr_bt)
        Me.Controls.Add(Me.profil_img)
        Me.Controls.Add(Me.partner_img)
        Me.Controls.Add(Me.message_box)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "nChat_frm"
        Me.Text = "nChat_frm"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Contextmenu.ResumeLayout(False)
        CType(Me.profil_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.partner_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents message_box As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents alert_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lock_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents encrypt_state As System.Windows.Forms.Timer
    Friend WithEvents partner_img As System.Windows.Forms.PictureBox
    Friend WithEvents profil_img As System.Windows.Forms.PictureBox
    Friend WithEvents check_profil_img As System.Windows.Forms.Timer
    Friend WithEvents check_onlinestate As System.Windows.Forms.Timer
    Friend WithEvents addusr_bt As System.Windows.Forms.Button
    Friend WithEvents sendfile_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents send_file_dialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Contextmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ClearChatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents alertCountdown As System.Windows.Forms.Timer
    Friend WithEvents RenewEncryptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents reEncrypt As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents recAudio As System.Windows.Forms.ToolStripButton
    Friend WithEvents recTimer As System.Windows.Forms.Timer
    Friend WithEvents BlockingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearChatToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
