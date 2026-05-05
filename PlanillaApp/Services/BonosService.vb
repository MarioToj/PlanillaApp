Public Class BonosService
    Private ReadOnly bonoRepo As New BonosRepository()

    Function ObtenerBonos() As List(Of Bono)
        Return bonoRepo.GetAll()
    End Function
End Class
