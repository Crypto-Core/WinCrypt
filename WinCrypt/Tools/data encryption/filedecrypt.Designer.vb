<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filedecrypt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(filedecrypt))
        Me.statuslb = New System.Windows.Forms.Label()
        Me.pwdlb = New System.Windows.Forms.Label()
        Me.pathlb = New System.Windows.Forms.Label()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.dencrypt = New System.Windows.Forms.Button()
        Me.pathtxt = New System.Windows.Forms.TextBox()
        Me.savefile = New System.Windows.Forms.Button()
        Me.filelb = New System.Windows.Forms.Label()
        Me.filetxt = New System.Windows.Forms.TextBox()
        Me.openfile = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
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
        'statuslb
        '
        Me.statuslb.AllowDrop = True
        Me.statuslb.BackColor = System.Drawing.Color.Gray
        Me.statuslb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.statuslb.ForeColor = System.Drawing.Color.Lime
        Me.statuslb.Location = New System.Drawing.Point(9, 113)
        Me.statuslb.Name = "statuslb"
        Me.statuslb.Size = New System.Drawing.Size(405, 20)
        Me.statuslb.TabIndex = 21
        Me.statuslb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pwdlb
        '
        Me.pwdlb.AutoSize = True
        Me.pwdlb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pwdlb.Location = New System.Drawing.Point(5, 93)
        Me.pwdlb.Name = "pwdlb"
        Me.pwdlb.Size = New System.Drawing.Size(53, 13)
        Me.pwdlb.TabIndex = 19
        Me.pwdlb.Text = "Passwort:"
        '
        'pathlb
        '
        Me.pathlb.AutoSize = True
        Me.pathlb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pathlb.Location = New System.Drawing.Point(6, 64)
        Me.pathlb.Name = "pathlb"
        Me.pathlb.Size = New System.Drawing.Size(32, 13)
        Me.pathlb.TabIndex = 18
        Me.pathlb.Text = "Pfad:"
        '
        'passwordtxt
        '
        Me.passwordtxt.AllowDrop = True
        Me.passwordtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passwordtxt.Enabled = False
        Me.passwordtxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.passwordtxt.Location = New System.Drawing.Point(64, 90)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(241, 20)
        Me.passwordtxt.TabIndex = 17
        Me.passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dencrypt
        '
        Me.dencrypt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dencrypt.Enabled = False
        Me.dencrypt.FlatAppearance.BorderSize = 0
        Me.dencrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dencrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dencrypt.Location = New System.Drawing.Point(167, 140)
        Me.dencrypt.Name = "dencrypt"
        Me.dencrypt.Size = New System.Drawing.Size(86, 23)
        Me.dencrypt.TabIndex = 16
        Me.dencrypt.Text = "Entschlüsseln"
        Me.dencrypt.UseVisualStyleBackColor = False
        '
        'pathtxt
        '
        Me.pathtxt.AllowDrop = True
        Me.pathtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pathtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pathtxt.Enabled = False
        Me.pathtxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pathtxt.Location = New System.Drawing.Point(46, 61)
        Me.pathtxt.Name = "pathtxt"
        Me.pathtxt.Size = New System.Drawing.Size(259, 20)
        Me.pathtxt.TabIndex = 15
        '
        'savefile
        '
        Me.savefile.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.savefile.Enabled = False
        Me.savefile.FlatAppearance.BorderSize = 0
        Me.savefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savefile.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.savefile.Location = New System.Drawing.Point(311, 59)
        Me.savefile.Name = "savefile"
        Me.savefile.Size = New System.Drawing.Size(104, 23)
        Me.savefile.TabIndex = 14
        Me.savefile.Text = "Speichern unter..."
        Me.savefile.UseVisualStyleBackColor = False
        '
        'filelb
        '
        Me.filelb.AutoSize = True
        Me.filelb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.filelb.Location = New System.Drawing.Point(5, 35)
        Me.filelb.Name = "filelb"
        Me.filelb.Size = New System.Drawing.Size(35, 13)
        Me.filelb.TabIndex = 13
        Me.filelb.Text = "Datei:"
        '
        'filetxt
        '
        Me.filetxt.AllowDrop = True
        Me.filetxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.filetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.filetxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.filetxt.Location = New System.Drawing.Point(46, 32)
        Me.filetxt.Name = "filetxt"
        Me.filetxt.Size = New System.Drawing.Size(259, 20)
        Me.filetxt.TabIndex = 12
        Me.filetxt.Tag = "Test"
        '
        'openfile
        '
        Me.openfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.openfile.FlatAppearance.BorderSize = 0
        Me.openfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.openfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.openfile.Location = New System.Drawing.Point(311, 30)
        Me.openfile.Name = "openfile"
        Me.openfile.Size = New System.Drawing.Size(104, 23)
        Me.openfile.TabIndex = 11
        Me.openfile.Text = "Öffnen"
        Me.openfile.UseVisualStyleBackColor = False
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'dragdroplb
        '
        Me.dragdroplb.AutoSize = True
        Me.dragdroplb.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.dragdroplb.Location = New System.Drawing.Point(1, 161)
        Me.dragdroplb.Name = "dragdroplb"
        Me.dragdroplb.Size = New System.Drawing.Size(53, 13)
        Me.dragdroplb.TabIndex = 22
        Me.dragdroplb.Text = "Drag&Drop"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(420, 27)
        Me.MenuStrip1.TabIndex = 23
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
        Me.wincrypttitle.Size = New System.Drawing.Size(124, 16)
        Me.wincrypttitle.TabIndex = 24
        Me.wincrypttitle.Text = "Datei entschlüsseln"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_WinCrypt.My.Resources.Resources.icon
        Me.PictureBox1.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'filedecrypt
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 180)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dragdroplb)
        Me.Controls.Add(Me.statuslb)
        Me.Controls.Add(Me.pwdlb)
        Me.Controls.Add(Me.pathlb)
        Me.Controls.Add(Me.passwordtxt)
        Me.Controls.Add(Me.dencrypt)
        Me.Controls.Add(Me.pathtxt)
        Me.Controls.Add(Me.savefile)
        Me.Controls.Add(Me.filelb)
        Me.Controls.Add(Me.filetxt)
        Me.Controls.Add(Me.openfile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "filedecrypt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datei entschlüsseln"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statuslb As System.Windows.Forms.Label
    Friend WithEvents pwdlb As System.Windows.Forms.Label
    Friend WithEvents pathlb As System.Windows.Forms.Label
    Friend WithEvents passwordtxt As System.Windows.Forms.TextBox
    Friend WithEvents dencrypt As System.Windows.Forms.Button
    Friend WithEvents pathtxt As System.Windows.Forms.TextBox
    Friend WithEvents savefile As System.Windows.Forms.Button
    Friend WithEvents filelb As System.Windows.Forms.Label
    Friend WithEvents filetxt As System.Windows.Forms.TextBox
    Friend WithEvents openfile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents dragdroplb As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
