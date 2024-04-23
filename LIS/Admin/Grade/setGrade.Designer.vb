<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class setGrade
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
        Me.SiticoneLabel8 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.stdno_lbl = New Siticone.UI.WinForms.SiticoneLabel()
        Me.name_lbl = New Siticone.UI.WinForms.SiticoneLabel()
        Me.SiticoneLabel3 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.SiticoneLabel1 = New Siticone.UI.WinForms.SiticoneLabel()
        Me.comboboxsemester = New Siticone.UI.WinForms.SiticoneComboBox()
        Me.subjectBox = New System.Windows.Forms.FlowLayoutPanel()
        Me.submitBtn = New Siticone.UI.WinForms.SiticoneButton()
        Me.SuspendLayout()
        '
        'SiticoneLabel8
        '
        Me.SiticoneLabel8.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel8.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel8.ForeColor = System.Drawing.Color.Gray
        Me.SiticoneLabel8.Location = New System.Drawing.Point(12, 12)
        Me.SiticoneLabel8.Name = "SiticoneLabel8"
        Me.SiticoneLabel8.Size = New System.Drawing.Size(77, 19)
        Me.SiticoneLabel8.TabIndex = 48
        Me.SiticoneLabel8.Text = "Student No."
        '
        'stdno_lbl
        '
        Me.stdno_lbl.BackColor = System.Drawing.Color.Transparent
        Me.stdno_lbl.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdno_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.stdno_lbl.Location = New System.Drawing.Point(95, 12)
        Me.stdno_lbl.Name = "stdno_lbl"
        Me.stdno_lbl.Size = New System.Drawing.Size(43, 19)
        Me.stdno_lbl.TabIndex = 49
        Me.stdno_lbl.Text = "####"
        '
        'name_lbl
        '
        Me.name_lbl.BackColor = System.Drawing.Color.Transparent
        Me.name_lbl.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.name_lbl.Location = New System.Drawing.Point(61, 37)
        Me.name_lbl.Name = "name_lbl"
        Me.name_lbl.Size = New System.Drawing.Size(43, 19)
        Me.name_lbl.TabIndex = 51
        Me.name_lbl.Text = "####"
        '
        'SiticoneLabel3
        '
        Me.SiticoneLabel3.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel3.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel3.ForeColor = System.Drawing.Color.Gray
        Me.SiticoneLabel3.Location = New System.Drawing.Point(12, 37)
        Me.SiticoneLabel3.Name = "SiticoneLabel3"
        Me.SiticoneLabel3.Size = New System.Drawing.Size(43, 19)
        Me.SiticoneLabel3.TabIndex = 50
        Me.SiticoneLabel3.Text = "Name:"
        '
        'SiticoneLabel1
        '
        Me.SiticoneLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel1.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel1.ForeColor = System.Drawing.Color.Gray
        Me.SiticoneLabel1.Location = New System.Drawing.Point(12, 62)
        Me.SiticoneLabel1.Name = "SiticoneLabel1"
        Me.SiticoneLabel1.Size = New System.Drawing.Size(59, 19)
        Me.SiticoneLabel1.TabIndex = 53
        Me.SiticoneLabel1.Text = "Semester"
        '
        'comboboxsemester
        '
        Me.comboboxsemester.BackColor = System.Drawing.Color.Transparent
        Me.comboboxsemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboboxsemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxsemester.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboboxsemester.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.comboboxsemester.FormattingEnabled = True
        Me.comboboxsemester.HoveredState.Parent = Me.comboboxsemester
        Me.comboboxsemester.ItemHeight = 30
        Me.comboboxsemester.Items.AddRange(New Object() {"1", "2"})
        Me.comboboxsemester.ItemsAppearance.Parent = Me.comboboxsemester
        Me.comboboxsemester.Location = New System.Drawing.Point(12, 87)
        Me.comboboxsemester.Name = "comboboxsemester"
        Me.comboboxsemester.ShadowDecoration.Parent = Me.comboboxsemester
        Me.comboboxsemester.Size = New System.Drawing.Size(214, 36)
        Me.comboboxsemester.TabIndex = 52
        '
        'subjectBox
        '
        Me.subjectBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.subjectBox.Location = New System.Drawing.Point(12, 129)
        Me.subjectBox.Name = "subjectBox"
        Me.subjectBox.Size = New System.Drawing.Size(588, 423)
        Me.subjectBox.TabIndex = 54
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
        Me.submitBtn.Location = New System.Drawing.Point(489, 569)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.ShadowDecoration.Parent = Me.submitBtn
        Me.submitBtn.Size = New System.Drawing.Size(111, 42)
        Me.submitBtn.TabIndex = 55
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.TextOffset = New System.Drawing.Point(0, 2)
        '
        'setGrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(616, 623)
        Me.Controls.Add(Me.submitBtn)
        Me.Controls.Add(Me.subjectBox)
        Me.Controls.Add(Me.SiticoneLabel1)
        Me.Controls.Add(Me.comboboxsemester)
        Me.Controls.Add(Me.name_lbl)
        Me.Controls.Add(Me.SiticoneLabel3)
        Me.Controls.Add(Me.stdno_lbl)
        Me.Controls.Add(Me.SiticoneLabel8)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(632, 662)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(632, 662)
        Me.name = "setGrade"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SiticoneLabel8 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents stdno_lbl As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents name_lbl As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents SiticoneLabel3 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents SiticoneLabel1 As Siticone.UI.WinForms.SiticoneLabel
    Friend WithEvents comboboxsemester As Siticone.UI.WinForms.SiticoneComboBox
    Friend WithEvents subjectBox As FlowLayoutPanel
    Friend WithEvents submitBtn As Siticone.UI.WinForms.SiticoneButton
End Class
