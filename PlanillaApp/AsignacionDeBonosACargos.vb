Public Class AsignacionDeBonosACargos

    Private ReadOnly cargoService As New CargoService()
    Private ReadOnly bonosService As New BonosService()
    Private ReadOnly cargoBonoService As New CargoBonoService()
    Private Sub AsignacionDeBonosACargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbObtenerCargos.DataSource = cargoService.ObtenerCargos()
        CbObtenerCargos.DisplayMember = "NombreCargo"
        CbObtenerCargos.ValueMember = "IDCargo"

        CbObtenerBonos.DataSource = bonosService.ObtenerBonos()
        CbObtenerBonos.DisplayMember = "NombreBono"
        CbObtenerBonos.ValueMember = "IDBono"
    End Sub

    Private Sub BtnAsignarBono_Click(sender As Object, e As EventArgs) Handles BtnAsignarBono.Click
        Try
            cargoBonoService.AsignarBono(New CargoBono With {
                .IDCargo = CInt(CbObtenerCargos.SelectedValue),
                .IDBono = CInt(CbObtenerBonos.SelectedValue)
            })
            MessageBox.Show("Bono asignado al cargo correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Function ObtenerCargos() As List(Of Cargo)
        Return cargoService.ObtenerCargos()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAsignarCargos.Click
        Me.Hide()
        FrmAsignarCargoATrabajador.Show()
    End Sub
End Class