Public Class SinhVien
#Region "thuoc tinh"
    Public MaSV As Int32
    Public HoTen As String
    Public NgaySinh As String
    Public NoiSinh As String
    Public GioiTinh As String

    '    Public Property MaSV As Int32
    '        Get
    '            Return _MaSV
    '        End Get
    '        Set(value As Int32)
    '            _MaSV = value
    '        End Set
    '    End Property

    '    Public Property HoTen As Int32
    '        Get
    '            Return _HoTen
    '        End Get
    '        Set(value As Int32)
    '            _HoTen = value
    '        End Set
    '    End Property

    '    Public Property NgaySinh As Int32
    '        Get
    '            Return _NgaySinh
    '        End Get
    '        Set(value As Int32)
    '            _NgaySinh = value
    '        End Set
    '    End Property

    '    Public Property NoiSinh As Int32
    '        Get
    '            Return _NoiSinh
    '        End Get
    '        Set(value As Int32)
    '            _NoiSinh = value
    '        End Set
    '    End Property

    '    Public Property GioiTinh As Int32
    '        Get
    '            Return _GioiTinh
    '        End Get
    '        Set(value As Int32)
    '            _GioiTinh = value
    '        End Set
    '    End Property
    '#End Region
    '#Region "Phuong thuc"
    '    Public Sub New(masv As Int32, hoten As String, ngaysinh As String, noisinh As String, gioitinh As String)
    '        Me.MaSV = masv
    '        Me.HoTen = hoten
    '        Me.NgaySinh = ngaysinh
    '        Me.NoiSinh = noisinh
    '        Me.GioiTinh = gioitinh
    '    End Sub

    Public Sub ShowAll()
        MessageBox.Show(String.Format("Ma SV: {0}, Ho ten: {1}, Ngay sinh: {2}, Noi sinh: {3}, Gioi tinh: {4} ", Me.MaSV, Me.HoTen, Me.NgaySinh, Me.NoiSinh, Me.GioiTinh))
    End Sub
#End Region
End Class
