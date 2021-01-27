Option Explicit On
Option Strict On

Module SubFunctionsExamples

    Sub Main()

        Console.WriteLine("I'm in the sub main!")
        MyOtherSub() 'call other sub
        Console.WriteLine("I'm in the sub main!")
        MyOtherSub() 'call other sub

        Dim firstNumber As Integer
        Dim secondNumber As Integer

        firstNumber = 5
        secondNumber = 6

        For i = 0 To 5
            DoMath(firstNumber, secondNumber * i)
        Next

        Console.WriteLine(MyCoolFunc("Laura"))

        Console.Read()
    End Sub

    Sub MyOtherSub()
        Console.WriteLine("I'm in my other sub")
    End Sub

    Sub DoMath(someNumber As Integer, someOtherNumber As Integer)
        someNumber *= 2
        Console.WriteLine(someNumber + someOtherNumber)
    End Sub

    Function MyCoolFunc(noteToSelf As String) As String
        Dim temp As String
        temp = $"Hello {noteToSelf}"
        Return temp
    End Function

End Module
