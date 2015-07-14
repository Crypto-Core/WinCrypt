Imports System.Net
Imports System.IO

Public Class counter
    Public Function counter()
        Try
            'Hole den Aktuellen Status des WinCrypt Counters
            Dim httpRequest As HttpWebRequest = HttpWebRequest.Create("http://wincrypt.org/count/get.php")
            Dim httpResponse As HttpWebResponse = httpRequest.GetResponse()
            Dim reader As StreamReader = New StreamReader(httpResponse.GetResponseStream)
            Dim httpContent As String = reader.ReadToEnd
            Dim browser As New WebBrowser
            Dim setcount As Integer

            'Der aktuelle WinCrypt Counter wird mit 1 addiert
            setcount = httpContent + 1
            ' Es wird der WinCrypt Counter um 1 erhöt
            browser.Navigate("http://wincrypt.org/count/set.php?count=" & setcount)
        Catch ex As Exception
        End Try
    End Function
End Class
