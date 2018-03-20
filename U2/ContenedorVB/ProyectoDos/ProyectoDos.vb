Public Class ProyectoDos

    Dim a, b, c As Int16
    Dim d As Decimal
    Dim aux As New Biblioteca.Biblioteca


    Private Sub txtDato1_TextChanged(sender As Object, e As EventArgs) Handles txtDato1.TextChanged
        a = Convert.ToInt16(txtDato1.Text)
    End Sub

    Private Sub txtDato2_TextChanged(sender As Object, e As EventArgs) Handles txtDato2.TextChanged
        b = Convert.ToInt16(txtDato2.Text)
    End Sub

    Private Sub txtDato3_TextChanged(sender As Object, e As EventArgs) Handles txtDato3.TextChanged
        c = Convert.ToInt16(txtDato3.Text)
    End Sub

    Private Sub btnIr_Click(sender As Object, e As EventArgs) Handles btnIr.Click
        Dim objTres As New ProyectoTres.ProyectoTres()
        Me.Hide()
        objTres.Show()

    End Sub

    Private Sub txtDato4_TextChanged(sender As Object, e As EventArgs) Handles txtDato4.TextChanged
        txtDato4.Enabled = False
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'd = ((a + b) / c)
        d = aux.SumaDatos(a, b, c)
        txtDato4.Text = CType(d, String)
    End Sub
End Class
