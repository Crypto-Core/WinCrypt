Public Class DataTransfer
    Public Shared Function Send(ByVal FileName As String, ByVal ToEran As String, ByVal Key As String)
        Dim fileinfo As New IO.FileInfo(FileName)
        Dim readByte As Byte() = My.Computer.FileSystem.ReadAllBytes(FileName)
        DataStream.PacketName = fileinfo.Name
        DataStream.Data = readByte
        DataStream.Key = Key
        DataStream.SplitSize = 65536
        DataStream.ToEran = ToEran
        Dim trd As New Threading.Thread(AddressOf DataStream.SendToClient)
        trd.IsBackground = True
        trd.Start()
    End Function
End Class
