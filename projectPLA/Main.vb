Imports System.Data
Imports System.Data.OleDb
Public Class Main

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Apakah Anda Yakin...?", "Logout", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            koneksi.Close()
            Login.TextBox1.Clear()
            Login.TextBox2.Clear()
            Login.TextBox1.Focus()
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub DataAnggotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataAnggotaToolStripMenuItem.Click
        FDAnggota.Show()

    End Sub

    Private Sub DataBukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBukuToolStripMenuItem.Click
        FDBuku.Show()

    End Sub

    Private Sub DataUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataUserToolStripMenuItem.Click
        FDUser.Show()

    End Sub

    Private Sub DataPeminjamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPeminjamToolStripMenuItem.Click
        FDPinjam.Show()

    End Sub

    Private Sub KembalikanBukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KembalikanBukuToolStripMenuItem.Click
        FTKbuku.Show()

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LaporanAnggotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanAnggotaToolStripMenuItem.Click
        LAnggota.Show()

    End Sub

    Private Sub LaporanPeminjamanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPeminjamanToolStripMenuItem.Click
        LPinjam.Show()

    End Sub

    Private Sub SearchBukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBukuToolStripMenuItem.Click
        SBuku.Show()

    End Sub

    Private Sub AboutMeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMeToolStripMenuItem.Click
        AboutMe.Show()

    End Sub

    Private Sub PinjamBukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PinjamBukuToolStripMenuItem.Click
        FTPBuku.Show()

    End Sub
End Class