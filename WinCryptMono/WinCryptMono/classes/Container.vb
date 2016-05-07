Imports System.IO
Imports WinCryptMono.IniFile

Public Class Container
    Friend Shared INI As New IniFile
    Private AES As New AESEncrypt

    Event IncludeFolderProgress(ByVal max As Integer, ByVal value As Integer)

    Public Function AddFile(ByVal Data As Byte(), ByVal FileName As String, ByVal headPath As String)
        Dim fileInfo As New IO.FileInfo(FileName)
        Dim short_ As String = fileInfo.FullName.Replace(headPath, "")
        short_ = short_.Substring(1, short_.Length - 1)
        Dim Section As String = Convert.ToBase64String(System.Text.UTF8Encoding.UTF8.GetBytes(short_))
        INI.AddSection(Section)
        INI.SetKeyValue(Section, "Data", Convert.ToBase64String(Data))
    End Function
    Public Function RemoveAll()
        INI.RemoveAllSections()
        INI = New IniFile
    End Function
    Public Function IncludeDir(ByVal Path As String, Optional ByVal SearchOption As SearchOption = SearchOption.TopDirectoryOnly)
        Dim max As Integer = Directory.GetFiles(Path, "*.*", SearchOption).Count
        Dim value As Integer = 0
        For Each index In Directory.GetFiles(Path, "*.*", SearchOption)
            Dim short_ As String = index.Replace(Path, "")
            Dim Section As String = Convert.ToBase64String(System.Text.UTF8Encoding.UTF8.GetBytes(short_))
            INI.AddSection(Section)
            INI.SetKeyValue(Section, "Data", Convert.ToBase64String(File.ReadAllBytes(index)))
            value += 1
            RaiseEvent IncludeFolderProgress(max, value)
        Next
        max = 0
        value = 0
    End Function

    Public Function RemoveFile(ByVal FileName As String)
        Dim fileInfo As New IO.FileInfo(FileName)
        Dim Section As String = Convert.ToBase64String(System.Text.UTF8Encoding.UTF8.GetBytes(fileInfo.Name))
        INI.RemoveSection(Section)
    End Function

    Public Function GetFile(ByVal FileName As String) As Byte()
        Dim fileInfo As New IO.FileInfo(FileName)
        Dim Section As String = Convert.ToBase64String(System.Text.UTF8Encoding.UTF8.GetBytes(fileInfo.Name))
        Return Convert.FromBase64String(INI.GetKeyValue(Section, "Data"))
    End Function

    Public Function SetFile(ByVal Data As Byte(), ByVal FileName As String)
        Dim fileInfo As New IO.FileInfo(FileName)
        Dim Section As String = Convert.ToBase64String(System.Text.UTF8Encoding.UTF8.GetBytes(fileInfo.Name))
        INI.SetKeyValue(Section, "Data", Convert.ToBase64String(Data))
    End Function

    Private Function RenameFile(ByVal FileName As String, ByVal NewName As String)
        Dim fileInfo As New IO.FileInfo(FileName)
        Dim Section As String = Convert.ToBase64String(System.Text.UTF8Encoding.UTF8.GetBytes(fileInfo.Name))
        INI.RenameSection(Section, Convert.ToBase64String(System.Text.UTF8Encoding.UTF8.GetBytes(NewName)))
    End Function


    Public Function Extract(ByVal OutPath As String)
        On Error Resume Next
        For Each s As IniSection In INI.Sections
            For Each k As IniSection.IniKey In s.Keys
                If k.Value <> String.Empty Then
                    Dim decodeFileName As String = System.Text.UTF8Encoding.UTF8.GetChars(Convert.FromBase64String(s.Name))
                    Dim decodeData As Byte() = Convert.FromBase64String(k.Value)

                    If IncludedPath(decodeFileName) = False Then
                        If decodeFileName.Contains("\") Then
                            If OS.OS = OS.OSPlatform.Unix Then
                                Directory.CreateDirectory(OutPath & decodeFileName.Substring(0, decodeFileName.LastIndexOf("\")).Replace("\", "/"))
                            Else
                                Directory.CreateDirectory(OutPath & decodeFileName.Substring(0, decodeFileName.LastIndexOf("\")))
                            End If
                        Else
                            If OS.OS = OS.OSPlatform.Win32NT Then
                                Directory.CreateDirectory(OutPath & decodeFileName.Substring(0, decodeFileName.LastIndexOf("/")).Replace("/", "\"))
                            Else
                                Directory.CreateDirectory(OutPath & decodeFileName.Substring(0, decodeFileName.LastIndexOf("/")))
                            End If
                        End If
                    End If
                    If OS.OS = OS.OSPlatform.Unix Then
                        File.WriteAllBytes(OutPath & decodeFileName.Replace("\", "/"), decodeData)
                    Else
                        File.WriteAllBytes(OutPath & decodeFileName.Replace("/", "\"), decodeData)
                    End If

                End If
            Next
        Next
    End Function
  
    Public Function LoadContainer(ByVal Path As String, ByVal Password As String, Optional ByVal BitLength As Integer = 4096)
        Dim readByte As Byte() = File.ReadAllBytes(Path)
        Dim target As Byte()
        AES.Decode(readByte, target, Password, AESEncrypt.ALGO.RIJNDAEL, BitLength)
        Dim mem As New MemoryStream(target)
        INI.LoadFromMemory(mem)
        mem.Close()
        mem.Dispose()
    End Function

    Public Function SaveContainer(ByVal Path As String, ByVal Password As String, Optional ByVal BitLength As Integer = 4096)
        Dim target As Byte()
        AES.Encode(INI.SavetoByte, target, Password, AESEncrypt.ALGO.RIJNDAEL, BitLength)
        File.WriteAllBytes(Path, target)
        INI.RemoveAllSections()
    End Function
    Private Function IncludedPath(ByVal FileName As String) As Boolean
        On Error Resume Next
        Dim decode As String = System.Text.UTF8Encoding.UTF8.GetChars(Convert.FromBase64String(FileName))
        If decode.Split(OS.OS_slash).Count - 1 = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
