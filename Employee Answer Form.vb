Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports Guna
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI


Public Class Employee_Answer_Form
    Public ID As String = Login.ID
    Public eN As String
    Public sID As String
    Public sN As String
    Public mID As String
    Public mN As String
    Dim currentPage As Integer = 1
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
    Private Er1 As String
    Private Er2 As String
    Private Er3 As String
    Private Er4 As String
    Private Er5 As String
    Private Er6 As String
    Private Er7 As String
    Private ERating As Double


    Private Sub Employee_Answer_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbPage1.Checked = True
        lblEID.Text = ID
        lblEName.Text = eN
        lblSupervisor.Text = sID & ", " & sN
        lblManager.Text = mID & ", " & mN

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
            Er1 = txtSD.Text
            Er2 = txtSDA.Text
            Er3 = txtPS.Text
            Er4 = txtD.Text
            Er5 = txtCI.Text
            Er6 = txtCL.Text
            Er7 = txtP.Text
            CalculateFormula()
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
        End If
    End Sub

    Sub insertfeedback()
        Dim myConnectionx As MySqlConnection
        Dim myCommandx As MySqlCommand

        myConnectionx = Connector.getDBConnection()

        Try

            myConnectionx.Open()
            myCommandx = New MySqlCommand($"INSERT INTO tblfeedback (dEmployeeID, dEmployeeName, dSupervisorID, dSupervisorName, dManagerID, dManagerName, dEl1, dEl2, dEl3, dEl4, dEl5, dEl6, dEl7, dEl8
            , dEl9, dEl10, dEl11, dEl12, dEl13, dEl14, dEl15, dEl16, dEl17, dEl18, dEl19, dEl20, dEl21, dEl22, dEl23, dEl24, dEl25, dEl26, dEl27, dEl28, dEl29, dEl30, dEl31, dEl32, dEl33, dEl34, dEr1, dEr2, dEr3, dEr4, dEr5, dEr6, dEr7, tEDateResponse, dErating)
            VALUES ('{ID}', '{eN}','{sID}','{sN}','{mID}', '{mN}','{SD1}','{SD2}','{SD3}','{SD4}','{SD5}','{SD6}','{SD7}','{SD8}','{SD9}','{SD10}','{SD11}','{SD12}','{SD13}','{SD14}','{SD15}',
            '{SDA1}','{SDA2}','{PS1}','{D1}','{D2}','{CI1}','{CI2}','{CI3}','{CI4}','{CL1}','{CL2}','{CL3}','{P1}','{P2}','{P3}','{P4}','{P5}','{P6}','{P7}','{Er1}','{Er2}','{Er3}','{Er4}','{Er5}','{Er6}','{Er7}', CURRENT_TIMESTAMP(), '{ERating}')", myConnectionx)
            myCommandx.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally

            myConnectionx.Close()
            MessageBox.Show("Thank you for Answering, Your Data has been saved.")

        End Try
    End Sub

    Private Sub rbPage_CheckedChanged(sender As Object, e As EventArgs) Handles rbPage1.CheckedChanged, rbPage2.CheckedChanged, rbPage3.CheckedChanged
        ' Show/hide groupboxes based on the selected radiobutton
        gbPage1.Visible = rbPage1.Checked
        gbPage2.Visible = rbPage2.Checked
        gbPage3.Visible = rbPage3.Checked

        ' Update the current page variable
        If rbPage1.Checked Then
            currentPage = 1
        ElseIf rbPage2.Checked Then
            currentPage = 2
        ElseIf rbPage3.Checked Then
            currentPage = 3
        End If
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

        ERating = 0.00

        If (yesCount + noCount) > 0 Then
            ERating = Math.Round((yesCount / (yesCount + noCount)) * 5, 2)
        Else
            ' Handle the case where there are no Yes or No responses
            ERating = 0.00
        End If

        ERating.ToString()
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
        ERating = Nothing
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
