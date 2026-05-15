
Public Class PlanillaService
        Private ReadOnly planillaRepository As New PlanillaRepository()

    Public Sub GuardarPlanilla(p As Planilla)
        planillaRepository.Guardar(p)
    End Sub


    Public Function ObtenerTodasPlanillas() As List(Of Planilla)
        Return planillaRepository.ObtenerTodasPlanillas()
    End Function


    Public Function ObtenerPlanillaPorId(id As Integer) As Planilla
        Return planillaRepository.ObtenerPlanillaPorId(id)
    End Function
End Class

