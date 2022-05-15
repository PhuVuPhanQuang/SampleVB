Imports System.Data.SqlClient
Imports System.Text
Imports SampleVB.Form1

Public Class DbFunction
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property Message As String

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Private Property _errorMsg As String = String.Empty

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Function GetMessage() As String
        Return _errorMsg
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAll() As List(Of SinhVien)
        Dim connection As SqlConnection = Nothing

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
                'sinhVienInfo.MaSV = Int32.Parse(reader.GetValue(reader.GetOrdinal("MASV")))
                sinhVienInfo.MaSV = reader.GetString(reader.GetOrdinal("MASV"))
                sinhVienInfo.HoTen = reader.GetString(reader.GetOrdinal("HOTEN"))
                sinhVienInfo.NgaySinh = reader.GetString(reader.GetOrdinal("NGAYSINH"))
                sinhVienInfo.NoiSinh = reader.GetString(reader.GetOrdinal("NOISINH"))
                sinhVienInfo.GioiTinh = reader.GetString(reader.GetOrdinal("GIOITINH"))
                sinhVienInfos.Add(sinhVienInfo)

            End While
            'Trả về List<SinhVien> đã get ở trên
            Return sinhVienInfos
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            'Message = ex.Message
            Return Nothing
        Finally
            Dbbase.Close(connection)
        End Try
    End Function


    Public Function Insert(ByVal them As SinhVien) As String
        Dim connection As SqlConnection = Nothing
        Dim errorMsg As String = ""
        Try
            Dim queryString As StringBuilder = New StringBuilder()
            queryString.Append("  INSERT INTO SINHVIEN").Append(" ")
            queryString.Append("  (").Append(" ")
            queryString.Append("  MASV" & ",").Append(" ")
            queryString.Append("  HOTEN" & ",").Append(" ")
            queryString.Append("  NGAYSINH" & ",").Append(" ")
            queryString.Append("  NOISINH" & ",").Append(" ")
            queryString.Append("  GIOITINH" & " ").Append(" ")
            queryString.Append(")").Append(" ")
            queryString.Append("VALUES").Append(" ")
            queryString.Append("(").Append(" ")
            queryString.Append("  @masv" & ",").Append(" ")
            queryString.Append("  @hoten" & ",").Append(" ")
            queryString.Append("  @ngaysinh" & ",").Append(" ")
            queryString.Append("  @noisinh" & ",").Append(" ")
            queryString.Append("  @gioitinh" & " ").Append(" ")
            queryString.Append(")").Append(" ")
            connection = Dbbase.GetSqlConnection()
            connection.Open()
            Dim command As SqlCommand = New SqlCommand(queryString.ToString(), connection)
            command.CommandType = CommandType.Text
            Dim parameters As SqlParameterCollection = command.Parameters
            parameters.AddWithValue("@masv", them.MaSV)
            parameters.AddWithValue("@hoten", them.HoTen)
            parameters.AddWithValue("@ngaysinh", them.NgaySinh)
            parameters.AddWithValue("@noisinh", them.NoiSinh)
            parameters.AddWithValue("@gioitinh", them.GioiTinh)

            Dim res As Integer = command.ExecuteNonQuery()

            If res <> 1 Then
                GoTo TheEnd
            End If


        Catch ex As Exception
            Console.WriteLine(ex.Message)
            errorMsg = ex.Message
            'GoTo TheEnd
        Finally
            Dbbase.Close(connection)
        End Try

TheEnd:
        Return errorMsg
    End Function


    Public Function Delete(ByVal masv As String) As Boolean
        Dim retDel As Boolean = False
        Dim connection As SqlConnection = Nothing

        Try
            Dim queryString As StringBuilder = New StringBuilder()
            queryString.Append("DELETE FROM SINHVIEN").Append(" ")
            queryString.Append("WHERE MASV = " & "@masv").Append(" ")
            connection = Dbbase.GetSqlConnection()
            connection.Open()
            Dim command As SqlCommand = New SqlCommand(queryString.ToString(), connection)
            command.CommandType = CommandType.Text
            Dim parameters As SqlParameterCollection = command.Parameters
            parameters.AddWithValue("@masv", masv)
            Dim res As Integer = command.ExecuteNonQuery()

            If res <> 1 Then
                GoTo TheEnd
            End If

            retDel = True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            GoTo TheEnd
        Finally
            Dbbase.Close(connection)
        End Try

TheEnd:
        Return retDel
    End Function

    Public Function Update(ByVal masv As String, ByVal capnhat As SinhVien) As Boolean
        Dim retUpdate As Boolean = False
        Dim connection As SqlConnection = Nothing

        Try
            Dim queryString As StringBuilder = New StringBuilder()
            queryString.Append("UPDATE SINHVIEN").Append(" ")
            queryString.Append("SET").Append(" ")
            queryString.Append("  HOTEN = " & "@hoten" & ",").Append(" ")
            queryString.Append("  NGAYSINH = " & "@ngaysinh" & ",").Append(" ")
            queryString.Append("  NOISINH = " & "@noisinh" & ",").Append(" ")
            queryString.Append("  GIOITINH = " & "@gioitinh" & " ").Append(" ")
            queryString.Append("WHERE").Append(" ")
            queryString.Append("  MASV = " & "@masv").Append(" ")
            connection = Dbbase.GetSqlConnection()
            connection.Open()
            Dim command As SqlCommand = New SqlCommand(queryString.ToString(), connection)
            command.CommandType = CommandType.Text
            Dim parameters As SqlParameterCollection = command.Parameters
            parameters.AddWithValue("@masv", masv)
            parameters.AddWithValue("@hoten", capnhat.HoTen)
            parameters.AddWithValue("@ngaysinh", capnhat.NgaySinh)
            parameters.AddWithValue("@noisinh", capnhat.NoiSinh)
            parameters.AddWithValue("@gioitinh", capnhat.GioiTinh)
            Dim res As Integer = command.ExecuteNonQuery()

            If res <> 1 Then
                GoTo TheEnd
            End If

            retUpdate = True
        Catch ex As Exception
            _errorMsg = ex.Message
            GoTo TheEnd
        Finally
            Dbbase.Close(connection)
        End Try

TheEnd:
        Return retUpdate
    End Function




End Class
