Imports System.Data.Odbc

Module MainModule
    Public password As String
    Public Pemakai As String
    Public IdPemakai As Integer
    Public Peran As String
    Public con As Odbc.OdbcConnection = New Odbc.OdbcConnection("dsn=didik")
    Public Sub init()
        con.Open()
    End Sub
    Public Sub log(ByVal s As String)
        FormProsesLaporan.lstOutput.Items.Insert(0, s)
    End Sub
    Public Function GetData(ByVal sqlCommand As String) As DataTable
        Dim command As New OdbcCommand(sqlCommand, con)
        Dim adapter As OdbcDataAdapter = New OdbcDataAdapter()
        adapter.SelectCommand = command

        Dim table As New DataTable
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        Return table

    End Function
    Public Sub IsiDataGrid(ByVal DataGridView1 As DataGridView, ByVal Sql As String, ByRef BindingSource1 As BindingSource)
        With DataGridView1
            ' Automatically generate the DataGridView columns.
            .AutoGenerateColumns = True

            ' Set up the data source.
            bindingSource1.DataSource = GetData(Sql)
            .DataSource = bindingSource1

            ' Automatically resize the visible rows.
            .AutoSizeRowsMode = _
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersVisible = False

            ' Set the DataGridView control's border.
            .BorderStyle = BorderStyle.Fixed3D

            ' Put the cells in edit mode when user enters them.
            .EditMode = DataGridViewEditMode.EditOnEnter

            .Columns(.ColumnCount - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
    End Sub

    Public Function findid(ByVal KolomKode As String, ByVal TableName As String, ByVal Where As String) As String
        Dim sql As String = "select " & KolomKode & " from " & TableName & " where " & Where
        Dim cmd As New OdbcCommand(sql, con)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        Dim hasil As String
        If dr.Read Then
            If Not IsDBNull(dr(0)) Then
                hasil = dr(0)
            Else
                hasil = 0
            End If

        Else
            hasil = 0
        End If

        dr.Close()
        cmd.Dispose()
        Return hasil
    End Function
    Public Sub explain(ByVal value As String, ByVal lbl As Label, ByVal kolomId As String, ByVal kolomLabel As String, ByVal tabel As String, ByVal where As String)
        Dim cmd As Odbc.OdbcCommand
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String

        lbl.Text = ""
        sql = "select " & kolomId & "," & kolomLabel & " from " & tabel & "  where " & where & ""
        cmd = New Odbc.OdbcCommand(sql, con)
        dr = cmd.ExecuteReader
        If dr.Read Then lbl.Text = dr.GetString(1)
        dr.Close()
        cmd.Dispose()
    End Sub
    Public Sub runCommand(ByVal sql As String, ByVal trans As OdbcTransaction)
        Dim cmd As OdbcCommand
        cmd = New OdbcCommand(sql, con, trans)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Sub runCommand(ByVal sql As String)
        Dim cmd As OdbcCommand
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Function runQuery(ByVal sql As String, ByVal trans As OdbcTransaction) As OdbcDataReader
        Dim cmd As OdbcCommand
        Dim dr As OdbcDataReader
        If trans Is Nothing Then
            cmd = New OdbcCommand(sql, con)
        Else
            cmd = New OdbcCommand(sql, con, trans)
        End If
        dr = cmd.ExecuteReader()
        cmd.Dispose()
        Return dr
    End Function
    Public Function runQuery(ByVal sql As String) As OdbcDataReader
        Dim cmd As OdbcCommand
        Dim dr As OdbcDataReader
        cmd = New OdbcCommand(sql, con)
        dr = cmd.ExecuteReader()
        cmd.Dispose()
        Return dr
    End Function

End Module
