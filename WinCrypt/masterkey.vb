Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Project_WinCrypt.classes

Public Class Masterkey
    Private _decrypt As New AES
    ReadOnly _
        _readinikey As _
            New IniDatei(String.Format("{0}\WinCrypt\config.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))

    ReadOnly _wmiobj As Object = GetObject("winmgmts://localhost/root/cimv2:Win32_BIOS")
    Private _bios As String
    ReadOnly _lang As New language

    Private Sub ok_bt_Click(sender As Object, e As EventArgs) Handles ok_bt.Click
        Try
            Dim encrypt As New AES
            Dim lGuid As GuidAttribute
            lGuid = DirectCast(
                Assembly.GetExecutingAssembly().GetCustomAttributes(
                    GetType(GuidAttribute), False)(0), 
                GuidAttribute)
            If _readinikey.worthreading("Key", "master") = encrypt.AESEncrypt(key_txt.Text, _bios, lGuid.Value) Then
                Hide()
                Startwindow.ShowDialog()
            Else
                If _lang.langname = "English" Then
                    MessageBox.Show("wrong masterkey!", "masterkey", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Falscher Masterkey", "Masterkey", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub masterkey_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub abort_bt_Click(sender As Object, e As EventArgs) Handles abort_bt.Click
        Application.Exit()
    End Sub

    Private Sub masterkey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loadcolor As New designcolor
        loadcolor.color()
        _lang.check()
        For Each ver In _wmiobj.Instances_
            _bios = ver.SerialNumber
            _bios.Replace(" ", Nothing)
        Next
    End Sub

    Private Sub exit_bt_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Application.Exit()
    End Sub

    Private Sub form_head_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = MouseButtons.Left) Then
            form_head.Capture = False
            WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else
        End If
    End Sub

    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = MouseButtons.Left) Then
            wincrypttitle.Capture = False
            WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else
        End If
    End Sub

    Private Sub key_txt_KeyDown(sender As Object, e As KeyEventArgs) Handles key_txt.KeyDown
        If e.KeyCode = Keys.Enter Then
            ok_bt.PerformClick()
        End If
    End Sub

    Private Sub form_head_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles form_head.ItemClicked

    End Sub
End Class