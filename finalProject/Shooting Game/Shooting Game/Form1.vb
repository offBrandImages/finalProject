Public Class Form1

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim intCount As Integer = 1
        For intCount = 1 To 780
        Next

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        picEasy.Left += 20
    End Sub
End Class
