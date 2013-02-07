Imports System.Windows.Forms

Public Class ManajemenPemakai

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PemakaiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PemakaiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub ManajemenPemakai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.Pemakai' table. You can move, or remove it, as needed.
        Me.PemakaiTableAdapter.Fill(Me.DataSet.Pemakai)
        'TODO: This line of code loads data into the 'DataSet.Pemakai' table. You can move, or remove it, as needed.
        '        Me.PemakaiTableAdapter.Fill(Me.DataSet.Pemakai)

    End Sub

    Private Sub PemakaiBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PemakaiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PemakaiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub
End Class
