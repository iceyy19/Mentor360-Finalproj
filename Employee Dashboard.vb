Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Employee_Dashboard
    Private Answerformopen As Boolean = False
    Private Resultformopen As Boolean = False
    Private Historyformopen As Boolean = False



    Private Sub Employee_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Answerform As Employee_Answer_Form

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        If Answerformopen Then
            ' Hide the child form
            Answerform.Hide()

            ' Update the open status
            Answerformopen = False
        End If
    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        If Not Answerformopen Then

            Answerform = New Employee_Answer_Form()
            Answerform.TopLevel = False
            Answerform.StartPosition = FormStartPosition.Manual
            Answerform.Location = New Point(Homepanel.Left, Homepanel.Top)

            Me.Controls.Add(Answerform)
            Answerform.FormBorderStyle = FormBorderStyle.FixedDialog
            Answerform.ControlBox = False
            Answerform.Text = ""

            Answerform.Show()
            Answerformopen = True
            Answerform.BringToFront()

        End If
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        If Answerformopen Then

            Answerform.Hide()


            Answerformopen = False
        End If
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        If Answerformopen Then

            Answerform.Hide()


            Answerformopen = False
        End If
    End Sub
End Class