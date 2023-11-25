<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceipt))
        DataGridView3 = New DataGridView()
        Panel1 = New Panel()
        Label1 = New Label()
        lblTake = New Label()
        btnDineIn = New Button()
        lblAmount = New Label()
        lblAAHH = New Label()
        lblFoodservice = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblTendered = New Label()
        lblChange = New Label()
        Label7 = New Label()
        picLogo = New PictureBox()
        picName = New PictureBox()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(picName, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView3
        ' 
        DataGridView3.AccessibleRole = AccessibleRole.None
        DataGridView3.AllowUserToAddRows = False
        DataGridView3.AllowUserToDeleteRows = False
        DataGridView3.AllowUserToResizeColumns = False
        DataGridView3.AllowUserToResizeRows = False
        DataGridView3.BackgroundColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        DataGridView3.BorderStyle = BorderStyle.Fixed3D
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView3.Enabled = False
        DataGridView3.Location = New Point(12, 40)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.ReadOnly = True
        DataGridView3.RowHeadersVisible = False
        DataGridView3.RowTemplate.Height = 25
        DataGridView3.ScrollBars = ScrollBars.None
        DataGridView3.Size = New Size(345, 403)
        DataGridView3.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(107), CByte(112), CByte(80))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblTake)
        Panel1.Controls.Add(btnDineIn)
        Panel1.Controls.Add(DataGridView3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(369, 521)
        Panel1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        Label1.Location = New Point(180, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 17)
        Label1.TabIndex = 244
        Label1.Text = "Your order is being prepared"
        ' 
        ' lblTake
        ' 
        lblTake.AutoSize = True
        lblTake.BackColor = Color.Transparent
        lblTake.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblTake.ForeColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        lblTake.Location = New Point(82, 498)
        lblTake.Name = "lblTake"
        lblTake.Size = New Size(212, 17)
        lblTake.TabIndex = 243
        lblTake.Text = "Thank you for choosing Cafe Liebe"
        ' 
        ' btnDineIn
        ' 
        btnDineIn.BackColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        btnDineIn.FlatAppearance.BorderColor = Color.White
        btnDineIn.FlatAppearance.BorderSize = 0
        btnDineIn.FlatStyle = FlatStyle.Flat
        btnDineIn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnDineIn.ForeColor = Color.FromArgb(CByte(107), CByte(112), CByte(80))
        btnDineIn.Location = New Point(12, 451)
        btnDineIn.Name = "btnDineIn"
        btnDineIn.Size = New Size(345, 43)
        btnDineIn.TabIndex = 238
        btnDineIn.Text = "Confirm && Exit"
        btnDineIn.UseVisualStyleBackColor = False
        ' 
        ' lblAmount
        ' 
        lblAmount.BackColor = Color.Transparent
        lblAmount.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblAmount.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblAmount.Location = New Point(421, 142)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(80, 25)
        lblAmount.TabIndex = 11
        lblAmount.Text = "00.00"
        lblAmount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblAAHH
        ' 
        lblAAHH.AutoSize = True
        lblAAHH.BackColor = Color.Transparent
        lblAAHH.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblAAHH.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblAAHH.Location = New Point(411, 125)
        lblAAHH.Name = "lblAAHH"
        lblAAHH.Size = New Size(90, 17)
        lblAAHH.TabIndex = 10
        lblAAHH.Text = "Total Amount"
        ' 
        ' lblFoodservice
        ' 
        lblFoodservice.BackColor = Color.Transparent
        lblFoodservice.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblFoodservice.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblFoodservice.Location = New Point(375, 315)
        lblFoodservice.Name = "lblFoodservice"
        lblFoodservice.Size = New Size(126, 25)
        lblFoodservice.TabIndex = 13
        lblFoodservice.Text = "Service"
        lblFoodservice.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        Label3.Location = New Point(445, 298)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 17)
        Label3.TabIndex = 12
        Label3.Text = "Service"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        Label4.Location = New Point(386, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 17)
        Label4.TabIndex = 12
        Label4.Text = "Amount Tendered"
        ' 
        ' lblTendered
        ' 
        lblTendered.BackColor = Color.Transparent
        lblTendered.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblTendered.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblTendered.Location = New Point(424, 200)
        lblTendered.Name = "lblTendered"
        lblTendered.Size = New Size(80, 25)
        lblTendered.TabIndex = 13
        lblTendered.Text = "00.00"
        lblTendered.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblChange
        ' 
        lblChange.BackColor = Color.Transparent
        lblChange.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblChange.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblChange.Location = New Point(421, 259)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(80, 25)
        lblChange.TabIndex = 15
        lblChange.Text = "00.00"
        lblChange.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        Label7.Location = New Point(445, 242)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 17)
        Label7.TabIndex = 14
        Label7.Text = "Change"
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.Image = My.Resources.Resources.Logo
        picLogo.Location = New Point(384, 401)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(114, 107)
        picLogo.SizeMode = PictureBoxSizeMode.StretchImage
        picLogo.TabIndex = 16
        picLogo.TabStop = False
        ' 
        ' picName
        ' 
        picName.BackColor = Color.Transparent
        picName.Image = My.Resources.Resources.Logoo
        picName.Location = New Point(372, 11)
        picName.Name = "picName"
        picName.Size = New Size(138, 69)
        picName.SizeMode = PictureBoxSizeMode.Zoom
        picName.TabIndex = 17
        picName.TabStop = False
        ' 
        ' frmReceipt
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        ClientSize = New Size(513, 521)
        Controls.Add(picLogo)
        Controls.Add(picName)
        Controls.Add(lblChange)
        Controls.Add(Label7)
        Controls.Add(lblTendered)
        Controls.Add(Label4)
        Controls.Add(lblFoodservice)
        Controls.Add(Label3)
        Controls.Add(lblAmount)
        Controls.Add(lblAAHH)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmReceipt"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cafe Liebe"
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(picName, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDineIn As Button
    Friend WithEvents lblTake As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblAAHH As Label
    Friend WithEvents lblFoodservice As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTendered As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents picName As PictureBox
End Class
