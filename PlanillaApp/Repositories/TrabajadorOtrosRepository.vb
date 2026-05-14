Imports MySql.Data.MySqlClient

Public Class TrabajadorOtrosRepository

    Private ReadOnly dbConnect As New ConnPlanillaDb()

    Function GetAll() As List(Of OtroTipo)
        Dim Lista As New List(Of OtroTipo)
        Using conn = dbConnect.GetConnection()
            conn.Open()
            Dim Cmd As New MySqlCommand("SELECT * from otros_tipos", conn)
            Using rd = Cmd.ExecuteReader()
                While rd.Read()
                    Lista.Add(New OtroTipo With {
                        .IDOtroTipo = rd.GetInt32("IDOtroTipo"),
                        .NombreOtro = rd.GetString("NombreOtro"),
                        .EsIngreso = rd.GetBoolean("EsIngreso"),
                        .TipoCalculo = rd.GetString("TipoCalculo"),
                        .ValorBase = rd.GetDecimal("ValorBase")
                    })
                End While
            End Using
        End Using
        Return Lista
    End Function

    Public Sub GuardarOtros(trabajadorOtros As TrabajadorOtros)
        Dim query As String = "
            Insert into trabajador_otros (IDTrabajador, IDOtroTipo, Monto) 
            values (@IDTrabajador, @IDOtroTipo, @Monto)
            on duplicate key update Monto = @Monto;"

        Using conn = dbConnect.GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IDTrabajador", trabajadorOtros.IDTrabajador)
                cmd.Parameters.AddWithValue("@IDOtroTipo", trabajadorOtros.IDOtroTipo)
                cmd.Parameters.AddWithValue("@Monto", trabajadorOtros.Monto)
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub
End Class
