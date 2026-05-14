Public Class TrabajadoresOtrosService

    Private ReadOnly repository As New TrabajadorOtrosRepository()
    Function GetAll() As List(Of OtroTipo)
        Return repository.GetAll()
    End Function

    Public Sub Guardar(trabajadorOtros As TrabajadorOtros)
        repository.GuardarOtros(trabajadorOtros)
    End Sub
End Class
