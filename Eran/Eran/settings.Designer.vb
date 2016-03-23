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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.listen_port_txt = New System.Windows.Forms.TextBox()
        Me.allow_access_node_cb = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.scan_port_txt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.scan_host_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.save_cb = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.startmodus_gb.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.listen_port_txt)
        Me.GroupBox1.Controls.Add(Me.allow_access_node_cb)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 222)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 74)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Own Access Node"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Listen on Port:"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.scan_host_txt)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.save_cb)
        Me.GroupBox2.Controls.Add(Me.scan_port_txt)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 98)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Save Connection Acces Node"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Host:"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Port:"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(274, 100)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Messenger"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(218, 118)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(274, 51)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Encryption"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Auto reconnect:"
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(124, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Play Message sound"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 44)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(91, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Show Balloon"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(136, 19)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(129, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Play useronline sound"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(502, 308)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.startmodus_gb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.startmodus_gb.ResumeLayout(False)
        Me.startmodus_gb.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents startmodus_gb As System.Windows.Forms.GroupBox
    Friend WithEvents secure_desktop_rb As System.Windows.Forms.RadioButton
    Friend WithEvents start_normal As System.Windows.Forms.RadioButton
    Friend WithEvents startwindow_rb As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents allow_access_node_cb As System.Windows.Forms.CheckBox
    Friend WithEvents scan_port_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents save_cb As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents scan_host_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listen_port_txt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
