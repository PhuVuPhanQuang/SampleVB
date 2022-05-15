Imports System.IO

Public Class ReadFile

    ''' <summary>
    ''' Hàm đọc File text lên datagridview
    ''' </summary>
    ''' <param name="filePath"></param>
    ''' <param name="DataGridView"></param>
    ''' <param name="isTitle"></param>
    Public Shared Sub ReadCsvToDgv(filePath As String, ByVal DataGridView As DataGridView, ByVal isTitle As Boolean)

        Try
            'Dim endcode As Encoding = encoding.GetEncoding(encoding)
            Dim streamReader As StreamReader = New StreamReader(filePath)
            Dim fileLine As String = ""
            Dim lineCounter As Integer = 0

            Do
                fileLine = streamReader.ReadLine()

                If fileLine Is Nothing Then
                    Continue Do
                End If

                fileLine = fileLine.Trim()

                Console.WriteLine(fileLine)
                If fileLine.Length = 0 Then
                    Continue Do
                End If

                If (lineCounter = 0) AndAlso (isTitle <> False) Then
                    lineCounter = lineCounter + 1
                    Continue Do
                End If

                Dim line = fileLine.Split(Convert.ToChar(","))
                DataGridView.Rows.Add(line)
                lineCounter = lineCounter + 1

            Loop While fileLine IsNot Nothing

            streamReader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
End Class
