Imports System.Diagnostics.Metrics

Public Class OvalControl
    Inherits Control

    Private isDragging As Boolean = False
    Private dragStartPoint As Point
    Private resizing As Boolean = False
    Private resizeStartPoint As Point

    Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
        ' Do not call the base method to prevent the default background painting
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H20 ' WS_EX_TRANSPARENT
            Return cp
        End Get
    End Property

    Public Sub New()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        Me.Size = New Size(100, 100)
    End Sub


    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        ' Draw the oval with a light blue fill and a black border
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.FillEllipse(Brushes.LightBlue, rect)
        g.DrawEllipse(Pens.Black, rect)

        ' Draw the wrapped text inside the oval
        Dim textRect As New Rectangle(10, 10, Me.Width - 20, Me.Height - 20)
        Dim sf As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
        g.DrawString(Me.Text, Me.Font, Brushes.Black, textRect, sf)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isDragging = True
            dragStartPoint = e.Location
        ElseIf e.Button = MouseButtons.Right Then
            resizing = True
            resizeStartPoint = e.Location
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        If isDragging Then
            Me.Left += e.X - dragStartPoint.X
            Me.Top += e.Y - dragStartPoint.Y
        ElseIf resizing Then
            Me.Width += e.X - resizeStartPoint.X
            Me.Height += e.Y - resizeStartPoint.Y
            resizeStartPoint = e.Location
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        isDragging = False
        resizing = False
    End Sub
End Class
