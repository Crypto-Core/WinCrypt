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
        Me.main_panel = New System.Windows.Forms.Panel()
        Me.login_bt = New System.Windows.Forms.Button()
        Me.login_gb = New System.Windows.Forms.GroupBox()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.password_lb = New System.Windows.Forms.Label()
        Me.username_lb = New System.Windows.Forms.Label()
        Me.accessnode_gb = New System.Windows.Forms.GroupBox()
        Me.port_lb = New System.Windows.Forms.Label()
        Me.port_txt = New System.Windows.Forms.TextBox()
        Me.host_txt = New System.Windows.Forms.TextBox()
        Me.host_lb = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.main_panel.SuspendLayout()
        Me.login_gb.SuspendLayout()
        Me.accessnode_gb.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'main_panel
        '
        Me.main_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.main_panel.BackgroundImage = Global.Eran_Mono.My.Resources.Resources.trans5
        Me.main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.main_panel.Controls.Add(Me.login_bt)
        Me.main_panel.Controls.Add(Me.login_gb)
        Me.main_panel.Controls.Add(Me.accessnode_gb)
        Me.main_panel.Controls.Add(Me.PictureBox1)
        Me.main_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_panel.Font = New System.Drawing.Font("Ubuntu Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_panel.ForeColor = System.Drawing.Color.White
        Me.main_panel.Location = New System.Drawing.Point(0, 0)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(332, 552)
        Me.main_panel.TabIndex = 0
        '
        'login_bt
        '
        Me.login_bt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.login_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.login_bt.Enabled = False
        Me.login_bt.FlatAppearance.BorderSize = 0
        Me.login_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_bt.Location = New System.Drawing.Point(129, 394)
        Me.login_bt.Name = "login_bt"
        Me.login_bt.Size = New System.Drawing.Size(75, 23)
        Me.login_bt.TabIndex = 2
        Me.login_bt.Text = "Login"
        Me.login_bt.UseVisualStyleBackColor = False
        '
        'login_gb
        '
        Me.login_gb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.login_gb.BackColor = System.Drawing.Color.Transparent
        Me.login_gb.Controls.Add(Me.password_txt)
        Me.login_gb.Controls.Add(Me.username_txt)
        Me.login_gb.Controls.Add(Me.password_lb)
        Me.login_gb.Controls.Add(Me.username_lb)
        Me.login_gb.ForeColor = System.Drawing.Color.White
        Me.login_gb.Location = New System.Drawing.Point(29, 241)
        Me.login_gb.Name = "login_gb"
        Me.login_gb.Size = New System.Drawing.Size(275, 120)
        Me.login_gb.TabIndex = 1
        Me.login_gb.TabStop = False
        Me.login_gb.Text = "Login"
        '
        'password_txt
        '
        Me.password_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.password_txt.Font = New System.Drawing.Font("Ubuntu Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.password_txt.Location = New System.Drawing.Point(6, 81)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(259, 25)
        Me.password_txt.TabIndex = 1
        Me.password_txt.UseSystemPasswordChar = True
        '
        'username_txt
        '
        Me.username_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.username_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.username_txt.Font = New System.Drawing.Font("Ubuntu Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.username_txt.Location = New System.Drawing.Point(6, 34)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.ReadOnly = True
        Me.username_txt.Size = New System.Drawing.Size(259, 25)
        Me.username_txt.TabIndex = 3
        Me.username_txt.TabStop = False
        '
        'password_lb
        '
        Me.password_lb.AutoSize = True
        Me.password_lb.Location = New System.Drawing.Point(6, 63)
        Me.password_lb.Name = "password_lb"
        Me.password_lb.Size = New System.Drawing.Size(61, 15)
        Me.password_lb.TabIndex = 1
        Me.password_lb.Text = "Password:"
        '
        'username_lb
        '
        Me.username_lb.AutoSize = True
        Me.username_lb.Location = New System.Drawing.Point(3, 16)
        Me.username_lb.Name = "username_lb"
        Me.username_lb.Size = New System.Drawing.Size(61, 15)
        Me.username_lb.TabIndex = 0
        Me.username_lb.Text = "Username:"
        '
        'accessnode_gb
        '
        Me.accessnode_gb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.accessnode_gb.BackColor = System.Drawing.Color.Transparent
        Me.accessnode_gb.Controls.Add(Me.port_lb)
        Me.accessnode_gb.Controls.Add(Me.port_txt)
        Me.accessnode_gb.Controls.Add(Me.host_txt)
        Me.accessnode_gb.Controls.Add(Me.host_lb)
        Me.accessnode_gb.ForeColor = System.Drawing.Color.White
        Me.accessnode_gb.Location = New System.Drawing.Point(29, 173)
        Me.accessnode_gb.Name = "accessnode_gb"
        Me.accessnode_gb.Size = New System.Drawing.Size(275, 62)
        Me.accessnode_gb.TabIndex = 3
        Me.accessnode_gb.TabStop = False
        Me.accessnode_gb.Text = "Access Node"
        '
        'port_lb
        '
        Me.port_lb.AutoSize = True
        Me.port_lb.Location = New System.Drawing.Point(163, 26)
        Me.port_lb.Name = "port_lb"
        Me.port_lb.Size = New System.Drawing.Size(37, 15)
        Me.port_lb.TabIndex = 5
        Me.port_lb.Text = "Port:"
        '
        'port_txt
        '
        Me.port_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.port_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.port_txt.Font = New System.Drawing.Font("Ubuntu Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.port_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.port_txt.Location = New System.Drawing.Point(202, 21)
        Me.port_txt.Name = "port_txt"
        Me.port_txt.Size = New System.Drawing.Size(63, 25)
        Me.port_txt.TabIndex = 2
        Me.port_txt.Text = "8000"
        '
        'host_txt
        '
        Me.host_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.host_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.host_txt.Font = New System.Drawing.Font("Ubuntu Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.host_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.host_txt.Location = New System.Drawing.Point(44, 21)
        Me.host_txt.Name = "host_txt"
        Me.host_txt.Size = New System.Drawing.Size(113, 25)
        Me.host_txt.TabIndex = 1
        Me.host_txt.Text = "eran-im.com"
        '
        'host_lb
        '
        Me.host_lb.AutoSize = True
        Me.host_lb.Location = New System.Drawing.Point(6, 26)
        Me.host_lb.Name = "host_lb"
        Me.host_lb.Size = New System.Drawing.Size(37, 15)
        Me.host_lb.TabIndex = 4
        Me.host_lb.Text = "Host:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImage = Global.Eran_Mono.My.Resources.Resources.profilimage
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.Eran_Mono.My.Resources.Resources.onlineR
        Me.PictureBox1.Location = New System.Drawing.Point(129, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 552)
        Me.Controls.Add(Me.main_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.Text = "login"
        Me.main_panel.ResumeLayout(False)
        Me.main_panel.PerformLayout()
        Me.login_gb.ResumeLayout(False)
        Me.login_gb.PerformLayout()
        Me.accessnode_gb.ResumeLayout(False)
        Me.accessnode_gb.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_panel As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents login_bt As System.Windows.Forms.Button
    Friend WithEvents port_txt As System.Windows.Forms.TextBox
    Friend WithEvents login_gb As System.Windows.Forms.GroupBox
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
    Friend WithEvents username_txt As System.Windows.Forms.TextBox
    Friend WithEvents password_lb As System.Windows.Forms.Label
    Friend WithEvents username_lb As System.Windows.Forms.Label
    Friend WithEvents accessnode_gb As System.Windows.Forms.GroupBox
    Friend WithEvents port_lb As System.Windows.Forms.Label
    Friend WithEvents host_txt As System.Windows.Forms.TextBox
    Friend WithEvents host_lb As System.Windows.Forms.Label
End Class
