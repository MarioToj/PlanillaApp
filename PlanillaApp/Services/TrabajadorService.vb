Public Class TrabajadorService

    Private ReadOnly repo As New TrabajadorRepository()

    Public Function ObtenerTrabajadores() As List(Of Trabajador)
        Return repo.GetAll()
    End Function

End Class
