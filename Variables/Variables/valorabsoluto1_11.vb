Module valorabsoluto1_11
    Sub Main()
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Console.WriteLine("ingrese un numero: ")
        a = Console.ReadLine()
        Console.WriteLine("su valor absoluto es: " & Math.Abs(a))
        b = a ^ 10
        c = Math.Sqrt(a)
        Console.WriteLine("numero eleveado a la decima potencia: " & b)
        Console.WriteLine("raiz cuadrada: " & c)


        Console.ReadLine()
    End Sub


End Module
