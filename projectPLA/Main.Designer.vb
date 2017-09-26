<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPeminjamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PinjamBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KembalikanBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPeminjamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.SearchBukuToolStripMenuItem, Me.AboutMeToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(447, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataAnggotaToolStripMenuItem, Me.DataBukuToolStripMenuItem, Me.DataUserToolStripMenuItem, Me.DataPeminjamToolStripMenuItem})
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.DataMasterToolStripMenuItem.Text = "Data Master"
        '
        'DataAnggotaToolStripMenuItem
        '
        Me.DataAnggotaToolStripMenuItem.Name = "DataAnggotaToolStripMenuItem"
        Me.DataAnggotaToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DataAnggotaToolStripMenuItem.Text = "Data Anggota"
        '
        'DataBukuToolStripMenuItem
        '
        Me.DataBukuToolStripMenuItem.Name = "DataBukuToolStripMenuItem"
        Me.DataBukuToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DataBukuToolStripMenuItem.Text = "Data Buku"
        '
        'DataUserToolStripMenuItem
        '
        Me.DataUserToolStripMenuItem.Name = "DataUserToolStripMenuItem"
        Me.DataUserToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DataUserToolStripMenuItem.Text = "Data User"
        '
        'DataPeminjamToolStripMenuItem
        '
        Me.DataPeminjamToolStripMenuItem.Name = "DataPeminjamToolStripMenuItem"
        Me.DataPeminjamToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DataPeminjamToolStripMenuItem.Text = "Data Peminjam"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PinjamBukuToolStripMenuItem, Me.KembalikanBukuToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PinjamBukuToolStripMenuItem
        '
        Me.PinjamBukuToolStripMenuItem.Name = "PinjamBukuToolStripMenuItem"
        Me.PinjamBukuToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PinjamBukuToolStripMenuItem.Text = "Pinjam Buku"
        '
        'KembalikanBukuToolStripMenuItem
        '
        Me.KembalikanBukuToolStripMenuItem.Name = "KembalikanBukuToolStripMenuItem"
        Me.KembalikanBukuToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.KembalikanBukuToolStripMenuItem.Text = "Kembalikan Buku"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanAnggotaToolStripMenuItem, Me.LaporanPeminjamanToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanAnggotaToolStripMenuItem
        '
        Me.LaporanAnggotaToolStripMenuItem.Name = "LaporanAnggotaToolStripMenuItem"
        Me.LaporanAnggotaToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.LaporanAnggotaToolStripMenuItem.Text = "Laporan Anggota"
        '
        'LaporanPeminjamanToolStripMenuItem
        '
        Me.LaporanPeminjamanToolStripMenuItem.Name = "LaporanPeminjamanToolStripMenuItem"
        Me.LaporanPeminjamanToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.LaporanPeminjamanToolStripMenuItem.Text = "Laporan Peminjaman"
        '
        'SearchBukuToolStripMenuItem
        '
        Me.SearchBukuToolStripMenuItem.Name = "SearchBukuToolStripMenuItem"
        Me.SearchBukuToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.SearchBukuToolStripMenuItem.Text = "Search Buku"
        '
        'AboutMeToolStripMenuItem
        '
        Me.AboutMeToolStripMenuItem.Name = "AboutMeToolStripMenuItem"
        Me.AboutMeToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.AboutMeToolStripMenuItem.Text = "About Me"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(447, 234)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 261)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataAnggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPeminjamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PinjamBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KembalikanBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPeminjamanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanAnggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutMeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
