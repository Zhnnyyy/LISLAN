<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payment_content
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SiticoneLabel1 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.SiticoneTextBox1 = New Siticone.UI.WinForms.SiticoneTextBox()
        Me.SiticoneDataGridView1 = New Siticone.UI.WinForms.SiticoneDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SiticoneDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SiticoneLabel1
        '
        Me.SiticoneLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel1.Font = New System.Drawing.Font("Perpetua", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel1.Location = New System.Drawing.Point(15, 14)
        Me.SiticoneLabel1.Name = "SiticoneLabel1"
        Me.SiticoneLabel1.Size = New System.Drawing.Size(91, 30)
        Me.SiticoneLabel1.TabIndex = 2
        Me.SiticoneLabel1.Text = "Payment"
        '
        'SiticoneTextBox1
        '
        Me.SiticoneTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SiticoneTextBox1.DefaultText = ""
        Me.SiticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SiticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SiticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SiticoneTextBox1.DisabledState.Parent = Me.SiticoneTextBox1
        Me.SiticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SiticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox1.FocusedState.Parent = Me.SiticoneTextBox1
        Me.SiticoneTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox1.HoveredState.Parent = Me.SiticoneTextBox1
        Me.SiticoneTextBox1.IconLeft = Global.LIS.My.Resources.src.Search
        Me.SiticoneTextBox1.Location = New System.Drawing.Point(781, 14)
        Me.SiticoneTextBox1.Name = "SiticoneTextBox1"
        Me.SiticoneTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SiticoneTextBox1.PlaceholderText = "Search"
        Me.SiticoneTextBox1.SelectedText = ""
        Me.SiticoneTextBox1.ShadowDecoration.Parent = Me.SiticoneTextBox1
        Me.SiticoneTextBox1.Size = New System.Drawing.Size(200, 36)
        Me.SiticoneTextBox1.TabIndex = 4
        '
        'SiticoneDataGridView1
        '
        Me.SiticoneDataGridView1.AllowUserToAddRows = False
        Me.SiticoneDataGridView1.AllowUserToDeleteRows = False
        Me.SiticoneDataGridView1.AllowUserToResizeColumns = False
        Me.SiticoneDataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.SiticoneDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.SiticoneDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SiticoneDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.SiticoneDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SiticoneDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SiticoneDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SiticoneDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.SiticoneDataGridView1.ColumnHeadersHeight = 35
        Me.SiticoneDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.SiticoneDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SiticoneDataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.SiticoneDataGridView1.EnableHeadersVisualStyles = False
        Me.SiticoneDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.SiticoneDataGridView1.Location = New System.Drawing.Point(15, 56)
        Me.SiticoneDataGridView1.Name = "SiticoneDataGridView1"
        Me.SiticoneDataGridView1.ReadOnly = True
        Me.SiticoneDataGridView1.RowHeadersVisible = False
        Me.SiticoneDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SiticoneDataGridView1.ShowCellErrors = False
        Me.SiticoneDataGridView1.ShowCellToolTips = False
        Me.SiticoneDataGridView1.ShowEditingIcon = False
        Me.SiticoneDataGridView1.ShowRowErrors = False
        Me.SiticoneDataGridView1.Size = New System.Drawing.Size(966, 536)
        Me.SiticoneDataGridView1.TabIndex = 5
        Me.SiticoneDataGridView1.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.LightGrid
        Me.SiticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.SiticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.SiticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.SiticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.SiticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.SiticoneDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.SiticoneDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.SiticoneDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.SiticoneDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.SiticoneDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.SiticoneDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.SiticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.SiticoneDataGridView1.ThemeStyle.HeaderStyle.Height = 35
        Me.SiticoneDataGridView1.ThemeStyle.ReadOnly = True
        Me.SiticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.SiticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SiticoneDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.SiticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.SiticoneDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.SiticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.SiticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column1
        '
        Me.Column1.HeaderText = "Student No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Prelim"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Midterm"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Pre-Finals"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Final"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column7
        '
        Me.Column7.HeaderText = "Semester"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Balance"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'payment_content
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.SiticoneDataGridView1)
        Me.Controls.Add(Me.SiticoneTextBox1)
        Me.Controls.Add(Me.SiticoneLabel1)
        Me.Name = "payment_content"
        Me.Size = New System.Drawing.Size(995, 606)
        CType(Me.SiticoneDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SiticoneLabel1 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents SiticoneTextBox1 As Siticone.UI.WinForms.SiticoneTextBox
    Friend WithEvents SiticoneDataGridView1 As Siticone.UI.WinForms.SiticoneDataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
