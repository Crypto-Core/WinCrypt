Option Strict On
Public Class newpwmgrdatabase
    Dim aes As New AES
    Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
    'test
    Private Sub createdb_bt_Click(sender As Object, e As EventArgs) Handles createdb_bt.Click
        If password_txt.Text.Length < 8 Then
            If startwindow.langname = "English" Then
                MsgBox("The password must consist of at least 8 characters!", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Das Passwort muss mindestens aus 8 Zeichen bestehen!", MsgBoxStyle.Exclamation)
            End If
        Else
            Dim newentry As String = "[1]" & vbCrLf & "user=" & vbCrLf & "password=" & vbCrLf & "source=" & vbCrLf & "comment=" & vbCrLf & "index=|"
            My.Computer.FileSystem.WriteAllText(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", CStr(aes.AESEncrypt(newentry, password_txt.Text, startwindow.biosid)), False)
            passwordmanager.mgrpass = password_txt.Text
            If startwindow.langname = "English" Then
                MsgBox("Database has been successfully created!", MsgBoxStyle.Information)
            Else
                MsgBox("Datenbank wurde erfolgreich angelegt!", MsgBoxStyle.Information)
            End If
            Dim textdecrypt As String
            textdecrypt = aes.AESDecrypt(My.Computer.FileSystem.ReadAllText(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini"), password_txt.Text, startwindow.biosid)
            My.Computer.FileSystem.WriteAllText(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\pwmanager.ini", textdecrypt, False)
            passwordmanager.ListView1.Items.Clear()
            For Each go As String In passwordmanager.schleife.ToString
                Do
                    passwordmanager.schleife += 1
                    If passwordmanager.ini.WertLesen(Str(passwordmanager.schleife), "index") = "" Then
                        passwordmanager.schleife = 0
                        Exit Do
                    Else
                        If passwordmanager.ini.WertLesen(Str(passwordmanager.schleife), "index") = "|" Then
                        Else
                            With passwordmanager.ListView1.Items.Add(passwordmanager.ini.WertLesen(CStr(passwordmanager.schleife), "user"))
                                .SubItems.Add(passwordmanager.ini.WertLesen(CStr(passwordmanager.schleife), "source"))
                                .SubItems.Add(passwordmanager.ini.WertLesen(CStr(passwordmanager.schleife), "index"))
                            End With
                        End If
                    End If
                Loop
                Me.Close()
                Return
            Next go
        End If
    End Sub
End Class