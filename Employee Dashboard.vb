Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Employee_Dashboard
    Private Answerform As Employee_Answer_Form
    Public Resultform As Employee_Result
    Private Historyform As Employee_History
    Public ID As String = Login.ID
    Public eN As String
    Public sID As String
    Public sN As String
    Public mID As String
    Public mN As String
    Private Sub Employee_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Answerform = New Employee_Answer_Form()
        Resultform = New Employee_Result()
        Historyform = New Employee_History()

        InitializeForm(Answerform)
        InitializeForm(Resultform)
        InitializeForm(Historyform)

        Dim result As Tuple(Of String, String, String, String, String) = GetEmployeeData(ID)

        ' Access the data using the result variables
        eN = result.Item1
        sID = result.Item2
        sN = result.Item3
        mID = result.Item4
        mN = result.Item5

        lblEID.Text = ID
        lblEName.Text = eN
        lblSupervisor.Text = sN
        lblManager.Text = mN

        Resultform.lblEmployeeID.Text = ID
        Resultform.lblEmployeeName.Text = eN
        Resultform.lblManager.Text = mN
        Resultform.lblSupervisor.Text = sN

        Answerform.Show()
        Resultform.Show()
        Historyform.Show()
        Answerform.Hide()
        Resultform.Hide()
        Historyform.Hide()
        btnIndicatorHome.Show()
        btnIndicatorAnswer.Hide()
        btnIndicatorResult.Hide()
        btnIndicatorHistory.Hide()
        shLineHome.Show()
        shLineAnswer.Hide()
        shLineResult.Hide()
        shLineHistory.Hide()
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
        Historyform.Hide()

        form.Show()
        form.BringToFront()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Answerform.Hide()
        Resultform.Hide()
        Historyform.Hide()
        btnIndicatorHome.Show()
        btnIndicatorAnswer.Hide()
        btnIndicatorResult.Hide()
        btnIndicatorHistory.Hide()
        shLineHome.Show()
        shLineAnswer.Hide()
        shLineResult.Hide()
        shLineHistory.Hide()
    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        Answerform.eN = eN
        Answerform.sID = sID
        Answerform.sN = sN
        Answerform.mID = mID
        Answerform.mN = mN
        Resultform.Hide()
        Historyform.Hide()
        btnIndicatorHome.Hide()
        btnIndicatorAnswer.Show()
        btnIndicatorResult.Hide()
        btnIndicatorHistory.Hide()
        shLineHome.Hide()
        shLineAnswer.Show()
        shLineResult.Hide()
        shLineHistory.Hide()
        ShowForm(Answerform)
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Answerform.Hide()
        Historyform.Hide()
        btnIndicatorHome.Hide()
        btnIndicatorAnswer.Hide()
        btnIndicatorResult.Show()
        btnIndicatorHistory.Hide()
        shLineHome.Hide()
        shLineAnswer.Hide()
        shLineResult.Show()
        shLineHistory.Hide()
        ShowForm(Resultform)
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
                Resultform.txtDiscussion.Text = Resultform.SelectedRowData2("dDiscussion")
            End If

            Answerform.Hide()
            Historyform.Hide()
            ShowForm(Resultform)
        Else
            Answerform.Hide()
            Historyform.Hide()
            ShowForm(Resultform)
        End If
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Answerform.Hide()
        Resultform.Hide()
        btnIndicatorHome.Hide()
        btnIndicatorAnswer.Hide()
        btnIndicatorResult.Hide()
        btnIndicatorHistory.Show()
        shLineHome.Hide()
        shLineAnswer.Hide()
        shLineResult.Hide()
        shLineHistory.Show()
        ShowForm(Historyform)
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
                    dEmployeeID = @EID AND (dDiscussion IS NOT NULL OR dDiscussion = '');
            "
            Using command As New MySqlCommand(query, myConnection)
                ' Add parameters
                command.Parameters.AddWithValue("@EID", ID)

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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub Homepanel_Paint(sender As Object, e As PaintEventArgs) Handles Homepanel.Paint

    End Sub
End Class