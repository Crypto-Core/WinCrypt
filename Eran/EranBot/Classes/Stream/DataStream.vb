
Imports System.IO

Public Class DataStream
    Friend PacketList As New List(Of Stream)
    Friend Key As String
    Friend SplitSize As Integer
    Friend Data As Byte()
    Friend ToEran As String
    Friend PacketName As String

    Friend Structure Stream
        Dim Name As String
        Dim Packets As Integer
        Dim CurrentPacket As Integer
        Dim Memory As MemoryStream
    End Structure
    
    Friend Function SendToClient() As Object
        Dim div As Double = Data.Length \ SplitSize
        Dim rest As Double = Data.Length - (div * SplitSize)
        Dim buffer As Integer = SplitSize
        Dim aes As New AESEncrypt
        For tt As Double = 0 To div - 1
            Dim mem As New MemoryStream
            mem.Write(Data, buffer - SplitSize, SplitSize)
            buffer += SplitSize
            Dim encryptByte As Byte()
            aes.Encode(mem.ToArray, encryptByte, Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
            main.API.SendToServer("/adress " & API.Account.Address & "; /to " & ToEran & "; " & "/packetname " & PacketName & "; /currentPacket " & tt & "; /packetcount " & div & "; /hash " & rHash.HashByte(Data, rHash.HASH.MD5) & "; /packetbytes " & Convert.ToBase64String(encryptByte) & ";")
        Next
        Dim mem_ As New MemoryStream
        mem_.Write(Data, (buffer - SplitSize), CInt(rest))
        Dim encryptByte_ As Byte()
        aes.Encode(mem_.ToArray, encryptByte_, Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
        main.API.SendToServer("/adress " & API.Account.Address & "; /to " & ToEran & "; " & "/packetname " & PacketName & "; /currentPacket " & div & "; /packetcount " & div & "; /hash " & rHash.HashByte(Data, rHash.HASH.MD5) & "; /packetbytes " & Convert.ToBase64String(encryptByte_) & ";")

    End Function

    Friend Function IsInPacketList(ByVal Hash As String) As Boolean
        For Each Check In PacketList
            If Check.Name = Hash Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function
End Class
