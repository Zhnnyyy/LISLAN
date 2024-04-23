Imports System.Data.SqlClient
Public Class grade_content
    Dim mywidth, myheight As Integer
    Sub New(mwith As Integer, mheight As Integer)
        InitializeComponent()
        mywidth = mwith
        myheight = mheight
    End Sub
    Sub New()
        InitializeComponent()
    End Sub
    Private Sub grade_content_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = mywidth
        Me.Height = myheight
        loadCourses()
        loadYearlevel()
        loadTableStuentGrade()
    End Sub

    Sub loadTableStuentGrade()
        studentGradeTbl.Rows.Clear()
        Using con As New SqlConnection(My.Settings.connection)
            con.Open()
            Using cmd As New SqlCommand()
                cmd.Connection = con
                cmd.CommandText = "select stdno, firstname, middlename, lastname, course.Course, yearlevel.Yearlevel, section from student inner join course on course.id = student.course inner join yearlevel on yearlevel.id = student.yrlevel"
                Using reader As SqlDataReader = cmd.ExecuteReader
                    While reader.Read
                        Dim name As String = reader.Item(3).ToString & ", " & reader.Item(1).ToString & " " & reader.Item(2)
                        studentGradeTbl.Rows.Add(reader.Item(0).ToString, name, reader.Item(4).ToString, reader.Item(5).ToString, reader.Item(6).ToString, "View", "Grades")
                    End While
                End Using
            End Using
            con.Close()
        End Using
    End Sub
    Private Sub loadCourses()
        Using con As New SqlConnection(My.Settings.connection)
            con.Open()
            Using cmd As New SqlCommand("select id, Course from course", con)
                Using reader As SqlDataReader = cmd.ExecuteReader
                    While reader.Read
                        comboboxcourse.Items.Add(New KeyValuePair(Of Integer, String)(reader.Item(0), reader.Item(1)))
                    End While
                    comboboxcourse.DisplayMember = "Value"
                End Using
            End Using
            con.Close()
        End Using
    End Sub

    Private Sub studentGradeTbl_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentGradeTbl.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex = 5 Then
            Dim data As DataGridViewRow = studentGradeTbl.Rows(e.RowIndex)
            Dim stdno As String = data.Cells(0).Value.ToString
            Dim name As String = data.Cells(1).Value.ToString
            Dim course As String = data.Cells(2).Value.ToString
            Dim yrlevel As String = data.Cells(3).Value.ToString
            Dim obj As New viewGrade(stdno, name, course, yrlevel)
            obj.ShowDialog()
        End If

        If e.RowIndex >= 0 And e.ColumnIndex = 6 Then
            Dim data As DataGridViewRow = studentGradeTbl.Rows(e.RowIndex)
            Dim stdno As String = data.Cells(0).Value.ToString
            Dim name As String = data.Cells(1).Value.ToString
            Dim course As String = data.Cells(2).Value.ToString
            Dim yrlevel As String = data.Cells(3).Value.ToString
            Dim obj As New setGrade(stdno, name, course, yrlevel)
            obj.ShowDialog()
        End If
    End Sub

    Private Sub loadYearlevel()
        Using con As New SqlConnection(My.Settings.connection)
            con.Open()
            Using cmd As New SqlCommand("select id, Yearlevel from yearlevel", con)
                Using reader As SqlDataReader = cmd.ExecuteReader
                    While reader.Read
                        comboboxyearlevel.Items.Add(New KeyValuePair(Of Integer, String)(reader.Item(0), reader.Item(1)))
                    End While
                    comboboxyearlevel.DisplayMember = "Value"
                End Using
            End Using
            con.Close()
        End Using
    End Sub
End Class
