Public Class masterkey
    Dim decrypt As New AES
    Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
    Dim readinikey As New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")
    Dim wmiobj = GetObject("winmgmts://localhost/root/cimv2:Win32_BIOS")
    Dim bios As String
    Dim lang As New language
    Private Sub ok_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_bt.Click
        Try
            Dim encrypt As New AES
            Dim lGuid As System.Runtime.InteropServices.GuidAttribute
            lGuid = DirectCast(System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes( _
                      GetType(System.Runtime.InteropServices.GuidAttribute), False)(0),  _
                      System.Runtime.InteropServices.GuidAttribute)
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

    Private Sub masterkey_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub abort_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abort_bt.Click
        Application.Exit()
    End Sub

    Private Sub masterkey_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lang.check()
        For Each ver In wmiobj.Instances_
            bios = ver.SerialNumber
            bios.Replace(" ", "")
        Next
    End Sub
End Class