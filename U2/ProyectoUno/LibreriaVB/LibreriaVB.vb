Public Class Class1

    'Declarar el atrubuto
    Private dato As Int16

    'Declarar la propiedad
    Public Property pDato As Int16
        Get
            Return dato
        End Get

        Set(value As Int16)
            dato = value
        End Set
    End Property

    Function PromDatos(ByRef arreglo() As Int16, ByVal ene As Int16) As Decimal
        Dim cuatro As Decimal
        Dim suma, ciclo As Int16

        For ciclo = 0 To ene * 3
            suma += arreglo(ciclo)
        Next
        cuatro = suma / ene * 3
        Return (cuatro)
    End Function

    Sub MuestraRespuesta(ByVal cinco As Decimal)
        Console.WriteLine("La respuesta es {0}", cinco)
        Console.ReadLine()
    End Sub
End Class
