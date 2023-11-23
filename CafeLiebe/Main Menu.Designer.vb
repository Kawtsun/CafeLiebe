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
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTap = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.picStartTop = New System.Windows.Forms.PictureBox()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnCancelAll = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.picItem = New System.Windows.Forms.PictureBox()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.pnlList = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSorbet = New System.Windows.Forms.Button()
        Me.btnCake = New System.Windows.Forms.Button()
        Me.btnCoffee = New System.Windows.Forms.Button()
        Me.pnlOrder = New System.Windows.Forms.Panel()
        Me.pnlTop.SuspendLayout()
        CType(Me.picStartTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLeft.SuspendLayout()
        CType(Me.picItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlList.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTap)
        Me.pnlTop.Controls.Add(Me.btnBack)
        Me.pnlTop.Controls.Add(Me.picStartTop)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(934, 40)
        Me.pnlTop.TabIndex = 1
        '
        'lblTap
        '
        Me.lblTap.AutoSize = True
        Me.lblTap.BackColor = System.Drawing.Color.Transparent
        Me.lblTap.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblTap.Location = New System.Drawing.Point(60, 12)
        Me.lblTap.Name = "lblTap"
        Me.lblTap.Size = New System.Drawing.Size(156, 17)
        Me.lblTap.TabIndex = 3
        Me.lblTap.Text = "Please place your order..."
        '
        'btnBack
        '
        Me.btnBack.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 2
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(859, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 40)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'picStartTop
        '
        Me.picStartTop.Image = Global.CafeLiebe.My.Resources.Resources.order
        Me.picStartTop.Location = New System.Drawing.Point(0, 3)
        Me.picStartTop.Name = "picStartTop"
        Me.picStartTop.Size = New System.Drawing.Size(54, 34)
        Me.picStartTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStartTop.TabIndex = 0
        Me.picStartTop.TabStop = False
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlLeft.Controls.Add(Me.btnRemove)
        Me.pnlLeft.Controls.Add(Me.btnCancelAll)
        Me.pnlLeft.Controls.Add(Me.btnConfirm)
        Me.pnlLeft.Controls.Add(Me.picItem)
        Me.pnlLeft.Controls.Add(Me.lblItems)
        Me.pnlLeft.Controls.Add(Me.pnlList)
        Me.pnlLeft.Controls.Add(Me.btnSorbet)
        Me.pnlLeft.Controls.Add(Me.btnCake)
        Me.pnlLeft.Controls.Add(Me.btnCoffee)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 40)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(287, 521)
        Me.pnlLeft.TabIndex = 2
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRemove.Location = New System.Drawing.Point(19, 488)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(132, 27)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "Remove an Item..."
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnCancelAll
        '
        Me.btnCancelAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnCancelAll.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancelAll.FlatAppearance.BorderSize = 0
        Me.btnCancelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelAll.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnCancelAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCancelAll.Location = New System.Drawing.Point(19, 442)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.Size = New System.Drawing.Size(96, 43)
        Me.btnCancelAll.TabIndex = 6
        Me.btnCancelAll.Text = "Cancel All"
        Me.btnCancelAll.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnConfirm.Location = New System.Drawing.Point(173, 442)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(96, 43)
        Me.btnConfirm.TabIndex = 5
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'picItem
        '
        Me.picItem.Image = Global.CafeLiebe.My.Resources.Resources.item
        Me.picItem.Location = New System.Drawing.Point(116, 448)
        Me.picItem.Name = "picItem"
        Me.picItem.Size = New System.Drawing.Size(54, 34)
        Me.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picItem.TabIndex = 4
        Me.picItem.TabStop = False
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.BackColor = System.Drawing.Color.Transparent
        Me.lblItems.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblItems.Location = New System.Drawing.Point(18, 137)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(244, 17)
        Me.lblItems.TabIndex = 4
        Me.lblItems.Text = "You have selected the following items..."
        '
        'pnlList
        '
        Me.pnlList.BackColor = System.Drawing.Color.White
        Me.pnlList.Controls.Add(Me.DataGridView1)
        Me.pnlList.Location = New System.Drawing.Point(19, 158)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Size = New System.Drawing.Size(250, 278)
        Me.pnlList.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.QTY, Me.Price})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(250, 278)
        Me.DataGridView1.TabIndex = 4
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 120
        '
        'QTY
        '
        Me.QTY.HeaderText = "QTY"
        Me.QTY.Name = "QTY"
        Me.QTY.ReadOnly = True
        Me.QTY.Width = 30
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 60
        '
        'btnSorbet
        '
        Me.btnSorbet.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnSorbet.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSorbet.FlatAppearance.BorderSize = 0
        Me.btnSorbet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSorbet.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnSorbet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSorbet.Location = New System.Drawing.Point(0, 78)
        Me.btnSorbet.Name = "btnSorbet"
        Me.btnSorbet.Size = New System.Drawing.Size(287, 40)
        Me.btnSorbet.TabIndex = 2
        Me.btnSorbet.Text = "Sorbet"
        Me.btnSorbet.UseVisualStyleBackColor = False
        '
        'btnCake
        '
        Me.btnCake.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnCake.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCake.FlatAppearance.BorderSize = 0
        Me.btnCake.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCake.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnCake.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCake.Location = New System.Drawing.Point(0, 39)
        Me.btnCake.Name = "btnCake"
        Me.btnCake.Size = New System.Drawing.Size(287, 40)
        Me.btnCake.TabIndex = 1
        Me.btnCake.Text = "Cake"
        Me.btnCake.UseVisualStyleBackColor = False
        '
        'btnCoffee
        '
        Me.btnCoffee.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnCoffee.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCoffee.FlatAppearance.BorderSize = 0
        Me.btnCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCoffee.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnCoffee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCoffee.Location = New System.Drawing.Point(0, 0)
        Me.btnCoffee.Name = "btnCoffee"
        Me.btnCoffee.Size = New System.Drawing.Size(287, 40)
        Me.btnCoffee.TabIndex = 0
        Me.btnCoffee.Text = "Coffee"
        Me.btnCoffee.UseVisualStyleBackColor = False
        '
        'pnlOrder
        '
        Me.pnlOrder.BackgroundImage = Global.CafeLiebe.My.Resources.Resources.bg
        Me.pnlOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOrder.Location = New System.Drawing.Point(287, 40)
        Me.pnlOrder.Name = "pnlOrder"
        Me.pnlOrder.Size = New System.Drawing.Size(647, 521)
        Me.pnlOrder.TabIndex = 3
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 561)
        Me.Controls.Add(Me.pnlOrder)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.picStartTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        CType(Me.picItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlList.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
