<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class connecting_frame
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.acc_veri_img = New System.Windows.Forms.PictureBox()
        Me.con_img = New System.Windows.Forms.PictureBox()
        Me.login_img = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.acc_veri_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.con_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.login_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.acc_veri_img)
        Me.Panel1.Controls.Add(Me.con_img)
        Me.Panel1.Controls.Add(Me.login_img)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Ubuntu Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 492)
        Me.Panel1.TabIndex = 0
        '
        'acc_veri_img
        '
        Me.acc_veri_img.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.acc_veri_img.Image = Global.Eran_Mono.My.Resources.Resources.accept
        Me.acc_veri_img.Location = New System.Drawing.Point(102, 268)
        Me.acc_veri_img.Name = "acc_veri_img"
        Me.acc_veri_img.Size = New System.Drawing.Size(16, 16)
        Me.acc_veri_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.acc_veri_img.TabIndex = 5
        Me.acc_veri_img.TabStop = False
        Me.acc_veri_img.Visible = False
        '
        'con_img
        '
        Me.con_img.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.con_img.Image = Global.Eran_Mono.My.Resources.Resources.accept
        Me.con_img.Location = New System.Drawing.Point(102, 238)
        Me.con_img.Name = "con_img"
        Me.con_img.Size = New System.Drawing.Size(16, 16)
        Me.con_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.con_img.TabIndex = 4
        Me.con_img.TabStop = False
        Me.con_img.Visible = False
        '
        'login_img
        '
        Me.login_img.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.login_img.Image = Global.Eran_Mono.My.Resources.Resources.accept
        Me.login_img.Location = New System.Drawing.Point(102, 209)
        Me.login_img.Name = "login_img"
        Me.login_img.Size = New System.Drawing.Size(16, 16)
        Me.login_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.login_img.TabIndex = 3
        Me.login_img.TabStop = False
        Me.login_img.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "account verification..."
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "login to server..."
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Check login data..."
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(97, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 35)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Connecting..."
        '
        'connecting_frame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 492)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "connecting_frame"
        Me.Text = "connecting_frame"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.acc_veri_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.con_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.login_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents login_img As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents acc_veri_img As System.Windows.Forms.PictureBox
    Friend WithEvents con_img As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
