<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setting))
        Me.trezorcrypt_gb = New System.Windows.Forms.GroupBox()
        Me.autostart_gb = New System.Windows.Forms.GroupBox()
        Me.autostart_cb = New System.Windows.Forms.CheckBox()
        Me.decryption_gb = New System.Windows.Forms.GroupBox()
        Me.opensync_cb = New System.Windows.Forms.CheckBox()
        Me.listenmode_cb = New System.Windows.Forms.CheckBox()
        Me.trezorcrypt_gb.SuspendLayout()
        Me.autostart_gb.SuspendLayout()
        Me.decryption_gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'trezorcrypt_gb
        '
        Me.trezorcrypt_gb.Controls.Add(Me.autostart_gb)
        Me.trezorcrypt_gb.Controls.Add(Me.decryption_gb)
        Me.trezorcrypt_gb.Controls.Add(Me.listenmode_cb)
        Me.trezorcrypt_gb.ForeColor = System.Drawing.Color.White
        Me.trezorcrypt_gb.Location = New System.Drawing.Point(12, 12)
        Me.trezorcrypt_gb.Name = "trezorcrypt_gb"
        Me.trezorcrypt_gb.Size = New System.Drawing.Size(274, 235)
        Me.trezorcrypt_gb.TabIndex = 3
        Me.trezorcrypt_gb.TabStop = False
        Me.trezorcrypt_gb.Text = "TrezorCrypt"
        '
        'autostart_gb
        '
        Me.autostart_gb.Controls.Add(Me.autostart_cb)
        Me.autostart_gb.ForeColor = System.Drawing.Color.White
        Me.autostart_gb.Location = New System.Drawing.Point(6, 42)
        Me.autostart_gb.Name = "autostart_gb"
        Me.autostart_gb.Size = New System.Drawing.Size(262, 53)
        Me.autostart_gb.TabIndex = 4
        Me.autostart_gb.TabStop = False
        Me.autostart_gb.Text = "Autostart"
        '
        'autostart_cb
        '
        Me.autostart_cb.AutoSize = True
        Me.autostart_cb.Location = New System.Drawing.Point(64, 18)
        Me.autostart_cb.Name = "autostart_cb"
        Me.autostart_cb.Size = New System.Drawing.Size(134, 17)
        Me.autostart_cb.TabIndex = 0
        Me.autostart_cb.Text = "Start with Windows"
        Me.autostart_cb.UseVisualStyleBackColor = True
        '
        'decryption_gb
        '
        Me.decryption_gb.Controls.Add(Me.opensync_cb)
        Me.decryption_gb.ForeColor = System.Drawing.Color.White
        Me.decryption_gb.Location = New System.Drawing.Point(6, 101)
        Me.decryption_gb.Name = "decryption_gb"
        Me.decryption_gb.Size = New System.Drawing.Size(262, 44)
        Me.decryption_gb.TabIndex = 3
        Me.decryption_gb.TabStop = False
        Me.decryption_gb.Text = "Decryption"
        '
        'opensync_cb
        '
        Me.opensync_cb.AutoSize = True
        Me.opensync_cb.Location = New System.Drawing.Point(7, 14)
        Me.opensync_cb.Name = "opensync_cb"
        Me.opensync_cb.Size = New System.Drawing.Size(248, 17)
        Me.opensync_cb.TabIndex = 0
        Me.opensync_cb.Text = "Open SyncPath folder after decryption"
        Me.opensync_cb.UseVisualStyleBackColor = True
        '
        'listenmode_cb
        '
        Me.listenmode_cb.AutoSize = True
        Me.listenmode_cb.Location = New System.Drawing.Point(13, 19)
        Me.listenmode_cb.Name = "listenmode_cb"
        Me.listenmode_cb.Size = New System.Drawing.Size(86, 17)
        Me.listenmode_cb.TabIndex = 0
        Me.listenmode_cb.Text = "Listenmode"
        Me.listenmode_cb.UseVisualStyleBackColor = True
        '
        'setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(298, 259)
        Me.Controls.Add(Me.trezorcrypt_gb)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "setting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrezorCrypt - Settings"
        Me.trezorcrypt_gb.ResumeLayout(False)
        Me.trezorcrypt_gb.PerformLayout()
        Me.autostart_gb.ResumeLayout(False)
        Me.autostart_gb.PerformLayout()
        Me.decryption_gb.ResumeLayout(False)
        Me.decryption_gb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trezorcrypt_gb As System.Windows.Forms.GroupBox
    Friend WithEvents listenmode_cb As System.Windows.Forms.CheckBox
    Friend WithEvents autostart_gb As System.Windows.Forms.GroupBox
    Friend WithEvents autostart_cb As System.Windows.Forms.CheckBox
    Friend WithEvents decryption_gb As System.Windows.Forms.GroupBox
    Friend WithEvents opensync_cb As System.Windows.Forms.CheckBox
End Class
