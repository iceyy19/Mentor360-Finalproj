Public Class Supervisor_Answer_Form
    Private Sub lblSupervisor_Click(sender As Object, e As EventArgs) Handles lblManager.Click

    End Sub

    Private Sub Supervisor_Answer_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbPage2.Visible = False
        gbPage3.Visible = False
        rbPage1.Checked = True
    End Sub

    Private Sub Guna2CustomRadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rbPage1.CheckedChanged
        If rbPage1.Checked Then
            gbPage1.Visible = True
            gbPage2.Visible = False
            gbPage3.Visible = False
        End If
    End Sub

    Private Sub rbPage2_CheckedChanged(sender As Object, e As EventArgs) Handles rbPage2.CheckedChanged
        If rbPage2.Checked Then
            gbPage1.Visible = False
            gbPage2.Visible = True
            gbPage3.Visible = False
        End If
    End Sub

    Private Sub rbPage3_CheckedChanged(sender As Object, e As EventArgs) Handles rbPage3.CheckedChanged
        If rbPage3.Checked Then
            gbPage1.Visible = False
            gbPage2.Visible = False
            gbPage3.Visible = True
        End If
    End Sub
End Class