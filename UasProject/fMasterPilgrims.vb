Imports MySql.Data.MySqlClient
Imports System.Data
Public Class fMasterPilgrims
    Dim myData As New DataTable
    Dim myAdapter As New MySqlDataAdapter
    Dim myCommand As New MySqlCommand
    Dim stt As String = "Active"
    Dim isStatus As String = "Pilgrims"
    Dim queryGlobal As String = "SELECT id, family_id, username, fullName, role, country, province, city, subdistrict, vilage, status  FROM users " &
    "WHERE status = '" & stt & "' AND role  = '" & isStatus & "'"
    Sub getPilgrim(Optional ByVal query As String = "")
        'myData.Clear()
        Try
            connDb()
            Dim sqlQuery As String
            If tSearchPilgrims.Text = "" Then
                Select Case isLoggedin
                    Case "Admin Center"
                        sqlQuery = queryGlobal & query
                    Case "Admin Province"
                        sqlQuery = queryGlobal & query & "AND province = '" & isProvince & "'"
                    Case "Admin City"
                        sqlQuery = queryGlobal & query & "AND city = '" & isCity & "'"
                    Case "Admin District"
                        sqlQuery = queryGlobal & query & "AND subdistrict = '" & isDistrict & "'"
                    Case "Admin Village"
                        sqlQuery = queryGlobal & "AND regionAdminID = '" & regionIdAdmin & "'"
                End Select
            Else
                Select Case isLoggedin
                    Case "Admin Center"
                        sqlQuery = queryGlobal & " AND fullname LIKE '%" & tSearchPilgrims.Text & "%' AND role LIKE '%" & isStatus & "%'"
                    Case "Admin Province"
                        sqlQuery = queryGlobal & "AND province = '" & isProvince & "' AND fullname LIKE '%" & tSearchPilgrims.Text & "%' AND role LIKE '%" & isStatus & "%'"
                    Case "Admin City"
                        sqlQuery = queryGlobal & "AND city = '" & isCity & "' AND fullname LIKE '%" & tSearchPilgrims.Text & "%' AND role LIKE '%" & isStatus & "%'"
                    Case "Admin District"
                        sqlQuery = queryGlobal & "AND subdistrict = '" & isDistrict & "' AND fullname LIKE '%" & tSearchPilgrims.Text & "%' AND role LIKE '%" & isStatus & "%'"
                    Case "Admin Village"
                        sqlQuery = queryGlobal & "AND regionAdminID = '" & regionIdAdmin & "' AND fullname LIKE '%" & tSearchPilgrims.Text & "%' AND role LIKE '%" & isStatus & "%'"
                End Select
            End If
            myCommand.Connection = conn
            myCommand.CommandText = sqlQuery
            myAdapter.SelectCommand = myCommand
            myData = New DataTable
            myAdapter.Fill(myData)
            DataGridView1.DataSource = myData
            DataGridView1.ReadOnly = True
            disconetDb()
            totalDanaBox.Text = countBox("id") & " DanaBox"
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
            disconetDb()
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
                    cVlge.Enabled = True
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
                    cVlge.Text = isVillage
                    cVlge.Enabled = False
            End Select
        Catch ex As Exception
            MsgBox("err " & ex.Message)
        End Try
    End Sub


    Private Sub fMasterPilgrims_Load(sender As Object, e As EventArgs) Handles MyBase.Load, tSearchPilgrims.TextChanged
        getPilgrim()
        getProvince()
        DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Green
        If isLoggedin = "Admin Center" OrElse isLoggedin = "Admin Village" Then
            btnAdmin.Hide()
        End If

        Select Case isLoggedin
            Case "Admin Province"
                btnUpdate.Hide()
            Case "Admin City"
                btnUpdate.Hide()
            Case "Admin District"
                btnUpdate.Hide()
        End Select

    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        getPilgrim()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If isLoggedin = "Admin Center" Then
            fDashboardAdmin.switchPanel(New fAddAdmin())
        Else
            fAdminVillage.switchPanelVillage(New fAddAdmin())
        End If
    End Sub

    Private Function countBox(ByVal params As String)
        Dim count As Double = (From dgvrow In DataGridView1.Rows
                               Select CInt(CType(dgvrow, DataGridViewRow).Cells(params).Value)).Count()
        Return count - 1
    End Function

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
                Dim sqlQuery = "SELECT * FROM villages WHERE district_id = '" & id & "'"
                myCommand.Connection = conn
                myCommand.CommandText = sqlQuery
                myAdapter.SelectCommand = myCommand
                myData = New DataTable
                myAdapter.Fill(myData)
                disconetDb()
                cVlge.DataSource = myData
                cVlge.ValueMember = "id"
                cVlge.DisplayMember = "name"
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show(ex.Message)
                disconetDb()
            End Try
        End If
    End Sub

    Private Sub btnFilterProvince_Click(sender As Object, e As EventArgs) Handles btnFilterProvince.Click
        Dim req As String = " AND province = '" & cProvince.Text.ToString & "'"
        If isLoggedin = "Admin Center" Then
            getPilgrim(req)
        End If
    End Sub

    Private Sub btnFilterCity_Click(sender As Object, e As EventArgs) Handles btnFilterCity.Click
        If isLoggedin = "Admin Center" OrElse isLoggedin = "Admin Province" Then
            Dim req As String = " AND province = '" & cProvince.Text.ToString & "' AND city = '" & cCity.Text.ToString & "'"
            getPilgrim(req)
        End If
    End Sub

    Private Sub btnFIlterDistrict_Click(sender As Object, e As EventArgs) Handles btnFIlterDistrict.Click
        If isLoggedin = "Admin Center" OrElse isLoggedin = "Admin Province" OrElse isLoggedin = "Admin City" Then
            Dim req As String = " AND province = '" & cProvince.Text.ToString & "'" &
                                "AND city = '" & cCity.Text.ToString & "' AND subdistrict = '" & cDistrict.Text.ToString & "'"
            getPilgrim(req)
        End If
    End Sub

    Private Sub btnFilterVillage_Click(sender As Object, e As EventArgs) Handles btnFilterVillage.Click
        If isLoggedin = "Admin Center" OrElse isLoggedin = "Admin Province" OrElse isLoggedin = "Admin City" OrElse isLoggedin = "Admin District" Then
            Dim req As String = " AND province = '" & cProvince.Text.ToString & "' " &
                                "AND city = '" & cCity.Text.ToString & "' AND subdistrict = '" & cDistrict.Text.ToString & "' " &
                                "AND vilage = '" & cVlge.Text.ToString & "'"
            getPilgrim(req)
        End If
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        fAdminVillage.switchPanelVillage(fAdminMaster)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim id As String = DataGridView1.CurrentRow.Cells("id").Value.ToString
        Dim family_id As String = DataGridView1.CurrentRow.Cells("family_id").Value.ToString
        Dim username As String = DataGridView1.CurrentRow.Cells("username").Value.ToString
        Dim fullname As String = DataGridView1.CurrentRow.Cells("fullName").Value.ToString
        Dim role As String = DataGridView1.CurrentRow.Cells("role").Value.ToString
        Dim country As String = DataGridView1.CurrentRow.Cells("country").Value.ToString
        Dim province As String = DataGridView1.CurrentRow.Cells("province").Value.ToString
        Dim city As String = DataGridView1.CurrentRow.Cells("city").Value.ToString
        Dim subdistrict As String = DataGridView1.CurrentRow.Cells("subdistrict").Value.ToString
        Dim vilage As String = DataGridView1.CurrentRow.Cells("vilage").Value.ToString
        Dim status As String = DataGridView1.CurrentRow.Cells("status").Value.ToString

        Dim candidateUpdate As New Dictionary(Of String, String)()
        candidateUpdate.Add("id", id)
        candidateUpdate.Add("family_id", family_id)
        candidateUpdate.Add("username", username)
        candidateUpdate.Add("fullName", fullname)
        candidateUpdate.Add("role", role)
        candidateUpdate.Add("country", country)
        candidateUpdate.Add("province", province)
        candidateUpdate.Add("city", city)
        candidateUpdate.Add("subdistrict", subdistrict)
        candidateUpdate.Add("vilage", vilage)
        candidateUpdate.Add("status", status)

        If isLoggedin = "Admin Village" Then
            fAdminVillage.switchPanelVillage(New fAddAdmin(candidateUpdate, True))
        Else
            fDashboardAdmin.switchPanel(New fAddAdmin(candidateUpdate, True))
        End If
    End Sub
End Class