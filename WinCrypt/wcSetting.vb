Imports System.ComponentModel
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Project_WinCrypt.classes

Public Class WcSetting
    Private designcolor As New designcolor
    ReadOnly _
        _iniwrite As _
            New IniDatei(String.Format("{0}\WinCrypt\config.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))) _
    ' Die config.ini wird eingelesen
    ReadOnly _
        _ini As _
            New IniDatei(String.Format("{0}\WinCrypt\config.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))) _
    ' Die config.ini wird eingelesen
    ReadOnly _lang As New Language ' Die Sprache wird deklariert
    ReadOnly _wmiobj As Object = GetObject("winmgmts://localhost/root/cimv2:Win32_BIOS") _
    ' Die Bios ID wird deklariert

    Private _bios As String
    Private Sub registfiletype_Click(sender As Object, e As EventArgs) Handles registfiletype.Click
        Try
            Process.Start(Application.StartupPath & "\WinCryptRegistry.exe") _
            ' regist.exe wird ausgeführt und die Dateitypen .wc und .wcp werden regestriert
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Falls ein Fehler auftritt wird dieser angezeigt
        End Try
    End Sub

    Private Sub okbt_Click(sender As Object, e As EventArgs) Handles okbt.Click
        Dim c As New designcolor
        If languagecb.SelectedIndex = 0 Then ' Es wird überprüft ob die Sprache Deutsch ausgewählt wurde
            _iniwrite.WertSchreiben("Info", "Lang", "German") ' Wenn ja wird diese in der config.ini eingetragen
        End If
        If languagecb.SelectedIndex = 1 Then ' Es wird überprüft ob die Sprache English ausgewählt wurde
            _iniwrite.WertSchreiben("Info", "Lang", "English") ' Wenn ja denn wird diese in der config.ini eingetragen
        End If

        If use_template_rb2.Checked Then
            _iniwrite.WertSchreiben("Design", "UseTemplate", "False") ' Wenn ja denn wird diese in der config.ini eingetragen
        Else
            _iniwrite.WertSchreiben("Design", "UseTemplate", useTemplate_cb.Text) ' Wenn ja denn wird diese in der config.ini eingetragen
        End If

        Dim keyaes As New AES ' AES wird deklariert
        Dim lGuid As GuidAttribute ' Die WinCrypt GUID wird deklariert
        lGuid = DirectCast(
            Assembly.GetExecutingAssembly().GetCustomAttributes(
                GetType(GuidAttribute), False)(0),
            GuidAttribute)

        If key_cb.Checked = True Then ' Es wird überprüft ob der Masterkey aktiviert wurde
            ' Wenn ja wird dieses Passwort in AES verschlüsselt und in der config.ini eingetragen
            _iniwrite.WertSchreiben("Key", "master", CStr(keyaes.AesEncrypt(key_txt.Text, _bios, lGuid.Value)))
            My.Settings.Masterkey = True ' In den WinCrypt Einstellungen wird der wert Masterkey auf true gesetzt
        Else
            ' Wenn der Masterkey nicht aktiviert wurde wird der Masterkey in den Einstellungen auf false gesetzt
            My.Settings.Masterkey = False
        End If

        ' Das Hauptlaufwerk wird deklariert um die config.ini zu lesen
        Dim root As New DirectoryInfo(Application.StartupPath)
        Dim _
            i As _
                New IniDatei(
                    root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")

        Startwindow.Langname = i.worthreading("Info", "Lang") _
        ' Die gewählte Sprache wird in dem String startwindow.langname gesetzt
        _lang.check() 'Es wird die gespeicherte Sprache ausgelesen und durchgeführt
        c.color()
        Close() ' Das Fenster wird geschlossen
    End Sub

    Private Sub MakeShortcut(file As String, shortcutFolder As String, Name As String, workDirectory As String)
        Dim wshShell As Object = CreateObject("WScript.Shell") ' Es wird eine Verknüpfung deklariert
        Dim newShortcut As Object = wshShell.CreateShortcut(shortcutFolder & "\" & Name & ".lnk") _
        ' Es wird eine neue Verknüpfung erstellt
        newShortcut.TargetPath = file 'Es wird das Schlüsselwort ausgelesen und gesetzt

        ' Wenn WinCrypt minimiert starten gewählt wurde werden diese Einstellungen in den Verknüpfungseigenschaften gesetzt
        If startminwincryptrb.Checked = True Then
            newShortcut.WindowStyle = 7
        End If

        ' Wenn WinCrypt normal starten gewählt wurde werden diese Einstellungen in den Verknüpfungseigenschaften gesetzt
        If startnormalwincrypt.Checked = True Then
            newShortcut.WindowStyle = 1
        End If
        newShortcut.IconLocation = file & ",0" ' Das standardicon vom index 0 wird der Verknüpfung zugewiesen
        newShortcut.WorkingDirectory = workDirectory
        newShortcut.Save() ' Die Verknüpfungseinstellungen werden gespeichert
    End Sub

    Private Sub wcSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        designcolor.color()
        _lang.check() ' Es wird die Sprache überprüft
        If _iniwrite.worthreading("Design", "UseTemplate") = "False" Then
            use_template_rb.Checked = False
            use_template_rb2.Checked = True
        Else
            useTemplate_cb.Text = _iniwrite.worthreading("Design", "UseTemplate")
            use_template_rb.Checked = True
            use_template_rb2.Checked = False
        End If
        'Alle leerzeichen der Bios ID werden entfernt
        For Each ver In _wmiobj.Instances_
            _bios = ver.SerialNumber
            _bios.Replace(" ", Nothing)
        Next

        If My.Settings.Masterkey = True Then _
            'Es wird überprüft ob der Masterkey in den Einstellungen auf true gesetzt wurde
            key_cb.Checked = True 'Wenn ja wird die Masterkey Checkbox ausgewählt
        Else
            key_cb.Checked = False ' Wenn nicht wird die Masterkey Checkbox nicht ausgewählt
        End If
        If _ini.worthreading("Info", "Shortcut") = "minimized" Then _
            ' Es wird überprüft ob die Verknüpfung auf minimiert gesetzt wurde
            startminwincryptrb.Checked = True ' Wenn ja wird die ,,WinCrypt minimiert starten" RadioBox angewählt
            WindowState = FormWindowState.Minimized
        Else
        End If
        If _ini.worthreading("Info", "Shortcut") = "normal" Then _
            ' Es wird überprüft ob die Verknüpfung auf normal gesetzt wurde
            startnormalwincrypt.Checked = True ' Wenn ja wird die ,,WinCrypt normal starten" RadioBox angewählt
        Else
        End If

        ' Es wird überprüft ob die WinCrypt verknüpfung im Startup Ordner existiert
        If File.Exists("C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\WinCrypt.lnk") Then
            startwincb.Checked = True ' Falls ja wird die ,,WinCrypt mit Windows starten" Checkbox angewählt
        Else
            startwincb.Checked = False ' Falls nicht wird die ,,WinCrypt mit Windows starten" Checkbox nicht angewählt
        End If
        If _iniwrite.worthreading("Info", "Lang") = "English" Then _
            ' Es wird überprüft ob in der config.ini der Sprachwert auf English gesetzt wurde
            languagecb.SelectedIndex = 1 ' Wenn ja wird der ComboBox Text English sein
        End If
        If _iniwrite.worthreading("Info", "Lang") = "German" Then _
            ' Es wird überprüft ob in der config.ini der Sprachwert auf German gesetzt wurde
            languagecb.SelectedIndex = 0 ' Wenn ja wird der ComboBox Text Deutsch sein
        End If
        If _iniwrite.worthreading("Design", "UseTemplate") = "False" Then
            use_template_rb2.Checked = True
        Else
            use_template_rb2.Checked = False
        End If
    End Sub

    Private Sub startwincb_CheckedChanged(sender As Object, e As EventArgs) Handles startwincb.CheckedChanged
        'Wenn die ,,WinCrypt mit Windows starten" CheckBox geändert wurde wird überprüft
        'ob sie auf true oder false gesetzt wurde
        If startwincb.Checked = True Then
            'Wenn sie auf true gesetzt wurde so wird die WinCrypt verknüpfung in dem Startup ordner erstellt
            MakeShortcut(Application.StartupPath & "\Project WinCrypt.exe",
                         "C:\Users\" & Environment.UserName &
                         "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup", "WinCrypt",
                         Application.StartupPath)
        Else
            ' Wenn nicht, wird die Verknüpfung gelöscht bzw. entfernt
            File.Delete("C:\Users\" & Environment.UserName &
                "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\WinCrypt.lnk")
        End If
    End Sub

    Private Sub startminwincryptrb_CheckedChanged(sender As Object, e As EventArgs) _
        Handles startminwincryptrb.CheckedChanged
        ' Wenn die RadioBox ,,WinCrypt minimiert starten geändert wurde wird überprüft
        If startminwincryptrb.Checked = True Then ' ob sie auf True gesetzt wurde
            If startwincb.Checked = True Then _
                'dann wird überprüft ob ob überhaupt die WinCrypt verknüpfung im Startup ordner erstellt werden soll
                'Wenn ja, wird die Verknüpfung erstellt und die Einstellung in die Config.ini geschrieben
                MakeShortcut(Application.StartupPath & "\Project WinCrypt.exe",
                             "C:\Users\" & Environment.UserName &
                             "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup", "WinCrypt",
                             Application.StartupPath)
                _ini.WertSchreiben("Info", "Shortcut", "minimized") _
                ' in der config.ini wird der Wert minimized gespeichert das WinCrypt beim Systemstart minimiert gestartet werden soll
            Else
            End If
        Else
        End If
    End Sub

    Private Sub startnormalwincrypt_CheckedChanged(sender As Object, e As EventArgs) _
        Handles startnormalwincrypt.CheckedChanged
        ' Es wird überprüft ob der RadioButton ,,WinCrypt normal starten" gewählt wurde
        If startnormalwincrypt.Checked = True Then 'wenn ja, ob sie auf True gesetzt wurde
            If startwincb.Checked = True Then _
                'dann wird überprüft ob ob überhaupt die WinCrypt verknüpfung im Startup ordner erstellt werden soll
                MakeShortcut(Application.StartupPath & "\Project WinCrypt.exe",
                             "C:\Users\" & Environment.UserName &
                             "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup", "WinCrypt",
                             Application.StartupPath)
                _ini.WertSchreiben("Info", "Shortcut", "normal") _
                ' in der config.ini wird der Wert minimized gespeichert das WinCrypt beim Systemstart normal gestartet werden soll
            Else
            End If
        End If
    End Sub

    Private Sub show_bt_MouseDown(sender As Object, e As MouseEventArgs)
        key_txt.UseSystemPasswordChar = False _
        'Wenn auf dem Button haltend gedrückt wird um das Passwort vom Masterkey anzeigen zu lassen
    End Sub

    Private Sub show_bt_MouseUp(sender As Object, e As MouseEventArgs)
        key_txt.UseSystemPasswordChar = True _
        'Wenn auf dem Button nicht gedrückt wird wird der klartext vom Masterkey verborgen
    End Sub

    Private Sub key_cb_CheckedChanged(sender As Object, e As EventArgs) Handles key_cb.CheckedChanged
        'Wenn die Masterkey checkbox geändert wird
        If key_cb.Checked = True Then ' wird überprüft ob sie auf true gesetzt wurde
            ' Wenn ja so wird das Key textfeld, key label, der showbutton freigegeben und in den Masterkey einstellungen wird der Wert auf true gesetzt
            key_txt.Enabled = True
            My.Settings.Masterkey = True
        Else
            'Wenn nicht, so wird das Key textfeld, das key label und der showbutton deaktiviert und in den Masterkey einstellungen wird der Wert auf false gesetzt
            key_txt.Enabled = False
            My.Settings.Masterkey = False
        End If
        Dim readkey As New AES ' Es wird AES deklariert
        Dim lGuid As GuidAttribute ' Es wird die Application GUID deklariert
        lGuid = DirectCast(
            Assembly.GetExecutingAssembly().GetCustomAttributes(
                GetType(GuidAttribute), False)(0), 
            GuidAttribute)
        If My.Settings.Masterkey = True Then ' Wenn in den Masterkey einstellungen der Wert auf true steht
            key_txt.Text = readkey.AesDecrypt(_iniwrite.worthreading("Key", "master"), _bios, lGuid.Value) _
            ' dann wird das Passwort in AES verschlüsselt und in der config.ini geschrieben
        Else
        End If
    End Sub

    Private Sub minimize_bt_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub exit_bt_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
        Close()
    End Sub

    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = MouseButtons.Left) Then
            wincrypttitle.Capture = False
            WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else
        End If
    End Sub

    Private Sub form_head_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = MouseButtons.Left) Then
            form_head.Capture = False
            WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else
        End If
    End Sub

    Private Sub bgcolor_bt_Click(sender As Object, e As EventArgs) Handles bgcolor_bt.Click
        designcolor_dialog.Color = bgcolor_bt.BackColor
        designcolor_dialog.ShowDialog()
        _ini.WertSchreiben("Design", "BackgroundColor", ColorTranslator.ToHtml(designcolor_dialog.Color))
        bgcolor_bt.BackColor = designcolor_dialog.Color

    End Sub

    Private Sub formhead_color_bt_Click(sender As Object, e As EventArgs) Handles formhead_color_bt.Click
        designcolor_dialog.Color = formhead_color_bt.BackColor
        designcolor_dialog.ShowDialog()
        _ini.WertSchreiben("Design", "FormHeadColor", ColorTranslator.ToHtml(designcolor_dialog.Color))
        formhead_color_bt.BackColor = designcolor_dialog.Color
    End Sub

    Private Sub inputbackground_bt_Click(sender As Object, e As EventArgs) Handles inputbackground_bt.Click
        designcolor_dialog.Color = inputbackground_bt.BackColor
        designcolor_dialog.ShowDialog()
        _ini.WertSchreiben("Design", "InputBackgroundColor", ColorTranslator.ToHtml(designcolor_dialog.Color))
        inputbackground_bt.BackColor = designcolor_dialog.Color
    End Sub

    Private Sub buttoncolor_bt_Click(sender As Object, e As EventArgs) Handles buttoncolor_bt.Click
        designcolor_dialog.Color = buttoncolor_bt.BackColor
        designcolor_dialog.ShowDialog()
        _ini.WertSchreiben("Design", "ButtonColor", ColorTranslator.ToHtml(designcolor_dialog.Color))
        buttoncolor_bt.BackColor = designcolor_dialog.Color
    End Sub

    Private Sub textcolor_bt_Click(sender As Object, e As EventArgs) Handles textcolor_bt.Click
        designcolor_dialog.Color = textcolor_bt.BackColor
        designcolor_dialog.ShowDialog()
        _ini.WertSchreiben("Design", "TextColor", ColorTranslator.ToHtml(designcolor_dialog.Color))
        textcolor_bt.BackColor = designcolor_dialog.Color
    End Sub

    Private Sub inputtextcolor_bt_Click(sender As Object, e As EventArgs) Handles inputtextcolor_bt.Click
        designcolor_dialog.Color = inputtextcolor_bt.BackColor
        designcolor_dialog.ShowDialog()
        _ini.WertSchreiben("Design", "InputTextColor", ColorTranslator.ToHtml(designcolor_dialog.Color))
        inputtextcolor_bt.BackColor = designcolor_dialog.Color
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles standard_restore_bt.Click
        _ini.WertSchreiben("Design", "BackgroundColor", "#2d2d30")
        _ini.WertSchreiben("Design", "FormHeadColor", "#2d2d30")
        _ini.WertSchreiben("Design", "InputBackgroundColor", "#333337")
        _ini.WertSchreiben("Design", "ButtonColor", "#3e3e40")
        _ini.WertSchreiben("Design", "TextColor", "#ffffff")
        _ini.WertSchreiben("Design", "InputTextColor", "#007acc")
        _ini.WertSchreiben("Design", "UseTemplate", "Standard")
        Dim colorload As New designcolor
        colorload.color()
    End Sub

    Private Sub design_export_Click_1(sender As Object, e As EventArgs) Handles design_export.Click
        design_export_dialog.ShowDialog()
        File.WriteAllText(design_export_dialog.FileName, Nothing)
        If File.Exists(design_export_dialog.FileName) Then
            Dim exportDesign As New IniDatei(design_export_dialog.FileName)
            exportDesign.WertSchreiben("Design", "BackgroundColor", ColorTranslator.ToHtml(bgcolor_bt.BackColor))
            exportDesign.WertSchreiben("Design", "FormHeadColor", ColorTranslator.ToHtml(formhead_color_bt.BackColor))
            exportDesign.WertSchreiben("Design", "InputBackgroundColor", ColorTranslator.ToHtml(inputbackground_bt.BackColor))
            exportDesign.WertSchreiben("Design", "ButtonColor", ColorTranslator.ToHtml(buttoncolor_bt.BackColor))
            exportDesign.WertSchreiben("Design", "TextColor", ColorTranslator.ToHtml(textcolor_bt.BackColor))
            exportDesign.WertSchreiben("Design", "InputTextColor", ColorTranslator.ToHtml(inputtextcolor_bt.BackColor))

            'exportDesign.WertSchreiben("Design", "UseTemplate", ColorTranslator.ToHtml(inputtextcolor_bt.BackColor))

        End If
        If _lang.langname = "English" Then
            MessageBox.Show("design exported!", "Design", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Design exportiert!", "Design", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub design_import_Click(sender As Object, e As EventArgs) Handles design_import.Click
        import_design_dialog.ShowDialog()
    End Sub
    Private Sub import_design_dialog_FileOk(sender As Object, e As CancelEventArgs) Handles import_design_dialog.FileOk
        If File.Exists(import_design_dialog.FileName) = True Then
            If use_template_rb2.Checked Then
                _iniwrite.WertSchreiben("Design", "UseTemplate", "False") ' Wenn ja denn wird diese in der config.ini eingetragen
            Else
                _iniwrite.WertSchreiben("Design", "UseTemplate", useTemplate_cb.Text) ' Wenn ja denn wird diese in der config.ini eingetragen
            End If
            Dim readDesign As New IniDatei(import_design_dialog.FileName)
            Dim BackgroundColor_hex As String = readDesign.worthreading("Design", "BackgroundColor")
            Dim FormHeadColor_hex As String = readDesign.worthreading("Design", "FormHeadColor")
            Dim InputBackgroundColor_hex As String = readDesign.worthreading("Design", "InputBackgroundColor")
            Dim ButtonColor_hex As String = readDesign.worthreading("Design", "ButtonColor")
            Dim TextColor_hex As String = readDesign.worthreading("Design", "TextColor")
            Dim InputTextColor_hex As String = readDesign.worthreading("Design", "InputTextColor")

            _iniwrite.WertSchreiben("Design", "BackgroundColor", BackgroundColor_hex)
            _iniwrite.WertSchreiben("Design", "FormHeadColor", FormHeadColor_hex)
            _iniwrite.WertSchreiben("Design", "InputBackgroundColor", InputBackgroundColor_hex)
            _iniwrite.WertSchreiben("Design", "ButtonColor", ButtonColor_hex)
            _iniwrite.WertSchreiben("Design", "TextColor", TextColor_hex)
            _iniwrite.WertSchreiben("Design", "InputTextColor", InputTextColor_hex)

            bgcolor_bt.BackColor = ColorTranslator.FromHtml(BackgroundColor_hex)
            formhead_color_bt.BackColor = ColorTranslator.FromHtml(FormHeadColor_hex)
            inputbackground_bt.BackColor = ColorTranslator.FromHtml(InputBackgroundColor_hex)
            buttoncolor_bt.BackColor = ColorTranslator.FromHtml(ButtonColor_hex)
            textcolor_bt.BackColor = ColorTranslator.FromHtml(TextColor_hex)
            inputtextcolor_bt.BackColor = ColorTranslator.FromHtml(InputTextColor_hex)

            Dim loadDesign As New designcolor
            loadDesign.color()

            If _lang.langname = "English" Then
                MessageBox.Show("design imported!", "Design", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Design importiert!", "Design", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else

        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles use_template_rb.CheckedChanged
        useTemplate_cb.Enabled = True
        bgcolor_lb.Enabled = False
        formhead_color_lb.Enabled = False
        inputbackground_lb.Enabled = False
        buttoncolor_lb.Enabled = False
        textcolor_lb.Enabled = False
        inputtextcolor_lb.Enabled = False
        bgcolor_bt.Enabled = False
        formhead_color_bt.Enabled = False
        inputbackground_bt.Enabled = False
        buttoncolor_bt.Enabled = False
        textcolor_bt.Enabled = False
        inputtextcolor_bt.Enabled = False
        design_export.Enabled = False
        design_import.Enabled = False
        standard_restore_bt.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles use_template_rb2.CheckedChanged
        useTemplate_cb.Enabled = False
        bgcolor_lb.Enabled = True
        formhead_color_lb.Enabled = True
        inputbackground_lb.Enabled = True
        buttoncolor_lb.Enabled = True
        textcolor_lb.Enabled = True
        inputtextcolor_lb.Enabled = True
        bgcolor_bt.Enabled = True
        formhead_color_bt.Enabled = True
        inputbackground_bt.Enabled = True
        buttoncolor_bt.Enabled = True
        textcolor_bt.Enabled = True
        inputtextcolor_bt.Enabled = True
        design_export.Enabled = True
        design_import.Enabled = True
        standard_restore_bt.Enabled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles useTemplate_cb.SelectedIndexChanged

        Select Case useTemplate_cb.SelectedIndex
            Case 0
                _ini.WertSchreiben("Design", "UseTemplate", "DarkStyle")
                _ini.WertSchreiben("Design", "BackgroundColor", "#2D2D30")
                _ini.WertSchreiben("Design", "FormHeadColor", "#007ACC")
                _ini.WertSchreiben("Design", "InputBackgroundColor", "#1B1B1C")
                _ini.WertSchreiben("Design", "ButtonColor", "#1B1B1C")
                _ini.WertSchreiben("Design", "TextColor", "White")
                _ini.WertSchreiben("Design", "InputTextColor", "White")
            Case 1
                _ini.WertSchreiben("Design", "UseTemplate", "LightStyle")
                _ini.WertSchreiben("Design", "BackgroundColor", "#E2E2E2")
                _ini.WertSchreiben("Design", "FormHeadColor", "#007ACC")
                _ini.WertSchreiben("Design", "InputBackgroundColor", "#F6F6F6")
                _ini.WertSchreiben("Design", "ButtonColor", "#F6F6F6")
                _ini.WertSchreiben("Design", "TextColor", "Black")
                _ini.WertSchreiben("Design", "InputTextColor", "Black")
        End Select
        Dim colorload As New designcolor
        colorload.color()
    End Sub

    Private Sub languagecb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles languagecb.SelectedIndexChanged

        Select Case languagecb.SelectedIndex
            Case 0
                Language.ChangeLanguage("de-DE")
            Case 1
                Language.ChangeLanguage("en-US")
        End Select

    End Sub

    Private Sub key_txt_TextChanged(sender As Object, e As EventArgs) Handles key_txt.TextChanged
        Dim passstrength As New Passstrength
        If passstrength.PasswordStrength(key_txt.Text, key_txt.Text.Length) = -0 Then
            Dim color As New designcolor
            key_txt.BackColor = color.inputbackgroundcolor
        End If
        If passstrength.PasswordStrength(key_txt.Text, key_txt.Text.Length) = 1 Then
            Dim color As New designcolor
            key_txt.BackColor = Drawing.Color.Red
        End If
        If passstrength.PasswordStrength(key_txt.Text, key_txt.Text.Length) = 2 Then
            Dim color As New designcolor
            key_txt.BackColor = Drawing.Color.Yellow
        End If
        If passstrength.PasswordStrength(key_txt.Text, key_txt.Text.Length) = 3 Then
            Dim color As New designcolor
            key_txt.BackColor = Drawing.Color.GreenYellow
        End If
        If passstrength.PasswordStrength(key_txt.Text, key_txt.Text.Length) = 4 Then
            Dim color As New designcolor
            key_txt.BackColor = Drawing.Color.Lime
        End If

    End Sub
End Class