Imports System.Text
Imports MySql.Data.MySqlClient

Public Class fLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = tUsername.Text
        Dim password As String = tPassword.Text

        If username = "" OrElse password = "" Then
            MsgBox("Username cannot be empty")
        ElseIf password = "" Then
            MsgBox("Password cannot be empty")
        Else
            LoginCore()
            Select Case isLoggedin
                Case "Admin Center"
                    fDashboardAdmin.Show()
                    Me.Hide()
                Case "Admin Province"
                    'fAdminProvince.Show()
                    fAdminVillage.Show()
                    Me.Hide()
                Case "Admin City"
                    'fAdminCity.Show()
                    fAdminVillage.Show()
                    Me.Hide()
                Case "Admin District"
                    'fAdminSubDistrict.Show()
                    fAdminVillage.Show()
                    Me.Hide()
                Case "Admin Village"
                    fAdminVillage.Show()
                    Me.Hide()
                Case Else
                    MsgBox("You do not have access rights.")
            End Select

        End If
    End Sub

    Public Sub LoginCore()
        Call connDb()
        Try
            Dim myAdapter As New MySqlDataAdapter
            Dim sqlQuery = "SELECT * FROM users WHERE username = '" & tUsername.Text & "'AND password = '" & tPassword.Text & "'"
            Dim myCommand As New MySqlCommand
            myCommand.Connection = conn
            myCommand.CommandText = sqlQuery

            myAdapter.SelectCommand = myCommand
            Dim myData As MySqlDataReader
            myData = myCommand.ExecuteReader()
            myData.Read()

            If myData.HasRows Then
                tUsername.Text = ""
                tPassword.Text = ""
                regionIdAdmin = myData("regionAdminID").ToString
                isProvince = myData("province").ToString
                isCity = myData("city").ToString
                isDistrict = myData("subdistrict").ToString
                isVillage = myData("vilage").ToString
                isLoggedin = myData("role").ToString
                isUsername = myData("username").ToString
            Else
                MsgBox("Incorrect username and password.")
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
        disconetDb()
    End Sub

    Private Sub fLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tPassword.UseSystemPasswordChar = True
    End Sub
End Class
