Public Class BonosService
    Private ReadOnly bonoRepo As New BonosRepository()

    Function ObtenerBonos() As List(Of Bono)
        Return bonoRepo.GetAll()
    End Function

    Sub Agregarbono(bono As Bono)
        bonoRepo.AddBono(bono)
    End Sub
End Class
