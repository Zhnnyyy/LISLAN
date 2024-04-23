<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class details
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SiticoneShadowForm1 = New Siticone.UI.WinForms.SiticoneShadowForm(Me.components)
        Me.documentsTable = New Siticone.UI.WinForms.SiticoneDataGridView()
        Me.closeBtn = New Siticone.UI.WinForms.SiticoneButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.documentsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'documentsTable
        '
        Me.documentsTable.AllowUserToAddRows = False
        Me.documentsTable.AllowUserToDeleteRows = False
        Me.documentsTable.AllowUserToResizeColumns = False
        Me.documentsTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.documentsTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.documentsTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.documentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.documentsTable.BackgroundColor = System.Drawing.Color.White
        Me.documentsTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.documentsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.documentsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.documentsTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.documentsTable.ColumnHeadersHeight = 35
        Me.documentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.documentsTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.documentsTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.documentsTable.EnableHeadersVisualStyles = False
        Me.documentsTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.documentsTable.Location = New System.Drawing.Point(12, 12)
        Me.documentsTable.MultiSelect = False
        Me.documentsTable.Name = "documentsTable"
        Me.documentsTable.ReadOnly = True
        Me.documentsTable.RowHeadersVisible = False
        Me.documentsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.documentsTable.RowTemplate.Height = 30
        Me.documentsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.documentsTable.ShowCellErrors = False
        Me.documentsTable.ShowCellToolTips = False
        Me.documentsTable.ShowEditingIcon = False
        Me.documentsTable.ShowRowErrors = False
        Me.documentsTable.Size = New System.Drawing.Size(407, 164)
        Me.documentsTable.TabIndex = 7
        Me.documentsTable.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Dark
        Me.documentsTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.documentsTable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.documentsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.documentsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.documentsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.documentsTable.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.documentsTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.documentsTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.documentsTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.documentsTable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.documentsTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.documentsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.documentsTable.ThemeStyle.HeaderStyle.Height = 35
        Me.documentsTable.ThemeStyle.ReadOnly = True
        Me.documentsTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.documentsTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.documentsTable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.documentsTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.documentsTable.ThemeStyle.RowsStyle.Height = 30
        Me.documentsTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.documentsTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'closeBtn
        '
        Me.closeBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBtn.BorderRadius = 8
        Me.closeBtn.CheckedState.Parent = Me.closeBtn
        Me.closeBtn.CustomImages.Parent = Me.closeBtn
        Me.closeBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.closeBtn.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.White
        Me.closeBtn.HoveredState.Parent = Me.closeBtn
        Me.closeBtn.Location = New System.Drawing.Point(133, 182)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.ShadowDecoration.Parent = Me.closeBtn
        Me.closeBtn.Size = New System.Drawing.Size(147, 36)
        Me.closeBtn.TabIndex = 8
        Me.closeBtn.Text = "Close"
        Me.closeBtn.TextOffset = New System.Drawing.Point(0, 2)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 20
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "File"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(431, 229)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.documentsTable)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "details"
        CType(Me.documentsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SiticoneShadowForm1 As Siticone.UI.WinForms.SiticoneShadowForm
    Friend WithEvents documentsTable As Siticone.UI.WinForms.SiticoneDataGridView
    Friend WithEvents closeBtn As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
