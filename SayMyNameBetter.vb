Imports System.Timers

Module SayMyNameBetter

    Sub Main()

        Dim userInput As String
        Dim leave As Boolean = False

        Console.WriteLine("What is your name?")
        userInput = Console.ReadLine()

        Do
            If userInput = "Emily" Then
                Console.WriteLine("Hello, Emily! Good to see you.")
                leave = True
            ElseIf userInput = "Joe" Then
                Console.WriteLine("Hello, Joe! Good to see you.")
                leave = True
            ElseIf userInput = "Rahiel" Then
                Console.WriteLine("Hello, Rahiel. I'm glad to see you again" & vbNewLine _
                                  & "Hola, Rahiel. Encantado de verte de nuevo")
                leave = True
            Else
                Console.WriteLine("Welcome to this program.")
                leave = True
            End If
        Loop Until leave

        Console.Read()
    End Sub

End Module
