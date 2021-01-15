Imports MySql.Data.MySqlClient
Imports System.Data

Public Class fAdminMaster
    Private Sub BtnAddAdmin_Click(sender As Object, e As EventArgs) Handles BtnAddAdmin.Click
        'fDashboardAdmin.switchPanel(fAddAdmin)
        fDashboardAdmin.switchPanel(New fAddAdmin())
    End Sub

    Dim myData As New DataTable
    Dim myAdapter As New MySqlDataAdapter
    Dim myCommand As New MySqlCommand
    Dim gelobalQuery As String = "SELECT id, family_id, username, fullName, role, country, province, city, subdistrict, vilage, status  FROM users"
    Public Sub getDataAdmin()
        Try
            connDb()
            Dim sqlQuery As String
            myData.Clear()
            Dim stt As String = "Active"
            Dim isAdmin As String = "Admin"
            If tSearchAdmin.Text = "" Then
                sqlQuery = gelobalQuery & " WHERE status ='" & stt & "' AND role LIKE '%" & isAdmin & "%'"
            Else
                sqlQuery = gelobalQuery & " WHERE fullname LIKE '%" & tSearchAdmin.Text & "%' AND role LIKE '%" & isAdmin & "%'"
            End If
            myCommand.Connection = conn
            myCommand.CommandText = sqlQuery
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            DataGridView1.DataSource = myData
            DataGridView1.ReadOnly = True
            disconetDb()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
            disconetDb()
        End Try
    End Sub
    Private Sub fAdminMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load, tSearchAdmin.TextChanged
        getDataAdmin()
        DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Green
        If Not isLoggedin = "Admin Center" Then
            btnUpdate.Hide()
            btnTrash.Hide()
        End If
    End Sub

    Private Sub btnFilterRole_Click(sender As Object, e As EventArgs) Handles btnFilterRole.Click
        Call connDb()
        Try
            myData.Clear()
            Dim sqlQuery As String
            Dim isAdmin As String = "Admin"
            If tFilterAdminRole.Text = "All" Then
                sqlQuery = "SELECT id, family_id, username, fullName, role, country, province, city, subdistrict, vilage, status  FROM users WHERE status='" & tFilterAdminStatus.Text & "' AND role LIKE '%" & isAdmin & "%'"
            Else
                sqlQuery = "SELECT id, family_id, username, fullName, role, country, province, city, subdistrict, vilage, status FROM users WHERE role ='" & tFilterAdminRole.Text & "' AND status ='" & tFilterAdminStatus.Text & "'"
            End If
            myCommand.Connection = conn
            myCommand.CommandText = sqlQuery
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            DataGridView1.DataSource = myData
            DataGridView1.ReadOnly = True
            disconetDb()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
            disconetDb()
        End Try
    End Sub

    Private Sub btnTrash_Click(sender As Object, e As EventArgs) Handles btnTrash.Click
        Dim idSelector As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Dim nameSelector = DataGridView1.CurrentRow.Cells(2).Value.ToString
        Dim status As String
        If idSelector = "" Then
            MsgBox("Please select the data to be deleted below the table.")
        Else
            Dim result As DialogResult = MessageBox.Show("You're sure you want to throw the " & nameSelector & " in the trash", "Warning...", MessageBoxButtons.YesNo)
            If DataGridView1.CurrentRow.Cells("status").Value.ToString = "Active" Then
                If result = DialogResult.Yes Then
                    Try
                        status = "Trash"
                        connDb()
                        Dim sqlQuery = "UPDATE users SET status ='" & status & "'WHERE id ='" & idSelector & "'"
                        myCommand.Connection = conn
                        myCommand.CommandText = sqlQuery
                        myCommand.ExecuteNonQuery()
                        MessageBox.Show("Managed to throw the " & nameSelector & " into the trash.", "Notification")
                        disconetDb()
                        getDataAdmin()
                    Catch ex As Exception
                        MsgBox("Failed something wrong. " & ex.Message)
                        disconetDb()
                    End Try
                End If
            Else
                If result = DialogResult.Yes Then
                    Try
                        status = "Active"
                        connDb()
                        Dim sqlQuery = "UPDATE users SET status ='" & status & "'WHERE id ='" & idSelector & "'"
                        myCommand.Connection = conn
                        myCommand.CommandText = sqlQuery
                        myCommand.ExecuteNonQuery()
                        MessageBox.Show("Managed to recover.'" & nameSelector & "'", "Notification")
                        disconetDb()
                        getDataAdmin()
                    Catch ex As Exception
                        MsgBox("Failed something wrong. " & ex.Message)
                        disconetDb()
                    End Try
                End If
            End If
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (DataGridView1.CurrentRow.Cells("status").Value.ToString = "Trash") Then
            btnTrash.BackColor = Color.Green
            btnTrash.Text = "Restore"
        Else
            btnTrash.BackColor = Color.Red
            btnTrash.Text = "Trash"
        End If
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
        fDashboardAdmin.switchPanel(New fAddAdmin(candidateUpdate, True))
    End Sub
End Class