Module Module1
    Public Structure BrowseInfo
    lngHwnd        As Long
    pIDLRoot       As Long
    pszDisplayName As Long
    lpszTitle      As Long
    ulFlags        As Long
    lpfnCallback   As Long
    lParam         As Long
    iImage         As Long
    End Structure

    Public Const BIF_RETURNONLYFSDIRS = 1
    Public Const MAX_PATH = 260

    Declare Sub CoTaskMemFree Lib "ole32.dll" _
        (ByVal hMem As Long)

    Declare Function lstrcat Lib "kernel32" _
       Alias "lstrcatA" (ByVal lpString1 As String, _
       ByVal lpString2 As String) As Long

    Declare Function SHBrowseForFolder Lib "shell32" _
       (ByVal lpbi As BrowseInfo) As Long

    Declare Function SHGetPathFromIDList Lib "shell32" _
       (ByVal pidList As Long, ByVal lpBuffer As String) As Long

    Declare Function GetDriveType Lib "kernel32" Alias "GetDriveTypeA" (ByVal nDrive As String) As Long

Global Drives(1 To 26) As String

    Public Function BrowseForFolder(ByVal lngHwnd As Long, ByVal strPrompt As String) As String

        On Error GoTo ehBrowseForFolder 'Trap for errors

        Dim intNull As Integer
        Dim lngIDList As Long, lngResult As Long
        Dim strPath As String
        Dim udtBI As BrowseInfo

        'Set API properties (housed in a UDT)
        With udtBI_
            .lngHwnd = lngHwnd
            .lpszTitle = lstrcat(strPrompt, "")
            .ulFlags = BIF_RETURNONLYFSDIRS
        End With

        'Display the browse folder...
        lngIDList = SHBrowseForFolder(udtBI)

        If lngIDList <> 0 Then
            'Create string of nulls so it will fill in with the path
        strPath = String(MAX_PATH, 0)

            'Retrieves the path selected, places in the null
            'character filled string
            lngResult = SHGetPathFromIDList(lngIDList, strPath)

            'Frees memory
            Call CoTaskMemFree(lngIDList)

            'Find the first instance of a null character,
            'so we can get just the path
            intNull = InStr(strPath, vbNullChar)
            'Greater than 0 means the path exists...
            If intNull > 0 Then
                'Set the value
                strPath = Left(strPath, intNull - 1)
            End If
        End If

        'Return the path name
        BrowseForFolder = strPath
        Exit Function 'Abort

ehBrowseForFolder:

        'Return no value
        BrowseForFolder = Empty

    End Function

    Sub SetDrives()
        Drives(1) = "a:"
        Drives(2) = "b:"
        Drives(3) = "c:"
        Drives(4) = "d:"
        Drives(5) = "e:"
        Drives(6) = "f:"
        Drives(7) = "g:"
        Drives(8) = "h:"
        Drives(9) = "i:"
        Drives(10) = "j:"
        Drives(11) = "k:"
        Drives(12) = "l:"
        Drives(13) = "m:"
        Drives(14) = "n:"
        Drives(15) = "o:"
        Drives(16) = "p:"
        Drives(17) = "q:"
        Drives(18) = "r:"
        Drives(19) = "s:"
        Drives(20) = "t:"
        Drives(21) = "u:"
        Drives(22) = "v:"
        Drives(23) = "w:"
        Drives(24) = "x:"
        Drives(25) = "y:"
        Drives(26) = "z:"
    End Sub

    Private Function udtBI_() As Object
        Throw New NotImplementedException
    End Function

End Module
