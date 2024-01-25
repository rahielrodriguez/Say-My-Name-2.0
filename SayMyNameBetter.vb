'Rahiel Rodriguez
'RCET 2265
'Say My Name Better
'Spring 2024
'https://github.com/rahielrodriguez/SayMyName2.0.git

Option Explicit On
Option Strict On

Module SayMyNameBetter

    Sub Main()

        Dim userInput As String

        Console.WriteLine("What is your name?")
        userInput = Console.ReadLine()

        If userInput = "Emily" Then
            Console.WriteLine("Hello, Emily! Good to see you.")
        ElseIf userInput = "Joe" Then
            Console.WriteLine("Hello, Joe! Good to see you.")
        ElseIf userInput = "Rahiel" Then
            Console.WriteLine("Hello, Rahiel. I'm glad to see you again" & vbNewLine _
                                  & "Hola, Rahiel. Encantado de verte de nuevo")
        Else
            Console.WriteLine("Welcome to this program.")
        End If

            Console.Read()
    End Sub

End Module
