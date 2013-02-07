Imports System.Windows.Forms
Imports System.Data.Odbc

Public Class FormUbahPassword

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim inpassword As String = ""

        If UCase(txtOldPass.Text) <> UCase(password) Then
            MessageBox.Show("Maaf, Password lama salah. Ulangi kembali", "Supervisor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim cmd As OdbcCommand
        Dim sql As String = "update pemakai set password='" & txtNewPass.Text & "'"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        password = txtNewPass.Text


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub FormUbahPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
