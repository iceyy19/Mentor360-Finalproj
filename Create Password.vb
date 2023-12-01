Imports MySql.Data.MySqlClient
Public Class Create_Password
    Public ID As String = Login.ID
    Public A1 As String = Security_Questions.A1
    Public A2 As String = Security_Questions.A2
    Public A3 As String = Security_Questions.A3
    Public Q1 As String = Security_Questions.Q1
    Public Q2 As String = Security_Questions.Q2
    Public Q3 As String = Security_Questions.Q3

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel5.Click

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If txtNPassword.Text = "" Or txtCNPassword.Text = "" Then
            MessageBox.Show("Fill the Required Fields.")
        ElseIf txtNPassword.Text = txtCNPassword.Text Then
            UpdateUserList()
        Else

        End If
    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click

    End Sub

    Sub UpdateUserList()
        Dim myConnectionx As MySqlConnection
        Dim myCommandx As MySqlCommand

        myConnectionx = Connector.getDBConnection()

        Try

            myConnectionx.Open()
            myCommandx = New MySqlCommand($"UPDATE tbluserlist SET dPassword = '{txtCNPassword.Text}', dSec1 = '{Q1}', dSec1 = '{A1}', dSec1 = '{Q2}', dSec1 = '{A2}', dSec1 = '{Q3}', dSec1 = '{A3}' WHERE dEmployeeID = '{ID}'", myConnectionx)
            myCommandx.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally

            myConnectionx.Close()

        End Try
    End Sub
End Class