<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSanpham
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
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txtMaTl = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtNgayNhap = New System.Windows.Forms.TextBox()
        Me.txtTitleSp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(30, 85)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(77, 13)
        Me.lbl2.TabIndex = 0
        Me.lbl2.Text = "Mã sản phẩm :"
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(107, 85)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(135, 20)
        Me.txtMaSP.TabIndex = 1
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(30, 59)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(65, 13)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Mã thể loại :"
        '
        'txtMaTl
        '
        Me.txtMaTl.Location = New System.Drawing.Point(107, 59)
        Me.txtMaTl.Name = "txtMaTl"
        Me.txtMaTl.ReadOnly = True
        Me.txtMaTl.Size = New System.Drawing.Size(135, 20)
        Me.txtMaTl.TabIndex = 1
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(26, 111)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(75, 13)
        Me.lbl3.TabIndex = 0
        Me.lbl3.Text = "Tên sản phẩm"
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(107, 111)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(135, 20)
        Me.txtTenSP.TabIndex = 1
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(30, 137)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(59, 13)
        Me.lbl4.TabIndex = 0
        Me.lbl4.Text = "Ngày nhập"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(30, 163)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(49, 13)
        Me.lbl5.TabIndex = 0
        Me.lbl5.Text = "Số lượng"
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(107, 163)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(135, 20)
        Me.txtSoluong.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(50, 207)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(156, 207)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtNgayNhap
        '
        Me.txtNgayNhap.Location = New System.Drawing.Point(107, 137)
        Me.txtNgayNhap.Name = "txtNgayNhap"
        Me.txtNgayNhap.Size = New System.Drawing.Size(135, 20)
        Me.txtNgayNhap.TabIndex = 1
        '
        'txtTitleSp
        '
        Me.txtTitleSp.AutoSize = True
        Me.txtTitleSp.Location = New System.Drawing.Point(104, 21)
        Me.txtTitleSp.Name = "txtTitleSp"
        Me.txtTitleSp.Size = New System.Drawing.Size(39, 13)
        Me.txtTitleSp.TabIndex = 3
        Me.txtTitleSp.Text = "Label1"
        '
        'frmAddSanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtTitleSp)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtSoluong)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.txtNgayNhap)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.txtMaTl)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.lbl2)
        Me.Name = "frmAddSanpham"
        Me.Text = "San Pham"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtMaTl As System.Windows.Forms.TextBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtNgayNhap As System.Windows.Forms.TextBox
    Friend WithEvents txtTitleSp As System.Windows.Forms.Label
End Class
