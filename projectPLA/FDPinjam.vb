Imports System.Data
Imports System.Data.OleDb
Public Class FDPinjam
    Sub tampil(ByVal data As String)
        TextBox1.Clear()

        ListView1.Items.Clear()
        konek_db()
        Dim perintah As New OleDb.OleDbCommand("Select * From pinjam " & data & "")
        Dim baca As OleDb.OleDbDataReader
        perintah.Connection = koneksi
        baca = perintah.ExecuteReader

        Dim i As Integer = 0
        Do While baca.Read()
            ListView1.Items.Add(baca!kode_anggota)
            ListView1.Items(i).SubItems.Add(baca!nama_anggota)
            ListView1.Items(i).SubItems.Add(baca!kode_buku)
            ListView1.Items(i).SubItems.Add(baca!judul_buku)
            ListView1.Items(i).SubItems.Add(baca!tgl_pinjam)
            ListView1.Items(i).SubItems.Add(baca!tgl_kembali)
            ListView1.Items(i).SubItems.Add(baca!jumlah_pinjam)
            i = i + 1
        Loop

    End Sub
    Private Sub FDPinjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil("")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan Kode Buku Yang Akan Di Cari", MsgBoxStyle.Critical, "Attention")
        Else
            konek_db()
            Dim data As String = "Where kode_buku like'%" & TextBox1.Text & "%'"
            MsgBox("Data Di Temukan", MsgBoxStyle.Information, "Information")
            tampil(data)

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tampil("")
    End Sub
End Class