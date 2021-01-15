<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fDeposit
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSubmitDepo = New System.Windows.Forms.Button()
        Me.tTotalDepo = New System.Windows.Forms.NumericUpDown()
        Me.tMoundYearDepo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tCitiIDDepo = New System.Windows.Forms.ComboBox()
        Me.tVillageIDDepo = New System.Windows.Forms.ComboBox()
        Me.tDistritIDDepo = New System.Windows.Forms.ComboBox()
        Me.tProvinceIDDepo = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lCenterRp = New System.Windows.Forms.Label()
        Me.lDistrictRp = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lProvinceRp = New System.Windows.Forms.Label()
        Me.lVillageRp = New System.Windows.Forms.Label()
        Me.lVillages = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lCityRp = New System.Windows.Forms.Label()
        Me.lCollectorsRp = New System.Windows.Forms.Label()
        Me.lCollectors = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tTotalDepo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnSubmitDepo)
        Me.GroupBox1.Controls.Add(Me.tTotalDepo)
        Me.GroupBox1.Controls.Add(Me.tMoundYearDepo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tCitiIDDepo)
        Me.GroupBox1.Controls.Add(Me.tVillageIDDepo)
        Me.GroupBox1.Controls.Add(Me.tDistritIDDepo)
        Me.GroupBox1.Controls.Add(Me.tProvinceIDDepo)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(861, 309)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deposit "
        '
        'btnSubmitDepo
        '
        Me.btnSubmitDepo.BackColor = System.Drawing.Color.Green
        Me.btnSubmitDepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitDepo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSubmitDepo.ForeColor = System.Drawing.Color.White
        Me.btnSubmitDepo.Location = New System.Drawing.Point(43, 252)
        Me.btnSubmitDepo.Name = "btnSubmitDepo"
        Me.btnSubmitDepo.Size = New System.Drawing.Size(99, 27)
        Me.btnSubmitDepo.TabIndex = 4
        Me.btnSubmitDepo.Text = "Submit"
        Me.btnSubmitDepo.UseVisualStyleBackColor = False
        '
        'tTotalDepo
        '
        Me.tTotalDepo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tTotalDepo.Location = New System.Drawing.Point(452, 197)
        Me.tTotalDepo.Maximum = New Decimal(New Integer() {-559939585, 902409669, 54, 0})
        Me.tTotalDepo.Name = "tTotalDepo"
        Me.tTotalDepo.Size = New System.Drawing.Size(369, 23)
        Me.tTotalDepo.TabIndex = 3
        '
        'tMoundYearDepo
        '
        Me.tMoundYearDepo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tMoundYearDepo.Location = New System.Drawing.Point(43, 198)
        Me.tMoundYearDepo.Name = "tMoundYearDepo"
        Me.tMoundYearDepo.Size = New System.Drawing.Size(369, 23)
        Me.tMoundYearDepo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(452, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "City"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(452, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total Deposit"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(452, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Village"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(43, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Moon "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(43, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "District"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(43, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Province"
        '
        'tCitiIDDepo
        '
        Me.tCitiIDDepo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tCitiIDDepo.FormattingEnabled = True
        Me.tCitiIDDepo.Location = New System.Drawing.Point(452, 57)
        Me.tCitiIDDepo.Name = "tCitiIDDepo"
        Me.tCitiIDDepo.Size = New System.Drawing.Size(369, 23)
        Me.tCitiIDDepo.TabIndex = 0
        '
        'tVillageIDDepo
        '
        Me.tVillageIDDepo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tVillageIDDepo.FormattingEnabled = True
        Me.tVillageIDDepo.Location = New System.Drawing.Point(452, 130)
        Me.tVillageIDDepo.Name = "tVillageIDDepo"
        Me.tVillageIDDepo.Size = New System.Drawing.Size(369, 23)
        Me.tVillageIDDepo.TabIndex = 0
        '
        'tDistritIDDepo
        '
        Me.tDistritIDDepo.FormattingEnabled = True
        Me.tDistritIDDepo.Location = New System.Drawing.Point(43, 130)
        Me.tDistritIDDepo.Name = "tDistritIDDepo"
        Me.tDistritIDDepo.Size = New System.Drawing.Size(369, 23)
        Me.tDistritIDDepo.TabIndex = 0
        '
        'tProvinceIDDepo
        '
        Me.tProvinceIDDepo.FormattingEnabled = True
        Me.tProvinceIDDepo.Location = New System.Drawing.Point(43, 57)
        Me.tProvinceIDDepo.Name = "tProvinceIDDepo"
        Me.tProvinceIDDepo.Size = New System.Drawing.Size(369, 23)
        Me.tProvinceIDDepo.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(23, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(242, 126)
        Me.Panel1.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(153, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Center 30%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(16, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 17)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Province 15%"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(153, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 17)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "City 15%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(16, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "District 15%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(153, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Village 15%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(16, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Collector 10%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(16, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Division System"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.lCenterRp)
        Me.Panel2.Controls.Add(Me.lDistrictRp)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.lProvinceRp)
        Me.Panel2.Controls.Add(Me.lVillageRp)
        Me.Panel2.Controls.Add(Me.lVillages)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.lCityRp)
        Me.Panel2.Controls.Add(Me.lCollectorsRp)
        Me.Panel2.Controls.Add(Me.lCollectors)
        Me.Panel2.Location = New System.Drawing.Point(282, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(678, 126)
        Me.Panel2.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(391, 92)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 17)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Center"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(458, 92)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(17, 17)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "="
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(92, 92)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(17, 17)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "="
        '
        'lCenterRp
        '
        Me.lCenterRp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lCenterRp.AutoSize = True
        Me.lCenterRp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lCenterRp.ForeColor = System.Drawing.Color.White
        Me.lCenterRp.Location = New System.Drawing.Point(481, 92)
        Me.lCenterRp.Name = "lCenterRp"
        Me.lCenterRp.Size = New System.Drawing.Size(35, 17)
        Me.lCenterRp.TabIndex = 0
        Me.lCenterRp.Text = "Rp 0"
        '
        'lDistrictRp
        '
        Me.lDistrictRp.AutoSize = True
        Me.lDistrictRp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lDistrictRp.ForeColor = System.Drawing.Color.White
        Me.lDistrictRp.Location = New System.Drawing.Point(115, 92)
        Me.lDistrictRp.Name = "lDistrictRp"
        Me.lDistrictRp.Size = New System.Drawing.Size(35, 17)
        Me.lDistrictRp.TabIndex = 0
        Me.lDistrictRp.Text = "Rp 0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(15, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 17)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "District"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(391, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 17)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Province"
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(458, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(17, 17)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "="
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(92, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 17)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "="
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label24.ForeColor = System.Drawing.Color.Yellow
        Me.Label24.Location = New System.Drawing.Point(15, 11)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(131, 17)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Save OR Transfer To"
        '
        'lProvinceRp
        '
        Me.lProvinceRp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lProvinceRp.AutoSize = True
        Me.lProvinceRp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lProvinceRp.ForeColor = System.Drawing.Color.White
        Me.lProvinceRp.Location = New System.Drawing.Point(481, 64)
        Me.lProvinceRp.Name = "lProvinceRp"
        Me.lProvinceRp.Size = New System.Drawing.Size(35, 17)
        Me.lProvinceRp.TabIndex = 0
        Me.lProvinceRp.Text = "Rp 0"
        '
        'lVillageRp
        '
        Me.lVillageRp.AutoSize = True
        Me.lVillageRp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lVillageRp.ForeColor = System.Drawing.Color.White
        Me.lVillageRp.Location = New System.Drawing.Point(115, 64)
        Me.lVillageRp.Name = "lVillageRp"
        Me.lVillageRp.Size = New System.Drawing.Size(35, 17)
        Me.lVillageRp.TabIndex = 0
        Me.lVillageRp.Text = "Rp 0"
        '
        'lVillages
        '
        Me.lVillages.AutoSize = True
        Me.lVillages.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lVillages.ForeColor = System.Drawing.Color.White
        Me.lVillages.Location = New System.Drawing.Point(15, 64)
        Me.lVillages.Name = "lVillages"
        Me.lVillages.Size = New System.Drawing.Size(51, 17)
        Me.lVillages.TabIndex = 0
        Me.lVillages.Text = "Village"
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(458, 36)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(17, 17)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "="
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(391, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 17)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "City"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(92, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "="
        '
        'lCityRp
        '
        Me.lCityRp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lCityRp.AutoSize = True
        Me.lCityRp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lCityRp.ForeColor = System.Drawing.Color.White
        Me.lCityRp.Location = New System.Drawing.Point(481, 36)
        Me.lCityRp.Name = "lCityRp"
        Me.lCityRp.Size = New System.Drawing.Size(35, 17)
        Me.lCityRp.TabIndex = 0
        Me.lCityRp.Text = "Rp 0"
        '
        'lCollectorsRp
        '
        Me.lCollectorsRp.AutoSize = True
        Me.lCollectorsRp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lCollectorsRp.ForeColor = System.Drawing.Color.White
        Me.lCollectorsRp.Location = New System.Drawing.Point(115, 36)
        Me.lCollectorsRp.Name = "lCollectorsRp"
        Me.lCollectorsRp.Size = New System.Drawing.Size(35, 17)
        Me.lCollectorsRp.TabIndex = 0
        Me.lCollectorsRp.Text = "Rp 0"
        '
        'lCollectors
        '
        Me.lCollectors.AutoSize = True
        Me.lCollectors.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lCollectors.ForeColor = System.Drawing.Color.White
        Me.lCollectors.Location = New System.Drawing.Point(15, 36)
        Me.lCollectors.Name = "lCollectors"
        Me.lCollectors.Size = New System.Drawing.Size(63, 17)
        Me.lCollectors.TabIndex = 0
        Me.lCollectors.Text = "Collector"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label31.ForeColor = System.Drawing.Color.Green
        Me.Label31.Location = New System.Drawing.Point(23, 9)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(121, 17)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "-> Village Deposit"
        '
        'fDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(995, 541)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label31)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fDeposit"
        Me.Text = "fDeposit"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tTotalDepo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSubmitDepo As Button
    Friend WithEvents tTotalDepo As NumericUpDown
    Friend WithEvents tMoundYearDepo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tCitiIDDepo As ComboBox
    Friend WithEvents tVillageIDDepo As ComboBox
    Friend WithEvents tDistritIDDepo As ComboBox
    Friend WithEvents tProvinceIDDepo As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lVillages As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lCollectors As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lCenterRp As Label
    Friend WithEvents lDistrictRp As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lProvinceRp As Label
    Friend WithEvents lVillageRp As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lCityRp As Label
    Friend WithEvents lCollectorsRp As Label
    Friend WithEvents Label31 As Label
End Class
