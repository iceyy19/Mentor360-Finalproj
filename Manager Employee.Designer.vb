<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager_Employee
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
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblManagerID = New Label()
        lblManagerName = New Label()
        Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Label2 = New Label()
        Label1 = New Label()
        dgManagerEmployee = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(dgManagerEmployee, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblManagerID
        ' 
        lblManagerID.AutoSize = True
        lblManagerID.Location = New Point(114, 42)
        lblManagerID.Name = "lblManagerID"
        lblManagerID.Size = New Size(41, 15)
        lblManagerID.TabIndex = 31
        lblManagerID.Tag = "lblManagerID"
        lblManagerID.Text = "Label6"
        ' 
        ' lblManagerName
        ' 
        lblManagerName.AutoSize = True
        lblManagerName.Location = New Point(114, 17)
        lblManagerName.Name = "lblManagerName"
        lblManagerName.Size = New Size(41, 15)
        lblManagerName.TabIndex = 29
        lblManagerName.Tag = "lblManagerName"
        lblManagerName.Text = "Label5"
        ' 
        ' Guna2Shapes1
        ' 
        Guna2Shapes1.FillColor = Color.Gray
        Guna2Shapes1.Location = New Point(-80, 78)
        Guna2Shapes1.Margin = New Padding(3, 2, 3, 2)
        Guna2Shapes1.Name = "Guna2Shapes1"
        Guna2Shapes1.PolygonSkip = 1
        Guna2Shapes1.Rotate = 0F
        Guna2Shapes1.RoundedEdges = CustomizableEdges2
        Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Guna2Shapes1.Size = New Size(965, 2)
        Guna2Shapes1.TabIndex = 30
        Guna2Shapes1.Text = "Guna2Shapes1"
        Guna2Shapes1.Zoom = 80
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(16, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 28
        Label2.Text = "Manager ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(16, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 15)
        Label1.TabIndex = 27
        Label1.Text = "Manager Name:"
        ' 
        ' dgManagerEmployee
        ' 
        DataGridViewCellStyle4.BackColor = Color.White
        dgManagerEmployee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgManagerEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgManagerEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgManagerEmployee.DefaultCellStyle = DataGridViewCellStyle6
        dgManagerEmployee.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgManagerEmployee.Location = New Point(16, 102)
        dgManagerEmployee.Name = "dgManagerEmployee"
        dgManagerEmployee.RowHeadersVisible = False
        dgManagerEmployee.RowTemplate.Height = 25
        dgManagerEmployee.Size = New Size(770, 419)
        dgManagerEmployee.TabIndex = 32
        dgManagerEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgManagerEmployee.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgManagerEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgManagerEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgManagerEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgManagerEmployee.ThemeStyle.BackColor = Color.White
        dgManagerEmployee.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgManagerEmployee.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgManagerEmployee.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgManagerEmployee.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgManagerEmployee.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgManagerEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgManagerEmployee.ThemeStyle.HeaderStyle.Height = 4
        dgManagerEmployee.ThemeStyle.ReadOnly = False
        dgManagerEmployee.ThemeStyle.RowsStyle.BackColor = Color.White
        dgManagerEmployee.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgManagerEmployee.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgManagerEmployee.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgManagerEmployee.ThemeStyle.RowsStyle.Height = 25
        dgManagerEmployee.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgManagerEmployee.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Manager_Employee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(803, 552)
        ControlBox = False
        Controls.Add(dgManagerEmployee)
        Controls.Add(lblManagerID)
        Controls.Add(lblManagerName)
        Controls.Add(Guna2Shapes1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Manager_Employee"
        CType(dgManagerEmployee, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblManagerID As Label
    Friend WithEvents lblManagerName As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgManagerEmployee As Guna.UI2.WinForms.Guna2DataGridView
End Class
