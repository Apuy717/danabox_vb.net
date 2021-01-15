<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fAdminVillage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fAdminVillage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LtitleUsernam = New System.Windows.Forms.Label()
        Me.btnLogoutVillageAdmin = New System.Windows.Forms.Button()
        Me.LIsAdmin = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PContainerVillage = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 43)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(70, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DanaBox"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Controls.Add(Me.LtitleUsernam)
        Me.Panel2.Controls.Add(Me.btnLogoutVillageAdmin)
        Me.Panel2.Controls.Add(Me.LIsAdmin)
        Me.Panel2.Location = New System.Drawing.Point(252, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(711, 43)
        Me.Panel2.TabIndex = 1
        '
        'LtitleUsernam
        '
        Me.LtitleUsernam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LtitleUsernam.AutoSize = True
        Me.LtitleUsernam.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LtitleUsernam.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LtitleUsernam.ForeColor = System.Drawing.Color.Green
        Me.LtitleUsernam.Location = New System.Drawing.Point(544, 11)
        Me.LtitleUsernam.Name = "LtitleUsernam"
        Me.LtitleUsernam.Size = New System.Drawing.Size(73, 23)
        Me.LtitleUsernam.TabIndex = 2
        Me.LtitleUsernam.Text = "is Admin"
        '
        'btnLogoutVillageAdmin
        '
        Me.btnLogoutVillageAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogoutVillageAdmin.BackColor = System.Drawing.Color.Green
        Me.btnLogoutVillageAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogoutVillageAdmin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLogoutVillageAdmin.ForeColor = System.Drawing.Color.White
        Me.btnLogoutVillageAdmin.Location = New System.Drawing.Point(623, 9)
        Me.btnLogoutVillageAdmin.Name = "btnLogoutVillageAdmin"
        Me.btnLogoutVillageAdmin.Size = New System.Drawing.Size(75, 27)
        Me.btnLogoutVillageAdmin.TabIndex = 1
        Me.btnLogoutVillageAdmin.Text = "Logout"
        Me.btnLogoutVillageAdmin.UseVisualStyleBackColor = False
        '
        'LIsAdmin
        '
        Me.LIsAdmin.AutoSize = True
        Me.LIsAdmin.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LIsAdmin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LIsAdmin.ForeColor = System.Drawing.Color.Green
        Me.LIsAdmin.Location = New System.Drawing.Point(7, 13)
        Me.LIsAdmin.Name = "LIsAdmin"
        Me.LIsAdmin.Size = New System.Drawing.Size(107, 21)
        Me.LIsAdmin.TabIndex = 0
        Me.LIsAdmin.Text = "Admin Village"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.btnReport)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.BtnHome)
        Me.Panel3.Controls.Add(Me.btnDeposit)
        Me.Panel3.Location = New System.Drawing.Point(1, 44)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(252, 470)
        Me.Panel3.TabIndex = 2
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.Green
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(11, 325)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(226, 37)
        Me.btnReport.TabIndex = 0
        Me.btnReport.Text = "DETAIL TRIANSACTION"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(11, 282)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(226, 37)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "SALDO BOX PILLGRIMS"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(11, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(226, 37)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "MASTER PILGRIMS"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BtnHome
        '
        Me.BtnHome.BackColor = System.Drawing.Color.Green
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHome.ForeColor = System.Drawing.Color.White
        Me.BtnHome.Location = New System.Drawing.Point(11, 195)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(226, 37)
        Me.BtnHome.TabIndex = 0
        Me.BtnHome.Text = "HOME"
        Me.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHome.UseVisualStyleBackColor = False
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.Green
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeposit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDeposit.ForeColor = System.Drawing.Color.White
        Me.btnDeposit.Location = New System.Drawing.Point(11, 368)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(226, 37)
        Me.btnDeposit.TabIndex = 0
        Me.btnDeposit.Text = "DEPOSITE"
        Me.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeposit.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Location = New System.Drawing.Point(1, 44)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(251, 189)
        Me.Panel4.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PContainerVillage
        '
        Me.PContainerVillage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PContainerVillage.Location = New System.Drawing.Point(257, 44)
        Me.PContainerVillage.Name = "PContainerVillage"
        Me.PContainerVillage.Size = New System.Drawing.Size(702, 470)
        Me.PContainerVillage.TabIndex = 3
        '
        'fAdminVillage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(962, 514)
        Me.Controls.Add(Me.PContainerVillage)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "fAdminVillage"
        Me.Text = "fAdminVillage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LIsAdmin As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDeposit As Button
    Friend WithEvents PContainerVillage As Panel
    Friend WithEvents LtitleUsernam As Label
    Friend WithEvents btnLogoutVillageAdmin As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnHome As Button
    Friend WithEvents btnReport As Button
End Class
