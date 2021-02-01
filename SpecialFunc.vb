Option Explicit On
Option Strict On

Module SpecialFunc
    Sub Main()

        PromptUser("hello user")

        For i = 0 To 5
            StoreMessages("hello")
        Next

        PromptUser(StoreMessages(""))

        Console.Read()
    End Sub

    Sub PromptUser(message As String)
        Console.WriteLine(message)
    End Sub

    Function StoreMessages(message As String) As String
        Static storedMessages As String 'Static extrends the lifetime of the variable

        storedMessages &= message & vbCrLf

        Return storedMessages
    End Function

    Function RandomNumberInRange(maxNumber As Integer) As Single
        Dim value As Integer
        Dim temp As Single
        ' Initialize the random-number generator.
        Randomize(DateTime.Now.Millisecond)

        'value = CInt(Int((6 * Rnd()) + 1))
        temp = Rnd()
        Console.WriteLine($"Rnd:{temp} Cint:{CInt(temp)} Int:{Int(temp)}")
        Return temp

    End Function

End Module
