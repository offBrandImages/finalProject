Public Class simonSays
    Dim fullList(256) As Integer
    Dim currentLevel As Integer = 0

    Private Sub simonSays_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        numberMaker()
    End Sub

    Private Sub mainTimer_Tick(sender As Object, e As EventArgs) Handles mainTimer.Tick
        Dim currentLoop As Integer = 1
        If currentLoop >= currentLevel Then
            mainTimer.Stop()
        Else
            If fullList(currentLevel) = 0 Then
                timerGreen.Start()
            ElseIf fullList(currentLevel) = 1 Then
                timerBlue.Start()
            ElseIf fullList(currentLevel) = 2 Then
                timerYellow.Start()
            ElseIf fullList(currentLevel) = 3 Then
                timerRed.Start()
            End If
        End If
        currentLoop += 1
        Console.WriteLine(fullList(currentLevel))
        currentLevel += 1
        Console.WriteLine(currentLevel)
    End Sub

    Private Sub timerBlue_Tick(sender As Object, e As EventArgs) Handles timerBlue.Tick
        picBlue.Image = My.Resources.blueLit
        timerCleanUp.Start()
        timerBlue.Stop()
    End Sub

    Private Sub timerGreen_Tick(sender As Object, e As EventArgs) Handles timerGreen.Tick
        picGreen.Image = My.Resources.greenLit
        timerCleanUp.Start()
        timerGreen.Stop()
    End Sub

    Private Sub timerYellow_Tick(sender As Object, e As EventArgs) Handles timerYellow.Tick
        picYellow.Image = My.Resources.yellowLit
        timerCleanUp.Start()
        timerYellow.Stop()
    End Sub

    Private Sub timerRed_Tick(sender As Object, e As EventArgs) Handles timerRed.Tick
        picRed.Image = My.Resources.redLit
        timerCleanUp.Start()
        timerRed.Stop()
    End Sub

    Private Sub btnStartRound_Click(sender As Object, e As EventArgs) Handles btnStartRound.Click
        mainTimer.Start()
    End Sub

    Private Sub timerCleanUp_Tick(sender As Object, e As EventArgs) Handles timerCleanUp.Tick
        picBlue.Image = My.Resources.blueDim
        picGreen.Image = My.Resources.greenDim
        picYellow.Image = My.Resources.yellowDim
        picRed.Image = My.Resources.RedDim
        timerCleanUp.Stop()
    End Sub

    Private Sub numberMaker()
        For i As Integer = 0 To fullList.Length - 1
            Dim secret As Integer = CInt(Rnd() * 3)
            fullList(i) = secret
        Next
    End Sub
End Class