﻿Public Class frmPaymentMenu
    Public Property recieverTotal As Integer
    Public Property serviceType As String = ""
    Public Property paymentUpdate As Boolean = True
    Dim index, change As Integer
    Dim total As Integer

    Private Sub UpdateTotalAmount()
        total = 0
        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow Then
                Dim cellValue As Object = row.Cells(2).Value
                If cellValue IsNot Nothing AndAlso Not IsDBNull(cellValue) Then
                    Dim value As Integer = Int32.Parse(Val(cellValue))
                    total += value
                End If
            End If
        Next
    End Sub

    Private Sub DuplicateDataGridView()
        ' Get access to Form1 instance
        Dim form1Instance As frmMainMenu = CType(Application.OpenForms("frmMainMenu"), frmMainMenu)

        ' Check if Form1 instance exists
        If form1Instance IsNot Nothing Then
            ' Get the DataGridView from Form1
            Dim dataGridViewFromForm1 As DataGridView = form1Instance.GetDataGridView()

            ' Duplicate the columns
            For Each column As DataGridViewColumn In dataGridViewFromForm1.Columns
                DataGridView2.Columns.Add(DirectCast(column.Clone(), DataGridViewColumn))
            Next

            ' Duplicate the rows and their data
            For Each row As DataGridViewRow In dataGridViewFromForm1.Rows
                Dim newRow As DataGridViewRow = DirectCast(row.Clone(), DataGridViewRow)
                For i As Integer = 0 To row.Cells.Count - 1
                    newRow.Cells(i).Value = row.Cells(i).Value
                Next
                DataGridView2.Rows.Add(newRow)
            Next
        End If
        DataGridView2.Columns(0).Width = 291
        DataGridView2.Columns(1).Width = 50
        DataGridView2.Columns(2).Width = 74
    End Sub

    Public Function GetDataGridView() As DataGridView
        Return DataGridView2
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainMenu.DataGridView1.Rows.Clear()
        frmMainMenu.DataGridView1.Columns.Clear()
        frmMainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Val(txtTendered.Text) - Val(lblAmount.Text) >= 0 Then
            frmReceipt.Show()
            Me.Hide()
        Else
            MsgBox("Invalid Amount", vbOKOnly + vbExclamation, "Invalid")
        End If
    End Sub

    Private Sub frmPaymentMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DuplicateDataGridView()
        UpdateTotalAmount()
        lblTotal.Text = total
        'lblAmount.Text = total
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'frmMainMenu.DataGridView1.Rows.Clear()
        If DataGridView2.CurrentCell IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = DataGridView2.CurrentCell.OwningRow
            Dim index As Integer = selectedRow.Index
            Try
                DataGridView2.Rows.Remove(selectedRow)
                frmMainMenu.DataGridView1.Rows.RemoveAt(index)
            Catch ex As System.InvalidOperationException
                MsgBox("No item selected!", vbOKOnly + vbExclamation, "No Item")
            End Try
        End If

        UpdateTotalAmount()
        lblAmount.Text = total
        lblTotal.Text = total
    End Sub

    Private Sub btnCancelAll_Click(sender As Object, e As EventArgs) Handles btnCancelAll.Click
        DataGridView2.Rows.Clear()
        UpdateTotalAmount()
        lblTotal.Text = total
        'lblAmount.Text = total
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTendered.Clear()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtTendered.Text = Val(txtTendered.Text) + 1
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtTendered.Text = Val(txtTendered.Text) + 5
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        txtTendered.Text = Val(txtTendered.Text) + 10
    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        txtTendered.Text = Val(txtTendered.Text) + 20
    End Sub

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        txtTendered.Text = Val(txtTendered.Text) + 50
    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        txtTendered.Text = Val(txtTendered.Text) + 100
    End Sub

    Private Sub btn200_Click(sender As Object, e As EventArgs) Handles btn200.Click
        txtTendered.Text = Val(txtTendered.Text) + 200
    End Sub

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        txtTendered.Text = Val(txtTendered.Text) + 500
    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        txtTendered.Text = Val(txtTendered.Text) + 1000
    End Sub

    Private Sub btnBaack_Click(sender As Object, e As EventArgs) Handles btnBaack.Click
        pnlLeft.Enabled = True
        pnlRight.Enabled = True
        pnlCalcu.Enabled = False

        lblAmount.Text = "00.00"
    End Sub

    Private Sub txtTendered_TextChanged(sender As Object, e As EventArgs) Handles txtTendered.TextChanged
        change = Val(txtTendered.Text) - Val(lblAmount.Text)

        If change >= 0 Then
            lblChange.Text = change
        ElseIf txtTendered.Text = "" Then
            lblChange.Text = "00.00"
        Else
            lblChange.Text = "00.00"
        End If
    End Sub

    Private Sub frmPaymentMenu_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated


        DataGridView2.Rows.Clear()
        DuplicateDataGridView()
        UpdateTotalAmount()
        lblTotal.Text = total
        paymentUpdate = False

    End Sub

    Private Sub btnDineIn_Click(sender As Object, e As EventArgs) Handles btnDineIn.Click
        btnTakeOut.BackColor = System.Drawing.Color.FromArgb(254, 245, 230)
        btnDineIn.BackColor = System.Drawing.Color.White

        serviceType = "Dine In"
    End Sub

    Private Sub btnTakeOut_Click(sender As Object, e As EventArgs) Handles btnTakeOut.Click
        btnTakeOut.BackColor = System.Drawing.Color.White
        btnDineIn.BackColor = System.Drawing.Color.FromArgb(254, 245, 230)

        serviceType = "Take Out"
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim amt As Integer = Val(lblTotal.Text)

        If amt <= 0 Then
            frmMainMenu.DataGridView1.Rows.Clear()
            MsgBox("No item/s selected", vbOKOnly + vbExclamation, "No Item/s")
        Else
            If serviceType IsNot "" Then
                lblAmount.Text = lblTotal.Text
                pnlCalcu.Enabled = True

                pnlRight.Enabled = False
                pnlLeft.Enabled = False

            Else
                MsgBox("Please select a Service", vbOKOnly + vbExclamation, "Service")
            End If
        End If

    End Sub
End Class