<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(about))
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.product = New System.Windows.Forms.Label()
        Me.developer = New System.Windows.Forms.Label()
        Me.ok = New System.Windows.Forms.Button()
        Me.link = New System.Windows.Forms.LinkLabel()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.Image = Global.WinCrypt_Designer.My.Resources.Resources.wc_icon
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(128, 128)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'product
        '
        Me.product.AutoSize = True
        Me.product.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.product.Location = New System.Drawing.Point(161, 12)
        Me.product.Name = "product"
        Me.product.Size = New System.Drawing.Size(264, 25)
        Me.product.TabIndex = 1
        Me.product.Text = "WinCrypt Designer 0.0.0.0"
        '
        'developer
        '
        Me.developer.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.developer.Location = New System.Drawing.Point(163, 37)
        Me.developer.Name = "developer"
        Me.developer.Size = New System.Drawing.Size(262, 77)
        Me.developer.TabIndex = 2
        Me.developer.Text = "Harry Machura"
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(266, 117)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 3
        Me.ok.Text = "OK"
        Me.ok.UseVisualStyleBackColor = True
        '
        'link
        '
        Me.link.AutoSize = True
        Me.link.Location = New System.Drawing.Point(357, 127)
        Me.link.Name = "link"
        Me.link.Size = New System.Drawing.Size(68, 13)
        Me.link.TabIndex = 4
        Me.link.TabStop = True
        Me.link.Text = "WinCrypt.org"
        '
        'about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(437, 151)
        Me.Controls.Add(Me.link)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.developer)
        Me.Controls.Add(Me.product)
        Me.Controls.Add(Me.logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "about"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents product As System.Windows.Forms.Label
    Friend WithEvents developer As System.Windows.Forms.Label
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents link As System.Windows.Forms.LinkLabel
End Class
