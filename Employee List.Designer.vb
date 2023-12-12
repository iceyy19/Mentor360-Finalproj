<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_List
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
        dgEmployeeList = New Guna.UI2.WinForms.Guna2DataGridView()
        lblAdminID = New Label()
        lblAdminName = New Label()
        Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Label2 = New Label()
        Label1 = New Label()
        txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        CType(dgEmployeeList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgEmployeeList
        ' 
        dgEmployeeList.AllowUserToAddRows = False
        dgEmployeeList.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgEmployeeList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgEmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgEmployeeList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgEmployeeList.ColumnHeadersHeight = 20
        dgEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgEmployeeList.DefaultCellStyle = DataGridViewCellStyle3
        dgEmployeeList.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgEmployeeList.Location = New Point(15, 133)
        dgEmployeeList.Name = "dgEmployeeList"
        dgEmployeeList.ReadOnly = True
        dgEmployeeList.RowHeadersVisible = False
        dgEmployeeList.RowTemplate.Height = 25
        dgEmployeeList.Size = New Size(770, 395)
        dgEmployeeList.TabIndex = 45
        dgEmployeeList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgEmployeeList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgEmployeeList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgEmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgEmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgEmployeeList.ThemeStyle.BackColor = Color.White
        dgEmployeeList.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgEmployeeList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgEmployeeList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgEmployeeList.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgEmployeeList.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgEmployeeList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgEmployeeList.ThemeStyle.HeaderStyle.Height = 20
        dgEmployeeList.ThemeStyle.ReadOnly = True
        dgEmployeeList.ThemeStyle.RowsStyle.BackColor = Color.White
        dgEmployeeList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgEmployeeList.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgEmployeeList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgEmployeeList.ThemeStyle.RowsStyle.Height = 25
        dgEmployeeList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgEmployeeList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' lblAdminID
        ' 
        lblAdminID.AutoSize = True
        lblAdminID.ForeColor = Color.Black
        lblAdminID.Location = New Point(63, 49)
        lblAdminID.Name = "lblAdminID"
        lblAdminID.Size = New Size(41, 15)
        lblAdminID.TabIndex = 44
        lblAdminID.Tag = "lblManagerID"
        lblAdminID.Text = "Label6"
        ' 
        ' lblAdminName
        ' 
        lblAdminName.AutoSize = True
        lblAdminName.ForeColor = Color.Black
        lblAdminName.Location = New Point(63, 24)
        lblAdminName.Name = "lblAdminName"
        lblAdminName.Size = New Size(41, 15)
        lblAdminName.TabIndex = 42
        lblAdminName.Tag = "lblManagerName"
        lblAdminName.Text = "Label5"
        ' 
        ' Guna2Shapes1
        ' 
        Guna2Shapes1.FillColor = Color.Gray
        Guna2Shapes1.Location = New Point(-81, 85)
        Guna2Shapes1.Margin = New Padding(3, 2, 3, 2)
        Guna2Shapes1.Name = "Guna2Shapes1"
        Guna2Shapes1.PolygonSkip = 1
        Guna2Shapes1.Rotate = 0F
        Guna2Shapes1.RoundedEdges = CustomizableEdges1
        Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Guna2Shapes1.Size = New Size(965, 2)
        Guna2Shapes1.TabIndex = 43
        Guna2Shapes1.Text = "Guna2Shapes1"
        Guna2Shapes1.Zoom = 80
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(15, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(21, 15)
        Label2.TabIndex = 41
        Label2.Text = "ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(15, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 40
        Label1.Text = "Name:"
        ' 
        ' txtPassword
        ' 
        txtPassword.AutoRoundedCorners = True
        txtPassword.BackColor = Color.Transparent
        txtPassword.BorderRadius = 13
        txtPassword.CustomizableEdges = CustomizableEdges2
        txtPassword.DefaultText = "Password"
        txtPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.ForeColor = Color.DarkGray
        txtPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Location = New Point(15, 93)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.MaxLength = 10
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = ChrW(0)
        txtPassword.PlaceholderText = ""
        txtPassword.SelectedText = ""
        txtPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        txtPassword.ShadowDecoration.Enabled = True
        txtPassword.ShadowDecoration.Shadow = New Padding(0, 0, 0, 5)
        txtPassword.Size = New Size(202, 28)
        txtPassword.TabIndex = 46
        ' 
        ' btnUpdate
        ' 
        btnUpdate.AutoRoundedCorners = True
        btnUpdate.BackColor = Color.Transparent
        btnUpdate.BorderRadius = 13
        btnUpdate.CustomizableEdges = CustomizableEdges4
        btnUpdate.DisabledState.BorderColor = Color.DarkGray
        btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray
        btnUpdate.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnUpdate.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnUpdate.FillColor = Color.FromArgb(CByte(17), CByte(16), CByte(68))
        btnUpdate.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(233, 93)
        btnUpdate.Margin = New Padding(3, 2, 3, 2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        btnUpdate.Size = New Size(95, 28)
        btnUpdate.TabIndex = 47
        btnUpdate.Text = "Update"
        btnUpdate.UseTransparentBackground = True
        ' 
        ' Employee_List
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(803, 552)
        ControlBox = False
        Controls.Add(btnUpdate)
        Controls.Add(txtPassword)
        Controls.Add(dgEmployeeList)
        Controls.Add(lblAdminID)
        Controls.Add(lblAdminName)
        Controls.Add(Guna2Shapes1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Employee_List"
        CType(dgEmployeeList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgEmployeeList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblAdminID As Label
    Friend WithEvents lblAdminName As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
End Class
