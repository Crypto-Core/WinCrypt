Module config
    Dim ini As New IniFile
    Friend config_path As String = My.Application.Info.DirectoryPath & OS.OS_slash & "config.ini"
    Public Function load()
        ini.Load(config_path)
        On Error Resume Next
        own_access_node_port = ini.GetKeyValue("config", "own_access_node_port")
        acces_node_port = ini.GetKeyValue("config", "access_node_port")
        Select Case ini.GetKeyValue("config", "own_access_node")
            Case 0
                own_access_node = True
            Case 1
                own_access_node = False
        End Select

        access_node_host = ini.GetKeyValue("config", "access_node_host")
        startmodus = ini.GetKeyValue("config", "startmodus")
        Select Case ini.GetKeyValue("config", "access_node_save")
            Case 0
                acces_node_save = True
            Case 1
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
