Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set KeyPreview to True to capture key presses at the form level
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Perform the click action of ViewSubmission button
            ViewSubmission.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Perform the click action of Createsubmission button
            Createsubmission.PerformClick()
        End If
    End Sub

    Private Sub ViewSubmission_Click(sender As Object, e As EventArgs) Handles ViewSubmission.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Createsubmission_Click(sender As Object, e As EventArgs) Handles Createsubmission.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Handle label click event if needed
    End Sub

End Class
