Option Strict On

Imports System.Security.Cryptography
Imports System.Text

Public Class rHash
    Public Enum HASH As Integer
        MD5 = 0
        SHA1 = 1
        SHA256 = 2
        SHA384 = 3
        SHA512 = 4
        RIPEMD160 = 5
    End Enum

    ''' <summary>
    '''     Diese Funktion berechnet einen Hash von einem String
    ''' </summary>
    ''' <param name="Value">Den String von dem ein Hash berechnet werden soll</param>
    ''' <param name="Hash">Gibt den Hashalgorithmus an</param>
    Public Shared Function HashString(Value As String, Hash As HASH) As String
        Dim Data(0) As Byte
        Dim HashValue(0) As Byte
        Dim Result = ""
        Dim Tmp = ""

        Select Case Hash
            Case HASH.MD5
                Dim MD5 As New MD5CryptoServiceProvider
                Data = Encoding.ASCII.GetBytes(Value)
                HashValue = MD5.ComputeHash(Data)

            Case HASH.SHA1
                Dim SHA1 As New SHA1Managed
                Data = Encoding.ASCII.GetBytes(Value)
                HashValue = SHA1.ComputeHash(Data)

            Case HASH.SHA256
                Dim SHA256 As New SHA256Managed
                Data = Encoding.ASCII.GetBytes(Value)
                HashValue = SHA256.ComputeHash(Data)

            Case HASH.SHA384
                Dim SHA384 As New SHA384Managed
                Data = Encoding.ASCII.GetBytes(Value)
                HashValue = SHA384.ComputeHash(Data)

            Case HASH.SHA512
                Dim SHA512 As New SHA512Managed
                Data = Encoding.ASCII.GetBytes(Value)
                HashValue = SHA512.ComputeHash(Data)

            Case HASH.RIPEMD160
                Dim RIPEMD160 As New RIPEMD160Managed
                Data = Encoding.ASCII.GetBytes(Value)
                HashValue = RIPEMD160.ComputeHash(Data)
        End Select

        For i = 0 To HashValue.Length - 1
            Tmp = Hex(HashValue(i))
            If Len(Tmp) = 1 Then Tmp = "0" & Tmp
            Result += Tmp
        Next
        Return Result
    End Function
End Class
