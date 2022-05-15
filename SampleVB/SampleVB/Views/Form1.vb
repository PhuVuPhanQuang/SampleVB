Imports System.Data.SqlClient
Imports System.IO
Imports ClosedXML.Excel
Imports SampleVB.DbFunction

Public Class Form1
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = Dbbase.GetSqlConnection()
        con.Open()
        Dim dbFunction As New DbFunction
        Dim sinhVienInfos = dbFunction.GetAll()
        If sinhVienInfos Is Nothing Then
            MessageBox.Show(dbFunction.Message)
        End If

        'Add thêm row   
        For index As Integer = 0 To sinhVienInfos.Count - 1
            DGVSinhVien.Rows.Add()

            'Set dữ liệu vào Column
            Dim newRow As DataGridViewRow = DGVSinhVien.Rows(index)
            newRow.Cells("ColMaSV").Value = sinhVienInfos(index).MaSV
            newRow.Cells("ColHoTen").Value = sinhVienInfos(index).HoTen
            newRow.Cells("ColNgaySinh").Value = sinhVienInfos(index).NgaySinh
            newRow.Cells("ColNoiSinh").Value = sinhVienInfos(index).NoiSinh
            newRow.Cells("ColGioiTinh").Value = sinhVienInfos(index).GioiTinh
        Next
        Return
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub LoadData()
        con = Dbbase.GetSqlConnection()
        con.Open()
        Dim dbFunction As New DbFunction
        Dim sinhVienInfos = dbFunction.GetAll()
        If sinhVienInfos Is Nothing Then
            MessageBox.Show(dbFunction.Message)
        End If

        'Add thêm row   
        For index As Integer = 0 To sinhVienInfos.Count - 1
            DGVSinhVien.Rows.Add()

            'Set dữ liệu vào Column
            Dim newRow As DataGridViewRow = DGVSinhVien.Rows(index)
            newRow.Cells("ColMaSV").Value = sinhVienInfos(index).MaSV
            newRow.Cells("ColHoTen").Value = sinhVienInfos(index).HoTen
            newRow.Cells("ColNgaySinh").Value = sinhVienInfos(index).NgaySinh
            newRow.Cells("ColNoiSinh").Value = sinhVienInfos(index).NoiSinh
            newRow.Cells("ColGioiTinh").Value = sinhVienInfos(index).GioiTinh
        Next
        Return
    End Sub

    ''' <summary>
    ''' Nút sự kiện thêm datagridview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Dim dbFunction As New DbFunction()
            Dim modelsSV As New SinhVien()

            modelsSV.MaSV = txtMaSV.Text
            modelsSV.HoTen = txtHoTen.Text
            modelsSV.NgaySinh = txtNgaySinh.Text
            modelsSV.NoiSinh = txtNoiSinh.Text
            modelsSV.GioiTinh = txtGioiTinh.Text

            dbFunction.Insert(modelsSV)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        LoadData()

    End Sub

    ''' <summary>
    ''' Nút sự kiện xóa datagridview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click

        Try
            Dim dbFunction As New DbFunction()
            Dim retDel = dbFunction.Delete(txtMaSV.Text)

            If retDel = False Then
                dbFunction.GetMessage()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        LoadData()
    End Sub

    ''' <summary>
    ''' Nút sự kiện cập nhật datagridview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Try
            Dim dbFunction As New DbFunction()
            Dim modelsSV As New SinhVien()

            modelsSV.HoTen = txtHoTen.Text
            modelsSV.NgaySinh = txtNgaySinh.Text
            modelsSV.NoiSinh = txtNoiSinh.Text
            modelsSV.GioiTinh = txtGioiTinh.Text

            dbFunction.Update(txtMaSV.Text, modelsSV)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        LoadData()
    End Sub



    Private Sub DGVSinhVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSinhVien.CellClick
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        Dim i As Integer
        i = Convert.ToInt32(DGVSinhVien.SelectedCells.Item(0).Value.ToString())
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from SinhVien where MASV = " & i & ""
        'Dim reader = cmd.ExecuteReader()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Dim dr As SqlClient.SqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            txtMaSV.Text = dr.GetString(0).ToString()
            txtHoTen.Text = dr.GetString(1).ToString()
            txtNgaySinh.Text = dr.GetString(2).ToString()
            txtNoiSinh.Text = dr.GetString(3).ToString()
            txtGioiTinh.Text = dr.GetString(4).ToString()
        End While
    End Sub

End Class
