
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
    Friend Function StartSecureWindow(ByVal frm As Form) As Object
        Dim hOldDesktop As IntPtr = GetThreadDesktop(GetCurrentThreadId())
        Dim hNewDesktop As IntPtr = CreateDesktop(desktopname, IntPtr.Zero, IntPtr.Zero, 0, CUInt(DESKTOP_ACCESS.GENERIC_ALL), IntPtr.Zero)
        SwitchDesktop(hNewDesktop)
        Dim passwd As String = ""
        Task.Factory.StartNew(Function() As Object
                                  SetThreadDesktop(hNewDesktop)
                                  language.load()
                                  main_frm.CopyEranAddressToolStripMenuItem.Enabled = False
                                  AddHandler main_frm.FormClosed, Function(sender, e) As Object


                                                                  End Function

                                  AddHandler main_frm.FormClosing, Function(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) As Object
                                                                       Dim SecureDesktopMSGClose As String
                                                                       Dim SecureDesktopTitleClose As String

                                                                       If MessageBox.Show(language.ini.GetKeyValue("SecureDesktop", "SecureDesktopMSGClose"), language.ini.GetKeyValue("SecureDesktop", "SecureDesktopTitleClose"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                                                           SwitchDesktop(hOldDesktop)
                                                                           CloseDesktop(hNewDesktop)
                                                                           Process.GetCurrentProcess.Kill()
                                                                       Else

                                                                       End If
                                                                   End Function
                                  backgroundSecure.Show()
                                  main_frm.ShowDialog()
                                  main_frm.TopMost = True
                                  main_frm.BringToFront()
                              End Function).Wait()
        SwitchDesktop(hOldDesktop)
        CloseDesktop(hNewDesktop)
    End Function
End Module