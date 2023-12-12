<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Logs
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
        dgAdminLogs = New Guna.UI2.WinForms.Guna2DataGridView()
        lblAdminID = New Label()
        lblAdminName = New Label()
        Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        CType(dgAdminLogs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgAdminLogs
        ' 
        dgAdminLogs.AllowUserToAddRows = False
        dgAdminLogs.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgAdminLogs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgAdminLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgAdminLogs.ColumnHeadersHeight = 20
        dgAdminLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgAdminLogs.DefaultCellStyle = DataGridViewCellStyle3
        dgAdminLogs.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgAdminLogs.Location = New Point(15, 123)
        dgAdminLogs.Name = "dgAdminLogs"
        dgAdminLogs.ReadOnly = True
        dgAdminLogs.RowHeadersVisible = False
        dgAdminLogs.RowTemplate.Height = 25
        dgAdminLogs.Size = New Size(770, 405)
        dgAdminLogs.TabIndex = 38
        dgAdminLogs.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgAdminLogs.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgAdminLogs.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgAdminLogs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgAdminLogs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgAdminLogs.ThemeStyle.BackColor = Color.White
        dgAdminLogs.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgAdminLogs.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgAdminLogs.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgAdminLogs.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgAdminLogs.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgAdminLogs.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgAdminLogs.ThemeStyle.HeaderStyle.Height = 20
        dgAdminLogs.ThemeStyle.ReadOnly = True
        dgAdminLogs.ThemeStyle.RowsStyle.BackColor = Color.White
        dgAdminLogs.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgAdminLogs.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgAdminLogs.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgAdminLogs.ThemeStyle.RowsStyle.Height = 25
        dgAdminLogs.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgAdminLogs.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' lblAdminID
        ' 
        lblAdminID.AutoSize = True
        lblAdminID.ForeColor = Color.Black
        lblAdminID.Location = New Point(63, 49)
        lblAdminID.Name = "lblAdminID"
        lblAdminID.Size = New Size(41, 15)
        lblAdminID.TabIndex = 37
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
        lblAdminName.TabIndex = 35
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
        Guna2Shapes1.TabIndex = 36
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
        Label2.TabIndex = 34
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
        Label1.TabIndex = 33
        Label1.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(15, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 20)
        Label3.TabIndex = 39
        Label3.Text = "Admin Logs"
        ' 
        ' Admin_Logs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(803, 552)
        ControlBox = False
        Controls.Add(dgAdminLogs)
        Controls.Add(lblAdminID)
        Controls.Add(lblAdminName)
        Controls.Add(Guna2Shapes1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Name = "Admin_Logs"
        CType(dgAdminLogs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgAdminLogs As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblAdminID As Label
    Friend WithEvents lblAdminName As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
