Imports MySql.Data.MySqlClient
Public Class Supervisor_History
    Private Sub Supervisor_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewlogs()
    End Sub
    Sub viewlogs()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet

        myConnection1 = Connector.getDBConnection()

        Try

            myConnection1.Open()
            myCommand1 = New MySqlCommand("
    SELECT
        dEmployeeID,
        dEmployeeName,
        dSupervisorID,
        dSupervisorName,
        dManagerID,
        dManagerName,
        dEl1, dEl2, dEl3, dEl4, dEl5, dEl6, dEl7, dEl8, dEl9, dEl10,
        dEl11, dEl12, dEl13, dEl14, dEl15, dEl16, dEl17, dEl18, dEl19, dEl20,
        dEl21, dEl22, dEl23, dEl24, dEl25, dEl26, dEl27, dEl28, dEl29, dEl30,
        dEl31, dEl32, dEl33, dEl34,
        dEr1, dEr2, dEr3, dEr4, dEr5, dEr6, dEr7,
        tEDateResponse,
        dSl1, dSl2, dSl3, dSl4, dSl5, dSl6, dSl7, dSl8, dSl9, dSl10,
        dSl11, dSl12, dSl13, dSl14, dSl15, dSl16, dSl17, dSl18, dSl19, dSl20,
        dSl21, dSl22, dSl23, dSl24, dSl25, dSl26, dSl27, dSl28, dSl29, dSl30,
        dSl31, dSl32, dSl33, dSl34,
        dSr1, dSr2, dSr3, dSr4, dSr5, dSr6, dSr7,
        tSDateResponse,
        dERating,
        dSRating,
        dDiscussion
    FROM
        tblfeedback
    WHERE
        dSupervisorID = 2022;", myConnection1)

            myAdapter2.SelectCommand = myCommand1
            myAdapter2.Fill(myDataSet2, "myData")
            dghistory.DataSource = myDataSet2.Tables("myData")

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection1.Close()
        End Try
    End Sub
End Class