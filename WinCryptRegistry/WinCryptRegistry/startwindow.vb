Imports Microsoft.Win32

Public Class startwindow
    Private Sub startwindow(sender As Object, e As EventArgs) Handles MyBase.Load
        If _
            Registerfile(".wc", "WinCrypt-Datei", Application.StartupPath & "\Project WinCrypt.exe",
                         Application.StartupPath & "\icon.ico") Then
        Else :
        End If

        If _
            Registerfile(".wcp", "WinCryptPath-Datei", Application.StartupPath & "\Project WinCrypt.exe",
                         Application.StartupPath & "\wcp.ico") Then
            MsgBox("Dateitypen wurden registriert", MsgBoxStyle.Information)
        Else
            MessageBox.Show("Die Dateiendung konnte nicht registriert werden.")
        End If
        Application.Exit()
    End Sub

    Private Function Registerfile(endung As String, namedesdateityps As String, pfadzuprogramm As String,
                                  pfadzuicon As String) As Boolean
        Try
            Dim objSubKey As RegistryKey
            Dim objSubKey2 As RegistryKey
            Dim Wert As String = namedesdateityps
            Dim sKey As String = endung
            Dim sKey2 As String = endung & "\ShellNew"
            Dim sEntry = "Content Type"
            Dim sValue = "text/plain"
            Dim sEntry2 = "PerceivedType"
            Dim sValue2 = "text"
            Dim sEntry3 = "Nullfile"
            objSubKey = My.Computer.Registry.ClassesRoot.CreateSubKey(sKey)
            objSubKey.SetValue(Nothing, Wert)
            objSubKey.SetValue(sEntry, sValue)
            objSubKey.SetValue(sEntry2, sValue2)
            objSubKey2 = My.Computer.Registry.ClassesRoot.CreateSubKey(sKey2)
            objSubKey2.SetValue(sEntry3, Nothing)
            Dim objSubKey3 As RegistryKey
            Dim sKey3 As String = namedesdateityps
            Dim sKey4 As String = namedesdateityps & "\shell\open\command"
            Dim skey5 As String = namedesdateityps & "\DefaultIcon"
            Dim sValue3 As String = namedesdateityps
            Dim objSubKey5 As RegistryKey
            Dim sValue5 As String = """" + pfadzuprogramm + """" + " %1"
            Dim sValue6 As String = """" + pfadzuicon + """"
            Dim objSubKey4 As RegistryKey
            objSubKey3 = My.Computer.Registry.ClassesRoot.CreateSubKey(sKey3)
            objSubKey3.SetValue(Nothing, sValue3)
            objSubKey4 = My.Computer.Registry.ClassesRoot.CreateSubKey(sKey4)
            objSubKey4.SetValue(Nothing, sValue5)
            objSubKey5 = My.Computer.Registry.ClassesRoot.CreateSubKey(skey5)
            objSubKey5.SetValue(Nothing, sValue6)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
