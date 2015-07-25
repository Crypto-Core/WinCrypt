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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'open_privkey_bt
        '
        Me.open_privkey_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.open_privkey_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.open_privkey_bt.FlatAppearance.BorderSize = 0
        Me.open_privkey_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.open_privkey_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.open_privkey_bt.Location = New System.Drawing.Point(565, 43)
        Me.open_privkey_bt.Name = "open_privkey_bt"
        Me.open_privkey_bt.Size = New System.Drawing.Size(75, 23)
        Me.open_privkey_bt.TabIndex = 0
        Me.open_privkey_bt.Text = "Öffnen"
        Me.open_privkey_bt.UseVisualStyleBackColor = False
        '
        'privkey_lb
        '
        Me.privkey_lb.AutoSize = True
        Me.privkey_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.privkey_lb.Location = New System.Drawing.Point(12, 48)
        Me.privkey_lb.Name = "privkey_lb"
        Me.privkey_lb.Size = New System.Drawing.Size(64, 13)
        Me.privkey_lb.TabIndex = 1
        Me.privkey_lb.Text = "Private Key:"
        '
        'privkey_path_txt
        '
        Me.privkey_path_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.privkey_path_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.privkey_path_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.privkey_path_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.privkey_path_txt.Location = New System.Drawing.Point(82, 45)
        Me.privkey_path_txt.Name = "privkey_path_txt"
        Me.privkey_path_txt.Size = New System.Drawing.Size(477, 20)
        Me.privkey_path_txt.TabIndex = 2
        '
        'encrypt_message_lb
        '
        Me.encrypt_message_lb.AutoSize = True
        Me.encrypt_message_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.encrypt_message_lb.Location = New System.Drawing.Point(12, 86)
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
        Me.encrypt_message_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.encrypt_message_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.encrypt_message_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.encrypt_message_txt.Location = New System.Drawing.Point(15, 102)
        Me.encrypt_message_txt.Multiline = True
        Me.encrypt_message_txt.Name = "encrypt_message_txt"
        Me.encrypt_message_txt.Size = New System.Drawing.Size(625, 168)
        Me.encrypt_message_txt.TabIndex = 4
        '
        'message_lb
        '
        Me.message_lb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.message_lb.AutoSize = True
        Me.message_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.message_lb.Location = New System.Drawing.Point(12, 283)
        Me.message_lb.Name = "message_lb"
        Me.message_lb.Size = New System.Drawing.Size(53, 13)
        Me.message_lb.TabIndex = 5
        Me.message_lb.Text = "Nachricht"
        '
        'message_txt
        '
        Me.message_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.message_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.message_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.message_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.message_txt.Location = New System.Drawing.Point(15, 299)
        Me.message_txt.Multiline = True
        Me.message_txt.Name = "message_txt"
        Me.message_txt.ReadOnly = True
        Me.message_txt.Size = New System.Drawing.Size(625, 137)
        Me.message_txt.TabIndex = 6
        '
        'decrypt_bt
        '
        Me.decrypt_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.decrypt_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.decrypt_bt.FlatAppearance.BorderSize = 0
        Me.decrypt_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.decrypt_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.decrypt_bt.Location = New System.Drawing.Point(548, 442)
        Me.decrypt_bt.Name = "decrypt_bt"
        Me.decrypt_bt.Size = New System.Drawing.Size(92, 23)
        Me.decrypt_bt.TabIndex = 7
        Me.decrypt_bt.Text = "Entschlüsseln"
        Me.decrypt_bt.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(652, 27)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "WinCrypt"
        '
        'XToolStripMenuItem
        '
        Me.XToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.XToolStripMenuItem.Name = "XToolStripMenuItem"
        Me.XToolStripMenuItem.Size = New System.Drawing.Size(29, 23)
        Me.XToolStripMenuItem.Text = "X"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(32, 23)
        Me.ToolStripMenuItem1.Text = "─"
        '
        'wincrypttitle
        '
        Me.wincrypttitle.AutoSize = True
        Me.wincrypttitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.wincrypttitle.Location = New System.Drawing.Point(34, 6)
        Me.wincrypttitle.Name = "wincrypttitle"
        Me.wincrypttitle.Size = New System.Drawing.Size(136, 16)
        Me.wincrypttitle.TabIndex = 14
        Me.wincrypttitle.Text = "RSA Entschlüsselung"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_WinCrypt.My.Resources.Resources.icon
        Me.PictureBox1.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'rsa_decrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(652, 470)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.decrypt_bt)
        Me.Controls.Add(Me.message_txt)
        Me.Controls.Add(Me.message_lb)
        Me.Controls.Add(Me.encrypt_message_txt)
        Me.Controls.Add(Me.encrypt_message_lb)
        Me.Controls.Add(Me.privkey_path_txt)
        Me.Controls.Add(Me.privkey_lb)
        Me.Controls.Add(Me.open_privkey_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rsa_decrypt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RSA Entschlüsselung"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
