Public Class fDashboardAdmin
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        isLoggedin = ""
        isUsername = ""
        regionIdAdmin = ""
        isProvince = ""
        isCity = ""
        isDistrict = ""
        isVillage = ""
        fLogin.Show()
        My.Application.OpenForms.Cast(Of Form)().Except({fLogin}).ToList().ForEach(Sub(form) form.Close())
    End Sub

    Private Sub BtnMasterAdmin_Click(sender As Object, e As EventArgs) Handles BtnMasterAdmin.Click
        'Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        fAdminMaster.getDataAdmin()
        switchPanel(fAdminMaster)
    End Sub


    Public Sub switchPanel(ByVal pnl As Form)
        PanelContainer.Controls.Clear()
        pnl.TopLevel = False
        PanelContainer.Controls.Add(pnl)
        pnl.TopMost = True
        pnl.WindowState = FormWindowState.Maximized
        pnl.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        fMasterPilgrims.getPilgrim()
        switchPanel(fMasterPilgrims)
    End Sub
    Private Sub fDashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LTitleAdmin.Text = isUsername
        tPusatAdmin.Text = isLoggedin
        fAdminHome.getData()
        switchPanel(fAdminHome)
    End Sub

    Private Sub btnMonitoringBoxPillgrims_Click(sender As Object, e As EventArgs) Handles btnMonitoringBoxPillgrims.Click
        fMonitoringBoxPilgrims.getSaldo()
        fMonitoringBoxPilgrims.getPilgrims()
        fMonitoringBoxPilgrims.getProvince()
        switchPanel(fMonitoringBoxPilgrims)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fAdminHome.getData()
        switchPanel(fAdminHome)
    End Sub

    Private Sub btnReoprt_Click(sender As Object, e As EventArgs) Handles btnReoprt.Click
        fDetailBoxTransaction.getData()
        switchPanel(fDetailBoxTransaction)
    End Sub
End Class