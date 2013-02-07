Public Class MainForm
    'Private inbox As List(Of CInbox)
    Private Sub MainForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        sesuaikanPeran()
    End Sub

    Private Sub MainForm_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        LoginForm.Close()
    End Sub
    Public Sub sesuaikanPeran()

        ManajemenPemakaiToolStripMenuItem1.Visible = False
        If UCase(Peran) = UCase("ADMIN") Then
            ManajemenPemakaiToolStripMenuItem1.Visible = True
        ElseIf UCase(Peran) = UCase("OPERATOR") Then

        End If

    End Sub
    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = Application.ProductName
        Me.ToolStripStatusLabel2.Text = Me.Text & " - Hak Cipta © " & Application.CompanyName
        sesuaikanPeran()
    End Sub


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub


    

    Private Sub ExitToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem2.Click
        End
    End Sub

    Private Sub LogoutToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem2.Click
        Hide()
        LoginForm.Show()
    End Sub

    Private Sub UbahPasswordToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormUbahPassword.ShowDialog()
    End Sub

    Private Sub ManajemenPemakaiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManajemenPemakaiToolStripMenuItem1.Click
        ManajemenPemakai.MdiParent = Me
        ManajemenPemakai.Show()
    End Sub

    Private Sub AboutToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AboutBox.ShowDialog()
    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        DataPegawaiToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub DataPegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPegawaiToolStripMenuItem.Click
        FormPegawai.MdiParent = Me
        FormPegawai.Show()
    End Sub

    
    Private Sub StatusAbsensiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusAbsensiToolStripMenuItem.Click
        FormStatusAbsensi.MdiParent = Me
        FormStatusAbsensi.Show()
    End Sub

    Private Sub UnitKerjaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitKerjaToolStripMenuItem.Click
        FormUnitKerja.MdiParent = Me
        FormUnitKerja.Show()
    End Sub

    Private Sub AbsensiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbsensiToolStripMenuItem.Click
        FormAbsensi.MdiParent = Me
        FormAbsensi.Show()
    End Sub

    Private Sub mnuProsesLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProsesLaporan.Click
        FormProsesLaporan.MdiParent = Me
        FormProsesLaporan.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        mnuProsesLaporan_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        FormAbsensi.MdiParent = Me
        FormAbsensi.Show()
    End Sub

    Private Sub HelpToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem2.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub UbahPasswordToolStripMenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UbahPasswordToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahPasswordToolStripMenuItem3.Click
        FormUbahPassword.MdiParent = Me
        FormUbahPassword.Show()
    End Sub


    Private Sub KapabilPegawaiToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KapabilPegawaiToolStripMenuItem.Click
        FormLaporanKapabil.MdiParent = Me
        FormLaporanKapabil.Show()
    End Sub

    Private Sub KinerjaSeluruhUnitKerjaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KinerjaSeluruhUnitKerjaToolStripMenuItem.Click
        FormLaporanKinerja.MdiParent = Me
        FormLaporanKinerja.Show()
    End Sub

    Private Sub KinerjaPerUnitKerjaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KinerjaPerUnitKerjaToolStripMenuItem.Click
        FormLaporanKinerjaPerUnit.MdiParent = Me
        FormLaporanKinerjaPerUnit.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = FormatDateTime(Now)
    End Sub

    Private Sub PegawaiBermasalahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegawaiBermasalahToolStripMenuItem.Click
        FormPegawaiBermasalah.mdiparent = Me
        FormPegawaiBermasalah.Show()
    End Sub

    Private Sub ToolStripStatusLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub

    Private Sub lblTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTime.Click

    End Sub

    Private Sub toolBar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles toolBar.ItemClicked

    End Sub
End Class
