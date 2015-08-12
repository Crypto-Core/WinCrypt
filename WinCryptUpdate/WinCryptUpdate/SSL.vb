Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Public Class SSL
    Public Function SSL_validation(ByVal localKey As String, ByVal serverKey As String) As Boolean
        Dim lKey As String = Nothing
        Try
            Dim local As New X509Certificate(localKey)
            lKey = local.GetPublicKeyString
        Catch ex As Exception
            MsgBox("Local SSL certificate does not exist!", MsgBoxStyle.Critical)
        End Try

        Dim res As HttpWebResponse = Nothing
        Dim req As HttpWebRequest = CType(WebRequest.Create(serverKey), HttpWebRequest)
        res = CType(req.GetResponse(), HttpWebResponse)
        Dim currentServicePoint As ServicePoint = req.ServicePoint

        Dim sKey As String = currentServicePoint.Certificate.GetPublicKeyString
        If lKey = sKey Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
