Public Class Menu
    'Opcion del menu
    Dim opcion As Int16

    'Recuperar los valores
    Dim val1 As Int16
    Dim val2 As Int16
    Dim val3 As Int16

    Dim sum As Int16 = 0
    Dim rest As Int16 = 0
    Dim mult As Int16 = 0

    Dim ban1 As Boolean = False
    Dim ban2 As Boolean = False
    Dim ban3 As Boolean = False

    Private Sub txtOption_TextChanged(sender As Object, e As EventArgs) Handles txtOption.TextChanged
        If txtOption.Text <> "" Then
            opcion = Convert.ToInt16(txtOption.Text)

        End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim objeto As Captura.Captura = New Captura.Captura()
        Dim objeto2 As Resultados.Form1 = New Resultados.Form1

        Select Case opcion
            Case 1
                Me.Hide()
                objeto.Show()
            Case 2
                MessageBox.Show("Suma realizada")
                ban1 = True
            Case 3
                MessageBox.Show("resta realizada")
                ban2 = True
            Case 4
                MessageBox.Show("multiplicacion realizada")
                ban3 = True
            Case 5
                MessageBox.Show("division realizada")
            Case 6
                Me.Hide()
                objeto2.Show()

            Case Else
                MessageBox.Show("Solo estan disponibles las opciones 1-6")


        End Select
    End Sub

    'Metodos para los calculos
    Public Sub recuperarInfo(ByVal a As Int16, ByVal b As Int16, ByVal c As Int16)
        val1 = a
        val2 = b
        val3 = c
    End Sub

    Public Function suma(ByVal a As Int16, ByVal b As Int16, ByVal c As Int16) As Int16
        sum = a + b + c

        Return sum
    End Function

    Public Function resta(ByVal a As Int16, ByVal b As Int16, ByVal c As Int16) As Int16
        rest = a + b + c

        Return rest
    End Function

    Public Function multi(ByVal a As Int16, ByVal b As Int16, ByVal c As Int16) As Int16
        mult = a * b * c
        Return mult
    End Function
End Class
