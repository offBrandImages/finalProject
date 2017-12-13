Public Class Form1
    Dim xSpeedOfBall As Double = 10.5
    Dim ySpeedOfBall As Double = 5.0
    Dim running As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        Me.Size = New Size(900, 450)
    End Sub

    Private Sub paddle1Move(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.W Then
            picPaddle1.Top -= 10
            If picPaddle1.Top < 35 Then
                picPaddle1.Top = 37
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
            If picPaddle2.Top < 35 Then
                picPaddle2.Top = 37
            End If
        ElseIf d.KeyCode = Keys.Down Then
            picPaddle2.Top += 10
            If picPaddle2.Top > 350 Then
                picPaddle2.Top = 350
            End If
        End If
    End Sub

    Private Sub Collison(sender As Object, e As EventArgs) Handles Timer1.Tick
        picBallMain.Location = New Point(picBallMain.Location.X + xSpeedOfBall, picBallMain.Location.Y + ySpeedOfBall)
        If picBallMain.Bounds.IntersectsWith(picPaddle2.Bounds) Then
            picBallMain.Location = New Point(picPaddle2.Location.X - picBallMain.Size.Width, _picBallMain.Location.Y)
            xSpeedOfBall = -xSpeedOfBall
        End If
        If picBallMain.Bounds.IntersectsWith(picPaddle1.Bounds) Then
            picBallMain.Location = New Point(picPaddle1.Location.X + picBallMain.Size.Width + 1, _picBallMain.Location.Y)
            xSpeedOfBall = -xSpeedOfBall
        End If
        If picBallMain.Location.Y > Me.Height - picBallMain.Size.Height - 45 Then
            picBallMain.Location = New Point(picBallMain.Location.X, Me.Height - picBallMain.Size.Height - 45)
            ySpeedOfBall = -ySpeedOfBall
        End If
        If picBallMain.Location.Y < 25 Then
            picBallMain.Location = New Point(picBallMain.Location.X, 25)
            ySpeedOfBall = -ySpeedOfBall
        End If

        'Scoring
        If picBallMain.Location.X < 12 Then

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub
End Class
