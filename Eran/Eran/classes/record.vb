
Public Class record
    Private Declare Function record Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Friend Shared Function start_record() As Object
        record("open new Type waveaudio Alias recsound", "", 0, 0)
        record("record recsound", "", 0, 0)
    End Function

    Friend Shared Function save_record(ByVal path As String) As Object
        record("save recsound " & path, "", 0, 0)
        record("close recsound", "", 0, 0)
    End Function
End Class
