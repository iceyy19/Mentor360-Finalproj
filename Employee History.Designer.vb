<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_History
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        dgHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        btnExport = New Guna.UI2.WinForms.Guna2Button()
        lblManager = New Label()
        lblSupervisor = New Label()
        lblEmployeeID = New Label()
        lblEmployeeName = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        btnSelect = New Guna.UI2.WinForms.Guna2Button()
        CType(dgHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgHistory
        ' 
        dgHistory.AllowUserToAddRows = False
        dgHistory.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgHistory.ColumnHeadersHeight = 20
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
        dgHistory.Location = New Point(17, 91)
        dgHistory.Margin = New Padding(3, 2, 3, 2)
        dgHistory.Name = "dgHistory"
        dgHistory.ReadOnly = True
        dgHistory.RowHeadersVisible = False
        dgHistory.RowHeadersWidth = 51
        dgHistory.RowTemplate.Height = 29
        dgHistory.Size = New Size(772, 391)
        dgHistory.TabIndex = 0
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
        dgHistory.ThemeStyle.HeaderStyle.Height = 20
        dgHistory.ThemeStyle.ReadOnly = True
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
        btnExport.CustomizableEdges = CustomizableEdges1
        btnExport.DisabledState.BorderColor = Color.DarkGray
        btnExport.DisabledState.CustomBorderColor = Color.DarkGray
        btnExport.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnExport.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnExport.FillColor = Color.Maroon
        btnExport.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnExport.ForeColor = Color.White
        btnExport.Location = New Point(690, 496)
        btnExport.Margin = New Padding(3, 2, 3, 2)
        btnExport.Name = "btnExport"
        btnExport.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnExport.Size = New Size(99, 32)
        btnExport.TabIndex = 8
        btnExport.Tag = "btnExport"
        btnExport.Text = "Export"
        ' 
        ' lblManager
        ' 
        lblManager.AutoSize = True
        lblManager.Location = New Point(642, 49)
        lblManager.Name = "lblManager"
        lblManager.Size = New Size(41, 15)
        lblManager.TabIndex = 19
        lblManager.Tag = "lblManager"
        lblManager.Text = "Label8"
        ' 
        ' lblSupervisor
        ' 
        lblSupervisor.AutoSize = True
        lblSupervisor.Location = New Point(642, 23)
        lblSupervisor.Name = "lblSupervisor"
        lblSupervisor.Size = New Size(41, 15)
        lblSupervisor.TabIndex = 18
        lblSupervisor.Tag = "lblSupervisor"
        lblSupervisor.Text = "Label7"
        ' 
        ' lblEmployeeID
        ' 
        lblEmployeeID.AutoSize = True
        lblEmployeeID.Location = New Point(129, 49)
        lblEmployeeID.Name = "lblEmployeeID"
        lblEmployeeID.Size = New Size(41, 15)
        lblEmployeeID.TabIndex = 17
        lblEmployeeID.Tag = "lblEmployeeID"
        lblEmployeeID.Text = "Label6"
        ' 
        ' lblEmployeeName
        ' 
        lblEmployeeName.AutoSize = True
        lblEmployeeName.Location = New Point(129, 23)
        lblEmployeeName.Name = "lblEmployeeName"
        lblEmployeeName.Size = New Size(41, 15)
        lblEmployeeName.TabIndex = 13
        lblEmployeeName.Tag = "lblEmployeeName"
        lblEmployeeName.Text = "Label5"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(566, 49)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 15
        Label4.Text = "Manager:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(566, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 15)
        Label3.TabIndex = 14
        Label3.Text = "Supervisor:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(17, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 12
        Label2.Text = "Employee ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(17, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 15)
        Label1.TabIndex = 11
        Label1.Text = "Employee Name:"
        ' 
        ' Guna2Shapes1
        ' 
        Guna2Shapes1.FillColor = Color.Gray
        Guna2Shapes1.Location = New Point(-80, 74)
        Guna2Shapes1.Margin = New Padding(3, 2, 3, 2)
        Guna2Shapes1.Name = "Guna2Shapes1"
        Guna2Shapes1.PolygonSkip = 1
        Guna2Shapes1.Rotate = 0F
        Guna2Shapes1.RoundedEdges = CustomizableEdges3
        Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Guna2Shapes1.Size = New Size(965, 2)
        Guna2Shapes1.TabIndex = 58
        Guna2Shapes1.Text = "Guna2Shapes1"
        Guna2Shapes1.Zoom = 80
        ' 
        ' btnSelect
        ' 
        btnSelect.BackColor = Color.WhiteSmoke
        btnSelect.CustomizableEdges = CustomizableEdges4
        btnSelect.DisabledState.BorderColor = Color.DarkGray
        btnSelect.DisabledState.CustomBorderColor = Color.DarkGray
        btnSelect.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSelect.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSelect.FillColor = Color.FromArgb(CByte(17), CByte(16), CByte(68))
        btnSelect.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSelect.ForeColor = Color.White
        btnSelect.Location = New Point(17, 496)
        btnSelect.Margin = New Padding(3, 2, 3, 2)
        btnSelect.Name = "btnSelect"
        btnSelect.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        btnSelect.Size = New Size(99, 32)
        btnSelect.TabIndex = 10
        btnSelect.Tag = "btnSelect"
        btnSelect.Text = "Select"
        ' 
        ' Employee_History
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(803, 552)
        ControlBox = False
        Controls.Add(Guna2Shapes1)
        Controls.Add(lblManager)
        Controls.Add(lblSupervisor)
        Controls.Add(lblEmployeeID)
        Controls.Add(lblEmployeeName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSelect)
        Controls.Add(dgHistory)
        Controls.Add(btnExport)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Employee_History"
        CType(dgHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgHistory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblManager As Label
    Friend WithEvents lblSupervisor As Label
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents btnSelect As Guna.UI2.WinForms.Guna2Button
End Class
