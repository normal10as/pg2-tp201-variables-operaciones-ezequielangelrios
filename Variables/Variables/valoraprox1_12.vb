Module valoraprox1_12
    Sub Main()
        Dim num As Decimal
        Dim a As Decimal
        Dim b As Double
        Dim c As Decimal
        Console.WriteLine("ingrese un numero: ")
        num = Console.ReadLine()
        a = Math.Ceiling(num)
        b = Math.Floor(num)
        c = Math.Round(num)
        Console.WriteLine("el valor aproximado por exceso {0}, valor aproximado por defecto {1},
                           y su valor redondeado {2} ", a, b, c)
        Console.ReadLine()

    End Sub


End Module
