Public Class Form1
    Dim xSpeedOfBall As Double = 10.5
    Dim ySpeedOfBall As Double = 5.0
    Dim scorePlayer1 As Integer = 0
    Dim scorePlayer2 As Integer = 0
    Dim running As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        Me.Size = New Size(900, 450)
        randomNumberMaker()
    End Sub

    Private Sub paddle1Move(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.W Then
            picPaddle1.Top -= 15
            If picPaddle1.Top < 35 Then
                picPaddle1.Top = 37
            End If
        ElseIf e.KeyCode = Keys.S Then
            picPaddle1.Top += 15
            If picPaddle1.Top > 350 Then
                picPaddle1.Top = 350
            End If
        End If
    End Sub

    Private Sub paddle2Move(ByVal sender As System.Object, ByVal d As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If d.KeyCode = Keys.Up Then
            picPaddle2.Top -= 15
            If picPaddle2.Top < 35 Then
                picPaddle2.Top = 37
            End If
        ElseIf d.KeyCode = Keys.Down Then
            picPaddle2.Top += 15
            If picPaddle2.Top > 350 Then
                picPaddle2.Top = 350
            End If
        End If
    End Sub

    Private Sub Collison(sender As Object, e As EventArgs) Handles Timer1.Tick
        'AI
        picPaddle2.Location = New Point(862, picBallMain.Location.Y - 35)

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
        If picBallMain.Location.Y < 35 Then
            picBallMain.Location = New Point(picBallMain.Location.X, 35)
            ySpeedOfBall = -ySpeedOfBall
        End If

        'Scoring
        If picBallMain.Location.X < 12 Then
            scorePlayer2 += 1
            picBallMain.Location = New Point(65, 175)
            lblScorePlayer2.Text = "Player 2 Score: " & scorePlayer2
            Threading.Thread.Sleep(500)
            randomNumberMaker()
        ElseIf picBallMain.Location.X > 862 Then
            scorePlayer1 += 1
            picBallMain.Location = New Point(855, 175)
            lblScorePlayer1.Text = "Player 1 Score: " & scorePlayer1
            Threading.Thread.Sleep(500)
            randomNumberMaker()
            xSpeedOfBall = -xSpeedOfBall
            ySpeedOfBall = -ySpeedOfBall
        End If
    End Sub

    Private Sub randomNumberMaker()
        xSpeedOfBall = CDbl(Rnd() * 15 + 10)
        ySpeedOfBall = CDbl(Rnd() * 7.5 + 1)
    End Sub
End Class
