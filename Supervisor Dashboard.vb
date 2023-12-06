Public Class Supervisor_Dashboard
    Private Answerform As Supervisor_Answer_Form
    Private Resultform As Supervisor_Result
    Private Historyform As Supervisor_History
    Private Sub Supervisor_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Answerform = New Supervisor_Answer_Form()
        Resultform = New Supervisor_Result()
        Historyform = New Supervisor_History


        InitializeForm(Answerform)
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
        Answerform.Hide()
        Resultform.Hide()
        Historyform.Hide()

        form.Show()
        form.BringToFront()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Answerform.Hide()
        Resultform.Hide()
        Historyform.Hide()
    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswers.Click
        Resultform.Hide()
        Historyform.Hide()
        ShowForm(Answerform)
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        If Supervisor_History.SelectedRowData IsNot Nothing Then
            ' Create an instance of the ResultForm


            ' Set the SelectedRowData property from HistoryForm
            Resultform.SelectedRowData = Supervisor_History.SelectedRowData

            If Resultform.SelectedRowData IsNot Nothing Then
                Resultform.lblEmployeeID.Text = Resultform.SelectedRowData("dEmployeeID")
                Resultform.lblEmployeeName.Text = Resultform.SelectedRowData("dEmployeeName")
                Resultform.lblSDS1.Text = Resultform.SelectedRowData("dSl1")
                Resultform.txtSDS1.Text = Resultform.SelectedRowData("dSr1")
                ' ... (Repeat for other columns)
            End If

            Answerform.Hide()
            Historyform.Hide()
            ShowForm(Resultform)
        Else
            Answerform.Hide()
            Historyform.Hide()
            ShowForm(Resultform)
        End If
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Answerform.Hide()
        Resultform.Hide()
        ShowForm(Historyform)
    End Sub
End Class