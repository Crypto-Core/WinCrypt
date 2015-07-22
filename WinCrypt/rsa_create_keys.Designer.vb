<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rsa_create_keys
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rsa_create_keys))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.save_privkey_bt = New System.Windows.Forms.Button()
        Me.save_pubkey_bt = New System.Windows.Forms.Button()
        Me.private_key_path_txt = New System.Windows.Forms.TextBox()
        Me.public_key_path_txt = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.generate_key_bt = New System.Windows.Forms.Button()
        Me.save_bt = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.privatekey_txt = New System.Windows.Forms.TextBox()
        Me.publickey_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Private Key:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Public Key:"
        '
        'save_privkey_bt
        '
        Me.save_privkey_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save_privkey_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.save_privkey_bt.FlatAppearance.BorderSize = 0
        Me.save_privkey_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_privkey_bt.Location = New System.Drawing.Point(470, 17)
        Me.save_privkey_bt.Name = "save_privkey_bt"
        Me.save_privkey_bt.Size = New System.Drawing.Size(93, 23)
        Me.save_privkey_bt.TabIndex = 2
        Me.save_privkey_bt.Text = "Speichern unter"
        Me.save_privkey_bt.UseVisualStyleBackColor = False
        '
        'save_pubkey_bt
        '
        Me.save_pubkey_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save_pubkey_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.save_pubkey_bt.FlatAppearance.BorderSize = 0
        Me.save_pubkey_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_pubkey_bt.Location = New System.Drawing.Point(470, 46)
        Me.save_pubkey_bt.Name = "save_pubkey_bt"
        Me.save_pubkey_bt.Size = New System.Drawing.Size(93, 23)
        Me.save_pubkey_bt.TabIndex = 3
        Me.save_pubkey_bt.Text = "Speichern unter"
        Me.save_pubkey_bt.UseVisualStyleBackColor = False
        '
        'private_key_path_txt
        '
        Me.private_key_path_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.private_key_path_txt.Location = New System.Drawing.Point(82, 19)
        Me.private_key_path_txt.Name = "private_key_path_txt"
        Me.private_key_path_txt.Size = New System.Drawing.Size(382, 20)
        Me.private_key_path_txt.TabIndex = 4
        '
        'public_key_path_txt
        '
        Me.public_key_path_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.public_key_path_txt.Location = New System.Drawing.Point(82, 48)
        Me.public_key_path_txt.Name = "public_key_path_txt"
        Me.public_key_path_txt.Size = New System.Drawing.Size(382, 20)
        Me.public_key_path_txt.TabIndex = 5
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "XML-Datei|*.xml"
        '
        'generate_key_bt
        '
        Me.generate_key_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.generate_key_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.generate_key_bt.FlatAppearance.BorderSize = 0
        Me.generate_key_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generate_key_bt.Location = New System.Drawing.Point(12, 363)
        Me.generate_key_bt.Name = "generate_key_bt"
        Me.generate_key_bt.Size = New System.Drawing.Size(117, 23)
        Me.generate_key_bt.TabIndex = 6
        Me.generate_key_bt.Text = "Schlüssel generieren"
        Me.generate_key_bt.UseVisualStyleBackColor = False
        '
        'save_bt
        '
        Me.save_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.save_bt.Enabled = False
        Me.save_bt.FlatAppearance.BorderSize = 0
        Me.save_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_bt.Location = New System.Drawing.Point(488, 363)
        Me.save_bt.Name = "save_bt"
        Me.save_bt.Size = New System.Drawing.Size(75, 23)
        Me.save_bt.TabIndex = 7
        Me.save_bt.Text = "Speichern"
        Me.save_bt.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Private Key"
        '
        'privatekey_txt
        '
        Me.privatekey_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.privatekey_txt.Location = New System.Drawing.Point(15, 98)
        Me.privatekey_txt.Multiline = True
        Me.privatekey_txt.Name = "privatekey_txt"
        Me.privatekey_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.privatekey_txt.Size = New System.Drawing.Size(548, 135)
        Me.privatekey_txt.TabIndex = 9
        '
        'publickey_txt
        '
        Me.publickey_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.publickey_txt.Location = New System.Drawing.Point(12, 252)
        Me.publickey_txt.Multiline = True
        Me.publickey_txt.Name = "publickey_txt"
        Me.publickey_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.publickey_txt.Size = New System.Drawing.Size(551, 105)
        Me.publickey_txt.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Public Key"
        '
        'rsa_create_keys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 398)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.publickey_txt)
        Me.Controls.Add(Me.privatekey_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.save_bt)
        Me.Controls.Add(Me.generate_key_bt)
        Me.Controls.Add(Me.public_key_path_txt)
        Me.Controls.Add(Me.private_key_path_txt)
        Me.Controls.Add(Me.save_pubkey_bt)
        Me.Controls.Add(Me.save_privkey_bt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rsa_create_keys"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RSA Schlüssel erstellen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents save_privkey_bt As System.Windows.Forms.Button
    Friend WithEvents save_pubkey_bt As System.Windows.Forms.Button
    Friend WithEvents private_key_path_txt As System.Windows.Forms.TextBox
    Friend WithEvents public_key_path_txt As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents generate_key_bt As System.Windows.Forms.Button
    Friend WithEvents save_bt As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents privatekey_txt As System.Windows.Forms.TextBox
    Friend WithEvents publickey_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
