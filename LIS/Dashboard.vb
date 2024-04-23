Imports Siticone.UI.WinForms
Imports System.Net.Http
Imports Newtonsoft.Json
Public Class Dashboard
    Dim obj_dashboard As New dashboard_content

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(Me.Width, Me.Height)
        content_box.Controls.Add(New dashboard_content(content_box.Width, content_box.Height))
        setSeleted(dashboardBtn, dashboardBtn.HoveredState.Image)
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        content_box.Controls.Clear()
        content_box.Controls.Add(New dashboard_content(content_box.Width, content_box.Height))
        setSeleted(dashboardBtn, dashboardBtn.HoveredState.Image)
    End Sub

    Private Sub studentInfoBtn_Click(sender As Object, e As EventArgs) Handles studentInfoBtn.Click
        content_box.Controls.Clear()
        content_box.Controls.Add(New student_content(content_box.Width, content_box.Height))
        setSeleted(studentInfoBtn, studentInfoBtn.HoveredState.Image)
    End Sub

    Private Sub requirementsBtn_Click(sender As Object, e As EventArgs) Handles requirementsBtn.Click
        content_box.Controls.Clear()
        content_box.Controls.Add(New requirements_content(content_box.Width, content_box.Height))
        setSeleted(requirementsBtn, requirementsBtn.HoveredState.Image)
    End Sub

    Private Sub paymentBtn_Click(sender As Object, e As EventArgs) Handles paymentBtn.Click
        content_box.Controls.Clear()
        content_box.Controls.Add(New payment_content(content_box.Width, content_box.Height))
        setSeleted(paymentBtn, paymentBtn.HoveredState.Image)
    End Sub

    Private Sub reportsBtn_Click(sender As Object, e As EventArgs) Handles reportsBtn.Click
        content_box.Controls.Clear()
        content_box.Controls.Add(New report_content(content_box.Width, content_box.Height))
        setSeleted(reportsBtn, reportsBtn.HoveredState.Image)
    End Sub

    Sub setSeleted(btn As SiticoneButton, icon As Bitmap)
        For Each ctrl As Control In controls_panel.Controls
            If TypeOf ctrl Is SiticoneButton Then
                Dim mybtn As SiticoneButton = DirectCast(ctrl, SiticoneButton)
                Dim img As Bitmap = mybtn.Image
                mybtn.FillColor = Color.White
                mybtn.ForeColor = Color.FromArgb(3, 6, 83)
                mybtn.Image = mybtn.BackgroundImage
            End If
        Next
        btn.FillColor = Color.FromArgb(3, 6, 83)
        btn.ForeColor = Color.White
        btn.Image = icon
    End Sub

    Private Sub gradeBtn_Click(sender As Object, e As EventArgs) Handles gradeBtn.Click
        content_box.Controls.Clear()
        content_box.Controls.Add(New grade_content(content_box.Width, content_box.Height))
        setSeleted(gradeBtn, gradeBtn.HoveredState.Image)
    End Sub


End Class
