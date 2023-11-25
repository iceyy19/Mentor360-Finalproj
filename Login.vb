Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If CheckStudentCredentials(txtID.Text, txtPass.Text) Then
            txtID.Clear()
            txtPass.Clear()
            Me.Hide()
            Admin_Dashboard.Show()
        Else
            MsgBox("Incorrect Credentials", "h", vbOK)
        End If

    End Sub
    Private Function CheckStudentCredentials(AdminID As String, password As String) As Boolean
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

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class