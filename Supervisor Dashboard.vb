Public Class Supervisor_Dashboard
    Private Answerform As Supervisor_Answer_Form
    Private Resultform As Supervisor_Result
    Private Sub Supervisor_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Answerform = New Supervisor_Answer_Form()
        Resultform = New Supervisor_Result()


        InitializeForm(Answerform)
        InitializeForm(Resultform)
    End Sub

    Private Sub InitializeForm(form As Form)
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.FixedDialog
        form.ControlBox = False
        form.Text = ""
        form.Hide()
        Homepanel.Controls.Add(form)
    End Sub

    Private Sub ShowForm(form As Form)
        Answerform.Hide()
        Resultform.Hide()

        form.Show()
        form.BringToFront()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Answerform.Hide()
        Resultform.Hide()
    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswers.Click
        Resultform.Hide()
        ShowForm(Answerform)
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Answerform.Hide()
        ShowForm(Resultform)
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Answerform.Hide()
        Resultform.Hide()
    End Sub
End Class