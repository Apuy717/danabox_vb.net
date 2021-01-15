Imports MySql.Data.MySqlClient
Imports System.Data
Public Class fAddAdmin
    Dim isUpdate As Boolean
    Dim isIdUpdate As String
    Dim myData As New DataTable
    Dim myAdapter As New MySqlDataAdapter
    Dim myCommand As New MySqlCommand
    Dim updateProvince As String
    Dim updateCIty As String
    Dim updateDistrict As String
    Dim updateVilage As String
    Private Sub fAddAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connDb()
            Dim sqlQuery = "SELECT * FROM provinces"
            myCommand.Connection = conn
            myCommand.CommandText = sqlQuery
            myAdapter.SelectCommand = myCommand
            myData = New DataTable
            myAdapter.Fill(myData)
            disconetDb()
            tProvinceAdmin.DataSource = myData
            tProvinceAdmin.ValueMember = "id"
            tProvinceAdmin.DisplayMember = "name"
            tStatusAdmin.Text = "Active"
            If isUpdate Then
                tProvinceAdmin.Text = updateProvince
                tCityAdmin.Text = updateCIty
                tSubDistrictAdmin.Text = updateDistrict
                tVilageAdmin.Text = updateVilage
            End If
            tStatusAdmin.Text = "Active"
            tCountryAdmin.Text = "Indonesia"

            Select Case isLoggedin
                Case "Admin Center"
                    tCountryAdmin.Text = "Indonesia"
                    tCountryAdmin.Enabled = False
                    tProvinceAdmin.Text = isProvince
                    tCityAdmin.Text = isCity
                    tSubDistrictAdmin.Text = isDistrict
                    tVilageAdmin.Text = isVillage
                Case "Admin Province"
                    tCountryAdmin.Text = "Indonesia"
                    tCountryAdmin.Enabled = False
                    tProvinceAdmin.Text = isProvince
                    tProvinceAdmin.Enabled = False
                    tCityAdmin.Text = isCity
                    tSubDistrictAdmin.Text = isDistrict
                    tVilageAdmin.Text = isVillage
                    tRoleAdmin.Text = "Admin City"
                    tRoleAdmin.Enabled = False
                Case "Admin City"
                    tCountryAdmin.Text = "Indonesia"
                    tCountryAdmin.Enabled = False
                    tProvinceAdmin.Text = isProvince
                    tProvinceAdmin.Enabled = False
                    tCityAdmin.Text = isCity
                    tCityAdmin.Enabled = False
                    tSubDistrictAdmin.Text = isDistrict
                    tVilageAdmin.Text = isVillage
                    tRoleAdmin.Text = "Admin District"
                    tRoleAdmin.Enabled = False
                Case "Admin District"
                    tCountryAdmin.Text = "Indonesia"
                    tCountryAdmin.Enabled = False
                    tProvinceAdmin.Text = isProvince
                    tProvinceAdmin.Enabled = False
                    tCityAdmin.Text = isCity
                    tCityAdmin.Enabled = False
                    tSubDistrictAdmin.Text = isDistrict
                    tSubDistrictAdmin.Enabled = False
                    tVilageAdmin.Text = isVillage
                    tRoleAdmin.Text = "Admin Village"
                    tRoleAdmin.Enabled = False
                Case "Admin Village"
                    tCountryAdmin.Text = "Indonesia"
                    tCountryAdmin.Enabled = False
                    tProvinceAdmin.Text = isProvince
                    tProvinceAdmin.Enabled = False
                    tCityAdmin.Text = isCity
                    tCityAdmin.Enabled = False
                    tSubDistrictAdmin.Text = isDistrict
                    tSubDistrictAdmin.Enabled = False
                    tVilageAdmin.Text = isVillage
                    tVilageAdmin.Enabled = False
                    tRoleAdmin.Text = "Pilgrims"
                    tRoleAdmin.Enabled = False
            End Select
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
            disconetDb()
        End Try
    End Sub
    Private Sub tProvinceAdmin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tProvinceAdmin.SelectedIndexChanged
        Dim id As String = tProvinceAdmin.SelectedValue.ToString
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
                tCityAdmin.DataSource = myData
                tCityAdmin.ValueMember = "id"
                tCityAdmin.DisplayMember = "name"
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show(ex.Message)
                disconetDb()
            End Try
        End If
    End Sub


    Private Sub tCityAdmin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tCityAdmin.SelectedIndexChanged
        Dim id As String = tCityAdmin.SelectedValue.ToString
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
                tSubDistrictAdmin.DataSource = myData
                tSubDistrictAdmin.ValueMember = "id"
                tSubDistrictAdmin.DisplayMember = "name"
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show(ex.Message)
                disconetDb()
            End Try
        End If
    End Sub

    Private Sub tSubDistrictAdmin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tSubDistrictAdmin.SelectedIndexChanged
        Dim id As String = tSubDistrictAdmin.SelectedValue.ToString
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
                tVilageAdmin.DataSource = myData
                tVilageAdmin.ValueMember = "id"
                tVilageAdmin.DisplayMember = "name"
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show(ex.Message)
                disconetDb()
            End Try
        End If
    End Sub


    Private Sub btnSaveAdmin_Click(sender As Object, e As EventArgs) Handles btnSaveAdmin.Click
        Dim username As String = tUsernameAdmin.Text
        Dim fullName As String = tFullNameAdmin.Text
        Dim familyId As String = tFamilyId.Value.ToString
        Dim password As String = tPasswordAdmin.Text
        Dim confirmPassword As String = tConfirmPassword.Text
        Dim country As String = tCountryAdmin.Text
        Dim province As String = tProvinceAdmin.Text
        Dim city As String = tCityAdmin.Text
        Dim district As String = tSubDistrictAdmin.Text
        Dim vilage As String = tVilageAdmin.Text
        Dim role As String = tRoleAdmin.Text
        Dim status As String = tStatusAdmin.Text
        Dim isValid As Boolean = False

        Dim regionIdAdmin As String
        Select Case role
            Case "Admin Center"
                regionIdAdmin = "717"
            Case "Admin Province"
                regionIdAdmin = tProvinceAdmin.SelectedValue.ToString
            Case "Admin City"
                regionIdAdmin = tCityAdmin.SelectedValue.ToString
            Case "Admin District"
                regionIdAdmin = tSubDistrictAdmin.SelectedValue.ToString
            Case "Admin Village"
                regionIdAdmin = tVilageAdmin.SelectedValue.ToString
            Case "Pilgrims"
                regionIdAdmin = tVilageAdmin.SelectedValue.ToString
        End Select

        If username = "" OrElse fullName = "" OrElse password = "" OrElse confirmPassword = "" OrElse familyId = "" Then
            MsgBox("All forms are mandatory")
        Else
            If password = confirmPassword Then
                Try
                    connDb()
                    myCommand.Connection = conn
                    myCommand.CommandText = "SELECT username, family_id FROM users WHERE family_id = '" & familyId & "' OR username = '" & username & "'"
                    myAdapter.SelectCommand = myCommand
                    Dim resultValidate As MySqlDataReader
                    resultValidate = myCommand.ExecuteReader()
                    resultValidate.Read()
                    If Not resultValidate.HasRows Then
                        isValid = True
                    Else
                        If isUpdate Then
                            isValid = True
                        Else
                            MessageBox.Show("Failed, This user is already registered. pleace unique username and family id", "Warning...")
                            isValid = False
                        End If
                    End If
                    disconetDb()

                    If isValid Then
                        Try
                            connDb()
                            Dim dateTime = TimeOfDay.ToString("yyyy-MM-dd HH:mm:ss")
                            Dim sqlQuery As String
                            If isUpdate Then
                                sqlQuery = "UPDATE users SET family_id ='" & familyId & "', username='" & username & "', fullName='" & fullName & "', role='" & role & "', country='" & country & "', province='" & province & "', city='" & city & "', subdistrict='" & district & "', vilage='" & vilage & "', status='" & status & "' WHERE id ='" & isIdUpdate & "'"
                            Else
                                sqlQuery = "INSERT INTO users (family_id, username, fullName, password, role, country, province, city, subdistrict, vilage, status, created_at, updated_at, regionAdminID) VALUES ('" & familyId & "', '" & username & "', '" & fullName & "', '" & password & "', '" & role & "', '" & country & "', '" & province & "', '" & city & "', '" & district & "', '" & vilage & "', '" & status & "', '" & dateTime & "', '" & dateTime & "', '" & regionIdAdmin & "')"
                            End If
                            myCommand.Connection = conn
                            myCommand.CommandText = sqlQuery
                            myCommand.ExecuteNonQuery()
                            disconetDb()
                            MsgBox("success")
                            tUsernameAdmin.Text = ""
                            tFullNameAdmin.Text = ""
                            tPasswordAdmin.Text = ""
                            tConfirmPassword.Text = ""
                            tFamilyId.Value = 321
                            If isLoggedin = "Admin Center" Then
                                If role = "Pilgrims" Then
                                    fDashboardAdmin.switchPanel(fMasterPilgrims)
                                Else
                                    fDashboardAdmin.switchPanel(fAdminMaster)
                                    fAdminMaster.getDataAdmin()
                                End If
                            Else
                                If role = "Pilgrims" Then
                                    fAdminVillage.switchPanelVillage(fMasterPilgrims)
                                End If
                            End If
                        Catch ex As Exception
                            MsgBox("Failed something wrong. " & ex.Message)
                            disconetDb()
                        End Try
                    End If
                Catch ex As Exception
                    MsgBox("Failed something wrong. " & ex.Message)
                    disconetDb()
                End Try
            Else
                MsgBox("Password does not match.")
            End If
        End If
    End Sub


    Public Sub New(Optional ByVal params As Object = Nothing, Optional ByVal st As Boolean = False)
        InitializeComponent()
        isUpdate = st
        If st Then
            updateProvince = params("province").ToString
            updateCIty = params("city").ToString
            updateDistrict = params("subdistrict").ToString
            updateVilage = params("vilage").ToString
            Label11.Text = "Update Admin or Pilgrims"
            Label9.Text = "Update admin, be it central, provincial, regency, district And pilgrims"
            tPasswordAdmin.Text = "someting"
            tPasswordAdmin.ReadOnly = True
            tConfirmPassword.Text = "someting"
            tConfirmPassword.ReadOnly = True
            isIdUpdate = params("id").ToString
            tUsernameAdmin.Text = params("username").ToString
            tFullNameAdmin.Text = params("fullName").ToString
            tFamilyId.Value = params("family_id").ToString
            tStatusAdmin.SelectedItem = params("status").ToString
            tCountryAdmin.SelectedItem = params("country").ToString
            tRoleAdmin.SelectedItem = params("role").ToString
        End If
    End Sub


End Class