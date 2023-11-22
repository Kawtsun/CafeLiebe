<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlTop = New Panel()
        btnExit = New Button()
        picStartTop = New PictureBox()
        btnContinue = New Button()
        picLogo = New PictureBox()
        picName = New PictureBox()
        lblTap = New Label()
        lblEhhh = New Label()
        pnlTop.SuspendLayout()
        CType(picStartTop, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(picName, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlTop
        ' 
        pnlTop.BackColor = Color.FromArgb(CByte(254), CByte(245), CByte(230))
        pnlTop.Controls.Add(lblEhhh)
        pnlTop.Controls.Add(btnExit)
        pnlTop.Controls.Add(picStartTop)
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(0, 0)
        pnlTop.Name = "pnlTop"
        pnlTop.Size = New Size(934, 40)
        pnlTop.TabIndex = 0
        ' 
        ' btnExit
        ' 
        btnExit.Dock = DockStyle.Right
        btnExit.FlatAppearance.BorderColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btnExit.FlatAppearance.BorderSize = 2
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        btnExit.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        btnExit.Location = New Point(859, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 40)
        btnExit.TabIndex = 1
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' picStartTop
        ' 
        picStartTop.Image = My.Resources.Resources.start
        picStartTop.Location = New Point(0, 3)
        picStartTop.Name = "picStartTop"
        picStartTop.Size = New Size(54, 34)
        picStartTop.SizeMode = PictureBoxSizeMode.Zoom
        picStartTop.TabIndex = 0
        picStartTop.TabStop = False
        ' 
        ' btnContinue
        ' 
        btnContinue.BackgroundImage = My.Resources.Resources.bg
        btnContinue.FlatAppearance.BorderSize = 0
        btnContinue.FlatStyle = FlatStyle.Flat
        btnContinue.Location = New Point(0, 0)
        btnContinue.Name = "btnContinue"
        btnContinue.Size = New Size(934, 561)
        btnContinue.TabIndex = 1
        btnContinue.Text = " "
        btnContinue.UseVisualStyleBackColor = True
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.Image = My.Resources.Resources.Logo
        picLogo.Location = New Point(81, 133)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(274, 266)
        picLogo.SizeMode = PictureBoxSizeMode.StretchImage
        picLogo.TabIndex = 2
        picLogo.TabStop = False
        ' 
        ' picName
        ' 
        picName.BackColor = Color.Transparent
        picName.Image = My.Resources.Resources.Logoo
        picName.Location = New Point(336, 133)
        picName.Name = "picName"
        picName.Size = New Size(523, 289)
        picName.SizeMode = PictureBoxSizeMode.Zoom
        picName.TabIndex = 2
        picName.TabStop = False
        ' 
        ' lblTap
        ' 
        lblTap.AutoSize = True
        lblTap.BackColor = Color.Transparent
        lblTap.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblTap.ForeColor = Color.FromArgb(CByte(234), CByte(225), CByte(210))
        lblTap.Location = New Point(348, 402)
        lblTap.Name = "lblTap"
        lblTap.Size = New Size(257, 25)
        lblTap.TabIndex = 2
        lblTap.Text = "Tap Anywhere to Continue..."
        ' 
        ' lblEhhh
        ' 
        lblEhhh.AutoSize = True
        lblEhhh.BackColor = Color.Transparent
        lblEhhh.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblEhhh.ForeColor = Color.FromArgb(CByte(62), CByte(47), CByte(40))
        lblEhhh.Location = New Point(60, 11)
        lblEhhh.Name = "lblEhhh"
        lblEhhh.Size = New Size(180, 17)
        lblEhhh.TabIndex = 4
        lblEhhh.Text = "Welcome beloved customer..."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg
        ClientSize = New Size(934, 561)
        Controls.Add(lblTap)
        Controls.Add(picLogo)
        Controls.Add(picName)
        Controls.Add(pnlTop)
        Controls.Add(btnContinue)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        pnlTop.ResumeLayout(False)
        pnlTop.PerformLayout()
        CType(picStartTop, ComponentModel.ISupportInitialize).EndInit()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(picName, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents picStartTop As PictureBox
    Friend WithEvents btnContinue As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents picName As PictureBox
    Friend WithEvents lblTap As Label
    Friend WithEvents lblEhhh As Label
End Class
