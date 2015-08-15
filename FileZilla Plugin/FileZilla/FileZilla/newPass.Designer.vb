<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newPass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newPass))
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.password_lb = New System.Windows.Forms.Label()
        Me.ok_bt = New System.Windows.Forms.Button()
        Me.label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'password_txt
        '
        Me.password_txt.Location = New System.Drawing.Point(73, 40)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(236, 20)
        Me.password_txt.TabIndex = 0
        Me.password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.password_txt.UseSystemPasswordChar = True
        '
        'password_lb
        '
        Me.password_lb.AutoSize = True
        Me.password_lb.Location = New System.Drawing.Point(12, 43)
        Me.password_lb.Name = "password_lb"
        Me.password_lb.Size = New System.Drawing.Size(55, 13)
        Me.password_lb.TabIndex = 1
        Me.password_lb.Text = "Kennwort:"
        '
        'ok_bt
        '
        Me.ok_bt.Location = New System.Drawing.Point(234, 66)
        Me.ok_bt.Name = "ok_bt"
        Me.ok_bt.Size = New System.Drawing.Size(75, 23)
        Me.ok_bt.TabIndex = 2
        Me.ok_bt.Text = "OK"
        Me.ok_bt.UseVisualStyleBackColor = True
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(15, 13)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(224, 13)
        Me.label.TabIndex = 3
        Me.label.Text = "Bitte geben Sie ein neues Hauptkennwort ein."
        '
        'newPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 98)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.ok_bt)
        Me.Controls.Add(Me.password_lb)
        Me.Controls.Add(Me.password_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "newPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileZilla - Neues Kennwort"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
    Friend WithEvents password_lb As System.Windows.Forms.Label
    Friend WithEvents ok_bt As System.Windows.Forms.Button
    Friend WithEvents label As System.Windows.Forms.Label
End Class
