Module ejercicio1_14
    Sub Main()
        Dim hoy As Date
        hoy = Now
        Dim findeanio As New DateTime(Year(Now()), 12, 31)
        Console.WriteLine("hoy es {0} y Faltan {1} dias para fin de año ", hoy.Date,
                          findeanio.DayOfYear - hoy.DayOfYear)
        Console.ReadLine()
    End Sub

End Module
