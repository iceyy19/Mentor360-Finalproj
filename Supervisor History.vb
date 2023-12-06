Imports MySql.Data.MySqlClient

Public Class Supervisor_History
    Private itemsPerPage As Integer = 20
    Private Resultform As Supervisor_Result
    Public Shared Property SelectedRowData As Dictionary(Of String, String)
    Private Sub Supervisor_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()
    End Sub

    Private Sub LoadData()
        Dim myConnection As MySqlConnection
        myConnection = Connector.getDBConnection()

        Try
            ' Open the connection
            myConnection.Open()

            ' SQL query
            Dim query As String = "
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
                    dSupervisorID = 2022 AND (dSl1 IS NOT NULL OR dSr1 IS NOT NULL);
            "

            ' Create a MySqlCommand with the SQL query and MySqlConnection
            Dim myCommand As New MySqlCommand(query, myConnection)

            Dim myDataAdapter As New MySqlDataAdapter(myCommand)
            Dim dataTable As New DataTable()
            myDataAdapter.Fill(dataTable)

            ' Set up BindingSource
            Dim bindingSource As New BindingSource()
            bindingSource.DataSource = dataTable

            ' Set up DataGridView
            dgHistory.DataSource = bindingSource

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            myConnection.Close()
        End Try
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' Check if a row is selected
        If dgHistory.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = dgHistory.SelectedRows(0)

            ' Fetch data from the selected row
            Dim rowData As New Dictionary(Of String, String)()
            For Each cell As DataGridViewCell In selectedRow.Cells
                rowData.Add(cell.OwningColumn.Name, cell.Value.ToString())
            Next

            ' Set the Shared Property
            SelectedRowData = rowData

        Else
            MessageBox.Show("Please select a row first.")
        End If
    End Sub
End Class