Imports System.Text
Imports MySql.Data.MySqlClient
Module ModuleDBConn
    Public conn As New MySql.Data.MySqlClient.MySqlConnection


    Public Sub connDb()
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
            & "uid=apuystereo;" _
            & "pwd=dewabulan;" _
            & "database=danabox"

        Try
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
            conn.ConnectionString = myConnectionString
            conn.Open()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("Connection to database failed." & ex.Message)
        End Try
    End Sub

    Public Sub disconetDb()
        conn.Close()
    End Sub
End Module
