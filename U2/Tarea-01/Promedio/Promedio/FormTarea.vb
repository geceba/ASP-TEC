Public Class FormTarea
    'Variables  -> para los campos de calif
    Dim a, b, c As Int16
    'Repeticiones
    Dim cuanto As Int16
    'Contador
    Dim contador As Int16 = 0

    'variables para prom y promG, prom hace la operacion y promG guardar el resultado de los prom prom
    Dim prom, promG As Decimal

    'Creamos el arreglo para guardar calificaciones

    Dim promProm As Decimal() = New Decimal(9) {}   ' asi se declara un arreglo

    Private Sub txtRepeticiones_TextChanged(sender As Object, e As EventArgs) Handles txtRepeticiones.TextChanged
        'comprobar de guardar vacio
        If txtRepeticiones.Text <> "" Then
            cuanto = Convert.ToInt16(txtRepeticiones.Text)
        End If
    End Sub

    Private Sub txtValor1_TextChanged(sender As Object, e As EventArgs) Handles txtValor1.TextChanged
        If txtValor1.Text <> "" Then
            a = Convert.ToInt16(txtValor1.Text)
        End If
    End Sub

    Private Sub txtValor2_TextChanged(sender As Object, e As EventArgs) Handles txtValor2.TextChanged
        If txtValor2.Text <> "" Then
            b = Convert.ToInt16(txtValor2.Text)
        End If
    End Sub

    Private Sub txtValor3_TextChanged(sender As Object, e As EventArgs) Handles txtValor3.TextChanged
        If txtValor3.Text <> "" Then
            c = Convert.ToInt16(txtValor3.Text)
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim obj As Libreria.Libreria = New Libreria.Libreria() 'Creaar el objeto

        prom = obj.calProm(a, b, c) ' guardar el resultado de promedio
        promProm(contador) = prom

        'Mandar al lbl el promedio normal
        lblProm.Text = "" & prom ' asi se manda a un lbl
        contador += 1

        'Comprobar si ya cumplio el numero de repeticiones
        If contador = cuanto Then
            promG = obj.calPromProm(promProm, cuanto)
            lblPromProm.Text = "El promedio de promedio es: " & promG
            lblAlert.Text = "Ya se cumplieron las repeticiones"

        Else
            'Limpiar los campos si no se ha cumplido el numero de repeticiones
            txtValor1.Text = ""
            txtValor2.Text = ""
            txtValor3.Text = ""

        End If


    End Sub
End Class
