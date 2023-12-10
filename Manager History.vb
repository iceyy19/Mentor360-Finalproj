﻿Public Class Manager_History
    Public Resultform As Manager_Results
    Public ID As String = Login.ID
    Public Shared Property SelectedRowData3 As Dictionary(Of String, String)
    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgHistory.CellContentClick

    End Sub

    Private Sub Manager_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Resultform = Manager_Dashboard.Resultform

        InitializeForm(Resultform)
    End Sub
    Private Sub InitializeForm(form As Form)
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.FixedDialog
        form.ControlBox = False
        form.Text = ""
        form.Hide()
        Manager_Dashboard.Homepanel.Controls.Add(form)
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
            SelectedRowData3 = rowData
            MessageBox.Show("A row has been selected.")
            Me.Hide()
            loadRow()

        Else
            MessageBox.Show("Please select a row first.")
        End If

        Manager_Dashboard.btnIndicatorHome.Hide()
        Manager_Dashboard.btnIndicatorResult.Show()
        Manager_Dashboard.btnIndicatorHistory.Hide()
        Manager_Dashboard.btnIndicatorEmployees.Hide()
        Manager_Dashboard.shLineHome.Hide()
        Manager_Dashboard.shLineResult.Show()
        Manager_Dashboard.shLineHistory.Hide()
        Manager_Dashboard.shLineEmployees.Hide()
    End Sub
    Sub loadRow()
        If Manager_History.SelectedRowData3 IsNot Nothing Then
            ' Create an instance of the ResultForm


            ' Set the SelectedRowData property from HistoryForm
            Resultform.SelectedRowData3 = Manager_History.SelectedRowData3

            If Resultform.SelectedRowData3 IsNot Nothing Then
                Resultform.lblEmployeeID.Text = Resultform.SelectedRowData3("dEmployeeID")
                Resultform.lblEmployeeName.Text = Resultform.SelectedRowData3("dEmployeeName")
                Resultform.lblSupervisorID.Text = Resultform.SelectedRowData3("dSupervisorID")
                Resultform.lblSupervisorName.Text = Resultform.SelectedRowData3("dSupervisorName")

                Resultform.lblSDS1.Text = Resultform.SelectedRowData3("dSl1")
                Resultform.lblSDS2.Text = Resultform.SelectedRowData3("dSl2")
                Resultform.lblSDS3.Text = Resultform.SelectedRowData3("dSl3")
                Resultform.lblSDS4.Text = Resultform.SelectedRowData3("dSl4")
                Resultform.lblSDS5.Text = Resultform.SelectedRowData3("dSl5")
                Resultform.lblSDS6.Text = Resultform.SelectedRowData3("dSl6")
                Resultform.lblSDS7.Text = Resultform.SelectedRowData3("dSl7")
                Resultform.lblSDS8.Text = Resultform.SelectedRowData3("dSl8")
                Resultform.lblSDS9.Text = Resultform.SelectedRowData3("dSl9")
                Resultform.lblSDS10.Text = Resultform.SelectedRowData3("dSl10")
                Resultform.lblSDS11.Text = Resultform.SelectedRowData3("dSl11")
                Resultform.lblSDS12.Text = Resultform.SelectedRowData3("dSl12")
                Resultform.lblSDS13.Text = Resultform.SelectedRowData3("dSl13")
                Resultform.lblSDS14.Text = Resultform.SelectedRowData3("dSl14")
                Resultform.lblSDS15.Text = Resultform.SelectedRowData3("dSl15")
                Resultform.lblSDAS1.Text = Resultform.SelectedRowData3("dSl16")
                Resultform.lblSDAS2.Text = Resultform.SelectedRowData3("dSl17")
                Resultform.lblPSS1.Text = Resultform.SelectedRowData3("dSl18")
                Resultform.lblDS1.Text = Resultform.SelectedRowData3("dSl19")
                Resultform.lblDS2.Text = Resultform.SelectedRowData3("dSl20")
                Resultform.lblCIS1.Text = Resultform.SelectedRowData3("dSl21")
                Resultform.lblCIS2.Text = Resultform.SelectedRowData3("dSl22")
                Resultform.lblCIS3.Text = Resultform.SelectedRowData3("dSl23")
                Resultform.lblCIS4.Text = Resultform.SelectedRowData3("dSl24")
                Resultform.lblCLS1.Text = Resultform.SelectedRowData3("dSl25")
                Resultform.lblCLS2.Text = Resultform.SelectedRowData3("dSl26")
                Resultform.lblCLS3.Text = Resultform.SelectedRowData3("dSl27")
                Resultform.lblPS1.Text = Resultform.SelectedRowData3("dSl28")
                Resultform.lblPS2.Text = Resultform.SelectedRowData3("dSl29")
                Resultform.lblPS3.Text = Resultform.SelectedRowData3("dSl30")
                Resultform.lblPS4.Text = Resultform.SelectedRowData3("dSl31")
                Resultform.lblPS5.Text = Resultform.SelectedRowData3("dSl32")
                Resultform.lblPS6.Text = Resultform.SelectedRowData3("dSl33")
                Resultform.lblPS7.Text = Resultform.SelectedRowData3("dSl34")

                Resultform.lblSDE1.Text = Resultform.SelectedRowData3("dEl1")
                Resultform.lblSDE2.Text = Resultform.SelectedRowData3("dEl2")
                Resultform.lblSDE3.Text = Resultform.SelectedRowData3("dEl3")
                Resultform.lblSDE4.Text = Resultform.SelectedRowData3("dEl4")
                Resultform.lblSDE5.Text = Resultform.SelectedRowData3("dEl5")
                Resultform.lblSDE6.Text = Resultform.SelectedRowData3("dEl6")
                Resultform.lblSDE7.Text = Resultform.SelectedRowData3("dEl7")
                Resultform.lblSDE8.Text = Resultform.SelectedRowData3("dEl8")
                Resultform.lblSDE9.Text = Resultform.SelectedRowData3("dEl9")
                Resultform.lblSDE10.Text = Resultform.SelectedRowData3("dEl10")
                Resultform.lblSDE11.Text = Resultform.SelectedRowData3("dEl11")
                Resultform.lblSDE12.Text = Resultform.SelectedRowData3("dEl12")
                Resultform.lblSDE13.Text = Resultform.SelectedRowData3("dEl13")
                Resultform.lblSDE14.Text = Resultform.SelectedRowData3("dEl14")
                Resultform.lblSDE15.Text = Resultform.SelectedRowData3("dEl15")
                Resultform.lblSDAE1.Text = Resultform.SelectedRowData3("dEl16")
                Resultform.lblSDAE2.Text = Resultform.SelectedRowData3("dEl17")
                Resultform.lblPSE1.Text = Resultform.SelectedRowData3("dEl18")
                Resultform.lblDE1.Text = Resultform.SelectedRowData3("dEl19")
                Resultform.lblDE2.Text = Resultform.SelectedRowData3("dEl20")
                Resultform.lblCIE1.Text = Resultform.SelectedRowData3("dEl21")
                Resultform.lblCIE2.Text = Resultform.SelectedRowData3("dEl22")
                Resultform.lblCIE3.Text = Resultform.SelectedRowData3("dEl23")
                Resultform.lblCIE4.Text = Resultform.SelectedRowData3("dEl24")
                Resultform.lblCLE1.Text = Resultform.SelectedRowData3("dEl25")
                Resultform.lblCLE2.Text = Resultform.SelectedRowData3("dEl26")
                Resultform.lblCLE3.Text = Resultform.SelectedRowData3("dEl27")
                Resultform.lblPE1.Text = Resultform.SelectedRowData3("dEl28")
                Resultform.lblPE2.Text = Resultform.SelectedRowData3("dEl29")
                Resultform.lblPE3.Text = Resultform.SelectedRowData3("dEl30")
                Resultform.lblPE4.Text = Resultform.SelectedRowData3("dEl31")
                Resultform.lblPE5.Text = Resultform.SelectedRowData3("dEl32")
                Resultform.lblPE6.Text = Resultform.SelectedRowData3("dEl33")
                Resultform.lblPE7.Text = Resultform.SelectedRowData3("dEl34")

                Resultform.txtSDE1.Text = Resultform.SelectedRowData3("dEr1")
                Resultform.txtSDAE1.Text = Resultform.SelectedRowData3("dEr2")
                Resultform.txtPSE1.Text = Resultform.SelectedRowData3("dEr3")
                Resultform.txtDE1.Text = Resultform.SelectedRowData3("dEr4")
                Resultform.txtCIE1.Text = Resultform.SelectedRowData3("dEr5")
                Resultform.txtCLE1.Text = Resultform.SelectedRowData3("dEr6")
                Resultform.txtPE1.Text = Resultform.SelectedRowData3("dEr7")

                Resultform.txtSDS1.Text = Resultform.SelectedRowData3("dSr1")
                Resultform.txtSDAS1.Text = Resultform.SelectedRowData3("dSr2")
                Resultform.txtPSS1.Text = Resultform.SelectedRowData3("dSr3")
                Resultform.txtDS1.Text = Resultform.SelectedRowData3("dSr4")
                Resultform.txtCIS1.Text = Resultform.SelectedRowData3("dSr5")
                Resultform.txtCLS1.Text = Resultform.SelectedRowData3("dSr6")
                Resultform.txtPS1.Text = Resultform.SelectedRowData3("dSr7")
                Resultform.txtDiscussion.Text = Resultform.SelectedRowData3("dDiscussion")
                Resultform.lblERating.Text = Resultform.SelectedRowData3("dERating")
                Resultform.lblSRating.Text = Resultform.SelectedRowData3("dSRating")
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
End Class