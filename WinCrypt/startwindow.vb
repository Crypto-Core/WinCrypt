
Option Explicit On

Imports System.IO
Imports System.Threading
Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.Win32
Imports Project_WinCrypt.classes
Public Class Startwindow
    Private WithEvents loadcolor As New designcolor
    ReadOnly _filezip As New Zip
    Private _selectcombo As String
    ReadOnly _wmiobj As Object = GetObject("winmgmts://localhost/root/cimv2:Win32_BIOS")
    Public Biosid As String
    Public Iniread As String
    Public Mypath As String
    Public Selecteddrive As String
    Public Langname As String
    Public Errormount As String
    Private _removestring As String
    ReadOnly _lang As New Language
    Public Formclose As Boolean = False
    Public Timerclose As Boolean = False
    Private _finishcrypt As Integer = 0
    Private _finunmount As Integer = 0
    Public vCommand As Boolean = False
    Private admin_restart As Boolean = False
    Dim krypt_passstrength As New Passstrength
    ReadOnly _
        _ini As _
            New IniDatei(String.Format("{0}\WinCrypt\config.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))

    Function GetFolderSize(dirPath As String,
                           Optional ByVal includeSubFolders As Boolean = True) As Long
        Dim lngDirSize As Long
        Dim objFileInfo As FileInfo
        Dim objDir = New DirectoryInfo(dirPath)
        Dim objSubFolder As DirectoryInfo
        Try
            For Each objFileInfo In objDir.GetFiles()
                lngDirSize += objFileInfo.Length
            Next

            If includeSubFolders Then
                For Each objSubFolder In objDir.GetDirectories()
                    lngDirSize += GetFolderSize(objSubFolder.FullName)
                Next
            End If
        Catch ex As Exception

        End Try
        Return lngDirSize
    End Function

    Private Sub encrypttimer_Tick(sender As Object, e As EventArgs) Handles encrypttimer.Tick
        _finishcrypt = 0
        If Iniread = "yes" Then
            Try
                Dim p As Integer = pathtxt.Text.LastIndexOf("\", StringComparison.Ordinal)
                _removestring = pathtxt.Text.Remove(0, p + 1)
                FileSystem.RenameFile(
                    My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & ".zip", _removestring & "f.zip")
                If Langname = "English" Then
                    encrypt_list_status.Items.Add("Now is encrypted...........")
                Else
                    encrypt_list_status.Items.Add("Jetzt wird Verschlüsselt.......")
                End If
                encrypttimer.Enabled = True
                Dim computerName = "."
                Dim wmiServices = GetObject(
                    "winmgmts:{impersonationLevel=Impersonate}!//" & computerName)
                Dim wmiDiskDrives = wmiServices.ExecQuery("SELECT Caption, DeviceID FROM Win32_DiskDrive")
                For Each wmiDiskDrive In wmiDiskDrives
                    Dim deviceid As String = wmiDiskDrive.Caption
                    Dim query = "ASSOCIATORS OF {Win32_DiskDrive.DeviceID='" _
                                & wmiDiskDrive.DeviceID & "'} WHERE AssocClass = Win32_DiskDriveToDiskPartition"
                    Dim wmiDiskPartitions = wmiServices.ExecQuery(query)
                    For Each wmiDiskPartition In wmiDiskPartitions
                        Dim wmiLogicalDisks = wmiServices.ExecQuery _
                                ("ASSOCIATORS OF {Win32_DiskPartition.DeviceID='" _
                                 & wmiDiskPartition.DeviceID & "'} WHERE AssocClass = Win32_LogicalDiskToPartition")
                        For Each wmiLogicalDisk In wmiLogicalDisks
                            If wmiLogicalDisk.DeviceID = pathtxt.Text.Replace("\", Nothing) Then
                                Selecteddrive = deviceid
                            End If
                        Next
                    Next
                Next
                If _removestring = Nothing Then
                    CryptFile(Biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & "f.zip",
                              My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & Selecteddrive.Replace(" ", Nothing) &
                              ".wcp", True)
                Else
                    CryptFile(Biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & "f.zip",
                              My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & _removestring.Replace(" ", Nothing) &
                              ".wcp", True)
                End If

                If Langname = "English" Then
                    encrypt_list_status.Items.Add("Container encrypted.....")
                Else
                    encrypt_list_status.Items.Add("Container verschlüsselt.....")
                End If
                My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)
                _finishcrypt = 1
                encrypttimer.Enabled = False
                If Timerclose = True Then
                    Application.Exit()
                End If
            Catch ex As Exception

            End Try
        Else
            Try
                Dim lastBackslash As Integer = pathtxt.Text.LastIndexOf("\", StringComparison.Ordinal)
                _removestring = pathtxt.Text.Remove(0, lastBackslash + 1)
                FileSystem.RenameFile(
                    My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & ".zip", _removestring & "f.zip")
                If Langname = "English" Then
                    encrypt_list_status.Items.Add("Now is encrypted...........")
                Else
                    encrypt_list_status.Items.Add("Jetzt wird Verschlüsselt.......")
                End If
                Dim computerName = "."
                Dim wmiServices = GetObject(
                    "winmgmts:{impersonationLevel=Impersonate}!//" & computerName)
                Dim wmiDiskDrives = wmiServices.ExecQuery("SELECT Caption, DeviceID FROM Win32_DiskDrive")
                For Each wmiDiskDrive In wmiDiskDrives
                    Dim deviceid As String = wmiDiskDrive.Caption
                    Dim query = "ASSOCIATORS OF {Win32_DiskDrive.DeviceID='" _
                                & wmiDiskDrive.DeviceID & "'} WHERE AssocClass = Win32_DiskDriveToDiskPartition"
                    Dim wmiDiskPartitions = wmiServices.ExecQuery(query)
                    For Each wmiDiskPartition In wmiDiskPartitions
                        Dim wmiLogicalDisks = wmiServices.ExecQuery _
                                ("ASSOCIATORS OF {Win32_DiskPartition.DeviceID='" _
                                 & wmiDiskPartition.DeviceID & "'} WHERE AssocClass = Win32_LogicalDiskToPartition")
                        For Each wmiLogicalDisk In wmiLogicalDisks
                            If wmiLogicalDisk.DeviceID = pathtxt.Text.Replace("\", Nothing) Then
                                Selecteddrive = deviceid
                            End If

                        Next
                    Next
                Next
                If _removestring = Nothing Then
                    CryptFile(keycrypt.Text,
                              My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & "f.zip",
                              Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & Selecteddrive.Replace(" ", Nothing) &
                              ".wcp", True)
                Else
                    CryptFile(keycrypt.Text,
                              My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & "f.zip",
                              Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & _removestring.Replace(" ", Nothing) &
                              ".wcp", True)
                End If
                If Langname = "English" Then
                    encrypt_list_status.Items.Add(CStr("Container encrypted....."))
                Else
                    encrypt_list_status.Items.Add(CStr("Container verschlüsselt....."))
                End If
                My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)
                _finishcrypt = 1
                encrypttimer.Enabled = False
                If Timerclose = True Then
                    Application.Exit()
                End If
            Catch ex As Exception

            End Try
        End If
        encrypt_list_status.SelectedIndex = encrypt_list_status.Items.Count - 1
    End Sub

    Private Sub mount_Click(sender As Object, e As EventArgs) Handles mount.Click
        Formclose = True
        Errormount = Nothing
        If Iniread = "yes" Then
            If drivecb.Text.Length > 2 Then
                keyencrypt.Enabled = False
                decrypt_filepath.Enabled = False
                drivecb.Enabled = False
                keyencrypt.UseSystemPasswordChar = True
                Dim lastBackslash As Integer = decrypt_filepath.Text.LastIndexOf("\", StringComparison.Ordinal)
                Dim removeStr As String = decrypt_filepath.Text.Remove(0, lastBackslash + 1)
                DecryptFile(Biosid, decrypt_filepath.Text,
                            My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip")
                If Errormount = "error" Then

                Else
                    Dim _file As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip"
                    Dim cu As New Unzip(_file, Path.Combine(Path.GetDirectoryName(_file), "unmount"))
                    cu.UnzipNow()
                    File.Delete(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip")
                    Try
                        _selectcombo = CStr(drivecb.SelectedItem)
                        Shell(
                            "subst " & _selectcombo.Replace("\", Nothing) & " " & ChrW(34) &
                            My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount" & ChrW(34))
                    Catch ex As Exception
                        If Langname = "English" Then
                            MessageBox.Show("Error: Drive not found!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            MessageBox.Show("Fehler: Laufwerk nicht gefunden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        Application.Restart()
                    End Try
                    If Langname = "English" Then
                        decrypt_list_status.Items.Add(CStr("Container embedded!"))
                    Else
                        decrypt_list_status.Items.Add(CStr("Container eingebunden!"))
                    End If
                    My.Computer.Audio.Play(My.Resources.Vista_DeviceConnect, AudioPlayMode.WaitToComplete)
                    Process.Start("explorer.exe", CStr(drivecb.SelectedItem))
                    mount.Enabled = False
                    dismount.Enabled = True
                End If

            Else
                If Langname = "English" Then
                    MessageBox.Show("Error: Drive not found!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Fehler: Laufwerk nicht gefunden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If CInt(drivecb.Text.Length) > 2 Then
                If Langname = "English" Then
                    decrypt_list_status.Items.Add(CStr("Container is decrypted....."))
                Else
                    decrypt_list_status.Items.Add(CStr("Container wird entschlüsselt....."))
                End If
                keyencrypt.Enabled = False
                decrypt_filepath.Enabled = False
                drivecb.Enabled = False
                keyencrypt.UseSystemPasswordChar = True
                Dim lastBackslash As Integer = decrypt_filepath.Text.LastIndexOf("\", StringComparison.Ordinal)
                Dim removeStr As String = decrypt_filepath.Text.Remove(0, lastBackslash + 1)
                DecryptFile(keyencrypt.Text, decrypt_filepath.Text,
                            My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip")
                If Errormount = "error" Then

                Else
                    Dim _file As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip"
                    Dim cu As New Unzip(_file, Path.Combine(Path.GetDirectoryName(_file), "unmount"))
                    cu.UnzipNow()
                    File.Delete(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip")
                    Try
                        _selectcombo = CStr(drivecb.SelectedItem)
                        Shell(
                            "subst " & _selectcombo.Replace("\", Nothing) & " " & ChrW(34) &
                            My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount" & ChrW(34))
                    Catch ex As Exception
                        If Langname = "English" Then
                            MessageBox.Show("Error: Drive not found!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            MessageBox.Show("Fehler: Laufwerk nicht gefunden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        Application.Restart()
                    End Try
                    If Langname = "English" Then
                        decrypt_list_status.Items.Add(CStr("Container embedded!"))
                    Else
                        decrypt_list_status.Items.Add(CStr("Container eingebunden!"))
                    End If
                    My.Computer.Audio.Play(My.Resources.Vista_DeviceConnect, AudioPlayMode.WaitToComplete)
                    Process.Start("explorer.exe", CStr(drivecb.SelectedItem))
                    mount.Enabled = False
                    dismount.Enabled = True
                End If
            Else
                If Langname = "English" Then
                    MessageBox.Show("Error: Drive not found!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Fehler: Laufwerk nicht gefunden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
        decrypt_list_status.SelectedIndex = decrypt_list_status.Items.Count - 1
    End Sub

    Private Sub dismount_Click(sender As Object, e As EventArgs) Handles dismount.Click
        Formclose = False
        If Errormount = "error" Then

        Else
            Dim lastBackslash As Integer = decrypt_filepath.Text.LastIndexOf("\", StringComparison.Ordinal)
            Dim removeStr As String = decrypt_filepath.Text.Remove(0, lastBackslash + 1)
            _filezip.zip(CStr(drivecb.SelectedItem),
                        My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip")
            If Langname = "English" Then
                decrypt_list_status.Items.Add("Path is then compressed..........")
            Else
                decrypt_list_status.Items.Add("Pfad wird kompremiert..........")
            End If
            encryptmounttimer.Enabled = True
            My.Computer.Audio.Play(My.Resources.Vista_DeviceDisconnect, AudioPlayMode.Background)
            decrypt_filepath.Enabled = True
            drivecb.Enabled = True
        End If
        decrypt_list_status.SelectedIndex = decrypt_list_status.Items.Count - 1
    End Sub

    Private Sub encryptmounttimer_Tick(sender As Object, e As EventArgs) Handles encryptmounttimer.Tick
        If Iniread = "yes" Then
            Try
                Dim lastBackslash As Integer = decrypt_filepath.Text.LastIndexOf("\", StringComparison.Ordinal)
                Dim removeStr As String = decrypt_filepath.Text.Remove(0, lastBackslash + 1)
                FileSystem.RenameFile(
                    My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip", removeStr & "f.zip")
                If Langname = "English" Then
                    decrypt_list_status.Items.Add("Now is encrypted.......")
                Else
                    decrypt_list_status.Items.Add("Jetzt wird Verschlüsselt.......")
                End If
                If removeStr = Nothing Then
                    CryptFile(Biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & "f.zip",
                              My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\Drive-" &
                              decrypt_filepath.Text.Replace(":\", Nothing) & ".wcp", True)
                Else
                    CryptFile(Biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & "f.zip",
                              My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\" &
                              removeStr.Replace(".wcp", Nothing) & ".wcp", True)
                End If
                File.Delete(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & "f.zip")
                If Langname = "English" Then
                    decrypt_list_status.Items.Add("Encryption completed!")
                Else
                    decrypt_list_status.Items.Add("Verschlüsselung abgeschlossen!")
                End If

                If Langname = "English" Then
                    decrypt_list_status.Items.Add(CStr(drivecb.SelectedItem) & " drive will be closed...")
                Else
                    decrypt_list_status.Items.Add("Laufwerk " & CStr(drivecb.SelectedItem) & " wird geschlossen...")
                End If
                dismount.Enabled = False
                Shell("subst " & _selectcombo.Replace("\", Nothing) & " /D")
                Thread.Sleep(3000)
                mount.Enabled = True
                keyencrypt.UseSystemPasswordChar = False
                _finunmount = 1
                If Langname = "English" Then
                    decrypt_list_status.Items.Add("Closed drive " & CStr(drivecb.SelectedItem))
                Else
                    decrypt_list_status.Items.Add("Laufwerk " & CStr(drivecb.SelectedItem) & " geschlossen!")
                End If
                keyencrypt.Enabled = True
                encrypttimer.Enabled = False
                If Timerclose = True Then
                    Application.Exit()
                End If
            Catch ex As Exception

            End Try
        Else
            Try
                Dim lastBackslash = CStr(decrypt_filepath.Text.LastIndexOf("\", StringComparison.Ordinal))
                Dim removeStr As String = decrypt_filepath.Text.Remove(0, CInt(CDbl(lastBackslash) + 1))
                FileSystem.RenameFile(
                    My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip", removeStr & "f.zip")

                If Langname = "English" Then
                    decrypt_list_status.Items.Add(CStr("Now is encrypted......."))
                Else
                    decrypt_list_status.Items.Add(CStr("Jetzt wird Verschlüsselt......."))
                End If
                If removeStr = Nothing Then
                    CryptFile(keyencrypt.Text,
                              My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & "f.zip",
                              My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\Drive-" &
                              decrypt_filepath.Text.Replace(":\", Nothing) & ".wcp", True)
                Else
                    CryptFile(keyencrypt.Text,
                              My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & "f.zip",
                              My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\" &
                              removeStr.Replace(".wcp", Nothing) & ".wcp", True)
                End If
                File.Delete(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & "f.zip")
                If Langname = "English" Then
                    decrypt_list_status.Items.Add(CStr("Encryption completed!"))
                Else
                    decrypt_list_status.Items.Add(CStr("Verschlüsselung abgeschlossen!"))
                End If

                If Langname = "English" Then
                    decrypt_list_status.Items.Add(CStr(drivecb.SelectedItem) & CStr(" drive will be closed..."))
                Else
                    decrypt_list_status.Items.Add(CStr("Laufwerk ") & CStr(drivecb.SelectedItem) & CStr(" wird geschlossen..."))
                End If
                dismount.Enabled = False
                Shell("subst " & _selectcombo.Replace("\", Nothing) & " /D")
                Thread.Sleep(3000)
                mount.Enabled = True
                keyencrypt.UseSystemPasswordChar = False
                _finunmount = 1
                If Langname = "English" Then
                    decrypt_list_status.Items.Add("Drive " & CStr(drivecb.SelectedItem) & " closed!")
                Else
                    decrypt_list_status.Items.Add("Laufwerk " & CStr(drivecb.SelectedItem) & " geschlossen!")
                End If
                keyencrypt.Enabled = True
                encrypttimer.Enabled = False
                If Timerclose = True Then
                    Application.Exit()
                End If
            Catch ex As Exception

            End Try
        End If
        decrypt_list_status.SelectedIndex = decrypt_list_status.Items.Count - 1
    End Sub

    Private Sub crypt_file_pathbutton_Click(sender As Object, e As EventArgs) Handles crypt_file_pathbutton.Click
        folder_dialog.ShowDialog()
        pathtxt.Text = folder_dialog.SelectedPath
        If Iniread = "yes" Then
            If Directory.Exists(pathtxt.Text) Then
                create_container_encrypt.Enabled = True
            Else
            End If
        End If
        If CInt(pathtxt.Text.Length) < 3 Then

        Else
            generate_key_encrypt.Enabled = True
        End If
    End Sub

    Private Sub generate_key_Click(sender As Object, e As EventArgs) Handles generate_key_encrypt.Click
        Dim numCharacters As Integer
        Dim i As Integer
        Dim txt = Nothing
        Dim ch As Integer
        Randomize()
        numCharacters = CInt(32)
        For i = 1 To numCharacters
            ch = CInt(Int((26 + 26 + 10) * Rnd()))
            If ch < 26 Then
                txt = txt & Chr(ch + Asc("A"))
            ElseIf ch < 2 * 26 Then
                ch = ch - 26
                txt = txt & Chr(ch + Asc("a"))
            Else
                ch = ch - 26 - 26
                txt = txt & Chr(ch + Asc("0"))
            End If
        Next i
        keycrypt.Text = txt
    End Sub

    Private Sub create_container_Click(sender As Object, e As EventArgs) Handles create_container_encrypt.Click
        If Iniread = "yes" Then
            Dim lastBackslash = CStr(pathtxt.Text.LastIndexOf("\", StringComparison.Ordinal))
            Dim removeStr As String = pathtxt.Text.Remove(0, CInt(CDbl(lastBackslash) + 1))
            _filezip.zip(pathtxt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip")
            If Langname = "English" Then
                encrypt_list_status.Items.Add("Path is then compressed...........")
                encrypt_list_status.SelectedIndex = 0
            Else
                encrypt_list_status.Items.Add("Pfad wird kompremiert..........")
            End If
            encrypttimer.Enabled = True
        Else
            If CInt(keycrypt.Text.Length) < 6 Then
                If Langname = "English" Then
                    MessageBox.Show("The key must have at least 6 characters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Der Schlüssel muss mindestens aus 6 Zeichen bestehen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                Dim lastBackslash = CStr(pathtxt.Text.LastIndexOf("\", StringComparison.Ordinal))
                Dim removeStr As String = pathtxt.Text.Remove(0, CInt(CDbl(lastBackslash) + 1))
                _filezip.zip(pathtxt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip")
                If Langname = "English" Then
                    encrypt_list_status.Items.Add(CStr("Path is then compressed..........."))
                Else
                    encrypt_list_status.Items.Add(CStr("Pfad wird kompremiert.........."))
                End If
                encrypttimer.Enabled = True
            End If
        End If
    End Sub

    Private Sub keycrypt_TextChanged(sender As Object, e As EventArgs) Handles keycrypt.TextChanged

        If krypt_passstrength.PasswordStrength(keycrypt.Text, keycrypt.Text.Length) = -0 Then
            Dim color As New designcolor
            keycrypt.BackColor = color.inputbackgroundcolor
        End If
        If krypt_passstrength.PasswordStrength(keycrypt.Text, keycrypt.Text.Length) = 1 Then
            keycrypt.BackColor = Color.Red
        End If
        If krypt_passstrength.PasswordStrength(keycrypt.Text, keycrypt.Text.Length) = 2 Then
            keycrypt.BackColor = Color.Yellow
        End If
        If krypt_passstrength.PasswordStrength(keycrypt.Text, keycrypt.Text.Length) = 3 Then
            keycrypt.BackColor = Color.GreenYellow
        End If
        If krypt_passstrength.PasswordStrength(keycrypt.Text, keycrypt.Text.Length) = 4 Then
            keycrypt.BackColor = Color.Lime
        End If
        If keycrypt.Text.Length < 6 Then
            create_container_encrypt.Enabled = False
        Else
            create_container_encrypt.Enabled = True
        End If
        If keycrypt.Text.Length < 6 Then

        Else
            create_container_encrypt.Enabled = True
        End If
    End Sub

    Private Sub Opencryptfile_Click(sender As Object, e As EventArgs) Handles opencryptfile.Click
        open_encrypt_dialog.ShowDialog()
        decrypt_filepath.Text = open_encrypt_dialog.FileName
        If Iniread = "yes" Then
            If File.Exists(decrypt_filepath.Text) Then
                mount.Enabled = True
            End If
        End If
    End Sub

    Private Sub cryptfile_path_TextChanged(sender As Object, e As EventArgs) Handles decrypt_filepath.TextChanged
        If Iniread = "yes" Then
            If File.Exists(decrypt_filepath.Text) Then
                mount.Enabled = True
            End If
        End If
        If decrypt_filepath.TextLength < 3 Then

        Else
            If File.Exists(decrypt_filepath.Text) = True Then
                keyencrypt.Enabled = True
            Else
                keyencrypt.Enabled = False
            End If
        End If
    End Sub

    Private Sub keyencrypt_TextChanged(sender As Object, e As EventArgs) Handles keyencrypt.TextChanged
        mount.Enabled = True
    End Sub

    

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = Formclose
        If e.Cancel = True Then
            e.Cancel = Formclose
            systemtray.Visible = True
            Hide()
            systemtray.BalloonTipIcon = ToolTipIcon.Info
            If Langname = "English" Then
                systemtray.BalloonTipText = "C: \ drive is embedded." & vbCrLf & "WinCrypt runs in the background!"
            Else
                systemtray.BalloonTipText = String.Format("Laufwerk {0} ist eingebunden.{1}WinCrypt läuft im hintergrund!", drivecb.Text, vbCrLf)
            End If
            systemtray.BalloonTipTitle = "WinCrypt"
            systemtray.ShowBalloonTip(3000)
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub startwindow_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '// Ordner hinzufügen zum verschlüsseln hotkey
        If e.KeyCode = Keys.E AndAlso e.Control = True Then
            crypt_file_pathbutton.PerformClick()
        End If

        '// Schlüssel generieren
        If e.KeyCode = Keys.G AndAlso e.Control = True Then
            If generate_key_encrypt.Enabled = True Then
                generate_key_encrypt.PerformClick()
            End If
        End If

        '// Container erstellen
        If e.KeyCode = Keys.C AndAlso e.Alt = True Then
            If generate_key_encrypt.Enabled = True Then
                create_container_encrypt.PerformClick()
            End If
        End If

        '//Ordner hinzufügen zum mounten hotkey
        If e.KeyCode = Keys.D AndAlso e.Control = True Then
            opencryptfile.PerformClick()
        End If

        '//Ordner mounten hotkey
        If e.KeyCode = Keys.M AndAlso e.Shift = True Then
            If mount.Enabled = True Then
                mount.PerformClick()
            End If
        End If

        '//Dismount
        If e.KeyCode = Keys.D AndAlso e.Shift = True Then
            If dismount.Enabled = True Then
                dismount.PerformClick()
            End If
        End If
    End Sub
    Private Sub startwindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _ini.worthreading("Info", "Lang") = "English" Then Language.ChangeLanguage("en-US")
        If _ini.worthreading("Info", "Lang") = "German" Then Language.ChangeLanguage("de-DE")


        Dim loadColor As New designcolor
        loadColor.color()

        Text = "WinCrypt " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        wincrypttitle.Text = Text
        Iniread = _ini.worthreading("systemidentification", "status")
        If My.Settings.Masterkey = True Then
            Masterkey.ShowDialog()
        Else
        End If
        _lang.check()
        Langname = _lang.langname

        If File.Exists(My.Application.Info.DirectoryPath.ToString & "\WinCryptRegistry.exe") Then

        Else
            Dim i As New FileStream(My.Application.Info.DirectoryPath & "\WinCryptRegistry.exe", FileMode.Create)
            i.Write(My.Resources.WinCryptRegistry, 0, CInt(My.Resources.WinCryptRegistry.Length))
            i.Close()
        End If

        If File.Exists(My.Application.Info.DirectoryPath.ToString & "\WinCryptUpdate.exe") Then

        Else
            Dim i As New FileStream(My.Application.Info.DirectoryPath & "\WinCryptUpdate.exe", FileMode.Create)
            i.Write(My.Resources.WinCryptUpdate, 0, CInt(My.Resources.WinCryptUpdate.Length))
            i.Close()
        End If


        Text = String.Format("WinCrypt {0}.{1}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        _ini.WertSchreiben("Info", "Version", My.Application.Info.Version.ToString.Replace(".", Nothing))
        If Iniread = "yes" Then
            generate_key_encrypt.Visible = False
            keycrypt.Visible = False
            key_lb1.Visible = False
            keyencrypt.Visible = False
            key_lb.Visible = False
            tools.text_encryption.Textencrypt.password_txt.Visible = False
            tools.text_encryption.Textencrypt.password_lb.Visible = False
            tools.text_encryption.Textencrypt.generate_bt.Visible = False
            tools.data_encryption.Filedecrypt.passwordtxt.Visible = False
            tools.data_encryption.Filedecrypt.pwdlb.Visible = False
            tools.data_encryption.Fileencrypt.passwordlb.Visible = False
            tools.data_encryption.Fileencrypt.passwordtxt.Visible = False
            tools.data_encryption.Fileencrypt.generatebt.Visible = False
            wincrypttitle.Text = String.Format("WinCrypt {0}.{1} (Systemidentifikation)", My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        Else
            If Iniread = "no" Then
                generate_key_encrypt.Visible = True
                keycrypt.Visible = True
                key_lb1.Visible = True
                keyencrypt.Visible = True
                key_lb.Visible = True
                tools.text_encryption.Textencrypt.password_txt.Visible = True
                tools.text_encryption.Textencrypt.password_lb.Visible = True
                tools.text_encryption.Textencrypt.generate_bt.Visible = True
                tools.data_encryption.Filedecrypt.passwordtxt.Visible = True
                tools.data_encryption.Filedecrypt.pwdlb.Visible = True
                tools.data_encryption.Fileencrypt.passwordlb.Visible = True
                tools.data_encryption.Fileencrypt.passwordtxt.Visible = True
                tools.data_encryption.Fileencrypt.generatebt.Visible = True
            End If
        End If
        For Each ver In _wmiobj.Instances_
            Biosid = ver.SerialNumber
            Biosid.Replace(" ", Nothing)
        Next
        For Each drives In DriveInfo.GetDrives
            drivecb.Items.Remove(drives.ToString)
        Next
    End Sub

    Private Function Registerfile(endung As String, namedesdateityps As String, pfadzuprogramm As String, pfadzuicon As String) As Boolean
        Try
            Dim objSubKey As RegistryKey
            Dim objSubKey2 As RegistryKey
            Dim wert As String = namedesdateityps
            Dim sKey As String = endung
            Dim sKey2 As String = endung & "\ShellNew"
            Dim sEntry = "Content Type"
            Dim sValue = "text/plain"
            Dim sEntry2 = "PerceivedType"
            Dim sValue2 = "text"
            Dim sEntry3 = "Nullfile"
            objSubKey = Registry.ClassesRoot.CreateSubKey(sKey)
            objSubKey.SetValue(Nothing, wert)
            objSubKey.SetValue(sEntry, sValue)
            objSubKey.SetValue(sEntry2, sValue2)
            objSubKey2 = Registry.ClassesRoot.CreateSubKey(sKey2)
            objSubKey2.SetValue(sEntry3, Nothing)
            Dim objSubKey3 As RegistryKey
            Dim sKey3 As String = namedesdateityps
            Dim sKey4 As String = namedesdateityps & "\shell\open\command"
            Dim skey5 As String = namedesdateityps & "\DefaultIcon"
            Dim sValue3 As String = namedesdateityps
            Dim objSubKey5 As RegistryKey
            Dim sValue5 As String = """" + pfadzuprogramm + """" + " %1"
            Dim sValue6 As String = """" + pfadzuicon + """"
            Dim objSubKey4 As RegistryKey
            objSubKey3 = Registry.ClassesRoot.CreateSubKey(sKey3)
            objSubKey3.SetValue(Nothing, sValue3)
            objSubKey4 = Registry.ClassesRoot.CreateSubKey(sKey4)
            objSubKey4.SetValue(Nothing, sValue5)
            objSubKey5 = Registry.ClassesRoot.CreateSubKey(skey5)
            objSubKey5.SetValue(Nothing, sValue6)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub startwindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim f As Form
        f = CType(sender, Form)
        If f.WindowState = FormWindowState.Minimized Then
            systemtray.Visible = True
            Hide()
            systemtray.BalloonTipIcon = ToolTipIcon.Info
            If Langname = "English" Then
                systemtray.BalloonTipText = "WinCrypt runs in the background!"
            Else
                systemtray.BalloonTipText = "WinCrypt läuft im hintergrund!"
            End If
            systemtray.BalloonTipTitle = "WinCrypt"
            systemtray.ShowBalloonTip(3000)
        End If
    End Sub

    Private Sub startwindow_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Try
            If My.Application.CommandLineArgs.Count > 0 Then
                Dim vArray As Array
                Dim commandlineargs As String = Environment.CommandLine
                vArray = Split(commandlineargs, """ ")
                Mypath = vArray(1)
                If Mypath = "-delete" Then
                    Hide()
                    vCommand = True
                    tools.safedelete.safedelete.ShowDialog()
                End If
                If Mypath = "-fileencrypt" Then
                    Hide()
                    vCommand = True
                    tools.data_encryption.Fileencrypt.ShowDialog()
                End If
                If Mypath = "-filedecrypt" Then
                    Hide()
                    vCommand = True
                    tools.data_encryption.Filedecrypt.ShowDialog()
                End If
                If Mypath = "-about" Then
                    Hide()
                    vCommand = True
                    about.ShowDialog()
                End If
                If Mypath = "-passwordmanager" Then
                    Hide()
                    vCommand = True
                    tools.passwordmanager.Passwordmanager.ShowDialog()
                End If
                If Mypath = "-passwordgenerator" Then
                    Hide()
                    vCommand = True
                    tools.passwordgenerator.passwordgenerator.ShowDialog()

                End If
                If Mypath = "-mail" Then
                    Hide()
                    vCommand = True
                    tools.mail.Sendmail.ShowDialog()
                End If
                If Mypath = "-txtencrypt" Then
                    Hide()
                    vCommand = True
                    tools.text_encryption.Textencrypt.ShowDialog()
                End If
                If Mypath = "-rsaencrypt" Then
                    Hide()
                    vCommand = True
                    tools.rsa.rsa_encrypt.ShowDialog()
                End If
                If Mypath = "-rsadecrypt" Then
                    Hide()
                    vCommand = True
                    tools.rsa.rsa_decrypt.ShowDialog()
                End If
                If Mypath = "-rsacreate" Then
                    Hide()
                    vCommand = True
                    tools.rsa.rsa_decrypt.ShowDialog()
                End If
                If Mypath.Remove(0, Mypath.LastIndexOf(".", StringComparison.Ordinal)) = ".wc" Then
                    tools.data_encryption.Filedecrypt.Show()
                    tools.data_encryption.Filedecrypt.filetxt.Text = Mypath.ToString
                    tools.data_encryption.Filedecrypt.pathtxt.Text = Mypath.Replace(".wc", Nothing)
                    tools.data_encryption.Filedecrypt.pathtxt.Enabled = True
                    tools.data_encryption.Filedecrypt.passwordtxt.Enabled = True
                    tools.data_encryption.Filedecrypt.savefile.Enabled = True
                    If Iniread = "yes" Then
                        tools.data_encryption.Filedecrypt.decrypt.Enabled = True
                    End If
                End If

                If Mypath.Remove(0, Mypath.LastIndexOf(".", StringComparison.Ordinal)) = ".wcp" Then
                    decrypt_filepath.Text = Mypath.ToString
                    If Iniread = "yes" Then
                        mount.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub systemtray_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles systemtray.MouseDoubleClick
        systemtray.Visible = False
        Show()
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub BeendenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles exit_bt_systemtray.Click
        If dismount.Enabled = True Then
            If _
                MessageBox.Show("Laufwerk " & drivecb.Text & " ist noch eingebunden!" & vbCrLf &
                    "Möchten Sie WinCrypt wirklich schließen?", "Laufwerk", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = MsgBoxResult.Yes Then
                Formclose = False
                Timerclose = True
                If dismount.Enabled = True Then
                    If Errormount = "error" Then

                    Else
                        Dim lastBackslash As Integer = CInt(decrypt_filepath.Text.LastIndexOf("\", StringComparison.Ordinal))
                        Dim removeStr As String = decrypt_filepath.Text.Remove(0, CInt(lastBackslash) + 1)
                        _filezip.zip(CStr(drivecb.SelectedItem),
                                    My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip")
                        If Langname = "English" Then
                            decrypt_list_status.Items.Add(CStr("Path is then compressed.........."))
                        Else
                            decrypt_list_status.Items.Add(CStr("Pfad wird kompremiert.........."))
                        End If
                        encryptmounttimer.Enabled = True
                        My.Computer.Audio.Play(My.Resources.Vista_DeviceDisconnect, AudioPlayMode.Background)
                        decrypt_filepath.Enabled = True
                        drivecb.Enabled = True
                    End If
                Else
                End If
            Else
            End If
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub decrypt_list_status_DragDrop(sender As Object, e As DragEventArgs) Handles decrypt_list_status.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
            str = filestr(0)
            decrypt_filepath.Text = str
        End If
    End Sub

    Private Sub decrypt_list_status_DragEnter(sender As Object, e As DragEventArgs) _
        Handles decrypt_list_status.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub encrypt_list_status_DragDrop(sender As Object, e As DragEventArgs) Handles encrypt_list_status.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
            str = filestr(0)
            pathtxt.Text = str
        End If
    End Sub

    Private Sub encrypt_list_status_DragEnter(sender As Object, e As DragEventArgs) _
        Handles encrypt_list_status.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub pathtxt_TextChanged(sender As Object, e As EventArgs) Handles pathtxt.TextChanged
        If Iniread = "yes" Then

            If Directory.Exists(pathtxt.Text) Then
                create_container_encrypt.Enabled = True
            Else
            End If
        End If

        If Directory.Exists(pathtxt.Text) = True Then
            generate_key_encrypt.Enabled = True
        Else
            generate_key_encrypt.Enabled = False
        End If
    End Sub

    Private Sub encrypt_list_status_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles encrypt_list_status.SelectedIndexChanged
        If _finishcrypt = 1 Then
            Dim _
                filesize As _
                    New FileStream(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & "f.zip",
                                   FileMode.Open)
            Dim fsize = CInt(Int(filesize.Length))
            filesize.Close()
            Dim _
                fstream As _
                    New StreamWriter(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & "f.zip")
            For o = 0 To CInt(fsize)
                fstream.Write(" ")
            Next
            fstream.Close()
            Do

                If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & "f.zip") = True Then
                    File.Delete(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & "f.zip")
                Else
                    Exit Do
                End If
            Loop
            _finishcrypt = 0
        Else
        End If
    End Sub

    Private Sub decrypt_list_status_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles decrypt_list_status.SelectedIndexChanged
        If _finunmount = 1 Then
            Try
                Dim di As New DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount")
                For Each fi As FileInfo In di.GetFiles("*.*", IO.SearchOption.AllDirectories)
                    Dim filesize As New FileStream(fi.FullName, FileMode.Open)
                    Dim fsize = CInt(Int(filesize.Length))
                    filesize.Close()
                    Dim fstream As New StreamWriter(fi.FullName)
                    For o = 0 To CInt(fsize)
                        fstream.Write(" ")
                    Next
                    fstream.Close()
                    Do
                        If File.Exists(fi.FullName) = True Then
                            File.Delete(fi.FullName)
                        Else
                            Exit Do
                        End If
                    Loop
                Next
                Directory.Delete(My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount", True)
                _finunmount = 0
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = MouseButtons.Left) Then
            wincrypttitle.Capture = False
            WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else
        End If
    End Sub

    Private Sub Minimizebt(sender As Object, e As EventArgs) Handles minimize_bt.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Exitbt(sender As Object, e As EventArgs) Handles exit_bt.Click
        Application.Exit()
    End Sub

    Private Sub exitbt_menu(sender As Object, e As EventArgs) Handles exit_bt_menu.Click
        Application.Exit()
    End Sub

    Private Sub settingbt_menu(sender As Object, e As EventArgs) Handles setting_bt_menu.Click
        WcSetting.Show()
    End Sub

    Private Sub fileencrypt_bt_menu(sender As Object, e As EventArgs)
        tools.data_encryption.Fileencrypt.Show()
    End Sub

    Private Sub filedecrypt_bt_menu(sender As Object, e As EventArgs)
        tools.data_encryption.Filedecrypt.Show()
    End Sub

    Private Sub textencrypt_bt_menu(sender As Object, e As EventArgs)
        tools.text_encryption.Textencrypt.Show()
    End Sub

    Private Sub send_mail_bt_menu_Click(sender As Object, e As EventArgs) Handles send_mail_bt_menu.Click
        tools.mail.Sendmail.Show()
    End Sub

    Private Sub pw_manager_bt_menu_Click(sender As Object, e As EventArgs) Handles pw_manager_bt_menu.Click
        tools.passwordmanager.Passwordmanager.Show()
    End Sub

    Private Sub export_db_bt_menu_Click(sender As Object, e As EventArgs) Handles export_db_bt_menu.Click

        If _
            File.Exists(String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))) Then
            export_db_dialog.ShowDialog()
            Try
                File.Copy(String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)),
                    export_db_dialog.FileName)
            Catch ex As Exception
                MessageBox.Show(ErrorToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            If Langname = "English" Then
                MessageBox.Show("Database has been exported successfully!", "database exported", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Datenbank wurde erfolgreich exportiert!", "Datenbank exportiert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If Langname = "English" Then
                MessageBox.Show("It has not yet created any database!" & vbCrLf &
                    "Specify in advance a database to be able to export them to.", "database", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Es wurde noch keine Datenbank angelegt!" & vbCrLf &
                    "Legen Sie vorher eine Datenbank an um diese exportieren zu können.", "Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub import_db_bt_menu_Click(sender As Object, e As EventArgs) Handles import_db_bt_menu.Click
        import_db_dialog.ShowDialog()
        If File.Exists(import_db_dialog.FileName) Then
            If _
                File.Exists(String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))) _
                Then
                If Langname = "English" Then
                    If MessageBox.Show("There is already a database." & vbCrLf & "Do you want to overwrite it?", "overwrite database", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        File.Copy(import_db_dialog.FileName,
                                                        String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)), True)
                        MessageBox.Show("Database has been imported successfully!", "database imported", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                    End If
                Else

                    If MessageBox.Show("Es existiert bereits eine Datenbank." & vbCrLf & "Möchten Sie diese überschreiben?", "Datenbank überschreiben", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        File.Copy(import_db_dialog.FileName,
                                                        String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)), True)
                        MessageBox.Show("Datenbank wurde erfolgreich Importiert!", "Datenbank importiert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                    End If
                End If
            Else
                File.Copy(import_db_dialog.FileName,
                                                String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)), True)
                If Langname = "English" Then
                    MessageBox.Show("Database has been imported successfully!", "database imported", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Datenbank wurde erfolgreich Importiert!", "Datenbank importiert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
        End If
    End Sub

    Private Sub delete_db_menu_Click(sender As Object, e As EventArgs) Handles delete_db_menu.Click
        If File.Exists(String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))) Then
            If Langname = "English" Then
                If MessageBox.Show("Do you really want to drop the database?", "database drop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    File.Delete(
                        String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
                    If Langname = "English" Then
                        MessageBox.Show("Database has been deleted!", "delete database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Datenbank wurde gelöscht!", "Datenbank gelöscht", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    If Langname = "English" Then
                        MessageBox.Show("Database has not been deleted!", "delete database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Datenbank wurde nicht gelöscht!", "Datenbank löschen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Else
                If MessageBox.Show("Wollen Sie wirklich die Datenbank löschen?", "Datenbank löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    File.Delete(
                        String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
                    If Langname = "English" Then
                        MessageBox.Show("Database has been deleted!", "database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Datenbank wurde gelöscht!", "Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    If Langname = "English" Then
                        MessageBox.Show("Database has not been deleted!", "database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Datenbank wurde nicht gelöscht!", "Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        Else
            If Langname = "English" Then
                MessageBox.Show("It has not yet created any database by deleting them!", "database", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Es wurde noch keine Datenbank angelegt um diese zu löschen!", "Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub systemidentification_bt_menu_Click(sender As Object, e As EventArgs) _
        Handles systemidentification_bt_menu.Click
        Systemidentification.Show()
    End Sub

    Private Sub pw_generator_bt_menu_Click(sender As Object, e As EventArgs) Handles pw_generator_bt_menu.Click
        tools.passwordgenerator.passwordgenerator.Show()
    End Sub

    Private Sub delete_file_bt_menu_Click(sender As Object, e As EventArgs) Handles delete_file_bt_menu.Click
        tools.safedelete.safedelete.Show()
    End Sub

    Private Sub update_bt_menu_Click(sender As Object, e As EventArgs) Handles update_bt_menu.Click
        Try
            Process.Start(My.Application.Info.DirectoryPath & "\WinCryptUpdate.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub feedback_bt_menu_Click(sender As Object, e As EventArgs) Handles feedback_bt_menu.Click
        feedback.Show()
    End Sub

    Private Sub about_bt_menu_Click(sender As Object, e As EventArgs) Handles about_bt_menu.Click
        about.ShowDialog()
    End Sub

    Private Sub open_bt_systemtray_Click(sender As Object, e As EventArgs) Handles open_bt_systemtray.Click
        systemtray.Visible = False
        Show()
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub feedback_bt_systemtray_Click(sender As Object, e As EventArgs) Handles feedback_bt_systemtray.Click
        feedback.Show()
    End Sub

    Private Sub about_bt_systemtray_Click(sender As Object, e As EventArgs) Handles about_bt_systemtray.Click
        about.ShowDialog()
    End Sub

    Private Sub update_bt_systemtray_Click(sender As Object, e As EventArgs) Handles update_bt_systemtray.Click
        Try
            Process.Start(Application.StartupPath & "\WinCryptUpdate.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub file_encrypt__bt_systemtray_Click(sender As Object, e As EventArgs) _
        Handles file_encrypt__bt_systemtray.Click
        tools.data_encryption.Fileencrypt.Show()
    End Sub

    Private Sub file_decrypt_bt_systemtray_Click(sender As Object, e As EventArgs) _
        Handles file_decrypt_bt_systemtray.Click
        tools.data_encryption.Filedecrypt.Show()
    End Sub

    Private Sub text_encrypt_bt_systemtray_Click(sender As Object, e As EventArgs) _
        Handles text_encrypt_bt_systemtray.Click
        tools.text_encryption.Textencrypt.Show()
    End Sub

    Private Sub md5_converter_bt_systemtray_Click(sender As Object, e As EventArgs) _
        Handles converter_bt_systemtray.Click
        tools.hash.converter.Show()
    End Sub

    Private Sub md5_bf_bt_systemtray_Click(sender As Object, e As EventArgs) Handles bf_bt_systemtray.Click
        tools.hash.Bruteforce.Show()
    End Sub

    Private Sub send_mail_bt_systemtray_Click(sender As Object, e As EventArgs) Handles send_mail_bt_systemtray.Click
        tools.mail.Sendmail.Show()
    End Sub

    Private Sub pw_manager_bt_systemtray_Click(sender As Object, e As EventArgs) Handles pw_manager_bt_systemtray.Click
        tools.passwordmanager.Passwordmanager.Show()
    End Sub

    Private Sub systemidentification_bt_systemtray_Click(sender As Object, e As EventArgs) _
        Handles systemidentification_bt_systemtray.Click
        Systemidentification.Show()
    End Sub

    Private Sub pwg_bt_systemtray_Click(sender As Object, e As EventArgs) Handles pwg_bt_systemtray.Click
        tools.passwordgenerator.passwordgenerator.Show()
    End Sub

    Private Sub file_delete_bt_systemtray_Click(sender As Object, e As EventArgs) _
        Handles file_delete_bt_systemtray.Click
        tools.safedelete.safedelete.Show()
    End Sub

    Private Sub rsa_encrypt_bt_systemtray_Click(sender As Object, e As EventArgs) _
        Handles rsa_encrypt_bt_systemtray.Click
        tools.rsa.rsa_decrypt.Show()
    End Sub

    Private Sub rsa_decrypt_bt_systemtray_Click(sender As Object, e As EventArgs) _
        Handles rsa_decrypt_bt_systemtray.Click
        tools.rsa.rsa_encrypt.Show()
    End Sub

    Private Sub rsa_create_keys_bt_systemtray_Click(sender As Object, e As EventArgs) _
        Handles rsa_create_keys_bt_systemtray.Click
        tools.rsa.rsa_create_keys.Show()
    End Sub

    Private Sub export_db_bt_systemtray_Click(sender As Object, e As EventArgs) Handles export_db_bt_systemtray.Click

        If File.Exists(String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))) Then
            export_db_dialog.ShowDialog()
            Try
                File.Copy(String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)),
                    export_db_dialog.FileName)
            Catch ex As Exception
                MessageBox.Show(ErrorToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            If Langname = "English" Then
                MessageBox.Show("Database has been exported successfully!", "database", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Datenbank wurde erfolgreich exportiert!", "Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If Langname = "English" Then
                MessageBox.Show("It has not yet created any database!" & vbCrLf &
                    "Specify in advance a database to be able to export them to.", "database", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Es wurde noch keine Datenbank angelegt!" & vbCrLf &
                    "Legen Sie vorher eine Datenbank an um diese exportieren zu können.", "Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub import_db_bt_systemtray_Click(sender As Object, e As EventArgs) Handles import_db_bt_systemtray.Click
        import_db_dialog.ShowDialog()
        If File.Exists(import_db_dialog.FileName) Then
            If _
                File.Exists(String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))) _
                Then
                If Langname = "English" Then
                    If _
                        MessageBox.Show("There is already a database." & vbCrLf & "Do you want to overwrite it?", "database", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        File.Copy(import_db_dialog.FileName,
                                                        String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)), True)
                        MessageBox.Show("Database has been imported successfully!", "database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                    End If
                Else

                    If _
                        MessageBox.Show("Es existiert bereits eine Datenbank." & vbCrLf & "Möchten Sie diese überschreiben?", "Datenbank", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        File.Copy(import_db_dialog.FileName,
                                                        String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)), True)
                        MessageBox.Show("Datenbank wurde erfolgreich Importiert!", "Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                    End If
                End If
            Else
                File.Copy(import_db_dialog.FileName,
                                                String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)), True)
                If Langname = "English" Then
                    MessageBox.Show("Database has been imported successfully!", "database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Datenbank wurde erfolgreich Importiert!", "Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
        End If
    End Sub

    Private Sub delete_db_bt_systemtray_Click(sender As Object, e As EventArgs) Handles delete_db_bt_systemtray.Click
        If _
            File.Exists(
                String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))) Then
            If Langname = "English" Then
                If MessageBox.Show("Do you really want to drop the database?", "database", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
                    File.Delete(
                        String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
                    If Langname = "English" Then
                        MessageBox.Show("Database has been deleted!", "databse", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Datenbank wurde gelöscht!", "Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    If Langname = "English" Then
                        MessageBox.Show("Database has not been deleted!", "database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Datenbank wurde nicht gelöscht!", "Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Else
                If MessageBox.Show("Wollen Sie wirklich die Datenbank löschen?", "Datenbank", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
                    File.Delete(
                        String.Format("{0}\WinCrypt\pwmanager.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
                    If Langname = "English" Then
                        MessageBox.Show("Database has been deleted!", "database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Datenbank wurde gelöscht!", "Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    If Langname = "English" Then
                        MessageBox.Show("Database has not been deleted!", "database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Datenbank wurde nicht gelöscht!", "Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        Else
            If Langname = "English" Then
                MessageBox.Show("It has not yet created any database by deleting them!", "database", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Es wurde noch keine Datenbank angelegt um diese zu löschen!", "Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub cleanlb1_Click(sender As Object, e As EventArgs) Handles cleanlb1.Click
        encrypt_list_status.Items.Clear()
    End Sub

    Private Sub cleanlb2_Click(sender As Object, e As EventArgs) Handles cleanlb2.Click
        decrypt_list_status.Items.Clear()
    End Sub

    Declare Function GetAsyncKeyState Lib "user32" (vkKey As Integer) As Short

    Private Sub gethotkey_Tick(sender As Object, e As EventArgs) Handles gethotkey.Tick
        If WindowState = FormWindowState.Minimized = True Then
            ' STRG+P öffnet den Passwortmanager
            If CBool(GetAsyncKeyState(Keys.F2)) AndAlso CBool(GetAsyncKeyState(Keys.ControlKey)) Then
                gethotkey.Enabled = False
                tools.passwordmanager.Passwordmanager.Show()
                tools.passwordmanager.Passwordmanager.Focus()
                tools.passwordmanager.passwordmgr_pass.Focus()
                Newpwmgrdatabase.Focus()
                gethotkey.Enabled = True
            End If

            ' Shift+P öffnet den Passwortgenerator
            If CBool(GetAsyncKeyState(Keys.F2)) AndAlso CBool(GetAsyncKeyState(Keys.LShiftKey)) Then
                gethotkey.Enabled = False
                tools.passwordgenerator.passwordgenerator.Show()
                tools.passwordgenerator.passwordgenerator.Focus()
                gethotkey.Enabled = True
            End If

            ' STRG+E öffnet Datei verschlüsseln
            If CBool(GetAsyncKeyState(Keys.F3)) AndAlso CBool(GetAsyncKeyState(Keys.ControlKey)) Then
                gethotkey.Enabled = False
                tools.data_encryption.Fileencrypt.Show()
                tools.data_encryption.Fileencrypt.Focus()
                gethotkey.Enabled = True
            End If

            ' STRG+D öffnet Datei entschlüsseln
            If CBool(GetAsyncKeyState(Keys.F4)) AndAlso CBool(GetAsyncKeyState(Keys.ControlKey)) Then
                gethotkey.Enabled = False
                tools.data_encryption.Filedecrypt.Show()
                tools.data_encryption.Filedecrypt.Focus()
                gethotkey.Enabled = True
            End If

            ' Shift+T öffnet das Text ver- und entschlüsseln fenster
            If CBool(GetAsyncKeyState(Keys.T)) AndAlso CBool(GetAsyncKeyState(Keys.LShiftKey)) Then
                gethotkey.Enabled = False
                tools.text_encryption.Textencrypt.Show()
                tools.text_encryption.Textencrypt.Focus()
                gethotkey.Enabled = True
            End If

            ' Shift+M öffnet das E-Mail senden fenster
            If CBool(GetAsyncKeyState(Keys.M)) AndAlso CBool(GetAsyncKeyState(Keys.LShiftKey)) Then
                gethotkey.Enabled = False
                tools.mail.Sendmail.Show()
                tools.mail.Sendmail.TopMost = True
                tools.mail.Sendmail.Focus()
                tools.mail.Sendmail.TopMost = False
                gethotkey.Enabled = True
            End If

            ' Shift+D öffnet das E-Mail senden fenster
            If CBool(GetAsyncKeyState(Keys.D)) AndAlso CBool(GetAsyncKeyState(Keys.LShiftKey)) Then
                gethotkey.Enabled = False
                tools.safedelete.safedelete.Show()
                tools.safedelete.safedelete.Focus()
                gethotkey.Enabled = True
            End If

            ' ShiftR+W öffnet WinCrypt
            If CBool(GetAsyncKeyState(Keys.W)) AndAlso CBool(GetAsyncKeyState(Keys.RShiftKey)) Then
                gethotkey.Enabled = False
                systemtray.Visible = False
                Show()
                WindowState = FormWindowState.Normal
                gethotkey.Enabled = True
            End If

            ' STRG+F8 öffnet das fenster RSA Verschlüsselung
            If CBool(GetAsyncKeyState(Keys.F8)) AndAlso CBool(GetAsyncKeyState(Keys.ControlKey)) Then
                gethotkey.Enabled = False
                tools.rsa.rsa_encrypt.Show()
                tools.rsa.rsa_encrypt.Focus()
                gethotkey.Enabled = True
            End If

            ' STRG+F9 öffnet das fenster RSA Entschlüsselung
            If CBool(GetAsyncKeyState(Keys.F9)) AndAlso CBool(GetAsyncKeyState(Keys.ControlKey)) Then
                gethotkey.Enabled = False
                tools.rsa.rsa_decrypt.Show()
                tools.rsa.rsa_decrypt.Focus()
                gethotkey.Enabled = True
            End If
        Else

        End If
    End Sub

    Private Sub form_head_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = MouseButtons.Left) Then
            wincrypttitle.Capture = False
            WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else
        End If
    End Sub

    Private Sub MD5DateiCheksumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles file_checksum_systray.Click
        FileHash_frm.Show()
    End Sub

    Private Sub rsa_encrypt_bt_menu_Click(sender As Object, e As EventArgs) Handles rsa_encrypt_bt_menu.Click
        tools.rsa.rsa_encrypt.Show()
    End Sub

    Private Sub rsa_decrypt_bt_menu_Click(sender As Object, e As EventArgs) Handles rsa_decrypt_bt_menu.Click
        tools.rsa.rsa_decrypt.Show()
    End Sub

    Private Sub rsa_create_keys_bt_menu_Click(sender As Object, e As EventArgs) Handles rsa_create_keys_bt_menu.Click
        tools.rsa.rsa_create_keys.Show()
    End Sub

    Private Sub md5_converter_bt_menu_Click(sender As Object, e As EventArgs) Handles md5_converter_bt_menu.Click
        tools.hash.converter.Show()
    End Sub

    Private Sub md5_bf_bt_menu_Click(sender As Object, e As EventArgs) Handles md5_bf_bt_menu.Click
        tools.hash.Bruteforce.Show()
    End Sub

    Private Sub MD5DateiChecksumToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles MD5DateiChecksumToolStripMenuItem.Click
        FileHash_frm.Show()
    End Sub

    Private Sub text_encrypt_bt_menu_Click(sender As Object, e As EventArgs) Handles text_encrypt_bt_menu.Click
        tools.text_encryption.Textencrypt.Show()

    End Sub

    Private Sub file_encrypt_bt_menu_Click(sender As Object, e As EventArgs) Handles file_encrypt_bt_menu.Click
        tools.data_encryption.Fileencrypt.Show()
    End Sub

    Private Sub file_decrypt_bt_menu_Click(sender As Object, e As EventArgs) Handles file_decrypt_bt_menu.Click
        tools.data_encryption.Filedecrypt.Show()
    End Sub
End Class
