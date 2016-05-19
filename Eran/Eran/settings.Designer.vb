<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        Me.startmodus_gb = New System.Windows.Forms.GroupBox()
        Me.secure_desktop_rb = New System.Windows.Forms.RadioButton()
        Me.start_normal = New System.Windows.Forms.RadioButton()
        Me.startwindow_rb = New System.Windows.Forms.RadioButton()
        Me.own_access_node_gb = New System.Windows.Forms.GroupBox()
        Me.listen_port_txt = New System.Windows.Forms.TextBox()
        Me.allow_access_node_cb = New System.Windows.Forms.CheckBox()
        Me.listen_on_port_lb = New System.Windows.Forms.Label()
        Me.scan_port_txt = New System.Windows.Forms.TextBox()
        Me.scan_gb = New System.Windows.Forms.GroupBox()
        Me.host_lb = New System.Windows.Forms.Label()
        Me.scan_host_txt = New System.Windows.Forms.TextBox()
        Me.port_lb = New System.Windows.Forms.Label()
        Me.save_cb = New System.Windows.Forms.CheckBox()
        Me.messenger_gb = New System.Windows.Forms.GroupBox()
        Me.play_usr_online = New System.Windows.Forms.CheckBox()
        Me.play_msg_sound = New System.Windows.Forms.CheckBox()
        Me.encryption_gb = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.auto_rec_lb = New System.Windows.Forms.Label()
        Me.startmodus_gb.SuspendLayout()
        Me.own_access_node_gb.SuspendLayout()
        Me.scan_gb.SuspendLayout()
        Me.messenger_gb.SuspendLayout()
        Me.encryption_gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'startmodus_gb
        '
        Me.startmodus_gb.Controls.Add(Me.secure_desktop_rb)
        Me.startmodus_gb.Controls.Add(Me.start_normal)
        Me.startmodus_gb.Controls.Add(Me.startwindow_rb)
        Me.startmodus_gb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.startmodus_gb.Location = New System.Drawing.Point(12, 12)
        Me.startmodus_gb.Name = "startmodus_gb"
        Me.startmodus_gb.Size = New System.Drawing.Size(200, 100)
        Me.startmodus_gb.TabIndex = 6
        Me.startmodus_gb.TabStop = False
        Me.startmodus_gb.Text = "Startmodus"
        '
        'secure_desktop_rb
        '
        Me.secure_desktop_rb.AutoSize = True
        Me.secure_desktop_rb.Location = New System.Drawing.Point(18, 66)
        Me.secure_desktop_rb.Name = "secure_desktop_rb"
        Me.secure_desktop_rb.Size = New System.Drawing.Size(138, 17)
        Me.secure_desktop_rb.TabIndex = 2
        Me.secure_desktop_rb.TabStop = True
        Me.secure_desktop_rb.Text = "Start in Secure Desktop"
        Me.secure_desktop_rb.UseVisualStyleBackColor = True
        '
        'start_normal
        '
        Me.start_normal.AutoSize = True
        Me.start_normal.Location = New System.Drawing.Point(18, 43)
        Me.start_normal.Name = "start_normal"
        Me.start_normal.Size = New System.Drawing.Size(81, 17)
        Me.start_normal.TabIndex = 1
        Me.start_normal.TabStop = True
        Me.start_normal.Text = "Start normal"
        Me.start_normal.UseVisualStyleBackColor = True
        '
        'startwindow_rb
        '
        Me.startwindow_rb.AutoSize = True
        Me.startwindow_rb.Location = New System.Drawing.Point(18, 20)
        Me.startwindow_rb.Name = "startwindow_rb"
        Me.startwindow_rb.Size = New System.Drawing.Size(113, 17)
        Me.startwindow_rb.TabIndex = 0
        Me.startwindow_rb.TabStop = True
        Me.startwindow_rb.Text = "Show Startwindow"
        Me.startwindow_rb.UseVisualStyleBackColor = True
        '
        'own_access_node_gb
        '
        Me.own_access_node_gb.Controls.Add(Me.listen_port_txt)
        Me.own_access_node_gb.Controls.Add(Me.allow_access_node_cb)
        Me.own_access_node_gb.Controls.Add(Me.listen_on_port_lb)
        Me.own_access_node_gb.Enabled = False
        Me.own_access_node_gb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.own_access_node_gb.Location = New System.Drawing.Point(12, 222)
        Me.own_access_node_gb.Name = "own_access_node_gb"
        Me.own_access_node_gb.Size = New System.Drawing.Size(200, 74)
        Me.own_access_node_gb.TabIndex = 7
        Me.own_access_node_gb.TabStop = False
        Me.own_access_node_gb.Text = "Own Access Node"
        '
        'listen_port_txt
        '
        Me.listen_port_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.listen_port_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listen_port_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.listen_port_txt.Location = New System.Drawing.Point(128, 20)
        Me.listen_port_txt.Name = "listen_port_txt"
        Me.listen_port_txt.Size = New System.Drawing.Size(66, 20)
        Me.listen_port_txt.TabIndex = 13
        Me.listen_port_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'allow_access_node_cb
        '
        Me.allow_access_node_cb.AutoSize = True
        Me.allow_access_node_cb.Location = New System.Drawing.Point(9, 46)
        Me.allow_access_node_cb.Name = "allow_access_node_cb"
        Me.allow_access_node_cb.Size = New System.Drawing.Size(113, 17)
        Me.allow_access_node_cb.TabIndex = 9
        Me.allow_access_node_cb.Text = "Allow Acces Node"
        Me.allow_access_node_cb.UseVisualStyleBackColor = True
        '
        'listen_on_port_lb
        '
        Me.listen_on_port_lb.AutoSize = True
        Me.listen_on_port_lb.Location = New System.Drawing.Point(6, 22)
        Me.listen_on_port_lb.Name = "listen_on_port_lb"
        Me.listen_on_port_lb.Size = New System.Drawing.Size(75, 13)
        Me.listen_on_port_lb.TabIndex = 1
        Me.listen_on_port_lb.Text = "Listen on Port:"
        '
        'scan_port_txt
        '
        Me.scan_port_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.scan_port_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scan_port_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.scan_port_txt.Location = New System.Drawing.Point(128, 73)
        Me.scan_port_txt.Name = "scan_port_txt"
        Me.scan_port_txt.Size = New System.Drawing.Size(66, 20)
        Me.scan_port_txt.TabIndex = 8
        Me.scan_port_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'scan_gb
        '
        Me.scan_gb.Controls.Add(Me.host_lb)
        Me.scan_gb.Controls.Add(Me.scan_host_txt)
        Me.scan_gb.Controls.Add(Me.port_lb)
        Me.scan_gb.Controls.Add(Me.save_cb)
        Me.scan_gb.Controls.Add(Me.scan_port_txt)
        Me.scan_gb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.scan_gb.Location = New System.Drawing.Point(12, 118)
        Me.scan_gb.Name = "scan_gb"
        Me.scan_gb.Size = New System.Drawing.Size(200, 98)
        Me.scan_gb.TabIndex = 10
        Me.scan_gb.TabStop = False
        Me.scan_gb.Text = "Save Connection Acces Node"
        '
        'host_lb
        '
        Me.host_lb.AutoSize = True
        Me.host_lb.Location = New System.Drawing.Point(6, 49)
        Me.host_lb.Name = "host_lb"
        Me.host_lb.Size = New System.Drawing.Size(32, 13)
        Me.host_lb.TabIndex = 12
        Me.host_lb.Text = "Host:"
        '
        'scan_host_txt
        '
        Me.scan_host_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.scan_host_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scan_host_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.scan_host_txt.Location = New System.Drawing.Point(44, 47)
        Me.scan_host_txt.Name = "scan_host_txt"
        Me.scan_host_txt.Size = New System.Drawing.Size(150, 20)
        Me.scan_host_txt.TabIndex = 11
        '
        'port_lb
        '
        Me.port_lb.AutoSize = True
        Me.port_lb.Location = New System.Drawing.Point(6, 75)
        Me.port_lb.Name = "port_lb"
        Me.port_lb.Size = New System.Drawing.Size(29, 13)
        Me.port_lb.TabIndex = 10
        Me.port_lb.Text = "Port:"
        '
        'save_cb
        '
        Me.save_cb.AutoSize = True
        Me.save_cb.Location = New System.Drawing.Point(6, 19)
        Me.save_cb.Name = "save_cb"
        Me.save_cb.Size = New System.Drawing.Size(57, 17)
        Me.save_cb.TabIndex = 9
        Me.save_cb.Text = "Saved"
        Me.save_cb.UseVisualStyleBackColor = True
        '
        'messenger_gb
        '
        Me.messenger_gb.Controls.Add(Me.play_usr_online)
        Me.messenger_gb.Controls.Add(Me.play_msg_sound)
        Me.messenger_gb.ForeColor = System.Drawing.Color.White
        Me.messenger_gb.Location = New System.Drawing.Point(218, 12)
        Me.messenger_gb.Name = "messenger_gb"
        Me.messenger_gb.Size = New System.Drawing.Size(274, 100)
        Me.messenger_gb.TabIndex = 11
        Me.messenger_gb.TabStop = False
        Me.messenger_gb.Text = "Messenger"
        '
        'play_usr_online
        '
        Me.play_usr_online.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.play_usr_online.Location = New System.Drawing.Point(136, 19)
        Me.play_usr_online.Name = "play_usr_online"
        Me.play_usr_online.Size = New System.Drawing.Size(132, 64)
        Me.play_usr_online.TabIndex = 2
        Me.play_usr_online.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.play_usr_online.UseVisualStyleBackColor = True
        '
        'play_msg_sound
        '
        Me.play_msg_sound.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.play_msg_sound.Location = New System.Drawing.Point(6, 19)
        Me.play_msg_sound.Name = "play_msg_sound"
        Me.play_msg_sound.Size = New System.Drawing.Size(124, 64)
        Me.play_msg_sound.TabIndex = 0
        Me.play_msg_sound.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.play_msg_sound.UseVisualStyleBackColor = True
        '
        'encryption_gb
        '
        Me.encryption_gb.Controls.Add(Me.ComboBox1)
        Me.encryption_gb.Controls.Add(Me.auto_rec_lb)
        Me.encryption_gb.ForeColor = System.Drawing.Color.White
        Me.encryption_gb.Location = New System.Drawing.Point(218, 118)
        Me.encryption_gb.Name = "encryption_gb"
        Me.encryption_gb.Size = New System.Drawing.Size(274, 51)
        Me.encryption_gb.TabIndex = 12
        Me.encryption_gb.TabStop = False
        Me.encryption_gb.Text = "Encryption"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"5", "10", "15", "20"})
        Me.ComboBox1.Location = New System.Drawing.Point(164, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(36, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "10"
        '
        'auto_rec_lb
        '
        Me.auto_rec_lb.Location = New System.Drawing.Point(6, 23)
        Me.auto_rec_lb.Name = "auto_rec_lb"
        Me.auto_rec_lb.Size = New System.Drawing.Size(152, 13)
        Me.auto_rec_lb.TabIndex = 0
        Me.auto_rec_lb.Text = "Auto reconnect:"
        Me.auto_rec_lb.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(502, 308)
        Me.Controls.Add(Me.encryption_gb)
        Me.Controls.Add(Me.messenger_gb)
        Me.Controls.Add(Me.scan_gb)
        Me.Controls.Add(Me.own_access_node_gb)
        Me.Controls.Add(Me.startmodus_gb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.startmodus_gb.ResumeLayout(False)
        Me.startmodus_gb.PerformLayout()
        Me.own_access_node_gb.ResumeLayout(False)
        Me.own_access_node_gb.PerformLayout()
        Me.scan_gb.ResumeLayout(False)
        Me.scan_gb.PerformLayout()
        Me.messenger_gb.ResumeLayout(False)
        Me.encryption_gb.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents startmodus_gb As System.Windows.Forms.GroupBox
    Friend WithEvents secure_desktop_rb As System.Windows.Forms.RadioButton
    Friend WithEvents start_normal As System.Windows.Forms.RadioButton
    Friend WithEvents startwindow_rb As System.Windows.Forms.RadioButton
    Friend WithEvents own_access_node_gb As System.Windows.Forms.GroupBox
    Friend WithEvents allow_access_node_cb As System.Windows.Forms.CheckBox
    Friend WithEvents scan_port_txt As System.Windows.Forms.TextBox
    Friend WithEvents listen_on_port_lb As System.Windows.Forms.Label
    Friend WithEvents scan_gb As System.Windows.Forms.GroupBox
    Friend WithEvents save_cb As System.Windows.Forms.CheckBox
    Friend WithEvents host_lb As System.Windows.Forms.Label
    Friend WithEvents scan_host_txt As System.Windows.Forms.TextBox
    Friend WithEvents port_lb As System.Windows.Forms.Label
    Friend WithEvents listen_port_txt As System.Windows.Forms.TextBox
    Friend WithEvents messenger_gb As System.Windows.Forms.GroupBox
    Friend WithEvents play_usr_online As System.Windows.Forms.CheckBox
    Friend WithEvents play_msg_sound As System.Windows.Forms.CheckBox
    Friend WithEvents encryption_gb As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents auto_rec_lb As System.Windows.Forms.Label
End Class
