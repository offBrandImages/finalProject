﻿Public Class FinishedGame

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Game.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class