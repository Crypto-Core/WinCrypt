﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nChat_frm
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.sendfile_bt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.alert_bt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lock_bt = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.encrypt_state = New System.Windows.Forms.Timer(Me.components)
        Me.check_profil_img = New System.Windows.Forms.Timer(Me.components)
        Me.check_onlinestate = New System.Windows.Forms.Timer(Me.components)
        Me.addusr_bt = New System.Windows.Forms.Button()
        Me.profil_img = New System.Windows.Forms.PictureBox()
        Me.partner_img = New System.Windows.Forms.PictureBox()
        Me.send_file_dialog = New System.Windows.Forms.OpenFileDialog()
        Me.Contextmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.profil_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.partner_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contextmenu.SuspendLayout()
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
        Me.message_box.Multiline = True
        Me.message_box.Name = "message_box"
        Me.message_box.Size = New System.Drawing.Size(494, 56)
        Me.message_box.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sendfile_bt, Me.ToolStripSeparator1, Me.alert_bt, Me.ToolStripSeparator2, Me.lock_bt})
        Me.ToolStrip1.Location = New System.Drawing.Point(92, 300)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(494, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'sendfile_bt
        '
        Me.sendfile_bt.Image = Global.Eran.My.Resources.Resources.add
        Me.sendfile_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.sendfile_bt.Name = "sendfile_bt"
        Me.sendfile_bt.Size = New System.Drawing.Size(135, 22)
        Me.sendfile_bt.Text = "Send file (max. 2mb)"
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
        Me.lock_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.lock_bt.Image = Global.Eran.My.Resources.Resources.unlock16
        Me.lock_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.lock_bt.Name = "lock_bt"
        Me.lock_bt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lock_bt.Size = New System.Drawing.Size(23, 22)
        Me.lock_bt.Text = "Encryption"
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
        Me.UserToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
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
        'send_file_dialog
        '
        '
        'Contextmenu
        '
        Me.Contextmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearChatToolStripMenuItem})
        Me.Contextmenu.Name = "Contextmenu"
        Me.Contextmenu.Size = New System.Drawing.Size(130, 26)
        '
        'ClearChatToolStripMenuItem
        '
        Me.ClearChatToolStripMenuItem.Name = "ClearChatToolStripMenuItem"
        Me.ClearChatToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ClearChatToolStripMenuItem.Text = "Clear Chat"
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
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "nChat_frm"
        Me.Text = "nChat_frm"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.profil_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.partner_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contextmenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents message_box As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
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
End Class