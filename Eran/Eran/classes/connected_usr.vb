Imports System.IO
Public Class connected_usr
    Friend Shared usr_lst As New List(Of Encrypted_User)
    Friend Structure Encrypted_User
        Dim Eran_adress As String
        Dim Key As String
    End Structure
    Friend Shared Function remove_encrypt_session(ByVal eran_adress As String) As Object
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

    Friend Shared Function broke_all_sessions() As Object
        For Each check In connected_usr.usr_lst
            main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & check.Eran_adress & "; /handshake 3;")
        Next
        connected_usr.usr_lst.RemoveRange(0, connected_usr.usr_lst.Count)
    End Function
    Friend Shared Function blockuser(ByVal eran_adress As String) As Object
        If main_frm.blocklist.Exists(Function(x) x = eran_adress) = False Then
            main_frm.blocklist.Add(eran_adress)
            File.WriteAllLines(My.Application.Info.DirectoryPath & OS.OS_slash & "blocklist", main_frm.blocklist)
            For Each block As ListViewItem In main_frm.userlist_viewer.Items
                If block.SubItems(1).Text = eran_adress Then
                    block.ImageIndex = 3
                End If
            Next
        Else
            main_frm.blocklist.Remove(eran_adress)
            File.WriteAllLines(My.Application.Info.DirectoryPath & OS.OS_slash & "blocklist", main_frm.blocklist)
            For Each block As ListViewItem In main_frm.userlist_viewer.Items
                If block.SubItems(1).Text = eran_adress Then
                    block.ImageIndex = 0
                End If
            Next
            main_frm.Send_to_Server("/adress " & main_frm.eran_adress & "; /to " & eran_adress & "; /get_state True; /get_profil_img 1;")
        End If
    End Function
End Class
