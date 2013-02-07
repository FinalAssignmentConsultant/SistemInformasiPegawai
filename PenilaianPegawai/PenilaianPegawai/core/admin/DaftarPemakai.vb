Imports System.Windows.Forms

Public Class DaftarPemakai

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim sql As String = "insert into pemakai(nama,[password],[hak akses])values('" & TextBoxNama.Text & "','" & TextBoxPassword.Text & "','Siswa')"
        Dim cmd As New Odbc.OdbcCommand(sql, con)
        Dim id As Integer

        If TextBoxNama.Text = "" Or TextBoxPassword.Text = "" Or TextBoxKelas.Text = "" Or TextBoxNIS.Text = "" Then
            MessageBox.Show("Maaf, data siswa belum lengkap. " & vbCrLf & "Lengkapi terlebih dahulu", "Validasi Data", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        sql = "select id from pemakai where nama='" & TextBoxNama.Text & "'"
        cmd = New Odbc.OdbcCommand(sql, con)
        Dim dr As Odbc.OdbcDataReader
        dr = cmd.ExecuteReader
        If dr.Read Then
            id = dr.GetValue(0)
        End If
        dr.Close()
        cmd.Dispose()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    


End Class
