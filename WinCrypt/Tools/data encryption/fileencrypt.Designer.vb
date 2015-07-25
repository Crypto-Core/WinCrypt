<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fileencrypt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fileencrypt))
        Me.fileopenbt = New System.Windows.Forms.Button()
        Me.filetxt = New System.Windows.Forms.TextBox()
        Me.filelb = New System.Windows.Forms.Label()
        Me.savefilebt = New System.Windows.Forms.Button()
        Me.savepathtxt = New System.Windows.Forms.TextBox()
        Me.encryptbt = New System.Windows.Forms.Button()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.pathlb = New System.Windows.Forms.Label()
        Me.passwordlb = New System.Windows.Forms.Label()
        Me.generatebt = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.statuslb = New System.Windows.Forms.Label()
        Me.dragdroplb = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fileopenbt
        '
        Me.fileopenbt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fileopenbt.FlatAppearance.BorderSize = 0
        Me.fileopenbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fileopenbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.fileopenbt.Location = New System.Drawing.Point(315, 42)
        Me.fileopenbt.Name = "fileopenbt"
        Me.fileopenbt.Size = New System.Drawing.Size(104, 23)
        Me.fileopenbt.TabIndex = 0
        Me.fileopenbt.Text = "Öffnen"
        Me.fileopenbt.UseVisualStyleBackColor = False
        '
        'filetxt
        '
        Me.filetxt.AllowDrop = True
        Me.filetxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.filetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.filetxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.filetxt.Location = New System.Drawing.Point(50, 44)
        Me.filetxt.Name = "filetxt"
        Me.filetxt.Size = New System.Drawing.Size(259, 20)
        Me.filetxt.TabIndex = 1
        Me.filetxt.Tag = "Test"
        '
        'filelb
        '
        Me.filelb.AutoSize = True
        Me.filelb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.filelb.Location = New System.Drawing.Point(9, 47)
        Me.filelb.Name = "filelb"
        Me.filelb.Size = New System.Drawing.Size(35, 13)
        Me.filelb.TabIndex = 2
        Me.filelb.Text = "Datei:"
        '
        'savefilebt
        '
        Me.savefilebt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.savefilebt.Enabled = False
        Me.savefilebt.FlatAppearance.BorderSize = 0
        Me.savefilebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savefilebt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.savefilebt.Location = New System.Drawing.Point(315, 71)
        Me.savefilebt.Name = "savefilebt"
        Me.savefilebt.Size = New System.Drawing.Size(104, 23)
        Me.savefilebt.TabIndex = 3
        Me.savefilebt.Text = "Speichern unter..."
        Me.savefilebt.UseVisualStyleBackColor = False
        '
        'savepathtxt
        '
        Me.savepathtxt.AllowDrop = True
        Me.savepathtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.savepathtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.savepathtxt.Enabled = False
        Me.savepathtxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.savepathtxt.Location = New System.Drawing.Point(50, 73)
        Me.savepathtxt.Name = "savepathtxt"
        Me.savepathtxt.Size = New System.Drawing.Size(259, 20)
        Me.savepathtxt.TabIndex = 4
        '
        'encryptbt
        '
        Me.encryptbt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.encryptbt.Enabled = False
        Me.encryptbt.FlatAppearance.BorderSize = 0
        Me.encryptbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.encryptbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.encryptbt.Location = New System.Drawing.Point(172, 152)
        Me.encryptbt.Name = "encryptbt"
        Me.encryptbt.Size = New System.Drawing.Size(86, 23)
        Me.encryptbt.TabIndex = 5
        Me.encryptbt.Text = "Verschlüsseln"
        Me.encryptbt.UseVisualStyleBackColor = False
        '
        'passwordtxt
        '
        Me.passwordtxt.AllowDrop = True
        Me.passwordtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passwordtxt.Enabled = False
        Me.passwordtxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.passwordtxt.Location = New System.Drawing.Point(68, 102)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(241, 20)
        Me.passwordtxt.TabIndex = 6
        Me.passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pathlb
        '
        Me.pathlb.AutoSize = True
        Me.pathlb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pathlb.Location = New System.Drawing.Point(10, 76)
        Me.pathlb.Name = "pathlb"
        Me.pathlb.Size = New System.Drawing.Size(32, 13)
        Me.pathlb.TabIndex = 7
        Me.pathlb.Text = "Pfad:"
        '
        'passwordlb
        '
        Me.passwordlb.AutoSize = True
        Me.passwordlb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.passwordlb.Location = New System.Drawing.Point(9, 105)
        Me.passwordlb.Name = "passwordlb"
        Me.passwordlb.Size = New System.Drawing.Size(53, 13)
        Me.passwordlb.TabIndex = 8
        Me.passwordlb.Text = "Passwort:"
        '
        'generatebt
        '
        Me.generatebt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.generatebt.Enabled = False
        Me.generatebt.FlatAppearance.BorderSize = 0
        Me.generatebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generatebt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.generatebt.Location = New System.Drawing.Point(315, 100)
        Me.generatebt.Name = "generatebt"
        Me.generatebt.Size = New System.Drawing.Size(103, 23)
        Me.generatebt.TabIndex = 9
        Me.generatebt.Text = "Generieren"
        Me.generatebt.UseVisualStyleBackColor = False
        '
        'statuslb
        '
        Me.statuslb.AllowDrop = True
        Me.statuslb.BackColor = System.Drawing.Color.Gray
        Me.statuslb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.statuslb.ForeColor = System.Drawing.Color.Lime
        Me.statuslb.Location = New System.Drawing.Point(13, 125)
        Me.statuslb.Name = "statuslb"
        Me.statuslb.Size = New System.Drawing.Size(405, 20)
        Me.statuslb.TabIndex = 10
        Me.statuslb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dragdroplb
        '
        Me.dragdroplb.AutoSize = True
        Me.dragdroplb.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.dragdroplb.Location = New System.Drawing.Point(1, 171)
        Me.dragdroplb.Name = "dragdroplb"
        Me.dragdroplb.Size = New System.Drawing.Size(53, 13)
        Me.dragdroplb.TabIndex = 11
        Me.dragdroplb.Text = "Drag&Drop"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(430, 27)
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
        Me.wincrypttitle.Size = New System.Drawing.Size(125, 16)
        Me.wincrypttitle.TabIndex = 25
        Me.wincrypttitle.Text = "Datei verschlüsseln"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_WinCrypt.My.Resources.Resources.icon
        Me.PictureBox1.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'fileencrypt
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 189)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dragdroplb)
        Me.Controls.Add(Me.statuslb)
        Me.Controls.Add(Me.generatebt)
        Me.Controls.Add(Me.passwordlb)
        Me.Controls.Add(Me.pathlb)
        Me.Controls.Add(Me.passwordtxt)
        Me.Controls.Add(Me.encryptbt)
        Me.Controls.Add(Me.savepathtxt)
        Me.Controls.Add(Me.savefilebt)
        Me.Controls.Add(Me.filelb)
        Me.Controls.Add(Me.filetxt)
        Me.Controls.Add(Me.fileopenbt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fileencrypt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datei Verschlüsseln"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fileopenbt As System.Windows.Forms.Button
    Friend WithEvents filetxt As System.Windows.Forms.TextBox
    Friend WithEvents filelb As System.Windows.Forms.Label
    Friend WithEvents savefilebt As System.Windows.Forms.Button
    Friend WithEvents savepathtxt As System.Windows.Forms.TextBox
    Friend WithEvents encryptbt As System.Windows.Forms.Button
    Friend WithEvents passwordtxt As System.Windows.Forms.TextBox
    Friend WithEvents pathlb As System.Windows.Forms.Label
    Friend WithEvents passwordlb As System.Windows.Forms.Label
    Friend WithEvents generatebt As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents statuslb As System.Windows.Forms.Label
    Friend WithEvents dragdroplb As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
