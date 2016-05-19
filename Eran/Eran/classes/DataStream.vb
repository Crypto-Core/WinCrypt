
Imports System.IO

Public Class DataStream
    Friend Shared PacketList As New List(Of Stream)
    Friend Shared Key As String
    Friend Shared SplitSize As Integer
    Friend Shared Data As Byte()
    Friend Shared ToEran As String
    Friend Shared PacketName As String
    Friend Structure Stream
        Dim Name As String
        Dim Packets As Integer
        Dim CurrentPacket As Integer
        Dim Memory As MemoryStream
    End Structure
    Friend Shared Function SendToClient() As Object
        Dim div As Double = Data.Length \ SplitSize
        Dim rest As Double = Data.Length - (div * SplitSize)
        Dim buffer As Integer = SplitSize
        Dim aes As New AESEncrypt
        main_frm.sendFileState = True
        SendFile.TopMost = True
        Dim diagtrg As New Threading.Thread(AddressOf SendFile.ShowDialog)
        diagtrg.Start()
        SendFile.pgb.Maximum = CInt(div)
        SendFile.packet_status_lb.Text = "Packet " & 0 & " of " & div
        SendFile.packname_lb.Text = "Packetname: " & PacketName
        SendFile.hash_lb.Text = "Hash: " & rHash.HashByte(Data, rHash.HASH.MD5)
        For tt As Double = 0 To div - 1
            Dim mem As New MemoryStream
            mem.Write(Data, buffer - SplitSize, SplitSize)
            buffer += SplitSize
            Dim encryptByte As Byte()
            aes.Encode(mem.ToArray, encryptByte, Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & ToEran & "; " & "/packetname " & PacketName & "; /currentPacket " & tt & "; /packetcount " & div & "; /hash " & rHash.HashByte(Data, rHash.HASH.MD5) & "; /packetbytes " & Convert.ToBase64String(encryptByte) & ";")
            SendFile.pgb.Value = CInt(tt)
            SendFile.packet_status_lb.Text = "Packet " & tt & " of " & div
        Next
        Dim mem_ As New MemoryStream
        mem_.Write(Data, (buffer - SplitSize), CInt(rest))
        Dim encryptByte_ As Byte()
        aes.Encode(mem_.ToArray, encryptByte_, Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
        main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & ToEran & "; " & "/packetname " & PacketName & "; /currentPacket " & div & "; /packetcount " & div & "; /hash " & rHash.HashByte(Data, rHash.HASH.MD5) & "; /packetbytes " & Convert.ToBase64String(encryptByte_) & ";")
        SendFile.pgb.Value = CInt(div)
        SendFile.packet_status_lb.Text = "Packet " & div & " of " & div
        SendFile.Close()
        main_frm.sendFileState = False
    End Function
    Friend Shared Function IsInPacketList(ByVal Hash As String) As Boolean
        For Each Check In PacketList
            If Check.Name = Hash Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function
End Class
