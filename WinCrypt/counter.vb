Imports System.Net
Imports System.IO

Public Class counter
    Public Function counter()
        Try
            Dim httpRequest As HttpWebRequest = HttpWebRequest.Create("http://wincrypt.org/count/get.php")
            Dim httpResponse As HttpWebResponse = httpRequest.GetResponse()
            Dim reader As StreamReader = New StreamReader(httpResponse.GetResponseStream)
            Dim httpContent As String = reader.ReadToEnd
            Dim browser As New WebBrowser
            Dim setcount As Integer
            setcount = httpContent + 1
            browser.Navigate("http://wincrypt.org/count/set.php?count=" & setcount)
        Catch ex As Exception
        End Try
    End Function
End Class
