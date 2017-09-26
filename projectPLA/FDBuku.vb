Imports System.Data
Imports System.Data.OleDb
Public Class FDBuku
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

    Private Sub FDBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil_data("")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Warning")
        Else
            konek_db()
            Dim simpan As New OleDb.OleDbCommand("Insert Into buku values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & _
                                                 TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & _
                                                 TextBox6.Text & "')")
            simpan.Connection = koneksi
            Try
                simpan.ExecuteNonQuery()
                MsgBox("Buku Berhasil Di Tambah", MsgBoxStyle.Information, "Sukses")
                tampil_data("")

            Catch ex As Exception
                MsgBox("Failed", MsgBoxStyle.Critical, "Errors")
                TextBox1.Focus()
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan Kode Buku / Pilih Buku yang Akan di Update", MsgBoxStyle.Critical, "Attention")
        Else
            konek_db()
            Dim update As New OleDb.OleDbCommand("Update buku set judul_buku='" & TextBox2.Text & "', pengarang='" & _
                                                 TextBox3.Text & "', penerbit='" & TextBox4.Text & "', tahun_terbit='" & _
                                                 TextBox5.Text & "', stock= '" & TextBox6.Text & "' Where kode_buku='" & TextBox1.Text & "'")
            update.Connection = koneksi
            Try
                update.ExecuteNonQuery()
                MsgBox("Update Buku Berhasil", MsgBoxStyle.Information, "Sukses")
                tampil_data("")
            Catch ex As Exception
                MsgBox("Failed", MsgBoxStyle.Critical, "Errors")
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan Kode Buku Yang Akan Di Cari", MsgBoxStyle.Critical, "Attention")
        Else
            konek_db()
            Dim data As String = "Where kode_buku like'%" & TextBox1.Text & "%'"
            MsgBox("Data Di Temukan", MsgBoxStyle.Information, "Information")
            tampil_data(data)

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan Kode Buku Dulu", MsgBoxStyle.Critical, "Attention")
        Else
            konek_db()
            If MessageBox.Show("Apakah Anda Yakin Menghapus '" & TextBox1.Text & "'?", "Hapus Data", MessageBoxButtons.YesNo) = "" & _
            Windows.Forms.DialogResult.Yes Then
                Dim hapus As New OleDb.OleDbCommand("Delete From buku where kode_buku = '" & TextBox1.Text & "'")
                hapus.Connection = koneksi
                Try
                    hapus.ExecuteNonQuery()
                    MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.Information, "Sukses")
                    tampil_data("")
                Catch ex As Exception
                    MsgBox("Kode Buku Tidak Di Temukan", MsgBoxStyle.Critical, "Errors")
                    TextBox1.Focus()
                End Try
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        tampil_data("")
    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        TextBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text
        TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text
        TextBox3.Text = ListView1.SelectedItems(0).SubItems(2).Text
        TextBox4.Text = ListView1.SelectedItems(0).SubItems(3).Text
        TextBox5.Text = ListView1.SelectedItems(0).SubItems(4).Text
        TextBox6.Text = ListView1.SelectedItems(0).SubItems(5).Text
    End Sub

End Class