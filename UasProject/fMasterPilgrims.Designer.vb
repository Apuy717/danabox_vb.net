<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fMasterPilgrims
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tSearchPilgrims = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.cProvince = New System.Windows.Forms.ComboBox()
        Me.cCity = New System.Windows.Forms.ComboBox()
        Me.btnFilterProvince = New System.Windows.Forms.Button()
        Me.btnFIlterDistrict = New System.Windows.Forms.Button()
        Me.btnFilterCity = New System.Windows.Forms.Button()
        Me.btnFilterVillage = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlBox = New System.Windows.Forms.Panel()
        Me.totalDanaBox = New System.Windows.Forms.Label()
        Me.cVlge = New System.Windows.Forms.ComboBox()
        Me.cDistrict = New System.Windows.Forms.ComboBox()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "-> Master Pilgrims"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 151)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1012, 394)
        Me.DataGridView1.TabIndex = 2
        '
        'tSearchPilgrims
        '
        Me.tSearchPilgrims.Location = New System.Drawing.Point(4, 122)
        Me.tSearchPilgrims.Name = "tSearchPilgrims"
        Me.tSearchPilgrims.PlaceholderText = "Search Pillgrims by name"
        Me.tSearchPilgrims.Size = New System.Drawing.Size(411, 23)
        Me.tSearchPilgrims.TabIndex = 3
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Green
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(421, 121)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 24)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.BackColor = System.Drawing.Color.Green
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Location = New System.Drawing.Point(886, 9)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(120, 35)
        Me.btnCreate.TabIndex = 4
        Me.btnCreate.Text = "Add Pillgrims"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'cProvince
        '
        Me.cProvince.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cProvince.FormattingEnabled = True
        Me.cProvince.Location = New System.Drawing.Point(502, 77)
        Me.cProvince.Name = "cProvince"
        Me.cProvince.Size = New System.Drawing.Size(169, 23)
        Me.cProvince.TabIndex = 5
        '
        'cCity
        '
        Me.cCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cCity.FormattingEnabled = True
        Me.cCity.Location = New System.Drawing.Point(754, 77)
        Me.cCity.Name = "cCity"
        Me.cCity.Size = New System.Drawing.Size(169, 23)
        Me.cCity.TabIndex = 5
        '
        'btnFilterProvince
        '
        Me.btnFilterProvince.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterProvince.BackColor = System.Drawing.Color.Green
        Me.btnFilterProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterProvince.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFilterProvince.ForeColor = System.Drawing.Color.White
        Me.btnFilterProvince.Location = New System.Drawing.Point(673, 76)
        Me.btnFilterProvince.Name = "btnFilterProvince"
        Me.btnFilterProvince.Size = New System.Drawing.Size(75, 24)
        Me.btnFilterProvince.TabIndex = 4
        Me.btnFilterProvince.Text = "Fillter"
        Me.btnFilterProvince.UseVisualStyleBackColor = False
        '
        'btnFIlterDistrict
        '
        Me.btnFIlterDistrict.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFIlterDistrict.BackColor = System.Drawing.Color.Green
        Me.btnFIlterDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFIlterDistrict.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFIlterDistrict.ForeColor = System.Drawing.Color.White
        Me.btnFIlterDistrict.Location = New System.Drawing.Point(673, 120)
        Me.btnFIlterDistrict.Name = "btnFIlterDistrict"
        Me.btnFIlterDistrict.Size = New System.Drawing.Size(75, 24)
        Me.btnFIlterDistrict.TabIndex = 4
        Me.btnFIlterDistrict.Text = "Fillter"
        Me.btnFIlterDistrict.UseVisualStyleBackColor = False
        '
        'btnFilterCity
        '
        Me.btnFilterCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterCity.BackColor = System.Drawing.Color.Green
        Me.btnFilterCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterCity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFilterCity.ForeColor = System.Drawing.Color.White
        Me.btnFilterCity.Location = New System.Drawing.Point(929, 77)
        Me.btnFilterCity.Name = "btnFilterCity"
        Me.btnFilterCity.Size = New System.Drawing.Size(75, 24)
        Me.btnFilterCity.TabIndex = 4
        Me.btnFilterCity.Text = "Fillter"
        Me.btnFilterCity.UseVisualStyleBackColor = False
        '
        'btnFilterVillage
        '
        Me.btnFilterVillage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterVillage.BackColor = System.Drawing.Color.Green
        Me.btnFilterVillage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterVillage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFilterVillage.ForeColor = System.Drawing.Color.White
        Me.btnFilterVillage.Location = New System.Drawing.Point(929, 119)
        Me.btnFilterVillage.Name = "btnFilterVillage"
        Me.btnFilterVillage.Size = New System.Drawing.Size(75, 24)
        Me.btnFilterVillage.TabIndex = 4
        Me.btnFilterVillage.Text = "Fillter"
        Me.btnFilterVillage.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(502, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Province"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(502, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "District"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(754, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "City"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(754, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Village"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(4, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Search"
        '
        'pnlBox
        '
        Me.pnlBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBox.BackColor = System.Drawing.Color.Green
        Me.pnlBox.Controls.Add(Me.totalDanaBox)
        Me.pnlBox.Location = New System.Drawing.Point(688, 11)
        Me.pnlBox.Name = "pnlBox"
        Me.pnlBox.Size = New System.Drawing.Size(192, 32)
        Me.pnlBox.TabIndex = 7
        '
        'totalDanaBox
        '
        Me.totalDanaBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totalDanaBox.AutoSize = True
        Me.totalDanaBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.totalDanaBox.ForeColor = System.Drawing.Color.White
        Me.totalDanaBox.Location = New System.Drawing.Point(6, 5)
        Me.totalDanaBox.Name = "totalDanaBox"
        Me.totalDanaBox.Size = New System.Drawing.Size(121, 21)
        Me.totalDanaBox.TabIndex = 0
        Me.totalDanaBox.Text = "Total DanaBox"
        '
        'cVlge
        '
        Me.cVlge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cVlge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cVlge.FormattingEnabled = True
        Me.cVlge.Location = New System.Drawing.Point(754, 120)
        Me.cVlge.Name = "cVlge"
        Me.cVlge.Size = New System.Drawing.Size(169, 23)
        Me.cVlge.TabIndex = 5
        '
        'cDistrict
        '
        Me.cDistrict.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cDistrict.FormattingEnabled = True
        Me.cDistrict.Location = New System.Drawing.Point(502, 121)
        Me.cDistrict.Name = "cDistrict"
        Me.cDistrict.Size = New System.Drawing.Size(169, 23)
        Me.cDistrict.TabIndex = 5
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Location = New System.Drawing.Point(421, 70)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(75, 24)
        Me.btnAdmin.TabIndex = 4
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(421, 96)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 24)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'fMasterPilgrims
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1018, 549)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cDistrict)
        Me.Controls.Add(Me.cVlge)
        Me.Controls.Add(Me.cCity)
        Me.Controls.Add(Me.cProvince)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnFilterVillage)
        Me.Controls.Add(Me.btnFIlterDistrict)
        Me.Controls.Add(Me.btnFilterCity)
        Me.Controls.Add(Me.btnFilterProvince)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.tSearchPilgrims)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fMasterPilgrims"
        Me.Text = "fMasterPilgrims"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBox.ResumeLayout(False)
        Me.pnlBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tSearchPilgrims As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents cProvince As ComboBox
    Friend WithEvents cCity As ComboBox
    Friend WithEvents btnFilterProvince As Button
    Friend WithEvents btnFIlterDistrict As Button
    Friend WithEvents btnFilterCity As Button
    Friend WithEvents btnFilterVillage As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlBox As Panel
    Friend WithEvents totalDanaBox As Label
    Friend WithEvents cVlge As ComboBox
    Friend WithEvents cDistrict As ComboBox
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnUpdate As Button
End Class
