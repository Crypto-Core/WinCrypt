Imports System.IO
Public Class DataTransfer
    Friend ToEran As String
    Friend Key As String
    Friend FileName As String
    Public Function Send() As Object
        Dim fileinfo As New IO.FileInfo(FileName)
        Dim readByte As Byte() = File.ReadAllBytes(FileName)
        Dim DS As New DataStream

        DS.PacketName = fileinfo.Name
        DS.Data = readByte
        DS.Key = Key
        DS.SplitSize = 65536
        DS.ToEran = ToEran
        DS.SendToClient()
        
    End Function
End Class
