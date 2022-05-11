Imports System.Data.SqlClient

Public Class Dbbase
    Public Shared _exception As Exception = Nothing
    Private Const _servername As String = "LAPTOP-RAKLD1NN"
    Private Const _database As String = "Demo"
    Private Const _password As String = "123456789"

    Public Shared Function GetConnectString() As String
        Dim connectStr As String = String.Empty
        connectStr += "Data Source=" & _servername & ";"
        connectStr += "Database=" & _database & ";"
        connectStr += "uid=sa" & ";"
        connectStr += "pwd=" & _password
        Return connectStr
    End Function

    Public Shared Function GetSqlConnection() As SqlConnection
        Dim connectStr As String = GetConnectString()
        Return New SqlConnection(connectStr)
    End Function

    Public Shared Sub Close(ByVal sqlConnection As SqlConnection)
        Try

            If sqlConnection IsNot Nothing Then
                sqlConnection.Close()
            End If

        Catch ex As Exception
            _exception = ex
        End Try

        Return
    End Sub
End Class
