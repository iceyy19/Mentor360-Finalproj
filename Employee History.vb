﻿Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms
Imports ClosedXML.Excel
Public Class Employee_History
    Public Shared Property SelectedRowData2 As Dictionary(Of String, String)
    Public Resultform As Employee_Result
    Public ID As String = Login.ID
    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgHistory.CellContentClick

    End Sub

    Private Sub Employee_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Resultform = Employee_Dashboard.Resultform

        InitializeForm(Resultform)
        lblEmployeeID.Text = ID
        lblEmployeeName.Text = Employee_Dashboard.eN
        lblSupervisor.Text = Employee_Dashboard.sN
        lblManager.Text = Employee_Dashboard.mN
    End Sub
    Private Sub InitializeForm(form As Form)
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.FixedDialog
        form.ControlBox = False
        form.Text = ""
        form.Hide()
        Employee_Dashboard.Homepanel.Controls.Add(form)
    End Sub
    Private Sub ShowForm(form As Form)

        form.Show()
        form.BringToFront()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If dgHistory.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = dgHistory.SelectedRows(0)

            ' Fetch data from the selected row
            Dim rowData As New Dictionary(Of String, String)()
            For Each cell As DataGridViewCell In selectedRow.Cells
                rowData.Add(cell.OwningColumn.Name, cell.Value.ToString())
            Next

            ' Set the Shared Property
            SelectedRowData2 = rowData
            MessageBox.Show("A row has been selected.")
            Me.Hide()
            loadRow()

        Else
            MessageBox.Show("Please select a row first.")
        End If

        Employee_Dashboard.btnIndicatorHome.Hide()
        Employee_Dashboard.btnIndicatorAnswer.Hide()
        Employee_Dashboard.btnIndicatorResult.Show()
        Employee_Dashboard.btnIndicatorHistory.Hide()
        Employee_Dashboard.shLineHome.Hide()
        Employee_Dashboard.shLineAnswer.Hide()
        Employee_Dashboard.shLineResult.Show()
        Employee_Dashboard.shLineHistory.Hide()
    End Sub

    Sub loadRow()
        Resultform.txtDiscussion.Enabled = False
        If Employee_History.SelectedRowData2 IsNot Nothing Then
            ' Create an instance of the ResultForm


            ' Set the SelectedRowData property from HistoryForm
            Resultform.SelectedRowData2 = Employee_History.SelectedRowData2

            If Resultform.SelectedRowData2 IsNot Nothing Then
                Resultform.lblSDS1.Text = Resultform.SelectedRowData2("dSl1")
                Resultform.lblSDS2.Text = Resultform.SelectedRowData2("dSl2")
                Resultform.lblSDS3.Text = Resultform.SelectedRowData2("dSl3")
                Resultform.lblSDS4.Text = Resultform.SelectedRowData2("dSl4")
                Resultform.lblSDS5.Text = Resultform.SelectedRowData2("dSl5")
                Resultform.lblSDS6.Text = Resultform.SelectedRowData2("dSl6")
                Resultform.lblSDS7.Text = Resultform.SelectedRowData2("dSl7")
                Resultform.lblSDS8.Text = Resultform.SelectedRowData2("dSl8")
                Resultform.lblSDS9.Text = Resultform.SelectedRowData2("dSl9")
                Resultform.lblSDS10.Text = Resultform.SelectedRowData2("dSl10")
                Resultform.lblSDS11.Text = Resultform.SelectedRowData2("dSl11")
                Resultform.lblSDS12.Text = Resultform.SelectedRowData2("dSl12")
                Resultform.lblSDS13.Text = Resultform.SelectedRowData2("dSl13")
                Resultform.lblSDS14.Text = Resultform.SelectedRowData2("dSl14")
                Resultform.lblSDS15.Text = Resultform.SelectedRowData2("dSl15")
                Resultform.lblSDAS1.Text = Resultform.SelectedRowData2("dSl16")
                Resultform.lblSDAS2.Text = Resultform.SelectedRowData2("dSl17")
                Resultform.lblPSS1.Text = Resultform.SelectedRowData2("dSl18")
                Resultform.lblDS1.Text = Resultform.SelectedRowData2("dSl19")
                Resultform.lblDS2.Text = Resultform.SelectedRowData2("dSl20")
                Resultform.lblCIS1.Text = Resultform.SelectedRowData2("dSl21")
                Resultform.lblCIS2.Text = Resultform.SelectedRowData2("dSl22")
                Resultform.lblCIS3.Text = Resultform.SelectedRowData2("dSl23")
                Resultform.lblCIS4.Text = Resultform.SelectedRowData2("dSl24")
                Resultform.lblCLS1.Text = Resultform.SelectedRowData2("dSl25")
                Resultform.lblCLS2.Text = Resultform.SelectedRowData2("dSl26")
                Resultform.lblCLS3.Text = Resultform.SelectedRowData2("dSl27")
                Resultform.lblPS1.Text = Resultform.SelectedRowData2("dSl28")
                Resultform.lblPS2.Text = Resultform.SelectedRowData2("dSl29")
                Resultform.lblPS3.Text = Resultform.SelectedRowData2("dSl30")
                Resultform.lblPS4.Text = Resultform.SelectedRowData2("dSl31")
                Resultform.lblPS5.Text = Resultform.SelectedRowData2("dSl32")
                Resultform.lblPS6.Text = Resultform.SelectedRowData2("dSl33")
                Resultform.lblPS7.Text = Resultform.SelectedRowData2("dSl34")


                Resultform.lblSDE1.Text = Resultform.SelectedRowData2("dEl1")
                Resultform.lblSDE2.Text = Resultform.SelectedRowData2("dEl2")
                Resultform.lblSDE3.Text = Resultform.SelectedRowData2("dEl3")
                Resultform.lblSDE4.Text = Resultform.SelectedRowData2("dEl4")
                Resultform.lblSDE5.Text = Resultform.SelectedRowData2("dEl5")
                Resultform.lblSDE6.Text = Resultform.SelectedRowData2("dEl6")
                Resultform.lblSDE7.Text = Resultform.SelectedRowData2("dEl7")
                Resultform.lblSDE8.Text = Resultform.SelectedRowData2("dEl8")
                Resultform.lblSDE9.Text = Resultform.SelectedRowData2("dEl9")
                Resultform.lblSDE10.Text = Resultform.SelectedRowData2("dEl10")
                Resultform.lblSDE11.Text = Resultform.SelectedRowData2("dEl11")
                Resultform.lblSDE12.Text = Resultform.SelectedRowData2("dEl12")
                Resultform.lblSDE13.Text = Resultform.SelectedRowData2("dEl13")
                Resultform.lblSDE14.Text = Resultform.SelectedRowData2("dEl14")
                Resultform.lblSDE15.Text = Resultform.SelectedRowData2("dEl15")
                Resultform.lblSDAE1.Text = Resultform.SelectedRowData2("dEl16")
                Resultform.lblSDAE2.Text = Resultform.SelectedRowData2("dEl17")
                Resultform.lblPSE1.Text = Resultform.SelectedRowData2("dEl18")
                Resultform.lblDE1.Text = Resultform.SelectedRowData2("dEl19")
                Resultform.lblDE2.Text = Resultform.SelectedRowData2("dEl20")
                Resultform.lblCIE1.Text = Resultform.SelectedRowData2("dEl21")
                Resultform.lblCIE2.Text = Resultform.SelectedRowData2("dEl22")
                Resultform.lblCIE3.Text = Resultform.SelectedRowData2("dEl23")
                Resultform.lblCIE4.Text = Resultform.SelectedRowData2("dEl24")
                Resultform.lblCLE1.Text = Resultform.SelectedRowData2("dEl25")
                Resultform.lblCLE2.Text = Resultform.SelectedRowData2("dEl26")
                Resultform.lblCLE3.Text = Resultform.SelectedRowData2("dEl27")
                Resultform.lblPE1.Text = Resultform.SelectedRowData2("dEl28")
                Resultform.lblPE2.Text = Resultform.SelectedRowData2("dEl29")
                Resultform.lblPE3.Text = Resultform.SelectedRowData2("dEl30")
                Resultform.lblPE4.Text = Resultform.SelectedRowData2("dEl31")
                Resultform.lblPE5.Text = Resultform.SelectedRowData2("dEl32")
                Resultform.lblPE6.Text = Resultform.SelectedRowData2("dEl33")
                Resultform.lblPE7.Text = Resultform.SelectedRowData2("dEl34")

                Resultform.txtSDE1.Text = Resultform.SelectedRowData2("dEr1")
                Resultform.txtSDAE1.Text = Resultform.SelectedRowData2("dEr2")
                Resultform.txtPSE1.Text = Resultform.SelectedRowData2("dEr3")
                Resultform.txtDE1.Text = Resultform.SelectedRowData2("dEr4")
                Resultform.txtCIE1.Text = Resultform.SelectedRowData2("dEr5")
                Resultform.txtCLE1.Text = Resultform.SelectedRowData2("dEr6")
                Resultform.txtPE1.Text = Resultform.SelectedRowData2("dEr7")

                Resultform.txtSDS1.Text = Resultform.SelectedRowData2("dSr1")
                Resultform.txtSDAS1.Text = Resultform.SelectedRowData2("dSr2")
                Resultform.txtPSS1.Text = Resultform.SelectedRowData2("dSr3")
                Resultform.txtDS1.Text = Resultform.SelectedRowData2("dSr4")
                Resultform.txtCIS1.Text = Resultform.SelectedRowData2("dSr5")
                Resultform.txtCLS1.Text = Resultform.SelectedRowData2("dSr6")
                Resultform.txtPS1.Text = Resultform.SelectedRowData2("dSr7")

                Resultform.lblERating.Text = Resultform.SelectedRowData2("Employee Rating")
                Resultform.lblSRating.Text = Resultform.SelectedRowData2("Supervisor Rating")
                Resultform.txtDiscussion.Text = Resultform.SelectedRowData2("Discussion")
                ' ... (Repeat for other columns)
            End If

            ShowForm(Resultform)
        Else
            Try

            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try

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