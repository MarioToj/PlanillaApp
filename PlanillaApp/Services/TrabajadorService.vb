Public Class TrabajadorService

    Private ReadOnly trabajadorRepository As New TrabajadorRepository()
    Private ReadOnly cargoRepository As New CargoRepository()

    Public Function ObtenerTrabajadores() As List(Of Trabajador)
        Return trabajadorRepository.GetAll()
    End Function

    Public Sub AgregarTrabajador(trabajador As Trabajador)
        If String.IsNullOrWhiteSpace(trabajador.Nombre) Then
            Throw New Exception("El nombre del trabajador no puede estar vacío.")
        End If
        If trabajador.IDCargo <= 0 Then
            Throw New Exception("El ID del cargo del trabajador no puede ser menor o igual a cero.")
        End If
        trabajadorRepository.Add(trabajador)
    End Sub

    Function TrabajadoresConCargos() As List(Of TrabajadorConCargo)
        Dim resultado As New List(Of TrabajadorConCargo)()
        For Each t In ObtenerTrabajadores()
            Dim cargo = cargoRepository.GetById(t.IDCargo)
            If cargo IsNot Nothing Then
                resultado.Add(New TrabajadorConCargo With {
                    .IDTrabajador = t.IDTrabajador,
                    .Nombre = t.Nombre,
                    .NombreCargo = cargo.NombreCargo
                })
            End If
        Next
        Return resultado
    End Function

    Function ObtenerTrabajadorPorId(id As Integer) As Trabajador
        Return trabajadorRepository.GetById(id)
    End Function
End Class
