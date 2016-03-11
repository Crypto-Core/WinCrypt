<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enterpwd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(enterpwd))
        Me.password_lb = New System.Windows.Forms.Label()
        Me.sync_bt = New System.Windows.Forms.Button()
        Me.logo_img = New System.Windows.Forms.PictureBox()
        Me.device_name_lb = New System.Windows.Forms.Label()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.SynState = New System.Windows.Forms.Timer(Me.components)
        CType(Me.logo_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'password_lb
        '
        Me.password_lb.AutoSize = True
        Me.password_lb.Location = New System.Drawing.Point(84, 63)
        Me.password_lb.Name = "password_lb"
        Me.password_lb.Size = New System.Drawing.Size(61, 13)
        Me.password_lb.TabIndex = 0
        Me.password_lb.Text = "Password:"
        '
        'sync_bt
        '
        Me.sync_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.sync_bt.Enabled = False
        Me.sync_bt.FlatAppearance.BorderSize = 0
        Me.sync_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sync_bt.Location = New System.Drawing.Point(296, 86)
        Me.sync_bt.Name = "sync_bt"
        Me.sync_bt.Size = New System.Drawing.Size(75, 23)
        Me.sync_bt.TabIndex = 1
        Me.sync_bt.Text = "Sync"
        Me.sync_bt.UseVisualStyleBackColor = False
        '
        'logo_img
        '
        Me.logo_img.Image = Global.TrezorCrypt.My.Resources.Resources.trezorcrypt64
        Me.logo_img.Location = New System.Drawing.Point(12, 12)
        Me.logo_img.Name = "logo_img"
        Me.logo_img.Size = New System.Drawing.Size(64, 64)
        Me.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.logo_img.TabIndex = 2
        Me.logo_img.TabStop = False
        '
        'device_name_lb
        '
        Me.device_name_lb.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.device_name_lb.Location = New System.Drawing.Point(83, 13)
        Me.device_name_lb.Name = "device_name_lb"
        Me.device_name_lb.Size = New System.Drawing.Size(288, 29)
        Me.device_name_lb.TabIndex = 3
        Me.device_name_lb.Text = "-"
        '
        'password_txt
        '
        Me.password_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.password_txt.ForeColor = System.Drawing.Color.White
        Me.password_txt.Location = New System.Drawing.Point(151, 60)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(220, 20)
        Me.password_txt.TabIndex = 4
        Me.password_txt.UseSystemPasswordChar = True
        '
        'SynState
        '
        Me.SynState.Interval = 1000
        '
        'enterpwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(379, 119)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.device_name_lb)
        Me.Controls.Add(Me.logo_img)
        Me.Controls.Add(Me.sync_bt)
        Me.Controls.Add(Me.password_lb)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "enterpwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrezorCrypt - Password"
        Me.TopMost = True
        CType(Me.logo_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents password_lb As System.Windows.Forms.Label
    Friend WithEvents sync_bt As System.Windows.Forms.Button
    Friend WithEvents logo_img As System.Windows.Forms.PictureBox
    Friend WithEvents device_name_lb As System.Windows.Forms.Label
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
    Friend WithEvents SynState As System.Windows.Forms.Timer
End Class
