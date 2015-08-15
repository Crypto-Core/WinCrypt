<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class install_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(install_frm))
        Me.logo_image = New System.Windows.Forms.PictureBox()
        Me.label = New System.Windows.Forms.Label()
        Me.install_bt = New System.Windows.Forms.Button()
        Me.select_path_bt = New System.Windows.Forms.Button()
        Me.save_path_txt = New System.Windows.Forms.TextBox()
        Me.save_path = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.wincrypt_link = New System.Windows.Forms.LinkLabel()
        Me.copyright = New System.Windows.Forms.Label()
        CType(Me.logo_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo_image
        '
        Me.logo_image.Image = Global.FileZilla_AES_Pass.My.Resources.Resources.Icon_5
        Me.logo_image.Location = New System.Drawing.Point(135, 12)
        Me.logo_image.Name = "logo_image"
        Me.logo_image.Size = New System.Drawing.Size(128, 128)
        Me.logo_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo_image.TabIndex = 0
        Me.logo_image.TabStop = False
        '
        'label
        '
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(12, 143)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(373, 105)
        Me.label.TabIndex = 1
        Me.label.Text = resources.GetString("label.Text")
        '
        'install_bt
        '
        Me.install_bt.Location = New System.Drawing.Point(164, 313)
        Me.install_bt.Name = "install_bt"
        Me.install_bt.Size = New System.Drawing.Size(75, 23)
        Me.install_bt.TabIndex = 2
        Me.install_bt.Text = "Installieren"
        Me.install_bt.UseVisualStyleBackColor = True
        '
        'select_path_bt
        '
        Me.select_path_bt.Location = New System.Drawing.Point(310, 273)
        Me.select_path_bt.Name = "select_path_bt"
        Me.select_path_bt.Size = New System.Drawing.Size(75, 23)
        Me.select_path_bt.TabIndex = 3
        Me.select_path_bt.Text = "wählen"
        Me.select_path_bt.UseVisualStyleBackColor = True
        '
        'save_path_txt
        '
        Me.save_path_txt.Enabled = False
        Me.save_path_txt.Location = New System.Drawing.Point(16, 275)
        Me.save_path_txt.Name = "save_path_txt"
        Me.save_path_txt.Size = New System.Drawing.Size(288, 20)
        Me.save_path_txt.TabIndex = 4
        '
        'save_path
        '
        Me.save_path.AutoSize = True
        Me.save_path.Location = New System.Drawing.Point(13, 259)
        Me.save_path.Name = "save_path"
        Me.save_path.Size = New System.Drawing.Size(64, 13)
        Me.save_path.TabIndex = 5
        Me.save_path.Text = "Speicherort:"
        '
        'wincrypt_link
        '
        Me.wincrypt_link.AutoSize = True
        Me.wincrypt_link.Location = New System.Drawing.Point(12, 326)
        Me.wincrypt_link.Name = "wincrypt_link"
        Me.wincrypt_link.Size = New System.Drawing.Size(96, 13)
        Me.wincrypt_link.TabIndex = 6
        Me.wincrypt_link.TabStop = True
        Me.wincrypt_link.Text = "Plugin by WinCrypt"
        '
        'copyright
        '
        Me.copyright.AutoSize = True
        Me.copyright.Location = New System.Drawing.Point(296, 326)
        Me.copyright.Name = "copyright"
        Me.copyright.Size = New System.Drawing.Size(89, 13)
        Me.copyright.TabIndex = 7
        Me.copyright.Text = "© Harry Machura"
        '
        'install_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 348)
        Me.Controls.Add(Me.copyright)
        Me.Controls.Add(Me.wincrypt_link)
        Me.Controls.Add(Me.save_path)
        Me.Controls.Add(Me.save_path_txt)
        Me.Controls.Add(Me.select_path_bt)
        Me.Controls.Add(Me.install_bt)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.logo_image)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "install_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileZilla AES Pass Plugin"
        CType(Me.logo_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo_image As System.Windows.Forms.PictureBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents install_bt As System.Windows.Forms.Button
    Friend WithEvents select_path_bt As System.Windows.Forms.Button
    Friend WithEvents save_path_txt As System.Windows.Forms.TextBox
    Friend WithEvents save_path As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents wincrypt_link As System.Windows.Forms.LinkLabel
    Friend WithEvents copyright As System.Windows.Forms.Label

End Class
