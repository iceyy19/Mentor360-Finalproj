﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supervisor_History
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        lblManager = New Label()
        lblSupervisorID = New Label()
        lblSupervisorName = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnSelect = New Guna.UI2.WinForms.Guna2Button()
        dgHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        btnExport = New Guna.UI2.WinForms.Guna2Button()
        CType(dgHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Shapes1
        ' 
        Guna2Shapes1.FillColor = Color.Gray
        Guna2Shapes1.Location = New Point(-92, 98)
        Guna2Shapes1.Name = "Guna2Shapes1"
        Guna2Shapes1.PolygonSkip = 1
        Guna2Shapes1.Rotate = 0F
        Guna2Shapes1.RoundedEdges = CustomizableEdges1
        Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Guna2Shapes1.Size = New Size(1103, 3)
        Guna2Shapes1.TabIndex = 70
        Guna2Shapes1.Text = "Guna2Shapes1"
        Guna2Shapes1.Zoom = 80
        ' 
        ' lblManager
        ' 
        lblManager.AutoSize = True
        lblManager.Location = New Point(736, 31)
        lblManager.Name = "lblManager"
        lblManager.Size = New Size(53, 20)
        lblManager.TabIndex = 69
        lblManager.Tag = "lblManager"
        lblManager.Text = "Label8"
        ' 
        ' lblSupervisorID
        ' 
        lblSupervisorID.AutoSize = True
        lblSupervisorID.Location = New Point(147, 65)
        lblSupervisorID.Name = "lblSupervisorID"
        lblSupervisorID.Size = New Size(53, 20)
        lblSupervisorID.TabIndex = 67
        lblSupervisorID.Tag = "lblSupervisorID"
        lblSupervisorID.Text = "Label6"
        ' 
        ' lblSupervisorName
        ' 
        lblSupervisorName.AutoSize = True
        lblSupervisorName.Location = New Point(147, 31)
        lblSupervisorName.Name = "lblSupervisorName"
        lblSupervisorName.Size = New Size(53, 20)
        lblSupervisorName.TabIndex = 64
        lblSupervisorName.Tag = "lblSupervisorName"
        lblSupervisorName.Text = "Label5"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(649, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 20)
        Label4.TabIndex = 66
        Label4.Text = "Manager:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(19, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 63
        Label2.Text = "Supervisor ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(19, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 20)
        Label1.TabIndex = 62
        Label1.Text = "Supervisor Name:"
        ' 
        ' btnSelect
        ' 
        btnSelect.BackColor = Color.WhiteSmoke
        btnSelect.CustomizableEdges = CustomizableEdges2
        btnSelect.DisabledState.BorderColor = Color.DarkGray
        btnSelect.DisabledState.CustomBorderColor = Color.DarkGray
        btnSelect.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSelect.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSelect.FillColor = Color.FromArgb(CByte(17), CByte(16), CByte(68))
        btnSelect.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSelect.ForeColor = Color.White
        btnSelect.Location = New Point(19, 662)
        btnSelect.Name = "btnSelect"
        btnSelect.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        btnSelect.Size = New Size(113, 43)
        btnSelect.TabIndex = 61
        btnSelect.Tag = "btnSelect"
        btnSelect.Text = "Select"
        ' 
        ' dgHistory
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgHistory.BorderStyle = BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgHistory.ColumnHeadersHeight = 4
        dgHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgHistory.DefaultCellStyle = DataGridViewCellStyle3
        dgHistory.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgHistory.Location = New Point(19, 121)
        dgHistory.Name = "dgHistory"
        dgHistory.RowHeadersVisible = False
        dgHistory.RowHeadersWidth = 51
        dgHistory.RowTemplate.Height = 29
        dgHistory.Size = New Size(882, 521)
        dgHistory.TabIndex = 59
        dgHistory.Tag = "dgHistory"
        dgHistory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgHistory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgHistory.ThemeStyle.BackColor = Color.White
        dgHistory.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgHistory.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgHistory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgHistory.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgHistory.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgHistory.ThemeStyle.HeaderStyle.Height = 4
        dgHistory.ThemeStyle.ReadOnly = False
        dgHistory.ThemeStyle.RowsStyle.BackColor = Color.White
        dgHistory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgHistory.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgHistory.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgHistory.ThemeStyle.RowsStyle.Height = 29
        dgHistory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgHistory.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.WhiteSmoke
        btnExport.CustomizableEdges = CustomizableEdges4
        btnExport.DisabledState.BorderColor = Color.DarkGray
        btnExport.DisabledState.CustomBorderColor = Color.DarkGray
        btnExport.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnExport.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnExport.FillColor = Color.Maroon
        btnExport.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnExport.ForeColor = Color.White
        btnExport.Location = New Point(788, 662)
        btnExport.Name = "btnExport"
        btnExport.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        btnExport.Size = New Size(113, 43)
        btnExport.TabIndex = 60
        btnExport.Tag = "btnExport"
        btnExport.Text = "Export"
        ' 
        ' Supervisor_History
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(918, 736)
        ControlBox = False
        Controls.Add(Guna2Shapes1)
        Controls.Add(lblManager)
        Controls.Add(lblSupervisorID)
        Controls.Add(lblSupervisorName)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSelect)
        Controls.Add(dgHistory)
        Controls.Add(btnExport)
        Name = "Supervisor_History"
        CType(dgHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents lblManager As Label
    Friend WithEvents lblSupervisorID As Label
    Friend WithEvents lblSupervisorName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSelect As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgHistory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
End Class
