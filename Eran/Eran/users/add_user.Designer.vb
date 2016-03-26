<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_user
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_user))
        Me.add_bt = New System.Windows.Forms.Button()
        Me.eran_adress_lb = New System.Windows.Forms.Label()
        Me.eran_adress_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'add_bt
        '
        Me.add_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.add_bt.FlatAppearance.BorderSize = 0
        Me.add_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_bt.Location = New System.Drawing.Point(277, 39)
        Me.add_bt.Name = "add_bt"
        Me.add_bt.Size = New System.Drawing.Size(75, 23)
        Me.add_bt.TabIndex = 0
        Me.add_bt.Text = "Add"
        Me.add_bt.UseVisualStyleBackColor = False
        '
        'eran_adress_lb
        '
        Me.eran_adress_lb.AutoSize = True
        Me.eran_adress_lb.Location = New System.Drawing.Point(10, 15)
        Me.eran_adress_lb.Name = "eran_adress_lb"
        Me.eran_adress_lb.Size = New System.Drawing.Size(72, 13)
        Me.eran_adress_lb.TabIndex = 1
        Me.eran_adress_lb.Text = "Eran address:"
        '
        'eran_adress_txt
        '
        Me.eran_adress_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.eran_adress_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.eran_adress_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.eran_adress_txt.Location = New System.Drawing.Point(84, 13)
        Me.eran_adress_txt.Name = "eran_adress_txt"
        Me.eran_adress_txt.Size = New System.Drawing.Size(268, 20)
        Me.eran_adress_txt.TabIndex = 4
        '
        'add_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(364, 68)
        Me.Controls.Add(Me.eran_adress_txt)
        Me.Controls.Add(Me.eran_adress_lb)
        Me.Controls.Add(Me.add_bt)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "add_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add user"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents add_bt As System.Windows.Forms.Button
    Friend WithEvents eran_adress_lb As System.Windows.Forms.Label
    Friend WithEvents eran_adress_txt As System.Windows.Forms.TextBox
End Class
