<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.SiticoneShadowPanel1 = New Siticone.UI.WinForms.SiticoneShadowPanel()
        Me.controls_panel = New System.Windows.Forms.Panel()
        Me.SiticoneShadowPanel2 = New Siticone.UI.WinForms.SiticoneShadowPanel()
        Me.content_box = New System.Windows.Forms.FlowLayoutPanel()
        Me.gradeBtn = New Siticone.UI.WinForms.SiticoneButton()
        Me.reportsBtn = New Siticone.UI.WinForms.SiticoneButton()
        Me.paymentBtn = New Siticone.UI.WinForms.SiticoneButton()
        Me.requirementsBtn = New Siticone.UI.WinForms.SiticoneButton()
        Me.studentInfoBtn = New Siticone.UI.WinForms.SiticoneButton()
        Me.dashboardBtn = New Siticone.UI.WinForms.SiticoneButton()
        Me.logoutBtn = New Siticone.UI.WinForms.SiticoneButton()
        Me.settingsBtn = New Siticone.UI.WinForms.SiticoneButton()
        Me.SiticonePictureBox1 = New Siticone.UI.WinForms.SiticonePictureBox()
        Me.SiticoneShadowPanel1.SuspendLayout()
        Me.controls_panel.SuspendLayout()
        Me.SiticoneShadowPanel2.SuspendLayout()
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SiticoneShadowPanel1
        '
        Me.SiticoneShadowPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SiticoneShadowPanel1.AutoSize = True
        Me.SiticoneShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneShadowPanel1.Controls.Add(Me.controls_panel)
        Me.SiticoneShadowPanel1.Controls.Add(Me.logoutBtn)
        Me.SiticoneShadowPanel1.Controls.Add(Me.settingsBtn)
        Me.SiticoneShadowPanel1.Controls.Add(Me.SiticonePictureBox1)
        Me.SiticoneShadowPanel1.FillColor = System.Drawing.Color.White
        Me.SiticoneShadowPanel1.Location = New System.Drawing.Point(12, 12)
        Me.SiticoneShadowPanel1.Name = "SiticoneShadowPanel1"
        Me.SiticoneShadowPanel1.Radius = 10
        Me.SiticoneShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.SiticoneShadowPanel1.ShadowDepth = 50
        Me.SiticoneShadowPanel1.Size = New System.Drawing.Size(278, 620)
        Me.SiticoneShadowPanel1.TabIndex = 1
        '
        'controls_panel
        '
        Me.controls_panel.Controls.Add(Me.gradeBtn)
        Me.controls_panel.Controls.Add(Me.reportsBtn)
        Me.controls_panel.Controls.Add(Me.paymentBtn)
        Me.controls_panel.Controls.Add(Me.requirementsBtn)
        Me.controls_panel.Controls.Add(Me.studentInfoBtn)
        Me.controls_panel.Controls.Add(Me.dashboardBtn)
        Me.controls_panel.Location = New System.Drawing.Point(0, 126)
        Me.controls_panel.Name = "controls_panel"
        Me.controls_panel.Size = New System.Drawing.Size(275, 372)
        Me.controls_panel.TabIndex = 8
        '
        'SiticoneShadowPanel2
        '
        Me.SiticoneShadowPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneShadowPanel2.AutoSize = True
        Me.SiticoneShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneShadowPanel2.Controls.Add(Me.content_box)
        Me.SiticoneShadowPanel2.FillColor = System.Drawing.Color.White
        Me.SiticoneShadowPanel2.Location = New System.Drawing.Point(293, 12)
        Me.SiticoneShadowPanel2.Name = "SiticoneShadowPanel2"
        Me.SiticoneShadowPanel2.Radius = 10
        Me.SiticoneShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.SiticoneShadowPanel2.ShadowDepth = 50
        Me.SiticoneShadowPanel2.Size = New System.Drawing.Size(933, 620)
        Me.SiticoneShadowPanel2.TabIndex = 2
        '
        'content_box
        '
        Me.content_box.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.content_box.BackColor = System.Drawing.Color.Transparent
        Me.content_box.Location = New System.Drawing.Point(15, 18)
        Me.content_box.Name = "content_box"
        Me.content_box.Size = New System.Drawing.Size(902, 582)
        Me.content_box.TabIndex = 0
        '
        'gradeBtn
        '
        Me.gradeBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gradeBtn.BackgroundImage = Global.LIS.My.Resources.src.report
        Me.gradeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gradeBtn.BorderRadius = 5
        Me.gradeBtn.CheckedState.Parent = Me.gradeBtn
        Me.gradeBtn.CustomImages.Parent = Me.gradeBtn
        Me.gradeBtn.FillColor = System.Drawing.Color.White
        Me.gradeBtn.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gradeBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gradeBtn.HoveredState.ForeColor = System.Drawing.Color.White
        Me.gradeBtn.HoveredState.Image = Global.LIS.My.Resources.src.report_hover
        Me.gradeBtn.HoveredState.Parent = Me.gradeBtn
        Me.gradeBtn.Image = Global.LIS.My.Resources.src.report
        Me.gradeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.gradeBtn.Location = New System.Drawing.Point(22, 294)
        Me.gradeBtn.Name = "gradeBtn"
        Me.gradeBtn.ShadowDecoration.Parent = Me.gradeBtn
        Me.gradeBtn.Size = New System.Drawing.Size(234, 45)
        Me.gradeBtn.TabIndex = 11
        Me.gradeBtn.Text = "Grade"
        Me.gradeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.gradeBtn.TextOffset = New System.Drawing.Point(0, 2)
        '
        'reportsBtn
        '
        Me.reportsBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reportsBtn.BackgroundImage = Global.LIS.My.Resources.src.report
        Me.reportsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.reportsBtn.BorderRadius = 5
        Me.reportsBtn.CheckedState.Parent = Me.reportsBtn
        Me.reportsBtn.CustomImages.Parent = Me.reportsBtn
        Me.reportsBtn.FillColor = System.Drawing.Color.White
        Me.reportsBtn.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.reportsBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.reportsBtn.HoveredState.ForeColor = System.Drawing.Color.White
        Me.reportsBtn.HoveredState.Image = Global.LIS.My.Resources.src.report_hover
        Me.reportsBtn.HoveredState.Parent = Me.reportsBtn
        Me.reportsBtn.Image = Global.LIS.My.Resources.src.report
        Me.reportsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.reportsBtn.Location = New System.Drawing.Point(22, 243)
        Me.reportsBtn.Name = "reportsBtn"
        Me.reportsBtn.ShadowDecoration.Parent = Me.reportsBtn
        Me.reportsBtn.Size = New System.Drawing.Size(234, 45)
        Me.reportsBtn.TabIndex = 10
        Me.reportsBtn.Text = "Tracking Reports"
        Me.reportsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.reportsBtn.TextOffset = New System.Drawing.Point(0, 2)
        '
        'paymentBtn
        '
        Me.paymentBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.paymentBtn.BackgroundImage = Global.LIS.My.Resources.src.payment
        Me.paymentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.paymentBtn.BorderRadius = 5
        Me.paymentBtn.CheckedState.Parent = Me.paymentBtn
        Me.paymentBtn.CustomImages.Parent = Me.paymentBtn
        Me.paymentBtn.FillColor = System.Drawing.Color.White
        Me.paymentBtn.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.paymentBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.paymentBtn.HoveredState.ForeColor = System.Drawing.Color.White
        Me.paymentBtn.HoveredState.Image = Global.LIS.My.Resources.src.payment_hover
        Me.paymentBtn.HoveredState.Parent = Me.paymentBtn
        Me.paymentBtn.Image = Global.LIS.My.Resources.src.payment
        Me.paymentBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.paymentBtn.Location = New System.Drawing.Point(22, 192)
        Me.paymentBtn.Name = "paymentBtn"
        Me.paymentBtn.ShadowDecoration.Parent = Me.paymentBtn
        Me.paymentBtn.Size = New System.Drawing.Size(234, 45)
        Me.paymentBtn.TabIndex = 9
        Me.paymentBtn.Text = "Payment"
        Me.paymentBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.paymentBtn.TextOffset = New System.Drawing.Point(0, 2)
        '
        'requirementsBtn
        '
        Me.requirementsBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.requirementsBtn.BackgroundImage = Global.LIS.My.Resources.src.requirement
        Me.requirementsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.requirementsBtn.BorderRadius = 5
        Me.requirementsBtn.CheckedState.Parent = Me.requirementsBtn
        Me.requirementsBtn.CustomImages.Parent = Me.requirementsBtn
        Me.requirementsBtn.FillColor = System.Drawing.Color.White
        Me.requirementsBtn.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requirementsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.requirementsBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.requirementsBtn.HoveredState.ForeColor = System.Drawing.Color.White
        Me.requirementsBtn.HoveredState.Image = Global.LIS.My.Resources.src.requirement_hover
        Me.requirementsBtn.HoveredState.Parent = Me.requirementsBtn
        Me.requirementsBtn.Image = Global.LIS.My.Resources.src.requirement
        Me.requirementsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.requirementsBtn.Location = New System.Drawing.Point(22, 141)
        Me.requirementsBtn.Name = "requirementsBtn"
        Me.requirementsBtn.ShadowDecoration.Parent = Me.requirementsBtn
        Me.requirementsBtn.Size = New System.Drawing.Size(234, 45)
        Me.requirementsBtn.TabIndex = 8
        Me.requirementsBtn.Text = "Requirement"
        Me.requirementsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.requirementsBtn.TextOffset = New System.Drawing.Point(0, 2)
        '
        'studentInfoBtn
        '
        Me.studentInfoBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.studentInfoBtn.BackgroundImage = Global.LIS.My.Resources.src.person
        Me.studentInfoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.studentInfoBtn.BorderRadius = 5
        Me.studentInfoBtn.CheckedState.Parent = Me.studentInfoBtn
        Me.studentInfoBtn.CustomImages.Parent = Me.studentInfoBtn
        Me.studentInfoBtn.FillColor = System.Drawing.Color.White
        Me.studentInfoBtn.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentInfoBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.studentInfoBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.studentInfoBtn.HoveredState.ForeColor = System.Drawing.Color.White
        Me.studentInfoBtn.HoveredState.Image = Global.LIS.My.Resources.src.person_hover
        Me.studentInfoBtn.HoveredState.Parent = Me.studentInfoBtn
        Me.studentInfoBtn.Image = Global.LIS.My.Resources.src.person
        Me.studentInfoBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.studentInfoBtn.Location = New System.Drawing.Point(22, 90)
        Me.studentInfoBtn.Name = "studentInfoBtn"
        Me.studentInfoBtn.ShadowDecoration.Parent = Me.studentInfoBtn
        Me.studentInfoBtn.Size = New System.Drawing.Size(234, 45)
        Me.studentInfoBtn.TabIndex = 7
        Me.studentInfoBtn.Text = "Student Information"
        Me.studentInfoBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.studentInfoBtn.TextOffset = New System.Drawing.Point(0, 2)
        '
        'dashboardBtn
        '
        Me.dashboardBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dashboardBtn.BackgroundImage = Global.LIS.My.Resources.src.dashboard
        Me.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dashboardBtn.BorderRadius = 5
        Me.dashboardBtn.CheckedState.Parent = Me.dashboardBtn
        Me.dashboardBtn.CustomImages.Parent = Me.dashboardBtn
        Me.dashboardBtn.FillColor = System.Drawing.Color.White
        Me.dashboardBtn.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboardBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.dashboardBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.dashboardBtn.HoveredState.ForeColor = System.Drawing.Color.White
        Me.dashboardBtn.HoveredState.Image = Global.LIS.My.Resources.src.dashboard_hover
        Me.dashboardBtn.HoveredState.Parent = Me.dashboardBtn
        Me.dashboardBtn.Image = Global.LIS.My.Resources.src.dashboard
        Me.dashboardBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.dashboardBtn.Location = New System.Drawing.Point(22, 39)
        Me.dashboardBtn.Name = "dashboardBtn"
        Me.dashboardBtn.ShadowDecoration.Parent = Me.dashboardBtn
        Me.dashboardBtn.Size = New System.Drawing.Size(234, 45)
        Me.dashboardBtn.TabIndex = 6
        Me.dashboardBtn.Text = "Dashboard"
        Me.dashboardBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.dashboardBtn.TextOffset = New System.Drawing.Point(0, 2)
        '
        'logoutBtn
        '
        Me.logoutBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logoutBtn.BorderRadius = 5
        Me.logoutBtn.CheckedState.Parent = Me.logoutBtn
        Me.logoutBtn.CustomImages.Parent = Me.logoutBtn
        Me.logoutBtn.FillColor = System.Drawing.Color.White
        Me.logoutBtn.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.logoutBtn.HoveredState.FillColor = System.Drawing.Color.Maroon
        Me.logoutBtn.HoveredState.ForeColor = System.Drawing.Color.White
        Me.logoutBtn.HoveredState.Image = Global.LIS.My.Resources.src.out_hover
        Me.logoutBtn.HoveredState.Parent = Me.logoutBtn
        Me.logoutBtn.Image = Global.LIS.My.Resources.src.out
        Me.logoutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.logoutBtn.Location = New System.Drawing.Point(22, 555)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.ShadowDecoration.Parent = Me.logoutBtn
        Me.logoutBtn.Size = New System.Drawing.Size(234, 45)
        Me.logoutBtn.TabIndex = 7
        Me.logoutBtn.Text = "Log out"
        Me.logoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.logoutBtn.TextOffset = New System.Drawing.Point(0, 2)
        '
        'settingsBtn
        '
        Me.settingsBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settingsBtn.BorderRadius = 5
        Me.settingsBtn.CheckedState.Parent = Me.settingsBtn
        Me.settingsBtn.CustomImages.Parent = Me.settingsBtn
        Me.settingsBtn.FillColor = System.Drawing.Color.White
        Me.settingsBtn.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.settingsBtn.HoveredState.FillColor = System.Drawing.Color.Maroon
        Me.settingsBtn.HoveredState.ForeColor = System.Drawing.Color.White
        Me.settingsBtn.HoveredState.Image = Global.LIS.My.Resources.src.settings_hover
        Me.settingsBtn.HoveredState.Parent = Me.settingsBtn
        Me.settingsBtn.Image = Global.LIS.My.Resources.src.settings
        Me.settingsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.settingsBtn.Location = New System.Drawing.Point(22, 504)
        Me.settingsBtn.Name = "settingsBtn"
        Me.settingsBtn.ShadowDecoration.Parent = Me.settingsBtn
        Me.settingsBtn.Size = New System.Drawing.Size(234, 45)
        Me.settingsBtn.TabIndex = 6
        Me.settingsBtn.Text = "Settings"
        Me.settingsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.settingsBtn.TextOffset = New System.Drawing.Point(0, 2)
        '
        'SiticonePictureBox1
        '
        Me.SiticonePictureBox1.Image = Global.LIS.My.Resources.src.logo
        Me.SiticonePictureBox1.Location = New System.Drawing.Point(22, 18)
        Me.SiticonePictureBox1.Name = "SiticonePictureBox1"
        Me.SiticonePictureBox1.ShadowDecoration.Parent = Me.SiticonePictureBox1
        Me.SiticonePictureBox1.Size = New System.Drawing.Size(77, 73)
        Me.SiticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SiticonePictureBox1.TabIndex = 0
        Me.SiticonePictureBox1.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1238, 644)
        Me.Controls.Add(Me.SiticoneShadowPanel2)
        Me.Controls.Add(Me.SiticoneShadowPanel1)
        Me.MinimizeBox = False
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SiticoneShadowPanel1.ResumeLayout(False)
        Me.controls_panel.ResumeLayout(False)
        Me.SiticoneShadowPanel2.ResumeLayout(False)
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SiticoneShadowPanel1 As Siticone.UI.WinForms.SiticoneShadowPanel
    Friend WithEvents SiticoneShadowPanel2 As Siticone.UI.WinForms.SiticoneShadowPanel
    Friend WithEvents SiticonePictureBox1 As Siticone.UI.WinForms.SiticonePictureBox
    Friend WithEvents settingsBtn As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents logoutBtn As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents content_box As FlowLayoutPanel
    Friend WithEvents controls_panel As Panel
    Friend WithEvents reportsBtn As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents paymentBtn As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents requirementsBtn As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents studentInfoBtn As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents dashboardBtn As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents gradeBtn As Siticone.UI.WinForms.SiticoneButton
End Class
