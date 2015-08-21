Option Strict On
Public Class about
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ok_bt.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loadcolor As New designcolor
        loadcolor.color()
        copyright_lb.Text = "Copyright © " & DateTime.Today.Year & " Harry Machura"
        product_lb.Text = "WinCrypt " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        version_lb.Text = "(Version " & My.Application.Info.Version.ToString & ")"
        wincrypt_logo.Select()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        Process.Start("https://wincrypt.org/lizenz/")
    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Me.Close()
    End Sub

    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = MouseButtons.Left) Then
            wincrypttitle.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else :
        End If
    End Sub

    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = MouseButtons.Left) Then
            form_head.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else :
        End If
    End Sub
End Class