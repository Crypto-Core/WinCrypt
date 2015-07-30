Namespace tools.safedelete
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class del_report
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(del_report))
            Me.form_head = New System.Windows.Forms.MenuStrip()
            Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
            Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
            Me.report_txt = New System.Windows.Forms.RichTextBox()
            Me.ok_bt = New System.Windows.Forms.Button()
            Me.saveas_bt = New System.Windows.Forms.Button()
            Me.save_error_dialog = New System.Windows.Forms.SaveFileDialog()
            Me.wincrypttitle = New System.Windows.Forms.Label()
            Me.form_head.SuspendLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'form_head
            '
            Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt})
            Me.form_head.Location = New System.Drawing.Point(0, 0)
            Me.form_head.Name = "form_head"
            Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.form_head.Size = New System.Drawing.Size(516, 24)
            Me.form_head.TabIndex = 17
            Me.form_head.Text = "WinCrypt"
            '
            'exit_bt
            '
            Me.exit_bt.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.exit_bt.ForeColor = System.Drawing.Color.White
            Me.exit_bt.Name = "exit_bt"
            Me.exit_bt.Size = New System.Drawing.Size(29, 20)
            Me.exit_bt.Text = "X"
            '
            'wincrypt_icon
            '
            Me.wincrypt_icon.BackColor = System.Drawing.Color.Transparent
            Me.wincrypt_icon.Image = Global.Project_WinCrypt.My.Resources.Resources.wc_icon16
            Me.wincrypt_icon.Location = New System.Drawing.Point(9, 6)
            Me.wincrypt_icon.Name = "wincrypt_icon"
            Me.wincrypt_icon.Size = New System.Drawing.Size(16, 16)
            Me.wincrypt_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.wincrypt_icon.TabIndex = 19
            Me.wincrypt_icon.TabStop = False
            '
            'report_txt
            '
            Me.report_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.report_txt.Location = New System.Drawing.Point(12, 30)
            Me.report_txt.Name = "report_txt"
            Me.report_txt.Size = New System.Drawing.Size(492, 232)
            Me.report_txt.TabIndex = 20
            Me.report_txt.Text = ""
            '
            'ok_bt
            '
            Me.ok_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ok_bt.FlatAppearance.BorderSize = 0
            Me.ok_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ok_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.ok_bt.Location = New System.Drawing.Point(221, 268)
            Me.ok_bt.Name = "ok_bt"
            Me.ok_bt.Size = New System.Drawing.Size(75, 23)
            Me.ok_bt.TabIndex = 21
            Me.ok_bt.Text = "OK"
            Me.ok_bt.UseVisualStyleBackColor = False
            '
            'saveas_bt
            '
            Me.saveas_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.saveas_bt.FlatAppearance.BorderSize = 0
            Me.saveas_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.saveas_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.saveas_bt.Location = New System.Drawing.Point(397, 268)
            Me.saveas_bt.Name = "saveas_bt"
            Me.saveas_bt.Size = New System.Drawing.Size(107, 23)
            Me.saveas_bt.TabIndex = 22
            Me.saveas_bt.Text = "Speichern unter..."
            Me.saveas_bt.UseVisualStyleBackColor = False
            '
            'save_error_dialog
            '
            Me.save_error_dialog.FileName = "report.rtf"
            Me.save_error_dialog.Filter = "RTF-File|*.rtf"
            '
            'wincrypttitle
            '
            Me.wincrypttitle.AutoSize = True
            Me.wincrypttitle.BackColor = System.Drawing.Color.Transparent
            Me.wincrypttitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.wincrypttitle.Location = New System.Drawing.Point(31, 6)
            Me.wincrypttitle.Name = "wincrypttitle"
            Me.wincrypttitle.Size = New System.Drawing.Size(191, 17)
            Me.wincrypttitle.TabIndex = 23
            Me.wincrypttitle.Text = "Dateien sicher löschen - Report"
            '
            'del_report
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(516, 303)
            Me.Controls.Add(Me.wincrypttitle)
            Me.Controls.Add(Me.saveas_bt)
            Me.Controls.Add(Me.ok_bt)
            Me.Controls.Add(Me.report_txt)
            Me.Controls.Add(Me.wincrypt_icon)
            Me.Controls.Add(Me.form_head)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "del_report"
            Me.Text = "Dateien sicher löschen - Report"
            Me.form_head.ResumeLayout(False)
            Me.form_head.PerformLayout()
            CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents form_head As System.Windows.Forms.MenuStrip
        Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
        Friend WithEvents report_txt As System.Windows.Forms.RichTextBox
        Friend WithEvents ok_bt As System.Windows.Forms.Button
        Friend WithEvents saveas_bt As System.Windows.Forms.Button
        Friend WithEvents save_error_dialog As System.Windows.Forms.SaveFileDialog
        Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    End Class
End Namespace