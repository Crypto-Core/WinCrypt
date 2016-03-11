Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

''' <summary>
''' Das ist eine Kryptographieklasse die die Verschlüsselungsalgorithmen aus den .NET Framework
''' zusammenfasst und in einfach anzuwendenen Funktionen kapselt.
''' </summary>
''' <remarks>Tim Hartwig</remarks>
Public Class AESEncrypt
    Private mKeySalt() As Byte = {&HA1, &H41, &HC4, &HF5, &H23, &H70, &HBF, &H52}
    Private mIVSalt() As Byte = {&H47, &H80, &H22, &HFF, &H12, &HE7, &HF1, &H39}
    Private mBitLen As Integer

    Public Event ProgressError(ByVal sender As Object, ByVal ex As Exception)

    ''' <summary>
    ''' Gibt einen Salt-Wert für das Passwort für die Verschlüsselung an (ab 8 Bytes)
    ''' </summary>
    Public Property KeySalt() As Byte()
        Get
            Return mKeySalt
        End Get
        Set(ByVal value As Byte())
            If value.Length < 8 Then
                Throw New Exception("Der Salt-Wert ist zu klein. Der Wert muss  >= 8 Bytes sein.")
            Else
                mKeySalt = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gibt einen Salt-Wert für den InitialisierungsVektor für die Verschlüsselung an (ab 8 Bytes)
    ''' </summary>
    Public Property IVSalt() As Byte()
        Get
            Return mIVSalt
        End Get
        Set(ByVal value As Byte())
            If value.Length < 8 Then
                Throw New Exception("Der Salt-Wert ist zu klein. Der Wert muss  >= 8 Bytes sein.")
            Else
                mIVSalt = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gibt die Verschlüsselungsstärke in Bits an:
    ''' DES = 64;  TDES = 128,192;  RIJNDAEL = 128,192,256;  RC2 = 40 bis 128 (8er Schritte)
    ''' </summary>
    Public Property BitLen() As Integer
        Get
            Return mBitLen * 8
        End Get
        Set(ByVal value As Integer)
            If value Mod 8 = 1 Then Throw New Exception("Es wurde keine gültige Bitstärke für die Verschlüsselung angegeben!")
            mBitLen = value / 8
        End Set
    End Property

    Public Enum ALGO As Integer
        ''' <summary>
        ''' 64 Bit
        ''' </summary>
        DES = 0

        ''' <summary>
        ''' 128 Bit, 192 Bit
        ''' </summary>
        TDES = 1

        ''' <summary>
        ''' 128 Bit, 192 Bit, 256 Bit
        ''' </summary>
        RIJNDAEL = 2

        ''' <summary>
        ''' 40 - 128 Bit
        ''' </summary>
        RC2 = 3
    End Enum

    Private Sub CheckBitLen(ByVal Algorithm As ALGO)
        Select Case Algorithm
            Case ALGO.DES
                If (mBitLen = 0) Or (Not mBitLen = 8) Then mBitLen = 8
            Case ALGO.TDES
                If (mBitLen = 0) Or (Not mBitLen = 16) Or (Not mBitLen = 24) Then mBitLen = 24
            Case ALGO.RIJNDAEL
                If (mBitLen = 0) Or (Not mBitLen = 16) Or (Not mBitLen = 24) Or (Not mBitLen = 32) Then mBitLen = 32
            Case ALGO.RC2
                If (mBitLen < 5) Or (mBitLen > 16) Then mBitLen = 16
        End Select
    End Sub

    ''' <summary>
    ''' Diese Funktion verschlüsselt eine Datei und speichert es in eine andere Datei (HDD -> HDD)
    ''' </summary>
    Public Overloads Function Encode(ByVal SourceFile As String, ByVal TargetFile As String, ByVal Password As String, ByVal Algorithm As ALGO, Optional ByVal BufferSize As Integer = 4096) As Boolean
        Try
            Dim InFileStream As New FileStream(SourceFile, FileMode.Open)
            Dim OutFileStream As New FileStream(TargetFile, FileMode.Create)
            Dim CryptStream As CryptoStream = Nothing

            Dim Data(BufferSize - 1) As Byte
            Dim Buffer As Long
            Dim BufferCount As Long
            Dim FileLen As Long = InFileStream.Length

            Dim MakeKey As New Rfc2898DeriveBytes(Password, mKeySalt)
            Dim MakeIV As New Rfc2898DeriveBytes(Password, mIVSalt)

            'Prüfen ob die Bitstärke mit dem gewählten Algorithmus übereinstimmt und evtl. anpassen
            CheckBitLen(Algorithm)

            Select Case Algorithm
                Case ALGO.DES
                    Dim DES As New DESCryptoServiceProvider
                    CryptStream = New CryptoStream(OutFileStream, DES.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write) '8
                Case ALGO.TDES
                    Dim TDES As New TripleDESCryptoServiceProvider
                    CryptStream = New CryptoStream(OutFileStream, TDES.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write) '16,24
                Case ALGO.RIJNDAEL
                    Dim RIJNDAEL As New RijndaelManaged
                    CryptStream = New CryptoStream(OutFileStream, RIJNDAEL.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write) '16,24,32
                Case ALGO.RC2
                    Dim RC2 As New RC2CryptoServiceProvider
                    CryptStream = New CryptoStream(OutFileStream, RC2.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write) '5 bis 16
            End Select

            Do
                If BufferCount >= FileLen - BufferSize Then
                    ReDim Data(FileLen - BufferCount)
                    Buffer = InFileStream.Read(Data, 0, FileLen - BufferCount)
                    CryptStream.Write(Data, 0, Buffer)
                    Exit Do
                End If

                Buffer = InFileStream.Read(Data, 0, BufferSize)
                CryptStream.Write(Data, 0, BufferSize)
                BufferCount += Buffer
            Loop

            InFileStream.Close()
            CryptStream.Close()
            OutFileStream.Close()
            Return True
        Catch ex As Exception
            RaiseEvent ProgressError(Me, ex)
        End Try
    End Function

    ''' <summary>
    ''' Diese Funktion verschlüsselt ein ByteArray und speichert es in eine Datei (RAM -> HDD)
    ''' </summary>
    Public Overloads Function Encode(ByRef SourceByte() As Byte, ByVal TargetFile As String, ByVal Password As String, ByVal Algorithm As ALGO, Optional ByVal BufferSize As Integer = 4096) As Boolean
        Try
            Dim InByteStream As New MemoryStream(SourceByte, False)
            Dim OutFileStream As New FileStream(TargetFile, FileMode.Create)
            Dim CryptStream As CryptoStream = Nothing

            Dim Data(BufferSize - 1) As Byte
            Dim Buffer As Long
            Dim BufferCount As Long
            Dim FileLen As Long = InByteStream.Length

            Dim MakeKey As New Rfc2898DeriveBytes(Password, mKeySalt)
            Dim MakeIV As New Rfc2898DeriveBytes(Password, mIVSalt)

            'Prüfen ob die Bitstärke mit dem gewählten Algorithmus übereinstimmt und evtl. anpassen
            CheckBitLen(Algorithm)

            Select Case Algorithm
                Case ALGO.DES
                    Dim DES As New DESCryptoServiceProvider
                    CryptStream = New CryptoStream(OutFileStream, DES.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write)
                Case ALGO.TDES
                    Dim TDES As New TripleDESCryptoServiceProvider
                    CryptStream = New CryptoStream(OutFileStream, TDES.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write)
                Case ALGO.RIJNDAEL
                    Dim RIJNDAEL As New RijndaelManaged
                    CryptStream = New CryptoStream(OutFileStream, RIJNDAEL.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write)
                Case ALGO.RC2
                    Dim RC2 As New RC2CryptoServiceProvider
                    CryptStream = New CryptoStream(OutFileStream, RC2.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write)
            End Select

            Do
                If BufferCount >= FileLen - BufferSize Then
                    ReDim Data(FileLen - BufferCount)
                    Buffer = InByteStream.Read(Data, 0, FileLen - BufferCount)
                    CryptStream.Write(Data, 0, Buffer)
                    Exit Do
                End If

                Buffer = InByteStream.Read(Data, 0, BufferSize)
                CryptStream.Write(Data, 0, BufferSize)
                BufferCount += Buffer
            Loop

            InByteStream.Close()
            CryptStream.Close()
            OutFileStream.Close()
            Return True
        Catch ex As Exception
            RaiseEvent ProgressError(Me, ex)
        End Try
    End Function

    ''' <summary>
    ''' Diese Funktion verschlüsselt eine Datei und speichert es in ein ByteArray (HDD -> RAM)
    ''' </summary>
    Public Overloads Function Encode(ByVal SourceFile As String, ByRef TargetByte() As Byte, ByVal Password As String, ByVal Algorithm As ALGO, Optional ByVal BufferSize As Integer = 4096) As Boolean
        Try
            Dim InFileStream As New FileStream(SourceFile, FileMode.Open)
            Dim OutByteStream As New MemoryStream
            Dim CryptStream As CryptoStream = Nothing

            Dim Data(BufferSize - 1) As Byte
            Dim Buffer As Long
            Dim BufferCount As Long
            Dim FileLen As Long = InFileStream.Length

            Dim MakeKey As New Rfc2898DeriveBytes(Password, mKeySalt)
            Dim MakeIV As New Rfc2898DeriveBytes(Password, mIVSalt)

            'Prüfen ob die Bitstärke mit dem gewählten Algorithmus übereinstimmt und evtl. anpassen
            CheckBitLen(Algorithm)

            Select Case Algorithm
                Case ALGO.DES
                    Dim DES As New DESCryptoServiceProvider
                    CryptStream = New CryptoStream(OutByteStream, DES.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write)
                Case ALGO.TDES
                    Dim TDES As New TripleDESCryptoServiceProvider
                    CryptStream = New CryptoStream(OutByteStream, TDES.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write)
                Case ALGO.RIJNDAEL
                    Dim RIJNDAEL As New RijndaelManaged
                    CryptStream = New CryptoStream(OutByteStream, RIJNDAEL.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write)
                Case ALGO.RC2
                    Dim RC2 As New RC2CryptoServiceProvider
                    CryptStream = New CryptoStream(OutByteStream, RC2.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write)
            End Select

            Do
                If BufferCount >= FileLen - BufferSize Then
                    ReDim Data(FileLen - BufferCount)
                    Buffer = InFileStream.Read(Data, 0, FileLen - BufferCount)
                    CryptStream.Write(Data, 0, Buffer)
                    Exit Do
                End If

                Buffer = InFileStream.Read(Data, 0, BufferSize)
                CryptStream.Write(Data, 0, BufferSize)
                BufferCount += Buffer
            Loop

            InFileStream.Close()
            CryptStream.Close()
            OutByteStream.Close()

            TargetByte = OutByteStream.ToArray
            Return True
        Catch ex As Exception
            RaiseEvent ProgressError(Me, ex)
        End Try
    End Function

    ''' <summary>
    ''' Diese Funktion verschlüsselt ein ByteArray und speichert es in ein anders ByteArray (RAM -> RAM)
    ''' </summary>
    Public Overloads Function Encode(ByRef SourceByte() As Byte, ByRef TargetByte() As Byte, ByVal Password As String, ByVal Algorithm As ALGO, Optional ByVal BufferSize As Integer = 4096) As Boolean
        Try
            Dim InByteStream As New MemoryStream(SourceByte, False)
            Dim OutByteStream As New MemoryStream
            Dim CryptStream As CryptoStream = Nothing

            Dim Data(BufferSize - 1) As Byte
            Dim Buffer As Long
            Dim BufferCount As Long
            Dim FileLen As Long = InByteStream.Length

            Dim MakeKey As New Rfc2898DeriveBytes(Password, mKeySalt)
            Dim MakeIV As New Rfc2898DeriveBytes(Password, mIVSalt)

            'Prüfen ob die Bitstärke mit dem gewählten Algorithmus übereinstimmt und evtl. anpassen
            CheckBitLen(Algorithm)

            Select Case Algorithm
                Case ALGO.DES
                    Dim DES As New DESCryptoServiceProvider
                    CryptStream = New CryptoStream(OutByteStream, DES.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write)
                Case ALGO.TDES
                    Dim TDES As New TripleDESCryptoServiceProvider
                    CryptStream = New CryptoStream(OutByteStream, TDES.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write)
                Case ALGO.RIJNDAEL
                    Dim RIJNDAEL As New RijndaelManaged
                    CryptStream = New CryptoStream(OutByteStream, RIJNDAEL.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write)
                Case ALGO.RC2
                    Dim RC2 As New RC2CryptoServiceProvider
                    CryptStream = New CryptoStream(OutByteStream, RC2.CreateEncryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Write)
            End Select

            Do
                If BufferCount >= FileLen - BufferSize Then
                    ReDim Data(FileLen - BufferCount)
                    Buffer = InByteStream.Read(Data, 0, FileLen - BufferCount)
                    CryptStream.Write(Data, 0, Buffer)
                    Exit Do
                End If

                Buffer = InByteStream.Read(Data, 0, BufferSize)
                CryptStream.Write(Data, 0, BufferSize)
                BufferCount += Buffer
            Loop

            InByteStream.Close()
            CryptStream.Close()
            OutByteStream.Close()

            TargetByte = OutByteStream.ToArray
            Return True
        Catch ex As Exception
            RaiseEvent ProgressError(Me, ex)
        End Try
    End Function

    ''' <summary>
    ''' Diese Funktion entschlüsselt eine Datei und speichert es in eine andere Datei (HDD -> HDD)
    ''' </summary>
    Public Overloads Function Decode(ByVal SourceFile As String, ByVal TargetFile As String, ByVal Password As String, ByVal Algorithm As ALGO, Optional ByVal BufferSize As Integer = 4096) As Boolean
        Try
            Dim InFileStream As New FileStream(SourceFile, FileMode.Open)
            Dim OutFileStream As New FileStream(TargetFile, FileMode.Create)
            Dim CryptStream As CryptoStream = Nothing

            Dim Data(BufferSize - 1) As Byte
            Dim Buffer As Long
            Dim BufferCount As Long
            Dim FileLen As Long = InFileStream.Length

            Dim MakeKey As New Rfc2898DeriveBytes(Password, mKeySalt)
            Dim MakeIV As New Rfc2898DeriveBytes(Password, mIVSalt)

            'Prüfen ob die Bitstärke mit dem gewählten Algorithmus übereinstimmt und evtl. anpassen
            CheckBitLen(Algorithm)

            Select Case Algorithm
                Case ALGO.DES
                    Dim DES As New DESCryptoServiceProvider
                    CryptStream = New CryptoStream(InFileStream, DES.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
                Case ALGO.TDES
                    Dim TDES As New TripleDESCryptoServiceProvider
                    CryptStream = New CryptoStream(InFileStream, TDES.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
                Case ALGO.RIJNDAEL
                    Dim RIJNDAEL As New RijndaelManaged
                    CryptStream = New CryptoStream(InFileStream, RIJNDAEL.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
                Case ALGO.RC2
                    Dim RC2 As New RC2CryptoServiceProvider
                    CryptStream = New CryptoStream(InFileStream, RC2.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
            End Select

            Do
                If BufferCount >= FileLen - BufferSize Then
                    ReDim Data(FileLen - BufferCount)
                    Buffer = CryptStream.Read(Data, 0, FileLen - BufferCount)
                    OutFileStream.Write(Data, 0, Buffer)
                    Exit Do
                End If

                Buffer = CryptStream.Read(Data, 0, BufferSize)
                OutFileStream.Write(Data, 0, BufferSize)
                BufferCount += Buffer
            Loop

            OutFileStream.Close()
            CryptStream.Close()
            InFileStream.Close()
            Return True
        Catch ex As Exception
            RaiseEvent ProgressError(Me, ex)
        End Try
    End Function

    ''' <summary>
    ''' Diese Funktion entschlüsselt ein ByteArray und speichert es in eine Datei (RAM -> HDD)
    ''' </summary>
    Public Overloads Function Decode(ByRef SourceByte() As Byte, ByVal TargetFile As String, ByVal Password As String, ByVal Algorithm As ALGO, Optional ByVal BufferSize As Integer = 4096) As Boolean
        Try
            Dim InByteStream As New MemoryStream(SourceByte, False)
            Dim OutFileStream As New FileStream(TargetFile, FileMode.Create)
            Dim CryptStream As CryptoStream = Nothing

            Dim Data(BufferSize - 1) As Byte
            Dim Buffer As Long
            Dim BufferCount As Long
            Dim FileLen As Long = InByteStream.Length

            Dim MakeKey As New Rfc2898DeriveBytes(Password, mKeySalt)
            Dim MakeIV As New Rfc2898DeriveBytes(Password, mIVSalt)

            'Prüfen ob die Bitstärke mit dem gewählten Algorithmus übereinstimmt und evtl. anpassen
            CheckBitLen(Algorithm)

            Select Case Algorithm
                Case ALGO.DES
                    Dim DES As New DESCryptoServiceProvider
                    CryptStream = New CryptoStream(InByteStream, DES.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
                Case ALGO.TDES
                    Dim TDES As New TripleDESCryptoServiceProvider
                    CryptStream = New CryptoStream(InByteStream, TDES.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
                Case ALGO.RIJNDAEL
                    Dim RIJNDAEL As New RijndaelManaged
                    CryptStream = New CryptoStream(InByteStream, RIJNDAEL.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
                Case ALGO.RC2
                    Dim RC2 As New RC2CryptoServiceProvider
                    CryptStream = New CryptoStream(InByteStream, RC2.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
            End Select

            Do
                If BufferCount >= FileLen - BufferSize Then
                    ReDim Data(FileLen - BufferCount)
                    Buffer = CryptStream.Read(Data, 0, FileLen - BufferCount)
                    OutFileStream.Write(Data, 0, Buffer)
                    Exit Do
                End If

                Buffer = CryptStream.Read(Data, 0, BufferSize)
                OutFileStream.Write(Data, 0, BufferSize)
                BufferCount += Buffer
            Loop

            OutFileStream.Close()
            CryptStream.Close()
            InByteStream.Close()
            Return True
        Catch ex As Exception
            RaiseEvent ProgressError(Me, ex)
        End Try
    End Function

    ''' <summary>
    ''' Diese Funktion entschlüsselt eine Datei und speichert es in ein ByteArray (HDD -> RAM)
    ''' </summary>
    Public Overloads Function Decode(ByVal SourceFile As String, ByRef TargetByte() As Byte, ByVal Password As String, ByVal Algorithm As ALGO, Optional ByVal BufferSize As Integer = 4096) As Boolean
        Try
            Dim InFileStream As New FileStream(SourceFile, FileMode.Open)
            Dim OutByteStream As New MemoryStream
            Dim CryptStream As CryptoStream = Nothing

            Dim Data(BufferSize - 1) As Byte
            Dim Buffer As Long
            Dim BufferCount As Long
            Dim FileLen As Long = InFileStream.Length

            Dim MakeKey As New Rfc2898DeriveBytes(Password, mKeySalt)
            Dim MakeIV As New Rfc2898DeriveBytes(Password, mIVSalt)

            'Prüfen ob die Bitstärke mit dem gewählten Algorithmus übereinstimmt und evtl. anpassen
            CheckBitLen(Algorithm)

            Select Case Algorithm
                Case ALGO.DES
                    Dim DES As New DESCryptoServiceProvider
                    CryptStream = New CryptoStream(InFileStream, DES.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
                Case ALGO.TDES
                    Dim TDES As New TripleDESCryptoServiceProvider
                    CryptStream = New CryptoStream(InFileStream, TDES.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
                Case ALGO.RIJNDAEL
                    Dim RIJNDAEL As New RijndaelManaged
                    CryptStream = New CryptoStream(InFileStream, RIJNDAEL.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
                Case ALGO.RC2
                    Dim RC2 As New RC2CryptoServiceProvider
                    CryptStream = New CryptoStream(InFileStream, RC2.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
            End Select

            Do
                If BufferCount >= FileLen - BufferSize Then
                    ReDim Data(FileLen - BufferCount)
                    Buffer = CryptStream.Read(Data, 0, FileLen - BufferCount)
                    OutByteStream.Write(Data, 0, Buffer)
                    Exit Do
                End If

                Buffer = CryptStream.Read(Data, 0, BufferSize)
                OutByteStream.Write(Data, 0, BufferSize)
                BufferCount += Buffer
            Loop

            OutByteStream.Close()
            CryptStream.Close()
            InFileStream.Close()

            TargetByte = OutByteStream.ToArray()
            Return True
        Catch ex As Exception
            RaiseEvent ProgressError(Me, ex)
        End Try
    End Function

    ''' <summary>
    ''' Diese Funktion entschlüsselt ein ByteArray und speichert es in ein anders ByteArray (RAM -> RAM)
    ''' </summary>
    Public Overloads Function Decode(ByRef SourceByte() As Byte, ByRef TargetByte() As Byte, ByVal Password As String, ByVal Algorithm As ALGO, Optional ByVal BufferSize As Integer = 4096) As Boolean
        Try
            Dim InByteStream As New MemoryStream(SourceByte, False)
            Dim OutByteStream As New MemoryStream
            Dim CryptStream As CryptoStream = Nothing

            Dim Data(BufferSize - 1) As Byte
            Dim Buffer As Long
            Dim BufferCount As Long
            Dim FileLen As Long = InByteStream.Length

            Dim MakeKey As New Rfc2898DeriveBytes(Password, mKeySalt)
            Dim MakeIV As New Rfc2898DeriveBytes(Password, mIVSalt)

            'Prüfen ob die Bitstärke mit dem gewählten Algorithmus übereinstimmt und evtl. anpassen
            CheckBitLen(Algorithm)

            Select Case Algorithm
                Case ALGO.DES
                    Dim DES As New DESCryptoServiceProvider
                    CryptStream = New CryptoStream(InByteStream, DES.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
                Case ALGO.TDES
                    Dim TDES As New TripleDESCryptoServiceProvider
                    CryptStream = New CryptoStream(InByteStream, TDES.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
                Case ALGO.RIJNDAEL
                    Dim RIJNDAEL As New RijndaelManaged
                    CryptStream = New CryptoStream(InByteStream, RIJNDAEL.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
                Case ALGO.RC2
                    Dim RC2 As New RC2CryptoServiceProvider
                    CryptStream = New CryptoStream(InByteStream, RC2.CreateDecryptor(MakeKey.GetBytes(mBitLen), MakeIV.GetBytes(16)), CryptoStreamMode.Read)
            End Select

            Do
                If BufferCount >= FileLen - BufferSize Then
                    ReDim Data(FileLen - BufferCount)
                    Buffer = CryptStream.Read(Data, 0, FileLen - BufferCount)
                    OutByteStream.Write(Data, 0, Buffer)
                    Exit Do
                End If

                Buffer = CryptStream.Read(Data, 0, BufferSize)
                OutByteStream.Write(Data, 0, BufferSize)
                BufferCount += Buffer
            Loop

            OutByteStream.Close()
            CryptStream.Close()
            InByteStream.Close()

            TargetByte = OutByteStream.ToArray
            Return True
        Catch ex As Exception
            RaiseEvent ProgressError(Me, ex)
        End Try
    End Function
End Class