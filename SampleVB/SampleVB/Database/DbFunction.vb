Imports System.Data.SqlClient
Imports System.Text
Imports SampleVB.Form1

Public Class DbFunction

    Public Property Message As String


    Public Function GetAll() As List(Of SinhVien)
        Dim connection As SqlConnection

        Try
            'Viết câu sql lấy all
            Dim queryString As New StringBuilder()
            queryString.Append("SELECT * FROM SinhVien").Append(" ")
            'Khởi tạo connection
            connection = Dbbase.GetSqlConnection()
            'Open connection
            connection.Open()
            'Tạo command
            Dim command = New SqlCommand(queryString.ToString(), connection)
            command.CommandType = CommandType.Text
            'Binding dữ liệu vào command

            'Lấy dữ liệu đã get được set vào model SinhVien
            Dim sinhVienInfos = New List(Of SinhVien)
            Dim reader = command.ExecuteReader()
            While reader.Read() <> False
                Dim sinhVienInfo As New SinhVien()
                sinhVienInfo.MaSV = Int32.Parse(reader.GetValue(reader.GetOrdinal("MASV")))
                sinhVienInfo.HoTen = reader.GetString(reader.GetOrdinal("HOTEN"))
                sinhVienInfo.NgaySinh = reader.GetString(reader.GetOrdinal("NGAYSINH"))
                sinhVienInfo.NoiSinh = reader.GetString(reader.GetOrdinal("NOISINH"))
                sinhVienInfo.GioiTinh = reader.GetString(reader.GetOrdinal("GIOITINH"))
                sinhVienInfos.Add(sinhVienInfo)

            End While
            'Trả về List<SinhVien> đã get ở trên
            Return sinhVienInfos
        Catch ex As Exception
            Message = ex.Message
            Return Nothing
        Finally
            Dbbase.Close(connection)
        End Try
    End Function
    'Private Sub disp_data()
    '    cmd = con.CreateCommand()
    '    cmd.CommandType = CommandType.Text
    '    cmd.CommandText = "select * from SinhVien"
    '    cmd.ExecuteNonQuery()
    '    Dim dt As New DataTable()
    '    Dim da As New SqlDataAdapter(cmd)
    '    da.Fill(dt)
    '    DGVSinhVien.DataSource = dt
    'End Sub


    '    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
    '        If con.State = ConnectionState.Open Then
    '            con.Close()

    '        End If
    '        con.Open()

    '        disp_data()
    '    End Sub

    '    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
    '        If con.State = ConnectionState.Open Then
    '            con.Close()

    '        End If
    '        con.Open()
    '        cmd = con.CreateCommand()
    '        cmd.CommandType = CommandType.Text
    '        cmd.CommandText = "delete from SinhVien where MASV='" + txtMaSV.Text + "'"
    '        cmd.ExecuteNonQuery()
    '        disp_data()
    '    End Sub

    '    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
    '        If con.State = ConnectionState.Open Then
    '            con.Close()

    '        End If
    '        con.Open()
    '        cmd = con.CreateCommand()
    '        cmd.CommandType = CommandType.Text
    '        cmd.CommandText = "update SinhVien set HOTEN = N'" + txtHoTen.Text + "', NGAYSINH ='" + txtNgaySinh.Text + "', NOISINH = N'" + txtNoiSinh.Text + "', GIOITINH = N'" + txtGioiTinh.Text + "' where MASV =" + txtMaSV.Text + ""
    '        cmd.ExecuteNonQuery()
    '        disp_data()
    '    End Sub

    '    Private Sub DGVSinhVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSinhVien.CellClick
    '        Dim i As Integer
    '        i = Convert.ToInt32(DGVSinhVien.SelectedCells.Item(0).Value.ToString())
    '        cmd = con.CreateCommand()
    '        cmd.CommandType = CommandType.Text
    '        cmd.CommandText = "select * from SinhVien where MASV = " & i & ""
    '        'Dim reader = cmd.ExecuteReader()
    '        Dim dt As New DataTable()
    '        Dim da As New SqlDataAdapter(cmd)
    '        da.Fill(dt)
    '        Dim dr As SqlClient.SqlDataReader
    '        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
    '        While dr.Read
    '            txtMaSV.Text = dr.GetString(0).ToString()
    '            txtHoTen.Text = dr.GetString(1).ToString()
    '            txtNgaySinh.Text = dr.GetString(2).ToString()
    '            txtNoiSinh.Text = dr.GetString(3).ToString()
    '            txtGioiTinh.Text = dr.GetString(4).ToString()

    '        End While
    '    End Sub

End Class
