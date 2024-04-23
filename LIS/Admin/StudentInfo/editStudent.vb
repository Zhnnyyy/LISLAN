Imports System.Data.SqlClient
Imports System.IO
Public Class editStudent
    Dim UID As String
    Sub New(id As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.UID = id
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub editStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SiticoneShadowForm1.SetShadowForm(Me)
        loadDetails()
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub

    Private Sub loadYrlevel()
        comboboxyrlevel.Items.Clear()
        Try
            Using con As New SqlConnection(My.Settings.connection)
                con.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandText = "select id, Yearlevel from yearlevel"
                    Using reader As SqlDataReader = cmd.ExecuteReader
                        While reader.Read
                            comboboxyrlevel.Items.Add(New KeyValuePair(Of Integer, String)(reader.Item("id"), reader.Item("Yearlevel")))
                        End While
                        comboboxyrlevel.DisplayMember = "Value"
                        comboboxyrlevel.ValueMember = "Key"
                    End Using
                End Using
                con.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loadCourses()
        comboboxcourse.Items.Clear()
        Try
            Using con As New SqlConnection(My.Settings.connection)
                con.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandText = "select id, Course from course"
                    Using reader As SqlDataReader = cmd.ExecuteReader
                        While reader.Read
                            comboboxcourse.Items.Add(New KeyValuePair(Of Integer, String)(reader.Item("id"), reader.Item("Course")))
                        End While
                        comboboxcourse.DisplayMember = "Value"
                        comboboxcourse.ValueMember = "Key"
                    End Using
                End Using
                con.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim studentPath As String
    Sub loadDetails()
        loadCourses()
        loadYrlevel()

        Try
            Using con As New SqlConnection(My.Settings.connection)
                con.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandText = $"select stdno,firstname,middlename,lastname,course.Course,yearlevel.Yearlevel, section, type from student inner join course on course.id = student.course inner join yearlevel on yearlevel.id = student.yrlevel where stdno='{UID}'"
                    Using reader As SqlDataReader = cmd.ExecuteReader
                        While reader.Read
                            Dim middlename As String = If(reader.Item(2).ToString.Length <> 0, " " & reader.Item(2).ToString, "")
                            Dim name As String = reader.Item(3).ToString & ", " & reader.Item(1).ToString & middlename
                            studentPath = "\" & reader.Item(4).ToString & "\" & reader.Item(5).ToString & "\" & reader.Item(6).ToString & "\" & name
                            stdno.Text = reader.Item(0).ToString
                            fname.Text = reader.Item(1).ToString
                            mname.Text = reader.Item(2).ToString
                            lname.Text = reader.Item(3).ToString
                            Dim index As Integer = comboboxcourse.FindStringExact(reader.Item(4).ToString)
                            comboboxcourse.SelectedIndex = index
                            Dim index1 As Integer = comboboxyrlevel.FindStringExact(reader.Item(5).ToString)
                            comboboxyrlevel.SelectedIndex = index1
                            comboboxsection.SelectedItem = reader.Item(6).ToString
                            comboboxtype.SelectedItem = reader.Item(7).ToString
                        End While
                    End Using
                End Using
                con.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub moveStudentFolder()
        Dim rootPath As String = Application.StartupPath & "\LisData\LIS" & studentPath
        If Directory.Exists(rootPath) Then
            Dim middlename As String = If(mname.Text.Length <> 0, " " & mname.Text, "")
            Dim name As String = lname.Text & ", " & fname.Text & middlename & "\"
            Dim newPath As String = comboboxcourse.SelectedItem.Value & "\" & comboboxyrlevel.SelectedItem.Value & "\" & comboboxsection.SelectedItem & "\" & name
            Directory.Move(rootPath, Application.StartupPath & "\LisData\LIS\" & newPath)
        End If
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        If validator(fname) And validator(lname) Then
            Dim res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo)
            If res = DialogResult.Yes Then
                Try
                    updateStudent(New student(stdno.Text, fname.Text, mname.Text, lname.Text, "", comboboxcourse.SelectedItem.Key, comboboxyrlevel.SelectedItem.Key, comboboxsection.SelectedItem, comboboxtype.SelectedItem, ""))
                    moveStudentFolder()
                    loadTableStudentInfo()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MsgBox("Please check your input")
        End If
    End Sub
End Class