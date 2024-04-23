<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editStudent
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
        Me.components = New System.ComponentModel.Container()
        Me.SiticoneLabel1 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.stdno = New Siticone.UI.WinForms.SiticoneTextBox()
        Me.SiticoneLabel2 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.fname = New Siticone.UI.WinForms.SiticoneTextBox()
        Me.SiticoneLabel3 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.lname = New Siticone.UI.WinForms.SiticoneTextBox()
        Me.SiticoneLabel4 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.mname = New Siticone.UI.WinForms.SiticoneTextBox()
        Me.SiticoneLabel5 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.SiticoneLabel17 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.comboboxyrlevel = New Siticone.UI.WinForms.SiticoneComboBox()
        Me.SiticoneLabel18 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.comboboxcourse = New Siticone.UI.WinForms.SiticoneComboBox()
        Me.SiticoneLabel16 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.comboboxsection = New Siticone.UI.WinForms.SiticoneComboBox()
        Me.SiticoneShadowForm1 = New Siticone.UI.WinForms.SiticoneShadowForm(Me.components)
        Me.cancelBtn = New Siticone.UI.WinForms.SiticoneButton()
        Me.submitBtn = New Siticone.UI.WinForms.SiticoneButton()
        Me.SiticoneLabel6 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.comboboxtype = New Siticone.UI.WinForms.SiticoneComboBox()
        Me.SuspendLayout()
        '
        'SiticoneLabel1
        '
        Me.SiticoneLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel1.Font = New System.Drawing.Font("Perpetua", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel1.Location = New System.Drawing.Point(12, 12)
        Me.SiticoneLabel1.Name = "SiticoneLabel1"
        Me.SiticoneLabel1.Size = New System.Drawing.Size(260, 30)
        Me.SiticoneLabel1.TabIndex = 32
        Me.SiticoneLabel1.Text = "Edit Student Information"
        '
        'stdno
        '
        Me.stdno.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.stdno.BorderRadius = 10
        Me.stdno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.stdno.DefaultText = ""
        Me.stdno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.stdno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.stdno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.stdno.DisabledState.Parent = Me.stdno
        Me.stdno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.stdno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stdno.FocusedState.Parent = Me.stdno
        Me.stdno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.stdno.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stdno.HoveredState.Parent = Me.stdno
        Me.stdno.Location = New System.Drawing.Point(12, 73)
        Me.stdno.Name = "stdno"
        Me.stdno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.stdno.PlaceholderText = ""
        Me.stdno.ReadOnly = True
        Me.stdno.SelectedText = ""
        Me.stdno.ShadowDecoration.Parent = Me.stdno
        Me.stdno.Size = New System.Drawing.Size(214, 44)
        Me.stdno.TabIndex = 33
        '
        'SiticoneLabel2
        '
        Me.SiticoneLabel2.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel2.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SiticoneLabel2.Location = New System.Drawing.Point(12, 52)
        Me.SiticoneLabel2.Name = "SiticoneLabel2"
        Me.SiticoneLabel2.Size = New System.Drawing.Size(77, 19)
        Me.SiticoneLabel2.TabIndex = 34
        Me.SiticoneLabel2.Text = "Student No."
        '
        'fname
        '
        Me.fname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fname.BorderRadius = 10
        Me.fname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fname.DefaultText = ""
        Me.fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fname.DisabledState.Parent = Me.fname
        Me.fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fname.FocusedState.Parent = Me.fname
        Me.fname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fname.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fname.HoveredState.Parent = Me.fname
        Me.fname.Location = New System.Drawing.Point(270, 73)
        Me.fname.Name = "fname"
        Me.fname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fname.PlaceholderText = ""
        Me.fname.SelectedText = ""
        Me.fname.ShadowDecoration.Parent = Me.fname
        Me.fname.Size = New System.Drawing.Size(214, 44)
        Me.fname.TabIndex = 35
        '
        'SiticoneLabel3
        '
        Me.SiticoneLabel3.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel3.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SiticoneLabel3.Location = New System.Drawing.Point(270, 52)
        Me.SiticoneLabel3.Name = "SiticoneLabel3"
        Me.SiticoneLabel3.Size = New System.Drawing.Size(64, 19)
        Me.SiticoneLabel3.TabIndex = 36
        Me.SiticoneLabel3.Text = "Firstname"
        '
        'lname
        '
        Me.lname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lname.BorderRadius = 10
        Me.lname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lname.DefaultText = ""
        Me.lname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lname.DisabledState.Parent = Me.lname
        Me.lname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lname.FocusedState.Parent = Me.lname
        Me.lname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lname.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lname.HoveredState.Parent = Me.lname
        Me.lname.Location = New System.Drawing.Point(270, 164)
        Me.lname.Name = "lname"
        Me.lname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lname.PlaceholderText = ""
        Me.lname.SelectedText = ""
        Me.lname.ShadowDecoration.Parent = Me.lname
        Me.lname.Size = New System.Drawing.Size(214, 44)
        Me.lname.TabIndex = 40
        '
        'SiticoneLabel4
        '
        Me.SiticoneLabel4.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel4.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SiticoneLabel4.Location = New System.Drawing.Point(270, 143)
        Me.SiticoneLabel4.Name = "SiticoneLabel4"
        Me.SiticoneLabel4.Size = New System.Drawing.Size(62, 19)
        Me.SiticoneLabel4.TabIndex = 42
        Me.SiticoneLabel4.Text = "Lastname"
        '
        'mname
        '
        Me.mname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.mname.BorderRadius = 10
        Me.mname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mname.DefaultText = ""
        Me.mname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.mname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.mname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mname.DisabledState.Parent = Me.mname
        Me.mname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mname.FocusedState.Parent = Me.mname
        Me.mname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mname.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mname.HoveredState.Parent = Me.mname
        Me.mname.Location = New System.Drawing.Point(12, 164)
        Me.mname.Name = "mname"
        Me.mname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mname.PlaceholderText = ""
        Me.mname.SelectedText = ""
        Me.mname.ShadowDecoration.Parent = Me.mname
        Me.mname.Size = New System.Drawing.Size(214, 44)
        Me.mname.TabIndex = 39
        '
        'SiticoneLabel5
        '
        Me.SiticoneLabel5.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel5.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SiticoneLabel5.Location = New System.Drawing.Point(12, 143)
        Me.SiticoneLabel5.Name = "SiticoneLabel5"
        Me.SiticoneLabel5.Size = New System.Drawing.Size(166, 19)
        Me.SiticoneLabel5.TabIndex = 41
        Me.SiticoneLabel5.Text = "Middlename (if you have)"
        '
        'SiticoneLabel17
        '
        Me.SiticoneLabel17.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel17.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SiticoneLabel17.Location = New System.Drawing.Point(269, 234)
        Me.SiticoneLabel17.Name = "SiticoneLabel17"
        Me.SiticoneLabel17.Size = New System.Drawing.Size(62, 19)
        Me.SiticoneLabel17.TabIndex = 68
        Me.SiticoneLabel17.Text = "Yearlevel"
        '
        'comboboxyrlevel
        '
        Me.comboboxyrlevel.BackColor = System.Drawing.Color.Transparent
        Me.comboboxyrlevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboboxyrlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxyrlevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboboxyrlevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.comboboxyrlevel.FormattingEnabled = True
        Me.comboboxyrlevel.HoveredState.Parent = Me.comboboxyrlevel
        Me.comboboxyrlevel.ItemHeight = 30
        Me.comboboxyrlevel.ItemsAppearance.Parent = Me.comboboxyrlevel
        Me.comboboxyrlevel.Location = New System.Drawing.Point(269, 259)
        Me.comboboxyrlevel.Name = "comboboxyrlevel"
        Me.comboboxyrlevel.ShadowDecoration.Parent = Me.comboboxyrlevel
        Me.comboboxyrlevel.Size = New System.Drawing.Size(214, 36)
        Me.comboboxyrlevel.TabIndex = 66
        '
        'SiticoneLabel18
        '
        Me.SiticoneLabel18.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel18.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SiticoneLabel18.Location = New System.Drawing.Point(12, 234)
        Me.SiticoneLabel18.Name = "SiticoneLabel18"
        Me.SiticoneLabel18.Size = New System.Drawing.Size(46, 19)
        Me.SiticoneLabel18.TabIndex = 67
        Me.SiticoneLabel18.Text = "Course"
        '
        'comboboxcourse
        '
        Me.comboboxcourse.BackColor = System.Drawing.Color.Transparent
        Me.comboboxcourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboboxcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxcourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboboxcourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.comboboxcourse.FormattingEnabled = True
        Me.comboboxcourse.HoveredState.Parent = Me.comboboxcourse
        Me.comboboxcourse.ItemHeight = 30
        Me.comboboxcourse.ItemsAppearance.Parent = Me.comboboxcourse
        Me.comboboxcourse.Location = New System.Drawing.Point(12, 259)
        Me.comboboxcourse.Name = "comboboxcourse"
        Me.comboboxcourse.ShadowDecoration.Parent = Me.comboboxcourse
        Me.comboboxcourse.Size = New System.Drawing.Size(214, 36)
        Me.comboboxcourse.TabIndex = 65
        '
        'SiticoneLabel16
        '
        Me.SiticoneLabel16.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel16.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SiticoneLabel16.Location = New System.Drawing.Point(12, 317)
        Me.SiticoneLabel16.Name = "SiticoneLabel16"
        Me.SiticoneLabel16.Size = New System.Drawing.Size(49, 19)
        Me.SiticoneLabel16.TabIndex = 70
        Me.SiticoneLabel16.Text = "Section"
        '
        'comboboxsection
        '
        Me.comboboxsection.BackColor = System.Drawing.Color.Transparent
        Me.comboboxsection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboboxsection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxsection.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboboxsection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.comboboxsection.FormattingEnabled = True
        Me.comboboxsection.HoveredState.Parent = Me.comboboxsection
        Me.comboboxsection.ItemHeight = 30
        Me.comboboxsection.Items.AddRange(New Object() {"A", "B"})
        Me.comboboxsection.ItemsAppearance.Parent = Me.comboboxsection
        Me.comboboxsection.Location = New System.Drawing.Point(12, 342)
        Me.comboboxsection.Name = "comboboxsection"
        Me.comboboxsection.ShadowDecoration.Parent = Me.comboboxsection
        Me.comboboxsection.Size = New System.Drawing.Size(214, 36)
        Me.comboboxsection.TabIndex = 69
        '
        'cancelBtn
        '
        Me.cancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelBtn.BorderRadius = 8
        Me.cancelBtn.CheckedState.Parent = Me.cancelBtn
        Me.cancelBtn.CustomImages.Parent = Me.cancelBtn
        Me.cancelBtn.FillColor = System.Drawing.Color.Silver
        Me.cancelBtn.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.Color.White
        Me.cancelBtn.HoveredState.Parent = Me.cancelBtn
        Me.cancelBtn.Location = New System.Drawing.Point(268, 461)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.ShadowDecoration.Parent = Me.cancelBtn
        Me.cancelBtn.Size = New System.Drawing.Size(111, 42)
        Me.cancelBtn.TabIndex = 72
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.TextOffset = New System.Drawing.Point(0, 2)
        '
        'submitBtn
        '
        Me.submitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.submitBtn.BorderRadius = 8
        Me.submitBtn.CheckedState.Parent = Me.submitBtn
        Me.submitBtn.CustomImages.Parent = Me.submitBtn
        Me.submitBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.submitBtn.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitBtn.ForeColor = System.Drawing.Color.White
        Me.submitBtn.HoveredState.Parent = Me.submitBtn
        Me.submitBtn.Location = New System.Drawing.Point(390, 461)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.ShadowDecoration.Parent = Me.submitBtn
        Me.submitBtn.Size = New System.Drawing.Size(111, 42)
        Me.submitBtn.TabIndex = 71
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.TextOffset = New System.Drawing.Point(0, 2)
        '
        'SiticoneLabel6
        '
        Me.SiticoneLabel6.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel6.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SiticoneLabel6.Location = New System.Drawing.Point(268, 317)
        Me.SiticoneLabel6.Name = "SiticoneLabel6"
        Me.SiticoneLabel6.Size = New System.Drawing.Size(35, 19)
        Me.SiticoneLabel6.TabIndex = 74
        Me.SiticoneLabel6.Text = "Type"
        '
        'comboboxtype
        '
        Me.comboboxtype.BackColor = System.Drawing.Color.Transparent
        Me.comboboxtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboboxtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxtype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboboxtype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.comboboxtype.FormattingEnabled = True
        Me.comboboxtype.HoveredState.Parent = Me.comboboxtype
        Me.comboboxtype.ItemHeight = 30
        Me.comboboxtype.Items.AddRange(New Object() {"Old", "New"})
        Me.comboboxtype.ItemsAppearance.Parent = Me.comboboxtype
        Me.comboboxtype.Location = New System.Drawing.Point(268, 342)
        Me.comboboxtype.Name = "comboboxtype"
        Me.comboboxtype.ShadowDecoration.Parent = Me.comboboxtype
        Me.comboboxtype.Size = New System.Drawing.Size(214, 36)
        Me.comboboxtype.TabIndex = 73
        '
        'editStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(513, 515)
        Me.Controls.Add(Me.SiticoneLabel6)
        Me.Controls.Add(Me.comboboxtype)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.submitBtn)
        Me.Controls.Add(Me.SiticoneLabel16)
        Me.Controls.Add(Me.comboboxsection)
        Me.Controls.Add(Me.SiticoneLabel17)
        Me.Controls.Add(Me.comboboxyrlevel)
        Me.Controls.Add(Me.SiticoneLabel18)
        Me.Controls.Add(Me.comboboxcourse)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.SiticoneLabel4)
        Me.Controls.Add(Me.mname)
        Me.Controls.Add(Me.SiticoneLabel5)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.SiticoneLabel3)
        Me.Controls.Add(Me.stdno)
        Me.Controls.Add(Me.SiticoneLabel2)
        Me.Controls.Add(Me.SiticoneLabel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "editStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "editStudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SiticoneLabel1 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents stdno As Siticone.UI.WinForms.SiticoneTextBox
    Friend WithEvents SiticoneLabel2 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents fname As Siticone.UI.WinForms.SiticoneTextBox
    Friend WithEvents SiticoneLabel3 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents lname As Siticone.UI.WinForms.SiticoneTextBox
    Friend WithEvents SiticoneLabel4 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents mname As Siticone.UI.WinForms.SiticoneTextBox
    Friend WithEvents SiticoneLabel5 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents SiticoneLabel17 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents comboboxyrlevel As Siticone.UI.WinForms.SiticoneComboBox
    Friend WithEvents SiticoneLabel18 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents comboboxcourse As Siticone.UI.WinForms.SiticoneComboBox
    Friend WithEvents SiticoneLabel16 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents comboboxsection As Siticone.UI.WinForms.SiticoneComboBox
    Friend WithEvents SiticoneShadowForm1 As Siticone.UI.WinForms.SiticoneShadowForm
    Friend WithEvents cancelBtn As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents submitBtn As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents SiticoneLabel6 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents comboboxtype As Siticone.UI.WinForms.SiticoneComboBox
End Class
