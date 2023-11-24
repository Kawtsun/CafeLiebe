<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentMenu
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
        pnlBottom = New Panel()
        lblTotal = New Label()
        lblEwan1 = New Label()
        btnRemove = New Button()
        btnConfirm = New Button()
        picItem = New PictureBox()
        btnCancelAll = New Button()
        lblItems = New Label()
        pnlList = New Panel()
        DataGridView2 = New DataGridView()
        pnlCalcu = New Panel()
        btn1000 = New Button()
        btn500 = New Button()
        btn200 = New Button()
        btnPrint = New Button()
        btn100 = New Button()
        btn50 = New Button()
        btn20 = New Button()
        btnBaack = New Button()
        btn10 = New Button()
        btn5 = New Button()
        btn1 = New Button()
        btnClear = New Button()
        pnlMiddle = New Panel()
        txtTendered = New TextBox()
        lblChange = New Label()
        lblOOHH = New Label()
        lblEEHH = New Label()
        lblAmount = New Label()
        lblAAHH = New Label()
        picCalcu = New PictureBox()
        pnlRight = New Panel()
        lblTake = New Label()
        lblDine = New Label()
        lblMessage4 = New Label()
        lblMessage2 = New Label()
        btnTakeOut = New Button()
        btnDineIn = New Button()
        lblMessage1 = New Label()
        lblMessage3 = New Label()
        lblEwan2 = New Label()
        lblDineTake = New Label()
        pnlTop.SuspendLayout()
        CType(picStartTop, ComponentModel.ISupportInitialize).BeginInit()
        pnlLeft.SuspendLayout()
        pnlBottom.SuspendLayout()
        CType(picItem, ComponentModel.ISupportInitialize).BeginInit()
        pnlList.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        pnlCalcu.SuspendLayout()
        pnlMiddle.SuspendLayout()
        CType(picCalcu, ComponentModel.ISupportInitialize).BeginInit()
        pnlRight.SuspendLayout()
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
        pnlTop.TabIndex = 2
        ' 
        ' lblTap
        ' 
        lblTap.AutoSize = True
        lblTap.BackColor = Color.Transparent
        lblTap.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblTap.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblTap.Location = New Point(60, 12)
        lblTap.Name = "lblTap"
        lblTap.Size = New Size(170, 17)
        lblTap.TabIndex = 3
        lblTap.Text = "Honesty is the best policy..."
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
        picStartTop.Image = My.Resources.Resources.last
        picStartTop.Location = New Point(0, 3)
        picStartTop.Name = "picStartTop"
        picStartTop.Size = New Size(54, 34)
        picStartTop.SizeMode = PictureBoxSizeMode.Zoom
        picStartTop.TabIndex = 0
        picStartTop.TabStop = False
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        pnlLeft.Controls.Add(pnlBottom)
        pnlLeft.Controls.Add(lblItems)
        pnlLeft.Controls.Add(pnlList)
        pnlLeft.Dock = DockStyle.Left
        pnlLeft.Location = New Point(0, 40)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(455, 521)
        pnlLeft.TabIndex = 3
        ' 
        ' pnlBottom
        ' 
        pnlBottom.BackColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        pnlBottom.Controls.Add(lblTotal)
        pnlBottom.Controls.Add(lblEwan1)
        pnlBottom.Controls.Add(btnRemove)
        pnlBottom.Controls.Add(btnConfirm)
        pnlBottom.Controls.Add(picItem)
        pnlBottom.Controls.Add(btnCancelAll)
        pnlBottom.Location = New Point(0, 434)
        pnlBottom.Name = "pnlBottom"
        pnlBottom.Size = New Size(455, 87)
        pnlBottom.TabIndex = 4
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.Transparent
        lblTotal.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblTotal.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblTotal.Location = New Point(72, 34)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(66, 25)
        lblTotal.TabIndex = 9
        lblTotal.Text = "00.00"
        ' 
        ' lblEwan1
        ' 
        lblEwan1.AutoSize = True
        lblEwan1.BackColor = Color.Transparent
        lblEwan1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblEwan1.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblEwan1.Location = New Point(19, 17)
        lblEwan1.Name = "lblEwan1"
        lblEwan1.Size = New Size(90, 17)
        lblEwan1.TabIndex = 8
        lblEwan1.Text = "Total Amount"
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        btnRemove.FlatAppearance.BorderColor = Color.White
        btnRemove.FlatAppearance.BorderSize = 0
        btnRemove.FlatStyle = FlatStyle.Flat
        btnRemove.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnRemove.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btnRemove.Location = New Point(304, 55)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(132, 27)
        btnRemove.TabIndex = 7
        btnRemove.Text = "Remove an Item..."
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btnConfirm.FlatAppearance.BorderColor = Color.White
        btnConfirm.FlatAppearance.BorderSize = 0
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnConfirm.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btnConfirm.Location = New Point(340, 11)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(96, 43)
        btnConfirm.TabIndex = 5
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' picItem
        ' 
        picItem.BackColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        picItem.Image = My.Resources.Resources.item
        picItem.Location = New Point(169, 17)
        picItem.Name = "picItem"
        picItem.Size = New Size(54, 34)
        picItem.SizeMode = PictureBoxSizeMode.Zoom
        picItem.TabIndex = 4
        picItem.TabStop = False
        ' 
        ' btnCancelAll
        ' 
        btnCancelAll.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btnCancelAll.FlatAppearance.BorderColor = Color.White
        btnCancelAll.FlatAppearance.BorderSize = 0
        btnCancelAll.FlatStyle = FlatStyle.Flat
        btnCancelAll.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnCancelAll.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btnCancelAll.Location = New Point(229, 11)
        btnCancelAll.Name = "btnCancelAll"
        btnCancelAll.Size = New Size(96, 43)
        btnCancelAll.TabIndex = 6
        btnCancelAll.Text = "Cancel All"
        btnCancelAll.UseVisualStyleBackColor = False
        ' 
        ' lblItems
        ' 
        lblItems.AutoSize = True
        lblItems.BackColor = Color.Transparent
        lblItems.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblItems.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblItems.Location = New Point(18, 13)
        lblItems.Name = "lblItems"
        lblItems.Size = New Size(244, 17)
        lblItems.TabIndex = 4
        lblItems.Text = "You have selected the following items..."
        ' 
        ' pnlList
        ' 
        pnlList.BackColor = Color.White
        pnlList.Controls.Add(DataGridView2)
        pnlList.Location = New Point(19, 33)
        pnlList.Name = "pnlList"
        pnlList.Size = New Size(417, 403)
        pnlList.TabIndex = 4
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        DataGridView2.BorderStyle = BorderStyle.Fixed3D
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Dock = DockStyle.Fill
        DataGridView2.Location = New Point(0, 0)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(417, 403)
        DataGridView2.TabIndex = 0
        ' 
        ' pnlCalcu
        ' 
        pnlCalcu.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        pnlCalcu.Controls.Add(btn1000)
        pnlCalcu.Controls.Add(btn500)
        pnlCalcu.Controls.Add(btn200)
        pnlCalcu.Controls.Add(btnPrint)
        pnlCalcu.Controls.Add(btn100)
        pnlCalcu.Controls.Add(btn50)
        pnlCalcu.Controls.Add(btn20)
        pnlCalcu.Controls.Add(btnBaack)
        pnlCalcu.Controls.Add(btn10)
        pnlCalcu.Controls.Add(btn5)
        pnlCalcu.Controls.Add(btn1)
        pnlCalcu.Controls.Add(btnClear)
        pnlCalcu.Controls.Add(pnlMiddle)
        pnlCalcu.Dock = DockStyle.Bottom
        pnlCalcu.Location = New Point(455, 231)
        pnlCalcu.Name = "pnlCalcu"
        pnlCalcu.Size = New Size(479, 330)
        pnlCalcu.TabIndex = 10
        ' 
        ' btn1000
        ' 
        btn1000.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btn1000.FlatAppearance.BorderColor = Color.White
        btn1000.FlatAppearance.BorderSize = 0
        btn1000.FlatStyle = FlatStyle.Flat
        btn1000.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btn1000.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btn1000.Location = New Point(359, 248)
        btn1000.Name = "btn1000"
        btn1000.Size = New Size(120, 82)
        btn1000.TabIndex = 21
        btn1000.Text = "1000"
        btn1000.UseVisualStyleBackColor = False
        ' 
        ' btn500
        ' 
        btn500.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btn500.FlatAppearance.BorderColor = Color.White
        btn500.FlatAppearance.BorderSize = 0
        btn500.FlatStyle = FlatStyle.Flat
        btn500.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btn500.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btn500.Location = New Point(242, 248)
        btn500.Name = "btn500"
        btn500.Size = New Size(122, 82)
        btn500.TabIndex = 20
        btn500.Text = "500"
        btn500.UseVisualStyleBackColor = False
        ' 
        ' btn200
        ' 
        btn200.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btn200.FlatAppearance.BorderColor = Color.White
        btn200.FlatAppearance.BorderSize = 0
        btn200.FlatStyle = FlatStyle.Flat
        btn200.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btn200.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btn200.Location = New Point(121, 248)
        btn200.Name = "btn200"
        btn200.Size = New Size(122, 82)
        btn200.TabIndex = 19
        btn200.Text = "200"
        btn200.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.FromArgb(CByte(107), CByte(112), CByte(80))
        btnPrint.FlatAppearance.BorderColor = Color.White
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnPrint.ForeColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        btnPrint.Location = New Point(0, 248)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(122, 82)
        btnPrint.TabIndex = 18
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btn100
        ' 
        btn100.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btn100.FlatAppearance.BorderColor = Color.White
        btn100.FlatAppearance.BorderSize = 0
        btn100.FlatStyle = FlatStyle.Flat
        btn100.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btn100.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btn100.Location = New Point(359, 168)
        btn100.Name = "btn100"
        btn100.Size = New Size(120, 82)
        btn100.TabIndex = 17
        btn100.Text = "100"
        btn100.UseVisualStyleBackColor = False
        ' 
        ' btn50
        ' 
        btn50.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btn50.FlatAppearance.BorderColor = Color.White
        btn50.FlatAppearance.BorderSize = 0
        btn50.FlatStyle = FlatStyle.Flat
        btn50.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btn50.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btn50.Location = New Point(242, 168)
        btn50.Name = "btn50"
        btn50.Size = New Size(122, 82)
        btn50.TabIndex = 16
        btn50.Text = "50"
        btn50.UseVisualStyleBackColor = False
        ' 
        ' btn20
        ' 
        btn20.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btn20.FlatAppearance.BorderColor = Color.White
        btn20.FlatAppearance.BorderSize = 0
        btn20.FlatStyle = FlatStyle.Flat
        btn20.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btn20.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btn20.Location = New Point(121, 168)
        btn20.Name = "btn20"
        btn20.Size = New Size(122, 82)
        btn20.TabIndex = 15
        btn20.Text = "20"
        btn20.UseVisualStyleBackColor = False
        ' 
        ' btnBaack
        ' 
        btnBaack.BackColor = Color.FromArgb(CByte(107), CByte(112), CByte(80))
        btnBaack.FlatAppearance.BorderColor = Color.White
        btnBaack.FlatAppearance.BorderSize = 0
        btnBaack.FlatStyle = FlatStyle.Flat
        btnBaack.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnBaack.ForeColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        btnBaack.Location = New Point(0, 168)
        btnBaack.Name = "btnBaack"
        btnBaack.Size = New Size(122, 82)
        btnBaack.TabIndex = 14
        btnBaack.Text = "Back"
        btnBaack.UseVisualStyleBackColor = False
        ' 
        ' btn10
        ' 
        btn10.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btn10.FlatAppearance.BorderColor = Color.White
        btn10.FlatAppearance.BorderSize = 0
        btn10.FlatStyle = FlatStyle.Flat
        btn10.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btn10.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btn10.Location = New Point(359, 86)
        btn10.Name = "btn10"
        btn10.Size = New Size(120, 82)
        btn10.TabIndex = 13
        btn10.Text = "10"
        btn10.UseVisualStyleBackColor = False
        ' 
        ' btn5
        ' 
        btn5.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btn5.FlatAppearance.BorderColor = Color.White
        btn5.FlatAppearance.BorderSize = 0
        btn5.FlatStyle = FlatStyle.Flat
        btn5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btn5.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btn5.Location = New Point(242, 86)
        btn5.Name = "btn5"
        btn5.Size = New Size(122, 82)
        btn5.TabIndex = 12
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = False
        ' 
        ' btn1
        ' 
        btn1.BackColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        btn1.FlatAppearance.BorderColor = Color.White
        btn1.FlatAppearance.BorderSize = 0
        btn1.FlatStyle = FlatStyle.Flat
        btn1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btn1.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btn1.Location = New Point(121, 86)
        btn1.Name = "btn1"
        btn1.Size = New Size(122, 82)
        btn1.TabIndex = 11
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(107), CByte(112), CByte(80))
        btnClear.FlatAppearance.BorderColor = Color.White
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnClear.ForeColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        btnClear.Location = New Point(0, 86)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(122, 82)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' pnlMiddle
        ' 
        pnlMiddle.BackColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        pnlMiddle.Controls.Add(txtTendered)
        pnlMiddle.Controls.Add(lblChange)
        pnlMiddle.Controls.Add(lblOOHH)
        pnlMiddle.Controls.Add(lblEEHH)
        pnlMiddle.Controls.Add(lblAmount)
        pnlMiddle.Controls.Add(lblAAHH)
        pnlMiddle.Controls.Add(picCalcu)
        pnlMiddle.Location = New Point(0, 0)
        pnlMiddle.Name = "pnlMiddle"
        pnlMiddle.Size = New Size(479, 87)
        pnlMiddle.TabIndex = 5
        ' 
        ' txtTendered
        ' 
        txtTendered.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        txtTendered.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        txtTendered.Location = New Point(151, 37)
        txtTendered.Name = "txtTendered"
        txtTendered.ReadOnly = True
        txtTendered.Size = New Size(123, 33)
        txtTendered.TabIndex = 13
        ' 
        ' lblChange
        ' 
        lblChange.AutoSize = True
        lblChange.BackColor = Color.Transparent
        lblChange.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblChange.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblChange.Location = New Point(315, 37)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(66, 25)
        lblChange.TabIndex = 12
        lblChange.Text = "00.00"
        ' 
        ' lblOOHH
        ' 
        lblOOHH.AutoSize = True
        lblOOHH.BackColor = Color.Transparent
        lblOOHH.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblOOHH.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblOOHH.Location = New Point(288, 17)
        lblOOHH.Name = "lblOOHH"
        lblOOHH.Size = New Size(53, 17)
        lblOOHH.TabIndex = 11
        lblOOHH.Text = "Change"
        ' 
        ' lblEEHH
        ' 
        lblEEHH.AutoSize = True
        lblEEHH.BackColor = Color.Transparent
        lblEEHH.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblEEHH.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblEEHH.Location = New Point(133, 17)
        lblEEHH.Name = "lblEEHH"
        lblEEHH.Size = New Size(115, 17)
        lblEEHH.TabIndex = 10
        lblEEHH.Text = "Amount Tendered"
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.BackColor = Color.Transparent
        lblAmount.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblAmount.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblAmount.Location = New Point(46, 37)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(66, 25)
        lblAmount.TabIndex = 9
        lblAmount.Text = "00.00"
        ' 
        ' lblAAHH
        ' 
        lblAAHH.AutoSize = True
        lblAAHH.BackColor = Color.Transparent
        lblAAHH.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblAAHH.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblAAHH.Location = New Point(19, 17)
        lblAAHH.Name = "lblAAHH"
        lblAAHH.Size = New Size(90, 17)
        lblAAHH.TabIndex = 8
        lblAAHH.Text = "Total Amount"
        ' 
        ' picCalcu
        ' 
        picCalcu.BackColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        picCalcu.Image = My.Resources.Resources.start
        picCalcu.Location = New Point(404, 25)
        picCalcu.Name = "picCalcu"
        picCalcu.Size = New Size(54, 34)
        picCalcu.SizeMode = PictureBoxSizeMode.Zoom
        picCalcu.TabIndex = 4
        picCalcu.TabStop = False
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.FromArgb(CByte(107), CByte(112), CByte(80))
        pnlRight.Controls.Add(lblTake)
        pnlRight.Controls.Add(lblDine)
        pnlRight.Controls.Add(lblMessage4)
        pnlRight.Controls.Add(lblMessage2)
        pnlRight.Controls.Add(btnTakeOut)
        pnlRight.Controls.Add(btnDineIn)
        pnlRight.Controls.Add(lblMessage1)
        pnlRight.Controls.Add(lblMessage3)
        pnlRight.Controls.Add(lblEwan2)
        pnlRight.Controls.Add(lblDineTake)
        pnlRight.Dock = DockStyle.Fill
        pnlRight.Location = New Point(455, 40)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(479, 191)
        pnlRight.TabIndex = 0
        ' 
        ' lblTake
        ' 
        lblTake.AutoSize = True
        lblTake.BackColor = Color.Transparent
        lblTake.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblTake.ForeColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        lblTake.Location = New Point(51, 144)
        lblTake.Name = "lblTake"
        lblTake.Size = New Size(183, 17)
        lblTake.TabIndex = 242
        lblTake.Text = "Take care on your way back..."
        ' 
        ' lblDine
        ' 
        lblDine.AutoSize = True
        lblDine.BackColor = Color.Transparent
        lblDine.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblDine.ForeColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        lblDine.Location = New Point(51, 144)
        lblDine.Name = "lblDine"
        lblDine.Size = New Size(121, 17)
        lblDine.TabIndex = 241
        lblDine.Text = "You are dining in..."
        ' 
        ' lblMessage4
        ' 
        lblMessage4.AutoSize = True
        lblMessage4.BackColor = Color.Transparent
        lblMessage4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblMessage4.ForeColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        lblMessage4.Location = New Point(98, 90)
        lblMessage4.Name = "lblMessage4"
        lblMessage4.Size = New Size(322, 17)
        lblMessage4.TabIndex = 240
        lblMessage4.Text = "Take a seat at any open table and await your order..."
        ' 
        ' lblMessage2
        ' 
        lblMessage2.AutoSize = True
        lblMessage2.BackColor = Color.Transparent
        lblMessage2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblMessage2.ForeColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        lblMessage2.Location = New Point(98, 56)
        lblMessage2.Name = "lblMessage2"
        lblMessage2.Size = New Size(235, 17)
        lblMessage2.TabIndex = 239
        lblMessage2.Text = "you have deposited into this machine."
        ' 
        ' btnTakeOut
        ' 
        btnTakeOut.BackColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        btnTakeOut.FlatAppearance.BorderColor = Color.White
        btnTakeOut.FlatAppearance.BorderSize = 0
        btnTakeOut.FlatStyle = FlatStyle.Flat
        btnTakeOut.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnTakeOut.ForeColor = Color.FromArgb(CByte(107), CByte(112), CByte(80))
        btnTakeOut.Location = New Point(359, 129)
        btnTakeOut.Name = "btnTakeOut"
        btnTakeOut.Size = New Size(96, 43)
        btnTakeOut.TabIndex = 238
        btnTakeOut.Text = "Take Out"
        btnTakeOut.UseVisualStyleBackColor = False
        ' 
        ' btnDineIn
        ' 
        btnDineIn.BackColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        btnDineIn.FlatAppearance.BorderColor = Color.White
        btnDineIn.FlatAppearance.BorderSize = 0
        btnDineIn.FlatStyle = FlatStyle.Flat
        btnDineIn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnDineIn.ForeColor = Color.FromArgb(CByte(107), CByte(112), CByte(80))
        btnDineIn.Location = New Point(248, 129)
        btnDineIn.Name = "btnDineIn"
        btnDineIn.Size = New Size(96, 43)
        btnDineIn.TabIndex = 237
        btnDineIn.Text = "Dine In"
        btnDineIn.UseVisualStyleBackColor = False
        ' 
        ' lblMessage1
        ' 
        lblMessage1.AutoSize = True
        lblMessage1.BackColor = Color.Transparent
        lblMessage1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblMessage1.ForeColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        lblMessage1.Location = New Point(98, 39)
        lblMessage1.Name = "lblMessage1"
        lblMessage1.Size = New Size(301, 17)
        lblMessage1.TabIndex = 236
        lblMessage1.Text = "After this process, please enter the sum of money"
        ' 
        ' lblMessage3
        ' 
        lblMessage3.AutoSize = True
        lblMessage3.BackColor = Color.Transparent
        lblMessage3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblMessage3.ForeColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        lblMessage3.Location = New Point(98, 73)
        lblMessage3.Name = "lblMessage3"
        lblMessage3.Size = New Size(297, 17)
        lblMessage3.TabIndex = 235
        lblMessage3.Text = "Thank you for being patient, and understanding."
        ' 
        ' lblEwan2
        ' 
        lblEwan2.AutoSize = True
        lblEwan2.BackColor = Color.Transparent
        lblEwan2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblEwan2.ForeColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        lblEwan2.Location = New Point(27, 119)
        lblEwan2.Name = "lblEwan2"
        lblEwan2.Size = New Size(176, 25)
        lblEwan2.TabIndex = 234
        lblEwan2.Text = "Would you like to -"
        ' 
        ' lblDineTake
        ' 
        lblDineTake.AutoSize = True
        lblDineTake.BackColor = Color.Transparent
        lblDineTake.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblDineTake.ForeColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        lblDineTake.Location = New Point(27, 22)
        lblDineTake.Name = "lblDineTake"
        lblDineTake.Size = New Size(152, 17)
        lblDineTake.TabIndex = 233
        lblDineTake.Text = "Hello beloved customer!"
        ' 
        ' frmPaymentMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg
        ClientSize = New Size(934, 561)
        Controls.Add(pnlRight)
        Controls.Add(pnlCalcu)
        Controls.Add(pnlLeft)
        Controls.Add(pnlTop)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmPaymentMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        pnlTop.ResumeLayout(False)
        pnlTop.PerformLayout()
        CType(picStartTop, ComponentModel.ISupportInitialize).EndInit()
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
        pnlBottom.ResumeLayout(False)
        pnlBottom.PerformLayout()
        CType(picItem, ComponentModel.ISupportInitialize).EndInit()
        pnlList.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        pnlCalcu.ResumeLayout(False)
        pnlMiddle.ResumeLayout(False)
        pnlMiddle.PerformLayout()
        CType(picCalcu, ComponentModel.ISupportInitialize).EndInit()
        pnlRight.ResumeLayout(False)
        pnlRight.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTap As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents picStartTop As PictureBox
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnCancelAll As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents picItem As PictureBox
    Friend WithEvents lblItems As Label
    Friend WithEvents pnlList As Panel
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents lblEwan1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents pnlCalcu As Panel
    Friend WithEvents pnlRight As Panel
    Friend WithEvents lblDineTake As Label
    Friend WithEvents lblMessage3 As Label
    Friend WithEvents lblEwan2 As Label
    Friend WithEvents btnTakeOut As Button
    Friend WithEvents btnDineIn As Button
    Friend WithEvents lblMessage1 As Label
    Friend WithEvents lblMessage2 As Label
    Friend WithEvents lblMessage4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents pnlMiddle As Panel
    Friend WithEvents txtTendered As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents lblOOHH As Label
    Friend WithEvents lblEEHH As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblAAHH As Label
    Friend WithEvents picCalcu As PictureBox
    Friend WithEvents btn10 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn1000 As Button
    Friend WithEvents btn500 As Button
    Friend WithEvents btn200 As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btn100 As Button
    Friend WithEvents btn50 As Button
    Friend WithEvents btn20 As Button
    Friend WithEvents btnBaack As Button
    Friend WithEvents lblDine As Label
    Friend WithEvents lblTake As Label
    Friend WithEvents DataGridView2 As DataGridView
End Class
