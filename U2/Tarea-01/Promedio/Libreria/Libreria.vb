Public Class Libreria
    'Crear los metodos para hacer los calculo
    Public Function calProm(ByVal valor1 As Int16, ByVal valor2 As Int16, ByVal valor3 As Int16) As Decimal
        Dim respuesta As Decimal
        respuesta = (valor1 + valor2 + valor3) / 3

        Return respuesta
    End Function


    Public Function calPromProm(ByRef array As Decimal(), ByVal cantidad As Int16) As Decimal
        Dim resultado As Decimal = 0, promedioProm As Decimal = 0
        Dim i As Int16

        'Declarar el ciclo for
        For i = 0 To cantidad - 1
            resultado += array(i)
        Next

        promedioProm = resultado / cantidad

        Return promedioProm
    End Function
End Class
