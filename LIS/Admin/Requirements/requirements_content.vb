Imports System.Data.SqlClient
Public Class requirements_content
    Dim mywidth, myheight As Integer
    Sub New(mwith As Integer, mheight As Integer)
        InitializeComponent()
        mywidth = mwith
        myheight = mheight
    End Sub
    Sub New()
        InitializeComponent()
    End Sub

    Private Sub openRootBtn_Click(sender As Object, e As EventArgs) Handles openRootBtn.Click
        root.ShowDialog()
    End Sub

    Private Sub requirements_content_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        requirementContent = Me
        Me.Width = mywidth
        Me.Height = myheight
        loadTableStudentRequirement()

    End Sub




    Private Sub searchStudent(data As String)
        studentReqirementsTbl.Rows.Clear()
        Try
            Using con As New SqlConnection(My.Settings.connection)
                con.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandText = $"select stdno, concat(lastname,', ',firstname,' ',middlename) as name from student where stdno like '{data}' or firstname like '{data}' or middlename like '{data}' or lastname like '{data}'"
                    Using reader As SqlDataReader = cmd.ExecuteReader
                        While reader.Read
                            studentReqirementsTbl.Rows.Add(reader.Item("stdno"), reader.Item("name"), isSubmitted(reader.Item("stdno"), "BirthCertificate"), isSubmitted(reader.Item("stdno"), "Card"), isSubmitted(reader.Item("stdno"), "GoodMoral"), isSubmitted(reader.Item("stdno"), "HonorableDismissal"), "Details", "Upload")
                        End While
                    End Using
                End Using
                con.Close()
            End Using
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub studentReqirementsTbl_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentReqirementsTbl.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex = 6 Then
            Dim data As DataGridViewRow = studentReqirementsTbl.Rows(e.RowIndex)
            Dim stdno As String = data.Cells(0).Value.ToString
            Dim obj As New details(searchbox.Location.X + 100, searchbox.Location.Y + 100, stdno)
            obj.ShowDialog()
        End If
    End Sub

    Private Sub searchbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles searchbox.KeyPress
        Dim searchString As String = "%" & searchbox.Text & "%"
        If searchbox.Text.Length <> 0 Then
            searchStudent(searchString)
        End If
    End Sub


End Class
