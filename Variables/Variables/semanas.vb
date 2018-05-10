Module semanas
    Sub Main()
        'VARIABLES
        Dim diasdelasemana As Integer
        Dim diaslaborables As Integer
        Dim diasdelanio As Integer
        Dim semanaslaborables As Integer
        Dim semanasdelanio As Integer
        semanaslaborables = 0
        semanasdelanio = 0
        diasdelasemana = 7
        diasdelanio = 365
        diaslaborables = 5
        'PROCESO
        semanasdelanio = 365 / 7
        semanaslaborables = (semanasdelanio * diaslaborables) / diasdelasemana
        Console.WriteLine("semanas del año: " & semanasdelanio)
        Console.WriteLine("semanas laborables: " & semanaslaborables)


        Console.ReadLine()




    End Sub


End Module
