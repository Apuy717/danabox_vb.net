Imports MySql.Data.MySqlClient
Imports System.Data

Public Class fAdminVillage
    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        fDeposit.getLocation()
        switchPanelVillage(fDeposit)
    End Sub

    Public Sub switchPanelVillage(ByVal pnl As Form)
        PContainerVillage.Controls.Clear()
        pnl.TopLevel = False
        PContainerVillage.Controls.Add(pnl)
        pnl.TopMost = True
        pnl.WindowState = FormWindowState.Maximized
        pnl.Show()
    End Sub

    Private Sub fAdminVillage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not isLoggedin = "Admin Village" Then
            btnDeposit.Hide()
        End If
        LtitleUsernam.Text = isUsername
        LIsAdmin.Text = isLoggedin
        fAdminHome.getData()
        switchPanelVillage(fAdminHome)
    End Sub

    Private Sub btnLogoutVillageAdmin_Click(sender As Object, e As EventArgs) Handles btnLogoutVillageAdmin.Click
        isLoggedin = ""
        isUsername = ""
        regionIdAdmin = ""
        isProvince = ""
        isCity = ""
        isDistrict = ""
        isVillage = ""
        fLogin.Show()
        My.Application.OpenForms.Cast(Of Form)() _
              .Except({fLogin}).ToList().ForEach(Sub(form) form.Close())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        fMonitoringBoxPilgrims.getSaldo()
        fMonitoringBoxPilgrims.getPilgrims()
        fMonitoringBoxPilgrims.getProvince()
        switchPanelVillage(fMonitoringBoxPilgrims)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fMasterPilgrims.getPilgrim()
        switchPanelVillage(fMasterPilgrims)
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        fAdminHome.getData()
        switchPanelVillage(fAdminHome)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        fDetailBoxTransaction.getData()
        switchPanelVillage(fDetailBoxTransaction)
    End Sub
End Class