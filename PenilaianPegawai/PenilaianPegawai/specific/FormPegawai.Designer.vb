<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPegawai
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
        Dim NIKLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim Tunjangan_MaxLabel As System.Windows.Forms.Label
        Dim IdunitkerjaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPegawai))
        Me.PegawaiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.PegawaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Project.DataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.PegawaiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.UnitKerjaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PegawaiTableAdapter = New Project.DataSetTableAdapters.PegawaiTableAdapter
        Me.TableAdapterManager = New Project.DataSetTableAdapters.TableAdapterManager
        Me.Unit_kerjaTableAdapter = New Project.DataSetTableAdapters.Unit_KerjaTableAdapter
        Me.PegawaiDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtNamaUnitKerja = New System.Windows.Forms.TextBox
        Me.IdunitkerjaTextBox = New System.Windows.Forms.TextBox
        Me.Tunjangan_MaxTextBox = New System.Windows.Forms.TextBox
        Me.NamaTextBox = New System.Windows.Forms.TextBox
        Me.NIKTextBox = New System.Windows.Forms.TextBox
        Me.UnitKerjaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        NIKLabel = New System.Windows.Forms.Label
        NamaLabel = New System.Windows.Forms.Label
        Tunjangan_MaxLabel = New System.Windows.Forms.Label
        IdunitkerjaLabel = New System.Windows.Forms.Label
        CType(Me.PegawaiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PegawaiBindingNavigator.SuspendLayout()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitKerjaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PegawaiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UnitKerjaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NIKLabel
        '
        NIKLabel.AutoSize = True
        NIKLabel.Location = New System.Drawing.Point(70, 24)
        NIKLabel.Name = "NIKLabel"
        NIKLabel.Size = New System.Drawing.Size(28, 13)
        NIKLabel.TabIndex = 0
        NIKLabel.Text = "NIK:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(60, 50)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 2
        NamaLabel.Text = "Nama:"
        '
        'Tunjangan_MaxLabel
        '
        Tunjangan_MaxLabel.AutoSize = True
        Tunjangan_MaxLabel.Location = New System.Drawing.Point(14, 76)
        Tunjangan_MaxLabel.Name = "Tunjangan_MaxLabel"
        Tunjangan_MaxLabel.Size = New System.Drawing.Size(84, 13)
        Tunjangan_MaxLabel.TabIndex = 4
        Tunjangan_MaxLabel.Text = "Tunjangan Max:"
        '
        'IdunitkerjaLabel
        '
        IdunitkerjaLabel.AutoSize = True
        IdunitkerjaLabel.Location = New System.Drawing.Point(40, 102)
        IdunitkerjaLabel.Name = "IdunitkerjaLabel"
        IdunitkerjaLabel.Size = New System.Drawing.Size(56, 13)
        IdunitkerjaLabel.TabIndex = 6
        IdunitkerjaLabel.Text = "Unit Kerja:"
        '
        'PegawaiBindingNavigator
        '
        Me.PegawaiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PegawaiBindingNavigator.BindingSource = Me.PegawaiBindingSource
        Me.PegawaiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PegawaiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PegawaiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PegawaiBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.PegawaiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PegawaiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PegawaiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PegawaiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PegawaiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PegawaiBindingNavigator.Name = "PegawaiBindingNavigator"
        Me.PegawaiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PegawaiBindingNavigator.Size = New System.Drawing.Size(614, 25)
        Me.PegawaiBindingNavigator.TabIndex = 0
        Me.PegawaiBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'PegawaiBindingSource
        '
        Me.PegawaiBindingSource.DataMember = "pegawai"
        Me.PegawaiBindingSource.DataSource = Me.DataSet
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 20)
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
        'PegawaiBindingNavigatorSaveItem
        '
        Me.PegawaiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PegawaiBindingNavigatorSaveItem.Image = CType(resources.GetObject("PegawaiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PegawaiBindingNavigatorSaveItem.Name = "PegawaiBindingNavigatorSaveItem"
        Me.PegawaiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PegawaiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Project.My.Resources.Resources.door_in
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripButton1.Text = "Tutup"
        '
        'UnitKerjaBindingSource
        '
        Me.UnitKerjaBindingSource.DataMember = "unit kerja"
        Me.UnitKerjaBindingSource.DataSource = Me.DataSet
        '
        'PegawaiTableAdapter
        '
        Me.PegawaiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbsensiTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KapabilitasTableAdapter = Nothing
        Me.TableAdapterManager.KedisiplinanTableAdapter = Nothing
        Me.TableAdapterManager.KinerjaTableAdapter = Nothing
        Me.TableAdapterManager.Komponen_KapabilTableAdapter = Nothing
        Me.TableAdapterManager.Komponen_PenilaianTableAdapter = Nothing
        Me.TableAdapterManager.PegawaiTableAdapter = Me.PegawaiTableAdapter
        Me.TableAdapterManager.PemakaiTableAdapter = Nothing
        Me.TableAdapterManager.Status_AbsensiTableAdapter = Nothing
        Me.TableAdapterManager.Unit_KerjaTableAdapter = Me.Unit_kerjaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Project.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Unit_kerjaTableAdapter
        '
        Me.Unit_kerjaTableAdapter.ClearBeforeFill = True
        '
        'PegawaiDataGridView
        '
        Me.PegawaiDataGridView.AllowUserToAddRows = False
        Me.PegawaiDataGridView.AllowUserToDeleteRows = False
        Me.PegawaiDataGridView.AutoGenerateColumns = False
        Me.PegawaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PegawaiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.PegawaiDataGridView.DataSource = Me.PegawaiBindingSource
        Me.PegawaiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PegawaiDataGridView.Location = New System.Drawing.Point(3, 153)
        Me.PegawaiDataGridView.Name = "PegawaiDataGridView"
        Me.PegawaiDataGridView.ReadOnly = True
        Me.PegawaiDataGridView.Size = New System.Drawing.Size(608, 207)
        Me.PegawaiDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NIK"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NIK"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Nama"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Tunjangan Max"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tunjangan Max"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idunitkerja"
        Me.DataGridViewTextBoxColumn8.DataSource = Me.UnitKerjaBindingSource
        Me.DataGridViewTextBoxColumn8.DisplayMember = "nama unit kerja"
        Me.DataGridViewTextBoxColumn8.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn8.HeaderText = "Unit Kerja"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.ValueMember = "idunitkerja"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PegawaiDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(614, 363)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtNamaUnitKerja)
        Me.Panel1.Controls.Add(Me.IdunitkerjaTextBox)
        Me.Panel1.Controls.Add(IdunitkerjaLabel)
        Me.Panel1.Controls.Add(Tunjangan_MaxLabel)
        Me.Panel1.Controls.Add(Me.Tunjangan_MaxTextBox)
        Me.Panel1.Controls.Add(NamaLabel)
        Me.Panel1.Controls.Add(Me.NamaTextBox)
        Me.Panel1.Controls.Add(NIKLabel)
        Me.Panel1.Controls.Add(Me.NIKTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 144)
        Me.Panel1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(210, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = ".."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNamaUnitKerja
        '
        Me.txtNamaUnitKerja.Location = New System.Drawing.Point(104, 99)
        Me.txtNamaUnitKerja.Name = "txtNamaUnitKerja"
        Me.txtNamaUnitKerja.ReadOnly = True
        Me.txtNamaUnitKerja.Size = New System.Drawing.Size(100, 20)
        Me.txtNamaUnitKerja.TabIndex = 10
        '
        'IdunitkerjaTextBox
        '
        Me.IdunitkerjaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PegawaiBindingSource, "idunitkerja", True))
        Me.IdunitkerjaTextBox.Location = New System.Drawing.Point(458, 94)
        Me.IdunitkerjaTextBox.Name = "IdunitkerjaTextBox"
        Me.IdunitkerjaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdunitkerjaTextBox.TabIndex = 9
        '
        'Tunjangan_MaxTextBox
        '
        Me.Tunjangan_MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PegawaiBindingSource, "Tunjangan Max", True))
        Me.Tunjangan_MaxTextBox.Location = New System.Drawing.Point(104, 73)
        Me.Tunjangan_MaxTextBox.Name = "Tunjangan_MaxTextBox"
        Me.Tunjangan_MaxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tunjangan_MaxTextBox.TabIndex = 5
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PegawaiBindingSource, "Nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(104, 47)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NamaTextBox.TabIndex = 3
        '
        'NIKTextBox
        '
        Me.NIKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PegawaiBindingSource, "NIK", True))
        Me.NIKTextBox.Location = New System.Drawing.Point(104, 21)
        Me.NIKTextBox.Name = "NIKTextBox"
        Me.NIKTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NIKTextBox.TabIndex = 1
        '
        'UnitKerjaBindingSource1
        '
        Me.UnitKerjaBindingSource1.DataMember = "Unit Kerja"
        Me.UnitKerjaBindingSource1.DataSource = Me.DataSet
        '
        'FormPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 388)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PegawaiBindingNavigator)
        Me.Name = "FormPegawai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Pegawai"
        CType(Me.PegawaiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PegawaiBindingNavigator.ResumeLayout(False)
        Me.PegawaiBindingNavigator.PerformLayout()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitKerjaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PegawaiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UnitKerjaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet As Project.DataSet
    Friend WithEvents PegawaiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PegawaiTableAdapter As Project.DataSetTableAdapters.pegawaiTableAdapter
    Friend WithEvents TableAdapterManager As Project.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PegawaiBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PegawaiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Unit_kerjaTableAdapter As Project.DataSetTableAdapters.unit_kerjaTableAdapter
    Friend WithEvents UnitKerjaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PegawaiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Tunjangan_MaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NIKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitKerjaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents txtNamaUnitKerja As System.Windows.Forms.TextBox
    Friend WithEvents IdunitkerjaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
