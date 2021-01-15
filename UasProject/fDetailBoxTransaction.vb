Imports MySql.Data.MySqlClient
Imports System.Data
Public Class fDetailBoxTransaction
    Dim myData As New DataTable
    Dim myAdapter As New MySqlDataAdapter
    Dim myCommand As New MySqlCommand
    Dim globalQuery As String = "SELECT " &
                                "savesbox.id, " &
                                "savesbox.monthYear, " &
                                "villages.`name` As village, " &
                                "savesbox.totalNotDIvision AS total, " &
                                "savesbox.incomeCollector, " &
                                "savesbox.incomeVillage, " &
                                "districts.`name` As district, " &
                                "savesbox.incomeDIstrict, " &
                                "regencies.`name` As city, " &
                                "savesbox.incomeCity, " &
                                "provinces.`name` As province, " &
                                "savesbox.incomeProvince, " &
                                "savesbox.incomeCenter " &
                                "FROM savesbox INNER JOIN villages ON " &
                                "savesbox.villageID = villages.id " &
                                "INNER JOIN districts On " &
                                "savesbox.districtID = districts.id " &
                                "INNER JOIN regencies On " &
                                "savesbox.cityID = regencies.id " &
                                "INNER JOIN provinces On " &
                                "savesbox.provinceID = provinces.id "

    Public Sub getData(Optional params As String = "")
        Dim sqlQuery As String
        Try
            Select Case isLoggedin
                Case "Admin Center"
                    sqlQuery = globalQuery & params & " AND savesbox.monthYear = '" & dFilterMounth.Value.ToString("MMMM - yyyy") & "'"
                Case "Admin Province"
                    sqlQuery = globalQuery & params & " AND savesbox.provinceID = '" & regionIdAdmin.ToString & "' AND savesbox.monthYear = '" & dFilterMounth.Value.ToString("MMMM - yyyy") & "'"
                Case "Admin City"
                    sqlQuery = globalQuery & params & " AND savesbox.cityID = '" & regionIdAdmin.ToString & "' AND savesbox.monthYear = '" & dFilterMounth.Value.ToString("MMMM - yyyy") & "'"
                Case "Admin District"
                    sqlQuery = globalQuery & params & " AND savesbox.districtID = '" & regionIdAdmin.ToString & "' AND savesbox.monthYear = '" & dFilterMounth.Value.ToString("MMMM - yyyy") & "'"
                Case "Admin Village"
                    sqlQuery = globalQuery & params & " WHERE savesbox.villageID = '" & regionIdAdmin.ToString & "' AND savesbox.monthYear = '" & dFilterMounth.Value.ToString("MMMM - yyyy") & "'"
            End Select
            connDb()
            myCommand.Connection = conn
            myCommand.CommandText = sqlQuery
            myAdapter.SelectCommand = myCommand
            myData = New DataTable
            myAdapter.Fill(myData)

            dGridDetail.DataSource = myData
            dGridDetail.ReadOnly = True
            disconetDb()
        Catch ex As Exception
            MsgBox("Err " & ex.Message)
        End Try
    End Sub
    Private Sub fDetailBoxTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getData()
        getProvince()
        dGridDetail.RowsDefaultCellStyle.SelectionBackColor = Color.Green

        SumTotal.Text = "Rp " & sumDetail("total")
        SumIncomeCenter.Text = "Rp " & sumDetail("incomeCenter")
        SumIncomeProvince.Text = "Rp " & sumDetail("incomeProvince")
        sumIncomeCIty.Text = "Rp " & sumDetail("incomeCity")
        sumIncomeDistrict.Text = "Rp " & sumDetail("incomeDIstrict")
        sumIncomeVillage.Text = "Rp " & sumDetail("incomeVillage")
        sumIncomeCollectors.Text = "Rp " & sumDetail("incomeCollector")

        PincomeProvince.BackColor = Color.Green
        PIncomeCity.BackColor = Color.Green
        PincomeDistrict.BackColor = Color.Green
        PincomeIncomeVillage.BackColor = Color.Green
        dFilterMounth.Format = DateTimePickerFormat.Custom
        dFilterMounth.CustomFormat = "MMMM - yyyy"
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

    Public Function sumDetail(ByVal params As String)
        Dim sum As Double = (From dgvrow In dGridDetail.Rows
                             Select CInt(CType(dgvrow, DataGridViewRow).Cells(params).Value)).Sum()
        Return sum
    End Function

    Private Sub btnFilterProvince_Click(sender As Object, e As EventArgs) Handles btnFilterProvince.Click
        Dim query As String = "WHERE savesbox.provinceID = '" & cProvince.SelectedValue.ToString & "'"
        If isLoggedin = "Admin Center" Then
            getData(query)
            SumTotal.Text = "Rp " & sumDetail("total")
            SumIncomeCenter.Text = "Rp " & sumDetail("incomeCenter")
            SumIncomeProvince.Text = "Rp " & sumDetail("incomeProvince")
            sumIncomeCIty.Text = "Rp " & sumDetail("incomeCity")
            sumIncomeDistrict.Text = "Rp " & sumDetail("incomeDIstrict")
            sumIncomeVillage.Text = "Rp " & sumDetail("incomeVillage")
            sumIncomeCollectors.Text = "Rp " & sumDetail("incomeCollector")
            PincomeProvince.BackColor = Color.Red
            PIncomeCity.BackColor = Color.Green
            PincomeDistrict.BackColor = Color.Green
            PincomeIncomeVillage.BackColor = Color.Green
        End If
    End Sub

    Private Sub btnFilterCity_Click(sender As Object, e As EventArgs) Handles btnFilterCity.Click
        Dim query As String = "WHERE savesbox.provinceID = '" & cProvince.SelectedValue.ToString & "' AND savesbox.cityID = '" & cCity.SelectedValue.ToString & "'"
        If isLoggedin = "Admin Center" OrElse isLoggedin = "Admin Province" Then
            getData(query)
            SumTotal.Text = "Rp " & sumDetail("total")
            SumIncomeCenter.Text = "Rp " & sumDetail("incomeCenter")
            SumIncomeProvince.Text = "Rp " & sumDetail("incomeProvince")
            sumIncomeCIty.Text = "Rp " & sumDetail("incomeCity")
            sumIncomeDistrict.Text = "Rp " & sumDetail("incomeDIstrict")
            sumIncomeVillage.Text = "Rp " & sumDetail("incomeVillage")
            sumIncomeCollectors.Text = "Rp " & sumDetail("incomeCollector")
            PincomeProvince.BackColor = Color.Green
            PIncomeCity.BackColor = Color.Red
            PincomeDistrict.BackColor = Color.Green
            PincomeIncomeVillage.BackColor = Color.Green
        End If
    End Sub

    Private Sub btnFilterDistrict_Click(sender As Object, e As EventArgs) Handles btnFilterDistrict.Click
        Dim query As String = "WHERE savesbox.provinceID = '" & cProvince.SelectedValue.ToString & "'" &
            "And savesbox.cityID = '" & cCity.SelectedValue.ToString & "' AND savesbox.districtID = '" & cDistrict.SelectedValue.ToString & "'"
        If isLoggedin = "Admin Center" OrElse isLoggedin = "Admin Province" OrElse isLoggedin = "Admin City" Then
            getData(query)
            SumTotal.Text = "Rp " & sumDetail("total")
            SumIncomeCenter.Text = "Rp " & sumDetail("incomeCenter")
            SumIncomeProvince.Text = "Rp " & sumDetail("incomeProvince")
            sumIncomeCIty.Text = "Rp " & sumDetail("incomeCity")
            sumIncomeDistrict.Text = "Rp " & sumDetail("incomeDIstrict")
            sumIncomeVillage.Text = "Rp " & sumDetail("incomeVillage")
            sumIncomeCollectors.Text = "Rp " & sumDetail("incomeCollector")
            PincomeProvince.BackColor = Color.Green
            PIncomeCity.BackColor = Color.Green
            PincomeDistrict.BackColor = Color.Red
            PincomeIncomeVillage.BackColor = Color.Green
        End If
    End Sub

    Private Sub btnFilterVillage_Click(sender As Object, e As EventArgs) Handles btnFilterVillage.Click
        Dim query As String = "WHERE savesbox.provinceID = '" & cProvince.SelectedValue.ToString & "' " &
            "And savesbox.cityID = '" & cCity.SelectedValue.ToString & "' " &
            "And savesbox.districtID = '" & cDistrict.SelectedValue.ToString & "' AND savesbox.villageID = '" & cVillage.SelectedValue.ToString & "'"
        If isLoggedin = "Admin Center" OrElse isLoggedin = "Admin Province" OrElse isLoggedin = "Admin City" OrElse isLoggedin = "Admin District" Then
            getData(query)
            SumTotal.Text = "Rp " & sumDetail("total")
            SumIncomeCenter.Text = "Rp " & sumDetail("incomeCenter")
            SumIncomeProvince.Text = "Rp " & sumDetail("incomeProvince")
            sumIncomeCIty.Text = "Rp " & sumDetail("incomeCity")
            sumIncomeDistrict.Text = "Rp " & sumDetail("incomeDIstrict")
            sumIncomeVillage.Text = "Rp " & sumDetail("incomeVillage")
            sumIncomeCollectors.Text = "Rp " & sumDetail("incomeCollector")
            PincomeProvince.BackColor = Color.Green
            PIncomeCity.BackColor = Color.Green
            PincomeDistrict.BackColor = Color.Green
            PincomeIncomeVillage.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnFilterClear_Click(sender As Object, e As EventArgs) Handles btnFilterClear.Click
        getData()
        SumTotal.Text = "Rp " & sumDetail("total")
        SumIncomeCenter.Text = "Rp " & sumDetail("incomeCenter")
        SumIncomeProvince.Text = "Rp " & sumDetail("incomeProvince")
        sumIncomeCIty.Text = "Rp " & sumDetail("incomeCity")
        sumIncomeDistrict.Text = "Rp " & sumDetail("incomeDIstrict")
        sumIncomeVillage.Text = "Rp " & sumDetail("incomeVillage")
        sumIncomeCollectors.Text = "Rp " & sumDetail("incomeCollector")

        PincomeProvince.BackColor = Color.Green
        PIncomeCity.BackColor = Color.Green
        PincomeDistrict.BackColor = Color.Green
        PincomeIncomeVillage.BackColor = Color.Green
    End Sub

    Private Sub btnFilterDate_Click(sender As Object, e As EventArgs) Handles btnFilterDate.Click
        getData()
    End Sub
End Class