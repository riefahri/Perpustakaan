Imports System.Data
Imports System.Data.OleDb
Public Class FDUser
    Sub tampil(ByVal data As String)
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.Text = "--- Pilih Level User ---"

        ListView1.Items.Clear()
        konek_db()
        Dim perintah As New OleDb.OleDbCommand("select * From users")
        Dim baca As OleDb.OleDbDataReader
        perintah.Connection = koneksi
        baca = perintah.ExecuteReader

        Dim i As Integer = 0
        Do While baca.Read()
            ListView1.Items.Add(baca!username)
            ListView1.Items(i).SubItems.Add(baca!password)
            ListView1.Items(i).SubItems.Add(baca!level)
            i = i + 1
        Loop
    End Sub
    Private Sub FDUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil("")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data Belum Lengkpa", MsgBoxStyle.Critical, "Attention")
        Else
            konek_db()
            Dim simpan As New OleDb.OleDbCommand("Insert Into users Values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "')")
            simpan.Connection = koneksi
            Try
                simpan.ExecuteNonQuery()
                MsgBox("User Berhasil Di Tambah", MsgBoxStyle.Information, "Sukses")
                tampil("")
            Catch ex As Exception
                MsgBox("Failed", MsgBoxStyle.Critical, "Errror")
                TextBox1.Focus()
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan Username yang Akan di Update", MsgBoxStyle.Critical, "Attention")
            TextBox1.Focus()
        Else
            konek_db()
            Dim update As New OleDb.OleDbCommand("Update users set password='" & TextBox2.Text & "', level='" & ComboBox1.Text & "' Where username='" & TextBox1.Text & "'")
            update.Connection = koneksi
            Try
                update.ExecuteNonQuery()
                MsgBox("Update Password Berhasil", MsgBoxStyle.Information, "Sukses")
                tampil("")
            Catch ex As Exception
                MsgBox("Failed", MsgBoxStyle.Critical, "Errors")
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan Username", MsgBoxStyle.Critical, "Attention")
        Else
            konek_db()
            If MessageBox.Show("Apakah Anda Yakin Menghapus '" & TextBox1.Text & "'?", "Hapus Data", MessageBoxButtons.YesNo) = "" & _
            Windows.Forms.DialogResult.Yes Then
                Dim hapus As New OleDb.OleDbCommand("Delete From users where username = '" & TextBox1.Text & "'")
                hapus.Connection = koneksi
                Try
                    hapus.ExecuteNonQuery()
                    MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.Information, "Sukses")
                    tampil("")
                Catch ex As Exception
                    MsgBox("Username Tidak Di Temukan", MsgBoxStyle.Critical, "Errors")
                    TextBox1.Focus()
                End Try
            End If
        End If
    End Sub
End Class