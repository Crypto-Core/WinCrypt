﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartWindow))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.secureDesktop_bt = New System.Windows.Forms.Button()
        Me.startNormal_bt = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PictureBox1.Image = Global.Eran.My.Resources.Resources.SecureDesktop
        Me.PictureBox1.Location = New System.Drawing.Point(131, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(118, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Want to Eran start in Secure Desktop?"
        '
        'secureDesktop_bt
        '
        Me.secureDesktop_bt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.secureDesktop_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.secureDesktop_bt.FlatAppearance.BorderSize = 0
        Me.secureDesktop_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.secureDesktop_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.secureDesktop_bt.Location = New System.Drawing.Point(262, 376)
        Me.secureDesktop_bt.Name = "secureDesktop_bt"
        Me.secureDesktop_bt.Size = New System.Drawing.Size(150, 23)
        Me.secureDesktop_bt.TabIndex = 3
        Me.secureDesktop_bt.Text = "Start in Secure Desktop"
        Me.secureDesktop_bt.UseVisualStyleBackColor = False
        '
        'startNormal_bt
        '
        Me.startNormal_bt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.startNormal_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.startNormal_bt.FlatAppearance.BorderSize = 0
        Me.startNormal_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startNormal_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.startNormal_bt.Location = New System.Drawing.Point(106, 376)
        Me.startNormal_bt.Name = "startNormal_bt"
        Me.startNormal_bt.Size = New System.Drawing.Size(150, 23)
        Me.startNormal_bt.TabIndex = 4
        Me.startNormal_bt.Text = "Start normal"
        Me.startNormal_bt.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(477, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "In Secure Desktop Every feature such as screenshots or Keylogger is disabled." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Th" & _
            "is protection is especially against trojans and spyware."
        '
        'StartWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(518, 411)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.startNormal_bt)
        Me.Controls.Add(Me.secureDesktop_bt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "StartWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eran Start Window"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents secureDesktop_bt As System.Windows.Forms.Button
    Friend WithEvents startNormal_bt As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
