Module Module1

    Sub Main()

        Dim name As String
        Dim answer As String
        Dim answer_corona As String

        Console.WriteLine("Hello what is your name?")
        name = Console.ReadLine()

        Console.WriteLine("Hello " & name)
        Console.WriteLine("How was your day?")

        answer = Console.ReadLine()

        Console.WriteLine("So you say your day was " & answer)
        Threading.Thread.Sleep(2000)
        Console.WriteLine("Well how I see it..")
        Threading.Thread.Sleep(2000)
        Console.WriteLine(name)
        Threading.Thread.Sleep(1000)
        If answer = ("good") Then
            Console.WriteLine("I think you had a nice day as you answered good")
        Else
            Console.WriteLine("You did not answer that your day was good so I think you had a bad day")
        End If
        If answer = ("bad") Then
            Console.WriteLine("I hope tomorrow will be better..")
        End If
        Threading.Thread.Sleep(1000)
        Console.WriteLine("Do you think the corona virus will stop before 2021?")

        answer_corona = Console.ReadLine()
        If (answer_corona = "yes") Then
            Console.WriteLine("I really do hope that you are right")
            Threading.Thread.Sleep(1000)
            Console.WriteLine("I think here was enough questions for today. Stay safe!")

            Threading.Thread.Sleep(4000)
            End
        End If

        If (answer_corona = "no") Then
            Console.WriteLine("Hopefully you are wrong")
            Threading.Thread.Sleep(1000)
            Console.WriteLine("I think here was enough questions for today. Stay safe!")

            Threading.Thread.Sleep(4000)
            End
        End If

        If (answer_corona IsNot "yes") Then
            Console.WriteLine("It was a simple question. Answer yes or no")
        ElseIf (answer_corona IsNot "no") Then
            Console.WriteLine("It was a simple question. Answer yes or no")
        End If
        Threading.Thread.Sleep(1000)
        Console.WriteLine("Do you think the corona virus will stop before 2021?")
        Threading.Thread.Sleep(1000)
        Console.WriteLine("Or actually. I think here was enough questions for today. Stay safe!")

        Console.ReadKey(True)
    End Sub

End Module
