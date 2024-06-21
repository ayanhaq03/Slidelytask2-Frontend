Imports Newtonsoft.Json.Linq
Imports System.Net

Public Class Form2

    Private submissions As JArray
    Private currentSubmissionIndex As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        LoadSubmissions()
        DisplayCurrentSubmission()
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            Prevbtn.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            Nextbtn.PerformClick()
        End If
    End Sub

    Private Sub Prevbtn_Click(sender As Object, e As EventArgs) Handles Prevbtn.Click
        If currentSubmissionIndex > 0 Then
            currentSubmissionIndex -= 1
            DisplayCurrentSubmission()
        Else
            MsgBox("No previous submission")
        End If
    End Sub

    Private Sub Nextbtn_Click(sender As Object, e As EventArgs) Handles Nextbtn.Click
        If currentSubmissionIndex < submissions.Count - 1 Then
            currentSubmissionIndex += 1
            DisplayCurrentSubmission()
        Else
            MsgBox("No next submission")
        End If
    End Sub

    Private Sub DisplayCurrentSubmission()
        Try
            Dim submission As JObject = submissions(currentSubmissionIndex)

            TextBox1.Text = submission("name").ToString()
            TextBox2.Text = submission("email").ToString()
            TextBox3.Text = submission("phone").ToString()
            TextBox4.Text = submission("github_link").ToString()
            TextBox5.Text = submission("stopwatch_time").ToString()
        Catch ex As Exception
            MsgBox("Failed to display submission: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadSubmissions()
        Try
            Dim apiUrl As String = "http://localhost:3000/api/readAll"
            Dim client As New WebClient()
            Dim response As String = client.DownloadString(apiUrl)

            ' Parse the JSON response into a JArray
            submissions = JArray.Parse(response)
        Catch ex As Exception
            MsgBox("Failed to load submissions: " & ex.Message)
            submissions = New JArray() ' Initialize empty array or handle error
        End Try
    End Sub

End Class
