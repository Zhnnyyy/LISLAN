<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class root
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(root))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.backBtn = New Siticone.UI.WinForms.SiticonePictureBox()
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder_48px.png")
        Me.ImageList1.Images.SetKeyName(1, "document_48px.png")
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(12, 51)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1062, 496)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'backBtn
        '
        Me.backBtn.Image = Global.LIS.My.Resources.src.back
        Me.backBtn.Location = New System.Drawing.Point(12, 0)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.ShadowDecoration.Parent = Me.backBtn
        Me.backBtn.Size = New System.Drawing.Size(38, 45)
        Me.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.backBtn.TabIndex = 10
        Me.backBtn.TabStop = False
        '
        'root
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1086, 559)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.ListView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "root"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "root"
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ListView1 As ListView
    Friend WithEvents backBtn As Siticone.UI.WinForms.SiticonePictureBox
End Class
