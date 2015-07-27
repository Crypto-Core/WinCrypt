
Option Explicit On
Imports System.IO
Imports System.Threading
Imports System.Net
Imports System
Imports System.Security.Principal
Imports System.Text
Public Class startwindow
    Dim filezip As New Zip
    Dim selectcombo As String
    Dim wmiobj As Object = GetObject("winmgmts://localhost/root/cimv2:Win32_BIOS")
    Public biosid As String
    Public iniread As String
    Public mypath As String
    Public selecteddrive As String
    Public langname As String
    Public errormount As String
    Dim removestring As String
    Dim lang As New language
    Public formclose As Boolean = False
    Public timerclose As Boolean = False
    Dim finishcrypt As Integer = 0
    Dim finunmount As Integer = 0
    Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
    Dim ini As New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")
    Function GetFolderSize(ByVal DirPath As String, _
   Optional ByVal IncludeSubFolders As Boolean = True) As Long
        Dim lngDirSize As Long
        Dim objFileInfo As FileInfo
        Dim objDir As DirectoryInfo = New DirectoryInfo(DirPath)
        Dim objSubFolder As DirectoryInfo
        Try
            For Each objFileInfo In objDir.GetFiles()
                lngDirSize += objFileInfo.Length
            Next

            If IncludeSubFolders Then
                For Each objSubFolder In objDir.GetDirectories()
                    lngDirSize += GetFolderSize(objSubFolder.FullName)
                Next
            End If
        Catch Ex As Exception

        End Try
        Return lngDirSize
    End Function

    Private Sub encrypttimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles encrypttimer.Tick
        finishcrypt = 0
        If iniread = "yes" Then
            Try
                Dim p As Integer = pathtxt.Text.LastIndexOf("\")
                removestring = pathtxt.Text.Remove(0, p + 1)
                My.Computer.FileSystem.RenameFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removestring & ".zip", removestring & "f.zip")
                If langname = "English" Then
                    encrypt_list_status.Items.Add("Now is encrypted...........")
                Else
                    encrypt_list_status.Items.Add("Jetzt wird Verschlüsselt.......")
                End If
                encrypttimer.Enabled = True
                Dim ComputerName = "."
                Dim wmiServices = GetObject( _
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
                                selecteddrive = deviceid
                            End If
                        Next
                    Next
                Next
                If removestring = "" Then
                    CryptoStuff.CryptFile(biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removestring & "f.zip", My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & selecteddrive.Replace(" ", "") & ".wcp", True)
                Else
                    CryptoStuff.CryptFile(biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removestring & "f.zip", My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & removestring.Replace(" ", "") & ".wcp", True)
                End If
                If langname = "English" Then
                    encrypt_list_status.Items.Add("Container encrypted.....")
                Else
                    encrypt_list_status.Items.Add("Container verschlüsselt.....")
                End If
                My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)
                finishcrypt = 1
                encrypttimer.Enabled = False
                If timerclose = True Then
                    Application.Exit()
                End If
            Catch ex As Exception

            End Try
        Else
            Try
                Dim last_backslash As Integer = pathtxt.Text.LastIndexOf("\")
                removestring = pathtxt.Text.Remove(0, last_backslash + 1)
                My.Computer.FileSystem.RenameFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removestring & ".zip", removestring & "f.zip")
                If langname = "English" Then
                    encrypt_list_status.Items.Add("Now is encrypted...........")
                Else
                    encrypt_list_status.Items.Add("Jetzt wird Verschlüsselt.......")
                End If
                Dim ComputerName = "."
                Dim wmiServices = GetObject( _
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
                                selecteddrive = deviceid
                            End If

                        Next
                    Next
                Next
                If removestring = "" Then
                    CryptoStuff.CryptFile(keycrypt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removestring & "f.zip", My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & selecteddrive.Replace(" ", "") & ".wcp", True)
                Else
                    CryptoStuff.CryptFile(keycrypt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removestring & "f.zip", My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & removestring.Replace(" ", "") & ".wcp", True)
                End If
                If langname = "English" Then
                    encrypt_list_status.Items.Add("Container encrypted.....")
                Else
                    encrypt_list_status.Items.Add("Container verschlüsselt.....")
                End If
                My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)
                finishcrypt = 1
                encrypttimer.Enabled = False
                If timerclose = True Then
                    Application.Exit()
                End If
            Catch ex As Exception

            End Try
        End If
        encrypt_list_status.SelectedIndex = encrypt_list_status.Items.Count - 1
    End Sub

    Private Sub mount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mount.Click
        formclose = True
        errormount = ""
        If iniread = "yes" Then
            If drivecb.Text.Length > 2 Then
                keyencrypt.Enabled = False
                decrypt_filepath.Enabled = False
                drivecb.Enabled = False
                keyencrypt.UseSystemPasswordChar = True
                Dim last_backslash As Integer = decrypt_filepath.Text.LastIndexOf("\")
                Dim remove_str As String = decrypt_filepath.Text.Remove(0, last_backslash + 1)
                CryptoStuff.DecryptFile(biosid, decrypt_filepath.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & ".zip")
                If errormount = "error" Then

                Else
                    Dim file As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & ".zip"
                    Dim cu As New Unzip(file, Path.Combine(Path.GetDirectoryName(file), "unmount"))
                    cu.UnzipNow()
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & ".zip")
                    Try
                        selectcombo = CStr(drivecb.SelectedItem)
                        Shell("subst " & selectcombo.Replace("\", "") & " " & My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount")
                    Catch ex As Exception
                        If langname = "English" Then
                            MsgBox("Error: Drive not found!", MsgBoxStyle.Critical)
                        Else
                            MsgBox("Fehler: Laufwerk nicht gefunden!", MsgBoxStyle.Critical)
                        End If
                        Application.Restart()
                    End Try
                    If langname = "English" Then
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
                If langname = "English" Then
                    MsgBox("Error: Drive not found!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Fehler: Laufwerk nicht gefunden!", MsgBoxStyle.Critical)
                End If
            End If
        Else
            If drivecb.Text.Length > 2 Then
                If langname = "English" Then
                    decrypt_list_status.Items.Add("Container is decrypted.....")
                Else
                    decrypt_list_status.Items.Add("Container wird entschlüsselt.....")
                End If
                keyencrypt.Enabled = False
                decrypt_filepath.Enabled = False
                drivecb.Enabled = False
                keyencrypt.UseSystemPasswordChar = True
                Dim last_backslash As Integer = decrypt_filepath.Text.LastIndexOf("\")
                Dim remove_str As String = decrypt_filepath.Text.Remove(0, last_backslash + 1)
                CryptoStuff.DecryptFile(keyencrypt.Text, decrypt_filepath.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & ".zip")
                If errormount = "error" Then

                Else
                    Dim file As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & ".zip"
                    Dim cu As New Unzip(file, Path.Combine(Path.GetDirectoryName(file), "unmount"))
                    cu.UnzipNow()
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & ".zip")

                    Try
                        selectcombo = CStr(drivecb.SelectedItem)
                        Shell("subst " & selectcombo.Replace("\", "") & " " & My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount")
                    Catch ex As Exception
                        If langname = "English" Then
                            MsgBox("Error: Drive not found!", MsgBoxStyle.Critical)
                        Else
                            MsgBox("Fehler: Laufwerk nicht gefunden!", MsgBoxStyle.Critical)
                        End If
                        Application.Restart()
                    End Try
                    If langname = "English" Then
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
                If langname = "English" Then
                    MsgBox("Error: Drive not found!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Fehler: Laufwerk nicht gefunden!", MsgBoxStyle.Critical)
                End If
            End If
        End If
        decrypt_list_status.SelectedIndex = decrypt_list_status.Items.Count - 1
    End Sub

    Private Sub dismount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dismount.Click
        formclose = False
        If errormount = "error" Then

        Else
            Dim last_backslash As Integer = decrypt_filepath.Text.LastIndexOf("\")
            Dim remove_str As String = decrypt_filepath.Text.Remove(0, last_backslash + 1)
            filezip.zip(CStr(drivecb.SelectedItem), My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & ".zip")
            If langname = "English" Then
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

    Private Sub encryptmounttimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles encryptmounttimer.Tick
        If iniread = "yes" Then
            Try
                Dim last_backslash As Integer = decrypt_filepath.Text.LastIndexOf("\")
                Dim remove_str As String = decrypt_filepath.Text.Remove(0, last_backslash + 1)
                My.Computer.FileSystem.RenameFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & ".zip", remove_str & "f.zip")
                If langname = "English" Then
                    decrypt_list_status.Items.Add("Now is encrypted.......")
                Else
                    decrypt_list_status.Items.Add("Jetzt wird Verschlüsselt.......")
                End If
                If remove_str = "" Then
                    CryptoStuff.CryptFile(biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & "f.zip", My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\Drive-" & decrypt_filepath.Text.Replace(":\", "") & ".wcp", True)
                Else
                    CryptoStuff.CryptFile(biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & "f.zip", My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\" & remove_str.Replace(".wcp", "") & ".wcp", True)
                End If

                My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & "f.zip")

                If langname = "English" Then
                    decrypt_list_status.Items.Add("Encryption completed!")
                Else
                    decrypt_list_status.Items.Add("Verschlüsselung abgeschlossen!")
                End If

                If langname = "English" Then
                    decrypt_list_status.Items.Add(CStr(drivecb.SelectedItem) & " drive will be closed...")
                Else
                    decrypt_list_status.Items.Add("Laufwerk " & CStr(drivecb.SelectedItem) & " wird geschlossen...")
                End If
                dismount.Enabled = False
                Shell("subst " & selectcombo.Replace("\", "") & " /D")
                Threading.Thread.Sleep(3000)
                mount.Enabled = True
                keyencrypt.UseSystemPasswordChar = False
                finunmount = 1
                If langname = "English" Then
                    decrypt_list_status.Items.Add("Closed drive " & CStr(drivecb.SelectedItem))
                Else
                    decrypt_list_status.Items.Add("Laufwerk " & CStr(drivecb.SelectedItem) & " geschlossen!")
                End If
                keyencrypt.Enabled = True
                encrypttimer.Enabled = False
                If timerclose = True Then
                    Application.Exit()
                End If
            Catch ex As Exception

            End Try
        Else
            Try
                Dim last_backslash As String = CStr(decrypt_filepath.Text.LastIndexOf("\"))
                Dim remove_str As String = decrypt_filepath.Text.Remove(0, CInt(CDbl(last_backslash) + 1))
                My.Computer.FileSystem.RenameFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & ".zip", remove_str & "f.zip")

                If langname = "English" Then
                    decrypt_list_status.Items.Add("Now is encrypted.......")
                Else
                    decrypt_list_status.Items.Add("Jetzt wird Verschlüsselt.......")
                End If
                If remove_str = "" Then
                    CryptoStuff.CryptFile(keyencrypt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & "f.zip", My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\Drive-" & decrypt_filepath.Text.Replace(":\", "") & ".wcp", True)
                Else
                    CryptoStuff.CryptFile(keyencrypt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & "f.zip", My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\" & remove_str.Replace(".wcp", "") & ".wcp", True)
                End If
                My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & "f.zip")
                If langname = "English" Then
                    decrypt_list_status.Items.Add("Encryption completed!")
                Else
                    decrypt_list_status.Items.Add("Verschlüsselung abgeschlossen!")
                End If

                If langname = "English" Then
                    decrypt_list_status.Items.Add(CStr(drivecb.SelectedItem) & " drive will be closed...")
                Else
                    decrypt_list_status.Items.Add("Laufwerk " & CStr(drivecb.SelectedItem) & " wird geschlossen...")
                End If
                dismount.Enabled = False
                Shell("subst " & selectcombo.Replace("\", "") & " /D")
                Threading.Thread.Sleep(3000)
                mount.Enabled = True
                keyencrypt.UseSystemPasswordChar = False
                finunmount = 1
                If langname = "English" Then
                    decrypt_list_status.Items.Add("Drive " & CStr(drivecb.SelectedItem) & " closed!")
                Else
                    decrypt_list_status.Items.Add("Laufwerk " & CStr(drivecb.SelectedItem) & " geschlossen!")
                End If
                keyencrypt.Enabled = True
                encrypttimer.Enabled = False
                If timerclose = True Then
                    Application.Exit()
                End If
            Catch ex As Exception

            End Try
        End If
        decrypt_list_status.SelectedIndex = decrypt_list_status.Items.Count - 1
    End Sub
    Private Sub crypt_file_pathbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crypt_file_pathbutton.Click
        folder_dialog.ShowDialog()
        pathtxt.Text = folder_dialog.SelectedPath
        If iniread = "yes" Then
            If My.Computer.FileSystem.DirectoryExists(pathtxt.Text) Then
                create_container_encrypt.Enabled = True
            Else : End If
        End If
        If pathtxt.Text.Length < 3 Then

        Else
            generate_key_encrypt.Enabled = True
        End If
    End Sub
    Private Sub generate_key_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generate_key_encrypt.Click
        Dim num_characters As Integer
        Dim i As Integer
        Dim txt As String = ""
        Dim ch As Integer
        Randomize()
        num_characters = CInt(32)
        For i = 1 To num_characters
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

    Private Sub create_container_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles create_container_encrypt.Click
        If iniread = "yes" Then
            Dim last_backslash As String = CStr(pathtxt.Text.LastIndexOf("\"))
            Dim remove_str As String = pathtxt.Text.Remove(0, CInt(CDbl(last_backslash) + 1))
            filezip.zip(pathtxt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & ".zip")
            If langname = "English" Then
                encrypt_list_status.Items.Add("Path is then compressed...........")
                encrypt_list_status.SelectedIndex = 0
            Else
                encrypt_list_status.Items.Add("Pfad wird kompremiert..........")
            End If
            encrypttimer.Enabled = True
        Else
            If keycrypt.Text.Length < 6 Then
                If langname = "English" Then
                    MsgBox("The key must have at least 6 characters", MsgBoxStyle.Information)
                Else
                    MsgBox("Der Schlüssel muss mindestens aus 6 Zeichen bestehen", MsgBoxStyle.Information)
                End If
            Else
                Dim last_backslash As String = CStr(pathtxt.Text.LastIndexOf("\"))
                Dim remove_str As String = pathtxt.Text.Remove(0, CInt(CDbl(last_backslash) + 1))
                filezip.zip(pathtxt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & ".zip")
                If langname = "English" Then
                    encrypt_list_status.Items.Add("Path is then compressed...........")
                Else
                    encrypt_list_status.Items.Add("Pfad wird kompremiert..........")
                End If
                encrypttimer.Enabled = True
            End If
        End If
    End Sub

    Private Sub keycrypt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keycrypt.TextChanged
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

    Private Sub Opencryptfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opencryptfile.Click
        open_encrypt_dialog.ShowDialog()
        decrypt_filepath.Text = open_encrypt_dialog.FileName
        If iniread = "yes" Then
            If My.Computer.FileSystem.FileExists(decrypt_filepath.Text) Then
                mount.Enabled = True
            End If
        End If
    End Sub
    Private Sub cryptfile_path_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decrypt_filepath.TextChanged
        If iniread = "yes" Then
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

    Private Sub keyencrypt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keyencrypt.TextChanged
        mount.Enabled = True
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = formclose
        If e.Cancel = True Then
            e.Cancel = formclose
            systemtray.Visible = True
            Me.Hide()
            systemtray.BalloonTipIcon = ToolTipIcon.Info
            If langname = "English" Then
                systemtray.BalloonTipText = drivecb.Text & "C: \ drive is embedded." & vbCrLf & "WinCrypt runs in the background!"
            Else
                systemtray.BalloonTipText = "Laufwerk " & drivecb.Text & " ist eingebunden." & vbCrLf & "WinCrypt läuft im hintergrund!"
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
    Private Sub startwindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        wincrypttitle.Text = "WinCrypt " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        iniread = ini.WertLesen("systemidentification", "status")
        If My.Settings.Masterkey = True Then
            masterkey.ShowDialog()
        Else : End If
        lang.check()
        langname = lang.langname
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath.ToString & "\WinCryptRegistry.exe") Then

        Else
            Dim i As New System.IO.FileStream(My.Application.Info.DirectoryPath & "\WinCryptRegistry.exe", FileMode.Create)
            i.Write(My.Resources.WinCryptRegistry, 0, My.Resources.WinCryptRegistry.Length)
            i.Close()
        End If

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath.ToString & "\WinCryptUpdate.exe") Then

        Else
            Dim i As New System.IO.FileStream(My.Application.Info.DirectoryPath & "\WinCryptUpdate.exe", FileMode.Create)
            i.Write(My.Resources.WinCryptUpdate, 0, My.Resources.WinCryptUpdate.Length)
            i.Close()
        End If


        Me.Text = "WinCrypt " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        ini.WertSchreiben("Info", "Version", My.Application.Info.Version.ToString.Replace(".", ""))
        If iniread = "yes" Then
            generate_key_encrypt.Visible = False
            keycrypt.Visible = False
            key_lb1.Visible = False
            keyencrypt.Visible = False
            key_lb.Visible = False
            textencrypt.password_txt.Visible = False
            textencrypt.password_lb.Visible = False
            textencrypt.generate_bt.Visible = False
            filedecrypt.passwordtxt.Visible = False
            filedecrypt.pwdlb.Visible = False
            fileencrypt.passwordlb.Visible = False
            fileencrypt.passwordtxt.Visible = False
            fileencrypt.generatebt.Visible = False
            Me.Text = "WinCrypt " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & " (Systemidentifikation)"
        Else
            If iniread = "no" Then
                generate_key_encrypt.Visible = True
                keycrypt.Visible = True
                key_lb1.Visible = True
                keyencrypt.Visible = True
                key_lb.Visible = True
                textencrypt.password_txt.Visible = True
                textencrypt.password_lb.Visible = True
                textencrypt.generate_bt.Visible = True
                filedecrypt.passwordtxt.Visible = True
                filedecrypt.pwdlb.Visible = True
                fileencrypt.passwordlb.Visible = True
                fileencrypt.passwordtxt.Visible = True
                fileencrypt.generatebt.Visible = True
            End If
        End If
        For Each ver In wmiobj.Instances_
            biosid = ver.SerialNumber
            biosid.Replace(" ", "")
        Next
        For Each drives In IO.DriveInfo.GetDrives
            drivecb.Items.Remove(drives.ToString)
        Next
    End Sub

    Private Function Registerfile(ByVal endung As String, ByVal namedesdateityps As String, ByVal pfadzuprogramm As String, ByVal pfadzuicon As String) As Boolean
        Try
            Dim objSubKey As Microsoft.Win32.RegistryKey
            Dim objSubKey2 As Microsoft.Win32.RegistryKey
            Dim Wert As String = namedesdateityps
            Dim sKey As String = endung
            Dim sKey2 As String = endung & "\ShellNew"
            Dim sEntry As String = "Content Type"
            Dim sValue As String = "text/plain"
            Dim sEntry2 As String = "PerceivedType"
            Dim sValue2 As String = "text"
            Dim sEntry3 As String = "Nullfile"
            objSubKey = My.Computer.Registry.ClassesRoot.CreateSubKey(sKey)
            objSubKey.SetValue("", Wert)
            objSubKey.SetValue(sEntry, sValue)
            objSubKey.SetValue(sEntry2, sValue2)
            objSubKey2 = My.Computer.Registry.ClassesRoot.CreateSubKey(sKey2)
            objSubKey2.SetValue(sEntry3, "")
            Dim objSubKey3 As Microsoft.Win32.RegistryKey
            Dim sKey3 As String = namedesdateityps
            Dim sKey4 As String = namedesdateityps & "\shell\open\command"
            Dim skey5 As String = namedesdateityps & "\DefaultIcon"
            Dim sValue3 As String = namedesdateityps
            Dim objSubKey5 As Microsoft.Win32.RegistryKey
            Dim sValue5 As String = """" + pfadzuprogramm + """" + " %1"
            Dim sValue6 As String = """" + pfadzuicon + """"
            Dim objSubKey4 As Microsoft.Win32.RegistryKey
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

    Private Sub startwindow_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim f As Form
        f = CType(sender, Form)
        If f.WindowState = FormWindowState.Minimized Then
            systemtray.Visible = True
            Me.Hide()
            systemtray.BalloonTipIcon = ToolTipIcon.Info
            If langname = "English" Then
                systemtray.BalloonTipText = "WinCrypt runs in the background!"
            Else
                systemtray.BalloonTipText = "WinCrypt läuft im hintergrund!"
            End If
            systemtray.BalloonTipTitle = "WinCrypt"
            systemtray.ShowBalloonTip(3000)
        End If
    End Sub

    Private Sub startwindow_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If My.Application.CommandLineArgs.Count > 0 Then
            Dim v_array As Array
            Dim commandlineargs As String = Environment.CommandLine
            v_array = Split(commandlineargs, """ ")
            mypath = v_array(1)
            If mypath.Remove(0, mypath.LastIndexOf(".")) = ".wc" Then
                filedecrypt.Show()
                filedecrypt.filetxt.Text = mypath.ToString
                filedecrypt.pathtxt.Text = mypath.Replace(".wc", "")
                filedecrypt.pathtxt.Enabled = True
                filedecrypt.passwordtxt.Enabled = True
                filedecrypt.savefile.Enabled = True
                If iniread = "yes" Then
                    filedecrypt.decrypt.Enabled = True
                End If
            End If

            If mypath.Remove(0, mypath.LastIndexOf(".")) = ".wcp" Then
                decrypt_filepath.Text = mypath.ToString
                If iniread = "yes" Then
                    mount.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub systemtray_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles systemtray.MouseDoubleClick
        systemtray.Visible = False
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BeendenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_bt_systemtray.Click
        If dismount.Enabled = True Then
            If MsgBox("Laufwerk " & drivecb.Text & " ist noch eingebunden!" & vbCrLf & "Möchten Sie WinCrypt wirklich schließen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                formclose = False
                timerclose = True
                If dismount.Enabled = True Then
                    If errormount = "error" Then

                    Else
                        Dim last_backslash As Integer = decrypt_filepath.Text.LastIndexOf("\")
                        Dim remove_str As String = decrypt_filepath.Text.Remove(0, last_backslash + 1)
                        filezip.zip(CStr(drivecb.SelectedItem), My.Computer.FileSystem.SpecialDirectories.Temp & "\" & remove_str & ".zip")
                        If langname = "English" Then
                            decrypt_list_status.Items.Add("Path is then compressed..........")
                        Else
                            decrypt_list_status.Items.Add("Pfad wird kompremiert..........")
                        End If
                        encryptmounttimer.Enabled = True
                        My.Computer.Audio.Play(My.Resources.Vista_DeviceDisconnect, AudioPlayMode.Background)
                        decrypt_filepath.Enabled = True
                        drivecb.Enabled = True
                    End If
                Else : End If
            Else : End If
        Else
            Application.Exit()
        End If

    End Sub
    Private Sub decrypt_list_status_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles decrypt_list_status.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
            str = filestr(0)
            decrypt_filepath.Text = str
        End If
    End Sub

    Private Sub decrypt_list_status_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles decrypt_list_status.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub encrypt_list_status_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles encrypt_list_status.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
            str = filestr(0)
            pathtxt.Text = str
        End If
    End Sub

    Private Sub encrypt_list_status_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles encrypt_list_status.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub pathtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pathtxt.TextChanged
        If iniread = "yes" Then
            If My.Computer.FileSystem.DirectoryExists(pathtxt.Text) Then
                create_container_encrypt.Enabled = True
            Else : End If
        End If
        If My.Computer.FileSystem.DirectoryExists(pathtxt.Text) = True Then
            generate_key_encrypt.Enabled = True
        Else
            generate_key_encrypt.Enabled = False
        End If
    End Sub
    Private Sub encrypt_list_status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles encrypt_list_status.SelectedIndexChanged
        If finishcrypt = 1 Then
            Dim filesize As New System.IO.FileStream(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removestring & "f.zip", IO.FileMode.Open)
            Dim fsize As Integer = CInt(Int(filesize.Length))
            filesize.Close()
            Dim fstream As New System.IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removestring & "f.zip")
            For o As Integer = 0 To CInt(fsize)
                fstream.Write(" ")
            Next
            fstream.Close()
            Do
                If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removestring & "f.zip") = True Then
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & removestring & "f.zip")
                Else
                    Exit Do
                End If
            Loop
            finishcrypt = 0
        Else : End If
    End Sub
    Private Sub decrypt_list_status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles decrypt_list_status.SelectedIndexChanged
        If finunmount = 1 Then
            Try
                Dim di As New System.IO.DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount")
                For Each fi As System.IO.FileInfo In di.GetFiles("*.*", System.IO.SearchOption.AllDirectories)
                    Dim filesize As New System.IO.FileStream(fi.FullName, IO.FileMode.Open)
                    Dim fsize As Integer = CInt(Int(filesize.Length))
                    filesize.Close()
                    Dim fstream As New System.IO.StreamWriter(fi.FullName)
                    For o As Integer = 0 To CInt(fsize)
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
                My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount", FileIO.DeleteDirectoryOption.DeleteAllContents)
                finunmount = 0
            Catch ex As Exception

            End Try
        End If

    End Sub
    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            wincrypttitle.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
    Private Sub minimizebt(sender As Object, e As EventArgs) Handles minimize_bt.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub exitbt(sender As Object, e As EventArgs) Handles exit_bt.Click
        Application.Exit()
    End Sub

    Private Sub exitbt_menu(sender As Object, e As EventArgs) Handles exit_bt_menu.Click
        Application.Exit()
    End Sub

    Private Sub settingbt_menu(sender As Object, e As EventArgs) Handles setting_bt_menu.Click
        wcSetting.Show()
    End Sub

    Private Sub fileencrypt_bt_menu(sender As Object, e As EventArgs) Handles file_encrypt_bt_menu.Click
        fileencrypt.Show()
    End Sub

    Private Sub filedecrypt_bt_menu(sender As Object, e As EventArgs) Handles file_decrypt_bt_menu.Click
        filedecrypt.Show()
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
        If My.Computer.FileSystem.FileExists(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
            export_db_dialog.ShowDialog()
            Try
                My.Computer.FileSystem.CopyFile(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", export_db_dialog.FileName)
            Catch ex As Exception
                MsgBox(ErrorToString)
            End Try
            If langname = "English" Then
                MsgBox("Database has been exported successfully!", MsgBoxStyle.Information)
            Else
                MsgBox("Datenbank wurde erfolgreich exportiert!", MsgBoxStyle.Information)
            End If
        Else
            If langname = "English" Then
                MsgBox("It has not yet created any database!" & vbCrLf & "Specify in advance a database to be able to export them to.", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Es wurde noch keine Datenbank angelegt!" & vbCrLf & "Legen Sie vorher eine Datenbank an um diese exportieren zu können.", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub import_db_bt_menu_Click(sender As Object, e As EventArgs) Handles import_db_bt_menu.Click
        import_db_dialog.ShowDialog()
        If My.Computer.FileSystem.FileExists(import_db_dialog.FileName) Then
            If My.Computer.FileSystem.FileExists(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
                If langname = "English" Then
                    If MsgBox("There is already a database." & vbCrLf & "Do you want to overwrite it?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyFile(import_db_dialog.FileName, root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                        MsgBox("Database has been imported successfully!", MsgBoxStyle.Information)
                    Else : End If
                Else
                    If MsgBox("Es existiert bereits eine Datenbank." & vbCrLf & "Möchten Sie diese überschreiben?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyFile(import_db_dialog.FileName, root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                        MsgBox("Datenbank wurde erfolgreich Importiert!", MsgBoxStyle.Information)
                    Else : End If
                End If
            Else
                My.Computer.FileSystem.CopyFile(import_db_dialog.FileName, root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                If langname = "English" Then
                    MsgBox("Database has been imported successfully!", MsgBoxStyle.Information)
                Else
                    MsgBox("Datenbank wurde erfolgreich Importiert!", MsgBoxStyle.Information)
                End If
            End If
        Else : End If
    End Sub

    Private Sub delete_db_menu_Click(sender As Object, e As EventArgs) Handles delete_db_menu.Click
        If My.Computer.FileSystem.FileExists(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
            If langname = "English" Then
                If MsgBox("Do you really want to drop the database?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini")
                    If langname = "English" Then
                        MsgBox("Database has been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde gelöscht!", MsgBoxStyle.Information)
                    End If
                Else
                    If langname = "English" Then
                        MsgBox("Database has not been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde nicht gelöscht!", MsgBoxStyle.Information)
                    End If
                End If
            Else
                If MsgBox("Wollen Sie wirklich die Datenbank löschen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini")
                    If langname = "English" Then
                        MsgBox("Database has been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde gelöscht!", MsgBoxStyle.Information)
                    End If
                Else
                    If langname = "English" Then
                        MsgBox("Database has not been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde nicht gelöscht!", MsgBoxStyle.Information)
                    End If
                End If
            End If
        Else
            If langname = "English" Then
                MsgBox("It has not yet created any database by deleting them!", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Es wurde noch keine Datenbank angelegt um diese zu löschen!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub systemidentification_bt_menu_Click(sender As Object, e As EventArgs) Handles systemidentification_bt_menu.Click
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
        Me.Show()
        Me.WindowState = FormWindowState.Normal
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

    Private Sub file_encrypt__bt_systemtray_Click(sender As Object, e As EventArgs) Handles file_encrypt__bt_systemtray.Click
        fileencrypt.Show()
    End Sub

    Private Sub file_decrypt_bt_systemtray_Click(sender As Object, e As EventArgs) Handles file_decrypt_bt_systemtray.Click
        filedecrypt.Show()
    End Sub

    Private Sub text_encrypt_bt_systemtray_Click(sender As Object, e As EventArgs) Handles text_encrypt_bt_systemtray.Click
        textencrypt.Show()
    End Sub

    Private Sub md5_converter_bt_systemtray_Click(sender As Object, e As EventArgs) Handles md5_converter_bt_systemtray.Click
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

    Private Sub systemidentification_bt_systemtray_Click(sender As Object, e As EventArgs) Handles systemidentification_bt_systemtray.Click
        systemidentification.Show()
    End Sub

    Private Sub pwg_bt_systemtray_Click(sender As Object, e As EventArgs) Handles pwg_bt_systemtray.Click
        passwordgenerator.Show()
    End Sub

    Private Sub file_delete_bt_systemtray_Click(sender As Object, e As EventArgs) Handles file_delete_bt_systemtray.Click
        safedelete.Show()
    End Sub

    Private Sub rsa_encrypt_bt_systemtray_Click(sender As Object, e As EventArgs) Handles rsa_encrypt_bt_systemtray.Click
        rsa_decrypt.Show()
    End Sub

    Private Sub rsa_decrypt_bt_systemtray_Click(sender As Object, e As EventArgs) Handles rsa_decrypt_bt_systemtray.Click
        rsa_encrypt.Show()
    End Sub

    Private Sub rsa_create_keys_bt_systemtray_Click(sender As Object, e As EventArgs) Handles rsa_create_keys_bt_systemtray.Click
        rsa_create_keys.Show()
    End Sub

    Private Sub export_db_bt_systemtray_Click(sender As Object, e As EventArgs) Handles export_db_bt_systemtray.Click
        If My.Computer.FileSystem.FileExists(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
            export_db_dialog.ShowDialog()
            Try
                My.Computer.FileSystem.CopyFile(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", export_db_dialog.FileName)
            Catch ex As Exception
                MsgBox(ErrorToString)
            End Try
            If langname = "English" Then
                MsgBox("Database has been exported successfully!", MsgBoxStyle.Information)
            Else
                MsgBox("Datenbank wurde erfolgreich exportiert!", MsgBoxStyle.Information)
            End If
        Else
            If langname = "English" Then
                MsgBox("It has not yet created any database!" & vbCrLf & "Specify in advance a database to be able to export them to.", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Es wurde noch keine Datenbank angelegt!" & vbCrLf & "Legen Sie vorher eine Datenbank an um diese exportieren zu können.", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub import_db_bt_systemtray_Click(sender As Object, e As EventArgs) Handles import_db_bt_systemtray.Click
        import_db_dialog.ShowDialog()
        If My.Computer.FileSystem.FileExists(import_db_dialog.FileName) Then
            If My.Computer.FileSystem.FileExists(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
                If langname = "English" Then
                    If MsgBox("There is already a database." & vbCrLf & "Do you want to overwrite it?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyFile(import_db_dialog.FileName, root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                        MsgBox("Database has been imported successfully!", MsgBoxStyle.Information)
                    Else : End If
                Else
                    If MsgBox("Es existiert bereits eine Datenbank." & vbCrLf & "Möchten Sie diese überschreiben?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyFile(import_db_dialog.FileName, root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                        MsgBox("Datenbank wurde erfolgreich Importiert!", MsgBoxStyle.Information)
                    Else : End If
                End If
            Else
                My.Computer.FileSystem.CopyFile(import_db_dialog.FileName, root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                If langname = "English" Then
                    MsgBox("Database has been imported successfully!", MsgBoxStyle.Information)
                Else
                    MsgBox("Datenbank wurde erfolgreich Importiert!", MsgBoxStyle.Information)
                End If
            End If
        Else : End If
    End Sub

    Private Sub delete_db_bt_systemtray_Click(sender As Object, e As EventArgs) Handles delete_db_bt_systemtray.Click
        If My.Computer.FileSystem.FileExists(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
            If langname = "English" Then
                If MsgBox("Do you really want to drop the database?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini")
                    If langname = "English" Then
                        MsgBox("Database has been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde gelöscht!", MsgBoxStyle.Information)
                    End If
                Else
                    If langname = "English" Then
                        MsgBox("Database has not been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde nicht gelöscht!", MsgBoxStyle.Information)
                    End If
                End If
            Else
                If MsgBox("Wollen Sie wirklich die Datenbank löschen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini")
                    If langname = "English" Then
                        MsgBox("Database has been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde gelöscht!", MsgBoxStyle.Information)
                    End If
                Else
                    If langname = "English" Then
                        MsgBox("Database has not been deleted!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Datenbank wurde nicht gelöscht!", MsgBoxStyle.Information)
                    End If
                End If
            End If
        Else
            If langname = "English" Then
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
    Declare Function GetAsyncKeyState Lib "user32" (ByVal vkKey As Integer) As Short
    Private Sub gethotkey_Tick(sender As Object, e As EventArgs) Handles gethotkey.Tick
        If Me.WindowState = FormWindowState.Minimized = True Then
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
                fileencrypt.Show()
                fileencrypt.Focus()
                gethotkey.Enabled = True
            End If

            ' STRG+D öffnet Datei entschlüsseln
            If CBool(GetAsyncKeyState(Keys.F4)) AndAlso CBool(GetAsyncKeyState(Keys.ControlKey)) Then
                gethotkey.Enabled = False
                filedecrypt.Show()
                filedecrypt.Focus()
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
                Me.Show()
                Me.WindowState = FormWindowState.Normal
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
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            wincrypttitle.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
End Class
