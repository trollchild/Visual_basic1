Module Module1

    Sub Main()

        Dim name As String
        Dim answer As String

        Console.WriteLine("Hello what is your name?")
        name = Console.ReadLine()

        Console.WriteLine("Hello " & name)

        Console.WriteLine("How was your day?")
        answer = Console.ReadLine()

        Console.WriteLine("So you say your day was " & answer)
        Console.Wait(Now + TimeValue("0:00:10"))
        Console.WriteLine("So if I understood correctly...")

        Console.ReadKey(True)

    End Sub

End Module
