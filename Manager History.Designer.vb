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
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        lblManagerID = New Label()
        lblManagerName = New Label()
        Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Label2 = New Label()
        Label1 = New Label()
        dgHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        dtpfrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        dtpto = New Guna.UI2.WinForms.Guna2DateTimePicker()
        btnExport = New Guna.UI2.WinForms.Guna2Button()
        btnSelect = New Guna.UI2.WinForms.Guna2Button()
        btnReset = New Guna.UI2.WinForms.Guna2Button()
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
        Guna2Shapes1.RoundedEdges = CustomizableEdges12
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
        dgHistory.AllowUserToAddRows = False
        dgHistory.AllowUserToDeleteRows = False
        dgHistory.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = Color.White
        dgHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        dgHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgHistory.ColumnHeadersHeight = 20
        dgHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
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
        dgHistory.ReadOnly = True
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
        dgHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgHistory.ThemeStyle.HeaderStyle.Height = 20
        dgHistory.ThemeStyle.ReadOnly = True
        dgHistory.ThemeStyle.RowsStyle.BackColor = Color.White
        dgHistory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgHistory.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgHistory.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgHistory.ThemeStyle.RowsStyle.Height = 25
        dgHistory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgHistory.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' dtpfrom
        ' 
        dtpfrom.AutoRoundedCorners = True
        dtpfrom.BorderRadius = 17
        dtpfrom.Checked = True
        dtpfrom.CustomizableEdges = CustomizableEdges13
        dtpfrom.FillColor = Color.LightCyan
        dtpfrom.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dtpfrom.Format = DateTimePickerFormat.Short
        dtpfrom.Location = New Point(16, 105)
        dtpfrom.MaxDate = New DateTime(9998, 12, 31, 0, 0, 0, 0)
        dtpfrom.MinDate = New DateTime(1753, 1, 1, 0, 0, 0, 0)
        dtpfrom.Name = "dtpfrom"
        dtpfrom.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        dtpfrom.Size = New Size(123, 36)
        dtpfrom.TabIndex = 28
        dtpfrom.Value = New DateTime(2023, 12, 9, 15, 27, 15, 279)
        ' 
        ' dtpto
        ' 
        dtpto.AutoRoundedCorners = True
        dtpto.BorderRadius = 17
        dtpto.Checked = True
        dtpto.CustomizableEdges = CustomizableEdges15
        dtpto.FillColor = Color.LightCyan
        dtpto.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dtpto.Format = DateTimePickerFormat.Short
        dtpto.Location = New Point(158, 105)
        dtpto.MaxDate = New DateTime(9998, 12, 31, 0, 0, 0, 0)
        dtpto.MinDate = New DateTime(1753, 1, 1, 0, 0, 0, 0)
        dtpto.Name = "dtpto"
        dtpto.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        dtpto.Size = New Size(123, 36)
        dtpto.TabIndex = 29
        dtpto.Value = New DateTime(2023, 12, 9, 15, 27, 15, 279)
        ' 
        ' btnExport
        ' 
        btnExport.AutoRoundedCorners = True
        btnExport.BorderRadius = 16
        btnExport.CustomizableEdges = CustomizableEdges17
        btnExport.DisabledState.BorderColor = Color.DarkGray
        btnExport.DisabledState.CustomBorderColor = Color.DarkGray
        btnExport.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnExport.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnExport.FillColor = Color.FromArgb(CByte(17), CByte(16), CByte(68))
        btnExport.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnExport.ForeColor = Color.White
        btnExport.Location = New Point(689, 499)
        btnExport.Name = "btnExport"
        btnExport.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        btnExport.Size = New Size(102, 34)
        btnExport.TabIndex = 30
        btnExport.Text = "Export"
        ' 
        ' btnSelect
        ' 
        btnSelect.AutoRoundedCorners = True
        btnSelect.BorderRadius = 16
        btnSelect.CustomizableEdges = CustomizableEdges19
        btnSelect.DisabledState.BorderColor = Color.DarkGray
        btnSelect.DisabledState.CustomBorderColor = Color.DarkGray
        btnSelect.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSelect.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSelect.FillColor = Color.FromArgb(CByte(17), CByte(16), CByte(68))
        btnSelect.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSelect.ForeColor = Color.White
        btnSelect.Location = New Point(16, 499)
        btnSelect.Name = "btnSelect"
        btnSelect.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        btnSelect.Size = New Size(102, 34)
        btnSelect.TabIndex = 31
        btnSelect.Text = "Select"
        ' 
        ' btnReset
        ' 
        btnReset.AutoRoundedCorners = True
        btnReset.BorderRadius = 16
        btnReset.CustomizableEdges = CustomizableEdges21
        btnReset.DisabledState.BorderColor = Color.DarkGray
        btnReset.DisabledState.CustomBorderColor = Color.DarkGray
        btnReset.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnReset.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnReset.FillColor = Color.FromArgb(CByte(17), CByte(16), CByte(68))
        btnReset.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnReset.ForeColor = Color.White
        btnReset.Location = New Point(298, 106)
        btnReset.Name = "btnReset"
        btnReset.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        btnReset.Size = New Size(102, 34)
        btnReset.TabIndex = 32
        btnReset.Text = "Reset Time"
        ' 
        ' Manager_History
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(803, 552)
        ControlBox = False
        Controls.Add(btnReset)
        Controls.Add(btnSelect)
        Controls.Add(btnExport)
        Controls.Add(dtpto)
        Controls.Add(dtpfrom)
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
    Friend WithEvents dtpfrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpto As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSelect As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReset As Guna.UI2.WinForms.Guna2Button
End Class
