Imports System.Data.Odbc

Public Class FormAbsensi
    Dim monthNumber(12) As Integer
    Private Function validasiKapabil() As Boolean
        Dim i As Integer
        Dim total As Double = 0
        For i = 0 To gridKapabil.RowCount - 1
            total = total + gridKapabil.Rows(i).Cells("Nilai").Value
        Next
        If CInt(total) > 50 Then Return False
        Return True
    End Function
    Private Sub AbsensiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbsensiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AbsensiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

        If Not validasiKapabil() Then
            MessageBox.Show("Maaf, nilai kapabil melebihi 50. Mohon ulangi input Anda.")
            TabControl1.SelectedIndex = 1
            Exit Sub
        End If

        'kesetiaan dan kejujuran
        'runCommand("delete from kinerja where nik='" & txtPegawai.Text & "' and bulan=" & cboBulan.SelectedIndex + 1 & " and tahun=" & cboTahun.Text)
        Dim kesetiaan As Double
        Dim kejujuran As Double
        If cboKesetiaan.SelectedIndex = 0 Then
            kesetiaan = 10
        ElseIf cboKesetiaan.SelectedIndex = 1 Then
            kesetiaan = 5
        ElseIf cboKesetiaan.SelectedIndex = 2 Then
            kesetiaan = 2.5
        End If

        If cboKejujuran.SelectedIndex = 0 Then
            kejujuran = 10
        ElseIf cboKejujuran.SelectedIndex = 1 Then
            kejujuran = 5
        ElseIf cboKejujuran.SelectedIndex = 2 Then
            kejujuran = 2.5
        End If
        Dim idkinerja As String = findid("idkinerja", "kinerja", "nik='" & txtPegawai.Text & "' and bulan=" & cboBulan.SelectedIndex + 1 & " and tahun=" & cboTahun.Text)
        If idkinerja = 0 Then
            runCommand("insert into kinerja(nik,bulan,tahun,[pelanggaran kewajiban],[pelanggaran larangan]) values('" & txtPegawai.Text & "'," & cboBulan.SelectedIndex + 1 & "," & cboTahun.Text & "," & kesetiaan & "," & kejujuran & ")")
        Else
            runCommand("update kinerja set [pelanggaran kewajiban]=" & kesetiaan & ",[pelanggaran larangan]=" & kejujuran & " where nik='" & txtPegawai.Text & "' and bulan=" & cboBulan.SelectedIndex + 1 & " and tahun=" & cboTahun.Text)
        End If

        'kapabil
        runCommand("delete from kapabilitas where nik='" & txtPegawai.Text & "' and bulan=" & cboBulan.SelectedIndex + 1 & " and tahun=" & cboTahun.Text)
        Dim ikapabil As Integer
        Dim idkomponenkapabilitas As Integer
        Dim idunitkerja As Integer = findid("idunitkerja", "[pegawai]", "nik = '" & txtPegawai.Text & "'")
        Dim NilaiKapabil As Double
        For ikapabil = 0 To gridKapabil.Rows.Count - 1
            idkomponenkapabilitas = findid("idkomponenkapabilitas", "[komponen kapabil]", "idunitkerja=" & idunitkerja & " and [nama komponen]='" & gridKapabil.Rows(ikapabil).Cells("KomponenKapabil").Value & "'")
            NilaiKapabil = gridKapabil.Rows(ikapabil).Cells("Nilai").Value
            runCommand("insert into kapabilitas(nik,idkomponenkapabilitas,bulan,tahun,nilai)values('" & txtPegawai.Text & "'," & idkomponenkapabilitas & "," & cboBulan.SelectedIndex + 1 & "," & cboTahun.Text & "," & NilaiKapabil & ")")
        Next

        MessageBox.Show("Penyimpanan berhasil", "Penilaian Pegawai", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub FormAbsensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AbsensiBindingNavigatorSaveItem.Enabled = False
        Me.Status_AbsensiTableAdapter.Fill(Me.DataSet.Status_Absensi)
        cboBulan.SelectedIndex = Now.Month - 1
        cboTahun.Text = Now.Year
        monthNumber(0) = 31
        monthNumber(1) = 30
        monthNumber(2) = 29 'umumnya 28. 29 setiap kabisat, yaitu jumlah tahun habis dibagi 4
        monthNumber(3) = 30
        monthNumber(4) = 31
        monthNumber(5) = 30
        monthNumber(6) = 31
        monthNumber(7) = 31
        monthNumber(8) = 30
        monthNumber(9) = 31
        monthNumber(10) = 30
        monthNumber(11) = 31
        Dim sql As String = "select [nama unit kerja] from [unit kerja]"
        Dim cmd As New Odbc.OdbcCommand(sql, con)
        Dim dr As Odbc.OdbcDataReader = cmd.ExecuteReader
        cboUnitKerja.Items.Clear()
        While dr.Read
            cboUnitKerja.Items.Add(dr(0))
        End While
        cboUnitKerja.SelectedIndex = -1

        fillData()
    End Sub


    Private Sub fillData()
        Me.AbsensiTableAdapter.Fill(Me.DataSet.Absensi)
        If Not txtPegawai.Text.ToUpper.Equals("<<KLIK DISINI>>") Then
            AbsensiDataGridView.Visible = True
            AbsensiBindingSource.Filter = "nik='" & txtPegawai.Text & "' and bulan = " & cboBulan.SelectedIndex + 1 & " and tahun = " & cboTahun.Text

            DataSet.Absensi.NIKColumn.DefaultValue = txtPegawai.Text
            DataSet.Absensi.bulanColumn.DefaultValue = cboBulan.SelectedIndex + 1
            DataSet.Absensi.tahunColumn.DefaultValue = cboTahun.Text
            DataSet.Absensi.ijin_keluar_kantorColumn.DefaultValue = 0
            DataSet.Absensi.idstatusabsensiColumn.DefaultValue = 1
            prepareData()
        Else
            AbsensiDataGridView.Visible = False
        End If
    End Sub
    Public Sub prepareData()
        Dim jumlahBulan As Integer
        Dim i As Integer
        Dim hari As String
        Dim tanggal As Date
        Dim isHariKerja As Boolean

        'kejujuran dan kesetiaan
        cboKejujuran.SelectedIndex = 0
        cboKesetiaan.SelectedIndex = 0

        'kapabil
        Dim drKomponenKapabil As OdbcDataReader = runQuery("SELECT [Komponen Kapabil].[nama komponen] FROM ([Unit Kerja] INNER JOIN [Komponen Kapabil] ON [Unit Kerja].idunitkerja = [Komponen Kapabil].idunitkerja) INNER JOIN Pegawai ON [Unit Kerja].idunitkerja = Pegawai.idunitkerja WHERE (((Pegawai.NIK)='" & txtPegawai.Text & "'))")
        Dim ikapabil As Integer
        gridKapabil.Rows.Clear()
        ikapabil = 0
        While drKomponenKapabil.Read()
            ikapabil = ikapabil + 1
            gridKapabil.Rows.Add()
            gridKapabil.Rows(gridKapabil.Rows.Count - 1).Cells("KomponenKapabil").Value = drKomponenKapabil("nama komponen")

        End While
        drKomponenKapabil.Close()
        'normalkan nilai
        Dim nilaiRataRataKapabil As Double = 50 / ikapabil
        For ikapabil = 0 To gridKapabil.Rows.Count - 1
            gridKapabil.Rows(ikapabil).Cells("Nilai").Value = nilaiRataRataKapabil
        Next

        If AbsensiDataGridView.RowCount = 0 Then 'data absensi baru
            If cboBulan.SelectedIndex = 1 Then
                If CInt(cboTahun.Text) Mod 4 = 0 Then jumlahBulan = 29 Else jumlahBulan = 28
            Else
                jumlahBulan = monthNumber(cboBulan.SelectedIndex)
            End If

            For i = 1 To jumlahBulan
                tanggal = New Date(CInt(cboTahun.Text), cboBulan.SelectedIndex + 1, i)
                If tanggal.DayOfWeek.ToString.ToUpper().Equals("SUNDAY") Or tanggal.DayOfWeek.ToString.ToUpper().Equals("SATURDAY") Then
                    isHariKerja = False
                Else
                    isHariKerja = True
                End If
                If isHariKerja Then
                    AbsensiBindingSource.AddNew()
                    hari = FormatDateTime(tanggal, DateFormat.LongDate)
                    AbsensiDataGridView.Rows(AbsensiDataGridView.RowCount - 1).Cells(0).Value = i
                    AbsensiDataGridView.Rows(AbsensiDataGridView.RowCount - 1).Cells(1).Value = hari
                    AbsensiDataGridView.Rows(AbsensiDataGridView.RowCount - 1).Cells(2).Value = New Date(1899, 12, 30, 7, 30, 0)
                    AbsensiDataGridView.Rows(AbsensiDataGridView.RowCount - 1).Cells(3).Value = New Date(1899, 12, 30, 15, 0, 0)
                End If
            Next
        Else
            For i = 0 To AbsensiDataGridView.RowCount - 1
                tanggal = New Date(DataSet.Absensi.Rows(i).Item("tahun"), DataSet.Absensi.Rows(i).Item("bulan") + 1, DataSet.Absensi.Rows(i).Item("tanggal"))
                hari = FormatDateTime(tanggal, DateFormat.LongDate)
                AbsensiDataGridView.Rows(i).Cells(1).Value = hari
            Next

            'isi data kesetiaan dan kejujuran
            Dim drKesKej As OdbcDataReader = runQuery(" SELECT Kinerja.[pelanggaran kewajiban] as Kesetiaan, Kinerja.[pelanggaran larangan] as Kejujuran " & _
                                                    " FROM(Kinerja) " & _
                                                    " WHERE (((Kinerja.NIK)='" & txtPegawai.Text & "') AND ((Kinerja.bulan)=" & cboBulan.SelectedIndex + 1 & ") AND ((Kinerja.tahun)=" & cboTahun.Text & "))")
            If drKesKej.HasRows And Not IsDBNull(drKesKej("Kesetiaan")) Then
                If drKesKej("Kesetiaan") = 10 Then
                    cboKesetiaan.SelectedIndex = 0
                ElseIf drKesKej("Kesetiaan") = 5 Then
                    cboKesetiaan.SelectedIndex = 1
                ElseIf drKesKej("Kesetiaan") = 2.5 Then
                    cboKesetiaan.SelectedIndex = 2
                End If

                If drKesKej("Kejujuran") = 10 Then
                    cboKejujuran.SelectedIndex = 0
                ElseIf drKesKej("Kejujuran") = 5 Then
                    cboKejujuran.SelectedIndex = 1
                ElseIf drKesKej("Kejujuran") = 2.5 Then
                    cboKejujuran.SelectedIndex = 2
                End If

                'isi nilai komponen kapabil
                Dim komponenKapabil As String
                Dim nilaikomponenKapabil As Double
                Dim drNilaiKapabil As OdbcDataReader
                For ikapabil = 0 To gridKapabil.Rows.Count - 1
                    komponenKapabil = gridKapabil.Rows(ikapabil).Cells("KomponenKapabil").Value
                    drNilaiKapabil = runQuery("SELECT Kapabilitas.nilai FROM Pegawai INNER JOIN ([Komponen Kapabil] INNER JOIN Kapabilitas ON [Komponen Kapabil].idkomponenkapabilitas = Kapabilitas.idkomponenkapabilitas) ON Pegawai.NIK = Kapabilitas.NIK WHERE (((Pegawai.NIK)='" & txtPegawai.Text & "') AND (([Komponen Kapabil].[nama komponen])='" & komponenKapabil & "') AND ((Kapabilitas.bulan)=" & cboBulan.SelectedIndex + 1 & ") AND ((Kapabilitas.tahun)=" & cboTahun.Text & "))")
                    drNilaiKapabil.Read()
                    If drNilaiKapabil.HasRows Then
                        nilaikomponenKapabil = drNilaiKapabil(0)
                        gridKapabil.Rows(ikapabil).Cells("Nilai").Value = nilaikomponenKapabil
                    End If
                    drNilaiKapabil.Close()
                Next
            End If
        End If
    End Sub


    Private Sub txtPegawai_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPegawai.MouseClick
        Lookup.sql = "select [nik],nama as [Nama Pegawai] from pegawai p, [unit kerja] u where p.idunitkerja=u.idunitkerja and u.[nama unit kerja]='" & cboUnitKerja.Text & "' order by [nama unit kerja],nik"
        Lookup.DoShow()
        If Lookup.dipilih Then
            txtPegawai.Text = Lookup.idfield
            lblNamaPegawai.Text = Lookup.labelfield
        End If

        fillData()
        AbsensiBindingNavigatorSaveItem.Enabled = True
    End Sub

    Private Sub cboBulan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBulan.SelectedIndexChanged
        fillData()
    End Sub

    Private Sub cboTahun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTahun.SelectedIndexChanged
        fillData()
    End Sub

    Private Sub txtPegawai_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPegawai.TextChanged

    End Sub

    Private Sub AbsensiDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AbsensiDataGridView.CellContentClick

    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub TableLayoutPanel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Close()
    End Sub

    Private Sub cboUnitKerja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUnitKerja.SelectedIndexChanged
        AbsensiDataGridView.Visible = False
        txtPegawai.Text = "<<Klik disini>>"
        lblNamaPegawai.Text = "Pilih karyawan"
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class