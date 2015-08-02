Option Strict On

Imports System.IO
Imports Shell32



Friend Class Unzip
        Private _file As String
        Private ReadOnly _folder As String
        Private _towhere As String
    Private WithEvents finishunzip As New AppUpdate
    Private ReadOnly _shell As IShellDispatch2

        ''' <summary>Event welches vor dem Entpacken (Unzip) ausgeführt wird.</summary>
        ''' <remarks></remarks>
        Friend Event Unzipstart()

        ''' <summary>Event welches nach dem Entpacken (Unzip) ausgeführt wird.</summary>
        ''' <remarks></remarks>
        Friend Event UnzipFinishd()

        ''' <summary>Neue Instanz der ClassUnzip Klasse.</summary>
        ''' <param name="file">Datei welche entpackt werden soll.</param>
        ''' <param name="towhere">Zielordner.</param>
        ''' <remarks></remarks>
        Friend Sub New(file As String, towhere As String)
            _file = file
            _towhere = towhere
            _folder = Path.Combine(Path.GetDirectoryName(_file), _towhere)
            _shell = CType(CreateObject("Shell.Application"), IShellDispatch2)
        End Sub

    ''' <summary>Das Entpacken (Unzip) wird ausgeführt.</summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function UnzipNow() As Boolean
        If Directory.Exists(_folder) = False Then
            Directory.CreateDirectory(_folder)
        End If
        RaiseEvent Unzipstart()
        Dim temp As Folder = _shell.NameSpace((_folder))
        Try
            If temp IsNot Nothing Then
                temp.CopyHere(_shell.NameSpace((_file)).Items)
            End If
        Catch ex As Exception

        End Try
        RaiseEvent UnzipFinishd()
        Return True
    End Function

    ''' <summary>Gibt den Namen der gepackten Datei zurück, oder setzt diesen.</summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property UnZipFile As String
        Get
            Return _file
        End Get
        Set(value As String)
            _file = value
        End Set
    End Property

    ''' <summary>Gibt den Zielort (entpacken) zurück, oder setzt diesen.</summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property UnzipTo As String
            Get
                Return _towhere
            End Get
            Set(value As String)
                _towhere = value
            End Set
        End Property
End Class