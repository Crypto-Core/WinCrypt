<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bruteforce
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            Try
                MyBase.Dispose(disposing)
            Catch ex As Exception

            End Try

        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bruteforce))
        Me.bruteforcesearchedHash = New System.Windows.Forms.TextBox()
        Me.md5_lb = New System.Windows.Forms.Label()
        Me.passwordlist_lb = New System.Windows.Forms.Label()
        Me.fileWordlist = New System.Windows.Forms.TextBox()
        Me.openWordlist = New System.Windows.Forms.Button()
        Me.bruteforceStatus = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.bgw = New System.ComponentModel.BackgroundWorker()
        Me.bruteforceWorker_status = New System.Windows.Forms.Timer(Me.components)
        Me.bruteforcerightPassword = New System.Windows.Forms.Label()
        Me.bruteforceLine = New System.Windows.Forms.Label()
        Me.bruteforceHash = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bruteforcePassword = New System.Windows.Forms.Label()
        Me.bruteforceChecked = New System.Windows.Forms.ProgressBar()
        Me.showProgress = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bruteforceHashtype = New System.Windows.Forms.ComboBox()
        Me.bruteforceToggle = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bruteforcesearchedHash
        '
        Me.bruteforcesearchedHash.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.bruteforcesearchedHash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bruteforcesearchedHash.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bruteforcesearchedHash.Location = New System.Drawing.Point(43, 36)
        Me.bruteforcesearchedHash.Name = "bruteforcesearchedHash"
        Me.bruteforcesearchedHash.Size = New System.Drawing.Size(252, 20)
        Me.bruteforcesearchedHash.TabIndex = 1
        Me.bruteforcesearchedHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'md5_lb
        '
        Me.md5_lb.AutoSize = True
        Me.md5_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.md5_lb.Location = New System.Drawing.Point(6, 39)
        Me.md5_lb.Name = "md5_lb"
        Me.md5_lb.Size = New System.Drawing.Size(35, 13)
        Me.md5_lb.TabIndex = 2
        Me.md5_lb.Text = "Hash:"
        '
        'passwordlist_lb
        '
        Me.passwordlist_lb.AutoSize = True
        Me.passwordlist_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.passwordlist_lb.Location = New System.Drawing.Point(6, 61)
        Me.passwordlist_lb.Name = "passwordlist_lb"
        Me.passwordlist_lb.Size = New System.Drawing.Size(71, 13)
        Me.passwordlist_lb.TabIndex = 3
        Me.passwordlist_lb.Text = "Passwortliste:"
        '
        'fileWordlist
        '
        Me.fileWordlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.fileWordlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fileWordlist.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.fileWordlist.Location = New System.Drawing.Point(10, 77)
        Me.fileWordlist.Name = "fileWordlist"
        Me.fileWordlist.Size = New System.Drawing.Size(322, 20)
        Me.fileWordlist.TabIndex = 4
        '
        'openWordlist
        '
        Me.openWordlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.openWordlist.FlatAppearance.BorderSize = 0
        Me.openWordlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.openWordlist.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.openWordlist.Location = New System.Drawing.Point(338, 75)
        Me.openWordlist.Name = "openWordlist"
        Me.openWordlist.Size = New System.Drawing.Size(75, 23)
        Me.openWordlist.TabIndex = 5
        Me.openWordlist.Text = "Öffnen"
        Me.openWordlist.UseVisualStyleBackColor = False
        '
        'bruteforceStatus
        '
        Me.bruteforceStatus.AutoSize = True
        Me.bruteforceStatus.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bruteforceStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bruteforceStatus.Location = New System.Drawing.Point(30, 9)
        Me.bruteforceStatus.Name = "bruteforceStatus"
        Me.bruteforceStatus.Size = New System.Drawing.Size(64, 16)
        Me.bruteforceStatus.TabIndex = 6
        Me.bruteforceStatus.Text = "Status:"
        '
        'bgw
        '
        Me.bgw.WorkerReportsProgress = True
        Me.bgw.WorkerSupportsCancellation = True
        '
        'bruteforceWorker_status
        '
        Me.bruteforceWorker_status.Interval = 1
        '
        'bruteforcerightPassword
        '
        Me.bruteforcerightPassword.AutoSize = True
        Me.bruteforcerightPassword.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bruteforcerightPassword.ForeColor = System.Drawing.Color.Lime
        Me.bruteforcerightPassword.Location = New System.Drawing.Point(14, 57)
        Me.bruteforcerightPassword.Name = "bruteforcerightPassword"
        Me.bruteforcerightPassword.Size = New System.Drawing.Size(80, 16)
        Me.bruteforcerightPassword.TabIndex = 7
        Me.bruteforcerightPassword.Text = "Passwort:"
        Me.bruteforcerightPassword.Visible = False
        '
        'bruteforceLine
        '
        Me.bruteforceLine.AutoSize = True
        Me.bruteforceLine.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bruteforceLine.ForeColor = System.Drawing.Color.Lime
        Me.bruteforceLine.Location = New System.Drawing.Point(46, 76)
        Me.bruteforceLine.Name = "bruteforceLine"
        Me.bruteforceLine.Size = New System.Drawing.Size(48, 16)
        Me.bruteforceLine.TabIndex = 8
        Me.bruteforceLine.Text = "Line:"
        Me.bruteforceLine.Visible = False
        '
        'bruteforceHash
        '
        Me.bruteforceHash.AutoSize = True
        Me.bruteforceHash.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bruteforceHash.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bruteforceHash.Location = New System.Drawing.Point(46, 34)
        Me.bruteforceHash.Name = "bruteforceHash"
        Me.bruteforceHash.Size = New System.Drawing.Size(48, 16)
        Me.bruteforceHash.TabIndex = 9
        Me.bruteforceHash.Text = "Hash:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.bruteforcePassword)
        Me.Panel1.Controls.Add(Me.bruteforcerightPassword)
        Me.Panel1.Controls.Add(Me.bruteforceHash)
        Me.Panel1.Controls.Add(Me.bruteforceLine)
        Me.Panel1.Controls.Add(Me.bruteforceStatus)
        Me.Panel1.Location = New System.Drawing.Point(10, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 139)
        Me.Panel1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(3, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(397, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "_________________________________________________________________"
        '
        'bruteforcePassword
        '
        Me.bruteforcePassword.AutoSize = True
        Me.bruteforcePassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bruteforcePassword.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bruteforcePassword.ForeColor = System.Drawing.Color.Red
        Me.bruteforcePassword.Location = New System.Drawing.Point(14, 115)
        Me.bruteforcePassword.Name = "bruteforcePassword"
        Me.bruteforcePassword.Size = New System.Drawing.Size(136, 16)
        Me.bruteforcePassword.TabIndex = 10
        Me.bruteforcePassword.Text = "tested password:"
        '
        'bruteforceChecked
        '
        Me.bruteforceChecked.Location = New System.Drawing.Point(10, 280)
        Me.bruteforceChecked.Name = "bruteforceChecked"
        Me.bruteforceChecked.Size = New System.Drawing.Size(400, 23)
        Me.bruteforceChecked.TabIndex = 12
        '
        'showProgress
        '
        Me.showProgress.AutoSize = True
        Me.showProgress.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.showProgress.Location = New System.Drawing.Point(9, 252)
        Me.showProgress.Name = "showProgress"
        Me.showProgress.Size = New System.Drawing.Size(117, 17)
        Me.showProgress.TabIndex = 13
        Me.showProgress.Text = "Zeige Fortschritt an"
        Me.showProgress.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(299, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Art:"
        '
        'bruteforceHashtype
        '
        Me.bruteforceHashtype.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.bruteforceHashtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bruteforceHashtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bruteforceHashtype.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bruteforceHashtype.FormattingEnabled = True
        Me.bruteforceHashtype.Items.AddRange(New Object() {"MD5", "SHA1", "SHA256", "SHA384", "SHA512", "RIPEMD160"})
        Me.bruteforceHashtype.Location = New System.Drawing.Point(323, 36)
        Me.bruteforceHashtype.Name = "bruteforceHashtype"
        Me.bruteforceHashtype.Size = New System.Drawing.Size(90, 21)
        Me.bruteforceHashtype.TabIndex = 14
        '
        'bruteforceToggle
        '
        Me.bruteforceToggle.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bruteforceToggle.FlatAppearance.BorderSize = 0
        Me.bruteforceToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bruteforceToggle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bruteforceToggle.Location = New System.Drawing.Point(159, 248)
        Me.bruteforceToggle.Name = "bruteforceToggle"
        Me.bruteforceToggle.Size = New System.Drawing.Size(101, 23)
        Me.bruteforceToggle.TabIndex = 16
        Me.bruteforceToggle.Text = "Brute Force"
        Me.bruteforceToggle.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(421, 27)
        Me.MenuStrip1.TabIndex = 17
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
        Me.wincrypttitle.Size = New System.Drawing.Size(104, 16)
        Me.wincrypttitle.TabIndex = 18
        Me.wincrypttitle.Text = "MD5 Brute-force"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_WinCrypt.My.Resources.Resources.icon
        Me.PictureBox1.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'bruteforce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(421, 276)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.bruteforceToggle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bruteforceHashtype)
        Me.Controls.Add(Me.showProgress)
        Me.Controls.Add(Me.bruteforceChecked)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.openWordlist)
        Me.Controls.Add(Me.fileWordlist)
        Me.Controls.Add(Me.passwordlist_lb)
        Me.Controls.Add(Me.md5_lb)
        Me.Controls.Add(Me.bruteforcesearchedHash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "bruteforce"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hash Brute Force"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bruteforcesearchedHash As System.Windows.Forms.TextBox
    Friend WithEvents md5_lb As System.Windows.Forms.Label
    Friend WithEvents passwordlist_lb As System.Windows.Forms.Label
    Friend WithEvents fileWordlist As System.Windows.Forms.TextBox
    Friend WithEvents openWordlist As System.Windows.Forms.Button
    Friend WithEvents bruteforceStatus As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bgw As System.ComponentModel.BackgroundWorker
    Friend WithEvents bruteforceWorker_status As System.Windows.Forms.Timer
    Friend WithEvents bruteforcerightPassword As System.Windows.Forms.Label
    Friend WithEvents bruteforceLine As System.Windows.Forms.Label
    Friend WithEvents bruteforceHash As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bruteforcePassword As System.Windows.Forms.Label
    Friend WithEvents bruteforceChecked As System.Windows.Forms.ProgressBar
    Friend WithEvents showProgress As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bruteforceHashtype As System.Windows.Forms.ComboBox
    Friend WithEvents bruteforceToggle As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
