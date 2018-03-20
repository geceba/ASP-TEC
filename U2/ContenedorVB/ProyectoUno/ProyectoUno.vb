Module ProyectoUno

    Public Class ProyectoUno
        Sub New()

        End Sub
    End Class

    Dim a, b, c As Int16
    Dim d As Decimal

    'Function SumaDatos(uno As Int16, dos As Int16, tres As Int16) As Decimal
    'Dim resultado As Decimal

    '   resultado = ((uno + dos) / tres)
    'Return (resultado)

    'End Function

    'Sub imprimirRespuesta(respuesta As Decimal)
    'Console.WriteLine("La respuesta es {0}", respuesta)
    'End Sub

    Sub Main()
        Dim MyObject As ProyectoUno()
        Dim aux As New Biblioteca.Biblioteca


        Console.WriteLine("Dar el dato 1:")
        a = Convert.ToInt16(Console.ReadLine())
        Console.WriteLine("Dar el dato 2:")
        b = Convert.ToInt16(Console.ReadLine())
        Console.WriteLine("Dar el dato 3:")
        c = CType(Console.ReadLine, Int16)

        'd = (a + b / c)

        'Console.WriteLine("La respuesta es {0}", d)

        d = aux.SumaDatos(a, b, c)
        aux.imprimirRespuesta(d)

        Console.ReadLine()
    End Sub

End Module
