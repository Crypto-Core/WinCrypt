
Imports System.IO

Module config
    Dim ini As New IniFile
    Friend config_path As String
    Public Function load() As Object
        If File.Exists(My.Application.Info.DirectoryPath & OS.OS_slash & "config.ini") = False Then
            File.WriteAllText(My.Application.Info.DirectoryPath & OS.OS_slash & "config.ini", My.Resources.confg)
            'My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & OS.OS_slash & "config.ini", My.Resources.confg, False)
        End If
        config_path = My.Application.Info.DirectoryPath & OS.OS_slash & "config.ini"

        ini.Load(config_path)
        On Error Resume Next
        own_access_node_port = CInt(ini.GetKeyValue("config", "own_access_node_port"))
        acces_node_port = CInt(ini.GetKeyValue("config", "access_node_port"))
        Select Case ini.GetKeyValue("config", "own_access_node")
            Case CStr(0)
                own_access_node = True
            Case CStr(1)
                own_access_node = False
        End Select

        access_node_host = ini.GetKeyValue("config", "access_node_host")
        startmodus = CInt(ini.GetKeyValue("config", "startmodus"))
        Select Case ini.GetKeyValue("config", "access_node_save")
            Case CStr(0)
                acces_node_save = True
            Case CStr(1)
                acces_node_save = False
        End Select
    End Function

    Public own_access_node_port As Integer
    Public acces_node_port As Integer
    Public own_access_node As Boolean
    Public access_node_host As String
    Public startmodus As Integer
    Public acces_node_save As Boolean
End Module
