Option Explicit On
Option Strict On
Module Calculator

    Sub Main()
        'Dim userResponse As String
        'Console.WriteLine("Type anything and press enter...")
        'userResponse = Console.ReadLine()
        'Console.WriteLine("You entered, '" + userResponse + "'")

        Dim numberA As Integer
        Dim numberB As Integer
        Dim UA As String
        Dim UB As String

        Dim result As Integer
        Console.WriteLine("Please enter a number...")
        UA = Console.ReadLine()
        Console.WriteLine("Please enter another number...")
        UB = Console.ReadLine()
        numberA = CInt(UA)
        numberB = CInt(UB)
        result = numberA + numberB

        Console.WriteLine($"{UA} + {UB} = {result}")

        'introducing if statements
        If result > 5 Then
            Console.WriteLine("Your chosen numbers which add to greater than 5, Congrats!")
        End If
        Console.ReadLine()
    End Sub

End Module

