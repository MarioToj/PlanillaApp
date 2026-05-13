Public Class FrmAsignarOtrosATrabajador

    Private por_hora As Decimal
    Private ReadOnly por_dia As Decimal
    Private ReadOnly fijo As Double
    Private ReadOnly porcentaje As Decimal

    Private ReadOnly trabajadorOtroService As New TrabajadoresOtrosService()
    Private ReadOnly trabajadorService As New TrabajadorService()
    Private ReadOnly cargoService As New CargoService()
    Private Sub FrmAsignarOtrosATrabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClbOtrosTipos.DataSource = trabajadorOtroService.GetAll()
        ClbOtrosTipos.DisplayMember = "NombreOtro"
        ClbOtrosTipos.ValueMember = "IDOtroTipo"

        CbTrabajadores.DataSource = trabajadorService.TrabajadoresConCargos()
        CbTrabajadores.DisplayMember = "NombreCompleto"
        CbTrabajadores.ValueMember = "IDTrabajador"

    End Sub
    Private Function CalcularHoraExtra(idTrabajador As Integer) As Decimal
        Dim trabajador = trabajadorService.ObtenerTrabajadorPorId(idTrabajador)
        Dim sueldo = cargoService.ObtenerCargoPorId(trabajador.IDCargo).SueldoBase
        Return ((sueldo / 30) / 8) * 1.5
    End Function

End Class