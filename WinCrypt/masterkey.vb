Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices

Public Class masterkey
    Dim decrypt As New AES
    Dim ReadOnly root As New DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)

    Dim ReadOnly _
        readinikey As _
            New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")

    Dim ReadOnly wmiobj As Object = GetObject("winmgmts://localhost/root/cimv2:Win32_BIOS")
    Dim bios As String
    Dim ReadOnly lang As New language

    Private Sub ok_bt_Click(sender As Object, e As EventArgs) Handles ok_bt.Click
        Try
            Dim encrypt As New AES
            Dim lGuid As GuidAttribute
            lGuid = DirectCast(
                Assembly.GetExecutingAssembly().GetCustomAttributes(
                    GetType(GuidAttribute), False)(0),
                GuidAttribute)
            If readinikey.WertLesen("Key", "master") = encrypt.AESEncrypt(key_txt.Text, bios, lGuid.Value) Then
                Me.Hide()
                startwindow.ShowDialog()
            Else
                If lang.langname = "English" Then
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
        lang.check()
        For Each ver In wmiobj.Instances_
            bios = ver.SerialNumber
            bios.Replace(" ", "")
        Next
    End Sub

    Private Sub exit_bt_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Application.Exit()
    End Sub

    Private Sub form_head_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = MouseButtons.Left) Then
            form_head.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else :
        End If
    End Sub

    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = MouseButtons.Left) Then
            wincrypttitle.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else :
        End If
    End Sub

    Private Sub key_txt_KeyDown(sender As Object, e As KeyEventArgs) Handles key_txt.KeyDown
        If e.KeyCode = Keys.Enter Then
            ok_bt.PerformClick()
        End If
    End Sub
End Class