Public Class TrabajadorConCargo
    Public Property IDTrabajador As Integer
    Public Property Nombre As String
    Public Property NombreCargo As String

    Public ReadOnly Property NombreCompleto As String
        Get
            Return $"{Nombre} - {NombreCargo}"
        End Get
    End Property
End Class
