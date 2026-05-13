Public Class TrabajadoresOtrosService

    Private ReadOnly repository As New TrabajadorOtrosRepository()
    Function GetAll() As List(Of OtroTipo)
        Return repository.GetAll()
    End Function
End Class
