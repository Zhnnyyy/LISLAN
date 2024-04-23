Public Class grades
    Private stdno As String
    Private subject As String
    Private grade As Double

    Public Sub New(stdno As String, subject As String, grade As Double)
        Me.stdno = stdno
        Me.subject = subject
        Me.grade = grade
    End Sub

    Public Property Stdno1 As String
        Get
            Return stdno
        End Get
        Set(value As String)
            stdno = value
        End Set
    End Property

    Public Property Subject1 As String
        Get
            Return subject
        End Get
        Set(value As String)
            subject = value
        End Set
    End Property

    Public Property Grade1 As Double
        Get
            Return grade
        End Get
        Set(value As Double)
            grade = value
        End Set
    End Property
End Class
