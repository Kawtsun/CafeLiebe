Public Class frmMainMenu
    Public Property totalofAll As Integer
    Dim index As Integer
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCoffee.PerformClick()
    End Sub

    Public Function GetDataGridView() As DataGridView
        Return DataGridView1
    End Function

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

        btnCoffee.BackColor = System.Drawing.Color.White
        btnCake.BackColor = System.Drawing.Color.FromArgb(234, 225, 210)
        btnSorbet.BackColor = System.Drawing.Color.FromArgb(234, 225, 210)

    End Sub

    Private Sub btnCake_Click(sender As Object, e As EventArgs) Handles btnCake.Click
        With frmCakeTab
            .TopLevel = False
            pnlOrder.Controls.Add(frmCakeTab)
            .BringToFront()
            .Show()
        End With

        btnCoffee.BackColor = System.Drawing.Color.FromArgb(234, 225, 210)
        btnCake.BackColor = System.Drawing.Color.White
        btnSorbet.BackColor = System.Drawing.Color.FromArgb(234, 225, 210)
    End Sub

    Private Sub btnSorbet_Click(sender As Object, e As EventArgs) Handles btnSorbet.Click
        With frmDesertTab
            .TopLevel = False
            pnlOrder.Controls.Add(frmDesertTab)
            .BringToFront()
            .Show()
        End With

        btnCoffee.BackColor = System.Drawing.Color.FromArgb(234, 225, 210)
        btnCake.BackColor = System.Drawing.Color.FromArgb(234, 225, 210)
        btnSorbet.BackColor = System.Drawing.Color.White
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        totalofAll += frmCoffeeTab.sumTotalCoffee + frmCakeTab.sumTotalCake + frmDesertTab.sumTotalDesert
        frmPaymentMenu.Show()
        Me.Hide()
    End Sub
    Public Sub AddDataToGrid(data1 As String, data2 As String, data3 As String)
        DataGridView1.Rows.Add(data1, data2, data3)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'Select item (row) then click button to remove from Grid
        If DataGridView1.SelectedRows.Count > 0 Then
            For i As Integer = DataGridView1.SelectedRows.Count - 1 To 0 Step -1
                DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(i).Index)
            Next
        Else
            MsgBox("No item selected!")
        End If
    End Sub
End Class