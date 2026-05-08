Public Class CargoBonoService
    Private ReadOnly cargoBonoRepo As New CargoBonoRepository()

    Public Sub AsignarBono(cB As CargoBono)
        If cB.IDCargo = 0 OrElse cB.IDBono = 0 Then
            Throw New Exception("Seleccione el cargo y el bono")
        End If
        cargoBonoRepo.Asignar(cB)
    End Sub
End Class
