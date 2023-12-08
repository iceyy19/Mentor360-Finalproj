Imports System.Globalization
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI.Common

Public Class Supervisor_Dashboard
    Private Answerform As Supervisor_Answer_Form
    Public Resultform As Supervisor_Result
    Public Historyform As Supervisor_History
    Public ID As String = Login.ID
    Private Sub Supervisor_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Answerform = New Supervisor_Answer_Form()
        Resultform = New Supervisor_Result()
        Historyform = New Supervisor_History


        InitializeForm(Answerform)
        InitializeForm(Resultform)
        InitializeForm(Historyform)
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
    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswers.Click
        Resultform.Hide()
        Historyform.Hide()
        ShowForm(Answerform)
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Resultform.btnsubmit.Hide()
        Resultform.txtDiscussion.Enabled = False
        If Supervisor_History.SelectedRowData IsNot Nothing Then
            ' Create an instance of the ResultForm


            ' Set the SelectedRowData property from HistoryForm
            Resultform.SelectedRowData = Supervisor_History.SelectedRowData

            If Resultform.SelectedRowData IsNot Nothing Then
                Resultform.lblEmployeeID.Text = Resultform.SelectedRowData("dEmployeeID")
                Resultform.lblEmployeeName.Text = Resultform.SelectedRowData("dEmployeeName")
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
                Resultform.txtDiscussion.Text = Resultform.SelectedRowData("dDiscussion")

                Historyform.Time = Resultform.SelectedRowData("tEDateResponse").ToString()
                Dim parsedtime As DateTime
                DateTime.TryParse(Historyform.Time, parsedtime)

                Dim EmployeeID As String = Resultform.SelectedRowData("dEmployeeID")
                Using connection As MySqlConnection = Connector.getDBConnection()
                    connection.Open()

                    Dim query As String = $"SELECT dSupervisorID, dEmployeeID, tEDateResponse, dDiscussion FROM tblfeedback WHERE dSupervisorID = @SID and dEmployeeID = @EID and tEDateResponse = @Time"
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
                    dSupervisorID = @SID AND (dSl1 IS NOT NULL OR dSr1 IS NOT NULL);
            "
            Using command As New MySqlCommand(query, myConnection)
                ' Add parameters
                command.Parameters.AddWithValue("@SID", ID)

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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
            Login.Show()
        End If
    End Sub
End Class