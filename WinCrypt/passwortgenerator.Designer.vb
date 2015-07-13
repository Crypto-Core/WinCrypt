<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class passwortgenerator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(passwortgenerator))
        Me.generatebt = New System.Windows.Forms.Button()
        Me.generatetxt = New System.Windows.Forms.TextBox()
        Me.length = New System.Windows.Forms.TextBox()
        Me.uppercasecb = New System.Windows.Forms.CheckBox()
        Me.lowercasecb = New System.Windows.Forms.CheckBox()
        Me.numberscb = New System.Windows.Forms.CheckBox()
        Me.lengthlb = New System.Windows.Forms.Label()
        Me.copybt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'generatebt
        '
        Me.generatebt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.generatebt.BackColor = System.Drawing.Color.Gainsboro
        Me.generatebt.FlatAppearance.BorderSize = 0
        Me.generatebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generatebt.Location = New System.Drawing.Point(443, 193)
        Me.generatebt.Name = "generatebt"
        Me.generatebt.Size = New System.Drawing.Size(75, 23)
        Me.generatebt.TabIndex = 0
        Me.generatebt.Text = "Generieren"
        Me.generatebt.UseVisualStyleBackColor = False
        '
        'generatetxt
        '
        Me.generatetxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.generatetxt.Location = New System.Drawing.Point(12, 12)
        Me.generatetxt.Multiline = True
        Me.generatetxt.Name = "generatetxt"
        Me.generatetxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.generatetxt.Size = New System.Drawing.Size(506, 175)
        Me.generatetxt.TabIndex = 1
        '
        'length
        '
        Me.length.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.length.Location = New System.Drawing.Point(195, 237)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(75, 20)
        Me.length.TabIndex = 2
        Me.length.Text = "32"
        '
        'uppercasecb
        '
        Me.uppercasecb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.uppercasecb.AutoSize = True
        Me.uppercasecb.Checked = True
        Me.uppercasecb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uppercasecb.Location = New System.Drawing.Point(12, 193)
        Me.uppercasecb.Name = "uppercasecb"
        Me.uppercasecb.Size = New System.Drawing.Size(105, 17)
        Me.uppercasecb.TabIndex = 3
        Me.uppercasecb.Text = "Großbuchstaben"
        Me.uppercasecb.UseVisualStyleBackColor = True
        '
        'lowercasecb
        '
        Me.lowercasecb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lowercasecb.AutoSize = True
        Me.lowercasecb.Checked = True
        Me.lowercasecb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.lowercasecb.Location = New System.Drawing.Point(12, 216)
        Me.lowercasecb.Name = "lowercasecb"
        Me.lowercasecb.Size = New System.Drawing.Size(105, 17)
        Me.lowercasecb.TabIndex = 4
        Me.lowercasecb.Text = "Kleinbuchstaben"
        Me.lowercasecb.UseVisualStyleBackColor = True
        '
        'numberscb
        '
        Me.numberscb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.numberscb.AutoSize = True
        Me.numberscb.Checked = True
        Me.numberscb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.numberscb.Location = New System.Drawing.Point(12, 239)
        Me.numberscb.Name = "numberscb"
        Me.numberscb.Size = New System.Drawing.Size(59, 17)
        Me.numberscb.TabIndex = 5
        Me.numberscb.Text = "Zahlen"
        Me.numberscb.UseVisualStyleBackColor = True
        '
        'lengthlb
        '
        Me.lengthlb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lengthlb.AutoSize = True
        Me.lengthlb.Location = New System.Drawing.Point(152, 240)
        Me.lengthlb.Name = "lengthlb"
        Me.lengthlb.Size = New System.Drawing.Size(37, 13)
        Me.lengthlb.TabIndex = 6
        Me.lengthlb.Text = "Länge"
        '
        'copybt
        '
        Me.copybt.BackColor = System.Drawing.Color.Gainsboro
        Me.copybt.Enabled = False
        Me.copybt.FlatAppearance.BorderSize = 0
        Me.copybt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copybt.Location = New System.Drawing.Point(362, 193)
        Me.copybt.Name = "copybt"
        Me.copybt.Size = New System.Drawing.Size(75, 23)
        Me.copybt.TabIndex = 7
        Me.copybt.Text = "Kopieren"
        Me.copybt.UseVisualStyleBackColor = False
        '
        'passwortgenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 268)
        Me.Controls.Add(Me.copybt)
        Me.Controls.Add(Me.lengthlb)
        Me.Controls.Add(Me.numberscb)
        Me.Controls.Add(Me.lowercasecb)
        Me.Controls.Add(Me.uppercasecb)
        Me.Controls.Add(Me.length)
        Me.Controls.Add(Me.generatetxt)
        Me.Controls.Add(Me.generatebt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "passwortgenerator"
        Me.Text = "WinCrypt - Passwortgenerator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents generatebt As System.Windows.Forms.Button
    Friend WithEvents generatetxt As System.Windows.Forms.TextBox
    Friend WithEvents length As System.Windows.Forms.TextBox
    Friend WithEvents uppercasecb As System.Windows.Forms.CheckBox
    Friend WithEvents lowercasecb As System.Windows.Forms.CheckBox
    Friend WithEvents numberscb As System.Windows.Forms.CheckBox
    Friend WithEvents lengthlb As System.Windows.Forms.Label
    Friend WithEvents copybt As System.Windows.Forms.Button
End Class
