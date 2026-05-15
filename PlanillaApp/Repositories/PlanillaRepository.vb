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

    Public Function ObtenerTodasPlanillas() As List(Of Planilla)
        Dim planillas As New List(Of Planilla)()
        Using conn = dbPlanilla.GetConnection()
            conn.Open()
            Dim sql = "SELECT * FROM nomina"
            Dim cmd As New MySqlCommand(sql, conn)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    planillas.Add(New Planilla With {
                        .IDPlanilla = reader.GetInt32("IDNomina"),
                        .IDTrabajador = reader.GetInt32("IDTrabajador"),
                        .SueldoBase = reader.GetDecimal("SueldoBase"),
                        .TotalBonos = reader.GetDecimal("TotalBonos"),
                        .TotalIngresos = reader.GetDecimal("TotalIngresos"),
                        .TotalDeducciones = reader.GetDecimal("TotalDeducciones"),
                        .SueldoNeto = reader.GetDecimal("SueldoNeto"),
                        .FechaPago = reader.GetDateTime("FechaPago")
                    })
                End While
            End Using
        End Using
        Return planillas
    End Function

    Public Function ObtenerPlanillaPorId(id As Integer) As Planilla
        Using conn = dbPlanilla.GetConnection()
            conn.Open()
            Dim sql = "SELECT * FROM nomina WHERE IDNomina = @id"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", id)
            Using reader = cmd.ExecuteReader()
                If reader.Read() Then
                    Return New Planilla With {
                        .IDPlanilla = reader.GetInt32("IDNomina"),
                        .IDTrabajador = reader.GetInt32("IDTrabajador"),
                        .SueldoBase = reader.GetDecimal("SueldoBase"),
                        .TotalBonos = reader.GetDecimal("TotalBonos"),
                        .TotalIngresos = reader.GetDecimal("TotalIngresos"),
                        .TotalDeducciones = reader.GetDecimal("TotalDeducciones"),
                        .SueldoNeto = reader.GetDecimal("SueldoNeto"),
                        .FechaPago = reader.GetDateTime("FechaPago")
                    }
                End If
            End Using
        End Using
        Return Nothing
    End Function
End Class
