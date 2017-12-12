Public Class Form1
    Dim previousKey As Keys? = Nothing
    Const speedOfBall As Double = 10.5
    Dim angleOfBall As Double = 0.0
    Dim previousAngle As Double = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        Me.Size = New Size(900, 450)
    End Sub

    Private Sub paddle1Move(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.W Then
            picPaddle1.Top -= 10
            If picPaddle1.Top < 10 Then
                picPaddle1.Top = 12
            End If
        ElseIf e.KeyCode = Keys.S Then
            picPaddle1.Top += 10
            If picPaddle1.Top > 350 Then
                picPaddle1.Top = 350
            End If
        End If
        If e.KeyCode = Keys.Y Then
            picBallMain.Left += 10
        End If
    End Sub

    Private Sub paddle2Move(ByVal sender As System.Object, ByVal d As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If d.KeyCode = Keys.Up Then
            picPaddle2.Top -= 10
            If picPaddle2.Top < 10 Then
                picPaddle2.Top = 12
            End If
        ElseIf d.KeyCode = Keys.Down Then
            picPaddle2.Top += 10
            If picPaddle2.Top > 350 Then
                picPaddle2.Top = 350
            End If
        End If
    End Sub

    Private Sub collision()
        angleOfBall = previousAngle
        If picBallMain.Bounds.IntersectsWith(picPaddle1.Bounds) Then
            angleOfBall = previousAngle - 1
            picBallMain.Top -= angleOfBall
            picBallMain.Left -= speedOfBall
        ElseIf picBallMain.Bounds.IntersectsWith(picPaddle2.Bounds) Then
            angleOfBall = previousAngle + 1
            picBallMain.Top += angleOfBall
            picBallMain.Left += speedOfBall
        End If
        If picBallMain.Top < 10 Then
            picBallMain.Top = 10
        ElseIf picBallMain.Top > 350 Then
            picBallMain.Top = 350
        End If
    End Sub
End Class
