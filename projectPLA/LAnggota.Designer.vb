<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LAnggota
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.anggotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.plaDataSet = New projectPLA.plaDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.anggotaTableAdapter = New projectPLA.plaDataSetTableAdapters.anggotaTableAdapter()
        CType(Me.anggotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'anggotaBindingSource
        '
        Me.anggotaBindingSource.DataMember = "anggota"
        Me.anggotaBindingSource.DataSource = Me.plaDataSet
        '
        'plaDataSet
        '
        Me.plaDataSet.DataSetName = "plaDataSet"
        Me.plaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.DocumentMapWidth = 93
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.anggotaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "projectPLA.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(896, 421)
        Me.ReportViewer1.TabIndex = 0
        '
        'anggotaTableAdapter
        '
        Me.anggotaTableAdapter.ClearBeforeFill = True
        '
        'LAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 433)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "LAnggota"
        Me.Text = "LAnggota"
        CType(Me.anggotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents anggotaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents plaDataSet As projectPLA.plaDataSet
    Friend WithEvents anggotaTableAdapter As projectPLA.plaDataSetTableAdapters.anggotaTableAdapter
End Class
