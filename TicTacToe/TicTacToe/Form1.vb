Public Class Form1
    Dim playerOneTurn As Boolean = True 'keeps track of players turn


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If playerOneTurn Then
            Button1.Text = "X"
            playerOneTurn = False
            Button1.Enabled = False
            checkit()
        Else
            Button1.Text = "O"
            playerOneTurn = True
            Button1.Enabled = False
            checkit()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If playerOneTurn Then
            Button2.Text = "X"
            playerOneTurn = False
            Button2.Enabled = False
            checkit()
        Else
            Button2.Text = "O"
            playerOneTurn = True
            Button2.Enabled = False
            checkit()
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If playerOneTurn Then
            Button3.Text = "X"
            playerOneTurn = False
            Button3.Enabled = False
            checkit()
        Else
            Button3.Text = "O"
            playerOneTurn = True
            Button3.Enabled = False
            checkit()
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If playerOneTurn Then
            Button4.Text = "X"
            playerOneTurn = False
            Button4.Enabled = False
            checkit()
        Else
            Button4.Text = "O"
            playerOneTurn = True
            Button4.Enabled = False
            checkit()
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If playerOneTurn Then
            Button5.Text = "X"
            playerOneTurn = False
            Button5.Enabled = False
            checkit()
        Else
            Button5.Text = "O"
            playerOneTurn = True
            Button5.Enabled = False
            checkit()
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If playerOneTurn Then
            Button6.Text = "X"
            playerOneTurn = False
            Button6.Enabled = False
            checkit()
        Else
            Button6.Text = "O"
            playerOneTurn = True
            Button6.Enabled = False
            checkit()
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If playerOneTurn Then
            Button7.Text = "X"
            playerOneTurn = False
            Button7.Enabled = False
            checkit()
        Else
            Button7.Text = "O"
            playerOneTurn = True
            Button7.Enabled = False
            checkit()
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If playerOneTurn Then
            Button8.Text = "X"
            playerOneTurn = False
            Button8.Enabled = False
            checkit()
        Else
            Button8.Text = "O"
            playerOneTurn = True
            Button8.Enabled = False
            checkit()
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If playerOneTurn Then
            Button9.Text = "X"
            playerOneTurn = False
            Button9.Enabled = False
            checkit()
        Else
            Button9.Text = "O"
            playerOneTurn = True
            Button9.Enabled = False
            checkit()
        End If
    End Sub
    ' the method below checks for wins and ties
    Public Sub checkit()
        ' The if statements below handle all the different ways "X" could win
        If (Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X") Then
            MessageBox.Show("Player 1 Wins!")
            Close()
        ElseIf (Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X") Then
            MessageBox.Show("Player 1 Wins!")
            Close()
        ElseIf (Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X") Then
            MessageBox.Show("Player 1 Wins!")
            Close()
        ElseIf (Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X") Then
            MessageBox.Show("Player 1 Wins!")
            Close()
        ElseIf (Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X") Then
            MessageBox.Show("Player 1 Wins!")
            Close()
        ElseIf (Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X") Then
            MessageBox.Show("Player 1 Wins!")
            Close()
        ElseIf (Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X") Then
            MessageBox.Show("Player 1 Wins!")
            Close()
        ElseIf (Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X") Then
            MessageBox.Show("Player 1 Wins!")
            Close()
        End If
        ' The if statements below handle all the different ways "O" could win
        If (Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O") Then
            MessageBox.Show("Player 2 Wins!")
            Close()
        ElseIf (Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O") Then
            MessageBox.Show("Player 2 Wins!")
            Close()
        ElseIf (Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O") Then
            MessageBox.Show("Player 2 Wins!")
            Close()
        ElseIf (Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O") Then
            MessageBox.Show("Player 2 Wins!")
            Close()
        ElseIf (Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O") Then
            MessageBox.Show("Player 2 Wins!")
            Close()
        ElseIf (Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O") Then
            MessageBox.Show("Player 2 Wins!")
            Close()
        ElseIf (Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O") Then
            MessageBox.Show("Player 2 Wins!")
            Close()
        ElseIf (Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O") Then
            MessageBox.Show("Player 2 Wins!")
            Close()
        End If

        'The if statement below handles ties
        If (Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And
            Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And
            Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False) Then
            MessageBox.Show("Players Tie!")
            Close()
        End If

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
