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
        Me.SuspendLayout()
        '
        'fileopenbt
        '
        Me.fileopenbt.BackColor = System.Drawing.Color.Gainsboro
        Me.fileopenbt.FlatAppearance.BorderSize = 0
        Me.fileopenbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fileopenbt.Location = New System.Drawing.Point(315, 24)
        Me.fileopenbt.Name = "fileopenbt"
        Me.fileopenbt.Size = New System.Drawing.Size(104, 23)
        Me.fileopenbt.TabIndex = 0
        Me.fileopenbt.Text = "Öffnen"
        Me.fileopenbt.UseVisualStyleBackColor = False
        '
        'filetxt
        '
        Me.filetxt.AllowDrop = True
        Me.filetxt.Location = New System.Drawing.Point(50, 26)
        Me.filetxt.Name = "filetxt"
        Me.filetxt.Size = New System.Drawing.Size(259, 20)
        Me.filetxt.TabIndex = 1
        Me.filetxt.Tag = "Test"
        '
        'filelb
        '
        Me.filelb.AutoSize = True
        Me.filelb.Location = New System.Drawing.Point(9, 29)
        Me.filelb.Name = "filelb"
        Me.filelb.Size = New System.Drawing.Size(35, 13)
        Me.filelb.TabIndex = 2
        Me.filelb.Text = "Datei:"
        '
        'savefilebt
        '
        Me.savefilebt.BackColor = System.Drawing.Color.Gainsboro
        Me.savefilebt.Enabled = False
        Me.savefilebt.FlatAppearance.BorderSize = 0
        Me.savefilebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savefilebt.Location = New System.Drawing.Point(315, 53)
        Me.savefilebt.Name = "savefilebt"
        Me.savefilebt.Size = New System.Drawing.Size(104, 23)
        Me.savefilebt.TabIndex = 3
        Me.savefilebt.Text = "Speichern unter..."
        Me.savefilebt.UseVisualStyleBackColor = False
        '
        'savepathtxt
        '
        Me.savepathtxt.AllowDrop = True
        Me.savepathtxt.Enabled = False
        Me.savepathtxt.Location = New System.Drawing.Point(50, 55)
        Me.savepathtxt.Name = "savepathtxt"
        Me.savepathtxt.Size = New System.Drawing.Size(259, 20)
        Me.savepathtxt.TabIndex = 4
        '
        'encryptbt
        '
        Me.encryptbt.BackColor = System.Drawing.Color.Gainsboro
        Me.encryptbt.Enabled = False
        Me.encryptbt.FlatAppearance.BorderSize = 0
        Me.encryptbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.encryptbt.Location = New System.Drawing.Point(181, 134)
        Me.encryptbt.Name = "encryptbt"
        Me.encryptbt.Size = New System.Drawing.Size(86, 23)
        Me.encryptbt.TabIndex = 5
        Me.encryptbt.Text = "Verschlüsseln"
        Me.encryptbt.UseVisualStyleBackColor = False
        '
        'passwordtxt
        '
        Me.passwordtxt.AllowDrop = True
        Me.passwordtxt.Enabled = False
        Me.passwordtxt.Location = New System.Drawing.Point(68, 84)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(241, 20)
        Me.passwordtxt.TabIndex = 6
        Me.passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pathlb
        '
        Me.pathlb.AutoSize = True
        Me.pathlb.Location = New System.Drawing.Point(10, 58)
        Me.pathlb.Name = "pathlb"
        Me.pathlb.Size = New System.Drawing.Size(32, 13)
        Me.pathlb.TabIndex = 7
        Me.pathlb.Text = "Pfad:"
        '
        'passwordlb
        '
        Me.passwordlb.AutoSize = True
        Me.passwordlb.Location = New System.Drawing.Point(9, 87)
        Me.passwordlb.Name = "passwordlb"
        Me.passwordlb.Size = New System.Drawing.Size(53, 13)
        Me.passwordlb.TabIndex = 8
        Me.passwordlb.Text = "Passwort:"
        '
        'generatebt
        '
        Me.generatebt.BackColor = System.Drawing.Color.Gainsboro
        Me.generatebt.Enabled = False
        Me.generatebt.FlatAppearance.BorderSize = 0
        Me.generatebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generatebt.Location = New System.Drawing.Point(315, 82)
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
        Me.statuslb.Location = New System.Drawing.Point(13, 107)
        Me.statuslb.Name = "statuslb"
        Me.statuslb.Size = New System.Drawing.Size(405, 20)
        Me.statuslb.TabIndex = 10
        Me.statuslb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dragdroplb
        '
        Me.dragdroplb.AutoSize = True
        Me.dragdroplb.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.dragdroplb.Location = New System.Drawing.Point(1, 153)
        Me.dragdroplb.Name = "dragdroplb"
        Me.dragdroplb.Size = New System.Drawing.Size(53, 13)
        Me.dragdroplb.TabIndex = 11
        Me.dragdroplb.Text = "Drag&Drop"
        '
        'fileencrypt
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 169)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fileencrypt"
        Me.Text = "Datei Verschlüsseln"
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
End Class
