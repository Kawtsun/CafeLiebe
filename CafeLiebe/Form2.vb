Public Class Form2
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnCoffee_Click(sender As Object, e As EventArgs) Handles btnCoffee.Click
        With Form3
            .TopLevel = False
            pnlOrder.Controls.Add(Form3)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnCake_Click(sender As Object, e As EventArgs) Handles btnCake.Click
        With Form4
            .TopLevel = False
            pnlOrder.Controls.Add(Form4)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnSorbet_Click(sender As Object, e As EventArgs) Handles btnSorbet.Click
        With Form5
            .TopLevel = False
            pnlOrder.Controls.Add(Form5)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Form6.Show()
        Me.Hide()
    End Sub
End Class