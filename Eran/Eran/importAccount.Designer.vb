<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class importAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(importAccount))
        Me.import_bt = New System.Windows.Forms.Button()
        Me.pwd_lb = New System.Windows.Forms.Label()
        Me.pwd_txt = New System.Windows.Forms.TextBox()
        Me.filepath_txt = New System.Windows.Forms.TextBox()
        Me.path_lb = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'import_bt
        '
        Me.import_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.import_bt.FlatAppearance.BorderSize = 0
        Me.import_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.import_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.import_bt.Location = New System.Drawing.Point(309, 64)
        Me.import_bt.Name = "import_bt"
        Me.import_bt.Size = New System.Drawing.Size(95, 23)
        Me.import_bt.TabIndex = 1
        Me.import_bt.Text = "Import"
        Me.import_bt.UseVisualStyleBackColor = False
        '
        'pwd_lb
        '
        Me.pwd_lb.AutoSize = True
        Me.pwd_lb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwd_lb.ForeColor = System.Drawing.Color.White
        Me.pwd_lb.Location = New System.Drawing.Point(12, 14)
        Me.pwd_lb.Name = "pwd_lb"
        Me.pwd_lb.Size = New System.Drawing.Size(59, 13)
        Me.pwd_lb.TabIndex = 2
        Me.pwd_lb.Text = "Password:"
        '
        'pwd_txt
        '
        Me.pwd_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pwd_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pwd_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pwd_txt.Location = New System.Drawing.Point(74, 12)
        Me.pwd_txt.Name = "pwd_txt"
        Me.pwd_txt.Size = New System.Drawing.Size(330, 20)
        Me.pwd_txt.TabIndex = 5
        Me.pwd_txt.UseSystemPasswordChar = True
        '
        'filepath_txt
        '
        Me.filepath_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.filepath_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.filepath_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.filepath_txt.Location = New System.Drawing.Point(74, 38)
        Me.filepath_txt.Name = "filepath_txt"
        Me.filepath_txt.ReadOnly = True
        Me.filepath_txt.Size = New System.Drawing.Size(330, 20)
        Me.filepath_txt.TabIndex = 6
        '
        'path_lb
        '
        Me.path_lb.AutoSize = True
        Me.path_lb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.path_lb.ForeColor = System.Drawing.Color.White
        Me.path_lb.Location = New System.Drawing.Point(38, 40)
        Me.path_lb.Name = "path_lb"
        Me.path_lb.Size = New System.Drawing.Size(33, 13)
        Me.path_lb.TabIndex = 7
        Me.path_lb.Text = "Path:"
        '
        'importAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(416, 100)
        Me.Controls.Add(Me.path_lb)
        Me.Controls.Add(Me.filepath_txt)
        Me.Controls.Add(Me.pwd_txt)
        Me.Controls.Add(Me.pwd_lb)
        Me.Controls.Add(Me.import_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "importAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents import_bt As System.Windows.Forms.Button
    Friend WithEvents pwd_lb As System.Windows.Forms.Label
    Friend WithEvents pwd_txt As System.Windows.Forms.TextBox
    Friend WithEvents filepath_txt As System.Windows.Forms.TextBox
    Friend WithEvents path_lb As System.Windows.Forms.Label
End Class
