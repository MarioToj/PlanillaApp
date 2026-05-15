Imports MySql.Data.MySqlClient

Public Class PlanillaRepository

    Private ReadOnly dbPlanilla As New ConnPlanillaDb()
    Public Sub Guardar(n As Planilla)
        Using conn = dbPlanilla.GetConnection()
            conn.Open()
            Dim sql = "INSERT INTO nomina
                       (IDTrabajador, SueldoBase, TotalBonos,
                        TotalIngresos, TotalDeducciones, SueldoNeto, FechaPago)
                   VALUES (@t, @sb, @b, @i, @d, @n, @f)
                   ON DUPLICATE KEY UPDATE
                       SueldoBase       = @sb,
                       TotalBonos       = @b,
                       TotalIngresos    = @i,
                       TotalDeducciones = @d,
                       SueldoNeto       = @n,
                       FechaPago        = @f"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@t", n.IDTrabajador)
            cmd.Parameters.AddWithValue("@sb", n.SueldoBase)
            cmd.Parameters.AddWithValue("@b", n.TotalBonos)
            cmd.Parameters.AddWithValue("@i", n.TotalIngresos)
            cmd.Parameters.AddWithValue("@d", n.TotalDeducciones)
            cmd.Parameters.AddWithValue("@n", n.SueldoNeto)
            cmd.Parameters.AddWithValue("@f", n.FechaPago)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class
