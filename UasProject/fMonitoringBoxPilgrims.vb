Imports MySql.Data.MySqlClient
Imports System.Data
Public Class fMonitoringBoxPilgrims
    Dim myData As New DataTable
    Dim myAdapter As New MySqlDataAdapter
    Dim myCommand As New MySqlCommand
    Dim globalQuery As String = "SELECT " &
                           "users.family_id, " &
                           "users.fullName, " &
                           "users.role, " &
                           "users.province, " &
                           "users.city, " &
                           "users.subdistrict, " &
                           "users.vilage, " &
                           "pilgrimsbox.total, " &
                           "pilgrimsbox.mounthYear, " &
                           "pilgrimsbox.createdAt " &
                           "FROM users INNER JOIN pilgrimsbox " &
                           "ON users.family_id = pilgrimsbox.NIKID "
    Public Sub getSaldo(Optional ByVal query As String = "")
        Dim sqlQuery As String
        Try
            If tSearchPillgrimsByName.Text = "" Then
                Select Case isLoggedin
                    Case "Admin Center"
                        sqlQuery = globalQuery & query
                    Case "Admin Province"
                        sqlQuery = globalQuery & query
                    Case "Admin City"
                        sqlQuery = globalQuery & query
                    Case "Admin District"
                        sqlQuery = globalQuery & query
                    Case "Admin Village"
                        sqlQuery = globalQuery & "WHERE regionAdminID ='" & regionIdAdmin & "'"

                End Select
            Else
                Select Case isLoggedin
                    Case "Admin Center"
                        sqlQuery = globalQuery & "WHERE fullName LIKE '%" & tSearchPillgrimsByName.Text & "%'"
                    Case "Admin Province"
                        sqlQuery = globalQuery & "WHERE province ='" & isProvince & "' AND fullName LIKE '%" & tSearchPillgrimsByName.Text & "%'"
                    Case "Admin City"
                        sqlQuery = globalQuery & "WHERE city ='" & isCity & "' AND fullName LIKE '%" & tSearchPillgrimsByName.Text & "%'"
                    Case "Admin District"
                        sqlQuery = globalQuery & "WHERE subdistrict ='" & isDistrict & "' AND fullName LIKE '%" & tSearchPillgrimsByName.Text & "%'"
                    Case "Admin Village"
                        sqlQuery = globalQuery & "WHERE regionAdminID ='" & regionIdAdmin & "' AND fullName LIKE '%" & tSearchPillgrimsByName.Text & "%'"
                End Select
            End If
            myCommand.Connection = conn
            myCommand.CommandText = sqlQuery
            myAdapter.SelectCommand = myCommand
            myData = New DataTable
            myAdapter.Fill(myData)
            dPillgrimsBoxSHow.DataSource = myData
            dPillgrimsBoxSHow.ReadOnly = True
            disconetDb()
        Catch ex As Exception
            MsgBox("err " & ex.Message)
        End Try
    End Sub

    Sub getProvince()
        Try
            connDb()
            Dim sqlQuery = "SELECT * FROM provinces"
            myCommand.Connection = conn
            myCommand.CommandText = sqlQuery
            myAdapter.SelectCommand = myCommand
            myData = New DataTable
            myAdapter.Fill(myData)
            disconetDb()
            cProvince.DataSource = myData
            cProvince.ValueMember = "id"
            cProvince.DisplayMember = "name"

            Select Case isLoggedin
                Case "Admin Center"
                    cProvince.Enabled = True
                    cCity.Enabled = True
                    cDistrict.Enabled = True
                    cVillage.Enabled = True
                Case "Admin Province"
                    cProvince.Text = isProvince
                    cProvince.Enabled = False
                Case "Admin City"
                    cProvince.Text = isProvince
                    cProvince.Enabled = False
                    cCity.Text = isCity
                    cCity.Enabled = False
                Case "Admin District"
                    cProvince.Text = isProvince
                    cProvince.Enabled = False
                    cCity.Text = isCity
                    cCity.Enabled = False
                    cDistrict.Text = isDistrict
                    cDistrict.Enabled = False
                Case "Admin Village"
                    cProvince.Text = isProvince
                    cProvince.Enabled = False
                    cCity.Text = isCity
                    cCity.Enabled = False
                    cDistrict.Text = isDistrict
                    cDistrict.Enabled = False
                    cVillage.Text = isVillage
                    cVillage.Enabled = False
            End Select
        Catch ex As Exception
            MsgBox("err " & ex.Message)
        End Try

    End Sub
    Public Sub getPilgrims()
        If Not isLoggedin = "Admin Village" Then
            Label9.Hide()
            Label8.Hide()
            Label6.Hide()
            cPilgrimsTopUp.Hide()
            cTotalTopUp.Hide()
            dTopUp.Hide()
            btnTopUp.Hide()
        End If
        Try
            connDb()
            Dim sqlQuery = "SELECT * FROM users WHERE regionAdminID ='" & regionIdAdmin & "'"
            myCommand.Connection = conn
            myCommand.CommandText = sqlQuery
            myAdapter.SelectCommand = myCommand
            myData = New DataTable
            myAdapter.Fill(myData)
            disconetDb()
            cPilgrimsTopUp.DataSource = myData
            cPilgrimsTopUp.ValueMember = "family_id"
            cPilgrimsTopUp.DisplayMember = "fullName"

            dTopUp.Format = DateTimePickerFormat.Custom
            dTopUp.CustomFormat = "MMMM - yyyy"
        Catch ex As Exception
            MsgBox("err " & ex.Message)
            disconetDb()
        End Try
    End Sub
    Private Sub fMonitoringBoxPilgrims_Load(sender As Object, e As EventArgs) Handles MyBase.Load, tSearchPillgrimsByName.TextChanged
        getSaldo()
        getProvince()
        getPilgrims()
        dPillgrimsBoxSHow.RowsDefaultCellStyle.SelectionBackColor = Color.Green
    End Sub

    Private Sub btnTopUp_Click(sender As Object, e As EventArgs) Handles btnTopUp.Click
        Dim mounthYear = dTopUp.Value.ToString("MMMM - yyyy")
        Dim familyId = cPilgrimsTopUp.SelectedValue.ToString
        Dim total = cTotalTopUp.Value.ToString
        Try
            If familyId = "" OrElse total = "" Then
                MsgBox("Top Up owner name is required")
            Else
                connDb()
                Dim sqlQuery As String = "INSERT INTO pilgrimsbox (NIKID, mounthYear, total, createdAt) VALUES ('" & familyId & "', '" & mounthYear & "', '" & total & "', '" & dTopUp.Value.ToString & "')"
                myCommand.Connection = conn
                myCommand.CommandText = sqlQuery
                myCommand.ExecuteNonQuery()
                disconetDb()
                MsgBox("Success")
                getSaldo()
            End If
        Catch ex As Exception
            MsgBox("Err " & ex.Message)
            disconetDb()
        End Try
    End Sub
    Private Sub cProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cProvince.SelectedIndexChanged
        Dim id As String = cProvince.SelectedValue.ToString
        If Not IsNothing(id) Then
            Try
                connDb()
                Dim sqlQuery = "SELECT * FROM regencies WHERE province_id ='" & id & "'"
                myCommand.Connection = conn
                myCommand.CommandText = sqlQuery
                myAdapter.SelectCommand = myCommand
                myData = New DataTable
                myAdapter.Fill(myData)
                disconetDb()
                cCity.DataSource = myData
                cCity.ValueMember = "id"
                cCity.DisplayMember = "name"
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show(ex.Message)
                disconetDb()
            End Try
        End If
    End Sub
    Private Sub cCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cCity.SelectedIndexChanged
        Dim id As String = cCity.SelectedValue.ToString
        If Not IsNothing(id) Then
            Try
                connDb()
                Dim sqlQuery = "SELECT * FROM districts WHERE regency_id ='" & id & "'"
                myCommand.Connection = conn
                myCommand.CommandText = sqlQuery
                myAdapter.SelectCommand = myCommand
                myData = New DataTable
                myAdapter.Fill(myData)
                disconetDb()
                cDistrict.DataSource = myData
                cDistrict.ValueMember = "id"
                cDistrict.DisplayMember = "name"
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show(ex.Message)
                disconetDb()
            End Try
        End If
    End Sub

    Private Sub cDistrict_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cDistrict.SelectedIndexChanged
        Dim id As String = cDistrict.SelectedValue.ToString
        If Not IsNothing(id) Then
            Try
                connDb()
                Dim sqlQuery = "SELECT * FROM villages WHERE district_id ='" & id & "'"
                myCommand.Connection = conn
                myCommand.CommandText = sqlQuery
                myAdapter.SelectCommand = myCommand
                myData = New DataTable
                myAdapter.Fill(myData)
                disconetDb()
                cVillage.DataSource = myData
                cVillage.ValueMember = "id"
                cVillage.DisplayMember = "name"
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show(ex.Message)
                disconetDb()
            End Try
        End If
    End Sub

    Private Sub btnFilterProvince_Click(sender As Object, e As EventArgs) Handles btnFilterProvince.Click
        Dim query As String = "WHERE users.province = '" & cProvince.Text.ToString & "'"
        If isLoggedin = "Admin Center" OrElse isLoggedin = "Admin Province" Then
            getSaldo(query)
        End If
    End Sub

    Private Sub btnFilterCity_Click(sender As Object, e As EventArgs) Handles btnFilterCity.Click
        Dim query As String = "WHERE users.province = '" & cProvince.Text.ToString & "' AND users.city = '" & cCity.Text.ToString & "'"
        If isLoggedin = "Admin Center" OrElse isLoggedin = "Admin Province" OrElse isLoggedin = "Admin City" Then
            getSaldo(query)
        End If
    End Sub

    Private Sub btnFilterDistrict_Click(sender As Object, e As EventArgs) Handles btnFilterDistrict.Click
        Dim query As String = "WHERE users.province = '" & cProvince.Text.ToString & "' AND " &
        "users.city = '" & cCity.Text.ToString & "' AND users.subdistrict = '" & cDistrict.Text.ToString & "'"
        If isLoggedin = "Admin Center" OrElse isLoggedin = "Admin Province" OrElse isLoggedin = "Admin City" OrElse isLoggedin = "Admin District" Then
            getSaldo(query)
        End If
    End Sub

    Private Sub btnFilterVillage_Click(sender As Object, e As EventArgs) Handles btnFilterVillage.Click
        Dim query As String = "WHERE users.province = '" & cProvince.Text.ToString & "' AND " &
        "users.city = '" & cCity.Text.ToString & "' AND " &
        "users.subdistrict = '" & cDistrict.Text.ToString & "' AND users.vilage = '" & cVillage.Text.ToString & "'"
        If isLoggedin = "Admin Center" OrElse isLoggedin = "Admin Province" OrElse isLoggedin = "Admin City" OrElse isLoggedin = "Admin District" Then
            getSaldo(query)
        End If
    End Sub
End Class