<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enter_Employee_ID
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
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtEmployeeID = New Guna.UI2.WinForms.Guna2TextBox()
        btnNext = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.CustomizableEdges = CustomizableEdges1
        btnCancel.DisabledState.BorderColor = Color.DarkGray
        btnCancel.DisabledState.CustomBorderColor = Color.DarkGray
        btnCancel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCancel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCancel.FillColor = Color.Maroon
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(21, 117)
        btnCancel.Margin = New Padding(3, 2, 3, 2)
        btnCancel.Name = "btnCancel"
        btnCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnCancel.Size = New Size(99, 31)
        btnCancel.TabIndex = 19
        btnCancel.Text = "Cancel"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.AutoSize = False
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Location = New Point(21, 19)
        Guna2HtmlLabel1.Margin = New Padding(3, 2, 3, 2)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(184, 16)
        Guna2HtmlLabel1.TabIndex = 18
        Guna2HtmlLabel1.Text = "Enter Employee ID:"
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.AutoRoundedCorners = True
        txtEmployeeID.BorderRadius = 16
        txtEmployeeID.CustomizableEdges = CustomizableEdges3
        txtEmployeeID.DefaultText = ""
        txtEmployeeID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtEmployeeID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtEmployeeID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEmployeeID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEmployeeID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEmployeeID.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmployeeID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEmployeeID.Location = New Point(21, 40)
        txtEmployeeID.Margin = New Padding(3, 2, 3, 2)
        txtEmployeeID.MaxLength = 10
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.PasswordChar = ChrW(0)
        txtEmployeeID.PlaceholderText = ""
        txtEmployeeID.SelectedText = ""
        txtEmployeeID.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtEmployeeID.Size = New Size(259, 34)
        txtEmployeeID.TabIndex = 17
        ' 
        ' btnNext
        ' 
        btnNext.CustomizableEdges = CustomizableEdges5
        btnNext.DisabledState.BorderColor = Color.DarkGray
        btnNext.DisabledState.CustomBorderColor = Color.DarkGray
        btnNext.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnNext.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnNext.FillColor = Color.FromArgb(CByte(17), CByte(16), CByte(68))
        btnNext.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnNext.ForeColor = Color.White
        btnNext.Location = New Point(181, 117)
        btnNext.Margin = New Padding(3, 2, 3, 2)
        btnNext.Name = "btnNext"
        btnNext.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnNext.Size = New Size(99, 31)
        btnNext.TabIndex = 20
        btnNext.Text = "Next"
        ' 
        ' Enter_Employee_ID
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(310, 170)
        ControlBox = False
        Controls.Add(btnNext)
        Controls.Add(btnCancel)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(txtEmployeeID)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Enter_Employee_ID"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtEmployeeID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
End Class
