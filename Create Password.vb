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
            txtCNPassword.Clear()
            txtNPassword.Clear()
            Me.Close()
        ElseIf txtNPassword.Text IsNot txtCNPassword.Text Then
            MessageBox.Show("Both are not the same.")
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

            myCommandx = New MySqlCommand($"UPDATE tbluserlist SET dPassword = '{txtNPassword.Text}', dSec1 = '{Q1}' , dSeca1 = '{A1}', dSec2 = '{Q2}', dSeca2 = '{A2}', dSec3 = '{Q3}', dSeca3 = '{A3}', tDataChanged = CURRENT_TIMESTAMP() WHERE dEmployeeID = '{ID}'", myConnectionx)
            myCommandx.ExecuteNonQuery()
            MessageBox.Show("Password updated successfully.")
        Catch ex As Exception
            MsgBox(ex.Message) ' Display the exception message instead of Err.Description
        Finally
            myConnectionx.Close()
        End Try
    End Sub

    Private Sub Create_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class