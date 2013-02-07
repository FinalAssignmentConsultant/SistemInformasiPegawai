<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbsensi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAbsensi))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.AbsensiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AbsensiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Project.DataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.AbsensiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.AbsensiDataGridView = New System.Windows.Forms.DataGridView
        Me.StatusAbsensiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboKejujuran = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboKesetiaan = New System.Windows.Forms.ComboBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.gridKapabil = New System.Windows.Forms.DataGridView
        Me.KomponenKapabil = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nilai = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblNamaPegawai = New System.Windows.Forms.Label
        Me.cboUnitKerja = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboTahun = New System.Windows.Forms.ComboBox
        Me.cboBulan = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPegawai = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.AbsensiTableAdapter = New Project.DataSetTableAdapters.AbsensiTableAdapter
        Me.TableAdapterManager = New Project.DataSetTableAdapters.TableAdapterManager
        Me.Status_AbsensiTableAdapter = New Project.DataSetTableAdapters.Status_AbsensiTableAdapter
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hari = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn
        CType(Me.AbsensiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AbsensiBindingNavigator.SuspendLayout()
        CType(Me.AbsensiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbsensiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusAbsensiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.gridKapabil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AbsensiBindingNavigator
        '
        Me.AbsensiBindingNavigator.AddNewItem = Nothing
        Me.AbsensiBindingNavigator.BindingSource = Me.AbsensiBindingSource
        Me.AbsensiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AbsensiBindingNavigator.DeleteItem = Nothing
        Me.AbsensiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.AbsensiBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.AbsensiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AbsensiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AbsensiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AbsensiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AbsensiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AbsensiBindingNavigator.Name = "AbsensiBindingNavigator"
        Me.AbsensiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AbsensiBindingNavigator.Size = New System.Drawing.Size(707, 25)
        Me.AbsensiBindingNavigator.TabIndex = 0
        Me.AbsensiBindingNavigator.Text = "BindingNavigator1"
        '
        'AbsensiBindingSource
        '
        Me.AbsensiBindingSource.DataMember = "Absensi"
        Me.AbsensiBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.Locale = New System.Globalization.CultureInfo("id-ID")
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AbsensiBindingNavigatorSaveItem
        '
        Me.AbsensiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AbsensiBindingNavigatorSaveItem.Image = CType(resources.GetObject("AbsensiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AbsensiBindingNavigatorSaveItem.Name = "AbsensiBindingNavigatorSaveItem"
        Me.AbsensiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AbsensiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Project.My.Resources.Resources.door_in
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripButton1.Text = "Tutup"
        '
        'AbsensiDataGridView
        '
        Me.AbsensiDataGridView.AllowUserToAddRows = False
        Me.AbsensiDataGridView.AutoGenerateColumns = False
        Me.AbsensiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AbsensiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.Hari, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6})
        Me.AbsensiDataGridView.DataSource = Me.AbsensiBindingSource
        Me.AbsensiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AbsensiDataGridView.Location = New System.Drawing.Point(3, 190)
        Me.AbsensiDataGridView.Name = "AbsensiDataGridView"
        Me.AbsensiDataGridView.Size = New System.Drawing.Size(701, 221)
        Me.AbsensiDataGridView.TabIndex = 1
        '
        'StatusAbsensiBindingSource
        '
        Me.StatusAbsensiBindingSource.DataMember = "Status Absensi"
        Me.StatusAbsensiBindingSource.DataSource = Me.DataSet
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 707.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AbsensiDataGridView, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 187.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(707, 414)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(701, 181)
        Me.Panel1.TabIndex = 22
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TabControl1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(701, 181)
        Me.TableLayoutPanel2.TabIndex = 33
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(303, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(395, 175)
        Me.TabControl1.TabIndex = 36
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cboKejujuran)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cboKesetiaan)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(387, 149)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Kesetiaan dan Kejujuran"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Kejujuran"
        '
        'cboKejujuran
        '
        Me.cboKejujuran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKejujuran.FormattingEnabled = True
        Me.cboKejujuran.Items.AddRange(New Object() {"Tidak ada teguran tertulis", "Teguran lesan ke 2", "Ada teguran tertulis"})
        Me.cboKejujuran.Location = New System.Drawing.Point(83, 38)
        Me.cboKejujuran.Name = "cboKejujuran"
        Me.cboKejujuran.Size = New System.Drawing.Size(238, 21)
        Me.cboKejujuran.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kesetiaan"
        '
        'cboKesetiaan
        '
        Me.cboKesetiaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKesetiaan.FormattingEnabled = True
        Me.cboKesetiaan.Items.AddRange(New Object() {"Tidak ada teguran tertulis", "Teguran lesan ke 2", "Ada teguran tertulis"})
        Me.cboKesetiaan.Location = New System.Drawing.Point(83, 14)
        Me.cboKesetiaan.Name = "cboKesetiaan"
        Me.cboKesetiaan.Size = New System.Drawing.Size(238, 21)
        Me.cboKesetiaan.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gridKapabil)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(387, 149)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Kapabilitas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gridKapabil
        '
        Me.gridKapabil.AllowUserToAddRows = False
        Me.gridKapabil.AllowUserToDeleteRows = False
        Me.gridKapabil.AllowUserToOrderColumns = True
        Me.gridKapabil.AllowUserToResizeColumns = False
        Me.gridKapabil.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridKapabil.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.gridKapabil.BackgroundColor = System.Drawing.Color.White
        Me.gridKapabil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridKapabil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KomponenKapabil, Me.Nilai})
        Me.gridKapabil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridKapabil.Location = New System.Drawing.Point(3, 3)
        Me.gridKapabil.Name = "gridKapabil"
        Me.gridKapabil.Size = New System.Drawing.Size(381, 143)
        Me.gridKapabil.TabIndex = 0
        '
        'KomponenKapabil
        '
        Me.KomponenKapabil.HeaderText = "Komponen Kapabil"
        Me.KomponenKapabil.Name = "KomponenKapabil"
        Me.KomponenKapabil.Width = 200
        '
        'Nilai
        '
        Me.Nilai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nilai.HeaderText = "Nilai"
        Me.Nilai.Name = "Nilai"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblNamaPegawai)
        Me.Panel2.Controls.Add(Me.cboUnitKerja)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cboTahun)
        Me.Panel2.Controls.Add(Me.cboBulan)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtPegawai)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(294, 175)
        Me.Panel2.TabIndex = 35
        '
        'lblNamaPegawai
        '
        Me.lblNamaPegawai.AutoSize = True
        Me.lblNamaPegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaPegawai.Location = New System.Drawing.Point(97, 74)
        Me.lblNamaPegawai.Name = "lblNamaPegawai"
        Me.lblNamaPegawai.Size = New System.Drawing.Size(108, 16)
        Me.lblNamaPegawai.TabIndex = 40
        Me.lblNamaPegawai.Text = "Pilih karyawan"
        '
        'cboUnitKerja
        '
        Me.cboUnitKerja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnitKerja.FormattingEnabled = True
        Me.cboUnitKerja.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cboUnitKerja.Location = New System.Drawing.Point(100, 20)
        Me.cboUnitKerja.Name = "cboUnitKerja"
        Me.cboUnitKerja.Size = New System.Drawing.Size(162, 21)
        Me.cboUnitKerja.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Pilih Unit Kerja"
        '
        'cboTahun
        '
        Me.cboTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTahun.FormattingEnabled = True
        Me.cboTahun.Items.AddRange(New Object() {"2009", "2010", "2011"})
        Me.cboTahun.Location = New System.Drawing.Point(100, 123)
        Me.cboTahun.Name = "cboTahun"
        Me.cboTahun.Size = New System.Drawing.Size(162, 21)
        Me.cboTahun.TabIndex = 37
        '
        'cboBulan
        '
        Me.cboBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBulan.FormattingEnabled = True
        Me.cboBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cboBulan.Location = New System.Drawing.Point(100, 93)
        Me.cboBulan.Name = "cboBulan"
        Me.cboBulan.Size = New System.Drawing.Size(162, 21)
        Me.cboBulan.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Pilih Tahun"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Pilih Bulan"
        '
        'txtPegawai
        '
        Me.txtPegawai.Location = New System.Drawing.Point(100, 47)
        Me.txtPegawai.Name = "txtPegawai"
        Me.txtPegawai.ReadOnly = True
        Me.txtPegawai.Size = New System.Drawing.Size(162, 20)
        Me.txtPegawai.TabIndex = 33
        Me.txtPegawai.Text = "<<Klik disini>>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Pilih Pegawai"
        '
        'AbsensiTableAdapter
        '
        Me.AbsensiTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PegawaiTableAdapter = Nothing
        Me.TableAdapterManager.PemakaiTableAdapter = Nothing
        Me.TableAdapterManager.Status_AbsensiTableAdapter = Me.Status_AbsensiTableAdapter
        Me.TableAdapterManager.Unit_KerjaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Status_AbsensiTableAdapter
        '
        Me.Status_AbsensiTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tanggal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tanggal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'Hari
        '
        Me.Hari.HeaderText = "Hari, Tanggal"
        Me.Hari.Name = "Hari"
        Me.Hari.Width = 170
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "jam masuk"
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Jam Masuk"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "jam pulang"
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Jam Pulang"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ijin keluar kantor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Jumlah Jam Ijin Keluar Kantor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idstatusabsensi"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.StatusAbsensiBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "status absensi"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Status Absensi"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "idstatusabsensi"
        '
        'FormAbsensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 439)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.AbsensiBindingNavigator)
        Me.Name = "FormAbsensi"
        Me.Text = "Form Input Penilaian Pegawai"
        CType(Me.AbsensiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AbsensiBindingNavigator.ResumeLayout(False)
        Me.AbsensiBindingNavigator.PerformLayout()
        CType(Me.AbsensiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbsensiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusAbsensiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.gridKapabil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet As Project.DataSet
    Friend WithEvents AbsensiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AbsensiTableAdapter As Project.DataSetTableAdapters.AbsensiTableAdapter
    Friend WithEvents TableAdapterManager As Project.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AbsensiBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AbsensiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AbsensiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Status_AbsensiTableAdapter As Project.DataSetTableAdapters.Status_AbsensiTableAdapter
    Friend WithEvents StatusAbsensiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboKejujuran As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboKesetiaan As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblNamaPegawai As System.Windows.Forms.Label
    Friend WithEvents cboUnitKerja As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboTahun As System.Windows.Forms.ComboBox
    Friend WithEvents cboBulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPegawai As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gridKapabil As System.Windows.Forms.DataGridView
    Friend WithEvents KomponenKapabil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nilai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hari As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
