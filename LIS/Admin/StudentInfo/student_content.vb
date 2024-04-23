Imports System.Data.SqlClient
Public Class student_content
    Dim mywidth, myheight As Integer
    Sub New(mwith As Integer, mheight As Integer)
        InitializeComponent()
        mywidth = mwith
        myheight = mheight
    End Sub

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub addStudentBtn_Click(sender As Object, e As EventArgs) Handles addStudentBtn.Click
        addStudent.ShowDialog()
    End Sub

    Private Sub student_content_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = mywidth
        Me.Height = myheight
        'loadTable()
        studentContent = Me
        loadTableStudentInfo()
    End Sub





    Private Sub searchStudent(data As String)
        studentInformationTbl.Rows.Clear()
        Try
            Using con As New SqlConnection(My.Settings.connection)
                con.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandText = $"select stdno,firstname,middlename,lastname,course.Course,yearlevel.Yearlevel,section,type,date from student inner join course on course.id = student.course inner join yearlevel on yearlevel.id = student.yrlevel where firstname like '{data}' or lastname like '{data}' or course.Course like '{data}' or yearlevel.Yearlevel like '{data}' or type like '{data}'"
                    Using reader As SqlDataReader = cmd.ExecuteReader
                        While reader.Read
                            Dim middlename As String = reader.Item("middlename")
                            Dim mname As String = If(middlename.ToString.Length <> 0, middlename(0) & ".", "")
                            Dim name As String = reader.Item("lastname") & ", " & reader.Item("firstname") & " " & mname
                            studentInformationTbl.Rows.Add(reader.Item("stdno"), name, reader.Item("Course"), reader.Item("Yearlevel"), reader.Item("section"), reader.Item("type"), reader.Item("date"), "UPDATE")
                        End While
                    End Using
                End Using
                con.Close()
            End Using
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub searchBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles searchBox.KeyPress
        Dim searchString As String = "%" & searchBox.Text & "%"
        If searchBox.Text.Length <> 0 Then
            searchStudent(searchString)
        Else
            loadTableStudentInfo()
        End If
    End Sub

    Private Sub studentInformationTbl_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentInformationTbl.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex = 7 Then
            Dim stdno As DataGridViewRow = studentInformationTbl.Rows(e.RowIndex)
            Dim data = stdno.Cells(0).Value.ToString
            Dim obj As New editStudent(data)
            obj.ShowDialog()
        End If
    End Sub


End Class
