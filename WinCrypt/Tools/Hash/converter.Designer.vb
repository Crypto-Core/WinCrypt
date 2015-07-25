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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'convert_bt
        '
        Me.convert_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.convert_bt.FlatAppearance.BorderSize = 0
        Me.convert_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.convert_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.convert_bt.Location = New System.Drawing.Point(197, 99)
        Me.convert_bt.Name = "convert_bt"
        Me.convert_bt.Size = New System.Drawing.Size(75, 23)
        Me.convert_bt.TabIndex = 0
        Me.convert_bt.Text = "Konvertieren"
        Me.convert_bt.UseVisualStyleBackColor = False
        '
        'noHash_Textbox
        '
        Me.noHash_Textbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.noHash_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.noHash_Textbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.noHash_Textbox.Location = New System.Drawing.Point(49, 38)
        Me.noHash_Textbox.Name = "noHash_Textbox"
        Me.noHash_Textbox.Size = New System.Drawing.Size(290, 20)
        Me.noHash_Textbox.TabIndex = 1
        '
        'text_lb
        '
        Me.text_lb.AutoSize = True
        Me.text_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.text_lb.Location = New System.Drawing.Point(12, 41)
        Me.text_lb.Name = "text_lb"
        Me.text_lb.Size = New System.Drawing.Size(31, 13)
        Me.text_lb.TabIndex = 2
        Me.text_lb.Text = "Text:"
        '
        'isHash_Textbox
        '
        Me.isHash_Textbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.isHash_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.isHash_Textbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.isHash_Textbox.Location = New System.Drawing.Point(15, 73)
        Me.isHash_Textbox.Name = "isHash_Textbox"
        Me.isHash_Textbox.ReadOnly = True
        Me.isHash_Textbox.Size = New System.Drawing.Size(442, 20)
        Me.isHash_Textbox.TabIndex = 4
        Me.isHash_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'toHash_ComboBox
        '
        Me.toHash_ComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.toHash_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.toHash_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.toHash_ComboBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.toHash_ComboBox.FormattingEnabled = True
        Me.toHash_ComboBox.Items.AddRange(New Object() {"MD5", "SHA1", "SHA256", "SHA384", "SHA512", "RIPEMD160"})
        Me.toHash_ComboBox.Location = New System.Drawing.Point(367, 38)
        Me.toHash_ComboBox.Name = "toHash_ComboBox"
        Me.toHash_ComboBox.Size = New System.Drawing.Size(90, 21)
        Me.toHash_ComboBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(342, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Art:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(469, 27)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "WinCrypt"
        '
        'XToolStripMenuItem
        '
        Me.XToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.XToolStripMenuItem.Name = "XToolStripMenuItem"
        Me.XToolStripMenuItem.Size = New System.Drawing.Size(29, 23)
        Me.XToolStripMenuItem.Text = "X"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(32, 23)
        Me.ToolStripMenuItem1.Text = "─"
        '
        'wincrypttitle
        '
        Me.wincrypttitle.AutoSize = True
        Me.wincrypttitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.wincrypttitle.Location = New System.Drawing.Point(34, 6)
        Me.wincrypttitle.Name = "wincrypttitle"
        Me.wincrypttitle.Size = New System.Drawing.Size(96, 16)
        Me.wincrypttitle.TabIndex = 14
        Me.wincrypttitle.Text = "MD5 Konverter"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_WinCrypt.My.Resources.Resources.icon
        Me.PictureBox1.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'converter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(469, 129)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.toHash_ComboBox)
        Me.Controls.Add(Me.isHash_Textbox)
        Me.Controls.Add(Me.text_lb)
        Me.Controls.Add(Me.noHash_Textbox)
        Me.Controls.Add(Me.convert_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "converter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hash Konverter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents convert_bt As System.Windows.Forms.Button
    Friend WithEvents noHash_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents text_lb As System.Windows.Forms.Label
    Friend WithEvents isHash_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents toHash_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
