Imports System.Text

Public Class rndPass
    Friend Shared Function random(ByVal length As Integer) As String
        Dim str As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!%&/()=-:;.,"
        Dim builder As New StringBuilder
        Dim rnd As New Random
        For index As Integer = 0 To length - 1
            builder.Append(str.Substring(rnd.Next(0, str.Length), 1))
        Next
        Return builder.ToString
    End Function
End Class
