Public Class Base64
    Public Shared Function Str_To_Base64Str(ByVal str As String) As String
        Dim read_bytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(str)
        Dim encode As String = Convert.ToBase64String(read_bytes)
        Return encode
    End Function
    Public Shared Function encodeBytes_to_Base64Str(ByVal bytes As Byte()) As String
        Dim encode As String = Convert.ToBase64String(bytes)
        Return encode
    End Function
    Public Shared Function FromBase64Str_to_Str(ByVal base64_str As String) As String
        Try
            Dim read_bytes As Byte() = Convert.FromBase64String(base64_str)
            Dim decode As String = System.Text.UTF8Encoding.UTF8.GetChars(read_bytes)
            Return decode
        Catch ex As Exception

        End Try
        
    End Function
    Public Shared Function FromBase64Str_to_decodeBytes(ByVal base64_str As String) As Byte()
        Dim decode As Byte() = Convert.FromBase64String(base64_str)
        Return decode
    End Function
End Class
