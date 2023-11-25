Imports Guna.UI2.WinForms

Public Class Admin_Dashboard
    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Admin_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each textBox As Guna2TextBox In {txtEId, txtEName, txtSId, txtSName, txtMId, txtMName}
            textBox.Tag = textBox.Text
        Next
    End Sub
    Private Sub GunaTextBox_GotFocus(sender As Object, e As EventArgs) Handles txtEId.GotFocus, txtEName.GotFocus, txtSId.GotFocus, txtSName.GotFocus, txtMId.GotFocus, txtMName.GotFocus
        HandleGunaTextBoxFocus(DirectCast(sender, Guna2TextBox), Color.Black)
    End Sub

    Private Sub GunaTextBox_LostFocus(sender As Object, e As EventArgs) Handles txtEId.LostFocus, txtEName.LostFocus, txtSId.LostFocus, txtSName.LostFocus, txtMId.LostFocus, txtMName.LostFocus
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtEId.Clear()
        txtEName.Clear()
        txtSId.Clear()
        txtSName.Clear()
        txtMId.Clear()
        txtMName.Clear()
    End Sub
End Class