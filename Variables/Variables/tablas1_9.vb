Module tablas1_9
    Sub Main()
        Dim tablaand As Integer
        Dim tablanot As Integer
        Dim tablaor As Integer
        Dim tablaxor As Integer
        tablaand = 1
        tablanot = 2
        tablaor = 3
        tablaxor = 4
        '-------------------------------------
        Console.WriteLine("Ingrese la tabla que desea ver:1=AND,2=NOT,3=OR,4=XOR ")
        tablaand = Console.ReadLine()
        Console.WriteLine("tabla AND: Exp1  Exp2    Exp1 y Exp2")
        Console.WriteLine("             V   V       V")
        Console.WriteLine("             V   F       F")
        Console.WriteLine("             F   V       F")
        Console.WriteLine("             F   F       F")
        tablanot = Console.ReadLine()
        Console.WriteLine("tabla NOT:   Exp1 NO Exp1")
        Console.WriteLine("               V       F")
        Console.WriteLine("               F       V")
        tablaor = Console.ReadLine()
        Console.WriteLine("tabla OR:    Exp1  Exp2    Exp1 o Exp2")
        Console.WriteLine("             V       V       V")
        Console.WriteLine("             V       F       V")
        Console.WriteLine("             F       V       V")
        Console.WriteLine("             F       F       F")
        tablaxor = Console.ReadLine()
        Console.WriteLine("tabla XOR:    Exp1  Exp2    Exp1 Y Exp2")
        Console.WriteLine("                V       V       F")
        Console.WriteLine("                V       F       T")
        Console.WriteLine("                F       V       T")
        Console.WriteLine("                F       F       F")
        Console.ReadLine()

    End Sub


End Module
