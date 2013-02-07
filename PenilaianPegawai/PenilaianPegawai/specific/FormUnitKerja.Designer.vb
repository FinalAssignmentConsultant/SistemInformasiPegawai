<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUnitKerja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUnitKerja))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Unit_KerjaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.Unit_KerjaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Unit_KerjaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Unit_KerjaDataGridView = New System.Windows.Forms.DataGridView
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Komponen_KapabilDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Komponen_KapabilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Unit_KerjaTableAdapter = New Project.DataSetTableAdapters.Unit_KerjaTableAdapter
        Me.TableAdapterManager = New Project.DataSetTableAdapters.TableAdapterManager
        Me.Komponen_KapabilTableAdapter = New Project.DataSetTableAdapters.Komponen_KapabilTableAdapter
        Me.IdunitkerjaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaUnitKerjaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.Unit_KerjaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Unit_KerjaBindingNavigator.SuspendLayout()
        CType(Me.Unit_KerjaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Unit_KerjaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Komponen_KapabilDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Komponen_KapabilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Unit_KerjaBindingNavigator
        '
        Me.Unit_KerjaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Unit_KerjaBindingNavigator.BindingSource = Me.Unit_KerjaBindingSource
        Me.Unit_KerjaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Unit_KerjaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Unit_KerjaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Unit_KerjaBindingNavigatorSaveItem})
        Me.Unit_KerjaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Unit_KerjaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Unit_KerjaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Unit_KerjaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Unit_KerjaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Unit_KerjaBindingNavigator.Name = "Unit_KerjaBindingNavigator"
        Me.Unit_KerjaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Unit_KerjaBindingNavigator.Size = New System.Drawing.Size(657, 25)
        Me.Unit_KerjaBindingNavigator.TabIndex = 0
        Me.Unit_KerjaBindingNavigator.Text = "BindingNavigator1"
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
        'Unit_KerjaBindingSource
        '
        Me.Unit_KerjaBindingSource.DataMember = "Unit Kerja"
        Me.Unit_KerjaBindingSource.DataSource = Me.DataSet
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
        'Unit_KerjaBindingNavigatorSaveItem
        '
        Me.Unit_KerjaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Unit_KerjaBindingNavigatorSaveItem.Image = CType(resources.GetObject("Unit_KerjaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Unit_KerjaBindingNavigatorSaveItem.Name = "Unit_KerjaBindingNavigatorSaveItem"
        Me.Unit_KerjaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Unit_KerjaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Unit_KerjaDataGridView
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Unit_KerjaDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Unit_KerjaDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Unit_KerjaDataGridView.AutoGenerateColumns = False
        Me.Unit_KerjaDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Unit_KerjaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Unit_KerjaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdunitkerjaDataGridViewTextBoxColumn, Me.NamaUnitKerjaDataGridViewTextBoxColumn})
        Me.Unit_KerjaDataGridView.DataSource = Me.Unit_KerjaBindingSource
        Me.Unit_KerjaDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Unit_KerjaDataGridView.Name = "Unit_KerjaDataGridView"
        Me.Unit_KerjaDataGridView.Size = New System.Drawing.Size(295, 345)
        Me.Unit_KerjaDataGridView.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.96651!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.03349!))
        Me.TableLayoutPanel1.Controls.Add(Me.Unit_KerjaDataGridView, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Komponen_KapabilDataGridView, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(657, 351)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Komponen_KapabilDataGridView
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Komponen_KapabilDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Komponen_KapabilDataGridView.AutoGenerateColumns = False
        Me.Komponen_KapabilDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Komponen_KapabilDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Komponen_KapabilDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4})
        Me.Komponen_KapabilDataGridView.DataSource = Me.Komponen_KapabilBindingSource
        Me.Komponen_KapabilDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Komponen_KapabilDataGridView.Location = New System.Drawing.Point(304, 3)
        Me.Komponen_KapabilDataGridView.Name = "Komponen_KapabilDataGridView"
        Me.Komponen_KapabilDataGridView.Size = New System.Drawing.Size(350, 345)
        Me.Komponen_KapabilDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nama komponen"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Komponen Kapabilitas"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Komponen_KapabilBindingSource
        '
        Me.Komponen_KapabilBindingSource.DataMember = "Unit KerjaKomponen Kapabil"
        Me.Komponen_KapabilBindingSource.DataSource = Me.Unit_KerjaBindingSource
        '
        'Unit_KerjaTableAdapter
        '
        Me.Unit_KerjaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbsensiTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KapabilitasTableAdapter = Nothing
        Me.TableAdapterManager.KedisiplinanTableAdapter = Nothing
        Me.TableAdapterManager.KinerjaTableAdapter = Nothing
        Me.TableAdapterManager.Komponen_KapabilTableAdapter = Me.Komponen_KapabilTableAdapter
        Me.TableAdapterManager.Komponen_PenilaianTableAdapter = Nothing
        Me.TableAdapterManager.PegawaiTableAdapter = Nothing
        Me.TableAdapterManager.PemakaiTableAdapter = Nothing
        Me.TableAdapterManager.Status_AbsensiTableAdapter = Nothing
        Me.TableAdapterManager.Unit_KerjaTableAdapter = Me.Unit_KerjaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Project.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Komponen_KapabilTableAdapter
        '
        Me.Komponen_KapabilTableAdapter.ClearBeforeFill = True
        '
        'IdunitkerjaDataGridViewTextBoxColumn
        '
        Me.IdunitkerjaDataGridViewTextBoxColumn.DataPropertyName = "idunitkerja"
        Me.IdunitkerjaDataGridViewTextBoxColumn.HeaderText = "idunitkerja"
        Me.IdunitkerjaDataGridViewTextBoxColumn.Name = "IdunitkerjaDataGridViewTextBoxColumn"
        '
        'NamaUnitKerjaDataGridViewTextBoxColumn
        '
        Me.NamaUnitKerjaDataGridViewTextBoxColumn.DataPropertyName = "nama unit kerja"
        Me.NamaUnitKerjaDataGridViewTextBoxColumn.HeaderText = "nama unit kerja"
        Me.NamaUnitKerjaDataGridViewTextBoxColumn.Name = "NamaUnitKerjaDataGridViewTextBoxColumn"
        '
        'FormUnitKerja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 376)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Unit_KerjaBindingNavigator)
        Me.Name = "FormUnitKerja"
        Me.Text = "Form Input Unit Kerja"
        CType(Me.Unit_KerjaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Unit_KerjaBindingNavigator.ResumeLayout(False)
        Me.Unit_KerjaBindingNavigator.PerformLayout()
        CType(Me.Unit_KerjaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Unit_KerjaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Komponen_KapabilDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Komponen_KapabilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet As Project.DataSet
    Friend WithEvents Unit_KerjaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Unit_KerjaTableAdapter As Project.DataSetTableAdapters.Unit_KerjaTableAdapter
    Friend WithEvents TableAdapterManager As Project.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Unit_KerjaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Unit_KerjaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Unit_KerjaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Komponen_KapabilTableAdapter As Project.DataSetTableAdapters.Komponen_KapabilTableAdapter
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Komponen_KapabilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Komponen_KapabilDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaUnitKerjaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdunitkerjaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
