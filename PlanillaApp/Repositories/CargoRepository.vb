Imports MySql.Data.MySqlClient

Public Class CargoRepository
    Private ReadOnly dbConn As New ConnPlanillaDb()

    Function GetAll() As List(Of Cargo)
        Dim Lista As New List(Of Cargo)
        Using conn = dbConn.GetConnection()
            conn.Open()
            Dim Cmd As New MySqlCommand("SELECT * from cargos", conn)
            Using rd = Cmd.ExecuteReader()
                While rd.Read()
                    Lista.Add(New Cargo With {
                        .IDCargo = rd.GetInt32("IDCargo"),
                        .NombreCargo = rd.GetString("NombreCargo"),
                        .SueldoBase = rd.GetDecimal("SueldoBase")
                    })
                End While
            End Using
        End Using
        Return Lista
    End Function

    Function GetById(id As Integer) As Cargo
        Using conn = dbConn.GetConnection()
            conn.Open()
            Dim Cmd As New MySqlCommand("SELECT * from cargos WHERE IDCargo = @id", conn)
            Cmd.Parameters.AddWithValue("@id", id)
            Using rd = Cmd.ExecuteReader()
                If rd.Read() Then
                    Return New Cargo With {
                        .IDCargo = rd.GetInt32("IDCargo"),
                        .NombreCargo = rd.GetString("NombreCargo"),
                        .SueldoBase = rd.GetDecimal("SueldoBase")
                    }
                End If
            End Using
        End Using
        Return Nothing
    End Function

    Public Sub AddCargo(c As Cargo)
        Using conn = dbConn.GetConnection()
            conn.Open()
            Dim Cmd As New MySqlCommand("INSERT INTO cargos (NombreCargo, SueldoBase) VALUES (@c, @s)", conn)
            Cmd.Parameters.AddWithValue("@c", c.NombreCargo)
            Cmd.Parameters.AddWithValue("@s", c.SueldoBase)
            Cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class
