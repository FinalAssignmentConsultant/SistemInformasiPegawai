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
        Dim NamaLengkapLabel As System.Windows.Forms.Label
        Dim KeteranganLabel As System.Windows.Forms.Label
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.OK_Button = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.DataSet = New Project.DataSet
        Me.PemakaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PemakaiTableAdapter = New Project.DataSetTableAdapters.PemakaiTableAdapter
        Me.TableAdapterManager = New Project.DataSetTableAdapters.TableAdapterManager
        Me.PemakaiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PemakaiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.NamaTextBox = New System.Windows.Forms.TextBox
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.Hak_aksesComboBox = New System.Windows.Forms.ComboBox
        Me.NamaLengkapTextBox = New System.Windows.Forms.TextBox
        Me.KeteranganTextBox = New System.Windows.Forms.TextBox
        NamaLabel = New System.Windows.Forms.Label
        PasswordLabel = New System.Windows.Forms.Label
        Hak_aksesLabel = New System.Windows.Forms.Label
        NamaLengkapLabel = New System.Windows.Forms.Label
        KeteranganLabel = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PemakaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PemakaiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PemakaiBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(147, 226)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
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
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PemakaiTableAdapter = Me.PemakaiTableAdapter
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
        Me.PemakaiBindingNavigator.Size = New System.Drawing.Size(305, 25)
        Me.PemakaiBindingNavigator.TabIndex = 1
        Me.PemakaiBindingNavigator.Text = "BindingNavigator1"
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
        'PemakaiBindingNavigatorSaveItem
        '
        Me.PemakaiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PemakaiBindingNavigatorSaveItem.Image = CType(resources.GetObject("PemakaiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PemakaiBindingNavigatorSaveItem.Name = "PemakaiBindingNavigatorSaveItem"
        Me.PemakaiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PemakaiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(46, 53)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(36, 13)
        NamaLabel.TabIndex = 2
        NamaLabel.Text = "nama:"
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemakaiBindingSource, "nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(128, 53)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NamaTextBox.TabIndex = 3
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(46, 84)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 4
        PasswordLabel.Text = "password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemakaiBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(128, 84)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 5
        '
        'Hak_aksesLabel
        '
        Hak_aksesLabel.AutoSize = True
        Hak_aksesLabel.Location = New System.Drawing.Point(46, 117)
        Hak_aksesLabel.Name = "Hak_aksesLabel"
        Hak_aksesLabel.Size = New System.Drawing.Size(59, 13)
        Hak_aksesLabel.TabIndex = 6
        Hak_aksesLabel.Text = "hak akses:"
        '
        'Hak_aksesComboBox
        '
        Me.Hak_aksesComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemakaiBindingSource, "hak akses", True))
        Me.Hak_aksesComboBox.FormattingEnabled = True
        Me.Hak_aksesComboBox.Items.AddRange(New Object() {"Supervisor", "Tim Kawil", "Manajer"})
        Me.Hak_aksesComboBox.Location = New System.Drawing.Point(128, 114)
        Me.Hak_aksesComboBox.Name = "Hak_aksesComboBox"
        Me.Hak_aksesComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Hak_aksesComboBox.TabIndex = 7
        '
        'NamaLengkapLabel
        '
        NamaLengkapLabel.AutoSize = True
        NamaLengkapLabel.Location = New System.Drawing.Point(46, 148)
        NamaLengkapLabel.Name = "NamaLengkapLabel"
        NamaLengkapLabel.Size = New System.Drawing.Size(81, 13)
        NamaLengkapLabel.TabIndex = 8
        NamaLengkapLabel.Text = "nama Lengkap:"
        '
        'NamaLengkapTextBox
        '
        Me.NamaLengkapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemakaiBindingSource, "namaLengkap", True))
        Me.NamaLengkapTextBox.Location = New System.Drawing.Point(128, 141)
        Me.NamaLengkapTextBox.Name = "NamaLengkapTextBox"
        Me.NamaLengkapTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NamaLengkapTextBox.TabIndex = 9
        '
        'KeteranganLabel
        '
        KeteranganLabel.AutoSize = True
        KeteranganLabel.Location = New System.Drawing.Point(46, 170)
        KeteranganLabel.Name = "KeteranganLabel"
        KeteranganLabel.Size = New System.Drawing.Size(64, 13)
        KeteranganLabel.TabIndex = 10
        KeteranganLabel.Text = "keterangan:"
        '
        'KeteranganTextBox
        '
        Me.KeteranganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemakaiBindingSource, "keterangan", True))
        Me.KeteranganTextBox.Location = New System.Drawing.Point(128, 167)
        Me.KeteranganTextBox.Name = "KeteranganTextBox"
        Me.KeteranganTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KeteranganTextBox.TabIndex = 11
        '
        'ManajemenPemakai
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(305, 267)
        Me.Controls.Add(KeteranganLabel)
        Me.Controls.Add(Me.KeteranganTextBox)
        Me.Controls.Add(NamaLengkapLabel)
        Me.Controls.Add(Me.NamaLengkapTextBox)
        Me.Controls.Add(Hak_aksesLabel)
        Me.Controls.Add(Me.Hak_aksesComboBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(NamaLabel)
        Me.Controls.Add(Me.NamaTextBox)
        Me.Controls.Add(Me.PemakaiBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManajemenPemakai"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manajemen Pemakai"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PemakaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PemakaiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PemakaiBindingNavigator.ResumeLayout(False)
        Me.PemakaiBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
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
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hak_aksesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NamaLengkapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KeteranganTextBox As System.Windows.Forms.TextBox
    'Friend WithEvents PemakaiTableAdapter As Project.DataSetTableAdapters.PemakaiTableAdapter

End Class
