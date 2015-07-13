<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rsa_decrypt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rsa_decrypt))
        Me.open_privkey_bt = New System.Windows.Forms.Button()
        Me.privkey_lb = New System.Windows.Forms.Label()
        Me.privkey_path_txt = New System.Windows.Forms.TextBox()
        Me.encrypt_message_lb = New System.Windows.Forms.Label()
        Me.encrypt_message_txt = New System.Windows.Forms.TextBox()
        Me.message_lb = New System.Windows.Forms.Label()
        Me.message_txt = New System.Windows.Forms.TextBox()
        Me.decrypt_bt = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'open_privkey_bt
        '
        Me.open_privkey_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.open_privkey_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.open_privkey_bt.FlatAppearance.BorderSize = 0
        Me.open_privkey_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.open_privkey_bt.Location = New System.Drawing.Point(534, 12)
        Me.open_privkey_bt.Name = "open_privkey_bt"
        Me.open_privkey_bt.Size = New System.Drawing.Size(75, 23)
        Me.open_privkey_bt.TabIndex = 0
        Me.open_privkey_bt.Text = "Öffnen"
        Me.open_privkey_bt.UseVisualStyleBackColor = False
        '
        'privkey_lb
        '
        Me.privkey_lb.AutoSize = True
        Me.privkey_lb.Location = New System.Drawing.Point(12, 17)
        Me.privkey_lb.Name = "privkey_lb"
        Me.privkey_lb.Size = New System.Drawing.Size(64, 13)
        Me.privkey_lb.TabIndex = 1
        Me.privkey_lb.Text = "Private Key:"
        '
        'privkey_path_txt
        '
        Me.privkey_path_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.privkey_path_txt.Location = New System.Drawing.Point(82, 14)
        Me.privkey_path_txt.Name = "privkey_path_txt"
        Me.privkey_path_txt.Size = New System.Drawing.Size(446, 20)
        Me.privkey_path_txt.TabIndex = 2
        '
        'encrypt_message_lb
        '
        Me.encrypt_message_lb.AutoSize = True
        Me.encrypt_message_lb.Location = New System.Drawing.Point(12, 55)
        Me.encrypt_message_lb.Name = "encrypt_message_lb"
        Me.encrypt_message_lb.Size = New System.Drawing.Size(124, 13)
        Me.encrypt_message_lb.TabIndex = 3
        Me.encrypt_message_lb.Text = "Verschlüsselte Nachricht"
        '
        'encrypt_message_txt
        '
        Me.encrypt_message_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.encrypt_message_txt.Location = New System.Drawing.Point(15, 71)
        Me.encrypt_message_txt.Multiline = True
        Me.encrypt_message_txt.Name = "encrypt_message_txt"
        Me.encrypt_message_txt.Size = New System.Drawing.Size(594, 168)
        Me.encrypt_message_txt.TabIndex = 4
        '
        'message_lb
        '
        Me.message_lb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.message_lb.AutoSize = True
        Me.message_lb.Location = New System.Drawing.Point(12, 252)
        Me.message_lb.Name = "message_lb"
        Me.message_lb.Size = New System.Drawing.Size(53, 13)
        Me.message_lb.TabIndex = 5
        Me.message_lb.Text = "Nachricht"
        '
        'message_txt
        '
        Me.message_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.message_txt.Location = New System.Drawing.Point(15, 268)
        Me.message_txt.Multiline = True
        Me.message_txt.Name = "message_txt"
        Me.message_txt.ReadOnly = True
        Me.message_txt.Size = New System.Drawing.Size(594, 137)
        Me.message_txt.TabIndex = 6
        '
        'decrypt_bt
        '
        Me.decrypt_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.decrypt_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.decrypt_bt.FlatAppearance.BorderSize = 0
        Me.decrypt_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.decrypt_bt.Location = New System.Drawing.Point(517, 411)
        Me.decrypt_bt.Name = "decrypt_bt"
        Me.decrypt_bt.Size = New System.Drawing.Size(92, 23)
        Me.decrypt_bt.TabIndex = 7
        Me.decrypt_bt.Text = "Entschlüsseln"
        Me.decrypt_bt.UseVisualStyleBackColor = False
        '
        'rsa_decrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 439)
        Me.Controls.Add(Me.decrypt_bt)
        Me.Controls.Add(Me.message_txt)
        Me.Controls.Add(Me.message_lb)
        Me.Controls.Add(Me.encrypt_message_txt)
        Me.Controls.Add(Me.encrypt_message_lb)
        Me.Controls.Add(Me.privkey_path_txt)
        Me.Controls.Add(Me.privkey_lb)
        Me.Controls.Add(Me.open_privkey_bt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rsa_decrypt"
        Me.Text = "RSA Entschlüsselung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents open_privkey_bt As System.Windows.Forms.Button
    Friend WithEvents privkey_lb As System.Windows.Forms.Label
    Friend WithEvents privkey_path_txt As System.Windows.Forms.TextBox
    Friend WithEvents encrypt_message_lb As System.Windows.Forms.Label
    Friend WithEvents encrypt_message_txt As System.Windows.Forms.TextBox
    Friend WithEvents message_lb As System.Windows.Forms.Label
    Friend WithEvents message_txt As System.Windows.Forms.TextBox
    Friend WithEvents decrypt_bt As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
