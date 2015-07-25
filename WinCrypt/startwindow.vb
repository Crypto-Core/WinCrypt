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
    Dim i As String
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
                i = pathtxt.Text.Remove(0, p + 1)
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
                Dim p As Integer = pathtxt.Text.LastIndexOf("\")
                i = pathtxt.Text.Remove(0, p + 1)
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
            Dim p As Integer = decrypt_filepath.Text.LastIndexOf("\")
            Dim i As String = decrypt_filepath.Text.Remove(0, p + 1)
            filezip.zip(CStr(drivecb.SelectedItem), My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip")
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
                Dim p As String = CStr(decrypt_filepath.Text.LastIndexOf("\"))
                Dim i As String = decrypt_filepath.Text.Remove(0, CInt(CDbl(p) + 1))
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
            Dim p As String = CStr(pathtxt.Text.LastIndexOf("\"))
            Dim i As String = pathtxt.Text.Remove(0, CInt(CDbl(p) + 1))
            filezip.zip(pathtxt.Text, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip")
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
                Dim p As String = CStr(pathtxt.Text.LastIndexOf("\"))
                Dim i As String = pathtxt.Text.Remove(0, CInt(CDbl(p) + 1))
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
                        filezip.zip(CStr(drivecb.SelectedItem), My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & ".zip")
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
        MsgBox(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")
    End Sub

    Private Sub DatenbankExportierenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DatenbankExportierenToolStripMenuItem1.Click
        If My.Computer.FileSystem.FileExists(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
            SaveFileDialog1.ShowDialog()
            Try
                My.Computer.FileSystem.CopyFile(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", SaveFileDialog1.FileName)
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

    Private Sub DatenbankLöschenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DatenbankLöschenToolStripMenuItem1.Click
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

    Private Sub DatenbankImportierenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DatenbankImportierenToolStripMenuItem1.Click
        OpenFileDialog2.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog2.FileName) Then
            If My.Computer.FileSystem.FileExists(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
                If langname = "English" Then
                    If MsgBox("There is already a database." & vbCrLf & "Do you want to overwrite it?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyFile(OpenFileDialog2.FileName, root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                        MsgBox("Database has been imported successfully!", MsgBoxStyle.Information)
                    Else : End If
                Else
                    If MsgBox("Es existiert bereits eine Datenbank." & vbCrLf & "Möchten Sie diese überschreiben?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyFile(OpenFileDialog2.FileName, root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                        MsgBox("Datenbank wurde erfolgreich Importiert!", MsgBoxStyle.Information)
                    Else : End If
                End If
            Else
                My.Computer.FileSystem.CopyFile(OpenFileDialog2.FileName, root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                If langname = "English" Then
                    MsgBox("Database has been imported successfully!", MsgBoxStyle.Information)
                Else
                    MsgBox("Datenbank wurde erfolgreich Importiert!", MsgBoxStyle.Information)
                End If
            End If
        Else : End If
    End Sub

    Private Sub encrypt_list_status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles encrypt_list_status.SelectedIndexChanged
        If finishcrypt = 1 Then
            Dim filesize As New System.IO.FileStream(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip", IO.FileMode.Open)
            Dim fsize As Integer = CInt(Int(filesize.Length))
            filesize.Close()
            Dim fstream As New System.IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip")
            For o As Integer = 0 To CInt(fsize)
                fstream.Write(" ")
            Next
            fstream.Close()
            Do
                If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip") = True Then
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & i & "f.zip")
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

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            wincrypttitle.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            MenuStrip1.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Application.Exit()
    End Sub

    Private Sub BeendenToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem2.Click
        Application.Exit()
    End Sub

    Private Sub EinstellungToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EinstellungToolStripMenuItem1.Click
        wcSetting.Show()
    End Sub

    Private Sub DateiVerschlüsselnToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DateiVerschlüsselnToolStripMenuItem2.Click
        fileencrypt.Show()
    End Sub

    Private Sub DateiEntschlüsselnToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DateiEntschlüsselnToolStripMenuItem2.Click
        filedecrypt.Show()
    End Sub

    Private Sub TextVerUndEntschlüsselnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TextVerUndEntschlüsselnToolStripMenuItem1.Click
        textencrypt.Show()
    End Sub

    Private Sub MD5KonverterToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MD5KonverterToolStripMenuItem2.Click
        converter.Show()
    End Sub

    Private Sub MD5BruteforceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MD5BruteforceToolStripMenuItem1.Click
        bruteforce.Show()
    End Sub

    Private Sub VerschlüsselungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerschlüsselungToolStripMenuItem.Click
        rsa_encrypt.Show()
    End Sub

    Private Sub EntschlüsselungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntschlüsselungToolStripMenuItem.Click
        rsa_decrypt.Show()
    End Sub

    Private Sub SchlüsselErstellenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SchlüsselErstellenToolStripMenuItem1.Click
        rsa_create_keys.Show()
    End Sub

    Private Sub EMailSendenToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EMailSendenToolStripMenuItem2.Click
        sendmail.Show()
    End Sub

    Private Sub PasswortmanagerToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PasswortmanagerToolStripMenuItem2.Click
        passwordmanager.Show()
    End Sub

    Private Sub DatenbankExportierenToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DatenbankExportierenToolStripMenuItem2.Click
        If My.Computer.FileSystem.FileExists(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
            SaveFileDialog1.ShowDialog()
            Try
                My.Computer.FileSystem.CopyFile(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", SaveFileDialog1.FileName)
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

    Private Sub DatenbankImportierenToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DatenbankImportierenToolStripMenuItem2.Click
        OpenFileDialog2.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog2.FileName) Then
            If My.Computer.FileSystem.FileExists(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
                If langname = "English" Then
                    If MsgBox("There is already a database." & vbCrLf & "Do you want to overwrite it?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyFile(OpenFileDialog2.FileName, root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                        MsgBox("Database has been imported successfully!", MsgBoxStyle.Information)
                    Else : End If
                Else
                    If MsgBox("Es existiert bereits eine Datenbank." & vbCrLf & "Möchten Sie diese überschreiben?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyFile(OpenFileDialog2.FileName, root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                        MsgBox("Datenbank wurde erfolgreich Importiert!", MsgBoxStyle.Information)
                    Else : End If
                End If
            Else
                My.Computer.FileSystem.CopyFile(OpenFileDialog2.FileName, root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                If langname = "English" Then
                    MsgBox("Database has been imported successfully!", MsgBoxStyle.Information)
                Else
                    MsgBox("Datenbank wurde erfolgreich Importiert!", MsgBoxStyle.Information)
                End If
            End If
        Else : End If
    End Sub

    Private Sub DatenbankLöschenToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DatenbankLöschenToolStripMenuItem2.Click
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

    Private Sub SystemidentifikationToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SystemidentifikationToolStripMenuItem2.Click
        systemidentification.Show()
    End Sub

    Private Sub PasswortgeneratorToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PasswortgeneratorToolStripMenuItem2.Click
        passwordgenerator.Show()
    End Sub

    Private Sub DateienSicherLöschenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DateienSicherLöschenToolStripMenuItem1.Click
        safedelete.Show()
    End Sub

    Private Sub UpdateToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem2.Click
        Try
            Process.Start(My.Application.Info.DirectoryPath & "\WinCryptUpdate.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FeedbackToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem2.Click
        feedback.Show()
    End Sub

    Private Sub AboutToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem2.Click
        about.ShowDialog()
    End Sub

    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click
        systemtray.Visible = False
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub FeedbackToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem1.Click
        feedback.Show()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        about.ShowDialog()
    End Sub

    Private Sub UpdateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem1.Click
        Try
            Process.Start(My.Application.Info.DirectoryPath & "\WinCryptUpdate.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateiVerschlüsselnToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DateiVerschlüsselnToolStripMenuItem3.Click
        fileencrypt.Show()
    End Sub

    Private Sub DateiEntschlüsselnToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DateiEntschlüsselnToolStripMenuItem3.Click
        filedecrypt.Show()
    End Sub

    Private Sub TextVerUndEntschlüsselnToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles TextVerUndEntschlüsselnToolStripMenuItem2.Click
        textencrypt.Show()
    End Sub

    Private Sub MD5KonverterToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles MD5KonverterToolStripMenuItem3.Click
        converter.Show()
    End Sub

    Private Sub MD5BruteforceToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MD5BruteforceToolStripMenuItem2.Click
        bruteforce.Show()
    End Sub

    Private Sub EMailSendenToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles EMailSendenToolStripMenuItem3.Click
        sendmail.Show()
    End Sub

    Private Sub PasswortmanagerToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles PasswortmanagerToolStripMenuItem3.Click
        passwordmanager.Show()
    End Sub

    Private Sub SystemidentifikationToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles SystemidentifikationToolStripMenuItem3.Click
        systemidentification.Show()
    End Sub

    Private Sub PasswortgeneratorToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles PasswortgeneratorToolStripMenuItem3.Click
        passwordgenerator.Show()
    End Sub

    Private Sub DateienSicherLöschenToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DateienSicherLöschenToolStripMenuItem2.Click
        safedelete.Show()
    End Sub

    Private Sub EntschlüsselnToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EntschlüsselnToolStripMenuItem2.Click
        rsa_decrypt.Show()
    End Sub

    Private Sub VerschlüsselnToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles VerschlüsselnToolStripMenuItem2.Click
        rsa_encrypt.Show()
    End Sub

    Private Sub SchlüsselErstellenToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SchlüsselErstellenToolStripMenuItem2.Click
        rsa_create_keys.Show()
    End Sub

    Private Sub DatenbankExportierenToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DatenbankExportierenToolStripMenuItem3.Click
        If My.Computer.FileSystem.FileExists(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
            SaveFileDialog1.ShowDialog()
            Try
                My.Computer.FileSystem.CopyFile(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", SaveFileDialog1.FileName)
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

    Private Sub DatenbankImportierenToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DatenbankImportierenToolStripMenuItem3.Click
        OpenFileDialog2.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog2.FileName) Then
            If My.Computer.FileSystem.FileExists(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini") Then
                If langname = "English" Then
                    If MsgBox("There is already a database." & vbCrLf & "Do you want to overwrite it?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyFile(OpenFileDialog2.FileName, root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                        MsgBox("Database has been imported successfully!", MsgBoxStyle.Information)
                    Else : End If
                Else
                    If MsgBox("Es existiert bereits eine Datenbank." & vbCrLf & "Möchten Sie diese überschreiben?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyFile(OpenFileDialog2.FileName, root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                        MsgBox("Datenbank wurde erfolgreich Importiert!", MsgBoxStyle.Information)
                    Else : End If
                End If
            Else
                My.Computer.FileSystem.CopyFile(OpenFileDialog2.FileName, root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", True)
                If langname = "English" Then
                    MsgBox("Database has been imported successfully!", MsgBoxStyle.Information)
                Else
                    MsgBox("Datenbank wurde erfolgreich Importiert!", MsgBoxStyle.Information)
                End If
            End If
        Else : End If
    End Sub

    Private Sub DatenbankLöschenToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DatenbankLöschenToolStripMenuItem3.Click
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
End Class
