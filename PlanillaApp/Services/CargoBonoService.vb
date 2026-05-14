Public Class CargoBonoService
    Private ReadOnly cargoBonoRepo As New CargoBonoRepository()

    Public Sub AsignarBono(cB As CargoBono)
        If cB.IDCargo = 0 OrElse cB.IDBono = 0 Then
            Throw New Exception("Seleccione el cargo y el bono")
        End If
        cargoBonoRepo.Asignar(cB)
    End Sub

    Public Function ObtenerBonosPorCargo(idCargo As Integer) As List(Of BonoPorId)
        If idCargo = 0 Then
            Throw New Exception("Seleccione un cargo")
        End If
        Return cargoBonoRepo.ObtenerBonosPorCargo(idCargo)
    End Function
End Class
