Imports System.Data.SqlClient
Public Class details
    Dim x, y As Integer
    Dim uid As String
    Sub New(x As Integer, y As Integer, uid As String)
        InitializeComponent()
        Me.x = x
        Me.y = y
        Me.uid = uid
    End Sub
    Private Sub details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SiticoneShadowForm1.SetShadowForm(Me)
        Me.Location = New Point(x, y)
        loadTable()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Sub loadTable()
        documentsTable.Rows.Clear()
        Using con As New SqlConnection(My.Settings.connection)
            con.Open()
            Try
                Using cmd As New SqlCommand()
                    cmd.Connection = con
                    cmd.CommandText = $"select filename,type,date from documents where stdno='{uid}'"
                    Using reader As SqlDataReader = cmd.ExecuteReader
                        Dim row As Integer = 0
                        While reader.Read
                            row += 1
                            documentsTable.Rows.Add(row, reader.Item(0).ToString, reader.Item(1).ToString, reader.Item(2).ToString)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()
        End Using
    End Sub
End Class