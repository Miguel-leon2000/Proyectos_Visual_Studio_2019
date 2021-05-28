Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine("Introduzca el valor del radio")
        Dim radio As Integer = Console.ReadLine()

        Dim area As Double = Math.PI * radio ^ 2

        Console.WriteLine("El area es: " & area)

        Console.ReadLine()

    End Sub
End Module
