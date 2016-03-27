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
    Friend Shared Function SendToClient()
        Dim div As Double = data.Length \ splitsize
        Dim rest As Double = data.Length - (div * splitsize)
        Dim buffer As Integer = splitsize
        Dim aes As New AESEncrypt
        For tt As Double = 0 To div - 1
            Dim mem As New MemoryStream
            mem.Write(data, buffer - splitsize, splitsize)
            buffer += splitsize
            Dim encryptByte As Byte()
            aes.Encode(mem.ToArray, encryptByte, Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
            main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & ToEran & "; " & "/packetname " & PacketName & "; /currentPacket " & tt & "; /packetcount " & div & "; /hash " & rHash.HashByte(Data, rHash.HASH.MD5) & "; /packetbytes " & Convert.ToBase64String(encryptByte) & ";")
        Next
        Dim mem_ As New MemoryStream
        mem_.Write(data, (buffer - splitsize), rest)
        Dim encryptByte_ As Byte()
        aes.Encode(mem_.ToArray, encryptByte_, Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
        main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & ToEran & "; " & "/packetname " & PacketName & "; /currentPacket " & div & "; /packetcount " & div & "; /hash " & rHash.HashByte(Data, rHash.HASH.MD5) & "; /packetbytes " & Convert.ToBase64String(encryptByte_) & ";")
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
