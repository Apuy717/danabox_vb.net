Imports MySql.Data.MySqlClient
Imports System.Data
Public Class fDeposit
    Dim myData As New DataTable
    Dim myAdapter As New MySqlDataAdapter
    Dim myCommand As New MySqlCommand

    Sub getLocation()
        Try
            connDb()
            Dim sqlQuery = "SELECT villages.id AS vilageID, " &
                            "villages.name AS vilageName, " &
                            "districts.id AS districtId, " &
                            "districts.name AS districtName, " &
                            "regencies.id AS cityId, " &
                            "regencies.name AS cityName, " &
                            "provinces.id AS provinceId, " &
                            "provinces.name AS provinceName " &
                            "FROM districts INNER JOIN villages ON districts.id = villages.district_id INNER JOIN regencies ON districts.regency_id = regencies.id INNER JOIN provinces ON regencies.province_id = provinces.id " &
                            "WHERE villages.id = '" & regionIdAdmin & "'"

            myCommand.Connection = conn
            myCommand.CommandText = sqlQuery
            myAdapter.SelectCommand = myCommand
            myData = New DataTable
            myAdapter.Fill(myData)
            disconetDb()
            tVillageIDDepo.DataSource = myData
            tVillageIDDepo.ValueMember = "vilageID"
            tVillageIDDepo.DisplayMember = "vilageName"
            tVillageIDDepo.Enabled = False

            'district
            tDistritIDDepo.DataSource = myData
            tDistritIDDepo.ValueMember = "districtId"
            tDistritIDDepo.DisplayMember = "districtName"
            tDistritIDDepo.Enabled = False
            'city
            tCitiIDDepo.DataSource = myData
            tCitiIDDepo.ValueMember = "cityId"
            tCitiIDDepo.DisplayMember = "cityName"
            tCitiIDDepo.Enabled = False

            'province
            tProvinceIDDepo.DataSource = myData
            tProvinceIDDepo.ValueMember = "provinceId"
            tProvinceIDDepo.DisplayMember = "provinceName"
            tProvinceIDDepo.Enabled = False
            tMoundYearDepo.Format = DateTimePickerFormat.Custom
            tMoundYearDepo.CustomFormat = "MMMM - yyyy"

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
            disconetDb()
        End Try
    End Sub
    Private Sub fDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getLocation()
        Try
            connDb()
            Dim querys As String = "SELECT " &
                                "SUM(pilgrimsbox.total) AS total " &
                                "FROM users INNER JOIN pilgrimsbox " &
                                "ON users.family_id = pilgrimsbox.NIKID WHERE mounthYear = '" & tMoundYearDepo.Value.ToString("MMMM - yyyy") & "' " &
                                "AND regionAdminID = '" & regionIdAdmin & "'"
            myCommand.Connection = conn
            myCommand.CommandText = querys
            myAdapter.SelectCommand = myCommand
            Dim myDepo As MySqlDataReader
            myDepo = myCommand.ExecuteReader()
            myDepo.Read()
            If myDepo.HasRows Then
                Dim sums As Double = CDbl(Val(myDepo("total").ToString))
                tTotalDepo.Value = sums
            Else
                tTotalDepo.Value = 1
            End If
            disconetDb()
        Catch ex As Exception
            disconetDb()
            MsgBox("err something wrong. " & ex.Message)
        End Try
    End Sub

    Private Sub btnSubmitDepo_Click(sender As Object, e As EventArgs) Handles btnSubmitDepo.Click
        Dim provinceID As String = tProvinceIDDepo.SelectedValue.ToString
        Dim cityID As String = tCitiIDDepo.SelectedValue.ToString
        Dim districtID As String = tDistritIDDepo.SelectedValue.ToString
        Dim villageID As String = tVillageIDDepo.SelectedValue.ToString
        Dim dateYear = tMoundYearDepo.Value.ToString("MMMM - yyyy")
        Dim createdAT = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        Dim collect As Double = (10 * tTotalDepo.Value.ToString) / 100
        Dim village As Double = (15 * (tTotalDepo.Value.ToString - collect)) / 100
        Dim district As Double = (15 * (tTotalDepo.Value.ToString - (village + collect))) / 100
        Dim city As Double = (15 * (tTotalDepo.Value.ToString - (district + village + collect))) / 100
        Dim province As Double = (15 * (tTotalDepo.Value.ToString - (city + district + village + collect))) / 100
        Dim center As Double = (tTotalDepo.Value.ToString - (province + city + district + village + collect))

        lCollectorsRp.Text = "Rp " & collect
        lVillageRp.Text = "Rp " & village
        lDistrictRp.Text = "Rp " & district

        lCityRp.Text = "Rp " & city
        lProvinceRp.Text = "Rp " & province
        lCenterRp.Text = "Rp " & center


        Try
            connDb()
            Dim sqlQuery = "INSERT INTO savesbox " &
            "(provinceID, cityID, districtID, villageID, monthYear, totalNotDivision, createdAt, incomeCollector, incomeVillage, incomeDistrict, incomeCity, incomeProvince, incomeCenter) " &
            "VALUES ('" & provinceID & "', '" & cityID & "', '" & districtID & "', '" & villageID & "', '" & dateYear & "', '" & tTotalDepo.Value.ToString & "', '" & createdAT & "', '" & collect & "', '" & village & "', '" & district & "', '" & city & "', '" & province & "', '" & center & "')"
            myCommand.Connection = conn
            myCommand.CommandText = sqlQuery
            myCommand.ExecuteNonQuery()
            disconetDb()
            MsgBox("success")
        Catch ex As Exception
            MsgBox(ex.Message)
            disconetDb()
        End Try
    End Sub


End Class