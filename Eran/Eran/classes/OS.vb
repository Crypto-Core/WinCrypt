Public Class OS
    Enum OSPlatform
        Unix
        Win32NT
    End Enum
    Public Shared Property OS As OSPlatform
        Get
            If My.Computer.Info.OSPlatform = "Win32NT" Then
                OS = OSPlatform.Win32NT
            End If
            If My.Computer.Info.OSPlatform = "Unix" Then
                OS = OSPlatform.Unix
            End If
        End Get
        Set(ByVal value As OSPlatform)
        End Set
    End Property

    Public Shared Function OS_slash() As String
        Select Case OS
            Case OSPlatform.Win32NT
                Return "\"
            Case OSPlatform.Unix
                Return "/"
        End Select
    End Function
End Class
