Public Class frmCakeTab
    Public Property nameCake As String
    Public Property quantityCake As Integer
    Public Property priceCake As Integer
    Public Property totalAmountCake As Integer
    Public Property sumTotalCake As Integer

    Dim qty1, qty2, qty3, qty4, qty5, qty6, qty7, qty8 As Integer

    Private Sub btnCaQAdd01_Click(sender As Object, e As EventArgs) Handles btnCaQAdd01.Click
        If qty1 < 10 Then
            qty1 = qty1 + 1
            lblCaQuantity01.Text = qty1
        End If
    End Sub

    Private Sub btnCaQMinus01_Click(sender As Object, e As EventArgs) Handles btnCaQMinus01.Click
        If qty1 > 0 Then
            qty1 = qty1 - 1
            lblCaQuantity01.Text = qty1
        End If
    End Sub

    Private Sub btnCaQAdd02_Click(sender As Object, e As EventArgs) Handles btnCaQAdd02.Click
        If qty2 < 10 Then
            qty2 = qty2 + 1
            lblCaQuantity02.Text = qty2
        End If
    End Sub

    Private Sub btnCaQMinus02_Click(sender As Object, e As EventArgs) Handles btnCaQMinus02.Click
        If qty2 > 0 Then
            qty2 = qty2 - 1
            lblCaQuantity02.Text = qty2
        End If
    End Sub

    Private Sub btnCaQAdd03_Click(sender As Object, e As EventArgs) Handles btnCaQAdd03.Click
        If qty3 < 10 Then
            qty3 = qty3 + 1
            lblCaQuantity03.Text = qty3
        End If
    End Sub

    Private Sub btnCaQMinus03_Click(sender As Object, e As EventArgs) Handles btnCaQMinus03.Click
        If qty3 > 0 Then
            qty3 = qty3 - 1
            lblCaQuantity03.Text = qty3
        End If
    End Sub

    Private Sub btnCaQAdd04_Click(sender As Object, e As EventArgs) Handles btnCaQAdd04.Click
        If qty4 < 10 Then
            qty4 = qty4 + 1
            lblCaQuantity04.Text = qty4
        End If
    End Sub

    Private Sub btnCaQMinus04_Click(sender As Object, e As EventArgs) Handles btnCaQMinus04.Click
        If qty4 > 0 Then
            qty4 = qty4 - 1
            lblCaQuantity04.Text = qty4
        End If
    End Sub

    Private Sub btnCaQAdd05_Click(sender As Object, e As EventArgs) Handles btnCaQAdd05.Click
        If qty5 < 10 Then
            qty5 = qty5 + 1
            lblCaQuantity05.Text = qty5
        End If
    End Sub

    Private Sub btnCaQMinus05_Click(sender As Object, e As EventArgs) Handles btnCaQMinus05.Click
        If qty5 > 0 Then
            qty5 = qty5 - 1
            lblCaQuantity05.Text = qty5
        End If
    End Sub

    Private Sub btnCaQAdd06_Click(sender As Object, e As EventArgs) Handles btnCaQAdd06.Click
        If qty6 < 10 Then
            qty6 = qty6 + 1
            lblCaQuantity06.Text = qty6
        End If
    End Sub

    Private Sub btnCaQMinus06_Click(sender As Object, e As EventArgs) Handles btnCaQMinus06.Click
        If qty6 > 0 Then
            qty6 = qty6 - 1
            lblCaQuantity06.Text = qty6
        End If
    End Sub

    Private Sub btnCaQAdd07_Click(sender As Object, e As EventArgs) Handles btnCaQAdd07.Click
        If qty7 < 10 Then
            qty7 = qty7 + 1
            lblCaQuantity07.Text = qty7
        End If
    End Sub

    Private Sub btnCaQMinus07_Click(sender As Object, e As EventArgs) Handles btnCaQMinus07.Click
        If qty7 > 0 Then
            qty7 = qty7 - 1
            lblCaQuantity07.Text = qty7
        End If
    End Sub

    Private Sub btnCaQAdd08_Click(sender As Object, e As EventArgs) Handles btnCaQAdd08.Click
        If qty8 < 10 Then
            qty8 = qty8 + 1
            lblCaQuantity08.Text = qty8
        End If
    End Sub

    Private Sub btnCaBuy01_Click(sender As Object, e As EventArgs) Handles btnCaBuy01.Click
        nameCake = lblCakeName01.Text
        quantityCake = lblCaQuantity01.Text
        priceCake = lblCaPrice01.Text
        totalAmountCake = quantityCake * priceCake
        sumTotalCake += totalAmountCake
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameCake, quantityCake, totalAmountCake)
        End If
        qty1 = 0
        lblCaQuantity01.Text = qty1
    End Sub

    Private Sub btnCaBuy02_Click(sender As Object, e As EventArgs) Handles btnCaBuy02.Click
        nameCake = lblCakeName02.Text
        quantityCake = lblCaQuantity02.Text
        priceCake = lblCaPrice02.Text
        totalAmountCake = quantityCake * priceCake
        sumTotalCake += totalAmountCake
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameCake, quantityCake, totalAmountCake)
        End If
        qty2 = 0
        lblCaQuantity02.Text = qty2
    End Sub

    Private Sub btnCaBuy03_Click(sender As Object, e As EventArgs) Handles btnCaBuy03.Click
        nameCake = lblCakeName03.Text
        quantityCake = lblCaQuantity03.Text
        priceCake = lblCaPrice03.Text
        totalAmountCake = quantityCake * priceCake
        sumTotalCake += totalAmountCake
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameCake, quantityCake, totalAmountCake)
        End If
        qty3 = 0
        lblCaQuantity03.Text = qty3
    End Sub

    Private Sub btnCaBuy04_Click(sender As Object, e As EventArgs) Handles btnCaBuy04.Click
        nameCake = lblCakeName04.Text
        quantityCake = lblCaQuantity04.Text
        priceCake = lblCaPrice04.Text
        totalAmountCake = quantityCake * priceCake
        sumTotalCake += totalAmountCake
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameCake, quantityCake, totalAmountCake)
        End If
        qty4 = 0
        lblCaQuantity04.Text = qty4
    End Sub

    Private Sub btnCaBuy05_Click(sender As Object, e As EventArgs) Handles btnCaBuy05.Click
        nameCake = lblCakeName05.Text
        quantityCake = lblCaQuantity05.Text
        priceCake = lblCaPrice05.Text
        totalAmountCake = quantityCake * priceCake
        sumTotalCake += totalAmountCake
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameCake, quantityCake, totalAmountCake)
        End If
        qty5 = 0
        lblCaQuantity05.Text = qty5
    End Sub

    Private Sub btnCaBuy06_Click(sender As Object, e As EventArgs) Handles btnCaBuy06.Click
        nameCake = lblCakeName06.Text
        quantityCake = lblCaQuantity06.Text
        priceCake = lblCaPrice06.Text
        totalAmountCake = quantityCake * priceCake
        sumTotalCake += totalAmountCake
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameCake, quantityCake, totalAmountCake)
        End If
        qty6 = 0
        lblCaQuantity06.Text = qty6
    End Sub

    Private Sub btnCaBuy07_Click(sender As Object, e As EventArgs) Handles btnCaBuy07.Click
        nameCake = lblCakeName07.Text
        quantityCake = lblCaQuantity07.Text
        priceCake = lblCaPrice07.Text
        totalAmountCake = quantityCake * priceCake
        sumTotalCake += totalAmountCake
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameCake, quantityCake, totalAmountCake)
        End If
        qty7 = 0
        lblCaQuantity07.Text = qty7
    End Sub

    Private Sub btnCaBuy08_Click(sender As Object, e As EventArgs) Handles btnCaBuy08.Click
        nameCake = lblCakeName08.Text
        quantityCake = lblCaQuantity08.Text
        priceCake = lblCaPrice08.Text
        totalAmountCake = quantityCake * priceCake
        sumTotalCake += totalAmountCake
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)
        If form1Instance IsNot Nothing Then
            form1Instance.AddDataToGrid(nameCake, quantityCake, totalAmountCake)
        End If
        qty8 = 0
        lblCaQuantity08.Text = qty8
    End Sub
End Class