Public Class Login
    Public cmd As OleDb.OleDbCommand
    Public rd As OleDb.OleDbDataReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        konek_db()
        cmd = New OleDb.OleDbCommand("select * from users where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", koneksi)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Me.Visible = False
            Main.Show()

            If level.Text = "Admin" Then
                Main.LaporanToolStripMenuItem.Visible = True
                Main.TransaksiToolStripMenuItem.Visible = False
                Main.PinjamBukuToolStripMenuItem.Visible = False
                Main.KembalikanBukuToolStripMenuItem.Visible = False
                Main.LaporanPeminjamanToolStripMenuItem.Visible = True
                Main.DataUserToolStripMenuItem.Visible = True
                Main.DataPeminjamToolStripMenuItem.Visible = True
                Main.DataBukuToolStripMenuItem.Visible = True
                Main.DataAnggotaToolStripMenuItem.Visible = True
                Main.SearchBukuToolStripMenuItem.Visible = False
                Main.LogoutToolStripMenuItem.Visible = True
            ElseIf level.Text = "Petugas" Then
                Main.TransaksiToolStripMenuItem.Visible = True
                Main.LaporanToolStripMenuItem.Visible = False
                Main.PinjamBukuToolStripMenuItem.Visible = True
                Main.KembalikanBukuToolStripMenuItem.Visible = True
                Main.LaporanPeminjamanToolStripMenuItem.Visible = False
                Main.DataUserToolStripMenuItem.Visible = False
                Main.DataPeminjamToolStripMenuItem.Visible = True
                Main.DataBukuToolStripMenuItem.Visible = True
                Main.DataAnggotaToolStripMenuItem.Visible = True
                Main.SearchBukuToolStripMenuItem.Visible = False
                Main.LogoutToolStripMenuItem.Visible = True
            ElseIf level.Text = "Anggota" Then
                Main.DataBukuToolStripMenuItem.Visible = False
                Main.TransaksiToolStripMenuItem.Visible = False
                Main.LaporanToolStripMenuItem.Visible = False
                Main.PinjamBukuToolStripMenuItem.Visible = False
                Main.KembalikanBukuToolStripMenuItem.Visible = False
                Main.LaporanPeminjamanToolStripMenuItem.Visible = False
                Main.DataUserToolStripMenuItem.Visible = False
                Main.DataPeminjamToolStripMenuItem.Visible = False
                Main.DataBukuToolStripMenuItem.Visible = True
                Main.DataAnggotaToolStripMenuItem.Visible = False
                Main.SearchBukuToolStripMenuItem.Visible = True
                Main.LogoutToolStripMenuItem.Visible = True

            End If
        Else
            MsgBox("Username or Password is Wrong,Please Try Again")
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        konek_db()
        Dim pilih As New OleDb.OleDbCommand("Select * From users where username = '" & TextBox1.Text & "'")
        Dim reader As OleDb.OleDbDataReader
        pilih.Connection = koneksi
        reader = pilih.ExecuteReader
        Try
            If reader.Read() Then
                level.Text = reader.GetString(2)
            Else
                level.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(Keys.Tab) Then
            konek_db()
            Dim cari As New OleDb.OleDbCommand("Select * From users where username='" & TextBox1.Text & "'")
            Dim baca As OleDb.OleDbDataReader
            cari.Connection = koneksi
            baca = cari.ExecuteReader
            Try
                baca.Read()
                level.Text = baca.GetString(2)
            Catch ex As Exception
                MsgBox("Data Tidak Di Temukan", MsgBoxStyle.Critical, "Errors")

            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Untuk Login Anggota Untuk Melihat / Mencari Buku, Silahkan Gunakan Username 'member' dan Password 'member'", MsgBoxStyle.Information, "INFO")
        TextBox1.Focus()
    End Sub
End Class
