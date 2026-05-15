Public Class FrmBonos

    Private ReadOnly bonoService As New BonosService()
    Private Sub FrmBonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarBonos()
    End Sub

    Function CargarBonos()
        DgvBonos.DataSource = bonoService.ObtenerBonos()
    End Function

    Private Sub BtnIrAsignacion_Click(sender As Object, e As EventArgs) Handles BtnIrAsignacion.Click
        Me.Hide()
        AsignacionDeBonosACargos.Show()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            bonoService.Agregarbono(New Bono With {
                .NombreBono = TxtNombreBono.Text,
                .Monto = CDec(TxtMontoBono.Text)
            })
            CargarBonos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class