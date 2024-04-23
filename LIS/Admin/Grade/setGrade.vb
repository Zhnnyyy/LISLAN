Imports System.Data.SqlClient
Public Class setGrade
    Dim stdno, name, course, yrlevel As String
    Sub New(stdno As String, name As String, course As String, yrlevel As String)
        InitializeComponent()
        Me.stdno = stdno
        Me.name = name
        Me.course = course
        Me.yrlevel = yrlevel
    End Sub

    Private Sub comboboxsemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxsemester.SelectedIndexChanged
        loadsubjects()
    End Sub

    Private Sub setGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stdno_lbl.Text = stdno
        name_lbl.Text = name
        comboboxsemester.SelectedIndex = 0
        loadsubjects()
    End Sub

    Sub loadsubjects()
        subjectBox.Controls.Clear()
        Using con As New SqlConnection(My.Settings.connection)
            con.Open()
            Using cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandText = $"select subjects.id, code, subject from subjects inner join course on course.id = subjects.course inner join yearlevel on yearlevel.id = subjects.yearlevel where course.Course = '{course}' and yearlevel.Yearlevel = '{yrlevel}' and semester = '{comboboxsemester.SelectedItem}'"
                Using reader As SqlDataReader = cmd.ExecuteReader
                    While reader.Read
                        subjectBox.Controls.Add(New subject(reader.Item(1).ToString, reader.Item(2).ToString, reader.Item(0).ToString, ""))
                    End While
                End Using
            End Using
            con.Close()
        End Using
    End Sub
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim subjectid As New ArrayList()
        Dim grade As New ArrayList()
        If gradeValidation() Then
            If textValidator() Then
                For Each ctrl As Control In subjectBox.Controls
                    If TypeOf ctrl Is subject Then
                        Dim obj As subject = DirectCast(ctrl, subject)
                        subjectid.Add(obj.Tag)
                        For Each subctrl As Control In obj.Controls
                            If TypeOf subctrl Is TextBox AndAlso subctrl.Tag = "gradetag" Then
                                Dim value As Decimal = Convert.ToDecimal(subctrl.Text)
                                grade.Add(value)
                            End If
                        Next
                    End If
                Next
                For i As Integer = 0 To subjectid.Count - 1 Step 1
                    markGrades(New grades(stdno, subjectid.Item(i), grade.Item(i)))

                Next
                MsgBox("Grade has been added")
                loadsubjects()
            Else
                MsgBox("All fields are required")
            End If
        Else
            MsgBox("Student has already been graded in this semester")
        End If
    End Sub

    Function textValidator() As Boolean
        For Each ctrl As Control In subjectBox.Controls
            If TypeOf ctrl Is subject Then
                Dim obj As subject = DirectCast(ctrl, subject)
                For Each subctrl As Control In obj.Controls
                    If TypeOf subctrl Is TextBox Then
                        If subctrl.Text.Length = 0 Then
                            Return False
                        End If
                    End If
                Next
            End If
        Next
        Return True
    End Function
    Function gradeValidation() As Boolean
        Using con As New SqlConnection(My.Settings.connection)
            con.Open()
            Using cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandText = $"select count(*) from grades inner join subjects on subjects.id = grades.subjectid where grades.studentid= '{stdno}' and subjects.semester = '{comboboxsemester.SelectedItem}'"
                Dim result = cmd.ExecuteScalar
                If result <> 0 Then
                    Return False
                End If
            End Using
            con.Close()
        End Using
        Return True
    End Function
End Class