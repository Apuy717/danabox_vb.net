<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fDetailBoxTransaction
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
        Me.dGridDetail = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cVillage = New System.Windows.Forms.ComboBox()
        Me.cCity = New System.Windows.Forms.ComboBox()
        Me.cProvince = New System.Windows.Forms.ComboBox()
        Me.cDistrict = New System.Windows.Forms.ComboBox()
        Me.btnFilterVillage = New System.Windows.Forms.Button()
        Me.btnFilterDistrict = New System.Windows.Forms.Button()
        Me.btnFilterCity = New System.Windows.Forms.Button()
        Me.btnFilterProvince = New System.Windows.Forms.Button()
        Me.pIncomeCenter = New System.Windows.Forms.Panel()
        Me.SumIncomeCenter = New System.Windows.Forms.Label()
        Me.LIncome = New System.Windows.Forms.Label()
        Me.PincomeProvince = New System.Windows.Forms.Panel()
        Me.SumIncomeProvince = New System.Windows.Forms.Label()
        Me.LincomeProvince = New System.Windows.Forms.Label()
        Me.PIncomeCity = New System.Windows.Forms.Panel()
        Me.sumIncomeCIty = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PincomeDistrict = New System.Windows.Forms.Panel()
        Me.sumIncomeDistrict = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PincomeIncomeVillage = New System.Windows.Forms.Panel()
        Me.sumIncomeVillage = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dFilterMounth = New System.Windows.Forms.DateTimePicker()
        Me.btnFilterDate = New System.Windows.Forms.Button()
        Me.btnFilterClear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sumIncomeCollectors = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pTotal = New System.Windows.Forms.Panel()
        Me.SumTotal = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.dGridDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pIncomeCenter.SuspendLayout()
        Me.PincomeProvince.SuspendLayout()
        Me.PIncomeCity.SuspendLayout()
        Me.PincomeDistrict.SuspendLayout()
        Me.PincomeIncomeVillage.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'dGridDetail
        '
        Me.dGridDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGridDetail.BackgroundColor = System.Drawing.Color.White
        Me.dGridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGridDetail.Location = New System.Drawing.Point(0, 220)
        Me.dGridDetail.Name = "dGridDetail"
        Me.dGridDetail.RowTemplate.Height = 25
        Me.dGridDetail.Size = New System.Drawing.Size(1044, 316)
        Me.dGridDetail.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(279, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Village"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(276, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(11, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "District"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(11, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Province"
        '
        'cVillage
        '
        Me.cVillage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cVillage.ForeColor = System.Drawing.Color.Green
        Me.cVillage.FormattingEnabled = True
        Me.cVillage.Location = New System.Drawing.Point(279, 187)
        Me.cVillage.Name = "cVillage"
        Me.cVillage.Size = New System.Drawing.Size(181, 23)
        Me.cVillage.TabIndex = 11
        '
        'cCity
        '
        Me.cCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cCity.ForeColor = System.Drawing.Color.Green
        Me.cCity.FormattingEnabled = True
        Me.cCity.Location = New System.Drawing.Point(279, 142)
        Me.cCity.Name = "cCity"
        Me.cCity.Size = New System.Drawing.Size(181, 23)
        Me.cCity.TabIndex = 12
        '
        'cProvince
        '
        Me.cProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cProvince.ForeColor = System.Drawing.Color.Green
        Me.cProvince.FormattingEnabled = True
        Me.cProvince.Location = New System.Drawing.Point(11, 144)
        Me.cProvince.Name = "cProvince"
        Me.cProvince.Size = New System.Drawing.Size(181, 23)
        Me.cProvince.TabIndex = 13
        '
        'cDistrict
        '
        Me.cDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cDistrict.ForeColor = System.Drawing.Color.Green
        Me.cDistrict.FormattingEnabled = True
        Me.cDistrict.Location = New System.Drawing.Point(11, 189)
        Me.cDistrict.Name = "cDistrict"
        Me.cDistrict.Size = New System.Drawing.Size(181, 23)
        Me.cDistrict.TabIndex = 14
        '
        'btnFilterVillage
        '
        Me.btnFilterVillage.BackColor = System.Drawing.Color.Green
        Me.btnFilterVillage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterVillage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFilterVillage.ForeColor = System.Drawing.Color.White
        Me.btnFilterVillage.Location = New System.Drawing.Point(466, 185)
        Me.btnFilterVillage.Name = "btnFilterVillage"
        Me.btnFilterVillage.Size = New System.Drawing.Size(75, 24)
        Me.btnFilterVillage.TabIndex = 7
        Me.btnFilterVillage.Text = "Fillter"
        Me.btnFilterVillage.UseVisualStyleBackColor = False
        '
        'btnFilterDistrict
        '
        Me.btnFilterDistrict.BackColor = System.Drawing.Color.Green
        Me.btnFilterDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterDistrict.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFilterDistrict.ForeColor = System.Drawing.Color.White
        Me.btnFilterDistrict.Location = New System.Drawing.Point(198, 189)
        Me.btnFilterDistrict.Name = "btnFilterDistrict"
        Me.btnFilterDistrict.Size = New System.Drawing.Size(75, 24)
        Me.btnFilterDistrict.TabIndex = 8
        Me.btnFilterDistrict.Text = "Fillter"
        Me.btnFilterDistrict.UseVisualStyleBackColor = False
        '
        'btnFilterCity
        '
        Me.btnFilterCity.BackColor = System.Drawing.Color.Green
        Me.btnFilterCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterCity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFilterCity.ForeColor = System.Drawing.Color.White
        Me.btnFilterCity.Location = New System.Drawing.Point(466, 141)
        Me.btnFilterCity.Name = "btnFilterCity"
        Me.btnFilterCity.Size = New System.Drawing.Size(75, 24)
        Me.btnFilterCity.TabIndex = 9
        Me.btnFilterCity.Text = "Fillter"
        Me.btnFilterCity.UseVisualStyleBackColor = False
        '
        'btnFilterProvince
        '
        Me.btnFilterProvince.BackColor = System.Drawing.Color.Green
        Me.btnFilterProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterProvince.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFilterProvince.ForeColor = System.Drawing.Color.White
        Me.btnFilterProvince.Location = New System.Drawing.Point(198, 142)
        Me.btnFilterProvince.Name = "btnFilterProvince"
        Me.btnFilterProvince.Size = New System.Drawing.Size(75, 24)
        Me.btnFilterProvince.TabIndex = 10
        Me.btnFilterProvince.Text = "Fillter"
        Me.btnFilterProvince.UseVisualStyleBackColor = False
        '
        'pIncomeCenter
        '
        Me.pIncomeCenter.BackColor = System.Drawing.Color.Green
        Me.pIncomeCenter.Controls.Add(Me.SumIncomeCenter)
        Me.pIncomeCenter.Controls.Add(Me.LIncome)
        Me.pIncomeCenter.Location = New System.Drawing.Point(9, 50)
        Me.pIncomeCenter.Name = "pIncomeCenter"
        Me.pIncomeCenter.Size = New System.Drawing.Size(141, 67)
        Me.pIncomeCenter.TabIndex = 19
        '
        'SumIncomeCenter
        '
        Me.SumIncomeCenter.AutoSize = True
        Me.SumIncomeCenter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SumIncomeCenter.ForeColor = System.Drawing.Color.White
        Me.SumIncomeCenter.Location = New System.Drawing.Point(4, 31)
        Me.SumIncomeCenter.Name = "SumIncomeCenter"
        Me.SumIncomeCenter.Size = New System.Drawing.Size(35, 17)
        Me.SumIncomeCenter.TabIndex = 0
        Me.SumIncomeCenter.Text = "Rp 0"
        '
        'LIncome
        '
        Me.LIncome.AutoSize = True
        Me.LIncome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LIncome.ForeColor = System.Drawing.Color.White
        Me.LIncome.Location = New System.Drawing.Point(4, 4)
        Me.LIncome.Name = "LIncome"
        Me.LIncome.Size = New System.Drawing.Size(97, 17)
        Me.LIncome.TabIndex = 0
        Me.LIncome.Text = "Income Center"
        '
        'PincomeProvince
        '
        Me.PincomeProvince.BackColor = System.Drawing.Color.Green
        Me.PincomeProvince.Controls.Add(Me.SumIncomeProvince)
        Me.PincomeProvince.Controls.Add(Me.LincomeProvince)
        Me.PincomeProvince.Location = New System.Drawing.Point(156, 49)
        Me.PincomeProvince.Name = "PincomeProvince"
        Me.PincomeProvince.Size = New System.Drawing.Size(141, 67)
        Me.PincomeProvince.TabIndex = 19
        '
        'SumIncomeProvince
        '
        Me.SumIncomeProvince.AutoSize = True
        Me.SumIncomeProvince.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SumIncomeProvince.ForeColor = System.Drawing.Color.White
        Me.SumIncomeProvince.Location = New System.Drawing.Point(4, 31)
        Me.SumIncomeProvince.Name = "SumIncomeProvince"
        Me.SumIncomeProvince.Size = New System.Drawing.Size(35, 17)
        Me.SumIncomeProvince.TabIndex = 0
        Me.SumIncomeProvince.Text = "Rp 0"
        '
        'LincomeProvince
        '
        Me.LincomeProvince.AutoSize = True
        Me.LincomeProvince.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LincomeProvince.ForeColor = System.Drawing.Color.White
        Me.LincomeProvince.Location = New System.Drawing.Point(4, 3)
        Me.LincomeProvince.Name = "LincomeProvince"
        Me.LincomeProvince.Size = New System.Drawing.Size(110, 17)
        Me.LincomeProvince.TabIndex = 0
        Me.LincomeProvince.Text = "Income Province"
        '
        'PIncomeCity
        '
        Me.PIncomeCity.BackColor = System.Drawing.Color.Green
        Me.PIncomeCity.Controls.Add(Me.sumIncomeCIty)
        Me.PIncomeCity.Controls.Add(Me.Label7)
        Me.PIncomeCity.Location = New System.Drawing.Point(303, 50)
        Me.PIncomeCity.Name = "PIncomeCity"
        Me.PIncomeCity.Size = New System.Drawing.Size(141, 67)
        Me.PIncomeCity.TabIndex = 19
        '
        'sumIncomeCIty
        '
        Me.sumIncomeCIty.AutoSize = True
        Me.sumIncomeCIty.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.sumIncomeCIty.ForeColor = System.Drawing.Color.White
        Me.sumIncomeCIty.Location = New System.Drawing.Point(4, 31)
        Me.sumIncomeCIty.Name = "sumIncomeCIty"
        Me.sumIncomeCIty.Size = New System.Drawing.Size(35, 17)
        Me.sumIncomeCIty.TabIndex = 0
        Me.sumIncomeCIty.Text = "Rp 0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(4, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Income City"
        '
        'PincomeDistrict
        '
        Me.PincomeDistrict.BackColor = System.Drawing.Color.Green
        Me.PincomeDistrict.Controls.Add(Me.sumIncomeDistrict)
        Me.PincomeDistrict.Controls.Add(Me.Label8)
        Me.PincomeDistrict.Location = New System.Drawing.Point(450, 50)
        Me.PincomeDistrict.Name = "PincomeDistrict"
        Me.PincomeDistrict.Size = New System.Drawing.Size(141, 67)
        Me.PincomeDistrict.TabIndex = 19
        '
        'sumIncomeDistrict
        '
        Me.sumIncomeDistrict.AutoSize = True
        Me.sumIncomeDistrict.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.sumIncomeDistrict.ForeColor = System.Drawing.Color.White
        Me.sumIncomeDistrict.Location = New System.Drawing.Point(4, 31)
        Me.sumIncomeDistrict.Name = "sumIncomeDistrict"
        Me.sumIncomeDistrict.Size = New System.Drawing.Size(35, 17)
        Me.sumIncomeDistrict.TabIndex = 0
        Me.sumIncomeDistrict.Text = "Rp 0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(4, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "IncomeDistrict"
        '
        'PincomeIncomeVillage
        '
        Me.PincomeIncomeVillage.BackColor = System.Drawing.Color.Green
        Me.PincomeIncomeVillage.Controls.Add(Me.sumIncomeVillage)
        Me.PincomeIncomeVillage.Controls.Add(Me.Label9)
        Me.PincomeIncomeVillage.Location = New System.Drawing.Point(597, 50)
        Me.PincomeIncomeVillage.Name = "PincomeIncomeVillage"
        Me.PincomeIncomeVillage.Size = New System.Drawing.Size(141, 67)
        Me.PincomeIncomeVillage.TabIndex = 19
        '
        'sumIncomeVillage
        '
        Me.sumIncomeVillage.AutoSize = True
        Me.sumIncomeVillage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.sumIncomeVillage.ForeColor = System.Drawing.Color.White
        Me.sumIncomeVillage.Location = New System.Drawing.Point(4, 31)
        Me.sumIncomeVillage.Name = "sumIncomeVillage"
        Me.sumIncomeVillage.Size = New System.Drawing.Size(35, 17)
        Me.sumIncomeVillage.TabIndex = 0
        Me.sumIncomeVillage.Text = "Rp 0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(4, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "IncomeVillage"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(4, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "-> Detail Trasnsaction"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(14, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(836, 20)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "system distribution total -> collectors 10% -> village 15%  -> district 15% -> ci" &
    "ty 15% -> province 15% -> center 30%"
        '
        'dFilterMounth
        '
        Me.dFilterMounth.Location = New System.Drawing.Point(547, 185)
        Me.dFilterMounth.Name = "dFilterMounth"
        Me.dFilterMounth.Size = New System.Drawing.Size(295, 23)
        Me.dFilterMounth.TabIndex = 20
        '
        'btnFilterDate
        '
        Me.btnFilterDate.BackColor = System.Drawing.Color.Green
        Me.btnFilterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFilterDate.ForeColor = System.Drawing.Color.White
        Me.btnFilterDate.Location = New System.Drawing.Point(848, 184)
        Me.btnFilterDate.Name = "btnFilterDate"
        Me.btnFilterDate.Size = New System.Drawing.Size(75, 24)
        Me.btnFilterDate.TabIndex = 9
        Me.btnFilterDate.Text = "Fillter"
        Me.btnFilterDate.UseVisualStyleBackColor = False
        '
        'btnFilterClear
        '
        Me.btnFilterClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFilterClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFilterClear.ForeColor = System.Drawing.Color.White
        Me.btnFilterClear.Location = New System.Drawing.Point(929, 184)
        Me.btnFilterClear.Name = "btnFilterClear"
        Me.btnFilterClear.Size = New System.Drawing.Size(97, 24)
        Me.btnFilterClear.TabIndex = 9
        Me.btnFilterClear.Text = "Clear Filter"
        Me.btnFilterClear.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.sumIncomeCollectors)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(744, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 67)
        Me.Panel1.TabIndex = 19
        '
        'sumIncomeCollectors
        '
        Me.sumIncomeCollectors.AutoSize = True
        Me.sumIncomeCollectors.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.sumIncomeCollectors.ForeColor = System.Drawing.Color.White
        Me.sumIncomeCollectors.Location = New System.Drawing.Point(4, 31)
        Me.sumIncomeCollectors.Name = "sumIncomeCollectors"
        Me.sumIncomeCollectors.Size = New System.Drawing.Size(35, 17)
        Me.sumIncomeCollectors.TabIndex = 0
        Me.sumIncomeCollectors.Text = "Rp 0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(4, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Income Collectors"
        '
        'pTotal
        '
        Me.pTotal.BackColor = System.Drawing.Color.Green
        Me.pTotal.Controls.Add(Me.SumTotal)
        Me.pTotal.Controls.Add(Me.Label16)
        Me.pTotal.Location = New System.Drawing.Point(891, 49)
        Me.pTotal.Name = "pTotal"
        Me.pTotal.Size = New System.Drawing.Size(141, 67)
        Me.pTotal.TabIndex = 19
        '
        'SumTotal
        '
        Me.SumTotal.AutoSize = True
        Me.SumTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SumTotal.ForeColor = System.Drawing.Color.White
        Me.SumTotal.Location = New System.Drawing.Point(4, 32)
        Me.SumTotal.Name = "SumTotal"
        Me.SumTotal.Size = New System.Drawing.Size(35, 17)
        Me.SumTotal.TabIndex = 0
        Me.SumTotal.Text = "Rp 0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(4, 4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 17)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Income Total"
        '
        'fDetailBoxTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1044, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.dFilterMounth)
        Me.Controls.Add(Me.pTotal)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PincomeIncomeVillage)
        Me.Controls.Add(Me.PincomeDistrict)
        Me.Controls.Add(Me.PIncomeCity)
        Me.Controls.Add(Me.PincomeProvince)
        Me.Controls.Add(Me.pIncomeCenter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cVillage)
        Me.Controls.Add(Me.cCity)
        Me.Controls.Add(Me.cProvince)
        Me.Controls.Add(Me.cDistrict)
        Me.Controls.Add(Me.btnFilterVillage)
        Me.Controls.Add(Me.btnFilterDistrict)
        Me.Controls.Add(Me.btnFilterClear)
        Me.Controls.Add(Me.btnFilterDate)
        Me.Controls.Add(Me.btnFilterCity)
        Me.Controls.Add(Me.btnFilterProvince)
        Me.Controls.Add(Me.dGridDetail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fDetailBoxTransaction"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "fDetailBoxTransaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dGridDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pIncomeCenter.ResumeLayout(False)
        Me.pIncomeCenter.PerformLayout()
        Me.PincomeProvince.ResumeLayout(False)
        Me.PincomeProvince.PerformLayout()
        Me.PIncomeCity.ResumeLayout(False)
        Me.PIncomeCity.PerformLayout()
        Me.PincomeDistrict.ResumeLayout(False)
        Me.PincomeDistrict.PerformLayout()
        Me.PincomeIncomeVillage.ResumeLayout(False)
        Me.PincomeIncomeVillage.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pTotal.ResumeLayout(False)
        Me.pTotal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dGridDetail As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cVillage As ComboBox
    Friend WithEvents cCity As ComboBox
    Friend WithEvents cProvince As ComboBox
    Friend WithEvents cDistrict As ComboBox
    Friend WithEvents btnFilterVillage As Button
    Friend WithEvents btnFilterDistrict As Button
    Friend WithEvents btnFilterCity As Button
    Friend WithEvents btnFilterProvince As Button
    Friend WithEvents pIncomeCenter As Panel
    Friend WithEvents PincomeProvince As Panel
    Friend WithEvents PIncomeCity As Panel
    Friend WithEvents PincomeDistrict As Panel
    Friend WithEvents PincomeIncomeVillage As Panel
    Friend WithEvents SumIncomeCenter As Label
    Friend WithEvents LIncome As Label
    Friend WithEvents SumIncomeProvince As Label
    Friend WithEvents LincomeProvince As Label
    Friend WithEvents sumIncomeCIty As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents sumIncomeDistrict As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents sumIncomeVillage As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents dFilterMounth As DateTimePicker
    Friend WithEvents btnFilterDate As Button
    Friend WithEvents btnFilterClear As Button
    Friend WithEvents Pincome As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents sumIncomeCollectors As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents pTotal As Panel
    Friend WithEvents SumTotal As Label
    Friend WithEvents Label16 As Label
End Class
