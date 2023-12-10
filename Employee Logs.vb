Imports MySql.Data.MySqlClient
Public Class Employee_Logs
    Public ID As String = Login.ID
    Public Nname As String = Login.Nname
    Private Sub Employee_Logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAdminID.Text = ID
        lblAdminName.Text = Nname
        viewElogs()
    End Sub
    Sub viewElogs()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet

        myConnection1 = Connector.getDBConnection()

        Try

            myConnection1.Open()
            myCommand1 = New MySqlCommand("SELECT
            dEmployeeID As `EmployeeID`, 
            dEmployeeName AS `Employee Name`, 
            dPOsition AS Position,
            tTimestamp AS Timestamp
            FROM tblEmployeelogs;", myConnection1)

            myAdapter2.SelectCommand = myCommand1
            myAdapter2.Fill(myDataSet2, "myData")
            dgEmployeeLogs.DataSource = myDataSet2.Tables("myData")

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection1.Close()
        End Try
    End Sub
End Class