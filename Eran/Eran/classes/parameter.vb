﻿
Public Class parameter
    Public Shared Function read_parameter(ByVal parameter As String, ByVal get_command As String) As String
        Dim index As Integer = get_command.IndexOf(parameter)
        Do
            Try
                If get_command.Substring(index, 1) = ";" Then
                    Dim filter As String = get_command.Substring(get_command.LastIndexOf(parameter), index - get_command.LastIndexOf(parameter)).Replace(parameter, Nothing)
                    Return filter
                    Exit Function
                Else
                    index += 1
                End If
            Catch ex As Exception
                Return ""
            End Try
        Loop
    End Function

    Public Shared Function set_parameter(ByVal parameter As String, ByRef get_command As String, ByVal set_str As String) As String
        Dim index As Integer = get_command.IndexOf(parameter)
        Do
            Try
                If get_command.Substring(index, 1) = ";" Then
                    Dim filter As String = get_command.Substring(get_command.LastIndexOf(parameter), index - get_command.LastIndexOf(parameter)).Replace(parameter, Nothing)
                    get_command = get_command.Replace(parameter & filter, parameter & set_str)

                    Exit Do
                Else
                    index += 1
                End If
            Catch ex As Exception
                Return ""
            End Try
        Loop
    End Function
End Class
