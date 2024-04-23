Public Class document
    Private stdno As String
    Private filename As String
    Private filedata As Byte()
    Private filetype As String
    Private SubmittedDate As String

    Public Sub New(stdno As String, filename As String, filedata() As Byte, filetype As String, SubmittedDate As String)
        Me.stdno = stdno
        Me.filename = filename
        Me.filedata = filedata
        Me.filetype = filetype
        Me.SubmittedDate = SubmittedDate
    End Sub

    Public Property Stdno1 As String
        Get
            Return stdno
        End Get
        Set(value As String)
            stdno = value
        End Set
    End Property

    Public Property Filename1 As String
        Get
            Return filename
        End Get
        Set(value As String)
            filename = value
        End Set
    End Property

    Public Property Filedata1 As Byte()
        Get
            Return filedata
        End Get
        Set(value As Byte())
            filedata = value
        End Set
    End Property

    Public Property Filetype1 As String
        Get
            Return filetype
        End Get
        Set(value As String)
            filetype = value
        End Set
    End Property

    Public Property SubmittedDate1 As String
        Get
            Return SubmittedDate
        End Get
        Set(value As String)
            SubmittedDate = value
        End Set
    End Property
End Class
