Option Strict On
Public Class INIDatei

    Public Pfad As String

    Sub New(ByVal Pfad_der_ini As String)
        Pfad = Pfad_der_ini
    End Sub

    Private Declare Ansi Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" ( _
        ByVal lpApplicationName As String, ByVal lpSchlüsselName As String, ByVal lpDefault As String, _
        ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" ( _
        ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, _
        ByVal lpFileName As String) As Integer

    Private Declare Ansi Function DeletePrivateProfileSection Lib "kernel32" Alias "WritePrivateProfileStringA" ( _
        ByVal Section As String, ByVal NoKey As Integer, ByVal NoSetting As Integer, _
        ByVal FileName As String) As Integer



    Public Function WertLesen(ByVal Sektion As String, ByVal Schlüssel As String, Optional ByVal Standardwert As String = "", Optional ByVal BufferSize As Integer = 1024) As String
        Try
            If Pfad = "" Then
                MsgBox("Es ist kein Pfad zur INI angegeben. Deshalb ist das Auslesen des Wertes nicht möglich." _
                    & vbCrLf & vbCrLf & "Angeforderte Sektion: " & Sektion & vbCrLf & "Angeforderter Schlüssel: " _
                    & Schlüssel, MsgBoxStyle.Exclamation, "Pfad zur INI-Datei fehlt")
                WertLesen = "Lesefehler"
                Exit Function
            End If


            If IO.File.Exists(Pfad) = False Then
                MsgBox("Die angegebene INI-Datei exstiert auf diesem Rechner nicht. Deshalb ist das " _
                    & "Auslesen des Wertes nicht möglich." & vbCrLf & vbCrLf & "INI-Datei: " & Pfad _
                    & vbCrLf & "Angeforderte Sektion: " & Sektion & vbCrLf & "Angeforderter Schlüssel: " _
                    & Schlüssel, MsgBoxStyle.Exclamation, "Pfad zur INI-Datei fehlt")
                WertLesen = "Lesefehler"
                Exit Function
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        Dim sTemp As String = Space(BufferSize)
        Dim Length As Integer = GetPrivateProfileString(Sektion, Schlüssel, Standardwert, sTemp, BufferSize, Pfad)

        Return Left(sTemp, Length)

    End Function

    Public Sub WertSchreiben(ByVal Sektion As String, ByVal Schlüssel As String, ByVal Wert As String)
        Try
            If Not (System.IO.File.Exists(Pfad)) Then
                MsgBox("Die Datei " & vbCrLf & Pfad & vbCrLf & "existiert nicht und wird neu angelegt")
            End If
            Dim Filetest As Short = CShort(FreeFile())
            FileOpen(Filetest, Pfad, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.LockReadWrite)
            FileClose(Filetest)
            If Pfad = "" Then
                MsgBox("Es ist kein Pfad zur INI angegeben. Deshalb ist das Schreiben des Wertes nicht möglich." _
                    & vbCrLf & vbCrLf & "Angeforderte Sektion: " & Sektion & vbCrLf & "Zu schreibender Schlüssel: " _
                    & Schlüssel, MsgBoxStyle.Exclamation, "Pfad zur INI-Datei fehlt")
                Exit Sub
            End If
            Dim Ordner As String
            Ordner = IO.Path.GetDirectoryName(Pfad)
            If IO.Directory.Exists(Ordner) = False Then
                MsgBox("Die angegebene Ordner für die INI-Datei exstiert auf diesem Rechner nicht. Deshalb ist das " _
                    & "Schreiben des Wertes nicht möglich." & vbCrLf & vbCrLf & "Fehlender Ordner: " & Ordner _
                    & vbCrLf & "Angeforderte Sektion: " & Sektion & vbCrLf & "Zu schreibender Schlüssel: " _
                    & Schlüssel, MsgBoxStyle.Exclamation, "Pfad zur INI-Datei existiet nicht")
                Exit Sub
            End If
            WritePrivateProfileString(Sektion, Schlüssel, Wert, Pfad)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SchlüsselLöschen(ByVal Sektion As String, ByVal Schlüssel As String)
        Try
            If Pfad = "" Then
                MsgBox("Es ist kein Pfad zur INI angegeben. Deshalb ist das Löschen des Schlüssels nicht möglich." _
                    & vbCrLf & vbCrLf & "Angeforderte Sektion: " & Sektion & vbCrLf & "Zu löschender Schlüssel: " _
                    & Schlüssel, MsgBoxStyle.Exclamation, "Pfad zur INI-Datei fehlt")
                Exit Sub
            End If
            Dim Ordner As String
            Ordner = IO.Path.GetDirectoryName(Pfad)
            If IO.Directory.Exists(Ordner) = False Then
                MsgBox("Die angegebene Ordner für die INI-Datei exstiert auf diesem Rechner nicht. Deshalb ist das " _
                    & "Löschen des Wertes nicht möglich." & vbCrLf & vbCrLf & "Fehlender Ordner: " & Ordner _
                    & vbCrLf & "Angeforderte Sektion: " & Sektion & vbCrLf & "Zu löschender Schlüssel: " _
                    & Schlüssel, MsgBoxStyle.Exclamation, "Pfad zur INI-Datei existiert nicht")
                Exit Sub
            End If
            WritePrivateProfileString(Sektion, Schlüssel, Nothing, Pfad)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SektionLöschen(ByVal Sektion As String)
        Try
            If Pfad = "" Then
                MsgBox("Es ist kein Pfad zur INI angegeben. Deshalb ist das Löschen der Sektion nicht möglich." _
                    & vbCrLf & vbCrLf & "Angeforderte Sektion: " & Sektion, MsgBoxStyle.Exclamation, _
                    "Pfad zur INI-Datei fehlt")
                Exit Sub
            End If
            If IO.File.Exists(Pfad) = False Then
                MsgBox("Die angegebene INI-Datei exstiert auf diesem Rechner nicht. Deshalb ist das " _
                    & "Löschen der Sektion nicht möglich." & vbCrLf & vbCrLf & "INI-Datei: " & Pfad _
                    & vbCrLf & "Angeforderte Sektion: ", MsgBoxStyle.Exclamation, "Pfad zur INI-Datei fehlt")
                Exit Sub
            End If
            DeletePrivateProfileSection(Sektion, 0, 0, Pfad)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub BackupAnlegen(ByVal Zielpfad As String, Optional ByVal FehlermeldungAnzeigen As Boolean = False)
        Try
            If Pfad = "" Then
                If FehlermeldungAnzeigen = True Then
                    MsgBox("Es ist kein Pfad zur INI, von der ein Backup angelegt werden soll, angegeben." _
                        & "Das Backup konnte NICHT angelegt werden.", MsgBoxStyle.Exclamation, "Pfad zur INI-Datei fehlt")
                End If
                Exit Sub
            End If
            Dim Ordner As String
            Ordner = IO.Path.GetDirectoryName(Pfad)
            If IO.Directory.Exists(Ordner) = False Then
                If FehlermeldungAnzeigen = True Then
                    MsgBox(Zielpfad & vbCrLf & vbCrLf & "Dieser Ordner existiert nicht." _
                       & vbCrLf & vbCrLf & "Das Backup konnte NICHT angelegt werden.", MsgBoxStyle.Exclamation, _
                       "Zielordner existiert nicht")
                End If
                Exit Sub
            End If
            IO.File.Copy(Pfad, Zielpfad)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub DateiLöschen(Optional ByVal FehlermeldungAnzeigen As Boolean = False)
        If Pfad = "" Then
            If FehlermeldungAnzeigen = True Then
                MsgBox("Es ist kein Pfad zur INI, die gelöscht werden soll, angegeben." _
                    & "Das Löschen konnte NICHT durchgeführt werden.", MsgBoxStyle.Exclamation, "Pfad zur INI-Datei fehlt")
            End If
            Exit Sub
        End If
        Try
            If IO.File.Exists(Pfad) = False Then
                If FehlermeldungAnzeigen = True Then
                    MsgBox(Pfad & vbCrLf & vbCrLf & "Diese Datei existiert bereits nicht mehr. " _
                        & "Das Löschen hat sich damit erübrigt.", MsgBoxStyle.Exclamation, _
                       "Datei existiert nicht mehr")
                End If
                Exit Sub
            End If
            IO.File.Delete(Pfad)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
