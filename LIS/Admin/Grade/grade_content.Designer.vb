<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class grade_content
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SiticoneLabel1 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SiticoneLabel8 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.comboboxcourse = New Siticone.UI.WinForms.SiticoneComboBox()
        Me.SiticoneLabel2 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.comboboxyearlevel = New Siticone.UI.WinForms.SiticoneComboBox()
        Me.SiticoneLabel3 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.comboboxsection = New Siticone.UI.WinForms.SiticoneComboBox()
        Me.studentGradeTbl = New Siticone.UI.WinForms.SiticoneDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.studentGradeTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SiticoneLabel1
        '
        Me.SiticoneLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel1.Font = New System.Drawing.Font("Perpetua", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel1.Location = New System.Drawing.Point(15, 14)
        Me.SiticoneLabel1.Name = "SiticoneLabel1"
        Me.SiticoneLabel1.Size = New System.Drawing.Size(74, 30)
        Me.SiticoneLabel1.TabIndex = 3
        Me.SiticoneLabel1.Text = "Grades"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.SiticoneLabel3)
        Me.GroupBox1.Controls.Add(Me.comboboxsection)
        Me.GroupBox1.Controls.Add(Me.SiticoneLabel2)
        Me.GroupBox1.Controls.Add(Me.comboboxyearlevel)
        Me.GroupBox1.Controls.Add(Me.SiticoneLabel8)
        Me.GroupBox1.Controls.Add(Me.comboboxcourse)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1023, 99)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Table Filer"
        '
        'SiticoneLabel8
        '
        Me.SiticoneLabel8.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel8.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SiticoneLabel8.Location = New System.Drawing.Point(28, 28)
        Me.SiticoneLabel8.Name = "SiticoneLabel8"
        Me.SiticoneLabel8.Size = New System.Drawing.Size(46, 19)
        Me.SiticoneLabel8.TabIndex = 47
        Me.SiticoneLabel8.Text = "Course"
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
        Me.comboboxcourse.Location = New System.Drawing.Point(28, 53)
        Me.comboboxcourse.Name = "comboboxcourse"
        Me.comboboxcourse.ShadowDecoration.Parent = Me.comboboxcourse
        Me.comboboxcourse.Size = New System.Drawing.Size(214, 36)
        Me.comboboxcourse.TabIndex = 46
        '
        'SiticoneLabel2
        '
        Me.SiticoneLabel2.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel2.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SiticoneLabel2.Location = New System.Drawing.Point(264, 28)
        Me.SiticoneLabel2.Name = "SiticoneLabel2"
        Me.SiticoneLabel2.Size = New System.Drawing.Size(62, 19)
        Me.SiticoneLabel2.TabIndex = 49
        Me.SiticoneLabel2.Text = "Yearlevel"
        '
        'comboboxyearlevel
        '
        Me.comboboxyearlevel.BackColor = System.Drawing.Color.Transparent
        Me.comboboxyearlevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboboxyearlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxyearlevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboboxyearlevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.comboboxyearlevel.FormattingEnabled = True
        Me.comboboxyearlevel.HoveredState.Parent = Me.comboboxyearlevel
        Me.comboboxyearlevel.ItemHeight = 30
        Me.comboboxyearlevel.ItemsAppearance.Parent = Me.comboboxyearlevel
        Me.comboboxyearlevel.Location = New System.Drawing.Point(264, 53)
        Me.comboboxyearlevel.Name = "comboboxyearlevel"
        Me.comboboxyearlevel.ShadowDecoration.Parent = Me.comboboxyearlevel
        Me.comboboxyearlevel.Size = New System.Drawing.Size(214, 36)
        Me.comboboxyearlevel.TabIndex = 48
        '
        'SiticoneLabel3
        '
        Me.SiticoneLabel3.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel3.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SiticoneLabel3.Location = New System.Drawing.Point(501, 28)
        Me.SiticoneLabel3.Name = "SiticoneLabel3"
        Me.SiticoneLabel3.Size = New System.Drawing.Size(49, 19)
        Me.SiticoneLabel3.TabIndex = 51
        Me.SiticoneLabel3.Text = "Section"
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
        Me.comboboxsection.Location = New System.Drawing.Point(501, 53)
        Me.comboboxsection.Name = "comboboxsection"
        Me.comboboxsection.ShadowDecoration.Parent = Me.comboboxsection
        Me.comboboxsection.Size = New System.Drawing.Size(214, 36)
        Me.comboboxsection.TabIndex = 50
        '
        'studentGradeTbl
        '
        Me.studentGradeTbl.AllowUserToAddRows = False
        Me.studentGradeTbl.AllowUserToDeleteRows = False
        Me.studentGradeTbl.AllowUserToResizeColumns = False
        Me.studentGradeTbl.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.studentGradeTbl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.studentGradeTbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.studentGradeTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.studentGradeTbl.BackgroundColor = System.Drawing.Color.White
        Me.studentGradeTbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.studentGradeTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.studentGradeTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentGradeTbl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.studentGradeTbl.ColumnHeadersHeight = 35
        Me.studentGradeTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.studentGradeTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column8, Me.Column6, Me.Column5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.studentGradeTbl.DefaultCellStyle = DataGridViewCellStyle3
        Me.studentGradeTbl.EnableHeadersVisualStyles = False
        Me.studentGradeTbl.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.studentGradeTbl.Location = New System.Drawing.Point(15, 155)
        Me.studentGradeTbl.MultiSelect = False
        Me.studentGradeTbl.Name = "studentGradeTbl"
        Me.studentGradeTbl.ReadOnly = True
        Me.studentGradeTbl.RowHeadersVisible = False
        Me.studentGradeTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.studentGradeTbl.RowTemplate.Height = 30
        Me.studentGradeTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.studentGradeTbl.ShowCellErrors = False
        Me.studentGradeTbl.ShowCellToolTips = False
        Me.studentGradeTbl.ShowEditingIcon = False
        Me.studentGradeTbl.ShowRowErrors = False
        Me.studentGradeTbl.Size = New System.Drawing.Size(1023, 493)
        Me.studentGradeTbl.TabIndex = 5
        Me.studentGradeTbl.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Dark
        Me.studentGradeTbl.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.studentGradeTbl.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.studentGradeTbl.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.studentGradeTbl.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.studentGradeTbl.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.studentGradeTbl.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.studentGradeTbl.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.studentGradeTbl.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.studentGradeTbl.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.studentGradeTbl.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentGradeTbl.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.studentGradeTbl.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.studentGradeTbl.ThemeStyle.HeaderStyle.Height = 35
        Me.studentGradeTbl.ThemeStyle.ReadOnly = True
        Me.studentGradeTbl.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.studentGradeTbl.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.studentGradeTbl.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.studentGradeTbl.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.studentGradeTbl.ThemeStyle.RowsStyle.Height = 30
        Me.studentGradeTbl.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.studentGradeTbl.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "Student No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.HeaderText = "Course"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.HeaderText = "Yearlevel"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column8.HeaderText = "Section"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 70
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column6.HeaderText = ""
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 70
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 70
        '
        'grade_content
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.studentGradeTbl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SiticoneLabel1)
        Me.Name = "grade_content"
        Me.Size = New System.Drawing.Size(1051, 651)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.studentGradeTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SiticoneLabel1 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SiticoneLabel3 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents comboboxsection As Siticone.UI.WinForms.SiticoneComboBox
    Friend WithEvents SiticoneLabel2 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents comboboxyearlevel As Siticone.UI.WinForms.SiticoneComboBox
    Friend WithEvents SiticoneLabel8 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents comboboxcourse As Siticone.UI.WinForms.SiticoneComboBox
    Friend WithEvents studentGradeTbl As Siticone.UI.WinForms.SiticoneDataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewButtonColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
End Class
