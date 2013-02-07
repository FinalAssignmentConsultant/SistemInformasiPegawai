Public Class FormLaporanKinerjaPerUnit
    Public tahun As String
    Public bulan As Integer
    Private Sub FormLaporanKinerja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReportViewer1.Enabled = False
        bulan = Now.Month - 1
        tahun = Now.Year
        cboBulan.SelectedIndex = bulan
        cboTahun.Text = tahun
        Dim dr As Odbc.OdbcDataReader = runQuery("select [nama unit kerja] from [unit kerja] order by [nama unit kerja]")
        ComboBox1.Items.Clear()
        While dr.Read
            ComboBox1.Items.Add(dr("nama unit kerja"))
        End While
        dr.Close()
        ComboBox1.SelectedIndex = 0

    End Sub
    Public Sub RefreshForm()
        Me.LaporanKinerjaPerUnitKerjaTableAdapter.Fill(Me.DataSet.LaporanKinerjaPerUnitKerja, tahun, bulan, ComboBox1.Text)
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