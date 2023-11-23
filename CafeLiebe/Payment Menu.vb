Public Class frmPaymentMenu
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
        DataGridView2.Columns(0).Width = 200
        DataGridView2.Columns(1).Width = 50
        DataGridView2.Columns(2).Width = 150
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmHomeWindow.Show()
        Me.Hide()
    End Sub

    Private Sub frmPaymentMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DuplicateDataGridView()
    End Sub
End Class