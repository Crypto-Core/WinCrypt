<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hash_bruteforce
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hash_bruteforce))
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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bruteforcesearchedHash
        '
        Me.bruteforcesearchedHash.Location = New System.Drawing.Point(43, 6)
        Me.bruteforcesearchedHash.Name = "bruteforcesearchedHash"
        Me.bruteforcesearchedHash.Size = New System.Drawing.Size(252, 20)
        Me.bruteforcesearchedHash.TabIndex = 1
        Me.bruteforcesearchedHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'md5_lb
        '
        Me.md5_lb.AutoSize = True
        Me.md5_lb.Location = New System.Drawing.Point(6, 9)
        Me.md5_lb.Name = "md5_lb"
        Me.md5_lb.Size = New System.Drawing.Size(35, 13)
        Me.md5_lb.TabIndex = 2
        Me.md5_lb.Text = "Hash:"
        '
        'passwordlist_lb
        '
        Me.passwordlist_lb.AutoSize = True
        Me.passwordlist_lb.Location = New System.Drawing.Point(6, 31)
        Me.passwordlist_lb.Name = "passwordlist_lb"
        Me.passwordlist_lb.Size = New System.Drawing.Size(71, 13)
        Me.passwordlist_lb.TabIndex = 3
        Me.passwordlist_lb.Text = "Passwortliste:"
        '
        'fileWordlist
        '
        Me.fileWordlist.Location = New System.Drawing.Point(10, 47)
        Me.fileWordlist.Name = "fileWordlist"
        Me.fileWordlist.Size = New System.Drawing.Size(322, 20)
        Me.fileWordlist.TabIndex = 4
        '
        'openWordlist
        '
        Me.openWordlist.BackColor = System.Drawing.Color.Gainsboro
        Me.openWordlist.FlatAppearance.BorderSize = 0
        Me.openWordlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.openWordlist.Location = New System.Drawing.Point(338, 45)
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
        Me.Panel1.Location = New System.Drawing.Point(10, 73)
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
        Me.bruteforceChecked.Location = New System.Drawing.Point(10, 250)
        Me.bruteforceChecked.Name = "bruteforceChecked"
        Me.bruteforceChecked.Size = New System.Drawing.Size(400, 23)
        Me.bruteforceChecked.TabIndex = 12
        '
        'showProgress
        '
        Me.showProgress.AutoSize = True
        Me.showProgress.Location = New System.Drawing.Point(9, 222)
        Me.showProgress.Name = "showProgress"
        Me.showProgress.Size = New System.Drawing.Size(117, 17)
        Me.showProgress.TabIndex = 13
        Me.showProgress.Text = "Zeige Fortschritt an"
        Me.showProgress.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Art:"
        '
        'bruteforceHashtype
        '
        Me.bruteforceHashtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bruteforceHashtype.FormattingEnabled = True
        Me.bruteforceHashtype.Items.AddRange(New Object() {"MD5", "SHA1", "SHA256", "SHA384", "SHA512", "RIPEMD160"})
        Me.bruteforceHashtype.Location = New System.Drawing.Point(323, 6)
        Me.bruteforceHashtype.Name = "bruteforceHashtype"
        Me.bruteforceHashtype.Size = New System.Drawing.Size(90, 21)
        Me.bruteforceHashtype.TabIndex = 14
        '
        'bruteforceToggle
        '
        Me.bruteforceToggle.BackColor = System.Drawing.Color.Gainsboro
        Me.bruteforceToggle.FlatAppearance.BorderSize = 0
        Me.bruteforceToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bruteforceToggle.Location = New System.Drawing.Point(159, 218)
        Me.bruteforceToggle.Name = "bruteforceToggle"
        Me.bruteforceToggle.Size = New System.Drawing.Size(101, 23)
        Me.bruteforceToggle.TabIndex = 16
        Me.bruteforceToggle.Text = "Brute Force"
        Me.bruteforceToggle.UseVisualStyleBackColor = False
        '
        'Hash_bruteforce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(421, 247)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Hash_bruteforce"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hash Brute Force"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
End Class
