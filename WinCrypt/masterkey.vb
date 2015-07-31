Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Project_WinCrypt.classes

Public Class Masterkey
    Dim _decrypt As New AES
    ReadOnly _root As New DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)

    ReadOnly _
        _readinikey As _
            New INIDatei(_root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")

    ReadOnly _wmiobj As Object = GetObject("winmgmts://localhost/root/cimv2:Win32_BIOS")
    Dim _bios As String
    ReadOnly _lang As New language

    Private Sub ok_bt_Click(sender As Object, e As EventArgs) Handles ok_bt.Click
        Try
            Dim encrypt As New AES
            Dim lGuid As GuidAttribute
            lGuid = DirectCast(
                Assembly.GetExecutingAssembly().GetCustomAttributes(
                    GetType(GuidAttribute), False)(0), 
                GuidAttribute)
            If _readinikey.WertLesen("Key", "master") = encrypt.AESEncrypt(key_txt.Text, _bios, lGuid.Value) Then
                Hide()
                Startwindow.ShowDialog()
            Else
                If _lang.langname = "English" Then
                    MsgBox("wrong masterkey!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Falscher Masterkey!", MsgBoxStyle.Critical)
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
            _bios.Replace(" ", "")
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
End Class