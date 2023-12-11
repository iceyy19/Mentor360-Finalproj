Imports System.Drawing
Imports System.Windows.Forms

Public Class RoundedPanel
    Inherits Panel

    Private _cornerRadius As Integer = 10

    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()

        ' Create a rounded rectangle path
        path.AddArc(New Rectangle(0, 0, _cornerRadius * 2, _cornerRadius * 2), -180, 90)
        path.AddArc(New Rectangle(Me.Width - _cornerRadius * 2, 0, _cornerRadius * 2, _cornerRadius * 2), -90, 90)
        path.AddArc(New Rectangle(Me.Width - _cornerRadius * 2, Me.Height - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2), 0, 90)
        path.AddArc(New Rectangle(0, Me.Height - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2), 90, 90)
        path.CloseFigure()

        ' Set smoothing mode for better quality
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        ' Fill the rounded rectangle with the panel's background color
        e.Graphics.FillPath(New SolidBrush(Me.BackColor), path)

        MyBase.OnPaint(e)
    End Sub
End Class