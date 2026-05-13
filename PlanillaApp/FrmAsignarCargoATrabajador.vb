Public Class FrmAsignarCargoATrabajador
    Private ReadOnly cargoService As New CargoService()
    Private ReadOnly trabajadorService As New TrabajadorService()

    Private Sub FrmAsignarCargoATrabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbCargos.DataSource = cargoService.ObtenerCargos()
        CbCargos.DisplayMember = "NombreCargo"
        CbCargos.ValueMember = "IDCargo"
    End Sub

    Private Sub BtnAsignarCargo_Click(sender As Object, e As EventArgs) Handles BtnAsignarCargo.Click
        Try
            trabajadorService.AgregarTrabajador(New Trabajador With {
                .Nombre = TxtNombreTrabajador.Text,
                .IDCargo = CInt(CbCargos.SelectedValue)
            })
            MessageBox.Show("Cargo asignado al trabajador correctamente")
        Catch ex As Exception
            MessageBox.Show("Error al agregar trabajador: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BtnOtrosTipos_Click(sender As Object, e As EventArgs) Handles BtnOtrosTipos.Click
        Me.Hide()
        FrmAsignarOtrosATrabajador.Show()
    End Sub
End Class