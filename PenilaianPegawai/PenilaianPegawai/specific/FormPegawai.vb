Public Class FormPegawai

    Private Sub PegawaiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegawaiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PegawaiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)
        MessageBox.Show("Penyimpanan berhasil", "Input data Pegawai", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub FormPegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IdunitkerjaTextBox.Visible = False
        PegawaiBindingNavigatorSaveItem.Enabled = False
        Me.Unit_kerjaTableAdapter.Fill(Me.DataSet.Unit_Kerja)
        Me.PegawaiTableAdapter.Fill(Me.DataSet.Pegawai)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Close()
    End Sub

    
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        PegawaiBindingNavigatorSaveItem.Enabled = True
    End Sub

    Private Sub IdunitkerjaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub IdunitkerjaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdunitkerjaTextBox.TextChanged
        If IdunitkerjaTextBox.Text <> "" Then
            txtNamaUnitKerja.Text = findid("[nama unit kerja]", "[unit kerja]", "idunitkerja=" & IdunitkerjaTextBox.Text)
        Else
            txtNamaUnitKerja.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Lookup.sql = " select idunitkerja, [nama unit kerja] from [unit kerja] order by [nama unit kerja]"
        Lookup.DoShow()
        If Lookup.dipilih Then
            IdunitkerjaTextBox.Text = Lookup.idfield
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        PegawaiBindingNavigatorSaveItem.Enabled = True
    End Sub
End Class