<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateiEntschluesseln
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DateiEntschluesseln))
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
        Me.SuspendLayout()
        '
        'statuslb
        '
        Me.statuslb.AllowDrop = True
        Me.statuslb.BackColor = System.Drawing.Color.Gray
        Me.statuslb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.statuslb.ForeColor = System.Drawing.Color.Lime
        Me.statuslb.Location = New System.Drawing.Point(9, 96)
        Me.statuslb.Name = "statuslb"
        Me.statuslb.Size = New System.Drawing.Size(405, 20)
        Me.statuslb.TabIndex = 21
        Me.statuslb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pwdlb
        '
        Me.pwdlb.AutoSize = True
        Me.pwdlb.Location = New System.Drawing.Point(5, 76)
        Me.pwdlb.Name = "pwdlb"
        Me.pwdlb.Size = New System.Drawing.Size(53, 13)
        Me.pwdlb.TabIndex = 19
        Me.pwdlb.Text = "Passwort:"
        '
        'pathlb
        '
        Me.pathlb.AutoSize = True
        Me.pathlb.Location = New System.Drawing.Point(6, 47)
        Me.pathlb.Name = "pathlb"
        Me.pathlb.Size = New System.Drawing.Size(32, 13)
        Me.pathlb.TabIndex = 18
        Me.pathlb.Text = "Pfad:"
        '
        'passwordtxt
        '
        Me.passwordtxt.AllowDrop = True
        Me.passwordtxt.Enabled = False
        Me.passwordtxt.Location = New System.Drawing.Point(64, 73)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(241, 20)
        Me.passwordtxt.TabIndex = 17
        Me.passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dencrypt
        '
        Me.dencrypt.BackColor = System.Drawing.Color.Gainsboro
        Me.dencrypt.Enabled = False
        Me.dencrypt.FlatAppearance.BorderSize = 0
        Me.dencrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dencrypt.Location = New System.Drawing.Point(177, 123)
        Me.dencrypt.Name = "dencrypt"
        Me.dencrypt.Size = New System.Drawing.Size(86, 23)
        Me.dencrypt.TabIndex = 16
        Me.dencrypt.Text = "Entschlüsseln"
        Me.dencrypt.UseVisualStyleBackColor = False
        '
        'pathtxt
        '
        Me.pathtxt.AllowDrop = True
        Me.pathtxt.Enabled = False
        Me.pathtxt.Location = New System.Drawing.Point(46, 44)
        Me.pathtxt.Name = "pathtxt"
        Me.pathtxt.Size = New System.Drawing.Size(259, 20)
        Me.pathtxt.TabIndex = 15
        '
        'savefile
        '
        Me.savefile.BackColor = System.Drawing.Color.Gainsboro
        Me.savefile.Enabled = False
        Me.savefile.FlatAppearance.BorderSize = 0
        Me.savefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savefile.Location = New System.Drawing.Point(311, 42)
        Me.savefile.Name = "savefile"
        Me.savefile.Size = New System.Drawing.Size(104, 23)
        Me.savefile.TabIndex = 14
        Me.savefile.Text = "Speichern unter..."
        Me.savefile.UseVisualStyleBackColor = False
        '
        'filelb
        '
        Me.filelb.AutoSize = True
        Me.filelb.Location = New System.Drawing.Point(5, 18)
        Me.filelb.Name = "filelb"
        Me.filelb.Size = New System.Drawing.Size(35, 13)
        Me.filelb.TabIndex = 13
        Me.filelb.Text = "Datei:"
        '
        'filetxt
        '
        Me.filetxt.AllowDrop = True
        Me.filetxt.Location = New System.Drawing.Point(46, 15)
        Me.filetxt.Name = "filetxt"
        Me.filetxt.Size = New System.Drawing.Size(259, 20)
        Me.filetxt.TabIndex = 12
        Me.filetxt.Tag = "Test"
        '
        'openfile
        '
        Me.openfile.BackColor = System.Drawing.Color.Gainsboro
        Me.openfile.FlatAppearance.BorderSize = 0
        Me.openfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.openfile.Location = New System.Drawing.Point(311, 13)
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
        Me.dragdroplb.Location = New System.Drawing.Point(1, 144)
        Me.dragdroplb.Name = "dragdroplb"
        Me.dragdroplb.Size = New System.Drawing.Size(53, 13)
        Me.dragdroplb.TabIndex = 22
        Me.dragdroplb.Text = "Drag&Drop"
        '
        'DateiEntschluesseln
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 159)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "DateiEntschluesseln"
        Me.Text = "Datei entschlüsseln"
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
End Class
