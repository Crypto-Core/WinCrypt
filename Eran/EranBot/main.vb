Option Strict On
Option Explicit On

Imports System.IO
Imports System.Text
Imports System.Drawing

Module main
    Public WithEvents API As New EranAPI
    Private newtrd As New Threading.Thread(AddressOf trd)
    Private accountPath As String = My.Application.Info.DirectoryPath & OS.OS_slash & "account.ini"
    Private commandINI As New IniFile
    Private CommandList As New List(Of Command_)
    Structure Command_
        Dim CommandName As String
        Dim Command As String
        Dim Type As String
    End Structure
    Private loggedRemoteUser As String = ""
    Dim accountINI As New IniFile
    Sub Main()
        Console.WriteLine("EranBot 0.1")
        'Überprüft ob ein Lokales Konto existiert
        If File.Exists(accountPath) Then
            accountINI.Load(accountPath)
            'Lese den Authentifizierungskey aus der INI
            Dim authkey As String = accountINI.GetKeyValue("account", "authkey")
            'Lese den SHA512 wert des Passworts
            Dim iniPass As String = accountINI.GetKeyValue("account", "password")
            Dim Aliasname As String = accountINI.GetKeyValue("account", "alias")
            'Lese das Bild ein
            Dim accountImage As Byte() = Convert.FromBase64String(accountINI.GetKeyValue("account", "image"))
            Console.WriteLine("Username:")
            Dim username As String = Console.ReadLine

            'Überprüft ob es der richtige Benutzer ist vom Konto
            If username = accountINI.GetKeyValue("account", "username") Then
                'Wenn ja fordere das Password
                Console.WriteLine("Password:")
                Dim password As String = Console.ReadLine
                'Überprüft das Passwort
                If rHash.HashString(password, rHash.HASH.SHA512) = iniPass Then
                    '<-----------Wenn es richtig ist ist der Nutzer eigeloggt------------>
                    Console.WriteLine("you are loggin")
                    If Aliasname = "" Then
                        API.Account.Aliasname = username
                    Else
                        API.Account.Aliasname = Aliasname
                    End If
                    API.Account.AuthKey = authkey
                    API.Account.Password = password
                    API.Account.Profileimage = accountImage
                    API.Account.Username = username
                    API.Account.OnlineState = 2
                    newtrd.Start()
                    If File.Exists(My.Application.Info.DirectoryPath & OS.OS_slash & "commands.ini") Then
                        'lade die comandos
                        commandINI.Load(My.Application.Info.DirectoryPath & OS.OS_slash & "commands.ini")
                        For Each s As IniFile.IniSection In commandINI.Sections
                            For Each k As IniFile.IniSection.IniKey In s.Keys
                                Dim addCMD As New Command_
                                addCMD.CommandName = s.Name
                                addCMD.Type = k.Name
                                addCMD.Command = k.Value
                                CommandList.Add(addCMD)
                            Next : Next
                    Else
                        Console.WriteLine("WARNING COMMANDLIST NOT EXISTS!")
                    End If
                    cmdReturn()
                Else
                    'Wenn das Passwort falsch ist starte Main erneut!
                    Console.Clear()
                    Console.WriteLine("Wrong password!")
                    Main()
                End If
            Else
                'Wenn der Benutzername falsch ist dann starte Main erneut!
                Console.Clear()
                Console.WriteLine("Wrong username!")
                Main()
            End If
        Else
            'Wenn kein Lokales Konto existiert dann erstelle eins oder Lade es von einem Pfad
            Console.WriteLine("Select option:")
            Console.WriteLine("[1]  =   Load account from file")
            Console.WriteLine("[2]  =   Create new account")
            Dim selectIndex As Integer = CInt(Console.ReadLine())
            Select Case selectIndex
                Case 1
                    Console.WriteLine("Enter the accountfile path:")
                    Dim path As String = Console.ReadLine
                    If File.Exists(path) Then
                        File.Copy(path, My.Application.Info.DirectoryPath & OS.OS_slash & "account.ini")
                        Console.Clear()
                        Console.WriteLine("Account succefully added!")
                        Main()
                    Else
                        Console.Clear()
                        Console.WriteLine("Accountpath is valid!")
                        Main()
                    End If
                Case 2
                    Console.WriteLine("Enter username:")
                    Dim usrName As String = Console.ReadLine
                    Console.WriteLine("Enter password:")
                    Dim pwd As String = Console.ReadLine
                    Dim rndAuthKey As String = rndPass.Random(16)
                    Dim combine As String = rHash.HashString(rHash.HashString(usrName & pwd & rndAuthKey, rHash.HASH.SHA512), rHash.HASH.MD5)
                    Dim newAccINI As New IniFile
                    newAccINI.AddSection("account")
                    newAccINI.SetKeyValue("account", "username", usrName)
                    newAccINI.SetKeyValue("account", "password", rHash.HashString(pwd, rHash.HASH.SHA512))
                    newAccINI.SetKeyValue("account", "authkey", rndAuthKey)
                    newAccINI.SetKeyValue("account", "adress", combine)
                    newAccINI.SetKeyValue("account", "image", Resources_.ProfilImageB64)
                    newAccINI.Save(My.Application.Info.DirectoryPath & OS.OS_slash & "account.ini")
                    Console.WriteLine("Your Eran address: " & combine)
                    Console.WriteLine("Account succefully created!")
                    Main()
            End Select
        End If
    End Sub
    Sub trd()
        API.Connect("127.0.0.1", CInt(8000))
    End Sub

    Sub cmdReturn()
        Console.WriteLine(command(Console.ReadLine, accountINI))
        cmdReturn()
    End Sub

    Private Function command(ByVal cmd As String, ByVal loadedINI As IniFile) As String
        Select Case True
            Case cmd.Contains("/setAlias")
                Dim newAlias As String = parameter.read_parameter("/setAlias ", cmd)
                API.Account.Aliasname = newAlias
                Dim accINI As New IniFile
                accINI.Load(accountPath)
                accINI.SetKeyValue("account", "alias", newAlias)
                Dim mem As New MemoryStream(accINI.SavetoByte())
                My.Computer.FileSystem.WriteAllBytes(accountPath, mem.ToArray, False)
                mem.Close()
                sendAllAlias(newAlias)
                Return "Bot's new Aliasname is " & newAlias
            Case cmd.Contains("/getCommands")
                Dim cmdStrBuild As New StringBuilder
                For Each cmdList In CommandList
                    cmdStrBuild.AppendLine("-------------------------------------------")
                    cmdStrBuild.AppendLine("Command Name: " & cmdList.CommandName)
                    cmdStrBuild.AppendLine("Command Type: " & cmdList.Type)
                    cmdStrBuild.AppendLine("Command: " & cmdList.Command)
                    cmdStrBuild.AppendLine("-------------------------------------------")
                    cmdStrBuild.AppendLine("")
                Next
                Return cmdStrBuild.ToString
            Case cmd.Contains("/delCommand")
                'Löscht ein Kommando
                If parameter.read_parameter("/delCommand ", cmd).Length > 0 Then
                    'Überprüfen ob es den Kommando gibt
                    Dim delCommandName As String = parameter.read_parameter("/delCommand ", cmd)
                    If CommandList.Exists(Function(x) x.CommandName = delCommandName) Then
                        'Suche den Index
                        Dim delIndex As Integer = CommandList.FindIndex(Function(x) x.CommandName = delCommandName)
                        CommandList.RemoveAt(delIndex)
                        commandINI.RemoveSection(delCommandName)
                        commandINI.Save(My.Application.Info.DirectoryPath & OS.OS_slash & "commands.ini")
                        Return "Command " & delCommandName & " deleted!"
                    Else
                        Console.WriteLine("Command not exists!")
                        Return "Command " & delCommandName & " not exists!"
                    End If
                End If
            Case cmd.Contains("/setCommand")
                'Füge ein neues Kommando hinzu
                If parameter.read_parameter("/setCommand ", cmd).Length > 0 Then
                    Dim commandName As String = parameter.read_parameter("/setCommand ", cmd)
                    'Dim Command As String
                    commandINI.AddSection(commandName)
                    'Kommandotyp sendMessage
                    If parameter.read_parameter("/sendMessage ", cmd).Length > 0 Then
                        Dim sendMessage As String = parameter.read_parameter("/sendMessage ", cmd)
                        commandINI.SetKeyValue(commandName, "sendMessage", sendMessage)
                        commandINI.Save(My.Application.Info.DirectoryPath & OS.OS_slash & "commands.ini")
                        'Überprüfen ob es den Kommando schon gibt
                        If CommandList.Exists(Function(x) x.CommandName = commandName) Then
                            'Wenn ja lösche den alten und setze einen neuen
                            Dim cmdIndex As Integer = CommandList.FindIndex(Function(x) x.CommandName = commandName)
                            CommandList.RemoveAt(cmdIndex)
                            Dim addCMD As New Command_
                            addCMD.Type = "sendMessage"
                            addCMD.CommandName = commandName
                            addCMD.Command = sendMessage
                            CommandList.Add(addCMD)
                        Else
                            'Wenn es den Kommanndo nicht gibt
                            Dim addCMD As New Command_
                            addCMD.Type = "sendMessage"
                            addCMD.CommandName = commandName
                            addCMD.Command = sendMessage
                            CommandList.Add(addCMD)
                        End If
                        Return "Command " & commandName & " successfully added!"
                    End If

                    'Sende Message Datei
                    If parameter.read_parameter("/sendMessageFile ", cmd).Length > 0 Then
                        Dim sendMessageFile As String = parameter.read_parameter("/sendMessageFile ", cmd)
                        If File.Exists(sendMessageFile) Then
                            commandINI.SetKeyValue(commandName, "sendMessageFile", sendMessageFile)
                            commandINI.Save(My.Application.Info.DirectoryPath & OS.OS_slash & "commands.ini")
                            'Überprüfen ob es den Kommando schon gibt
                            If CommandList.Exists(Function(x) x.CommandName = commandName) Then
                                'Wenn ja lösche den alten und setze einen neuen
                                Dim cmdIndex As Integer = CommandList.FindIndex(Function(x) x.CommandName = commandName)
                                CommandList.RemoveAt(cmdIndex)
                                Dim addCMD As New Command_
                                addCMD.Type = "sendMessageFile"
                                addCMD.CommandName = commandName
                                addCMD.Command = sendMessageFile
                                CommandList.Add(addCMD)
                            Else
                                'Wenn es den Kommanndo nicht gibt
                                Dim addCMD As New Command_
                                addCMD.Type = "sendMessageFile"
                                addCMD.CommandName = commandName
                                addCMD.Command = sendMessageFile
                                CommandList.Add(addCMD)
                            End If
                            Return "Command " & commandName & " successfully added!"
                        Else
                            Return "File not exists!"
                        End If
                    End If

                    'Sende Sprachnachricht
                    If parameter.read_parameter("/sendAudio ", cmd).Length > 0 Then
                        Dim sendMessageFile As String = parameter.read_parameter("/sendAudio ", cmd)
                        If File.Exists(sendMessageFile) Then
                            commandINI.SetKeyValue(commandName, "sendAudio", sendMessageFile)
                            commandINI.Save(My.Application.Info.DirectoryPath & OS.OS_slash & "commands.ini")
                            'Überprüfen ob es den Kommando schon gibt
                            If CommandList.Exists(Function(x) x.CommandName = commandName) Then
                                'Wenn ja lösche den alten und setze einen neuen
                                Dim cmdIndex As Integer = CommandList.FindIndex(Function(x) x.CommandName = commandName)
                                CommandList.RemoveAt(cmdIndex)
                                Dim addCMD As New Command_
                                addCMD.Type = "sendAudio"
                                addCMD.CommandName = commandName
                                addCMD.Command = sendMessageFile
                                CommandList.Add(addCMD)
                            Else
                                'Wenn es den Kommanndo nicht gibt
                                Dim addCMD As New Command_
                                addCMD.Type = "sendAudio"
                                addCMD.CommandName = commandName
                                addCMD.Command = sendMessageFile
                                CommandList.Add(addCMD)
                            End If
                            Return "Audio command " & commandName & " successfully added!"
                        Else
                            Return "Audiofile not exists!"
                        End If
                    End If

                    'Kommandotyp sendMessage
                    If parameter.read_parameter("/sendFile ", cmd).Length > 0 Then
                        Dim sendMessage As String = parameter.read_parameter("/sendFile ", cmd)
                        commandINI.SetKeyValue(commandName, "sendFile", sendMessage)
                        commandINI.Save(My.Application.Info.DirectoryPath & OS.OS_slash & "commands.ini")
                        'Überprüfen ob es den Kommando schon gibt
                        If CommandList.Exists(Function(x) x.CommandName = commandName) Then
                            'Wenn ja lösche den alten und setze einen neuen
                            Dim cmdIndex As Integer = CommandList.FindIndex(Function(x) x.CommandName = commandName)
                            CommandList.RemoveAt(cmdIndex)
                            Dim addCMD As New Command_
                            addCMD.Type = "sendFile"
                            addCMD.CommandName = commandName
                            addCMD.Command = sendMessage
                            CommandList.Add(addCMD)
                        Else
                            'Wenn es den Kommanndo nicht gibt
                            Dim addCMD As New Command_
                            addCMD.Type = "sendFile"
                            addCMD.CommandName = commandName
                            addCMD.Command = sendMessage
                            CommandList.Add(addCMD)
                        End If
                        Return "Command " & commandName & " successfully added!"
                    End If
                Else
                    Return "Syntax Error!"
                    command(Console.ReadLine, loadedINI)
                End If

            Case cmd.Contains("/setWelcomeMessageEnabled")
                If parameter.read_parameter("/setWelcomeMessageEnabled", cmd).Length > 0 Then
                    Dim childAgeAsInt As Integer
                    If Integer.TryParse(parameter.read_parameter("/setWelcomeMessageEnabled", cmd), childAgeAsInt) Then
                        Dim setWelcomeMessageEnabled As Integer = CInt(parameter.read_parameter("/setWelcomeMessageEnabled", cmd))
                        Dim configINI As New IniFile
                        configINI.Load(My.Application.Info.DirectoryPath & OS.OS_slash & "config.ini")
                        Select Case setWelcomeMessageEnabled
                            Case 0
                                Return "Welcome message is disabled"
                                configINI.SetKeyValue("Bot", "welcomeMessageEnabled", CStr(setWelcomeMessageEnabled))
                                configINI.Save(My.Application.Info.DirectoryPath & OS.OS_slash & "config.ini")
                            Case 1
                                Return "Welcome message is enabled!"
                                configINI.SetKeyValue("Bot", "welcomeMessageEnabled", CStr(setWelcomeMessageEnabled))
                                configINI.Save(My.Application.Info.DirectoryPath & OS.OS_slash & "onfig.ini")
                            Case Else
                                Return "Enter 0(Disabled) | 1(Enabled)"
                        End Select 
                    Else
                        Return "Error: It is not an integer"
                    End If
                End If
            Case cmd.Contains("/setWelcomeMessage")
                If parameter.read_parameter("/message ", cmd).Length > 0 Then
                    Dim message As String = parameter.read_parameter("/message ", cmd)
                    Dim configINI As New IniFile
                    configINI.Load(My.Application.Info.DirectoryPath & OS.OS_slash & "config.ini")
                    configINI.SetKeyValue("Bot", "welcomeMessage", message)
                    configINI.Save(My.Application.Info.DirectoryPath & OS.OS_slash & "config.ini")
                    Return "Welcome message successfully changed!"
                Else
                    Return vbNewLine & "Please enter a message! |e.g. /setWelcomeMessage /message MyMessage\n\with line break;" & vbNewLine & "parameter {0} is the username from client."
                End If
            Case cmd.Contains("/setImage")
                If parameter.read_parameter("/url ", cmd).Length > 0 Then
                    Dim downImage As New Net.WebClient
                    Try
                        Dim imageByte As Byte() = downImage.DownloadData(parameter.read_parameter("/url ", cmd))

                        Dim cacheMem As New MemoryStream(imageByte)
                        Try
                            Dim new_bmp As Bitmap = CType(Bitmap.FromStream(cacheMem), Bitmap)
                            Dim resize As Bitmap = New Bitmap(new_bmp, New Size(64, 64))
                            Dim mem_ As New MemoryStream
                            resize.Save(mem_, System.Drawing.Imaging.ImageFormat.Png)
                            Dim to_bs64 As String = Convert.ToBase64String(mem_.ToArray)
                            API.Account.Profileimage = mem_.ToArray
                            mem_.Close()
                            cacheMem.Close()
                            Dim ini As New IniFile
                            ini.Load(accountPath)
                            ini.SetKeyValue("account", "image", to_bs64)
                            ini.Save(accountPath)
                            Dim img_str As String = to_bs64
                            For Each send_img In API.ChatSessions
                                API.SendToServer("/adress " & API.Account.Address & "; /to " & send_img.Address & "; /profil_image " & img_str & ";")
                            Next
                            Return "Bot image changed!"
                        Catch ex As Exception
                            Return "Error: URL is not a Image!"
                        End Try
                    Catch ex As Exception
                        Return "Error: The URL is not valid!"
                    End Try
                Else
                    If parameter.read_parameter("/path ", cmd).Length > 0 Then
                        If File.Exists(parameter.read_parameter("/path ", cmd)) Then
                            Dim new_bmp As Bitmap = CType(Bitmap.FromFile(parameter.read_parameter("/path ", cmd)), Bitmap)
                            Dim resize As Bitmap = New Bitmap(new_bmp, New Size(64, 64))
                            Dim mem_ As New MemoryStream
                            resize.Save(mem_, System.Drawing.Imaging.ImageFormat.Png)
                            Dim to_bs64 As String = Convert.ToBase64String(mem_.ToArray)
                            API.Account.Profileimage = mem_.ToArray
                            mem_.Close()
                            Dim ini As New IniFile
                            ini.Load(accountPath)
                            ini.SetKeyValue("account", "image", to_bs64)
                            ini.Save(accountPath)
                            Dim img_str As String = to_bs64
                            For Each send_img In API.ChatSessions
                                API.SendToServer("/adress " & API.Account.Address & "; /to " & send_img.Address & "; /profil_image " & img_str & ";")
                            Next
                            Return "Bot image changed!"
                        Else
                            Return "Imagepath does not exist!"
                        End If
                    Else
                        Return "Error"
                    End If
                    Return "Bot image changed!"
                End If

            Case cmd.Contains("/getWelcomeMessage")
                Dim configINI As New IniFile
                configINI.Load(My.Application.Info.DirectoryPath & OS.OS_slash & "config.ini")
                Dim readwlcMSG As String = configINI.GetKeyValue("Bot", "welcomeMessage").Replace("\n\", vbNewLine)
                Return (readwlcMSG)
            Case cmd.Contains("/help")
                Return cmdHelp
            Case cmd.Contains("/exit")
                Environment.Exit(0)
            Case cmd.Contains("/setState")
                If parameter.read_parameter("/setState ", cmd).Length > 0 Then
                    Dim childAgeAsInt As Integer
                    If Integer.TryParse(parameter.read_parameter("/setState ", cmd), childAgeAsInt) Then
                        Dim onlinestate As Integer = CInt(parameter.read_parameter("/setState ", cmd))
                        Select Case onlinestate
                            Case 0
                                API.Account.OnlineState = onlinestate
                                sendState(onlinestate)
                                Return "Bot Online State = Offline"
                            Case 1
                                API.Account.OnlineState = onlinestate
                                sendState(onlinestate)
                                Return "Bot Online State = Busy"
                            Case 2
                                API.Account.OnlineState = onlinestate
                                sendState(onlinestate)
                                Return "Bot Online State = Online"
                            Case Else
                                Return "Status is not available. Enter 0(Offline) | 1(Busy) | 2(Online)"
                        End Select
                    Else
                        Return "Error: It is not an integer"
                    End If   
                End If
            Case cmd.Contains("/getState")
                Select Case API.Account.OnlineState
                    Case 0
                        Return "Bot is Offline(0)"
                    Case 1
                        Return "Bot is Busy(1)"
                    Case 2
                        Return "Bot is Online(2)"
                End Select
            Case Else
                Return "Syntax Error!"
                command(Console.ReadLine, loadedINI)
        End Select
        Return "Syntax Error!"
    End Function

    Private Function sendState(ByVal state As Integer) As Object
        Dim readUsrList As New IniFile
        readUsrList.Load(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini")
        For Each s As IniFile.IniSection In readUsrList.Sections
            For Each k As IniFile.IniSection.IniKey In s.Keys
                API.SendToServer("/adress " & API.Account.Address & "; /to " & s.Name & "; /state " & API.Account.OnlineState & "; /username " & API.Account.Aliasname & ";")
            Next : Next
    End Function
    Private Function sendAllAlias(ByVal alias_ As String) As Object
        Dim readUsrList As New IniFile
        readUsrList.Load(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini")
        For Each s As IniFile.IniSection In readUsrList.Sections
            For Each k As IniFile.IniSection.IniKey In s.Keys
                API.SendToServer("/adress " & API.Account.Address & "; /to " & s.Name & "; /username " & alias_ & ";")
            Next : Next
    End Function


    Private cmdHelp As String = vbNewLine & "Enter a Bot command e.g." & vbNewLine & "/setCommand Test; /sendMessage Test back;" & _
                                     vbNewLine & "/delCommand youCommandNameHere;" & vbNewLine & "/getCommands" & vbNewLine & "/setWelcomeMessageEnabled 0|1;" & _
                                     vbNewLine & "/setWelcomeMessage /message yourMessageHere; " & vbNewLine & "(parameter {0} is the username, for line breake enter \n\)" & _
                                    vbNewLine & "/getWelcomeMessage" & vbNewLine & "/setAlias BotAliasHere;" & vbNewLine & "/setImage {/path BotFilePath  |  /url hostAddressHere};" & _
                                    vbNewLine & "/setState {0,1,2};" & vbNewLine & "/getState"

    Private Sub API_AuthorizedConnection(ByVal State As Boolean) Handles API.AuthorizedConnection
        If State = True Then
            sendState(API.Account.OnlineState)
            sendAllAlias(API.Account.Aliasname)
        End If
    End Sub

    Private Sub API_IncomingMessage(ByVal Address As String, ByVal Aliasname As String, ByVal ExchangeKey As String, ByVal Message As String, ByVal ProfilImage As System.Drawing.Image) Handles API.IncomingMessage
        If Address = loggedRemoteUser Then
            Select Case Message
                Case "/help"
                    API.SendToClient(Address, cmdHelp & vbNewLine & "---------------" & vbNewLine & "/logout")
                Case "/logout"
                    loggedRemoteUser = ""
                    API.SendToClient(Address, "Bye bye " & Aliasname)
                Case "/getWelcomeMessage"
                    Dim configINI As New IniFile
                    configINI.Load(My.Application.Info.DirectoryPath & OS.OS_slash & "config.ini")
                    Dim readwlcMSG As String = configINI.GetKeyValue("Bot", "welcomeMessage").Replace("\n\", vbNewLine)
                    API.SendToClient(Address, String.Format(readwlcMSG, Aliasname))
                Case Else
                    Select Case Message
                        Case "/exit"
                            API.SendToClient(Address, "The bot can not be turned off from the remote access." & vbNewLine & "To make the bot offline , use the ""/setState"" commando")
                        Case Else
                            API.SendToClient(Address, command(Message, commandINI))
                    End Select
            End Select
        Else
            If Message.Substring(0, 1) = "/" Then
                Dim readCommand As String = Message.Substring(1, Message.Length - 1)
                'Überprüfen ob der Kommando eingetragen ist
                If CommandList.Exists(Function(x) x.CommandName = readCommand) Then
                    ' Überüfe was es für ein Typ ist
                    Dim cmdIndex As Integer = CommandList.FindIndex(Function(x) x.CommandName = readCommand)
                    Dim commandType As String = CommandList.Item(cmdIndex).Type
                    Dim command As String = CommandList.Item(cmdIndex).Command

                    'Wenn es ein sendMessage ist denn sende den Client eine Nachricht
                    If commandType = "sendMessage" Then
                        API.SendToClient(Address, command)
                    End If

                    'Wenn es ein sendMessageFile ist denn sende den Client eine text datei
                    If commandType = "sendMessageFile" Then
                        Dim str As String = File.ReadAllText(command)
                        API.SendToClient(Address, str)
                    End If

                    'Wenn es ein senAudio ist denn sende den Client eine Sprachnachricht
                    If commandType = "sendAudio" Then
                        API.SendToClient(Address, "Please wait a moment...")
                        Dim aes As New AESEncrypt
                        Dim readRecByte As Byte() = File.ReadAllBytes(command)
                        Dim getbytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes("/" & System.Text.UTF8Encoding.UTF8.GetChars({200, 5, 255, 80, 208, 156}) & Convert.ToBase64String(readRecByte) & ";")
                        Dim target As Byte()
                        Dim getIndex As String = CStr(API.ChatSessions.FindIndex(Function(x) x.Address = Address))
                        Dim key As String = API.ChatSessions.Item(CInt(getIndex)).Key
                        aes.Encode(getbytes, target, key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                        Dim to_bs64 As String = Convert.ToBase64String(target)
                        API.SendToServer("/adress " & API.Account.Address & "; /to " & Address & "; /msg " & to_bs64 & ";")
                    End If

                    If commandType = "sendFile" Then
                        Dim sessionIndex As Integer = API.ChatSessions.FindIndex(Function(x) x.Address = Address)
                        Dim sessionKey As String = API.ChatSessions.Item(sessionIndex).Key
                        Dim DT As New DataTransfer
                        DT.ToEran = Address
                        DT.Key = sessionKey
                        DT.FileName = command
                        Dim DTTrd As New Threading.Thread(AddressOf DT.Send)
                        DTTrd.Start()
                    End If
                Else
                    Select Case readCommand
                        Case "help"
                            Dim strBuild As New StringBuilder
                            strBuild.Append(vbNewLine)

                            For Each getCommands In CommandList
                                strBuild.Append("/" & getCommands.CommandName & vbNewLine)
                            Next
                            strBuild.AppendLine("-----------------------------------")
                            strBuild.AppendLine("Standard commands:")
                            strBuild.AppendLine("/login         (login to EranBot remote control)")
                            strBuild.AppendLine("/bottime       (Date and Time from Bot device)")
                            strBuild.AppendLine("/bot address   (Eran address from Eran Bot)")
                            strBuild.AppendLine("-----------------------------------")
                            API.SendToClient(Address, strBuild.ToString)
                        Case "bottime"
                            API.SendToClient(Address, Now.ToString)
                        Case "bot address"
                            API.SendToClient(Address, "My address is: " & API.Account.Address)
                        Case Else
                            Select Case True
                                Case Message.Contains("/login")
                                    If parameter.read_parameter("/username ", Message).Length > 0 Then
                                        If parameter.read_parameter("/password ", Message).Length > 0 Then
                                            Dim usrname As String = parameter.read_parameter("username ", Message)
                                            Dim pwd As String = parameter.read_parameter("password ", Message)
                                            If API.Account.Username = usrname Then
                                                If API.Account.Password = pwd Then
                                                    loggedRemoteUser = Address
                                                    API.SendToClient(Address, "Welcome " & Aliasname & " what can I do for you? :-)")
                                                    Console.WriteLine(Aliasname & "[" & Address & "] ... Has logged in")
                                                Else
                                                    API.SendToClient(Address, "Login fail!")
                                                End If
                                            Else
                                                API.SendToClient(Address, "Login fail!")
                                            End If
                                        Else
                                            API.SendToClient(Address, "Please enter a password!")
                                        End If
                                    Else
                                        API.SendToClient(Address, "Please enter a username!")
                                    End If
                                Case Else
                                    API.SendToClient(Address, vbNewLine & "Sorry, command not exists!" & vbNewLine & "Please entry /help for commands")
                            End Select
                    End Select
                End If
            End If
        End If
    End Sub
End Module
