<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class md5bruteforce
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(md5bruteforce))
        Me.startbf_bt = New System.Windows.Forms.Button()
        Me.md5_txt = New System.Windows.Forms.TextBox()
        Me.md5_lb = New System.Windows.Forms.Label()
        Me.passwordlist_lb = New System.Windows.Forms.Label()
        Me.file_txt = New System.Windows.Forms.TextBox()
        Me.open_bt = New System.Windows.Forms.Button()
        Me.status_lb = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.bgw = New System.ComponentModel.BackgroundWorker()
        Me.statustimer = New System.Windows.Forms.Timer(Me.components)
        Me.password_lb = New System.Windows.Forms.Label()
        Me.line_lb = New System.Windows.Forms.Label()
        Me.md5lb = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.testedpw_lb = New System.Windows.Forms.Label()
        Me.stopbf_bt = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.progresscheck = New System.Windows.Forms.CheckBox()
        Me.progresstimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'startbf_bt
        '
        Me.startbf_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.startbf_bt.FlatAppearance.BorderSize = 0
        Me.startbf_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startbf_bt.Location = New System.Drawing.Point(165, 253)
        Me.startbf_bt.Name = "startbf_bt"
        Me.startbf_bt.Size = New System.Drawing.Size(101, 23)
        Me.startbf_bt.TabIndex = 0
        Me.startbf_bt.Text = "Start Burte-force"
        Me.startbf_bt.UseVisualStyleBackColor = False
        '
        'md5_txt
        '
        Me.md5_txt.Location = New System.Drawing.Point(15, 32)
        Me.md5_txt.Name = "md5_txt"
        Me.md5_txt.Size = New System.Drawing.Size(404, 20)
        Me.md5_txt.TabIndex = 1
        Me.md5_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'md5_lb
        '
        Me.md5_lb.AutoSize = True
        Me.md5_lb.Location = New System.Drawing.Point(13, 16)
        Me.md5_lb.Name = "md5_lb"
        Me.md5_lb.Size = New System.Drawing.Size(33, 13)
        Me.md5_lb.TabIndex = 2
        Me.md5_lb.Text = "MD5:"
        '
        'passwordlist_lb
        '
        Me.passwordlist_lb.AutoSize = True
        Me.passwordlist_lb.Location = New System.Drawing.Point(12, 66)
        Me.passwordlist_lb.Name = "passwordlist_lb"
        Me.passwordlist_lb.Size = New System.Drawing.Size(71, 13)
        Me.passwordlist_lb.TabIndex = 3
        Me.passwordlist_lb.Text = "Passwortliste:"
        '
        'file_txt
        '
        Me.file_txt.Location = New System.Drawing.Point(16, 82)
        Me.file_txt.Name = "file_txt"
        Me.file_txt.Size = New System.Drawing.Size(322, 20)
        Me.file_txt.TabIndex = 4
        '
        'open_bt
        '
        Me.open_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.open_bt.FlatAppearance.BorderSize = 0
        Me.open_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.open_bt.Location = New System.Drawing.Point(344, 80)
        Me.open_bt.Name = "open_bt"
        Me.open_bt.Size = New System.Drawing.Size(75, 23)
        Me.open_bt.TabIndex = 5
        Me.open_bt.Text = "Öffnen"
        Me.open_bt.UseVisualStyleBackColor = False
        '
        'status_lb
        '
        Me.status_lb.AutoSize = True
        Me.status_lb.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.status_lb.Location = New System.Drawing.Point(30, 9)
        Me.status_lb.Name = "status_lb"
        Me.status_lb.Size = New System.Drawing.Size(64, 16)
        Me.status_lb.TabIndex = 6
        Me.status_lb.Text = "Status:"
        Me.status_lb.Visible = False
        '
        'bgw
        '
        Me.bgw.WorkerReportsProgress = True
        Me.bgw.WorkerSupportsCancellation = True
        '
        'statustimer
        '
        '
        'password_lb
        '
        Me.password_lb.AutoSize = True
        Me.password_lb.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_lb.ForeColor = System.Drawing.Color.Lime
        Me.password_lb.Location = New System.Drawing.Point(14, 57)
        Me.password_lb.Name = "password_lb"
        Me.password_lb.Size = New System.Drawing.Size(80, 16)
        Me.password_lb.TabIndex = 7
        Me.password_lb.Text = "Passwort:"
        Me.password_lb.Visible = False
        '
        'line_lb
        '
        Me.line_lb.AutoSize = True
        Me.line_lb.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.line_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.line_lb.Location = New System.Drawing.Point(46, 76)
        Me.line_lb.Name = "line_lb"
        Me.line_lb.Size = New System.Drawing.Size(48, 16)
        Me.line_lb.TabIndex = 8
        Me.line_lb.Text = "Line:"
        Me.line_lb.Visible = False
        '
        'md5lb
        '
        Me.md5lb.AutoSize = True
        Me.md5lb.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.md5lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.md5lb.Location = New System.Drawing.Point(54, 34)
        Me.md5lb.Name = "md5lb"
        Me.md5lb.Size = New System.Drawing.Size(40, 16)
        Me.md5lb.TabIndex = 9
        Me.md5lb.Text = "MD5:"
        Me.md5lb.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.testedpw_lb)
        Me.Panel1.Controls.Add(Me.password_lb)
        Me.Panel1.Controls.Add(Me.md5lb)
        Me.Panel1.Controls.Add(Me.line_lb)
        Me.Panel1.Controls.Add(Me.status_lb)
        Me.Panel1.Location = New System.Drawing.Point(16, 108)
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
        'testedpw_lb
        '
        Me.testedpw_lb.AutoSize = True
        Me.testedpw_lb.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.testedpw_lb.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.testedpw_lb.ForeColor = System.Drawing.Color.Red
        Me.testedpw_lb.Location = New System.Drawing.Point(14, 115)
        Me.testedpw_lb.Name = "testedpw_lb"
        Me.testedpw_lb.Size = New System.Drawing.Size(136, 16)
        Me.testedpw_lb.TabIndex = 10
        Me.testedpw_lb.Text = "tested password:"
        '
        'stopbf_bt
        '
        Me.stopbf_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.stopbf_bt.FlatAppearance.BorderSize = 0
        Me.stopbf_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stopbf_bt.Location = New System.Drawing.Point(165, 253)
        Me.stopbf_bt.Name = "stopbf_bt"
        Me.stopbf_bt.Size = New System.Drawing.Size(101, 23)
        Me.stopbf_bt.TabIndex = 11
        Me.stopbf_bt.Text = "Stop Brute-force"
        Me.stopbf_bt.UseVisualStyleBackColor = False
        Me.stopbf_bt.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 289)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(400, 23)
        Me.ProgressBar1.TabIndex = 12
        '
        'progresscheck
        '
        Me.progresscheck.AutoSize = True
        Me.progresscheck.Location = New System.Drawing.Point(16, 259)
        Me.progresscheck.Name = "progresscheck"
        Me.progresscheck.Size = New System.Drawing.Size(117, 17)
        Me.progresscheck.TabIndex = 13
        Me.progresscheck.Text = "Zeige Fortschritt an"
        Me.progresscheck.UseVisualStyleBackColor = True
        '
        'progresstimer
        '
        Me.progresstimer.Interval = 1
        '
        'md5bruteforce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(431, 283)
        Me.Controls.Add(Me.progresscheck)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.stopbf_bt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.open_bt)
        Me.Controls.Add(Me.file_txt)
        Me.Controls.Add(Me.passwordlist_lb)
        Me.Controls.Add(Me.md5_lb)
        Me.Controls.Add(Me.md5_txt)
        Me.Controls.Add(Me.startbf_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "md5bruteforce"
        Me.Text = "MD5 Brute-force"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents startbf_bt As System.Windows.Forms.Button
    Friend WithEvents md5_txt As System.Windows.Forms.TextBox
    Friend WithEvents md5_lb As System.Windows.Forms.Label
    Friend WithEvents passwordlist_lb As System.Windows.Forms.Label
    Friend WithEvents file_txt As System.Windows.Forms.TextBox
    Friend WithEvents open_bt As System.Windows.Forms.Button
    Friend WithEvents status_lb As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bgw As System.ComponentModel.BackgroundWorker
    Friend WithEvents statustimer As System.Windows.Forms.Timer
    Friend WithEvents password_lb As System.Windows.Forms.Label
    Friend WithEvents line_lb As System.Windows.Forms.Label
    Friend WithEvents md5lb As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents stopbf_bt As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents testedpw_lb As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents progresscheck As System.Windows.Forms.CheckBox
    Friend WithEvents progresstimer As System.Windows.Forms.Timer
End Class
