Public Class frmPaymentMenu
    Dim index As Integer
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

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If DataGridView2.SelectedRows.Count > 0 Then
            For i As Integer = DataGridView2.SelectedRows.Count - 1 To 0 Step -1
                DataGridView2.Rows.RemoveAt(DataGridView2.SelectedRows(i).Index)
            Next
        Else
            MsgBox("No item selected!")
        End If
    End Sub

    Private Sub btnCancelAll_Click(sender As Object, e As EventArgs) Handles btnCancelAll.Click
        DataGridView2.Rows.Clear()
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

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub
End Class