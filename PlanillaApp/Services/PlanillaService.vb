
Public Class PlanillaService
        Private ReadOnly planillaRepository As New PlanillaRepository()

        Public Sub GuardarPlanilla(p As Planilla)
            planillaRepository.Guardar(p)
        End Sub
    End Class

