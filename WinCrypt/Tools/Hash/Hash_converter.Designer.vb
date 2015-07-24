<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hash_converter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hash_converter))
        Me.convert_bt = New System.Windows.Forms.Button()
        Me.noHash_Textbox = New System.Windows.Forms.TextBox()
        Me.text_lb = New System.Windows.Forms.Label()
        Me.isHash_Textbox = New System.Windows.Forms.TextBox()
        Me.toHash_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        'noHash_Textbox
        '
        Me.noHash_Textbox.Location = New System.Drawing.Point(49, 15)
        Me.noHash_Textbox.Name = "noHash_Textbox"
        Me.noHash_Textbox.Size = New System.Drawing.Size(304, 20)
        Me.noHash_Textbox.TabIndex = 1
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
        'isHash_Textbox
        '
        Me.isHash_Textbox.Location = New System.Drawing.Point(15, 50)
        Me.isHash_Textbox.Name = "isHash_Textbox"
        Me.isHash_Textbox.ReadOnly = True
        Me.isHash_Textbox.Size = New System.Drawing.Size(442, 20)
        Me.isHash_Textbox.TabIndex = 4
        Me.isHash_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'toHash_ComboBox
        '
        Me.toHash_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.toHash_ComboBox.FormattingEnabled = True
        Me.toHash_ComboBox.Items.AddRange(New Object() {"MD5", "SHA1", "SHA256", "SHA384", "SHA512"})
        Me.toHash_ComboBox.Location = New System.Drawing.Point(388, 15)
        Me.toHash_ComboBox.Name = "toHash_ComboBox"
        Me.toHash_ComboBox.Size = New System.Drawing.Size(69, 21)
        Me.toHash_ComboBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(359, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Art:"
        '
        'winHash_converter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 106)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.toHash_ComboBox)
        Me.Controls.Add(Me.isHash_Textbox)
        Me.Controls.Add(Me.text_lb)
        Me.Controls.Add(Me.noHash_Textbox)
        Me.Controls.Add(Me.convert_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "winHash_converter"
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
