Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Public Class SSL
    Public Function SSL_validation(ByVal localKey As String, ByVal serverKey As String) As Boolean
        Dim lKey As String = Nothing
        Try
            Dim local As New X509Certificate(localKey)
            lKey = local.GetCertHashString
        Catch ex As Exception
            MsgBox("Local SSL certificate does not exist!", MsgBoxStyle.Critical)
        End Try

        Dim res As HttpWebResponse = Nothing
        Dim req As HttpWebRequest = CType(WebRequest.Create(serverKey), HttpWebRequest)
        Try
            res = CType(req.GetResponse(), HttpWebResponse)
        Catch ex As Exception
            MsgBox("Warning: Possibly an attack was also carried out your connection!", MsgBoxStyle.Critical)
        End Try

        Dim currentServicePoint As ServicePoint = req.ServicePoint

        Dim sKey As String = currentServicePoint.Certificate.GetCertHashString
        If lKey = sKey Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
