Public Class FormLaporanKinerja
    Public tahun As String
    Public bulan As Integer
    Private Sub FormLaporanKinerja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bulan = Now.Month - 1
        tahun = Now.Year
        cboBulan.SelectedIndex = bulan
        cboTahun.Text = tahun
        ReportViewer1.Enabled = False
    End Sub
    Public Sub RefreshForm()
        Me.LaporanKinerjaTableAdapter.Fill(Me.DataSet.LaporanKinerja, tahun, bulan)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        tahun = cboTahun.Text
        bulan = cboBulan.SelectedIndex + 1
        RefreshForm()
        ReportViewer1.Enabled = True
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class