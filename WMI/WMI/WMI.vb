Imports System.Management
Imports Microsoft.VisualBasic.Devices
Public Class WMI
    Public Class Win32_Account
        ''' <summary>
        ''' Short description of the object. This property is inherited from the CIM_ManagedSystemElement class.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Caption() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Caption = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_Account")
            For Each objItem In objItems
                Caption = objItem.Caption
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Description of the object. This property is inherited from the CIM_ManagedSystemElement class.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Description() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Description = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_Account")
            For Each objItem In objItems
                Description = objItem.Description
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Name of the Windows domain to which a group or user belongs.
        '''Example: "NA-SALES"
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Domain() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Domain = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_Account")
            For Each objItem In objItems
                Domain = objItem.Domain
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Date and time that the object was installed. This property does not require a value to indicate that the object is installed. This property is inherited from the CIM_ManagedSystemElement class.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function InstallDate() As DateTime
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            InstallDate = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_Account")
            For Each objItem In objItems
                Dim str As String = objItem.InstallDate
                InstallDate = New DateTime(str.Substring(0, 4), str.Substring(4, 2), str.Substring(6, 2), str.Substring(8, 2), str.Substring(10, 2), str.Substring(12, 2))
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' If TRUE, the account is defined on the local machine. To retrieve only accounts defined on the local machine, design a query that includes the condition "LocalAccount=TRUE".
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function LocalAccount() As Boolean
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            LocalAccount = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_Account")
            For Each objItem In objItems
                LocalAccount = objItem.LocalAccount
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Name of the Windows system account on the domain specified by the Domain property of this class. This property overrides the Name property inherited from CIM_ManagedSystemElement.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Name() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Name = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_Account")
            For Each objItem In objItems
                Name = objItem.Name
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Security identifier (SID) for this account. A SID is a string value of variable length used to identify a trustee. Each account has a unique SID issued by an authority (such as a Windows domain), stored in a security database. When a user logs on, the system retrieves the user's SID from the database and places it in the user's access token. The system uses the SID in the user's access token to identify the user in all subsequent interactions with Windows security. When a SID has been used as the unique identifier for a user or group, it cannot be used again to identify another user or group.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function SID() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            SID = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_Account")
            For Each objItem In objItems
                SID = objItem.SID
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Enumerated values that specify the type of security identifier (SID).
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function SIDType() As SByte
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            SIDType = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_Account")
            For Each objItem In objItems
                SIDType = objItem.SIDType
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Current status of the object. Various operational and nonoperational statuses can be defined. Operational statuses include: "OK", "Degraded", and "Pred Fail" (an element, such as a SMART-enabled hard disk drive, may be functioning properly but predicts a failure in the near future). Nonoperational statuses include: "Error", "Starting", "Stopping", and "Service". The latter, "Service", can apply during mirror-resilvering of a disk, reload of a user permissions list, or other administrative work. Not all such work is online, yet the managed element is neither "OK" nor in one of the other states.
        '''This property is inherited from the CIM_ManagedSystemElement class.
        '''The values are:
        '''"OK"
        '''"Error"
        '''"Degraded"
        '''"Unknown"
        '''"Pred Fail"
        '''"Starting"
        '''"Stopping"
        '''"Service"
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Status() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Status = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_Account")
            For Each objItem In objItems
                Status = objItem.Status
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
    End Class
    Public Class Win32_OperatingSystem
        ''' <summary>
        ''' Short description of the object—a one-line string. The string includes the operating system version. For example, "Microsoft Windows 7 Enterprise ". This property can be localized.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Caption() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Caption = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                Caption = objItem.Caption
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Name of the disk drive from which the Windows operating system starts.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function BootDevice() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            BootDevice = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                BootDevice = objItem.BootDevice
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Build number of an operating system. It can be used for more precise version information than product release version numbers.
        '''Example: "1381"
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function BuildNumber() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            BuildNumber = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                BuildNumber = objItem.BuildNumber
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Type of build used for an operating system.
        '''Examples: ""retail build"", ""checked build""
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function BuildType() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            BuildType = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                BuildType = objItem.BuildType
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Code page value an operating system uses. A code page contains a character table that an operating system uses to translate strings for different languages. The American National Standards Institute (ANSI) lists values that represent defined code pages. If an operating system does not use an ANSI code page, this member is set to 0 (zero). The CodeSet string can use a maximum of six characters to define the code page value.
        '''Example: "1255"
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function CodeSet() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            CodeSet = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                CodeSet = objItem.CodeSet
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Code for the country/region that an operating system uses. Values are based on international phone dialing prefixes—also referred to as IBM country/region codes. This property can use a maximum of six characters to define the country/region code value.
        '''Example: "1" (United States)
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function CountryCode() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            CountryCode = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                CountryCode = objItem.CountryCode
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Name of the first concrete class that appears in the inheritance chain used in the creation of an instance. When used with other key properties of the class, this property allows all instances of this class and its subclasses to be identified uniquely.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function CreationClassName() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            CreationClassName = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                CreationClassName = objItem.CreationClassName
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Creation class name of the scoping computer system.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function CSCreationClassName() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            CSCreationClassName = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                CSCreationClassName = objItem.CSCreationClassName
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' NULL-terminated string that indicates the latest service pack installed on a computer. If no service pack is installed, the string is NULL.
        '''Example: "Service Pack 3"
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function CSDVersion() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            CSDVersion = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                CSDVersion = objItem.CSDVersion
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Name of the scoping computer system.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function CSName() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            CSName = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                CSName = objItem.CSName
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Number, in minutes, an operating system is offset from Greenwich mean time (GMT). The number is positive, negative, or zero.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function CurrentTimeZone() As Int16

            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            CurrentTimeZone = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                CurrentTimeZone = objItem.CurrentTimeZone
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Data execution prevention is a hardware feature to prevent buffer overrun attacks by stopping the execution of code on data-type memory pages. If True, then this feature is available. On 64-bit computers, the data execution prevention feature is configured in the BCD store and the properties in Win32_OperatingSystem are set accordingly.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function DataExecutionPrevention_Available() As Boolean
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            DataExecutionPrevention_Available = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                DataExecutionPrevention_Available = objItem.DataExecutionPrevention_Available
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' When the data execution prevention hardware feature is available, this property indicates that the feature is set to work for 32-bit applications if True. On 64-bit computers, the data execution prevention feature is configured in the Boot Configuration Data (BCD) store and the properties in Win32_OperatingSystem are set accordingly.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function DataExecutionPrevention_32BitApplications() As Boolean
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            DataExecutionPrevention_32BitApplications = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                DataExecutionPrevention_32BitApplications = objItem.DataExecutionPrevention_32BitApplications
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' When the data execution prevention hardware feature is available, this property indicates that the feature is set to work for drivers if True. On 64-bit computers, the data execution prevention feature is configured in the BCD store and the properties in Win32_OperatingSystem are set accordingly.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function DataExecutionPrevention_Drivers() As Boolean
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            DataExecutionPrevention_Drivers = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                DataExecutionPrevention_Drivers = objItem.DataExecutionPrevention_Drivers
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Indicates which Data Execution Prevention (DEP) setting is applied. The DEP setting specifies the extent to which DEP applies to 32-bit applications on the system. DEP is always applied to the Windows kernel.
        ''' 0 = Always Off(DEP is turned off for all 32-bit applications on the computer with no exceptions. This setting is not available for the user interface.)
        ''' 1 = Always On(DEP is enabled for all 32-bit applications on the computer. This setting is not available for the user interface.)
        ''' 2 = Opt In(DEP is enabled for a limited number of binaries, the kernel, and all Windows-based services. However, it is off by default for all 32-bit applications. A user or administrator must explicitly choose either the AlwaysOn or the OptOut setting before DEP can be applied to 32-bit applications.)
        ''' 3 = Opt Out(DEP is enabled by default for all 32-bit applications. A user or administrator can explicitly remove support for a 32-bit application by adding the application to an exceptions list.)
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function DataExecutionPrevention_SupportPolicy() As SByte
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            DataExecutionPrevention_SupportPolicy = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                DataExecutionPrevention_SupportPolicy = objItem.DataExecutionPrevention_SupportPolicy
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Operating system is a checked (debug) build. If True, the debugging version is installed. Checked builds provide error checking, argument verification, and system debugging code. Additional code in a checked binary generates a kernel debugger error message and breaks into the debugger. This helps immediately determine the cause and location of the error. Performance may be affected in a checked build due to the additional code that is executed.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Debug() As Boolean
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Debug = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                Debug = objItem.Debug
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Description of the Windows operating system. Some user interfaces for example, those that allow editing of this description, limit its length to 48 characters.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Description() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Description = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                Description = objItem.Description
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' If True, the operating system is distributed across several computer system nodes. If so, these nodes should be grouped as a cluster.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Distributed() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Distributed = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                Distributed = objItem.Distributed
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Encryption level for secure transactions: 40-bit, 128-bit, or n-bit.
        '''40-bit (0)
        '''128-bit (1)
        '''n-bit (2)
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function EncryptionLevel() As UInt32
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            EncryptionLevel = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                EncryptionLevel = objItem.EncryptionLevel
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Increase in priority is given to the foreground application. Application boost is implemented by giving an application more execution time slices (quantum lengths).
        ''' 0 = None (The system boosts the quantum length by 6.)
        ''' 1 = Minimum (The system boosts the quantum length by 12.)
        ''' 2 = Maximum (The system boosts the quantum length by 18.)
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function ForegroundApplicationBoost() As SByte
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            ForegroundApplicationBoost = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                ForegroundApplicationBoost = objItem.ForegroundApplicationBoost
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Number, in kilobytes, of physical memory currently unused and available.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function FreePhysicalMemory() As UInt64
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            FreePhysicalMemory = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                FreePhysicalMemory = objItem.FreePhysicalMemory
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Number, in kilobytes, that can be mapped into the operating system paging files without causing any other pages to be swapped out.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function FreeSpaceInPagingFiles() As UInt64
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            FreeSpaceInPagingFiles = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                FreeSpaceInPagingFiles = objItem.FreeSpaceInPagingFiles
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Number, in kilobytes, of virtual memory currently unused and available.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function FreeVirtualMemory() As UInt64
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            FreeVirtualMemory = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                FreeVirtualMemory = objItem.FreeVirtualMemory
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Date object was installed. This property does not require a value to indicate that the object is installed.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function InstallDate() As DateTime

            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            InstallDate = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                Dim str As String = objItem.InstallDate
                InstallDate = New DateTime(str.Substring(0, 4), str.Substring(4, 2), str.Substring(6, 2), str.Substring(8, 2), str.Substring(10, 2), str.Substring(12, 2))
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' his property is obsolete and not supported.
        ''' 0 = Optimize for Applications
        ''' 1 = Optimize for System Performance
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function LargeSystemCache() As UInt32
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            LargeSystemCache = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                LargeSystemCache = objItem.LargeSystemCache
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Date and time the operating system was last restarted.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function LastBootUpTime() As DateTime
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            LastBootUpTime = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                Dim str As String = objItem.LastBootUpTime
                LastBootUpTime = New DateTime(str.Substring(0, 4), str.Substring(4, 2), str.Substring(6, 2), str.Substring(8, 2), str.Substring(10, 2), str.Substring(12, 2))
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Operating system version of the local date and time-of-day.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function LocalDateTime() As DateTime
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            LocalDateTime = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                Dim str As String = objItem.LocalDateTime
                LocalDateTime = New DateTime(str.Substring(0, 4), str.Substring(4, 2), str.Substring(6, 2), str.Substring(8, 2), str.Substring(10, 2), str.Substring(12, 2))
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Language identifier used by the operating system. A language identifier is a standard international numeric abbreviation for a country/region. Each language has a unique language identifier (LANGID), a 16-bit value that consists of a primary language identifier and a secondary language identifier.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Locale() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Locale = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                Locale = objItem.Locale
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Name of the operating system manufacturer. For Windows-based systems, this value is "Microsoft Corporation".
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Manufacturer() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Manufacturer = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                Manufacturer = objItem.Manufacturer
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Maximum number of process contexts the operating system can support. The default value set by the provider is 4294967295 (0xFFFFFFFF). If there is no fixed maximum, the value should be 0 (zero). On systems that have a fixed maximum, this object can help diagnose failures that occur when the maximum is reached—if unknown, enter 4294967295 (0xFFFFFFFF).
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function MaxNumberOfProcesses() As UInt32
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            MaxNumberOfProcesses = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                MaxNumberOfProcesses = objItem.MaxNumberOfProcesses
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Maximum number, in kilobytes, of memory that can be allocated to a process. For operating systems with no virtual memory, typically this value is equal to the total amount of physical memory minus the memory used by the BIOS and the operating system. For some operating systems, this value may be infinity, in which case 0 (zero) should be entered. In other cases, this value could be a constant, for example, 2G or 4G.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function MaxProcessMemorySize() As UInt64
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            MaxProcessMemorySize = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                MaxProcessMemorySize = objItem.MaxProcessMemorySize
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Multilingual User Interface Pack (MUI Pack ) languages installed on the computer. For example, "en-us". MUI Pack languages are resource files that can be installed on the English version of the operating system. When an MUI Pack is installed, you can can change the user interface language to one of 33 supported languages.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function MUILanguages() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            MUILanguages = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                MUILanguages = objItem.MUILanguages
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Operating system instance within a computer system.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Name() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Name = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                Name = objItem.Name
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Number of user licenses for the operating system. If unlimited, enter 0 (zero). If unknown, enter -1.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function NumberOfLicensedUsers() As UInt32
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            NumberOfLicensedUsers = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                NumberOfLicensedUsers = objItem.NumberOfLicensedUsers
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Number of process contexts currently loaded or running on the operating system.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function NumberOfProcesses() As UInt32
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            NumberOfProcesses = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                NumberOfProcesses = objItem.NumberOfProcesses
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Number of user sessions for which the operating system is storing state information currently.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function NumberOfUsers() As UInt32
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            NumberOfUsers = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                NumberOfUsers = objItem.NumberOfUsers
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        Friend Shared Function OperatingSystemSKU() As UInt32
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            OperatingSystemSKU = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                OperatingSystemSKU = objItem.OperatingSystemSKU
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Company name for the registered user of the operating system.
        ''' Example: "Microsoft Corporation"
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Organization() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Organization = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                Organization = objItem.Organization
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Architecture of the operating system, as opposed to the processor. This property can be localized.
        ''' Example: 32-bit
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function OSArchitecture() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            OSArchitecture = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                OSArchitecture = objItem.OSArchitecture
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Language version of the operating system installed. The following table lists the possible values. Example: 0x0807 (German, Switzerland).
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function OSLanguage() As UInt32
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            OSLanguage = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                OSLanguage = objItem.OSLanguage
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Installed and licensed system product additions to the operating system. For example, the value of 146 (0x92) for OSProductSuite indicates Enterprise, Terminal Services, and Data Center (bits one, four, and seven set). The following table lists possible values.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function OSProductSuite() As UInt32
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            OSProductSuite = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                OSProductSuite = objItem.OSProductSuite
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Type of operating system. The following list identifies the possible values.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function OSType() As UInt16
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            OSType = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                OSType = objItem.OSType
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Additional description for the current operating system version.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function OtherTypeDescription() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            OtherTypeDescription = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                OtherTypeDescription = objItem.OtherTypeDescription
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' If True, the physical address extensions (PAE) are enabled by the operating system running on Intel processors. PAE allows applications to address more than 4 GB of physical memory. When PAE is enabled, the operating system uses three-level linear address translation rather than two-level. Providing more physical memory to an application reduces the need to swap memory to the page file and increases performance. To enable, PAE, use the "/PAE" switch in the Boot.ini file. For more information about the Physical Address Extension feature, see Http://Go.Microsoft.Com/FWLink/p/?LinkID=45912.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function PAEEnabled() As Boolean
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            PAEEnabled = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                PAEEnabled = objItem.PAEEnabled
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        Friend Shared Function PlusProductID() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            PlusProductID = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                PlusProductID = objItem.PlusProductID
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        Friend Shared Function PlusVersionNumber() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            PlusVersionNumber = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                PlusVersionNumber = objItem.PlusVersionNumber
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Specifies whether the operating system booted from an external USB device. If true, the operating system has detected it is booting on a supported locally connected storage device.
        ''' Windows Server 2008 R2, Windows 7, Windows Server 2008, and Windows Vista:  This property is not supported before Windows 8 and Windows Server 2012.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function PortableOperatingSystem() As Boolean
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            PortableOperatingSystem = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                PortableOperatingSystem = objItem.PortableOperatingSystem
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Specifies whether this is the primary operating system.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Primary() As Boolean
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Primary = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                Primary = objItem.Primary
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Additional system information.
        ''' Work Station (1)
        ''' Domain Controller (2)
        ''' Server (3)
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function ProductType() As UInt32
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            ProductType = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                ProductType = objItem.ProductType
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Name of the registered user of the operating system.
        ''' Example: "Ben Smith"
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function RegisteredUser() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            RegisteredUser = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                RegisteredUser = objItem.RegisteredUser
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Operating system product serial identification number.
        ''' Example: "10497-OEM-0031416-71674"
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function SerialNumber() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            SerialNumber = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                SerialNumber = objItem.SerialNumber
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Major version number of the service pack installed on the computer system. If no service pack has been installed, the value is 0 (zero).
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function ServicePackMajorVersion() As UInt16
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            ServicePackMajorVersion = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                ServicePackMajorVersion = objItem.ServicePackMajorVersion
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Minor version number of the service pack installed on the computer system. If no service pack has been installed, the value is 0 (zero).
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function ServicePackMinorVersion() As UInt16
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            ServicePackMinorVersion = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                ServicePackMinorVersion = objItem.ServicePackMinorVersion
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Total number of kilobytes that can be stored in the operating system paging files—0 (zero) indicates that there are no paging files. Be aware that this number does not represent the actual physical size of the paging file on disk.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function SizeStoredInPagingFiles() As UInt64
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            SizeStoredInPagingFiles = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                SizeStoredInPagingFiles = objItem.SizeStoredInPagingFiles
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Current status of the object. Various operational and nonoperational statuses can be defined. Operational statuses include: "OK", "Degraded", and "Pred Fail" (an element, such as a SMART-enabled hard disk drive may function properly, but predicts a failure in the near future). Nonoperational statuses include: "Error", "Starting", "Stopping", and "Service". The Service status applies to administrative work, such as mirror-resilvering of a disk, reload of a user permissions list, or other administrative work. Not all such work is online, but the managed element is neither "OK" nor in one of the other states.
        '''"OK"
        '''"Error"
        '''"Degraded"
        '''"Unknown"
        '''"Pred Fail"
        '''"Starting"
        '''"Stopping"
        '''"Service"
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Status() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Status = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                Status = objItem.Status
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Qualifiers: BitMap ("0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10") , BitValues ("Windows Server 2003, Small Business Edition", "Windows Server 2003, Enterprise Edition", "Windows Server 2003, Backoffice Edition", "Windows Server 2003, Communications Edition", "Microsoft Terminal Services", "Windows Server 2003, Small Business Edition Restricted", "Windows XP Embedded", "Windows Server 2003, Datacenter Edition", "Single User", "Windows XP Home Edition", "Windows Server 2003, Web Edition")
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function SuiteMask() As UInt32
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            SuiteMask = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                SuiteMask = objItem.SuiteMask
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Physical disk partition on which the operating system is installed.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function SystemDevice() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            SystemDevice = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                SystemDevice = objItem.SystemDevice
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' System directory of the operating system.
        '''Example: "C:\WINDOWS\SYSTEM32"
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function SystemDirectory() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            SystemDirectory = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                SystemDirectory = objItem.SystemDirectory
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Letter of the disk drive on which the operating system resides. Example: "C:"
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function SystemDrive() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            SystemDrive = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                SystemDrive = objItem.SystemDrive
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Total swap space in kilobytes. This value may be NULL (unspecified) if the swap space is not distinguished from page files. However, some operating systems distinguish these concepts. For example, in UNIX, whole processes can be swapped out when the free page list falls and remains below a specified amount.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function TotalSwapSpaceSize() As UInt64
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            TotalSwapSpaceSize = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                TotalSwapSpaceSize = objItem.TotalSwapSpaceSize
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Number, in kilobytes, of virtual memory. For example, this may be calculated by adding the amount of total RAM to the amount of paging space, that is, adding the amount of memory in or aggregated by the computer system to the property, SizeStoredInPagingFiles.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function TotalVirtualMemorySize() As UInt64
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            TotalVirtualMemorySize = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                TotalVirtualMemorySize = objItem.TotalVirtualMemorySize
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Total amount, in kilobytes, of physical memory available to the operating system. This value does not necessarily indicate the true amount of physical memory, but what is reported to the operating system as available to it.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function TotalVisibleMemorySize() As UInt64
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            TotalVisibleMemorySize = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                TotalVisibleMemorySize = objItem.TotalVisibleMemorySize
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Version number of the operating system.
        '''Example: "4.0"
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function Version() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            Version = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                Version = objItem.Version
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' Windows directory of the operating system.
        '''Example: "C:\WINDOWS"
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function WindowsDirectory() As String
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            WindowsDirectory = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                WindowsDirectory = objItem.WindowsDirectory
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' The QuantumLength property defines the number of clock ticks per quantum. A quantum is a unit of execution time that the scheduler is allowed to give to an application before switching to other applications. When a thread runs one quantum, the kernel preempts it and moves it to the end of a queue for applications with equal priorities. The actual length of a thread's quantum varies across different Windows platforms. For Windows NT/Windows 2000 only.
        '''Unknown (0)
        '''One tick (1)
        '''Two ticks (2)
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function QuantumLength() As SByte
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            QuantumLength = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                QuantumLength = objItem.QuantumLength
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
        ''' <summary>
        ''' The QuantumType property specifies either fixed or variable length quantums. Windows defaults to variable length quantums where the foreground application has a longer quantum than the background applications. Windows Server defaults to fixed-length quantums. A quantum is a unit of execution time that the scheduler is allowed to give to an application before switching to another application. When a thread runs one quantum, the kernel preempts it and moves it to the end of a queue for applications with equal priorities. The actual length of a thread's quantum varies across different Windows platforms.
        '''The property can take the following values:
        '''0 = Unkown - Quantum Type not known.
        '''1 = Fixed - Quantum length is fixed.
        '''2 = Variable - Quantum length is variable.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function QuantumType() As SByte
            Dim objWMIService As Object
            Dim objItems As Object
            Dim objItem As Object
            Dim server As New Devices.ServerComputer
            Dim ComputerName As String = server.Name
            QuantumType = Nothing
            objWMIService = GetObject("winmgmts:\\" & ComputerName & "\root\CIMV2")
            objItems = objWMIService.ExecQuery("SELECT * FROM Win32_OperatingSystem")
            For Each objItem In objItems
                QuantumType = objItem.QuantumType
            Next
            objWMIService = Nothing
            objItems = Nothing
            objItem = Nothing
        End Function
    End Class
End Class