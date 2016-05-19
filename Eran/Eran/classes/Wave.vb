
Imports System.IO

Public Class Wave
    Public Shared Function GetDuration(ByVal Fbyte As Byte()) As Double

        Dim rifftag(4) As Char
        Dim Filesize As Long
        Dim WAVtag(4) As Char
        Dim FMTtag(4) As Char
        Dim FMTsize As Long
        Dim compresstype As Integer
        Dim channels As Integer
        Dim samplerate As Long
        Dim bytespersec As Long
        Dim bytespersample As Integer
        Dim bitspersample As Integer
        Dim wavlength As Double
        Dim str As New MemoryStream(Fbyte)
        Dim reader = New BinaryReader(str)


        rifftag = reader.ReadChars(4)
        Filesize = reader.ReadInt32
        WAVtag = reader.ReadChars(4)
        FMTtag = reader.ReadChars(4)
        FMTsize = reader.ReadInt32
        compresstype = reader.ReadInt16
        channels = reader.ReadInt16
        samplerate = reader.ReadInt32
        bytespersec = reader.ReadInt32
        bytespersample = reader.ReadInt16
        bitspersample = reader.ReadInt16

        wavlength = (Filesize / bytespersec) * 1000 ' return in milliseconds

        reader.Close()

        Return wavlength

    End Function
End Class
