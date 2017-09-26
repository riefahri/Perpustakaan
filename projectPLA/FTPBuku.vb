Imports System.Data
Imports System.Data.OleDb
Public Class FTPBuku
    Sub tampil(ByVal data As String)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        RichTextBox1.Clear()
        DateTimePicker1.Value = Today
        DateTimePicker2.Value = Today
        TextBox5.Clear()

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
    Private Sub FTPBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox5.Visible = False
        TextBox2.Enabled = False
        RichTextBox1.Enabled = False
        TextBox1.Focus()
        tampil("")
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            konek_db()
            Dim cari As New OleDb.OleDbCommand("Select * From anggota where kode_anggota='" & TextBox1.Text & "'")
            Dim baca As OleDb.OleDbDataReader
            cari.Connection = koneksi
            baca = cari.ExecuteReader
            Try
                baca.Read()
                TextBox2.Text = baca.GetString(1)

            Catch ex As Exception
                MsgBox("Data Tidak Di Temukan", MsgBoxStyle.Critical, "Errors")
                TextBox1.Focus()

            End Try
        End If
    End Sub

    Private Sub TextBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Enter

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            konek_db()
            Dim cari As New OleDb.OleDbCommand("Select * From buku where kode_buku='" & TextBox3.Text & "'")
            Dim baca As OleDb.OleDbDataReader
            cari.Connection = koneksi
            baca = cari.ExecuteReader
            Try
                baca.Read()
                RichTextBox1.Text = baca.GetString(1)
                TextBox5.Text = baca.GetValue(5)
            Catch ex As Exception
                MsgBox("Data Tidak Di Temukan", MsgBoxStyle.Critical, "Errors")
                TextBox3.Focus()

            End Try
        End If

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            RichTextBox1.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub TextBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Attention")
            TextBox1.Focus()
        ElseIf TextBox5.Text = "" Then
            MsgBox("Maaf Stock Buku Habis ", MsgBoxStyle.Critical, "Information")
        ElseIf TextBox4.Text > TextBox5.Text Then
            MsgBox("Maaf Stock Buku Hanya " & TextBox5.Text & "", MsgBoxStyle.Critical, "Information")
        Else


            konek_db()
            Dim pinjam As New OleDb.OleDbCommand("Insert Into pinjam values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & _
                                                 TextBox3.Text & "','" & RichTextBox1.Text & "','" & DateTimePicker1.Text & "','" & _
                                                 DateTimePicker2.Text & "','" & TextBox4.Text & "')")
            pinjam.Connection = koneksi

            Try
                pinjam.ExecuteNonQuery()

                Dim x As Integer
                x = TextBox4.Text
                Dim update_stock As New OleDb.OleDbCommand("Update buku set stock = stock - '" & x & "' Where kode_buku='" & TextBox3.Text & "'", koneksi)
                update_stock.ExecuteNonQuery()

                MsgBox("Terimakasih Telah Meminjam Buku", MsgBoxStyle.Information, "Sukses")
                tampil("")
                TextBox1.Focus()
            Catch ex As Exception
                MsgBox("Anda Belum Melakukan Pengembalian Buku", MsgBoxStyle.Critical, "Message")
                TextBox1.Focus()
            End Try
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox3.Text = "" Then
            MsgBox("Masukkan Kode Buku Yang Akan Di Cari", MsgBoxStyle.Critical, "Attention")
        Else
            'Cari Data
            konek_db()
            Dim data As String = "Where kode_buku like'%" & TextBox1.Text & "%'"
            MsgBox("Data Di Temukan", MsgBoxStyle.Information, "Information")
            tampil(data)

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tampil("")
    End Sub

End Class