' NOTE: Install MySql.Data NuGet package first:
' Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution
' Search for "MySql.Data" and install it

Imports MySql.Data.MySqlClient

Public Class DatabaseHelper
    ' Update connection string if needed (default XAMPP settings)
    Private Shared connectionString As String = "Server=localhost;Database=hospital_db;Uid=root;Pwd=;"

    Public Shared Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    Public Shared Function ExecuteQuery(query As String) As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Shared Function ExecuteNonQuery(query As String, parameters As Dictionary(Of String, Object)) As Integer
        Using conn = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                conn.Open()
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function
End Class
