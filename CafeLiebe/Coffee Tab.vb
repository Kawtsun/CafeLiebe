Public Class frmCoffeeTab
    Public Property nameCoffee As String
    Public Property quantityCoffee As Integer
    Public Property priceCoffee As Integer
    Public Property totalAmountCoffee As Integer
    Public Property sumTotalCoffee As Integer
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
    Private Sub btnCBuy01_Click(sender As Object, e As EventArgs) Handles btnCBuy01.Click
        If qty1 = 0 Then
            MsgBox("Please enter valid quantity!", vbOKOnly + vbCritical, "Null")
        Else
            nameCoffee = lblCoffeeName01.Text
            quantityCoffee = lblCQuantity01.Text
            priceCoffee = lblCPrice01.Text
            totalAmountCoffee = quantityCoffee * priceCoffee
            sumTotalCoffee += totalAmountCoffee
            Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
            If form1Instance IsNot Nothing Then
                form1Instance.AddDataToGrid(nameCoffee, quantityCoffee, totalAmountCoffee)
            End If
            qty1 = 0
            lblCQuantity01.Text = qty1
        End If
    End Sub

    Private Sub btnCBuy02_Click(sender As Object, e As EventArgs) Handles btnCBuy02.Click
        If qty2 = 0 Then
            MsgBox("Please enter valid quantity!", vbOKOnly + vbCritical, "Null")
        Else
            nameCoffee = lblCoffeeName02.Text
            quantityCoffee = lblCQuantity02.Text
            priceCoffee = lblCPrice02.Text
            totalAmountCoffee = quantityCoffee * priceCoffee
            sumTotalCoffee += totalAmountCoffee
            Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
            If form1Instance IsNot Nothing Then
                form1Instance.AddDataToGrid(nameCoffee, quantityCoffee, totalAmountCoffee)
            End If
            qty2 = 0
            lblCQuantity02.Text = qty2
        End If
    End Sub

    Private Sub btnCBuy03_Click(sender As Object, e As EventArgs) Handles btnCBuy03.Click
        If qty3 = 0 Then
            MsgBox("Please enter valid quantity!", vbOKOnly + vbCritical, "Null")
        Else
            nameCoffee = lblCoffeeName03.Text
            quantityCoffee = lblCQuantity03.Text
            priceCoffee = lblCPrice03.Text
            totalAmountCoffee = quantityCoffee * priceCoffee
            sumTotalCoffee += totalAmountCoffee
            Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
            If form1Instance IsNot Nothing Then
                form1Instance.AddDataToGrid(nameCoffee, quantityCoffee, totalAmountCoffee)
            End If
            qty3 = 0
            lblCQuantity03.Text = qty3
        End If
    End Sub

    Private Sub btnCBuy04_Click(sender As Object, e As EventArgs) Handles btnCBuy04.Click
        If qty4 = 0 Then
            MsgBox("Please enter valid quantity!", vbOKOnly + vbCritical, "Null")
        Else
            nameCoffee = lblCoffeeName04.Text
            quantityCoffee = lblCQuantity04.Text
            priceCoffee = lblCPrice04.Text
            totalAmountCoffee = quantityCoffee * priceCoffee
            sumTotalCoffee += totalAmountCoffee
            Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
            If form1Instance IsNot Nothing Then
                form1Instance.AddDataToGrid(nameCoffee, quantityCoffee, totalAmountCoffee)
            End If
            qty4 = 0
            lblCQuantity04.Text = qty4
        End If
    End Sub

    Private Sub btnCBuy05_Click(sender As Object, e As EventArgs) Handles btnCBuy05.Click
        If qty5 = 0 Then
            MsgBox("Please enter valid quantity!", vbOKOnly + vbCritical, "Null")
        Else
            nameCoffee = lblCoffeeName05.Text
            quantityCoffee = lblCQuantity05.Text
            priceCoffee = lblCPrice05.Text
            totalAmountCoffee = quantityCoffee * priceCoffee
            sumTotalCoffee += totalAmountCoffee
            Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
            If form1Instance IsNot Nothing Then
                form1Instance.AddDataToGrid(nameCoffee, quantityCoffee, totalAmountCoffee)
            End If
            qty5 = 0
            lblCQuantity05.Text = qty5
        End If
    End Sub

    Private Sub btnCBuy06_Click(sender As Object, e As EventArgs) Handles btnCBuy06.Click
        If qty6 = 0 Then
            MsgBox("Please enter valid quantity!", vbOKOnly + vbCritical, "Null")
        Else
            nameCoffee = lblCoffeeName06.Text
            quantityCoffee = lblCQuantity06.Text
            priceCoffee = lblCPrice06.Text
            totalAmountCoffee = quantityCoffee * priceCoffee
            sumTotalCoffee += totalAmountCoffee
            Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
            If form1Instance IsNot Nothing Then
                form1Instance.AddDataToGrid(nameCoffee, quantityCoffee, totalAmountCoffee)
            End If
            qty6 = 0
            lblCQuantity06.Text = qty6
        End If
    End Sub

    Private Sub btnCBuy07_Click(sender As Object, e As EventArgs) Handles btnCBuy07.Click
        If qty7 = 0 Then
            MsgBox("Please enter valid quantity!", vbOKOnly + vbCritical, "Null")
        Else
            nameCoffee = lblCoffeeName07.Text
            quantityCoffee = lblCQuantity07.Text
            priceCoffee = lblCPrice07.Text
            totalAmountCoffee = quantityCoffee * priceCoffee
            sumTotalCoffee += totalAmountCoffee
            Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
            If form1Instance IsNot Nothing Then
                form1Instance.AddDataToGrid(nameCoffee, quantityCoffee, totalAmountCoffee)
            End If
            qty7 = 0
            lblCQuantity07.Text = qty7
        End If
    End Sub

    Private Sub btnCBuy08_Click(sender As Object, e As EventArgs) Handles btnCBuy08.Click
        If qty8 = 0 Then
            MsgBox("Please enter valid quantity!", vbOKOnly + vbCritical, "Null")
        Else
            nameCoffee = lblCoffeeName08.Text
            quantityCoffee = lblCQuantity02.Text
            priceCoffee = lblCPrice02.Text
            totalAmountCoffee = quantityCoffee * priceCoffee
            sumTotalCoffee += totalAmountCoffee
            Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
            If form1Instance IsNot Nothing Then
                form1Instance.AddDataToGrid(nameCoffee, quantityCoffee, totalAmountCoffee)
            End If
            qty8 = 0
            lblCQuantity08.Text = qty8
        End If
    End Sub

End Class