
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI2.WinForms

Public Class Security_Questions
    Public Shared A1, A2, A3, Q1, Q2, Q3 As String
    Private selectedOptions As New Dictionary(Of Guna2ComboBox, Object)
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtAnswer1.Clear()
        txtAnswer2.Clear()
        txtAnswer3.Clear()
        cbquestion1.SelectedItem = Nothing
        cbquestion2.SelectedItem = Nothing
        cbquestion3.SelectedItem = Nothing
        cbquestion1.Items.Clear()
        cbquestion2.Items.Clear()
        cbquestion3.Items.Clear()
        For Each cbo As Guna2ComboBox In {cbquestion1, cbquestion2, cbquestion3}
            cbo.Items.Add("What is the name of your favorite pet?")
            cbo.Items.Add("What is your favorite music?")
            cbo.Items.Add("What is your best friend’s name?")
            cbo.Items.Add("What is the first name of your cousin?")
            cbo.Items.Add("What was your dream job as a child?")
            selectedOptions(cbo) = Nothing
        Next
        Me.Refresh()
    End Sub


    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If txtAnswer1.Text = "" Or txtAnswer2.Text = "" Or txtAnswer2.Text = "" Or cbquestion1.Text = "" Or cbquestion2.Text = "" Or cbquestion3.Text = "" Then
            MessageBox.Show("Fill the Required Fields.")
        Else
            A1 = txtAnswer1.Text
            A2 = txtAnswer2.Text
            A3 = txtAnswer3.Text
            Q1 = cbquestion1.Text
            Q2 = cbquestion2.Text
            Q3 = cbquestion3.Text
            Me.Hide()
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add the common options to each ComboBox
        For Each cbo As Guna2ComboBox In {cbquestion1, cbquestion2, cbquestion3}
            cbo.Items.Add("What is the name of your favorite pet?")
            cbo.Items.Add("What is your favorite music?")
            cbo.Items.Add("What is your best friend’s name?")
            cbo.Items.Add("What is the first name of your cousin?")
            cbo.Items.Add("What was your dream job as a child?")
            selectedOptions(cbo) = Nothing
        Next
    End Sub

    Private Sub ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbquestion1.SelectedValueChanged, cbquestion2.SelectedValueChanged, cbquestion3.SelectedValueChanged
        Dim selectedComboBox As Guna2ComboBox = DirectCast(sender, Guna2ComboBox)

        ' Remove the selected option from other ComboBox controls
        Dim selectedOption As Object = selectedComboBox.SelectedItem
        For Each cbo As Guna2ComboBox In {cbquestion1, cbquestion2, cbquestion3}
            If cbo IsNot selectedComboBox AndAlso cbo.Items.Contains(selectedOption) Then
                cbo.Items.Remove(selectedOption)
            End If
        Next

        ' Restore previously selected option to other ComboBox controls
        For Each cbo As Guna2ComboBox In {cbquestion1, cbquestion2, cbquestion3}
            If cbo IsNot selectedComboBox Then
                If selectedOptions(cbo) IsNot Nothing AndAlso Not cbo.Items.Contains(selectedOptions(cbo)) Then
                    cbo.Items.Add(selectedOptions(cbo))
                End If
            End If
        Next

        ' Update selectedOptions dictionary with the new selection for the specific ComboBox
        selectedOptions(selectedComboBox) = selectedOption
    End Sub
End Class