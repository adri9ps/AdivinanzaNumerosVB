Public Class Form1

    Public numeroGeneradoAleatoriamente As Integer

    'Botón generar numero'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'generar numero aleatorio del 1 al 100' 
        numeroGeneradoAleatoriamente = CInt(Math.Ceiling(Rnd() * 100)) + 1

        'una vez generado, hay que deshabilitar el boton'
        Button1.Enabled = False

        'ListView1.Items.Add(numeroGeneradoAleatoriamente.ToString)'

    End Sub
    'Botón salir'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'salida'
        Application.Exit()


    End Sub
    'Botón limpiar'
    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        'primero, eliminar numero generado'
        numeroGeneradoAleatoriamente = 0
        Button1.Enabled = True
        ListView1.Clear()

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            'comprueba que es numerico lo que introducimos'
            If IsNumeric(TextBox1.Text) Then
                Dim numeroIntroducido As Integer = CInt(TextBox1.Text)
                ListView1.Items.Add(numeroIntroducido)
                If numeroIntroducido > numeroGeneradoAleatoriamente Then
                    ListView1.Items.Add("El numero que se ha generado es menor que el que has intoducido tú")
                ElseIf numeroIntroducido < numeroGeneradoAleatoriamente Then
                    ListView1.Items.Add("El numero que se ha generado es mayor que el que has intoducido tú")
                Else
                    ListView1.Items.Add("Correcto! El numero era: " + numeroGeneradoAleatoriamente.ToString)
                    'una vez acertado, borrar variable y habilitar boton de generado'
                    numeroGeneradoAleatoriamente = 0
                    Button1.Enabled = True

                End If
            Else
                ListView1.Items.Add("Introduce un numero")

            End If
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class
