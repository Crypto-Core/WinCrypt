Imports System.Text

Public Class rndPass
    Public Shared Function Random(ByVal length As Integer) As String
        Dim source_str As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-.,;:+?/()!"
        Dim builder As New StringBuilder
        Dim rnd As New Random
        For index As Integer = 0 To length
            builder.Append(source_str.Substring(rnd.Next(0, source_str.Length), 1))
        Next
        Return builder.ToString
    End Function
End Class
