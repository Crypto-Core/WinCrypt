Imports System.Management
Imports System.IO

Public Class devices

    Public Shared Function GetDevicesSerial() As List(Of String)
        Dim lst As New List(Of String)
        Try
            Dim MS As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_diskdrive where interfacetype = 'USB'")
            For Each MO As ManagementObject In MS.Get
                For Each Data As PropertyData In MO.Properties
                    If Data.Name = "PNPDeviceID" Then
                        lst.Add(MO.GetPropertyValue("SerialNumber"))

                    End If
                Next
            Next
            Return lst
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Function GetDevicesName() As List(Of String)
        Dim lst As New List(Of String)
        Try
            Dim MS As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_diskdrive where interfacetype = 'USB'")
            For Each MO As ManagementObject In MS.Get
                For Each Data As PropertyData In MO.Properties
                    If Data.Name = "PNPDeviceID" Then
                        lst.Add(MO.GetPropertyValue("Caption"))

                    End If
                Next
            Next
            Return lst
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Shared Function isDriveEmbed(ByVal driveSerial As String) As Boolean
        Try
            Dim MS As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_diskdrive where interfacetype = 'USB'")
            For Each MO As ManagementObject In MS.Get
                For Each Data As PropertyData In MO.Properties
                    If Data.Name = "PNPDeviceID" Then
                        If MO.GetPropertyValue("SerialNumber") = driveSerial Then
                            Return True
                            End
                        End If

                    End If
                Next
            Next
            Return False
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Shared Function DriveLetter() As List(Of String)
        Dim list As New List(Of String)
        For Each getDrive In DriveInfo.GetDrives
            If getDrive.DriveType = DriveType.Removable Then
                list.Add(getDrive.Name)
            End If

        Next
        Return list
    End Function
    Public Shared Function DriveSize() As List(Of String)
        Dim list As New List(Of String)
        For Each getDrive In DriveInfo.GetDrives
            If getDrive.DriveType = DriveType.Removable Then
                On Error Resume Next
                list.Add(getDrive.TotalSize)
            End If

        Next
        Return list
    End Function
End Class
