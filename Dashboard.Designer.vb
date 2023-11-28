<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2vScrollBar1 = New Guna.UI2.WinForms.Guna2VScrollBar()
        Guna2GroupBox1.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2GroupBox1
        ' 
        Guna2GroupBox1.Controls.Add(Guna2Panel1)
        Guna2GroupBox1.CustomBorderColor = Color.White
        Guna2GroupBox1.CustomizableEdges = CustomizableEdges3
        Guna2GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GroupBox1.ForeColor = Color.White
        Guna2GroupBox1.Location = New Point(-11, -11)
        Guna2GroupBox1.Name = "Guna2GroupBox1"
        Guna2GroupBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GroupBox1.Size = New Size(883, 1078)
        Guna2GroupBox1.TabIndex = 0
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.Controls.Add(Guna2vScrollBar1)
        Guna2Panel1.CustomizableEdges = CustomizableEdges1
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel1.Size = New Size(880, 1078)
        Guna2Panel1.TabIndex = 0
        ' 
        ' Guna2vScrollBar1
        ' 
        Guna2vScrollBar1.Dock = DockStyle.Right
        Guna2vScrollBar1.InUpdate = False
        Guna2vScrollBar1.LargeChange = 10
        Guna2vScrollBar1.Location = New Point(858, 0)
        Guna2vScrollBar1.Name = "Guna2vScrollBar1"
        Guna2vScrollBar1.ScrollbarSize = 22
        Guna2vScrollBar1.Size = New Size(22, 1078)
        Guna2vScrollBar1.TabIndex = 0
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(862, 1055)
        ControlBox = False
        Controls.Add(Guna2GroupBox1)
        Name = "Dashboard"
        Guna2GroupBox1.ResumeLayout(False)
        Guna2Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2vScrollBar1 As Guna.UI2.WinForms.Guna2VScrollBar
End Class
