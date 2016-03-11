Imports System.IO
Imports System.Text
Imports System.Threading


Public Class SafedeleteFunction
    Public Property DelThread As Thread

    Public Function SafeEraser(ByVal filepath As String, ByVal repeat As Integer, ByVal delete As Boolean)
        Dim r As New Random
        Dim sb As New StringBuilder
        Dim abc = "abcdefghijklmnopqrstuvwxyz"
        Try
            For i = 0 To repeat
                Dim idx As Integer = r.Next(0, abc.Length)
                Dim filesize As New FileInfo(filepath)
                Dim fsize = CInt(Int(filesize.Length))
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
            Else
            End If
        Catch ex As Exception
            'Falls eine Datei nicht gelsöcht werden konnte gibt es eine Fehlermeldung
        End Try
    End Function
End Class