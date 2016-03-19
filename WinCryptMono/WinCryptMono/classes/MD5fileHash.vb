
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Namespace classes
    Public Class fileHash
        Public Enum HASH
            MD5
            SHA1
            SHA256
            SHA384
            SHA512
            RIPEMD160
        End Enum
        Public Shared Function FileHash(ByVal sFile As String, Hash As HASH) As String
            Dim Data(0) As Byte
            Dim HashValue(0) As Byte
            Dim Result As String = Nothing
            Dim Tmp As String = Nothing

            Dim FN As New FileStream(sFile, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
            Select Case Hash
                Case Hash.MD5
                    Dim HashProv As New MD5CryptoServiceProvider
                    Try
                        HashProv.ComputeHash(FN)
                    Catch ex As Exception
                        MessageBox.Show(ErrorToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    FN.Close()
                    HashValue = HashProv.Hash

                Case Hash.RIPEMD160
                    Dim HashProv As New RIPEMD160Managed
                    Try
                        HashProv.ComputeHash(FN)
                    Catch ex As Exception
                        MessageBox.Show(ErrorToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    FN.Close()
                    HashValue = HashProv.Hash

                Case Hash.SHA1
                    Dim HashProv As New SHA1CryptoServiceProvider
                    Try
                        HashProv.ComputeHash(FN)
                    Catch ex As Exception
                        MessageBox.Show(ErrorToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    FN.Close()
                    HashValue = HashProv.Hash

                Case Hash.SHA256
                    Dim HashProv As New SHA256CryptoServiceProvider
                    Try
                        HashProv.ComputeHash(FN)
                    Catch ex As Exception
                        MessageBox.Show(ErrorToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    FN.Close()
                    HashValue = HashProv.Hash

                Case Hash.SHA384
                    Dim HashProv As New SHA384CryptoServiceProvider
                    Try
                        HashProv.ComputeHash(FN)
                    Catch ex As Exception
                        MessageBox.Show(ErrorToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    FN.Close()
                    HashValue = HashProv.Hash

                Case Hash.SHA512
                    Dim HashProv As New SHA512CryptoServiceProvider
                    Try
                        HashProv.ComputeHash(FN)
                    Catch ex As Exception
                        MessageBox.Show(ErrorToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    FN.Close()
                    HashValue = HashProv.Hash
            End Select



            For i As Integer = 0 To HashValue.Length - 1
                Tmp = Hex(HashValue(i))
                If Len(Tmp) = 1 Then Tmp = 0 & Tmp
                Result += Tmp
            Next
            Return Result
        End Function
    End Class
End Namespace

