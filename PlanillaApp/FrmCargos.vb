Public Class FrmCargos

    Private ReadOnly trabajadorService As New TrabajadorService
    Private ReadOnly cargoService As New CargoService()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            cargoService.InsertarCargo(New Cargo With {
                .NombreCargo = TxtNombreCargo.Text,
                .SueldoBase = CDec(TxtSueldoBase.Text)
            })
            MostrarDatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub MostrarDatos()
        DgvCargos.DataSource = cargoService.ObtenerCargos()
    End Sub
End Class
