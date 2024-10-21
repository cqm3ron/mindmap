Public Class Form1
    Private Sub btnAddTitle_Click(sender As Object, e As EventArgs) Handles btnAddTitle.Click
        Dim newOval As New OvalControl()
        newOval.Text = "Sample text that wraps inside the oval"
        newOval.Font = New Font("Arial", 10)
        newOval.Location = New Point(50, 50)
        Me.Controls.Add(newOval)
    End Sub
End Class
