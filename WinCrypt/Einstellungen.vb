Public Class Einstellungen
    Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
    Dim iniwrite As New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")
    Dim ini As New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")
    Dim lang As New language
    Dim wmiobj = GetObject("winmgmts://localhost/root/cimv2:Win32_BIOS")
    Dim bios As String
    Private Sub registfiletype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registfiletype.Click
        Try
            Process.Start(My.Application.Info.DirectoryPath & "\regist.exe")
        Catch ex As Exception
            MsgBox(ErrorToString, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub okbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okbt.Click
        Dim lang As New language
        If languagecb.Text = "Deutsch" Then
            iniwrite.WertSchreiben("Info", "Lang", "German")
        End If
        If languagecb.Text = "English" Then
            iniwrite.WertSchreiben("Info", "Lang", "English")
        Else

        End If
        Dim keyaes As New AES
        Dim lGuid As System.Runtime.InteropServices.GuidAttribute
        lGuid = DirectCast(System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes( _
                  GetType(System.Runtime.InteropServices.GuidAttribute), False)(0),  _
                  System.Runtime.InteropServices.GuidAttribute)
        If key_cb.Checked = True Then
            iniwrite.WertSchreiben("Key", "master", keyaes.AESEncrypt(key_txt.Text, bios, lGuid.Value))
            My.Settings.Masterkey = True
        Else
            My.Settings.Masterkey = False
        End If
        Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
        Dim i As New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")
        startwindow.langname = i.WertLesen("Info", "Lang")
        lang.check()
        Me.Close()
    End Sub
    Private Function MakeShortcut(ByVal File As String, ByVal ShortcutFolder As String, ByVal Name As String, ByVal WorkDirectory As String)
        Dim WshShell As Object = CreateObject("WScript.Shell")
        Dim NewShortcut As Object = WshShell.CreateShortcut(ShortcutFolder & "\" & Name & ".lnk")
        NewShortcut.TargetPath = File
        If startminwincryptrb.Checked = True Then
            NewShortcut.WindowStyle = 7
        End If
        If startnormalwincrypt.Checked = True Then
            NewShortcut.WindowStyle = 1
        End If
        NewShortcut.IconLocation = File & ",0"
        NewShortcut.WorkingDirectory = WorkDirectory
        NewShortcut.Save()
    End Function
    Private Sub Einstellungen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lang.check()
        For Each ver In wmiobj.Instances_
            bios = ver.SerialNumber
            bios.Replace(" ", "")
        Next
        If My.Settings.Masterkey = True Then
            key_cb.Checked = True
        Else
            key_cb.Checked = False
        End If
        If ini.WertLesen("Info", "Shortcut") = "minimized" Then
            startminwincryptrb.Checked = True
        Else

        End If
        If ini.WertLesen("Info", "Shortcut") = "normal" Then
            startnormalwincrypt.Checked = True
        Else

        End If
        If My.Computer.FileSystem.FileExists("C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\WinCrypt.lnk") Then
            startwincb.Checked = True
        Else
            startwincb.Checked = False

        End If
        If iniwrite.WertLesen("Info", "Lang") = "English" Then
            languagecb.Text = "English"
        End If
        If iniwrite.WertLesen("Info", "Lang") = "German" Then
            languagecb.Text = "Deutsch"
        End If
    End Sub

    Private Sub startwincb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startwincb.CheckedChanged
        If startwincb.Checked = True Then
            MakeShortcut(My.Application.Info.DirectoryPath & "\Project WinCrypt.exe", "C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup", "WinCrypt", My.Application.Info.DirectoryPath)
        Else
            My.Computer.FileSystem.DeleteFile("C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\WinCrypt.lnk")
        End If
    End Sub

    Private Sub startminwincryptrb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startminwincryptrb.CheckedChanged
        If startminwincryptrb.Checked = True Then
            If startwincb.Checked = True Then
                MakeShortcut(My.Application.Info.DirectoryPath & "\Project WinCrypt.exe", "C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup", "WinCrypt", My.Application.Info.DirectoryPath)
                ini.WertSchreiben("Info", "Shortcut", "minimized")
            Else

            End If
        Else

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startnormalwincrypt.CheckedChanged
        If startnormalwincrypt.Checked = True Then
            If startwincb.Checked = True Then
                MakeShortcut(My.Application.Info.DirectoryPath & "\Project WinCrypt.exe", "C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup", "WinCrypt", My.Application.Info.DirectoryPath)
                ini.WertSchreiben("Info", "Shortcut", "normal")
            Else

            End If
        End If
    End Sub

    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles show_bt.MouseDown
        key_txt.UseSystemPasswordChar = False
    End Sub

    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles show_bt.MouseUp
        key_txt.UseSystemPasswordChar = True
    End Sub

    Private Sub key_cb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_cb.CheckedChanged
        If key_cb.Checked = True Then
            key_txt.Enabled = True
            key_lb.Enabled = True
            show_bt.Enabled = True
            My.Settings.Masterkey = True
        Else
            key_txt.Enabled = False
            key_lb.Enabled = False
            show_bt.Enabled = False
            My.Settings.Masterkey = False
        End If
        Dim readkey As New AES
        Dim lGuid As System.Runtime.InteropServices.GuidAttribute
        lGuid = DirectCast(System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes( _
                  GetType(System.Runtime.InteropServices.GuidAttribute), False)(0),  _
                  System.Runtime.InteropServices.GuidAttribute)
        If My.Settings.Masterkey = True Then
            key_txt.Text = readkey.AESDecrypt(iniwrite.WertLesen("Key", "master"), bios, lGuid.Value)
        Else

        End If
    End Sub
End Class