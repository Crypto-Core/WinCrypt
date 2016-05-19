<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.login_panel = New System.Windows.Forms.Panel()
        Me.profile_img = New System.Windows.Forms.PictureBox()
        Me.join_bt = New System.Windows.Forms.Button()
        Me.server_gb = New System.Windows.Forms.GroupBox()
        Me.port_txt = New System.Windows.Forms.TextBox()
        Me.host_txt = New System.Windows.Forms.TextBox()
        Me.port_lb = New System.Windows.Forms.Label()
        Me.host_lb = New System.Windows.Forms.Label()
        Me.login_gb = New System.Windows.Forms.GroupBox()
        Me.pwd_txt = New System.Windows.Forms.TextBox()
        Me.usr_txt = New System.Windows.Forms.TextBox()
        Me.pwd_lb = New System.Windows.Forms.Label()
        Me.usr_lb = New System.Windows.Forms.Label()
        Me.login_panel.SuspendLayout()
        CType(Me.profile_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.server_gb.SuspendLayout()
        Me.login_gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'login_panel
        '
        Me.login_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.login_panel.BackgroundImage = Global.Eran.My.Resources.Resources.trans5
        Me.login_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.login_panel.Controls.Add(Me.profile_img)
        Me.login_panel.Controls.Add(Me.join_bt)
        Me.login_panel.Controls.Add(Me.server_gb)
        Me.login_panel.Controls.Add(Me.login_gb)
        Me.login_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.login_panel.Location = New System.Drawing.Point(0, 0)
        Me.login_panel.Name = "login_panel"
        Me.login_panel.Size = New System.Drawing.Size(313, 419)
        Me.login_panel.TabIndex = 0
        '
        'profile_img
        '
        Me.profile_img.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.profile_img.BackColor = System.Drawing.Color.Transparent
        Me.profile_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.profile_img.Image = Global.Eran.My.Resources.Resources.onlineR
        Me.profile_img.Location = New System.Drawing.Point(119, 21)
        Me.profile_img.Name = "profile_img"
        Me.profile_img.Size = New System.Drawing.Size(74, 74)
        Me.profile_img.TabIndex = 3
        Me.profile_img.TabStop = False
        '
        'join_bt
        '
        Me.join_bt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.join_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.join_bt.FlatAppearance.BorderSize = 0
        Me.join_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.join_bt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.join_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.join_bt.Location = New System.Drawing.Point(119, 338)
        Me.join_bt.Name = "join_bt"
        Me.join_bt.Size = New System.Drawing.Size(75, 23)
        Me.join_bt.TabIndex = 2
        Me.join_bt.Text = "Join"
        Me.join_bt.UseVisualStyleBackColor = False
        '
        'server_gb
        '
        Me.server_gb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.server_gb.BackColor = System.Drawing.Color.Transparent
        Me.server_gb.Controls.Add(Me.port_txt)
        Me.server_gb.Controls.Add(Me.host_txt)
        Me.server_gb.Controls.Add(Me.port_lb)
        Me.server_gb.Controls.Add(Me.host_lb)
        Me.server_gb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.server_gb.ForeColor = System.Drawing.Color.White
        Me.server_gb.Location = New System.Drawing.Point(12, 110)
        Me.server_gb.Name = "server_gb"
        Me.server_gb.Size = New System.Drawing.Size(289, 61)
        Me.server_gb.TabIndex = 1
        Me.server_gb.TabStop = False
        Me.server_gb.Text = "Access Node"
        '
        'port_txt
        '
        Me.port_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.port_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.port_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.port_txt.Location = New System.Drawing.Point(218, 22)
        Me.port_txt.Name = "port_txt"
        Me.port_txt.Size = New System.Drawing.Size(65, 22)
        Me.port_txt.TabIndex = 3
        Me.port_txt.Text = "8000"
        '
        'host_txt
        '
        Me.host_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.host_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.host_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.host_txt.Location = New System.Drawing.Point(44, 22)
        Me.host_txt.Name = "host_txt"
        Me.host_txt.Size = New System.Drawing.Size(133, 22)
        Me.host_txt.TabIndex = 2
        Me.host_txt.Text = "eran-im.com"
        '
        'port_lb
        '
        Me.port_lb.AutoSize = True
        Me.port_lb.Location = New System.Drawing.Point(183, 25)
        Me.port_lb.Name = "port_lb"
        Me.port_lb.Size = New System.Drawing.Size(31, 13)
        Me.port_lb.TabIndex = 1
        Me.port_lb.Text = "Port:"
        '
        'host_lb
        '
        Me.host_lb.AutoSize = True
        Me.host_lb.Location = New System.Drawing.Point(6, 25)
        Me.host_lb.Name = "host_lb"
        Me.host_lb.Size = New System.Drawing.Size(34, 13)
        Me.host_lb.TabIndex = 0
        Me.host_lb.Text = "Host:"
        '
        'login_gb
        '
        Me.login_gb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.login_gb.BackColor = System.Drawing.Color.Transparent
        Me.login_gb.Controls.Add(Me.pwd_txt)
        Me.login_gb.Controls.Add(Me.usr_txt)
        Me.login_gb.Controls.Add(Me.pwd_lb)
        Me.login_gb.Controls.Add(Me.usr_lb)
        Me.login_gb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_gb.ForeColor = System.Drawing.Color.White
        Me.login_gb.Location = New System.Drawing.Point(12, 177)
        Me.login_gb.Name = "login_gb"
        Me.login_gb.Size = New System.Drawing.Size(289, 116)
        Me.login_gb.TabIndex = 0
        Me.login_gb.TabStop = False
        Me.login_gb.Text = "Login"
        '
        'pwd_txt
        '
        Me.pwd_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pwd_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pwd_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pwd_txt.Location = New System.Drawing.Point(12, 79)
        Me.pwd_txt.Name = "pwd_txt"
        Me.pwd_txt.Size = New System.Drawing.Size(271, 22)
        Me.pwd_txt.TabIndex = 4
        Me.pwd_txt.UseSystemPasswordChar = True
        '
        'usr_txt
        '
        Me.usr_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.usr_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usr_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.usr_txt.Location = New System.Drawing.Point(12, 38)
        Me.usr_txt.Name = "usr_txt"
        Me.usr_txt.ReadOnly = True
        Me.usr_txt.Size = New System.Drawing.Size(271, 22)
        Me.usr_txt.TabIndex = 5
        '
        'pwd_lb
        '
        Me.pwd_lb.AutoSize = True
        Me.pwd_lb.Location = New System.Drawing.Point(9, 63)
        Me.pwd_lb.Name = "pwd_lb"
        Me.pwd_lb.Size = New System.Drawing.Size(59, 13)
        Me.pwd_lb.TabIndex = 1
        Me.pwd_lb.Text = "Password:"
        '
        'usr_lb
        '
        Me.usr_lb.AutoSize = True
        Me.usr_lb.Location = New System.Drawing.Point(9, 22)
        Me.usr_lb.Name = "usr_lb"
        Me.usr_lb.Size = New System.Drawing.Size(61, 13)
        Me.usr_lb.TabIndex = 0
        Me.usr_lb.Text = "Username:"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 419)
        Me.Controls.Add(Me.login_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.Text = "login"
        Me.login_panel.ResumeLayout(False)
        CType(Me.profile_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.server_gb.ResumeLayout(False)
        Me.server_gb.PerformLayout()
        Me.login_gb.ResumeLayout(False)
        Me.login_gb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents login_panel As System.Windows.Forms.Panel
    Friend WithEvents server_gb As System.Windows.Forms.GroupBox
    Friend WithEvents login_gb As System.Windows.Forms.GroupBox
    Friend WithEvents port_txt As System.Windows.Forms.TextBox
    Friend WithEvents host_txt As System.Windows.Forms.TextBox
    Friend WithEvents port_lb As System.Windows.Forms.Label
    Friend WithEvents host_lb As System.Windows.Forms.Label
    Friend WithEvents join_bt As System.Windows.Forms.Button
    Friend WithEvents pwd_txt As System.Windows.Forms.TextBox
    Friend WithEvents usr_txt As System.Windows.Forms.TextBox
    Friend WithEvents pwd_lb As System.Windows.Forms.Label
    Friend WithEvents usr_lb As System.Windows.Forms.Label
    Friend WithEvents profile_img As System.Windows.Forms.PictureBox
End Class
