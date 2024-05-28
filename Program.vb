Imports System


Module Factorial
    Sub Main()
        ' Prompt user
        Console.Write("Enter number: ")
        Dim number As Integer = CInt(Console.ReadLine())

        ' Calculate
        Dim factorial As Long = 1
        For i As Integer = 1 To number
            factorial *= i
        Next
        'Display result
        Console.WriteLine("Factorial of " & number & " = " & factorial)
    End Sub
End Module
