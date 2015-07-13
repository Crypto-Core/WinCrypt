<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class masterkey
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
        Me.key_txt = New System.Windows.Forms.TextBox()
        Me.key_lb = New System.Windows.Forms.Label()
        Me.ok_bt = New System.Windows.Forms.Button()
        Me.abort_bt = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'key_txt
        '
        Me.key_txt.Location = New System.Drawing.Point(13, 91)
        Me.key_txt.Name = "key_txt"
        Me.key_txt.Size = New System.Drawing.Size(266, 20)
        Me.key_txt.TabIndex = 0
        Me.key_txt.UseSystemPasswordChar = True
        '
        'key_lb
        '
        Me.key_lb.AutoSize = True
        Me.key_lb.Location = New System.Drawing.Point(10, 75)
        Me.key_lb.Name = "key_lb"
        Me.key_lb.Size = New System.Drawing.Size(59, 13)
        Me.key_lb.TabIndex = 1
        Me.key_lb.Text = "Masterkey:"
        '
        'ok_bt
        '
        Me.ok_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.ok_bt.FlatAppearance.BorderSize = 0
        Me.ok_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ok_bt.Location = New System.Drawing.Point(13, 117)
        Me.ok_bt.Name = "ok_bt"
        Me.ok_bt.Size = New System.Drawing.Size(75, 23)
        Me.ok_bt.TabIndex = 2
        Me.ok_bt.Text = "OK"
        Me.ok_bt.UseVisualStyleBackColor = False
        '
        'abort_bt
        '
        Me.abort_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.abort_bt.FlatAppearance.BorderSize = 0
        Me.abort_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abort_bt.Location = New System.Drawing.Point(204, 117)
        Me.abort_bt.Name = "abort_bt"
        Me.abort_bt.Size = New System.Drawing.Size(75, 23)
        Me.abort_bt.TabIndex = 3
        Me.abort_bt.Text = "Abbrechen"
        Me.abort_bt.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_WinCrypt.My.Resources.Resources.key2
        Me.PictureBox1.Location = New System.Drawing.Point(87, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'masterkey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 151)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.abort_bt)
        Me.Controls.Add(Me.ok_bt)
        Me.Controls.Add(Me.key_lb)
        Me.Controls.Add(Me.key_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "masterkey"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WinCrypt - Masterkey"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents key_txt As System.Windows.Forms.TextBox
    Friend WithEvents key_lb As System.Windows.Forms.Label
    Friend WithEvents ok_bt As System.Windows.Forms.Button
    Friend WithEvents abort_bt As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
