Imports System.Data.Odbc

Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim cmd As OdbcCommand
        Dim sql = "SELECT nama,password,[hak akses],id FROM pemakai WHERE nama = '" & UsernameTextBox.Text & "' AND Password = '" & PasswordTextBox.Text & "'"
        cmd = New OdbcCommand(sql, con)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        password = PasswordTextBox.Text
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
        Try
            If dr.Read = False Then 'tak ada data
                MessageBox.Show("Maaf, Anda tidak dikenal oleh sistem")
                dr.Close()
                Exit Sub
            Else 'ada data

                Pemakai = dr.GetString(0)
                IdPemakai = dr.GetInt32(3)
                Peran = dr.GetString(2)
                MainForm.Show()
                dr.Close()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("Kesalahan : " & ex.Message)
        End Try
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub LoginForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        UsernameTextBox.Focus()

    End Sub

    Private Sub LoginForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Text = Application.ProductName
        MainModule.init()
    End Sub

   
End Class
