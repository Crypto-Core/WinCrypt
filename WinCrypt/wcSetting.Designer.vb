<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WcSetting
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WcSetting))
        Me.registfiletypegb = New System.Windows.Forms.GroupBox()
        Me.registfiletype = New System.Windows.Forms.Button()
        Me.okbt = New System.Windows.Forms.Button()
        Me.languagegb = New System.Windows.Forms.GroupBox()
        Me.languagecb = New System.Windows.Forms.ComboBox()
        Me.autostartgb = New System.Windows.Forms.GroupBox()
        Me.startnormalwincrypt = New System.Windows.Forms.RadioButton()
        Me.line3 = New System.Windows.Forms.Label()
        Me.startminwincryptrb = New System.Windows.Forms.RadioButton()
        Me.line2 = New System.Windows.Forms.Label()
        Me.line = New System.Windows.Forms.Label()
        Me.startwincb = New System.Windows.Forms.CheckBox()
        Me.masterkey_gb = New System.Windows.Forms.GroupBox()
        Me.key_txt = New System.Windows.Forms.TextBox()
        Me.key_cb = New System.Windows.Forms.CheckBox()
        Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.form_head = New System.Windows.Forms.MenuStrip()
        Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.minimize_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.design_gb = New System.Windows.Forms.GroupBox()
        Me.use_template_rb2 = New System.Windows.Forms.RadioButton()
        Me.use_template_rb = New System.Windows.Forms.RadioButton()
        Me.useTemplate_cb = New System.Windows.Forms.ComboBox()
        Me.design_export = New System.Windows.Forms.Button()
        Me.design_import = New System.Windows.Forms.Button()
        Me.standard_restore_bt = New System.Windows.Forms.Button()
        Me.buttoncolor_bt = New System.Windows.Forms.Label()
        Me.buttoncolor_lb = New System.Windows.Forms.Label()
        Me.textcolor_bt = New System.Windows.Forms.Label()
        Me.textcolor_lb = New System.Windows.Forms.Label()
        Me.inputtextcolor_bt = New System.Windows.Forms.Label()
        Me.inputtextcolor_lb = New System.Windows.Forms.Label()
        Me.inputbackground_bt = New System.Windows.Forms.Label()
        Me.inputbackground_lb = New System.Windows.Forms.Label()
        Me.formhead_color_bt = New System.Windows.Forms.Label()
        Me.formhead_color_lb = New System.Windows.Forms.Label()
        Me.bgcolor_bt = New System.Windows.Forms.Label()
        Me.bgcolor_lb = New System.Windows.Forms.Label()
        Me.designcolor_dialog = New System.Windows.Forms.ColorDialog()
        Me.design_export_dialog = New System.Windows.Forms.SaveFileDialog()
        Me.import_design_dialog = New System.Windows.Forms.OpenFileDialog()
        Me.registfiletypegb.SuspendLayout()
        Me.languagegb.SuspendLayout()
        Me.autostartgb.SuspendLayout()
        Me.masterkey_gb.SuspendLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.form_head.SuspendLayout()
        Me.design_gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'registfiletypegb
        '
        Me.registfiletypegb.Controls.Add(Me.registfiletype)
        Me.registfiletypegb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.registfiletypegb, "registfiletypegb")
        Me.registfiletypegb.Name = "registfiletypegb"
        Me.registfiletypegb.TabStop = False
        '
        'registfiletype
        '
        Me.registfiletype.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.registfiletype.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.registfiletype, "registfiletype")
        Me.registfiletype.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.registfiletype.Name = "registfiletype"
        Me.registfiletype.UseVisualStyleBackColor = False
        '
        'okbt
        '
        Me.okbt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.okbt.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.okbt, "okbt")
        Me.okbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.okbt.Name = "okbt"
        Me.okbt.UseVisualStyleBackColor = False
        '
        'languagegb
        '
        Me.languagegb.Controls.Add(Me.languagecb)
        Me.languagegb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.languagegb, "languagegb")
        Me.languagegb.Name = "languagegb"
        Me.languagegb.TabStop = False
        '
        'languagecb
        '
        Me.languagecb.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.languagecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.languagecb, "languagecb")
        Me.languagecb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.languagecb.Items.AddRange(New Object() {resources.GetString("languagecb.Items"), resources.GetString("languagecb.Items1")})
        Me.languagecb.Name = "languagecb"
        '
        'autostartgb
        '
        Me.autostartgb.Controls.Add(Me.startnormalwincrypt)
        Me.autostartgb.Controls.Add(Me.line3)
        Me.autostartgb.Controls.Add(Me.startminwincryptrb)
        Me.autostartgb.Controls.Add(Me.line2)
        Me.autostartgb.Controls.Add(Me.line)
        Me.autostartgb.Controls.Add(Me.startwincb)
        Me.autostartgb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.autostartgb, "autostartgb")
        Me.autostartgb.Name = "autostartgb"
        Me.autostartgb.TabStop = False
        '
        'startnormalwincrypt
        '
        resources.ApplyResources(Me.startnormalwincrypt, "startnormalwincrypt")
        Me.startnormalwincrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.startnormalwincrypt.Name = "startnormalwincrypt"
        Me.startnormalwincrypt.UseVisualStyleBackColor = True
        '
        'line3
        '
        resources.ApplyResources(Me.line3, "line3")
        Me.line3.BackColor = System.Drawing.Color.Transparent
        Me.line3.Name = "line3"
        '
        'startminwincryptrb
        '
        resources.ApplyResources(Me.startminwincryptrb, "startminwincryptrb")
        Me.startminwincryptrb.Checked = True
        Me.startminwincryptrb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.startminwincryptrb.Name = "startminwincryptrb"
        Me.startminwincryptrb.TabStop = True
        Me.startminwincryptrb.UseVisualStyleBackColor = True
        '
        'line2
        '
        resources.ApplyResources(Me.line2, "line2")
        Me.line2.BackColor = System.Drawing.Color.Transparent
        Me.line2.Name = "line2"
        '
        'line
        '
        resources.ApplyResources(Me.line, "line")
        Me.line.Name = "line"
        '
        'startwincb
        '
        resources.ApplyResources(Me.startwincb, "startwincb")
        Me.startwincb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.startwincb.Name = "startwincb"
        Me.startwincb.UseVisualStyleBackColor = True
        '
        'masterkey_gb
        '
        Me.masterkey_gb.Controls.Add(Me.key_txt)
        Me.masterkey_gb.Controls.Add(Me.key_cb)
        Me.masterkey_gb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.masterkey_gb, "masterkey_gb")
        Me.masterkey_gb.Name = "masterkey_gb"
        Me.masterkey_gb.TabStop = False
        '
        'key_txt
        '
        Me.key_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.key_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.key_txt, "key_txt")
        Me.key_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.key_txt.Name = "key_txt"
        '
        'key_cb
        '
        resources.ApplyResources(Me.key_cb, "key_cb")
        Me.key_cb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.key_cb.Name = "key_cb"
        Me.key_cb.UseVisualStyleBackColor = True
        '
        'wincrypt_icon
        '
        Me.wincrypt_icon.Image = Global.Project_WinCrypt.My.Resources.Resources.wc_icon16
        resources.ApplyResources(Me.wincrypt_icon, "wincrypt_icon")
        Me.wincrypt_icon.Name = "wincrypt_icon"
        Me.wincrypt_icon.TabStop = False
        '
        'wincrypttitle
        '
        resources.ApplyResources(Me.wincrypttitle, "wincrypttitle")
        Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.wincrypttitle.Name = "wincrypttitle"
        '
        'form_head
        '
        Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt, Me.minimize_bt})
        resources.ApplyResources(Me.form_head, "form_head")
        Me.form_head.Name = "form_head"
        '
        'exit_bt
        '
        resources.ApplyResources(Me.exit_bt, "exit_bt")
        Me.exit_bt.ForeColor = System.Drawing.Color.White
        Me.exit_bt.Name = "exit_bt"
        '
        'minimize_bt
        '
        resources.ApplyResources(Me.minimize_bt, "minimize_bt")
        Me.minimize_bt.ForeColor = System.Drawing.Color.White
        Me.minimize_bt.Name = "minimize_bt"
        '
        'design_gb
        '
        Me.design_gb.Controls.Add(Me.use_template_rb2)
        Me.design_gb.Controls.Add(Me.use_template_rb)
        Me.design_gb.Controls.Add(Me.useTemplate_cb)
        Me.design_gb.Controls.Add(Me.design_export)
        Me.design_gb.Controls.Add(Me.design_import)
        Me.design_gb.Controls.Add(Me.standard_restore_bt)
        Me.design_gb.Controls.Add(Me.buttoncolor_bt)
        Me.design_gb.Controls.Add(Me.buttoncolor_lb)
        Me.design_gb.Controls.Add(Me.textcolor_bt)
        Me.design_gb.Controls.Add(Me.textcolor_lb)
        Me.design_gb.Controls.Add(Me.inputtextcolor_bt)
        Me.design_gb.Controls.Add(Me.inputtextcolor_lb)
        Me.design_gb.Controls.Add(Me.inputbackground_bt)
        Me.design_gb.Controls.Add(Me.inputbackground_lb)
        Me.design_gb.Controls.Add(Me.formhead_color_bt)
        Me.design_gb.Controls.Add(Me.formhead_color_lb)
        Me.design_gb.Controls.Add(Me.bgcolor_bt)
        Me.design_gb.Controls.Add(Me.bgcolor_lb)
        Me.design_gb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.design_gb, "design_gb")
        Me.design_gb.Name = "design_gb"
        Me.design_gb.TabStop = False
        '
        'use_template_rb2
        '
        resources.ApplyResources(Me.use_template_rb2, "use_template_rb2")
        Me.use_template_rb2.Name = "use_template_rb2"
        Me.use_template_rb2.TabStop = True
        Me.use_template_rb2.UseVisualStyleBackColor = True
        '
        'use_template_rb
        '
        resources.ApplyResources(Me.use_template_rb, "use_template_rb")
        Me.use_template_rb.Name = "use_template_rb"
        Me.use_template_rb.TabStop = True
        Me.use_template_rb.UseVisualStyleBackColor = True
        '
        'useTemplate_cb
        '
        Me.useTemplate_cb.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.useTemplate_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.useTemplate_cb, "useTemplate_cb")
        Me.useTemplate_cb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.useTemplate_cb.Items.AddRange(New Object() {resources.GetString("useTemplate_cb.Items"), resources.GetString("useTemplate_cb.Items1")})
        Me.useTemplate_cb.Name = "useTemplate_cb"
        '
        'design_export
        '
        Me.design_export.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.design_export.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.design_export, "design_export")
        Me.design_export.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.design_export.Name = "design_export"
        Me.design_export.UseVisualStyleBackColor = False
        '
        'design_import
        '
        Me.design_import.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.design_import.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.design_import, "design_import")
        Me.design_import.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.design_import.Name = "design_import"
        Me.design_import.UseVisualStyleBackColor = False
        '
        'standard_restore_bt
        '
        Me.standard_restore_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.standard_restore_bt.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.standard_restore_bt, "standard_restore_bt")
        Me.standard_restore_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.standard_restore_bt.Name = "standard_restore_bt"
        Me.standard_restore_bt.UseVisualStyleBackColor = False
        '
        'buttoncolor_bt
        '
        Me.buttoncolor_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.buttoncolor_bt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.buttoncolor_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttoncolor_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.buttoncolor_bt, "buttoncolor_bt")
        Me.buttoncolor_bt.Name = "buttoncolor_bt"
        '
        'buttoncolor_lb
        '
        resources.ApplyResources(Me.buttoncolor_lb, "buttoncolor_lb")
        Me.buttoncolor_lb.Name = "buttoncolor_lb"
        '
        'textcolor_bt
        '
        Me.textcolor_bt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.textcolor_bt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textcolor_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.textcolor_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.textcolor_bt, "textcolor_bt")
        Me.textcolor_bt.Name = "textcolor_bt"
        '
        'textcolor_lb
        '
        resources.ApplyResources(Me.textcolor_lb, "textcolor_lb")
        Me.textcolor_lb.Name = "textcolor_lb"
        '
        'inputtextcolor_bt
        '
        Me.inputtextcolor_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.inputtextcolor_bt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputtextcolor_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.inputtextcolor_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.inputtextcolor_bt, "inputtextcolor_bt")
        Me.inputtextcolor_bt.Name = "inputtextcolor_bt"
        '
        'inputtextcolor_lb
        '
        resources.ApplyResources(Me.inputtextcolor_lb, "inputtextcolor_lb")
        Me.inputtextcolor_lb.Name = "inputtextcolor_lb"
        '
        'inputbackground_bt
        '
        Me.inputbackground_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.inputbackground_bt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputbackground_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.inputbackground_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.inputbackground_bt, "inputbackground_bt")
        Me.inputbackground_bt.Name = "inputbackground_bt"
        '
        'inputbackground_lb
        '
        resources.ApplyResources(Me.inputbackground_lb, "inputbackground_lb")
        Me.inputbackground_lb.Name = "inputbackground_lb"
        '
        'formhead_color_bt
        '
        Me.formhead_color_bt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.formhead_color_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.formhead_color_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.formhead_color_bt, "formhead_color_bt")
        Me.formhead_color_bt.Name = "formhead_color_bt"
        '
        'formhead_color_lb
        '
        resources.ApplyResources(Me.formhead_color_lb, "formhead_color_lb")
        Me.formhead_color_lb.Name = "formhead_color_lb"
        '
        'bgcolor_bt
        '
        Me.bgcolor_bt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bgcolor_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bgcolor_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.bgcolor_bt, "bgcolor_bt")
        Me.bgcolor_bt.Name = "bgcolor_bt"
        '
        'bgcolor_lb
        '
        resources.ApplyResources(Me.bgcolor_lb, "bgcolor_lb")
        Me.bgcolor_lb.Name = "bgcolor_lb"
        '
        'designcolor_dialog
        '
        Me.designcolor_dialog.AnyColor = True
        Me.designcolor_dialog.Color = System.Drawing.Color.DimGray
        Me.designcolor_dialog.FullOpen = True
        '
        'design_export_dialog
        '
        Me.design_export_dialog.FileName = "DesignExport.wcDesign"
        resources.ApplyResources(Me.design_export_dialog, "design_export_dialog")
        '
        'import_design_dialog
        '
        Me.import_design_dialog.FileName = "ExportDesign.wcDesign"
        resources.ApplyResources(Me.import_design_dialog, "import_design_dialog")
        '
        'WcSetting
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Controls.Add(Me.design_gb)
        Me.Controls.Add(Me.wincrypt_icon)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.form_head)
        Me.Controls.Add(Me.masterkey_gb)
        Me.Controls.Add(Me.autostartgb)
        Me.Controls.Add(Me.languagegb)
        Me.Controls.Add(Me.okbt)
        Me.Controls.Add(Me.registfiletypegb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "WcSetting"
        Me.registfiletypegb.ResumeLayout(False)
        Me.languagegb.ResumeLayout(False)
        Me.autostartgb.ResumeLayout(False)
        Me.autostartgb.PerformLayout()
        Me.masterkey_gb.ResumeLayout(False)
        Me.masterkey_gb.PerformLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.form_head.ResumeLayout(False)
        Me.form_head.PerformLayout()
        Me.design_gb.ResumeLayout(False)
        Me.design_gb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents line3 As System.Windows.Forms.Label
    Friend WithEvents line2 As System.Windows.Forms.Label
    Friend WithEvents line As System.Windows.Forms.Label
    Friend WithEvents masterkey_gb As System.Windows.Forms.GroupBox
    Friend WithEvents key_txt As System.Windows.Forms.TextBox
    Friend WithEvents key_cb As System.Windows.Forms.CheckBox
    Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents form_head As System.Windows.Forms.MenuStrip
    Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents minimize_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents design_gb As System.Windows.Forms.GroupBox
    Friend WithEvents bgcolor_lb As System.Windows.Forms.Label
    Friend WithEvents designcolor_dialog As System.Windows.Forms.ColorDialog
    Friend WithEvents formhead_color_lb As System.Windows.Forms.Label
    Friend WithEvents bgcolor_bt As System.Windows.Forms.Label
    Friend WithEvents inputbackground_bt As System.Windows.Forms.Label
    Friend WithEvents inputbackground_lb As System.Windows.Forms.Label
    Friend WithEvents formhead_color_bt As System.Windows.Forms.Label
    Friend WithEvents buttoncolor_bt As System.Windows.Forms.Label
    Friend WithEvents buttoncolor_lb As System.Windows.Forms.Label
    Friend WithEvents textcolor_bt As System.Windows.Forms.Label
    Friend WithEvents textcolor_lb As System.Windows.Forms.Label
    Friend WithEvents inputtextcolor_bt As System.Windows.Forms.Label
    Friend WithEvents inputtextcolor_lb As System.Windows.Forms.Label
    Friend WithEvents standard_restore_bt As System.Windows.Forms.Button
    Friend WithEvents design_import As System.Windows.Forms.Button
    Friend WithEvents design_export As System.Windows.Forms.Button
    Friend WithEvents design_export_dialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents import_design_dialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents use_template_rb2 As RadioButton
    Friend WithEvents use_template_rb As RadioButton
    Friend WithEvents useTemplate_cb As ComboBox
End Class
