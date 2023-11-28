Public Class Employee_Dashboard
    Private Sub Employee_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub vScrollBar1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2vScrollBar1.ValueChanged
        Guna2Panel3.VerticalScroll.Value = Guna2vScrollBar1.Value
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub
End Class