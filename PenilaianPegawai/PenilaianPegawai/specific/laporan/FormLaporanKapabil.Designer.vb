<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanKapabil
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
        Me.LaporanKapabilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Project.DataSet
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.LaporanKapabilTableAdapter = New Project.DataSetTableAdapters.LaporanKapabilTableAdapter
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnProses = New System.Windows.Forms.Button
        Me.cboUnitKerja = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboTahun = New System.Windows.Forms.ComboBox
        Me.cboBulan = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.LaporanKapabilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LaporanKapabilBindingSource
        '
        Me.LaporanKapabilBindingSource.DataMember = "LaporanKapabil"
        Me.LaporanKapabilBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet_LaporanKapabil"
        ReportDataSource1.Value = Me.LaporanKapabilBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Project.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 136)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(745, 272)
        Me.ReportViewer1.TabIndex = 0
        '
        'LaporanKapabilTableAdapter
        '
        Me.LaporanKapabilTableAdapter.ClearBeforeFill = True
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(751, 411)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnProses)
        Me.Panel1.Controls.Add(Me.cboUnitKerja)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cboTahun)
        Me.Panel1.Controls.Add(Me.cboBulan)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 127)
        Me.Panel1.TabIndex = 1
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(98, 93)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 23)
        Me.btnProses.TabIndex = 51
        Me.btnProses.Text = "Tampilkan"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'cboUnitKerja
        '
        Me.cboUnitKerja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnitKerja.FormattingEnabled = True
        Me.cboUnitKerja.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cboUnitKerja.Location = New System.Drawing.Point(98, 9)
        Me.cboUnitKerja.Name = "cboUnitKerja"
        Me.cboUnitKerja.Size = New System.Drawing.Size(182, 21)
        Me.cboUnitKerja.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Pilih Unit Kerja"
        '
        'cboTahun
        '
        Me.cboTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTahun.FormattingEnabled = True
        Me.cboTahun.Items.AddRange(New Object() {"2009", "2010", "2011"})
        Me.cboTahun.Location = New System.Drawing.Point(98, 66)
        Me.cboTahun.Name = "cboTahun"
        Me.cboTahun.Size = New System.Drawing.Size(182, 21)
        Me.cboTahun.TabIndex = 40
        '
        'cboBulan
        '
        Me.cboBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBulan.FormattingEnabled = True
        Me.cboBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cboBulan.Location = New System.Drawing.Point(98, 36)
        Me.cboBulan.Name = "cboBulan"
        Me.cboBulan.Size = New System.Drawing.Size(182, 21)
        Me.cboBulan.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Pilih Tahun"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Pilih Bulan"
        '
        'FormLaporanKapabil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 411)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormLaporanKapabil"
        Me.Text = "FormLaporanKapabil"
        CType(Me.LaporanKapabilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LaporanKapabilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet As Project.DataSet
    Friend WithEvents LaporanKapabilTableAdapter As Project.DataSetTableAdapters.LaporanKapabilTableAdapter
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboTahun As System.Windows.Forms.ComboBox
    Friend WithEvents cboBulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboUnitKerja As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnProses As System.Windows.Forms.Button
End Class
