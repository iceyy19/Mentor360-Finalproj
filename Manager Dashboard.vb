Imports System.Net
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1

Public Class Manager_Dashboard
    Public Resultform As Manager_Results
    Public Historyform As Manager_History
    Private Employeesform As Manager_Employee
    Public ID As String = Login.ID
    Public Mname As String

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Employeesform.Hide()
        Resultform.Hide()
        Historyform.Hide()
        btnIndicatorHome.Show()
        btnIndicatorResult.Hide()
        btnIndicatorHistory.Hide()
        btnIndicatorEmployees.Hide()
        shLineHome.Show()
        shLineResult.Hide()
        shLineHistory.Hide()
        shLineEmployees.Hide()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Resultform.Hide()
        Employeesform.Hide()
        btnIndicatorHome.Hide()
        btnIndicatorResult.Hide()
        btnIndicatorHistory.Show()
        btnIndicatorEmployees.Hide()
        shLineHome.Hide()
        shLineResult.Hide()
        shLineHistory.Show()
        shLineEmployees.Hide()
        ShowForm(Historyform)
        Dim myConnection As MySqlConnection
        myConnection = Connector.getDBConnection()

        Try
            ' Open the connection
            myConnection.Open()

            ' SQL query
            Dim query As String = "
                SELECT
                    dEmployeeID AS 'Employee ID',
                    dEmployeeName AS 'Employee Name',
                    dSupervisorID AS 'Supervisor ID',
                    dSupervisorName AS 'Supervisor Name',
                    dManagerID AS 'Manager ID',
                    dManagerName AS 'Manager Name',
                    dEl1, dEl2, dEl3, dEl4, dEl5, dEl6, dEl7, dEl8, dEl9, dEl10,
                    dEl11, dEl12, dEl13, dEl14, dEl15, dEl16, dEl17, dEl18, dEl19, dEl20,
                    dEl21, dEl22, dEl23, dEl24, dEl25, dEl26, dEl27, dEl28, dEl29, dEl30,
                    dEl31, dEl32, dEl33, dEl34,
                    dEr1, dEr2, dEr3, dEr4, dEr5, dEr6, dEr7,
                    tEDateResponse AS 'Employee Date Response',
                    dSl1, dSl2, dSl3, dSl4, dSl5, dSl6, dSl7, dSl8, dSl9, dSl10,
                    dSl11, dSl12, dSl13, dSl14, dSl15, dSl16, dSl17, dSl18, dSl19, dSl20,
                    dSl21, dSl22, dSl23, dSl24, dSl25, dSl26, dSl27, dSl28, dSl29, dSl30,
                    dSl31, dSl32, dSl33, dSl34,
                    dSr1, dSr2, dSr3, dSr4, dSr5, dSr6, dSr7,
                    tSDateResponse AS 'Supervisor Date Response',
                    dERating AS 'Employee Rating',
                    dSRating AS 'Supervisor Rating',
                    dDiscussion AS 'Discussion'
                FROM
                    tblfeedback
                WHERE
                    dManagerID = @MID;
            "
            Using command As New MySqlCommand(query, myConnection)
                ' Add parameters
                command.Parameters.AddWithValue("@MID", ID)

                ' Create a MySqlDataAdapter and DataTable
                Dim myDataAdapter As New MySqlDataAdapter(command)
                Dim dataTable As New DataTable()

                ' Fill the DataTable with data from the database
                myDataAdapter.Fill(dataTable)

                ' Set up BindingSource
                Dim bindingSource As New BindingSource()
                bindingSource.DataSource = dataTable

                ' Set up DataGridView
                Historyform.dgHistory.DataSource = bindingSource
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            myConnection.Close()
        End Try
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Historyform.Hide()
        Employeesform.Hide()
        btnIndicatorHome.Hide()
        btnIndicatorResult.Show()
        btnIndicatorHistory.Hide()
        btnIndicatorEmployees.Hide()
        shLineHome.Hide()
        shLineResult.Show()
        shLineHistory.Hide()
        shLineEmployees.Hide()
        ShowForm(Resultform)
        loadRow()
    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        Resultform.Hide()
        Historyform.Hide()
        btnIndicatorHome.Hide()
        btnIndicatorResult.Hide()
        btnIndicatorHistory.Hide()
        btnIndicatorEmployees.Show()
        shLineHome.Hide()
        shLineResult.Hide()
        shLineHistory.Hide()
        shLineEmployees.Show()
        ShowForm(Employeesform)

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
                    dSupervisorName
                FROM
                    tblhierarchy
                WHERE
                    dManagerID = @MID;
            "
            Using command As New MySqlCommand(query, myConnection)
                ' Add parameters
                command.Parameters.AddWithValue("@MID", ID)

                ' Create a MySqlDataAdapter and DataTable
                Dim myDataAdapter As New MySqlDataAdapter(command)
                Dim dataTable As New DataTable()

                ' Fill the DataTable with data from the database
                myDataAdapter.Fill(dataTable)

                ' Set up BindingSource
                Dim bindingSource As New BindingSource()
                bindingSource.DataSource = dataTable

                ' Set up DataGridView
                Employeesform.dgManagerEmployee.DataSource = bindingSource
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            myConnection.Close()
        End Try
    End Sub

    Private Sub Manager_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Employeesform = New Manager_Employee()
        Resultform = New Manager_Results()
        Historyform = New Manager_History()

        InitializeForm(Employeesform)
        InitializeForm(Resultform)
        InitializeForm(Historyform)
        Dim sqlQuery As String = "SELECT dManagerName FROM tblhierarchy WHERE dManagerID = @ID"

        Using connection As MySqlConnection = Connector.getDBConnection()
            ' Create a MySqlCommand
            Using command As New MySqlCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@ID", ID) ' Replace YourManagerID with the actual manager ID
                ' Open the connection
                connection.Open()

                ' Execute the query
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Check if there are rows
                    If reader.HasRows Then
                        ' Read the first row
                        reader.Read()

                        ' Retrieve values and store in variables
                        Mname = reader("dManagerName").ToString()

                    Else
                        Console.WriteLine("No data found for the specified Supervisor ID.")
                    End If
                End Using
            End Using
        End Using

        lblManager.Text = ID & " - " & Mname
        Employeesform.lblManagerID.Text = ID
        Employeesform.lblManagerName.Text = Mname
        Resultform.lblManagerID.Text = ID
        Resultform.lblManagerName.Text = Mname
        Historyform.lblManagerID.Text = ID
        Historyform.lblManagerName.Text = Mname

        Resultform.Show()
        Historyform.Show()
        Employeesform.Show()
        Resultform.Hide()
        Historyform.Hide()
        Employeesform.Hide()
        btnIndicatorHome.Show()
        btnIndicatorResult.Hide()
        btnIndicatorHistory.Hide()
        btnIndicatorEmployees.Hide()
        shLineHome.Show()
        shLineResult.Hide()
        shLineHistory.Hide()
        shLineEmployees.Hide()
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
        Employeesform.Hide()
        Resultform.Hide()
        Historyform.Hide()

        form.Show()
        form.BringToFront()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
            Login.Show()
        End If
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
                Resultform.lblSRating.Text = Resultform.SelectedRowData3("dSRating")
                Resultform.lblERating.Text = Resultform.SelectedRowData3("dERating")

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