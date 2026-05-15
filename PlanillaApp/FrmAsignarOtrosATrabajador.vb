Public Class FrmAsignarOtrosATrabajador

    Public porHora As Decimal
    Public porDia As Decimal
    Public fijo As Double
    Public porcentajeSueldo As Decimal
    Public totalBonos As Decimal
    Public totalOtros As Decimal
    Public sueldoActual As Decimal
    Public totalDeducciones As Decimal
    Public monto As Decimal
    Public montoEnLetras As String

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

    Private Sub BtnImprimirPlanilla_Click(sender As Object, e As EventArgs) Handles BtnImprimirPlanilla.Click
        If monto = 0 Then
            MessageBox.Show("Primero calcula la planilla.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        PdPlanilla.Print()
    End Sub

    Private Sub BtnImprimirCheque_Click(sender As Object, e As EventArgs) Handles BtnImprimirCheque.Click
        If monto = 0 Then
            MessageBox.Show("Primero calcula la planilla.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        PdCheque.Print()
    End Sub

    Private Sub PdPlanilla_PrintPage(sender As Object,
            e As Printing.PrintPageEventArgs) Handles PdPlanilla.PrintPage

        Dim g = e.Graphics
        Dim fT = New Font("Arial", 13, FontStyle.Bold)
        Dim fS = New Font("Arial", 10, FontStyle.Bold)
        Dim fN = New Font("Arial", 9)
        Dim fL = New Font("Arial", 11, FontStyle.Bold)
        Dim negro = Brushes.Black
        Dim gris = Brushes.Gray
        Dim verde = Brushes.DarkGreen
        Dim rojo = Brushes.DarkRed
        Dim izq = 30
        Dim der = 780
        Dim col = 600
        Dim y = 30

        Dim nombreTrabajador = CbTrabajadores.Text
        Dim idTrabajador = CInt(CbTrabajadores.SelectedValue)
        Dim trabajador = trabajadorService.ObtenerTrabajadorPorId(idTrabajador)
        Dim cargo = cargoService.ObtenerCargoPorId(trabajador.IDCargo)

        g.DrawString("PLANILLA DE SUELDOS", fT, negro, 170, y) : y += 22
        g.DrawString($"Fecha: {Date.Today:dd/MM/yyyy}", fN, gris, izq, y) : y += 18
        g.DrawLine(Pens.Black, izq, y, der, y) : y += 12

        g.DrawString("EMPLEADO", fS, negro, izq, y) : y += 18
        g.DrawString($"Nombre : {nombreTrabajador}", fN, negro, izq, y) : y += 16
        g.DrawString($"Cargo  : {cargo.NombreCargo}", fN, negro, izq, y) : y += 16
        g.DrawLine(Pens.LightGray, izq, y, der, y) : y += 12

        g.DrawString("SUELDO BASE", fS, negro, izq, y)
        g.DrawString($"Q {sueldoActual:N2}", fN, negro, col, y) : y += 20
        g.DrawLine(Pens.LightGray, izq, y, der, y) : y += 12

        g.DrawString("INGRESOS", fS, verde, izq, y) : y += 18

        If totalBonos > 0 Then
            g.DrawString("  Bonos de cargo", fN, negro, izq, y)
            g.DrawString($"+ Q {totalBonos:N2}", fN, verde, col, y) : y += 16
            For Each item As BonoPorId In ClbCargoBonos.CheckedItems
                g.DrawString($"     · {item.NombreBono}", fN, gris, izq, y)
                g.DrawString($"Q {item.Monto:N2}", fN, gris, 430, y) : y += 14
            Next
        End If

        If totalOtros > 0 Then
            g.DrawString("  Otros ingresos", fN, negro, izq, y)
            g.DrawString($"+ Q {totalOtros:N2}", fN, verde, col, y) : y += 16
            If ChkPorHora.Checked Then
                g.DrawString($"     · Horas extra: ((sueldo/30)/8) * 1.5", fN, gris, izq, y)
                g.DrawString($"Q {porHora:N2}", fN, gris, 430, y) : y += 14
            End If
            If ChkPorDia.Checked Then
                g.DrawString($"     · Viáticos: Q.120.00/d ({NuDias.Value} días)", fN, gris, izq, y)
                g.DrawString($"Q {porDia:N2}", fN, gris, 430, y) : y += 14
            End If
        End If

        g.DrawLine(Pens.LightGray, izq, y, der, y) : y += 12

        g.DrawString("DEDUCCIONES", fS, rojo, izq, y) : y += 18

        If totalDeducciones > 0 Then
            g.DrawString("  Total deducciones", fN, negro, izq, y)
            g.DrawString($"- Q {totalDeducciones:N2}", fN, rojo, col, y) : y += 16
            If ChkFijo.Checked Then
                g.DrawString("     · Seguro médico", fN, gris, izq, y)
                g.DrawString($"Q {fijo:N2}", fN, gris, 430, y) : y += 14
            End If
            If ChkPorcentajeSueldo.Checked Then
                g.DrawString("     · Préstamo (10%)", fN, gris, izq, y)
                g.DrawString($"Q {porcentajeSueldo:N2}", fN, gris, 430, y) : y += 14
            End If
        Else
            g.DrawString("  Sin deducciones", fN, gris, izq, y) : y += 16
        End If

        g.DrawLine(Pens.Black, izq, y, der, y) : y += 12

        g.DrawString("SUELDO LÍQUIDO", fL, negro, izq, y)
        g.DrawString($"Q {monto:N2}", fL, negro, col - 20, y) : y += 30

        g.DrawLine(Pens.Black, izq, y, der, y)

        e.HasMorePages = False
    End Sub

    Private Sub PdCheque_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PdCheque.PrintPage
        Dim g = e.Graphics
        Dim fNormal = New Font("Courier New", 11)
        Dim fMonto = New Font("Courier New", 13, FontStyle.Bold)

        Dim negro = Brushes.Black

        Dim xFecha = 150
        Dim yFecha = 70

        Dim xNombre = 150
        Dim yNombre = 95

        Dim xMontoNum = 600
        Dim yMontoNum = 60

        Dim xMontoLetras = 120
        Dim yMontoLetras = 120

        Dim nombreTrabajador = CbTrabajadores.Text
        Dim montoLiquido = monto
        Dim letras As String = NumeroALetras.Convertir(monto)

        g.DrawString("Santa Cruz del Quiché, Quiché, " & Date.Today.ToString("dd/MM/yyyy"), fNormal, negro, xFecha, yFecha)

        g.DrawString(nombreTrabajador, fNormal, negro, xNombre, yNombre)

        g.DrawString("Q " & montoLiquido.ToString("N2"), fMonto, negro, xMontoNum, yMontoNum)

        g.DrawString(letras, fNormal, negro, xMontoLetras, yMontoLetras)

        e.HasMorePages = False
    End Sub

    Private Sub BtnListPlanitllas_Click(sender As Object, e As EventArgs) Handles BtnListPlanitllas.Click
        Me.Hide()
        FrmPlanillasList.Show()
    End Sub
End Class
