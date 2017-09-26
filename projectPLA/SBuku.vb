Imports System.Data
Imports System.Data.OleDb
Public Class SBuku
    Sub tampil_data(ByVal data As String)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox1.Focus()

        ListView1.Items.Clear()

        konek_db()
        Dim perintah As New OleDb.OleDbCommand("Select * From buku " & data & "")
        Dim baca As OleDb.OleDbDataReader
        perintah.Connection = koneksi
        baca = perintah.ExecuteReader


        Dim i As Integer = 0
        Do While baca.Read()
            ListView1.Items.Add(baca!kode_buku)
            ListView1.Items(i).SubItems.Add(baca!judul_buku)
            ListView1.Items(i).SubItems.Add(baca!pengarang)
            ListView1.Items(i).SubItems.Add(baca!penerbit)
            ListView1.Items(i).SubItems.Add(baca!tahun_terbit)
            ListView1.Items(i).SubItems.Add(baca!stock)
            i = i + 1
        Loop
    End Sub

    Private Sub SBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil_data("")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Masukkan Kode Buku Yang Akan Di Cari", MsgBoxStyle.Critical, "Attention")
        Else
            konek_db()
            Dim data As String = "Where kode_buku like'%" & TextBox1.Text & "%'"
            MsgBox("Data Di Temukan", MsgBoxStyle.Information, "Information")
            tampil_data(data)

        End If
    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        TextBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text
        TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text
        TextBox3.Text = ListView1.SelectedItems(0).SubItems(2).Text
        TextBox4.Text = ListView1.SelectedItems(0).SubItems(3).Text
        TextBox5.Text = ListView1.SelectedItems(0).SubItems(4).Text
        TextBox6.Text = ListView1.SelectedItems(0).SubItems(5).Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tampil_data("")
    End Sub

End Class