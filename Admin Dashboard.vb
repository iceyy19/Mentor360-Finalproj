﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities

Public Class Admin_Dashboard
    Public ID As String = "@000@" 'Login.ID
    Public Nname As String = "vernon" 'Login.Nname
    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Admin_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewHierarchy()
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
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

                ' Check if the employeeID already exists in tbluserlist
                Dim checkQuery As String = "SELECT COUNT(*) FROM tbluserlist WHERE dEmployeeID = @EmployeeID"
                Using checkCmd As New MySqlCommand(checkQuery, connection)
                    checkCmd.Parameters.AddWithValue("@EmployeeID", employeeID)

                    Dim userCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If userCount = 0 Then
                        ' EmployeeID does not exist in tbluserlist, insert it
                        Dim insertQuery As String = "INSERT INTO tbluserlist (dEmployeeID, dEmployeeName) VALUES (@EmployeeID, @EmployeeName)"
                        Using insertCmd As New MySqlCommand(insertQuery, connection)
                            insertCmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                            insertCmd.Parameters.AddWithValue("@EmployeeName", employeeName)

                            insertCmd.ExecuteNonQuery()
                        End Using
                    Else
                        ' EmployeeID already exists in tbluserlist
                    End If
                End Using

                ' Repeat the process for supervisorID and managerID if needed

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
            FROM `mentor360-finals`.tblhierarchy;", myConnection1)

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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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

End Class