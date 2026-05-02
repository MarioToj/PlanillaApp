Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class ConnPlanillaDb
    Private ReadOnly ConnectionString As String = ConfigurationManager.ConnectionStrings("PlanillaConn").ConnectionString

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function

End Class
