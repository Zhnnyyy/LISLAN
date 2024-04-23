Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Data.SqlClient
Imports Siticone.UI.WinForms
Imports System.IO
Public Class addStudent
    Dim frm137 As String = ""
    Dim gdmoral As String = ""
    Dim bc As String = ""
    Private Sub addStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SiticoneShadowForm1.SetShadowForm(Me)
        type1.Checked = True
        RegionList()
        loadCourses()
        loadYrlevel()
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

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub


    Sub RegionList()
        comboboxRegion.Items.Clear()
        Dim httpClient As New HttpClient()
        Dim url As String = "https://psgc.gitlab.io/api/regions.json"
        Dim response As HttpResponseMessage = httpClient.GetAsync(url).Result
        If response.IsSuccessStatusCode Then
            Dim responseBody As String = response.Content.ReadAsStringAsync().Result
            Dim exampleDataList As List(Of region) = JsonConvert.DeserializeObject(Of List(Of region))(responseBody)
            For Each exampleData As region In exampleDataList
                comboboxRegion.Items.Add(New KeyValuePair(Of String, String)(exampleData.code, exampleData.name))
            Next
            comboboxRegion.DisplayMember = "Value"
        Else
            Console.WriteLine("Error: " & response.StatusCode.ToString() & " - " & response.ReasonPhrase)
        End If
        httpClient.Dispose()
    End Sub

    Sub CityList()
        comboboxCity.Items.Clear()
        Dim httpClient As New HttpClient()
        Dim url As String = "https://psgc.gitlab.io/api/regions/" & comboboxRegion.SelectedItem.Key & "/cities.json"
        Dim response As HttpResponseMessage = httpClient.GetAsync(url).Result
        If response.IsSuccessStatusCode Then
            Dim responseBody As String = response.Content.ReadAsStringAsync().Result
            Dim exampleDataList As List(Of cities) = JsonConvert.DeserializeObject(Of List(Of cities))(responseBody)
            For Each exampleData As cities In exampleDataList
                comboboxCity.Items.Add(New KeyValuePair(Of String, String)(exampleData.code, exampleData.name))
            Next
            comboboxCity.DisplayMember = "Value"
        Else
            Console.WriteLine("Error: " & response.StatusCode.ToString() & " - " & response.ReasonPhrase)
        End If
        httpClient.Dispose()
    End Sub

    Sub BarangayList()
        comboboxBarangay.Items.Clear()
        Dim httpClient As New HttpClient()
        Dim url As String = "https://psgc.gitlab.io/api/cities/" & comboboxCity.SelectedItem.Key & "/barangays.json"
        Dim response As HttpResponseMessage = httpClient.GetAsync(url).Result
        If response.IsSuccessStatusCode Then
            Dim responseBody As String = response.Content.ReadAsStringAsync().Result
            Dim exampleDataList As List(Of barangay) = JsonConvert.DeserializeObject(Of List(Of barangay))(responseBody)

            For Each exampleData As barangay In exampleDataList
                comboboxBarangay.Items.Add(New KeyValuePair(Of Integer, String)(exampleData.code, exampleData.name))
            Next
            comboboxBarangay.DisplayMember = "Value"
        Else
            Console.WriteLine("Error: " & response.StatusCode.ToString() & " - " & response.ReasonPhrase)
        End If
        httpClient.Dispose()
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim studentType As String = If(type1.Checked, "Old", "New")
        If validator(stdno) And validator(fname) And validator(lname) And optionValidator(comboboxcourse) And optionValidator(comboboxyrlevel) And optionValidator(comboboxsection) And optionValidator(comboboxRegion) And optionValidator(comboboxCity) And optionValidator(comboboxBarangay) Then
            Try
                Dim otherDetails As String = If(address_other_details.Text.Length <> 0, ", " & address_other_details.Text, "")
                Dim studentAddress As String = comboboxRegion.SelectedItem.Value & " " & comboboxCity.SelectedItem.Value & " " & comboboxBarangay.SelectedItem.Value & otherDetails
                addStudents(New student(stdno.Text, fname.Text, mname.Text, lname.Text, studentAddress, comboboxcourse.SelectedItem.Key, comboboxyrlevel.SelectedItem.Key, comboboxsection.SelectedItem, studentType, DateTime.Now.Date))
                Dim mnameval As String = If(mname.Text.Length <> 0, " " & mname.Text, "")
                Dim name As String = lname.Text & ", " & fname.Text & mnameval
                addStudentDirectory(comboboxcourse.SelectedItem.Value, comboboxyrlevel.SelectedItem.Value, comboboxsection.SelectedItem, name)
                resetFields()
                loadTableStudentInfo()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Please fill out all fields")
        End If
    End Sub

    Sub addStudentDirectory(course As String, yrlevel As String, section As String, name As String)
        Dim rootPath As String = Application.StartupPath & "\LisData\LIS" & "\" & course & "\" & yrlevel & "\" & section
        If Not Directory.Exists(rootPath & "\" & name) Then
            Directory.CreateDirectory(rootPath & "\" & name & "\Documents")
        End If

        Dim finalPath As String = rootPath & "\" & name & "\Documents\"
        If form137.Tag IsNot Nothing Then
            Dim filename As String = Path.GetFileName(form137.Tag)
            Dim filedata As Byte() = File.ReadAllBytes(form137.Tag)
            Dim fileExtension As String = Path.GetExtension(form137.Tag)
            Dim newFilename As String = "Card" & fileExtension
            Try
                addDocument(New document(stdno.Text, newFilename, filedata, "Card", DateTime.Now.Date))
                File.Copy(form137.Tag, Path.Combine(finalPath, newFilename), True)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If goodmoral.Tag IsNot Nothing Then
            Dim filename As String = Path.GetFileName(goodmoral.Tag)
            Dim filedata As Byte() = File.ReadAllBytes(goodmoral.Tag)
            Dim fileExtension As String = Path.GetExtension(goodmoral.Tag)
            Dim newFilename As String = "GoodMoral" & fileExtension
            Try
                addDocument(New document(stdno.Text, newFilename, filedata, "GoodMoral", DateTime.Now.Date))
                File.Copy(goodmoral.Tag, Path.Combine(finalPath, newFilename), True)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If birthcertificate.Tag IsNot Nothing Then
            Dim filename As String = Path.GetFileName(birthcertificate.Tag)
            Dim filedata As Byte() = File.ReadAllBytes(birthcertificate.Tag)
            Dim fileExtension As String = Path.GetExtension(birthcertificate.Tag)
            Dim newFilename As String = "BirthCertificate" & fileExtension
            Try
                addDocument(New document(stdno.Text, newFilename, filedata, "BirthCertificate", DateTime.Now.Date))
                File.Copy(birthcertificate.Tag, Path.Combine(finalPath, newFilename), True)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If honorabledismissal.Tag IsNot Nothing Then
            Dim filename As String = Path.GetFileName(honorabledismissal.Tag)
            Dim filedata As Byte() = File.ReadAllBytes(honorabledismissal.Tag)
            Dim fileExtension As String = Path.GetExtension(honorabledismissal.Tag)
            Dim newFilename As String = "HonorableDismissal" & fileExtension
            Try
                addDocument(New document(stdno.Text, newFilename, filedata, "HonorableDismissal", DateTime.Now.Date))
                File.Copy(honorabledismissal.Tag, Path.Combine(finalPath, newFilename), True)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub resetFields()
        For Each ctrl As Control In controlbox.Controls
            If TypeOf ctrl Is SiticoneTextBox Then
                Dim txtbox As SiticoneTextBox = DirectCast(ctrl, SiticoneTextBox)
                txtbox.Clear()
            End If
            If TypeOf ctrl Is SiticoneComboBox Then
                Dim combobox As SiticoneComboBox = DirectCast(ctrl, SiticoneComboBox)
                combobox.Items.Clear()
            End If
        Next
        RegionList()
        loadYrlevel()
        loadCourses()
        comboboxsection.Items.Add("A")
        comboboxsection.Items.Add("B")
    End Sub
    Private Sub comboboxCity_Click(sender As Object, e As EventArgs) Handles comboboxCity.Click
        If comboboxRegion.SelectedIndex = -1 Then
            MsgBox("Please select region first")
        End If
    End Sub

    Private Sub comboboxRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxRegion.SelectedIndexChanged
        CityList()
    End Sub

    Private Sub comboboxBarangay_Click(sender As Object, e As EventArgs) Handles comboboxBarangay.Click
        If comboboxCity.SelectedIndex = -1 Then
            MsgBox("Please select city first")
        End If
    End Sub

    Private Sub comboboxCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxCity.SelectedIndexChanged
        BarangayList()
    End Sub



    Function optionValidator(target As Siticone.UI.WinForms.SiticoneComboBox) As Boolean
        If target.SelectedIndex = -1 Then
            Return False
        End If
        Return True
    End Function

    Private Sub form137_Click(sender As Object, e As EventArgs) Handles form137.Click
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            Dim filepath As String = OpenFileDialog.FileName
            Dim filename As String = Path.GetFileName(filepath)
            form137.Tag = filepath
            form137.Text = filename
        End If
    End Sub

    Private Sub goodmoral_Click(sender As Object, e As EventArgs) Handles goodmoral.Click
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            Dim filepath As String = OpenFileDialog.FileName
            Dim filename As String = Path.GetFileName(filepath)
            goodmoral.Tag = filepath
            goodmoral.Text = filename
        End If
    End Sub

    Private Sub birthcertificate_Click(sender As Object, e As EventArgs) Handles birthcertificate.Click
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            Dim filepath As String = OpenFileDialog.FileName
            Dim filename As String = Path.GetFileName(filepath)
            birthcertificate.Tag = filepath
            birthcertificate.Text = filename
        End If
    End Sub

    Private Sub honorabledismissal_Click(sender As Object, e As EventArgs) Handles honorabledismissal.Click
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            Dim filepath As String = OpenFileDialog.FileName
            Dim filename As String = Path.GetFileName(filepath)
            honorabledismissal.Tag = filepath
            honorabledismissal.Text = filename
        End If
    End Sub
End Class