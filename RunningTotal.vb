Option Strict On
Option Explicit On

Module RunningTotal
    Sub main()
        For i = 0 To 2
            Console.WriteLine(RunningTotal(5, False))
        Next
        Console.WriteLine(RunningTotal(17, True))
        Console.WriteLine(RunningTotal(82, False))
        Console.Read()
    End Sub

    Function RunningTotal(newAmount As Integer, clear As Boolean) As Integer
        Static _runningTotal As Integer
        _runningTotal += newAmount
        If clear = True Then
            _runningTotal = 0
        End If

        Return _runningTotal
    End Function

End Module
