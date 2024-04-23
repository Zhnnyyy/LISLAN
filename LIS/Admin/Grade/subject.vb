Public Class subject
    Dim code, name, subjectid, grade As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Not IsNumeric(TextBox1.Text) AndAlso TextBox1.Text.Length > 0 Then
            TextBox1.Clear()

        End If
    End Sub

    Sub New(code As String, name As String, id As String, grade As String)
        InitializeComponent()
        Me.code = code
        Me.name = name
        Me.subjectid = id
        Me.grade = grade
    End Sub
    Private Sub subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        codelbl.Text = code
        namelbl.Text = name
        TextBox1.Text = grade
        Me.Tag = subjectid

        If TextBox1.Text.Length <> 0 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Enabled = False
                End If
            Next
        End If
    End Sub
End Class
