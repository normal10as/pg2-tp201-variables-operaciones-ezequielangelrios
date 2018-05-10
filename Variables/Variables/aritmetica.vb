Module aritmetica

    Sub Main()
        'VARIABLES 
        Dim sumaenteros, sumapuntoflotante, sumaenteropuntoflotante As Double
        Dim puntoflotante1 As Double
        Dim puntoflotante2 As Double
        Dim entero1 As Integer
        Dim entero2 As Integer

        puntoflotante1 = 1.5E-18
        puntoflotante2 = 1.23 * 1000.0
        entero1 = 5
        entero2 = 10
        'PROCESO
        sumaenteros = entero1 + entero2
        sumapuntoflotante = puntoflotante1 + puntoflotante2
        sumaenteropuntoflotante = entero1 + puntoflotante1
        'SALIDA
        Console.WriteLine("Suma de enteros: " & sumaenteros)
        Console.WriteLine("Suma de valores con punto flotante: " & sumapuntoflotante)

        Console.WriteLine("Suma de enteros con punto flotante: " & sumaenteropuntoflotante)

        Console.ReadLine()




    End Sub

End Module
