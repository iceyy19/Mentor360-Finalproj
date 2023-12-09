Public Class Manager_Dashboard
    Public Resultform As Manager_Results
    Public Historyform As Manager_History
    Private Employeesform As Manager_Employee
    Public ID As String = Login.ID
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Employeesform.Hide()
        Resultform.Hide()
        Historyform.Hide()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Resultform.Hide()
        Employeesform.Hide()
        ShowForm(Historyform)
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Historyform.Hide()
        Employeesform.Hide()
        ShowForm(Resultform)
    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        Resultform.Hide()
        Historyform.Hide()
        ShowForm(Employeesform)
    End Sub

    Private Sub Manager_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Employeesform = New Manager_Employee()
        Resultform = New Manager_Results()
        Historyform = New Manager_History()

        InitializeForm(Employeesform)
        InitializeForm(Resultform)
        InitializeForm(Historyform)
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
        Employeesform.Hide()
        Resultform.Hide()
        Historyform.Hide()

        form.Show()
        form.BringToFront()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

    End Sub
End Class