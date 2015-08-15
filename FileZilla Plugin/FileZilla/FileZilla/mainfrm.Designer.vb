<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainfrm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainfrm))
        Me.ok_bt = New System.Windows.Forms.Button()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.password_lb = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.wincrypt_link = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'ok_bt
        '
        Me.ok_bt.Location = New System.Drawing.Point(129, 63)
        Me.ok_bt.Name = "ok_bt"
        Me.ok_bt.Size = New System.Drawing.Size(75, 23)
        Me.ok_bt.TabIndex = 0
        Me.ok_bt.Text = "OK"
        Me.ok_bt.UseVisualStyleBackColor = True
        '
        'password_txt
        '
        Me.password_txt.Location = New System.Drawing.Point(74, 34)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(232, 20)
        Me.password_txt.TabIndex = 1
        Me.password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.password_txt.UseSystemPasswordChar = True
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(13, 13)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(201, 13)
        Me.label.TabIndex = 2
        Me.label.Text = "Geben Sie ihr persönliches Kennwort ein!"
        '
        'password_lb
        '
        Me.password_lb.AutoSize = True
        Me.password_lb.Location = New System.Drawing.Point(13, 37)
        Me.password_lb.Name = "password_lb"
        Me.password_lb.Size = New System.Drawing.Size(55, 13)
        Me.password_lb.TabIndex = 3
        Me.password_lb.Text = "Kennwort:"
        '
        'Timer1
        '
        '
        'wincrypt_link
        '
        Me.wincrypt_link.AutoSize = True
        Me.wincrypt_link.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.wincrypt_link.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.wincrypt_link.Location = New System.Drawing.Point(12, 76)
        Me.wincrypt_link.Name = "wincrypt_link"
        Me.wincrypt_link.Size = New System.Drawing.Size(64, 13)
        Me.wincrypt_link.TabIndex = 4
        Me.wincrypt_link.TabStop = True
        Me.wincrypt_link.Text = "by WinCrypt"
        '
        'mainfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 98)
        Me.Controls.Add(Me.wincrypt_link)
        Me.Controls.Add(Me.password_lb)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.ok_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mainfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileZilla - Kennwort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ok_bt As System.Windows.Forms.Button
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents password_lb As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents wincrypt_link As System.Windows.Forms.LinkLabel

End Class
