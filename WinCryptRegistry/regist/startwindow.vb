Public Class startwindow

    Private Sub startwindow(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Registerfile(".wc", "WinCrypt-Datei", Application.StartupPath & "\Project WinCrypt.exe", Application.StartupPath & "\icon.ico") Then
        Else : End If

        If Registerfile(".wcp", "WinCryptPath-Datei", Application.StartupPath & "\Project WinCrypt.exe", Application.StartupPath & "\wcp.ico") Then
            MsgBox("Dateitypen wurden registriert", MsgBoxStyle.Information)
        Else
            MessageBox.Show("Die Dateiendung konnte nicht registriert werden.")
        End If
        Application.Exit()
    End Sub
    Private Function Registerfile(ByVal endung As String, ByVal namedesdateityps As String, ByVal pfadzuprogramm As String, ByVal pfadzuicon As String) As Boolean
        Try
            Dim objSubKey As Microsoft.Win32.RegistryKey
            Dim objSubKey2 As Microsoft.Win32.RegistryKey
            Dim Wert As String = namedesdateityps
            Dim sKey As String = endung
            Dim sKey2 As String = endung & "\ShellNew"
            Dim sEntry As String = "Content Type"
            Dim sValue As String = "text/plain"
            Dim sEntry2 As String = "PerceivedType"
            Dim sValue2 As String = "text"
            Dim sEntry3 As String = "Nullfile"
            objSubKey = My.Computer.Registry.ClassesRoot.CreateSubKey(sKey)
            objSubKey.SetValue("", Wert)
            objSubKey.SetValue(sEntry, sValue)
            objSubKey.SetValue(sEntry2, sValue2)
            objSubKey2 = My.Computer.Registry.ClassesRoot.CreateSubKey(sKey2)
            objSubKey2.SetValue(sEntry3, "")
            Dim objSubKey3 As Microsoft.Win32.RegistryKey
            Dim sKey3 As String = namedesdateityps
            Dim sKey4 As String = namedesdateityps & "\shell\open\command"
            Dim skey5 As String = namedesdateityps & "\DefaultIcon"
            Dim sValue3 As String = namedesdateityps
            Dim objSubKey5 As Microsoft.Win32.RegistryKey
            Dim sValue5 As String = """" + pfadzuprogramm + """" + " %1"
            Dim sValue6 As String = """" + pfadzuicon + """"
            Dim objSubKey4 As Microsoft.Win32.RegistryKey
            objSubKey3 = My.Computer.Registry.ClassesRoot.CreateSubKey(sKey3)
            objSubKey3.SetValue("", sValue3)
            objSubKey4 = My.Computer.Registry.ClassesRoot.CreateSubKey(sKey4)
            objSubKey4.SetValue("", sValue5)
            objSubKey5 = My.Computer.Registry.ClassesRoot.CreateSubKey(skey5)
            objSubKey5.SetValue("", sValue6)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
