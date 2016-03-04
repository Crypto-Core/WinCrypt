Imports Microsoft.Win32
Imports System.IO

Public Class StartWindow
    Private ini As New IniFile
    Friend Shared config_path As String = My.Application.Info.DirectoryPath & "\config.ini"
    Private Sub join_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles secureDesktop_bt.Click

        If save_selection_cb.Checked = True Then
            ini.Load(config_path)
            ini.SetKeyValue("config", "startmodus", 2)
            ini.Save(config_path)
        Else

        End If
        SecureDesktop.isOnSecureDesktop = True
        SecureDesktop.StartSecureWindow(main_frm)
    End Sub

    Private Sub startNormal_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startNormal_bt.Click

        If save_selection_cb.Checked = True Then
            ini.Load(config_path)
            ini.SetKeyValue("config", "startmodus", 1)
            ini.Save(config_path)
        Else

        End If
        SecureDesktop.isOnSecureDesktop = False
        Me.Hide()
        main_frm.ShowDialog()
    End Sub

    Private Sub StartWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        config.load()
        If File.Exists(config_path) = True Then
            ini.Load(config_path)

            Dim startmodus As String = ini.GetKeyValue("config", "startmodus")
            Select Case startmodus
                Case 0

                Case 1
                    SecureDesktop.isOnSecureDesktop = False
                    Me.Hide()
                    main_frm.ShowDialog()
                Case 2
                    SecureDesktop.isOnSecureDesktop = True
                    SecureDesktop.StartSecureWindow(main_frm)
            End Select
        Else
            My.Computer.FileSystem.WriteAllText(config_path, "[config]" & vbNewLine & "startmodus=0", False)
            ini.Load(config_path)
            Dim startmodus As String = ini.GetKeyValue("config", "startmodus")
            Select Case startmodus
                Case 0

                Case 1

                Case 2

            End Select
        End If

        
    End Sub
End Class