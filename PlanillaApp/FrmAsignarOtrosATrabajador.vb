Public Class FrmAsignarOtrosATrabajador

    Private porHora As Decimal
    Private porDia As Decimal
    Private fijo As Double
    Private porcentajeSueldo As Decimal
    Private totalBonos As Decimal
    Private totalOtros As Decimal
    Private sueldoActual As Decimal
    Private totalDeducciones As Decimal
    Private monto As Decimal

    Private ReadOnly trabajadorService As New TrabajadorService()
    Private ReadOnly cargoService As New CargoService()
    Private ReadOnly cargoBonoService As New CargoBonoService()
    Private ReadOnly trabajadorOtrosService As New TrabajadoresOtrosService()
    Private ReadOnly planillaService As New PlanillaService()

    Private Sub FrmAsignarOtrosATrabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbTrabajadores.DataSource = trabajadorService.TrabajadoresConCargos()
        CbTrabajadores.DisplayMember = "NombreCompleto"
        CbTrabajadores.ValueMember = "IDTrabajador"

        If CbTrabajadores.Items.Count > 0 Then
            CbTrabajadores.SelectedIndex = 0
            CargarSueldoInicial()
            CargarCargosBono()
        End If
    End Sub

    Private Sub CargarSueldoInicial()
        If CbTrabajadores.SelectedValue Is Nothing OrElse Not IsNumeric(CbTrabajadores.SelectedValue) Then Exit Sub

        Dim idTrabajador As Integer = CInt(CbTrabajadores.SelectedValue)
        Dim trabajador = trabajadorService.ObtenerTrabajadorPorId(idTrabajador)
        sueldoActual = cargoService.ObtenerCargoPorId(trabajador.IDCargo).SueldoBase

        LblSueldo.Text = "Q." & sueldoActual.ToString("N2")
    End Sub

    Private Sub CargarCargosBono()
        If CbTrabajadores.SelectedValue Is Nothing OrElse Not IsNumeric(CbTrabajadores.SelectedValue) Then Exit Sub
        Dim idTrabajador As Integer = CInt(CbTrabajadores.SelectedValue)
        Dim trabajador = trabajadorService.ObtenerTrabajadorPorId(idTrabajador)

        Dim bonos = cargoBonoService.ObtenerBonosPorCargo(trabajador.IDCargo)
        ClbCargoBonos.DataSource = bonos
        ClbCargoBonos.DisplayMember = "NombreBono"
        ClbCargoBonos.ValueMember = "IDBono"
        ClbCargoBonos.CheckOnClick = True
    End Sub

    Private Sub CalcularBonos()
        totalBonos = 0
        For Each item As BonoPorId In ClbCargoBonos.CheckedItems
            totalBonos += item.Monto
        Next
        LblTotalBonos.Text = totalBonos.ToString("N2")
    End Sub

    Private Sub ActualizarOtros()
        porHora = 0
        porDia = 0
        fijo = 0
        porcentajeSueldo = 0

        If ChkPorHora.Checked Then
            Dim horaNormal = (sueldoActual / 30) / 8
            Dim horaExtra = horaNormal * 1.5
            porHora = horaExtra * NuDHoras.Value
        End If

        If ChkPorDia.Checked Then
            porDia = 120 * NuDias.Value
        End If

        If ChkFijo.Checked Then
            fijo = 200
        End If

        If ChkPorcentajeSueldo.Checked Then
            porcentajeSueldo = sueldoActual * 0.1D
        End If

        LblPorHora.Text = porHora.ToString("N2")
        LblPorDia.Text = porDia.ToString("N2")
        LblFijo.Text = fijo.ToString("N2")
        LblPorcentajeSueldo.Text = porcentajeSueldo.ToString("N2")

        totalOtros = porHora + porDia
        totalDeducciones = fijo + porcentajeSueldo
        LblTotal.Text = totalOtros.ToString("N2")
        LblDeducciones.Text = totalDeducciones.ToString("N2")
    End Sub

    Private Sub BtnCalcularTotal_Click(sender As Object, e As EventArgs) Handles BtnCalcularTotal.Click


        monto = sueldoActual + totalBonos + totalOtros - totalDeducciones
        LblMonto.Text = "Q." & monto.ToString("N2")
    End Sub
    Private Sub BtnGenerarPlanilla_Click(sender As Object, e As EventArgs) Handles BtnGenerarPlanilla.Click
        If CbTrabajadores.SelectedValue Is Nothing OrElse
       Not IsNumeric(CbTrabajadores.SelectedValue) Then Exit Sub

        Dim idTrabajador As Integer = CInt(CbTrabajadores.SelectedValue)

        Try
            ' guardar otros_tipos — solo los que aplican
            If ChkPorHora.Checked Then
                trabajadorOtrosService.Guardar(New TrabajadorOtros With {
                .IDTrabajador = idTrabajador, .IDOtroTipo = 1, .Monto = porHora})
            End If

            If ChkPorDia.Checked Then
                trabajadorOtrosService.Guardar(New TrabajadorOtros With {
                .IDTrabajador = idTrabajador, .IDOtroTipo = 2, .Monto = porDia})
            End If

            If ChkFijo.Checked Then
                trabajadorOtrosService.Guardar(New TrabajadorOtros With {
                .IDTrabajador = idTrabajador, .IDOtroTipo = 3, .Monto = fijo})
            End If

            If ChkPorcentajeSueldo.Checked Then
                trabajadorOtrosService.Guardar(New TrabajadorOtros With {
                .IDTrabajador = idTrabajador, .IDOtroTipo = 4, .Monto = porcentajeSueldo})
            End If

            ' guardar planilla
            Dim planilla As New Planilla With {
            .IDTrabajador = idTrabajador,
            .SueldoBase = sueldoActual,
            .TotalBonos = totalBonos,
            .TotalIngresos = totalOtros,
            .TotalDeducciones = totalDeducciones,
            .SueldoNeto = monto,
            .FechaPago = Date.Today
        }

            planillaService.GuardarPlanilla(planilla)
            MessageBox.Show("Planilla guardada correctamente.", "Listo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChkPorHora_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPorHora.CheckedChanged
        ActualizarOtros()
    End Sub

    Private Sub ChkPorDia_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPorDia.CheckedChanged
        ActualizarOtros()
    End Sub

    Private Sub ChkFijo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFijo.CheckedChanged
        ActualizarOtros()
    End Sub

    Private Sub ChkPorcentajeSueldo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPorcentajeSueldo.CheckedChanged
        ActualizarOtros()
    End Sub

    Private Sub NuDHoras_ValueChanged(sender As Object, e As EventArgs) Handles NuDHoras.ValueChanged
        ActualizarOtros()
    End Sub

    Private Sub NuDias_ValueChanged(sender As Object, e As EventArgs) Handles NuDias.ValueChanged
        ActualizarOtros()
    End Sub

    Private Sub ClbCargoBonos_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ClbCargoBonos.ItemCheck
        Me.BeginInvoke(New Action(AddressOf CalcularBonos))
    End Sub

    Private Sub CbTrabajadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTrabajadores.SelectedIndexChanged
        CargarSueldoInicial()
        CargarCargosBono()
    End Sub

End Class
