Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Employee_Result
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Employee_Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbPage2.Visible = False
        gbPage3.Visible = False
        gbPage4.Visible = False
        rbPage1.Checked = True
    End Sub

    Private Sub Page1MouseWheel(sender As Object, e As MouseEventArgs) Handles MyBase.MouseWheel

    End Sub

    Private Sub rbPage1_CheckedChanged(sender As Object, e As EventArgs) Handles rbPage1.CheckedChanged
        If rbPage1.Checked Then
            gbPage1.Visible = True
            gbPage2.Visible = False
            gbPage3.Visible = False
            gbPage4.Visible = False
        End If
    End Sub

    Private Sub rbPage2_CheckedChanged(sender As Object, e As EventArgs) Handles rbPage2.CheckedChanged
        If rbPage2.Checked Then
            gbPage1.Visible = False
            gbPage2.Visible = True
            gbPage3.Visible = False
            gbPage4.Visible = False
        End If
    End Sub

    Private Sub rbPage3_CheckedChanged(sender As Object, e As EventArgs) Handles rbPage3.CheckedChanged
        If rbPage3.Checked Then
            gbPage1.Visible = False
            gbPage2.Visible = False
            gbPage3.Visible = True
            gbPage4.Visible = False
        End If
    End Sub

    Private Sub rbPage4_CheckedChanged(sender As Object, e As EventArgs) Handles rbPage4.CheckedChanged
        If rbPage4.Checked Then
            gbPage1.Visible = False
            gbPage2.Visible = False
            gbPage3.Visible = False
            gbPage4.Visible = True
        End If
    End Sub
End Class