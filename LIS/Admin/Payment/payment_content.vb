Public Class payment_content
    Dim mywidth, myheight As Integer

    Sub New(mwith As Integer, mheight As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        mywidth = mwith
        myheight = mheight
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub payment_content_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = mywidth
        Me.Height = myheight
    End Sub
End Class
