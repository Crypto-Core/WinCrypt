﻿Imports System.IO
Imports System.Text
Imports System.Threading

Public Class safedelete_function
    Dim delThread As Thread

    Public Function SafeEraser(filepath As String, repeat As Integer, delete As Boolean)
        Dim r As New Random
        Dim sb As New StringBuilder
        Dim abc = "abcdefghijklmnopqrstuvwxyz"
        Try
            For i = 0 To repeat
                Dim idx As Integer = r.Next(0, abc.Length)
                Dim filesize As New FileStream(filepath, FileMode.Open)
                Dim fsize = CInt(Int(filesize.Length))
                filesize.Close()
                Dim fstream As New StreamWriter(filepath)
                sb.Append(abc.Substring(idx, 1))
                For o = 0 To CInt(fsize)
                    fstream.Write(sb.ToString)
                Next
                sb.Clear()
                fstream.Close()
            Next
        Catch ex As Exception

        End Try

        Try
            If delete = True Then
                File.Delete(filepath)
            Else :
            End If
        Catch ex As Exception
            MsgBox("Datei konnte nicht gelöscht werden: " & ErrorToString(), MsgBoxStyle.Critical)
        End Try
    End Function
End Class
