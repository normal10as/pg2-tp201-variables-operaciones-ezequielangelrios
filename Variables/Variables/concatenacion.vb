Module concatenacion
    Sub Main()
        Dim nombredelaempresa As String
        Dim nombredelacalle As String
        Dim alturadelacalle As Integer
        Dim fechainiciodeactividades As Date

        Console.WriteLine("ingrese el nombre de la empresa")
        nombredelaempresa = Console.ReadLine()
        Console.WriteLine("ingrese nombre de la calle")
        nombredelacalle = Console.ReadLine()
        Console.WriteLine("ingrese altura de la calle")
        alturadelacalle = Console.ReadLine()
        Console.WriteLine("ingrese la fecha de inicio de actividades")
        fechainiciodeactividades = Console.ReadLine()

        Console.WriteLine("El nombre de la empresa es {0}, se ubica en {1}, altura {2}
        y inicio sus actividades el dia {3}", nombredelaempresa, nombredelacalle,
        alturadelacalle, fechainiciodeactividades.Date)
        Console.ReadLine()
    End Sub


End Module
