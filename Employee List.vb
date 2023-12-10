Imports MySql.Data.MySqlClient
Public Class Employee_List
    Public ID As String = Login.ID
    Public Nname As String = Login.Nname
    Dim idToEdit As Integer
    Dim rowIndexToEdit As Integer
    Private Sub Employee_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewList()
        lblAdminID.Text = ID
        lblAdminName.Text = Nname

    End Sub
    Sub viewList()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet

        myConnection1 = Connector.getDBConnection()

        Try

            myConnection1.Open()
            myCommand1 = New MySqlCommand("SELECT dEmployeeID AS EmployeeID, 
            dEmployeeName As `Employee Name`, 
            dPassword AS Password, 
            dSec1 AS `Security Question 1`,
            dSeca1 AS `Security Answer 1`, 
            dSec2 AS `Security Question 2`,
            dSeca2 AS `Security Answer 2`, 
            dSec3 AS `Security Question 3`,
            dSeca3 AS `Security Answer 3`, 
            tDataChanged AS `Time Data Changed` 
            FROM tbluserlist;", myConnection1)

            myAdapter2.SelectCommand = myCommand1
            myAdapter2.Fill(myDataSet2, "myData")
            dgEmployeeList.DataSource = myDataSet2.Tables("myData")

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection1.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to change password?", "Password Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If txtPassword.Text IsNot "" Then
                ' Get the edited data from textboxes
                Dim editedColumn1 As String = txtPassword.Text

                dgEmployeeList.Rows(rowIndexToEdit).Cells("Password").Value = editedColumn1


                ' Update data in the database
                Using connection As MySqlConnection = Connector.getDBConnection()
                    connection.Open()

                    ' Replace "YourTableName" with your actual table name
                    Dim query As String = $"UPDATE tbluserlist SET dPassword = @Column1, tDataChanged = CURRENT_TIMESTAMP() WHERE dEmployeeID = @ID"
                    Using cmd As New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@Column1", editedColumn1)
                        cmd.Parameters.AddWithValue("@ID", idToEdit)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Else
                MessageBox.Show("Fill in the required field")
            End If
        End If

    End Sub

    Private Sub dgEmployeeList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmployeeList.CellContentClick

        If dgEmployeeList.SelectedRows.Count > 0 Then
            ' Move the selected row data to textboxes
            Dim selectedRow As DataGridViewRow = dgEmployeeList.SelectedRows(0)
            txtPassword.Text = selectedRow.Cells("Password").Value.ToString()


            ' Store the ID of the selected row for later use
            ' You can use this ID to identify the row to update in the database
            idToEdit = Integer.Parse(selectedRow.Cells("EmployeeID").Value.ToString())
            ' Store the index of the selected row for later use
            rowIndexToEdit = selectedRow.Index
        End If
    End Sub
End Class