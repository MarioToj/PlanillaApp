Public Class CargoService
    Private ReadOnly repo As New CargoRepository()

    Public Function ObtenerCargos() As List(Of Cargo)
        Return repo.GetAll()
    End Function

    Public Sub InsertarCargo(c As Cargo)
        If String.IsNullOrWhiteSpace(c.NombreCargo) Then
            Throw New Exception("El nombre es requerido")
        End If
        If c.SueldoBase <= 0 Then
            Throw New Exception("El valor es requerido")
        End If
        repo.AddCargo(c)
    End Sub

    Function ObtenerCargoPorId(id As Integer) As Cargo
        Return repo.GetById(id)
    End Function
End Class
