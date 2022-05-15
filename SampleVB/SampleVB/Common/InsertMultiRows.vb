Imports System.Data.SqlClient

Public Class InsertMultiRows
    ''' <summary>
    ''' Hàm insert multi Rows
    ''' </summary>
    ''' <param name="dgv"></param>
    ''' <returns></returns>
    Public Shared Function DataGridViewToCsv(ByVal dgv As DataGridView) As Boolean
        For Each row As DataGridViewRow In dgv.Rows
            Dim constring As String = "Data Source=LAPTOP-RAKLD1NN;Initial Catalog=Demo;Integrated Security=True"
            Using con As New SqlConnection(constring)
                Using cmd As New SqlCommand("INSERT INTO SINHVIEN VALUES(@manv, @hoten, @ngaysinh,@noisinh,@gioitinh)", con)
                    cmd.Parameters.AddWithValue("@manv", row.Cells("ColMaSV").Value)
                    cmd.Parameters.AddWithValue("@hoten", row.Cells("ColHoTen").Value)
                    cmd.Parameters.AddWithValue("@ngaysinh", row.Cells("ColNgaySinh").Value)
                    cmd.Parameters.AddWithValue("@noisinh", row.Cells("ColNoiSinh").Value)
                    cmd.Parameters.AddWithValue("@gioitinh", row.Cells("ColGioiTinh").Value)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
        Next
        MessageBox.Show("Records inserted.")
        Return True
    End Function
End Class
