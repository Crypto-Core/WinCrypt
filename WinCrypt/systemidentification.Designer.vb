<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class systemidentification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(systemidentification))
        Me.on_rb = New System.Windows.Forms.RadioButton()
        Me.off_rb = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ok_bt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'on_rb
        '
        Me.on_rb.AutoSize = True
        Me.on_rb.BackColor = System.Drawing.SystemColors.ControlDark
        Me.on_rb.Location = New System.Drawing.Point(262, 112)
        Me.on_rb.Name = "on_rb"
        Me.on_rb.Size = New System.Drawing.Size(80, 17)
        Me.on_rb.TabIndex = 0
        Me.on_rb.Text = "Einschalten"
        Me.on_rb.UseVisualStyleBackColor = False
        '
        'off_rb
        '
        Me.off_rb.AutoSize = True
        Me.off_rb.BackColor = System.Drawing.SystemColors.ControlDark
        Me.off_rb.Checked = True
        Me.off_rb.Location = New System.Drawing.Point(145, 112)
        Me.off_rb.Name = "off_rb"
        Me.off_rb.Size = New System.Drawing.Size(83, 17)
        Me.off_rb.TabIndex = 1
        Me.off_rb.TabStop = True
        Me.off_rb.Text = "Ausschalten"
        Me.off_rb.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(18, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 40)
        Me.Label1.Size = New System.Drawing.Size(432, 131)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'ok_bt
        '
        Me.ok_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.ok_bt.FlatAppearance.BorderSize = 0
        Me.ok_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ok_bt.Location = New System.Drawing.Point(197, 149)
        Me.ok_bt.Name = "ok_bt"
        Me.ok_bt.Size = New System.Drawing.Size(75, 23)
        Me.ok_bt.TabIndex = 3
        Me.ok_bt.Text = "OK"
        Me.ok_bt.UseVisualStyleBackColor = False
        '
        'systemidentification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 183)
        Me.Controls.Add(Me.ok_bt)
        Me.Controls.Add(Me.off_rb)
        Me.Controls.Add(Me.on_rb)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "systemidentification"
        Me.Text = "Systemidentifikation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents on_rb As System.Windows.Forms.RadioButton
    Friend WithEvents off_rb As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ok_bt As System.Windows.Forms.Button
End Class
