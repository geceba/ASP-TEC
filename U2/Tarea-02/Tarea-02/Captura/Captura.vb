Public Class Captura
    Dim datos As Int16() = New Int16(2) {}   ' asi se declara un arreglo
    Dim valor1 As Int16
    Dim valor2 As Int16
    Dim valor3 As Int16

    Dim obj As Tarea_02.Menu = New Tarea_02.Menu()

    Private Sub txtValor_1_TextChanged(sender As Object, e As EventArgs) Handles txtValor_1.TextChanged
        If txtValor_1.Text <> "" Then
            valor1 = Convert.ToInt16(txtValor_1.Text)
        End If

    End Sub

    Private Sub txtValor_2_TextChanged(sender As Object, e As EventArgs) Handles txtValor_2.TextChanged
        If txtValor_2.Text <> "" Then
            valor2 = Convert.ToInt16(txtValor_2.Text)
        End If
    End Sub

    Private Sub txtValor_3_TextChanged(sender As Object, e As EventArgs) Handles txtValor_3.TextChanged
        If txtValor_3.Text <> "" Then
            valor3 = Convert.ToInt16(txtValor_3.Text)
        End If
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Me.Hide()
        obj.recuperarInfo(valor1, valor2, valor3)
        obj.Show()

    End Sub
End Class
