Public Class frmDesertTab
    Public Property nameDessert As String
    Public Property quantityDessert As Integer
    Public Property priceDessert As Integer
    Public Property totalAmountDessert As Integer
    Dim qty1, qty2, qty3, qty4, qty5, qty6, qty7, qty8 As Integer

    Private Sub btnSQAdd01_Click(sender As Object, e As EventArgs) Handles btnSQAdd01.Click
        If qty1 < 10 Then
            qty1 = qty1 + 1
            lblSQuantity01.Text = qty1
        End If
    End Sub

    Private Sub btnSQMinus01_Click(sender As Object, e As EventArgs) Handles btnSQMinus01.Click
        If qty1 > 0 Then
            qty1 = qty1 - 1
            lblSQuantity01.Text = qty1
        End If
    End Sub

    Private Sub btnSQAdd02_Click(sender As Object, e As EventArgs) Handles btnSQAdd02.Click
        If qty2 < 10 Then
            qty2 = qty2 + 1
            lblSQuantity02.Text = qty2
        End If
    End Sub

    Private Sub btnSQMinus02_Click(sender As Object, e As EventArgs) Handles btnSQMinus02.Click
        If qty2 > 0 Then
            qty2 = qty2 - 1
            lblSQuantity02.Text = qty2
        End If
    End Sub

    Private Sub btnSQAdd03_Click(sender As Object, e As EventArgs) Handles btnSQAdd03.Click
        If qty3 < 10 Then
            qty3 = qty3 + 1
            lblSQuantity03.Text = qty3
        End If
    End Sub

    Private Sub btnSQMinus03_Click(sender As Object, e As EventArgs) Handles btnSQMinus03.Click
        If qty3 > 0 Then
            qty3 = qty3 - 1
            lblSQuantity03.Text = qty3
        End If
    End Sub

    Private Sub btnSQAdd04_Click(sender As Object, e As EventArgs) Handles btnSQAdd04.Click
        If qty4 < 10 Then
            qty4 = qty4 + 1
            lblSQuantity04.Text = qty4
        End If
    End Sub

    Private Sub btnSQMinus04_Click(sender As Object, e As EventArgs) Handles btnSQMinus04.Click
        If qty4 > 0 Then
            qty4 = qty4 - 1
            lblSQuantity04.Text = qty4
        End If
    End Sub

    Private Sub btnSQAdd05_Click(sender As Object, e As EventArgs) Handles btnSQAdd05.Click
        If qty5 < 10 Then
            qty5 = qty5 + 1
            lblSQuantity05.Text = qty5
        End If
    End Sub

    Private Sub btnSQMinus05_Click(sender As Object, e As EventArgs) Handles btnSQMinus05.Click
        If qty5 > 0 Then
            qty5 = qty5 - 1
            lblSQuantity05.Text = qty5
        End If
    End Sub

    Private Sub btnSQAdd06_Click(sender As Object, e As EventArgs) Handles btnSQAdd06.Click
        If qty6 < 10 Then
            qty6 = qty6 + 1
            lblSQuantity06.Text = qty6
        End If
    End Sub

    Private Sub btnSQMinus06_Click(sender As Object, e As EventArgs) Handles btnSQMinus06.Click
        If qty6 > 0 Then
            qty6 = qty6 - 1
            lblSQuantity06.Text = qty6
        End If
    End Sub

    Private Sub btnSQAdd07_Click(sender As Object, e As EventArgs) Handles btnSQAdd07.Click
        If qty7 < 10 Then
            qty7 = qty7 + 1
            lblSQuantity07.Text = qty7
        End If
    End Sub

    Private Sub btnSQMinus07_Click(sender As Object, e As EventArgs) Handles btnSQMinus07.Click
        If qty7 > 0 Then
            qty7 = qty7 - 1
            lblSQuantity07.Text = qty7
        End If
    End Sub

    Private Sub btnSQAdd08_Click(sender As Object, e As EventArgs) Handles btnSQAdd08.Click
        If qty8 < 10 Then
            qty8 = qty8 + 1
            lblSQuantity08.Text = qty8
        End If
    End Sub

    Private Sub btnSBuy01_Click(sender As Object, e As EventArgs) Handles btnSBuy01.Click
        nameDessert = "Dessert 1"
        quantityDessert = lblSQuantity01.Text
        priceDessert = lblSPrice01.Text
        totalAmountDessert = quantityDessert * priceDessert
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameDessert, quantityDessert, totalAmountDessert)
        End If
    End Sub

    Private Sub btnSBuy02_Click(sender As Object, e As EventArgs) Handles btnSBuy02.Click
        nameDessert = "Dessert 2"
        quantityDessert = lblSQuantity02.Text
        priceDessert = lblSPrice02.Text
        totalAmountDessert = quantityDessert * priceDessert
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameDessert, quantityDessert, totalAmountDessert)
        End If
    End Sub

    Private Sub btnSBuy03_Click(sender As Object, e As EventArgs) Handles btnSBuy03.Click
        nameDessert = "Dessert 3"
        quantityDessert = lblSQuantity03.Text
        priceDessert = lblSPrice03.Text
        totalAmountDessert = quantityDessert * priceDessert
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameDessert, quantityDessert, totalAmountDessert)
        End If
    End Sub

    Private Sub btnSBuy04_Click(sender As Object, e As EventArgs) Handles btnSBuy04.Click
        nameDessert = "Dessert 4"
        quantityDessert = lblSQuantity04.Text
        priceDessert = lblSPrice04.Text
        totalAmountDessert = quantityDessert * priceDessert
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameDessert, quantityDessert, totalAmountDessert)
        End If
    End Sub

    Private Sub btnSBuy05_Click(sender As Object, e As EventArgs) Handles btnSBuy05.Click
        nameDessert = "Dessert 5"
        quantityDessert = lblSQuantity05.Text
        priceDessert = lblSPrice05.Text
        totalAmountDessert = quantityDessert * priceDessert
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameDessert, quantityDessert, totalAmountDessert)
        End If
    End Sub

    Private Sub btnSBuy06_Click(sender As Object, e As EventArgs) Handles btnSBuy06.Click
        nameDessert = "Dessert 6"
        quantityDessert = lblSQuantity06.Text
        priceDessert = lblSPrice06.Text
        totalAmountDessert = quantityDessert * priceDessert
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameDessert, quantityDessert, totalAmountDessert)
        End If
    End Sub

    Private Sub btnSBuy07_Click(sender As Object, e As EventArgs) Handles btnSBuy07.Click
        nameDessert = "Dessert 7"
        quantityDessert = lblSQuantity07.Text
        priceDessert = lblSPrice07.Text
        totalAmountDessert = quantityDessert * priceDessert
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameDessert, quantityDessert, totalAmountDessert)
        End If
    End Sub

    Private Sub btnSBuy08_Click(sender As Object, e As EventArgs) Handles btnSBuy08.Click
        nameDessert = "Dessert 8"
        quantityDessert = lblSQuantity08.Text
        priceDessert = lblSPrice08.Text
        totalAmountDessert = quantityDessert * priceDessert
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameDessert, quantityDessert, totalAmountDessert)
        End If
    End Sub
End Class