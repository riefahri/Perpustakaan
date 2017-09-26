Imports System.Data
Imports System.Data.OleDb
Public Class LPinjam

    Private Sub LPinjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'plaDataSet.kembali' table. You can move, or remove it, as needed.
        Me.kembaliTableAdapter.Fill(Me.plaDataSet.kembali)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class