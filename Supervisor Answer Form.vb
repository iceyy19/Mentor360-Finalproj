
Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms


Public Class Supervisor_Answer_Form
    Public ID As String = Login.ID
    Private eID As String
    Private eName As String
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
    Private SRating As String
    Private Sub lblSupervisor_Click(sender As Object, e As EventArgs) Handles lblManager.Click

    End Sub

    Private Sub Supervisor_Answer_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbPage2.Visible = False
        gbPage3.Visible = False
        rbPage1.Checked = True
        LoadNextRow()
        lblSupervisorID.Text = ID
        lblEmployeeID.Text = eID
        lblEmployeeName.Text = eName
        lblSupervisorName.Text = Supervisor_Dashboard.Sname
        lblManager.Text = Supervisor_Dashboard.Mname

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
            Dim query As String = $"SELECT dSupervisorID, dEmployeeID, dEmployeeName, dSl1, dSr1, tEDateResponse FROM tblfeedback WHERE dSupervisorID = @SupervisorID ORDER BY tEDateResponse ASC"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@SupervisorID", ID) ' Replace with the actual supervisor ID

                ' Execute the query
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Check if there is no data for the provided SupervisorID
                    If Not reader.HasRows Then
                        ' No data found, disable group boxes
                        DisableGroupBoxes()
                        ' Set the label to indicate zero rows
                        lblNeedToBeAnswered.Text = "0"
                        Exit Sub
                    End If

                    ' Move to the desired row index
                    Dim currentIndex As Integer = 0
                    Dim hasDataInDSl1OrDSr1 As Boolean = False

                    While reader.Read()
                        Dim dSl1Value As String = If(reader("dSl1") IsNot DBNull.Value, reader("dSl1").ToString(), String.Empty)
                        Dim dSr1Value As String = If(reader("dSr1") IsNot DBNull.Value, reader("dSr1").ToString(), String.Empty)

                        If String.IsNullOrEmpty(dSl1Value) Or String.IsNullOrEmpty(dSr1Value) Then
                            EnableGroupBoxes()
                            lblNeedToBeAnswered.Text = (GetTotalRowsWithNullOrEmptyDSl1OrDSr1().ToString())
                            hasDataInDSl1OrDSr1 = True
                            eID = Convert.ToString(reader("dEmployeeID"))
                            eName = Convert.ToString(reader("dEmployeeName"))
                            lblEmployeeID.Text = eID
                            lblEmployeeName.Text = eName
                            Exit Sub
                        Else
                            DisableGroupBoxes()
                        End If

                    End While

                End Using
            End Using
        End Using
    End Sub

    Private Function GetTotalRowsWithNullOrEmptyDSl1OrDSr1() As Integer
        Dim totalRowsWithNullOrEmptyDSl1OrDSr1 As Integer = 0

        ' Connect to the MySQL database
        Using connection As MySqlConnection = Connector.getDBConnection()
            connection.Open()

            ' Query to count the total number of rows with null or empty dSl1 or dSr1
            Dim query As String = $"SELECT COUNT(*) FROM tblfeedback WHERE dSupervisorID = @SupervisorID AND (dSl1 IS NULL OR TRIM(dSl1) = '') AND (dSr1 IS NULL OR TRIM(dSr1) = '')"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@SupervisorID", ID) ' Replace with the actual supervisor ID

                ' Execute the query
                totalRowsWithNullOrEmptyDSl1OrDSr1 = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return totalRowsWithNullOrEmptyDSl1OrDSr1
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
        If SD1 Is Nothing OrElse SD2 Is Nothing OrElse SD3 Is Nothing OrElse SD4 Is Nothing _
        OrElse SD5 Is Nothing OrElse SD6 Is Nothing OrElse SD7 Is Nothing OrElse SD8 Is Nothing _
        OrElse SD9 Is Nothing OrElse SD10 Is Nothing OrElse SD11 Is Nothing OrElse SD12 Is Nothing _
        OrElse SD13 Is Nothing OrElse SD14 Is Nothing OrElse SD15 Is Nothing _
        OrElse SDA1 Is Nothing OrElse SDA2 Is Nothing OrElse PS1 Is Nothing OrElse D1 Is Nothing OrElse D2 Is Nothing _
        OrElse CI1 Is Nothing OrElse CI2 Is Nothing OrElse CI3 Is Nothing OrElse CI4 Is Nothing _
        OrElse CL1 Is Nothing OrElse CL2 Is Nothing OrElse CL3 Is Nothing _
        OrElse P1 Is Nothing OrElse P2 Is Nothing OrElse P3 Is Nothing OrElse P4 Is Nothing _
        OrElse P5 Is Nothing OrElse P6 Is Nothing OrElse P7 Is Nothing OrElse txtSD.Text = "" OrElse txtSDA.Text = "" OrElse txtPS.Text _
        = "" OrElse txtD.Text = "" OrElse txtCI.Text = "" OrElse txtCL.Text = "" OrElse txtP.Text = "" Then

            ' Show MessageBox if any variable is Nothing
            MessageBox.Show("Please select a value for all options.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Sr1 = txtSD.Text
            Sr2 = txtSDA.Text
            Sr3 = txtPS.Text
            Sr4 = txtD.Text
            Sr5 = txtCI.Text
            Sr6 = txtCL.Text
            Sr7 = txtP.Text
            CalculateFormula()
            updatefeedback()
            ClearRadioButtons()
            ResetVariables()
            LoadNextRow()
            txtSD.Clear()
            txtSDA.Clear()
            txtPS.Clear()
            txtD.Clear()
            txtCI.Clear()
            txtCL.Clear()
            txtP.Clear()

        End If

    End Sub
    Sub updatefeedback()
        Dim myConnectionx As MySqlConnection
        Dim myCommandx As MySqlCommand

        myConnectionx = Connector.getDBConnection()

        Try

            myConnectionx.Open()
            myCommandx = New MySqlCommand($"UPDATE tblfeedback SET dSl1 = '{SD1}', dSl2 = '{SD2}', dSl3 = '{SD3}', dSl4 = '{SD4}', dSl5 = '{SD5}', dSl6 = '{SD6}', dSl7 = '{SD7}',
            dSl8 = '{SD8}', dSl9 = '{SD9}', dSl10 = '{SD10}', dSl11 = '{SD11}', dSl12 = '{SD12}', dSl13 = '{SD13}', dSl14 = '{SD14}', dSl15 = '{SD15}', dSl16 = '{SDA1}', dSl17 = '{SDA2}', dSl18 = '{PS1}',
            dSl19 = '{D1}', dSl20 = '{D2}', dSl21 = '{CI1}', dSl22 = '{CI2}', dSl23 = '{CI3}', dSl24 = '{CI4}', dSl25 = '{CL1}', dSl26 = '{CL2}', dSl27 = '{CL3}', dSl28 = '{P1}',
            dSl29 = '{P2}', dSl30 = '{P3}', dSl31 = '{P4}', dSl32 = '{P5}', dSl33 = '{P6}', dSl34 = '{P7}', dSr1 = '{Sr1}', dSr2 = '{Sr2}', dSr3 = '{Sr3}', dSr4 = '{Sr4}', 
            dSr5 = '{Sr5}', dSr6 = '{Sr6}', dSr7 = '{Sr7}', tSDateResponse =  CURRENT_TIMESTAMP(), dSrating = '{SRating}' WHERE dEmployeeID = '{eID}'", myConnectionx)
            myCommandx.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally

            myConnectionx.Close()
            MessageBox.Show($"Thank you for Answering. Your Data has been saved. {eID}")

        End Try
    End Sub
    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) _
    Handles rbYesSD1.CheckedChanged, rbNoSD1.CheckedChanged, rbNASD1.CheckedChanged,
            rbYesSD2.CheckedChanged, rbNoSD2.CheckedChanged, rbNASD2.CheckedChanged,
            rbYesSD3.CheckedChanged, rbNoSD3.CheckedChanged, rbNASD3.CheckedChanged,
            rbYesSD4.CheckedChanged, rbNoSD4.CheckedChanged, rbNASD4.CheckedChanged,
            rbYesSD5.CheckedChanged, rbNoSD5.CheckedChanged, rbNASD5.CheckedChanged,
            rbYesSD6.CheckedChanged, rbNoSD6.CheckedChanged, rbNASD6.CheckedChanged,
            rbYesSD7.CheckedChanged, rbNoSD7.CheckedChanged, rbNASD7.CheckedChanged,
            rbYesSD8.CheckedChanged, rbNoSD8.CheckedChanged, rbNASD8.CheckedChanged,
            rbYesSD9.CheckedChanged, rbNoSD9.CheckedChanged, rbNASD9.CheckedChanged,
            rbYesSD10.CheckedChanged, rbNoSD10.CheckedChanged, rbNASD10.CheckedChanged,
            rbYesSD11.CheckedChanged, rbNoSD11.CheckedChanged, rbNASD11.CheckedChanged,
            rbYesSD12.CheckedChanged, rbNoSD12.CheckedChanged, rbNASD12.CheckedChanged,
            rbYesSD13.CheckedChanged, rbNoSD13.CheckedChanged, rbNASD13.CheckedChanged,
            rbYesSD14.CheckedChanged, rbNoSD14.CheckedChanged, rbNASD14.CheckedChanged,
            rbYesSD15.CheckedChanged, rbNoSD15.CheckedChanged, rbNASD15.CheckedChanged,
            rbYESSDA1.CheckedChanged, rbNOSDA1.CheckedChanged, rbNASDA1.CheckedChanged,
            rbYESSDA2.CheckedChanged, rbNOSDA2.CheckedChanged, rbNASDA2.CheckedChanged,
            rbYESPS1.CheckedChanged, rbNOPS1.CheckedChanged, rbNAPS1.CheckedChanged,
            rbYESD1.CheckedChanged, rbNOD1.CheckedChanged, rbNAD1.CheckedChanged,
            rbYESD2.CheckedChanged, rbNOD2.CheckedChanged, rbNAD2.CheckedChanged,
            rbYESCI1.CheckedChanged, rbNOCI1.CheckedChanged, rbNACI1.CheckedChanged,
            rbYESCI2.CheckedChanged, rbNOCI2.CheckedChanged, rbNACI2.CheckedChanged,
            rbYESCI3.CheckedChanged, rbNOCI3.CheckedChanged, rbNACI3.CheckedChanged,
            rbYESCI4.CheckedChanged, rbNOCI4.CheckedChanged, rbNACI4.CheckedChanged,
            rbYESCL1.CheckedChanged, rbNOCL1.CheckedChanged, rbNACL1.CheckedChanged,
            rbYESCL2.CheckedChanged, rbNOCL2.CheckedChanged, rbNACL2.CheckedChanged,
            rbYESCL3.CheckedChanged, rbNOCL3.CheckedChanged, rbNACL3.CheckedChanged,
            rbYESP1.CheckedChanged, rbNOP1.CheckedChanged, rbNAP1.CheckedChanged,
            rbYESP2.CheckedChanged, rbNOP2.CheckedChanged, rbNAP2.CheckedChanged,
            rbYESP3.CheckedChanged, rbNOP3.CheckedChanged, rbNAP3.CheckedChanged,
            rbYESP4.CheckedChanged, rbNOP4.CheckedChanged, rbNAP4.CheckedChanged,
            rbYESP5.CheckedChanged, rbNOP5.CheckedChanged, rbNAP5.CheckedChanged,
            rbYESP6.CheckedChanged, rbNOP6.CheckedChanged, rbNAP6.CheckedChanged,
            rbYESP7.CheckedChanged, rbNOP7.CheckedChanged, rbNAP7.CheckedChanged
        ' Event handler for radio button selection change
        Dim selectedRadioButton = DirectCast(sender, RadioButton)

        If selectedRadioButton.Checked Then
            ' Identify the group (SD1, SD2, etc.) using the Tag property
            Dim groupTag As String = selectedRadioButton.Parent.Tag.ToString()

            ' Save the selected radio button's text or any other value you want
            Select Case groupTag
                Case "SD1"
                    SD1 = selectedRadioButton.Text
                Case "SD2"
                    SD2 = selectedRadioButton.Text
                Case "SD3"
                    SD3 = selectedRadioButton.Text
                Case "SD4"
                    SD4 = selectedRadioButton.Text
                Case "SD5"
                    SD5 = selectedRadioButton.Text
                Case "SD6"
                    SD6 = selectedRadioButton.Text
                Case "SD7"
                    SD7 = selectedRadioButton.Text
                Case "SD8"
                    SD8 = selectedRadioButton.Text
                Case "SD9"
                    SD9 = selectedRadioButton.Text
                Case "SD10"
                    SD10 = selectedRadioButton.Text
                Case "SD11"
                    SD11 = selectedRadioButton.Text
                Case "SD12"
                    SD12 = selectedRadioButton.Text
                Case "SD13"
                    SD13 = selectedRadioButton.Text
                Case "SD14"
                    SD14 = selectedRadioButton.Text
                Case "SD15"
                    SD15 = selectedRadioButton.Text
                Case "SDA1"
                    SDA1 = selectedRadioButton.Text
                Case "SDA2"
                    SDA2 = selectedRadioButton.Text
                Case "PS1"
                    PS1 = selectedRadioButton.Text
                Case "DD1"
                    D1 = selectedRadioButton.Text
                Case "DD2"
                    D2 = selectedRadioButton.Text
                Case "CI1"
                    CI1 = selectedRadioButton.Text
                Case "CI2"
                    CI2 = selectedRadioButton.Text
                Case "CI3"
                    CI3 = selectedRadioButton.Text
                Case "CI4"
                    CI4 = selectedRadioButton.Text
                Case "CL1"
                    CL1 = selectedRadioButton.Text
                Case "CL2"
                    CL2 = selectedRadioButton.Text
                Case "CL3"
                    CL3 = selectedRadioButton.Text
                Case "P1"
                    P1 = selectedRadioButton.Text
                Case "P2"
                    P2 = selectedRadioButton.Text
                Case "P3"
                    P3 = selectedRadioButton.Text
                Case "P4"
                    P4 = selectedRadioButton.Text
                Case "P5"
                    P5 = selectedRadioButton.Text
                Case "P6"
                    P6 = selectedRadioButton.Text
                Case "P7"
                    P7 = selectedRadioButton.Text
            End Select
        End If
    End Sub
    Private Sub CalculateFormula()
        Dim yesCount As Integer = 0
        Dim noCount As Integer = 0
        Dim naCount As Integer = 0

        CountOption(SD1, yesCount, noCount, naCount)
        CountOption(SD2, yesCount, noCount, naCount)
        CountOption(SD3, yesCount, noCount, naCount)
        CountOption(SD4, yesCount, noCount, naCount)
        CountOption(SD5, yesCount, noCount, naCount)
        CountOption(SD6, yesCount, noCount, naCount)
        CountOption(SD7, yesCount, noCount, naCount)
        CountOption(SD8, yesCount, noCount, naCount)
        CountOption(SD9, yesCount, noCount, naCount)
        CountOption(SD10, yesCount, noCount, naCount)
        CountOption(SD11, yesCount, noCount, naCount)
        CountOption(SD12, yesCount, noCount, naCount)
        CountOption(SD13, yesCount, noCount, naCount)
        CountOption(SD14, yesCount, noCount, naCount)
        CountOption(SD15, yesCount, noCount, naCount)
        CountOption(SDA1, yesCount, noCount, naCount)
        CountOption(SDA2, yesCount, noCount, naCount)
        CountOption(PS1, yesCount, noCount, naCount)
        CountOption(D1, yesCount, noCount, naCount)
        CountOption(D2, yesCount, noCount, naCount)
        CountOption(CI1, yesCount, noCount, naCount)
        CountOption(CI2, yesCount, noCount, naCount)
        CountOption(CI3, yesCount, noCount, naCount)
        CountOption(CI4, yesCount, noCount, naCount)
        CountOption(CL1, yesCount, noCount, naCount)
        CountOption(CL2, yesCount, noCount, naCount)
        CountOption(CL3, yesCount, noCount, naCount)
        CountOption(P1, yesCount, noCount, naCount)
        CountOption(P2, yesCount, noCount, naCount)
        CountOption(P3, yesCount, noCount, naCount)
        CountOption(P4, yesCount, noCount, naCount)
        CountOption(P5, yesCount, noCount, naCount)
        CountOption(P6, yesCount, noCount, naCount)
        CountOption(P7, yesCount, noCount, naCount)

        Dim result As Double = 0.0

        If (yesCount + noCount) > 0 Then
            result = Math.Round((yesCount / (yesCount + noCount)) * 5, 2)
        Else
            ' Handle the case where there are no Yes or No responses
            result = 0.0
        End If

        SRating = result.ToString()

    End Sub

    Private Sub CountOption(optionValue As String, ByRef yesCount As Integer, ByRef noCount As Integer, ByRef naCount As Integer)
        ' Update counters based on the option value
        Select Case optionValue
            Case "Yes"
                yesCount += 1
            Case "No"
                noCount += 1
            Case "NA"
                naCount += 1
        End Select
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
        eID = Nothing
        eName = Nothing
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