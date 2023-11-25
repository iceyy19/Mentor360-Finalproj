Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class Login
    Public Shared ID As String
    Public Shared Nname As String
    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each textBox As Guna2TextBox In {txtID, txtPass}
            textBox.Tag = textBox.Text
        Next
    End Sub
    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub buttonlogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtID.Text = "" And txtPass.Text = "" Then
            MessageBox.Show("Input ID and password.")
        Else
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
                Me.Hide()
                Admin_Dashboard.Show()
            Else
                MessageBox.Show("Invalid credentials.")
            End If
        End If

    End Sub
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

End Class