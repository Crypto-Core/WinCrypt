Imports System.Net
Imports System.IO
Public Class counter
    Public Sub counter()
        Try
            'Hole den Aktuellen Status des WinCrypt Counters
            Dim httpRequest As HttpWebRequest = CType(HttpWebRequest.Create("http://wincrypt.org/count/get.php"), HttpWebRequest)
            Dim httpResponse As HttpWebResponse = CType(httpRequest.GetResponse(), HttpWebResponse)
            Dim reader As StreamReader = New StreamReader(httpResponse.GetResponseStream)
            Dim httpContent As String = reader.ReadToEnd
            Dim browser As New WebBrowser
            Dim setcount As Integer

            'Der aktuelle WinCrypt Counter wird mit 1 addiert
            setcount = CInt(CDbl(httpContent) + 1)
            ' Es wird der WinCrypt Counter um 1 erhöt
            browser.Navigate("http://wincrypt.org/count/set.php?count=" & setcount)
        Catch ex As Exception
        End Try
    End Sub
End Class
