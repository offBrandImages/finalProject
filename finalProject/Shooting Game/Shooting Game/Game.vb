Public Class Game
    ' Dim variables for the visable Timer, the players score, 
    ' the FlamCount, and setting running as the game in motion.
    Dim intScore As Integer
    Dim intFalmCount As Integer
    Dim running As Boolean = False
    Dim intTimer As Integer = 15
    ' Sets sub Visable as resetting the location and positions of the images, as well as starting labels.
    Private Sub Visable()
        picEasy.Visible = True
        picEasy.Left = 0
        picMedium.Visible = True
        picMedium.Left = 0
        picMedium2.Visible = True
        picMedium2.Left = 705
        picSmall1.Visible = True
        picSmall2.Left = 0
        picSmall2.Visible = True
        picSmall1.Left = 0
        picSmall3.Visible = True
        picSmall3.Left = 730
        picFlamOne.Visible = True
        picFlamOne.Left = 0
        lblInstructions.Visible = True
        lblScore.Visible = False
        picFlamOne.Location = New Point(2, 331)
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' Enables timers to start game.
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        ' Sets the running boolean as true, starting game.
        Me.running = True
        ' Makes intructions not visable.
        lblInstructions.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Sets The FlamCount plus one, sets the visable timer minus one.
        intFalmCount += 1
        intTimer -= 1
        ' Displays viable timer.
        lblTimer.Text = intTimer
        ' Sets the FlamOnes motion.
        For Me.intFalmCount = 1 To 20
            picFlamOne.Left += 1
            picFlamOne.Top -= 1
        Next
        ' Checks the intTimer for a completed game, then displays apropriate winning messages.
        If intTimer <= 0 Then
            ' Resets Visable Timer
            lblTimer.Text = ("15")
            If intScore >= 22 Then
                ' Displays score for games over 22 points.
                FinishedGame.lblWinngingMessage.Text = ("You've completed the game! Your final score was " &
                                                    intScore & "! You are a bird hunting master!")
            ElseIf intScore >= 19 Then
                ' Displays score for games over 19
                FinishedGame.lblWinngingMessage.Text = ("You've completed the game! Your final score was " &
                                                   intScore & "! You're nearly pretty good at this! Try again for an even better score!")
            ElseIf intScore >= 15 Then
                ' Displays score for games over 15
                FinishedGame.lblWinngingMessage.Text = ("You've completed the game! Your final score was " &
                                                   intScore & "! Not your best try, but you're getting there! Try again!")
            ElseIf intScore >= 10 Then
                ' Displays score for games over 10 
                FinishedGame.lblWinngingMessage.Text = ("You've completed the game! Your final score was " &
                                                   intScore & "! Is this your first time? Try again!")
            ElseIf intScore <= 9 Then
                ' Displays score for games under or equal to 9
                FinishedGame.lblWinngingMessage.Text = ("You've completed the game! Your final score was " &
                                                   intScore & "! You need a lot more practice. Try Again?")
            End If
            ' Shows endgame form
            FinishedGame.Show()
            ' Resets timer, Score, FlamCount, resets running, and stops timers.
            intTimer = 15
            intScore = 0
            intFalmCount = 0
            Me.running = False
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            ' Resets locations
            Visable()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Moves the Easy and Medium pics
        picEasy.Left += 1
        picMedium.Left += 35
        picMedium2.Left -= 35
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ' Moves the Small pics
        picSmall1.Left += 30
        picSmall2.Left += 40
        picSmall3.Left -= 30
    End Sub
    Private Sub picSmall1_Click(sender As Object, e As EventArgs) Handles picSmall1.Click
        ' Sets visable to false if shot, and adds to score
        If Me.running = True Then
            picSmall1.Visible = False
            intScore += 5
            lblScore.Text = intScore
        End If
    End Sub

    Private Sub picMedium_Click(sender As Object, e As EventArgs) Handles picMedium.Click
        ' Sets visable to false if shot, and adds to score
        If Me.running = True Then
            picMedium.Visible = False
            intScore += 3
            lblScore.Text = intScore
        End If
    End Sub

    Private Sub picSmall2_Click(sender As Object, e As EventArgs) Handles picSmall2.Click
        ' Sets visable to false if shot, and adds to score
        If Me.running = True Then
            picSmall2.Visible = False
            intScore += 5
            lblScore.Text = intScore
        End If
    End Sub

    Private Sub picEasy_Click(sender As Object, e As EventArgs) Handles picEasy.Click
        ' Sets visable to false if shot, and adds to score
        If Me.running = True Then
            picEasy.Visible = False
            intScore += 1
            lblScore.Text = intScore
        End If
    End Sub

    Private Sub picSmall3_Click(sender As Object, e As EventArgs) Handles picSmall3.Click
        ' Sets visable to false if shot, and adds to score
        If Me.running = True Then
            picSmall3.Visible = False
            intScore += 5
            lblScore.Text = intScore
        End If
    End Sub

    Private Sub picMedium2_Click(sender As Object, e As EventArgs) Handles picMedium2.Click
        ' Sets visable to false if shot, and adds to score
        If Me.running = True Then
            picMedium2.Visible = False
            intScore += 3
            lblScore.Text = intScore
        End If
    End Sub

    Private Sub picFlamOne_Click(sender As Object, e As EventArgs) Handles picFlamOne.Click
        ' Sets visable to false if shot, and adds to score
        picFlamOne.Visible = False
        If Me.running = True Then
            picFlamOne.Visible = False
            intScore += 2
            lblScore.Text = intScore
        End If
    End Sub
End Class
