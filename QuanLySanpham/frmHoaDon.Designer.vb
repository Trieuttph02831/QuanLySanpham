<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDon
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
        Me.txttitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.txtNgayLapHD = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.btnOKHoaDon = New System.Windows.Forms.Button()
        Me.bntCancelHoadon = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txttitle
        '
        Me.txttitle.AutoSize = True
        Me.txttitle.Location = New System.Drawing.Point(114, 29)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(0, 13)
        Me.txttitle.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã KH :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mã  HD:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ngày Lập  HD:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 0
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(117, 59)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(134, 20)
        Me.txtMaKH.TabIndex = 1
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(117, 90)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(134, 20)
        Me.txtMaHD.TabIndex = 1
        '
        'txtNgayLapHD
        '
        Me.txtNgayLapHD.Location = New System.Drawing.Point(117, 122)
        Me.txtNgayLapHD.Name = "txtNgayLapHD"
        Me.txtNgayLapHD.Size = New System.Drawing.Size(134, 20)
        Me.txtNgayLapHD.TabIndex = 1
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(117, 153)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(134, 20)
        Me.txtDonGia.TabIndex = 1
        '
        'btnOKHoaDon
        '
        Me.btnOKHoaDon.Location = New System.Drawing.Point(52, 205)
        Me.btnOKHoaDon.Name = "btnOKHoaDon"
        Me.btnOKHoaDon.Size = New System.Drawing.Size(75, 23)
        Me.btnOKHoaDon.TabIndex = 2
        Me.btnOKHoaDon.Text = "&OK"
        Me.btnOKHoaDon.UseVisualStyleBackColor = True
        '
        'bntCancelHoadon
        '
        Me.bntCancelHoadon.Location = New System.Drawing.Point(159, 205)
        Me.bntCancelHoadon.Name = "bntCancelHoadon"
        Me.bntCancelHoadon.Size = New System.Drawing.Size(75, 23)
        Me.bntCancelHoadon.TabIndex = 2
        Me.bntCancelHoadon.Text = "&Cancel"
        Me.bntCancelHoadon.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Đơn Giá"
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.bntCancelHoadon)
        Me.Controls.Add(Me.btnOKHoaDon)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtNgayLapHD)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttitle)
        Me.Name = "frmHoaDon"
        Me.Text = "Hóa Đơn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttitle As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents txtNgayLapHD As System.Windows.Forms.TextBox
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents btnOKHoaDon As System.Windows.Forms.Button
    Friend WithEvents bntCancelHoadon As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
