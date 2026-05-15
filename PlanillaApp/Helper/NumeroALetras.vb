Public Class NumeroALetras

    Public Shared Function Convertir(valor As Decimal) As String
        Dim entero As Long = Math.Truncate(valor)
        Dim decimales As Integer = CInt((valor - entero) * 100)

        Dim textoEntero As String = ConvertirNumero(entero)
        Dim textoDecimales As String = ""

        If decimales > 0 Then
            textoDecimales = " con " & ConvertirNumero(decimales) & " centavos"
        End If

        Return textoEntero & " quetzales" & textoDecimales
    End Function

    Private Shared Function ConvertirNumero(numero As Long) As String
        Dim unidades() As String = {"", "uno", "dos", "tres", "cuatro", "cinco",
                                    "seis", "siete", "ocho", "nueve", "diez",
                                    "once", "doce", "trece", "catorce", "quince",
                                    "dieciséis", "diecisiete", "dieciocho", "diecinueve"}
        Dim decenas() As String = {"", "diez", "veinte", "treinta", "cuarenta",
                                   "cincuenta", "sesenta", "setenta", "ochenta", "noventa"}
        Dim centenas() As String = {"", "cien", "doscientos", "trescientos", "cuatrocientos",
                                    "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos"}

        If numero = 0 Then Return "cero"
        If numero < 20 Then Return unidades(numero)

        ' 🔹 Caso especial: 21–29 → "veintiuno", "veintidós", etc.
        If numero >= 21 AndAlso numero <= 29 Then
            Return "veinti" & unidades(numero Mod 10)
        End If

        If numero < 100 Then
            Dim d As Integer = numero \ 10
            Dim u As Integer = numero Mod 10
            If u = 0 Then
                Return decenas(d)
            Else
                Return decenas(d) & " y " & unidades(u)
            End If
        End If

        If numero < 1000 Then
            Dim c As Integer = numero \ 100
            Dim resto As Integer = numero Mod 100
            If resto = 0 Then
                Return centenas(c)
            Else
                Return centenas(c) & " " & ConvertirNumero(resto)
            End If
        End If

        If numero < 1000000 Then
            Dim miles As Integer = numero \ 1000
            Dim resto As Integer = numero Mod 1000
            Dim textoMiles As String = If(miles = 1, "mil", ConvertirNumero(miles) & " mil")
            If resto = 0 Then
                Return textoMiles
            Else
                Return textoMiles & " " & ConvertirNumero(resto)
            End If
        End If

        Return numero.ToString()
    End Function

End Class
