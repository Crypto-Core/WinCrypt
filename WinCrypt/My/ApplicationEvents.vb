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
                Dim pfadDesGelinktenObjects As String = e.CommandLine.Item(0).ToString

                Try
                    If pfadDesGelinktenObjects.Remove(0, pfadDesGelinktenObjects.LastIndexOf(".", StringComparison.Ordinal)) = ".wc" Then
                        tools.data_encryption.Filedecrypt.Show()
                        tools.data_encryption.Filedecrypt.filetxt.Text = pfadDesGelinktenObjects.ToString
                        tools.data_encryption.Filedecrypt.pathtxt.Text = pfadDesGelinktenObjects.Replace(".wc", Nothing)
                        tools.data_encryption.Filedecrypt.pathtxt.Enabled = True
                        tools.data_encryption.Filedecrypt.passwordtxt.Enabled = True
                        tools.data_encryption.Filedecrypt.savefile.Enabled = True
                        If Startwindow.Iniread = "true" Then
                            tools.data_encryption.Filedecrypt.decrypt.Enabled = True
                        End If
                    End If
                    If pfadDesGelinktenObjects.Remove(0, pfadDesGelinktenObjects.LastIndexOf(".", StringComparison.Ordinal)) = ".wcp" Then
                        Startwindow.decrypt_filepath.Text = pfadDesGelinktenObjects.ToString
                        If Startwindow.Iniread = "true" Then
                            Startwindow.mount.Enabled = True
                        End If
                    End If
                Catch ex As Exception

                End Try
            Catch ex As Exception
            End Try
        End Sub
    End Class
End Namespace