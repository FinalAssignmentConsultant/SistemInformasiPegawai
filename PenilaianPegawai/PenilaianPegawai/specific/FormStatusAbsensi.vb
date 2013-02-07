Public Class FormStatusAbsensi

    Private Sub Status_AbsensiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Status_AbsensiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Status_AbsensiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub FormStatusAbsensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Status_AbsensiTableAdapter.Fill(Me.DataSet.Status_Absensi)
    End Sub
End Class