Imports System.IO
Imports System.Threading
Public Class CryptMain
    Dim serial As String
    Dim letter As String
    Dim USBName As String
    Dim SyncPath As String
    Dim ini As New IniFile
    Dim algo As String
    Dim blocksize As Integer
    Dim clipher As String
    Dim aes As New AESEncrypt
    Private Sub CryptMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub isEmbedUSB_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles isEmbedUSB.Tick

        If devices.isDriveEmbed(serial_lb.Text) = True Then
            PictureBox2.Image = My.Resources._1457579252_lock_unlock
        Else
            Try
                isEmbedUSB.Enabled = False
                PictureBox2.Image = My.Resources._1457579322_lock
                FileSystemWatcher1.EnableRaisingEvents = False
                Dim SafeDelete As New SafedeleteFunction
                For Each DeleteFiles In Directory.GetFiles(SyncPath, "*.*", SearchOption.AllDirectories)
                    SafeDelete.SafeEraser(DeleteFiles, 3, True)
                Next
                Directory.Delete(SyncPath, True)
            Catch ex As Exception
                main_frm.NotifyIcon1.Visible = False
                Application.Restart()
            End Try
            main_frm.NotifyIcon1.Visible = False
            Application.Restart()
        End If
    End Sub

    Private Sub FileSystemWatcher1_Changed(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        ListBox1.Items.Add("Changed: " & e.FullPath)
        If Directory.Exists(e.FullPath) = True Then

        Else
            If File.Exists(letter & "crypt\" & EncryptString(e.FullPath)) = True Then

            Else
                File.WriteAllBytes(letter & "crypt\" & EncryptString(e.FullPath), EncryptFile(File.ReadAllBytes(e.FullPath)))
            End If
        End If
        
    End Sub

    Private Sub FileSystemWatcher1_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Created
        ListBox1.Items.Add("Encrypt: " & e.FullPath)

        If Directory.Exists(e.FullPath) = True Then
            For Each getSub In Directory.GetFiles(e.FullPath, "*.*", SearchOption.AllDirectories)
                File.WriteAllBytes(letter & "crypt\" & EncryptString(getSub), EncryptFile(File.ReadAllBytes(getSub)))

            Next
        Else
            If File.Exists(letter & "crypt\" & EncryptString(e.FullPath)) = True Then

            Else

                File.WriteAllBytes(letter & "crypt\" & EncryptString(e.FullPath), EncryptFile(File.ReadAllBytes(e.FullPath)))
            End If
        End If


    End Sub

    Private Sub FileSystemWatcher1_Deleted(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Deleted
        ListBox1.Items.Add("Deleted: " & e.FullPath)
        If Directory.Exists(e.FullPath) = True Then
            
        Else
            If File.Exists(letter & "crypt\" & EncryptString(e.FullPath)) = True Then
                File.Delete(letter & "crypt\" & EncryptString(e.FullPath))
            End If
            For Each getFiles In Directory.GetFiles(letter & "crypt", "*.*")
                Dim decrypt As String = DecryptString(getFiles.Replace(letter & "crypt\", ""))
                If decrypt.Contains(e.FullPath) = True Then
                    File.Delete(getFiles)
                End If
            Next
        End If
        
    End Sub

    Private Sub FileSystemWatcher1_Renamed(ByVal sender As Object, ByVal e As System.IO.RenamedEventArgs) Handles FileSystemWatcher1.Renamed
        ListBox1.Items.Add("Renamed: " & e.FullPath)
        If Directory.Exists(e.FullPath) = True Then
        Else
            If File.Exists(letter & "crypt\" & EncryptString(e.OldFullPath)) = True Then
                File.Move(letter & "crypt\" & EncryptString(e.OldFullPath), letter & "crypt\" & EncryptString(e.FullPath))
            Else

            End If
        End If
        
    End Sub

    Private Function DecryptString(ByVal inputStr As String) As String
        Dim decode As Byte() = Convert.FromBase64String(inputStr.Replace("-", "/"))
        Dim decrypt_bt As Byte()
        Select Case algo
            Case 0
                aes.Decode(decode, decrypt_bt, clipher, AESEncrypt.ALGO.DES, blocksize)
            Case 1
                aes.Decode(decode, decrypt_bt, clipher, AESEncrypt.ALGO.RC2, blocksize)
            Case 2
                aes.Decode(decode, decrypt_bt, clipher, AESEncrypt.ALGO.RIJNDAEL, blocksize)
            Case 3
                aes.Decode(decode, decrypt_bt, clipher, AESEncrypt.ALGO.TDES, blocksize)
        End Select
        Return System.Text.UTF8Encoding.UTF8.GetChars(decrypt_bt)
    End Function

    Private Function EncryptString(ByVal inputStr As String) As String
        Dim read_byte As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(inputStr)
        Dim encrypt_byte As Byte()
        Select Case algo
            Case 0
                aes.Encode(read_byte, encrypt_byte, clipher, AESEncrypt.ALGO.DES, blocksize)
            Case 1
                aes.Encode(read_byte, encrypt_byte, clipher, AESEncrypt.ALGO.RC2, blocksize)
            Case 2
                aes.Encode(read_byte, encrypt_byte, clipher, AESEncrypt.ALGO.RIJNDAEL, blocksize)
            Case 3
                aes.Encode(read_byte, encrypt_byte, clipher, AESEncrypt.ALGO.TDES, blocksize)
        End Select

        Dim to_b64 As String = Convert.ToBase64String(encrypt_byte).Replace("/", "-")
        Return to_b64
    End Function
    Private Function DecryptFile(ByVal inputByte As Byte()) As Byte()
        Dim decrypt_byte As Byte()
        Select Case algo
            Case 0
                aes.Decode(inputByte, decrypt_byte, clipher, AESEncrypt.ALGO.DES, blocksize)
            Case 1
                aes.Decode(inputByte, decrypt_byte, clipher, AESEncrypt.ALGO.RC2, blocksize)
            Case 2
                aes.Decode(inputByte, decrypt_byte, clipher, AESEncrypt.ALGO.RIJNDAEL, blocksize)
            Case 3
                aes.Decode(inputByte, decrypt_byte, clipher, AESEncrypt.ALGO.TDES, blocksize)
        End Select
        Return decrypt_byte
    End Function

    Private Function EncryptFile(ByVal inputByte As Byte()) As Byte()
        Dim encrypt_byte As Byte()
        Select Case algo
            Case 0
                aes.Encode(inputByte, encrypt_byte, clipher, AESEncrypt.ALGO.DES, blocksize)
            Case 1
                aes.Encode(inputByte, encrypt_byte, clipher, AESEncrypt.ALGO.RC2, blocksize)
            Case 2
                aes.Encode(inputByte, encrypt_byte, clipher, AESEncrypt.ALGO.RIJNDAEL, blocksize)
            Case 3
                aes.Encode(inputByte, encrypt_byte, clipher, AESEncrypt.ALGO.TDES, blocksize)
        End Select
        Return encrypt_byte
    End Function

    Private Sub CryptMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        For Each tt In DriveInfo.GetDrives
            If tt.Name = device_lb.Text Then
                size_lb.Text = main_frm.ToFuzzyByteString(tt.TotalSize)
            End If
        Next
        ini.Load(device_lb.Text & "device.ini")
        serial = ini.GetKeyValue("Device", "Serial")
        letter = device_lb.Text
        USBName = ini.GetKeyValue("Device", "Name")
        SyncPath = ini.GetKeyValue("Device", "SyncPath")
        algo = ini.GetKeyValue("Device", "Algorithm")
        blocksize = ini.GetKeyValue("Device", "Blocksize")
        clipher = enterpwd.clipher
        enterpwd.clipher = ""

        If Directory.Exists(SyncPath) = True Then

        Else
            Directory.CreateDirectory(SyncPath)
        End If

        For Each decryptFiles In Directory.GetFiles(letter & "crypt", "*.*", SearchOption.AllDirectories)
            Dim filename As String = decryptFiles.Replace(letter & "crypt\", "")
            Dim decryptname As String = DecryptString(filename)
            Directory.CreateDirectory(decryptname.Substring(0, decryptname.LastIndexOf("\")))
            My.Computer.FileSystem.WriteAllBytes(decryptname, DecryptFile(File.ReadAllBytes(decryptFiles)), False)
            ListBox1.Items.Add("Decrypt: " & decryptname)
        Next
        FileSystemWatcher1.Path = SyncPath
    End Sub
End Class