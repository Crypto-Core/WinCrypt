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
        Me.pgb = New System.Windows.Forms.ProgressBar()
        Me.packet_status_lb = New System.Windows.Forms.Label()
        Me.hash_lb = New System.Windows.Forms.Label()
        Me.packname_lb = New System.Windows.Forms.Label()
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
        'FileTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(427, 105)
        Me.Controls.Add(Me.packname_lb)
        Me.Controls.Add(Me.hash_lb)
        Me.Controls.Add(Me.packet_status_lb)
        Me.Controls.Add(Me.pgb)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
End Class
