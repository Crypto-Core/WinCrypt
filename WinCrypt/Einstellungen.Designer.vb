<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Einstellungen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Einstellungen))
        Me.registfiletypegb = New System.Windows.Forms.GroupBox()
        Me.registfiletype = New System.Windows.Forms.Button()
        Me.okbt = New System.Windows.Forms.Button()
        Me.languagegb = New System.Windows.Forms.GroupBox()
        Me.languagecb = New System.Windows.Forms.ComboBox()
        Me.autostartgb = New System.Windows.Forms.GroupBox()
        Me.startnormalwincrypt = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.startminwincryptrb = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.startwincb = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.show_bt = New System.Windows.Forms.Button()
        Me.key_txt = New System.Windows.Forms.TextBox()
        Me.key_lb = New System.Windows.Forms.Label()
        Me.key_cb = New System.Windows.Forms.CheckBox()
        Me.registfiletypegb.SuspendLayout()
        Me.languagegb.SuspendLayout()
        Me.autostartgb.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'registfiletypegb
        '
        Me.registfiletypegb.Controls.Add(Me.registfiletype)
        Me.registfiletypegb.Location = New System.Drawing.Point(21, 12)
        Me.registfiletypegb.Name = "registfiletypegb"
        Me.registfiletypegb.Size = New System.Drawing.Size(200, 64)
        Me.registfiletypegb.TabIndex = 0
        Me.registfiletypegb.TabStop = False
        Me.registfiletypegb.Text = "WinCrypt Dateitypen registrieren"
        '
        'registfiletype
        '
        Me.registfiletype.Location = New System.Drawing.Point(61, 25)
        Me.registfiletype.Name = "registfiletype"
        Me.registfiletype.Size = New System.Drawing.Size(75, 23)
        Me.registfiletype.TabIndex = 0
        Me.registfiletype.Text = "Registrieren"
        Me.registfiletype.UseVisualStyleBackColor = True
        '
        'okbt
        '
        Me.okbt.Location = New System.Drawing.Point(21, 213)
        Me.okbt.Name = "okbt"
        Me.okbt.Size = New System.Drawing.Size(75, 23)
        Me.okbt.TabIndex = 1
        Me.okbt.Text = "Ok"
        Me.okbt.UseVisualStyleBackColor = True
        '
        'languagegb
        '
        Me.languagegb.Controls.Add(Me.languagecb)
        Me.languagegb.Location = New System.Drawing.Point(21, 82)
        Me.languagegb.Name = "languagegb"
        Me.languagegb.Size = New System.Drawing.Size(200, 45)
        Me.languagegb.TabIndex = 2
        Me.languagegb.TabStop = False
        Me.languagegb.Text = "Sprache"
        '
        'languagecb
        '
        Me.languagecb.Items.AddRange(New Object() {"Deutsch", "English"})
        Me.languagecb.Location = New System.Drawing.Point(47, 18)
        Me.languagecb.Name = "languagecb"
        Me.languagecb.Size = New System.Drawing.Size(121, 21)
        Me.languagecb.TabIndex = 0
        Me.languagecb.Text = "Deutsch"
        '
        'autostartgb
        '
        Me.autostartgb.Controls.Add(Me.startnormalwincrypt)
        Me.autostartgb.Controls.Add(Me.Label3)
        Me.autostartgb.Controls.Add(Me.startminwincryptrb)
        Me.autostartgb.Controls.Add(Me.Label2)
        Me.autostartgb.Controls.Add(Me.startwincb)
        Me.autostartgb.Controls.Add(Me.Label1)
        Me.autostartgb.Location = New System.Drawing.Point(237, 12)
        Me.autostartgb.Name = "autostartgb"
        Me.autostartgb.Size = New System.Drawing.Size(200, 116)
        Me.autostartgb.TabIndex = 3
        Me.autostartgb.TabStop = False
        Me.autostartgb.Text = "Autostart"
        '
        'startnormalwincrypt
        '
        Me.startnormalwincrypt.AutoSize = True
        Me.startnormalwincrypt.Location = New System.Drawing.Point(53, 91)
        Me.startnormalwincrypt.Name = "startnormalwincrypt"
        Me.startnormalwincrypt.Size = New System.Drawing.Size(137, 17)
        Me.startnormalwincrypt.TabIndex = 2
        Me.startnormalwincrypt.Text = "WinCrypt normal starten"
        Me.startnormalwincrypt.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "────"
        '
        'startminwincryptrb
        '
        Me.startminwincryptrb.AutoSize = True
        Me.startminwincryptrb.Checked = True
        Me.startminwincryptrb.Location = New System.Drawing.Point(53, 63)
        Me.startminwincryptrb.Name = "startminwincryptrb"
        Me.startminwincryptrb.Size = New System.Drawing.Size(146, 17)
        Me.startminwincryptrb.TabIndex = 4
        Me.startminwincryptrb.TabStop = True
        Me.startminwincryptrb.Text = "WinCrypt minimiert starten"
        Me.startminwincryptrb.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "────"
        '
        'startwincb
        '
        Me.startwincb.AutoSize = True
        Me.startwincb.Location = New System.Drawing.Point(15, 31)
        Me.startwincb.Name = "startwincb"
        Me.startwincb.Size = New System.Drawing.Size(167, 17)
        Me.startwincb.TabIndex = 0
        Me.startwincb.Text = "WinCrypt mit Windows starten"
        Me.startwincb.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 60)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "│" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "│" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "│" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "│"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.show_bt)
        Me.GroupBox1.Controls.Add(Me.key_txt)
        Me.GroupBox1.Controls.Add(Me.key_lb)
        Me.GroupBox1.Controls.Add(Me.key_cb)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 74)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masterkey"
        '
        'show_bt
        '
        Me.show_bt.Enabled = False
        Me.show_bt.Image = Global.Project_WinCrypt.My.Resources.Resources.eye
        Me.show_bt.Location = New System.Drawing.Point(378, 17)
        Me.show_bt.Name = "show_bt"
        Me.show_bt.Size = New System.Drawing.Size(31, 23)
        Me.show_bt.TabIndex = 3
        Me.show_bt.UseVisualStyleBackColor = True
        '
        'key_txt
        '
        Me.key_txt.Enabled = False
        Me.key_txt.Location = New System.Drawing.Point(40, 19)
        Me.key_txt.Name = "key_txt"
        Me.key_txt.Size = New System.Drawing.Size(332, 20)
        Me.key_txt.TabIndex = 2
        Me.key_txt.UseSystemPasswordChar = True
        '
        'key_lb
        '
        Me.key_lb.AutoSize = True
        Me.key_lb.Enabled = False
        Me.key_lb.Location = New System.Drawing.Point(6, 22)
        Me.key_lb.Name = "key_lb"
        Me.key_lb.Size = New System.Drawing.Size(28, 13)
        Me.key_lb.TabIndex = 1
        Me.key_lb.Text = "Key:"
        '
        'key_cb
        '
        Me.key_cb.AutoSize = True
        Me.key_cb.Location = New System.Drawing.Point(328, 45)
        Me.key_cb.Name = "key_cb"
        Me.key_cb.Size = New System.Drawing.Size(81, 17)
        Me.key_cb.TabIndex = 0
        Me.key_cb.Text = "Einschalten"
        Me.key_cb.UseVisualStyleBackColor = True
        '
        'Einstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 242)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.autostartgb)
        Me.Controls.Add(Me.languagegb)
        Me.Controls.Add(Me.okbt)
        Me.Controls.Add(Me.registfiletypegb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Einstellungen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einstellungen"
        Me.registfiletypegb.ResumeLayout(False)
        Me.languagegb.ResumeLayout(False)
        Me.autostartgb.ResumeLayout(False)
        Me.autostartgb.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents registfiletypegb As System.Windows.Forms.GroupBox
    Friend WithEvents registfiletype As System.Windows.Forms.Button
    Friend WithEvents okbt As System.Windows.Forms.Button
    Friend WithEvents languagegb As System.Windows.Forms.GroupBox
    Friend WithEvents languagecb As System.Windows.Forms.ComboBox
    Friend WithEvents autostartgb As System.Windows.Forms.GroupBox
    Friend WithEvents startwincb As System.Windows.Forms.CheckBox
    Friend WithEvents startminwincryptrb As System.Windows.Forms.RadioButton
    Friend WithEvents startnormalwincrypt As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents show_bt As System.Windows.Forms.Button
    Friend WithEvents key_txt As System.Windows.Forms.TextBox
    Friend WithEvents key_lb As System.Windows.Forms.Label
    Friend WithEvents key_cb As System.Windows.Forms.CheckBox
End Class
