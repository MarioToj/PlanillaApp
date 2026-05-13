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

    Function GetById(id As Integer) As Trabajador
        Using conn = dbConn.GetConnection()
            conn.Open()
            Dim Cmd As New MySqlCommand("SELECT * from trabajadores WHERE IDTrabajador = @id", conn)
            Cmd.Parameters.AddWithValue("@id", id)
            Using rd = Cmd.ExecuteReader()
                If rd.Read() Then
                    Return New Trabajador With {
                        .IDCargo = rd.GetInt32("IDCargo"),
                        .Nombre = rd.GetString("Nombre"),
                        .IDTrabajador = rd.GetInt32("IDTrabajador")
                    }
                End If
            End Using
        End Using
        Return Nothing
    End Function

    Sub Add(trabajador As Trabajador)
        Using conn = dbConn.GetConnection()
            conn.Open()
            Dim Cmd As New MySqlCommand("INSERT INTO trabajadores (Nombre, IDCargo) VALUES (@Nombre, @IDCargo)", conn)
            Cmd.Parameters.AddWithValue("@Nombre", trabajador.Nombre)
            Cmd.Parameters.AddWithValue("@IDCargo", trabajador.IDCargo)
            Cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class
