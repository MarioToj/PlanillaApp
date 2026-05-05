Public Class FrmBonos

    Private ReadOnly bonoService As New BonosService()
    Private Sub FrmBonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarBonos()
    End Sub

    Function CargarBonos()
        DgvBonos.DataSource = bonoService.ObtenerBonos()
    End Function
End Class