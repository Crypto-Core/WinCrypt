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
            Me.SuspendLayout()
            '
            'convert_bt
            '
            Me.convert_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.convert_bt.FlatAppearance.BorderSize = 0
            Me.convert_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.convert_bt.Font = New System.Drawing.Font("Ubuntu Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.convert_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.convert_bt.Location = New System.Drawing.Point(191, 80)
            Me.convert_bt.Name = "convert_bt"
            Me.convert_bt.Size = New System.Drawing.Size(87, 23)
            Me.convert_bt.TabIndex = 0
            Me.convert_bt.Text = "convert"
            Me.convert_bt.UseVisualStyleBackColor = False
            '
            'noHash_Textbox
            '
            Me.noHash_Textbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.noHash_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.noHash_Textbox.Font = New System.Drawing.Font("Ubuntu Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.noHash_Textbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.noHash_Textbox.Location = New System.Drawing.Point(49, 19)
            Me.noHash_Textbox.Name = "noHash_Textbox"
            Me.noHash_Textbox.Size = New System.Drawing.Size(270, 18)
            Me.noHash_Textbox.TabIndex = 1
            '
            'text_lb
            '
            Me.text_lb.AutoSize = True
            Me.text_lb.Font = New System.Drawing.Font("Ubuntu Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.text_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.text_lb.Location = New System.Drawing.Point(12, 21)
            Me.text_lb.Name = "text_lb"
            Me.text_lb.Size = New System.Drawing.Size(37, 15)
            Me.text_lb.TabIndex = 2
            Me.text_lb.Text = "text:"
            '
            'isHash_Textbox
            '
            Me.isHash_Textbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.isHash_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.isHash_Textbox.Font = New System.Drawing.Font("Ubuntu Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.isHash_Textbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.isHash_Textbox.Location = New System.Drawing.Point(15, 54)
            Me.isHash_Textbox.Name = "isHash_Textbox"
            Me.isHash_Textbox.ReadOnly = True
            Me.isHash_Textbox.Size = New System.Drawing.Size(442, 18)
            Me.isHash_Textbox.TabIndex = 4
            Me.isHash_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'toHash_ComboBox
            '
            Me.toHash_ComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.toHash_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.toHash_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.toHash_ComboBox.Font = New System.Drawing.Font("Ubuntu Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toHash_ComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.toHash_ComboBox.FormattingEnabled = True
            Me.toHash_ComboBox.Items.AddRange(New Object() {"MD5", "SHA1", "SHA256", "SHA384", "SHA512", "RIPEMD160"})
            Me.toHash_ComboBox.Location = New System.Drawing.Point(367, 19)
            Me.toHash_ComboBox.Name = "toHash_ComboBox"
            Me.toHash_ComboBox.Size = New System.Drawing.Size(90, 23)
            Me.toHash_ComboBox.TabIndex = 5
            '
            'art_lb
            '
            Me.art_lb.AutoSize = True
            Me.art_lb.Font = New System.Drawing.Font("Ubuntu Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.art_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.art_lb.Location = New System.Drawing.Point(330, 22)
            Me.art_lb.Name = "art_lb"
            Me.art_lb.Size = New System.Drawing.Size(31, 15)
            Me.art_lb.TabIndex = 6
            Me.art_lb.Text = "art:"
            '
            'converter
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(469, 118)
            Me.Controls.Add(Me.art_lb)
            Me.Controls.Add(Me.toHash_ComboBox)
            Me.Controls.Add(Me.isHash_Textbox)
            Me.Controls.Add(Me.text_lb)
            Me.Controls.Add(Me.noHash_Textbox)
            Me.Controls.Add(Me.convert_bt)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "converter"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Hash Konverter"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents convert_bt As System.Windows.Forms.Button
        Friend WithEvents noHash_Textbox As System.Windows.Forms.TextBox
        Friend WithEvents text_lb As System.Windows.Forms.Label
        Friend WithEvents isHash_Textbox As System.Windows.Forms.TextBox
        Friend WithEvents toHash_ComboBox As System.Windows.Forms.ComboBox
        Friend WithEvents art_lb As System.Windows.Forms.Label
    End Class
End Namespace