﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create_account
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
        Me.create_account_panel = New System.Windows.Forms.Panel()
        Me.create_bt = New System.Windows.Forms.Button()
        Me.create_eran_acc_gb = New System.Windows.Forms.GroupBox()
        Me.auth_key_lb = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.eran_adr_lb = New System.Windows.Forms.Label()
        Me.eran_txt = New System.Windows.Forms.TextBox()
        Me.pwd_txt = New System.Windows.Forms.TextBox()
        Me.usr_txt = New System.Windows.Forms.TextBox()
        Me.pwd_lb = New System.Windows.Forms.Label()
        Me.usr_lb = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.create_account_panel.SuspendLayout()
        Me.create_eran_acc_gb.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'create_account_panel
        '
        Me.create_account_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.create_account_panel.Controls.Add(Me.PictureBox1)
        Me.create_account_panel.Controls.Add(Me.create_bt)
        Me.create_account_panel.Controls.Add(Me.create_eran_acc_gb)
        Me.create_account_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.create_account_panel.Location = New System.Drawing.Point(0, 0)
        Me.create_account_panel.Name = "create_account_panel"
        Me.create_account_panel.Size = New System.Drawing.Size(313, 419)
        Me.create_account_panel.TabIndex = 0
        '
        'create_bt
        '
        Me.create_bt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.create_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.create_bt.FlatAppearance.BorderSize = 0
        Me.create_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.create_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.create_bt.Location = New System.Drawing.Point(119, 344)
        Me.create_bt.Name = "create_bt"
        Me.create_bt.Size = New System.Drawing.Size(75, 23)
        Me.create_bt.TabIndex = 0
        Me.create_bt.Text = "Create"
        Me.create_bt.UseVisualStyleBackColor = False
        '
        'create_eran_acc_gb
        '
        Me.create_eran_acc_gb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.create_eran_acc_gb.Controls.Add(Me.auth_key_lb)
        Me.create_eran_acc_gb.Controls.Add(Me.Label5)
        Me.create_eran_acc_gb.Controls.Add(Me.Label4)
        Me.create_eran_acc_gb.Controls.Add(Me.eran_adr_lb)
        Me.create_eran_acc_gb.Controls.Add(Me.eran_txt)
        Me.create_eran_acc_gb.Controls.Add(Me.pwd_txt)
        Me.create_eran_acc_gb.Controls.Add(Me.usr_txt)
        Me.create_eran_acc_gb.Controls.Add(Me.pwd_lb)
        Me.create_eran_acc_gb.Controls.Add(Me.usr_lb)
        Me.create_eran_acc_gb.ForeColor = System.Drawing.Color.White
        Me.create_eran_acc_gb.Location = New System.Drawing.Point(34, 117)
        Me.create_eran_acc_gb.Name = "create_eran_acc_gb"
        Me.create_eran_acc_gb.Size = New System.Drawing.Size(244, 221)
        Me.create_eran_acc_gb.TabIndex = 1
        Me.create_eran_acc_gb.TabStop = False
        Me.create_eran_acc_gb.Text = "Create Eran Account"
        '
        'auth_key_lb
        '
        Me.auth_key_lb.AutoSize = True
        Me.auth_key_lb.Location = New System.Drawing.Point(7, 173)
        Me.auth_key_lb.Name = "auth_key_lb"
        Me.auth_key_lb.Size = New System.Drawing.Size(55, 13)
        Me.auth_key_lb.TabIndex = 8
        Me.auth_key_lb.Text = "Auth. key:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(183, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 12)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "min. 8 chars"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(183, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "min. 6 chars"
        '
        'eran_adr_lb
        '
        Me.eran_adr_lb.AutoSize = True
        Me.eran_adr_lb.Location = New System.Drawing.Point(3, 124)
        Me.eran_adr_lb.Name = "eran_adr_lb"
        Me.eran_adr_lb.Size = New System.Drawing.Size(64, 13)
        Me.eran_adr_lb.TabIndex = 5
        Me.eran_adr_lb.Text = "Eran Adress"
        '
        'eran_txt
        '
        Me.eran_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.eran_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.eran_txt.ForeColor = System.Drawing.Color.Silver
        Me.eran_txt.Location = New System.Drawing.Point(6, 140)
        Me.eran_txt.Name = "eran_txt"
        Me.eran_txt.ReadOnly = True
        Me.eran_txt.Size = New System.Drawing.Size(232, 20)
        Me.eran_txt.TabIndex = 4
        Me.eran_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pwd_txt
        '
        Me.pwd_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pwd_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pwd_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pwd_txt.Location = New System.Drawing.Point(71, 77)
        Me.pwd_txt.Name = "pwd_txt"
        Me.pwd_txt.Size = New System.Drawing.Size(167, 20)
        Me.pwd_txt.TabIndex = 3
        Me.pwd_txt.UseSystemPasswordChar = True
        '
        'usr_txt
        '
        Me.usr_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.usr_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usr_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.usr_txt.Location = New System.Drawing.Point(71, 27)
        Me.usr_txt.Name = "usr_txt"
        Me.usr_txt.Size = New System.Drawing.Size(167, 20)
        Me.usr_txt.TabIndex = 2
        '
        'pwd_lb
        '
        Me.pwd_lb.AutoSize = True
        Me.pwd_lb.Location = New System.Drawing.Point(7, 80)
        Me.pwd_lb.Name = "pwd_lb"
        Me.pwd_lb.Size = New System.Drawing.Size(56, 13)
        Me.pwd_lb.TabIndex = 1
        Me.pwd_lb.Text = "Password:"
        '
        'usr_lb
        '
        Me.usr_lb.AutoSize = True
        Me.usr_lb.Location = New System.Drawing.Point(7, 30)
        Me.usr_lb.Name = "usr_lb"
        Me.usr_lb.Size = New System.Drawing.Size(58, 13)
        Me.usr_lb.TabIndex = 0
        Me.usr_lb.Text = "Username:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Eran.My.Resources.Resources.eran_icon80
        Me.PictureBox1.Location = New System.Drawing.Point(116, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'create_account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 419)
        Me.Controls.Add(Me.create_account_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "create_account"
        Me.Text = "create_account"
        Me.create_account_panel.ResumeLayout(False)
        Me.create_account_panel.PerformLayout()
        Me.create_eran_acc_gb.ResumeLayout(False)
        Me.create_eran_acc_gb.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents create_account_panel As System.Windows.Forms.Panel
    Friend WithEvents create_bt As System.Windows.Forms.Button
    Friend WithEvents create_eran_acc_gb As System.Windows.Forms.GroupBox
    Friend WithEvents eran_adr_lb As System.Windows.Forms.Label
    Friend WithEvents eran_txt As System.Windows.Forms.TextBox
    Friend WithEvents pwd_txt As System.Windows.Forms.TextBox
    Friend WithEvents usr_txt As System.Windows.Forms.TextBox
    Friend WithEvents pwd_lb As System.Windows.Forms.Label
    Friend WithEvents usr_lb As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents auth_key_lb As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
