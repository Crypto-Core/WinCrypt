<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class passwordmanager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(passwordmanager))
        Me.add_bt = New System.Windows.Forms.Button()
        Me.delete_bt = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.user_txt = New System.Windows.Forms.TextBox()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.source_txt = New System.Windows.Forms.TextBox()
        Me.comment_txt = New System.Windows.Forms.TextBox()
        Me.user_lb = New System.Windows.Forms.Label()
        Me.password_lb = New System.Windows.Forms.Label()
        Me.source_lb = New System.Windows.Forms.Label()
        Me.comment_lb = New System.Windows.Forms.Label()
        Me.save_bt = New System.Windows.Forms.Button()
        Me.copy_user_bt = New System.Windows.Forms.Button()
        Me.copy_password_bt = New System.Windows.Forms.Button()
        Me.copy_source_bt = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'add_bt
        '
        Me.add_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.add_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.add_bt.FlatAppearance.BorderSize = 0
        Me.add_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.add_bt.Location = New System.Drawing.Point(174, 422)
        Me.add_bt.Name = "add_bt"
        Me.add_bt.Size = New System.Drawing.Size(75, 23)
        Me.add_bt.TabIndex = 1
        Me.add_bt.Text = "Hinzufügen"
        Me.add_bt.UseVisualStyleBackColor = False
        '
        'delete_bt
        '
        Me.delete_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.delete_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.delete_bt.FlatAppearance.BorderSize = 0
        Me.delete_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.delete_bt.Location = New System.Drawing.Point(12, 422)
        Me.delete_bt.Name = "delete_bt"
        Me.delete_bt.Size = New System.Drawing.Size(75, 23)
        Me.delete_bt.TabIndex = 2
        Me.delete_bt.Text = "Löschen"
        Me.delete_bt.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ListView1.Location = New System.Drawing.Point(12, 43)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(237, 373)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Benutzer"
        Me.ColumnHeader1.Width = 114
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Quelle"
        Me.ColumnHeader2.Width = 112
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Index"
        '
        'user_txt
        '
        Me.user_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.user_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.user_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.user_txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.user_txt.Location = New System.Drawing.Point(315, 47)
        Me.user_txt.Name = "user_txt"
        Me.user_txt.Size = New System.Drawing.Size(328, 20)
        Me.user_txt.TabIndex = 4
        '
        'password_txt
        '
        Me.password_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.password_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.password_txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.password_txt.Location = New System.Drawing.Point(315, 73)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(328, 20)
        Me.password_txt.TabIndex = 5
        '
        'source_txt
        '
        Me.source_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.source_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.source_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.source_txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.source_txt.Location = New System.Drawing.Point(315, 99)
        Me.source_txt.Name = "source_txt"
        Me.source_txt.Size = New System.Drawing.Size(328, 20)
        Me.source_txt.TabIndex = 6
        '
        'comment_txt
        '
        Me.comment_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comment_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.comment_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.comment_txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.comment_txt.Location = New System.Drawing.Point(258, 149)
        Me.comment_txt.Multiline = True
        Me.comment_txt.Name = "comment_txt"
        Me.comment_txt.Size = New System.Drawing.Size(450, 267)
        Me.comment_txt.TabIndex = 7
        '
        'user_lb
        '
        Me.user_lb.AutoSize = True
        Me.user_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.user_lb.Location = New System.Drawing.Point(257, 50)
        Me.user_lb.Name = "user_lb"
        Me.user_lb.Size = New System.Drawing.Size(52, 13)
        Me.user_lb.TabIndex = 8
        Me.user_lb.Text = "Benutzer:"
        '
        'password_lb
        '
        Me.password_lb.AutoSize = True
        Me.password_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.password_lb.Location = New System.Drawing.Point(257, 76)
        Me.password_lb.Name = "password_lb"
        Me.password_lb.Size = New System.Drawing.Size(53, 13)
        Me.password_lb.TabIndex = 9
        Me.password_lb.Text = "Passwort:"
        '
        'source_lb
        '
        Me.source_lb.AutoSize = True
        Me.source_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.source_lb.Location = New System.Drawing.Point(257, 102)
        Me.source_lb.Name = "source_lb"
        Me.source_lb.Size = New System.Drawing.Size(40, 13)
        Me.source_lb.TabIndex = 10
        Me.source_lb.Text = "Quelle:"
        '
        'comment_lb
        '
        Me.comment_lb.AutoSize = True
        Me.comment_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.comment_lb.Location = New System.Drawing.Point(255, 133)
        Me.comment_lb.Name = "comment_lb"
        Me.comment_lb.Size = New System.Drawing.Size(60, 13)
        Me.comment_lb.TabIndex = 11
        Me.comment_lb.Text = "Kommentar"
        '
        'save_bt
        '
        Me.save_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.save_bt.FlatAppearance.BorderSize = 0
        Me.save_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.save_bt.Location = New System.Drawing.Point(633, 422)
        Me.save_bt.Name = "save_bt"
        Me.save_bt.Size = New System.Drawing.Size(75, 23)
        Me.save_bt.TabIndex = 12
        Me.save_bt.Text = "Speichern"
        Me.save_bt.UseVisualStyleBackColor = False
        '
        'copy_user_bt
        '
        Me.copy_user_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.copy_user_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.copy_user_bt.FlatAppearance.BorderSize = 0
        Me.copy_user_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copy_user_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.copy_user_bt.Location = New System.Drawing.Point(649, 46)
        Me.copy_user_bt.Name = "copy_user_bt"
        Me.copy_user_bt.Size = New System.Drawing.Size(61, 21)
        Me.copy_user_bt.TabIndex = 13
        Me.copy_user_bt.Text = "Kopieren"
        Me.copy_user_bt.UseVisualStyleBackColor = False
        '
        'copy_password_bt
        '
        Me.copy_password_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.copy_password_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.copy_password_bt.FlatAppearance.BorderSize = 0
        Me.copy_password_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copy_password_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.copy_password_bt.Location = New System.Drawing.Point(649, 72)
        Me.copy_password_bt.Name = "copy_password_bt"
        Me.copy_password_bt.Size = New System.Drawing.Size(61, 21)
        Me.copy_password_bt.TabIndex = 14
        Me.copy_password_bt.Text = "Kopieren"
        Me.copy_password_bt.UseVisualStyleBackColor = False
        '
        'copy_source_bt
        '
        Me.copy_source_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.copy_source_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.copy_source_bt.FlatAppearance.BorderSize = 0
        Me.copy_source_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copy_source_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.copy_source_bt.Location = New System.Drawing.Point(649, 98)
        Me.copy_source_bt.Name = "copy_source_bt"
        Me.copy_source_bt.Size = New System.Drawing.Size(61, 21)
        Me.copy_source_bt.TabIndex = 15
        Me.copy_source_bt.Text = "Kopieren"
        Me.copy_source_bt.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(720, 27)
        Me.MenuStrip1.TabIndex = 16
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
        Me.wincrypttitle.Size = New System.Drawing.Size(117, 16)
        Me.wincrypttitle.TabIndex = 17
        Me.wincrypttitle.Text = "Passwortmanager"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_WinCrypt.My.Resources.Resources.icon
        Me.PictureBox1.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'passwordmanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(720, 457)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.copy_source_bt)
        Me.Controls.Add(Me.copy_password_bt)
        Me.Controls.Add(Me.copy_user_bt)
        Me.Controls.Add(Me.save_bt)
        Me.Controls.Add(Me.comment_lb)
        Me.Controls.Add(Me.source_lb)
        Me.Controls.Add(Me.password_lb)
        Me.Controls.Add(Me.user_lb)
        Me.Controls.Add(Me.comment_txt)
        Me.Controls.Add(Me.source_txt)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.user_txt)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.delete_bt)
        Me.Controls.Add(Me.add_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(523, 365)
        Me.Name = "passwordmanager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Passwortmanager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents add_bt As System.Windows.Forms.Button
    Friend WithEvents delete_bt As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents user_txt As System.Windows.Forms.TextBox
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
    Friend WithEvents source_txt As System.Windows.Forms.TextBox
    Friend WithEvents comment_txt As System.Windows.Forms.TextBox
    Friend WithEvents user_lb As System.Windows.Forms.Label
    Friend WithEvents password_lb As System.Windows.Forms.Label
    Friend WithEvents source_lb As System.Windows.Forms.Label
    Friend WithEvents comment_lb As System.Windows.Forms.Label
    Friend WithEvents save_bt As System.Windows.Forms.Button
    Friend WithEvents copy_user_bt As System.Windows.Forms.Button
    Friend WithEvents copy_password_bt As System.Windows.Forms.Button
    Friend WithEvents copy_source_bt As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
