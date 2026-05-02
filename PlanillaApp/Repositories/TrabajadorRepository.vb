Imports MySql.Data.MySqlClient

Public Class TrabajadorRepository
    Private ReadOnly dbConn As New ConnPlanillaDb()

    Function GetAll() As List(Of Trabajador)
        Dim Lista As New List(Of Trabajador)
        Using conn = dbConn.GetConnection()
            conn.Open()
            Dim Cmd As New MySqlCommand("SELECT * from trabajadores", conn)
            Using rd = Cmd.ExecuteReader()
                While rd.Read()
                    Lista.Add(New Trabajador With {
                        .IDCargo = rd.GetInt32("IDCargo"),
                        .Nombre = rd.GetString("Nombre"),
                        .IDTrabajador = rd.GetInt32("IDTrabajador")
                    })
                End While
            End Using
        End Using
        Return Lista
    End Function
End Class
