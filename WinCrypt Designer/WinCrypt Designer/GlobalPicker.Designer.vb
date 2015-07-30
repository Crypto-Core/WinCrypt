<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GlobalPicker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GlobalPicker))
        Me.start_bt = New System.Windows.Forms.Button()
        Me.stop_bt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rgb_red_txt = New System.Windows.Forms.TextBox()
        Me.rgb_green_txt = New System.Windows.Forms.TextBox()
        Me.rgb_blue_txt = New System.Windows.Forms.TextBox()
        Me.color_pb = New System.Windows.Forms.PictureBox()
        Me.GetColor = New System.Windows.Forms.Timer(Me.components)
        Me.SSChk = New System.Windows.Forms.Timer(Me.components)
        Me.add_color_bt = New System.Windows.Forms.Button()
        Me.abort_bt = New System.Windows.Forms.Button()
        CType(Me.color_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'start_bt
        '
        Me.start_bt.Location = New System.Drawing.Point(12, 12)
        Me.start_bt.Name = "start_bt"
        Me.start_bt.Size = New System.Drawing.Size(95, 23)
        Me.start_bt.TabIndex = 0
        Me.start_bt.Text = "Start (F3)"
        Me.start_bt.UseVisualStyleBackColor = True
        '
        'stop_bt
        '
        Me.stop_bt.Location = New System.Drawing.Point(12, 41)
        Me.stop_bt.Name = "stop_bt"
        Me.stop_bt.Size = New System.Drawing.Size(95, 23)
        Me.stop_bt.TabIndex = 1
        Me.stop_bt.Text = "Stop (F4)"
        Me.stop_bt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Red"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Green"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Blue"
        '
        'rgb_red_txt
        '
        Me.rgb_red_txt.Location = New System.Drawing.Point(54, 81)
        Me.rgb_red_txt.Name = "rgb_red_txt"
        Me.rgb_red_txt.ReadOnly = True
        Me.rgb_red_txt.Size = New System.Drawing.Size(53, 20)
        Me.rgb_red_txt.TabIndex = 5
        Me.rgb_red_txt.Text = "0"
        Me.rgb_red_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rgb_green_txt
        '
        Me.rgb_green_txt.Location = New System.Drawing.Point(54, 107)
        Me.rgb_green_txt.Name = "rgb_green_txt"
        Me.rgb_green_txt.ReadOnly = True
        Me.rgb_green_txt.Size = New System.Drawing.Size(53, 20)
        Me.rgb_green_txt.TabIndex = 6
        Me.rgb_green_txt.Text = "0"
        Me.rgb_green_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rgb_blue_txt
        '
        Me.rgb_blue_txt.Location = New System.Drawing.Point(54, 133)
        Me.rgb_blue_txt.Name = "rgb_blue_txt"
        Me.rgb_blue_txt.ReadOnly = True
        Me.rgb_blue_txt.Size = New System.Drawing.Size(53, 20)
        Me.rgb_blue_txt.TabIndex = 7
        Me.rgb_blue_txt.Text = "0"
        Me.rgb_blue_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'color_pb
        '
        Me.color_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.color_pb.Location = New System.Drawing.Point(113, 14)
        Me.color_pb.Name = "color_pb"
        Me.color_pb.Size = New System.Drawing.Size(139, 139)
        Me.color_pb.TabIndex = 8
        Me.color_pb.TabStop = False
        '
        'GetColor
        '
        Me.GetColor.Interval = 1
        '
        'SSChk
        '
        Me.SSChk.Enabled = True
        Me.SSChk.Interval = 10
        '
        'add_color_bt
        '
        Me.add_color_bt.Location = New System.Drawing.Point(15, 159)
        Me.add_color_bt.Name = "add_color_bt"
        Me.add_color_bt.Size = New System.Drawing.Size(75, 23)
        Me.add_color_bt.TabIndex = 9
        Me.add_color_bt.Text = "Add"
        Me.add_color_bt.UseVisualStyleBackColor = True
        '
        'abort_bt
        '
        Me.abort_bt.Location = New System.Drawing.Point(177, 159)
        Me.abort_bt.Name = "abort_bt"
        Me.abort_bt.Size = New System.Drawing.Size(75, 23)
        Me.abort_bt.TabIndex = 10
        Me.abort_bt.Text = "Abort"
        Me.abort_bt.UseVisualStyleBackColor = True
        '
        'GlobalPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 194)
        Me.Controls.Add(Me.abort_bt)
        Me.Controls.Add(Me.add_color_bt)
        Me.Controls.Add(Me.color_pb)
        Me.Controls.Add(Me.rgb_blue_txt)
        Me.Controls.Add(Me.rgb_green_txt)
        Me.Controls.Add(Me.rgb_red_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.stop_bt)
        Me.Controls.Add(Me.start_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "GlobalPicker"
        Me.Text = "GlobalPicker"
        CType(Me.color_pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents start_bt As System.Windows.Forms.Button
    Friend WithEvents stop_bt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rgb_red_txt As System.Windows.Forms.TextBox
    Friend WithEvents rgb_green_txt As System.Windows.Forms.TextBox
    Friend WithEvents rgb_blue_txt As System.Windows.Forms.TextBox
    Friend WithEvents color_pb As System.Windows.Forms.PictureBox
    Friend WithEvents GetColor As System.Windows.Forms.Timer
    Friend WithEvents add_color_bt As System.Windows.Forms.Button
    Friend WithEvents SSChk As System.Windows.Forms.Timer
    Friend WithEvents abort_bt As System.Windows.Forms.Button
End Class
