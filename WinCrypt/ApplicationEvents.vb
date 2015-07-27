Option Strict On

Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) _
            Handles Me.StartupNextInstance
            If startwindow.WindowState = FormWindowState.Minimized Then
                If startwindow.systemtray.Visible = True Then
                    startwindow.systemtray.Visible = False
                    startwindow.Show()
                    startwindow.WindowState = FormWindowState.Normal
                End If
            End If
            Try
                Dim Pfad_des_gelinkten_Objects As String = e.CommandLine.Item(0).ToString
                Try
                    If Pfad_des_gelinkten_Objects.Remove(0, Pfad_des_gelinkten_Objects.LastIndexOf(".")) = ".wc" Then
                        filedecrypt.Show()
                        filedecrypt.filetxt.Text = Pfad_des_gelinkten_Objects.ToString
                        filedecrypt.pathtxt.Text = Pfad_des_gelinkten_Objects.Replace(".wc", "")
                        filedecrypt.pathtxt.Enabled = True
                        filedecrypt.passwordtxt.Enabled = True
                        filedecrypt.savefile.Enabled = True
                        If startwindow.iniread = "true" Then
                            filedecrypt.decrypt.Enabled = True
                        End If
                    End If
                    If Pfad_des_gelinkten_Objects.Remove(0, Pfad_des_gelinkten_Objects.LastIndexOf(".")) = ".wcp" Then
                        startwindow.decrypt_filepath.Text = Pfad_des_gelinkten_Objects.ToString
                        If startwindow.iniread = "true" Then
                            startwindow.mount.Enabled = True
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Der Dateiname darf keine leerzeichen enthalten", MsgBoxStyle.Exclamation)
                End Try
            Catch ex As Exception
            End Try
        End Sub
    End Class
End Namespace