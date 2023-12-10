Public Class Manager_Results
    Public Property SelectedRowData3 As Dictionary(Of String, String)
    Dim currentPage As Integer = 1
    Private Sub lblEmployeeID_Click(sender As Object, e As EventArgs) Handles lblEmployeeID.Click

    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles lblSRating.Click

    End Sub

    Private Sub Manager_Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        rbPage1.Checked = True
    End Sub
    Private Sub rbPage_CheckedChanged(sender As Object, e As EventArgs) Handles rbPage1.CheckedChanged, rbPage2.CheckedChanged, rbPage3.CheckedChanged
        ' Show/hide groupboxes based on the selected radiobutton
        gbPage1.Visible = rbPage1.Checked
        gbPage2.Visible = rbPage2.Checked
        gbPage3.Visible = rbPage3.Checked
        gbPage4.Visible = rbPage4.Checked

        ' Update the current page variable
        If rbPage1.Checked Then
            currentPage = 1
        ElseIf rbPage2.Checked Then
            currentPage = 2
        ElseIf rbPage3.Checked Then
            currentPage = 3
        ElseIf rbPage4.Checked Then
            currentPage = 4
        End If
    End Sub
End Class