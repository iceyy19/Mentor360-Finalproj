Public Class Employee_Dashboard
    Private Sub Employee_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub vScrollBar1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2vScrollBar1.ValueChanged
        Guna2Panel3.VerticalScroll.Value = Guna2vScrollBar1.Value
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint
    End Sub
End Class