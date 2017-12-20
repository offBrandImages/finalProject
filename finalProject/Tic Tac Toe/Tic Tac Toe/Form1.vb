Public Class Form1
    Dim blnSelect1 As Boolean = False
    Dim blnSelect2 As Boolean = False
    Dim blnSelect3 As Boolean = False
    Dim blnSelect4 As Boolean = False
    Dim blnSelect5 As Boolean = False
    Dim blnSelect6 As Boolean = False
    Dim blnSelect7 As Boolean = False
    Dim blnSelect8 As Boolean = False
    Dim blnSelect9 As Boolean = False
    Dim intGameMoveCounter As Integer = 0
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        blnSelect1 = True
        btn1.BackColor = Color.CadetBlue
        btn2.BackColor = Color.Empty
        btn3.BackColor = Color.Empty
        btn4.BackColor = Color.Empty
        btn5.BackColor = Color.Empty
        btn6.BackColor = Color.Empty
        btn7.BackColor = Color.Empty
        btn8.BackColor = Color.Empty
        btn9.BackColor = Color.Empty
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        blnSelect2 = True
        btn1.BackColor = Color.Empty
        btn2.BackColor = Color.CadetBlue
        btn3.BackColor = Color.Empty
        btn4.BackColor = Color.Empty
        btn5.BackColor = Color.Empty
        btn6.BackColor = Color.Empty
        btn7.BackColor = Color.Empty
        btn8.BackColor = Color.Empty
        btn9.BackColor = Color.Empty
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        blnSelect3 = True
        btn1.BackColor = Color.Empty
        btn2.BackColor = Color.Empty
        btn3.BackColor = Color.CadetBlue
        btn4.BackColor = Color.Empty
        btn5.BackColor = Color.Empty
        btn6.BackColor = Color.Empty
        btn7.BackColor = Color.Empty
        btn8.BackColor = Color.Empty
        btn9.BackColor = Color.Empty
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        blnSelect4 = True
        btn1.BackColor = Color.Empty
        btn2.BackColor = Color.Empty
        btn3.BackColor = Color.Empty
        btn4.BackColor = Color.CadetBlue
        btn5.BackColor = Color.Empty
        btn6.BackColor = Color.Empty
        btn7.BackColor = Color.Empty
        btn8.BackColor = Color.Empty
        btn9.BackColor = Color.Empty
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        blnSelect5 = True
        btn1.BackColor = Color.Empty
        btn2.BackColor = Color.Empty
        btn3.BackColor = Color.Empty
        btn4.BackColor = Color.Empty
        btn5.BackColor = Color.CadetBlue
        btn6.BackColor = Color.Empty
        btn7.BackColor = Color.Empty
        btn8.BackColor = Color.Empty
        btn9.BackColor = Color.Empty
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        blnSelect6 = True
        btn1.BackColor = Color.Empty
        btn2.BackColor = Color.Empty
        btn3.BackColor = Color.Empty
        btn4.BackColor = Color.Empty
        btn5.BackColor = Color.Empty
        btn6.BackColor = Color.CadetBlue
        btn7.BackColor = Color.Empty
        btn8.BackColor = Color.Empty
        btn9.BackColor = Color.Empty
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        blnSelect7 = True
        btn1.BackColor = Color.Empty
        btn2.BackColor = Color.Empty
        btn3.BackColor = Color.Empty
        btn4.BackColor = Color.Empty
        btn5.BackColor = Color.Empty
        btn6.BackColor = Color.Empty
        btn7.BackColor = Color.CadetBlue
        btn8.BackColor = Color.Empty
        btn9.BackColor = Color.Empty
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        blnSelect8 = True
        btn1.BackColor = Color.Empty
        btn2.BackColor = Color.Empty
        btn3.BackColor = Color.Empty
        btn4.BackColor = Color.Empty
        btn5.BackColor = Color.Empty
        btn6.BackColor = Color.Empty
        btn7.BackColor = Color.Empty
        btn8.BackColor = Color.CadetBlue
        btn9.BackColor = Color.Empty
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        blnSelect9 = True
        btn1.BackColor = Color.Empty
        btn2.BackColor = Color.Empty
        btn3.BackColor = Color.Empty
        btn4.BackColor = Color.Empty
        btn5.BackColor = Color.Empty
        btn6.BackColor = Color.Empty
        btn7.BackColor = Color.Empty
        btn8.BackColor = Color.Empty
        btn9.BackColor = Color.CadetBlue
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        intGameMoveCounter += 1
        Label1.Text = intGameMoveCounter.ToString()
        If blnSelect1 = True Then
            picO5.Visible = True
            picX1.Visible = True
            If blnSelect2 = True Then
                picO3.Visible = True
                picX2.Visible = True
                If blnSelect7 = True Then

                End If
            End If
        End If
    End Sub
End Class
