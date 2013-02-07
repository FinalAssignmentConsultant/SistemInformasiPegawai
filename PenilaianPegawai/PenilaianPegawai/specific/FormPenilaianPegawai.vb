Imports System.Data.Odbc

Public Class FormPenilaianPegawai

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub FormLoginPeserta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.detail_laporan_kapabil' table. You can move, or remove it, as needed.
        ' Me.Detail_laporan_kapabilTableAdapter.Fill(Me.DataSet.detail_laporan_kapabil)
        'TODO: This line of code loads data into the 'DataSet.detail_laporan' table. You can move, or remove it, as needed.
        ' Me.Detail_laporanTableAdapter.Fill(Me.DataSet.detail_laporan)
        'TODO: This line of code loads data into the 'DataSet1.Tahun' table. You can move, or remove it, as needed.
        '  Me.TahunTableAdapter.Fill(Me.DataSet1.Tahun)
        'TODO: This line of code loads data into the 'DataSet.status_absensi' table. You can move, or remove it, as needed.
        Me.Status_absensiTableAdapter.Fill(Me.DataSet.status_absensi)
        'TODO: This line of code loads data into the 'DataSet.absensi' table. You can move, or remove it, as needed.
        Me.AbsensiTableAdapter.Fill(Me.DataSet.absensi)
        'TODO: This line of code loads data into the 'DataSet.laporan' table. You can move, or remove it, as needed.
        ' Me.LaporanTableAdapter.Fill(Me.DataSet.laporan)
        'TODO: This line of code loads data into the 'DataSet.absensi_detail' table. You can move, or remove it, as needed.
        'Me.Absensi_detailTableAdapter.Fill(Me.DataSet.absensi_detail)
        'TODO: This line of code loads data into the 'DataSet.Tahun' table. You can move, or remove it, as needed.
        ' Me.TahunTableAdapter.Fill(Me.DataSet.Tahun)
        'TODO: This line of code loads data into the 'DataSet.bulan' table. You can move, or remove it, as needed.
        'Me.BulanTableAdapter.Fill(Me.DataSet.bulan)
        'TODO: This line of code loads data into the 'DataSet.unit_kerja' table. You can move, or remove it, as needed.
        Me.Unit_kerjaTableAdapter.Fill(Me.DataSet.unit_kerja)
        'TODO: This line of code loads data into the 'DataSet.pegawai' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DataSet.Peserta' table. You can move, or remove it, as needed.
        '  Me.PesertaTableAdapter.Fill(Me.DataSet.Peserta)
       

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TambahPeserta.MdiParent = MainForm
        'TambahPeserta.Show()

    End Sub

    Private Sub btnTutup_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub PegawaiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PegawaiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub
    Private Sub filldata()
        Me.PegawaiTableAdapter.Fill(Me.DataSet.pegawai)
        If Not IsNumeric(txtUnitKerja.Text) Then
            PegawaiBindingSource1.Filter = "[nama unit kerja]=" & findid("idunitkerja", "[unit kerja]", "[nama unit kerja]='" & txtUnitKerja.Text & "'")
        End If
    End Sub
  

   

    Private Sub txtUnitKerja_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtUnitKerja.MouseClick
        Lookup.sql = "select [nama unit kerja],idunitkerja  from [unit kerja]"
        Lookup.DoShow()
        If Lookup.dipilih Then txtUnitKerja.Text = Lookup.idfield
        filldata()
    End Sub

   

    
    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click

    End Sub

    Private Sub txtUnitKerja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnitKerja.TextChanged

    End Sub
End Class