<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pnlTop = New Panel()
        lblTap = New Label()
        btnBack = New Button()
        picStartTop = New PictureBox()
        pnlLeft = New Panel()
        btnRemove = New Button()
        btnCancelAll = New Button()
        btnConfirm = New Button()
        picItem = New PictureBox()
        lblItems = New Label()
        pnlList = New Panel()
        DataGridView1 = New DataGridView()
        Item = New DataGridViewTextBoxColumn()
        QTY = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        btnSorbet = New Button()
        btnCake = New Button()
        btnCoffee = New Button()
        pnlOrder = New Panel()
        pnlTop.SuspendLayout()
        CType(picStartTop, ComponentModel.ISupportInitialize).BeginInit()
        pnlLeft.SuspendLayout()
        CType(picItem, ComponentModel.ISupportInitialize).BeginInit()
        pnlList.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlTop
        ' 
        pnlTop.BackColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        pnlTop.Controls.Add(lblTap)
        pnlTop.Controls.Add(btnBack)
        pnlTop.Controls.Add(picStartTop)
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(0, 0)
        pnlTop.Name = "pnlTop"
        pnlTop.Size = New Size(934, 40)
        pnlTop.TabIndex = 1
        ' 
        ' lblTap
        ' 
        lblTap.AutoSize = True
        lblTap.BackColor = Color.Transparent
        lblTap.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblTap.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblTap.Location = New Point(60, 12)
        lblTap.Name = "lblTap"
        lblTap.Size = New Size(156, 17)
        lblTap.TabIndex = 3
        lblTap.Text = "Please place your order..."
        ' 
        ' btnBack
        ' 
        btnBack.Dock = DockStyle.Right
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btnBack.FlatAppearance.BorderSize = 2
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        btnBack.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btnBack.Location = New Point(859, 0)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 40)
        btnBack.TabIndex = 1
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' picStartTop
        ' 
        picStartTop.Image = My.Resources.Resources.order
        picStartTop.Location = New Point(0, 3)
        picStartTop.Name = "picStartTop"
        picStartTop.Size = New Size(54, 34)
        picStartTop.SizeMode = PictureBoxSizeMode.Zoom
        picStartTop.TabIndex = 0
        picStartTop.TabStop = False
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        pnlLeft.Controls.Add(btnRemove)
        pnlLeft.Controls.Add(btnCancelAll)
        pnlLeft.Controls.Add(btnConfirm)
        pnlLeft.Controls.Add(picItem)
        pnlLeft.Controls.Add(lblItems)
        pnlLeft.Controls.Add(pnlList)
        pnlLeft.Controls.Add(btnSorbet)
        pnlLeft.Controls.Add(btnCake)
        pnlLeft.Controls.Add(btnCoffee)
        pnlLeft.Dock = DockStyle.Left
        pnlLeft.Location = New Point(0, 40)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(287, 521)
        pnlLeft.TabIndex = 2
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        btnRemove.FlatAppearance.BorderColor = Color.White
        btnRemove.FlatAppearance.BorderSize = 0
        btnRemove.FlatStyle = FlatStyle.Flat
        btnRemove.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnRemove.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btnRemove.Location = New Point(19, 488)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(132, 27)
        btnRemove.TabIndex = 7
        btnRemove.Text = "Remove an Item..."
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' btnCancelAll
        ' 
        btnCancelAll.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btnCancelAll.FlatAppearance.BorderColor = Color.White
        btnCancelAll.FlatAppearance.BorderSize = 0
        btnCancelAll.FlatStyle = FlatStyle.Flat
        btnCancelAll.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnCancelAll.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btnCancelAll.Location = New Point(19, 442)
        btnCancelAll.Name = "btnCancelAll"
        btnCancelAll.Size = New Size(96, 43)
        btnCancelAll.TabIndex = 6
        btnCancelAll.Text = "Cancel All"
        btnCancelAll.UseVisualStyleBackColor = False
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btnConfirm.FlatAppearance.BorderColor = Color.White
        btnConfirm.FlatAppearance.BorderSize = 0
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnConfirm.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btnConfirm.Location = New Point(173, 442)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(96, 43)
        btnConfirm.TabIndex = 5
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' picItem
        ' 
        picItem.Image = My.Resources.Resources.item
        picItem.Location = New Point(116, 448)
        picItem.Name = "picItem"
        picItem.Size = New Size(54, 34)
        picItem.SizeMode = PictureBoxSizeMode.Zoom
        picItem.TabIndex = 4
        picItem.TabStop = False
        ' 
        ' lblItems
        ' 
        lblItems.AutoSize = True
        lblItems.BackColor = Color.Transparent
        lblItems.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblItems.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblItems.Location = New Point(18, 137)
        lblItems.Name = "lblItems"
        lblItems.Size = New Size(244, 17)
        lblItems.TabIndex = 4
        lblItems.Text = "You have selected the following items..."
        ' 
        ' pnlList
        ' 
        pnlList.BackColor = Color.White
        pnlList.Controls.Add(DataGridView1)
        pnlList.Location = New Point(19, 158)
        pnlList.Name = "pnlList"
        pnlList.Size = New Size(250, 278)
        pnlList.TabIndex = 4
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Item, QTY, Price})
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(250, 278)
        DataGridView1.TabIndex = 4
        ' 
        ' Item
        ' 
        Item.HeaderText = "Item"
        Item.Name = "Item"
        Item.ReadOnly = True
        Item.Width = 120
        ' 
        ' QTY
        ' 
        QTY.HeaderText = "QTY"
        QTY.Name = "QTY"
        QTY.ReadOnly = True
        QTY.Width = 30
        ' 
        ' Price
        ' 
        Price.HeaderText = "Price"
        Price.Name = "Price"
        Price.ReadOnly = True
        Price.Width = 60
        ' 
        ' btnSorbet
        ' 
        btnSorbet.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btnSorbet.FlatAppearance.BorderColor = Color.White
        btnSorbet.FlatAppearance.BorderSize = 0
        btnSorbet.FlatStyle = FlatStyle.Flat
        btnSorbet.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnSorbet.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btnSorbet.Location = New Point(0, 78)
        btnSorbet.Name = "btnSorbet"
        btnSorbet.Size = New Size(287, 40)
        btnSorbet.TabIndex = 2
        btnSorbet.Text = "Sorbet"
        btnSorbet.UseVisualStyleBackColor = False
        ' 
        ' btnCake
        ' 
        btnCake.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btnCake.FlatAppearance.BorderColor = Color.White
        btnCake.FlatAppearance.BorderSize = 0
        btnCake.FlatStyle = FlatStyle.Flat
        btnCake.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnCake.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btnCake.Location = New Point(0, 39)
        btnCake.Name = "btnCake"
        btnCake.Size = New Size(287, 40)
        btnCake.TabIndex = 1
        btnCake.Text = "Cake"
        btnCake.UseVisualStyleBackColor = False
        ' 
        ' btnCoffee
        ' 
        btnCoffee.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btnCoffee.FlatAppearance.BorderColor = Color.White
        btnCoffee.FlatAppearance.BorderSize = 0
        btnCoffee.FlatStyle = FlatStyle.Flat
        btnCoffee.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnCoffee.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btnCoffee.Location = New Point(0, 0)
        btnCoffee.Name = "btnCoffee"
        btnCoffee.Size = New Size(287, 40)
        btnCoffee.TabIndex = 0
        btnCoffee.Text = "Coffee"
        btnCoffee.UseVisualStyleBackColor = False
        ' 
        ' pnlOrder
        ' 
        pnlOrder.BackgroundImage = My.Resources.Resources.bg
        pnlOrder.BackgroundImageLayout = ImageLayout.Center
        pnlOrder.Dock = DockStyle.Fill
        pnlOrder.Location = New Point(287, 40)
        pnlOrder.Name = "pnlOrder"
        pnlOrder.Size = New Size(647, 521)
        pnlOrder.TabIndex = 3
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(934, 561)
        Controls.Add(pnlOrder)
        Controls.Add(pnlLeft)
        Controls.Add(pnlTop)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmMainMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        pnlTop.ResumeLayout(False)
        pnlTop.PerformLayout()
        CType(picStartTop, ComponentModel.ISupportInitialize).EndInit()
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
        CType(picItem, ComponentModel.ISupportInitialize).EndInit()
        pnlList.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents picStartTop As PictureBox
    Friend WithEvents lblTap As Label
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents btnSorbet As Button
    Friend WithEvents btnCake As Button
    Friend WithEvents btnCoffee As Button
    Friend WithEvents pnlList As Panel
    Friend WithEvents lblItems As Label
    Friend WithEvents btnCancelAll As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents picItem As PictureBox
    Friend WithEvents pnlOrder As Panel
    Friend WithEvents btnRemove As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents QTY As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
End Class
