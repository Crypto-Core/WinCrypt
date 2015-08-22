﻿
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Namespace classes
    Public Class MD5fileHash
        Public Function MD5FileHash(ByVal sFile As String) As String
            Dim MD5 As New MD5CryptoServiceProvider
            Dim Hash As Byte()
            Dim Result As String = Nothing
            Dim Tmp As String = Nothing

            Dim FN As New FileStream(sFile, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
            Try
                MD5.ComputeHash(FN)
            Catch ex As Exception
                MessageBox.Show(ErrorToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            FN.Close()

            Hash = MD5.Hash
            For i As Integer = 0 To Hash.Length - 1
                Tmp = Hex(Hash(i))
                If Len(Tmp) = 1 Then Tmp = 0 & Tmp
                Result += Tmp
            Next
            Return Result
        End Function
    End Class
End Namespace

