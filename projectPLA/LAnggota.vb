Imports System.Data
Imports System.Data.OleDb
Public Class LAnggota

    Private Sub LAnggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'plaDataSet.anggota' table. You can move, or remove it, as needed.
        Me.anggotaTableAdapter.Fill(Me.plaDataSet.anggota)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class