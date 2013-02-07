<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManajemenPemakai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManajemenPemakai))
        Dim NamaLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim Hak_aksesLabel As System.Windows.Forms.Label
        Me.DataSet = New Project.DataSet
        Me.PemakaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PemakaiTableAdapter = New Project.DataSetTableAdapters.PemakaiTableAdapter
        Me.TableAdapterManager = New Project.DataSetTableAdapters.TableAdapterManager
        Me.PemakaiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
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
        Me.PemakaiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PemakaiDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaTextBox = New System.Windows.Forms.TextBox
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.Hak_aksesComboBox = New System.Windows.Forms.ComboBox
        NamaLabel = New System.Windows.Forms.Label
        PasswordLabel = New System.Windows.Forms.Label
        Hak_aksesLabel = New System.Windows.Forms.Label
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PemakaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PemakaiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PemakaiBindingNavigator.SuspendLayout()
        CType(Me.PemakaiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PemakaiBindingSource
        '
        Me.PemakaiBindingSource.DataMember = "Pemakai"
        Me.PemakaiBindingSource.DataSource = Me.DataSet
        '
        'PemakaiTableAdapter
        '
        Me.PemakaiTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PemakaiTableAdapter = Me.PemakaiTableAdapter
        Me.TableAdapterManager.Status_AbsensiTableAdapter = Nothing
        Me.TableAdapterManager.Unit_KerjaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PemakaiBindingNavigator
        '
        Me.PemakaiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PemakaiBindingNavigator.BindingSource = Me.PemakaiBindingSource
        Me.PemakaiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PemakaiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PemakaiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PemakaiBindingNavigatorSaveItem})
        Me.PemakaiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PemakaiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PemakaiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PemakaiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PemakaiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PemakaiBindingNavigator.Name = "PemakaiBindingNavigator"
        Me.PemakaiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PemakaiBindingNavigator.Size = New System.Drawing.Size(485, 25)
        Me.PemakaiBindingNavigator.TabIndex = 1
        Me.PemakaiBindingNavigator.Text = "BindingNavigator1"
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
        'PemakaiBindingNavigatorSaveItem
        '
        Me.PemakaiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PemakaiBindingNavigatorSaveItem.Image = CType(resources.GetObject("PemakaiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PemakaiBindingNavigatorSaveItem.Name = "PemakaiBindingNavigatorSaveItem"
        Me.PemakaiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PemakaiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PemakaiDataGridView
        '
        Me.PemakaiDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PemakaiDataGridView.AutoGenerateColumns = False
        Me.PemakaiDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PemakaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PemakaiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4})
        Me.PemakaiDataGridView.DataSource = Me.PemakaiBindingSource
        Me.PemakaiDataGridView.Location = New System.Drawing.Point(12, 126)
        Me.PemakaiDataGridView.Name = "PemakaiDataGridView"
        Me.PemakaiDataGridView.Size = New System.Drawing.Size(453, 220)
        Me.PemakaiDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Hak Akses"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Hak Akses"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(33, 50)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(36, 13)
        NamaLabel.TabIndex = 2
        NamaLabel.Text = "nama:"
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemakaiBindingSource, "nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(75, 47)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NamaTextBox.TabIndex = 3
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(14, 76)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 4
        PasswordLabel.Text = "password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemakaiBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(75, 73)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PasswordTextBox.TabIndex = 5
        '
        'Hak_aksesLabel
        '
        Hak_aksesLabel.AutoSize = True
        Hak_aksesLabel.Location = New System.Drawing.Point(10, 102)
        Hak_aksesLabel.Name = "Hak_aksesLabel"
        Hak_aksesLabel.Size = New System.Drawing.Size(59, 13)
        Hak_aksesLabel.TabIndex = 6
        Hak_aksesLabel.Text = "hak akses:"
        '
        'Hak_aksesComboBox
        '
        Me.Hak_aksesComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemakaiBindingSource, "hak akses", True))
        Me.Hak_aksesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Hak_aksesComboBox.FormattingEnabled = True
        Me.Hak_aksesComboBox.Items.AddRange(New Object() {"Admin", "Operator"})
        Me.Hak_aksesComboBox.Location = New System.Drawing.Point(75, 99)
        Me.Hak_aksesComboBox.Name = "Hak_aksesComboBox"
        Me.Hak_aksesComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Hak_aksesComboBox.TabIndex = 7
        '
        'ManajemenPemakai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 367)
        Me.Controls.Add(Hak_aksesLabel)
        Me.Controls.Add(Me.Hak_aksesComboBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(NamaLabel)
        Me.Controls.Add(Me.NamaTextBox)
        Me.Controls.Add(Me.PemakaiDataGridView)
        Me.Controls.Add(Me.PemakaiBindingNavigator)
        Me.Name = "ManajemenPemakai"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manajemen Pemakai"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PemakaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PemakaiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PemakaiBindingNavigator.ResumeLayout(False)
        Me.PemakaiBindingNavigator.PerformLayout()
        CType(Me.PemakaiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet As Project.DataSet
    Friend WithEvents PemakaiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PemakaiTableAdapter As Project.DataSetTableAdapters.PemakaiTableAdapter
    Friend WithEvents TableAdapterManager As Project.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PemakaiBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PemakaiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PemakaiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hak_aksesComboBox As System.Windows.Forms.ComboBox
    'Friend WithEvents PemakaiTableAdapter As Project.DataSetTableAdapters.PemakaiTableAdapter

End Class
