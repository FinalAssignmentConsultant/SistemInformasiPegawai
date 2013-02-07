<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProsesLaporan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnProses = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnCetakLaporan = New System.Windows.Forms.Button
        Me.cboTahun = New System.Windows.Forms.ComboBox
        Me.cboBulan = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.gridKinerja = New System.Windows.Forms.DataGridView
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitKerja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NIK = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ketepatan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pulang = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kehadiran = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ijin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Setia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jujur = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kapabilitas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Proaktif = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TunjanganMaksimum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JumlahTunjangan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Catatan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lstOutput = New System.Windows.Forms.ListBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.gridKinerja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(87, 66)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 23)
        Me.btnProses.TabIndex = 0
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(957, 537)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnCetakLaporan)
        Me.Panel1.Controls.Add(Me.cboTahun)
        Me.Panel1.Controls.Add(Me.cboBulan)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnProses)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 94)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(312, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Laporan Per Unit Kerja"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCetakLaporan
        '
        Me.btnCetakLaporan.Location = New System.Drawing.Point(312, 9)
        Me.btnCetakLaporan.Name = "btnCetakLaporan"
        Me.btnCetakLaporan.Size = New System.Drawing.Size(162, 23)
        Me.btnCetakLaporan.TabIndex = 33
        Me.btnCetakLaporan.Text = "Laporan Semua Unit Kerja"
        Me.btnCetakLaporan.UseVisualStyleBackColor = True
        '
        'cboTahun
        '
        Me.cboTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTahun.FormattingEnabled = True
        Me.cboTahun.Items.AddRange(New Object() {"2009", "2010", "2011"})
        Me.cboTahun.Location = New System.Drawing.Point(87, 39)
        Me.cboTahun.Name = "cboTahun"
        Me.cboTahun.Size = New System.Drawing.Size(182, 21)
        Me.cboTahun.TabIndex = 32
        '
        'cboBulan
        '
        Me.cboBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBulan.FormattingEnabled = True
        Me.cboBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cboBulan.Location = New System.Drawing.Point(87, 9)
        Me.cboBulan.Name = "cboBulan"
        Me.cboBulan.Size = New System.Drawing.Size(182, 21)
        Me.cboBulan.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Pilih Tahun"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Pilih Bulan"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 103)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(951, 431)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gridKinerja)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(943, 405)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Kinerja Pegawai"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gridKinerja
        '
        Me.gridKinerja.AllowUserToAddRows = False
        Me.gridKinerja.AllowUserToDeleteRows = False
        Me.gridKinerja.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridKinerja.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridKinerja.BackgroundColor = System.Drawing.Color.White
        Me.gridKinerja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridKinerja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.UnitKerja, Me.NIK, Me.Nama, Me.Ketepatan, Me.Pulang, Me.Kehadiran, Me.Ijin, Me.Setia, Me.Jujur, Me.Kapabilitas, Me.Proaktif, Me.TunjanganMaksimum, Me.JumlahTunjangan, Me.Catatan})
        Me.gridKinerja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridKinerja.Location = New System.Drawing.Point(3, 3)
        Me.gridKinerja.Name = "gridKinerja"
        Me.gridKinerja.ReadOnly = True
        Me.gridKinerja.Size = New System.Drawing.Size(937, 399)
        Me.gridKinerja.TabIndex = 0
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 30
        '
        'UnitKerja
        '
        Me.UnitKerja.HeaderText = "Unit Kerja"
        Me.UnitKerja.Name = "UnitKerja"
        Me.UnitKerja.ReadOnly = True
        '
        'NIK
        '
        Me.NIK.HeaderText = "NIK"
        Me.NIK.Name = "NIK"
        Me.NIK.ReadOnly = True
        Me.NIK.Width = 75
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama"
        Me.Nama.Name = "Nama"
        Me.Nama.ReadOnly = True
        Me.Nama.Width = 130
        '
        'Ketepatan
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Ketepatan.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ketepatan.HeaderText = "Ketepatan"
        Me.Ketepatan.Name = "Ketepatan"
        Me.Ketepatan.ReadOnly = True
        Me.Ketepatan.Width = 60
        '
        'Pulang
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Pulang.DefaultCellStyle = DataGridViewCellStyle3
        Me.Pulang.HeaderText = "Pulang"
        Me.Pulang.Name = "Pulang"
        Me.Pulang.ReadOnly = True
        Me.Pulang.Width = 60
        '
        'Kehadiran
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Kehadiran.DefaultCellStyle = DataGridViewCellStyle4
        Me.Kehadiran.HeaderText = "Kehadiran"
        Me.Kehadiran.Name = "Kehadiran"
        Me.Kehadiran.ReadOnly = True
        Me.Kehadiran.Width = 60
        '
        'Ijin
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Ijin.DefaultCellStyle = DataGridViewCellStyle5
        Me.Ijin.HeaderText = "Ijin"
        Me.Ijin.Name = "Ijin"
        Me.Ijin.ReadOnly = True
        Me.Ijin.Width = 60
        '
        'Setia
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Setia.DefaultCellStyle = DataGridViewCellStyle6
        Me.Setia.HeaderText = "Setia"
        Me.Setia.Name = "Setia"
        Me.Setia.ReadOnly = True
        Me.Setia.Width = 60
        '
        'Jujur
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Jujur.DefaultCellStyle = DataGridViewCellStyle7
        Me.Jujur.HeaderText = "Jujur"
        Me.Jujur.Name = "Jujur"
        Me.Jujur.ReadOnly = True
        Me.Jujur.Width = 60
        '
        'Kapabilitas
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Kapabilitas.DefaultCellStyle = DataGridViewCellStyle8
        Me.Kapabilitas.HeaderText = "Kapabilitas"
        Me.Kapabilitas.Name = "Kapabilitas"
        Me.Kapabilitas.ReadOnly = True
        Me.Kapabilitas.Width = 60
        '
        'Proaktif
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Proaktif.DefaultCellStyle = DataGridViewCellStyle9
        Me.Proaktif.HeaderText = "Proaktif"
        Me.Proaktif.Name = "Proaktif"
        Me.Proaktif.ReadOnly = True
        Me.Proaktif.Width = 60
        '
        'TunjanganMaksimum
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.TunjanganMaksimum.DefaultCellStyle = DataGridViewCellStyle10
        Me.TunjanganMaksimum.HeaderText = "Tunjangan Maksimum"
        Me.TunjanganMaksimum.Name = "TunjanganMaksimum"
        Me.TunjanganMaksimum.ReadOnly = True
        '
        'JumlahTunjangan
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.JumlahTunjangan.DefaultCellStyle = DataGridViewCellStyle11
        Me.JumlahTunjangan.HeaderText = "Jumlah Tunjangan"
        Me.JumlahTunjangan.Name = "JumlahTunjangan"
        Me.JumlahTunjangan.ReadOnly = True
        '
        'Catatan
        '
        Me.Catatan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Catatan.HeaderText = "Catatan"
        Me.Catatan.MinimumWidth = 100
        Me.Catatan.Name = "Catatan"
        Me.Catatan.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lstOutput)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(721, 405)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Output Proses"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(3, 3)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(715, 394)
        Me.lstOutput.TabIndex = 2
        '
        'FormProsesLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(957, 537)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormProsesLaporan"
        Me.Text = "Form Proses Laporan"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.gridKinerja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboTahun As System.Windows.Forms.ComboBox
    Friend WithEvents cboBulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents gridKinerja As System.Windows.Forms.DataGridView
    Friend WithEvents btnCetakLaporan As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitKerja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NIK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ketepatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pulang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kehadiran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ijin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Setia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jujur As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kapabilitas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proaktif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TunjanganMaksimum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahTunjangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Catatan As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
