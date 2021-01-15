<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fAddAdmin
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
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tFamilyId = New System.Windows.Forms.NumericUpDown()
        Me.tStatusAdmin = New System.Windows.Forms.ComboBox()
        Me.tRoleAdmin = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tFullNameAdmin = New System.Windows.Forms.TextBox()
        Me.tCityAdmin = New System.Windows.Forms.ComboBox()
        Me.tVilageAdmin = New System.Windows.Forms.ComboBox()
        Me.tSubDistrictAdmin = New System.Windows.Forms.ComboBox()
        Me.tProvinceAdmin = New System.Windows.Forms.ComboBox()
        Me.tCountryAdmin = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tPasswordAdmin = New System.Windows.Forms.TextBox()
        Me.btnSaveAdmin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tUsernameAdmin = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tFamilyId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Username
        '
        Me.Username.HeaderText = "Username"
        Me.Username.Name = "Username"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.tFamilyId)
        Me.GroupBox1.Controls.Add(Me.tStatusAdmin)
        Me.GroupBox1.Controls.Add(Me.tRoleAdmin)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tFullNameAdmin)
        Me.GroupBox1.Controls.Add(Me.tCityAdmin)
        Me.GroupBox1.Controls.Add(Me.tVilageAdmin)
        Me.GroupBox1.Controls.Add(Me.tSubDistrictAdmin)
        Me.GroupBox1.Controls.Add(Me.tProvinceAdmin)
        Me.GroupBox1.Controls.Add(Me.tCountryAdmin)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.tPasswordAdmin)
        Me.GroupBox1.Controls.Add(Me.btnSaveAdmin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tUsernameAdmin)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(963, 411)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Admin"
        '
        'tFamilyId
        '
        Me.tFamilyId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tFamilyId.Location = New System.Drawing.Point(11, 96)
        Me.tFamilyId.Maximum = New Decimal(New Integer() {268435455, 1042612833, 542101086, 0})
        Me.tFamilyId.Name = "tFamilyId"
        Me.tFamilyId.Size = New System.Drawing.Size(460, 23)
        Me.tFamilyId.TabIndex = 3
        Me.tFamilyId.Value = New Decimal(New Integer() {321, 0, 0, 0})
        '
        'tStatusAdmin
        '
        Me.tStatusAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tStatusAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tStatusAdmin.FormattingEnabled = True
        Me.tStatusAdmin.Items.AddRange(New Object() {"Active", "Trash"})
        Me.tStatusAdmin.Location = New System.Drawing.Point(492, 95)
        Me.tStatusAdmin.Name = "tStatusAdmin"
        Me.tStatusAdmin.Size = New System.Drawing.Size(460, 23)
        Me.tStatusAdmin.TabIndex = 4
        '
        'tRoleAdmin
        '
        Me.tRoleAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tRoleAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tRoleAdmin.FormattingEnabled = True
        Me.tRoleAdmin.Items.AddRange(New Object() {"Admin Center", "Admin Province", "Admin City", "Admin District", "Admin Village", "Pilgrims"})
        Me.tRoleAdmin.Location = New System.Drawing.Point(490, 325)
        Me.tRoleAdmin.Name = "tRoleAdmin"
        Me.tRoleAdmin.Size = New System.Drawing.Size(460, 23)
        Me.tRoleAdmin.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(492, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 17)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Confirm Password"
        '
        'tConfirmPassword
        '
        Me.tConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tConfirmPassword.Location = New System.Drawing.Point(492, 154)
        Me.tConfirmPassword.Name = "tConfirmPassword"
        Me.tConfirmPassword.PlaceholderText = "Password"
        Me.tConfirmPassword.Size = New System.Drawing.Size(460, 25)
        Me.tConfirmPassword.TabIndex = 6
        Me.tConfirmPassword.UseSystemPasswordChar = True
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(490, 305)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 17)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Role"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(490, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Full Name"
        '
        'tFullNameAdmin
        '
        Me.tFullNameAdmin.AcceptsTab = True
        Me.tFullNameAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tFullNameAdmin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tFullNameAdmin.Location = New System.Drawing.Point(492, 42)
        Me.tFullNameAdmin.Name = "tFullNameAdmin"
        Me.tFullNameAdmin.PlaceholderText = "Full Name"
        Me.tFullNameAdmin.Size = New System.Drawing.Size(460, 25)
        Me.tFullNameAdmin.TabIndex = 2
        '
        'tCityAdmin
        '
        Me.tCityAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tCityAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tCityAdmin.FormattingEnabled = True
        Me.tCityAdmin.Location = New System.Drawing.Point(11, 265)
        Me.tCityAdmin.Name = "tCityAdmin"
        Me.tCityAdmin.Size = New System.Drawing.Size(460, 23)
        Me.tCityAdmin.TabIndex = 9
        '
        'tVilageAdmin
        '
        Me.tVilageAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tVilageAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tVilageAdmin.FormattingEnabled = True
        Me.tVilageAdmin.Location = New System.Drawing.Point(11, 325)
        Me.tVilageAdmin.Name = "tVilageAdmin"
        Me.tVilageAdmin.Size = New System.Drawing.Size(460, 23)
        Me.tVilageAdmin.TabIndex = 11
        '
        'tSubDistrictAdmin
        '
        Me.tSubDistrictAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tSubDistrictAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tSubDistrictAdmin.FormattingEnabled = True
        Me.tSubDistrictAdmin.Items.AddRange(New Object() {"Indonesia"})
        Me.tSubDistrictAdmin.Location = New System.Drawing.Point(490, 265)
        Me.tSubDistrictAdmin.Name = "tSubDistrictAdmin"
        Me.tSubDistrictAdmin.Size = New System.Drawing.Size(460, 23)
        Me.tSubDistrictAdmin.TabIndex = 10
        '
        'tProvinceAdmin
        '
        Me.tProvinceAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tProvinceAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tProvinceAdmin.FormattingEnabled = True
        Me.tProvinceAdmin.Location = New System.Drawing.Point(490, 211)
        Me.tProvinceAdmin.Name = "tProvinceAdmin"
        Me.tProvinceAdmin.Size = New System.Drawing.Size(460, 23)
        Me.tProvinceAdmin.TabIndex = 8
        '
        'tCountryAdmin
        '
        Me.tCountryAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tCountryAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tCountryAdmin.FormattingEnabled = True
        Me.tCountryAdmin.Items.AddRange(New Object() {"Indonesia"})
        Me.tCountryAdmin.Location = New System.Drawing.Point(11, 211)
        Me.tCountryAdmin.Name = "tCountryAdmin"
        Me.tCountryAdmin.Size = New System.Drawing.Size(460, 23)
        Me.tCountryAdmin.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(11, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 17)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Family Card ID"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(492, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Status"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(490, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Sub District"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(492, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Province"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(11, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Vilage"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(11, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "City"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(11, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Country"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(11, 134)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 17)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Password"
        '
        'tPasswordAdmin
        '
        Me.tPasswordAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tPasswordAdmin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tPasswordAdmin.Location = New System.Drawing.Point(11, 154)
        Me.tPasswordAdmin.Name = "tPasswordAdmin"
        Me.tPasswordAdmin.PlaceholderText = "Password"
        Me.tPasswordAdmin.Size = New System.Drawing.Size(460, 25)
        Me.tPasswordAdmin.TabIndex = 5
        Me.tPasswordAdmin.UseSystemPasswordChar = True
        '
        'btnSaveAdmin
        '
        Me.btnSaveAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSaveAdmin.BackColor = System.Drawing.Color.Green
        Me.btnSaveAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAdmin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSaveAdmin.ForeColor = System.Drawing.Color.White
        Me.btnSaveAdmin.Location = New System.Drawing.Point(11, 360)
        Me.btnSaveAdmin.Name = "btnSaveAdmin"
        Me.btnSaveAdmin.Size = New System.Drawing.Size(460, 33)
        Me.btnSaveAdmin.TabIndex = 13
        Me.btnSaveAdmin.Text = "Save"
        Me.btnSaveAdmin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(11, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Username"
        '
        'tUsernameAdmin
        '
        Me.tUsernameAdmin.AcceptsTab = True
        Me.tUsernameAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tUsernameAdmin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tUsernameAdmin.Location = New System.Drawing.Point(11, 42)
        Me.tUsernameAdmin.Name = "tUsernameAdmin"
        Me.tUsernameAdmin.PlaceholderText = "Username"
        Me.tUsernameAdmin.Size = New System.Drawing.Size(460, 25)
        Me.tUsernameAdmin.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(23, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(661, 30)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Add admin, be it central, provincial, regency, district And Pilgrims"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Green
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(206, 21)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "-> Add Admin Or Pilgrims"
        '
        'fAddAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 565)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fAddAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "fAddAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tFamilyId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSaveAdmin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tFullNameAdmin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tUsernameAdmin As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents tPasswordAdmin As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tVilageAdmin As ComboBox
    Friend WithEvents tSubDistrictAdmin As ComboBox
    Friend WithEvents tProvinceAdmin As ComboBox
    Friend WithEvents tCountryAdmin As ComboBox
    Friend WithEvents Label10 As Label
    'Friend WithEvents TextBox1 As TextBox
    Friend WithEvents tCityAdmin As ComboBox
    Friend WithEvents tConfirmPassword As TextBox
    Friend WithEvents tStatusAdmin As ComboBox
    Friend WithEvents tRoleAdmin As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tFamilyId As NumericUpDown
End Class
