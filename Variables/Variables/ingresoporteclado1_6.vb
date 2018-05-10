Module ingresoporteclado1_6
    Sub Main()
        Dim a, b, c, d As Integer
        Console.WriteLine("ingrese cuatro números: ")
        a = Console.ReadLine()
        Console.WriteLine("ingrese cuatro números: ")
        b = Console.ReadLine()
        Console.WriteLine("ingrese cuatro números: ")
        c = Console.ReadLine()
        Console.WriteLine("ingrese cuatro números: ")
        d = Console.ReadLine()
        Dim r As Integer = a + b + c + d
        Console.WriteLine("sumatoria " & r)
        Console.WriteLine("media " & r / 4)
        Console.ReadLine()
    End Sub

End Module
