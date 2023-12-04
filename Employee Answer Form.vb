Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Employee_Answer_Form
    Private Sub Employee_Answer_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbPage2.Visible = False
        gbPage3.Visible = False
        rbPage1.Checked = True
    End Sub

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel3.Paint

    End Sub

    Private Sub RadioButton98_CheckedChanged(sender As Object, e As EventArgs) Handles rbYESP1.CheckedChanged

    End Sub

    Private Sub RadioButton99_CheckedChanged(sender As Object, e As EventArgs) Handles rbNOP1.CheckedChanged
    End Sub

    Private Sub RadioButton97_CheckedChanged(sender As Object, e As EventArgs) Handles rbNAP1.CheckedChanged
    End Sub

    Private Sub RadioButton91_CheckedChanged(sender As Object, e As EventArgs) Handles rbNAP2.CheckedChanged
    End Sub

    Private Sub RadioButton93_CheckedChanged(sender As Object, e As EventArgs) Handles rbNOP2.CheckedChanged
    End Sub

    Private Sub RadioButton92_CheckedChanged(sender As Object, e As EventArgs) Handles rbYESP2.CheckedChanged
    End Sub

    Private Sub RadioButton81_CheckedChanged(sender As Object, e As EventArgs) Handles rbNOP3.CheckedChanged
    End Sub

    Private Sub RadioButton80_CheckedChanged(sender As Object, e As EventArgs) Handles rbYESP3.CheckedChanged
    End Sub

    Private Sub txtSystemAndArchitecture_TextChanged(sender As Object, e As EventArgs) Handles txtSystemAndArchitecture.TextChanged

    End Sub

    Private Sub gbPageSelection_Click(sender As Object, e As EventArgs) Handles gbPageSelection.Click

    End Sub

    Private Sub rbPage2_CheckedChanged(sender As Object, e As EventArgs) Handles rbPage2.CheckedChanged
        If rbPage2.Checked Then
            gbPage2.Visible = True
            gbPage1.Visible = False
            gbPage3.Visible = False
        End If
    End Sub

    Private Sub rbPage3_CheckedChanged(sender As Object, e As EventArgs) Handles rbPage3.CheckedChanged
        If rbPage3.Checked Then
            gbPage3.Visible = True
            gbPage1.Visible = False
            gbPage2.Visible = False
        End If
    End Sub

    Private Sub rbPage1_CheckedChanged(sender As Object, e As EventArgs) Handles rbPage1.CheckedChanged
        If rbPage1.Checked Then
            gbPage1.Visible = True
            gbPage2.Visible = False
            gbPage3.Visible = False
        End If
    End Sub

    Private Sub gbPage1_Click(sender As Object, e As EventArgs) Handles gbPage1.Click

    End Sub
End Class