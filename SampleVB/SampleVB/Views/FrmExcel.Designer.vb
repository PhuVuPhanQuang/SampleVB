<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmExcel
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
        Me.components = New System.ComponentModel.Container()
        Me.SINHVIENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DemoDataSet = New SampleVB.DemoDataSet()
        Me.btnXuat = New System.Windows.Forms.Button()
        Me.btnThemDuLieu = New System.Windows.Forms.Button()
        Me.SINHVIENTableAdapter = New SampleVB.DemoDataSetTableAdapters.SINHVIENTableAdapter()
        Me.dgvSinhVien = New System.Windows.Forms.DataGridView()
        Me.ColMaSV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHoTen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNgaySinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNoiSinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColGioiTinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtFileDich = New System.Windows.Forms.TextBox()
        Me.lblPathDes = New System.Windows.Forms.Label()
        CType(Me.SINHVIENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DemoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SINHVIENBindingSource
        '
        Me.SINHVIENBindingSource.DataMember = "SINHVIEN"
        Me.SINHVIENBindingSource.DataSource = Me.DemoDataSet
        '
        'DemoDataSet
        '
        Me.DemoDataSet.DataSetName = "DemoDataSet"
        Me.DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnXuat
        '
        Me.btnXuat.Location = New System.Drawing.Point(831, 308)
        Me.btnXuat.Name = "btnXuat"
        Me.btnXuat.Size = New System.Drawing.Size(75, 23)
        Me.btnXuat.TabIndex = 4
        Me.btnXuat.Text = "Export"
        Me.btnXuat.UseVisualStyleBackColor = True
        '
        'btnThemDuLieu
        '
        Me.btnThemDuLieu.BackColor = System.Drawing.Color.Transparent
        Me.btnThemDuLieu.Location = New System.Drawing.Point(686, 308)
        Me.btnThemDuLieu.Name = "btnThemDuLieu"
        Me.btnThemDuLieu.Size = New System.Drawing.Size(116, 23)
        Me.btnThemDuLieu.TabIndex = 5
        Me.btnThemDuLieu.Text = "Add Data From File"
        Me.btnThemDuLieu.UseVisualStyleBackColor = False
        '
        'SINHVIENTableAdapter
        '
        Me.SINHVIENTableAdapter.ClearBeforeFill = True
        '
        'dgvSinhVien
        '
        Me.dgvSinhVien.AllowDrop = True
        Me.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSinhVien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColMaSV, Me.ColHoTen, Me.ColNgaySinh, Me.ColNoiSinh, Me.ColGioiTinh})
        Me.dgvSinhVien.Location = New System.Drawing.Point(23, 86)
        Me.dgvSinhVien.Name = "dgvSinhVien"
        Me.dgvSinhVien.RowTemplate.Height = 21
        Me.dgvSinhVien.Size = New System.Drawing.Size(883, 206)
        Me.dgvSinhVien.TabIndex = 7
        '
        'ColMaSV
        '
        Me.ColMaSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColMaSV.HeaderText = "MASV"
        Me.ColMaSV.Name = "ColMaSV"
        '
        'ColHoTen
        '
        Me.ColHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColHoTen.HeaderText = "HOTEN"
        Me.ColHoTen.Name = "ColHoTen"
        '
        'ColNgaySinh
        '
        Me.ColNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColNgaySinh.HeaderText = "NGAYSINH"
        Me.ColNgaySinh.Name = "ColNgaySinh"
        '
        'ColNoiSinh
        '
        Me.ColNoiSinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColNoiSinh.HeaderText = "NoiSinh"
        Me.ColNoiSinh.Name = "ColNoiSinh"
        '
        'ColGioiTinh
        '
        Me.ColGioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColGioiTinh.HeaderText = "GIOITINH"
        Me.ColGioiTinh.Name = "ColGioiTinh"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(41, 15)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(30, 12)
        Me.lblPath.TabIndex = 8
        Me.lblPath.Text = "Path:"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(77, 12)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(198, 19)
        Me.txtFilePath.TabIndex = 9
        '
        'txtFileDich
        '
        Me.txtFileDich.Location = New System.Drawing.Point(77, 52)
        Me.txtFileDich.Name = "txtFileDich"
        Me.txtFileDich.Size = New System.Drawing.Size(198, 19)
        Me.txtFileDich.TabIndex = 11
        '
        'lblPathDes
        '
        Me.lblPathDes.AutoSize = True
        Me.lblPathDes.Location = New System.Drawing.Point(21, 55)
        Me.lblPathDes.Name = "lblPathDes"
        Me.lblPathDes.Size = New System.Drawing.Size(54, 12)
        Me.lblPathDes.TabIndex = 12
        Me.lblPathDes.Text = "Path Des:"
        '
        'FrmExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 350)
        Me.Controls.Add(Me.lblPathDes)
        Me.Controls.Add(Me.txtFileDich)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.dgvSinhVien)
        Me.Controls.Add(Me.btnThemDuLieu)
        Me.Controls.Add(Me.btnXuat)
        Me.Name = "FrmExcel"
        Me.Text = "FrmExcel"
        CType(Me.SINHVIENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DemoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnXuat As Button
    Friend WithEvents btnThemDuLieu As Button
    Friend WithEvents DemoDataSet As DemoDataSet
    Friend WithEvents SINHVIENBindingSource As BindingSource
    Friend WithEvents SINHVIENTableAdapter As DemoDataSetTableAdapters.SINHVIENTableAdapter
    Friend WithEvents dgvSinhVien As DataGridView
    Friend WithEvents lblPath As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents ColMaSV As DataGridViewTextBoxColumn
    Friend WithEvents ColHoTen As DataGridViewTextBoxColumn
    Friend WithEvents ColNgaySinh As DataGridViewTextBoxColumn
    Friend WithEvents ColNoiSinh As DataGridViewTextBoxColumn
    Friend WithEvents ColGioiTinh As DataGridViewTextBoxColumn
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents txtFileDich As TextBox
    Friend WithEvents lblPathDes As Label
End Class
