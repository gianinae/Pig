Public Class Form1
    Dim dado As Integer = 0
    Dim acumGlobal As Integer = 0
    Dim acum1 As Integer = 0
    Dim acum2 As Integer = 0
    Dim jugador As Integer = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnTirar.Click
        If jugador = 0 Then
            dado = random()
            TxtDado.Text = dado
            If dado = 1 Then
                acumGlobal = 0
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
        End If
        Computador()


    End Sub

    Sub Computador()
        dado = 0
        While dado <> 1
            If jugador = 1 Then
                dado = random()
                TxtDado.Text = dado
                acumGlobal = acumGlobal + dado
                acum2 = acum2 + acumGlobal
                TxtAcumula.Text = acumGlobal
                TxtMaquina.Text = acum2
            End If
            jugador = 0
        End While
    End Sub


End Class
