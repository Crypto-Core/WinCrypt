<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class connect_frame
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.connect_lb = New System.Windows.Forms.Label()
        Me.wait_tm = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.connect_lb)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 444)
        Me.Panel1.TabIndex = 0
        '
        'connect_lb
        '
        Me.connect_lb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.connect_lb.AutoSize = True
        Me.connect_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_lb.ForeColor = System.Drawing.Color.White
        Me.connect_lb.Location = New System.Drawing.Point(80, 210)
        Me.connect_lb.Name = "connect_lb"
        Me.connect_lb.Size = New System.Drawing.Size(116, 25)
        Me.connect_lb.TabIndex = 0
        Me.connect_lb.Text = "Connect...."
        '
        'wait_tm
        '
        Me.wait_tm.Interval = 200
        '
        'connect_frame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 444)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "connect_frame"
        Me.Text = "connect_frame"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents connect_lb As System.Windows.Forms.Label
    Friend WithEvents wait_tm As System.Windows.Forms.Timer
End Class
