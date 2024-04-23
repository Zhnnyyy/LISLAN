<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class requirements_content
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
        Me.openRootBtn = New Siticone.UI.WinForms.SiticoneButton()
        Me.studentReqirementsTbl = New Siticone.UI.WinForms.SiticoneDataGridView()
        Me.searchbox = New Siticone.UI.WinForms.SiticoneTextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.studentReqirementsTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SiticoneLabel1
        '
        Me.SiticoneLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel1.Font = New System.Drawing.Font("Perpetua", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel1.Location = New System.Drawing.Point(15, 14)
        Me.SiticoneLabel1.Name = "SiticoneLabel1"
        Me.SiticoneLabel1.Size = New System.Drawing.Size(147, 30)
        Me.SiticoneLabel1.TabIndex = 1
        Me.SiticoneLabel1.Text = "Requirements"
        '
        'openRootBtn
        '
        Me.openRootBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.openRootBtn.BorderRadius = 8
        Me.openRootBtn.CheckedState.Parent = Me.openRootBtn
        Me.openRootBtn.CustomImages.Parent = Me.openRootBtn
        Me.openRootBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.openRootBtn.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openRootBtn.ForeColor = System.Drawing.Color.White
        Me.openRootBtn.HoveredState.Parent = Me.openRootBtn
        Me.openRootBtn.Location = New System.Drawing.Point(614, 8)
        Me.openRootBtn.Name = "openRootBtn"
        Me.openRootBtn.ShadowDecoration.Parent = Me.openRootBtn
        Me.openRootBtn.Size = New System.Drawing.Size(147, 36)
        Me.openRootBtn.TabIndex = 5
        Me.openRootBtn.Text = "Open root folder"
        Me.openRootBtn.TextOffset = New System.Drawing.Point(0, 2)
        '
        'studentReqirementsTbl
        '
        Me.studentReqirementsTbl.AllowUserToAddRows = False
        Me.studentReqirementsTbl.AllowUserToDeleteRows = False
        Me.studentReqirementsTbl.AllowUserToResizeColumns = False
        Me.studentReqirementsTbl.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.studentReqirementsTbl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.studentReqirementsTbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.studentReqirementsTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.studentReqirementsTbl.BackgroundColor = System.Drawing.Color.White
        Me.studentReqirementsTbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.studentReqirementsTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.studentReqirementsTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentReqirementsTbl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.studentReqirementsTbl.ColumnHeadersHeight = 35
        Me.studentReqirementsTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.studentReqirementsTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Column8, Me.DataGridViewTextBoxColumn5, Me.DataGridViewButtonColumn1, Me.Column1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.studentReqirementsTbl.DefaultCellStyle = DataGridViewCellStyle3
        Me.studentReqirementsTbl.EnableHeadersVisualStyles = False
        Me.studentReqirementsTbl.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.studentReqirementsTbl.Location = New System.Drawing.Point(2, 71)
        Me.studentReqirementsTbl.MultiSelect = False
        Me.studentReqirementsTbl.Name = "studentReqirementsTbl"
        Me.studentReqirementsTbl.ReadOnly = True
        Me.studentReqirementsTbl.RowHeadersVisible = False
        Me.studentReqirementsTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.studentReqirementsTbl.RowTemplate.Height = 30
        Me.studentReqirementsTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.studentReqirementsTbl.ShowCellErrors = False
        Me.studentReqirementsTbl.ShowCellToolTips = False
        Me.studentReqirementsTbl.ShowEditingIcon = False
        Me.studentReqirementsTbl.ShowRowErrors = False
        Me.studentReqirementsTbl.Size = New System.Drawing.Size(979, 535)
        Me.studentReqirementsTbl.TabIndex = 6
        Me.studentReqirementsTbl.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Dark
        Me.studentReqirementsTbl.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.studentReqirementsTbl.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.studentReqirementsTbl.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.studentReqirementsTbl.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.studentReqirementsTbl.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.studentReqirementsTbl.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.studentReqirementsTbl.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.studentReqirementsTbl.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.studentReqirementsTbl.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.studentReqirementsTbl.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentReqirementsTbl.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.studentReqirementsTbl.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.studentReqirementsTbl.ThemeStyle.HeaderStyle.Height = 35
        Me.studentReqirementsTbl.ThemeStyle.ReadOnly = True
        Me.studentReqirementsTbl.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.studentReqirementsTbl.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.studentReqirementsTbl.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.studentReqirementsTbl.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.studentReqirementsTbl.ThemeStyle.RowsStyle.Height = 30
        Me.studentReqirementsTbl.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.studentReqirementsTbl.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'searchbox
        '
        Me.searchbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchbox.DefaultText = ""
        Me.searchbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchbox.DisabledState.Parent = Me.searchbox
        Me.searchbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchbox.FocusedState.Parent = Me.searchbox
        Me.searchbox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchbox.HoveredState.Parent = Me.searchbox
        Me.searchbox.IconLeft = Global.LIS.My.Resources.src.Search
        Me.searchbox.Location = New System.Drawing.Point(781, 8)
        Me.searchbox.Name = "searchbox"
        Me.searchbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchbox.PlaceholderText = "Search"
        Me.searchbox.SelectedText = ""
        Me.searchbox.ShadowDecoration.Parent = Me.searchbox
        Me.searchbox.Size = New System.Drawing.Size(200, 36)
        Me.searchbox.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.HeaderText = "Student No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.HeaderText = "BirthCertificate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.HeaderText = "Form137/138"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column8.HeaderText = "GoodMoral"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.HeaderText = "HonorableDismissal"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewButtonColumn1.HeaderText = ""
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        Me.DataGridViewButtonColumn1.Width = 70
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'requirements_content
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.studentReqirementsTbl)
        Me.Controls.Add(Me.openRootBtn)
        Me.Controls.Add(Me.searchbox)
        Me.Controls.Add(Me.SiticoneLabel1)
        Me.Name = "requirements_content"
        Me.Size = New System.Drawing.Size(984, 609)
        CType(Me.studentReqirementsTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SiticoneLabel1 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents searchbox As Siticone.UI.WinForms.SiticoneTextBox
    Friend WithEvents openRootBtn As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents studentReqirementsTbl As Siticone.UI.WinForms.SiticoneDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
End Class
