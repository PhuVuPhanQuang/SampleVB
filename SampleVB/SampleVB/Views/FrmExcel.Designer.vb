<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExcel
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
        Me.components = New System.ComponentModel.Container()
        Me.DGVSinhVien = New System.Windows.Forms.DataGridView()
        Me.btnXuat = New System.Windows.Forms.Button()
        Me.btnThemData = New System.Windows.Forms.Button()
        Me.DemoDataSet = New SampleVB.DemoDataSet()
        Me.SINHVIENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SINHVIENTableAdapter = New SampleVB.DemoDataSetTableAdapters.SINHVIENTableAdapter()
        Me.MASVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOTENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGAYSINHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOISINHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GIOITINHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DemoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SINHVIENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVSinhVien
        '
        Me.DGVSinhVien.AllowDrop = True
        Me.DGVSinhVien.AutoGenerateColumns = False
        Me.DGVSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSinhVien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MASVDataGridViewTextBoxColumn, Me.HOTENDataGridViewTextBoxColumn, Me.NGAYSINHDataGridViewTextBoxColumn, Me.NOISINHDataGridViewTextBoxColumn, Me.GIOITINHDataGridViewTextBoxColumn})
        Me.DGVSinhVien.DataSource = Me.SINHVIENBindingSource
        Me.DGVSinhVien.Location = New System.Drawing.Point(12, 12)
        Me.DGVSinhVien.Name = "DGVSinhVien"
        Me.DGVSinhVien.RowHeadersWidth = 51
        Me.DGVSinhVien.RowTemplate.Height = 24
        Me.DGVSinhVien.Size = New System.Drawing.Size(891, 365)
        Me.DGVSinhVien.TabIndex = 0
        '
        'btnXuat
        '
        Me.btnXuat.Location = New System.Drawing.Point(828, 399)
        Me.btnXuat.Name = "btnXuat"
        Me.btnXuat.Size = New System.Drawing.Size(75, 33)
        Me.btnXuat.TabIndex = 1
        Me.btnXuat.Text = "Xuất File"
        Me.btnXuat.UseVisualStyleBackColor = True
        '
        'btnThemData
        '
        Me.btnThemData.Location = New System.Drawing.Point(702, 399)
        Me.btnThemData.Name = "btnThemData"
        Me.btnThemData.Size = New System.Drawing.Size(102, 33)
        Me.btnThemData.TabIndex = 2
        Me.btnThemData.Text = "Thêm dữ liệu"
        Me.btnThemData.UseVisualStyleBackColor = True
        '
        'DemoDataSet
        '
        Me.DemoDataSet.DataSetName = "DemoDataSet"
        Me.DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SINHVIENBindingSource
        '
        Me.SINHVIENBindingSource.DataMember = "SINHVIEN"
        Me.SINHVIENBindingSource.DataSource = Me.DemoDataSet
        '
        'SINHVIENTableAdapter
        '
        Me.SINHVIENTableAdapter.ClearBeforeFill = True
        '
        'MASVDataGridViewTextBoxColumn
        '
        Me.MASVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MASVDataGridViewTextBoxColumn.DataPropertyName = "MASV"
        Me.MASVDataGridViewTextBoxColumn.HeaderText = "MASV"
        Me.MASVDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MASVDataGridViewTextBoxColumn.Name = "MASVDataGridViewTextBoxColumn"
        '
        'HOTENDataGridViewTextBoxColumn
        '
        Me.HOTENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN"
        Me.HOTENDataGridViewTextBoxColumn.HeaderText = "HOTEN"
        Me.HOTENDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HOTENDataGridViewTextBoxColumn.Name = "HOTENDataGridViewTextBoxColumn"
        '
        'NGAYSINHDataGridViewTextBoxColumn
        '
        Me.NGAYSINHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH"
        Me.NGAYSINHDataGridViewTextBoxColumn.HeaderText = "NGAYSINH"
        Me.NGAYSINHDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NGAYSINHDataGridViewTextBoxColumn.Name = "NGAYSINHDataGridViewTextBoxColumn"
        '
        'NOISINHDataGridViewTextBoxColumn
        '
        Me.NOISINHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NOISINHDataGridViewTextBoxColumn.DataPropertyName = "NOISINH"
        Me.NOISINHDataGridViewTextBoxColumn.HeaderText = "NOISINH"
        Me.NOISINHDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOISINHDataGridViewTextBoxColumn.Name = "NOISINHDataGridViewTextBoxColumn"
        '
        'GIOITINHDataGridViewTextBoxColumn
        '
        Me.GIOITINHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GIOITINHDataGridViewTextBoxColumn.DataPropertyName = "GIOITINH"
        Me.GIOITINHDataGridViewTextBoxColumn.HeaderText = "GIOITINH"
        Me.GIOITINHDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GIOITINHDataGridViewTextBoxColumn.Name = "GIOITINHDataGridViewTextBoxColumn"
        '
        'FrmExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 444)
        Me.Controls.Add(Me.btnThemData)
        Me.Controls.Add(Me.btnXuat)
        Me.Controls.Add(Me.DGVSinhVien)
        Me.Name = "FrmExcel"
        Me.Text = "FrmExcel"
        CType(Me.DGVSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DemoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SINHVIENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVSinhVien As DataGridView
    Friend WithEvents btnXuat As Button
    Friend WithEvents btnThemData As Button
    Friend WithEvents DemoDataSet As DemoDataSet
    Friend WithEvents SINHVIENBindingSource As BindingSource
    Friend WithEvents SINHVIENTableAdapter As DemoDataSetTableAdapters.SINHVIENTableAdapter
    Friend WithEvents MASVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HOTENDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NGAYSINHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOISINHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GIOITINHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
