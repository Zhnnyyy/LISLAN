Imports System.Data.SqlClient
Module main
    Public Property studentContent As New student_content()
    Public Property requirementContent As New requirements_content()
    Sub addStudents(st As student)
        Using con As New SqlConnection(My.Settings.connection)
            con.Open()
            Using transaction As SqlTransaction = con.BeginTransaction
                Try
                    Using cmd As New SqlCommand
                        cmd.Connection = con
                        cmd.Transaction = transaction

                        'Student
                        cmd.CommandText = $"insert into student(stdno,firstname,middlename,lastname,address,course,yrlevel,section,type,date) values('{st.Stdno1}','{st.Fname1}','{st.Mname1}','{st.Lname1}','{st.Address1}','{st.Course1}','{st.Yrlevel1}','{st.Section1}','{st.StudentType1}','{st.DateEnrolled1}')"
                        cmd.ExecuteNonQuery()
                        transaction.Commit()
                        MsgBox("Student has been added")
                    End Using
                Catch ex As Exception
                    transaction.Rollback()
                    MsgBox(ex.Message)
                End Try
            End Using
            con.Close()
        End Using
    End Sub

    Sub addDocument(dc As document)
        Using con As New SqlConnection(My.Settings.connection)
            con.Open()
            Using transaction As SqlTransaction = con.BeginTransaction
                Try
                    Dim query As String = "INSERT INTO documents (stdno, filename, filedata, type, date) VALUES (@Stdno, @Filename, @Filedata, @Type, @date)"
                    Using cmd As New SqlCommand(query, con, transaction)
                        cmd.Parameters.AddWithValue("@Stdno", dc.Stdno1)
                        cmd.Parameters.AddWithValue("@Filename", dc.Filename1)
                        cmd.Parameters.AddWithValue("@Filedata", dc.Filedata1)
                        cmd.Parameters.AddWithValue("@Type", dc.Filetype1)
                        cmd.Parameters.AddWithValue("@date", dc.SubmittedDate1)
                        cmd.ExecuteNonQuery()
                    End Using
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                    MsgBox(ex.Message)
                End Try
            End Using
            con.Close()
        End Using
    End Sub

    Sub updateStudent(st As student)
        Using con As New SqlConnection(My.Settings.connection)
            con.Open()
            Using transaction As SqlTransaction = con.BeginTransaction
                Try
                    Using cmd As New SqlCommand
                        cmd.Connection = con
                        cmd.Transaction = transaction
                        cmd.CommandText = $"update student set firstname='{st.Fname1}', middlename='{st.Mname1}',lastname='{st.Lname1}',course='{st.Course1}',yrlevel='{st.Yrlevel1}',section='{st.Section1}',type='{st.StudentType1}' where stdno='{st.Stdno1}'"
                        cmd.ExecuteNonQuery()
                    End Using
                    transaction.Commit()
                    MsgBox("Student has been updated")
                Catch ex As Exception
                    transaction.Rollback()
                    MsgBox(ex.Message)
                End Try
            End Using
            con.Close()
        End Using
    End Sub


    Function validator(target As Siticone.UI.WinForms.SiticoneTextBox) As Boolean
        If target.Text.Length <= 1 Then
            Return False
        End If
        Return True
    End Function

    Sub loadTableStudentInfo()
        studentContent.studentInformationTbl.Rows.Clear()
        Try
            Using con As New SqlConnection(My.Settings.connection)
                con.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandText = "select stdno,firstname,middlename,lastname,course.Course,yearlevel.Yearlevel,section,type,date from student inner join course on course.id = student.course inner join yearlevel on yearlevel.id = student.yrlevel order by stdno asc"
                    Using reader As SqlDataReader = cmd.ExecuteReader
                        While reader.Read
                            Dim middlename As String = reader.Item("middlename")

                            Dim mname As String = If(middlename.ToString.Length <> 0, middlename(0) & ".", "")
                            Dim name As String = reader.Item("lastname") & ", " & reader.Item("firstname") & " " & mname
                            studentContent.studentInformationTbl.Rows.Add(reader.Item("stdno"), name, reader.Item("Course"), reader.Item("Yearlevel"), reader.Item("section"), reader.Item("type"), reader.Item("date"), "UPDATE")
                        End While
                    End Using
                End Using
                con.Close()
            End Using
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Function isSubmitted(id As String, target As String) As String
        Dim data As String = ""
        Try
            Using con As New SqlConnection(My.Settings.connection)
                con.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandText = $"select count(*) from documents where stdno='{id}' and type='{target}'"
                    data = cmd.ExecuteScalar
                End Using
                con.Close()
                If data <> 0 Then
                    Return "Submitted"
                End If
                If data = 0 Then
                    Return "N/A"
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Sub loadTableStudentRequirement()
        requirementContent.studentReqirementsTbl.Rows.Clear()
        Try
            Using con As New SqlConnection(My.Settings.connection)
                con.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandText = "select stdno, concat(lastname,', ',firstname,' ',middlename) as name from student"
                    Using reader As SqlDataReader = cmd.ExecuteReader
                        While reader.Read
                            requirementContent.studentReqirementsTbl.Rows.Add(reader.Item("stdno"), reader.Item("name"), isSubmitted(reader.Item("stdno"), "BirthCertificate"), isSubmitted(reader.Item("stdno"), "Card"), isSubmitted(reader.Item("stdno"), "GoodMoral"), isSubmitted(reader.Item("stdno"), "HonorableDismissal"), "Details", "Upload")
                        End While
                    End Using
                End Using
                con.Close()
            End Using
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Sub markGrades(gr As grades)
        Using con As New SqlConnection(My.Settings.connection)
            con.Open()
            Using transaction As SqlTransaction = con.BeginTransaction
                Try
                    Using cmd As New SqlCommand
                        cmd.Connection = con
                        cmd.Transaction = transaction
                        cmd.CommandText = $"insert into grades(studentid,subjectid,grade)values('{gr.Stdno1}', '{gr.Subject1}', '{gr.Grade1}')"
                        cmd.ExecuteNonQuery()
                    End Using
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                    MsgBox(ex.Message)
                End Try
            End Using
            con.Close()
        End Using
    End Sub
End Module
