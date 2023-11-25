Public Class frmMainMenu
    Public Property totalofAll As Integer
    Dim index As Integer

    Private Sub DuplicateDataGridView()
        ' Get access to Form1 instance
        Dim form2Instance As frmPaymentMenu = CType(Application.OpenForms("frmPaymentMenu"), frmPaymentMenu)

        ' Check if Form1 instance exists
        If form2Instance IsNot Nothing Then
            ' Get the DataGridView from Form1
            Dim dataGridViewFromForm2 As DataGridView = form2Instance.GetDataGridView()

            ' Duplicate the columns
            For Each column As DataGridViewColumn In dataGridViewFromForm2.Columns
                DataGridView1.Columns.Add(DirectCast(column.Clone(), DataGridViewColumn))
            Next

            ' Duplicate the rows and their data
            For Each row As DataGridViewRow In dataGridViewFromForm2.Rows
                Dim newRow As DataGridViewRow = DirectCast(row.Clone(), DataGridViewRow)
                For i As Integer = 0 To row.Cells.Count - 1
                    newRow.Cells(i).Value = row.Cells(i).Value
                Next
                DataGridView1.Rows.Add(newRow)
            Next
        End If
        DataGridView1.Columns(0).Width = 176
        DataGridView1.Columns(1).Width = 30
        DataGridView1.Columns(2).Width = 42
    End Sub

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
        totalofAll = 0
        frmPaymentMenu.DataGridView2.Rows.Clear()
        frmPaymentMenu.DataGridView2.Columns.Clear()
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim cellValue As Object = row.Cells(2).Value
                If cellValue IsNot Nothing AndAlso Not IsDBNull(cellValue) Then
                    Dim value As Integer = Int32.Parse(Val(cellValue))
                    totalofAll += value
                End If
            End If
        Next
        frmPaymentMenu.Show()
        Me.Hide()
    End Sub
    Public Sub AddDataToGrid(data1 As String, data2 As String, data3 As String)
        DataGridView1.Rows.Add(data1, data2, data3)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If DataGridView1.CurrentCell IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = DataGridView1.CurrentCell.OwningRow
            Try
                DataGridView1.Rows.Remove(selectedRow)
            Catch ex As System.InvalidOperationException
                MsgBox("No item selected!", vbOKOnly + vbExclamation, "No Item")
            End Try
        End If
    End Sub

    Private Sub btnCancelAll_Click(sender As Object, e As EventArgs) Handles btnCancelAll.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub frmMainMenu_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        DuplicateDataGridView()
    End Sub
End Class