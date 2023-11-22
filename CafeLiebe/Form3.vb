Public Class Form3
    Dim qty1, qty2, qty3, qty4, qty5, qty6, qty7, qty8 As Integer

    Private Sub btnCQAdd01_Click(sender As Object, e As EventArgs) Handles btnCQAdd01.Click
        If qty1 < 10 Then
            qty1 = qty1 + 1
            lblCQuantity01.Text = qty1
        End If
    End Sub

    Private Sub btnCQMinus01_Click(sender As Object, e As EventArgs) Handles btnCQMinus01.Click
        If qty1 > 0 Then
            qty1 = qty1 - 1
            lblCQuantity01.Text = qty1
        End If
    End Sub

    Private Sub btnCQAdd02_Click(sender As Object, e As EventArgs) Handles btnCQAdd02.Click
        If qty2 < 10 Then
            qty2 = qty2 + 1
            lblCQuantity02.Text = qty2
        End If
    End Sub

    Private Sub btnCQMinus02_Click(sender As Object, e As EventArgs) Handles btnCQMinus02.Click
        If qty2 > 0 Then
            qty2 = qty2 - 1
            lblCQuantity02.Text = qty2
        End If
    End Sub

    Private Sub btnCQAdd03_Click(sender As Object, e As EventArgs) Handles btnCQAdd03.Click
        If qty3 < 10 Then
            qty3 = qty3 + 1
            lblCQuantity03.Text = qty3
        End If
    End Sub

    Private Sub btnCQMinus03_Click(sender As Object, e As EventArgs) Handles btnCQMinus03.Click
        If qty3 > 0 Then
            qty3 = qty3 - 1
            lblCQuantity03.Text = qty3
        End If
    End Sub

    Private Sub btnCQAdd04_Click(sender As Object, e As EventArgs) Handles btnCQAdd04.Click
        If qty4 < 10 Then
            qty4 = qty4 + 1
            lblCQuantity04.Text = qty4
        End If
    End Sub

    Private Sub btnCQMinus04_Click(sender As Object, e As EventArgs) Handles btnCQMinus04.Click
        If qty4 > 0 Then
            qty4 = qty4 - 1
            lblCQuantity04.Text = qty4
        End If
    End Sub

    Private Sub btnCQAdd05_Click(sender As Object, e As EventArgs) Handles btnCQAdd05.Click
        If qty5 < 10 Then
            qty5 = qty5 + 1
            lblCQuantity05.Text = qty5
        End If
    End Sub

    Private Sub btnCQMinus05_Click(sender As Object, e As EventArgs) Handles btnCQMinus05.Click
        If qty5 > 0 Then
            qty5 = qty5 - 1
            lblCQuantity05.Text = qty5
        End If
    End Sub

    Private Sub btnCQAdd06_Click(sender As Object, e As EventArgs) Handles btnCQAdd06.Click
        If qty6 < 10 Then
            qty6 = qty6 + 1
            lblCQuantity06.Text = qty6
        End If
    End Sub

    Private Sub btnCQMinus06_Click(sender As Object, e As EventArgs) Handles btnCQMinus06.Click
        If qty6 > 0 Then
            qty6 = qty6 - 1
            lblCQuantity06.Text = qty6
        End If
    End Sub

    Private Sub btnCQAdd07_Click(sender As Object, e As EventArgs) Handles btnCQAdd07.Click
        If qty7 < 10 Then
            qty7 = qty7 + 1
            lblCQuantity07.Text = qty7
        End If
    End Sub

    Private Sub btnCQMinus07_Click(sender As Object, e As EventArgs) Handles btnCQMinus07.Click
        If qty7 > 0 Then
            qty7 = qty7 - 1
            lblCQuantity07.Text = qty7
        End If
    End Sub

    Private Sub btnCQAdd08_Click(sender As Object, e As EventArgs) Handles btnCQAdd08.Click
        If qty8 < 10 Then
            qty8 = qty8 + 1
            lblCQuantity08.Text = qty8
        End If
    End Sub

    Private Sub btnCQMinus08_Click(sender As Object, e As EventArgs) Handles btnCQMinus08.Click
        If qty8 > 0 Then
            qty8 = qty8 - 1
            lblCQuantity08.Text = qty8
        End If
    End Sub
End Class