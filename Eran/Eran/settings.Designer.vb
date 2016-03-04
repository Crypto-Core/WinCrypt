<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        Me.startNormal_bt = New System.Windows.Forms.Button()
        Me.startmodus_gb = New System.Windows.Forms.GroupBox()
        Me.startwindow_rb = New System.Windows.Forms.RadioButton()
        Me.start_normal = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.startmodus_gb.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'startNormal_bt
        '
        Me.startNormal_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.startNormal_bt.FlatAppearance.BorderSize = 0
        Me.startNormal_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startNormal_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.startNormal_bt.Location = New System.Drawing.Point(75, 249)
        Me.startNormal_bt.Name = "startNormal_bt"
        Me.startNormal_bt.Size = New System.Drawing.Size(74, 23)
        Me.startNormal_bt.TabIndex = 5
        Me.startNormal_bt.Text = "Save"
        Me.startNormal_bt.UseVisualStyleBackColor = False
        '
        'startmodus_gb
        '
        Me.startmodus_gb.Controls.Add(Me.RadioButton3)
        Me.startmodus_gb.Controls.Add(Me.start_normal)
        Me.startmodus_gb.Controls.Add(Me.startwindow_rb)
        Me.startmodus_gb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.startmodus_gb.Location = New System.Drawing.Point(12, 12)
        Me.startmodus_gb.Name = "startmodus_gb"
        Me.startmodus_gb.Size = New System.Drawing.Size(200, 100)
        Me.startmodus_gb.TabIndex = 6
        Me.startmodus_gb.TabStop = False
        Me.startmodus_gb.Text = "Startmodus"
        '
        'startwindow_rb
        '
        Me.startwindow_rb.AutoSize = True
        Me.startwindow_rb.Location = New System.Drawing.Point(18, 20)
        Me.startwindow_rb.Name = "startwindow_rb"
        Me.startwindow_rb.Size = New System.Drawing.Size(113, 17)
        Me.startwindow_rb.TabIndex = 0
        Me.startwindow_rb.TabStop = True
        Me.startwindow_rb.Text = "Show Startwindow"
        Me.startwindow_rb.UseVisualStyleBackColor = True
        '
        'start_normal
        '
        Me.start_normal.AutoSize = True
        Me.start_normal.Location = New System.Drawing.Point(18, 43)
        Me.start_normal.Name = "start_normal"
        Me.start_normal.Size = New System.Drawing.Size(81, 17)
        Me.start_normal.TabIndex = 1
        Me.start_normal.TabStop = True
        Me.start_normal.Text = "Start normal"
        Me.start_normal.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(18, 66)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(138, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Start in Secure Desktop"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 74)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Own Access Node"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Listen on Port:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(66, 20)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "8000"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(9, 46)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(113, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Allow Acces Node"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 45)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Save Connection Access Node"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Saved"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(225, 283)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.startmodus_gb)
        Me.Controls.Add(Me.startNormal_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.startmodus_gb.ResumeLayout(False)
        Me.startmodus_gb.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents startNormal_bt As System.Windows.Forms.Button
    Friend WithEvents startmodus_gb As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents start_normal As System.Windows.Forms.RadioButton
    Friend WithEvents startwindow_rb As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
