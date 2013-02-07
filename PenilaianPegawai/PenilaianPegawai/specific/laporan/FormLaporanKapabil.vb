Public Class FormLaporanKapabil
    Public tahun As String
    Public bulan As Integer
    Private Sub FormLaporanKapabil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bulan = Now.Month - 1
        tahun = Now.Year
        cboBulan.SelectedIndex = bulan
        cboTahun.Text = tahun

        Dim sql As String = "select [nama unit kerja] from [unit kerja]"
        Dim cmd As New Odbc.OdbcCommand(sql, con)
        Dim dr As Odbc.OdbcDataReader = cmd.ExecuteReader
        cboUnitKerja.Items.Clear()
        While dr.Read
            cboUnitKerja.Items.Add(dr(0))
        End While
        cboUnitKerja.SelectedIndex = 0

        Me.LaporanKapabilTableAdapter.Fill(Me.DataSet.LaporanKapabil, bulan, tahun, cboUnitKerja.Text)
    End Sub

   

    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        bulan = cboBulan.SelectedIndex + 1
        tahun = cboTahun.Text

        Me.LaporanKapabilTableAdapter.Fill(Me.DataSet.LaporanKapabil, bulan, tahun, cboUnitKerja.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class