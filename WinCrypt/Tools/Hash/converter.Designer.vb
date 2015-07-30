Namespace tools.hash
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class converter
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(converter))
            Me.convert_bt = New System.Windows.Forms.Button()
            Me.noHash_Textbox = New System.Windows.Forms.TextBox()
            Me.text_lb = New System.Windows.Forms.Label()
            Me.isHash_Textbox = New System.Windows.Forms.TextBox()
            Me.toHash_ComboBox = New System.Windows.Forms.ComboBox()
            Me.art_lb = New System.Windows.Forms.Label()
            Me.form_head = New System.Windows.Forms.MenuStrip()
            Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.minimize_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.wincrypttitle = New System.Windows.Forms.Label()
            Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
            Me.form_head.SuspendLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'convert_bt
            '
            Me.convert_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.convert_bt.FlatAppearance.BorderSize = 0
            Me.convert_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.convert_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.convert_bt.Location = New System.Drawing.Point(191, 99)
            Me.convert_bt.Name = "convert_bt"
            Me.convert_bt.Size = New System.Drawing.Size(87, 23)
            Me.convert_bt.TabIndex = 0
            Me.convert_bt.Text = "Konvertieren"
            Me.convert_bt.UseVisualStyleBackColor = False
            '
            'noHash_Textbox
            '
            Me.noHash_Textbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.noHash_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.noHash_Textbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.noHash_Textbox.Location = New System.Drawing.Point(49, 38)
            Me.noHash_Textbox.Name = "noHash_Textbox"
            Me.noHash_Textbox.Size = New System.Drawing.Size(290, 22)
            Me.noHash_Textbox.TabIndex = 1
            '
            'text_lb
            '
            Me.text_lb.AutoSize = True
            Me.text_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.text_lb.Location = New System.Drawing.Point(12, 41)
            Me.text_lb.Name = "text_lb"
            Me.text_lb.Size = New System.Drawing.Size(29, 13)
            Me.text_lb.TabIndex = 2
            Me.text_lb.Text = "Text:"
            '
            'isHash_Textbox
            '
            Me.isHash_Textbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.isHash_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.isHash_Textbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.isHash_Textbox.Location = New System.Drawing.Point(15, 73)
            Me.isHash_Textbox.Name = "isHash_Textbox"
            Me.isHash_Textbox.ReadOnly = True
            Me.isHash_Textbox.Size = New System.Drawing.Size(442, 22)
            Me.isHash_Textbox.TabIndex = 4
            Me.isHash_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'toHash_ComboBox
            '
            Me.toHash_ComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.toHash_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.toHash_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.toHash_ComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.toHash_ComboBox.FormattingEnabled = True
            Me.toHash_ComboBox.Items.AddRange(New Object() {"MD5", "SHA1", "SHA256", "SHA384", "SHA512", "RIPEMD160"})
            Me.toHash_ComboBox.Location = New System.Drawing.Point(367, 38)
            Me.toHash_ComboBox.Name = "toHash_ComboBox"
            Me.toHash_ComboBox.Size = New System.Drawing.Size(90, 21)
            Me.toHash_ComboBox.TabIndex = 5
            '
            'art_lb
            '
            Me.art_lb.AutoSize = True
            Me.art_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.art_lb.Location = New System.Drawing.Point(342, 41)
            Me.art_lb.Name = "art_lb"
            Me.art_lb.Size = New System.Drawing.Size(25, 13)
            Me.art_lb.TabIndex = 6
            Me.art_lb.Text = "Art:"
            '
            'form_head
            '
            Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt, Me.minimize_bt})
            Me.form_head.Location = New System.Drawing.Point(0, 0)
            Me.form_head.Name = "form_head"
            Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.form_head.Size = New System.Drawing.Size(469, 27)
            Me.form_head.TabIndex = 13
            Me.form_head.Text = "WinCrypt"
            '
            'exit_bt
            '
            Me.exit_bt.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.exit_bt.ForeColor = System.Drawing.Color.White
            Me.exit_bt.Name = "exit_bt"
            Me.exit_bt.Size = New System.Drawing.Size(29, 23)
            Me.exit_bt.Text = "X"
            '
            'minimize_bt
            '
            Me.minimize_bt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.minimize_bt.ForeColor = System.Drawing.Color.White
            Me.minimize_bt.Name = "minimize_bt"
            Me.minimize_bt.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.minimize_bt.Size = New System.Drawing.Size(32, 23)
            Me.minimize_bt.Text = "─"
            '
            'wincrypttitle
            '
            Me.wincrypttitle.AutoSize = True
            Me.wincrypttitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.wincrypttitle.Location = New System.Drawing.Point(34, 6)
            Me.wincrypttitle.Name = "wincrypttitle"
            Me.wincrypttitle.Size = New System.Drawing.Size(97, 17)
            Me.wincrypttitle.TabIndex = 14
            Me.wincrypttitle.Text = "MD5 Konverter"
            '
            'wincrypt_icon
            '
            Me.wincrypt_icon.Image = Global.Project_WinCrypt.My.Resources.Resources.wc_icon16
            Me.wincrypt_icon.Location = New System.Drawing.Point(9, 6)
            Me.wincrypt_icon.Name = "wincrypt_icon"
            Me.wincrypt_icon.Size = New System.Drawing.Size(16, 16)
            Me.wincrypt_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.wincrypt_icon.TabIndex = 15
            Me.wincrypt_icon.TabStop = False
            '
            'converter
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(469, 129)
            Me.Controls.Add(Me.wincrypt_icon)
            Me.Controls.Add(Me.wincrypttitle)
            Me.Controls.Add(Me.form_head)
            Me.Controls.Add(Me.art_lb)
            Me.Controls.Add(Me.toHash_ComboBox)
            Me.Controls.Add(Me.isHash_Textbox)
            Me.Controls.Add(Me.text_lb)
            Me.Controls.Add(Me.noHash_Textbox)
            Me.Controls.Add(Me.convert_bt)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "converter"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Hash Konverter"
            Me.form_head.ResumeLayout(False)
            Me.form_head.PerformLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents convert_bt As System.Windows.Forms.Button
        Friend WithEvents noHash_Textbox As System.Windows.Forms.TextBox
        Friend WithEvents text_lb As System.Windows.Forms.Label
        Friend WithEvents isHash_Textbox As System.Windows.Forms.TextBox
        Friend WithEvents toHash_ComboBox As System.Windows.Forms.ComboBox
        Friend WithEvents art_lb As System.Windows.Forms.Label
        Friend WithEvents form_head As System.Windows.Forms.MenuStrip
        Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents minimize_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents wincrypttitle As System.Windows.Forms.Label
        Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
    End Class
End Namespace