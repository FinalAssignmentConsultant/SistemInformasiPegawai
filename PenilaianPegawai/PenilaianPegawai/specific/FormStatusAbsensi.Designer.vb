<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStatusAbsensi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStatusAbsensi))
        Me.DataSet = New Project.DataSet
        Me.Status_AbsensiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Status_AbsensiTableAdapter = New Project.DataSetTableAdapters.Status_AbsensiTableAdapter
        Me.TableAdapterManager = New Project.DataSetTableAdapters.TableAdapterManager
        Me.Status_AbsensiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.Status_AbsensiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Status_AbsensiDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Status_AbsensiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Status_AbsensiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Status_AbsensiBindingNavigator.SuspendLayout()
        CType(Me.Status_AbsensiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Status_AbsensiBindingSource
        '
        Me.Status_AbsensiBindingSource.DataMember = "Status Absensi"
        Me.Status_AbsensiBindingSource.DataSource = Me.DataSet
        '
        'Status_AbsensiTableAdapter
        '
        Me.Status_AbsensiTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PegawaiTableAdapter = Nothing
        Me.TableAdapterManager.PemakaiTableAdapter = Nothing
        Me.TableAdapterManager.Status_AbsensiTableAdapter = Me.Status_AbsensiTableAdapter
        Me.TableAdapterManager.Unit_KerjaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Status_AbsensiBindingNavigator
        '
        Me.Status_AbsensiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Status_AbsensiBindingNavigator.BindingSource = Me.Status_AbsensiBindingSource
        Me.Status_AbsensiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Status_AbsensiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Status_AbsensiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Status_AbsensiBindingNavigatorSaveItem})
        Me.Status_AbsensiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Status_AbsensiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Status_AbsensiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Status_AbsensiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Status_AbsensiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Status_AbsensiBindingNavigator.Name = "Status_AbsensiBindingNavigator"
        Me.Status_AbsensiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Status_AbsensiBindingNavigator.Size = New System.Drawing.Size(526, 25)
        Me.Status_AbsensiBindingNavigator.TabIndex = 0
        Me.Status_AbsensiBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Status_AbsensiBindingNavigatorSaveItem
        '
        Me.Status_AbsensiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Status_AbsensiBindingNavigatorSaveItem.Image = CType(resources.GetObject("Status_AbsensiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Status_AbsensiBindingNavigatorSaveItem.Name = "Status_AbsensiBindingNavigatorSaveItem"
        Me.Status_AbsensiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Status_AbsensiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Status_AbsensiDataGridView
        '
        Me.Status_AbsensiDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Status_AbsensiDataGridView.AutoGenerateColumns = False
        Me.Status_AbsensiDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Status_AbsensiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Status_AbsensiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.Status_AbsensiDataGridView.DataSource = Me.Status_AbsensiBindingSource
        Me.Status_AbsensiDataGridView.Location = New System.Drawing.Point(12, 43)
        Me.Status_AbsensiDataGridView.Name = "Status_AbsensiDataGridView"
        Me.Status_AbsensiDataGridView.Size = New System.Drawing.Size(502, 279)
        Me.Status_AbsensiDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "status absensi"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Status Absensi"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'FormStatusAbsensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 334)
        Me.Controls.Add(Me.Status_AbsensiDataGridView)
        Me.Controls.Add(Me.Status_AbsensiBindingNavigator)
        Me.Name = "FormStatusAbsensi"
        Me.Text = "FormStatusAbsensi"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Status_AbsensiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Status_AbsensiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Status_AbsensiBindingNavigator.ResumeLayout(False)
        Me.Status_AbsensiBindingNavigator.PerformLayout()
        CType(Me.Status_AbsensiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet As Project.DataSet
    Friend WithEvents Status_AbsensiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Status_AbsensiTableAdapter As Project.DataSetTableAdapters.Status_AbsensiTableAdapter
    Friend WithEvents TableAdapterManager As Project.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Status_AbsensiBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Status_AbsensiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Status_AbsensiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
