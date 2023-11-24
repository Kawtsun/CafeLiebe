Public Class frmPaymentMenu
    Public Property recieverTotal As Integer
    Dim index, change As Integer

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
        DataGridView2.Columns(0).Width = 250
        DataGridView2.Columns(1).Width = 50
        DataGridView2.Columns(2).Width = 74
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
        recieverTotal = frmMainMenu.totalofAll
        lblAmount.Text = recieverTotal
        lblTotal.Text = recieverTotal
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If DataGridView2.CurrentCell IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = DataGridView2.CurrentCell.OwningRow
            Try
                DataGridView2.Rows.Remove(selectedRow)
            Catch ex As System.InvalidOperationException
                MsgBox("No item selected!", vbOKOnly + vbExclamation, "No Item")
            End Try
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

    Private Sub btnBaack_Click(sender As Object, e As EventArgs) Handles btnBaack.Click
        frmMainMenu.Show()
        Me.Hide()
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
        recieverTotal = frmMainMenu.totalofAll
        lblAmount.Text = recieverTotal
        lblTotal.Text = recieverTotal
    End Sub
End Class