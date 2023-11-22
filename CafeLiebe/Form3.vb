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
End Class