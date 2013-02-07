Imports System.Data.Odbc

Public Class FormProsesLaporan
    Private Function prosesKedisiplinan(ByVal komponenPenilaian As String, ByVal NIK As String, ByVal Nama As String, ByVal sql As String) As Double
        Dim dr As OdbcDataReader
        Dim nilaiKomponen As Double = 0
        dr = runQuery(sql)
        If dr.HasRows Then
            Dim idketepatan As Integer = findid("idkomponenpenilaian", "[komponen penilaian]", "[nama komponen penilaian]='" & komponenPenilaian & "'")
            Dim adaIjin As Boolean = False
            If komponenPenilaian.ToUpper.Equals("KETEPATAN") Or komponenPenilaian.ToUpper.Equals("PULANG") Then
                If dr(0) > 2 Then
                    nilaiKomponen = 1
                ElseIf dr(0) = 2 Or dr(0) = 1 Then
                    nilaiKomponen = 2.5
                ElseIf dr(0) = 0 Then
                    nilaiKomponen = 5
                End If
            ElseIf komponenPenilaian.ToUpper.Equals("KEHADIRAN") Then
                While dr.Read

                    If dr("status absensi").Equals("Alfa") Then
                        If dr("jumlah") = 1 Or dr("jumlah") = 2 Then
                            nilaiKomponen = 2.5
                        ElseIf dr("jumlah") > 2 Then
                            nilaiKomponen = 1
                        End If
                        Exit While
                    End If

                    If dr("status absensi").Equals("Ijin") Then
                        adaIjin = True
                        If dr("jumlah") = 1 Or dr("jumlah") = 2 Then
                            nilaiKomponen = 5
                        ElseIf dr("jumlah") > 2 Then
                            nilaiKomponen = 2.5
                        Else
                            nilaiKomponen = 10
                        End If
                    End If
                    If dr("status absensi").Equals("Masuk") And Not adaIjin Then
                        nilaiKomponen = 10
                    End If


                End While
                

            ElseIf komponenPenilaian.ToUpper.Equals("IJIN") Then
                If dr(0) > 12 Then
                    nilaiKomponen = 2.5
                ElseIf dr(0) > 6 And dr(0) <= 12 Then
                    nilaiKomponen = 5
                ElseIf dr(0) <= 6 Then
                    nilaiKomponen = 10
                End If
            End If
            'log(sqlKedisiplinan)
            runCommand("insert into kedisiplinan(nik,idkomponenpenilaian,nilai,bulan,tahun)values('" & NIK & "'," & idketepatan & "," & nilaiKomponen & "," & cboBulan.SelectedIndex + 1 & "," & cboTahun.Text & ")")
            log("Update = " & komponenPenilaian & " = " & nilaiKomponen & " untuk NIK = " & NIK & ", " & Nama)
        Else
            log("Tidak bisa mengambil data " & komponenPenilaian & " untuk NIK = " & NIK & ", " & Nama)
        End If
        dr.Close()
        Return nilaiKomponen
    End Function
    Private Sub normalisasiJamPulang()
        Dim dr As OdbcDataReader
        Dim time As Date

        dr = runQuery("select nik,[jam pulang],idabsensi from absensi where bulan=" & cboBulan.SelectedIndex + 1 & " and tahun=" & cboTahun.Text)
        While dr.Read
            time = dr("jam pulang")
            runCommand("update absensi set [jam pulang]=#12/30/1899 " & time.Hour & ":" & time.Minute & ":" & time.Second & "# where idabsensi=" & dr("idabsensi"))
        End While
        dr.Close()
    End Sub
    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        lstOutput.Items.Clear()
        gridKinerja.Rows.Clear()
        normalisasiJamPulang()
        Dim sqlPegawai As String = "select nik,nama,[nama unit kerja],[tunjangan max] from pegawai, [unit kerja] where pegawai.idunitkerja = [unit kerja].idunitkerja order by [nama unit kerja], nik"
        Dim drPegawai As OdbcDataReader
        Dim iPegawai As Integer = 1
        drPegawai = runQuery(sqlPegawai)
        While drPegawai.Read
            Dim sqlAbsensi As String = "SELECT Absensi.NIK, Absensi.tanggal, Absensi.[jam masuk], Absensi.[jam pulang], [Status Absensi].[status absensi], Absensi.bulan, Absensi.tahun " & _
                           " FROM [Status Absensi] INNER JOIN (Pegawai INNER JOIN Absensi ON Pegawai.NIK = Absensi.NIK) ON [Status Absensi].idstatusabsensi = Absensi.idstatusabsensi " & _
                          " WHERE (((Absensi.NIK)='" & drPegawai("NIK") & "') AND ((Absensi.bulan)=" & cboBulan.SelectedIndex + 1 & ") AND ((Absensi.tahun)=" & cboTahun.Text & "))"
            Dim drAbsensi As OdbcDataReader = runQuery(sqlAbsensi)
            Dim nilaiHadir As Double = 10
            Dim nilaiPulang As Double = 10
            Dim nilaiKehadiran As Double = 10
            Dim nilaiIjin As Double = 10
            Dim nilaiSetia As Double = 10
            Dim nilaiJujur As Double = 10
            Dim nilaiKapabil As Double = 50
            Dim nilaiProaktif As Double = 0
            If drAbsensi.HasRows Then
                Dim sqlKedisiplinan As String = "delete from kedisiplinan where nik ='" & drPegawai("NIK") & "' and bulan=" & cboBulan.SelectedIndex + 1 & " and tahun=" & cboTahun.Text

                log("Memproses data absensi untuk pegawai NIK = " & drPegawai("NIK") & ", " & drPegawai("nama"))
                runCommand(sqlKedisiplinan)

                nilaiHadir = prosesKedisiplinan("Ketepatan", drPegawai("NIK"), drPegawai("Nama"), _
                                   "SELECT Count(Absensi.idabsensi) AS CountOfidabsensi " & _
                                    " FROM(Absensi) " & _
                                    "WHERE (((Absensi.NIK)='" & drPegawai("NIK") & "') AND ((Absensi.[jam masuk])>#12/30/1899 7:30:0#) AND ((Absensi.bulan)=" & cboBulan.SelectedIndex + 1 & ") AND ((Absensi.tahun)=" & cboTahun.Text & "))")


                nilaiPulang = prosesKedisiplinan("Pulang", drPegawai("NIK"), drPegawai("Nama"), _
                                   "SELECT Count(Absensi.idabsensi) AS CountOfidabsensi " & _
                                    " FROM(Absensi) " & _
                                    " WHERE (((Absensi.NIK)='" & drPegawai("NIK") & "') AND ((Absensi.[jam pulang])<#12/30/1899 15:00:00#) AND ((Absensi.bulan)=" & cboBulan.SelectedIndex + 1 & ") AND ((Absensi.tahun)=" & cboTahun.Text & "))")

                nilaiKehadiran = prosesKedisiplinan("Kehadiran", drPegawai("NIK"), drPegawai("Nama"), _
                                    " SELECT [Status Absensi].[status absensi], Count([Status Absensi].[status absensi]) AS [jumlah] " & _
                                    " FROM [Status Absensi] INNER JOIN Absensi ON [Status Absensi].idstatusabsensi = Absensi.idstatusabsensi " & _
                                    " WHERE(((Absensi.NIK) = '" & drPegawai("NIK") & "') And ((Absensi.bulan) = " & cboBulan.SelectedIndex + 1 & ") And ((Absensi.tahun) = " & cboTahun.Text & ")) " & _
                                    " GROUP BY [Status Absensi].[status absensi] " & _
                                    " HAVING ((([Status Absensi].[status absensi])='ijin' Or ([Status Absensi].[status absensi])='alfa' Or ([Status Absensi].[status absensi])='masuk'))")

                nilaiIjin = prosesKedisiplinan("Ijin", drPegawai("NIK"), drPegawai("Nama"), _
                                    " SELECT Sum(Absensi.[ijin keluar kantor]) AS [SumOfijin keluar kantor] " & _
                                    " FROM [Status Absensi] INNER JOIN Absensi ON [Status Absensi].idstatusabsensi = Absensi.idstatusabsensi " & _
                                    " WHERE (((Absensi.NIK)='" & drPegawai("NIK") & "') AND ((Absensi.bulan)=" & cboBulan.SelectedIndex + 1 & ") AND ((Absensi.tahun)=" & cboTahun.Text & "))")

                nilaiSetia = findid("[pelanggaran kewajiban]", "Kinerja", "nik='" & drPegawai("nik") & "' and bulan=" & cboBulan.SelectedIndex + 1 & " and tahun=" & cboTahun.Text)
                nilaiJujur = findid("[pelanggaran larangan]", "Kinerja", "nik='" & drPegawai("nik") & "' and bulan=" & cboBulan.SelectedIndex + 1 & " and tahun=" & cboTahun.Text)

                'kapabil
                Dim drNilaiKapabil As OdbcDataReader = runQuery("SELECT Sum(Kapabilitas.nilai) AS SumOfnilai FROM(Kapabilitas)WHERE (((Kapabilitas.NIK)='" & drPegawai("NIK") & "') AND ((Kapabilitas.bulan)=" & cboBulan.SelectedIndex + 1 & ") AND ((Kapabilitas.tahun)=" & cboTahun.Text & "))")
                drNilaiKapabil.Read()
                If drNilaiKapabil.HasRows Then
                    If IsDBNull(drNilaiKapabil(0)) Then nilaiKapabil = 0 Else nilaiKapabil = drNilaiKapabil(0)
                End If
                drNilaiKapabil.Close()

                'proaktif
                nilaiProaktif = nilaiIjin + nilaiJujur + nilaiKapabil + nilaiKehadiran + nilaiHadir + nilaiPulang + nilaiSetia
                Dim nilaiTunjangan As Double = nilaiProaktif * drPegawai("tunjangan max") / 100

                Dim nilaiCatatan As String
                gridKinerja.Rows.Add()
                gridKinerja.Rows(gridKinerja.RowCount - 1).Cells("No").Value = iPegawai
                gridKinerja.Rows(gridKinerja.RowCount - 1).Cells("NIK").Value = drPegawai("NIK")
                gridKinerja.Rows(gridKinerja.RowCount - 1).Cells("Nama").Value = drPegawai("Nama")
                gridKinerja.Rows(gridKinerja.RowCount - 1).Cells("UnitKerja").Value = drPegawai("Nama Unit Kerja")
                gridKinerja.Rows(gridKinerja.RowCount - 1).Cells("Ketepatan").Value = FormatNumber(nilaiHadir, 1)
                gridKinerja.Rows(gridKinerja.RowCount - 1).Cells("Pulang").Value = FormatNumber(nilaiPulang, 1)
                gridKinerja.Rows(gridKinerja.RowCount - 1).Cells("Kehadiran").Value = FormatNumber(nilaiKehadiran, 1)
                gridKinerja.Rows(gridKinerja.RowCount - 1).Cells("Ijin").Value = FormatNumber(nilaiIjin, 1)
                gridKinerja.Rows(gridKinerja.RowCount - 1).Cells("Setia").Value = FormatNumber(nilaiSetia, 1)
                gridKinerja.Rows(gridKinerja.RowCount - 1).Cells("Jujur").Value = FormatNumber(nilaiJujur, 1)
                gridKinerja.Rows(gridKinerja.RowCount - 1).Cells("Kapabilitas").Value = FormatNumber(nilaiKapabil, 1)
                gridKinerja.Rows(gridKinerja.RowCount - 1).Cells("Proaktif").Value = FormatNumber(nilaiProaktif, 1)
                gridKinerja.Rows(gridKinerja.RowCount - 1).Cells("TunjanganMaksimum").Value = FormatCurrency(drPegawai("tunjangan max"))
                gridKinerja.Rows(gridKinerja.RowCount - 1).Cells("JumlahTunjangan").Value = FormatCurrency(nilaiTunjangan)
                nilaiCatatan = buatKeterangan(drPegawai("nik"), cboBulan.SelectedIndex + 1, cboTahun.Text)
                gridKinerja.Rows(gridKinerja.RowCount - 1).Cells("Catatan").Value = nilaiCatatan

                'hasil dari pemrosesan, tidak bisa langsung dicetak, karena data menyebar. Untuk mengotomasi proses penyetakan, data harus di rekap ke dalam satu tabel : Kinerja.
                iPegawai = iPegawai + 1
                'simpan ke tabel kinerja untuk keperluan pencetakan
                Dim idkinerja As String = findid("idkinerja", "kinerja", "nik='" & drPegawai("NIK") & "' and bulan=" & cboBulan.SelectedIndex + 1 & " and tahun=" & cboTahun.Text)
                If idkinerja = 0 Then
                    runCommand("insert into kinerja(nik,bulan,tahun,ketepatan,pulang,kehadiran,ijin,setia,jujur,kapabilitas,proaktif,tunjangan,catatan)values(" & _
                    "'" & drPegawai("NIK") & "'," & _
                    cboBulan.SelectedIndex + 1 & "," & _
                    cboTahun.Text & "," & _
                    nilaiHadir & "," & _
                    nilaiPulang & "," & _
                    nilaiKehadiran & "," & _
                    nilaiIjin & "," & _
                    nilaiSetia & "," & _
                    nilaiJujur & "," & _
                    nilaiKapabil & "," & _
                    nilaiProaktif & "," & _
                    nilaiTunjangan & "," & _
                    "'" & nilaiCatatan & "'" & _
                    ")")
                Else
                    runCommand("update kinerja set ketepatan=" & nilaiHadir & ",pulang=" & nilaiPulang & ",kehadiran=" & nilaiKehadiran & "," & "ijin=" & nilaiIjin & ",setia=" & nilaiSetia & ",jujur=" & nilaiJujur & ",kapabilitas=" & nilaiKapabil & ",proaktif=" & nilaiProaktif & ",tunjangan=" & nilaiTunjangan & ",catatan='" & nilaiCatatan & "' " & _
                    " where nik='" & drPegawai("NIK") & "' and bulan=" & cboBulan.SelectedIndex + 1 & " and tahun =" & cboTahun.Text)

                End If
            Else
                log("Tidak ditemukan data absensi untuk pegawai NIK = " & drPegawai("NIK") & ", " & drPegawai("nama"))
            End If

        End While

        drPegawai.Close()
        MessageBox.Show("Proses selesai...", "Penilaian Pegawai", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Function buatKeterangan(ByVal nik As String, ByVal bulan As Integer, ByVal tahun As Integer)
        Dim drKeterangan As OdbcDataReader
        Dim keterangan As String = ""
        'terlambat datang
        drKeterangan = runQuery("SELECT Count(Absensi.[jam masuk]) AS jumlah FROM(Absensi) WHERE (((Absensi.[jam masuk])>#12/30/1899 7:30:0#) AND ((Absensi.NIK)='" & nik & "') AND ((Absensi.bulan)=" & bulan & ") AND ((Absensi.tahun)=" & tahun & "))")
        drKeterangan.Read()
        If (drKeterangan("jumlah") > 0) Then keterangan = "Terlambat " & drKeterangan("jumlah") & "x"
        drKeterangan.Close()
        'Pulang(awal)
        drKeterangan = runQuery("SELECT Count(Absensi.[jam pulang]) AS jumlah FROM(Absensi) WHERE (((Absensi.[jam pulang])<#12/30/1899 15:00:0#) AND ((Absensi.NIK)='" & nik & "') AND ((Absensi.bulan)=" & bulan & ") AND ((Absensi.tahun)=" & tahun & "))")
        drKeterangan.Read()
        If (drKeterangan("jumlah") > 0) Then keterangan = "Pulang awal " & drKeterangan("jumlah") & "x" & ", " & keterangan
        drKeterangan.Close()

        'Ijin
        drKeterangan = runQuery("SELECT Count(Absensi.idabsensi) AS jumlah FROM [Status Absensi] INNER JOIN Absensi ON [Status Absensi].idstatusabsensi = Absensi.idstatusabsensi WHERE (((Absensi.NIK)='" & nik & "') AND ((Absensi.bulan)=" & bulan & ") AND ((Absensi.tahun)=" & tahun & ") AND (([Status Absensi].[status absensi])='ijin'))")
        drKeterangan.Read()
        If (drKeterangan("jumlah") > 0) Then keterangan = "Ijin " & drKeterangan("jumlah") & "x" & ", " & keterangan
        drKeterangan.Close()
        'alfa
        drKeterangan = runQuery("SELECT Count(Absensi.idabsensi) AS jumlah FROM [Status Absensi] INNER JOIN Absensi ON [Status Absensi].idstatusabsensi = Absensi.idstatusabsensi WHERE (((Absensi.NIK)='" & nik & "') AND ((Absensi.bulan)=" & bulan & ") AND ((Absensi.tahun)=" & tahun & ") AND (([Status Absensi].[status absensi])='alfa'))")
        drKeterangan.Read()
        If (drKeterangan("jumlah") > 0) Then
            If keterangan <> "" Then keterangan = "Alfa " & drKeterangan("jumlah") & "x, " & keterangan Else keterangan = "Alfa " & drKeterangan("jumlah")
        End If
        drKeterangan.Close()
        

        'peringatan(tertulis)
        'TODO : ... ojo lali lho bune... ^^
        Dim drPelanggaran As OdbcDataReader = runQuery("SELECT Kinerja.[pelanggaran kewajiban], Kinerja.[pelanggaran larangan] FROM(Kinerja)WHERE (((Kinerja.NIK)='" & nik & "') AND ((Kinerja.bulan)=" & bulan & ") AND ((Kinerja.tahun)=" & tahun & "))")
        If drPelanggaran.Read Then

            Dim kesetiaan As Double = IIf(IsDBNull(drPelanggaran("pelanggaran kewajiban")), 10, drPelanggaran("pelanggaran kewajiban"))
            Dim kejujuran As Double = IIf(IsDBNull(drPelanggaran("pelanggaran larangan")), 10, drPelanggaran("pelanggaran larangan"))
            If kesetiaan = 5 Then
                'Tidak ada teguran tertulis
                'Teguran lesan ke 2
                'Ada teguran tertulis
                If keterangan <> "" Then keterangan = "Teguran lesan ke 2 atas Kesetiaan" & "," & keterangan Else keterangan = "Teguran lesan ke 2 atas Kesetiaan"
            ElseIf kesetiaan = 2.5 Then
                If keterangan <> "" Then keterangan = "Ada teguran tertulis atas Kesetiaan" & "," & keterangan Else keterangan = "Ada teguran tertulis atas Kesetiaan"
            End If

            If kejujuran = 5 Then
                'Tidak ada teguran tertulis
                'Teguran lesan ke 2
                'Ada teguran tertulis
                If keterangan <> "" Then keterangan = "Teguran lesan ke 2 atas Kejujuran" & "," & keterangan Else keterangan = "Teguran lesan ke 2 atas Kejujuran"
            ElseIf kejujuran = 2.5 Then
                If keterangan <> "" Then keterangan = "Ada teguran tertulis atas Kejujuran" & "," & keterangan Else keterangan = "Ada teguran tertulis atas Kejujuran"
            End If
        End If
        drPelanggaran.Close()

        keterangan = Trim(keterangan)
        If keterangan.EndsWith(",") Then
            keterangan = keterangan.Substring(0, keterangan.Length - 1)
        End If
        Return keterangan
    End Function
    Private Sub FormProsesLaporan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboBulan.SelectedIndex = Now.Month - 1
        cboTahun.Text = Now.Year
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub gridKinerja_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridKinerja.CellContentClick

    End Sub

    Private Sub btnCetakLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetakLaporan.Click
        FormLaporanKinerja.bulan = cboBulan.SelectedIndex + 1
        FormLaporanKinerja.tahun = cboTahun.Text
        FormLaporanKinerja.MdiParent = MainForm
        FormLaporanKinerja.Show()
        'FormLaporanKinerja.RefreshForm()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormLaporanKinerjaPerUnit.bulan = cboBulan.SelectedIndex + 1
        FormLaporanKinerjaPerUnit.tahun = cboTahun.Text
        FormLaporanKinerjaPerUnit.MdiParent = MainForm
        FormLaporanKinerjaPerUnit.Show()
        'FormLaporanKinerjaPerUnit.RefreshForm()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class