Imports System.Net.Sockets
Imports System.IO
Imports System.Net
Imports System.Timers
Module server
    Private server As TcpListener
    Private client As New TcpClient
    Private ipendpoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 8000)
    Private list As New List(Of Connection)
    Private PrivateKey As String
    Private PublicKey As String
    Private aes_ As New AESEncrypt
    Private myHost As String = "192.168.0.1"
    Private userOnline As Integer = 0
    Private WithEvents IsUserOnline As New System.Timers.Timer(30000)
    Private OnlineList As New List(Of String)
    Private Structure Connection
        Dim stream As NetworkStream
        Dim streamw As StreamWriter
        Dim streamr As StreamReader
        Dim eran_adress As String
        Dim rsa_public_key As String
        Dim Key As String
        Dim Authenticated As Boolean
    End Structure
    Friend Function isConnected(ByVal eran_adress As String) As Boolean
        Try
            For Each check In list
                If eran_adress = check.eran_adress Then
                    Return True
                    End
                End If
            Next
            Return False
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "/ErrorLog.txt", ex.ToString & vbNewLine, True)
        End Try

    End Function
    Sub Main()
        Try
            Dim rsa_keys = RSA.Create_RSA_Key
            Console.WriteLine("Server started")
            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "/useronline", userOnline, False)
            server = New TcpListener(ipendpoint)
            server.Start()
            While True
                'If IsUserOnline.Enabled = False Then
                'IsUserOnline.Enabled = True
                'Else : End If

                client = server.AcceptTcpClient
                'Console.WriteLine("Accepted Client" & vbNewLine)
                Dim c As New Connection

                c.stream = client.GetStream
                c.streamr = New StreamReader(c.stream)
                c.streamw = New StreamWriter(c.stream)
                Dim client_msg As String = Base64.FromBase64Str_to_Str(c.streamr.ReadLine) ' Empfange die Nachricht und Dekodiere den Base64 String
                If isConnected(parameter.read_parameter("/adress ", client_msg)) = True Then

                Else
                    'Console.WriteLine("Get Message: " & client_msg & vbNewLine)

                    'Empfange Eran Adresse
                    c.eran_adress = parameter.read_parameter("/adress ", client_msg) ' falls das mit dem nick nicht gewünscht, auch diese zeile entfernen.
                    'Console.WriteLine("Filtert Adress: " & c.eran_adress & vbNewLine)


                    'Empfange RSA PublicKey
                    Dim filter_PublicKey As String = parameter.read_parameter("/publickey ", client_msg)
                    c.rsa_public_key = Base64.FromBase64Str_to_Str(filter_PublicKey) ' Der PublicKey wird entgegengenommen
                    ' Console.WriteLine("Filtert RSA Public Key: " & filter_PublicKey & vbNewLine)

                    'Schicke verschlüsselte RSA Nachricht zurück.
                    Dim rndKey As String = rndPass.Random(32)
                    c.Key = rndKey
                    'Console.WriteLine("Create Key......" & vbNewLine)
                    'Console.WriteLine("Key: " & rndKey & vbNewLine)

                    Dim encrypted_key As String = RSA.RSA_encrypt(rndKey, c.rsa_public_key)
                    ' Console.WriteLine("Encrypt Key with Client Public Key......." & vbNewLine)

                    Dim handshake As String = Base64.Str_To_Base64Str("/to " & c.eran_adress & "; " & "/server_encrypted_key " & encrypted_key & "; " & "/reconnect_to " & myHost & "; /getauthKey 0;")
                    c.streamw.WriteLine(handshake)

                    c.Authenticated = False

                    'Console.WriteLine("Send Handshake to Client: " & handshake & vbNewLine)
                    c.streamw.Flush()
                    list.Add(c)
                    userOnline += 1
                    My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "/useronline", userOnline, False)
                    'Console.WriteLine(c.eran_adress & " has joined.")
                    Dim t As New Threading.Thread(AddressOf ListenToConnection)
                    t.Start(c)
                End If


            End While
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "/ErrorLog.txt", ex.ToString & vbNewLine, True)
        End Try

    End Sub

    Private Sub ListenToConnection(ByVal con As Connection)
        Do
            Dim decode_BS64 As Byte()
            Dim decrypt_tmp As Byte()
            Dim dec_byte_to_str As String
            Dim to_ As String
            Try
                Dim tmp As String = con.streamr.ReadLine
                decode_BS64 = Convert.FromBase64String(tmp)
                aes_.Decode(decode_BS64, decrypt_tmp, con.Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                dec_byte_to_str = System.Text.UTF8Encoding.UTF8.GetChars(decrypt_tmp)

                ' Verarbeite die Parameter
                Dim adress As String = parameter.read_parameter("/adress ", dec_byte_to_str)
                Dim ping As String = parameter.read_parameter("/ping ", dec_byte_to_str)
                Dim msg As String = parameter.read_parameter("/msg ", dec_byte_to_str)
                Dim get_authKey As String = parameter.read_parameter("/getauthKey ", dec_byte_to_str)
                Dim get_publickey As String = parameter.read_parameter("/get_publickey ", dec_byte_to_str)
                to_ = parameter.read_parameter("/to ", dec_byte_to_str)
                Dim get_nickname As String = parameter.read_parameter("/get_nickname ", dec_byte_to_str)
                Dim img_file As String = parameter.read_parameter("/img_file ", dec_byte_to_str)
                Dim reconnect_to As String = parameter.read_parameter("/reconnect_to ", dec_byte_to_str)

                If adress = con.eran_adress Then
                    If get_authKey.Length > 1 Then
                        Dim DecodeByte As Byte()
                        DecodeByte = Convert.FromBase64String(get_authKey)
                        Dim toSHA12 As String = rHash.HashByte(DecodeByte, rHash.HASH.SHA512)
                        Dim toMD5 As String = rHash.HashString(toSHA12, rHash.HASH.MD5)
                        If con.eran_adress = toMD5 Then
                            con.Authenticated = True
                            Console.WriteLine("Autorize")
                            Dim get_bytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes("/adress server; /to " & con.eran_adress & "; " & "/authorized 1;")
                            Dim encrypt_source As Byte()
                            aes_.Encode(get_bytes, encrypt_source, con.Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                            con.streamw.WriteLine(Convert.ToBase64String(encrypt_source))
                            con.streamw.Flush()
                        Else
                            Dim get_bytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes("/adress server; /to " & con.eran_adress & "; " & "/authorized 0;")
                            Dim encrypt_source As Byte()
                            aes_.Encode(get_bytes, encrypt_source, con.Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                            con.streamw.WriteLine(Convert.ToBase64String(encrypt_source))
                            con.streamw.Flush()
                        End If
                    End If
                    If con.Authenticated Then
                        If to_ = "server" Then
                            If ping = "pong" Then
                                OnlineList.Add(adress)
                                'Console.WriteLine(adress & " is available")
                            End If
                            If ping = "ping" Then
                                Dim get_bytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes("/adress server; /to " & con.eran_adress & "; " & "/ping pong;")
                                Dim encrypt_source As Byte()
                                aes_.Encode(get_bytes, encrypt_source, con.Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                                con.streamw.WriteLine(Convert.ToBase64String(encrypt_source))
                                con.streamw.Flush()
                            End If
                        Else
                            For Each c As Connection In list
                                Try
                                    If to_ = c.eran_adress Then
                                        Dim get_bytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(dec_byte_to_str)
                                        Dim encrypt_source As Byte()
                                        aes_.Encode(get_bytes, encrypt_source, c.Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                                        c.streamw.WriteLine(Convert.ToBase64String(encrypt_source))
                                        c.streamw.Flush()
                                        Exit For
                                    Else
                                    End If
                                Catch
                                End Try
                            Next
                        End If
                    End If
                Else

                End If
                GC_.FlushMemory()
            Catch

                For Each c As Connection In list
                    Try
                        Dim get_bytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes("/all " & con.eran_adress & "; /state 0;")
                        Dim encrypt_source As Byte()
                        aes_.Encode(get_bytes, encrypt_source, c.Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                        c.streamw.WriteLine(Convert.ToBase64String(encrypt_source))
                        c.streamw.Flush()
                        GC_.FlushMemory()
                        Exit For
                    Catch
                    End Try
                Next
                list.RemoveAt(list.FindIndex(Function(x) x.eran_adress = con.eran_adress))
                'list.Remove(con)
                userOnline -= 1
                My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "/useronline", userOnline, False)
                Console.WriteLine(con.eran_adress & " has exit.")
                Exit Do
            End Try
        Loop
    End Sub

    Private Sub IsUserOnline_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles IsUserOnline.Elapsed
        If list.Count = 0 Then : Else
            For Each tt As Connection In list
                Dim getBytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes("/adress server; /to " & tt.eran_adress & "; /ping ping;")
                Dim encrypt_source As Byte()
                aes_.Encode(getBytes, encrypt_source, tt.Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                tt.streamw.WriteLine(Convert.ToBase64String(encrypt_source))
                tt.streamw.Flush()
                'Console.WriteLine("Check available: " & tt.eran_adress)
            Next
            IsUserOnline.Enabled = False
            System.Threading.Thread.Sleep(20000)
            For Each tt As Connection In list
                If isOnline(tt.eran_adress) = False Then
                    list.Remove(tt)
                    Dim get_bytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes("/all " & tt.eran_adress & "; /state 0;")
                    Dim encrypt_source As Byte()
                    aes_.Encode(get_bytes, encrypt_source, tt.Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                    tt.streamw.WriteLine(Convert.ToBase64String(encrypt_source))
                    tt.streamw.Flush()
                    Exit For
                Else

                End If
            Next
            OnlineList.Clear()
            IsUserOnline.Enabled = True
        End If
    End Sub

    Private Function isOnline(ByVal Address As String) As Boolean
        For Each check In OnlineList
            If Address = check Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function
End Module
