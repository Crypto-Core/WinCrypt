Namespace tools.hash
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Bruteforce
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bruteforce))
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
            Me.StatusViewer = New System.Windows.Forms.Panel()
            Me.line_lb = New System.Windows.Forms.Label()
            Me.bruteforcePassword = New System.Windows.Forms.Label()
            Me.bruteforceChecked = New System.Windows.Forms.ProgressBar()
            Me.showProgress = New System.Windows.Forms.CheckBox()
            Me.art_lb = New System.Windows.Forms.Label()
            Me.bruteforceHashtype = New System.Windows.Forms.ComboBox()
            Me.bruteforceToggle = New System.Windows.Forms.Button()
            Me.form_head = New System.Windows.Forms.MenuStrip()
            Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.minimize_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.wincrypttitle = New System.Windows.Forms.Label()
            Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
            Me.StatusViewer.SuspendLayout()
            Me.form_head.SuspendLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'bruteforcesearchedHash
            '
            Me.bruteforcesearchedHash.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.bruteforcesearchedHash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.bruteforcesearchedHash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.bruteforcesearchedHash.Location = New System.Drawing.Point(43, 36)
            Me.bruteforcesearchedHash.Name = "bruteforcesearchedHash"
            Me.bruteforcesearchedHash.Size = New System.Drawing.Size(252, 22)
            Me.bruteforcesearchedHash.TabIndex = 1
            Me.bruteforcesearchedHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'md5_lb
            '
            Me.md5_lb.AutoSize = True
            Me.md5_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.md5_lb.Location = New System.Drawing.Point(6, 39)
            Me.md5_lb.Name = "md5_lb"
            Me.md5_lb.Size = New System.Drawing.Size(36, 13)
            Me.md5_lb.TabIndex = 2
            Me.md5_lb.Text = "Hash:"
            '
            'passwordlist_lb
            '
            Me.passwordlist_lb.AutoSize = True
            Me.passwordlist_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.passwordlist_lb.Location = New System.Drawing.Point(6, 61)
            Me.passwordlist_lb.Name = "passwordlist_lb"
            Me.passwordlist_lb.Size = New System.Drawing.Size(77, 13)
            Me.passwordlist_lb.TabIndex = 3
            Me.passwordlist_lb.Text = "Passwortliste:"
            '
            'fileWordlist
            '
            Me.fileWordlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.fileWordlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.fileWordlist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.fileWordlist.Location = New System.Drawing.Point(10, 77)
            Me.fileWordlist.Name = "fileWordlist"
            Me.fileWordlist.Size = New System.Drawing.Size(322, 22)
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
            'StatusViewer
            '
            Me.StatusViewer.BackColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.StatusViewer.Controls.Add(Me.line_lb)
            Me.StatusViewer.Controls.Add(Me.bruteforcePassword)
            Me.StatusViewer.Controls.Add(Me.bruteforcerightPassword)
            Me.StatusViewer.Controls.Add(Me.bruteforceHash)
            Me.StatusViewer.Controls.Add(Me.bruteforceLine)
            Me.StatusViewer.Controls.Add(Me.bruteforceStatus)
            Me.StatusViewer.Location = New System.Drawing.Point(10, 103)
            Me.StatusViewer.Name = "StatusViewer"
            Me.StatusViewer.Size = New System.Drawing.Size(403, 139)
            Me.StatusViewer.TabIndex = 10
            '
            'line_lb
            '
            Me.line_lb.AutoSize = True
            Me.line_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.line_lb.Location = New System.Drawing.Point(3, 97)
            Me.line_lb.Name = "line_lb"
            Me.line_lb.Size = New System.Drawing.Size(332, 13)
            Me.line_lb.TabIndex = 11
            Me.line_lb.Text = "_________________________________________________________________"
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
            Me.showProgress.Size = New System.Drawing.Size(126, 17)
            Me.showProgress.TabIndex = 13
            Me.showProgress.Text = "Zeige Fortschritt an"
            Me.showProgress.UseVisualStyleBackColor = True
            '
            'art_lb
            '
            Me.art_lb.AutoSize = True
            Me.art_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.art_lb.Location = New System.Drawing.Point(299, 39)
            Me.art_lb.Name = "art_lb"
            Me.art_lb.Size = New System.Drawing.Size(25, 13)
            Me.art_lb.TabIndex = 15
            Me.art_lb.Text = "Art:"
            '
            'bruteforceHashtype
            '
            Me.bruteforceHashtype.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.bruteforceHashtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.bruteforceHashtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bruteforceHashtype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.bruteforceHashtype.FormattingEnabled = True
            Me.bruteforceHashtype.Items.AddRange(New Object() {"MD5", "SHA1", "SHA256", "SHA384", "SHA512", "RIPEMD160"})
            Me.bruteforceHashtype.Location = New System.Drawing.Point(330, 36)
            Me.bruteforceHashtype.Name = "bruteforceHashtype"
            Me.bruteforceHashtype.Size = New System.Drawing.Size(83, 21)
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
            'form_head
            '
            Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt, Me.minimize_bt})
            Me.form_head.Location = New System.Drawing.Point(0, 0)
            Me.form_head.Name = "form_head"
            Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.form_head.Size = New System.Drawing.Size(421, 27)
            Me.form_head.TabIndex = 17
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
            Me.wincrypttitle.Size = New System.Drawing.Size(106, 17)
            Me.wincrypttitle.TabIndex = 18
            Me.wincrypttitle.Text = "Hash Brute-force"
            '
            'wincrypt_icon
            '
            Me.wincrypt_icon.Image = Global.Project_WinCrypt.My.Resources.Resources.wc_icon16
            Me.wincrypt_icon.Location = New System.Drawing.Point(9, 6)
            Me.wincrypt_icon.Name = "wincrypt_icon"
            Me.wincrypt_icon.Size = New System.Drawing.Size(16, 16)
            Me.wincrypt_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.wincrypt_icon.TabIndex = 19
            Me.wincrypt_icon.TabStop = False
            '
            'Bruteforce
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(421, 276)
            Me.Controls.Add(Me.wincrypt_icon)
            Me.Controls.Add(Me.wincrypttitle)
            Me.Controls.Add(Me.form_head)
            Me.Controls.Add(Me.bruteforceToggle)
            Me.Controls.Add(Me.art_lb)
            Me.Controls.Add(Me.bruteforceHashtype)
            Me.Controls.Add(Me.showProgress)
            Me.Controls.Add(Me.bruteforceChecked)
            Me.Controls.Add(Me.StatusViewer)
            Me.Controls.Add(Me.openWordlist)
            Me.Controls.Add(Me.fileWordlist)
            Me.Controls.Add(Me.passwordlist_lb)
            Me.Controls.Add(Me.md5_lb)
            Me.Controls.Add(Me.bruteforcesearchedHash)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Bruteforce"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Hash Brute Force"
            Me.StatusViewer.ResumeLayout(False)
            Me.StatusViewer.PerformLayout()
            Me.form_head.ResumeLayout(False)
            Me.form_head.PerformLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents StatusViewer As System.Windows.Forms.Panel
        Friend WithEvents line_lb As System.Windows.Forms.Label
        Friend WithEvents bruteforcePassword As System.Windows.Forms.Label
        Friend WithEvents bruteforceChecked As System.Windows.Forms.ProgressBar
        Friend WithEvents showProgress As System.Windows.Forms.CheckBox
        Friend WithEvents art_lb As System.Windows.Forms.Label
        Friend WithEvents bruteforceHashtype As System.Windows.Forms.ComboBox
        Friend WithEvents bruteforceToggle As System.Windows.Forms.Button
        Friend WithEvents form_head As System.Windows.Forms.MenuStrip
        Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents minimize_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents wincrypttitle As System.Windows.Forms.Label
        Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
    End Class
End Namespace