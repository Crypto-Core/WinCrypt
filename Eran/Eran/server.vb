﻿Imports System.Net.Sockets
Imports System.IO
Imports System.Net

Module server
    Private server_ As TcpListener
    Private client As New TcpClient
    Private ipendpoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 8000)
    Private list As New List(Of Connection)
    Private PrivateKey As String
    Private PublicKey As String
    Private aes_ As New AESEncrypt
    Friend myHost As String = "192.168.0.1"
    Friend forward_lst As New TextBox
    Private Structure Connection
        Dim stream As NetworkStream
        Dim streamw As StreamWriter
        Dim streamr As StreamReader
        Dim eran_adress As String
        Dim rsa_public_key As String
        Dim Key As String
    End Structure
    Friend Function isConnected(ByVal eran_adress As String) As Boolean
        For Each check In list
            If eran_adress = check.eran_adress Then
                Return True
                End
            End If
        Next
        Return False
    End Function
    Sub Main()
        Dim rsa_keys = RSA.Create_RSA_Key
        Console.WriteLine("Server started")
        server_ = New TcpListener(ipendpoint)
        server_.Start()

        While True
            client = server_.AcceptTcpClient
            Console.WriteLine("Accepted Client" & vbNewLine)
            Dim c As New Connection

            c.stream = client.GetStream
            c.streamr = New StreamReader(c.stream)
            c.streamw = New StreamWriter(c.stream)
            Dim client_msg As String = Base64.FromBase64Str_to_Str(c.streamr.ReadLine) ' Empfange die Nachricht und Dekodiere den Base64 String
            If isConnected(parameter.read_parameter("/adress ", client_msg)) Then : Else
                Console.WriteLine("Get Message: " & client_msg & vbNewLine)

                'Empfange Eran Adresse
                c.eran_adress = parameter.read_parameter("/adress ", client_msg) ' falls das mit dem nick nicht gewünscht, auch diese zeile entfernen.
                Console.WriteLine("Filtert Adress: " & c.eran_adress & vbNewLine)


                'Empfange RSA PublicKey
                Dim filter_PublicKey As String = parameter.read_parameter("/publickey ", client_msg)
                c.rsa_public_key = Base64.FromBase64Str_to_Str(filter_PublicKey) ' Der PublicKey wird entgegengenommen
                Console.WriteLine("Filtert RSA Public Key: " & filter_PublicKey & vbNewLine)

                'Schicke verschlüsselte RSA Nachricht zurück.
                Dim rndKey As String = rndPass.Random(32)
                c.Key = rndKey
                Console.WriteLine("Create Key......" & vbNewLine)
                Console.WriteLine("Key: " & rndKey & vbNewLine)

                Dim encrypted_key As String = RSA.RSA_encrypt(rndKey, c.rsa_public_key)
                Console.WriteLine("Encrypt Key with Client Public Key......." & vbNewLine)

                Dim handshake As String = Base64.Str_To_Base64Str("/to " & c.eran_adress & "; " & "/server_encrypted_key " & encrypted_key & "; " & "/reconnect_to " & myHost & "; ")
                c.streamw.WriteLine(handshake)

                Console.WriteLine("Send Handshake to Client: " & handshake & vbNewLine)
                c.streamw.Flush()
                list.Add(c)
                Console.WriteLine(c.eran_adress & " has joined.")
                Dim t As New Threading.Thread(AddressOf ListenToConnection)
                t.Start(c)
            End If


        End While
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
                'Console.WriteLine(tmp)
                ' Verarbeite die Parameter
                Dim adress As String = parameter.read_parameter("/adress ", dec_byte_to_str)
                Dim ping As String = parameter.read_parameter("/ping ", dec_byte_to_str)
                Dim msg As String = parameter.read_parameter("/msg ", dec_byte_to_str)
                Dim get_publickey As String = parameter.read_parameter("/get_publickey ", dec_byte_to_str)
                to_ = parameter.read_parameter("/to ", dec_byte_to_str)
                Dim get_nickname As String = parameter.read_parameter("/get_nickname ", dec_byte_to_str)
                Dim img_file As String = parameter.read_parameter("/img_file ", dec_byte_to_str)
                Dim reconnect_to As String = parameter.read_parameter("/reconnect_to ", dec_byte_to_str)
                Dim forwarding As String = parameter.read_parameter("/forwarding ", dec_byte_to_str)
                

                'Es wird überprüft ob der Absender in der eignen Liste ist
                    'Es wird überorüft ob der Empfänger der Server ist
                    If to_ = "server" Then
                        If ping = "ping" Then
                            Dim get_bytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes("/to " & con.eran_adress & "; " & "/ping pong;")
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
                                    'Wenn der Empfänger nicht in der eigenen Benutzerliste ist soll es
                                    'weitergeleitet werden.
                                If adress = main_frm.eran_adress Then
                                Else
                                    If main_frm.host = "localhost" Then
                                    Else
                                        forward_lst.Text = dec_byte_to_str
                                    End If
                                End If
                                End If
                            Catch
                            End Try
                        Next
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
                list.Remove(con)
                Console.WriteLine(con.eran_adress & " has exit.")
                Exit Do
            End Try
        Loop


    End Sub
    Friend Function send_to_clients(ByVal message As String)
        For Each c As Connection In list
            Try
                Dim get_bytes As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(message)
                Dim encrypt_source As Byte()
                aes_.Encode(get_bytes, encrypt_source, c.Key, AESEncrypt.ALGO.RIJNDAEL, 4096)
                c.streamw.WriteLine(Convert.ToBase64String(encrypt_source))
                c.streamw.Flush()
                GC_.FlushMemory()
                Exit For
            Catch
            End Try
        Next
    End Function
End Module
