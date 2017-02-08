Public Class Form1
    Dim dado As Integer = 0
    Dim acumGlobal As Integer = 0
    Dim acum1 As Integer = 0
    Dim acum2 As Integer = 0
    Dim jugador As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnTirar.Click

        If jugador = 0 Then
            Ganador()
            dado = random()
            TxtDado.Text = dado
            If dado = 1 Then
                acumGlobal = 0
                jugador = 1
                MessageBox.Show("Obtuviste un 1! 
Turno de la Maquina", "My application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Computador()
            End If
            acumGlobal = acumGlobal + dado
            TxtAcumula.Text = acumGlobal
        End If


    End Sub


    Function random()
        Randomize()
        Dim Num As Integer = CInt(Int((6 * Rnd()) + 1))
        Return Num

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If jugador = 0 Then
            acum1 = acumGlobal + acum1
            acumGlobal = 0
            TxtJugador.Text = acum1
            jugador = 1
            MessageBox.Show("Paraste!
Turno de la Maquina", "My application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End If
        Computador()


    End Sub

    Sub Computador()
        Dim contador As Integer = 0
        dado = 0
        Dim cuenta As Integer = random()
        While contador < cuenta
            Ganador()
            contador = contador + 1
            If jugador = 1 Then
                dado = random()
                TxtDado.Text = dado
                If dado = 1 Then
                    acumGlobal = 0
                    contador = cuenta
                End If
                If dado <> 1 Then
                    acumGlobal = acumGlobal + dado
                    acum2 = acum2 + acumGlobal
                    TxtAcumula.Text = acumGlobal
                    TxtMaquina.Text = acum2
                End If

            End If
        End While
        jugador = 0
        acumGlobal = 0
        MessageBox.Show("Tú turno", "My application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Sub Ganador()
        If acum1 >= 100 Then

            acumGlobal = 0
            acum1 = 0
            acum2 = 0
            jugador = 2
            MessageBox.Show("Ha Ganado!!", "My application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        If acum2 >= 100 Then
            acumGlobal = 0
            acum1 = 0
            acum2 = 0
            jugador = 2

            MessageBox.Show("Has Perdido!!", "My application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End If
        If jugador = 2 Then
            Close()
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub


End Class
