Public Class Form1
    Dim intScore As Integer
    Dim intFalmCount As Integer
    Dim running As Boolean = False
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Me.running = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        intFalmCount += 1

        For Me.intFalmCount = 1 To 20
            picFlamOne.Left += 1
            picFlamOne.Top -= 1
        Next
        
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        picEasy.Left += 1
        picMedium.Left += 35
        picMedium2.Left -= 35
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        picSmall1.Left += 30
        picSmall2.Left += 40
        picSmall3.Left -= 30
    End Sub
    Private Sub picSmall1_Click(sender As Object, e As EventArgs) Handles picSmall1.Click
        If Me.running = True Then
            picSmall1.Visible = False
            intScore += 5
            lblScore.Text = intScore
        End If
    End Sub

    Private Sub picMedium_Click(sender As Object, e As EventArgs) Handles picMedium.Click
        If Me.running = True Then
            picMedium.Visible = False
            intScore += 3
            lblScore.Text = intScore
        End If
    End Sub

    Private Sub picSmall2_Click(sender As Object, e As EventArgs) Handles picSmall2.Click
        If Me.running = True Then
            picSmall2.Visible = False
            intScore += 5
            lblScore.Text = intScore
        End If
    End Sub

    Private Sub picEasy_Click(sender As Object, e As EventArgs) Handles picEasy.Click
        If Me.running = True Then
            picEasy.Visible = False
            intScore += 1
            lblScore.Text = intScore
        End If
    End Sub

    Private Sub picSmall3_Click(sender As Object, e As EventArgs) Handles picSmall3.Click
        If Me.running = True Then
            picSmall3.Visible = False
            intScore += 5
            lblScore.Text = intScore
        End If
    End Sub

    Private Sub picMedium2_Click(sender As Object, e As EventArgs) Handles picMedium2.Click
        If Me.running = True Then
            picMedium2.Visible = False
            intScore += 3
            lblScore.Text = intScore
        End If
    End Sub

    Private Sub picFlamOne_Click(sender As Object, e As EventArgs) Handles picFlamOne.Click
        picFlamOne.Visible = False
        If Me.running = True Then
            picFlamOne.Visible = False
            intScore += 2
            lblScore.Text = intScore
        End If
    End Sub
End Class
