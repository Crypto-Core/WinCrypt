Namespace tools.data_encryption
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Filedecrypt
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Filedecrypt))
            Me.statuslb = New System.Windows.Forms.Label()
            Me.pwdlb = New System.Windows.Forms.Label()
            Me.pathlb = New System.Windows.Forms.Label()
            Me.passwordtxt = New System.Windows.Forms.TextBox()
            Me.decrypt = New System.Windows.Forms.Button()
            Me.pathtxt = New System.Windows.Forms.TextBox()
            Me.savefile = New System.Windows.Forms.Button()
            Me.filelb = New System.Windows.Forms.Label()
            Me.filetxt = New System.Windows.Forms.TextBox()
            Me.openfile = New System.Windows.Forms.Button()
            Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
            Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
            Me.dragdroplb = New System.Windows.Forms.Label()
            Me.form_head = New System.Windows.Forms.MenuStrip()
            Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.minimize_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.wincrypttitle = New System.Windows.Forms.Label()
            Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
            Me.form_head.SuspendLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'statuslb
            '
            Me.statuslb.AllowDrop = True
            Me.statuslb.BackColor = System.Drawing.Color.Gray
            Me.statuslb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.statuslb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
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
            Me.pwdlb.Size = New System.Drawing.Size(56, 13)
            Me.pwdlb.TabIndex = 19
            Me.pwdlb.Text = "Passwort:"
            '
            'pathlb
            '
            Me.pathlb.AutoSize = True
            Me.pathlb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.pathlb.Location = New System.Drawing.Point(6, 64)
            Me.pathlb.Name = "pathlb"
            Me.pathlb.Size = New System.Drawing.Size(33, 13)
            Me.pathlb.TabIndex = 18
            Me.pathlb.Text = "Pfad:"
            '
            'passwordtxt
            '
            Me.passwordtxt.AllowDrop = True
            Me.passwordtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.passwordtxt.Enabled = False
            Me.passwordtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.passwordtxt.Location = New System.Drawing.Point(67, 90)
            Me.passwordtxt.Name = "passwordtxt"
            Me.passwordtxt.Size = New System.Drawing.Size(238, 22)
            Me.passwordtxt.TabIndex = 17
            Me.passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'decrypt
            '
            Me.decrypt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.decrypt.Enabled = False
            Me.decrypt.FlatAppearance.BorderSize = 0
            Me.decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.decrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.decrypt.Location = New System.Drawing.Point(167, 140)
            Me.decrypt.Name = "decrypt"
            Me.decrypt.Size = New System.Drawing.Size(86, 23)
            Me.decrypt.TabIndex = 16
            Me.decrypt.Text = "Entschlüsseln"
            Me.decrypt.UseVisualStyleBackColor = False
            '
            'pathtxt
            '
            Me.pathtxt.AllowDrop = True
            Me.pathtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.pathtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pathtxt.Enabled = False
            Me.pathtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.pathtxt.Location = New System.Drawing.Point(58, 62)
            Me.pathtxt.Name = "pathtxt"
            Me.pathtxt.Size = New System.Drawing.Size(245, 22)
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
            Me.filelb.Size = New System.Drawing.Size(37, 13)
            Me.filelb.TabIndex = 13
            Me.filelb.Text = "Datei:"
            '
            'filetxt
            '
            Me.filetxt.AllowDrop = True
            Me.filetxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.filetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.filetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.filetxt.Location = New System.Drawing.Point(58, 33)
            Me.filetxt.Name = "filetxt"
            Me.filetxt.Size = New System.Drawing.Size(245, 22)
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
            Me.dragdroplb.Size = New System.Drawing.Size(58, 13)
            Me.dragdroplb.TabIndex = 22
            Me.dragdroplb.Text = "Drag&Drop"
            '
            'form_head
            '
            Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt, Me.minimize_bt})
            Me.form_head.Location = New System.Drawing.Point(0, 0)
            Me.form_head.Name = "form_head"
            Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.form_head.Size = New System.Drawing.Size(420, 27)
            Me.form_head.TabIndex = 23
            Me.form_head.Text = "WinCrypt"
            '
            'exit_bt
            '
            Me.exit_bt.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.exit_bt.ForeColor = System.Drawing.Color.White
            Me.exit_bt.Name = "exit_bt"
            Me.exit_bt.Size = New System.Drawing.Size(29, 23)
            Me.exit_bt.Text = "X"
            '
            'minimize_bt
            '
            Me.minimize_bt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.minimize_bt.ForeColor = System.Drawing.Color.White
            Me.minimize_bt.Name = "minimize_bt"
            Me.minimize_bt.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.minimize_bt.Size = New System.Drawing.Size(32, 23)
            Me.minimize_bt.Text = "─"
            '
            'wincrypttitle
            '
            Me.wincrypttitle.AutoSize = True
            Me.wincrypttitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.wincrypttitle.Location = New System.Drawing.Point(34, 6)
            Me.wincrypttitle.Name = "wincrypttitle"
            Me.wincrypttitle.Size = New System.Drawing.Size(118, 17)
            Me.wincrypttitle.TabIndex = 24
            Me.wincrypttitle.Text = "Datei entschlüsseln"
            '
            'wincrypt_icon
            '
            Me.wincrypt_icon.Image = Global.Project_WinCrypt.My.Resources.Resources.wc_icon16
            Me.wincrypt_icon.Location = New System.Drawing.Point(9, 6)
            Me.wincrypt_icon.Name = "wincrypt_icon"
            Me.wincrypt_icon.Size = New System.Drawing.Size(16, 16)
            Me.wincrypt_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.wincrypt_icon.TabIndex = 25
            Me.wincrypt_icon.TabStop = False
            '
            'Filedecrypt
            '
            Me.AllowDrop = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(420, 180)
            Me.Controls.Add(Me.wincrypt_icon)
            Me.Controls.Add(Me.wincrypttitle)
            Me.Controls.Add(Me.form_head)
            Me.Controls.Add(Me.dragdroplb)
            Me.Controls.Add(Me.statuslb)
            Me.Controls.Add(Me.pwdlb)
            Me.Controls.Add(Me.pathlb)
            Me.Controls.Add(Me.passwordtxt)
            Me.Controls.Add(Me.decrypt)
            Me.Controls.Add(Me.pathtxt)
            Me.Controls.Add(Me.savefile)
            Me.Controls.Add(Me.filelb)
            Me.Controls.Add(Me.filetxt)
            Me.Controls.Add(Me.openfile)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Filedecrypt"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Datei entschlüsseln"
            Me.form_head.ResumeLayout(False)
            Me.form_head.PerformLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents statuslb As System.Windows.Forms.Label
        Friend WithEvents pwdlb As System.Windows.Forms.Label
        Friend WithEvents pathlb As System.Windows.Forms.Label
        Friend WithEvents passwordtxt As System.Windows.Forms.TextBox
        Friend WithEvents decrypt As System.Windows.Forms.Button
        Friend WithEvents pathtxt As System.Windows.Forms.TextBox
        Friend WithEvents savefile As System.Windows.Forms.Button
        Friend WithEvents filelb As System.Windows.Forms.Label
        Friend WithEvents filetxt As System.Windows.Forms.TextBox
        Friend WithEvents openfile As System.Windows.Forms.Button
        Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
        Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
        Friend WithEvents dragdroplb As System.Windows.Forms.Label
        Friend WithEvents form_head As System.Windows.Forms.MenuStrip
        Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents minimize_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents wincrypttitle As System.Windows.Forms.Label
        Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
    End Class
End Namespace