Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports Newtonsoft.Json

Public Class Form3

    Dim hh, mm, ss, ms As Integer

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set KeyPreview to True to capture key presses at the form level
        Me.KeyPreview = True

        ' Set the Timer interval to 10 ms for milliseconds accuracy
        Timer1.Interval = 10
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Perform the click action of Submitbtn button
            Submitbtn.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.J Then
            ' Perform the click action of Startbtn button
            Startbtn.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.K Then
            ' Perform the click action of Resumebtn button
            Resumebtn.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.L Then
            ' Perform the click action of Stopbtn button
            Stopbtn.PerformClick()
        End If
    End Sub

    Private Sub Startbtn_Click(sender As Object, e As EventArgs) Handles Startbtn.Click
        Timer1.Enabled = True
        hh = 0
        mm = 0
        ss = 0
        ms = 0
    End Sub

    Private Sub Resumebtn_Click(sender As Object, e As EventArgs) Handles Resumebtn.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Stopbtn_Click(sender As Object, e As EventArgs) Handles Stopbtn.Click
        Timer1.Enabled = False
    End Sub

    Private Async Sub Submitbtn_Click(sender As Object, e As EventArgs) Handles Submitbtn.Click
        ' Collect form data
        Dim name As String = TextBox1.Text
        Dim email As String = TextBox2.Text
        Dim phone As String = TextBox3.Text
        Dim github_link As String = TextBox4.Text
        Dim stopwatch_time As String = TextBox5.Text

        ' Validate form data
        If String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(phone) OrElse String.IsNullOrEmpty(github_link) OrElse String.IsNullOrEmpty(stopwatch_time) Then
            MsgBox("All fields are required", MsgBoxStyle.Critical)
            Return
        End If

        ' Create the submission object
        Dim submission As New With {
        .name = name,
        .email = email,
        .phone = phone,
        .github_link = github_link,
        .stopwatch_time = stopwatch_time
    }

        ' Convert the submission object to JSON
        Dim json As String = JsonConvert.SerializeObject(submission)

        ' Send the data to the server
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:3000/")
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("api/submit", content)

            If response.IsSuccessStatusCode Then
                MsgBox("Submission saved successfully")
            Else
                MsgBox("Failed to save submission", MsgBoxStyle.Critical)
            End If
        End Using
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ms += 10
        If ms >= 1000 Then
            ms = 0
            ss += 1
        End If
        If ss >= 60 Then
            ss = 0
            mm += 1
        End If
        If mm >= 60 Then
            mm = 0
            hh += 1
        End If

        TextBox5.Text = Format(hh, "00:") & Format(mm, "00:") & Format(ss, "00:") & Format(ms \ 10, "00")
    End Sub

End Class
