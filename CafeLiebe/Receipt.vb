Public Class frmReceipt
    Private Sub btnDineIn_Click(sender As Object, e As EventArgs) Handles btnDineIn.Click
        End
    End Sub

    Public Sub DuplicateDataGridView()
        ' Get access to Form1 instance
        Dim form2Instance As frmPaymentMenu = CType(Application.OpenForms("frmPaymentMenu"), frmPaymentMenu)

        ' Check if Form1 instance exists
        If form2Instance IsNot Nothing Then
            ' Get the DataGridView from Form1
            Dim dataGridViewFromForm2 As DataGridView = form2Instance.GetDataGridView()

            ' Duplicate the columns
            For Each column As DataGridViewColumn In dataGridViewFromForm2.Columns
                DataGridView3.Columns.Add(DirectCast(column.Clone(), DataGridViewColumn))
            Next

            ' Duplicate the rows and their data
            For Each row As DataGridViewRow In dataGridViewFromForm2.Rows
                Dim newRow As DataGridViewRow = DirectCast(row.Clone(), DataGridViewRow)
                For i As Integer = 0 To row.Cells.Count - 1
                    newRow.Cells(i).Value = row.Cells(i).Value
                Next
                DataGridView3.Rows.Add(newRow)
            Next
        End If
        DataGridView3.Columns(0).Width = 176
        DataGridView3.Columns(1).Width = 30
        DataGridView3.Columns(2).Width = 42
    End Sub

    Private Sub frmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView3.Rows.Clear()
        DuplicateDataGridView()

        lblAmount.Text = frmPaymentMenu.lblAmount.Text
        lblChange.Text = frmPaymentMenu.lblChange.Text
        lblTendered.Text = frmPaymentMenu.txtTendered.Text
        lblFoodservice.Text = frmPaymentMenu.serviceType
    End Sub
End Class