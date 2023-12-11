Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class Login
    Public Shared ID As String
    Public Shared Nname As String

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.UseSystemPasswordChar = True
        btnShowPass.Image = My.Resources.Hidepassword
        btnShowPass.ImageOffset = New Point(0, 0)
        btnShowPass.ImageAlign = HorizontalAlignment.Center
        btnShowPass.TextAlign = HorizontalAlignment.Center
        For Each textBox As Guna2TextBox In {txtID, txtPass}
            textBox.Tag = textBox.Text
        Next

    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub buttonlogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtID.Text = "" Or txtPass.Text = "" Then
            MessageBox.Show("Input ID and password.")
        Else
            If cAdmin.Checked = True Then
                If CheckAdminCredentials(txtID.Text, txtPass.Text) Then
                    Try
                        Using myConnection As MySqlConnection = Connector.getDBConnection()
                            myConnection.Open()

                            Dim query As String = $"SELECT dAdminName FROM tbladmin WHERE dAdminID = @AdminID"

                            Using cmd As New MySqlCommand(query, myConnection)
                                cmd.Parameters.AddWithValue("@AdminId", txtID.Text)
                                Dim AdminName As String = Convert.ToString(cmd.ExecuteScalar())
                                Nname = AdminName
                            End Using
                        End Using
                    Catch ex As Exception
                        MessageBox.Show($"Error: {ex.Message}")
                    End Try
                    ID = txtID.Text
                    txtID.Clear()
                    txtPass.Clear()
                    txtPass.UseSystemPasswordChar = True
                    btnShowPass.Image = My.Resources.Hidepassword
                    Me.Hide()
                    Admin_Dashboard.Show()
                Else
                    MessageBox.Show("Invalid credentials.")
                End If
            ElseIf CheckEmployeeCredentials(txtID.Text, txtPass.Text) Then
                Try
                    Using Connection As MySqlConnection = Connector.getDBConnection()
                        Connection.Open()

                        Dim query As String = $"SELECT COUNT(*) FROM tbluserlist WHERE dEmployeeID = '{txtID.Text}' AND (dSec1 IS NULL OR dSec1 = '')"
                        Using cmd As New MySqlCommand(query, Connection)
                            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                            If count > 0 Then
                                ID = txtID.Text
                                txtID.Clear()
                                txtPass.Clear()
                                txtPass.UseSystemPasswordChar = True
                                btnShowPass.Image = My.Resources.Hidepassword
                                New_User.Close()
                                Create_Password.Close()
                                Security_Questions.Close()

                                New_User.ShowDialog()
                                If New_User.Visible = False Then
                                    Security_Questions.ShowDialog()
                                    If Security_Questions.Visible = False Then
                                        Create_Password.ShowDialog()
                                    End If
                                End If
                            Else
                                    CheckAndNavigate(txtID.Text)
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show($"Error: {ex.Message}")
                End Try

            Else
                MessageBox.Show("Invalid credentials.")
            End If

        End If
    End Sub
    Private Function Isnewformclosed() As Boolean
        If New_User Is Nothing OrElse New_User.IsDisposed Then
            Return True ' Login form is closed
        Else
            Return False ' Login form is still open
        End If
    End Function
    Private Sub GunaTextBox_GotFocus(sender As Object, e As EventArgs) Handles txtID.GotFocus, txtPass.GotFocus
        HandleGunaTextBoxFocus(DirectCast(sender, Guna2TextBox), Color.Black)
    End Sub

    Private Sub GunaTextBox_LostFocus(sender As Object, e As EventArgs) Handles txtID.LostFocus, txtPass.LostFocus
        HandleGunaTextBoxLostFocus(DirectCast(sender, Guna2TextBox), Color.LightGray)
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
    Private Function CheckAdminCredentials(AdminID As String, password As String) As Boolean
        Dim query As String = $"SELECT COUNT(*) FROM tbladmin WHERE dAdminID = @AdminID AND dAdminPassword = @password"

        Using myConnection As MySqlConnection = Connector.getDBConnection()
            Using cmd As New MySqlCommand(query, myConnection)
                cmd.Parameters.AddWithValue("@AdminID", AdminID)
                cmd.Parameters.AddWithValue("@password", password)

                myConnection.Open()
                Dim count As Integer = CInt(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function


    Private Function CheckEmployeeCredentials(EmployeeID As String, password As String) As Boolean
        Dim query As String = $"SELECT COUNT(*) FROM tbluserlist WHERE dEmployeeID = @employeeID AND dPassword = @password"

        Using myConnection As MySqlConnection = Connector.getDBConnection()
            Using cmd As New MySqlCommand(query, myConnection)
                cmd.Parameters.AddWithValue("@employeeID", EmployeeID)
                cmd.Parameters.AddWithValue("@password", password)

                myConnection.Open()
                Dim count As Integer = CInt(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub CheckAndNavigate(idd As String)
        Try
            Using Connection As MySqlConnection = Connector.getDBConnection()
                Connection.Open()

                ' Check if the specified ID is present in EmployeeID, SupervisorID, or ManagerID columns
                Dim query As String = "SELECT COUNT(*) FROM tblhierarchy WHERE dEmployeeID = @ID OR dSupervisorID = @ID OR dManagerID = @ID"
                Using cmd As New MySqlCommand(query, Connection)
                    cmd.Parameters.AddWithValue("@ID", idd)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        ' Determine the column where the ID is present
                        Dim column As String = GetIDColumn(idd)

                        ' Open the corresponding form based on the column
                        Select Case column
                            Case "EmployeeID"
                                ID = txtID.Text
                                txtID.Clear()
                                txtPass.Clear()
                                txtPass.UseSystemPasswordChar = True
                                btnShowPass.Image = My.Resources.Hidepassword
                                Me.Hide()
                                Employee_Dashboard.Show()
                            Case "SupervisorID"
                                ID = txtID.Text
                                txtID.Clear()
                                txtPass.Clear()
                                txtPass.UseSystemPasswordChar = True
                                btnShowPass.Image = My.Resources.Hidepassword
                                Me.Hide()
                                Supervisor_Dashboard.Show()
                            Case "ManagerID"
                                ID = txtID.Text
                                txtID.Clear()
                                txtPass.Clear()
                                txtPass.UseSystemPasswordChar = True
                                btnShowPass.Image = My.Resources.Hidepassword
                                Me.Hide()
                                Manager_Dashboard.Show()
                        End Select
                    Else
                        MessageBox.Show("ID not found.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Function GetIDColumn(id As String) As String
        Try
            Using Connection As MySqlConnection = Connector.getDBConnection()
                Connection.Open()

                ' Check in which column the ID is present
                Dim query As String = "SELECT CASE " &
                                      "WHEN dEmployeeID = @ID THEN 'EmployeeID' " &
                                      "WHEN dSupervisorID = @ID THEN 'SupervisorID' " &
                                      "WHEN dManagerID = @ID THEN 'ManagerID' " &
                                      "ELSE '' END AS IDColumn " &
                                      "FROM tblhierarchy " &
                                      "WHERE dEmployeeID = @ID OR dSupervisorID = @ID OR dManagerID = @ID"
                Using cmd As New MySqlCommand(query, Connection)
                    cmd.Parameters.AddWithValue("@ID", id)

                    Dim idColumn As String = Convert.ToString(cmd.ExecuteScalar())

                    Return idColumn
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
            Return String.Empty
        End Try
    End Function

    Sub insertLogs()
        Dim myConnectionx As MySqlConnection
        Dim myCommandx As MySqlCommand

        myConnectionx = Connector.getDBConnection()

        Try

            myConnectionx.Open()
            myCommandx = New MySqlCommand($"INSERT INTO tbllogs (demployeeID, ttimestamp, dstatus) VALUES ('{txtID.Text}', CURRENT_TIMESTAMP(), 'In')", myConnectionx)
            myCommandx.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally

            myConnectionx.Close()

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Enter_Employee_ID.Close()
        Answer_Security_Questions.Close()
        Enter_Employee_ID.ShowDialog()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Click the login button
            btnLogin.PerformClick()
        End If
    End Sub
    Private Sub txtID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Click the login button
            btnLogin.PerformClick()
        End If
    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ' Check if the Enter key is pressed
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            btnLogin.PerformClick()
            e.Handled = True
        End If
    End Sub

    Dim isPasswordVisible As Boolean = True
    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click

        isPasswordVisible = Not isPasswordVisible
        If isPasswordVisible Then
            txtPass.UseSystemPasswordChar = False
            btnShowPass.Image = My.Resources.Showpassword
        Else
            txtPass.UseSystemPasswordChar = True
            btnShowPass.Image = My.Resources.Hidepassword
        End If
        btnShowPass.ImageOffset = New Point(0, 0)
        btnShowPass.ImageAlign = HorizontalAlignment.Center
        btnShowPass.TextAlign = HorizontalAlignment.Center

    End Sub
End Class