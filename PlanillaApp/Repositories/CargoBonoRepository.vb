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
