Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities
Imports System.Text
Imports Mysqlx.XDevAPI.Common
Imports Mysqlx
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Admin_Dashboard
    Public ID As String = Login.ID
    Public Nname As String = Login.Nname
    Public AdminLogs As Admin_Logs
    Public EmployeeLogs As Employee_Logs
    Public EmployeeList As Employee_List

    Private Sub InitializeForm(form As Form)
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.FixedDialog
        form.ControlBox = False
        form.Text = ""
        form.Hide()
        Homepanel.Controls.Add(form)
    End Sub

    Private Sub ShowForm(form As Form)
        AdminLogs.Hide()
        EmployeeLogs.Hide()
        EmployeeList.Hide()

        form.Show()
        form.BringToFront()
    End Sub
    Dim dataTable As New DataTable()
    Private Sub Admin_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminLogs = New Admin_Logs
        EmployeeLogs = New Employee_Logs
        EmployeeList = New Employee_List

        InitializeForm(AdminLogs)
        InitializeForm(EmployeeLogs)
        InitializeForm(EmployeeList)

        EmployeeList.Show()
        EmployeeLogs.Show()
        AdminLogs.Show()
        EmployeeList.Hide()
        EmployeeLogs.Hide()
        AdminLogs.Hide()
        pIndicatorAdd.Hide()
        pIndicatorEdit.Hide()
        pIndicatorRemove.Hide()
        pIndicatorSave.Hide()
        btnIndicatorHome.Show()
        btnIndicatorALogs.Hide()
        btnIndicatorELogs.Hide()
        btnIndicatorEList.Hide()
        shLineHome.Show()
        shLineALogs.Hide()
        shLineELogs.Hide()
        shLineEList.Hide()
        dghierarchy.DataSource = dataTable
        viewHierarchy()
        txtEId.Enabled = False
        txtEName.Enabled = False
        txtSId.Enabled = False
        txtSName.Enabled = False
        txtMId.Enabled = False
        txtMName.Enabled = False
        btnEdit.Enabled = False
        btnRemove.Enabled = False
        btnSave.Enabled = False
        Dim timer As New Timer()
        timer.Interval = 1 ' Set the delay in milliseconds
        AddHandler timer.Tick, Sub()
                                   ' Set ActiveControl to Nothing to prevent auto selection
                                   Me.ActiveControl = Nothing
                                   timer.Stop()
                               End Sub
        timer.Start()
        dghierarchy.ColumnHeadersVisible = True
        lblID.Text = ID
        lblName.Text = Nname
        For Each textBox As Guna2TextBox In {txtEId, txtEName, txtSId, txtSName, txtMId, txtMName}
            textBox.Tag = textBox.Text
        Next

        For Each textBox As Guna2TextBox In {txtEId, txtEName, txtSId, txtSName, txtMId, txtMName}
            textBox.BorderRadius = "7"
        Next
    End Sub
    Private Sub GunaTextBox_GotFocus(sender As Object, e As EventArgs) Handles txtEId.GotFocus, txtEName.GotFocus, txtSId.GotFocus, txtSName.GotFocus, txtMId.GotFocus, txtMName.GotFocus
        HandleGunaTextBoxFocus(DirectCast(sender, Guna2TextBox), Color.DimGray)
    End Sub

    Private Sub GunaTextBox_LostFocus(sender As Object, e As EventArgs) Handles txtEId.LostFocus, txtEName.LostFocus, txtSId.LostFocus, txtSName.LostFocus, txtMId.LostFocus, txtMName.LostFocus
        HandleGunaTextBoxLostFocus(DirectCast(sender, Guna2TextBox), Color.DarkGray)
    End Sub

    Private Sub HandleGunaTextBoxFocus(textBox As Guna2TextBox, textColor As Color)
        If textBox.Text = textBox.Tag Then
            textBox.Text = ""
            textBox.ForeColor = textColor
        End If
    End Sub

    Private Sub HandleGunaTextBoxLostFocus(textBox As Guna2TextBox, placeholderColor As Color)
        If String.IsNullOrWhiteSpace(textBox.Text) Then
            textBox.Text = textBox.Tag
            textBox.ForeColor = placeholderColor
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs)
        Clear()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dghierarchy.CellContentClick

    End Sub
    Sub insertEmployee()
        Dim myConnectionx As MySqlConnection
        Dim myCommandx As MySqlCommand

        myConnectionx = Connector.getDBConnection()

        Try

            myConnectionx.Open()
            myCommandx = New MySqlCommand($"INSERT INTO tblhierarchy (dEmployeeID, dEmployeeName, dSupervisorID, dSupervisorName, dManagerID, dManagerName, dUploadedByID, dUploadedByName, tUploadedWhen) VALUES ('{txtEId.Text}', '{txtEName.Text}', '{txtSId.Text}', '{txtSName.Text}', '{txtMId.Text}', '{txtMName.Text}', '{ID}', '{Nname}',CURRENT_TIMESTAMP())", myConnectionx)
            myCommandx.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally

            myConnectionx.Close()
        End Try
    End Sub

    Private Sub AddOrUpdateUser(employeeID As String, employeeName As String, supervisorID As String, supervisorName As String, managerID As String, managerName As String)

        Try
            Using connection As MySqlConnection = Connector.getDBConnection()
                connection.Open()

                Dim checkQuery As String = "SELECT COUNT(*) FROM tbluserlist WHERE dEmployeeID = @EmployeeID"
                Using checkCmd As New MySqlCommand(checkQuery, connection)
                    checkCmd.Parameters.AddWithValue("@EmployeeID", employeeID)

                    Dim userCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())


                    If userCount = 0 Then
                        Dim randomString As String = GenerateUniqueRandomString(10)
                        Dim insertQuery As String = "INSERT INTO tbluserlist (dEmployeeID, dEmployeeName, dPassword) VALUES (@EmployeeID, @EmployeeName, @Password)"
                        Using insertCmd As New MySqlCommand(insertQuery, connection)
                            insertCmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                            insertCmd.Parameters.AddWithValue("@EmployeeName", employeeName)
                            insertCmd.Parameters.AddWithValue("@Password", employeeID & randomString)

                            insertCmd.ExecuteNonQuery()
                        End Using
                    Else
                    End If
                End Using

                ' Repeat the process for supervisorID and managerID if needed

            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try

        Try
            Using connection As MySqlConnection = Connector.getDBConnection()
                connection.Open()

                Dim checkQuery As String = "SELECT COUNT(*) FROM tbluserlist WHERE dEmployeeID = @EmployeeID"
                Using checkCmd As New MySqlCommand(checkQuery, connection)
                    checkCmd.Parameters.AddWithValue("@EmployeeID", supervisorID)

                    Dim userCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If userCount = 0 Then
                        Dim randomString As String = GenerateUniqueRandomString(10)
                        Dim insertQuery As String = "INSERT INTO tbluserlist (dEmployeeID, dEmployeeName, dPassword) VALUES (@EmployeeID, @EmployeeName, @Password)"
                        Using insertCmd As New MySqlCommand(insertQuery, connection)
                            insertCmd.Parameters.AddWithValue("@EmployeeID", supervisorID)
                            insertCmd.Parameters.AddWithValue("@EmployeeName", supervisorName)
                            insertCmd.Parameters.AddWithValue("@Password", supervisorID & randomString)

                            insertCmd.ExecuteNonQuery()
                        End Using
                    Else
                        ' EmployeeID already exists in tbluserlist
                    End If
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
        Try
            Using connection As MySqlConnection = Connector.getDBConnection()
                connection.Open()

                Dim checkQuery As String = "SELECT COUNT(*) FROM tbluserlist WHERE dEmployeeID = @EmployeeID"
                Using checkCmd As New MySqlCommand(checkQuery, connection)
                    checkCmd.Parameters.AddWithValue("@EmployeeID", managerID)

                    Dim userCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If userCount = 0 Then
                        Dim randomString As String = GenerateUniqueRandomString(10)
                        Dim insertQuery As String = "INSERT INTO tbluserlist (dEmployeeID, dEmployeeName, dPassword) VALUES (@EmployeeID, @EmployeeName, @Password)"
                        Using insertCmd As New MySqlCommand(insertQuery, connection)
                            insertCmd.Parameters.AddWithValue("@EmployeeID", managerID)
                            insertCmd.Parameters.AddWithValue("@EmployeeName", managerName)
                            insertCmd.Parameters.AddWithValue("@Password", managerID & randomString)

                            insertCmd.ExecuteNonQuery()
                        End Using
                    Else
                        ' EmployeeID already exists in tbluserlist
                    End If
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Sub viewHierarchy()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet

        myConnection1 = Connector.getDBConnection()

        Try

            myConnection1.Open()
            myCommand1 = New MySqlCommand("SELECT dEmployeeID AS EmployeeID, 
            dEmployeeName As `Employee Name`, 
            dSupervisorID AS SupervisorID, 
            dSupervisorName AS `Supervisor Name`,
            dManagerID AS ManagerID, 
            dManagerName AS `Manager Name`, 
            dUploadedByID AS UploaderID, 
            dUploadedByName AS `Uploader Name`, 
            tUploadedWhen AS `TimeStamp` 
            FROM tblhierarchy;", myConnection1)

            myAdapter2.SelectCommand = myCommand1
            myAdapter2.Fill(myDataSet2, "myData")
            dghierarchy.DataSource = myDataSet2.Tables("myData")

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection1.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        If txtEId.Text = "Employee ID" Or txtEName.Text = "Employee Name" Or txtSId.Text = "Supervisor ID" Or txtSName.Text = "Supervisor Name" Or txtMId.Text = "Manager ID" Or txtMName.Text = "Manager Name" Then
            MessageBox.Show("Provide information in the designated fields.")
        Else
            insertEmployee()
            viewHierarchy()
            Dim employeeID As String = txtEId.Text
            Dim employeeName As String = txtEName.Text
            Dim supervisorID As String = txtSId.Text
            Dim supervisorName As String = txtSName.Text
            Dim managerID As String = txtMId.Text
            Dim managerName As String = txtMName.Text
            AddOrUpdateUser(employeeID, employeeName, supervisorID, supervisorName, managerID, managerName)
            Clear()
        End If

    End Sub

    Private Function GenerateUniqueRandomString(maxLength As Integer) As String
        ' Define the characters that can be used in the random string
        Dim characters As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*?/+=-"

        ' Initialize the random number generator
        Dim random As New Random()

        ' Use StringBuilder to efficiently build the random string
        Dim stringBuilder As New StringBuilder()

        ' Generate a random string with characters from the defined set
        For i As Integer = 1 To maxLength
            Dim randomIndex As Integer = random.Next(0, characters.Length)
            stringBuilder.Append(characters(randomIndex))
        Next

        ' Return the generated random string
        Return stringBuilder.ToString()
    End Function
    Sub Clear()
        txtEId.Text = "Employee ID"
        txtEId.ForeColor = Color.DarkGray
        txtEName.Text = "Employee Name"
        txtEName.ForeColor = Color.DarkGray
        txtSId.Text = "Supervisor ID"
        txtSId.ForeColor = Color.DarkGray
        txtSName.Text = "Supervisor Name"
        txtSName.ForeColor = Color.DarkGray
        txtMId.Text = "Manager ID"
        txtMId.ForeColor = Color.DarkGray
        txtMName.Text = "Manager Name"
        txtMName.ForeColor = Color.DarkGray
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        EmployeeList.Hide()
        EmployeeLogs.Hide()
        ShowForm(AdminLogs)
        btnIndicatorHome.Hide()
        btnIndicatorALogs.Show()
        btnIndicatorELogs.Hide()
        btnIndicatorEList.Hide()
        shLineHome.Hide()
        shLineALogs.Show()
        shLineELogs.Hide()
        shLineEList.Hide()
        AdminLogs.viewALogs()
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        EmployeeList.Hide()
        AdminLogs.Hide()
        ShowForm(EmployeeLogs)
        btnIndicatorHome.Hide()
        btnIndicatorALogs.Hide()
        btnIndicatorELogs.Show()
        btnIndicatorEList.Hide()
        shLineHome.Hide()
        shLineALogs.Hide()
        shLineELogs.Show()
        shLineEList.Hide()
        EmployeeLogs.viewElogs()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Login.cAdmin.Checked = False
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub btnIndicatorHome_Click(sender As Object, e As EventArgs) Handles btnIndicatorHome.Click
        EmployeeLogs.Hide()
        EmployeeList.Hide()
        AdminLogs.Hide()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        EmployeeLogs.Hide()
        EmployeeList.Hide()
        AdminLogs.Hide()
        btnIndicatorHome.Show()
        btnIndicatorALogs.Hide()
        btnIndicatorELogs.Hide()
        btnIndicatorEList.Hide()
        shLineHome.Show()
        shLineALogs.Hide()
        shLineELogs.Hide()
        shLineEList.Hide()
    End Sub

    Private Sub btnIndicatorALogs_Click(sender As Object, e As EventArgs) Handles btnIndicatorALogs.Click
        EmployeeLogs.Hide()
        EmployeeList.Hide()
        AdminLogs.Show()
        AdminLogs.viewALogs()
    End Sub

    Private Sub btnIndicatorELogs_Click(sender As Object, e As EventArgs) Handles btnIndicatorELogs.Click
        EmployeeLogs.Show()
        EmployeeList.Hide()
        AdminLogs.Hide()
        EmployeeLogs.viewElogs()
    End Sub
    Private Sub btnEmployeeList_Click_1(sender As Object, e As EventArgs) Handles btnEmployeeList.Click
        EmployeeLogs.Hide()
        ShowForm(EmployeeList)
        AdminLogs.Hide()
        btnIndicatorHome.Hide()
        btnIndicatorALogs.Hide()
        btnIndicatorELogs.Hide()
        btnIndicatorEList.Show()
        shLineHome.Hide()
        shLineALogs.Hide()
        shLineELogs.Hide()
        shLineEList.Show()
        EmployeeList.viewList()
    End Sub

    Private Sub btnIndicatorEList_Click(sender As Object, e As EventArgs) Handles btnIndicatorEList.Click
        EmployeeLogs.Hide()
        EmployeeList.Show()
        AdminLogs.Hide()
        EmployeeList.viewList()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If dghierarchy.DataSource IsNot Nothing Then
            Dim filterExpression As String = $"EmployeeID LIKE '%{SanitizeString(txtSearch.Text)}%' OR " &
                                        $"[Employee Name] LIKE '%{SanitizeString(txtSearch.Text)}%' OR " &
                                        $"SupervisorID LIKE '%{SanitizeString(txtSearch.Text)}%' OR " &
                                        $"[Supervisor Name] LIKE '%{SanitizeString(txtSearch.Text)}%' OR " &
                                        $"ManagerID LIKE '%{SanitizeString(txtSearch.Text)}%' OR " &
                                        $"[Manager Name] LIKE '%{SanitizeString(txtSearch.Text)}%'"
            DirectCast(dghierarchy.DataSource, DataTable).DefaultView.RowFilter = filterExpression
        End If
    End Sub

    Private Function SanitizeString(input As String) As String
        ' Replace single quotes with double single quotes to handle SQL injection
        Return New String(input.Where(Function(c) Char.IsLetterOrDigit(c) Or Char.IsWhiteSpace(c)).ToArray())
    End Function
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles dghierarchy.SelectionChanged
        ' Check if there is any selected row

        txtEId.Enabled = False
        txtEName.Enabled = False
        txtSId.Enabled = False
        txtSName.Enabled = False
        txtMId.Enabled = False
        txtMName.Enabled = False
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnRemove.Enabled = False
        btnSave.Enabled = False

        pIndicatorAdd.Image = Nothing
        pIndicatorEdit.Image = Nothing
        pIndicatorRemove.Image = Nothing
        pIndicatorSave.Image = Nothing
        pIndicatorAdd.Visible = False
        pIndicatorEdit.Visible = False
        pIndicatorRemove.Visible = False
        pIndicatorSave.Visible = False
        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnRemove.Enabled = True
        btnSave.Enabled = True
        dghierarchy.Focus()
    End Sub
    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click

        Clear()
        txtEId.Enabled = True
        txtEName.Enabled = True
        txtSId.Enabled = True
        txtSName.Enabled = True
        txtMId.Enabled = True
        txtMName.Enabled = True


        pIndicatorAdd.Image = My.Resources.circle
        pIndicatorEdit.BackgroundImage = Nothing
        pIndicatorRemove.BackgroundImage = Nothing
        pIndicatorSave.BackgroundImage = Nothing
        pIndicatorAdd.Visible = True
        pIndicatorEdit.Visible = False
        pIndicatorRemove.Visible = False
        pIndicatorSave.Visible = False
        pIndicatorEdit.Focus()
        btnEdit.Enabled = False
        btnRemove.Enabled = False
        btnSave.Enabled = True

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        txtEId.Enabled = False
        txtEName.Enabled = False
        txtSId.Enabled = False
        txtSName.Enabled = False
        txtMId.Enabled = False
        txtMName.Enabled = False
        btnEdit.Enabled = False
        btnRemove.Enabled = False
        btnSave.Enabled = False

        pIndicatorAdd.BackgroundImage = Nothing
        pIndicatorEdit.BackgroundImage = Nothing
        pIndicatorRemove.Image = My.Resources.circle
        pIndicatorSave.BackgroundImage = Nothing
        pIndicatorAdd.Visible = False
        pIndicatorEdit.Visible = False
        pIndicatorRemove.Visible = True
        pIndicatorSave.Visible = False
        btnEdit.Enabled = True
        btnRemove.Enabled = True
        btnSave.Enabled = True


        If dghierarchy.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dghierarchy.SelectedRows(0)

            txtEId.Text = selectedRow.Cells("EmployeeID").Value.ToString()
            txtEName.Text = selectedRow.Cells("Employee Name").Value.ToString()
            txtSId.Text = selectedRow.Cells("SupervisorID").Value.ToString()
            txtSName.Text = selectedRow.Cells("Supervisor Name").Value.ToString()
            txtMId.Text = selectedRow.Cells("ManagerID").Value.ToString()
            txtMName.Text = selectedRow.Cells("Manager Name").Value.ToString()
        End If


    End Sub
    Dim idToEdit As Integer
    Dim rowIndexToEdit As Integer
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        txtEId.Enabled = False
        txtEName.Enabled = False
        txtSId.Enabled = True
        txtSName.Enabled = True
        txtMId.Enabled = True
        txtMName.Enabled = True
        btnEdit.Enabled = False
        btnRemove.Enabled = False
        btnSave.Enabled = False

        pIndicatorAdd.BackgroundImage = Nothing
        pIndicatorEdit.Image = My.Resources.circle
        pIndicatorRemove.BackgroundImage = Nothing
        pIndicatorSave.BackgroundImage = Nothing
        pIndicatorAdd.Visible = False
        pIndicatorEdit.Visible = True
        pIndicatorRemove.Visible = False
        pIndicatorSave.Visible = False
        btnEdit.Enabled = True
        btnRemove.Enabled = True
        btnSave.Enabled = True

        If dghierarchy.SelectedRows.Count > 0 Then
            ' Move the selected row data to textboxes
            Dim selectedRow As DataGridViewRow = dghierarchy.SelectedRows(0)
            txtEId.Text = selectedRow.Cells("EmployeeID").Value.ToString()
            txtEName.Text = selectedRow.Cells("Employee Name").Value.ToString()
            txtSId.Text = selectedRow.Cells("SupervisorID").Value.ToString()
            txtSName.Text = selectedRow.Cells("Supervisor Name").Value.ToString()
            txtMId.Text = selectedRow.Cells("ManagerID").Value.ToString()
            txtMName.Text = selectedRow.Cells("Manager Name").Value.ToString()

            ' Store the ID of the selected row for later use
            ' You can use this ID to identify the row to update in the database
            idToEdit = Integer.Parse(selectedRow.Cells("EmployeeID").Value.ToString())
            ' Store the index of the selected row for later use
            rowIndexToEdit = selectedRow.Index
        End If
    End Sub

    Private Sub btnReset_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click

        viewHierarchy()
        txtEId.Enabled = False
        txtEName.Enabled = False
        txtSId.Enabled = False
        txtSName.Enabled = False
        txtMId.Enabled = False
        txtMName.Enabled = False
        btnEdit.Enabled = False
        btnRemove.Enabled = False
        btnSave.Enabled = False
        btnAdd.Enabled = False

        Clear()

        pIndicatorEdit.Enabled = False
        pIndicatorRemove.Enabled = False
        pIndicatorSave.Enabled = False
        pIndicatorAdd.Enabled = False
        pIndicatorAdd.Visible = False
        pIndicatorEdit.Visible = False
        pIndicatorRemove.Visible = False
        pIndicatorSave.Visible = False
        btnAdd.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If pIndicatorAdd.Visible = True Then
            If txtEId.Text = "Employee ID" Or txtEName.Text = "Employee Name" Or txtSId.Text = "Supervisor ID" Or txtSName.Text = "Supervisor Name" Or txtMId.Text = "Manager ID" Or txtMName.Text = "Manager Name" Then
                MessageBox.Show("Provide information in the designated fields.")
            Else
                insertEmployee()
                viewHierarchy()
                Dim employeeID As String = txtEId.Text
                Dim employeeName As String = txtEName.Text
                Dim supervisorID As String = txtSId.Text
                Dim supervisorName As String = txtSName.Text
                Dim managerID As String = txtMId.Text
                Dim managerName As String = txtMName.Text
                AddOrUpdateUser(employeeID, employeeName, supervisorID, supervisorName, managerID, managerName)
                Clear()
                MessageBox.Show("Data has been added")
            End If
        ElseIf pIndicatorRemove.Visible = True Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove the enire row?", "Remove Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                If Not String.IsNullOrEmpty(txtEId.Text) Then
                    Dim idToRemove As Integer = Integer.Parse(txtEId.Text)

                    Using connection As MySqlConnection = Connector.getDBConnection()
                        connection.Open()

                        Dim query As String = $"DELETE FROM tblhierarchy WHERE dEmployeeID = @ID"
                        Using cmd As New MySqlCommand(query, connection)
                            cmd.Parameters.AddWithValue("@ID", idToRemove)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    Clear()
                    MessageBox.Show("Row has been removed")
                Else
                    MessageBox.Show("Error deleting the row")
                End If
            End If

        ElseIf pIndicatorEdit.Visible = True Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update the data?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                If txtEId.Text IsNot "" AndAlso txtEName.Text IsNot "" AndAlso txtSId.Text IsNot "" AndAlso txtSName.Text IsNot "" AndAlso txtMId.Text IsNot "" AndAlso txtMName.Text IsNot "" Then
                    ' Get the edited data from textboxes
                    Dim editedColumn1 As String = txtEId.Text
                    Dim editedColumn2 As String = txtEName.Text
                    Dim editedColumn3 As String = txtSId.Text
                    Dim editedColumn4 As String = txtSName.Text
                    Dim editedColumn5 As String = txtMId.Text
                    Dim editedColumn6 As String = txtMName.Text

                    If SupervisorExists(editedColumn3, editedColumn4) Then
                        If ManagerExists(editedColumn5, editedColumn6) Then
                            dghierarchy.Rows(rowIndexToEdit).Cells("EmployeeID").Value = editedColumn1
                            dghierarchy.Rows(rowIndexToEdit).Cells("Employee Name").Value = editedColumn2
                            dghierarchy.Rows(rowIndexToEdit).Cells("SupervisorID").Value = editedColumn3
                            dghierarchy.Rows(rowIndexToEdit).Cells("Supervisor Name").Value = editedColumn4
                            dghierarchy.Rows(rowIndexToEdit).Cells("ManagerID").Value = editedColumn5
                            dghierarchy.Rows(rowIndexToEdit).Cells("Manager Name").Value = editedColumn6

                            ' Update data in the database
                            Using connection As MySqlConnection = Connector.getDBConnection()
                                connection.Open()

                                ' Replace "YourTableName" with your actual table name
                                Dim query As String = $"UPDATE tblhierarchy SET dEmployeeID = @Column1, dEmployeeName = @Column2, dSupervisorID = @Column3, dSupervisorName = @Column4, dManagerID = @Column5, dManagerName = @Column6, tLastUpdate = CURRENT_TIMESTAMP() WHERE dEmployeeID = @ID"
                                Using cmd As New MySqlCommand(query, connection)
                                    cmd.Parameters.AddWithValue("@Column1", editedColumn1)
                                    cmd.Parameters.AddWithValue("@Column2", editedColumn2)
                                    cmd.Parameters.AddWithValue("@Column3", editedColumn3)
                                    cmd.Parameters.AddWithValue("@Column4", editedColumn4)
                                    cmd.Parameters.AddWithValue("@Column5", editedColumn5)
                                    cmd.Parameters.AddWithValue("@Column6", editedColumn6)
                                    cmd.Parameters.AddWithValue("@ID", idToEdit)
                                    cmd.ExecuteNonQuery()
                                End Using
                            End Using

                            Clear()
                        Else
                            MessageBox.Show("No matching Manager ID and name were found in the database.")
                            Return
                        End If
                    Else
                        MessageBox.Show("No matching Supervisor ID and name were found in the database.")
                    End If
                End If
            End If
        End If

        pIndicatorAdd.BackgroundImage = Nothing
        pIndicatorEdit.BackgroundImage = Nothing
        pIndicatorRemove.BackgroundImage = Nothing
        pIndicatorSave.BackgroundImage = Nothing

    End Sub
    Private Function SupervisorExists(supervisorID As String, supervisorName As String) As Boolean
        Using connection As MySqlConnection = Connector.getDBConnection()
            connection.Open()

            ' Replace "tbluserlist" with your actual table name
            Dim query As String = "SELECT COUNT(*) FROM tbluserlist WHERE dEmployeeID = @SupervisorID AND dEmployeeName = @SupervisorName"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@SupervisorID", supervisorID)
                cmd.Parameters.AddWithValue("@SupervisorName", supervisorName)

                ' If there is any record with the given SupervisorID or SupervisorName, it already exists
                Return CInt(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function
    Private Function ManagerExists(managerID As String, managerName As String) As Boolean
        Using connection As MySqlConnection = Connector.getDBConnection()
            connection.Open()

            ' Replace "tbluserlist" with your actual table name
            Dim query As String = "SELECT COUNT(*) FROM tbluserlist WHERE dEmployeeID = @ManagerID AND dEmployeeName = @ManagerName"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@ManagerID", managerID)
                cmd.Parameters.AddWithValue("@ManagerName", managerName)

                ' If there is any record with the given SupervisorID or SupervisorName, it already exists
                Return CInt(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

End Class