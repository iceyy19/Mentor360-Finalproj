﻿Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cms
Imports Org.BouncyCastle.Crypto.Agreement

Public Class Supervisor_Result
    Public ID As String = Login.ID
    Public EID As String
    Public Historyform As Supervisor_History
    Public time As String
    Public Property SelectedRowData As Dictionary(Of String, String)
    Private Sub Supervisor_Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSupervisorID.Text = ID
        lblSupervisorName.Text = Supervisor_Dashboard.Sname
        lblManager.Text = Supervisor_Dashboard.Mname
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

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub lblSDS1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblSDS2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim parsedtime As DateTime
        DateTime.TryParse(time, parsedtime)
        If txtDiscussion.Text = "" Then
            MessageBox.Show($"Please fill the required field for Discussion. {EID}")
        Else
            Dim myConnectionx As MySqlConnection
            Dim myCommandx As MySqlCommand

            myConnectionx = Connector.getDBConnection()
            Try
                myConnectionx.Open()
                myCommandx = New MySqlCommand($"UPDATE tblfeedback SET dDiscussion = '{txtDiscussion.Text}' WHERE dSupervisorID = '{ID}' and dEmployeeID = '{lblEmployeeID.Text}' and tEDateResponse = '{parsedtime.ToString("yyyy-MM-dd HH:mm:ss")}' ", myConnectionx)
                myCommandx.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                txtDiscussion.Clear()
                myConnectionx.Close()
                MessageBox.Show($"Thank you for Answering. Your Data has been saved. {EID}")

            End Try
            Using connection As MySqlConnection = Connector.getDBConnection()
                connection.Open()

                Dim query As String = $"SELECT dSupervisorID, dEmployeeID, tEDateResponse, dDiscussion FROM tblfeedback WHERE dSupervisorID = @SID and dEmployeeID = @EID and tEDateResponse = @Time"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SID", ID)
                    command.Parameters.AddWithValue("@EID", lblEmployeeID.Text)
                    command.Parameters.AddWithValue("@Time", parsedtime.ToString("yyyy-MM-dd HH:mm:ss"))

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then ' Check if there is at least one record
                            Dim dDiscussion As String = Convert.ToString(reader("dDiscussion"))
                            If String.IsNullOrEmpty(dDiscussion) Then
                                txtDiscussion.Enabled = True
                                btnsubmit.Show()
                            Else
                                txtDiscussion.Enabled = False
                                btnsubmit.Hide()
                                txtDiscussion.Text = Convert.ToString(reader("dDiscussion"))
                            End If
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel5.Paint

    End Sub
End Class