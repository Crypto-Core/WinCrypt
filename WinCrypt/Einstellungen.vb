Public Class Einstellungen
    Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory) ' Der aktuelle Pfad der Project WinCrypt.exe
    Dim iniwrite As New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini") ' Die config.ini wird eingelesen
    Dim ini As New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini") ' Die config.ini wird eingelesen
    Dim lang As New language ' Die Sprache wird deklariert
    Dim wmiobj = GetObject("winmgmts://localhost/root/cimv2:Win32_BIOS") ' Die Bios ID wird deklariert
    Dim bios As String
    Private Sub registfiletype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registfiletype.Click
        Try
            Process.Start(My.Application.Info.DirectoryPath & "\regist.exe") ' regist.exe wird ausgeführt und die Dateitypen .wc und .wcp werden regestriert
        Catch ex As Exception
            MsgBox(ErrorToString, MsgBoxStyle.Information) ' Falls ein Fehler auftritt wird dieser angezeigt
        End Try
    End Sub

    Private Sub okbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okbt.Click
        If languagecb.Text = "Deutsch" Then ' Es wird überprüft ob die Sprache Deutsch ausgewählt wurde
            iniwrite.WertSchreiben("Info", "Lang", "German") ' Wenn ja wird diese in der config.ini eingetragen
        End If
        If languagecb.Text = "English" Then ' Es wird überprüft ob die Sprache English ausgewählt wurde
            iniwrite.WertSchreiben("Info", "Lang", "English") ' Wenn ja denn wird diese in der config.ini eingetragen
        End If
        Dim keyaes As New AES ' AES wird deklariert
        Dim lGuid As System.Runtime.InteropServices.GuidAttribute ' Die WinCrypt GUID wird deklariert
        lGuid = DirectCast(System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes( _
                  GetType(System.Runtime.InteropServices.GuidAttribute), False)(0),  _
                  System.Runtime.InteropServices.GuidAttribute)

        If key_cb.Checked = True Then ' Es wird überprüft ob der Masterkey aktiviert wurde
            ' Wenn ja wird dieses Passwort in AES verschlüsselt und in der config.ini eingetragen
            iniwrite.WertSchreiben("Key", "master", keyaes.AESEncrypt(key_txt.Text, bios, lGuid.Value))
            My.Settings.Masterkey = True ' In den WinCrypt Einstellungen wird der wert Masterkey auf true gesetzt
        Else
            ' Wenn der Masterkey nicht aktiviert wurde wird der Masterkey in den Einstellungen auf false gesetzt
            My.Settings.Masterkey = False
        End If

        ' Das Hauptlaufwerk wird deklariert um die config.ini zu lesen
        Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
        Dim i As New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")

        startwindow.langname = i.WertLesen("Info", "Lang") ' Die gewählte Sprache wird in dem String startwindow.langname gesetzt
        lang.check() 'Es wird die gespeicherte Sprache ausgelesen und durchgeführt
        Me.Close() ' Das Fenster wird geschlossen
    End Sub
    Private Function MakeShortcut(ByVal File As String, ByVal ShortcutFolder As String, ByVal Name As String, ByVal WorkDirectory As String)
        Dim WshShell As Object = CreateObject("WScript.Shell") ' Es wird eine Verknüpfung deklariert
        Dim NewShortcut As Object = WshShell.CreateShortcut(ShortcutFolder & "\" & Name & ".lnk") ' Es wird eine neue Verknüpfung erstellt
        NewShortcut.TargetPath = File 'Es wird das Schlüsselwort ausgelesen und gesetzt

        ' Wenn WinCrypt minimiert starten gewählt wurde werden diese Einstellungen in den Verknüpfungseigenschaften gesetzt
        If startminwincryptrb.Checked = True Then
            NewShortcut.WindowStyle = 7
        End If

        ' Wenn WinCrypt normal starten gewählt wurde werden diese Einstellungen in den Verknüpfungseigenschaften gesetzt
        If startnormalwincrypt.Checked = True Then
            NewShortcut.WindowStyle = 1
        End If
        NewShortcut.IconLocation = File & ",0" ' Das standardicon vom index 0 wird der Verknüpfung zugewiesen
        NewShortcut.WorkingDirectory = WorkDirectory
        NewShortcut.Save() ' Die Verknüpfungseinstellungen werden gespeichert
    End Function
    Private Sub Einstellungen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lang.check() ' Es wird die Sprache überprüft

        'Alle leerzeichen der Bios ID werden entfernt
        For Each ver In wmiobj.Instances_
            bios = ver.SerialNumber
            bios.Replace(" ", "")
        Next

        If My.Settings.Masterkey = True Then 'Es wird überprüft ob der Masterkey in den Einstellungen auf true gesetzt wurde
            key_cb.Checked = True 'Wenn ja wird die Masterkey Checkbox ausgewählt
        Else
            key_cb.Checked = False ' Wenn nicht wird die Masterkey Checkbox nicht ausgewählt
        End If
        If ini.WertLesen("Info", "Shortcut") = "minimized" Then ' Es wird überprüft ob die Verknüpfung auf minimiert gesetzt wurde
            startminwincryptrb.Checked = True ' Wenn ja wird die ,,WinCrypt minimiert starten" RadioBox angewählt
        Else : End If
        If ini.WertLesen("Info", "Shortcut") = "normal" Then ' Es wird überprüft ob die Verknüpfung auf normal gesetzt wurde
            startnormalwincrypt.Checked = True ' Wenn ja wird die ,,WinCrypt normal starten" RadioBox angewählt
        Else : End If

        ' Es wird überprüft ob die WinCrypt verknüpfung im Startup Ordner existiert
        If My.Computer.FileSystem.FileExists("C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\WinCrypt.lnk") Then
            startwincb.Checked = True ' Falls ja wird die ,,WinCrypt mit Windows starten" Checkbox angewählt
        Else
            startwincb.Checked = False ' Falls nicht wird die ,,WinCrypt mit Windows starten" Checkbox nicht angewählt
        End If
        If iniwrite.WertLesen("Info", "Lang") = "English" Then ' Es wird überprüft ob in der config.ini der Sprachwert auf English gesetzt wurde
            languagecb.Text = "English" ' Wenn ja wird der ComboBox Text English sein
        End If
        If iniwrite.WertLesen("Info", "Lang") = "German" Then ' Es wird überprüft ob in der config.ini der Sprachwert auf German gesetzt wurde
            languagecb.Text = "Deutsch" ' Wenn ja wird der ComboBox Text Deutsch sein
        End If
    End Sub
    Private Sub startwincb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startwincb.CheckedChanged
        'Wenn die ,,WinCrypt mit Windows starten" CheckBox geändert wurde wird überprüft
        'ob sie auf true oder false gesetzt wurde
        If startwincb.Checked = True Then
            'Wenn sie auf true gesetzt wurde so wird die WinCrypt verknüpfung in dem Startup ordner erstellt
            MakeShortcut(My.Application.Info.DirectoryPath & "\Project WinCrypt.exe", "C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup", "WinCrypt", My.Application.Info.DirectoryPath)
        Else
            ' Wenn nicht, wird die Verknüpfung gelöscht bzw. entfernt
            My.Computer.FileSystem.DeleteFile("C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\WinCrypt.lnk")
        End If
    End Sub

    Private Sub startminwincryptrb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startminwincryptrb.CheckedChanged
        ' Wenn die RadioBox ,,WinCrypt minimiert starten geändert wurde wird überprüft
        If startminwincryptrb.Checked = True Then ' ob sie auf True gesetzt wurde
            If startwincb.Checked = True Then 'dann wird überprüft ob ob überhaupt die WinCrypt verknüpfung im Startup ordner erstellt werden soll
                'Wenn ja, wird die Verknüpfung erstellt und die Einstellung in die Config.ini geschrieben
                MakeShortcut(My.Application.Info.DirectoryPath & "\Project WinCrypt.exe", "C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup", "WinCrypt", My.Application.Info.DirectoryPath)
                ini.WertSchreiben("Info", "Shortcut", "minimized") ' in der config.ini wird der Wert minimized gespeichert das WinCrypt beim Systemstart minimiert gestartet werden soll
            Else : End If
        Else : End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startnormalwincrypt.CheckedChanged
        ' Es wird überprüft ob der RadioButton ,,WinCrypt normal starten" gewählt wurde
        If startnormalwincrypt.Checked = True Then 'wenn ja, ob sie auf True gesetzt wurde
            If startwincb.Checked = True Then 'dann wird überprüft ob ob überhaupt die WinCrypt verknüpfung im Startup ordner erstellt werden soll
                MakeShortcut(My.Application.Info.DirectoryPath & "\Project WinCrypt.exe", "C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup", "WinCrypt", My.Application.Info.DirectoryPath)
                ini.WertSchreiben("Info", "Shortcut", "normal") ' in der config.ini wird der Wert minimized gespeichert das WinCrypt beim Systemstart normal gestartet werden soll
            Else : End If
        End If
    End Sub

    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles show_bt.MouseDown
        key_txt.UseSystemPasswordChar = False 'Wenn auf dem Button haltend gedrückt wird um das Passwort vom Masterkey anzeigen zu lassen
    End Sub

    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles show_bt.MouseUp
        key_txt.UseSystemPasswordChar = True 'Wenn auf dem Button nicht gedrückt wird wird der klartext vom Masterkey verborgen
    End Sub

    Private Sub key_cb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_cb.CheckedChanged
        'Wenn die Masterkey checkbox geändert wird
        If key_cb.Checked = True Then ' wird überprüft ob sie auf true gesetzt wurde
            ' Wenn ja so wird das Key textfeld, key label, der showbutton freigegeben und in den Masterkey einstellungen wird der Wert auf true gesetzt
            key_txt.Enabled = True
            key_lb.Enabled = True
            show_bt.Enabled = True
            My.Settings.Masterkey = True
        Else
            'Wenn nicht, so wird das Key textfeld, das key label und der showbutton deaktiviert und in den Masterkey einstellungen wird der Wert auf false gesetzt
            key_txt.Enabled = False
            key_lb.Enabled = False
            show_bt.Enabled = False
            My.Settings.Masterkey = False
        End If
        Dim readkey As New AES ' Es wird AES deklariert
        Dim lGuid As System.Runtime.InteropServices.GuidAttribute ' Es wird die Application GUID deklariert
        lGuid = DirectCast(System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes( _
                  GetType(System.Runtime.InteropServices.GuidAttribute), False)(0),  _
                  System.Runtime.InteropServices.GuidAttribute)
        If My.Settings.Masterkey = True Then ' Wenn in den Masterkey einstellungen der Wert auf true steht
            key_txt.Text = readkey.AESDecrypt(iniwrite.WertLesen("Key", "master"), bios, lGuid.Value) ' dann wird das Passwort in AES verschlüsselt und in der config.ini geschrieben
        Else : End If
    End Sub
End Class