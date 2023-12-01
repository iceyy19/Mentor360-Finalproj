
Public Class Security_Questions
    Public ID As String = Login.ID
    Public Shared A1, A2, A3, Q1, Q2, Q3 As String
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtAnswer1.Clear()
        txtAnswer2.Clear()
        txtAnswer3.Clear()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If txtAnswer1.Text = "" Or txtAnswer2.Text = "" Or txtAnswer2.Text = "" Or cbquestion1.Text = "" Or cbquestion2.Text = "" Or cbquestion3.Text = "" Then
            MessageBox.Show("Fill the Required Fields.")
        Else
            A1 = txtAnswer1.Text
            A2 = txtAnswer2.Text
            A3 = txtAnswer3.Text
            Q1 = cbquestion1.Text
            Q2 = cbquestion2.Text
            Q3 = cbquestion3.Text
            Me.Close()
            Create_Password.Show()
        End If
    End Sub

End Class