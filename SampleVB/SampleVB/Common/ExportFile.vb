Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Text
Imports DocumentFormat.OpenXml.Office

Public Class ExportFile
    Public Shared Property _message As String

    ''' <summary>
    ''' Hàm xuất File .csv
    ''' </summary>
    ''' <param name="filePath">Duong dan file</param>
    ''' <param name="dgv"></param>
    ''' <returns></returns>
    Public Shared Function DataGridViewToCsv(ByVal filePath As String, ByVal dgv As DataGridView) As Boolean
        Dim isSuccess As Boolean

        Try
            ' Khai bao bien
            Dim contentWriteCsv As StringBuilder = New StringBuilder()
            Dim lastRow As Integer = If((dgv.AllowUserToAddRows <> False), (dgv.RowCount - 1), dgv.RowCount)


            For rowIdx As Integer = 0 To lastRow - 1
                Dim cellValues As String() = New String(dgv.ColumnCount - 1) {}

                For colIdx As Integer = 0 To dgv.ColumnCount - 1
                    cellValues(colIdx) = String.Empty

                    If dgv.Rows(rowIdx).Cells(colIdx).Value IsNot Nothing Then
                        cellValues(colIdx) = dgv.Rows(rowIdx).Cells(colIdx).Value.ToString()
                    End If
                Next

                Dim cellTexts As String = String.Join(",", cellValues)
                contentWriteCsv.AppendLine(cellTexts)
            Next

            File.WriteAllText(filePath, contentWriteCsv.ToString())
            isSuccess = True
        Catch ex As Exception
            _message = ex.Message
            isSuccess = False
            GoTo TheEnd
        End Try

TheEnd:
        Return isSuccess
    End Function


End Class
