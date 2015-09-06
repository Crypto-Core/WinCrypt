Public Class Passstrength
    Public Function PasswordStrength(password As String, length As Integer) As Integer
        If String.IsNullOrEmpty(password) Then
            Return -1 'Kein Passwort
        End If

        'Enthalten?'
        Dim foundLowerCase As Boolean = False
        Dim foundUpperCase As Boolean = False
        Dim foundDigits As Boolean = False
        Dim foundOther As Boolean = False

        For Each c As Char In password 'Alle Zeihen durchgehen und auf Sonderzeichen etc. abprüfen'
            Select Case c
                Case "a"c To "z"c 'Kleinbuchstaben'
                    foundLowerCase = True
                Case "A"c To "Z"c 'Großbuchstaben'
                    foundUpperCase = True
                Case "0"c To "9"c 'Zahlen'
                    foundDigits = True
                Case Else 'Sonstige'
                    foundOther = True
            End Select
        Next

        Dim level As Integer = 0 'Um so höher desto sicherer'
        If foundLowerCase Then
            level += 1
        End If
        If foundUpperCase Then
            level += 1
        End If
        If foundDigits Then
            level += 1
        End If
        If foundOther Then
            level += 1
        End If
        If length > 8 Then 'Länge abprüfen'
            level += 1
        End If
        Return level - 1

    End Function
End Class
