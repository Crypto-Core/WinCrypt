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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Private Key:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Public Key:"
        '
        'save_privkey_bt
        '
        Me.save_privkey_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save_privkey_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.save_privkey_bt.FlatAppearance.BorderSize = 0
        Me.save_privkey_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_privkey_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.save_privkey_bt.Location = New System.Drawing.Point(525, 48)
        Me.save_privkey_bt.Name = "save_privkey_bt"
        Me.save_privkey_bt.Size = New System.Drawing.Size(93, 23)
        Me.save_privkey_bt.TabIndex = 2
        Me.save_privkey_bt.Text = "Speichern unter"
        Me.save_privkey_bt.UseVisualStyleBackColor = False
        '
        'save_pubkey_bt
        '
        Me.save_pubkey_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save_pubkey_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.save_pubkey_bt.FlatAppearance.BorderSize = 0
        Me.save_pubkey_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_pubkey_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.save_pubkey_bt.Location = New System.Drawing.Point(525, 77)
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
        Me.private_key_path_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.private_key_path_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.private_key_path_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.private_key_path_txt.Location = New System.Drawing.Point(82, 50)
        Me.private_key_path_txt.Name = "private_key_path_txt"
        Me.private_key_path_txt.Size = New System.Drawing.Size(437, 20)
        Me.private_key_path_txt.TabIndex = 4
        '
        'public_key_path_txt
        '
        Me.public_key_path_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.public_key_path_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.public_key_path_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.public_key_path_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.public_key_path_txt.Location = New System.Drawing.Point(82, 79)
        Me.public_key_path_txt.Name = "public_key_path_txt"
        Me.public_key_path_txt.Size = New System.Drawing.Size(437, 20)
        Me.public_key_path_txt.TabIndex = 5
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "XML-Datei|*.xml"
        '
        'generate_key_bt
        '
        Me.generate_key_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.generate_key_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.generate_key_bt.FlatAppearance.BorderSize = 0
        Me.generate_key_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generate_key_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.generate_key_bt.Location = New System.Drawing.Point(12, 424)
        Me.generate_key_bt.Name = "generate_key_bt"
        Me.generate_key_bt.Size = New System.Drawing.Size(117, 23)
        Me.generate_key_bt.TabIndex = 6
        Me.generate_key_bt.Text = "Schlüssel generieren"
        Me.generate_key_bt.UseVisualStyleBackColor = False
        '
        'save_bt
        '
        Me.save_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.save_bt.Enabled = False
        Me.save_bt.FlatAppearance.BorderSize = 0
        Me.save_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.save_bt.Location = New System.Drawing.Point(543, 424)
        Me.save_bt.Name = "save_bt"
        Me.save_bt.Size = New System.Drawing.Size(75, 23)
        Me.save_bt.TabIndex = 7
        Me.save_bt.Text = "Speichern"
        Me.save_bt.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 113)
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
        Me.privatekey_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.privatekey_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.privatekey_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.privatekey_txt.Location = New System.Drawing.Point(15, 129)
        Me.privatekey_txt.Multiline = True
        Me.privatekey_txt.Name = "privatekey_txt"
        Me.privatekey_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.privatekey_txt.Size = New System.Drawing.Size(603, 165)
        Me.privatekey_txt.TabIndex = 9
        '
        'publickey_txt
        '
        Me.publickey_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.publickey_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.publickey_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.publickey_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.publickey_txt.Location = New System.Drawing.Point(12, 313)
        Me.publickey_txt.Multiline = True
        Me.publickey_txt.Name = "publickey_txt"
        Me.publickey_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.publickey_txt.Size = New System.Drawing.Size(606, 105)
        Me.publickey_txt.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(12, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Public Key"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(630, 27)
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
        Me.wincrypttitle.Size = New System.Drawing.Size(151, 16)
        Me.wincrypttitle.TabIndex = 14
        Me.wincrypttitle.Text = "RSA Schlüssel erstellen"
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
        'rsa_create_keys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(630, 459)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.MenuStrip1)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rsa_create_keys"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RSA Schlüssel erstellen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
