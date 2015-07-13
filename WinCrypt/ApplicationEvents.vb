Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            Try
                Dim Pfad_des_gelinkten_Objects As String = e.CommandLine.Item(0).ToString
                Try
                    If Pfad_des_gelinkten_Objects.Remove(0, Pfad_des_gelinkten_Objects.LastIndexOf(".")) = ".wc" Then
                        filedecrypt.Show()
                        filedecrypt.filetxt.Text = Pfad_des_gelinkten_Objects.ToString
                        filedecrypt.pathtxt.Text = Pfad_des_gelinkten_Objects.Replace(".wc", "")
                        'DateiEntschluesseln.TextBox2.Text = mypath.Substring(0, mypath.LastIndexOf("\"))
                        filedecrypt.pathtxt.Enabled = True
                        filedecrypt.passwordtxt.Enabled = True
                        filedecrypt.savefile.Enabled = True
                        If startwindow.iniread = "true" Then
                            filedecrypt.dencrypt.Enabled = True
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