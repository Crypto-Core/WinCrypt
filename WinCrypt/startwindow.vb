﻿Imports System.IO
Imports System.Threading
Imports System.Net
Imports System
Imports System.Security.Principal
Public Class startwindow
    Dim filezip As New Zip
    Dim selectcombo As String
    Dim wmiobj = GetObject("winmgmts://localhost/root/cimv2:Win32_BIOS")
    Public biosid As String
    Public iniread As String
    Public mypath As String
    Public selecteddrive As String
    Public langname As String
    Public errormount As String
    Dim lang As New language
    Public formclose As Boolean = False
    Public timerclose As Boolean = False
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
        If iniread = "yes" Then
            Try
                Dim p As String = pathtxt.Text.LastIndexOf("\")
                Dim i As String = pathtxt.Text.Remove(0, p + 1)
                My.Computer.FileSystem.RenameFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip", i & "f.zip")
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
                If i = "" Then
                    CryptoStuff.CryptFile(biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip", My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & selecteddrive.Replace(" ", "") & ".wcp", True)
                Else
                    CryptoStuff.CryptFile(biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip", My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & i.Replace(" ", "") & ".wcp", True)
                End If
                My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip")

                If langname = "English" Then
                    encrypt_list_status.Items.Add("Container encrypted.....")
                Else
                    encrypt_list_status.Items.Add("Container verschlüsselt.....")
                End If
                My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)
                encrypttimer.Enabled = False
                If timerclose = True Then
                    Application.Exit()
                End If
            Catch ex As Exception

            End Try
        Else
            Try
                Dim p As String = pathtxt.Text.LastIndexOf("\")
                Dim i As String = pathtxt.Text.Remove(0, p + 1)
                My.Computer.FileSystem.RenameFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip", i & "f.zip")
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
                If i = "" Then
                    CryptoStuff.CryptFile(keycrypt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip", My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & selecteddrive.Replace(" ", "") & ".wcp", True)
                Else
                    CryptoStuff.CryptFile(keycrypt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip", My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & i.Replace(" ", "") & ".wcp", True)
                End If
                My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip")
                If langname = "English" Then
                    encrypt_list_status.Items.Add("Container encrypted.....")
                Else
                    encrypt_list_status.Items.Add("Container verschlüsselt.....")
                End If
                My.Computer.Audio.Play(My.Resources.crypt, AudioPlayMode.Background)
                encrypttimer.Enabled = False
                If timerclose = True Then
                    Application.Exit()
                End If
            Catch ex As Exception

            End Try
        End If

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
                Dim p As Integer = decrypt_filepath.Text.LastIndexOf("\")
                Dim i As String = decrypt_filepath.Text.Remove(0, p + 1)
                CryptoStuff.DecryptFile(biosid, decrypt_filepath.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip")
                If errormount = "error" Then

                Else
                    Dim file As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip"
                    Dim cu As New Unzip(file, Path.Combine(Path.GetDirectoryName(file), "unmount"))
                    cu.UnzipNow()
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip")
                    Try
                        selectcombo = drivecb.SelectedItem
                        Shell("subst " & selectcombo.Replace("\", "") & " " & My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount")
                    Catch ex As Exception
                        If langname = "English" Then
                            MsgBox("Error: Drive not found!", MsgBoxStyle.Critical)
                        Else
                            MsgBox("Fehler: Laufwerk nicht gefunden!", MsgBoxStyle.Critical)
                        End If
                        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        Application.Restart()
                    End Try
                    If langname = "English" Then
                        decrypt_list_status.Items.Add("Container embedded!")
                    Else
                        decrypt_list_status.Items.Add("Container eingebunden!")
                    End If
                    My.Computer.Audio.Play(My.Resources.Vista_DeviceConnect, AudioPlayMode.WaitToComplete)
                    Process.Start("explorer.exe", drivecb.SelectedItem)
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
                Dim p As Integer = decrypt_filepath.Text.LastIndexOf("\")
                Dim i As String = decrypt_filepath.Text.Remove(0, p + 1)
                CryptoStuff.DecryptFile(keyencrypt.Text, decrypt_filepath.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip")
                If errormount = "error" Then

                Else
                    Dim file As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip"
                    Dim cu As New Unzip(file, Path.Combine(Path.GetDirectoryName(file), "unmount"))
                    cu.UnzipNow()
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip")

                    Try
                        selectcombo = drivecb.SelectedItem
                        Shell("subst " & selectcombo.Replace("\", "") & " " & My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount")
                    Catch ex As Exception
                        If langname = "English" Then
                            MsgBox("Error: Drive not found!", MsgBoxStyle.Critical)
                        Else
                            MsgBox("Fehler: Laufwerk nicht gefunden!", MsgBoxStyle.Critical)
                        End If
                        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        Application.Restart()
                    End Try
                    If langname = "English" Then
                        decrypt_list_status.Items.Add("Container embedded!")
                    Else
                        decrypt_list_status.Items.Add("Container eingebunden!")
                    End If
                    My.Computer.Audio.Play(My.Resources.Vista_DeviceConnect, AudioPlayMode.WaitToComplete)
                    Process.Start("explorer.exe", drivecb.SelectedItem)
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
    End Sub

    Private Sub dismount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dismount.Click
        formclose = False
        If errormount = "error" Then

        Else
            Dim p As Integer = decrypt_filepath.Text.LastIndexOf("\")
            Dim i As String = decrypt_filepath.Text.Remove(0, p + 1)
            filezip.zip(drivecb.SelectedItem, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip")
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
    End Sub

    Private Sub encryptmounttimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles encryptmounttimer.Tick
        If iniread = "yes" Then
            Try
                Dim p As Integer = decrypt_filepath.Text.LastIndexOf("\")
                Dim i As String = decrypt_filepath.Text.Remove(0, p + 1)
                My.Computer.FileSystem.RenameFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip", i & "f.zip")
                If langname = "English" Then
                    decrypt_list_status.Items.Add("Now is encrypted.......")
                Else
                    decrypt_list_status.Items.Add("Jetzt wird Verschlüsselt.......")
                End If
                If i = "" Then
                    CryptoStuff.CryptFile(biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip", My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\Drive-" & decrypt_filepath.Text.Replace(":\", "") & ".wcp", True)
                Else
                    CryptoStuff.CryptFile(biosid, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip", My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\" & i.Replace(".wcp", "") & ".wcp", True)
                End If

                My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip")

                If langname = "English" Then
                    decrypt_list_status.Items.Add("Encryption completed!")
                Else
                    decrypt_list_status.Items.Add("Verschlüsselung abgeschlossen!")
                End If

                If langname = "English" Then
                    decrypt_list_status.Items.Add(drivecb.SelectedItem & " drive will be closed...")
                Else
                    decrypt_list_status.Items.Add("Laufwerk " & drivecb.SelectedItem & " wird geschlossen...")
                End If
                dismount.Enabled = False
                Shell("subst " & selectcombo.Replace("\", "") & " /D")
                Threading.Thread.Sleep(3000)
                My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount", FileIO.DeleteDirectoryOption.DeleteAllContents)
                mount.Enabled = True
                keyencrypt.UseSystemPasswordChar = False
                If langname = "English" Then
                    decrypt_list_status.Items.Add("Closed drive " & drivecb.SelectedItem)
                Else
                    decrypt_list_status.Items.Add("Laufwerk " & drivecb.SelectedItem & " geschlossen!")
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
                Dim p As String = decrypt_filepath.Text.LastIndexOf("\")
                Dim i As String = decrypt_filepath.Text.Remove(0, p + 1)
                My.Computer.FileSystem.RenameFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip", i & "f.zip")

                If langname = "English" Then
                    decrypt_list_status.Items.Add("Now is encrypted.......")
                Else
                    decrypt_list_status.Items.Add("Jetzt wird Verschlüsselt.......")
                End If
                If i = "" Then
                    CryptoStuff.CryptFile(keyencrypt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip", My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\Drive-" & decrypt_filepath.Text.Replace(":\", "") & ".wcp", True)
                Else
                    CryptoStuff.CryptFile(keyencrypt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip", My.Computer.FileSystem.GetFileInfo(decrypt_filepath.Text).Directory.FullName & "\" & i.Replace(".wcp", "") & ".wcp", True)
                End If
                My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip")
                If langname = "English" Then
                    decrypt_list_status.Items.Add("Encryption completed!")
                Else
                    decrypt_list_status.Items.Add("Verschlüsselung abgeschlossen!")
                End If

                If langname = "English" Then
                    decrypt_list_status.Items.Add(drivecb.SelectedItem & " drive will be closed...")
                Else
                    decrypt_list_status.Items.Add("Laufwerk " & drivecb.SelectedItem & " wird geschlossen...")
                End If
                dismount.Enabled = False
                Shell("subst " & selectcombo.Replace("\", "") & " /D")
                Threading.Thread.Sleep(3000)
                My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp & "\unmount", FileIO.DeleteDirectoryOption.DeleteAllContents)
                mount.Enabled = True
                keyencrypt.UseSystemPasswordChar = False
                If langname = "English" Then
                    decrypt_list_status.Items.Add("Drive " & drivecb.SelectedItem & " closed!")
                Else
                    decrypt_list_status.Items.Add("Laufwerk " & drivecb.SelectedItem & " geschlossen!")
                End If
                keyencrypt.Enabled = True
                encrypttimer.Enabled = False
                If timerclose = True Then
                    Application.Exit()
                End If
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub crypt_file_pathbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crypt_file_pathbutton.Click
        FolderBrowserDialog1.ShowDialog()
        pathtxt.Text = FolderBrowserDialog1.SelectedPath
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
        Dim txt As String
        Dim ch As Integer
        Randomize()
        num_characters = CInt(32)
        For i = 1 To num_characters
            ch = Int((26 + 26 + 10) * Rnd())
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
            Dim p As String = pathtxt.Text.LastIndexOf("\")
            Dim i As String = pathtxt.Text.Remove(0, p + 1)
            filezip.zip(pathtxt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip")
            If langname = "English" Then
                encrypt_list_status.Items.Add("Path is then compressed...........")
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
                Dim p As String = pathtxt.Text.LastIndexOf("\")
                Dim i As String = pathtxt.Text.Remove(0, p + 1)
                filezip.zip(pathtxt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip")
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
        OpenFileDialog1.ShowDialog()
        decrypt_filepath.Text = OpenFileDialog1.FileName
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
        If decrypt_filepath.Text.Length > 0 Then
            Label6.Visible = False
        Else
            Label6.Visible = True
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
            systemtray.BalloonTipText = "Laufwerk " & drivecb.Text & " ist eingebunden." & vbCrLf & "WinCrypt läuft im hintergrund!"
            systemtray.BalloonTipTitle = "WinCrypt"
            systemtray.ShowBalloonTip(3000)
        Else
            Application.Exit()
        End If
    End Sub
    Private Sub startwindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iniread = ini.WertLesen("systemidentification", "status")
        If My.Settings.Masterkey = True Then
            masterkey.ShowDialog()
        Else : End If
        lang.check()
        langname = lang.langname
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath.ToString & "\regist.exe") Then

        Else
            Dim i As New System.IO.FileStream(My.Application.Info.DirectoryPath & "\regist.exe", FileMode.Create)
            i.Write(My.Resources.regist, 0, My.Resources.regist.Length)
            i.Close()
        End If
        Me.Text = "WinCrypt " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        ini.WertSchreiben("Info", "Version", My.Application.Info.Version.ToString.Replace(".", ""))
        If iniread = "yes" Then
            generate_key_encrypt.Visible = False
            keycrypt.Visible = False
            Label2.Visible = False
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
                Label2.Visible = True
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
    Private Sub DateiVerschlüsselnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateiVerschlüsselnToolStripMenuItem.Click
        fileencrypt.ShowDialog()
    End Sub

    Private Sub DateiEntschlüsselnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateiEntschlüsselnToolStripMenuItem.Click
        filedecrypt.ShowDialog()
    End Sub

    Private Sub TextVerschlüsselnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextVerschlüsselnToolStripMenuItem.Click
        textencrypt.ShowDialog()
    End Sub

    Private Sub SystemidentifikationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemidentifikationToolStripMenuItem.Click
        systemidentification.ShowDialog()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        Try
            Process.Start(My.Application.Info.DirectoryPath & "\WinCryptUpdate.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PasswortgeneratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswortgeneratorToolStripMenuItem.Click
        passwortgenerator.Show()
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
        f = sender
        If f.WindowState = FormWindowState.Minimized Then
            systemtray.Visible = True
            Me.Hide()
            systemtray.BalloonTipIcon = ToolTipIcon.Info
            systemtray.BalloonTipText = "WinCrypt läuft im hintergrund!"
            systemtray.BalloonTipTitle = "WinCrypt"
            systemtray.ShowBalloonTip(3000)
        End If
    End Sub
    Private Sub startwindow_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim count As New counter
        count.counter()
        If My.Application.CommandLineArgs.Count > 0 Then
            Dim v As Array
            Dim commandlineargs As String = Environment.CommandLine
            v = Split(commandlineargs, """ ")
            mypath = v(1)
            If mypath.Remove(0, mypath.LastIndexOf(".")) = ".wc" Then
                filedecrypt.Show()
                filedecrypt.filetxt.Text = mypath.ToString
                filedecrypt.pathtxt.Text = mypath.Replace(".wc", "")
                'DateiEntschluesseln.TextBox2.Text = mypath.Substring(0, mypath.LastIndexOf("\"))
                filedecrypt.pathtxt.Enabled = True
                filedecrypt.passwordtxt.Enabled = True
                filedecrypt.savefile.Enabled = True
                If iniread = "yes" Then
                    filedecrypt.dencrypt.Enabled = True
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

    Private Sub EinstellungToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinstellungToolStripMenuItem.Click
        Einstellungen.Show()
    End Sub

    Private Sub DateiSicherLöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateiSicherLöschenToolStripMenuItem.Click
        safedelete.ShowDialog()
    End Sub

    Private Sub systemtray_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles systemtray.MouseDoubleClick
        systemtray.Visible = False
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BeendenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem1.Click
        If dismount.Enabled = True Then
            If MsgBox("Laufwerk " & drivecb.Text & " ist noch eingebunden!" & vbCrLf & "Möchten Sie WinCrypt wirklich schließen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                formclose = False
                timerclose = True
                If dismount.Enabled = True Then
                    If errormount = "error" Then

                    Else
                        Dim p As Integer = decrypt_filepath.Text.LastIndexOf("\")
                        Dim i As String = decrypt_filepath.Text.Remove(0, p + 1)
                        filezip.zip(drivecb.SelectedItem, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip")
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
    Private Sub ÖffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖffnenToolStripMenuItem.Click
        systemtray.Visible = False
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub DateiVerschlüsselnToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateiVerschlüsselnToolStripMenuItem1.Click
        fileencrypt.ShowDialog()
    End Sub

    Private Sub DateiEntschlüsselnToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateiEntschlüsselnToolStripMenuItem1.Click
        filedecrypt.ShowDialog()
    End Sub

    Private Sub TextVerUndEntschlüsselnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextVerUndEntschlüsselnToolStripMenuItem.Click
        textencrypt.ShowDialog()
    End Sub

    Private Sub SystemidentifikationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemidentifikationToolStripMenuItem1.Click
        systemidentification.ShowDialog()
    End Sub

    Private Sub PasswortGeneratorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswortGeneratorToolStripMenuItem1.Click
        passwortgenerator.Show()
    End Sub

    Private Sub DateienSicherLöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateienSicherLöschenToolStripMenuItem.Click
        safedelete.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        about.ShowDialog()
    End Sub

    Private Sub UpdateToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem1.Click
        Try
            Process.Start(My.Application.Info.DirectoryPath & "\WinCryptUpdate.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub decrypt_list_status_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles decrypt_list_status.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = e.Data.GetData(DataFormats.FileDrop)
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
            filestr = e.Data.GetData(DataFormats.FileDrop)
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
        If pathtxt.Text.Length > 0 Then
            Label7.Visible = False
        Else
            Label7.Visible = True
        End If
        If My.Computer.FileSystem.DirectoryExists(pathtxt.Text) = True Then
            generate_key_encrypt.Enabled = True
        Else
            generate_key_encrypt.Enabled = False
        End If
    End Sub

    Private Sub MD5KonverterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        md5main.Show()
    End Sub

    Private Sub MD5KonverterToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MD5KonverterToolStripMenuItem.Click
        md5main.Show()
    End Sub

    Private Sub MD5CrackerToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MD5CrackerToolStripMenuItem.Click
        md5bruteforce.Show()
    End Sub

    Private Sub MD5KonverterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MD5KonverterToolStripMenuItem1.Click
        md5main.Show()
    End Sub

    Private Sub MD5BruteforceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MD5BruteforceToolStripMenuItem.Click
        md5bruteforce.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
        MsgBox(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")
    End Sub

    Private Sub KeyErstellenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeyErstellenToolStripMenuItem.Click
        rsa_create_keys.ShowDialog()
    End Sub

    Private Sub EntschlüsselnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntschlüsselnToolStripMenuItem.Click
        rsa_decrypt.Show()
    End Sub

    Private Sub VerschlüsselnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerschlüsselnToolStripMenuItem.Click
        rsa_encrypt.Show()
    End Sub
    Private Sub EMailSendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMailSendenToolStripMenuItem.Click
        sendmail.Show()
    End Sub

    Private Sub EMailSendenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EMailSendenToolStripMenuItem1.Click
        sendmail.Show()
    End Sub
End Class
