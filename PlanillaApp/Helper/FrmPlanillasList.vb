Imports System.Threading

Public Class FrmPlanillasList
    Private ReadOnly planillaService As New PlanillaService()
    Private trabajadorService As New TrabajadorService()
    Private WithEvents PdPlanilla As New Printing.PrintDocument()
    Private WithEvents PdCheque As New Printing.PrintDocument()
    Private planillaActual As Planilla

    Private Sub FrmListadoPlanillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DgvPlanillas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvPlanillas.AutoGenerateColumns = False


        DgvPlanillas.Columns.Clear()

        DgvPlanillas.Columns.Add(New DataGridViewTextBoxColumn With {.Name = "IDNomina", .HeaderText = "ID", .DataPropertyName = "IDPlanilla"})
        DgvPlanillas.Columns.Add(New DataGridViewTextBoxColumn With {.Name = "IDTrabajador", .HeaderText = "ID Trabajador", .DataPropertyName = "IDTrabajador"})
        DgvPlanillas.Columns.Add(New DataGridViewTextBoxColumn With {.Name = "SueldoBase", .HeaderText = "Sueldo Base", .DataPropertyName = "SueldoBase"})
        DgvPlanillas.Columns.Add(New DataGridViewTextBoxColumn With {.Name = "TotalBonos", .HeaderText = "Total Bonos", .DataPropertyName = "TotalBonos"})
        DgvPlanillas.Columns.Add(New DataGridViewTextBoxColumn With {.Name = "TotalIngresos", .HeaderText = "Total Ingresos", .DataPropertyName = "TotalIngresos"})
        DgvPlanillas.Columns.Add(New DataGridViewTextBoxColumn With {.Name = "TotalDeducciones", .HeaderText = "Deducciones", .DataPropertyName = "TotalDeducciones"})
        DgvPlanillas.Columns.Add(New DataGridViewTextBoxColumn With {.Name = "SueldoNeto", .HeaderText = "Sueldo Neto", .DataPropertyName = "SueldoNeto"})
        DgvPlanillas.Columns.Add(New DataGridViewTextBoxColumn With {.Name = "FechaPago", .HeaderText = "Fecha Pago", .DataPropertyName = "FechaPago"})

        Dim btnPlanilla As New DataGridViewButtonColumn With {
        .Name = "BtnImprimirPlanilla", .HeaderText = "Planilla",
        .Text = "Imprimir", .UseColumnTextForButtonValue = True}
        DgvPlanillas.Columns.Add(btnPlanilla)

        Dim btnCheque As New DataGridViewButtonColumn With {
        .Name = "BtnImprimirCheque", .HeaderText = "Cheque",
        .Text = "Imprimir", .UseColumnTextForButtonValue = True}
        DgvPlanillas.Columns.Add(btnCheque)

        DgvPlanillas.DataSource = planillaService.ObtenerTodasPlanillas()
    End Sub


    Private Sub DgvPlanillas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPlanillas.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim celdaId = DgvPlanillas.Rows(e.RowIndex).Cells("IDNomina").Value
        If celdaId Is Nothing Then Return

        Dim idNomina As Integer = CInt(celdaId)
        planillaActual = planillaService.ObtenerPlanillaPorId(idNomina)

        If planillaActual Is Nothing Then
            MessageBox.Show("No se encontró la planilla.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If DgvPlanillas.Columns(e.ColumnIndex).Name = "BtnImprimirPlanilla" Then
            PdPlanilla.Print()
        End If

        If DgvPlanillas.Columns(e.ColumnIndex).Name = "BtnImprimirCheque" Then
            PdCheque.Print()
        End If
    End Sub

    Private Sub PdPlanilla_PrintPage(sender As Object,
        e As Printing.PrintPageEventArgs) Handles PdPlanilla.PrintPage

        If planillaActual Is Nothing Then Return

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

        Dim trabajador = trabajadorService.ObtenerTrabajadorPorId(planillaActual.IDTrabajador)

        g.DrawString("PLANILLA DE SUELDOS", fT, negro, 170, y) : y += 22
        g.DrawString($"Fecha: {planillaActual.FechaPago:dd/MM/yyyy}", fN, gris, izq, y) : y += 18
        g.DrawLine(Pens.Black, izq, y, der, y) : y += 12

        g.DrawString("EMPLEADO", fS, negro, izq, y) : y += 18
        g.DrawString($"Nombre : {trabajador.Nombre}", fN, negro, izq, y) : y += 16
        g.DrawLine(Pens.LightGray, izq, y, der, y) : y += 12

        g.DrawString("SUELDO BASE", fS, negro, izq, y)
        g.DrawString($"Q {planillaActual.SueldoBase:N2}", fN, negro, col, y) : y += 20
        g.DrawLine(Pens.LightGray, izq, y, der, y) : y += 12

        g.DrawString("INGRESOS", fS, verde, izq, y) : y += 18

        g.DrawString("  Bonos", fN, negro, izq, y)
        g.DrawString($"+ Q {planillaActual.TotalBonos:N2}", fN, verde, col, y) : y += 16

        g.DrawString("  Otros ingresos", fN, negro, izq, y)
        g.DrawString($"+ Q {planillaActual.TotalIngresos:N2}", fN, verde, col, y) : y += 16

        g.DrawLine(Pens.LightGray, izq, y, der, y) : y += 12

        g.DrawString("DEDUCCIONES", fS, rojo, izq, y) : y += 18

        If planillaActual.TotalDeducciones > 0 Then
            g.DrawString("  Total deducciones", fN, negro, izq, y)
            g.DrawString($"- Q {planillaActual.TotalDeducciones:N2}", fN, rojo, col, y) : y += 16
        Else
            g.DrawString("  Sin deducciones", fN, gris, izq, y) : y += 16
        End If

        g.DrawLine(Pens.Black, izq, y, der, y) : y += 12

        g.DrawString("SUELDO LÍQUIDO", fL, negro, izq, y)
        g.DrawString($"Q {planillaActual.SueldoNeto:N2}", fL, negro, col - 20, y) : y += 30
        g.DrawLine(Pens.Black, izq, y, der, y)

        e.HasMorePages = False
    End Sub

    Private Sub PdCheque_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PdCheque.PrintPage

        If planillaActual Is Nothing Then Return

        Dim trabajador = trabajadorService.ObtenerTrabajadorPorId(planillaActual.IDTrabajador)
        If trabajador Is Nothing Then
            MessageBox.Show("No se encontró el trabajador.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim g = e.Graphics
        Dim fNormal = New Font("Courier New", 11)
        Dim fMonto = New Font("Courier New", 13, FontStyle.Bold)
        Dim negro = Brushes.Black

        Dim xFecha = 150, yFecha = 70
        Dim xNombre = 150, yNombre = 95
        Dim xMontoNum = 600, yMontoNum = 60
        Dim xMontoLetras = 120, yMontoLetras = 120

        g.DrawString("Santa Cruz del Quiché, Quiché, " & planillaActual.FechaPago.ToString("dd/MM/yyyy"), fNormal, negro, xFecha, yFecha)

        g.DrawString(trabajador.Nombre, fNormal, negro, xNombre, yNombre)

        g.DrawString("Q " & planillaActual.SueldoNeto.ToString("N2"), fMonto, negro, xMontoNum, yMontoNum)

        g.DrawString(NumeroALetras.Convertir(planillaActual.SueldoNeto), fNormal, negro, xMontoLetras, yMontoLetras)

        e.HasMorePages = False
    End Sub
End Class