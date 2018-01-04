Public Class Form1
    Dim intCount As Integer

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True

        For Me.intCount = 1 To 30

        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        picEasy.Left += 20
        Me.intCount += 1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        picMedium.Left += 35
        picMedium2.Left -= 35
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        picSmall1.Left += 30
        picSmall2.Left += 40
        picSmall3.Left -= 30
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub picSmall1_Click(sender As Object, e As EventArgs) Handles picSmall1.Click
        picSmall1.Visible = False
    End Sub

    Private Sub picMedium_Click(sender As Object, e As EventArgs) Handles picMedium.Click
        picMedium.Visible = False
    End Sub

    Private Sub picSmall2_Click(sender As Object, e As EventArgs) Handles picSmall2.Click
        picSmall2.Visible = False
    End Sub

    Private Sub picEasy_Click(sender As Object, e As EventArgs) Handles picEasy.Click
        picEasy.Visible = False
    End Sub

    Private Sub picSmall3_Click(sender As Object, e As EventArgs) Handles picSmall3.Click
        picSmall3.Visible = False
    End Sub

    Private Sub picMedium2_Click(sender As Object, e As EventArgs) Handles picMedium2.Click
        picMedium2.Visible = False
    End Sub

    Private Sub picFlamOne_Click(sender As Object, e As EventArgs) Handles picFlamOne.Click
        picFlamOne.Visible = False
    End Sub
End Class
