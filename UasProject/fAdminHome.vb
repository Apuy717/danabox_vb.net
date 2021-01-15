Imports MySql.Data.MySqlClient
Imports System.Data
Public Class fAdminHome
    Dim myData As New DataTable
    Dim myAdapter As New MySqlDataAdapter
    Dim myCommand As New MySqlCommand
    Dim queryGlobal As String = "SELECT SUM(incomeCollector) AS incomeCollectors, " &
                                    "SUM(incomeVillage) As incomeVillage, " &
                                    "SUM(incomeDIstrict) AS incomeDIstrict, " &
                                    "SUM(incomeCity) AS incomeCity, " &
                                    "SUM(incomeProvince) AS incomeProvince, " &
                                    "SUM(incomeCenter) AS incomeCenter, " &
                                    "SUM(totalNotDIvision) AS totalAll " &
                                    "FROM savesbox "

    Public Sub getData()
        myData.Clear()
        dFIlterIncome.Format = DateTimePickerFormat.Custom
        dFIlterIncome.CustomFormat = "MMMM - yyyy"
        Dim mounthYear As String = dFIlterIncome.Value.ToString("MMMM - yyyy")
        Dim sqlQuery As String
        Try
            connDb()
            Select Case isLoggedin
                Case "Admin Center"
                    sqlQuery = queryGlobal & "WHERE monthYear = '" & mounthYear & "'"
                Case "Admin Province"
                    sqlQuery = queryGlobal & "WHERE monthYear = '" & mounthYear & "' AND provinceID ='" & regionIdAdmin & "'"
                Case "Admin City"
                    sqlQuery = queryGlobal & "WHERE monthYear = '" & mounthYear & "' AND cityID ='" & regionIdAdmin & "'"
                Case "Admin District"
                    sqlQuery = queryGlobal & "WHERE monthYear = '" & mounthYear & "' AND districtID ='" & regionIdAdmin & "'"
                Case "Admin Village"
                    sqlQuery = queryGlobal & "WHERE monthYear = '" & mounthYear & "' AND villageID ='" & regionIdAdmin & "'"
            End Select

            myCommand.Connection = conn
            myCommand.CommandText = sqlQuery
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            disconetDb()
            LMounthYear.Text = "OrderBy " & mounthYear
            LIncomeCenter.Text = "All income -> Rp " & myData.Rows(0).Item("totalAll").ToString
            LincomeTotal.Text = "Total -> Rp " & myData.Rows(0).Item("incomeCenter").ToString
            LIncomeProvice.Text = "Rp " & myData.Rows(0).Item("incomeProvince").ToString
            LIncomeCity.Text = "Rp " & myData.Rows(0).Item("incomeCity").ToString
            LIncomeDistrict.Text = "Rp " & myData.Rows(0).Item("incomeDIstrict").ToString
            LIncomeVillage.Text = "Rp " & myData.Rows(0).Item("incomeVillage").ToString
            LIncomeCollectors.Text = "Rp " & myData.Rows(0).Item("incomeCollectors").ToString
        Catch ex As Exception
            disconetDb()
        End Try
    End Sub
    Private Sub fAdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load, dFIlterIncome.ValueChanged
        getData()
    End Sub
End Class