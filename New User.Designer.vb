<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_User
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
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        btnStart = New Guna.UI2.WinForms.Guna2Button()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges1
        Guna2PictureBox1.Image = My.Resources.Resources.new_user_bg2
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(0, -2)
        Guna2PictureBox1.Margin = New Padding(3, 2, 3, 2)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2PictureBox1.Size = New Size(544, 339)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' btnStart
        ' 
        btnStart.CustomizableEdges = CustomizableEdges3
        btnStart.DisabledState.BorderColor = Color.DarkGray
        btnStart.DisabledState.CustomBorderColor = Color.DarkGray
        btnStart.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnStart.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnStart.FillColor = Color.FromArgb(CByte(17), CByte(16), CByte(68))
        btnStart.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnStart.ForeColor = Color.White
        btnStart.Location = New Point(213, 259)
        btnStart.Margin = New Padding(3, 2, 3, 2)
        btnStart.Name = "btnStart"
        btnStart.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnStart.Size = New Size(118, 38)
        btnStart.TabIndex = 1
        btnStart.Text = "Get Started"
        ' 
        ' New_User
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(543, 306)
        ControlBox = False
        Controls.Add(btnStart)
        Controls.Add(Guna2PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 2, 3, 2)
        Name = "New_User"
        StartPosition = FormStartPosition.CenterScreen
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnStart As Guna.UI2.WinForms.Guna2Button
End Class
