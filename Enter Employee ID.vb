Imports MySql.Data.MySqlClient
Public Class Enter_Employee_ID
    Public EmployeeID As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If CheckEmployeeCredentials(txtNPassword.Text) Then
            EmployeeID = txtNPassword.Text
            Answer_Security_Questions.Show()
            Me.Close()
        Else
            MessageBox.Show("Incorrect EmployeeID")
        End If
    End Sub

    Private Function CheckEmployeeCredentials(EmployeeID As String) As Boolean
        Dim query As String = $"SELECT COUNT(*) FROM tbluserlist WHERE dEmployeeID = @employeeID"

        Using myConnection As MySqlConnection = Connector.getDBConnection()
            Using cmd As New MySqlCommand(query, myConnection)
                cmd.Parameters.AddWithValue("@employeeID", EmployeeID)

                myConnection.Open()
                Dim count As Integer = CInt(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
End Class