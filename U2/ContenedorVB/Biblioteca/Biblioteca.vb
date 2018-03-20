Public Class Biblioteca
    Function SumaDatos(uno As Int16, dos As Int16, tres As Int16) As Decimal
        Dim resultado As Decimal

        resultado = ((uno + dos) / tres)
        Return (resultado)

    End Function

    Sub imprimirRespuesta(respuesta As Decimal)
        Console.WriteLine("La respuesta es {0}", respuesta)
    End Sub
End Class
