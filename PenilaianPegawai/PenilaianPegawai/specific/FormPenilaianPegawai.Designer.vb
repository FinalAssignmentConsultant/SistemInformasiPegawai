<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenilaianPegawai
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
        Me.components = New System.ComponentModel.Container
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUnitKerja = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PegawaiBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Project.DataSet
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.StatusAbsensiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbsensiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PegawailaporanBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BulanBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TahunBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Project.DataSet
        Me.DetailLaporandetailLaporanKapabilBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetailLaporanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PegawailaporanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PegawaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Unit_kerjaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BulanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TahunBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PegawaiTableAdapter = New Project.DataSetTableAdapters.PegawaiTableAdapter
        Me.TableAdapterManager = New Project.DataSetTableAdapters.TableAdapterManager
        Me.AbsensiTableAdapter = New Project.DataSetTableAdapters.AbsensiTableAdapter
        Me.Status_absensiTableAdapter = New Project.DataSetTableAdapters.Status_AbsensiTableAdapter
        Me.Unit_kerjaTableAdapter = New Project.DataSetTableAdapters.Unit_KerjaTableAdapter
        Me.DetailLaporandetailLaporanKapabilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PegawaiBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusAbsensiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbsensiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PegawailaporanBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BulanBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TahunBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLaporandetailLaporanKapabilBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLaporanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PegawailaporanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Unit_kerjaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BulanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TahunBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLaporandetailLaporanKapabilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtUnitKerja)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1033, 135)
        Me.Panel1.TabIndex = 9
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.Location = New System.Drawing.Point(951, 106)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 18
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(195, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 51)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Pilih unit kerja yang akan dinilai pegawainya, kemudian pada data pegawai klik na" & _
            "ma pegawai yang akan dicatat absensi hariannya dan juga penilaiannya."
        '
        'txtUnitKerja
        '
        Me.txtUnitKerja.Location = New System.Drawing.Point(198, 32)
        Me.txtUnitKerja.Name = "txtUnitKerja"
        Me.txtUnitKerja.ReadOnly = True
        Me.txtUnitKerja.Size = New System.Drawing.Size(162, 20)
        Me.txtUnitKerja.TabIndex = 16
        Me.txtUnitKerja.Text = "<<Klik disini>>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Pilih Unit Kerja"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project.My.Resources.Resources.report_user
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PegawaiBindingSource1
        '
        Me.PegawaiBindingSource1.DataMember = "pegawai"
        Me.PegawaiBindingSource1.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.77327!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.22673!))
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 135)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1033, 422)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'StatusAbsensiBindingSource
        '
        Me.StatusAbsensiBindingSource.DataMember = "status absensi"
        Me.StatusAbsensiBindingSource.DataSource = Me.DataSet
        '
        'AbsensiBindingSource
        '
        Me.AbsensiBindingSource.DataMember = "laporanabsensi"
        Me.AbsensiBindingSource.DataSource = Me.PegawailaporanBindingSource1
        '
        'PegawailaporanBindingSource1
        '
        Me.PegawailaporanBindingSource1.DataMember = "pegawailaporan"
        Me.PegawailaporanBindingSource1.DataSource = Me.PegawaiBindingSource1
        '
        'BulanBindingSource1
        '
        Me.BulanBindingSource1.DataMember = "bulan"
        Me.BulanBindingSource1.DataSource = Me.DataSet
        '
        'TahunBindingSource1
        '
        Me.TahunBindingSource1.DataMember = "Tahun"
        Me.TahunBindingSource1.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetailLaporandetailLaporanKapabilBindingSource1
        '
        Me.DetailLaporandetailLaporanKapabilBindingSource1.DataMember = "detail laporandetail laporan kapabil"
        Me.DetailLaporandetailLaporanKapabilBindingSource1.DataSource = Me.DetailLaporanBindingSource
        '
        'DetailLaporanBindingSource
        '
        Me.DetailLaporanBindingSource.DataMember = "detail laporan"
        Me.DetailLaporanBindingSource.DataSource = Me.DataSet
        '
        'PegawailaporanBindingSource
        '
        Me.PegawailaporanBindingSource.DataMember = "pegawailaporan"
        Me.PegawailaporanBindingSource.DataSource = Me.PegawaiBindingSource
        '
        'PegawaiBindingSource
        '
        Me.PegawaiBindingSource.DataMember = "pegawai"
        Me.PegawaiBindingSource.DataSource = Me.DataSet
        '
        'Unit_kerjaBindingSource
        '
        Me.Unit_kerjaBindingSource.DataMember = "unit kerja"
        Me.Unit_kerjaBindingSource.DataSource = Me.DataSet
        '
        'BulanBindingSource
        '
        Me.BulanBindingSource.DataMember = "bulan"
        Me.BulanBindingSource.DataSource = Me.DataSet
        '
        'TahunBindingSource
        '
        Me.TahunBindingSource.DataMember = "Tahun"
        Me.TahunBindingSource.DataSource = Me.DataSet
        '
        'PegawaiTableAdapter
        '
        Me.PegawaiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbsensiTableAdapter = Me.AbsensiTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KapabilitasTableAdapter = Nothing
        Me.TableAdapterManager.KedisiplinanTableAdapter = Nothing
        Me.TableAdapterManager.KinerjaTableAdapter = Nothing
        Me.TableAdapterManager.Komponen_KapabilTableAdapter = Nothing
        Me.TableAdapterManager.Komponen_PenilaianTableAdapter = Nothing
        Me.TableAdapterManager.PegawaiTableAdapter = Me.PegawaiTableAdapter
        Me.TableAdapterManager.PemakaiTableAdapter = Nothing
        Me.TableAdapterManager.Status_AbsensiTableAdapter = Me.Status_absensiTableAdapter
        Me.TableAdapterManager.Unit_KerjaTableAdapter = Me.Unit_kerjaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Project.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AbsensiTableAdapter
        '
        Me.AbsensiTableAdapter.ClearBeforeFill = True
        '
        'Status_absensiTableAdapter
        '
        Me.Status_absensiTableAdapter.ClearBeforeFill = True
        '
        'Unit_kerjaTableAdapter
        '
        Me.Unit_kerjaTableAdapter.ClearBeforeFill = True
        '
        'DetailLaporandetailLaporanKapabilBindingSource
        '
        Me.DetailLaporandetailLaporanKapabilBindingSource.DataMember = "detail laporandetail laporan kapabil"
        Me.DetailLaporandetailLaporanKapabilBindingSource.DataSource = Me.DetailLaporanBindingSource
        '
        'FormPenilaianPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 557)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormPenilaianPegawai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Penilaian Pegawai"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PegawaiBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusAbsensiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbsensiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PegawailaporanBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BulanBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TahunBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLaporandetailLaporanKapabilBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLaporanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PegawailaporanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Unit_kerjaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BulanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TahunBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLaporandetailLaporanKapabilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    ' Friend WithEvents PesertaTableAdapter As Project.DataSetTableAdapters.PesertaTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataSet As Project.DataSet
    Friend WithEvents PegawaiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PegawaiTableAdapter As Project.DataSetTableAdapters.pegawaiTableAdapter
    Friend WithEvents TableAdapterManager As Project.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Unit_kerjaTableAdapter As Project.DataSetTableAdapters.unit_kerjaTableAdapter
    Friend WithEvents Unit_kerjaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    'Friend WithEvents BulanTableAdapter As Project.DataSetTableAdapters.bulanTableAdapter
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BulanBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents TahunTableAdapter As Project.DataSetTableAdapters.TahunTableAdapter
    Friend WithEvents TahunBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtUnitKerja As System.Windows.Forms.TextBox
    'Friend WithEvents Absensi_detailTableAdapter As Project.DataSetTableAdapters.absensi_detailTableAdapter
    Friend WithEvents PegawaiBindingSource1 As System.Windows.Forms.BindingSource
    ' Friend WithEvents LaporanTableAdapter As Project.DataSetTableAdapters.laporanTableAdapter
    Friend WithEvents PegawailaporanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PegawailaporanBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AbsensiTableAdapter As Project.DataSetTableAdapters.absensiTableAdapter
    Friend WithEvents AbsensiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Status_absensiTableAdapter As Project.DataSetTableAdapters.status_absensiTableAdapter
    Friend WithEvents StatusAbsensiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BulanBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Project.DataSet
    Friend WithEvents TahunBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    'Friend WithEvents Detail_laporanTableAdapter As Project.DataSetTableAdapters.detail_laporanTableAdapter
    Friend WithEvents DetailLaporanBindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents Detail_laporan_kapabilTableAdapter As Project.DataSetTableAdapters.detail_laporan_kapabilTableAdapter
    Friend WithEvents DetailLaporandetailLaporanKapabilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DetailLaporandetailLaporanKapabilBindingSource1 As System.Windows.Forms.BindingSource
End Class
