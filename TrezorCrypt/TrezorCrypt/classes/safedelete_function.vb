Imports System.IO
Imports System.Text
Imports System.Threading


Public Class SafedeleteFunction
    Public Property DelThread As Thread

    Friend Shared Function SafeErase(ByVal file_path As String)
        For index_ As Integer = 0 To 2
            Dim FStream As New FileStream(file_path, FileMode.Open)
            Dim size As Long = FStream.Length
            Dim ByteArray(size - 1) As Byte
            Dim rnd As New Random
            Select Case index_
                Case 0
                    For index As Integer = 0 To size - 1
                        ByteArray(index) = 0
                    Next
                Case 1
                    For index As Integer = 0 To size - 1
                        ByteArray(index) = 1
                    Next
                Case 2
                    Dim bytA As Byte = 0
                    Dim bytB As Byte = 1

                    For index As Integer = 0 To size - 1
                        Select Case rnd.Next(0, 2)
                            Case 0
                                ByteArray(index) = bytA
                            Case 1
                                ByteArray(index) = bytB
                        End Select
                    Next

            End Select
            FStream.Write(ByteArray, 0, size)
            FStream.Flush()
            FStream.Close()
        Next
        File.Delete(file_path)
    End Function
End Class