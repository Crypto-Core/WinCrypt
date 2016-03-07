Public Class connected_usr
    Friend Shared usr_lst As New List(Of Encrypted_User)
    Friend Structure Encrypted_User
        Dim Eran_adress As String
        Dim Key As String
    End Structure
    Friend Shared Function remove_encrypt_session(ByVal eran_adress As String)
        On Error Resume Next
        For Each check In connected_usr.usr_lst
            If eran_adress = check.Eran_adress Then
                usr_lst.Remove(check)
            End If
        Next
    End Function
    Friend Shared Function isConnect_Encrypt(ByVal eran_adress As String) As Boolean
        For Each check In connected_usr.usr_lst
            If eran_adress = check.Eran_adress Then
                Return True
                End
            End If
        Next
        Return False
    End Function

    Friend Shared Function broke_all_sessions()
        For Each check In connected_usr.usr_lst
            main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & check.Eran_adress & "; /handshake 3;")
        Next
        connected_usr.usr_lst.RemoveRange(0, connected_usr.usr_lst.Count)

    End Function
End Class
