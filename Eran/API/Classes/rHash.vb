
Imports System.Security.Cryptography
Imports System.Text

Friend Class rHash
    Friend Enum HASH
        MD5
        SHA1
        SHA256
        SHA384
        SHA512
        RIPEMD160
    End Enum

    ''' <summary>
    '''     Diese Funktion berechnet einen Hash von einem String
    ''' </summary>
    ''' <param name="Value">Den String von dem ein Hash berechnet werden soll</param>
    ''' <param name="Hash">Gibt den Hashalgorithmus an</param>
    Friend Shared Function HashString(ByVal Value As String, ByVal Hash As HASH) As String
        Dim Data(0) As Byte
        Dim HashValue(0) As Byte
        Dim Result = ""
        Dim Tmp = ""

        Select Case Hash
            Case Hash.MD5
                Dim MD5 As New MD5CryptoServiceProvider
                Data = Encoding.ASCII.GetBytes(Value)
                HashValue = MD5.ComputeHash(Data)

            Case Hash.SHA1
                Dim SHA1 As New SHA1Managed
                Data = Encoding.ASCII.GetBytes(Value)
                HashValue = SHA1.ComputeHash(Data)

            Case Hash.SHA256
                Dim SHA256 As New SHA256Managed
                Data = Encoding.ASCII.GetBytes(Value)
                HashValue = SHA256.ComputeHash(Data)

            Case Hash.SHA384
                Dim SHA384 As New SHA384Managed
                Data = Encoding.ASCII.GetBytes(Value)
                HashValue = SHA384.ComputeHash(Data)

            Case Hash.SHA512
                Dim SHA512 As New SHA512Managed
                Data = Encoding.ASCII.GetBytes(Value)
                HashValue = SHA512.ComputeHash(Data)

            Case Hash.RIPEMD160
                Dim RIPEMD160 As New RIPEMD160Managed
                Data = Encoding.ASCII.GetBytes(Value)
                HashValue = RIPEMD160.ComputeHash(Data)
        End Select

        For i = 0 To HashValue.Length - 1
            Tmp = Hex(HashValue(i))
            If Len(Tmp) = 1 Then Tmp = 0 & CStr(Tmp)
            Result += Tmp
        Next
        Return CStr(Result)
    End Function
    Friend Shared Function HashByte(ByVal bytes As Byte(), ByVal Hash As HASH) As String

        Dim HashValue(0) As Byte
        Dim Result = ""
        Dim Tmp = ""

        Select Case Hash
            Case Hash.MD5
                Dim MD5 As New MD5CryptoServiceProvider

                HashValue = MD5.ComputeHash(bytes)

            Case Hash.SHA1
                Dim SHA1 As New SHA1Managed

                HashValue = SHA1.ComputeHash(bytes)

            Case Hash.SHA256
                Dim SHA256 As New SHA256Managed

                HashValue = SHA256.ComputeHash(bytes)

            Case Hash.SHA384
                Dim SHA384 As New SHA384Managed

                HashValue = SHA384.ComputeHash(bytes)

            Case Hash.SHA512
                Dim SHA512 As New SHA512Managed

                HashValue = SHA512.ComputeHash(bytes)

            Case Hash.RIPEMD160
                Dim RIPEMD160 As New RIPEMD160Managed

                HashValue = RIPEMD160.ComputeHash(bytes)
        End Select

        For i = 0 To HashValue.Length - 1
            Tmp = Hex(HashValue(i))
            If Len(Tmp) = 1 Then Tmp = "0" & Tmp
            Result += Tmp
        Next
        Return Result
    End Function
End Class