'Imports System.Data.SqlClient
'Imports System.Text

'Public Class test
'    Public Function GetListAll() As IActionResult
'        Dim blogInfos As List(Of BlogModel) = Nothing
'        Dim connection As SqlConnection = Nothing

'        Try
'            Dim queryString As StringBuilder = New StringBuilder()
'            queryString.Append("SELECT * FROM SinhVien").Append(" ")
'            connection = Dbbase.GetSqlConnection()
'            connection.Open()
'            Dim command As SqlCommand = New SqlCommand(queryString.ToString(), connection)
'            command.CommandType = CommandType.Text
'            blogInfos = New List(Of BlogModel)()
'            Dim reader As SqlDataReader = command.ExecuteReader()

'            While reader.Read() <> False
'                Dim blog As BlogModel = New BlogModel()
'                SinhVien.Id = CStr((reader("Id")))
'                SinhVien.Title = CStr((reader("Title")))
'                SinhVien.Description = CStr((reader("Description")))
'                SinhVien.ShortDescription = CStr((reader("ShortDescription")))
'                SinhVien.Image = CStr((reader("Image")))
'                SinhVien.BlogStart = CType((reader("BlogStart")), DateTime)
'                SinhVien.BlogEnd = CType((reader("BlogEnd")), DateTime)
'                SinhVien.Address = CStr((reader("Address")))
'                SinhVien.PhoneNumber = CInt((reader("PhoneNumber")))
'                SinhVien.Add(SinhVien)
'            End While

'            reader.Close()
'        Catch ex As Exception
'            _errorMsg = ex.Message
'            GoTo TheEnd
'        Finally
'            Dbbase.Close(connection)
'        End Try

'TheEnd:
'        Return View(blogInfos)
'    End Function
'End Class
