<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.FiturToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnitKerjaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusAbsensiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbsensiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuProsesLaporan = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KinerjaSeluruhUnitKerjaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KinerjaPerUnitKerjaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KapabilPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PegawaiBermasalahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdministrativeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UbahPasswordToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ManajemenPemakaiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FungsiAdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TambahPemakaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UbahPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AdministrativeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManajemenPemakaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UbahPasswordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.toolBar = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.lblTime = New System.Windows.Forms.ToolStripLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Unit_KerjaTableAdapter1 = New Project.DataSetTableAdapters.Unit_KerjaTableAdapter
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.toolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem2, Me.FiturToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.AdministrativeToolStripMenuItem1, Me.HelpToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(666, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem2
        '
        Me.FileToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem2, Me.ExitToolStripMenuItem2})
        Me.FileToolStripMenuItem2.Name = "FileToolStripMenuItem2"
        Me.FileToolStripMenuItem2.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem2.Text = "&File"
        '
        'LogoutToolStripMenuItem2
        '
        Me.LogoutToolStripMenuItem2.Name = "LogoutToolStripMenuItem2"
        Me.LogoutToolStripMenuItem2.Size = New System.Drawing.Size(118, 22)
        Me.LogoutToolStripMenuItem2.Text = "&Logout"
        '
        'ExitToolStripMenuItem2
        '
        Me.ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
        Me.ExitToolStripMenuItem2.Size = New System.Drawing.Size(118, 22)
        Me.ExitToolStripMenuItem2.Text = "E&xit"
        '
        'FiturToolStripMenuItem
        '
        Me.FiturToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnitKerjaToolStripMenuItem, Me.DataPegawaiToolStripMenuItem, Me.StatusAbsensiToolStripMenuItem, Me.AbsensiToolStripMenuItem, Me.mnuProsesLaporan})
        Me.FiturToolStripMenuItem.Name = "FiturToolStripMenuItem"
        Me.FiturToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FiturToolStripMenuItem.Text = "&Modul"
        '
        'UnitKerjaToolStripMenuItem
        '
        Me.UnitKerjaToolStripMenuItem.Name = "UnitKerjaToolStripMenuItem"
        Me.UnitKerjaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.UnitKerjaToolStripMenuItem.Text = "&Unit Kerja"
        '
        'DataPegawaiToolStripMenuItem
        '
        Me.DataPegawaiToolStripMenuItem.Name = "DataPegawaiToolStripMenuItem"
        Me.DataPegawaiToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DataPegawaiToolStripMenuItem.Text = "&Data Pegawai"
        '
        'StatusAbsensiToolStripMenuItem
        '
        Me.StatusAbsensiToolStripMenuItem.Name = "StatusAbsensiToolStripMenuItem"
        Me.StatusAbsensiToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.StatusAbsensiToolStripMenuItem.Text = "&Status Absensi"
        '
        'AbsensiToolStripMenuItem
        '
        Me.AbsensiToolStripMenuItem.Name = "AbsensiToolStripMenuItem"
        Me.AbsensiToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AbsensiToolStripMenuItem.Text = "&Penilaian Pegawai"
        '
        'mnuProsesLaporan
        '
        Me.mnuProsesLaporan.Name = "mnuProsesLaporan"
        Me.mnuProsesLaporan.Size = New System.Drawing.Size(170, 22)
        Me.mnuProsesLaporan.Text = "&Proses Laporan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KinerjaSeluruhUnitKerjaToolStripMenuItem, Me.KinerjaPerUnitKerjaToolStripMenuItem, Me.KapabilPegawaiToolStripMenuItem, Me.PegawaiBermasalahToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.LaporanToolStripMenuItem.Text = "&Laporan"
        '
        'KinerjaSeluruhUnitKerjaToolStripMenuItem
        '
        Me.KinerjaSeluruhUnitKerjaToolStripMenuItem.Name = "KinerjaSeluruhUnitKerjaToolStripMenuItem"
        Me.KinerjaSeluruhUnitKerjaToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.KinerjaSeluruhUnitKerjaToolStripMenuItem.Text = "&Kinerja Seluruh Unit Kerja"
        '
        'KinerjaPerUnitKerjaToolStripMenuItem
        '
        Me.KinerjaPerUnitKerjaToolStripMenuItem.Name = "KinerjaPerUnitKerjaToolStripMenuItem"
        Me.KinerjaPerUnitKerjaToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.KinerjaPerUnitKerjaToolStripMenuItem.Text = "&Kinerja Per Unit Kerja"
        '
        'KapabilPegawaiToolStripMenuItem
        '
        Me.KapabilPegawaiToolStripMenuItem.Name = "KapabilPegawaiToolStripMenuItem"
        Me.KapabilPegawaiToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.KapabilPegawaiToolStripMenuItem.Text = "&Kapabilitas Pegawai"
        '
        'PegawaiBermasalahToolStripMenuItem
        '
        Me.PegawaiBermasalahToolStripMenuItem.Name = "PegawaiBermasalahToolStripMenuItem"
        Me.PegawaiBermasalahToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.PegawaiBermasalahToolStripMenuItem.Text = "&Pegawai yang perlu pembinaan"
        '
        'AdministrativeToolStripMenuItem1
        '
        Me.AdministrativeToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UbahPasswordToolStripMenuItem3, Me.ManajemenPemakaiToolStripMenuItem1})
        Me.AdministrativeToolStripMenuItem1.Name = "AdministrativeToolStripMenuItem1"
        Me.AdministrativeToolStripMenuItem1.Size = New System.Drawing.Size(79, 20)
        Me.AdministrativeToolStripMenuItem1.Text = "&Administratif"
        '
        'UbahPasswordToolStripMenuItem3
        '
        Me.UbahPasswordToolStripMenuItem3.Name = "UbahPasswordToolStripMenuItem3"
        Me.UbahPasswordToolStripMenuItem3.Size = New System.Drawing.Size(182, 22)
        Me.UbahPasswordToolStripMenuItem3.Text = "&Ubah Password"
        '
        'ManajemenPemakaiToolStripMenuItem1
        '
        Me.ManajemenPemakaiToolStripMenuItem1.Name = "ManajemenPemakaiToolStripMenuItem1"
        Me.ManajemenPemakaiToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.ManajemenPemakaiToolStripMenuItem1.Text = "&Manajemen Pemakai"
        '
        'HelpToolStripMenuItem2
        '
        Me.HelpToolStripMenuItem2.Name = "HelpToolStripMenuItem2"
        Me.HelpToolStripMenuItem2.Size = New System.Drawing.Size(48, 20)
        Me.HelpToolStripMenuItem2.Text = "&About"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.LogoutToolStripMenuItem.Text = "&Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'FungsiAdministratorToolStripMenuItem
        '
        Me.FungsiAdministratorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahPemakaiToolStripMenuItem, Me.UbahPasswordToolStripMenuItem})
        Me.FungsiAdministratorToolStripMenuItem.Name = "FungsiAdministratorToolStripMenuItem"
        Me.FungsiAdministratorToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.FungsiAdministratorToolStripMenuItem.Text = "&Administratif"
        '
        'TambahPemakaiToolStripMenuItem
        '
        Me.TambahPemakaiToolStripMenuItem.Name = "TambahPemakaiToolStripMenuItem"
        Me.TambahPemakaiToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.TambahPemakaiToolStripMenuItem.Text = "Manajemen Pemakai"
        '
        'UbahPasswordToolStripMenuItem
        '
        Me.UbahPasswordToolStripMenuItem.Name = "UbahPasswordToolStripMenuItem"
        Me.UbahPasswordToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.UbahPasswordToolStripMenuItem.Text = "&Ubah password"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 383)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(666, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(103, 17)
        Me.ToolStripStatusLabel2.Text = "<< akan diganti >>"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(77, 17)
        Me.ToolStripStatusLabel1.Text = "Test Psikologi"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "&File"
        '
        'AdministrativeToolStripMenuItem
        '
        Me.AdministrativeToolStripMenuItem.Name = "AdministrativeToolStripMenuItem"
        Me.AdministrativeToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.AdministrativeToolStripMenuItem.Text = "&Administrative"
        '
        'ManajemenPemakaiToolStripMenuItem
        '
        Me.ManajemenPemakaiToolStripMenuItem.Name = "ManajemenPemakaiToolStripMenuItem"
        Me.ManajemenPemakaiToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ManajemenPemakaiToolStripMenuItem.Text = "&Manajemen Pemakai"
        '
        'UbahPasswordToolStripMenuItem1
        '
        Me.UbahPasswordToolStripMenuItem1.Name = "UbahPasswordToolStripMenuItem1"
        Me.UbahPasswordToolStripMenuItem1.Size = New System.Drawing.Size(186, 22)
        Me.UbahPasswordToolStripMenuItem1.Text = "&Ubah Password"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(43, 20)
        Me.HelpToolStripMenuItem1.Text = "&Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem1.Text = "&About"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem1.Text = "&Logout"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem1.Text = "E&xit"
        '
        'toolBar
        '
        Me.toolBar.BackColor = System.Drawing.Color.White
        Me.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolBar.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.lblTime})
        Me.toolBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.toolBar.Location = New System.Drawing.Point(0, 24)
        Me.toolBar.Name = "toolBar"
        Me.toolBar.Size = New System.Drawing.Size(666, 52)
        Me.toolBar.TabIndex = 6
        Me.toolBar.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Project.My.Resources.Resources.Vista_icons_09
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(51, 49)
        Me.ToolStripButton1.Text = "Pegawai"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Project.My.Resources.Resources.report_user
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(96, 49)
        Me.ToolStripButton2.Text = "Penilaian Pegawai"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.Project.My.Resources.Resources.loading
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(85, 49)
        Me.ToolStripButton3.Text = "Proses Laporan"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'lblTime
        '
        Me.lblTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblTime.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(128, 49)
        Me.lblTime.Text = "ToolStripLabel1"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Unit_KerjaTableAdapter1
        '
        Me.Unit_KerjaTableAdapter1.ClearBeforeFill = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(666, 405)
        Me.Controls.Add(Me.toolBar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<< akan diganti >>"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.toolBar.ResumeLayout(False)
        Me.toolBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FungsiAdministratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahPemakaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    'Friend WithEvents TSTableAdapter As TechSupport.DataSetTableAdapters.TSTableAdapter

    '    Friend WithEvents Sms_inboxTableAdapter As Project.DataSetTableAdapters.sms_inboxTableAdapter
    'Friend WithEvents Sms_outboxTableAdapter As Project.DataSetTableAdapters.sms_outboxTableAdapter
    'Friend WithEvents MasalahTableAdapter As TechSupport.DataSetTableAdapters.MasalahTableAdapter
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UbahPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrativeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManajemenPemakaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UbahPasswordToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrativeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManajemenPemakaiToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FiturToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolBar As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataPegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusAbsensiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitKerjaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbsensiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuProsesLaporan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UbahPasswordToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KinerjaSeluruhUnitKerjaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KinerjaPerUnitKerjaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KapabilPegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PegawaiBermasalahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Unit_KerjaTableAdapter1 As Project.DataSetTableAdapters.Unit_KerjaTableAdapter

End Class
