<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiTietHoaDon
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOKCTHD = New System.Windows.Forms.Button()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGiaBan = New System.Windows.Forms.TextBox()
        Me.btnCancelCTHD = New System.Windows.Forms.Button()
        Me.txtMaSP = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã HĐ :"
        '
        'btnOKCTHD
        '
        Me.btnOKCTHD.Location = New System.Drawing.Point(35, 187)
        Me.btnOKCTHD.Name = "btnOKCTHD"
        Me.btnOKCTHD.Size = New System.Drawing.Size(75, 23)
        Me.btnOKCTHD.TabIndex = 1
        Me.btnOKCTHD.Text = "&OK"
        Me.btnOKCTHD.UseVisualStyleBackColor = True
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(123, 49)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(126, 20)
        Me.txtMaHD.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã SP:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Số Lượng :"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(123, 101)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(126, 20)
        Me.txtSoLuong.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Giá Bán :"
        '
        'txtGiaBan
        '
        Me.txtGiaBan.Location = New System.Drawing.Point(123, 127)
        Me.txtGiaBan.Name = "txtGiaBan"
        Me.txtGiaBan.Size = New System.Drawing.Size(126, 20)
        Me.txtGiaBan.TabIndex = 2
        '
        'btnCancelCTHD
        '
        Me.btnCancelCTHD.Location = New System.Drawing.Point(174, 187)
        Me.btnCancelCTHD.Name = "btnCancelCTHD"
        Me.btnCancelCTHD.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelCTHD.TabIndex = 1
        Me.btnCancelCTHD.Text = "&Cancel"
        Me.btnCancelCTHD.UseVisualStyleBackColor = True
        '
        'txtMaSP
        '
        Me.txtMaSP.FormattingEnabled = True
        Me.txtMaSP.Location = New System.Drawing.Point(123, 74)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(126, 21)
        Me.txtMaSP.TabIndex = 3
        '
        'frmChiTietHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.txtGiaBan)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancelCTHD)
        Me.Controls.Add(Me.btnOKCTHD)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmChiTietHoaDon"
        Me.Text = "frmChiTietHoaDon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOKCTHD As System.Windows.Forms.Button
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGiaBan As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelCTHD As System.Windows.Forms.Button
    Friend WithEvents txtMaSP As System.Windows.Forms.ComboBox
End Class
