<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supervisor_Employees
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        dgSupervisorEmployee = New Guna.UI2.WinForms.Guna2DataGridView()
        lblSupervisorID = New Label()
        lblSupervisorName = New Label()
        Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Label2 = New Label()
        Label1 = New Label()
        lblManager = New Label()
        Label4 = New Label()
        CType(dgSupervisorEmployee, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgSupervisorEmployee
        ' 
        DataGridViewCellStyle4.BackColor = Color.White
        dgSupervisorEmployee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgSupervisorEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgSupervisorEmployee.ColumnHeadersHeight = 4
        dgSupervisorEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgSupervisorEmployee.DefaultCellStyle = DataGridViewCellStyle6
        dgSupervisorEmployee.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgSupervisorEmployee.Location = New Point(15, 109)
        dgSupervisorEmployee.Name = "dgSupervisorEmployee"
        dgSupervisorEmployee.RowHeadersVisible = False
        dgSupervisorEmployee.RowTemplate.Height = 25
        dgSupervisorEmployee.Size = New Size(770, 419)
        dgSupervisorEmployee.TabIndex = 38
        dgSupervisorEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgSupervisorEmployee.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgSupervisorEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgSupervisorEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgSupervisorEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgSupervisorEmployee.ThemeStyle.BackColor = Color.White
        dgSupervisorEmployee.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgSupervisorEmployee.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgSupervisorEmployee.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgSupervisorEmployee.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgSupervisorEmployee.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgSupervisorEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgSupervisorEmployee.ThemeStyle.HeaderStyle.Height = 4
        dgSupervisorEmployee.ThemeStyle.ReadOnly = False
        dgSupervisorEmployee.ThemeStyle.RowsStyle.BackColor = Color.White
        dgSupervisorEmployee.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgSupervisorEmployee.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgSupervisorEmployee.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgSupervisorEmployee.ThemeStyle.RowsStyle.Height = 25
        dgSupervisorEmployee.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgSupervisorEmployee.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' lblSupervisorID
        ' 
        lblSupervisorID.AutoSize = True
        lblSupervisorID.Location = New Point(121, 49)
        lblSupervisorID.Name = "lblSupervisorID"
        lblSupervisorID.Size = New Size(41, 15)
        lblSupervisorID.TabIndex = 37
        lblSupervisorID.Tag = "lblManagerID"
        lblSupervisorID.Text = "Label6"
        ' 
        ' lblSupervisorName
        ' 
        lblSupervisorName.AutoSize = True
        lblSupervisorName.Location = New Point(121, 24)
        lblSupervisorName.Name = "lblSupervisorName"
        lblSupervisorName.Size = New Size(41, 15)
        lblSupervisorName.TabIndex = 35
        lblSupervisorName.Tag = "lblManagerName"
        lblSupervisorName.Text = "Label5"
        ' 
        ' Guna2Shapes1
        ' 
        Guna2Shapes1.FillColor = Color.Gray
        Guna2Shapes1.Location = New Point(-81, 85)
        Guna2Shapes1.Margin = New Padding(3, 2, 3, 2)
        Guna2Shapes1.Name = "Guna2Shapes1"
        Guna2Shapes1.PolygonSkip = 1
        Guna2Shapes1.Rotate = 0F
        Guna2Shapes1.RoundedEdges = CustomizableEdges2
        Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Guna2Shapes1.Size = New Size(965, 2)
        Guna2Shapes1.TabIndex = 36
        Guna2Shapes1.Text = "Guna2Shapes1"
        Guna2Shapes1.Zoom = 80
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(15, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 34
        Label2.Text = "Supervisor ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(15, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 15)
        Label1.TabIndex = 33
        Label1.Text = "Supervisor Name:"
        ' 
        ' lblManager
        ' 
        lblManager.AutoSize = True
        lblManager.Location = New Point(596, 24)
        lblManager.Name = "lblManager"
        lblManager.Size = New Size(41, 15)
        lblManager.TabIndex = 40
        lblManager.Tag = "lblManagerName"
        lblManager.Text = "Label5"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(533, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 39
        Label4.Text = "Manager:"
        ' 
        ' Supervisor_Employees
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(803, 552)
        ControlBox = False
        Controls.Add(lblManager)
        Controls.Add(Label4)
        Controls.Add(dgSupervisorEmployee)
        Controls.Add(lblSupervisorID)
        Controls.Add(lblSupervisorName)
        Controls.Add(Guna2Shapes1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Supervisor_Employees"
        CType(dgSupervisorEmployee, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgSupervisorEmployee As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblSupervisorID As Label
    Friend WithEvents lblSupervisorName As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblManager As Label
    Friend WithEvents Label4 As Label
End Class
