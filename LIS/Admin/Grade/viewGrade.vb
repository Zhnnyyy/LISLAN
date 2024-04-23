Imports System.Data.SqlClient
Public Class viewGrade
    Dim stdno, name, course, yrlevel As String

    Private Sub comboboxsemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxsemester.SelectedIndexChanged
        loadsubjects()
        CheckBox1.Checked = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        For Each ctrl As Control In subjectBox.Controls
            If TypeOf ctrl Is subject Then
                Dim obj As subject = DirectCast(ctrl, subject)
                For Each subctrl As Control In obj.Controls
                    If TypeOf subctrl Is TextBox AndAlso subctrl.Tag = "gradetag" Then
                        If CheckBox1.Checked Then
                            subctrl.Enabled = True
                            submitBtn.Visible = True
                        Else
                            subctrl.Enabled = False
                            submitBtn.Visible = False
                        End If
                    End If
                Next
            End If
        Next

    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim gradeIDList As New ArrayList()
        Dim gradeList As New ArrayList()
        If textValidator() Then
            For Each ctrl As Control In subjectBox.Controls
                If TypeOf ctrl Is subject Then
                    gradeIDList.Add(ctrl.Tag)
                    Dim obj As subject = DirectCast(ctrl, subject)
                    For Each subctrl As Control In obj.Controls
                        If TypeOf subctrl Is TextBox AndAlso subctrl.Tag = "gradetag" Then
                            gradeList.Add(Convert.ToDecimal(subctrl.Text))
                        End If
                    Next
                End If
            Next
            For i As Integer = 0 To gradeIDList.Count - 1
                updateGrade(gradeIDList.Item(i), gradeList.Item(i))
            Next
            MsgBox("Grade has been updated")
            CheckBox1.Checked = False
            loadsubjects()
        Else
            MsgBox("All fields are required")
        End If
    End Sub

    Sub updateGrade(id As String, grade As Decimal)
        Using con As New SqlConnection(My.Settings.connection)
            con.Open()
            Using cmd As New SqlCommand()
                cmd.Connection = con
                cmd.CommandText = $"update grades set grade= '{grade}' where id= '{id}'"
                cmd.ExecuteNonQuery()
            End Using
            con.Close()
        End Using
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
    Sub New(stdno As String, name As String, course As String, yrlevel As String)
        InitializeComponent()
        Me.stdno = stdno
        Me.name = name
        Me.course = course
        Me.yrlevel = yrlevel
    End Sub
    Private Sub viewGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stdno_lbl.Text = stdno
        name_lbl.Text = name
        comboboxsemester.SelectedIndex = 0
        submitBtn.Visible = False
        loadsubjects()
    End Sub
    Sub loadsubjects()
        subjectBox.Controls.Clear()
        Using con As New SqlConnection(My.Settings.connection)
            con.Open()
            Using cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandText = $"select subjects.code, subjects.subject, grades.id, grade from grades inner join subjects on subjects.id = grades.subjectid where grades.studentid='{stdno}' and  subjects.semester = '{comboboxsemester.SelectedItem}'"
                Using reader As SqlDataReader = cmd.ExecuteReader
                    While reader.Read
                        subjectBox.Controls.Add(New subject(reader.Item(0).ToString, reader.Item(1).ToString, reader.Item(2).ToString, reader.Item(3).ToString))
                    End While
                End Using
            End Using
            con.Close()
        End Using
    End Sub
End Class