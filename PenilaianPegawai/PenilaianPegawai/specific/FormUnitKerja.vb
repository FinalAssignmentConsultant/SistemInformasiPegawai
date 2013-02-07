Public Class FormUnitKerja
    Private Sub Unit_KerjaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unit_KerjaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Unit_KerjaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub FormUnitKerja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim iPegawai As Integer = 1
        Me.Komponen_KapabilTableAdapter.Fill(Me.DataSet.Komponen_Kapabil)
              Me.Unit_KerjaTableAdapter.Fill(Me.DataSet.Unit_Kerja)
        iPegawai = iPegawai + 1
        Unit_KerjaDataGridView.Rows(Unit_KerjaDataGridView.RowCount - 1).Cells("No").Value = iPegawai


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Komponen_KapabilDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Komponen_KapabilDataGridView.CellContentClick

    End Sub

    Private Sub Unit_KerjaBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unit_KerjaBindingNavigator.RefreshItems

    End Sub

    Private Sub Unit_KerjaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Unit_KerjaDataGridView.CellContentClick

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub
End Class