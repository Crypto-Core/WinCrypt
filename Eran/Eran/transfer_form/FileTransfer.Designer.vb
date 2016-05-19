<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileTransfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileTransfer))
        Me.pgb = New System.Windows.Forms.ProgressBar()
        Me.packet_status_lb = New System.Windows.Forms.Label()
        Me.hash_lb = New System.Windows.Forms.Label()
        Me.packname_lb = New System.Windows.Forms.Label()
        Me.brocken_lb = New System.Windows.Forms.Label()
        Me.ok_bt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pgb
        '
        Me.pgb.Location = New System.Drawing.Point(12, 12)
        Me.pgb.Name = "pgb"
        Me.pgb.Size = New System.Drawing.Size(403, 23)
        Me.pgb.TabIndex = 0
        '
        'packet_status_lb
        '
        Me.packet_status_lb.AutoSize = True
        Me.packet_status_lb.Location = New System.Drawing.Point(9, 38)
        Me.packet_status_lb.Name = "packet_status_lb"
        Me.packet_status_lb.Size = New System.Drawing.Size(72, 13)
        Me.packet_status_lb.TabIndex = 1
        Me.packet_status_lb.Text = "Packet 0 of 0"
        '
        'hash_lb
        '
        Me.hash_lb.AutoSize = True
        Me.hash_lb.Location = New System.Drawing.Point(12, 66)
        Me.hash_lb.Name = "hash_lb"
        Me.hash_lb.Size = New System.Drawing.Size(36, 13)
        Me.hash_lb.TabIndex = 2
        Me.hash_lb.Text = "Hash:"
        '
        'packname_lb
        '
        Me.packname_lb.AutoSize = True
        Me.packname_lb.Location = New System.Drawing.Point(12, 84)
        Me.packname_lb.Name = "packname_lb"
        Me.packname_lb.Size = New System.Drawing.Size(71, 13)
        Me.packname_lb.TabIndex = 3
        Me.packname_lb.Text = "Packetname:"
        '
        'brocken_lb
        '
        Me.brocken_lb.AutoSize = True
        Me.brocken_lb.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brocken_lb.ForeColor = System.Drawing.Color.Red
        Me.brocken_lb.Location = New System.Drawing.Point(135, 40)
        Me.brocken_lb.Name = "brocken_lb"
        Me.brocken_lb.Size = New System.Drawing.Size(157, 25)
        Me.brocken_lb.TabIndex = 4
        Me.brocken_lb.Text = "Transfer brocken!"
        Me.brocken_lb.Visible = False
        '
        'ok_bt
        '
        Me.ok_bt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ok_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ok_bt.FlatAppearance.BorderSize = 0
        Me.ok_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ok_bt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ok_bt.Location = New System.Drawing.Point(340, 79)
        Me.ok_bt.Name = "ok_bt"
        Me.ok_bt.Size = New System.Drawing.Size(75, 23)
        Me.ok_bt.TabIndex = 5
        Me.ok_bt.Text = "OK"
        Me.ok_bt.UseVisualStyleBackColor = False
        Me.ok_bt.Visible = False
        '
        'FileTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(427, 105)
        Me.Controls.Add(Me.ok_bt)
        Me.Controls.Add(Me.brocken_lb)
        Me.Controls.Add(Me.packname_lb)
        Me.Controls.Add(Me.hash_lb)
        Me.Controls.Add(Me.packet_status_lb)
        Me.Controls.Add(Me.pgb)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FileTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incomming file"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pgb As System.Windows.Forms.ProgressBar
    Friend WithEvents packet_status_lb As System.Windows.Forms.Label
    Friend WithEvents hash_lb As System.Windows.Forms.Label
    Friend WithEvents packname_lb As System.Windows.Forms.Label
    Friend WithEvents brocken_lb As System.Windows.Forms.Label
    Friend WithEvents ok_bt As System.Windows.Forms.Button
End Class
