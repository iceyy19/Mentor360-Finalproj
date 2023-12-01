Public Class New_User
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Close()
        Security_Questions.Show()
    End Sub
End Class