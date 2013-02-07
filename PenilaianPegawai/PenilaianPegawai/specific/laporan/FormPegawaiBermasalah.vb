Public Class FormPegawaiBermasalah
    Private rpt As New CrystalReport1
    Private dt As DataTable
    Private Sub FormPegawaiBermasalah_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet.LaporanTerakhirInsyaAllah' table. You can move, or remove it, as needed.
        ' Me.LaporanTerakhirInsyaAllahTableAdapter.Fill(Me.DataSet.LaporanTerakhirInsyaAllah)
        'TODO: This line of code loads data into the 'DataSet.LaporanTerakhirInsyaAllah' table. You can move, or remove it, as needed.
        ' Me.LaporanTerakhirInsyaAllahTableAdapter.Fill(Me.DataSet.LaporanTerakhirInsyaAllah)

        'cboTahun.Text = Now.Year
        'Me.ReportViewer1.RefreshReport()
    End Sub
    Private Function prepareData() As DataTable
        Dim bulAwal As Integer = dtStart.Value.Month
        Dim bulAkhir As Integer = dtEnd.Value.Month
        Dim tahunAwal As Integer = dtStart.Value.Year
        Dim tahunAkhir As Integer = dtEnd.Value.Year

        If tahunAkhir <> tahunAwal Then
            MessageBox.Show("Harus dalam tahun yang sama", "Penilaian Pegawai", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        End If
        Dim sql As String = _
        " SELECT Kinerja.NIK, [Unit Kerja].[nama unit kerja], Pegawai.Nama, Kinerja.NIK AS [Jumlah Wanprestasi]" & _
        " FROM [Unit Kerja] INNER JOIN (Pegawai INNER JOIN Kinerja ON Pegawai.NIK = Kinerja.NIK) ON [Unit Kerja].idunitkerja = Pegawai.idunitkerja " & _
        " WHERE(((Kinerja.proaktif) < 75) And ((Kinerja.bulan) >= " & bulAwal & " And (Kinerja.bulan) <= " & bulAkhir & ") And ((Kinerja.tahun) = " & tahunAkhir & ")) " & _
        " GROUP BY Kinerja.NIK, [Unit Kerja].[nama unit kerja], Pegawai.Nama, Kinerja.NIK " & _
        " HAVING (((Kinerja.NIK)>='3'))"


        Dim da As Odbc.OdbcDataAdapter = New Odbc.OdbcDataAdapter(sql, con)
        da.Fill(dt)

        Return dt
    End Function

    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        dt = New DataTable
        dt = prepareData()
        If Not dt Is Nothing Then
            rpt.Close()
            rpt.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rpt
        End If

    End Sub
End Class