Module ejercicio15
    Sub Main()
        'VARIABLES
        Dim b As Integer
        Dim a, c, resta, multiplicacionnumerador As Integer
        Dim multiplicaciondenominador As Integer
        Dim div As Double
        a = 1
        b = 5 ^ 2
        c = 2
        resta = 0
        multiplicacionnumerador = 0
        multiplicaciondenominador = 0
        div = 0
        'PROCESO
        multiplicacionnumerador = 4 * a * c
        resta = b - multiplicacionnumerador
        multiplicaciondenominador = 2 * a
        div = resta / multiplicaciondenominador

        Console.WriteLine("Resultado es: " & div)

        Console.ReadLine()


    End Sub

End Module
