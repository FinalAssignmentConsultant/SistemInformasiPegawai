Imports System.Data.Odbc

Public Class FormLoginPeserta

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PesertaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PesertaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetTechSupport)

    End Sub

    Private Sub FormLoginPeserta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetTechSupport.Peserta' table. You can move, or remove it, as needed.
        Me.PesertaTableAdapter.Fill(Me.DataSetTechSupport.Peserta)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TambahPeserta.MdiParent = MainForm
        TambahPeserta.Show()

    End Sub

    Private Sub btnTutup_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Close()
    End Sub

    Private Sub btnLanjutkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLanjutkan.Click
        NIP_test = cboNIP.Text
        Close()
        Dim cmd As OdbcCommand
        cmd = New OdbcCommand("delete from test where nip = '" & NIP_test & "'", con)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New OdbcCommand("insert into test(nip,nama) values('" & NIP_test & "'," & IdPemakai & ")", con)
        cmd.ExecuteNonQuery()
        Peran = "Peserta"
        MainForm.sesuaikanPeran()
        FormTest.MulaiTest()
        FormTest.MdiParent = MainForm
        FormTest.Show()
    End Sub
End Class