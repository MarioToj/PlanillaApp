Imports MySql.Data.MySqlClient

Public Class CargoBonoRepository
    Private ReadOnly dbCoonect As New ConnPlanillaDb()

    Public Sub Asignar(cB As CargoBono)
        Using conn = dbCoonect.GetConnection()
            conn.Open()

            Using cmd As New MySqlCommand("INSERT IGNORE INTO cargo_bonos (IDCargo, IDBono) VALUES (@c, @b)", conn)
                cmd.Parameters.AddWithValue("@c", cB.IDCargo)
                cmd.Parameters.AddWithValue("@b", cB.IDBono)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function ObtenerBonosPorCargo(idCargo As Integer) As List(Of BonoPorId)

        Dim bonos As New List(Of BonoPorId)()
        Dim query As String = "
            SELECT b.IDBono, b.NombreBono, b.Monto
            FROM cargo_bonos cb
            JOIN bonos b ON cb.IDBono = b.IDBono
            WHERE cb.IDCargo = @idCargo;
        "

        Using conn = dbCoonect.GetConnection()
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@idCargo", idCargo)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        bonos.Add(New BonoPorId() With {
                            .IDBono = reader.GetInt32("IDBono"),
                            .NombreBono = reader.GetString("NombreBono"),
                            .Monto = reader.GetDecimal("Monto")
                        })

                    End While
                End Using
            End Using
        End Using
        Return bonos
    End Function

    Public Sub Quitar(cB As CargoBono)
        Using conn = dbCoonect.GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand(
                "DELETE FROM cargo_bonos WHERE IDCargo=@c AND IDBono=@b", conn)
            cmd.Parameters.AddWithValue("@c", cB.IDCargo)
            cmd.Parameters.AddWithValue("@b", cB.IDBono)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class
