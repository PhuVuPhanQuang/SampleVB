<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DGVSinhVien = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGioiTinh = New System.Windows.Forms.TextBox()
        Me.txtNoiSinh = New System.Windows.Forms.TextBox()
        Me.txtNgaySinh = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtMaSV = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.ColMaSV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHoTen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNgaySinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNoiSinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColGioiTinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVSinhVien
        '
        Me.DGVSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSinhVien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColMaSV, Me.ColHoTen, Me.ColNgaySinh, Me.ColNoiSinh, Me.ColGioiTinh})
        Me.DGVSinhVien.Location = New System.Drawing.Point(12, 219)
        Me.DGVSinhVien.Name = "DGVSinhVien"
        Me.DGVSinhVien.RowTemplate.Height = 21
        Me.DGVSinhVien.Size = New System.Drawing.Size(782, 217)
        Me.DGVSinhVien.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGioiTinh)
        Me.GroupBox1.Controls.Add(Me.txtNoiSinh)
        Me.GroupBox1.Controls.Add(Me.txtNgaySinh)
        Me.GroupBox1.Controls.Add(Me.txtHoTen)
        Me.GroupBox1.Controls.Add(Me.txtMaSV)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 185)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'txtGioiTinh
        '
        Me.txtGioiTinh.Location = New System.Drawing.Point(91, 157)
        Me.txtGioiTinh.Name = "txtGioiTinh"
        Me.txtGioiTinh.Size = New System.Drawing.Size(100, 19)
        Me.txtGioiTinh.TabIndex = 9
        '
        'txtNoiSinh
        '
        Me.txtNoiSinh.Location = New System.Drawing.Point(91, 126)
        Me.txtNoiSinh.Name = "txtNoiSinh"
        Me.txtNoiSinh.Size = New System.Drawing.Size(113, 19)
        Me.txtNoiSinh.TabIndex = 8
        '
        'txtNgaySinh
        '
        Me.txtNgaySinh.Location = New System.Drawing.Point(91, 90)
        Me.txtNgaySinh.Name = "txtNgaySinh"
        Me.txtNgaySinh.Size = New System.Drawing.Size(100, 19)
        Me.txtNgaySinh.TabIndex = 7
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(91, 56)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(130, 19)
        Me.txtHoTen.TabIndex = 6
        '
        'txtMaSV
        '
        Me.txtMaSV.Location = New System.Drawing.Point(91, 22)
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(100, 19)
        Me.txtMaSV.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Giới Tính"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nơi Sinh"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ngày Sinh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Họ Tên"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã SV"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnXoa)
        Me.GroupBox2.Controls.Add(Me.btnSua)
        Me.GroupBox2.Controls.Add(Me.btnThem)
        Me.GroupBox2.Location = New System.Drawing.Point(408, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(386, 185)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Control"
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(165, 79)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 2
        Me.btnXoa.Text = "Xóa "
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(293, 79)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 1
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(28, 79)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 0
        Me.btnThem.Text = "Thêm "
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'ColMaSV
        '
        Me.ColMaSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColMaSV.HeaderText = "Ma sinh vien"
        Me.ColMaSV.Name = "ColMaSV"
        '
        'ColHoTen
        '
        Me.ColHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColHoTen.HeaderText = "Ho ten "
        Me.ColHoTen.Name = "ColHoTen"
        '
        'ColNgaySinh
        '
        Me.ColNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColNgaySinh.HeaderText = "Ngay sinh"
        Me.ColNgaySinh.Name = "ColNgaySinh"
        '
        'ColNoiSinh
        '
        Me.ColNoiSinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColNoiSinh.HeaderText = "Noi sinh"
        Me.ColNoiSinh.Name = "ColNoiSinh"
        '
        'ColGioiTinh
        '
        Me.ColGioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColGioiTinh.HeaderText = "Gioi tinh"
        Me.ColGioiTinh.Name = "ColGioiTinh"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 448)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGVSinhVien)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGVSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVSinhVien As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtGioiTinh As TextBox
    Friend WithEvents txtNoiSinh As TextBox
    Friend WithEvents txtNgaySinh As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents ColMaSV As DataGridViewTextBoxColumn
    Friend WithEvents ColHoTen As DataGridViewTextBoxColumn
    Friend WithEvents ColNgaySinh As DataGridViewTextBoxColumn
    Friend WithEvents ColNoiSinh As DataGridViewTextBoxColumn
    Friend WithEvents ColGioiTinh As DataGridViewTextBoxColumn
End Class
