Imports System.Data
Imports System.Data.OleDb
Public Class FDAnggota
    Sub tampil_data(ByVal data As String)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        DateTimePicker1.Value = Today
        ComboBox1.Text = "--- Pilih Satu ---"
        ListView1.Items.Clear()

        konek_db()
        Dim perintah As New OleDb.OleDbCommand("Select * From anggota " & data & "")
        Dim baca As OleDb.OleDbDataReader
        perintah.Connection = koneksi
        baca = perintah.ExecuteReader

        Dim i As Integer = 0
        Do While baca.Read()
            ListView1.Items.Add(baca!kode_anggota)
            ListView1.Items(i).SubItems.Add(baca!nama_anggota)
            ListView1.Items(i).SubItems.Add(baca!alamat)
            ListView1.Items(i).SubItems.Add(baca!tgl_lahir)
            ListView1.Items(i).SubItems.Add(baca!jenis_kelamin)
            i = i + 1
        Loop
    End Sub
    Private Sub FDAnggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil_data("")
    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        TextBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text
        TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text
        TextBox3.Text = ListView1.SelectedItems(0).SubItems(2).Text
        DateTimePicker1.Text = ListView1.SelectedItems(0).SubItems(3).Text
        ComboBox1.Text = ListView1.SelectedItems(0).SubItems(4).Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Maaf, Data Belum Lengkap", MsgBoxStyle.Critical, "Attention")
            TextBox1.Focus()
        Else
            konek_db()
            Dim simpan As New OleDb.OleDbCommand("Insert Into anggota values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & _
                                                TextBox3.Text & "','" & DateTimePicker1.Text & "','" & ComboBox1.Text & "')")
            simpan.Connection = koneksi
            Try
                simpan.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Tambah", MsgBoxStyle.Information, "Sukses")
                tampil_data("")
            Catch ex As Exception
                MsgBox("Failed", MsgBoxStyle.Critical, "Errors")
                TextBox1.Focus()

            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If TextBox1.Text = "" Then
            MsgBox("Pilih Data Dulu", MsgBoxStyle.Critical, "Attention")
            TextBox1.Focus()
        Else
            konek_db()
            Dim update As New OleDb.OleDbCommand("Update anggota set nama_anggota='" & TextBox2.Text & "', alamat='" & _
                                                TextBox3.Text & "', tgl_lahir='" & DateTimePicker1.Text & "', jenis_kelamin='" & _
                                                ComboBox1.Text & "' Where kode_anggota='" & TextBox1.Text & "'")
            update.Connection = koneksi
            Try
                update.ExecuteNonQuery()
                MsgBox("Update Anggota Berhasil", MsgBoxStyle.Information, "Sukses")
                tampil_data("")
            Catch ex As Exception
                MsgBox("Failed", MsgBoxStyle.Critical, "Errors")
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan Kode Anggota Yang Akan Di Cari", MsgBoxStyle.Critical, "Attention")
        Else
            'Cari Data
            konek_db()
            Dim data As String = "Where kode_anggota like'%" & TextBox1.Text & "%'"
            MsgBox("Data Di Temukan", MsgBoxStyle.Information, "Information")
            tampil_data(data)

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan Kode Anggota Terlebih Dahulu", MsgBoxStyle.Critical, "Attention")
        Else

            'Hapus Data
            konek_db()
            If MessageBox.Show("Apakah Anda Yakin Menghapus '" & TextBox1.Text & "'?", "Hapus Data", MessageBoxButtons.YesNo) = "" & _
            Windows.Forms.DialogResult.Yes Then
                Dim hapus As New OleDb.OleDbCommand("Delete From anggota where kode_anggota = '" & TextBox1.Text & "'")
                hapus.Connection = koneksi
                Try
                    hapus.ExecuteNonQuery()
                    MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.Information, "Sukses")
                    tampil_data("")
                Catch ex As Exception
                    MsgBox("Maaf, Kode Anggota Tidak Di Temukan", MsgBoxStyle.Critical, "Errors")
                    TextBox1.Focus()
                End Try
            End If
        End If
    End Sub
End Class