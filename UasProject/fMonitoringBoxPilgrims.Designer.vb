<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMonitoringBoxPilgrims
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dPillgrimsBoxSHow = New System.Windows.Forms.DataGridView()
        Me.tSearchPillgrimsByName = New System.Windows.Forms.TextBox()
        Me.cDistrict = New System.Windows.Forms.ComboBox()
        Me.cProvince = New System.Windows.Forms.ComboBox()
        Me.cCity = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cTotalTopUp = New System.Windows.Forms.NumericUpDown()
        Me.btnTopUp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cVillage = New System.Windows.Forms.ComboBox()
        Me.btnFilterVillage = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnFilterProvince = New System.Windows.Forms.Button()
        Me.btnFilterDistrict = New System.Windows.Forms.Button()
        Me.btnFilterCity = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dTopUp = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cPilgrimsTopUp = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dPillgrimsBoxSHow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cTotalTopUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dPillgrimsBoxSHow
        '
        Me.dPillgrimsBoxSHow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dPillgrimsBoxSHow.BackgroundColor = System.Drawing.Color.White
        Me.dPillgrimsBoxSHow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dPillgrimsBoxSHow.Location = New System.Drawing.Point(3, 180)
        Me.dPillgrimsBoxSHow.Name = "dPillgrimsBoxSHow"
        Me.dPillgrimsBoxSHow.RowTemplate.Height = 25
        Me.dPillgrimsBoxSHow.Size = New System.Drawing.Size(984, 364)
        Me.dPillgrimsBoxSHow.TabIndex = 0
        '
        'tSearchPillgrimsByName
        '
        Me.tSearchPillgrimsByName.Location = New System.Drawing.Point(3, 59)
        Me.tSearchPillgrimsByName.Name = "tSearchPillgrimsByName"
        Me.tSearchPillgrimsByName.PlaceholderText = "Search By Name"
        Me.tSearchPillgrimsByName.Size = New System.Drawing.Size(516, 23)
        Me.tSearchPillgrimsByName.TabIndex = 1
        '
        'cDistrict
        '
        Me.cDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cDistrict.FormattingEnabled = True
        Me.cDistrict.Location = New System.Drawing.Point(3, 151)
        Me.cDistrict.Name = "cDistrict"
        Me.cDistrict.Size = New System.Drawing.Size(174, 23)
        Me.cDistrict.TabIndex = 2
        '
        'cProvince
        '
        Me.cProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cProvince.FormattingEnabled = True
        Me.cProvince.Location = New System.Drawing.Point(3, 103)
        Me.cProvince.Name = "cProvince"
        Me.cProvince.Size = New System.Drawing.Size(174, 23)
        Me.cProvince.TabIndex = 2
        '
        'cCity
        '
        Me.cCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cCity.FormattingEnabled = True
        Me.cCity.Location = New System.Drawing.Point(264, 103)
        Me.cCity.Name = "cCity"
        Me.cCity.Size = New System.Drawing.Size(174, 23)
        Me.cCity.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Province"
        '
        'cTotalTopUp
        '
        Me.cTotalTopUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cTotalTopUp.Location = New System.Drawing.Point(525, 103)
        Me.cTotalTopUp.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.cTotalTopUp.Name = "cTotalTopUp"
        Me.cTotalTopUp.Size = New System.Drawing.Size(369, 23)
        Me.cTotalTopUp.TabIndex = 5
        '
        'btnTopUp
        '
        Me.btnTopUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTopUp.BackColor = System.Drawing.Color.Green
        Me.btnTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTopUp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTopUp.ForeColor = System.Drawing.Color.White
        Me.btnTopUp.Location = New System.Drawing.Point(900, 150)
        Me.btnTopUp.Name = "btnTopUp"
        Me.btnTopUp.Size = New System.Drawing.Size(75, 23)
        Me.btnTopUp.TabIndex = 3
        Me.btnTopUp.Text = "Top Up"
        Me.btnTopUp.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(264, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(3, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "District"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(3, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Search By Name"
        '
        'cVillage
        '
        Me.cVillage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cVillage.FormattingEnabled = True
        Me.cVillage.Location = New System.Drawing.Point(264, 150)
        Me.cVillage.Name = "cVillage"
        Me.cVillage.Size = New System.Drawing.Size(174, 23)
        Me.cVillage.TabIndex = 2
        '
        'btnFilterVillage
        '
        Me.btnFilterVillage.BackColor = System.Drawing.Color.Green
        Me.btnFilterVillage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterVillage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFilterVillage.ForeColor = System.Drawing.Color.White
        Me.btnFilterVillage.Location = New System.Drawing.Point(444, 150)
        Me.btnFilterVillage.Name = "btnFilterVillage"
        Me.btnFilterVillage.Size = New System.Drawing.Size(75, 24)
        Me.btnFilterVillage.TabIndex = 3
        Me.btnFilterVillage.Text = "Filter"
        Me.btnFilterVillage.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(264, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Village"
        '
        'btnFilterProvince
        '
        Me.btnFilterProvince.BackColor = System.Drawing.Color.Green
        Me.btnFilterProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterProvince.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFilterProvince.ForeColor = System.Drawing.Color.White
        Me.btnFilterProvince.Location = New System.Drawing.Point(183, 101)
        Me.btnFilterProvince.Name = "btnFilterProvince"
        Me.btnFilterProvince.Size = New System.Drawing.Size(75, 24)
        Me.btnFilterProvince.TabIndex = 3
        Me.btnFilterProvince.Text = "Filter"
        Me.btnFilterProvince.UseVisualStyleBackColor = False
        '
        'btnFilterDistrict
        '
        Me.btnFilterDistrict.BackColor = System.Drawing.Color.Green
        Me.btnFilterDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterDistrict.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFilterDistrict.ForeColor = System.Drawing.Color.White
        Me.btnFilterDistrict.Location = New System.Drawing.Point(183, 148)
        Me.btnFilterDistrict.Name = "btnFilterDistrict"
        Me.btnFilterDistrict.Size = New System.Drawing.Size(75, 24)
        Me.btnFilterDistrict.TabIndex = 3
        Me.btnFilterDistrict.Text = "Filter"
        Me.btnFilterDistrict.UseVisualStyleBackColor = False
        '
        'btnFilterCity
        '
        Me.btnFilterCity.BackColor = System.Drawing.Color.Green
        Me.btnFilterCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterCity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFilterCity.ForeColor = System.Drawing.Color.White
        Me.btnFilterCity.Location = New System.Drawing.Point(444, 103)
        Me.btnFilterCity.Name = "btnFilterCity"
        Me.btnFilterCity.Size = New System.Drawing.Size(75, 24)
        Me.btnFilterCity.TabIndex = 3
        Me.btnFilterCity.Text = "Filter"
        Me.btnFilterCity.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(525, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Top Up Villgrims"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(3, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "-> monitoring saving box pilllgrims"
        '
        'dTopUp
        '
        Me.dTopUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dTopUp.Location = New System.Drawing.Point(525, 151)
        Me.dTopUp.Name = "dTopUp"
        Me.dTopUp.Size = New System.Drawing.Size(369, 23)
        Me.dTopUp.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(525, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Mounth And Year"
        '
        'cPilgrimsTopUp
        '
        Me.cPilgrimsTopUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cPilgrimsTopUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cPilgrimsTopUp.FormattingEnabled = True
        Me.cPilgrimsTopUp.Location = New System.Drawing.Point(525, 59)
        Me.cPilgrimsTopUp.Name = "cPilgrimsTopUp"
        Me.cPilgrimsTopUp.Size = New System.Drawing.Size(369, 23)
        Me.cPilgrimsTopUp.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(525, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Pillgrims Name"
        '
        'fMonitoringBoxPilgrims
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(987, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.dTopUp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cTotalTopUp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTopUp)
        Me.Controls.Add(Me.btnFilterProvince)
        Me.Controls.Add(Me.btnFilterDistrict)
        Me.Controls.Add(Me.btnFilterCity)
        Me.Controls.Add(Me.btnFilterVillage)
        Me.Controls.Add(Me.cPilgrimsTopUp)
        Me.Controls.Add(Me.cCity)
        Me.Controls.Add(Me.cProvince)
        Me.Controls.Add(Me.cVillage)
        Me.Controls.Add(Me.cDistrict)
        Me.Controls.Add(Me.tSearchPillgrimsByName)
        Me.Controls.Add(Me.dPillgrimsBoxSHow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fMonitoringBoxPilgrims"
        Me.Text = "fMonitoringBoxPilgrims"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dPillgrimsBoxSHow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cTotalTopUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dPillgrimsBoxSHow As DataGridView
    Friend WithEvents tSearchPillgrimsByName As TextBox
    Friend WithEvents cDistrict As ComboBox
    Friend WithEvents cProvince As ComboBox
    Friend WithEvents cCity As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cTotalTopUp As NumericUpDown
    Friend WithEvents btnTopUp As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cVillage As ComboBox
    Friend WithEvents btnFilterVillage As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnFilterProvince As Button
    Friend WithEvents btnFilterDistrict As Button
    Friend WithEvents btnFilterCity As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dTopUp As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents cPilgrimsTopUp As ComboBox
    Friend WithEvents Label9 As Label
End Class
