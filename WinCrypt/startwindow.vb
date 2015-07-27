
Option Explicit On

Imports System.IO
Imports System.Threading
Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.Win32

Public Class Startwindow
    ReadOnly _filezip As New Zip
    Dim _selectcombo As String
    ReadOnly _wmiobj As Object = GetObject("winmgmts://localhost/root/cimv2:Win32_BIOS")
    Public Biosid As String
    Public Iniread As String
    Public Mypath As String
    Public Selecteddrive As String
    Public Langname As String
    Public Errormount As String
    Dim _removestring As String
    ReadOnly _lang As New language
    Public Formclose As Boolean = False
    Public Timerclose As Boolean = False
    Dim _finishcrypt As Integer = 0
    Dim _finunmount As Integer = 0
    ReadOnly _root As New DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)

    ReadOnly _
        _ini As _
            New INIDatei(_root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")

    Function GetFolderSize(dirPath As String,
                           Optional ByVal includeSubFolders As Boolean = True) As Long
        Dim lngDirSize As Long
        Dim objFileInfo As FileInfo
        Dim objDir = New DirectoryInfo(DirPath)
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
                My.Computer.FileSystem.RenameFile(
                    My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & ".zip", _removestring & "f.zip")
                If Langname = "English" Then
                    encrypt_list_status.Items.Add("Now is encrypted...........")
                Else
                    encrypt_list_status.Items.Add("Jetzt wird Verschlüsselt.......")
                End If
                encrypttimer.Enabled = True
                Dim computerName = "."
                Dim wmiServices = GetObject(
                    "winmgmts:{impersonationLevel=Impersonate}!//" & ComputerName)
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
                            If wmiLogicalDisk.DeviceID = pathtxt.Text.Replace("\", "") Then
                                Selecteddrive = deviceid
                            End If
                        Next
                    Next
                Next
                If _removestring = "" Then
                    tools.data_encryption.CryptFile(Biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & "f.zip",
                              My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & Selecteddrive.Replace(" ", "") &
                              ".wcp", True)
                Else
                    tools.data_encryption.CryptFile(Biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & "f.zip",
                              My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & _removestring.Replace(" ", "") &
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
                My.Computer.FileSystem.RenameFile(
                    My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & ".zip", _removestring & "f.zip")
                If Langname = "English" Then
                    encrypt_list_status.Items.Add("Now is encrypted...........")
                Else
                    encrypt_list_status.Items.Add("Jetzt wird Verschlüsselt.......")
                End If
                Dim computerName = "."
                Dim wmiServices = GetObject(
                    "winmgmts:{impersonationLevel=Impersonate}!//" & ComputerName)
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
                            If wmiLogicalDisk.DeviceID = pathtxt.Text.Replace("\", "") Then
                                Selecteddrive = deviceid
                            End If

                        Next
                    Next
                Next
                If _removestring = "" Then
                    tools.data_encryption.CryptFile(keycrypt.Text,
                              My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & "f.zip",
                              My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & Selecteddrive.Replace(" ", "") &
                              ".wcp", True)
                Else
                    tools.data_encryption.CryptFile(keycrypt.Text,
                              My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & "f.zip",
                              My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & _removestring.Replace(" ", "") &
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
        End If
        encrypt_list_status.SelectedIndex = encrypt_list_status.Items.Count - 1
    End Sub

    Private Sub mount_Click(sender As Object, e As EventArgs) Handles mount.Click
        Formclose = True
        Errormount = ""
        If Iniread = "yes" Then
            If drivecb.Text.Length > 2 Then
                keyencrypt.Enabled = False
                decrypt_filepath.Enabled = False
                drivecb.Enabled = False
                keyencrypt.UseSystemPasswordChar = True
                Dim lastBackslash As Integer = decrypt_filepath.Text.LastIndexOf("\", StringComparison.Ordinal)
                Dim removeStr As String = decrypt_filepath.Text.Remove(0, lastBackslash + 1)
                tools.data_encryption.DecryptFile(Biosid, decrypt_filepath.Text,
                            My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip")
                If Errormount = "error" Then

                Else
                    Dim file As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip"
                    Dim cu As New Unzip(file, Path.Combine(Path.GetDirectoryName(file), "unmount"))
                    cu.UnzipNow()
                    My.Computer.FileSystem.DeleteFile(
                        My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip")
                    Try
                        _selectcombo = CStr(drivecb.SelectedItem)
                        Shell(
                            "subst " & _selectcombo.Replace("\", "") & " " &
                            My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount")
                    Catch ex As Exception
                        If Langname = "English" Then
                            MsgBox("Error: Drive not found!", MsgBoxStyle.Critical)
                        Else
                            MsgBox("Fehler: Laufwerk nicht gefunden!", MsgBoxStyle.Critical)
                        End If
                        Application.Restart()
                    End Try
                    If Langname = "English" Then
                        decrypt_list_status.Items.Add("Container embedded!")
                    Else
                        decrypt_list_status.Items.Add("Container eingebunden!")
                    End If
                    My.Computer.Audio.Play(My.Resources.Vista_DeviceConnect, AudioPlayMode.WaitToComplete)
                    Process.Start("explorer.exe", CStr(drivecb.SelectedItem))
                    mount.Enabled = False
                    dismount.Enabled = True
                End If

            Else
                If Langname = "English" Then
                    MsgBox("Error: Drive not found!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Fehler: Laufwerk nicht gefunden!", MsgBoxStyle.Critical)
                End If
            End If
        Else
            If drivecb.Text.Length > 2 Then
                If Langname = "English" Then
                    decrypt_list_status.Items.Add("Container is decrypted.....")
                Else
                    decrypt_list_status.Items.Add("Container wird entschlüsselt.....")
                End If
                keyencrypt.Enabled = False
                decrypt_filepath.Enabled = False
                drivecb.Enabled = False
                keyencrypt.UseSystemPasswordChar = True
                Dim lastBackslash As Integer = decrypt_filepath.Text.LastIndexOf("\", StringComparison.Ordinal)
                Dim removeStr As String = decrypt_filepath.Text.Remove(0, lastBackslash + 1)
                tools.data_encryption.DecryptFile(keyencrypt.Text, decrypt_filepath.Text,
                            My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip")
                If Errormount = "error" Then

                Else
                    Dim file As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip"
                    Dim cu As New Unzip(file, Path.Combine(Path.GetDirectoryName(file), "unmount"))
                    cu.UnzipNow()
                    My.Computer.FileSystem.DeleteFile(
                        My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip")

                    Try
                        _selectcombo = CStr(drivecb.SelectedItem)
                        Shell(
                            "subst " & _selectcombo.Replace("\", "") & " " &
                            My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount")
                    Catch ex As Exception
                        If Langname = "English" Then
                            MsgBox("Error: Drive not found!", MsgBoxStyle.Critical)
                        Else
                            MsgBox("Fehler: Laufwerk nicht gefunden!", MsgBoxStyle.Critical)
                        End If
                        Application.Restart()
                    End Try
                    If Langname = "English" Then
                        decrypt_list_status.Items.Add("Container embedded!")
                    Else
                        decrypt_list_status.Items.Add("Container eingebunden!")
                    End If
                    My.Computer.Audio.Play(My.Resources.Vista_DeviceConnect, AudioPlayMode.WaitToComplete)
                    Process.Start("explorer.exe", CStr(drivecb.SelectedItem))
                    mount.Enabled = False
                    dismount.Enabled = True
                End If
            Else
                If Langname = "English" Then
                    MsgBox("Error: Drive not found!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Fehler: Laufwerk nicht gefunden!", MsgBoxStyle.Critical)
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
                My.Computer.FileSystem.RenameFile(
                    My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip", removeStr & "f.zip")
                If Langname = "English" Then
                    decrypt_list_status.Items.Add("Now is encrypted.......")
                Else
                    decrypt_list_status.Items.Add("Jetzt wird Verschlüsselt.......")
                End If
                If removeStr = "" Then
                    tools.data_encryption.CryptFile(Biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & "f.zip",
                              My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\Drive-" &
                              decrypt_filepath.Text.Replace(":\", "") & ".wcp", True)
                Else
                    tools.data_encryption.CryptFile(Biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & "f.zip",
                              My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\" &
                              removeStr.Replace(".wcp", "") & ".wcp", True)
                End If

                My.Computer.FileSystem.DeleteFile(
                    My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & "f.zip")

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
                Shell("subst " & _selectcombo.Replace("\", "") & " /D")
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
                My.Computer.FileSystem.RenameFile(
                    My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip", removeStr & "f.zip")

                If Langname = "English" Then
                    decrypt_list_status.Items.Add("Now is encrypted.......")
                Else
                    decrypt_list_status.Items.Add("Jetzt wird Verschlüsselt.......")
                End If
                If removeStr = "" Then
                    tools.data_encryption.CryptFile(keyencrypt.Text,
                              My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & "f.zip",
                              My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\Drive-" &
                              decrypt_filepath.Text.Replace(":\", "") & ".wcp", True)
                Else
                    tools.data_encryption.CryptFile(keyencrypt.Text,
                              My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & "f.zip",
                              My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\" &
                              removeStr.Replace(".wcp", "") & ".wcp", True)
                End If
                My.Computer.FileSystem.DeleteFile(
                    My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & "f.zip")
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
                Shell("subst " & _selectcombo.Replace("\", "") & " /D")
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
            If My.Computer.FileSystem.DirectoryExists(pathtxt.Text) Then
                create_container_encrypt.Enabled = True
            Else
            End If
        End If
        If pathtxt.Text.Length < 3 Then

        Else
            generate_key_encrypt.Enabled = True
        End If
    End Sub

    Private Sub generate_key_Click(sender As Object, e As EventArgs) Handles generate_key_encrypt.Click
        Dim numCharacters As Integer
        Dim i As Integer
        Dim txt = ""
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
            If keycrypt.Text.Length < 6 Then
                If Langname = "English" Then
                    MsgBox("The key must have at least 6 characters", MsgBoxStyle.Information)
                Else
                    MsgBox("Der Schlüssel muss mindestens aus 6 Zeichen bestehen", MsgBoxStyle.Information)
                End If
            Else
                Dim lastBackslash = CStr(pathtxt.Text.LastIndexOf("\", StringComparison.Ordinal))
                Dim removeStr As String = pathtxt.Text.Remove(0, CInt(CDbl(lastBackslash) + 1))
                _filezip.zip(pathtxt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removeStr & ".zip")
                If Langname = "English" Then
                    encrypt_list_status.Items.Add("Path is then compressed...........")
                Else
                    encrypt_list_status.Items.Add("Pfad wird kompremiert..........")
                End If
                encrypttimer.Enabled = True
            End If
        End If
    End Sub

    Private Sub keycrypt_TextChanged(sender As Object, e As EventArgs) Handles keycrypt.TextChanged
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
            If My.Computer.FileSystem.FileExists(decrypt_filepath.Text) Then
                mount.Enabled = True
            End If
        End If
    End Sub

    Private Sub cryptfile_path_TextChanged(sender As Object, e As EventArgs) Handles decrypt_filepath.TextChanged
        If Iniread = "yes" Then
            If My.Computer.FileSystem.FileExists(decrypt_filepath.Text) Then
                mount.Enabled = True
            End If
        End If
        If decrypt_filepath.TextLength < 3 Then

        Else
            If My.Computer.FileSystem.FileExists(decrypt_filepath.Text) = True Then
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
                systemtray.BalloonTipText = String.Format("{0}C: \ drive is embedded.{1}WinCrypt runs in the background!", drivecb.Text, vbCrLf)
            Else
                systemtray.BalloonTipText = String.Format("Laufwerk {0} ist eingebunden.{1}WinCrypt läuft im hintergrund!", drivecb.Text, vbCrLf)
            End If
            systemtray.BalloonTipTitle = String.Format("Win{0}Crypt", "ARG0")
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
        wincrypttitle.Text = String.Format("WinCrypt {0}.{1}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        Iniread = _ini.WertLesen("systemidentification", "status")
        If My.Settings.Masterkey = True Then
            masterkey.ShowDialog()
        Else
        End If
        _lang.check()
        Langname = _lang.langname
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath.ToString & "\WinCryptRegistry.exe") Then

        Else
            Dim i As New FileStream(My.Application.Info.DirectoryPath & "\WinCryptRegistry.exe", FileMode.Create)
            i.Write(My.Resources.WinCryptRegistry, 0, My.Resources.WinCryptRegistry.Length)
            i.Close()
        End If

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath.ToString & "\WinCryptUpdate.exe") Then

        Else
            Dim i As New FileStream(My.Application.Info.DirectoryPath & "\WinCryptUpdate.exe", FileMode.Create)
            i.Write(My.Resources.WinCryptUpdate, 0, My.Resources.WinCryptUpdate.Length)
            i.Close()
        End If


        Text = String.Format("WinCrypt {0}.{1}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        _ini.WertSchreiben("Info", "Version", My.Application.Info.Version.ToString.Replace(".", ""))
        If Iniread = "yes" Then
            generate_key_encrypt.Visible = False
            keycrypt.Visible = False
            key_lb1.Visible = False
            keyencrypt.Visible = False
            key_lb.Visible = False
            textencrypt.password_txt.Visible = False
            textencrypt.password_lb.Visible = False
            textencrypt.generate_bt.Visible = False
            tools.data_encryption.Filedecrypt.passwordtxt.Visible = False
            tools.data_encryption.Filedecrypt.pwdlb.Visible = False
            tools.data_encryption.Fileencrypt.passwordlb.Visible = False
            tools.data_encryption.Fileencrypt.passwordtxt.Visible = False
            tools.data_encryption.Fileencrypt.generatebt.Visible = False
            Text = String.Format("WinCrypt {0}.{1} (Systemidentifikation)", My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        Else
            If Iniread = "no" Then
                generate_key_encrypt.Visible = True
                keycrypt.Visible = True
                key_lb1.Visible = True
                keyencrypt.Visible = True
                key_lb.Visible = True
                textencrypt.password_txt.Visible = True
                textencrypt.password_lb.Visible = True
                textencrypt.generate_bt.Visible = True
                tools.data_encryption.Filedecrypt.passwordtxt.Visible = True
                tools.data_encryption.Filedecrypt.pwdlb.Visible = True
                tools.data_encryption.Fileencrypt.passwordlb.Visible = True
                tools.data_encryption.Fileencrypt.passwordtxt.Visible = True
                tools.data_encryption.Fileencrypt.generatebt.Visible = True
            End If
        End If
        For Each ver In _wmiobj.Instances_
            Biosid = ver.SerialNumber
            Biosid.Replace(" ", "")
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
            objSubKey = My.Computer.Registry.ClassesRoot.CreateSubKey(sKey)
            objSubKey.SetValue("", wert)
            objSubKey.SetValue(sEntry, sValue)
            objSubKey.SetValue(sEntry2, sValue2)
            objSubKey2 = My.Computer.Registry.ClassesRoot.CreateSubKey(sKey2)
            objSubKey2.SetValue(sEntry3, "")
            Dim objSubKey3 As RegistryKey
            Dim sKey3 As String = namedesdateityps
            Dim sKey4 As String = namedesdateityps & "\shell\open\command"
            Dim skey5 As String = namedesdateityps & "\DefaultIcon"
            Dim sValue3 As String = namedesdateityps
            Dim objSubKey5 As RegistryKey
            Dim sValue5 As String = """" + pfadzuprogramm + """" + " %1"
            Dim sValue6 As String = """" + pfadzuicon + """"
            Dim objSubKey4 As RegistryKey
            objSubKey3 = My.Computer.Registry.ClassesRoot.CreateSubKey(sKey3)
            objSubKey3.SetValue("", sValue3)
            objSubKey4 = My.Computer.Registry.ClassesRoot.CreateSubKey(sKey4)
            objSubKey4.SetValue("", sValue5)
            objSubKey5 = My.Computer.Registry.ClassesRoot.CreateSubKey(skey5)
            objSubKey5.SetValue("", sValue6)
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
                systemtray.BalloonTipText = String.Format("{0}WinCrypt runs in the background!", "ARG0")
            Else
                systemtray.BalloonTipText = String.Format("{0}WinCrypt läuft im hintergrund!", "ARG0")
            End If
            systemtray.BalloonTipTitle = String.Format("{0}WinCrypt", "ARG0")
            systemtray.ShowBalloonTip(3000)
        End If
    End Sub

    Private Sub startwindow_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If My.Application.CommandLineArgs.Count > 0 Then
            Dim vArray As Array
            Dim commandlineargs As String = Environment.CommandLine
            vArray = Split(commandlineargs, """ ")
            Mypath = vArray(1)
            If Mypath.Remove(0, Mypath.LastIndexOf(".", StringComparison.Ordinal)) = ".wc" Then
                tools.data_encryption.Filedecrypt.Show()
                tools.data_encryption.Filedecrypt.filetxt.Text = Mypath.ToString
                tools.data_encryption.Filedecrypt.pathtxt.Text = Mypath.Replace(".wc", "")
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
    End Sub

    Private Sub systemtray_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles systemtray.MouseDoubleClick
        systemtray.Visible = False
        Show()
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub BeendenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles exit_bt_systemtray.Click
        If dismount.Enabled = True Then
            If _
                MsgBox(
                    "Laufwerk " & drivecb.Text & " ist noch eingebunden!" & vbCrLf &
                    "Möchten Sie WinCrypt wirklich schließen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Formclose = False
                Timerclose = True
                If dismount.Enabled = True Then
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
            If My.Computer.FileSystem.DirectoryExists(pathtxt.Text) Then
                create_container_encrypt.Enabled = True
            Else
            End If
        End If
        If My.Computer.FileSystem.DirectoryExists(pathtxt.Text) = True Then
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
                If _
                    My.Computer.FileSystem.FileExists(
                        My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & "f.zip") = True Then
                    My.Computer.FileSystem.DeleteFile(
                        My.Computer.FileSystem.SpecialDirectories.Temp & "\" & _removestring & "f.zip")
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
                        If My.Computer.FileSystem.FileExists(fi.FullName) = True Then
                            My.Computer.FileSystem.DeleteFile(fi.FullName)
                        Else
                            Exit Do
                        End If
                    Loop
                Next
                My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount",
                                                       DeleteDirectoryOption.DeleteAllContents)
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
        wcSetting.Show()
    End Sub

    Private Sub fileencrypt_bt_menu(sender As Object, e As EventArgs) Handles file_encrypt_bt_menu.Click
        tools.data_encryption.Fileencrypt.Show()
    End Sub

    Private Sub filedecrypt_bt_menu(sender As Object, e As EventArgs) Handles file_decrypt_bt_menu.Click
        tools.data_encryption.Filedecrypt.Show()
    End Sub

    Private Sub textencrypt_bt_menu(sender As Object, e As EventArgs) Handles text_encrypt_bt_menu.Click
        textencrypt.Show()
    End Sub

    Private Sub md5_converter_bt_menu_Click(sender As Object, e As EventArgs) Handles md5_converter_bt_menu.Click
        converter.Show()
    End Sub

    Private Sub md5_bf_bt_menu_Click(sender As Object, e As EventArgs) Handles md5_bf_bt_menu.Click
        bruteforce.Show()
    End Sub

    Private Sub rsa_encrypt_bt_menu_Click(sender As Object, e As EventArgs) Handles rsa_encrypt_bt_menu.Click
        rsa_encrypt.Show()
    End Sub

    Private Sub rsa_decrypt_bt_menu_Click(sender As Object, e As EventArgs) Handles rsa_decrypt_bt_menu.Click
        rsa_decrypt.Show()
    End Sub

    Private Sub rsa_create_keys_bt_menu_Click(sender As Object, e As EventArgs) Handles rsa_create_keys_bt_menu.Click
        rsa_create_keys.Show()
    End Sub

    Private Sub send_mail_bt_menu_Click(sender As Object, e As EventArgs) Handles send_mail_bt_menu.Click
        sendmail.Show()
    End Sub

    Private Sub pw_manager_bt_menu_Click(sender As Object, e As EventArgs) Handles pw_manager_bt_menu.Click
        passwordmanager.Show()
    End Sub

    Private Sub export_db_bt_menu_Click(sender As Object, e As EventArgs) Handles export_db_bt_menu.Click
        If _
            My.Computer.FileSystem.FileExists(
                _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
            export_db_dialog.ShowDialog()
            Try
                My.Computer.FileSystem.CopyFile(
                    _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini",
                    export_db_dialog.FileName)
            Catch ex As Exception
                MsgBox(ErrorToString)
            End Try
            If Langname = "English" Then
                MsgBox("Database has been exported successfully!", MsgBoxStyle.Information)
            Else
                MsgBox("Datenbank wurde erfolgreich exportiert!", MsgBoxStyle.Information)
            End If
        Else
            If Langname = "English" Then
                MsgBox(
                    "It has not yet created any database!" & vbCrLf &
                    "Specify in advance a database to be able to export them to.", MsgBoxStyle.Exclamation)
            Else
                MsgBox(
                    "Es wurde noch keine Datenbank angelegt!" & vbCrLf &
                    "Legen Sie vorher eine Datenbank an um diese exportieren zu können.", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub import_db_bt_menu_Click(sender As Object, e As EventArgs) Handles import_db_bt_menu.Click
        import_db_dialog.ShowDialog()
        If My.Computer.FileSystem.FileExists(import_db_dialog.FileName) Then
            If _
                My.Computer.FileSystem.FileExists(
                    _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") _
                Then
                If Langname = "English" Then
                    If _
                        MsgBox("There is already a database." & vbCrLf & "Do you want to overwrite it?",
                               MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyFile(import_db_dialog.FileName,
                                                        _root.Root.FullName & "Users\" & Environment.UserName &
                                                        "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                        MsgBox("Database has been imported successfully!", MsgBoxStyle.Information)
                    Else
                    End If
                Else
                    If _
                        MsgBox("Es existiert bereits eine Datenbank." & vbCrLf & "Möchten Sie diese überschreiben?",
                               MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyFile(import_db_dialog.FileName,
                                                        _root.Root.FullName & "Users\" & Environment.UserName &
                                                        "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                        MsgBox("Datenbank wurde erfolgreich Importiert!", MsgBoxStyle.Information)
                    Else
                    End If
                End If
            Else
                My.Computer.FileSystem.CopyFile(import_db_dialog.FileName,
                                                _root.Root.FullName & "Users\" & Environment.UserName &
                                                "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                If Langname = "English" Then
                    MsgBox("Database has been imported successfully!", MsgBoxStyle.Information)
                Else
                    MsgBox("Datenbank wurde erfolgreich Importiert!", MsgBoxStyle.Information)
                End If
            End If
        Else
        End If
    End Sub

    Private Sub delete_db_menu_Click(sender As Object, e As EventArgs) Handles delete_db_menu.Click
        If _
            My.Computer.FileSystem.FileExists(
                _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
            If Langname = "English" Then
                If MsgBox("Do you really want to drop the database?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(
                        _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini")
                    If Langname = "English" Then
                        MsgBox("Database has been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde gelöscht!", MsgBoxStyle.Information)
                    End If
                Else
                    If Langname = "English" Then
                        MsgBox("Database has not been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde nicht gelöscht!", MsgBoxStyle.Information)
                    End If
                End If
            Else
                If MsgBox("Wollen Sie wirklich die Datenbank löschen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(
                        _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini")
                    If Langname = "English" Then
                        MsgBox("Database has been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde gelöscht!", MsgBoxStyle.Information)
                    End If
                Else
                    If Langname = "English" Then
                        MsgBox("Database has not been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde nicht gelöscht!", MsgBoxStyle.Information)
                    End If
                End If
            End If
        Else
            If Langname = "English" Then
                MsgBox("It has not yet created any database by deleting them!", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Es wurde noch keine Datenbank angelegt um diese zu löschen!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub systemidentification_bt_menu_Click(sender As Object, e As EventArgs) _
        Handles systemidentification_bt_menu.Click
        systemidentification.Show()
    End Sub

    Private Sub pw_generator_bt_menu_Click(sender As Object, e As EventArgs) Handles pw_generator_bt_menu.Click
        passwordgenerator.Show()
    End Sub

    Private Sub delete_file_bt_menu_Click(sender As Object, e As EventArgs) Handles delete_file_bt_menu.Click
        safedelete.Show()
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
            Process.Start(My.Application.Info.DirectoryPath & "\WinCryptUpdate.exe")
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
        textencrypt.Show()
    End Sub

    Private Sub md5_converter_bt_systemtray_Click(sender As Object, e As EventArgs) _
        Handles md5_converter_bt_systemtray.Click
        converter.Show()
    End Sub

    Private Sub md5_bf_bt_systemtray_Click(sender As Object, e As EventArgs) Handles md5_bf_bt_systemtray.Click
        bruteforce.Show()
    End Sub

    Private Sub send_mail_bt_systemtray_Click(sender As Object, e As EventArgs) Handles send_mail_bt_systemtray.Click
        sendmail.Show()
    End Sub

    Private Sub pw_manager_bt_systemtray_Click(sender As Object, e As EventArgs) Handles pw_manager_bt_systemtray.Click
        passwordmanager.Show()
    End Sub

    Private Sub systemidentification_bt_systemtray_Click(sender As Object, e As EventArgs) _
        Handles systemidentification_bt_systemtray.Click
        systemidentification.Show()
    End Sub

    Private Sub pwg_bt_systemtray_Click(sender As Object, e As EventArgs) Handles pwg_bt_systemtray.Click
        passwordgenerator.Show()
    End Sub

    Private Sub file_delete_bt_systemtray_Click(sender As Object, e As EventArgs) _
        Handles file_delete_bt_systemtray.Click
        safedelete.Show()
    End Sub

    Private Sub rsa_encrypt_bt_systemtray_Click(sender As Object, e As EventArgs) _
        Handles rsa_encrypt_bt_systemtray.Click
        rsa_decrypt.Show()
    End Sub

    Private Sub rsa_decrypt_bt_systemtray_Click(sender As Object, e As EventArgs) _
        Handles rsa_decrypt_bt_systemtray.Click
        rsa_encrypt.Show()
    End Sub

    Private Sub rsa_create_keys_bt_systemtray_Click(sender As Object, e As EventArgs) _
        Handles rsa_create_keys_bt_systemtray.Click
        rsa_create_keys.Show()
    End Sub

    Private Sub export_db_bt_systemtray_Click(sender As Object, e As EventArgs) Handles export_db_bt_systemtray.Click
        If _
            My.Computer.FileSystem.FileExists(
                _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
            export_db_dialog.ShowDialog()
            Try
                My.Computer.FileSystem.CopyFile(
                    _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini",
                    export_db_dialog.FileName)
            Catch ex As Exception
                MsgBox(ErrorToString)
            End Try
            If Langname = "English" Then
                MsgBox("Database has been exported successfully!", MsgBoxStyle.Information)
            Else
                MsgBox("Datenbank wurde erfolgreich exportiert!", MsgBoxStyle.Information)
            End If
        Else
            If Langname = "English" Then
                MsgBox(
                    "It has not yet created any database!" & vbCrLf &
                    "Specify in advance a database to be able to export them to.", MsgBoxStyle.Exclamation)
            Else
                MsgBox(
                    "Es wurde noch keine Datenbank angelegt!" & vbCrLf &
                    "Legen Sie vorher eine Datenbank an um diese exportieren zu können.", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub import_db_bt_systemtray_Click(sender As Object, e As EventArgs) Handles import_db_bt_systemtray.Click
        import_db_dialog.ShowDialog()
        If My.Computer.FileSystem.FileExists(import_db_dialog.FileName) Then
            If _
                My.Computer.FileSystem.FileExists(
                    _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") _
                Then
                If Langname = "English" Then
                    If _
                        MsgBox("There is already a database." & vbCrLf & "Do you want to overwrite it?",
                               MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyFile(import_db_dialog.FileName,
                                                        _root.Root.FullName & "Users\" & Environment.UserName &
                                                        "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                        MsgBox("Database has been imported successfully!", MsgBoxStyle.Information)
                    Else
                    End If
                Else
                    If _
                        MsgBox("Es existiert bereits eine Datenbank." & vbCrLf & "Möchten Sie diese überschreiben?",
                               MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyFile(import_db_dialog.FileName,
                                                        _root.Root.FullName & "Users\" & Environment.UserName &
                                                        "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                        MsgBox("Datenbank wurde erfolgreich Importiert!", MsgBoxStyle.Information)
                    Else
                    End If
                End If
            Else
                My.Computer.FileSystem.CopyFile(import_db_dialog.FileName,
                                                _root.Root.FullName & "Users\" & Environment.UserName &
                                                "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                If Langname = "English" Then
                    MsgBox("Database has been imported successfully!", MsgBoxStyle.Information)
                Else
                    MsgBox("Datenbank wurde erfolgreich Importiert!", MsgBoxStyle.Information)
                End If
            End If
        Else
        End If
    End Sub

    Private Sub delete_db_bt_systemtray_Click(sender As Object, e As EventArgs) Handles delete_db_bt_systemtray.Click
        If _
            My.Computer.FileSystem.FileExists(
                _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
            If Langname = "English" Then
                If MsgBox("Do you really want to drop the database?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(
                        _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini")
                    If Langname = "English" Then
                        MsgBox("Database has been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde gelöscht!", MsgBoxStyle.Information)
                    End If
                Else
                    If Langname = "English" Then
                        MsgBox("Database has not been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde nicht gelöscht!", MsgBoxStyle.Information)
                    End If
                End If
            Else
                If MsgBox("Wollen Sie wirklich die Datenbank löschen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(
                        _root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini")
                    If Langname = "English" Then
                        MsgBox("Database has been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde gelöscht!", MsgBoxStyle.Information)
                    End If
                Else
                    If Langname = "English" Then
                        MsgBox("Database has not been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde nicht gelöscht!", MsgBoxStyle.Information)
                    End If
                End If
            End If
        Else
            If Langname = "English" Then
                MsgBox("It has not yet created any database by deleting them!", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Es wurde noch keine Datenbank angelegt um diese zu löschen!", MsgBoxStyle.Exclamation)
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
                passwordmanager.Show()
                passwordmanager.Focus()
                passwordmgr_pass.Focus()
                newpwmgrdatabase.Focus()
                gethotkey.Enabled = True
            End If

            ' Shift+P öffnet den Passwortgenerator
            If CBool(GetAsyncKeyState(Keys.F2)) AndAlso CBool(GetAsyncKeyState(Keys.LShiftKey)) Then
                gethotkey.Enabled = False
                passwordgenerator.Show()
                passwordgenerator.Focus()
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
                textencrypt.Show()
                textencrypt.Focus()
                gethotkey.Enabled = True
            End If

            ' Shift+M öffnet das E-Mail senden fenster
            If CBool(GetAsyncKeyState(Keys.M)) AndAlso CBool(GetAsyncKeyState(Keys.LShiftKey)) Then
                gethotkey.Enabled = False
                sendmail.Show()
                sendmail.TopMost = True
                sendmail.Focus()
                sendmail.TopMost = False
                gethotkey.Enabled = True
            End If

            ' Shift+D öffnet das E-Mail senden fenster
            If CBool(GetAsyncKeyState(Keys.D)) AndAlso CBool(GetAsyncKeyState(Keys.LShiftKey)) Then
                gethotkey.Enabled = False
                safedelete.Show()
                safedelete.Focus()
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
                rsa_encrypt.Show()
                rsa_encrypt.Focus()
                gethotkey.Enabled = True
            End If

            ' STRG+F9 öffnet das fenster RSA Entschlüsselung
            If CBool(GetAsyncKeyState(Keys.F9)) AndAlso CBool(GetAsyncKeyState(Keys.ControlKey)) Then
                gethotkey.Enabled = False
                rsa_decrypt.Show()
                rsa_decrypt.Focus()
                gethotkey.Enabled = True
            End If
        Else

        End If
    End Sub

    Private Sub form_head_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
        If (e.Button = MouseButtons.Left) Then
            wincrypttitle.Capture = False
            WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else
        End If
    End Sub
End Class
