<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanKinerja
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.LaporanKinerjaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Project.DataSet
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnProses = New System.Windows.Forms.Button
        Me.cboTahun = New System.Windows.Forms.ComboBox
        Me.cboBulan = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LaporanKinerjaTableAdapter = New Project.DataSetTableAdapters.LaporanKinerjaTableAdapter
        Me.LaporanKinerjaPerUnitKerjaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.LaporanKinerjaPerUnitKerjaTableAdapter = New Project.DataSetTableAdapters.LaporanKinerjaPerUnitKerjaTableAdapter
        CType(Me.LaporanKinerjaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.LaporanKinerjaPerUnitKerjaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LaporanKinerjaBindingSource
        '
        Me.LaporanKinerjaBindingSource.DataMember = "LaporanKinerja"
        Me.LaporanKinerjaBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnProses)
        Me.Panel1.Controls.Add(Me.cboTahun)
        Me.Panel1.Controls.Add(Me.cboBulan)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 108)
        Me.Panel1.TabIndex = 1
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(87, 75)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 23)
        Me.btnProses.TabIndex = 37
        Me.btnProses.Text = "Tampilkan"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'cboTahun
        '
        Me.cboTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTahun.FormattingEnabled = True
        Me.cboTahun.Items.AddRange(New Object() {"2009", "2010", "2011"})
        Me.cboTahun.Location = New System.Drawing.Point(87, 48)
        Me.cboTahun.Name = "cboTahun"
        Me.cboTahun.Size = New System.Drawing.Size(182, 21)
        Me.cboTahun.TabIndex = 36
        '
        'cboBulan
        '
        Me.cboBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBulan.FormattingEnabled = True
        Me.cboBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cboBulan.Location = New System.Drawing.Point(87, 18)
        Me.cboBulan.Name = "cboBulan"
        Me.cboBulan.Size = New System.Drawing.Size(182, 21)
        Me.cboBulan.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Pilih Tahun"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Pilih Bulan"
        '
        'LaporanKinerjaTableAdapter
        '
        Me.LaporanKinerjaTableAdapter.ClearBeforeFill = True
        '
        'LaporanKinerjaPerUnitKerjaBindingSource
        '
        Me.LaporanKinerjaPerUnitKerjaBindingSource.DataMember = "LaporanKinerjaPerUnitKerja"
        Me.LaporanKinerjaPerUnitKerjaBindingSource.DataSource = Me.DataSet
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ReportViewer1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(847, 397)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet_LaporanKinerja"
        ReportDataSource1.Value = Me.LaporanKinerjaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Project.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 117)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.Size = New System.Drawing.Size(841, 277)
        Me.ReportViewer1.TabIndex = 0
        '
        'LaporanKinerjaPerUnitKerjaTableAdapter
        '
        Me.LaporanKinerjaPerUnitKerjaTableAdapter.ClearBeforeFill = True
        '
        'FormLaporanKinerja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 397)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormLaporanKinerja"
        Me.Text = "FormLaporanKinerja"
        CType(Me.LaporanKinerjaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LaporanKinerjaPerUnitKerjaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents cboTahun As System.Windows.Forms.ComboBox
    Friend WithEvents cboBulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LaporanKinerjaTableAdapter As Project.DataSetTableAdapters.LaporanKinerjaTableAdapter
    Friend WithEvents LaporanKinerjaPerUnitKerjaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet As Project.DataSet
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LaporanKinerjaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LaporanKinerjaPerUnitKerjaTableAdapter As Project.DataSetTableAdapters.LaporanKinerjaPerUnitKerjaTableAdapter
End Class
