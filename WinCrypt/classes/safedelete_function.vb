Imports System.IO
Imports System.Text
Public Class safedelete_function
    Dim delThread As System.Threading.Thread
    Public Function SafeEraser(ByVal filepath As String, ByVal repeat As Integer, ByVal delete As Boolean)
        Dim r As New Random
        Dim sb As New StringBuilder
        Dim abc As String = "abcdefghijklmnopqrstuvwxyz"
        Try
            For i As Integer = 0 To repeat
                Dim idx As Integer = r.Next(0, abc.Length)
                Dim filesize As New System.IO.FileStream(filepath, IO.FileMode.Open)
                Dim fsize As Integer = CInt(Int(filesize.Length))
                filesize.Close()
                Dim fstream As New System.IO.StreamWriter(filepath)
                sb.Append(abc.Substring(idx, 1))
                For o As Integer = 0 To CInt(fsize)
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
            Else : End If
        Catch ex As Exception
            MsgBox("Datei konnte nicht gelöscht werden: " & ErrorToString(), MsgBoxStyle.Critical)
        End Try
    End Function
End Class
