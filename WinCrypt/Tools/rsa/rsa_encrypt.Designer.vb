<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rsa_encrypt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rsa_encrypt))
        Me.pubkey_path_bt = New System.Windows.Forms.Button()
        Me.pubkey_lb = New System.Windows.Forms.Label()
        Me.pubkey_path_txt = New System.Windows.Forms.TextBox()
        Me.encryption_message_txt = New System.Windows.Forms.TextBox()
        Me.decryption_message_txt = New System.Windows.Forms.TextBox()
        Me.message_lb = New System.Windows.Forms.Label()
        Me.encryption_message_lb = New System.Windows.Forms.Label()
        Me.encryption_bt = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'pubkey_path_bt
        '
        Me.pubkey_path_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pubkey_path_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.pubkey_path_bt.FlatAppearance.BorderSize = 0
        Me.pubkey_path_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pubkey_path_bt.Location = New System.Drawing.Point(534, 12)
        Me.pubkey_path_bt.Name = "pubkey_path_bt"
        Me.pubkey_path_bt.Size = New System.Drawing.Size(75, 23)
        Me.pubkey_path_bt.TabIndex = 0
        Me.pubkey_path_bt.Text = "Öffnen"
        Me.pubkey_path_bt.UseVisualStyleBackColor = False
        '
        'pubkey_lb
        '
        Me.pubkey_lb.AutoSize = True
        Me.pubkey_lb.Location = New System.Drawing.Point(12, 17)
        Me.pubkey_lb.Name = "pubkey_lb"
        Me.pubkey_lb.Size = New System.Drawing.Size(60, 13)
        Me.pubkey_lb.TabIndex = 1
        Me.pubkey_lb.Text = "Public Key:"
        '
        'pubkey_path_txt
        '
        Me.pubkey_path_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pubkey_path_txt.Location = New System.Drawing.Point(78, 14)
        Me.pubkey_path_txt.Name = "pubkey_path_txt"
        Me.pubkey_path_txt.Size = New System.Drawing.Size(450, 20)
        Me.pubkey_path_txt.TabIndex = 2
        '
        'encryption_message_txt
        '
        Me.encryption_message_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.encryption_message_txt.Location = New System.Drawing.Point(15, 62)
        Me.encryption_message_txt.Multiline = True
        Me.encryption_message_txt.Name = "encryption_message_txt"
        Me.encryption_message_txt.Size = New System.Drawing.Size(594, 165)
        Me.encryption_message_txt.TabIndex = 3
        '
        'decryption_message_txt
        '
        Me.decryption_message_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.decryption_message_txt.Location = New System.Drawing.Point(12, 254)
        Me.decryption_message_txt.Multiline = True
        Me.decryption_message_txt.Name = "decryption_message_txt"
        Me.decryption_message_txt.ReadOnly = True
        Me.decryption_message_txt.Size = New System.Drawing.Size(594, 151)
        Me.decryption_message_txt.TabIndex = 4
        '
        'message_lb
        '
        Me.message_lb.AutoSize = True
        Me.message_lb.Location = New System.Drawing.Point(15, 43)
        Me.message_lb.Name = "message_lb"
        Me.message_lb.Size = New System.Drawing.Size(53, 13)
        Me.message_lb.TabIndex = 5
        Me.message_lb.Text = "Nachricht"
        '
        'encryption_message_lb
        '
        Me.encryption_message_lb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.encryption_message_lb.AutoSize = True
        Me.encryption_message_lb.Location = New System.Drawing.Point(15, 236)
        Me.encryption_message_lb.Name = "encryption_message_lb"
        Me.encryption_message_lb.Size = New System.Drawing.Size(124, 13)
        Me.encryption_message_lb.TabIndex = 6
        Me.encryption_message_lb.Text = "Verschlüsselte Nachricht"
        '
        'encryption_bt
        '
        Me.encryption_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.encryption_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.encryption_bt.FlatAppearance.BorderSize = 0
        Me.encryption_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.encryption_bt.Location = New System.Drawing.Point(514, 411)
        Me.encryption_bt.Name = "encryption_bt"
        Me.encryption_bt.Size = New System.Drawing.Size(92, 23)
        Me.encryption_bt.TabIndex = 7
        Me.encryption_bt.Text = "Verschlüsseln"
        Me.encryption_bt.UseVisualStyleBackColor = False
        '
        'rsa_encrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 439)
        Me.Controls.Add(Me.encryption_bt)
        Me.Controls.Add(Me.encryption_message_lb)
        Me.Controls.Add(Me.message_lb)
        Me.Controls.Add(Me.decryption_message_txt)
        Me.Controls.Add(Me.encryption_message_txt)
        Me.Controls.Add(Me.pubkey_path_txt)
        Me.Controls.Add(Me.pubkey_lb)
        Me.Controls.Add(Me.pubkey_path_bt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rsa_encrypt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RSA Verschlüsselung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pubkey_path_bt As System.Windows.Forms.Button
    Friend WithEvents pubkey_lb As System.Windows.Forms.Label
    Friend WithEvents pubkey_path_txt As System.Windows.Forms.TextBox
    Friend WithEvents encryption_message_txt As System.Windows.Forms.TextBox
    Friend WithEvents decryption_message_txt As System.Windows.Forms.TextBox
    Friend WithEvents message_lb As System.Windows.Forms.Label
    Friend WithEvents encryption_message_lb As System.Windows.Forms.Label
    Friend WithEvents encryption_bt As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
