Option Strict On

Imports System.IO

Public Class INIDatei
    Public Pfad As String

    Sub New(Pfad_der_ini As String)
        Pfad = Pfad_der_ini
    End Sub

    Private Declare Ansi Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA"(
                                                                                                          lpApplicationName _
                                                                                                             As String,
                                                                                                          lpSchlüsselName _
                                                                                                             As String,
                                                                                                          lpDefault As _
                                                                                                             String,
                                                                                                          lpReturnedString _
                                                                                                             As String,
                                                                                                          nSize As _
                                                                                                             Integer,
                                                                                                          lpFileName As _
                                                                                                             String) _
        As Integer

    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA"(
                                                                                                              lpApplicationName _
                                                                                                                 As _
                                                                                                                 String,
                                                                                                              lpKeyName _
                                                                                                                 As _
                                                                                                                 String,
                                                                                                              lpString _
                                                                                                                 As _
                                                                                                                 String,
                                                                                                              lpFileName _
                                                                                                                 As _
                                                                                                                 String) _
        As Integer

    Private Declare Ansi Function DeletePrivateProfileSection Lib "kernel32" Alias "WritePrivateProfileStringA"(
                                                                                                                Section _
                                                                                                                   As _
                                                                                                                   String,
                                                                                                                NoKey As _
                                                                                                                   Integer,
                                                                                                                NoSetting _
                                                                                                                   As _
                                                                                                                   Integer,
                                                                                                                FileName _
                                                                                                                   As _
                                                                                                                   String) _
        As Integer


    Public Function WertLesen(Sektion As String, Schlüssel As String, Optional ByVal Standardwert As String = "",
                              Optional ByVal BufferSize As Integer = 1024) As String
        Try
            If Pfad = "" Then
                MsgBox("Es ist kein Pfad zur INI angegeben. Deshalb ist das Auslesen des Wertes nicht möglich." _
                       & vbCrLf & vbCrLf & "Angeforderte Sektion: " & Sektion & vbCrLf & "Angeforderter Schlüssel: " _
                       & Schlüssel, MsgBoxStyle.Exclamation, "Pfad zur INI-Datei fehlt")
                WertLesen = "Lesefehler"
                Exit Function
            End If


            If File.Exists(Pfad) = False Then
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

    Public Sub WertSchreiben(Sektion As String, Schlüssel As String, Wert As String)
        Try
            If Not (File.Exists(Pfad)) Then
                MsgBox("Die Datei " & vbCrLf & Pfad & vbCrLf & "existiert nicht und wird neu angelegt")
            End If
            Dim Filetest = CShort(FreeFile())
            FileOpen(Filetest, Pfad, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.LockReadWrite)
            FileClose(Filetest)
            If Pfad = "" Then
                MsgBox("Es ist kein Pfad zur INI angegeben. Deshalb ist das Schreiben des Wertes nicht möglich." _
                       & vbCrLf & vbCrLf & "Angeforderte Sektion: " & Sektion & vbCrLf & "Zu schreibender Schlüssel: " _
                       & Schlüssel, MsgBoxStyle.Exclamation, "Pfad zur INI-Datei fehlt")
                Exit Sub
            End If
            Dim Ordner As String
            Ordner = Path.GetDirectoryName(Pfad)
            If Directory.Exists(Ordner) = False Then
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

    Public Sub SchlüsselLöschen(Sektion As String, Schlüssel As String)
        Try
            If Pfad = "" Then
                MsgBox("Es ist kein Pfad zur INI angegeben. Deshalb ist das Löschen des Schlüssels nicht möglich." _
                       & vbCrLf & vbCrLf & "Angeforderte Sektion: " & Sektion & vbCrLf & "Zu löschender Schlüssel: " _
                       & Schlüssel, MsgBoxStyle.Exclamation, "Pfad zur INI-Datei fehlt")
                Exit Sub
            End If
            Dim Ordner As String
            Ordner = Path.GetDirectoryName(Pfad)
            If Directory.Exists(Ordner) = False Then
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

    Public Sub SektionLöschen(Sektion As String)
        Try
            If Pfad = "" Then
                MsgBox("Es ist kein Pfad zur INI angegeben. Deshalb ist das Löschen der Sektion nicht möglich." _
                       & vbCrLf & vbCrLf & "Angeforderte Sektion: " & Sektion, MsgBoxStyle.Exclamation,
                       "Pfad zur INI-Datei fehlt")
                Exit Sub
            End If
            If File.Exists(Pfad) = False Then
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

    Public Sub BackupAnlegen(Zielpfad As String, Optional ByVal FehlermeldungAnzeigen As Boolean = False)
        Try
            If Pfad = "" Then
                If FehlermeldungAnzeigen = True Then
                    MsgBox("Es ist kein Pfad zur INI, von der ein Backup angelegt werden soll, angegeben." _
                           & "Das Backup konnte NICHT angelegt werden.", MsgBoxStyle.Exclamation,
                           "Pfad zur INI-Datei fehlt")
                End If
                Exit Sub
            End If
            Dim Ordner As String
            Ordner = Path.GetDirectoryName(Pfad)
            If Directory.Exists(Ordner) = False Then
                If FehlermeldungAnzeigen = True Then
                    MsgBox(Zielpfad & vbCrLf & vbCrLf & "Dieser Ordner existiert nicht." _
                           & vbCrLf & vbCrLf & "Das Backup konnte NICHT angelegt werden.", MsgBoxStyle.Exclamation,
                           "Zielordner existiert nicht")
                End If
                Exit Sub
            End If
            File.Copy(Pfad, Zielpfad)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub DateiLöschen(Optional ByVal FehlermeldungAnzeigen As Boolean = False)
        If Pfad = "" Then
            If FehlermeldungAnzeigen = True Then
                MsgBox("Es ist kein Pfad zur INI, die gelöscht werden soll, angegeben." _
                       & "Das Löschen konnte NICHT durchgeführt werden.", MsgBoxStyle.Exclamation,
                       "Pfad zur INI-Datei fehlt")
            End If
            Exit Sub
        End If
        Try
            If File.Exists(Pfad) = False Then
                If FehlermeldungAnzeigen = True Then
                    MsgBox(Pfad & vbCrLf & vbCrLf & "Diese Datei existiert bereits nicht mehr. " _
                           & "Das Löschen hat sich damit erübrigt.", MsgBoxStyle.Exclamation,
                           "Datei existiert nicht mehr")
                End If
                Exit Sub
            End If
            File.Delete(Pfad)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
