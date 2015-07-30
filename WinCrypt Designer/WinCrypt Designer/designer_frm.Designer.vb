<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wincryptdesigner_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wincryptdesigner_frm))
        Me.wincrypt_panel = New System.Windows.Forms.Panel()
        Me.menu_panel = New System.Windows.Forms.Panel()
        Me.buttoncolor_gb = New System.Windows.Forms.GroupBox()
        Me.buttoncolor_picker_bt = New System.Windows.Forms.Button()
        Me.buttoncolor_hex_txt = New System.Windows.Forms.TextBox()
        Me.buttoncolor_ImagePicker_bt = New System.Windows.Forms.Button()
        Me.buttoncolor_hex_lb = New System.Windows.Forms.Label()
        Me.inputcolor_gb = New System.Windows.Forms.GroupBox()
        Me.inputcolor_picker_bt = New System.Windows.Forms.Button()
        Me.inputcolor_hex_txt = New System.Windows.Forms.TextBox()
        Me.inputcolor_hex_lb = New System.Windows.Forms.Label()
        Me.inputcolor_ImagePicker_bt = New System.Windows.Forms.Button()
        Me.textinputcolor_gb = New System.Windows.Forms.GroupBox()
        Me.textinputcolor_picker_bt = New System.Windows.Forms.Button()
        Me.textinputcolor_hex_txt = New System.Windows.Forms.TextBox()
        Me.textinoutcolor_hex_lb = New System.Windows.Forms.Label()
        Me.textinputcolor_ImagePicker_bt = New System.Windows.Forms.Button()
        Me.txtcolor_gb = New System.Windows.Forms.GroupBox()
        Me.txtcolor_picker_bt = New System.Windows.Forms.Button()
        Me.txtcolor_hex_txt = New System.Windows.Forms.TextBox()
        Me.txtcolor_hex_lb = New System.Windows.Forms.Label()
        Me.txtcolor_ImagePicker_bt = New System.Windows.Forms.Button()
        Me.bg_gb = New System.Windows.Forms.GroupBox()
        Me.bgcolor_ImagePicker_bt = New System.Windows.Forms.Button()
        Me.bgcolor_picker_bt = New System.Windows.Forms.Button()
        Me.bgcolor_hex_txt = New System.Windows.Forms.TextBox()
        Me.bgcolor_hex_lb = New System.Windows.Forms.Label()
        Me.formhead_gb = New System.Windows.Forms.GroupBox()
        Me.formhead_ImagePicker_bt = New System.Windows.Forms.Button()
        Me.formhead_picker_bt = New System.Windows.Forms.Button()
        Me.formhead_hex_txt = New System.Windows.Forms.TextBox()
        Me.formhead_hex_lb = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewdefaultDesignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesignLadenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesignSpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypt_picker_dialog = New System.Windows.Forms.ColorDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.menu_panel.SuspendLayout()
        Me.buttoncolor_gb.SuspendLayout()
        Me.inputcolor_gb.SuspendLayout()
        Me.textinputcolor_gb.SuspendLayout()
        Me.txtcolor_gb.SuspendLayout()
        Me.bg_gb.SuspendLayout()
        Me.formhead_gb.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'wincrypt_panel
        '
        Me.wincrypt_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wincrypt_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.wincrypt_panel.BackgroundImage = Global.WinCrypt_Designer.My.Resources.Resources.bg1
        Me.wincrypt_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.wincrypt_panel.Location = New System.Drawing.Point(193, 27)
        Me.wincrypt_panel.Name = "wincrypt_panel"
        Me.wincrypt_panel.Size = New System.Drawing.Size(633, 640)
        Me.wincrypt_panel.TabIndex = 0
        '
        'menu_panel
        '
        Me.menu_panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.menu_panel.BackColor = System.Drawing.SystemColors.Control
        Me.menu_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menu_panel.Controls.Add(Me.buttoncolor_gb)
        Me.menu_panel.Controls.Add(Me.inputcolor_gb)
        Me.menu_panel.Controls.Add(Me.textinputcolor_gb)
        Me.menu_panel.Controls.Add(Me.txtcolor_gb)
        Me.menu_panel.Controls.Add(Me.bg_gb)
        Me.menu_panel.Controls.Add(Me.formhead_gb)
        Me.menu_panel.Location = New System.Drawing.Point(12, 27)
        Me.menu_panel.Name = "menu_panel"
        Me.menu_panel.Size = New System.Drawing.Size(175, 640)
        Me.menu_panel.TabIndex = 2
        '
        'buttoncolor_gb
        '
        Me.buttoncolor_gb.Controls.Add(Me.buttoncolor_picker_bt)
        Me.buttoncolor_gb.Controls.Add(Me.buttoncolor_hex_txt)
        Me.buttoncolor_gb.Controls.Add(Me.buttoncolor_ImagePicker_bt)
        Me.buttoncolor_gb.Controls.Add(Me.buttoncolor_hex_lb)
        Me.buttoncolor_gb.Location = New System.Drawing.Point(3, 293)
        Me.buttoncolor_gb.Name = "buttoncolor_gb"
        Me.buttoncolor_gb.Size = New System.Drawing.Size(169, 52)
        Me.buttoncolor_gb.TabIndex = 5
        Me.buttoncolor_gb.TabStop = False
        Me.buttoncolor_gb.Text = "Button Color"
        '
        'buttoncolor_picker_bt
        '
        Me.buttoncolor_picker_bt.Image = Global.WinCrypt_Designer.My.Resources.Resources._1438291712_color_wheel
        Me.buttoncolor_picker_bt.Location = New System.Drawing.Point(114, 16)
        Me.buttoncolor_picker_bt.Name = "buttoncolor_picker_bt"
        Me.buttoncolor_picker_bt.Size = New System.Drawing.Size(25, 25)
        Me.buttoncolor_picker_bt.TabIndex = 8
        Me.buttoncolor_picker_bt.UseVisualStyleBackColor = True
        '
        'buttoncolor_hex_txt
        '
        Me.buttoncolor_hex_txt.Location = New System.Drawing.Point(44, 19)
        Me.buttoncolor_hex_txt.Name = "buttoncolor_hex_txt"
        Me.buttoncolor_hex_txt.Size = New System.Drawing.Size(64, 20)
        Me.buttoncolor_hex_txt.TabIndex = 9
        '
        'buttoncolor_ImagePicker_bt
        '
        Me.buttoncolor_ImagePicker_bt.Image = Global.WinCrypt_Designer.My.Resources.Resources._1438293349_color_picker
        Me.buttoncolor_ImagePicker_bt.Location = New System.Drawing.Point(142, 16)
        Me.buttoncolor_ImagePicker_bt.Name = "buttoncolor_ImagePicker_bt"
        Me.buttoncolor_ImagePicker_bt.Size = New System.Drawing.Size(25, 25)
        Me.buttoncolor_ImagePicker_bt.TabIndex = 7
        Me.buttoncolor_ImagePicker_bt.UseVisualStyleBackColor = True
        '
        'buttoncolor_hex_lb
        '
        Me.buttoncolor_hex_lb.AutoSize = True
        Me.buttoncolor_hex_lb.Location = New System.Drawing.Point(6, 22)
        Me.buttoncolor_hex_lb.Name = "buttoncolor_hex_lb"
        Me.buttoncolor_hex_lb.Size = New System.Drawing.Size(32, 13)
        Me.buttoncolor_hex_lb.TabIndex = 8
        Me.buttoncolor_hex_lb.Text = "HEX:"
        '
        'inputcolor_gb
        '
        Me.inputcolor_gb.Controls.Add(Me.inputcolor_picker_bt)
        Me.inputcolor_gb.Controls.Add(Me.inputcolor_hex_txt)
        Me.inputcolor_gb.Controls.Add(Me.inputcolor_hex_lb)
        Me.inputcolor_gb.Controls.Add(Me.inputcolor_ImagePicker_bt)
        Me.inputcolor_gb.Location = New System.Drawing.Point(3, 235)
        Me.inputcolor_gb.Name = "inputcolor_gb"
        Me.inputcolor_gb.Size = New System.Drawing.Size(169, 52)
        Me.inputcolor_gb.TabIndex = 4
        Me.inputcolor_gb.TabStop = False
        Me.inputcolor_gb.Text = "Input Color"
        '
        'inputcolor_picker_bt
        '
        Me.inputcolor_picker_bt.Image = Global.WinCrypt_Designer.My.Resources.Resources._1438291712_color_wheel
        Me.inputcolor_picker_bt.Location = New System.Drawing.Point(116, 16)
        Me.inputcolor_picker_bt.Name = "inputcolor_picker_bt"
        Me.inputcolor_picker_bt.Size = New System.Drawing.Size(25, 25)
        Me.inputcolor_picker_bt.TabIndex = 6
        Me.inputcolor_picker_bt.UseVisualStyleBackColor = True
        '
        'inputcolor_hex_txt
        '
        Me.inputcolor_hex_txt.Location = New System.Drawing.Point(44, 19)
        Me.inputcolor_hex_txt.Name = "inputcolor_hex_txt"
        Me.inputcolor_hex_txt.Size = New System.Drawing.Size(64, 20)
        Me.inputcolor_hex_txt.TabIndex = 7
        '
        'inputcolor_hex_lb
        '
        Me.inputcolor_hex_lb.AutoSize = True
        Me.inputcolor_hex_lb.Location = New System.Drawing.Point(6, 22)
        Me.inputcolor_hex_lb.Name = "inputcolor_hex_lb"
        Me.inputcolor_hex_lb.Size = New System.Drawing.Size(32, 13)
        Me.inputcolor_hex_lb.TabIndex = 6
        Me.inputcolor_hex_lb.Text = "HEX:"
        '
        'inputcolor_ImagePicker_bt
        '
        Me.inputcolor_ImagePicker_bt.Image = Global.WinCrypt_Designer.My.Resources.Resources._1438293349_color_picker
        Me.inputcolor_ImagePicker_bt.Location = New System.Drawing.Point(142, 16)
        Me.inputcolor_ImagePicker_bt.Name = "inputcolor_ImagePicker_bt"
        Me.inputcolor_ImagePicker_bt.Size = New System.Drawing.Size(25, 25)
        Me.inputcolor_ImagePicker_bt.TabIndex = 6
        Me.inputcolor_ImagePicker_bt.UseVisualStyleBackColor = True
        '
        'textinputcolor_gb
        '
        Me.textinputcolor_gb.Controls.Add(Me.textinputcolor_picker_bt)
        Me.textinputcolor_gb.Controls.Add(Me.textinputcolor_hex_txt)
        Me.textinputcolor_gb.Controls.Add(Me.textinoutcolor_hex_lb)
        Me.textinputcolor_gb.Controls.Add(Me.textinputcolor_ImagePicker_bt)
        Me.textinputcolor_gb.Location = New System.Drawing.Point(3, 177)
        Me.textinputcolor_gb.Name = "textinputcolor_gb"
        Me.textinputcolor_gb.Size = New System.Drawing.Size(169, 52)
        Me.textinputcolor_gb.TabIndex = 3
        Me.textinputcolor_gb.TabStop = False
        Me.textinputcolor_gb.Text = "Text Input Color"
        '
        'textinputcolor_picker_bt
        '
        Me.textinputcolor_picker_bt.Image = Global.WinCrypt_Designer.My.Resources.Resources._1438291712_color_wheel
        Me.textinputcolor_picker_bt.Location = New System.Drawing.Point(116, 16)
        Me.textinputcolor_picker_bt.Name = "textinputcolor_picker_bt"
        Me.textinputcolor_picker_bt.Size = New System.Drawing.Size(25, 25)
        Me.textinputcolor_picker_bt.TabIndex = 5
        Me.textinputcolor_picker_bt.UseVisualStyleBackColor = True
        '
        'textinputcolor_hex_txt
        '
        Me.textinputcolor_hex_txt.Location = New System.Drawing.Point(44, 19)
        Me.textinputcolor_hex_txt.Name = "textinputcolor_hex_txt"
        Me.textinputcolor_hex_txt.Size = New System.Drawing.Size(64, 20)
        Me.textinputcolor_hex_txt.TabIndex = 5
        '
        'textinoutcolor_hex_lb
        '
        Me.textinoutcolor_hex_lb.AutoSize = True
        Me.textinoutcolor_hex_lb.Location = New System.Drawing.Point(6, 22)
        Me.textinoutcolor_hex_lb.Name = "textinoutcolor_hex_lb"
        Me.textinoutcolor_hex_lb.Size = New System.Drawing.Size(32, 13)
        Me.textinoutcolor_hex_lb.TabIndex = 4
        Me.textinoutcolor_hex_lb.Text = "HEX:"
        '
        'textinputcolor_ImagePicker_bt
        '
        Me.textinputcolor_ImagePicker_bt.Image = Global.WinCrypt_Designer.My.Resources.Resources._1438293349_color_picker
        Me.textinputcolor_ImagePicker_bt.Location = New System.Drawing.Point(142, 16)
        Me.textinputcolor_ImagePicker_bt.Name = "textinputcolor_ImagePicker_bt"
        Me.textinputcolor_ImagePicker_bt.Size = New System.Drawing.Size(25, 25)
        Me.textinputcolor_ImagePicker_bt.TabIndex = 5
        Me.textinputcolor_ImagePicker_bt.UseVisualStyleBackColor = True
        '
        'txtcolor_gb
        '
        Me.txtcolor_gb.Controls.Add(Me.txtcolor_picker_bt)
        Me.txtcolor_gb.Controls.Add(Me.txtcolor_hex_txt)
        Me.txtcolor_gb.Controls.Add(Me.txtcolor_hex_lb)
        Me.txtcolor_gb.Controls.Add(Me.txtcolor_ImagePicker_bt)
        Me.txtcolor_gb.Location = New System.Drawing.Point(3, 119)
        Me.txtcolor_gb.Name = "txtcolor_gb"
        Me.txtcolor_gb.Size = New System.Drawing.Size(169, 52)
        Me.txtcolor_gb.TabIndex = 2
        Me.txtcolor_gb.TabStop = False
        Me.txtcolor_gb.Text = "Text Color"
        '
        'txtcolor_picker_bt
        '
        Me.txtcolor_picker_bt.Image = Global.WinCrypt_Designer.My.Resources.Resources._1438291712_color_wheel
        Me.txtcolor_picker_bt.Location = New System.Drawing.Point(114, 16)
        Me.txtcolor_picker_bt.Name = "txtcolor_picker_bt"
        Me.txtcolor_picker_bt.Size = New System.Drawing.Size(25, 25)
        Me.txtcolor_picker_bt.TabIndex = 4
        Me.txtcolor_picker_bt.UseVisualStyleBackColor = True
        '
        'txtcolor_hex_txt
        '
        Me.txtcolor_hex_txt.Location = New System.Drawing.Point(44, 19)
        Me.txtcolor_hex_txt.Name = "txtcolor_hex_txt"
        Me.txtcolor_hex_txt.Size = New System.Drawing.Size(64, 20)
        Me.txtcolor_hex_txt.TabIndex = 3
        '
        'txtcolor_hex_lb
        '
        Me.txtcolor_hex_lb.AutoSize = True
        Me.txtcolor_hex_lb.Location = New System.Drawing.Point(6, 22)
        Me.txtcolor_hex_lb.Name = "txtcolor_hex_lb"
        Me.txtcolor_hex_lb.Size = New System.Drawing.Size(32, 13)
        Me.txtcolor_hex_lb.TabIndex = 2
        Me.txtcolor_hex_lb.Text = "HEX:"
        '
        'txtcolor_ImagePicker_bt
        '
        Me.txtcolor_ImagePicker_bt.Image = Global.WinCrypt_Designer.My.Resources.Resources._1438293349_color_picker
        Me.txtcolor_ImagePicker_bt.Location = New System.Drawing.Point(142, 16)
        Me.txtcolor_ImagePicker_bt.Name = "txtcolor_ImagePicker_bt"
        Me.txtcolor_ImagePicker_bt.Size = New System.Drawing.Size(25, 25)
        Me.txtcolor_ImagePicker_bt.TabIndex = 4
        Me.txtcolor_ImagePicker_bt.UseVisualStyleBackColor = True
        '
        'bg_gb
        '
        Me.bg_gb.Controls.Add(Me.bgcolor_ImagePicker_bt)
        Me.bg_gb.Controls.Add(Me.bgcolor_picker_bt)
        Me.bg_gb.Controls.Add(Me.bgcolor_hex_txt)
        Me.bg_gb.Controls.Add(Me.bgcolor_hex_lb)
        Me.bg_gb.Location = New System.Drawing.Point(3, 61)
        Me.bg_gb.Name = "bg_gb"
        Me.bg_gb.Size = New System.Drawing.Size(169, 52)
        Me.bg_gb.TabIndex = 1
        Me.bg_gb.TabStop = False
        Me.bg_gb.Text = "Background Color"
        '
        'bgcolor_ImagePicker_bt
        '
        Me.bgcolor_ImagePicker_bt.Image = Global.WinCrypt_Designer.My.Resources.Resources._1438293349_color_picker
        Me.bgcolor_ImagePicker_bt.Location = New System.Drawing.Point(142, 16)
        Me.bgcolor_ImagePicker_bt.Name = "bgcolor_ImagePicker_bt"
        Me.bgcolor_ImagePicker_bt.Size = New System.Drawing.Size(25, 25)
        Me.bgcolor_ImagePicker_bt.TabIndex = 4
        Me.bgcolor_ImagePicker_bt.UseVisualStyleBackColor = True
        '
        'bgcolor_picker_bt
        '
        Me.bgcolor_picker_bt.Image = Global.WinCrypt_Designer.My.Resources.Resources._1438291712_color_wheel
        Me.bgcolor_picker_bt.Location = New System.Drawing.Point(114, 16)
        Me.bgcolor_picker_bt.Name = "bgcolor_picker_bt"
        Me.bgcolor_picker_bt.Size = New System.Drawing.Size(25, 25)
        Me.bgcolor_picker_bt.TabIndex = 3
        Me.bgcolor_picker_bt.UseVisualStyleBackColor = True
        '
        'bgcolor_hex_txt
        '
        Me.bgcolor_hex_txt.Location = New System.Drawing.Point(44, 19)
        Me.bgcolor_hex_txt.Name = "bgcolor_hex_txt"
        Me.bgcolor_hex_txt.Size = New System.Drawing.Size(64, 20)
        Me.bgcolor_hex_txt.TabIndex = 3
        '
        'bgcolor_hex_lb
        '
        Me.bgcolor_hex_lb.AutoSize = True
        Me.bgcolor_hex_lb.Location = New System.Drawing.Point(6, 22)
        Me.bgcolor_hex_lb.Name = "bgcolor_hex_lb"
        Me.bgcolor_hex_lb.Size = New System.Drawing.Size(32, 13)
        Me.bgcolor_hex_lb.TabIndex = 2
        Me.bgcolor_hex_lb.Text = "HEX:"
        '
        'formhead_gb
        '
        Me.formhead_gb.Controls.Add(Me.formhead_ImagePicker_bt)
        Me.formhead_gb.Controls.Add(Me.formhead_picker_bt)
        Me.formhead_gb.Controls.Add(Me.formhead_hex_txt)
        Me.formhead_gb.Controls.Add(Me.formhead_hex_lb)
        Me.formhead_gb.Location = New System.Drawing.Point(3, 3)
        Me.formhead_gb.Name = "formhead_gb"
        Me.formhead_gb.Size = New System.Drawing.Size(169, 52)
        Me.formhead_gb.TabIndex = 0
        Me.formhead_gb.TabStop = False
        Me.formhead_gb.Text = "Form Head"
        '
        'formhead_ImagePicker_bt
        '
        Me.formhead_ImagePicker_bt.Image = Global.WinCrypt_Designer.My.Resources.Resources._1438293349_color_picker
        Me.formhead_ImagePicker_bt.Location = New System.Drawing.Point(142, 19)
        Me.formhead_ImagePicker_bt.Name = "formhead_ImagePicker_bt"
        Me.formhead_ImagePicker_bt.Size = New System.Drawing.Size(25, 25)
        Me.formhead_ImagePicker_bt.TabIndex = 3
        Me.formhead_ImagePicker_bt.UseVisualStyleBackColor = True
        '
        'formhead_picker_bt
        '
        Me.formhead_picker_bt.Image = Global.WinCrypt_Designer.My.Resources.Resources._1438291712_color_wheel
        Me.formhead_picker_bt.Location = New System.Drawing.Point(114, 19)
        Me.formhead_picker_bt.Name = "formhead_picker_bt"
        Me.formhead_picker_bt.Size = New System.Drawing.Size(25, 25)
        Me.formhead_picker_bt.TabIndex = 2
        Me.formhead_picker_bt.UseVisualStyleBackColor = True
        '
        'formhead_hex_txt
        '
        Me.formhead_hex_txt.Location = New System.Drawing.Point(44, 22)
        Me.formhead_hex_txt.Name = "formhead_hex_txt"
        Me.formhead_hex_txt.Size = New System.Drawing.Size(64, 20)
        Me.formhead_hex_txt.TabIndex = 1
        '
        'formhead_hex_lb
        '
        Me.formhead_hex_lb.AutoSize = True
        Me.formhead_hex_lb.Location = New System.Drawing.Point(6, 25)
        Me.formhead_hex_lb.Name = "formhead_hex_lb"
        Me.formhead_hex_lb.Size = New System.Drawing.Size(32, 13)
        Me.formhead_hex_lb.TabIndex = 0
        Me.formhead_hex_lb.Text = "HEX:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(835, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewdefaultDesignToolStripMenuItem, Me.DesignLadenToolStripMenuItem, Me.DesignSpeichernToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.DateiToolStripMenuItem.Text = "File"
        '
        'NewdefaultDesignToolStripMenuItem
        '
        Me.NewdefaultDesignToolStripMenuItem.Name = "NewdefaultDesignToolStripMenuItem"
        Me.NewdefaultDesignToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.NewdefaultDesignToolStripMenuItem.Text = "New (default design)"
        '
        'DesignLadenToolStripMenuItem
        '
        Me.DesignLadenToolStripMenuItem.Name = "DesignLadenToolStripMenuItem"
        Me.DesignLadenToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DesignLadenToolStripMenuItem.Text = "Load Design"
        '
        'DesignSpeichernToolStripMenuItem
        '
        Me.DesignSpeichernToolStripMenuItem.Name = "DesignSpeichernToolStripMenuItem"
        Me.DesignSpeichernToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DesignSpeichernToolStripMenuItem.Text = "Save Design"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.BeendenToolStripMenuItem.Text = "Exit"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.InfoToolStripMenuItem.Text = "About"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'wincryptdesigner_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(835, 675)
        Me.Controls.Add(Me.menu_panel)
        Me.Controls.Add(Me.wincrypt_panel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "wincryptdesigner_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WinCrypt Designer"
        Me.menu_panel.ResumeLayout(False)
        Me.buttoncolor_gb.ResumeLayout(False)
        Me.buttoncolor_gb.PerformLayout()
        Me.inputcolor_gb.ResumeLayout(False)
        Me.inputcolor_gb.PerformLayout()
        Me.textinputcolor_gb.ResumeLayout(False)
        Me.textinputcolor_gb.PerformLayout()
        Me.txtcolor_gb.ResumeLayout(False)
        Me.txtcolor_gb.PerformLayout()
        Me.bg_gb.ResumeLayout(False)
        Me.bg_gb.PerformLayout()
        Me.formhead_gb.ResumeLayout(False)
        Me.formhead_gb.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wincrypt_panel As System.Windows.Forms.Panel
    Friend WithEvents menu_panel As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesignLadenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesignSpeichernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents formhead_gb As System.Windows.Forms.GroupBox
    Friend WithEvents buttoncolor_gb As System.Windows.Forms.GroupBox
    Friend WithEvents buttoncolor_hex_txt As System.Windows.Forms.TextBox
    Friend WithEvents buttoncolor_hex_lb As System.Windows.Forms.Label
    Friend WithEvents inputcolor_gb As System.Windows.Forms.GroupBox
    Friend WithEvents inputcolor_hex_txt As System.Windows.Forms.TextBox
    Friend WithEvents inputcolor_hex_lb As System.Windows.Forms.Label
    Friend WithEvents textinputcolor_gb As System.Windows.Forms.GroupBox
    Friend WithEvents textinputcolor_hex_txt As System.Windows.Forms.TextBox
    Friend WithEvents textinoutcolor_hex_lb As System.Windows.Forms.Label
    Friend WithEvents txtcolor_gb As System.Windows.Forms.GroupBox
    Friend WithEvents txtcolor_hex_txt As System.Windows.Forms.TextBox
    Friend WithEvents txtcolor_hex_lb As System.Windows.Forms.Label
    Friend WithEvents bg_gb As System.Windows.Forms.GroupBox
    Friend WithEvents bgcolor_hex_txt As System.Windows.Forms.TextBox
    Friend WithEvents bgcolor_hex_lb As System.Windows.Forms.Label
    Friend WithEvents formhead_hex_txt As System.Windows.Forms.TextBox
    Friend WithEvents formhead_hex_lb As System.Windows.Forms.Label
    Friend WithEvents formhead_picker_bt As System.Windows.Forms.Button
    Friend WithEvents wincrypt_picker_dialog As System.Windows.Forms.ColorDialog
    Friend WithEvents buttoncolor_picker_bt As System.Windows.Forms.Button
    Friend WithEvents inputcolor_picker_bt As System.Windows.Forms.Button
    Friend WithEvents textinputcolor_picker_bt As System.Windows.Forms.Button
    Friend WithEvents txtcolor_picker_bt As System.Windows.Forms.Button
    Friend WithEvents bgcolor_picker_bt As System.Windows.Forms.Button
    Friend WithEvents formhead_ImagePicker_bt As System.Windows.Forms.Button
    Friend WithEvents buttoncolor_ImagePicker_bt As System.Windows.Forms.Button
    Friend WithEvents inputcolor_ImagePicker_bt As System.Windows.Forms.Button
    Friend WithEvents textinputcolor_ImagePicker_bt As System.Windows.Forms.Button
    Friend WithEvents txtcolor_ImagePicker_bt As System.Windows.Forms.Button
    Friend WithEvents bgcolor_ImagePicker_bt As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents NewdefaultDesignToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
