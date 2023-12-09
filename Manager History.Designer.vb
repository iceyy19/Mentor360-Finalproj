<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager_History
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
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        lblManagerID = New Label()
        lblManagerName = New Label()
        Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Label2 = New Label()
        Label1 = New Label()
        dgHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Guna2DateTimePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(dgHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblManagerID
        ' 
        lblManagerID.AutoSize = True
        lblManagerID.Location = New Point(114, 42)
        lblManagerID.Name = "lblManagerID"
        lblManagerID.Size = New Size(41, 15)
        lblManagerID.TabIndex = 26
        lblManagerID.Tag = "lblManagerID"
        lblManagerID.Text = "Label6"
        ' 
        ' lblManagerName
        ' 
        lblManagerName.AutoSize = True
        lblManagerName.Location = New Point(114, 17)
        lblManagerName.Name = "lblManagerName"
        lblManagerName.Size = New Size(41, 15)
        lblManagerName.TabIndex = 24
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
        Guna2Shapes1.RoundedEdges = CustomizableEdges8
        Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Guna2Shapes1.Size = New Size(965, 2)
        Guna2Shapes1.TabIndex = 25
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
        Label2.TabIndex = 23
        Label2.Text = "Manager ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(16, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 15)
        Label1.TabIndex = 22
        Label1.Text = "Manager Name:"
        ' 
        ' dgHistory
        ' 
        DataGridViewCellStyle4.BackColor = Color.White
        dgHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgHistory.DefaultCellStyle = DataGridViewCellStyle6
        dgHistory.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgHistory.Location = New Point(16, 147)
        dgHistory.Name = "dgHistory"
        dgHistory.RowHeadersVisible = False
        dgHistory.RowTemplate.Height = 25
        dgHistory.Size = New Size(775, 335)
        dgHistory.TabIndex = 27
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
        dgHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgHistory.ThemeStyle.HeaderStyle.Height = 4
        dgHistory.ThemeStyle.ReadOnly = False
        dgHistory.ThemeStyle.RowsStyle.BackColor = Color.White
        dgHistory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgHistory.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgHistory.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgHistory.ThemeStyle.RowsStyle.Height = 25
        dgHistory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgHistory.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Guna2DateTimePicker1
        ' 
        Guna2DateTimePicker1.AutoRoundedCorners = True
        Guna2DateTimePicker1.BorderRadius = 17
        Guna2DateTimePicker1.Checked = True
        Guna2DateTimePicker1.CustomizableEdges = CustomizableEdges9
        Guna2DateTimePicker1.FillColor = Color.LightCyan
        Guna2DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2DateTimePicker1.Format = DateTimePickerFormat.Short
        Guna2DateTimePicker1.Location = New Point(16, 105)
        Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2DateTimePicker1.Size = New Size(123, 36)
        Guna2DateTimePicker1.TabIndex = 28
        Guna2DateTimePicker1.Value = New Date(2023, 12, 9, 15, 27, 15, 279)
        ' 
        ' Guna2DateTimePicker2
        ' 
        Guna2DateTimePicker2.AutoRoundedCorners = True
        Guna2DateTimePicker2.BorderRadius = 17
        Guna2DateTimePicker2.Checked = True
        Guna2DateTimePicker2.CustomizableEdges = CustomizableEdges11
        Guna2DateTimePicker2.FillColor = Color.LightCyan
        Guna2DateTimePicker2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2DateTimePicker2.Format = DateTimePickerFormat.Short
        Guna2DateTimePicker2.Location = New Point(158, 105)
        Guna2DateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Guna2DateTimePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Guna2DateTimePicker2.Name = "Guna2DateTimePicker2"
        Guna2DateTimePicker2.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2DateTimePicker2.Size = New Size(123, 36)
        Guna2DateTimePicker2.TabIndex = 29
        Guna2DateTimePicker2.Value = New Date(2023, 12, 9, 15, 27, 15, 279)
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.AutoRoundedCorners = True
        Guna2Button1.BorderRadius = 16
        Guna2Button1.CustomizableEdges = CustomizableEdges13
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.FromArgb(CByte(17), CByte(16), CByte(68))
        Guna2Button1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(689, 499)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2Button1.Size = New Size(102, 34)
        Guna2Button1.TabIndex = 30
        Guna2Button1.Text = "Export"
        ' 
        ' Manager_History
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(803, 552)
        ControlBox = False
        Controls.Add(Guna2Button1)
        Controls.Add(Guna2DateTimePicker2)
        Controls.Add(Guna2DateTimePicker1)
        Controls.Add(dgHistory)
        Controls.Add(lblManagerID)
        Controls.Add(lblManagerName)
        Controls.Add(Guna2Shapes1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Manager_History"
        CType(dgHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblManagerID As Label
    Friend WithEvents lblManagerName As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgHistory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2DateTimePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
