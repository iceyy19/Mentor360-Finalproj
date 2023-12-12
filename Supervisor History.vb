Imports System.Globalization
Imports ClosedXML.Excel
Imports MySql.Data.MySqlClient

Public Class Supervisor_History
    Public Resultform As Supervisor_Result
    Public ID As String = Login.ID
    Public Time As String
    Public Shared parsedtime As DateTime
    Public Shared Property SelectedRowData As Dictionary(Of String, String)
    Private Sub Supervisor_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSupervisorID.Text = ID
        lblSupervisorName.Text = Supervisor_Dashboard.Sname
        lblManager.Text = Supervisor_Dashboard.Mname
        Resultform = Supervisor_Dashboard.Resultform

        InitializeForm(Resultform)
    End Sub
    Private Sub InitializeForm(form As Form)
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.FixedDialog
        form.ControlBox = False
        form.Text = ""
        form.Hide()
        Supervisor_Dashboard.Homepanel.Controls.Add(form)
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
            MessageBox.Show("A row has been selected.")
            Me.Hide()
            loadRow()

        Else
            MessageBox.Show("Please select a row first.")
        End If

        Supervisor_Dashboard.btnIndicatorHome.Hide()
        Supervisor_Dashboard.btnIndicatorAnswer.Hide()
        Supervisor_Dashboard.btnIndicatorResult.Show()
        Supervisor_Dashboard.btnIndicatorHistory.Hide()
        Supervisor_Dashboard.btnIndicatorEmployees.Hide()
        Supervisor_Dashboard.shLineHome.Hide()
        Supervisor_Dashboard.shLineAnswer.Hide()
        Supervisor_Dashboard.shLineResult.Show()
        Supervisor_Dashboard.shLineHistory.Hide()
        Supervisor_Dashboard.shLineEmployees.Hide()
    End Sub
    Private Sub ShowForm(form As Form)

        form.Show()
        form.BringToFront()
    End Sub

    Sub loadRow()
        Resultform.btnsubmit.Hide()
        Resultform.txtDiscussion.Enabled = False
        If Supervisor_History.SelectedRowData IsNot Nothing Then
            ' Create an instance of the ResultForm


            ' Set the SelectedRowData property from HistoryForm
            Resultform.SelectedRowData = Supervisor_History.SelectedRowData

            If Resultform.SelectedRowData IsNot Nothing Then
                Time = Resultform.SelectedRowData("tEDateResponse").ToString()

                If DateTime.TryParse(Time, parsedtime) Then

                Else

                End If
                Dim EmployeeID As String = Resultform.SelectedRowData("Employee ID")
                Using connection As MySqlConnection = Connector.getDBConnection()
                    connection.Open()

                    Dim query As String = $"SELECT dSupervisorID, dEmployeeID, tEDateResponse, dDiscussion FROM tblfeedback WHERE dSupervisorID = @SID and dEmployeeID = @EID and tEDateResponse = @Time ORDER BY tEDateResponse DESC"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@SID", ID)
                        command.Parameters.AddWithValue("@EID", EmployeeID)
                        command.Parameters.AddWithValue("@Time", parsedtime)

                        Using reader As MySqlDataReader = command.ExecuteReader()
                            If reader.Read() Then ' Check if there is at least one record
                                Dim dDiscussion As String = Convert.ToString(reader("dDiscussion"))
                                If String.IsNullOrEmpty(dDiscussion) Then
                                    Resultform.time = parsedtime.ToString()
                                    Resultform.txtDiscussion.Enabled = True
                                    Resultform.btnsubmit.Show()
                                Else
                                    Resultform.txtDiscussion.Enabled = False
                                End If
                            End If
                        End Using
                    End Using
                End Using
                Resultform.lblEmployeeID.Text = Resultform.SelectedRowData("Employee ID")
                Resultform.lblEmployeeName.Text = Resultform.SelectedRowData("Employee Name")
                Resultform.lblSupervisorID.Text = Resultform.SelectedRowData("Supervisor ID")
                Resultform.lblSupervisorName.Text = Resultform.SelectedRowData("Supervisor Name")
                Resultform.lblManager.Text = Resultform.SelectedRowData("Manager Name")
                Resultform.lblSDS1.Text = Resultform.SelectedRowData("dSl1")
                Resultform.lblSDS2.Text = Resultform.SelectedRowData("dSl2")
                Resultform.lblSDS3.Text = Resultform.SelectedRowData("dSl3")
                Resultform.lblSDS4.Text = Resultform.SelectedRowData("dSl4")
                Resultform.lblSDS5.Text = Resultform.SelectedRowData("dSl5")
                Resultform.lblSDS6.Text = Resultform.SelectedRowData("dSl6")
                Resultform.lblSDS7.Text = Resultform.SelectedRowData("dSl7")
                Resultform.lblSDS8.Text = Resultform.SelectedRowData("dSl8")
                Resultform.lblSDS9.Text = Resultform.SelectedRowData("dSl9")
                Resultform.lblSDS10.Text = Resultform.SelectedRowData("dSl10")
                Resultform.lblSDS11.Text = Resultform.SelectedRowData("dSl11")
                Resultform.lblSDS12.Text = Resultform.SelectedRowData("dSl12")
                Resultform.lblSDS13.Text = Resultform.SelectedRowData("dSl13")
                Resultform.lblSDS14.Text = Resultform.SelectedRowData("dSl14")
                Resultform.lblSDS15.Text = Resultform.SelectedRowData("dSl15")
                Resultform.lblSDAS1.Text = Resultform.SelectedRowData("dSl16")
                Resultform.lblSDAS2.Text = Resultform.SelectedRowData("dSl17")
                Resultform.lblPSS1.Text = Resultform.SelectedRowData("dSl18")
                Resultform.lblDS1.Text = Resultform.SelectedRowData("dSl19")
                Resultform.lblDS2.Text = Resultform.SelectedRowData("dSl20")
                Resultform.lblCIS1.Text = Resultform.SelectedRowData("dSl21")
                Resultform.lblCIS2.Text = Resultform.SelectedRowData("dSl22")
                Resultform.lblCIS3.Text = Resultform.SelectedRowData("dSl23")
                Resultform.lblCIS4.Text = Resultform.SelectedRowData("dSl24")
                Resultform.lblCLS1.Text = Resultform.SelectedRowData("dSl25")
                Resultform.lblCLS2.Text = Resultform.SelectedRowData("dSl26")
                Resultform.lblCLS3.Text = Resultform.SelectedRowData("dSl27")
                Resultform.lblPS1.Text = Resultform.SelectedRowData("dSl28")
                Resultform.lblPS2.Text = Resultform.SelectedRowData("dSl29")
                Resultform.lblPS3.Text = Resultform.SelectedRowData("dSl30")
                Resultform.lblPS4.Text = Resultform.SelectedRowData("dSl31")
                Resultform.lblPS5.Text = Resultform.SelectedRowData("dSl32")
                Resultform.lblPS6.Text = Resultform.SelectedRowData("dSl33")
                Resultform.lblPS7.Text = Resultform.SelectedRowData("dSl34")


                Resultform.lblSDE1.Text = Resultform.SelectedRowData("dEl1")
                Resultform.lblSDE2.Text = Resultform.SelectedRowData("dEl2")
                Resultform.lblSDE3.Text = Resultform.SelectedRowData("dEl3")
                Resultform.lblSDE4.Text = Resultform.SelectedRowData("dEl4")
                Resultform.lblSDE5.Text = Resultform.SelectedRowData("dEl5")
                Resultform.lblSDE6.Text = Resultform.SelectedRowData("dEl6")
                Resultform.lblSDE7.Text = Resultform.SelectedRowData("dEl7")
                Resultform.lblSDE8.Text = Resultform.SelectedRowData("dEl8")
                Resultform.lblSDE9.Text = Resultform.SelectedRowData("dEl9")
                Resultform.lblSDE10.Text = Resultform.SelectedRowData("dEl10")
                Resultform.lblSDE11.Text = Resultform.SelectedRowData("dEl11")
                Resultform.lblSDE12.Text = Resultform.SelectedRowData("dEl12")
                Resultform.lblSDE13.Text = Resultform.SelectedRowData("dEl13")
                Resultform.lblSDE14.Text = Resultform.SelectedRowData("dEl14")
                Resultform.lblSDE15.Text = Resultform.SelectedRowData("dEl15")
                Resultform.lblSDAE1.Text = Resultform.SelectedRowData("dEl16")
                Resultform.lblSDAE2.Text = Resultform.SelectedRowData("dEl17")
                Resultform.lblPSE1.Text = Resultform.SelectedRowData("dEl18")
                Resultform.lblDE1.Text = Resultform.SelectedRowData("dEl19")
                Resultform.lblDE2.Text = Resultform.SelectedRowData("dEl20")
                Resultform.lblCIE1.Text = Resultform.SelectedRowData("dEl21")
                Resultform.lblCIE2.Text = Resultform.SelectedRowData("dEl22")
                Resultform.lblCIE3.Text = Resultform.SelectedRowData("dEl23")
                Resultform.lblCIE4.Text = Resultform.SelectedRowData("dEl24")
                Resultform.lblCLE1.Text = Resultform.SelectedRowData("dEl25")
                Resultform.lblCLE2.Text = Resultform.SelectedRowData("dEl26")
                Resultform.lblCLE3.Text = Resultform.SelectedRowData("dEl27")
                Resultform.lblPE1.Text = Resultform.SelectedRowData("dEl28")
                Resultform.lblPE2.Text = Resultform.SelectedRowData("dEl29")
                Resultform.lblPE3.Text = Resultform.SelectedRowData("dEl30")
                Resultform.lblPE4.Text = Resultform.SelectedRowData("dEl31")
                Resultform.lblPE5.Text = Resultform.SelectedRowData("dEl32")
                Resultform.lblPE6.Text = Resultform.SelectedRowData("dEl33")
                Resultform.lblPE7.Text = Resultform.SelectedRowData("dEl34")

                Resultform.txtSDE1.Text = Resultform.SelectedRowData("dEr1")
                Resultform.txtSDAE1.Text = Resultform.SelectedRowData("dEr2")
                Resultform.txtPSE1.Text = Resultform.SelectedRowData("dEr3")
                Resultform.txtDE1.Text = Resultform.SelectedRowData("dEr4")
                Resultform.txtCIE1.Text = Resultform.SelectedRowData("dEr5")
                Resultform.txtCLE1.Text = Resultform.SelectedRowData("dEr6")
                Resultform.txtPE1.Text = Resultform.SelectedRowData("dEr7")

                Resultform.txtSDS1.Text = Resultform.SelectedRowData("dSr1")
                Resultform.txtSDAS1.Text = Resultform.SelectedRowData("dSr2")
                Resultform.txtPSS1.Text = Resultform.SelectedRowData("dSr3")
                Resultform.txtDS1.Text = Resultform.SelectedRowData("dSr4")
                Resultform.txtCIS1.Text = Resultform.SelectedRowData("dSr5")
                Resultform.txtCLS1.Text = Resultform.SelectedRowData("dSr6")
                Resultform.txtPS1.Text = Resultform.SelectedRowData("dSr7")
                Resultform.lblERating.Text = Resultform.SelectedRowData("Employee Rating")
                Resultform.lblSRating.Text = Resultform.SelectedRowData("Supervisor Rating")
                Resultform.txtDiscussion.Text = Resultform.SelectedRowData("Discussion")
            End If

            ShowForm(Resultform)
        Else

            MessageBox.Show("There is an error! Please contact the Admin.")
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            ' Check if the DataGridView has any rows
            If dgHistory.Rows.Count > 0 Then
                ' Create a DataTable to store DataGridView data
                Dim dataTable As New DataTable()

                ' Add columns to the DataTable based on DataGridView columns
                For Each column As DataGridViewColumn In dgHistory.Columns
                    dataTable.Columns.Add(column.HeaderText, column.ValueType)
                Next

                ' Add rows to the DataTable based on DataGridView rows
                For Each row As DataGridViewRow In dgHistory.Rows
                    Dim dataRow As DataRow = dataTable.NewRow()

                    For Each cell As DataGridViewCell In row.Cells
                        dataRow(cell.ColumnIndex) = cell.Value
                    Next

                    dataTable.Rows.Add(dataRow)
                Next

                ' Create a SaveFileDialog to choose the location and name of the Excel file
                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Excel Workbook|*.xlsx"
                saveFileDialog.Title = "Save Excel File"
                saveFileDialog.ShowDialog()

                ' Check if a file name is selected
                If saveFileDialog.FileName <> "" Then
                    ' Export the DataTable to an Excel file
                    ExportDataTableToExcel(dataTable, saveFileDialog.FileName)
                    MessageBox.Show("Export successful!")
                End If
            Else
                MessageBox.Show("No data to export.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub
    Private Sub ExportDataTableToExcel(dataTable As DataTable, filePath As String)
        Using workbook As New XLWorkbook()
            ' Add a worksheet
            Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Sheet1")

            ' Add the DataTable to the worksheet starting from cell A1
            worksheet.Cell(1, 1).InsertTable(dataTable)

            ' Save the workbook to the specified file path
            workbook.SaveAs(filePath)
        End Using
    End Sub
End Class