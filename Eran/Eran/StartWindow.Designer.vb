<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartWindow))
        Me.secure_desktop_img = New System.Windows.Forms.PictureBox()
        Me.msg1 = New System.Windows.Forms.Label()
        Me.secureDesktop_bt = New System.Windows.Forms.Button()
        Me.startNormal_bt = New System.Windows.Forms.Button()
        Me.msg2 = New System.Windows.Forms.Label()
        Me.save_selection_cb = New System.Windows.Forms.CheckBox()
        Me.beta_warning = New System.Windows.Forms.Label()
        CType(Me.secure_desktop_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'secure_desktop_img
        '
        Me.secure_desktop_img.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.secure_desktop_img.Image = Global.Eran.My.Resources.Resources.SecureDesktop
        Me.secure_desktop_img.Location = New System.Drawing.Point(131, 12)
        Me.secure_desktop_img.Name = "secure_desktop_img"
        Me.secure_desktop_img.Size = New System.Drawing.Size(256, 222)
        Me.secure_desktop_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.secure_desktop_img.TabIndex = 1
        Me.secure_desktop_img.TabStop = False
        '
        'msg1
        '
        Me.msg1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msg1.ForeColor = System.Drawing.Color.White
        Me.msg1.Location = New System.Drawing.Point(30, 237)
        Me.msg1.Name = "msg1"
        Me.msg1.Size = New System.Drawing.Size(476, 13)
        Me.msg1.TabIndex = 2
        Me.msg1.Text = "Want to Eran start in Secure Desktop?"
        Me.msg1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'secureDesktop_bt
        '
        Me.secureDesktop_bt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.secureDesktop_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.secureDesktop_bt.FlatAppearance.BorderSize = 0
        Me.secureDesktop_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.secureDesktop_bt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secureDesktop_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.secureDesktop_bt.Location = New System.Drawing.Point(318, 363)
        Me.secureDesktop_bt.Name = "secureDesktop_bt"
        Me.secureDesktop_bt.Size = New System.Drawing.Size(150, 23)
        Me.secureDesktop_bt.TabIndex = 3
        Me.secureDesktop_bt.Text = "Start in Secure Desktop"
        Me.secureDesktop_bt.UseVisualStyleBackColor = False
        '
        'startNormal_bt
        '
        Me.startNormal_bt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.startNormal_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.startNormal_bt.FlatAppearance.BorderSize = 0
        Me.startNormal_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startNormal_bt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startNormal_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.startNormal_bt.Location = New System.Drawing.Point(114, 363)
        Me.startNormal_bt.Name = "startNormal_bt"
        Me.startNormal_bt.Size = New System.Drawing.Size(150, 23)
        Me.startNormal_bt.TabIndex = 4
        Me.startNormal_bt.Text = "Start normal"
        Me.startNormal_bt.UseVisualStyleBackColor = False
        '
        'msg2
        '
        Me.msg2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msg2.ForeColor = System.Drawing.Color.White
        Me.msg2.Location = New System.Drawing.Point(27, 265)
        Me.msg2.Name = "msg2"
        Me.msg2.Size = New System.Drawing.Size(464, 95)
        Me.msg2.TabIndex = 5
        Me.msg2.Text = "In Secure Desktop Every feature such as screenshots or Keylogger is disabled. Thi" & _
            "s protection is especially against trojans and spyware."
        '
        'save_selection_cb
        '
        Me.save_selection_cb.AutoSize = True
        Me.save_selection_cb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_selection_cb.ForeColor = System.Drawing.Color.White
        Me.save_selection_cb.Location = New System.Drawing.Point(12, 388)
        Me.save_selection_cb.Name = "save_selection_cb"
        Me.save_selection_cb.Size = New System.Drawing.Size(98, 17)
        Me.save_selection_cb.TabIndex = 6
        Me.save_selection_cb.Text = "Save selection"
        Me.save_selection_cb.UseVisualStyleBackColor = True
        '
        'beta_warning
        '
        Me.beta_warning.AutoSize = True
        Me.beta_warning.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.beta_warning.ForeColor = System.Drawing.Color.Red
        Me.beta_warning.Location = New System.Drawing.Point(297, 389)
        Me.beta_warning.Name = "beta_warning"
        Me.beta_warning.Size = New System.Drawing.Size(185, 13)
        Me.beta_warning.TabIndex = 7
        Me.beta_warning.Text = "[WARNING: IT'S A BETA FUNCTION!]"
        '
        'StartWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(518, 411)
        Me.Controls.Add(Me.beta_warning)
        Me.Controls.Add(Me.save_selection_cb)
        Me.Controls.Add(Me.msg2)
        Me.Controls.Add(Me.startNormal_bt)
        Me.Controls.Add(Me.secureDesktop_bt)
        Me.Controls.Add(Me.msg1)
        Me.Controls.Add(Me.secure_desktop_img)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "StartWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eran Start Window"
        CType(Me.secure_desktop_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents secure_desktop_img As System.Windows.Forms.PictureBox
    Friend WithEvents msg1 As System.Windows.Forms.Label
    Friend WithEvents secureDesktop_bt As System.Windows.Forms.Button
    Friend WithEvents startNormal_bt As System.Windows.Forms.Button
    Friend WithEvents msg2 As System.Windows.Forms.Label
    Friend WithEvents save_selection_cb As System.Windows.Forms.CheckBox
    Friend WithEvents beta_warning As System.Windows.Forms.Label
End Class
