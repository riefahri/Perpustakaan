Imports System.Data
Imports System.Data.OleDb
Public Class FTKbuku
    Sub tampil(ByVal data As String)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        RichTextBox1.Clear()

        TextBox4.Clear()
    

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

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            konek_db()
            Dim cari As New OleDb.OleDbCommand("Select * From pinjam where kode_anggota='" & TextBox1.Text & "'")
            Dim baca As OleDb.OleDbDataReader
            cari.Connection = koneksi
            baca = cari.ExecuteReader
            Try
                baca.Read()
                TextBox2.Text = baca.GetString(1)
                TextBox3.Text = baca.GetString(2)
                RichTextBox1.Text = baca.GetString(3)
                DateTimePicker1.Text = baca.GetDateTime(4)
                DateTimePicker2.Text = baca.GetDateTime(5)
                TextBox4.Text = baca.GetValue(6)
            Catch ex As Exception
                MsgBox("Data Tidak Di Temukan", MsgBoxStyle.Critical, "Errors")
                TextBox1.Focus()

            End Try
        End If
    End Sub

    Private Sub FTKblbuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil("")
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        RichTextBox1.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        TextBox4.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Attention")
            TextBox1.Focus()
        Else
            konek_db()
            Dim pinjam As New OleDb.OleDbCommand("Insert Into kembali values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & _
                                                 TextBox3.Text & "','" & RichTextBox1.Text & "','" & DateTimePicker1.Text & "','" & _
                                                 DateTimePicker2.Text & "','" & TextBox4.Text & "')")
            pinjam.Connection = koneksi
            pinjam.ExecuteNonQuery()
            Try

                Dim x As Integer
                x = TextBox4.Text
                Dim update_stock As New OleDb.OleDbCommand("Update buku set stock = stock + '" & x & "' Where kode_buku='" & TextBox3.Text & "'", koneksi)
                update_stock.ExecuteNonQuery()

                Dim hapus_data As New OleDb.OleDbCommand("Delete From pinjam where kode_anggota = '" & TextBox1.Text & "'", koneksi)
                hapus_data.ExecuteNonQuery()

                MsgBox("Terimakasih Telah Mengembalikan Buku", MsgBoxStyle.Information, "Sukses")
                tampil("")
                TextBox1.Focus()
            Catch ex As Exception
                MsgBox("Failed", MsgBoxStyle.Critical, "Errors")
                TextBox1.Focus()
            End Try


        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class