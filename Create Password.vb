Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Create_Password
    Public ID As String = Login.ID Or Enter_Employee_ID.EmployeeID
    Public A1 As String = Security_Questions.A1
    Public A2 As String = Security_Questions.A2
    Public A3 As String = Security_Questions.A3
    Public Q1 As String = Security_Questions.Q1
    Public Q2 As String = Security_Questions.Q2
    Public Q3 As String = Security_Questions.Q3

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCNPassword.Clear()
        txtNPassword.Clear()
        isPasswordVisible1 = True
        isPasswordVisible2 = True

        txtNPassword.UseSystemPasswordChar = True
        btnCreateShowPass.Image = My.Resources.Hidepassword
        btnCreateShowPass.ImageOffset = New Point(0, 0)
        btnCreateShowPass.ImageAlign = HorizontalAlignment.Center
        btnCreateShowPass.TextAlign = HorizontalAlignment.Center

        txtCNPassword.UseSystemPasswordChar = True
        btnConfirmShowPass.Image = My.Resources.Hidepassword
        btnConfirmShowPass.ImageOffset = New Point(0, 0)
        btnConfirmShowPass.ImageAlign = HorizontalAlignment.Center
        btnConfirmShowPass.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel5.Click

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If txtNPassword.Text = "" Or txtCNPassword.Text = "" Then
            MessageBox.Show("Fill the Required Fields.")
        ElseIf lblPasswordStatus.ForeColor = Color.Red Then
            MessageBox.Show("The credentials do not meet the specified requirements.")
        ElseIf txtNPassword.Text IsNot txtCNPassword.Text Then
            MessageBox.Show("Credentials do not match.")
        ElseIf lblPasswordStatus.ForeColor = Color.Green Then
            UpdateUserList()
            txtCNPassword.Clear()
            txtNPassword.Clear()
            New_User.Close()
            Security_Questions.Close()
            Enter_Employee_ID.Close()
            Answer_Security_Questions.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click

    End Sub

    Sub UpdateUserList()
        Dim myConnectionx As MySqlConnection
        Dim myCommandx As MySqlCommand

        myConnectionx = Connector.getDBConnection()

        Try
            myConnectionx.Open()

            myCommandx = New MySqlCommand($"UPDATE tbluserlist SET dPassword = '{txtNPassword.Text}', dSec1 = '{Q1}' , dSeca1 = '{A1}', dSec2 = '{Q2}', dSeca2 = '{A2}', dSec3 = '{Q3}', dSeca3 = '{A3}', tDataChanged = CURRENT_TIMESTAMP() WHERE dEmployeeID = '{ID}'", myConnectionx)
            myCommandx.ExecuteNonQuery()
            MessageBox.Show("Password updated successfully.")
        Catch ex As Exception
            MsgBox(ex.Message) ' Display the exception message instead of Err.Description
        Finally
            myConnectionx.Close()
        End Try
    End Sub

    Private Sub Create_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNPassword.UseSystemPasswordChar = True
        btnCreateShowPass.Image = My.Resources.Hidepassword
        btnCreateShowPass.ImageOffset = New Point(0, 0)
        btnCreateShowPass.ImageAlign = HorizontalAlignment.Center
        btnCreateShowPass.TextAlign = HorizontalAlignment.Center

        txtCNPassword.UseSystemPasswordChar = True
        btnConfirmShowPass.Image = My.Resources.Hidepassword
        btnConfirmShowPass.ImageOffset = New Point(0, 0)
        btnConfirmShowPass.ImageAlign = HorizontalAlignment.Center
        btnConfirmShowPass.TextAlign = HorizontalAlignment.Center
    End Sub
    Private Sub CheckPasswordStrength(password As String)
        ' Minimum of 10 characters
        Dim lengthRequirementMet As Boolean = password.Length >= 10

        ' At least 1 uppercase letter
        Dim uppercaseRequirementMet As Boolean = Regex.IsMatch(password, "[A-Z]")

        ' At least 1 lowercase letter
        Dim lowercaseRequirementMet As Boolean = Regex.IsMatch(password, "[a-z]")

        ' At least 1 special character
        Dim specialCharRequirementMet As Boolean = Regex.IsMatch(password, "[!@#$%^&*()_+{}\[\]:;<>,.?~\\/-]")

        ' At least 1 number
        Dim numberRequirementMet As Boolean = Regex.IsMatch(password, "[0-9]")

        Dim matchpass As Boolean = Regex.IsMatch(txtNPassword.Text, txtCNPassword.Text)

        ' Update label color based on requirements
        If lengthRequirementMet AndAlso uppercaseRequirementMet AndAlso lowercaseRequirementMet AndAlso specialCharRequirementMet AndAlso numberRequirementMet AndAlso matchpass Then
            lblPasswordStatus.ForeColor = Color.Green
            lblPasswordStatus.Text = "Password Strength: Valid"
        Else
            lblPasswordStatus.ForeColor = Color.Red
            lblPasswordStatus.Text = "Password Strength: Invalid"
        End If
    End Sub
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNPassword.TextChanged
        ' Call the password strength checker when the password text changes
        CheckPasswordStrength(txtNPassword.Text)
    End Sub

    Dim isPasswordVisible1 As Boolean = True
    Private Sub btnCreateShowPass_Click(sender As Object, e As EventArgs) Handles btnCreateShowPass.Click

        isPasswordVisible1 = Not isPasswordVisible1
        If isPasswordVisible1 Then
            txtNPassword.UseSystemPasswordChar = False
            btnCreateShowPass.Image = My.Resources.Showpassword
        Else
            txtNPassword.UseSystemPasswordChar = True
            btnCreateShowPass.Image = My.Resources.Hidepassword
        End If
        btnCreateShowPass.ImageOffset = New Point(0, 0)
        btnCreateShowPass.ImageAlign = HorizontalAlignment.Center
        btnCreateShowPass.TextAlign = HorizontalAlignment.Center

    End Sub
    Dim isPasswordVisible2 As Boolean = True
    Private Sub btnConfirmShowPass_Click(sender As Object, e As EventArgs) Handles btnConfirmShowPass.Click

        isPasswordVisible2 = Not isPasswordVisible2
        If isPasswordVisible2 Then
            txtCNPassword.UseSystemPasswordChar = False
            btnConfirmShowPass.Image = My.Resources.Showpassword
        Else
            txtCNPassword.UseSystemPasswordChar = True
            btnConfirmShowPass.Image = My.Resources.Hidepassword
        End If
        btnConfirmShowPass.ImageOffset = New Point(0, 0)
        btnConfirmShowPass.ImageAlign = HorizontalAlignment.Center
        btnConfirmShowPass.TextAlign = HorizontalAlignment.Center

    End Sub
    Private Sub txtCNPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCNPassword.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Click the login button
            btnConfirm.PerformClick()
        End If
    End Sub

    Private Sub txtCreatePass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNPassword.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Click the login button
            btnConfirm.PerformClick()
        End If
    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ' Check if the Enter key is pressed
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            btnConfirm.PerformClick()
            e.Handled = True
        End If
    End Sub
End Class