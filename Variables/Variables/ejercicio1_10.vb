Module ejercicio1_10
    Sub Main()
        Dim m As Double
        Dim r As Double
        Dim t As Double
        Dim i As Decimal

        Console.WriteLine("ingrese su monto")
        m = Console.ReadLine
        Console.WriteLine("ingrese su interes %: ")
        r = Console.ReadLine
        Console.WriteLine("ingrese el tiempo en dias: ")
        t = Console.ReadLine
        i = (m * r * t) / (360 * 10)
        Console.WriteLine("su interes es: " & i)
        Console.ReadLine()

    End Sub

End Module
