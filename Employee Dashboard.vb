Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Employee_Dashboard
    Private Answerform As Employee_Answer_Form
    Private Resultform As Employee_Result
    Public ID As String = Login.ID
    Public Shared eN As String
    Public Shared sID As String
    Public Shared sN As String
    Public Shared mID As String
    Public Shared mN As String
    Private Sub Employee_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Answerform = New Employee_Answer_Form()
        Resultform = New Employee_Result()


        InitializeForm(Answerform)
        InitializeForm(Resultform)
        Dim result As Tuple(Of String, String, String, String, String) = GetEmployeeData(ID)

        ' Access the data using the result variables
        eN = result.Item1
        sID = result.Item2
        sN = result.Item3
        mID = result.Item4
        mN = result.Item5

        lblEID.Text = ID
        lblEName.Text = eN
        lblSupervisor.Text = sID & ", " & sN
        lblManager.Text = mID & ", " & mN
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

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
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

    Private Function GetEmployeeData(EmployeeID As String) As Tuple(Of String, String, String, String, String)
        Dim employeeName As String = ""
        Dim supervisorID As String = ""
        Dim supervisorName As String = ""
        Dim managerID As String = ""
        Dim managerName As String = ""
        Try
            Using Connection As MySqlConnection = Connector.getDBConnection()
                Connection.Open()

                ' Adjust the table name and column names according to your database schema
                Dim query As String = "SELECT dEmployeeName, dSupervisorID, dSupervisorName, dManagerID, dManagerName " &
                                      "FROM tblhierarchy " &
                                      "WHERE dEmployeeID = @EmployeeID"

                Using command As MySqlCommand = New MySqlCommand(query, Connection)
                    command.Parameters.AddWithValue("@EmployeeID", EmployeeID)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            employeeName = reader("dEmployeeName").ToString()
                            supervisorID = reader("dSupervisorID").ToString()
                            supervisorName = reader("dSupervisorName").ToString()
                            managerID = reader("dManagerID").ToString()
                            managerName = reader("dManagerName").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try

        Return Tuple.Create(employeeName, supervisorID, supervisorName, managerID, managerName)
    End Function
End Class