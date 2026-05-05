Public Class BonosRepository
    Private ReadOnly dbCoonect As New ConnPlanillaDb()

    Function GetAll() As List(Of Bono)
        Dim Lista As New List(Of Bono)
        Using conn = dbCoonect.GetConnection()
            conn.Open()
            Dim Cmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT * from bonos", conn)
            Using rd = Cmd.ExecuteReader()
                While rd.Read()
                    Lista.Add(New Bono With {
                        .IDBono = rd.GetInt32("IDBono"),
                        .NombreBono = rd.GetString("NombreBono"),
                        .Monto = rd.GetDecimal("Monto")
                    })
                End While
            End Using
        End Using
        Return Lista
    End Function
End Class
