Public Class Form1

    Dim a As Integer = 0

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        a += 1
        If a Mod 2 = 0 Then
            btn1.Text = "0"
        Else
            btn1.Text = "X"
        End If
        btn1.Enabled = False
        Winner()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        a += 1
        If a Mod 2 = 0 Then
            btn2.Text = "0"
        Else
            btn2.Text = "X"
        End If
        btn2.Enabled = False
        Winner()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        a += 1
        If a Mod 2 = 0 Then
            btn3.Text = "0"
        Else
            btn3.Text = "X"
        End If
        btn3.Enabled = False
        Winner()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        a += 1
        If a Mod 2 = 0 Then
            btn4.Text = "0"
        Else
            btn4.Text = "X"
        End If
        btn4.Enabled = False
        Winner()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        a += 1
        If a Mod 2 = 0 Then
            btn5.Text = "0"
        Else
            btn5.Text = "X"
        End If
        btn5.Enabled = False
        Winner()
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        a += 1
        If a Mod 2 = 0 Then
            btn6.Text = "0"
        Else
            btn6.Text = "X"
        End If
        btn6.Enabled = False
        Winner()
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        a += 1
        If a Mod 2 = 0 Then
            btn7.Text = "0"
        Else
            btn7.Text = "X"
        End If
        btn7.Enabled = False
        Winner()
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        a += 1
        If a Mod 2 = 0 Then
            btn8.Text = "0"
        Else
            btn8.Text = "X"
        End If
        btn8.Enabled = False
        Winner()
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        a += 1
        If a Mod 2 = 0 Then
            btn9.Text = "0"
        Else
            btn9.Text = "X"
        End If
        btn9.Enabled = False
        Winner()
    End Sub

    Private Sub Winner()
        Dim dialogResult1 
        If btn1.Text.Equals("X") And btn2.Text.Equals("X") And btn3.Text.Equals("X") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER X Wins")
        ElseIf btn4.Text.Equals("X") And btn5.Text.Equals("X") And btn6.Text.Equals("X") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER X Wins")
        ElseIf btn7.Text.Equals("X") And btn8.Text.Equals("X") And btn9.Text.Equals("X") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER X Wins")
        ElseIf btn1.Text.Equals("X") And btn4.Text.Equals("X") And btn7.Text.Equals("X") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER X Wins")
        ElseIf btn2.Text.Equals("X") And btn5.Text.Equals("X") And btn8.Text.Equals("X") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER X Wins")
        ElseIf btn3.Text.Equals("X") And btn6.Text.Equals("X") And btn9.Text.Equals("X") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER X Wins")
        ElseIf btn1.Text.Equals("X") And btn5.Text.Equals("X") And btn9.Text.Equals("X") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER X Wins")
        ElseIf btn3.Text.Equals("X") And btn5.Text.Equals("X") And btn7.Text.Equals("X") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER X Wins")
        ElseIf btn1.Text.Equals("0") And btn2.Text.Equals("0") And btn3.Text.Equals("0") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER 0 Wins")
        ElseIf btn4.Text.Equals("0") And btn5.Text.Equals("0") And btn6.Text.Equals("0") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER 0 Wins")
        ElseIf btn7.Text.Equals("0") And btn8.Text.Equals("0") And btn9.Text.Equals("0") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER 0 Wins")
        ElseIf btn1.Text.Equals("0") And btn4.Text.Equals("0") And btn7.Text.Equals("0") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER 0 Wins")
        ElseIf btn2.Text.Equals("0") And btn5.Text.Equals("0") And btn8.Text.Equals("0") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER X Wins")
        ElseIf btn3.Text.Equals("0") And btn6.Text.Equals("0") And btn9.Text.Equals("0") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER 0 Wins")
        ElseIf btn1.Text.Equals("0") And btn5.Text.Equals("0") And btn9.Text.Equals("0") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER 0 Wins")
        ElseIf btn3.Text.Equals("0") And btn5.Text.Equals("0") And btn7.Text.Equals("0") Then
            Dim x = a Mod 2
            dialogResult1 = MessageBox.Show("PLAYER 0 Wins")
        ElseIf a = 9 Then
            dialogResult1 = MessageBox.Show("No Winner, DRAW")
        End If

        If dialogResult1 = DialogResult.OK Then
            Restart()
        End If
    End Sub

    Private Sub Restart()
        a = 0
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
    End Sub
End Class
