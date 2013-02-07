

Partial Public Class DataSet
    Partial Class Unit_KerjaDataTable

        Private Sub Unit_KerjaDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.idunitkerjaColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
