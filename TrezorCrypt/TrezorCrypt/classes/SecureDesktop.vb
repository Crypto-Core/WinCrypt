Imports System.Runtime.InteropServices
Imports System.Threading.Tasks
Imports Microsoft.Win32

Module SecureDesktop
    Public isOnSecureDesktop As Boolean = False
    <DllImport("user32.dll")> _
    Public Function CreateDesktop(ByVal lpszDesktop As String, ByVal lpszDevice As IntPtr, ByVal pDevmode As IntPtr, ByVal dwFlags As Integer, ByVal dwDesiredAccess As UInteger, ByVal lpsa As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll")> _
    Private Function SwitchDesktop(ByVal hDesktop As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll")> _
    Public Function CloseDesktop(ByVal handle As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll")> _
    Public Function SetThreadDesktop(ByVal hDesktop As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll")> _
    Public Function GetThreadDesktop(ByVal dwThreadId As Integer) As IntPtr
    End Function

    <DllImport("kernel32.dll")> _
    Public Function GetCurrentThreadId() As Integer
    End Function

    Private Enum DESKTOP_ACCESS As UInteger
        DESKTOP_NONE = 0
        DESKTOP_READOBJECTS = &H1
        DESKTOP_CREATEWINDOW = &H2
        DESKTOP_CREATEMENU = &H4
        DESKTOP_HOOKCONTROL = &H8
        DESKTOP_JOURNALRECORD = &H10
        DESKTOP_JOURNALPLAYBACK = &H20
        DESKTOP_ENUMERATE = &H40
        DESKTOP_WRITEOBJECTS = &H80
        DESKTOP_SWITCHDESKTOP = &H100

        GENERIC_ALL = (DESKTOP_READOBJECTS Or DESKTOP_CREATEWINDOW Or DESKTOP_CREATEMENU Or DESKTOP_HOOKCONTROL Or DESKTOP_JOURNALRECORD Or DESKTOP_JOURNALPLAYBACK Or DESKTOP_ENUMERATE Or DESKTOP_WRITEOBJECTS Or DESKTOP_SWITCHDESKTOP)
    End Enum
    Friend desktopname As String = rndPass.RandomDesktopName(8)
    Friend Function StartSecureWindow(ByVal frm As Form)
        ' old desktop's handle, obtained by getting the current desktop assigned for this thread
        Dim hOldDesktop As IntPtr = GetThreadDesktop(GetCurrentThreadId())

        ' new desktop's handle, assigned automatically by CreateDesktop
        Dim hNewDesktop As IntPtr = CreateDesktop(desktopname, IntPtr.Zero, IntPtr.Zero, 0, CUInt(DESKTOP_ACCESS.GENERIC_ALL), IntPtr.Zero)


        ' switching to the new desktop
        SwitchDesktop(hNewDesktop)


        ' Random login form: used for testing / not required
        Dim passwd As String = ""

        ' running on a different thread, this way SetThreadDesktop won't fail
        ' assigning the new desktop to this thread - so the Form will be shown in the new desktop)



        Task.Factory.StartNew(Function()
                                  SetThreadDesktop(hNewDesktop)

                                  AddHandler frm.FormClosed, Function(sender, e)

                                                                 SwitchDesktop(hOldDesktop)
                                                                 CloseDesktop(hNewDesktop)

                                                             End Function

                                  AddHandler frm.FormClosing, Function(sender, e)



                                                              End Function

                                  frm.ShowDialog()
                                  frm.TopMost = True
                                  frm.BringToFront()
                              End Function).Wait()

        ' waits for the task to finish
        ' end of login form

        ' if got here, the form is closed => switch back to the old desktop
        'SwitchDesktop(hOldDesktop)

        ' disposing the secure desktop since it's no longer needed
        'CloseDesktop(hNewDesktop)
        If enterpwd.isDecrypt = False Then
            main_frm.checkList.Enabled = True
        Else
            CryptMain.serial_lb.Text = enterpwd.serial
            CryptMain.device_lb.Text = enterpwd.Letter
            CryptMain.product_lb.Text = enterpwd.USBName
            CryptMain.Text = "TrezorCrypt - " & enterpwd.USBName
            CryptMain.ShowDialog()
        End If

    End Function

End Module

