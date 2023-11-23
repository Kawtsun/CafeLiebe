Public Class frmMainMenu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHomeWindow.Show()
        Me.Hide()
    End Sub

    Private Sub btnCoffee_Click(sender As Object, e As EventArgs) Handles btnCoffee.Click
        With frmCoffeeTab
            .TopLevel = False
            pnlOrder.Controls.Add(frmCoffeeTab)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnCake_Click(sender As Object, e As EventArgs) Handles btnCake.Click
        With frmCakeTab
            .TopLevel = False
            pnlOrder.Controls.Add(frmCakeTab)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnSorbet_Click(sender As Object, e As EventArgs) Handles btnSorbet.Click
        With frmDesertTab
            .TopLevel = False
            pnlOrder.Controls.Add(frmDesertTab)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        frmPaymentMenu.Show()
        Me.Hide()
    End Sub
End Class