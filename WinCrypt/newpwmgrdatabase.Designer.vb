<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newpwmgrdatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newpwmgrdatabase))
        Me.createdb_bt = New System.Windows.Forms.Button()
        Me.password_lb = New System.Windows.Forms.Label()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'createdb_bt
        '
        Me.createdb_bt.Location = New System.Drawing.Point(209, 49)
        Me.createdb_bt.Name = "createdb_bt"
        Me.createdb_bt.Size = New System.Drawing.Size(128, 23)
        Me.createdb_bt.TabIndex = 0
        Me.createdb_bt.Text = "Datenbank anlegen"
        Me.createdb_bt.UseVisualStyleBackColor = True
        '
        'password_lb
        '
        Me.password_lb.AutoSize = True
        Me.password_lb.Location = New System.Drawing.Point(12, 26)
        Me.password_lb.Name = "password_lb"
        Me.password_lb.Size = New System.Drawing.Size(53, 13)
        Me.password_lb.TabIndex = 1
        Me.password_lb.Text = "Passwort:"
        '
        'password_txt
        '
        Me.password_txt.Location = New System.Drawing.Point(71, 23)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(266, 20)
        Me.password_txt.TabIndex = 2
        Me.password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.password_txt.UseSystemPasswordChar = True
        '
        'newpwmgrdatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 87)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.password_lb)
        Me.Controls.Add(Me.createdb_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "newpwmgrdatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datenbank anlegen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents createdb_bt As System.Windows.Forms.Button
    Friend WithEvents password_lb As System.Windows.Forms.Label
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
End Class
