Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Employee_Result
    Public Property SelectedRowData2 As Dictionary(Of String, String)
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Employee_Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbPage2.Visible = False
        gbPage3.Visible = False
        gbPage4.Visible = False
        rbPage1.Checked = True

        txtCIE1.Enabled = False
        txtCIS1.Enabled = False
        txtSDAE1.Enabled = False
        txtSDAS1.Enabled = False
        txtCLE1.Enabled = False
        txtCLS1.Enabled = False
        txtDE1.Enabled = False
        txtDS1.Enabled = False
        txtPSE1.Enabled = False
        txtPSS1.Enabled = False
        txtSDE1.Enabled = False
        txtSDS1.Enabled = False
        txtPE1.Enabled = False
        txtPS1.Enabled = False
        txtDiscussion.Enabled = False
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

    Private Sub lblSDS1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub txtSDE1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSDS1_TextChanged(sender As Object, e As EventArgs)
    End Sub
End Class