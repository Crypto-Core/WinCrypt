Option Strict On
Imports System.IO
Namespace classes
    Public Class IniDatei
        Public Pfad As String

        Sub New(pfadDerIni As String)
            Pfad = pfadDerIni
        End Sub

        Private Declare Ansi Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (
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

        Private Declare Ansi Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (
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

        Private Declare Ansi Function DeletePrivateProfileSection Lib "kernel32" Alias "WritePrivateProfileStringA" (
                                                                                                                    section _
                                                                                                                       As _
                                                                                                                       String,
                                                                                                                    noKey As _
                                                                                                                       Integer,
                                                                                                                    noSetting _
                                                                                                                       As _
                                                                                                                       Integer,
                                                                                                                    fileName _
                                                                                                                       As _
                                                                                                                       String) _
            As Integer
        Public Function worthreading(section As String, key As String, Optional ByVal defaultvalue As String = Nothing,
                                  Optional ByVal bufferSize As Integer = 1024) As String
            Try
                If Pfad = Nothing Then
                    MessageBox.Show("Es ist kein Pfad zur INI angegeben. Deshalb ist das Auslesen des Wertes nicht möglich." _
                           & vbCrLf & vbCrLf & "Angeforderte Sektion: " & section & vbCrLf & "Angeforderter Schlüssel: " _
                           & key, "Pfad zur INI-Datei fehlt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    worthreading = "Lesefehler"
                    Exit Function
                End If

                If File.Exists(Pfad) = False Then
                    Directory.CreateDirectory(String.Format("{0}\WinCrypt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
                    File.WriteAllText(Pfad, My.Resources.config)
                    worthreading = "Lesefehler"
                    Exit Function
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
            Dim sTemp As String = Space(bufferSize)
            Dim length As Integer = GetPrivateProfileString(section, key, defaultvalue, sTemp, bufferSize, Pfad)
            Return Left(sTemp, length)
        End Function

        Public Sub WertSchreiben(sektion As String, schluessel As String, wert As String)
            Try
                If Not (File.Exists(Pfad)) Then

                End If
                Dim filetest = CShort(FreeFile())
                FileOpen(filetest, Pfad, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.LockReadWrite)
                FileClose(filetest)
                If Pfad = Nothing Then
                    MessageBox.Show("Es ist kein Pfad zur INI angegeben. Deshalb ist das Schreiben des Wertes nicht möglich." _
                           & vbCrLf & vbCrLf & "Angeforderte Sektion: " & sektion & vbCrLf & "Zu schreibender Schlüssel: " _
                           & schluessel, "Pfad zur INI-Datei fehlt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                Dim ordner As String
                ordner = Path.GetDirectoryName(Pfad)
                If Directory.Exists(ordner) = False Then
                    MessageBox.Show("Die angegebene Ordner für die INI-Datei exstiert auf diesem Rechner nicht. Deshalb ist das " _
                           & "Schreiben des Wertes nicht möglich." & vbCrLf & vbCrLf & "Fehlender Ordner: " & ordner _
                           & vbCrLf & "Angeforderte Sektion: " & sektion & vbCrLf & "Zu schreibender Schlüssel: " _
                           & schluessel, "Pfad zur INI-Datei existiet nicht", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                WritePrivateProfileString(sektion, schluessel, Wert, Pfad)
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub SchlüsselLöschen(sektion As String, schluessel As String)
            Try
                If Pfad = Nothing Then
                    MessageBox.Show("Es ist kein Pfad zur INI angegeben. Deshalb ist das Löschen des Schlüssels nicht möglich." _
                           & vbCrLf & vbCrLf & "Angeforderte Sektion: " & sektion & vbCrLf & "Zu löschender Schlüssel: " _
                           & schluessel, "Pfad zur INI-Datei fehlt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                Dim ordner As String
                ordner = Path.GetDirectoryName(Pfad)
                If Directory.Exists(ordner) = False Then
                    MessageBox.Show("Die angegebene Ordner für die INI-Datei exstiert auf diesem Rechner nicht. Deshalb ist das " _
                           & "Löschen des Wertes nicht möglich." & vbCrLf & vbCrLf & "Fehlender Ordner: " & ordner _
                           & vbCrLf & "Angeforderte Sektion: " & sektion & vbCrLf & "Zu löschender Schlüssel: " _
                           & schluessel, "Pfad zur INI-Datei existiert nicht", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                WritePrivateProfileString(sektion, schluessel, Nothing, Pfad)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Public Sub SektionLöschen(sektion As String)
            Try
                If Pfad = Nothing Then
                    MessageBox.Show("Es ist kein Pfad zur INI angegeben. Deshalb ist das Löschen der Sektion nicht möglich." _
                           & vbCrLf & vbCrLf & "Angeforderte Sektion: " & sektion, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                If File.Exists(Pfad) = False Then
                    MessageBox.Show("Die angegebene INI-Datei exstiert auf diesem Rechner nicht. Deshalb ist das " _
                           & "Löschen der Sektion nicht möglich." & vbCrLf & vbCrLf & "INI-Datei: " & Pfad _
                           & vbCrLf & "Angeforderte Sektion: ", "Pfad zur INI-Datei fehlt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                DeletePrivateProfileSection(Sektion, 0, 0, Pfad)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Sub BackupAnlegen(zielpfad As String, Optional ByVal fehlermeldungAnzeigen As Boolean = False)
            Try
                If Pfad = Nothing Then
                    If fehlermeldungAnzeigen = True Then
                        MessageBox.Show("Es ist kein Pfad zur INI, von der ein Backup angelegt werden soll, angegeben." _
                               & "Das Backup konnte NICHT angelegt werden.", "Pfad zur INI-Datei fehlt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    Exit Sub
                End If
                Dim ordner As String
                ordner = Path.GetDirectoryName(Pfad)
                If Directory.Exists(ordner) = False Then
                    If fehlermeldungAnzeigen = True Then
                        MessageBox.Show(zielpfad & vbCrLf & vbCrLf & "Dieser Ordner existiert nicht." _
                               & vbCrLf & vbCrLf & "Das Backup konnte NICHT angelegt werden.", "Zielordner existiert nicht", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    Exit Sub
                End If
                File.Copy(Pfad, zielpfad)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Sub DateiLöschen(Optional ByVal fehlermeldungAnzeigen As Boolean = False)
            If Pfad = Nothing Then
                If fehlermeldungAnzeigen = True Then
                    MessageBox.Show("Es ist kein Pfad zur INI, die gelöscht werden soll, angegeben." _
                           & "Das Löschen konnte NICHT durchgeführt werden.", "Pfad zur INI-Datei fehlt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                Exit Sub
            End If
            Try
                If File.Exists(Pfad) = False Then
                    If fehlermeldungAnzeigen = True Then
                        MessageBox.Show(Pfad & vbCrLf & vbCrLf & "Diese Datei existiert bereits nicht mehr. " _
                               & "Das Löschen hat sich damit erübrigt.", "Datei existiert nicht mehr", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    Exit Sub
                End If
                File.Delete(Pfad)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace