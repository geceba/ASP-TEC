Public Class ProyectoTres
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim aux As New ProyectoDos.ProyectoDos
        Me.Hide()
        aux.Show()

    End Sub
End Class
