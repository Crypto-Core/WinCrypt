Imports System.IO

Public Class Worker
    Public Path As String
    Public Clipher As String
    Public Blocksize As Integer
    Public Algorithm As Integer
    Public Letter As String
    Friend aes As New AESEncrypt
    Friend WithEvents fsw As New FileSystemWatcher
    Friend Shared isDecrypted_files As Boolean = False
    Friend Shared error_feedback As Boolean = False
    Friend Shared error_lst As New List(Of String)
    Friend Shared max_files As Integer = 0
    Friend Shared value_files As Integer = 0
    Friend Function Start()
        Try
            If Directory.Exists(Path) = True Then

            Else
                Directory.CreateDirectory(Path)
            End If
            max_files = Directory.GetFiles(Letter & "crypt", "*.*", SearchOption.AllDirectories).Count
            For Each decryptFiles In Directory.GetFiles(Letter & "crypt", "*.*", SearchOption.AllDirectories)
                value_files += 1
                Dim filename As String = decryptFiles.Replace(Letter & "crypt\", "")
                Dim decryptname As String = DecryptString(filename)
                Directory.CreateDirectory(decryptname.Substring(0, decryptname.LastIndexOf("\")))
                My.Computer.FileSystem.WriteAllBytes(decryptname, DecryptFile(File.ReadAllBytes(decryptFiles)), False)

            Next
            isDecrypted_files = True
            fsw.Path = Path
            fsw.IncludeSubdirectories = True

            fsw.EnableRaisingEvents = True



        Catch ex As Exception
            error_feedback = True
            error_lst.Add(ex.ToString)
        End Try
        
    End Function

    Friend Function DecryptString(ByVal inputStr As String) As String
        Dim decode As Byte() = Convert.FromBase64String(inputStr.Replace("-", "/"))
        Dim decrypt_bt As Byte()
        Select Case Algorithm
            Case 0
                aes.BitLen = 64
                aes.Decode(decode, decrypt_bt, Clipher, AESEncrypt.ALGO.DES, Blocksize)
            Case 1
                aes.BitLen = 128
                aes.Decode(decode, decrypt_bt, Clipher, AESEncrypt.ALGO.RC2, Blocksize)
            Case 2
                aes.BitLen = 256
                aes.Decode(decode, decrypt_bt, Clipher, AESEncrypt.ALGO.RIJNDAEL, Blocksize)
            Case 3
                aes.BitLen = 192
                aes.Decode(decode, decrypt_bt, Clipher, AESEncrypt.ALGO.TDES, Blocksize)
        End Select
        Return System.Text.UTF8Encoding.UTF8.GetChars(decrypt_bt)
    End Function

    Friend Function EncryptString(ByVal inputStr As String) As String
        Try
            Dim read_byte As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(inputStr)
            Dim encrypt_byte As Byte()
            Select Case Algorithm
                Case 0
                    aes.BitLen = 64
                    aes.Encode(read_byte, encrypt_byte, Clipher, AESEncrypt.ALGO.DES, Blocksize)
                Case 1
                    aes.BitLen = 128
                    aes.Encode(read_byte, encrypt_byte, Clipher, AESEncrypt.ALGO.RC2, Blocksize)
                Case 2
                    aes.BitLen = 256
                    aes.Encode(read_byte, encrypt_byte, Clipher, AESEncrypt.ALGO.RIJNDAEL, Blocksize)
                Case 3
                    aes.BitLen = 192
                    aes.Encode(read_byte, encrypt_byte, Clipher, AESEncrypt.ALGO.TDES, Blocksize)
            End Select

            Dim to_b64 As String = Convert.ToBase64String(encrypt_byte).Replace("/", "-")
            Return to_b64
        Catch ex As Exception
            error_feedback = True
            error_lst.Add(ex.ToString)
        End Try

    End Function
    Friend Function DecryptFile(ByVal inputByte As Byte()) As Byte()
        Dim decrypt_byte As Byte()
        Select Case Algorithm
            Case 0
                aes.BitLen = 64
                aes.Decode(inputByte, decrypt_byte, Clipher, AESEncrypt.ALGO.DES, Blocksize)
            Case 1
                aes.BitLen = 128
                aes.Decode(inputByte, decrypt_byte, Clipher, AESEncrypt.ALGO.RC2, Blocksize)
            Case 2
                aes.BitLen = 256
                aes.Decode(inputByte, decrypt_byte, Clipher, AESEncrypt.ALGO.RIJNDAEL, Blocksize)
            Case 3
                aes.BitLen = 192
                aes.Decode(inputByte, decrypt_byte, Clipher, AESEncrypt.ALGO.TDES, Blocksize)
        End Select
        Return decrypt_byte
    End Function

    Friend Function EncryptFile(ByVal inputByte As Byte()) As Byte()
        Try
            Dim encrypt_byte As Byte()
            Select Case Algorithm
                Case 0
                    aes.BitLen = 64
                    aes.Encode(inputByte, encrypt_byte, Clipher, AESEncrypt.ALGO.DES, Blocksize)
                Case 1
                    aes.BitLen = 128
                    aes.Encode(inputByte, encrypt_byte, Clipher, AESEncrypt.ALGO.RC2, Blocksize)
                Case 2
                    aes.BitLen = 256
                    aes.Encode(inputByte, encrypt_byte, Clipher, AESEncrypt.ALGO.RIJNDAEL, Blocksize)
                Case 3
                    aes.BitLen = 192
                    aes.Encode(inputByte, encrypt_byte, Clipher, AESEncrypt.ALGO.TDES, Blocksize)
            End Select
            Return encrypt_byte
        Catch ex As Exception
            error_feedback = True
            error_lst.Add(ex.ToString)
        End Try

    End Function
    Private Sub fsw_Changed(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles fsw.Changed
        Try
            If CryptMain.isDisconnected = True Then
                fsw.EnableRaisingEvents = False
            Else
                If Directory.Exists(e.FullPath) = True Then

                Else
                    If File.Exists(Letter & "crypt\" & EncryptString(e.FullPath)) = True Then

                    Else
                        File.WriteAllBytes(Letter & "crypt\" & EncryptString(e.FullPath), EncryptFile(File.ReadAllBytes(e.FullPath)))
                    End If
                End If
            End If
        Catch ex As Exception
            error_feedback = True
            error_lst.Add(ex.ToString)
        End Try

        
    End Sub

    Private Sub fsw_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles fsw.Created
        Try
            If CryptMain.isDisconnected = True Then
                fsw.EnableRaisingEvents = False
            Else
                If Directory.Exists(e.FullPath) = True Then
                    For Each getSub In Directory.GetFiles(e.FullPath, "*.*", SearchOption.AllDirectories)
                        File.WriteAllBytes(Letter & "crypt\" & EncryptString(getSub), EncryptFile(File.ReadAllBytes(getSub)))
                    Next
                Else
                    If File.Exists(Letter & "crypt\" & EncryptString(e.FullPath)) = True Then

                    Else
                        File.WriteAllBytes(Letter & "crypt\" & EncryptString(e.FullPath), EncryptFile(File.ReadAllBytes(e.FullPath)))
                    End If
                End If
            End If
        Catch ex As Exception
            error_feedback = True
            error_lst.Add(ex.ToString)
        End Try

    End Sub

    Private Sub fsw_Deleted(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles fsw.Deleted
        If CryptMain.isDisconnected = True Then
            fsw.EnableRaisingEvents = False
        Else
            If Directory.Exists(e.FullPath) = True Then

            Else
                If File.Exists(Letter & "crypt\" & EncryptString(e.FullPath)) = True Then
                    File.Delete(Letter & "crypt\" & EncryptString(e.FullPath))
                End If
                For Each getFiles In Directory.GetFiles(Letter & "crypt", "*.*")
                    Dim decrypt As String = DecryptString(getFiles.Replace(Letter & "crypt\", ""))
                    If decrypt.Contains(e.FullPath) = True Then
                        File.Delete(getFiles)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub fsw_Renamed(ByVal sender As Object, ByVal e As System.IO.RenamedEventArgs) Handles fsw.Renamed
        Try
            If Directory.Exists(e.FullPath) = True Then
            Else
                If File.Exists(Letter & "crypt\" & EncryptString(e.OldFullPath)) = True Then
                    File.Move(Letter & "crypt\" & EncryptString(e.OldFullPath), Letter & "crypt\" & EncryptString(e.FullPath))
                Else

                End If
            End If
        Catch ex As Exception
            error_feedback = True
            error_lst.Add(ex.ToString)
        End Try

    End Sub
End Class
