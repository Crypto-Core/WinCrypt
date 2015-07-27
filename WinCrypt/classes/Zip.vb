Option Strict On

Imports Shell32

Namespace classes

    Public Class Zip
        Public Sub zip(zipfrom As String, zipto As String)
            Dim srcfolderString As String = zipfrom
            Dim dstfolderString As String = zipto
            Dim fileContents() As Byte = {80, 75, 5, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            My.Computer.FileSystem.WriteAllBytes(dstfolderString, fileContents, False)
            Dim objShell As New Shell
            Dim objFolderSrc As Folder
            Dim objFolderDst As Folder
            Dim objFolderItems As FolderItems
            objFolderSrc = objShell.NameSpace(srcfolderString)
            objFolderDst = objShell.NameSpace(dstfolderString)
            objFolderItems = objFolderSrc.Items
            objFolderDst.CopyHere(objFolderItems, 20)
        End Sub
    End Class
End Namespace