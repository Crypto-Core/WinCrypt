<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class passwordgenerator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(passwordgenerator))
        Me.generatebt = New System.Windows.Forms.Button()
        Me.generatetxt = New System.Windows.Forms.TextBox()
        Me.length = New System.Windows.Forms.TextBox()
        Me.uppercasecb = New System.Windows.Forms.CheckBox()
        Me.lowercasecb = New System.Windows.Forms.CheckBox()
        Me.numberscb = New System.Windows.Forms.CheckBox()
        Me.lengthlb = New System.Windows.Forms.Label()
        Me.copybt = New System.Windows.Forms.Button()
        Me.specialchar = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'generatebt
        '
        Me.generatebt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.generatebt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.generatebt.FlatAppearance.BorderSize = 0
        Me.generatebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generatebt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.generatebt.Location = New System.Drawing.Point(553, 383)
        Me.generatebt.Name = "generatebt"
        Me.generatebt.Size = New System.Drawing.Size(75, 23)
        Me.generatebt.TabIndex = 0
        Me.generatebt.Text = "Generieren"
        Me.generatebt.UseVisualStyleBackColor = False
        '
        'generatetxt
        '
        Me.generatetxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.generatetxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.generatetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.generatetxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.generatetxt.Location = New System.Drawing.Point(12, 35)
        Me.generatetxt.Multiline = True
        Me.generatetxt.Name = "generatetxt"
        Me.generatetxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.generatetxt.Size = New System.Drawing.Size(616, 279)
        Me.generatetxt.TabIndex = 1
        '
        'length
        '
        Me.length.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.length.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.length.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.length.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.length.Location = New System.Drawing.Point(195, 387)
        Me.length.MaxLength = 5
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(75, 20)
        Me.length.TabIndex = 2
        Me.length.Text = "32"
        '
        'uppercasecb
        '
        Me.uppercasecb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.uppercasecb.AutoSize = True
        Me.uppercasecb.Checked = True
        Me.uppercasecb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uppercasecb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.uppercasecb.Location = New System.Drawing.Point(12, 343)
        Me.uppercasecb.Name = "uppercasecb"
        Me.uppercasecb.Size = New System.Drawing.Size(105, 17)
        Me.uppercasecb.TabIndex = 3
        Me.uppercasecb.Text = "Großbuchstaben"
        Me.uppercasecb.UseVisualStyleBackColor = True
        '
        'lowercasecb
        '
        Me.lowercasecb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lowercasecb.AutoSize = True
        Me.lowercasecb.Checked = True
        Me.lowercasecb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.lowercasecb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lowercasecb.Location = New System.Drawing.Point(12, 366)
        Me.lowercasecb.Name = "lowercasecb"
        Me.lowercasecb.Size = New System.Drawing.Size(105, 17)
        Me.lowercasecb.TabIndex = 4
        Me.lowercasecb.Text = "Kleinbuchstaben"
        Me.lowercasecb.UseVisualStyleBackColor = True
        '
        'numberscb
        '
        Me.numberscb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.numberscb.AutoSize = True
        Me.numberscb.Checked = True
        Me.numberscb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.numberscb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.numberscb.Location = New System.Drawing.Point(12, 389)
        Me.numberscb.Name = "numberscb"
        Me.numberscb.Size = New System.Drawing.Size(59, 17)
        Me.numberscb.TabIndex = 5
        Me.numberscb.Text = "Zahlen"
        Me.numberscb.UseVisualStyleBackColor = True
        '
        'lengthlb
        '
        Me.lengthlb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lengthlb.AutoSize = True
        Me.lengthlb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lengthlb.Location = New System.Drawing.Point(152, 390)
        Me.lengthlb.Name = "lengthlb"
        Me.lengthlb.Size = New System.Drawing.Size(37, 13)
        Me.lengthlb.TabIndex = 6
        Me.lengthlb.Text = "Länge"
        '
        'copybt
        '
        Me.copybt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.copybt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.copybt.Enabled = False
        Me.copybt.FlatAppearance.BorderSize = 0
        Me.copybt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copybt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.copybt.Location = New System.Drawing.Point(472, 383)
        Me.copybt.Name = "copybt"
        Me.copybt.Size = New System.Drawing.Size(75, 23)
        Me.copybt.TabIndex = 7
        Me.copybt.Text = "Kopieren"
        Me.copybt.UseVisualStyleBackColor = False
        '
        'specialchar
        '
        Me.specialchar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.specialchar.AutoSize = True
        Me.specialchar.Checked = True
        Me.specialchar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.specialchar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.specialchar.Location = New System.Drawing.Point(12, 320)
        Me.specialchar.Name = "specialchar"
        Me.specialchar.Size = New System.Drawing.Size(157, 17)
        Me.specialchar.TabIndex = 9
        Me.specialchar.Text = "Sonderzeichen (!""§$%&/()=?)"
        Me.specialchar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(640, 27)
        Me.MenuStrip1.TabIndex = 31
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
        Me.wincrypttitle.Size = New System.Drawing.Size(121, 16)
        Me.wincrypttitle.TabIndex = 32
        Me.wincrypttitle.Text = "Passwortgenerator"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_WinCrypt.My.Resources.Resources.icon
        Me.PictureBox1.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'passwordgenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 418)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.specialchar)
        Me.Controls.Add(Me.copybt)
        Me.Controls.Add(Me.lengthlb)
        Me.Controls.Add(Me.numberscb)
        Me.Controls.Add(Me.lowercasecb)
        Me.Controls.Add(Me.uppercasecb)
        Me.Controls.Add(Me.length)
        Me.Controls.Add(Me.generatetxt)
        Me.Controls.Add(Me.generatebt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "passwordgenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WinCrypt - Passwortgenerator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents generatebt As System.Windows.Forms.Button
    Friend WithEvents generatetxt As System.Windows.Forms.TextBox
    Friend WithEvents length As System.Windows.Forms.TextBox
    Friend WithEvents uppercasecb As System.Windows.Forms.CheckBox
    Friend WithEvents lowercasecb As System.Windows.Forms.CheckBox
    Friend WithEvents numberscb As System.Windows.Forms.CheckBox
    Friend WithEvents lengthlb As System.Windows.Forms.Label
    Friend WithEvents copybt As System.Windows.Forms.Button
    Friend WithEvents specialchar As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
