Imports System.Reflection.Emit
Imports MySql.Data.MySqlClient
Public Class Answer_Security_Questions
    Public EmployeeID As String = Enter_Employee_ID.EmployeeID

    Private Sub Answer_Security_Questions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Checkifsecurity(EmployeeID)
    End Sub

    Private Sub lblSec1_Click(sender As Object, e As EventArgs) Handles lblSec1.Click

    End Sub
    Private Sub CheckAnswers(employeeID As String, answer1 As String, answer2 As String, answer3 As String)

        Using connection As MySqlConnection = Connector.getDBConnection()
            connection.Open()


            Dim query As String = "SELECT dSeca1, dSeca2, dSeca3 FROM tbluserlist WHERE dEmployeeID = @EmployeeID"


            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@EmployeeID", employeeID)


                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then

                        Dim dbAnswer1 As String = Convert.ToString(reader("dSeca1"))
                        Dim dbAnswer2 As String = Convert.ToString(reader("dSeca2"))
                        Dim dbAnswer3 As String = Convert.ToString(reader("dSeca3"))


                        If answer1 = dbAnswer1 AndAlso answer2 = dbAnswer2 AndAlso answer3 = dbAnswer3 Then

                            MessageBox.Show("Answers match.")
                            Me.Hide()
                            Create_Password.ShowDialog()
                        Else

                            MessageBox.Show("Incorrect Answer!")
                        End If
                    Else
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub Checkifsecurity(employeeID As String)
        ' Connect to the MySQL database
        Using connection As MySqlConnection = Connector.getDBConnection()
            connection.Open()

            ' Query to retrieve data for the specified employee ID
            Dim query As String = "SELECT dSeca1, dSeca2, dSeca3, dSec1, dSec2, dSec3 FROM tbluserlist WHERE dEmployeeID = @EmployeeID"

            ' Execute the query
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@EmployeeID", employeeID)

                ' Use a reader to retrieve the data
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Compare the answers with the data from the database
                        Dim dbAnswer1 As String = Convert.ToString(reader("dSeca1"))
                        Dim dbAnswer2 As String = Convert.ToString(reader("dSeca2"))
                        Dim dbAnswer3 As String = Convert.ToString(reader("dSeca3"))
                        DisplayDataInLabels(reader)
                        If String.IsNullOrWhiteSpace(dbAnswer1) OrElse String.IsNullOrWhiteSpace(dbAnswer2) OrElse String.IsNullOrWhiteSpace(dbAnswer3) Then

                            MessageBox.Show("You still don't have any security questions. Please login first.")
                            Me.Close()

                        End If

                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub DisplayDataInLabels(reader As MySqlDataReader)
        ' Retrieve and display data from columns 4 to 6
        Dim column4Value As String = Convert.ToString(reader("dSec1"))
        Dim column5Value As String = Convert.ToString(reader("dSec2"))
        Dim column6Value As String = Convert.ToString(reader("dSec3"))

        ' Display data in labels (replace Label1, Label2, Label3 with actual labels)
        lblSec1.Text = column4Value
        lblSec2.Text = column5Value
        lblSec3.Text = column6Value
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        CheckAnswers(EmployeeID, txtAnswer1.Text, txtAnswer2.Text, txtAnswer3.Text)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub txtAnswer1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAnswer1.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Click the login button
            btnNext.PerformClick()
        End If
    End Sub
    Private Sub txtAnswer2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAnswer2.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Click the login button
            btnNext.PerformClick()
        End If
    End Sub
    Private Sub txtAnswer3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAnswer3.KeyDown
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