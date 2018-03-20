Public Class LibreriaVB2
    Inherits LibreriaVB.Class1
    'Declarar el atrubuto
    Private dato2 As Int16

    'Declarar la propiedad
    Public Property pDato2 As Int16
        Get
            Return dato2
        End Get

        Set(value As Int16)
            dato2 = value
        End Set
    End Property


    Function PromDatos2(ByRef arreglo() As Int16, ByVal ene As Int16) As Decimal
        Dim cuatro As Decimal
        Dim suma, ciclo As Int16

        For ciclo = 0 To ene * 3
            suma += arreglo(ciclo)
        Next
        cuatro = suma / ene * 3 + pDato

        Return (cuatro)
    End Function
End Class
