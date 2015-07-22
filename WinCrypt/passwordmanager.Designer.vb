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
        Me.SuspendLayout()
        '
        'add_bt
        '
        Me.add_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.add_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.add_bt.FlatAppearance.BorderSize = 0
        Me.add_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_bt.Location = New System.Drawing.Point(174, 397)
        Me.add_bt.Name = "add_bt"
        Me.add_bt.Size = New System.Drawing.Size(75, 23)
        Me.add_bt.TabIndex = 1
        Me.add_bt.Text = "Hinzufügen"
        Me.add_bt.UseVisualStyleBackColor = False
        '
        'delete_bt
        '
        Me.delete_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.delete_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.delete_bt.FlatAppearance.BorderSize = 0
        Me.delete_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_bt.Location = New System.Drawing.Point(12, 397)
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
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Location = New System.Drawing.Point(12, 18)
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
        Me.user_txt.Location = New System.Drawing.Point(315, 18)
        Me.user_txt.Name = "user_txt"
        Me.user_txt.Size = New System.Drawing.Size(328, 20)
        Me.user_txt.TabIndex = 4
        '
        'password_txt
        '
        Me.password_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.password_txt.Location = New System.Drawing.Point(315, 44)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(328, 20)
        Me.password_txt.TabIndex = 5
        '
        'source_txt
        '
        Me.source_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.source_txt.Location = New System.Drawing.Point(315, 70)
        Me.source_txt.Name = "source_txt"
        Me.source_txt.Size = New System.Drawing.Size(328, 20)
        Me.source_txt.TabIndex = 6
        '
        'comment_txt
        '
        Me.comment_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comment_txt.Location = New System.Drawing.Point(258, 120)
        Me.comment_txt.Multiline = True
        Me.comment_txt.Name = "comment_txt"
        Me.comment_txt.Size = New System.Drawing.Size(450, 271)
        Me.comment_txt.TabIndex = 7
        '
        'user_lb
        '
        Me.user_lb.AutoSize = True
        Me.user_lb.Location = New System.Drawing.Point(257, 21)
        Me.user_lb.Name = "user_lb"
        Me.user_lb.Size = New System.Drawing.Size(52, 13)
        Me.user_lb.TabIndex = 8
        Me.user_lb.Text = "Benutzer:"
        '
        'password_lb
        '
        Me.password_lb.AutoSize = True
        Me.password_lb.Location = New System.Drawing.Point(257, 47)
        Me.password_lb.Name = "password_lb"
        Me.password_lb.Size = New System.Drawing.Size(53, 13)
        Me.password_lb.TabIndex = 9
        Me.password_lb.Text = "Passwort:"
        '
        'source_lb
        '
        Me.source_lb.AutoSize = True
        Me.source_lb.Location = New System.Drawing.Point(257, 73)
        Me.source_lb.Name = "source_lb"
        Me.source_lb.Size = New System.Drawing.Size(40, 13)
        Me.source_lb.TabIndex = 10
        Me.source_lb.Text = "Quelle:"
        '
        'comment_lb
        '
        Me.comment_lb.AutoSize = True
        Me.comment_lb.Location = New System.Drawing.Point(255, 104)
        Me.comment_lb.Name = "comment_lb"
        Me.comment_lb.Size = New System.Drawing.Size(60, 13)
        Me.comment_lb.TabIndex = 11
        Me.comment_lb.Text = "Kommentar"
        '
        'save_bt
        '
        Me.save_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.save_bt.FlatAppearance.BorderSize = 0
        Me.save_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_bt.Location = New System.Drawing.Point(633, 397)
        Me.save_bt.Name = "save_bt"
        Me.save_bt.Size = New System.Drawing.Size(75, 23)
        Me.save_bt.TabIndex = 12
        Me.save_bt.Text = "Speichern"
        Me.save_bt.UseVisualStyleBackColor = False
        '
        'copy_user_bt
        '
        Me.copy_user_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.copy_user_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.copy_user_bt.FlatAppearance.BorderSize = 0
        Me.copy_user_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copy_user_bt.Location = New System.Drawing.Point(649, 17)
        Me.copy_user_bt.Name = "copy_user_bt"
        Me.copy_user_bt.Size = New System.Drawing.Size(61, 21)
        Me.copy_user_bt.TabIndex = 13
        Me.copy_user_bt.Text = "Kopieren"
        Me.copy_user_bt.UseVisualStyleBackColor = False
        '
        'copy_password_bt
        '
        Me.copy_password_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.copy_password_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.copy_password_bt.FlatAppearance.BorderSize = 0
        Me.copy_password_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copy_password_bt.Location = New System.Drawing.Point(649, 43)
        Me.copy_password_bt.Name = "copy_password_bt"
        Me.copy_password_bt.Size = New System.Drawing.Size(61, 21)
        Me.copy_password_bt.TabIndex = 14
        Me.copy_password_bt.Text = "Kopieren"
        Me.copy_password_bt.UseVisualStyleBackColor = False
        '
        'copy_source_bt
        '
        Me.copy_source_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.copy_source_bt.BackColor = System.Drawing.Color.Gainsboro
        Me.copy_source_bt.FlatAppearance.BorderSize = 0
        Me.copy_source_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copy_source_bt.Location = New System.Drawing.Point(649, 69)
        Me.copy_source_bt.Name = "copy_source_bt"
        Me.copy_source_bt.Size = New System.Drawing.Size(61, 21)
        Me.copy_source_bt.TabIndex = 15
        Me.copy_source_bt.Text = "Kopieren"
        Me.copy_source_bt.UseVisualStyleBackColor = False
        '
        'passwordmanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 432)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(523, 365)
        Me.Name = "passwordmanager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Passwortmanager"
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
End Class
