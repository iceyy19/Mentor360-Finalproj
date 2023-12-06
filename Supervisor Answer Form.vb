
Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms


Public Class Supervisor_Answer_Form
    Dim currentRowIndex As Integer = 0
    Dim totalRowCount As Integer = 0
    Private eID As String
    Private SD1 As String
    Private SD2 As String
    Private SD3 As String
    Private SD4 As String
    Private SD5 As String
    Private SD6 As String
    Private SD7 As String
    Private SD8 As String
    Private SD9 As String
    Private SD10 As String
    Private SD11 As String
    Private SD12 As String
    Private SD13 As String
    Private SD14 As String
    Private SD15 As String
    Private SDA1 As String
    Private SDA2 As String
    Private PS1 As String
    Private D1 As String
    Private D2 As String
    Private CI1 As String
    Private CI2 As String
    Private CI3 As String
    Private CI4 As String
    Private CL1 As String
    Private CL2 As String
    Private CL3 As String
    Private P1 As String
    Private P2 As String
    Private P3 As String
    Private P4 As String
    Private P5 As String
    Private P6 As String
    Private P7 As String
    Private Sr1 As String
    Private Sr2 As String
    Private Sr3 As String
    Private Sr4 As String
    Private Sr5 As String
    Private Sr6 As String
    Private Sr7 As String
    Private Sub lblSupervisor_Click(sender As Object, e As EventArgs) Handles lblManager.Click

    End Sub

    Private Sub Supervisor_Answer_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbPage2.Visible = False
        gbPage3.Visible = False
        rbPage1.Checked = True
        LoadNextRow()
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

    Private Sub gbPage2_Click(sender As Object, e As EventArgs) Handles gbPage2.Click

    End Sub

    Private Sub LoadNextRow()
        ' Connect to the MySQL database
        Using connection As MySqlConnection = Connector.getDBConnection()
            connection.Open()

            ' Query to retrieve all rows for a specific supervisor ordered by tEDateResponse in descending order
            Dim query As String = $"SELECT dSupervisorID, dEmployeeID, dSl1, dSr1, tEDateResponse FROM tblfeedback WHERE dSupervisorID = @SupervisorID ORDER BY tEDateResponse ASC"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@SupervisorID", "2022") ' Replace with the actual supervisor ID

                ' Execute the query
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Move to the desired row index
                    Dim currentIndex As Integer = 0
                    Dim totalNullOrEmptyDSl1Count As Integer = 0 ' Count for all rows

                    While currentIndex <= currentRowIndex AndAlso reader.Read()
                        ' Check if dSl1 is null or empty in the current row
                        Dim dSl1Value As String = Convert.ToString(reader("dSl1"))
                        If String.IsNullOrEmpty(dSl1Value) Then
                            ' Enable input controls for the user to enter data
                            EnableGroupBoxes()
                            totalNullOrEmptyDSl1Count += 1
                        Else
                            ' Disable input controls if dSl1 is not null or empty
                            DisableGroupBoxes()
                        End If

                        ' Display the data in the current row
                        ' Example: txtSl1.Text = dSl1Value

                        eID = Convert.ToString(reader("dEmployeeID"))
                        currentIndex += 1
                    End While

                    ' Update the label to show the total count of rows where dSl1 is null or empty
                    lblNeedToBeAnswered.Text = GetTotalNullOrEmptyDSl1Count().ToString()
                End Using
            End Using
        End Using
    End Sub

    Private Function GetTotalNullOrEmptyDSl1Count() As Integer
        Dim totalNullOrEmptyDSl1Count As Integer = 0

        ' Connect to the MySQL database
        Using connection As MySqlConnection = Connector.getDBConnection()
            connection.Open()

            ' Query to count the total number of rows with null or empty dSl1
            Dim query As String = $"SELECT COUNT(*) FROM tblfeedback WHERE dSupervisorID = @SupervisorID AND (dSl1 IS NULL OR TRIM(dSl1) = '')"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@SupervisorID", "2022") ' Replace with the actual supervisor ID

                ' Execute the query
                totalNullOrEmptyDSl1Count = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return totalNullOrEmptyDSl1Count
    End Function

    Private Sub EnableGroupBoxes()
        ' Enable all group boxes
        gbSD1.Enabled = True
        gbSD2.Enabled = True
        gbSD3.Enabled = True
        gbSD4.Enabled = True
        gbSD5.Enabled = True
        gbSD6.Enabled = True
        gbSD7.Enabled = True
        gbSD8.Enabled = True
        gbSD9.Enabled = True
        gbSD10.Enabled = True
        gbSD11.Enabled = True
        gbSD12.Enabled = True
        gbSD13.Enabled = True
        gbSD14.Enabled = True
        gbSD15.Enabled = True

        gbSDA1.Enabled = True
        gbSDA2.Enabled = True
        gbPS1.Enabled = True
        gbD1.Enabled = True
        gbD2.Enabled = True

        gbCI1.Enabled = True
        gbCI2.Enabled = True
        gbCI3.Enabled = True
        gbCI4.Enabled = True

        gbCL1.Enabled = True
        gbCL2.Enabled = True
        gbCL3.Enabled = True

        gbP1.Enabled = True
        gbP2.Enabled = True
        gbP3.Enabled = True
        gbP4.Enabled = True
        gbP5.Enabled = True
        gbP6.Enabled = True
        gbP7.Enabled = True

        txtSD.Enabled = True
        txtSDA.Enabled = True
        txtPS.Enabled = True
        txtD.Enabled = True
        txtCI.Enabled = True
        txtCL.Enabled = True
        txtP.Enabled = True
    End Sub
    Private Sub DisableGroupBoxes()
        ' Disable all group boxes
        gbSD1.Enabled = False
        gbSD2.Enabled = False
        gbSD3.Enabled = False
        gbSD4.Enabled = False
        gbSD5.Enabled = False
        gbSD6.Enabled = False
        gbSD7.Enabled = False
        gbSD8.Enabled = False
        gbSD9.Enabled = False
        gbSD10.Enabled = False
        gbSD11.Enabled = False
        gbSD12.Enabled = False
        gbSD13.Enabled = False
        gbSD14.Enabled = False
        gbSD15.Enabled = False

        gbSDA1.Enabled = False
        gbSDA2.Enabled = False
        gbPS1.Enabled = False
        gbD1.Enabled = False
        gbD2.Enabled = False

        gbCI1.Enabled = False
        gbCI2.Enabled = False
        gbCI3.Enabled = False
        gbCI4.Enabled = False

        gbCL1.Enabled = False
        gbCL2.Enabled = False
        gbCL3.Enabled = False

        gbP1.Enabled = False
        gbP2.Enabled = False
        gbP3.Enabled = False
        gbP4.Enabled = False
        gbP5.Enabled = False
        gbP6.Enabled = False
        gbP6.Enabled = False
        gbP7.Enabled = False

        txtSD.Enabled = False
        txtSDA.Enabled = False
        txtPS.Enabled = False
        txtD.Enabled = False
        txtCI.Enabled = False
        txtCL.Enabled = False
        txtP.Enabled = False
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If SD1 Is Nothing OrElse txtSD.Text = "" Then

            ' Show MessageBox if any variable is Nothing
            MessageBox.Show("Please select a value for all options.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Sr1 = txtSD.Text
            insertfeedback()
            ClearRadioButtons()
            ResetVariables()
            txtSD.Clear()
            txtSDA.Clear()
            txtPS.Clear()
            txtD.Clear()
            txtCI.Clear()
            txtCL.Clear()
            txtP.Clear()
            currentRowIndex += 1
            LoadNextRow()
        End If

    End Sub
    Sub insertfeedback()
        Dim myConnectionx As MySqlConnection
        Dim myCommandx As MySqlCommand

        myConnectionx = Connector.getDBConnection()

        Try

            myConnectionx.Open()
            myCommandx = New MySqlCommand($"UPDATE tblfeedback SET dSl1 = '{SD1}', dSr1 = '{Sr1}' WHERE dEmployeeID = '{eID}'", myConnectionx)
            myCommandx.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally

            myConnectionx.Close()
            MessageBox.Show($"Thank you for Answering. Your Data has been saved. {eID}")

        End Try
    End Sub
    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) _
    Handles rbYesSD1.CheckedChanged, rbNoSD1.CheckedChanged, rbNASD1.CheckedChanged
        ' Event handler for radio button selection change
        Dim selectedRadioButton = DirectCast(sender, RadioButton)

        If selectedRadioButton.Checked Then
            ' Identify the group (SD1, SD2, etc.) using the Tag property
            Dim groupTag As String = selectedRadioButton.Parent.Tag.ToString()

            ' Save the selected radio button's text or any other value you want
            Select Case groupTag
                Case "SD1"
                    SD1 = selectedRadioButton.Text

            End Select
        End If
    End Sub

    Private Sub ResetVariables()
        SDA1 = Nothing
        SDA2 = Nothing
        PS1 = Nothing
        D1 = Nothing
        D2 = Nothing
        CI1 = Nothing
        CI2 = Nothing
        CI3 = Nothing
        CI4 = Nothing
        CL1 = Nothing
        CL2 = Nothing
        CL3 = Nothing
        P1 = Nothing
        P2 = Nothing
        P3 = Nothing
        P4 = Nothing
        P5 = Nothing
        P6 = Nothing
        P7 = Nothing
        SD1 = Nothing
        SD2 = Nothing
        SD3 = Nothing
        SD4 = Nothing
        SD5 = Nothing
        SD6 = Nothing
        SD7 = Nothing
        SD8 = Nothing
        SD9 = Nothing
        SD10 = Nothing
        SD11 = Nothing
        SD12 = Nothing
        SD13 = Nothing
        SD14 = Nothing
        SD15 = Nothing
    End Sub

    Private Sub ClearRadioButtons()
        ' Clear the selected radio buttons for specific groups
        ClearGroupRadioButtons(gbSD1)
        ClearGroupRadioButtons(gbSD2)
        ClearGroupRadioButtons(gbSD3)
        ClearGroupRadioButtons(gbSD4)
        ClearGroupRadioButtons(gbSD5)
        ClearGroupRadioButtons(gbSD6)
        ClearGroupRadioButtons(gbSD7)
        ClearGroupRadioButtons(gbSD8)
        ClearGroupRadioButtons(gbSD9)
        ClearGroupRadioButtons(gbSD10)
        ClearGroupRadioButtons(gbSD11)
        ClearGroupRadioButtons(gbSD12)
        ClearGroupRadioButtons(gbSD13)
        ClearGroupRadioButtons(gbSD14)
        ClearGroupRadioButtons(gbSD15)
        ClearGroupRadioButtons(gbSDA1)
        ClearGroupRadioButtons(gbSDA2)
        ClearGroupRadioButtons(gbPS1)
        ClearGroupRadioButtons(gbD1)
        ClearGroupRadioButtons(gbD2)
        ClearGroupRadioButtons(gbCI1)
        ClearGroupRadioButtons(gbCI2)
        ClearGroupRadioButtons(gbCI3)
        ClearGroupRadioButtons(gbCI4)
        ClearGroupRadioButtons(gbCL1)
        ClearGroupRadioButtons(gbCL2)
        ClearGroupRadioButtons(gbCL3)
        ClearGroupRadioButtons(gbP1)
        ClearGroupRadioButtons(gbP2)
        ClearGroupRadioButtons(gbP3)
        ClearGroupRadioButtons(gbP4)
        ClearGroupRadioButtons(gbP5)
        ClearGroupRadioButtons(gbP6)
        ClearGroupRadioButtons(gbP7)
    End Sub

    Private Sub ClearGroupRadioButtons(groupBox As Guna2GroupBox)
        ' Set the Checked property of radio buttons in the specified group box to False
        For Each radioBtn As RadioButton In groupBox.Controls.OfType(Of RadioButton)()
            radioBtn.Checked = False
        Next
    End Sub
End Class