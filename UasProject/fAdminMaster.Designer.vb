<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fAdminMaster
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
        Me.BtnAddAdmin = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tSearchAdmin = New System.Windows.Forms.TextBox()
        Me.tFilterAdminRole = New System.Windows.Forms.ComboBox()
        Me.btnFilterRole = New System.Windows.Forms.Button()
        Me.tFilterAdminStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTrash = New System.Windows.Forms.Button()
        Me.LNavigation = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAddAdmin
        '
        Me.BtnAddAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddAdmin.BackColor = System.Drawing.Color.Green
        Me.BtnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAddAdmin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAddAdmin.ForeColor = System.Drawing.Color.White
        Me.BtnAddAdmin.Location = New System.Drawing.Point(847, 6)
        Me.BtnAddAdmin.Name = "BtnAddAdmin"
        Me.BtnAddAdmin.Size = New System.Drawing.Size(152, 29)
        Me.BtnAddAdmin.TabIndex = 0
        Me.BtnAddAdmin.Text = "Add Admin"
        Me.BtnAddAdmin.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1009, 453)
        Me.DataGridView1.TabIndex = 1
        '
        'tSearchAdmin
        '
        Me.tSearchAdmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tSearchAdmin.Location = New System.Drawing.Point(1, 63)
        Me.tSearchAdmin.Multiline = True
        Me.tSearchAdmin.Name = "tSearchAdmin"
        Me.tSearchAdmin.PlaceholderText = "Search by Full Name"
        Me.tSearchAdmin.Size = New System.Drawing.Size(382, 23)
        Me.tSearchAdmin.TabIndex = 2
        '
        'tFilterAdminRole
        '
        Me.tFilterAdminRole.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tFilterAdminRole.AutoCompleteCustomSource.AddRange(New String() {"All", "Admin Center", "Admin Province", "Admin  City", "Admin District", "Admin Vilage"})
        Me.tFilterAdminRole.FormattingEnabled = True
        Me.tFilterAdminRole.Items.AddRange(New Object() {"All", "Admin Center", "Admin Province", "Admin City", "Admin District", "Admin Village"})
        Me.tFilterAdminRole.Location = New System.Drawing.Point(389, 63)
        Me.tFilterAdminRole.Name = "tFilterAdminRole"
        Me.tFilterAdminRole.Size = New System.Drawing.Size(197, 23)
        Me.tFilterAdminRole.TabIndex = 3
        Me.tFilterAdminRole.Text = "All"
        '
        'btnFilterRole
        '
        Me.btnFilterRole.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterRole.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFilterRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterRole.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFilterRole.ForeColor = System.Drawing.Color.White
        Me.btnFilterRole.Location = New System.Drawing.Point(792, 62)
        Me.btnFilterRole.Name = "btnFilterRole"
        Me.btnFilterRole.Size = New System.Drawing.Size(68, 23)
        Me.btnFilterRole.TabIndex = 4
        Me.btnFilterRole.Text = "FIlter"
        Me.btnFilterRole.UseVisualStyleBackColor = False
        '
        'tFilterAdminStatus
        '
        Me.tFilterAdminStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tFilterAdminStatus.FormattingEnabled = True
        Me.tFilterAdminStatus.Items.AddRange(New Object() {"Active", "Trash"})
        Me.tFilterAdminStatus.Location = New System.Drawing.Point(592, 63)
        Me.tFilterAdminStatus.Name = "tFilterAdminStatus"
        Me.tFilterAdminStatus.Size = New System.Drawing.Size(197, 23)
        Me.tFilterAdminStatus.TabIndex = 5
        Me.tFilterAdminStatus.Text = "Active"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(1, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Search"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(389, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Role"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(592, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Status"
        '
        'btnTrash
        '
        Me.btnTrash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTrash.BackColor = System.Drawing.Color.Red
        Me.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrash.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTrash.ForeColor = System.Drawing.Color.White
        Me.btnTrash.Location = New System.Drawing.Point(866, 63)
        Me.btnTrash.Name = "btnTrash"
        Me.btnTrash.Size = New System.Drawing.Size(68, 23)
        Me.btnTrash.TabIndex = 4
        Me.btnTrash.Text = "Trash"
        Me.btnTrash.UseVisualStyleBackColor = False
        '
        'LNavigation
        '
        Me.LNavigation.AutoSize = True
        Me.LNavigation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LNavigation.ForeColor = System.Drawing.Color.Green
        Me.LNavigation.Location = New System.Drawing.Point(12, 9)
        Me.LNavigation.Name = "LNavigation"
        Me.LNavigation.Size = New System.Drawing.Size(138, 21)
        Me.LNavigation.TabIndex = 8
        Me.LNavigation.Text = "-> Admin Master"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(938, 63)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(68, 23)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'fAdminMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1011, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.LNavigation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tFilterAdminStatus)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnTrash)
        Me.Controls.Add(Me.btnFilterRole)
        Me.Controls.Add(Me.tFilterAdminRole)
        Me.Controls.Add(Me.tSearchAdmin)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnAddAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fAdminMaster"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "fAdminMaster"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAddAdmin As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tSearchAdmin As TextBox
    Friend WithEvents tFilterAdminRole As ComboBox
    Friend WithEvents btnFilterRole As Button
    Friend WithEvents tFilterAdminStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTrash As Button
    Friend WithEvents LNavigation As Label
    Friend WithEvents btnUpdate As Button
End Class
