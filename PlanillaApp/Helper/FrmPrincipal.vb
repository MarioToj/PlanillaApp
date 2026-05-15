Public Class FrmPrincipal

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CargarForm(frm As Form)
        For Each f As Form In PanelContenedor.Controls.OfType(Of Form)()
            f.Close()
        Next
        PanelContenedor.Controls.Clear()

        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(frm)
        frm.Show()
    End Sub

    ' 1 ── Cargos y Bonos ──────────────────────────────────
    Private Sub MenuCargos_Click(sender As Object, e As EventArgs) Handles MenuCargos.Click
        CargarForm(New FrmCargos())
    End Sub

    Private Sub MenuBonos_Click(sender As Object, e As EventArgs) Handles MenuBonos.Click
        CargarForm(New FrmBonos())
    End Sub

    ' 2 ── Relación Cargo-Bono ─────────────────────────────
    Private Sub MenuCargoBonos_Click(sender As Object, e As EventArgs) Handles MenuCargoBonos.Click
        CargarForm(New AsignacionDeBonosACargos())
    End Sub

    ' 3 ── Trabajadores ────────────────────────────────────
    Private Sub MenuTrabajadores_Click(sender As Object, e As EventArgs) Handles MenuTrabajadores.Click
        CargarForm(New FrmAsignarCargoATrabajador())
    End Sub

    ' 4 ── Asignación de Otros ─────────────────────────────
    Private Sub MenuAsignarOtros_Click(sender As Object, e As EventArgs) Handles MenuAsignarOtros.Click
        CargarForm(New FrmAsignarOtrosATrabajador())
    End Sub

    ' 5 ── Planilla ────────────────────────────────────────
    Private Sub MenuPlanilla_Click(sender As Object, e As EventArgs) Handles MenuPlanilla.Click
        CargarForm(New FrmPlanillasList())
    End Sub

End Class