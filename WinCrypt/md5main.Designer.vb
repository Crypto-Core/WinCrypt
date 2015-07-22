<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class md5main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(md5main))
        Me.convert_bt = New System.Windows.Forms.Button()
        Me.text_txt = New System.Windows.Forms.TextBox()
        Me.text_lb = New System.Windows.Forms.Label()
        Me.md5_lb = New System.Windows.Forms.Label()
        Me.md5_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'convert_bt
        '
        Me.convert_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.convert_bt.FlatAppearance.BorderSize = 0
        Me.convert_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.convert_bt.Location = New System.Drawing.Point(197, 76)
        Me.convert_bt.Name = "convert_bt"
        Me.convert_bt.Size = New System.Drawing.Size(75, 23)
        Me.convert_bt.TabIndex = 0
        Me.convert_bt.Text = "Konvertieren"
        Me.convert_bt.UseVisualStyleBackColor = False
        '
        'text_txt
        '
        Me.text_txt.Location = New System.Drawing.Point(49, 15)
        Me.text_txt.Name = "text_txt"
        Me.text_txt.Size = New System.Drawing.Size(408, 20)
        Me.text_txt.TabIndex = 1
        '
        'text_lb
        '
        Me.text_lb.AutoSize = True
        Me.text_lb.Location = New System.Drawing.Point(12, 18)
        Me.text_lb.Name = "text_lb"
        Me.text_lb.Size = New System.Drawing.Size(31, 13)
        Me.text_lb.TabIndex = 2
        Me.text_lb.Text = "Text:"
        '
        'md5_lb
        '
        Me.md5_lb.AutoSize = True
        Me.md5_lb.Location = New System.Drawing.Point(10, 53)
        Me.md5_lb.Name = "md5_lb"
        Me.md5_lb.Size = New System.Drawing.Size(33, 13)
        Me.md5_lb.TabIndex = 3
        Me.md5_lb.Text = "MD5:"
        '
        'md5_txt
        '
        Me.md5_txt.Location = New System.Drawing.Point(49, 50)
        Me.md5_txt.Name = "md5_txt"
        Me.md5_txt.ReadOnly = True
        Me.md5_txt.Size = New System.Drawing.Size(408, 20)
        Me.md5_txt.TabIndex = 4
        Me.md5_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'md5main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 106)
        Me.Controls.Add(Me.md5_txt)
        Me.Controls.Add(Me.md5_lb)
        Me.Controls.Add(Me.text_lb)
        Me.Controls.Add(Me.text_txt)
        Me.Controls.Add(Me.convert_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "md5main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MD5 Konverter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents convert_bt As System.Windows.Forms.Button
    Friend WithEvents text_txt As System.Windows.Forms.TextBox
    Friend WithEvents text_lb As System.Windows.Forms.Label
    Friend WithEvents md5_lb As System.Windows.Forms.Label
    Friend WithEvents md5_txt As System.Windows.Forms.TextBox
End Class
