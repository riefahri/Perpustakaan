Imports System.Data.OleDb
Module Module1
    Public koneksi As OleDbConnection = Nothing
    Public Sub konek_db()
        Dim server As String
        server = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\pla.accdb"
        koneksi = New OleDbConnection(server)
        koneksi.Open()
    End Sub
End Module