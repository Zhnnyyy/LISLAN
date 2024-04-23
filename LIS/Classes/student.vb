Public Class student
    Private stdno As String
    Private fname As String
    Private mname As String
    Private lname As String
    Private address As String
    Private course As Integer
    Private yrlevel As Integer
    Private section As String
    Private studentType As String
    Private DateEnrolled As String

    Public Sub New(stdno As String, fname As String, mname As String, lname As String, address As String, course As Integer, yrlevel As Integer, section As String, studentType As String, dateEnrolled As String)
        Me.stdno = stdno
        Me.fname = fname
        Me.mname = mname
        Me.lname = lname
        Me.address = address
        Me.course = course
        Me.yrlevel = yrlevel
        Me.section = section
        Me.studentType = studentType
        Me.DateEnrolled = dateEnrolled
    End Sub

    Public Property Stdno1 As String
        Get
            Return stdno
        End Get
        Set(value As String)
            stdno = value
        End Set
    End Property

    Public Property Fname1 As String
        Get
            Return fname
        End Get
        Set(value As String)
            fname = value
        End Set
    End Property

    Public Property Mname1 As String
        Get
            Return mname
        End Get
        Set(value As String)
            mname = value
        End Set
    End Property

    Public Property Lname1 As String
        Get
            Return lname
        End Get
        Set(value As String)
            lname = value
        End Set
    End Property

    Public Property Address1 As String
        Get
            Return address
        End Get
        Set(value As String)
            address = value
        End Set
    End Property

    Public Property Course1 As Integer
        Get
            Return course
        End Get
        Set(value As Integer)
            course = value
        End Set
    End Property

    Public Property Yrlevel1 As Integer
        Get
            Return yrlevel
        End Get
        Set(value As Integer)
            yrlevel = value
        End Set
    End Property

    Public Property Section1 As String
        Get
            Return section
        End Get
        Set(value As String)
            section = value
        End Set
    End Property

    Public Property StudentType1 As String
        Get
            Return studentType
        End Get
        Set(value As String)
            studentType = value
        End Set
    End Property

    Public Property DateEnrolled1 As String
        Get
            Return DateEnrolled
        End Get
        Set(value As String)
            DateEnrolled = value
        End Set
    End Property
End Class
