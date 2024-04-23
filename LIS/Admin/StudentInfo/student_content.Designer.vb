<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_content
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
        Me.addStudentBtn = New Siticone.UI.WinForms.SiticoneButton()
        Me.searchBox = New Siticone.UI.WinForms.SiticoneTextBox()
        Me.studentInformationTbl = New Siticone.UI.WinForms.SiticoneDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.studentInformationTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SiticoneLabel1
        '
        Me.SiticoneLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel1.Font = New System.Drawing.Font("Perpetua", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel1.Location = New System.Drawing.Point(15, 14)
        Me.SiticoneLabel1.Name = "SiticoneLabel1"
        Me.SiticoneLabel1.Size = New System.Drawing.Size(214, 30)
        Me.SiticoneLabel1.TabIndex = 0
        Me.SiticoneLabel1.Text = "Student Information"
        '
        'addStudentBtn
        '
        Me.addStudentBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addStudentBtn.BorderRadius = 8
        Me.addStudentBtn.CheckedState.Parent = Me.addStudentBtn
        Me.addStudentBtn.CustomImages.Parent = Me.addStudentBtn
        Me.addStudentBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.addStudentBtn.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addStudentBtn.ForeColor = System.Drawing.Color.White
        Me.addStudentBtn.HoveredState.Parent = Me.addStudentBtn
        Me.addStudentBtn.Location = New System.Drawing.Point(668, 14)
        Me.addStudentBtn.Name = "addStudentBtn"
        Me.addStudentBtn.ShadowDecoration.Parent = Me.addStudentBtn
        Me.addStudentBtn.Size = New System.Drawing.Size(111, 36)
        Me.addStudentBtn.TabIndex = 1
        Me.addStudentBtn.Text = "Add Student"
        Me.addStudentBtn.TextOffset = New System.Drawing.Point(0, 2)
        '
        'searchBox
        '
        Me.searchBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchBox.DefaultText = ""
        Me.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchBox.DisabledState.Parent = Me.searchBox
        Me.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchBox.FocusedState.Parent = Me.searchBox
        Me.searchBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchBox.HoveredState.Parent = Me.searchBox
        Me.searchBox.IconLeft = Global.LIS.My.Resources.src.Search
        Me.searchBox.Location = New System.Drawing.Point(794, 14)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchBox.PlaceholderText = "Search"
        Me.searchBox.SelectedText = ""
        Me.searchBox.ShadowDecoration.Parent = Me.searchBox
        Me.searchBox.Size = New System.Drawing.Size(200, 36)
        Me.searchBox.TabIndex = 2
        '
        'studentInformationTbl
        '
        Me.studentInformationTbl.AllowUserToAddRows = False
        Me.studentInformationTbl.AllowUserToDeleteRows = False
        Me.studentInformationTbl.AllowUserToResizeColumns = False
        Me.studentInformationTbl.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.studentInformationTbl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.studentInformationTbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.studentInformationTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.studentInformationTbl.BackgroundColor = System.Drawing.Color.White
        Me.studentInformationTbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.studentInformationTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.studentInformationTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentInformationTbl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.studentInformationTbl.ColumnHeadersHeight = 35
        Me.studentInformationTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.studentInformationTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column8, Me.Column5, Me.Column9, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.studentInformationTbl.DefaultCellStyle = DataGridViewCellStyle3
        Me.studentInformationTbl.EnableHeadersVisualStyles = False
        Me.studentInformationTbl.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.studentInformationTbl.Location = New System.Drawing.Point(15, 81)
        Me.studentInformationTbl.MultiSelect = False
        Me.studentInformationTbl.Name = "studentInformationTbl"
        Me.studentInformationTbl.ReadOnly = True
        Me.studentInformationTbl.RowHeadersVisible = False
        Me.studentInformationTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.studentInformationTbl.RowTemplate.Height = 30
        Me.studentInformationTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.studentInformationTbl.ShowCellErrors = False
        Me.studentInformationTbl.ShowCellToolTips = False
        Me.studentInformationTbl.ShowEditingIcon = False
        Me.studentInformationTbl.ShowRowErrors = False
        Me.studentInformationTbl.Size = New System.Drawing.Size(979, 535)
        Me.studentInformationTbl.TabIndex = 3
        Me.studentInformationTbl.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Dark
        Me.studentInformationTbl.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.studentInformationTbl.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.studentInformationTbl.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.studentInformationTbl.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.studentInformationTbl.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.studentInformationTbl.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.studentInformationTbl.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.studentInformationTbl.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.studentInformationTbl.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.studentInformationTbl.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentInformationTbl.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.studentInformationTbl.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.studentInformationTbl.ThemeStyle.HeaderStyle.Height = 35
        Me.studentInformationTbl.ThemeStyle.ReadOnly = True
        Me.studentInformationTbl.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.studentInformationTbl.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.studentInformationTbl.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.studentInformationTbl.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.studentInformationTbl.ThemeStyle.RowsStyle.Height = 30
        Me.studentInformationTbl.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.studentInformationTbl.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
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
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column5.HeaderText = "Type"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 50
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column9.HeaderText = "Date Enrolled"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 120
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column6.HeaderText = ""
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 70
        '
        'student_content
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.studentInformationTbl)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.addStudentBtn)
        Me.Controls.Add(Me.SiticoneLabel1)
        Me.Name = "student_content"
        Me.Size = New System.Drawing.Size(1013, 633)
        CType(Me.studentInformationTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SiticoneLabel1 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents addStudentBtn As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents searchBox As Siticone.UI.WinForms.SiticoneTextBox
    Friend WithEvents studentInformationTbl As Siticone.UI.WinForms.SiticoneDataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewButtonColumn
End Class
