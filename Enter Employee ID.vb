Imports MySql.Data.MySqlClient
Public Class Enter_Employee_ID
    Public EmployeeID As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If CheckEmployeeCredentials(txtEmployeeID.Text) Then
            EmployeeID = txtEmployeeID.Text
            Answer_Security_Questions.ShowDialog()
            Me.Hide()
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

    Private Sub Enter_Employee_ID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmployeeID.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Click the login button
            btnNext.PerformClick()
        End If
    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ' Check if the Enter key is pressed
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            btnNext.PerformClick()
            e.Handled = True
        End If
    End Sub
End Class