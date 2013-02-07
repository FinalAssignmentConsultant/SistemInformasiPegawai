<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoginPeserta
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataSetTechSupport = New TestPsikologi.DataSetTechSupport
        Me.PesertaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PesertaTableAdapter = New TestPsikologi.DataSetTechSupportTableAdapters.PesertaTableAdapter
        Me.TableAdapterManager = New TestPsikologi.DataSetTechSupportTableAdapters.TableAdapterManager
        Me.Button1 = New System.Windows.Forms.Button
        Me.cboNIP = New System.Windows.Forms.ComboBox
        Me.NamaLabel1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnLanjutkan = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnTutup = New System.Windows.Forms.Button
        CType(Me.DataSetTechSupport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PesertaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pilih Peserta"
        '
        'DataSetTechSupport
        '
        Me.DataSetTechSupport.DataSetName = "DataSetTechSupport"
        Me.DataSetTechSupport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PesertaBindingSource
        '
        Me.PesertaBindingSource.DataMember = "Peserta"
        Me.PesertaBindingSource.DataSource = Me.DataSetTechSupport
        '
        'PesertaTableAdapter
        '
        Me.PesertaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.jawabanTableAdapter = Nothing
        Me.TableAdapterManager.partTableAdapter = Nothing
        Me.TableAdapterManager.PemakaiTableAdapter = Nothing
        Me.TableAdapterManager.PesertaTableAdapter = Me.PesertaTableAdapter
        Me.TableAdapterManager.SoalTableAdapter = Nothing
        Me.TableAdapterManager.Test_JawabanTableAdapter = Nothing
        Me.TableAdapterManager.TestTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TestPsikologi.DataSetTechSupportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(247, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Tambah siswa.."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboNIP
        '
        Me.cboNIP.DataSource = Me.PesertaBindingSource
        Me.cboNIP.DisplayMember = "nip"
        Me.cboNIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNIP.FormattingEnabled = True
        Me.cboNIP.Location = New System.Drawing.Point(120, 28)
        Me.cboNIP.Name = "cboNIP"
        Me.cboNIP.Size = New System.Drawing.Size(121, 21)
        Me.cboNIP.TabIndex = 7
        '
        'NamaLabel1
        '
        Me.NamaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PesertaBindingSource, "nama", True))
        Me.NamaLabel1.Location = New System.Drawing.Point(117, 52)
        Me.NamaLabel1.Name = "NamaLabel1"
        Me.NamaLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NamaLabel1.TabIndex = 8
        Me.NamaLabel1.Text = "Label2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnLanjutkan)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnTutup)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 115)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TestPsikologi.My.Resources.Resources.Lampu
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnLanjutkan
        '
        Me.btnLanjutkan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLanjutkan.Location = New System.Drawing.Point(331, 80)
        Me.btnLanjutkan.Name = "btnLanjutkan"
        Me.btnLanjutkan.Size = New System.Drawing.Size(75, 23)
        Me.btnLanjutkan.TabIndex = 3
        Me.btnLanjutkan.Text = "&Lanjutkan>>"
        Me.btnLanjutkan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(119, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 68)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pilih siswa yang akan mengikuti ujian psikologi, dan klik Lanjutkan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnTutup
        '
        Me.btnTutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTutup.Location = New System.Drawing.Point(250, 80)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 23)
        Me.btnTutup.TabIndex = 1
        Me.btnTutup.Text = "&Batal"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'FormLoginPeserta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 248)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.NamaLabel1)
        Me.Controls.Add(Me.cboNIP)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormLoginPeserta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLoginPeserta"
        CType(Me.DataSetTechSupport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PesertaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSetTechSupport As TestPsikologi.DataSetTechSupport
    Friend WithEvents PesertaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PesertaTableAdapter As TestPsikologi.DataSetTechSupportTableAdapters.PesertaTableAdapter
    Friend WithEvents TableAdapterManager As TestPsikologi.DataSetTechSupportTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboNIP As System.Windows.Forms.ComboBox
    Friend WithEvents NamaLabel1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLanjutkan As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
